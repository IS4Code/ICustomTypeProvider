#if NET45_OR_GREATER || NETCOREAPP3_0_OR_GREATER || NET5_0_OR_GREATER

[assembly: System.Runtime.CompilerServices.TypeForwardedTo(typeof(System.Reflection.ICustomTypeProvider))]

#else

namespace System.Reflection
{
    /// <summary>
    /// Represents an object that provides a custom type.
    /// </summary>
    public interface ICustomTypeProvider
    {
        /// <summary>
        /// Gets the custom type provided by this object.
        /// </summary>
        /// <returns>The custom type.</returns>
        Type GetCustomType();
    }
}
#endif
