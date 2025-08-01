// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace Microsoft.EntityFrameworkCore.Metadata.Builders;

/// <summary>
///     Provides a simple API for configuring a <see cref="IMutableProperty" /> on a complex collection type.
/// </summary>
/// <remarks>
///     <para>
///         Instances of this class are returned from methods when using the <see cref="ModelBuilder" /> API
///         and it is not designed to be directly constructed in your application code.
///     </para>
///     <para>
///         See <see href="https://aka.ms/efcore-docs-modeling">Modeling complex types and relationships</see> for more information and
///         examples.
///     </para>
/// </remarks>
public class ComplexCollectionTypePropertyBuilder : IInfrastructure<IConventionPropertyBuilder>
{
    /// <summary>
    ///     This is an internal API that supports the Entity Framework Core infrastructure and not subject to
    ///     the same compatibility standards as public APIs. It may be changed or removed without notice in
    ///     any release. You should only use it directly in your code with extreme caution and knowing that
    ///     doing so can result in application failures when updating to a new Entity Framework Core release.
    /// </summary>
    [EntityFrameworkInternal]
    public ComplexCollectionTypePropertyBuilder(IMutableProperty property)
    {
        Check.NotNull(property);

        Builder = ((Property)property).Builder;
    }

    /// <summary>
    ///     The internal builder being used to configure the property.
    /// </summary>
    IConventionPropertyBuilder IInfrastructure<IConventionPropertyBuilder>.Instance
        => Builder;

    private InternalPropertyBuilder Builder { get; }

    /// <summary>
    ///     The property being configured.
    /// </summary>
    public virtual IMutableProperty Metadata
        => Builder.Metadata;

    /// <summary>
    ///     Adds or updates an annotation on the property. If an annotation with the key specified in
    ///     <paramref name="annotation" /> already exists its value will be updated.
    /// </summary>
    /// <param name="annotation">The key of the annotation to be added or updated.</param>
    /// <param name="value">The value to be stored in the annotation.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasAnnotation(string annotation, object? value)
    {
        Check.NotEmpty(annotation);

        Builder.HasAnnotation(annotation, value, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures whether this property must have a value assigned or <see langword="null" /> is a valid value.
    ///     A property can only be configured as non-required if it is based on a CLR type that can be
    ///     assigned <see langword="null" />.
    /// </summary>
    /// <param name="required">A value indicating whether the property is required.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder IsRequired(bool required = true)
    {
        Builder.IsRequired(required, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the value that will be used to determine if the property has been set or not. If the property is set to the
    ///     sentinel value, then it is considered not set. By default, the sentinel value is the CLR default value for the type of
    ///     the property.
    /// </summary>
    /// <param name="sentinel">The sentinel value.</param>
    /// <returns>The same builder instance if the configuration was applied, <see langword="null" /> otherwise.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasSentinel(object? sentinel)
    {
        Builder.HasSentinel(sentinel, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures whether the property as capable of persisting unicode characters.
    ///     Can only be set on <see cref="string" /> properties.
    /// </summary>
    /// <param name="unicode">A value indicating whether the property can contain unicode characters.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder IsUnicode(bool unicode = true)
    {
        Builder.IsUnicode(unicode, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the <see cref="ValueGenerator" /> that will generate values for this property.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values are generated when the entity is added to the context using, for example,
    ///         <see cref="DbContext.Add{TEntity}" />. Values are generated only when the property is assigned
    ///         the CLR default value (<see langword="null" /> for <c>string</c>, <c>0</c> for <c>int</c>,
    ///         <c>Guid.Empty</c> for <c>Guid</c>, etc.).
    ///     </para>
    ///     <para>
    ///         A single instance of this type will be created and used to generate values for this property in all
    ///         instances of the complex type. The type must be instantiable and have a parameterless constructor.
    ///     </para>
    ///     <para>
    ///         This method is intended for use with custom value generation. Value generation for common cases is
    ///         usually handled automatically by the database provider.
    ///     </para>
    /// </remarks>
    /// <typeparam name="TGenerator">A type that inherits from <see cref="ValueGenerator" />.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasValueGenerator
        <[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] TGenerator>()
        where TGenerator : ValueGenerator
    {
        Builder.HasValueGenerator(typeof(TGenerator), ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the <see cref="ValueGenerator" /> that will generate values for this property.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values are generated when the entity is added to the context using, for example,
    ///         <see cref="DbContext.Add{TEntity}" />. Values are generated only when the property is assigned
    ///         the CLR default value (<see langword="null" /> for <c>string</c>, <c>0</c> for <c>int</c>,
    ///         <c>Guid.Empty</c> for <c>Guid</c>, etc.).
    ///     </para>
    ///     <para>
    ///         A single instance of this type will be created and used to generate values for this property in all
    ///         instances of the complex type. The type must be instantiable and have a parameterless constructor.
    ///     </para>
    ///     <para>
    ///         This method is intended for use with custom value generation. Value generation for common cases is
    ///         usually handled automatically by the database provider.
    ///     </para>
    ///     <para>
    ///         Setting <see langword="null" /> does not disable value generation for this property, it just clears any generator explicitly
    ///         configured for this property. The database provider may still have a value generator for the property type.
    ///     </para>
    /// </remarks>
    /// <param name="valueGeneratorType">A type that inherits from <see cref="ValueGenerator" />.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasValueGenerator(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type? valueGeneratorType)
    {
        Builder.HasValueGenerator(valueGeneratorType, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the <see cref="ValueGeneratorFactory" /> for creating a <see cref="ValueGenerator" />
    ///     to use to generate values for this property.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values are generated when the entity is added to the context using, for example,
    ///         <see cref="DbContext.Add{TEntity}" />. Values are generated only when the property is assigned
    ///         the CLR default value (<see langword="null" /> for <c>string</c>, <c>0</c> for <c>int</c>,
    ///         <c>Guid.Empty</c> for <c>Guid</c>, etc.).
    ///     </para>
    ///     <para>
    ///         A single instance of this type will be created and used to generate values for this property in all
    ///         instances of the complex type. The type must be instantiable and have a parameterless constructor.
    ///     </para>
    ///     <para>
    ///         This method is intended for use with custom value generation. Value generation for common cases is
    ///         usually handled automatically by the database provider.
    ///     </para>
    ///     <para>
    ///         Setting <see langword="null" /> does not disable value generation for this property, it just clears any generator explicitly
    ///         configured for this property. The database provider may still have a value generator for the property type.
    ///     </para>
    /// </remarks>
    /// <typeparam name="TFactory">A type that inherits from <see cref="ValueGeneratorFactory" />.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasValueGeneratorFactory
        <[DynamicallyAccessedMembers(ValueGeneratorFactory.DynamicallyAccessedMemberTypes)] TFactory>()
        where TFactory : ValueGeneratorFactory
        => HasValueGeneratorFactory(typeof(TFactory));

    /// <summary>
    ///     Configures the <see cref="ValueGeneratorFactory" /> for creating a <see cref="ValueGenerator" />
    ///     to use to generate values for this property.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Values are generated when the entity is added to the context using, for example,
    ///         <see cref="DbContext.Add{TEntity}" />. Values are generated only when the property is assigned
    ///         the CLR default value (<see langword="null" /> for <c>string</c>, <c>0</c> for <c>int</c>,
    ///         <c>Guid.Empty</c> for <c>Guid</c>, etc.).
    ///     </para>
    ///     <para>
    ///         A single instance of this type will be created and used to generate values for this property in all
    ///         instances of the complex type. The type must be instantiable and have a parameterless constructor.
    ///     </para>
    ///     <para>
    ///         This method is intended for use with custom value generation. Value generation for common cases is
    ///         usually handled automatically by the database provider.
    ///     </para>
    ///     <para>
    ///         Setting <see langword="null" /> does not disable value generation for this property, it just clears any generator explicitly
    ///         configured for this property. The database provider may still have a value generator for the property type.
    ///     </para>
    /// </remarks>
    /// <param name="valueGeneratorFactoryType">A type that inherits from <see cref="ValueGeneratorFactory" />.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasValueGeneratorFactory(
        [DynamicallyAccessedMembers(ValueGeneratorFactory.DynamicallyAccessedMemberTypes)]
        Type? valueGeneratorFactoryType)
    {
        Builder.HasValueGeneratorFactory(valueGeneratorFactoryType, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Sets the backing field to use for this property.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         Backing fields are normally found by convention.
    ///         This method is useful for setting backing fields explicitly in cases where the
    ///         correct field is not found by convention.
    ///     </para>
    ///     <para>
    ///         By default, the backing field, if one is found or has been specified, is used when
    ///         new objects are constructed, typically when entities are queried from the database.
    ///         Properties are used for all other accesses. This can be changed by calling
    ///         <see cref="UsePropertyAccessMode" />.
    ///     </para>
    ///     <para>
    ///         See <see href="https://aka.ms/efcore-docs-backing-fields">Backing fields</see> for more information and examples.
    ///     </para>
    /// </remarks>
    /// <param name="fieldName">The field name.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasField(string fieldName)
    {
        Check.NotEmpty(fieldName);

        Builder.HasField(fieldName, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Sets the <see cref="PropertyAccessMode" /> to use for this property.
    /// </summary>
    /// <remarks>
    ///     <para>
    ///         By default, the backing field, if one is found by convention or has been specified, is used when
    ///         new objects are constructed, typically when entities are queried from the database.
    ///         Properties are used for all other accesses.  Calling this method will change that behavior
    ///         for this property as described in the <see cref="PropertyAccessMode" /> enum.
    ///     </para>
    ///     <para>
    ///         Calling this method overrides for this property any access mode that was set on the
    ///         complex type or model.
    ///     </para>
    /// </remarks>
    /// <param name="propertyAccessMode">The <see cref="PropertyAccessMode" /> to use for this property.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder UsePropertyAccessMode(PropertyAccessMode propertyAccessMode)
    {
        Builder.UsePropertyAccessMode(propertyAccessMode, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <typeparam name="TConversion">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TConversion>()
        => HasConversion(typeof(TConversion));

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="conversionType">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type? conversionType)
    {
        if (typeof(ValueConverter).IsAssignableFrom(conversionType))
        {
            Builder.HasConverter(conversionType, ConfigurationSource.Explicit);
        }
        else
        {
            Builder.HasConversion(conversionType, ConfigurationSource.Explicit);
        }

        return this;
    }

    /// <summary>
    ///     Configures the property so that the property value is converted to and from the database
    ///     using the given <see cref="ValueConverter" />.
    /// </summary>
    /// <param name="converter">The converter to use.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(ValueConverter? converter)
        => HasConversion(converter, null, null);

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="valueComparer">The comparer to use for values before conversion.</param>
    /// <typeparam name="TConversion">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TConversion>(
        ValueComparer? valueComparer)
        => HasConversion(typeof(TConversion), valueComparer);

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="valueComparer">The comparer to use for values before conversion.</param>
    /// <param name="providerComparer">The comparer to use for the provider values.</param>
    /// <typeparam name="TConversion">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion
        <[DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)] TConversion>(
            ValueComparer? valueComparer,
            ValueComparer? providerComparer)
        => HasConversion(typeof(TConversion), valueComparer, providerComparer);

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="conversionType">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</param>
    /// <param name="valueComparer">The comparer to use for values before conversion.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type conversionType,
        ValueComparer? valueComparer)
        => HasConversion(conversionType, valueComparer, null);

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="conversionType">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</param>
    /// <param name="valueComparer">The comparer to use for values before conversion.</param>
    /// <param name="providerComparer">The comparer to use for the provider values.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type conversionType,
        ValueComparer? valueComparer,
        ValueComparer? providerComparer)
    {
        Check.NotNull(conversionType);

        if (typeof(ValueConverter).IsAssignableFrom(conversionType))
        {
            Builder.HasConverter(conversionType, ConfigurationSource.Explicit);
        }
        else
        {
            Builder.HasConversion(conversionType, ConfigurationSource.Explicit);
        }

        Builder.HasValueComparer(valueComparer, ConfigurationSource.Explicit);
        Builder.HasProviderValueComparer(providerComparer, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the property so that the property value is converted to and from the database
    ///     using the given <see cref="ValueConverter" />.
    /// </summary>
    /// <param name="converter">The converter to use.</param>
    /// <param name="valueComparer">The comparer to use for values before conversion.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(ValueConverter? converter, ValueComparer? valueComparer)
        => HasConversion(converter, valueComparer, null);

    /// <summary>
    ///     Configures the property so that the property value is converted to and from the database
    ///     using the given <see cref="ValueConverter" />.
    /// </summary>
    /// <param name="converter">The converter to use.</param>
    /// <param name="valueComparer">The comparer to use for values before conversion.</param>
    /// <param name="providerComparer">The comparer to use for the provider values.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(
        ValueConverter? converter,
        ValueComparer? valueComparer,
        ValueComparer? providerComparer)
    {
        Builder.HasConversion(converter, ConfigurationSource.Explicit);
        Builder.HasValueComparer(valueComparer, ConfigurationSource.Explicit);
        Builder.HasProviderValueComparer(providerComparer, ConfigurationSource.Explicit);

        return this;
    }

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <typeparam name="TConversion">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</typeparam>
    /// <typeparam name="TComparer">A type that inherits from <see cref="ValueComparer" />.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TConversion,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TComparer>()
        where TComparer : ValueComparer
        => HasConversion(typeof(TConversion), typeof(TComparer));

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <typeparam name="TConversion">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</typeparam>
    /// <typeparam name="TComparer">A type that inherits from <see cref="ValueComparer" />.</typeparam>
    /// <typeparam name="TProviderComparer">A type that inherits from <see cref="ValueComparer" /> to use for the provider values.</typeparam>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion<
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TConversion,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TComparer,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        TProviderComparer>()
        where TComparer : ValueComparer
        where TProviderComparer : ValueComparer
        => HasConversion(typeof(TConversion), typeof(TComparer), typeof(TProviderComparer));

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="conversionType">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</param>
    /// <param name="comparerType">A type that inherits from <see cref="ValueComparer" />.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type conversionType,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type? comparerType)
        => HasConversion(conversionType, comparerType, null);

    /// <summary>
    ///     Configures the property so that the property value is converted before
    ///     writing to the database and converted back when reading from the database.
    /// </summary>
    /// <param name="conversionType">The type to convert to and from or a type that inherits from <see cref="ValueConverter" />.</param>
    /// <param name="comparerType">A type that inherits from <see cref="ValueComparer" />.</param>
    /// <param name="providerComparerType">A type that inherits from <see cref="ValueComparer" /> to use for the provider values.</param>
    /// <returns>The same builder instance so that multiple configuration calls can be chained.</returns>
    public virtual ComplexCollectionTypePropertyBuilder HasConversion(
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type conversionType,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type? comparerType,
        [DynamicallyAccessedMembers(DynamicallyAccessedMemberTypes.PublicParameterlessConstructor)]
        Type? providerComparerType)
    {
        Check.NotNull(conversionType);

        if (typeof(ValueConverter).IsAssignableFrom(conversionType))
        {
            Builder.HasConverter(conversionType, ConfigurationSource.Explicit);
        }
        else
        {
            Builder.HasConversion(conversionType, ConfigurationSource.Explicit);
        }

        Builder.HasValueComparer(comparerType, ConfigurationSource.Explicit);
        Builder.HasProviderValueComparer(providerComparerType, ConfigurationSource.Explicit);

        return this;
    }

    #region Hidden System.Object members

    /// <summary>
    ///     Returns a string that represents the current object.
    /// </summary>
    /// <returns>A string that represents the current object.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    public override string? ToString()
        => base.ToString();

    /// <summary>
    ///     Determines whether the specified object is equal to the current object.
    /// </summary>
    /// <param name="obj">The object to compare with the current object.</param>
    /// <returns><see langword="true" /> if the specified object is equal to the current object; otherwise, <see langword="false" />.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    // ReSharper disable once BaseObjectEqualsIsObjectEquals
    public override bool Equals(object? obj)
        => base.Equals(obj);

    /// <summary>
    ///     Serves as the default hash function.
    /// </summary>
    /// <returns>A hash code for the current object.</returns>
    [EditorBrowsable(EditorBrowsableState.Never)]
    // ReSharper disable once BaseObjectGetHashCodeCallInGetHashCode
    public override int GetHashCode()
        => base.GetHashCode();

    #endregion
}
