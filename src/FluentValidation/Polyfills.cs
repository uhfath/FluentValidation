// Polyfill StringSyntaxAttribute when compiling in .NET < 7.
#if NETSTANDARD || NET5_0 || NET6_0
namespace System.Diagnostics.CodeAnalysis {
	[AttributeUsage(AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter, AllowMultiple = false, Inherited = false)]
	internal sealed class StringSyntaxAttribute : Attribute {
		public const string Regex = "Regex";
		public StringSyntaxAttribute(string syntax) { }
	}
}
#endif
