using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200055A RID: 1370
	[CustomLuaClass]
	public class Mission
	{
		// Token: 0x06005041 RID: 20545 RVA: 0x00180888 File Offset: 0x0017EA88
		public Mission(int missionId)
		{
			this.MissionId = missionId;
			this.CompletedProcess = 0L;
		}

		// Token: 0x170013D3 RID: 5075
		// (get) Token: 0x06005042 RID: 20546 RVA: 0x001808A0 File Offset: 0x0017EAA0
		// (set) Token: 0x06005043 RID: 20547 RVA: 0x001808A8 File Offset: 0x0017EAA8
		public int MissionId { get; set; }

		// Token: 0x170013D4 RID: 5076
		// (get) Token: 0x06005044 RID: 20548 RVA: 0x001808B4 File Offset: 0x0017EAB4
		// (set) Token: 0x06005045 RID: 20549 RVA: 0x001808BC File Offset: 0x0017EABC
		public long CompletedProcess { get; set; }

		// Token: 0x170013D5 RID: 5077
		// (get) Token: 0x06005046 RID: 20550 RVA: 0x001808C8 File Offset: 0x0017EAC8
		// (set) Token: 0x06005047 RID: 20551 RVA: 0x001808D0 File Offset: 0x0017EAD0
		public ConfigDataMissionInfo Config { get; set; }

		// Token: 0x06005048 RID: 20552 RVA: 0x001808DC File Offset: 0x0017EADC
		public static Mission PBMissionToMission(ProMission pbMission)
		{
			return new Mission(pbMission.MissionId)
			{
				CompletedProcess = pbMission.MissionProcess
			};
		}

		// Token: 0x06005049 RID: 20553 RVA: 0x00180904 File Offset: 0x0017EB04
		public static List<Mission> PBMissionListToMissionList(List<ProMission> pbMissionList)
		{
			List<Mission> list = new List<Mission>();
			foreach (ProMission pbMission in pbMissionList)
			{
				list.Add(Mission.PBMissionToMission(pbMission));
			}
			return list;
		}

		// Token: 0x0600504A RID: 20554 RVA: 0x00180968 File Offset: 0x0017EB68
		public static ProMission MissionToPBMission(Mission misson)
		{
			if (misson.CompletedProcess == 0L)
			{
				return null;
			}
			return new ProMission
			{
				MissionId = misson.MissionId,
				MissionProcess = misson.CompletedProcess
			};
		}

		// Token: 0x0600504B RID: 20555 RVA: 0x001809A4 File Offset: 0x0017EBA4
		public static List<ProMission> MissionListToPBMissionList(List<Mission> missionList)
		{
			List<ProMission> list = new List<ProMission>();
			foreach (Mission misson in missionList)
			{
				ProMission proMission = Mission.MissionToPBMission(misson);
				if (proMission != null)
				{
					list.Add(proMission);
				}
			}
			return list;
		}
	}
}
