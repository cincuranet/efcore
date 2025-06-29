// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

namespace Microsoft.EntityFrameworkCore.Diagnostics;

/// <summary>
///     <para>
///         Configures the runtime behavior of events generated by Entity Framework.
///         You can set a default behavior and behaviors for each event ID.
///     </para>
///     <para>
///         This class is used within the <see cref="DbContextOptionsBuilder.ConfigureWarnings" />
///         API and it is not designed to be directly constructed in your application code.
///     </para>
/// </summary>
/// <remarks>
///     See <see href="https://aka.ms/efcore-docs-warning-configuration">Configuration for specific messages</see> for more information and
///     examples.
/// </remarks>
public class WarningsConfigurationBuilder
{
    private readonly DbContextOptionsBuilder _optionsBuilder;

    /// <summary>
    ///     Initializes a new instance of the <see cref="WarningsConfigurationBuilder" /> class.
    /// </summary>
    /// <param name="optionsBuilder">The options builder to which the warnings configuration will be applied.</param>
    public WarningsConfigurationBuilder(DbContextOptionsBuilder optionsBuilder)
        => _optionsBuilder = optionsBuilder;

    /// <summary>
    ///     Sets the default behavior when a warning is generated.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Event ID values can be found in <see cref="CoreEventId" /> and
    ///         <see cref="T:Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId" />.
    ///         The database provider being used may also define provider-specific event IDs in a similar class.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-warning-configuration">Configuration for specific messages</see> for more information and
    ///         examples.
    ///     </para>
    /// </remarks>
    /// <param name="warningBehavior">The desired behavior.</param>
    /// <returns>The same builder instance so that multiple calls can be chained.</returns>
    public virtual WarningsConfigurationBuilder Default(WarningBehavior warningBehavior)
        => WithOption(e => e.WithDefaultBehavior(warningBehavior));

    /// <summary>
    ///     Causes an exception to be thrown when the specified event occurs, regardless of default configuration.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Event ID values can be found in <see cref="CoreEventId" /> and
    ///         <see cref="T:Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId" />.
    ///         The database provider being used may also define provider-specific event IDs in a similar class.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-warning-configuration">Configuration for specific messages</see> for more information and
    ///         examples.
    ///     </para>
    /// </remarks>
    /// <param name="eventIds">
    ///     The IDs for events to configure.
    /// </param>
    /// <returns>The same builder instance so that multiple calls can be chained.</returns>
    public virtual WarningsConfigurationBuilder Throw(
        params EventId[] eventIds)
    {
        Check.NotNull(eventIds);

        return WithOption(e => e.WithExplicit(eventIds, WarningBehavior.Throw));
    }

    /// <summary>
    ///     Causes an event to be logged, regardless of default configuration.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Event ID values can be found in <see cref="CoreEventId" /> and
    ///         <see cref="T:Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId" />.
    ///         The database provider being used may also define provider-specific event IDs in a similar class.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-warning-configuration">Configuration for specific messages</see> for more information and
    ///         examples.
    ///     </para>
    /// </remarks>
    /// <param name="eventIds">
    ///     The IDs for events to configure.
    /// </param>
    /// <returns>The same builder instance so that multiple calls can be chained.</returns>
    public virtual WarningsConfigurationBuilder Log(
        params EventId[] eventIds)
    {
        Check.NotNull(eventIds);

        return WithOption(e => e.WithExplicit(eventIds, WarningBehavior.Log));
    }

    /// <summary>
    ///     Causes an event to be logged at the specified level, regardless of default configuration.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Event ID values can be found in <see cref="CoreEventId" /> and
    ///         <see cref="T:Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId" />.
    ///         The database provider being used may also define provider-specific event IDs in a similar class.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-warning-configuration">Configuration for specific messages</see> for more information and
    ///         examples.
    ///     </para>
    /// </remarks>
    /// <param name="eventsAndLevels">
    ///     The event IDs and levels to configure.
    /// </param>
    /// <returns>The same builder instance so that multiple calls can be chained.</returns>
    public virtual WarningsConfigurationBuilder Log(
        params (EventId Id, LogLevel Level)[] eventsAndLevels)
    {
        Check.NotNull(eventsAndLevels);

        return WithOption(e => e.WithExplicit(eventsAndLevels));
    }

    /// <summary>
    ///     Causes nothing to happen when the specified event occurs, regardless of default configuration.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Event ID values can be found in <see cref="CoreEventId" /> and
    ///         <see cref="T:Microsoft.EntityFrameworkCore.Diagnostics.RelationalEventId" />.
    ///         The database provider being used may also define provider-specific event IDs in a similar class.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-warning-configuration">Configuration for specific messages</see> for more information and
    ///         examples.
    ///     </para>
    /// </remarks>
    /// <param name="eventIds">
    ///     The IDs for events to configure.
    /// </param>
    /// <returns>The same builder instance so that multiple calls can be chained.</returns>
    public virtual WarningsConfigurationBuilder Ignore(
        params EventId[] eventIds)
    {
        Check.NotNull(eventIds);

        return WithOption(e => e.WithExplicit(eventIds, WarningBehavior.Ignore));
    }

    private WarningsConfigurationBuilder WithOption(Func<WarningsConfiguration, WarningsConfiguration> withFunc)
    {
        var coreOptionsExtension = _optionsBuilder.Options.FindExtension<CoreOptionsExtension>() ?? new CoreOptionsExtension();

        ((IDbContextOptionsBuilderInfrastructure)_optionsBuilder).AddOrUpdateExtension(
            coreOptionsExtension.WithWarningsConfiguration(withFunc(coreOptionsExtension.WarningsConfiguration)));

        return this;
    }
}
