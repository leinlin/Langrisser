using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;

namespace SimpleJson
{
	// Token: 0x020010C1 RID: 4289
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("simple-json", "1.0.0")]
	public class JsonArray : List<object>
	{
		// Token: 0x060158DE RID: 88286 RVA: 0x0057D768 File Offset: 0x0057B968
		public JsonArray()
		{
		}

		// Token: 0x060158DF RID: 88287 RVA: 0x0057D770 File Offset: 0x0057B970
		public JsonArray(int capacity) : base(capacity)
		{
		}

		// Token: 0x060158E0 RID: 88288 RVA: 0x0057D77C File Offset: 0x0057B97C
		public override string ToString()
		{
			return SimpleJson.SerializeObject(this) ?? string.Empty;
		}
	}
}
