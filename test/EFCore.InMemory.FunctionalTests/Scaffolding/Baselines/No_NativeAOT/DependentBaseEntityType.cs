// <auto-generated />
using System;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Scaffolding;
using Microsoft.EntityFrameworkCore.ValueGeneration;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    [EntityFrameworkInternal]
    public partial class DependentBaseEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "Microsoft.EntityFrameworkCore.Scaffolding.CompiledModelTestBase+DependentBase<byte?>",
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                baseEntityType,
                discriminatorProperty: "EnumDiscriminator",
                discriminatorValue: CompiledModelTestBase.Enum1.One,
                derivedTypesCount: 1,
                propertyCount: 4,
                navigationCount: 1,
                foreignKeyCount: 2,
                keyCount: 1);

            var principalId = runtimeEntityType.AddProperty(
                "PrincipalId",
                typeof(long),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: 0L);

            var principalAlternateId = runtimeEntityType.AddProperty(
                "PrincipalAlternateId",
                typeof(Guid),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                sentinel: new Guid("00000000-0000-0000-0000-000000000000"));

            var enumDiscriminator = runtimeEntityType.AddProperty(
                "EnumDiscriminator",
                typeof(CompiledModelTestBase.Enum1),
                afterSaveBehavior: PropertySaveBehavior.Throw,
                valueGeneratorFactory: new DiscriminatorValueGeneratorFactory().Create,
                sentinel: CompiledModelTestBase.Enum1.Default);

            var id = runtimeEntityType.AddProperty(
                "Id",
                typeof(byte?),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Id", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Id>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                nullable: true);

            var key = runtimeEntityType.AddKey(
                new[] { principalId, principalAlternateId });
            runtimeEntityType.SetPrimaryKey(key);

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                unique: true,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalId"), declaringEntityType.FindProperty("PrincipalAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.ClientNoAction,
                unique: true,
                required: true);

            var principal = declaringEntityType.AddNavigation("Principal",
                runtimeForeignKey,
                onDependent: true,
                typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>),
                propertyInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetProperty("Principal", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.DependentBase<byte?>).GetField("<Principal>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly));

            var dependent = principalEntityType.AddNavigation("Dependent",
                runtimeForeignKey,
                onDependent: false,
                typeof(CompiledModelTestBase.DependentBase<byte?>),
                propertyInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetProperty("Dependent", BindingFlags.Public | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                fieldInfo: typeof(CompiledModelTestBase.PrincipalDerived<CompiledModelTestBase.DependentBase<byte?>>).GetField("<Dependent>k__BackingField", BindingFlags.NonPublic | BindingFlags.Instance | BindingFlags.DeclaredOnly),
                eagerLoaded: true,
                lazyLoadingEnabled: false);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            runtimeEntityType.AddAnnotation("DiscriminatorMappingComplete", false);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}
