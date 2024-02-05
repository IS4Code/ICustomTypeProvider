ICustomTypeProvider
==========

This package adds the [`System.Reflection.ICustomTypeProvider` interface](https://learn.microsoft.com/dotnet/api/system.reflection.icustomtypeprovider) for use in .NET Standard and other platforms that do not support it.
On platforms where it is supported natively, it just forwards it to the original implementation.