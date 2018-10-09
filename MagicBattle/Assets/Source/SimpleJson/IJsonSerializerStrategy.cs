using System;
using System.CodeDom.Compiler;

namespace SimpleJson
{
	// Token: 0x020010C4 RID: 4292
	[GeneratedCode("simple-json", "1.0.0")]
	public interface IJsonSerializerStrategy
	{
		// Token: 0x06015914 RID: 88340
		bool TrySerializeNonPrimitiveObject(object input, out object output);

		// Token: 0x06015915 RID: 88341
		object DeserializeObject(object value, Type type);
	}
}
