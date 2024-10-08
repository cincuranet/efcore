// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using Microsoft.EntityFrameworkCore.Query.Internal;

namespace Microsoft.EntityFrameworkCore;

public static partial class EF
{
    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, IEnumerable<TResult>> CompileQuery<TContext, TResult>(
        Expression<Func<TContext, DbSet<TResult>>> queryExpression)
        where TContext : DbContext
        where TResult : class
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, IEnumerable<TResult>> CompileQuery<TContext, TResult, TProperty>(
        Expression<Func<TContext, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, IEnumerable<TResult>> CompileQuery<TContext, TResult>(
        Expression<Func<TContext, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TResult> CompileQuery<TContext, TResult>(
        Expression<Func<TContext, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, IEnumerable<TResult>> CompileQuery<TContext, TParam1, TResult, TProperty>(
        Expression<Func<TContext, TParam1, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, IEnumerable<TResult>> CompileQuery<TContext, TParam1, TResult>(
        Expression<Func<TContext, TParam1, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TResult> CompileQuery<TContext, TParam1, TResult>(
        Expression<Func<TContext, TParam1, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, IEnumerable<TResult>> CompileQuery<TContext, TParam1, TParam2, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, IEnumerable<TResult>> CompileQuery<TContext, TParam1, TParam2, TResult>(
        Expression<Func<TContext, TParam1, TParam2, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TResult> CompileQuery<TContext, TParam1, TParam2, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TResult> CompileQuery<TContext, TParam1, TParam2, TParam3, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, IIncludableQueryable<TResult, TProperty>>>
            queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, IIncludableQueryable<TResult, TProperty>>>
            queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8,
            IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, IQueryable<TResult>>>
            queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, IEnumerable<TResult>>
        CompileQuery<
            TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TResult, TProperty>(
            Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9,
                IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, IEnumerable<TResult>>
        CompileQuery<
            TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TResult>(
            Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, IQueryable<TResult>>>
                queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TResult>>
            queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10,
        IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10,
            IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10,
        IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10,
            IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TResult>
        CompileQuery<
            TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TResult>(
            Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TResult>>
                queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TResult,
        TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TParam14">The type of the fourteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TParam14, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TParam14, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TParam14, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TParam14">The type of the fourteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TParam14, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TParam14, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TParam14, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TParam14">The type of the fourteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TParam14, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TParam14, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TParam14, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TParam14">The type of the fourteenth query parameter.</typeparam>
    /// <typeparam name="TParam15">The type of the fifteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <typeparam name="TProperty">The included property type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TParam14, TParam15, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TParam14, TParam15, TResult, TProperty>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TParam14, TParam15, IIncludableQueryable<TResult, TProperty>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TParam14">The type of the fourteenth query parameter.</typeparam>
    /// <typeparam name="TParam15">The type of the fifteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TParam14, TParam15, IEnumerable<TResult>> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TParam14, TParam15, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TParam14, TParam15, IQueryable<TResult>>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, IEnumerable<TResult>>(queryExpression).Execute;

    /// <summary>
    ///     Creates a compiled query delegate that when invoked will execute the specified LINQ query.
    /// </summary>
    /// <typeparam name="TContext">The target DbContext type.</typeparam>
    /// <typeparam name="TParam1">The type of the first query parameter.</typeparam>
    /// <typeparam name="TParam2">The type of the second query parameter.</typeparam>
    /// <typeparam name="TParam3">The type of the third query parameter.</typeparam>
    /// <typeparam name="TParam4">The type of the fourth query parameter.</typeparam>
    /// <typeparam name="TParam5">The type of the fifth query parameter.</typeparam>
    /// <typeparam name="TParam6">The type of the sixth query parameter.</typeparam>
    /// <typeparam name="TParam7">The type of the seventh query parameter.</typeparam>
    /// <typeparam name="TParam8">The type of the eighth query parameter.</typeparam>
    /// <typeparam name="TParam9">The type of the ninth query parameter.</typeparam>
    /// <typeparam name="TParam10">The type of the tenth query parameter.</typeparam>
    /// <typeparam name="TParam11">The type of the eleventh query parameter.</typeparam>
    /// <typeparam name="TParam12">The type of the twelfth query parameter.</typeparam>
    /// <typeparam name="TParam13">The type of the thirteenth query parameter.</typeparam>
    /// <typeparam name="TParam14">The type of the fourteenth query parameter.</typeparam>
    /// <typeparam name="TParam15">The type of the fifteenth query parameter.</typeparam>
    /// <typeparam name="TResult">The query result type.</typeparam>
    /// <param name="queryExpression">The LINQ query expression.</param>
    /// <returns>A delegate that can be invoked to execute the compiled query.</returns>
    public static Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
        TParam12, TParam13, TParam14, TParam15, TResult> CompileQuery<
        TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11, TParam12, TParam13,
        TParam14, TParam15, TResult>(
        Expression<Func<TContext, TParam1, TParam2, TParam3, TParam4, TParam5, TParam6, TParam7, TParam8, TParam9, TParam10, TParam11,
            TParam12, TParam13, TParam14, TParam15, TResult>> queryExpression)
        where TContext : DbContext
        => new CompiledQuery<TContext, TResult>(queryExpression).Execute;
}
