using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000506 RID: 1286
	[CustomLuaClass]
	public class ArenaOpponentDefensiveBattleInfo
	{
		// Token: 0x170012EB RID: 4843
		// (get) Token: 0x06004DD6 RID: 19926 RVA: 0x0017B660 File Offset: 0x00179860
		// (set) Token: 0x06004DD7 RID: 19927 RVA: 0x0017B668 File Offset: 0x00179868
		public ArenaBattleReportStatus Status { get; set; }

		// Token: 0x170012EC RID: 4844
		// (get) Token: 0x06004DD8 RID: 19928 RVA: 0x0017B674 File Offset: 0x00179874
		// (set) Token: 0x06004DD9 RID: 19929 RVA: 0x0017B67C File Offset: 0x0017987C
		public string OpponentUserId { get; set; }

		// Token: 0x170012ED RID: 4845
		// (get) Token: 0x06004DDA RID: 19930 RVA: 0x0017B688 File Offset: 0x00179888
		// (set) Token: 0x06004DDB RID: 19931 RVA: 0x0017B690 File Offset: 0x00179890
		public int BattleRandomSeed { get; set; }

		// Token: 0x170012EE RID: 4846
		// (get) Token: 0x06004DDC RID: 19932 RVA: 0x0017B69C File Offset: 0x0017989C
		// (set) Token: 0x06004DDD RID: 19933 RVA: 0x0017B6A4 File Offset: 0x001798A4
		public long BattleExpiredTime { get; set; }

		// Token: 0x170012EF RID: 4847
		// (get) Token: 0x06004DDE RID: 19934 RVA: 0x0017B6B0 File Offset: 0x001798B0
		// (set) Token: 0x06004DDF RID: 19935 RVA: 0x0017B6B8 File Offset: 0x001798B8
		public int ArenaOpponentPointZoneId { get; set; }

		// Token: 0x06004DE0 RID: 19936 RVA: 0x0017B6C4 File Offset: 0x001798C4
		public static ArenaOpponentDefensiveBattleInfo PBDefensiveBattleInfoToDefensiveBattleInfo(ProArenaDefensiveBattleInfo pbDefensiveBattleInfo)
		{
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = new ArenaOpponentDefensiveBattleInfo();
			arenaOpponentDefensiveBattleInfo.BattleExpiredTime = pbDefensiveBattleInfo.BattleExpiredTime;
			arenaOpponentDefensiveBattleInfo.BattleRandomSeed = pbDefensiveBattleInfo.RandomSeed;
			arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.BattleId = pbDefensiveBattleInfo.BattleId;
			arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.ArenaDefenderRuleId = pbDefensiveBattleInfo.ArenaDefenderRuleId;
			arenaOpponentDefensiveBattleInfo.ArenaOpponentPointZoneId = pbDefensiveBattleInfo.ArenaOpponentPointZoneId;
			arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.PlayerLevel = pbDefensiveBattleInfo.PlayerLevel;
			foreach (ProBattleHero pbBattleHero in pbDefensiveBattleInfo.DefenderHeroes)
			{
				arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.DefenderHeroes.Add(BattleHero.PBBattleHeroToBattleHero(pbBattleHero));
			}
			foreach (ProTrainingTech tech in pbDefensiveBattleInfo.Techs)
			{
				arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.Techs.Add(TrainingTech.FromDataSection(tech));
			}
			return arenaOpponentDefensiveBattleInfo;
		}

		// Token: 0x06004DE1 RID: 19937 RVA: 0x0017B7E8 File Offset: 0x001799E8
		public static ProArenaDefensiveBattleInfo DefensiveBattleInfoToPBDefensiveBattleInfo(ArenaOpponentDefensiveBattleInfo defensiveBattleInfo)
		{
			ProArenaDefensiveBattleInfo proArenaDefensiveBattleInfo = new ProArenaDefensiveBattleInfo();
			proArenaDefensiveBattleInfo.BattleExpiredTime = defensiveBattleInfo.BattleExpiredTime;
			proArenaDefensiveBattleInfo.RandomSeed = defensiveBattleInfo.BattleRandomSeed;
			proArenaDefensiveBattleInfo.ArenaOpponentPointZoneId = defensiveBattleInfo.ArenaOpponentPointZoneId;
			ArenaPlayerDefensiveTeamSnapshot battleTeamSnapshot = defensiveBattleInfo.BattleTeamSnapshot;
			proArenaDefensiveBattleInfo.BattleId = battleTeamSnapshot.BattleId;
			proArenaDefensiveBattleInfo.ArenaDefenderRuleId = battleTeamSnapshot.ArenaDefenderRuleId;
			proArenaDefensiveBattleInfo.PlayerLevel = battleTeamSnapshot.PlayerLevel;
			foreach (BattleHero battleHero in battleTeamSnapshot.DefenderHeroes)
			{
				proArenaDefensiveBattleInfo.DefenderHeroes.Add(BattleHero.BattleHeroToPBBattleHero(battleHero));
			}
			foreach (TrainingTech trainingTech in battleTeamSnapshot.Techs)
			{
				proArenaDefensiveBattleInfo.Techs.Add(trainingTech.ToPro());
			}
			return proArenaDefensiveBattleInfo;
		}

		// Token: 0x04003914 RID: 14612
		public ArenaPlayerDefensiveTeamSnapshot BattleTeamSnapshot = new ArenaPlayerDefensiveTeamSnapshot();
	}
}
