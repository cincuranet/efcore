// <auto-generated />
using System;
using System.Runtime.CompilerServices;
using Microsoft.EntityFrameworkCore.Scaffolding;

#pragma warning disable 219, 612, 618
#nullable disable

namespace TestNamespace
{
    public static class LazyConstructorEntityUnsafeAccessors
    {
        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<Id>k__BackingField")]
        public static extern ref int Id(CompiledModelInMemoryTest.LazyConstructorEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyPropertyDelegateEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyPropertyDelegateEntity LazyPropertyDelegateEntity(CompiledModelInMemoryTest.LazyConstructorEntity @this);

        [UnsafeAccessor(UnsafeAccessorKind.Field, Name = "<LazyPropertyEntity>k__BackingField")]
        public static extern ref CompiledModelInMemoryTest.LazyPropertyEntity LazyPropertyEntity(CompiledModelInMemoryTest.LazyConstructorEntity @this);
    }
}
