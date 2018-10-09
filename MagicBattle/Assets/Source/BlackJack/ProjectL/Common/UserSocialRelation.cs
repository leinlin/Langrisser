using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000424 RID: 1060
	[CustomLuaClass]
	public class UserSocialRelation
	{
		// Token: 0x04002E53 RID: 11859
		public List<string> Friends = new List<string>();

		// Token: 0x04002E54 RID: 11860
		public List<string> Blacklist = new List<string>();

		// Token: 0x04002E55 RID: 11861
		public List<string> Invitelist = new List<string>();

		// Token: 0x04002E56 RID: 11862
		public List<string> Invitedlist = new List<string>();
	}
}
