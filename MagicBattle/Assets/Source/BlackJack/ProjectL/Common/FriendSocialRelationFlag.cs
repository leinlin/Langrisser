using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003EE RID: 1006
	public enum FriendSocialRelationFlag
	{
		// Token: 0x04002D44 RID: 11588
		None,
		// Token: 0x04002D45 RID: 11589
		Friend,
		// Token: 0x04002D46 RID: 11590
		Blacklist,
		// Token: 0x04002D47 RID: 11591
		Invite = 4,
		// Token: 0x04002D48 RID: 11592
		Invited = 8,
		// Token: 0x04002D49 RID: 11593
		RecentContactsChat = 16,
		// Token: 0x04002D4A RID: 11594
		RecentContactsTeamBattle = 32,
		// Token: 0x04002D4B RID: 11595
		All = -1
	}
}
