using System;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000426 RID: 1062
	[CustomLuaClass]
	public class UserSummary
	{
		// Token: 0x04002E57 RID: 11863
		public string UserId;

		// Token: 0x04002E58 RID: 11864
		public string Name;

		// Token: 0x04002E59 RID: 11865
		public int Level = 1;

		// Token: 0x04002E5A RID: 11866
		public int HeadIcon;

		// Token: 0x04002E5B RID: 11867
		public bool Online;

		// Token: 0x04002E5C RID: 11868
		public DateTime LogoutTime;

		// Token: 0x04002E5D RID: 11869
		public int TopHeroBattlePower;
	}
}
