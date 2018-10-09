using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004E6 RID: 1254
	[CustomLuaClass]
	public class DataSectionMission : DataSection
	{
		// Token: 0x06004C19 RID: 19481 RVA: 0x00177E30 File Offset: 0x00176030
		public DataSectionMission()
		{
			this.ProcessingEverydayMissions = new List<Mission>();
			this.ProcessingOneOffMissions = new List<Mission>();
			this.FinishedEverydayMissions = new HashSet<int>();
			this.FinishedOneOffMissions = new HashSet<int>();
		}

		// Token: 0x06004C1A RID: 19482 RVA: 0x00177E64 File Offset: 0x00176064
		public override void ClearInitedData()
		{
			this.ProcessingEverydayMissions.Clear();
			this.ProcessingOneOffMissions.Clear();
			this.FinishedEverydayMissions.Clear();
			this.FinishedOneOffMissions.Clear();
		}

		// Token: 0x06004C1B RID: 19483 RVA: 0x00177E94 File Offset: 0x00176094
		public override object SerializeToClient()
		{
			DSMissionNtf dsmissionNtf = new DSMissionNtf();
			dsmissionNtf.Version = (uint)base.Version;
			dsmissionNtf.FinishedEverydayMissionList.AddRange(this.FinishedEverydayMissions);
			dsmissionNtf.FinishedOneOffMissionList.AddRange(this.FinishedOneOffMissions);
			dsmissionNtf.ProcessingMissionList.AddRange(Mission.MissionListToPBMissionList(this.ProcessingOneOffMissions));
			dsmissionNtf.ProcessingMissionList.AddRange(Mission.MissionListToPBMissionList(this.ProcessingEverydayMissions));
			return dsmissionNtf;
		}

		// Token: 0x06004C1C RID: 19484 RVA: 0x00177F04 File Offset: 0x00176104
		public void InitEverydayMissions(List<Mission> missions)
		{
			this.ProcessingEverydayMissions.AddRange(missions);
		}

		// Token: 0x06004C1D RID: 19485 RVA: 0x00177F14 File Offset: 0x00176114
		public void InitOneOffMissions(List<Mission> missions)
		{
			this.ProcessingOneOffMissions.AddRange(missions);
		}

		// Token: 0x06004C1E RID: 19486 RVA: 0x00177F24 File Offset: 0x00176124
		public void InitFinishedEverydayMissions(List<int> missions)
		{
			foreach (int item in missions)
			{
				this.FinishedEverydayMissions.Add(item);
			}
		}

		// Token: 0x06004C1F RID: 19487 RVA: 0x00177F84 File Offset: 0x00176184
		public void InitFinishedOneOffMissions(List<int> missions)
		{
			foreach (int item in missions)
			{
				this.FinishedOneOffMissions.Add(item);
			}
		}

		// Token: 0x06004C20 RID: 19488 RVA: 0x00177FE4 File Offset: 0x001761E4
		public void ResetEverydayMissions()
		{
			this.ProcessingEverydayMissions.Clear();
			this.FinishedEverydayMissions.Clear();
			base.SetDirty(true);
		}

		// Token: 0x06004C21 RID: 19489 RVA: 0x00178004 File Offset: 0x00176204
		public void AddOneOffMission(Mission mission)
		{
			if (mission.Config.Obsoleted)
			{
				return;
			}
			this.ProcessingOneOffMissions.Add(mission);
		}

		// Token: 0x06004C22 RID: 19490 RVA: 0x00178024 File Offset: 0x00176224
		public void AddEverydayMission(Mission mission)
		{
			if (mission.Config.Obsoleted)
			{
				return;
			}
			this.ProcessingEverydayMissions.Add(mission);
		}

		// Token: 0x06004C23 RID: 19491 RVA: 0x00178044 File Offset: 0x00176244
		public void FinishOneOffMission(Mission mission)
		{
			if (mission.Config.Obsoleted)
			{
				return;
			}
			this.ProcessingOneOffMissions.Remove(mission);
			this.FinishedOneOffMissions.Add(mission.MissionId);
			base.SetDirty(true);
		}

		// Token: 0x06004C24 RID: 19492 RVA: 0x00178080 File Offset: 0x00176280
		public void FinishEverydayMission(Mission mission)
		{
			if (mission.Config.Obsoleted)
			{
				return;
			}
			this.ProcessingEverydayMissions.Remove(mission);
			this.FinishedEverydayMissions.Add(mission.MissionId);
			base.SetDirty(true);
		}

		// Token: 0x06004C25 RID: 19493 RVA: 0x001780BC File Offset: 0x001762BC
		public void AddMissionProcess(Mission mission, long count)
		{
			if (mission.Config.Obsoleted)
			{
				return;
			}
			mission.CompletedProcess += count;
			base.SetDirty(true);
		}

		// Token: 0x06004C26 RID: 19494 RVA: 0x001780E4 File Offset: 0x001762E4
		public void SetMissionProcess(Mission mission, int process)
		{
			if (mission.Config.Obsoleted)
			{
				return;
			}
			mission.CompletedProcess = (long)process;
			base.SetDirty(true);
		}

		// Token: 0x06004C27 RID: 19495 RVA: 0x00178108 File Offset: 0x00176308
		public void RemoveEveryDayMission(int missionId)
		{
			if (this.FinishedEverydayMissions.Contains(missionId))
			{
				this.FinishedEverydayMissions.Remove(missionId);
				base.SetDirty(true);
			}
			else
			{
				Mission mission = this.ProcessingEverydayMissions.Find((Mission t) => t.MissionId == missionId);
				if (mission != null)
				{
					this.ProcessingEverydayMissions.Remove(mission);
					base.SetDirty(true);
				}
			}
		}

		// Token: 0x06004C28 RID: 19496 RVA: 0x00178188 File Offset: 0x00176388
		public List<int> GetExistMissionIds()
		{
			List<int> list = new List<int>();
			list.AddRange(this.FinishedEverydayMissions);
			list.AddRange(this.FinishedOneOffMissions);
			foreach (Mission mission in this.ProcessingEverydayMissions)
			{
				list.Add(mission.MissionId);
			}
			foreach (Mission mission2 in this.ProcessingOneOffMissions)
			{
				list.Add(mission2.MissionId);
			}
			return list;
		}

		// Token: 0x06004C29 RID: 19497 RVA: 0x0017825C File Offset: 0x0017645C
		public bool IsProcessingMission(int missionId)
		{
			Mission mission = this.ProcessingOneOffMissions.Find((Mission t) => t.MissionId == missionId);
			return mission != null || this.ProcessingEverydayMissions.Find((Mission t) => t.MissionId == missionId) != null;
		}

		// Token: 0x06004C2A RID: 19498 RVA: 0x001782B8 File Offset: 0x001764B8
		public List<Mission> GetAllProcessingMissions()
		{
			List<Mission> list = new List<Mission>();
			list.AddRange(this.ProcessingEverydayMissions);
			list.AddRange(this.ProcessingOneOffMissions);
			return list;
		}

		// Token: 0x1700129D RID: 4765
		// (get) Token: 0x06004C2B RID: 19499 RVA: 0x001782E4 File Offset: 0x001764E4
		// (set) Token: 0x06004C2C RID: 19500 RVA: 0x001782EC File Offset: 0x001764EC
		public List<Mission> ProcessingEverydayMissions { get; set; }

		// Token: 0x1700129E RID: 4766
		// (get) Token: 0x06004C2D RID: 19501 RVA: 0x001782F8 File Offset: 0x001764F8
		// (set) Token: 0x06004C2E RID: 19502 RVA: 0x00178300 File Offset: 0x00176500
		public HashSet<int> FinishedEverydayMissions { get; set; }

		// Token: 0x1700129F RID: 4767
		// (get) Token: 0x06004C2F RID: 19503 RVA: 0x0017830C File Offset: 0x0017650C
		// (set) Token: 0x06004C30 RID: 19504 RVA: 0x00178314 File Offset: 0x00176514
		public List<Mission> ProcessingOneOffMissions { get; set; }

		// Token: 0x170012A0 RID: 4768
		// (get) Token: 0x06004C31 RID: 19505 RVA: 0x00178320 File Offset: 0x00176520
		// (set) Token: 0x06004C32 RID: 19506 RVA: 0x00178328 File Offset: 0x00176528
		public HashSet<int> FinishedOneOffMissions { get; set; }
	}
}
