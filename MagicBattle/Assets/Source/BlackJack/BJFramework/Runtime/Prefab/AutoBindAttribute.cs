using System;

namespace BlackJack.BJFramework.Runtime.Prefab
{
	// Token: 0x02000072 RID: 114
	[AttributeUsage(AttributeTargets.Field)]
	public class AutoBindAttribute : Attribute
	{
		// Token: 0x06000558 RID: 1368 RVA: 0x00017AA4 File Offset: 0x00015CA4
		public AutoBindAttribute(string path, AutoBindAttribute.InitState initState = AutoBindAttribute.InitState.NotInit, bool optional = false)
		{
			this.m_path = path;
			this.m_initState = initState;
			this.m_optional = optional;
		}

		// Token: 0x0400029D RID: 669
		public readonly string m_path;

		// Token: 0x0400029E RID: 670
		public readonly AutoBindAttribute.InitState m_initState;

		// Token: 0x0400029F RID: 671
		public readonly bool m_optional;

		// Token: 0x02000073 RID: 115
		public enum InitState
		{
			// Token: 0x040002A1 RID: 673
			NotInit,
			// Token: 0x040002A2 RID: 674
			Active,
			// Token: 0x040002A3 RID: 675
			Inactive
		}
	}
}
