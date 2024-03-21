// <auto-generated />
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.ChangeTracking;
using Microsoft.EntityFrameworkCore.ChangeTracking.Internal;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.EntityFrameworkCore.Sqlite.Storage.Internal;
using Microsoft.EntityFrameworkCore.Storage;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    internal partial class PrincipalBasePrincipalDerivedDependentBasebyteEntityType
    {
        public static RuntimeEntityType Create(RuntimeModel model, RuntimeEntityType baseEntityType = null)
        {
            var runtimeEntityType = model.AddEntityType(
                "PrincipalBasePrincipalDerived<DependentBase<byte?>>",
                typeof(Dictionary<string, object>),
                baseEntityType,
                sharedClrType: true,
                indexerPropertyInfo: RuntimeEntityType.FindIndexerProperty(typeof(Dictionary<string, object>)),
                propertyBag: true,
                propertyCount: 5,
                foreignKeyCount: 2,
                unnamedIndexCount: 1,
                keyCount: 1);

            var derivedsId = runtimeEntityType.AddProperty(
                "DerivedsId",
                typeof(long),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            derivedsId.SetGetter(
                (Dictionary<string, object> entity) => (entity.ContainsKey("DerivedsId") ? entity["DerivedsId"] : null) == null ? 0L : (long)(entity.ContainsKey("DerivedsId") ? entity["DerivedsId"] : null),
                (Dictionary<string, object> entity) => (entity.ContainsKey("DerivedsId") ? entity["DerivedsId"] : null) == null,
                (Dictionary<string, object> instance) => (instance.ContainsKey("DerivedsId") ? instance["DerivedsId"] : null) == null ? 0L : (long)(instance.ContainsKey("DerivedsId") ? instance["DerivedsId"] : null),
                (Dictionary<string, object> instance) => (instance.ContainsKey("DerivedsId") ? instance["DerivedsId"] : null) == null);
            derivedsId.SetSetter(
                (Dictionary<string, object> entity, long value) => entity["DerivedsId"] = (object)value);
            derivedsId.SetMaterializationSetter(
                (Dictionary<string, object> entity, long value) => entity["DerivedsId"] = (object)value);
            derivedsId.SetAccessors(
                (InternalEntityEntry entry) =>
                {
                    if (entry.FlaggedAsStoreGenerated(0))
                    {
                        return entry.ReadStoreGeneratedValue<long>(0);
                    }
                    else
                    {
                        {
                            if (entry.FlaggedAsTemporary(0) && (((Dictionary<string, object>)entry.Entity).ContainsKey("DerivedsId") ? ((Dictionary<string, object>)entry.Entity)["DerivedsId"] : null) == null)
                            {
                                return entry.ReadTemporaryValue<long>(0);
                            }
                            else
                            {
                                var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("DerivedsId") ? ((Dictionary<string, object>)entry.Entity)["DerivedsId"] : null;
                                return nullableValue == null ? default(long) : (long)nullableValue;
                            }
                        }
                    }
                },
                (InternalEntityEntry entry) =>
                {
                    var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("DerivedsId") ? ((Dictionary<string, object>)entry.Entity)["DerivedsId"] : null;
                    return nullableValue == null ? default(long) : (long)nullableValue;
                },
                (InternalEntityEntry entry) => entry.ReadOriginalValue<long>(derivedsId, 0),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<long>(derivedsId, 0),
                (ValueBuffer valueBuffer) => valueBuffer[0]);
            derivedsId.SetPropertyIndexes(
                index: 0,
                originalValueIndex: 0,
                shadowIndex: -1,
                relationshipIndex: 0,
                storeGenerationIndex: 0);
            derivedsId.TypeMapping = LongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));
            derivedsId.SetCurrentValueComparer(new EntryCurrentValueComparer<long>(derivedsId));

            var derivedsAlternateId = runtimeEntityType.AddProperty(
                "DerivedsAlternateId",
                typeof(Guid),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            derivedsAlternateId.SetGetter(
                (Dictionary<string, object> entity) => (entity.ContainsKey("DerivedsAlternateId") ? entity["DerivedsAlternateId"] : null) == null ? new Guid("00000000-0000-0000-0000-000000000000") : (Guid)(entity.ContainsKey("DerivedsAlternateId") ? entity["DerivedsAlternateId"] : null),
                (Dictionary<string, object> entity) => (entity.ContainsKey("DerivedsAlternateId") ? entity["DerivedsAlternateId"] : null) == null,
                (Dictionary<string, object> instance) => (instance.ContainsKey("DerivedsAlternateId") ? instance["DerivedsAlternateId"] : null) == null ? new Guid("00000000-0000-0000-0000-000000000000") : (Guid)(instance.ContainsKey("DerivedsAlternateId") ? instance["DerivedsAlternateId"] : null),
                (Dictionary<string, object> instance) => (instance.ContainsKey("DerivedsAlternateId") ? instance["DerivedsAlternateId"] : null) == null);
            derivedsAlternateId.SetSetter(
                (Dictionary<string, object> entity, Guid value) => entity["DerivedsAlternateId"] = (object)value);
            derivedsAlternateId.SetMaterializationSetter(
                (Dictionary<string, object> entity, Guid value) => entity["DerivedsAlternateId"] = (object)value);
            derivedsAlternateId.SetAccessors(
                (InternalEntityEntry entry) =>
                {
                    if (entry.FlaggedAsStoreGenerated(1))
                    {
                        return entry.ReadStoreGeneratedValue<Guid>(1);
                    }
                    else
                    {
                        {
                            if (entry.FlaggedAsTemporary(1) && (((Dictionary<string, object>)entry.Entity).ContainsKey("DerivedsAlternateId") ? ((Dictionary<string, object>)entry.Entity)["DerivedsAlternateId"] : null) == null)
                            {
                                return entry.ReadTemporaryValue<Guid>(1);
                            }
                            else
                            {
                                var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("DerivedsAlternateId") ? ((Dictionary<string, object>)entry.Entity)["DerivedsAlternateId"] : null;
                                return nullableValue == null ? default(Guid) : (Guid)nullableValue;
                            }
                        }
                    }
                },
                (InternalEntityEntry entry) =>
                {
                    var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("DerivedsAlternateId") ? ((Dictionary<string, object>)entry.Entity)["DerivedsAlternateId"] : null;
                    return nullableValue == null ? default(Guid) : (Guid)nullableValue;
                },
                (InternalEntityEntry entry) => entry.ReadOriginalValue<Guid>(derivedsAlternateId, 1),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<Guid>(derivedsAlternateId, 1),
                (ValueBuffer valueBuffer) => valueBuffer[1]);
            derivedsAlternateId.SetPropertyIndexes(
                index: 1,
                originalValueIndex: 1,
                shadowIndex: -1,
                relationshipIndex: 1,
                storeGenerationIndex: 1);
            derivedsAlternateId.TypeMapping = SqliteGuidTypeMapping.Default;
            derivedsAlternateId.SetCurrentValueComparer(new EntryCurrentValueComparer<Guid>(derivedsAlternateId));

            var principalsId = runtimeEntityType.AddProperty(
                "PrincipalsId",
                typeof(long),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            principalsId.SetGetter(
                (Dictionary<string, object> entity) => (entity.ContainsKey("PrincipalsId") ? entity["PrincipalsId"] : null) == null ? 0L : (long)(entity.ContainsKey("PrincipalsId") ? entity["PrincipalsId"] : null),
                (Dictionary<string, object> entity) => (entity.ContainsKey("PrincipalsId") ? entity["PrincipalsId"] : null) == null,
                (Dictionary<string, object> instance) => (instance.ContainsKey("PrincipalsId") ? instance["PrincipalsId"] : null) == null ? 0L : (long)(instance.ContainsKey("PrincipalsId") ? instance["PrincipalsId"] : null),
                (Dictionary<string, object> instance) => (instance.ContainsKey("PrincipalsId") ? instance["PrincipalsId"] : null) == null);
            principalsId.SetSetter(
                (Dictionary<string, object> entity, long value) => entity["PrincipalsId"] = (object)value);
            principalsId.SetMaterializationSetter(
                (Dictionary<string, object> entity, long value) => entity["PrincipalsId"] = (object)value);
            principalsId.SetAccessors(
                (InternalEntityEntry entry) =>
                {
                    if (entry.FlaggedAsStoreGenerated(2))
                    {
                        return entry.ReadStoreGeneratedValue<long>(2);
                    }
                    else
                    {
                        {
                            if (entry.FlaggedAsTemporary(2) && (((Dictionary<string, object>)entry.Entity).ContainsKey("PrincipalsId") ? ((Dictionary<string, object>)entry.Entity)["PrincipalsId"] : null) == null)
                            {
                                return entry.ReadTemporaryValue<long>(2);
                            }
                            else
                            {
                                var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("PrincipalsId") ? ((Dictionary<string, object>)entry.Entity)["PrincipalsId"] : null;
                                return nullableValue == null ? default(long) : (long)nullableValue;
                            }
                        }
                    }
                },
                (InternalEntityEntry entry) =>
                {
                    var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("PrincipalsId") ? ((Dictionary<string, object>)entry.Entity)["PrincipalsId"] : null;
                    return nullableValue == null ? default(long) : (long)nullableValue;
                },
                (InternalEntityEntry entry) => entry.ReadOriginalValue<long>(principalsId, 2),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<long>(principalsId, 2),
                (ValueBuffer valueBuffer) => valueBuffer[2]);
            principalsId.SetPropertyIndexes(
                index: 2,
                originalValueIndex: 2,
                shadowIndex: -1,
                relationshipIndex: 2,
                storeGenerationIndex: 2);
            principalsId.TypeMapping = LongTypeMapping.Default.Clone(
                comparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                keyComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                providerValueComparer: new ValueComparer<long>(
                    (long v1, long v2) => v1 == v2,
                    (long v) => v.GetHashCode(),
                    (long v) => v),
                mappingInfo: new RelationalTypeMappingInfo(
                    storeTypeName: "INTEGER"));
            principalsId.SetCurrentValueComparer(new EntryCurrentValueComparer<long>(principalsId));

            var principalsAlternateId = runtimeEntityType.AddProperty(
                "PrincipalsAlternateId",
                typeof(Guid),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                afterSaveBehavior: PropertySaveBehavior.Throw);
            principalsAlternateId.SetGetter(
                (Dictionary<string, object> entity) => (entity.ContainsKey("PrincipalsAlternateId") ? entity["PrincipalsAlternateId"] : null) == null ? new Guid("00000000-0000-0000-0000-000000000000") : (Guid)(entity.ContainsKey("PrincipalsAlternateId") ? entity["PrincipalsAlternateId"] : null),
                (Dictionary<string, object> entity) => (entity.ContainsKey("PrincipalsAlternateId") ? entity["PrincipalsAlternateId"] : null) == null,
                (Dictionary<string, object> instance) => (instance.ContainsKey("PrincipalsAlternateId") ? instance["PrincipalsAlternateId"] : null) == null ? new Guid("00000000-0000-0000-0000-000000000000") : (Guid)(instance.ContainsKey("PrincipalsAlternateId") ? instance["PrincipalsAlternateId"] : null),
                (Dictionary<string, object> instance) => (instance.ContainsKey("PrincipalsAlternateId") ? instance["PrincipalsAlternateId"] : null) == null);
            principalsAlternateId.SetSetter(
                (Dictionary<string, object> entity, Guid value) => entity["PrincipalsAlternateId"] = (object)value);
            principalsAlternateId.SetMaterializationSetter(
                (Dictionary<string, object> entity, Guid value) => entity["PrincipalsAlternateId"] = (object)value);
            principalsAlternateId.SetAccessors(
                (InternalEntityEntry entry) =>
                {
                    if (entry.FlaggedAsStoreGenerated(3))
                    {
                        return entry.ReadStoreGeneratedValue<Guid>(3);
                    }
                    else
                    {
                        {
                            if (entry.FlaggedAsTemporary(3) && (((Dictionary<string, object>)entry.Entity).ContainsKey("PrincipalsAlternateId") ? ((Dictionary<string, object>)entry.Entity)["PrincipalsAlternateId"] : null) == null)
                            {
                                return entry.ReadTemporaryValue<Guid>(3);
                            }
                            else
                            {
                                var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("PrincipalsAlternateId") ? ((Dictionary<string, object>)entry.Entity)["PrincipalsAlternateId"] : null;
                                return nullableValue == null ? default(Guid) : (Guid)nullableValue;
                            }
                        }
                    }
                },
                (InternalEntityEntry entry) =>
                {
                    var nullableValue = ((Dictionary<string, object>)entry.Entity).ContainsKey("PrincipalsAlternateId") ? ((Dictionary<string, object>)entry.Entity)["PrincipalsAlternateId"] : null;
                    return nullableValue == null ? default(Guid) : (Guid)nullableValue;
                },
                (InternalEntityEntry entry) => entry.ReadOriginalValue<Guid>(principalsAlternateId, 3),
                (InternalEntityEntry entry) => entry.ReadRelationshipSnapshotValue<Guid>(principalsAlternateId, 3),
                (ValueBuffer valueBuffer) => valueBuffer[3]);
            principalsAlternateId.SetPropertyIndexes(
                index: 3,
                originalValueIndex: 3,
                shadowIndex: -1,
                relationshipIndex: 3,
                storeGenerationIndex: 3);
            principalsAlternateId.TypeMapping = SqliteGuidTypeMapping.Default;
            principalsAlternateId.SetCurrentValueComparer(new EntryCurrentValueComparer<Guid>(principalsAlternateId));

            var rowid = runtimeEntityType.AddProperty(
                "rowid",
                typeof(byte[]),
                propertyInfo: runtimeEntityType.FindIndexerPropertyInfo(),
                nullable: true,
                concurrencyToken: true,
                valueGenerated: ValueGenerated.OnAddOrUpdate,
                beforeSaveBehavior: PropertySaveBehavior.Ignore,
                afterSaveBehavior: PropertySaveBehavior.Ignore);
            rowid.SetGetter(
                (Dictionary<string, object> entity) => (entity.ContainsKey("rowid") ? entity["rowid"] : null) == null ? null : (byte[])(entity.ContainsKey("rowid") ? entity["rowid"] : null),
                (Dictionary<string, object> entity) => (entity.ContainsKey("rowid") ? entity["rowid"] : null) == null,
                (Dictionary<string, object> instance) => (instance.ContainsKey("rowid") ? instance["rowid"] : null) == null ? null : (byte[])(instance.ContainsKey("rowid") ? instance["rowid"] : null),
                (Dictionary<string, object> instance) => (instance.ContainsKey("rowid") ? instance["rowid"] : null) == null);
            rowid.SetSetter(
                (Dictionary<string, object> entity, byte[] value) => entity["rowid"] = (object)value);
            rowid.SetMaterializationSetter(
                (Dictionary<string, object> entity, byte[] value) => entity["rowid"] = (object)value);
            rowid.SetAccessors(
                (InternalEntityEntry entry) => entry.FlaggedAsStoreGenerated(4) ? entry.ReadStoreGeneratedValue<byte[]>(4) : entry.FlaggedAsTemporary(4) && (((Dictionary<string, object>)entry.Entity).ContainsKey("rowid") ? ((Dictionary<string, object>)entry.Entity)["rowid"] : null) == null ? entry.ReadTemporaryValue<byte[]>(4) : (byte[])(((Dictionary<string, object>)entry.Entity).ContainsKey("rowid") ? ((Dictionary<string, object>)entry.Entity)["rowid"] : null),
                (InternalEntityEntry entry) => (byte[])(((Dictionary<string, object>)entry.Entity).ContainsKey("rowid") ? ((Dictionary<string, object>)entry.Entity)["rowid"] : null),
                (InternalEntityEntry entry) => entry.ReadOriginalValue<byte[]>(rowid, 4),
                (InternalEntityEntry entry) => entry.GetCurrentValue<byte[]>(rowid),
                (ValueBuffer valueBuffer) => valueBuffer[4]);
            rowid.SetPropertyIndexes(
                index: 4,
                originalValueIndex: 4,
                shadowIndex: -1,
                relationshipIndex: -1,
                storeGenerationIndex: 4);
            rowid.TypeMapping = SqliteByteArrayTypeMapping.Default.Clone(
                comparer: new ValueComparer<byte[]>(
                    (byte[] v1, byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals((object)v1, (object)v2),
                    (byte[] v) => v.GetHashCode(),
                    (byte[] v) => v),
                keyComparer: new ValueComparer<byte[]>(
                    (byte[] v1, byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals((object)v1, (object)v2),
                    (byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode((object)v),
                    (byte[] source) => source.ToArray()),
                providerValueComparer: new ValueComparer<byte[]>(
                    (byte[] v1, byte[] v2) => StructuralComparisons.StructuralEqualityComparer.Equals((object)v1, (object)v2),
                    (byte[] v) => StructuralComparisons.StructuralEqualityComparer.GetHashCode((object)v),
                    (byte[] source) => source.ToArray()));

            var key = runtimeEntityType.AddKey(
                new[] { derivedsId, derivedsAlternateId, principalsId, principalsAlternateId });
            runtimeEntityType.SetPrimaryKey(key);

            var index = runtimeEntityType.AddIndex(
                new[] { principalsId, principalsAlternateId });

            return runtimeEntityType;
        }

        public static RuntimeForeignKey CreateForeignKey1(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("DerivedsId"), declaringEntityType.FindProperty("DerivedsAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            return runtimeForeignKey;
        }

        public static RuntimeForeignKey CreateForeignKey2(RuntimeEntityType declaringEntityType, RuntimeEntityType principalEntityType)
        {
            var runtimeForeignKey = declaringEntityType.AddForeignKey(new[] { declaringEntityType.FindProperty("PrincipalsId"), declaringEntityType.FindProperty("PrincipalsAlternateId") },
                principalEntityType.FindKey(new[] { principalEntityType.FindProperty("Id"), principalEntityType.FindProperty("AlternateId") }),
                principalEntityType,
                deleteBehavior: DeleteBehavior.Cascade,
                required: true);

            return runtimeForeignKey;
        }

        public static void CreateAnnotations(RuntimeEntityType runtimeEntityType)
        {
            var derivedsId = runtimeEntityType.FindProperty("DerivedsId")!;
            var derivedsAlternateId = runtimeEntityType.FindProperty("DerivedsAlternateId")!;
            var principalsId = runtimeEntityType.FindProperty("PrincipalsId")!;
            var principalsAlternateId = runtimeEntityType.FindProperty("PrincipalsAlternateId")!;
            var rowid = runtimeEntityType.FindProperty("rowid")!;
            runtimeEntityType.SetOriginalValuesFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (Dictionary<string, object>)source.Entity;
                    return (ISnapshot)new Snapshot<long, Guid, long, Guid, byte[]>(((ValueComparer<long>)derivedsId.GetValueComparer()).Snapshot(source.GetCurrentValue<long>(derivedsId)), ((ValueComparer<Guid>)derivedsAlternateId.GetValueComparer()).Snapshot(source.GetCurrentValue<Guid>(derivedsAlternateId)), ((ValueComparer<long>)principalsId.GetValueComparer()).Snapshot(source.GetCurrentValue<long>(principalsId)), ((ValueComparer<Guid>)principalsAlternateId.GetValueComparer()).Snapshot(source.GetCurrentValue<Guid>(principalsAlternateId)), source.GetCurrentValue<byte[]>(rowid) == null ? null : ((ValueComparer<byte[]>)rowid.GetValueComparer()).Snapshot(source.GetCurrentValue<byte[]>(rowid)));
                });
            runtimeEntityType.SetStoreGeneratedValuesFactory(
                () => (ISnapshot)new Snapshot<long, Guid, long, Guid, byte[]>(((ValueComparer<long>)derivedsId.GetValueComparer()).Snapshot(default(long)), ((ValueComparer<Guid>)derivedsAlternateId.GetValueComparer()).Snapshot(default(Guid)), ((ValueComparer<long>)principalsId.GetValueComparer()).Snapshot(default(long)), ((ValueComparer<Guid>)principalsAlternateId.GetValueComparer()).Snapshot(default(Guid)), default(byte[]) == null ? null : ((ValueComparer<byte[]>)rowid.GetValueComparer()).Snapshot(default(byte[]))));
            runtimeEntityType.SetTemporaryValuesFactory(
                (InternalEntityEntry source) => (ISnapshot)new Snapshot<long, Guid, long, Guid, byte[]>(default(long), default(Guid), default(long), default(Guid), default(byte[])));
            runtimeEntityType.SetShadowValuesFactory(
                (IDictionary<string, object> source) => Snapshot.Empty);
            runtimeEntityType.SetEmptyShadowValuesFactory(
                () => Snapshot.Empty);
            runtimeEntityType.SetRelationshipSnapshotFactory(
                (InternalEntityEntry source) =>
                {
                    var entity = (Dictionary<string, object>)source.Entity;
                    return (ISnapshot)new Snapshot<long, Guid, long, Guid>(((ValueComparer<long>)derivedsId.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<long>(derivedsId)), ((ValueComparer<Guid>)derivedsAlternateId.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Guid>(derivedsAlternateId)), ((ValueComparer<long>)principalsId.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<long>(principalsId)), ((ValueComparer<Guid>)principalsAlternateId.GetKeyValueComparer()).Snapshot(source.GetCurrentValue<Guid>(principalsAlternateId)));
                });
            runtimeEntityType.Counts = new PropertyCounts(
                propertyCount: 5,
                navigationCount: 0,
                complexPropertyCount: 0,
                originalValueCount: 5,
                shadowCount: 0,
                relationshipCount: 4,
                storeGeneratedCount: 5);
            runtimeEntityType.AddAnnotation("Relational:FunctionName", null);
            runtimeEntityType.AddAnnotation("Relational:Schema", null);
            runtimeEntityType.AddAnnotation("Relational:SqlQuery", null);
            runtimeEntityType.AddAnnotation("Relational:TableName", "PrincipalBasePrincipalDerived<DependentBase<byte?>>");
            runtimeEntityType.AddAnnotation("Relational:ViewName", null);
            runtimeEntityType.AddAnnotation("Relational:ViewSchema", null);

            Customize(runtimeEntityType);
        }

        static partial void Customize(RuntimeEntityType runtimeEntityType);
    }
}