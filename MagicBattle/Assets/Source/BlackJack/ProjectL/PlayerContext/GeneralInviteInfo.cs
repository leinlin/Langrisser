using System;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200090E RID: 2318
	[CustomLuaClass]
	public class GeneralInviteInfo
	{
		// Token: 0x0600865F RID: 34399 RVA: 0x00269154 File Offset: 0x00267354
		public DateTime GetTimeout()
		{
			if (this.TeamRoomInviteInfo != null)
			{
				return this.TeamRoomInviteInfo.TimeOut;
			}
			return this.PVPInviteInfo.Timeout;
		}

		// Token: 0x04005F55 RID: 24405
		public TeamRoomInviteInfo TeamRoomInviteInfo;

		// Token: 0x04005F56 RID: 24406
		public PVPInviteInfo PVPInviteInfo;
	}
}
