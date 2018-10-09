using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000508 RID: 1288
	[CustomLuaClass]
	public class ArenaDefenseInfo
	{
		// Token: 0x06004DEF RID: 19951 RVA: 0x0017B9F4 File Offset: 0x00179BF4
		public ArenaDefenseInfo()
		{
			int num = 0;
			this.TotalDefenseNums = num;
			this.SuccessfulDefenseNums = num;
		}

		// Token: 0x170012F5 RID: 4853
		// (get) Token: 0x06004DF0 RID: 19952 RVA: 0x0017BA18 File Offset: 0x00179C18
		// (set) Token: 0x06004DF1 RID: 19953 RVA: 0x0017BA20 File Offset: 0x00179C20
		public int SuccessfulDefenseNums { get; set; }

		// Token: 0x170012F6 RID: 4854
		// (get) Token: 0x06004DF2 RID: 19954 RVA: 0x0017BA2C File Offset: 0x00179C2C
		// (set) Token: 0x06004DF3 RID: 19955 RVA: 0x0017BA34 File Offset: 0x00179C34
		public int TotalDefenseNums { get; set; }

		// Token: 0x06004DF4 RID: 19956 RVA: 0x0017BA40 File Offset: 0x00179C40
		public void AddDefenseNums(bool successfulDefense)
		{
			if (successfulDefense)
			{
				this.SuccessfulDefenseNums++;
			}
			this.TotalDefenseNums++;
		}
	}
}
