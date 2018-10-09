using System;
using BlackJack.ProjectL.Protocol;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200052D RID: 1325
	public class ClimbTower
	{
		// Token: 0x17001349 RID: 4937
		// (get) Token: 0x06004EF9 RID: 20217 RVA: 0x0017DEA4 File Offset: 0x0017C0A4
		// (set) Token: 0x06004EFA RID: 20218 RVA: 0x0017DEAC File Offset: 0x0017C0AC
		public int Floor { get; set; }

		// Token: 0x1700134A RID: 4938
		// (get) Token: 0x06004EFB RID: 20219 RVA: 0x0017DEB8 File Offset: 0x0017C0B8
		// (set) Token: 0x06004EFC RID: 20220 RVA: 0x0017DEC0 File Offset: 0x0017C0C0
		public int HistoryFloorMax { get; set; }

		// Token: 0x1700134B RID: 4939
		// (get) Token: 0x06004EFD RID: 20221 RVA: 0x0017DECC File Offset: 0x0017C0CC
		// (set) Token: 0x06004EFE RID: 20222 RVA: 0x0017DED4 File Offset: 0x0017C0D4
		public DateTime NextFlushTime { get; set; }

		// Token: 0x06004EFF RID: 20223 RVA: 0x0017DEE0 File Offset: 0x0017C0E0
		public static ProClimbTower ToPb(GlobalClimbTowerInfo globalClimbTowerInfo)
		{
			ProClimbTower proClimbTower = new ProClimbTower();
			proClimbTower.NextFlushTime = globalClimbTowerInfo.ClimbNextWeekFlushTime.Ticks;
			foreach (GlobalClimbTowerFloor globalClimbTowerFloor in globalClimbTowerInfo.Floors)
			{
				proClimbTower.Floors.Add(ClimbTower.ToPb(globalClimbTowerFloor));
			}
			return proClimbTower;
		}

		// Token: 0x06004F00 RID: 20224 RVA: 0x0017DF64 File Offset: 0x0017C164
		public static ProClimbTowerFloor ToPb(GlobalClimbTowerFloor globalClimbTowerFloor)
		{
			return new ProClimbTowerFloor
			{
				LevelId = globalClimbTowerFloor.LevelId,
				ArmyRandomSeed = globalClimbTowerFloor.ArmyRandomSeed,
				BonusHeroGroupId = globalClimbTowerFloor.BonusHeroGroupId,
				RuleId = globalClimbTowerFloor.RuleId
			};
		}

		// Token: 0x06004F01 RID: 20225 RVA: 0x0017DFA8 File Offset: 0x0017C1A8
		public static GlobalClimbTowerInfo FromPb(ProClimbTower pbClimbTower)
		{
			GlobalClimbTowerInfo globalClimbTowerInfo = new GlobalClimbTowerInfo();
			globalClimbTowerInfo.ClimbNextWeekFlushTime = new DateTime(pbClimbTower.NextFlushTime);
			foreach (ProClimbTowerFloor pbClimbTowerFloor in pbClimbTower.Floors)
			{
				globalClimbTowerInfo.Floors.Add(ClimbTower.FromPb(pbClimbTowerFloor));
			}
			return globalClimbTowerInfo;
		}

		// Token: 0x06004F02 RID: 20226 RVA: 0x0017E028 File Offset: 0x0017C228
		public static GlobalClimbTowerFloor FromPb(ProClimbTowerFloor pbClimbTowerFloor)
		{
			return new GlobalClimbTowerFloor
			{
				LevelId = pbClimbTowerFloor.LevelId,
				ArmyRandomSeed = pbClimbTowerFloor.ArmyRandomSeed,
				BonusHeroGroupId = pbClimbTowerFloor.BonusHeroGroupId,
				RuleId = pbClimbTowerFloor.RuleId
			};
		}
	}
}
