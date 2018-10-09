using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000502 RID: 1282
	[CustomLuaClass]
	public class ArenaPlayerInfo
	{
		// Token: 0x06004D96 RID: 19862 RVA: 0x0017AFBC File Offset: 0x001791BC
		public ArenaPlayerInfo()
		{
			this.Opponents = new List<ArenaOpponent>();
			this.ThisWeekBattleIds = new List<int>();
			this.ReceivedVictoryPointsRewardIndexs = new List<int>();
			this.AttackedOpponent = false;
			this.WeekLastFlushTime = DateTime.MinValue;
			this.DefensiveTeam = new ArenaPlayerDefensiveTeam();
		}

		// Token: 0x170012D1 RID: 4817
		// (get) Token: 0x06004D97 RID: 19863 RVA: 0x0017B010 File Offset: 0x00179210
		// (set) Token: 0x06004D98 RID: 19864 RVA: 0x0017B018 File Offset: 0x00179218
		public ArenaPlayerDefensiveTeam DefensiveTeam { get; set; }

		// Token: 0x170012D2 RID: 4818
		// (get) Token: 0x06004D99 RID: 19865 RVA: 0x0017B024 File Offset: 0x00179224
		// (set) Token: 0x06004D9A RID: 19866 RVA: 0x0017B02C File Offset: 0x0017922C
		public List<ArenaOpponent> Opponents { get; set; }

		// Token: 0x170012D3 RID: 4819
		// (get) Token: 0x06004D9B RID: 19867 RVA: 0x0017B038 File Offset: 0x00179238
		// (set) Token: 0x06004D9C RID: 19868 RVA: 0x0017B040 File Offset: 0x00179240
		public int ArenaLevelId { get; set; }

		// Token: 0x170012D4 RID: 4820
		// (get) Token: 0x06004D9D RID: 19869 RVA: 0x0017B04C File Offset: 0x0017924C
		// (set) Token: 0x06004D9E RID: 19870 RVA: 0x0017B054 File Offset: 0x00179254
		public ushort ArenaPoints { get; set; }

		// Token: 0x170012D5 RID: 4821
		// (get) Token: 0x06004D9F RID: 19871 RVA: 0x0017B060 File Offset: 0x00179260
		// (set) Token: 0x06004DA0 RID: 19872 RVA: 0x0017B068 File Offset: 0x00179268
		public bool AttackedOpponent { get; set; }

		// Token: 0x170012D6 RID: 4822
		// (get) Token: 0x06004DA1 RID: 19873 RVA: 0x0017B074 File Offset: 0x00179274
		// (set) Token: 0x06004DA2 RID: 19874 RVA: 0x0017B07C File Offset: 0x0017927C
		public DateTime WeekLastFlushTime { get; set; }

		// Token: 0x170012D7 RID: 4823
		// (get) Token: 0x06004DA3 RID: 19875 RVA: 0x0017B088 File Offset: 0x00179288
		// (set) Token: 0x06004DA4 RID: 19876 RVA: 0x0017B090 File Offset: 0x00179290
		public int VictoryPoints { get; set; }

		// Token: 0x170012D8 RID: 4824
		// (get) Token: 0x06004DA5 RID: 19877 RVA: 0x0017B09C File Offset: 0x0017929C
		// (set) Token: 0x06004DA6 RID: 19878 RVA: 0x0017B0A4 File Offset: 0x001792A4
		public List<int> ReceivedVictoryPointsRewardIndexs { get; set; }

		// Token: 0x170012D9 RID: 4825
		// (get) Token: 0x06004DA7 RID: 19879 RVA: 0x0017B0B0 File Offset: 0x001792B0
		// (set) Token: 0x06004DA8 RID: 19880 RVA: 0x0017B0B8 File Offset: 0x001792B8
		public List<int> ThisWeekBattleIds { get; set; }

		// Token: 0x170012DA RID: 4826
		// (get) Token: 0x06004DA9 RID: 19881 RVA: 0x0017B0C4 File Offset: 0x001792C4
		// (set) Token: 0x06004DAA RID: 19882 RVA: 0x0017B0CC File Offset: 0x001792CC
		public int ThisWeekTotalBattleNums { get; set; }

		// Token: 0x170012DB RID: 4827
		// (get) Token: 0x06004DAB RID: 19883 RVA: 0x0017B0D8 File Offset: 0x001792D8
		// (set) Token: 0x06004DAC RID: 19884 RVA: 0x0017B0E0 File Offset: 0x001792E0
		public int ThisWeekVictoryNums { get; set; }

		// Token: 0x170012DC RID: 4828
		// (get) Token: 0x06004DAD RID: 19885 RVA: 0x0017B0EC File Offset: 0x001792EC
		// (set) Token: 0x06004DAE RID: 19886 RVA: 0x0017B0F4 File Offset: 0x001792F4
		public bool IsAutoBattle { get; set; }

		// Token: 0x170012DD RID: 4829
		// (get) Token: 0x06004DAF RID: 19887 RVA: 0x0017B100 File Offset: 0x00179300
		// (set) Token: 0x06004DB0 RID: 19888 RVA: 0x0017B108 File Offset: 0x00179308
		public ArenaOpponent RevengeOpponent { get; set; }

		// Token: 0x170012DE RID: 4830
		// (get) Token: 0x06004DB1 RID: 19889 RVA: 0x0017B114 File Offset: 0x00179314
		// (set) Token: 0x06004DB2 RID: 19890 RVA: 0x0017B11C File Offset: 0x0017931C
		public ulong RevengeBattleReportInstanceId { get; set; }

		// Token: 0x170012DF RID: 4831
		// (get) Token: 0x06004DB3 RID: 19891 RVA: 0x0017B128 File Offset: 0x00179328
		// (set) Token: 0x06004DB4 RID: 19892 RVA: 0x0017B130 File Offset: 0x00179330
		public ArenaOpponentDefensiveBattleInfo OpponentDefensiveBattleInfo { get; set; }

		// Token: 0x170012E0 RID: 4832
		// (get) Token: 0x06004DB5 RID: 19893 RVA: 0x0017B13C File Offset: 0x0017933C
		// (set) Token: 0x06004DB6 RID: 19894 RVA: 0x0017B144 File Offset: 0x00179344
		public int MineRank { get; set; }

		// Token: 0x170012E1 RID: 4833
		// (get) Token: 0x06004DB7 RID: 19895 RVA: 0x0017B150 File Offset: 0x00179350
		// (set) Token: 0x06004DB8 RID: 19896 RVA: 0x0017B158 File Offset: 0x00179358
		public int ConsecutiveVictoryNums { get; set; }

		// Token: 0x170012E2 RID: 4834
		// (get) Token: 0x06004DB9 RID: 19897 RVA: 0x0017B164 File Offset: 0x00179364
		// (set) Token: 0x06004DBA RID: 19898 RVA: 0x0017B16C File Offset: 0x0017936C
		public long NextFlushOpponentTime { get; set; }

		// Token: 0x06004DBB RID: 19899 RVA: 0x0017B178 File Offset: 0x00179378
		public static ArenaPlayerInfo PBArenaPlayerInfoToArenaPlayerInfo(ProArenaPlayerInfo pbArenaPlayerInfo)
		{
			ArenaPlayerInfo arenaPlayerInfo = new ArenaPlayerInfo();
			arenaPlayerInfo.DefensiveTeam = ArenaPlayerDefensiveTeam.PBArenaDefensiveTeamToArenaDefensiveTeam(pbArenaPlayerInfo.DefensiveTeam);
			foreach (ProArenaOpponent pbArenaOpponent in pbArenaPlayerInfo.Opponents)
			{
				arenaPlayerInfo.Opponents.Add(ArenaOpponent.PBArenaOpponentToArenaOpponent(pbArenaOpponent));
			}
			arenaPlayerInfo.IsAutoBattle = pbArenaPlayerInfo.IsAutoBattle;
			arenaPlayerInfo.ArenaLevelId = pbArenaPlayerInfo.ArenaLevelId;
			arenaPlayerInfo.ArenaPoints = (ushort)pbArenaPlayerInfo.ArenaPoints;
			arenaPlayerInfo.AttackedOpponent = pbArenaPlayerInfo.AttackedOpponent;
			arenaPlayerInfo.VictoryPoints = pbArenaPlayerInfo.VictoryPoints;
			arenaPlayerInfo.WeekLastFlushTime = new DateTime(pbArenaPlayerInfo.WeekLastFlushTime);
			arenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.AddRange(pbArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs);
			arenaPlayerInfo.ThisWeekBattleIds.AddRange(pbArenaPlayerInfo.ThisWeekBattleIds);
			arenaPlayerInfo.ConsecutiveVictoryNums = pbArenaPlayerInfo.ConsecutiveVictoryNums;
			arenaPlayerInfo.ThisWeekTotalBattleNums = pbArenaPlayerInfo.ThisWeekTotalBattleNums;
			arenaPlayerInfo.ThisWeekVictoryNums = pbArenaPlayerInfo.ThisWeekVictoryNums;
			arenaPlayerInfo.NextFlushOpponentTime = pbArenaPlayerInfo.NextFlushOpponentTime;
			return arenaPlayerInfo;
		}

		// Token: 0x06004DBC RID: 19900 RVA: 0x0017B298 File Offset: 0x00179498
		public static ProArenaPlayerInfo ArenaPlayerInfoToPBArenaPlayerInfo(ArenaPlayerInfo arenaPlayerInfo)
		{
			ProArenaPlayerInfo proArenaPlayerInfo = new ProArenaPlayerInfo();
			proArenaPlayerInfo.DefensiveTeam = ArenaPlayerDefensiveTeam.ArenaDefensiveTeamToPBArenaDefensiveTeam(arenaPlayerInfo.DefensiveTeam);
			foreach (ArenaOpponent arenaOpponent in arenaPlayerInfo.Opponents)
			{
				proArenaPlayerInfo.Opponents.Add(ArenaOpponent.ArenaOpponentToPBArenaOpponent(arenaOpponent));
			}
			proArenaPlayerInfo.IsAutoBattle = arenaPlayerInfo.IsAutoBattle;
			proArenaPlayerInfo.ArenaLevelId = arenaPlayerInfo.ArenaLevelId;
			proArenaPlayerInfo.ArenaPoints = (int)arenaPlayerInfo.ArenaPoints;
			proArenaPlayerInfo.AttackedOpponent = arenaPlayerInfo.AttackedOpponent;
			proArenaPlayerInfo.VictoryPoints = arenaPlayerInfo.VictoryPoints;
			proArenaPlayerInfo.WeekLastFlushTime = arenaPlayerInfo.WeekLastFlushTime.Ticks;
			proArenaPlayerInfo.ReceivedVictoryPointsRewardIndexs.AddRange(arenaPlayerInfo.ReceivedVictoryPointsRewardIndexs);
			proArenaPlayerInfo.ThisWeekBattleIds.AddRange(arenaPlayerInfo.ThisWeekBattleIds);
			proArenaPlayerInfo.ConsecutiveVictoryNums = arenaPlayerInfo.ConsecutiveVictoryNums;
			proArenaPlayerInfo.ThisWeekTotalBattleNums = arenaPlayerInfo.ThisWeekTotalBattleNums;
			proArenaPlayerInfo.ThisWeekVictoryNums = arenaPlayerInfo.ThisWeekVictoryNums;
			proArenaPlayerInfo.NextFlushOpponentTime = arenaPlayerInfo.NextFlushOpponentTime;
			return proArenaPlayerInfo;
		}
	}
}
