// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Transactions;

namespace Microsoft.EntityFrameworkCore.Migrations.Internal;

/// <summary>
///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
///     the same compatibility standards as public APIs. It may be changed or removed without notice in
///     any release. You should only use it directly in your code with extreme caution and knowing that
///     doing so can result in application failures when updating to a new Entity Framework Core release.
/// </summary>
/// <remarks>
///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
///     the same compatibility standards as public APIs. It may be changed or removed without notice in
///     any release. You should only use it directly in your code with extreme caution and knowing that
///     doing so can result in application failures when updating to a new Entity Framework Core release.
/// </remarks>
public class MigrationCommandExecutor(IExecutionStrategy executionStrategy) : IMigrationCommandExecutor
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public virtual void ExecuteNonQuery(
        IEnumerable<MigrationCommand> migrationCommands,
        IRelationalConnection connection)
        => ExecuteNonQuery(
            migrationCommands.ToList(), connection, new MigrationExecutionState(), useExecutionStrategy: true);

    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public virtual void ExecuteNonQuery(
        IReadOnlyList<MigrationCommand> migrationCommands,
        IRelationalConnection connection,
        MigrationExecutionState executionState,
        bool useExecutionStrategy)
    {
        var inUserTransaction = connection.CurrentTransaction is not null && executionState.Transaction == null;
        if (inUserTransaction
            && (migrationCommands.Any(x => x.TransactionSuppressed)
                || (useExecutionStrategy && executionStrategy.RetriesOnFailure)))
        {
            throw new NotSupportedException(RelationalStrings.TransactionSuppressedMigrationInUserTransaction);
        }

        using (new TransactionScope(TransactionScopeOption.Suppress, TransactionScopeAsyncFlowOption.Enabled))
        {
            if (useExecutionStrategy)
            {
                executionStrategy.Execute(
                    (migrationCommands, connection, inUserTransaction, executionState),
                    static (_, s) => Execute(
                        s.migrationCommands,
                        s.connection,
                        s.executionState,
                        beginTransaction: !s.inUserTransaction,
                        commitTransaction: !s.inUserTransaction),
                    verifySucceeded: null);
            }
            else
            {
                Execute(migrationCommands, connection, executionState, beginTransaction: !inUserTransaction, commitTransaction: false);
            }
        }
    }

    private static IDbContextTransaction? Execute(
        IReadOnlyList<MigrationCommand> migrationCommands,
        IRelationalConnection connection,
        MigrationExecutionState executionState,
        bool beginTransaction,
        bool commitTransaction)
    {
        var connectionOpened = connection.Open();
        Check.DebugAssert(!connectionOpened || executionState.Transaction == null,
            "executionState.Transaction should be null");

        try
        {
            for (var i = executionState.LastCommittedCommandIndex; i < migrationCommands.Count; i++)
            {
                var command = migrationCommands[i];
                if (executionState.Transaction == null
                    && !command.TransactionSuppressed
                    && beginTransaction)
                {
                    executionState.Transaction = connection.BeginTransaction();
                    if (executionState.DatabaseLock != null)
                    {
                        executionState.DatabaseLock = executionState.DatabaseLock.Refresh(
                            connectionOpened, transactionRestarted: true);
                        connectionOpened = false;
                    }
                }

                if (executionState.Transaction != null
                    && command.TransactionSuppressed)
                {
                    executionState.Transaction.Commit();
                    executionState.Transaction.Dispose();
                    executionState.Transaction = null;
                    executionState.LastCommittedCommandIndex = i;
                    executionState.AnyOperationPerformed = true;

                    if (executionState.DatabaseLock != null)
                    {
                        executionState.DatabaseLock = executionState.DatabaseLock.Refresh(
                            connectionOpened, transactionRestarted: null);
                        connectionOpened = false;
                    }
                }

                command.ExecuteNonQuery(connection);

                if (executionState.Transaction == null)
                {
                    executionState.LastCommittedCommandIndex = i + 1;
                    executionState.AnyOperationPerformed = true;
                }
            }

            if (commitTransaction
                && executionState.Transaction != null)
            {
                executionState.Transaction.Commit();
                executionState.Transaction.Dispose();
                executionState.Transaction = null;
            }
        }
        catch
        {
            executionState.Transaction?.Dispose();
            executionState.Transaction = null;
            connection.Close();
            throw;
        }

        connection.Close();
        return executionState.Transaction;
    }

    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public virtual Task ExecuteNonQueryAsync(
        IEnumerable<MigrationCommand> migrationCommands,
        IRelationalConnection connection,
        CancellationToken cancellationToken = default)
        => ExecuteNonQueryAsync(
            migrationCommands.ToList(), connection, new MigrationExecutionState(), useExecutionStrategy: true, cancellationToken);
    
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    public virtual async Task ExecuteNonQueryAsync(
        IReadOnlyList<MigrationCommand> migrationCommands,
        IRelationalConnection connection,
        MigrationExecutionState executionState,
        bool useExecutionStrategy,
        CancellationToken cancellationToken = default)
    {
        var inUserTransaction = connection.CurrentTransaction is not null && executionState.Transaction == null;
        if (inUserTransaction
            && (migrationCommands.Any(x => x.TransactionSuppressed)
                || (useExecutionStrategy && executionStrategy.RetriesOnFailure)))
        {
            throw new NotSupportedException(RelationalStrings.TransactionSuppressedMigrationInUserTransaction);
        }

        using var transactionScope = new TransactionScope(TransactionScopeOption.Suppress, TransactionScopeAsyncFlowOption.Enabled);

        if (useExecutionStrategy)
        {
            await executionStrategy.ExecuteAsync(
                (migrationCommands, connection, inUserTransaction, executionState),
                static (_, s, ct) => ExecuteAsync(
                    s.migrationCommands,
                    s.connection,
                    s.executionState,
                    beginTransaction: !s.inUserTransaction,
                    commitTransaction: !s.inUserTransaction, ct),
                verifySucceeded: null,
                cancellationToken).ConfigureAwait(false);
        }
        else
        {
            await ExecuteAsync(migrationCommands, connection, executionState, beginTransaction: !inUserTransaction, commitTransaction: false, cancellationToken).ConfigureAwait(false);
        }
    }

    private static async Task<IDbContextTransaction?> ExecuteAsync(
        IReadOnlyList<MigrationCommand> migrationCommands,
        IRelationalConnection connection,
        MigrationExecutionState executionState,
        bool beginTransaction,
        bool commitTransaction,
        CancellationToken cancellationToken)
    {
        var connectionOpened = await connection.OpenAsync(cancellationToken).ConfigureAwait(false);
        Check.DebugAssert(!connectionOpened || executionState.Transaction == null,
            "executionState.Transaction should be null");

        try
        {
            for (var i = executionState.LastCommittedCommandIndex; i < migrationCommands.Count; i++)
            {
                var command = migrationCommands[i];
                if (executionState.Transaction == null
                    && !command.TransactionSuppressed
                    && beginTransaction)
                {
                    executionState.Transaction = await connection.BeginTransactionAsync(cancellationToken)
                        .ConfigureAwait(false);

                    if (executionState.DatabaseLock != null)
                    {
                        executionState.DatabaseLock = await executionState.DatabaseLock.RefreshAsync(
                            connectionOpened, transactionRestarted: true, cancellationToken)
                            .ConfigureAwait(false);
                        connectionOpened = false;
                    }
                }

                if (executionState.Transaction != null
                    && command.TransactionSuppressed)
                {
                    await executionState.Transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
                    await executionState.Transaction.DisposeAsync().ConfigureAwait(false);
                    executionState.Transaction = null;
                    executionState.LastCommittedCommandIndex = i;
                    executionState.AnyOperationPerformed = true;

                    if (executionState.DatabaseLock != null)
                    {
                        executionState.DatabaseLock = await executionState.DatabaseLock.RefreshAsync(
                            connectionOpened, transactionRestarted: null, cancellationToken)
                            .ConfigureAwait(false);
                        connectionOpened = false;
                    }
                }

                await command.ExecuteNonQueryAsync(connection, cancellationToken: cancellationToken)
                    .ConfigureAwait(false);

                if (executionState.Transaction == null)
                {
                    executionState.LastCommittedCommandIndex = i + 1;
                    executionState.AnyOperationPerformed = true;
                }
            }

            if (commitTransaction
                && executionState.Transaction != null)
            {
                await executionState.Transaction.CommitAsync(cancellationToken).ConfigureAwait(false);
                await executionState.Transaction.DisposeAsync().ConfigureAwait(false);
                executionState.Transaction = null;
            }
        }
        catch
        {
            if (executionState.Transaction != null)
            {
                await executionState.Transaction.DisposeAsync().ConfigureAwait(false);
                executionState.Transaction = null;
            }
            await connection.CloseAsync().ConfigureAwait(false);
            throw;
        }

        await connection.CloseAsync().ConfigureAwait(false);
        return executionState.Transaction;
    }
}
