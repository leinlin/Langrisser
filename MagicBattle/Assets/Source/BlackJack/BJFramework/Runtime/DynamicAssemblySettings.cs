using System;
using System.Collections.Generic;

namespace BlackJack.BJFramework.Runtime
{
	// Token: 0x0200003F RID: 63
	[Serializable]
	public class DynamicAssemblySettings
	{
		// Token: 0x0400014B RID: 331
		public bool EnableDynamicAssembly;

		// Token: 0x0400014C RID: 332
		public List<string> DynamicAssemblyList = new List<string>();
	}
}
