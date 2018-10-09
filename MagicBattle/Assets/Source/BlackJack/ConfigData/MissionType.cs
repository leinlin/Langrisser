using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C1 RID: 705
	[ProtoContract(Name = "MissionType")]
	public enum MissionType
	{
		// Token: 0x04001CF0 RID: 7408
		[ProtoEnum(Name = "MissionType_CardPoolSelectCard", Value = 1)]
		MissionType_CardPoolSelectCard = 1,
		// Token: 0x04001CF1 RID: 7409
		[ProtoEnum(Name = "MissionType_SummonHero", Value = 2)]
		MissionType_SummonHero,
		// Token: 0x04001CF2 RID: 7410
		[ProtoEnum(Name = "MissionType_ConsumeEnergy", Value = 3)]
		MissionType_ConsumeEnergy,
		// Token: 0x04001CF3 RID: 7411
		[ProtoEnum(Name = "MissionType_CompleteEvent", Value = 4)]
		MissionType_CompleteEvent,
		// Token: 0x04001CF4 RID: 7412
		[ProtoEnum(Name = "MissionType_CompleteLevel", Value = 5)]
		MissionType_CompleteLevel,
		// Token: 0x04001CF5 RID: 7413
		[ProtoEnum(Name = "MissionType_DirectActivation", Value = 6)]
		MissionType_DirectActivation,
		// Token: 0x04001CF6 RID: 7414
		[ProtoEnum(Name = "MissionType_CompleteAllEverydayMission", Value = 7)]
		MissionType_CompleteAllEverydayMission,
		// Token: 0x04001CF7 RID: 7415
		[ProtoEnum(Name = "MissionType_CompleteScenario", Value = 8)]
		MissionType_CompleteScenario,
		// Token: 0x04001CF8 RID: 7416
		[ProtoEnum(Name = "MissionType_ComleteSimpleRiftLevel", Value = 9)]
		MissionType_ComleteSimpleRiftLevel,
		// Token: 0x04001CF9 RID: 7417
		[ProtoEnum(Name = "MissionType_ComleteDiffcultRiftLevel", Value = 10)]
		MissionType_ComleteDiffcultRiftLevel,
		// Token: 0x04001CFA RID: 7418
		[ProtoEnum(Name = "MissionType_GetRiftLevelFightAchievement", Value = 11)]
		MissionType_GetRiftLevelFightAchievement,
		// Token: 0x04001CFB RID: 7419
		[ProtoEnum(Name = "MissionType_GetRiftLevelFightStar", Value = 12)]
		MissionType_GetRiftLevelFightStar,
		// Token: 0x04001CFC RID: 7420
		[ProtoEnum(Name = "MissionType_ConsumeCrystal", Value = 13)]
		MissionType_ConsumeCrystal,
		// Token: 0x04001CFD RID: 7421
		[ProtoEnum(Name = "MissionType_ConsumeGold", Value = 14)]
		MissionType_ConsumeGold,
		// Token: 0x04001CFE RID: 7422
		[ProtoEnum(Name = "MissionType_UseAnyHeroExpItem", Value = 15)]
		MissionType_UseAnyHeroExpItem,
		// Token: 0x04001CFF RID: 7423
		[ProtoEnum(Name = "MissionType_AllHeroAllJobLevelUpNums", Value = 16)]
		MissionType_AllHeroAllJobLevelUpNums,
		// Token: 0x04001D00 RID: 7424
		[ProtoEnum(Name = "MissionType_AllHerohaveJobNums", Value = 17)]
		MissionType_AllHerohaveJobNums,
		// Token: 0x04001D01 RID: 7425
		[ProtoEnum(Name = "MissionType_AllHeroHaveSkillNums", Value = 18)]
		MissionType_AllHeroHaveSkillNums,
		// Token: 0x04001D02 RID: 7426
		[ProtoEnum(Name = "MissionType_AllHeroHaveSoliderNums", Value = 19)]
		MissionType_AllHeroHaveSoliderNums,
		// Token: 0x04001D03 RID: 7427
		[ProtoEnum(Name = "MissionType_AllJobMasterHeroNums", Value = 20)]
		MissionType_AllJobMasterHeroNums,
		// Token: 0x04001D04 RID: 7428
		[ProtoEnum(Name = "MissionType_HeroMasterJobNums", Value = 21)]
		MissionType_HeroMasterJobNums,
		// Token: 0x04001D05 RID: 7429
		[ProtoEnum(Name = "MissionType_HaveStarHeroNums", Value = 22)]
		MissionType_HaveStarHeroNums,
		// Token: 0x04001D06 RID: 7430
		[ProtoEnum(Name = "MissionType_PlayerLevelUp", Value = 23)]
		MissionType_PlayerLevelUp,
		// Token: 0x04001D07 RID: 7431
		[ProtoEnum(Name = "MissionType_UseCrystalBuyEnergyNums", Value = 24)]
		MissionType_UseCrystalBuyEnergyNums,
		// Token: 0x04001D08 RID: 7432
		[ProtoEnum(Name = "MissionType_LoginGameDays", Value = 25)]
		MissionType_LoginGameDays,
		// Token: 0x04001D09 RID: 7433
		[ProtoEnum(Name = "MissionType_RankJobHeroNums", Value = 26)]
		MissionType_RankJobHeroNums,
		// Token: 0x04001D0A RID: 7434
		[ProtoEnum(Name = "MissionType_SpecificHeroFightNums", Value = 27)]
		MissionType_SpecificHeroFightNums,
		// Token: 0x04001D0B RID: 7435
		[ProtoEnum(Name = "MissionType_CompleteBattleAchievement", Value = 28)]
		MissionType_CompleteBattleAchievement,
		// Token: 0x04001D0C RID: 7436
		[ProtoEnum(Name = "MissionType_SpecificHeroMasterSpecificJobRelationId", Value = 29)]
		MissionType_SpecificHeroMasterSpecificJobRelationId,
		// Token: 0x04001D0D RID: 7437
		[ProtoEnum(Name = "MissionType_ArenaConsecutiveVictoryNums", Value = 30)]
		MissionType_ArenaConsecutiveVictoryNums,
		// Token: 0x04001D0E RID: 7438
		[ProtoEnum(Name = "MissionType_HasAboveLevelHeroNums", Value = 31)]
		MissionType_HasAboveLevelHeroNums,
		// Token: 0x04001D0F RID: 7439
		[ProtoEnum(Name = "MissionType_TransferNewJobNums", Value = 32)]
		MissionType_TransferNewJobNums,
		// Token: 0x04001D10 RID: 7440
		[ProtoEnum(Name = "MissionType_HaveRankHeroNums", Value = 33)]
		MissionType_HaveRankHeroNums,
		// Token: 0x04001D11 RID: 7441
		[ProtoEnum(Name = "MissionType_SpecificHeroReachSpecificLevel", Value = 34)]
		MissionType_SpecificHeroReachSpecificLevel,
		// Token: 0x04001D12 RID: 7442
		[ProtoEnum(Name = "MissionType_TrainingTechToLevel", Value = 35)]
		MissionType_TrainingTechToLevel,
		// Token: 0x04001D13 RID: 7443
		[ProtoEnum(Name = "MissionType_EquipmentToLevel", Value = 36)]
		MissionType_EquipmentToLevel,
		// Token: 0x04001D14 RID: 7444
		[ProtoEnum(Name = "MissionType_FinishTeamBattle", Value = 37)]
		MissionType_FinishTeamBattle,
		// Token: 0x04001D15 RID: 7445
		[ProtoEnum(Name = "MissionType_FavorabilityToLevel", Value = 38)]
		MissionType_FavorabilityToLevel,
		// Token: 0x04001D16 RID: 7446
		[ProtoEnum(Name = "MissionType_FetterToLevel", Value = 39)]
		MissionType_FetterToLevel,
		// Token: 0x04001D17 RID: 7447
		[ProtoEnum(Name = "MissionType_EnchatEquipments", Value = 40)]
		MissionType_EnchatEquipments,
		// Token: 0x04001D18 RID: 7448
		[ProtoEnum(Name = "MissionType_TotalHeroJobLevelUp", Value = 41)]
		MissionType_TotalHeroJobLevelUp,
		// Token: 0x04001D19 RID: 7449
		[ProtoEnum(Name = "MissionType_AddFriend", Value = 42)]
		MissionType_AddFriend,
		// Token: 0x04001D1A RID: 7450
		[ProtoEnum(Name = "MissionType_AssignHeroToTask", Value = 43)]
		MissionType_AssignHeroToTask,
		// Token: 0x04001D1B RID: 7451
		[ProtoEnum(Name = "MissionType_BattlePractice", Value = 44)]
		MissionType_BattlePractice,
		// Token: 0x04001D1C RID: 7452
		[ProtoEnum(Name = "MissionType_RealTimeArena", Value = 45)]
		MissionType_RealTimeArena,
		// Token: 0x04001D1D RID: 7453
		[ProtoEnum(Name = "MissionType_ReachedSpecificRealTimeArenaDan", Value = 46)]
		MissionType_ReachedSpecificRealTimeArenaDan,
		// Token: 0x04001D1E RID: 7454
		[ProtoEnum(Name = "MissionType_DailyEquipmentEnchant", Value = 47)]
		MissionType_DailyEquipmentEnchant,
		// Token: 0x04001D1F RID: 7455
		[ProtoEnum(Name = "MissionType_BuyGiftStoreGoods", Value = 48)]
		MissionType_BuyGiftStoreGoods,
		// Token: 0x04001D20 RID: 7456
		[ProtoEnum(Name = "MissionType_BuyRechargeStoreGoods", Value = 49)]
		MissionType_BuyRechargeStoreGoods,
		// Token: 0x04001D21 RID: 7457
		[ProtoEnum(Name = "MissionType_Share", Value = 50)]
		MissionType_Share,
		// Token: 0x04001D22 RID: 7458
		[ProtoEnum(Name = "MissionType_MissionSelectCard", Value = 51)]
		MissionType_MissionSelectCard
	}
}
