using System;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000410 RID: 1040
	[CustomLuaClass]
	public class TeamRoomSetting
	{
		// Token: 0x17001088 RID: 4232
		// (get) Token: 0x06003CC1 RID: 15553 RVA: 0x001134A0 File Offset: 0x001116A0
		// (set) Token: 0x06003CC2 RID: 15554 RVA: 0x001134A8 File Offset: 0x001116A8
		public GameFunctionType GameFunctionTypeId { get; set; }

		// Token: 0x17001089 RID: 4233
		// (get) Token: 0x06003CC3 RID: 15555 RVA: 0x001134B4 File Offset: 0x001116B4
		// (set) Token: 0x06003CC4 RID: 15556 RVA: 0x001134BC File Offset: 0x001116BC
		public int LocationId { get; set; }

		// Token: 0x1700108A RID: 4234
		// (get) Token: 0x06003CC5 RID: 15557 RVA: 0x001134C8 File Offset: 0x001116C8
		// (set) Token: 0x06003CC6 RID: 15558 RVA: 0x001134D0 File Offset: 0x001116D0
		public int JoinMinLevel { get; set; }

		// Token: 0x1700108B RID: 4235
		// (get) Token: 0x06003CC7 RID: 15559 RVA: 0x001134DC File Offset: 0x001116DC
		// (set) Token: 0x06003CC8 RID: 15560 RVA: 0x001134E4 File Offset: 0x001116E4
		public int JoinMaxLevel { get; set; }

		// Token: 0x1700108C RID: 4236
		// (get) Token: 0x06003CC9 RID: 15561 RVA: 0x001134F0 File Offset: 0x001116F0
		// (set) Token: 0x06003CCA RID: 15562 RVA: 0x001134F8 File Offset: 0x001116F8
		public TeamRoomAuthority Authority { get; set; }

		// Token: 0x06003CCB RID: 15563 RVA: 0x00113504 File Offset: 0x00111704
		public static ProTeamRoomSetting TeamRoomSettingToPbTeamRoomSetting(TeamRoomSetting setting)
		{
			return new ProTeamRoomSetting
			{
				GameFunctionTypeId = (int)setting.GameFunctionTypeId,
				LocationId = setting.LocationId,
				Authority = (int)setting.Authority,
				JoinMaxLevel = setting.JoinMaxLevel,
				JoinMinLevel = setting.JoinMinLevel
			};
		}

		// Token: 0x06003CCC RID: 15564 RVA: 0x00113558 File Offset: 0x00111758
		public static TeamRoomSetting PbTeamRoomSettingToTeamRoomSetting(ProTeamRoomSetting pbSetting)
		{
			return new TeamRoomSetting
			{
				GameFunctionTypeId = (GameFunctionType)pbSetting.GameFunctionTypeId,
				LocationId = pbSetting.LocationId,
				Authority = (TeamRoomAuthority)pbSetting.Authority,
				JoinMaxLevel = pbSetting.JoinMaxLevel,
				JoinMinLevel = pbSetting.JoinMinLevel
			};
		}
	}
}
