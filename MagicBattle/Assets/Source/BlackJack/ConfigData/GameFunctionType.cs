using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C5 RID: 709
	[ProtoContract(Name = "GameFunctionType")]
	public enum GameFunctionType
	{
		// Token: 0x04001D54 RID: 7508
		[ProtoEnum(Name = "GameFunctionType_None", Value = 0)]
		GameFunctionType_None,
		// Token: 0x04001D55 RID: 7509
		[ProtoEnum(Name = "GameFunctionType_Mission", Value = 1)]
		GameFunctionType_Mission,
		// Token: 0x04001D56 RID: 7510
		[ProtoEnum(Name = "GameFunctionType_Achievement", Value = 2)]
		GameFunctionType_Achievement,
		// Token: 0x04001D57 RID: 7511
		[ProtoEnum(Name = "GameFunctionType_BattleAchievement", Value = 3)]
		GameFunctionType_BattleAchievement,
		// Token: 0x04001D58 RID: 7512
		[ProtoEnum(Name = "GameFunctionType_ArenaBattle", Value = 4)]
		GameFunctionType_ArenaBattle,
		// Token: 0x04001D59 RID: 7513
		[ProtoEnum(Name = "GameFunctionType_ArenaPoint", Value = 5)]
		GameFunctionType_ArenaPoint,
		// Token: 0x04001D5A RID: 7514
		[ProtoEnum(Name = "GameFunctionType_ArenaGrade", Value = 6)]
		GameFunctionType_ArenaGrade,
		// Token: 0x04001D5B RID: 7515
		[ProtoEnum(Name = "GameFunctionType_ArenaRanking", Value = 7)]
		GameFunctionType_ArenaRanking,
		// Token: 0x04001D5C RID: 7516
		[ProtoEnum(Name = "GameFunctionType_Sign", Value = 8)]
		GameFunctionType_Sign,
		// Token: 0x04001D5D RID: 7517
		[ProtoEnum(Name = "GameFunctionType_Rift", Value = 9)]
		GameFunctionType_Rift,
		// Token: 0x04001D5E RID: 7518
		[ProtoEnum(Name = "GameFunctionType_Scenario", Value = 10)]
		GameFunctionType_Scenario,
		// Token: 0x04001D5F RID: 7519
		[ProtoEnum(Name = "GameFunctionType_Event", Value = 11)]
		GameFunctionType_Event,
		// Token: 0x04001D60 RID: 7520
		[ProtoEnum(Name = "GameFunctionType_AnikiGym", Value = 12)]
		GameFunctionType_AnikiGym,
		// Token: 0x04001D61 RID: 7521
		[ProtoEnum(Name = "GameFunctionType_ThearchyTrial", Value = 13)]
		GameFunctionType_ThearchyTrial,
		// Token: 0x04001D62 RID: 7522
		[ProtoEnum(Name = "GameFunctionType_Store", Value = 14)]
		GameFunctionType_Store,
		// Token: 0x04001D63 RID: 7523
		[ProtoEnum(Name = "GameFunctionType_Recharge", Value = 15)]
		GameFunctionType_Recharge,
		// Token: 0x04001D64 RID: 7524
		[ProtoEnum(Name = "GameFunctionType_EquipmentEnhance", Value = 16)]
		GameFunctionType_EquipmentEnhance,
		// Token: 0x04001D65 RID: 7525
		[ProtoEnum(Name = "GameFunctionType_EquipmentUpgrade", Value = 17)]
		GameFunctionType_EquipmentUpgrade,
		// Token: 0x04001D66 RID: 7526
		[ProtoEnum(Name = "GameFunctionType_HeroUpgrade", Value = 18)]
		GameFunctionType_HeroUpgrade,
		// Token: 0x04001D67 RID: 7527
		[ProtoEnum(Name = "GameFunctionType_HeroJobChange", Value = 19)]
		GameFunctionType_HeroJobChange,
		// Token: 0x04001D68 RID: 7528
		[ProtoEnum(Name = "GameFunctionType_JobUnlock", Value = 20)]
		GameFunctionType_JobUnlock,
		// Token: 0x04001D69 RID: 7529
		[ProtoEnum(Name = "GameFunctionType_BondInteract", Value = 21)]
		GameFunctionType_BondInteract,
		// Token: 0x04001D6A RID: 7530
		[ProtoEnum(Name = "GameFunctionType_Bond", Value = 22)]
		GameFunctionType_Bond,
		// Token: 0x04001D6B RID: 7531
		[ProtoEnum(Name = "GameFunctionType_ChangeName", Value = 23)]
		GameFunctionType_ChangeName,
		// Token: 0x04001D6C RID: 7532
		[ProtoEnum(Name = "GameFunctionType_SelectCard", Value = 24)]
		GameFunctionType_SelectCard,
		// Token: 0x04001D6D RID: 7533
		[ProtoEnum(Name = "GameFunctionType_Item", Value = 25)]
		GameFunctionType_Item,
		// Token: 0x04001D6E RID: 7534
		[ProtoEnum(Name = "GameFunctionType_GM", Value = 26)]
		GameFunctionType_GM,
		// Token: 0x04001D6F RID: 7535
		[ProtoEnum(Name = "GameFunctionType_HeroJobLevelUp", Value = 27)]
		GameFunctionType_HeroJobLevelUp,
		// Token: 0x04001D70 RID: 7536
		[ProtoEnum(Name = "GameFunctionType_HeroDungeon", Value = 28)]
		GameFunctionType_HeroDungeon,
		// Token: 0x04001D71 RID: 7537
		[ProtoEnum(Name = "GameFunctionType_BuyEnergy", Value = 29)]
		GameFunctionType_BuyEnergy,
		// Token: 0x04001D72 RID: 7538
		[ProtoEnum(Name = "GameFunctionType_BuyArenaTicket", Value = 30)]
		GameFunctionType_BuyArenaTicket,
		// Token: 0x04001D73 RID: 7539
		[ProtoEnum(Name = "GameFunctionType_OperationalActivityExchange", Value = 31)]
		GameFunctionType_OperationalActivityExchange,
		// Token: 0x04001D74 RID: 7540
		[ProtoEnum(Name = "GameFunctionType_OperationalActivityReward", Value = 32)]
		GameFunctionType_OperationalActivityReward,
		// Token: 0x04001D75 RID: 7541
		[ProtoEnum(Name = "GameFunctionType_TrainningGroupInstrumentLevelUp", Value = 33)]
		GameFunctionType_TrainningGroupInstrumentLevelUp,
		// Token: 0x04001D76 RID: 7542
		[ProtoEnum(Name = "GameFunctionType_NewPlayerInitialItem", Value = 34)]
		GameFunctionType_NewPlayerInitialItem,
		// Token: 0x04001D77 RID: 7543
		[ProtoEnum(Name = "GameFunctionType_BattleTreasure", Value = 35)]
		GameFunctionType_BattleTreasure,
		// Token: 0x04001D78 RID: 7544
		[ProtoEnum(Name = "GameFunctionType_CoachFavourabilityLevelUp", Value = 36)]
		GameFunctionType_CoachFavourabilityLevelUp,
		// Token: 0x04001D79 RID: 7545
		[ProtoEnum(Name = "GameFunctionType_RandomEvent", Value = 37)]
		GameFunctionType_RandomEvent,
		// Token: 0x04001D7A RID: 7546
		[ProtoEnum(Name = "GameFunctionType_Survey", Value = 38)]
		GameFunctionType_Survey,
		// Token: 0x04001D7B RID: 7547
		[ProtoEnum(Name = "GameFunctionType_ExchangeGiftCDKey", Value = 39)]
		GameFunctionType_ExchangeGiftCDKey,
		// Token: 0x04001D7C RID: 7548
		[ProtoEnum(Name = "GameFunctionType_SystemGiveArenaTicket", Value = 40)]
		GameFunctionType_SystemGiveArenaTicket,
		// Token: 0x04001D7D RID: 7549
		[ProtoEnum(Name = "GameFunctionType_TreasureMap", Value = 41)]
		GameFunctionType_TreasureMap,
		// Token: 0x04001D7E RID: 7550
		[ProtoEnum(Name = "GameFunctionType_MemoryCorridor", Value = 42)]
		GameFunctionType_MemoryCorridor,
		// Token: 0x04001D7F RID: 7551
		[ProtoEnum(Name = "GameFunctionType_HeroFavorabilityLeveUP", Value = 43)]
		GameFunctionType_HeroFavorabilityLeveUP,
		// Token: 0x04001D80 RID: 7552
		[ProtoEnum(Name = "GameFunctionType_PlayerLevelUp", Value = 44)]
		GameFunctionType_PlayerLevelUp,
		// Token: 0x04001D81 RID: 7553
		[ProtoEnum(Name = "GameFunctionType_SystemRecoveyEnergy", Value = 45)]
		GameFunctionType_SystemRecoveyEnergy,
		// Token: 0x04001D82 RID: 7554
		[ProtoEnum(Name = "GameFunctionType_HeroFetterLevelUp", Value = 46)]
		GameFunctionType_HeroFetterLevelUp,
		// Token: 0x04001D83 RID: 7555
		[ProtoEnum(Name = "GameFunctionType_HeroFetterUnlock", Value = 47)]
		GameFunctionType_HeroFetterUnlock,
		// Token: 0x04001D84 RID: 7556
		[ProtoEnum(Name = "GameFunctionType_HeroConfess", Value = 48)]
		GameFunctionType_HeroConfess,
		// Token: 0x04001D85 RID: 7557
		[ProtoEnum(Name = "GameFunctionType_HeroDungeonChaterStarReward", Value = 49)]
		GameFunctionType_HeroDungeonChaterStarReward,
		// Token: 0x04001D86 RID: 7558
		[ProtoEnum(Name = "GameFunctionType_RiftChaterStarReward", Value = 50)]
		GameFunctionType_RiftChaterStarReward,
		// Token: 0x04001D87 RID: 7559
		[ProtoEnum(Name = "GameFunctionType_HeroTrainning", Value = 51)]
		GameFunctionType_HeroTrainning,
		// Token: 0x04001D88 RID: 7560
		[ProtoEnum(Name = "GameFunctionType_TrainingGround", Value = 52)]
		GameFunctionType_TrainingGround,
		// Token: 0x04001D89 RID: 7561
		[ProtoEnum(Name = "GameFunctionType_HeroAssistants", Value = 53)]
		GameFunctionType_HeroAssistants,
		// Token: 0x04001D8A RID: 7562
		[ProtoEnum(Name = "GameFunctionType_DecomposeBagItems", Value = 54)]
		GameFunctionType_DecomposeBagItems,
		// Token: 0x04001D8B RID: 7563
		[ProtoEnum(Name = "GameFunctionType_Friend", Value = 55)]
		GameFunctionType_Friend,
		// Token: 0x04001D8C RID: 7564
		[ProtoEnum(Name = "GameFunctionType_HeroPhantom", Value = 56)]
		GameFunctionType_HeroPhantom,
		// Token: 0x04001D8D RID: 7565
		[ProtoEnum(Name = "GameFunctionType_CooperateBattle", Value = 57)]
		GameFunctionType_CooperateBattle,
		// Token: 0x04001D8E RID: 7566
		[ProtoEnum(Name = "GameFunctionType_Enchant", Value = 58)]
		GameFunctionType_Enchant,
		// Token: 0x04001D8F RID: 7567
		[ProtoEnum(Name = "GameFunctionType_Novice", Value = 59)]
		GameFunctionType_Novice,
		// Token: 0x04001D90 RID: 7568
		[ProtoEnum(Name = "GameFunctionType_Equipment", Value = 60)]
		GameFunctionType_Equipment,
		// Token: 0x04001D91 RID: 7569
		[ProtoEnum(Name = "GameFunctionType_Fetters", Value = 61)]
		GameFunctionType_Fetters,
		// Token: 0x04001D92 RID: 7570
		[ProtoEnum(Name = "GameFunctionType_AutoBattle", Value = 62)]
		GameFunctionType_AutoBattle,
		// Token: 0x04001D93 RID: 7571
		[ProtoEnum(Name = "GameFunctionType_FastBattle", Value = 63)]
		GameFunctionType_FastBattle,
		// Token: 0x04001D94 RID: 7572
		[ProtoEnum(Name = "GameFunctionType_SkipBattleAnimation", Value = 64)]
		GameFunctionType_SkipBattleAnimation,
		// Token: 0x04001D95 RID: 7573
		[ProtoEnum(Name = "GameFunctionType_RMBGift", Value = 65)]
		GameFunctionType_RMBGift,
		// Token: 0x04001D96 RID: 7574
		[ProtoEnum(Name = "GameFunctionType_Regret", Value = 66)]
		GameFunctionType_Regret,
		// Token: 0x04001D97 RID: 7575
		[ProtoEnum(Name = "GameFunctionType_Raffle", Value = 67)]
		GameFunctionType_Raffle,
		// Token: 0x04001D98 RID: 7576
		[ProtoEnum(Name = "GameFunctionType_RMBGiftRewards", Value = 68)]
		GameFunctionType_RMBGiftRewards,
		// Token: 0x04001D99 RID: 7577
		[ProtoEnum(Name = "GameFunctionType_MonthCard", Value = 69)]
		GameFunctionType_MonthCard,
		// Token: 0x04001D9A RID: 7578
		[ProtoEnum(Name = "GameFunctionType_RealTimePVP", Value = 70)]
		GameFunctionType_RealTimePVP,
		// Token: 0x04001D9B RID: 7579
		[ProtoEnum(Name = "GameFunctionType_CheatBuyingGiftStoreGoodsCompensation", Value = 71)]
		GameFunctionType_CheatBuyingGiftStoreGoodsCompensation,
		// Token: 0x04001D9C RID: 7580
		[ProtoEnum(Name = "GameFunctionType_RealTimePVPBattle", Value = 72)]
		GameFunctionType_RealTimePVPBattle,
		// Token: 0x04001D9D RID: 7581
		[ProtoEnum(Name = "GameFunctionType_RealTimePVPPoint", Value = 73)]
		GameFunctionType_RealTimePVPPoint,
		// Token: 0x04001D9E RID: 7582
		[ProtoEnum(Name = "GameFunctionType_RealTimePVPDan", Value = 74)]
		GameFunctionType_RealTimePVPDan,
		// Token: 0x04001D9F RID: 7583
		[ProtoEnum(Name = "GameFunctionType_RealTimePVPRanking", Value = 75)]
		GameFunctionType_RealTimePVPRanking,
		// Token: 0x04001DA0 RID: 7584
		[ProtoEnum(Name = "GameFunctionType_MonthCardMission", Value = 76)]
		GameFunctionType_MonthCardMission,
		// Token: 0x04001DA1 RID: 7585
		[ProtoEnum(Name = "GameFunctionType_ExchangeHeroFragment", Value = 77)]
		GameFunctionType_ExchangeHeroFragment,
		// Token: 0x04001DA2 RID: 7586
		[ProtoEnum(Name = "GameFunctionType_BattlePractice", Value = 78)]
		GameFunctionType_BattlePractice,
		// Token: 0x04001DA3 RID: 7587
		[ProtoEnum(Name = "GameFunctionType_UnchartedScoreChallengeLevel", Value = 79)]
		GameFunctionType_UnchartedScoreChallengeLevel,
		// Token: 0x04001DA4 RID: 7588
		[ProtoEnum(Name = "GameFunctionType_UnchartedScoreScoreLevel", Value = 80)]
		GameFunctionType_UnchartedScoreScoreLevel,
		// Token: 0x04001DA5 RID: 7589
		[ProtoEnum(Name = "GameFunctionType_GuildChangeName", Value = 81)]
		GameFunctionType_GuildChangeName,
		// Token: 0x04001DA6 RID: 7590
		[ProtoEnum(Name = "GameFunctionType_ClimbTower", Value = 82)]
		GameFunctionType_ClimbTower,
		// Token: 0x04001DA7 RID: 7591
		[ProtoEnum(Name = "GameFunctionType_Guild", Value = 83)]
		GameFunctionType_Guild,
		// Token: 0x04001DA8 RID: 7592
		[ProtoEnum(Name = "GameFunctionType_HeroCompose", Value = 84)]
		GameFunctionType_HeroCompose,
		// Token: 0x04001DA9 RID: 7593
		[ProtoEnum(Name = "GameFunctionType_Chat", Value = 85)]
		GameFunctionType_Chat,
		// Token: 0x04001DAA RID: 7594
		[ProtoEnum(Name = "GameFunctionType_HeroComment", Value = 86)]
		GameFunctionType_HeroComment,
		// Token: 0x04001DAB RID: 7595
		[ProtoEnum(Name = "GameFunctionType_RankList", Value = 87)]
		GameFunctionType_RankList,
		// Token: 0x04001DAC RID: 7596
		[ProtoEnum(Name = "GameFunctionType_Redeem", Value = 88)]
		GameFunctionType_Redeem,
		// Token: 0x04001DAD RID: 7597
		[ProtoEnum(Name = "GameFunctionType_RefreshStoreByCrystal", Value = 89)]
		GameFunctionType_RefreshStoreByCrystal,
		// Token: 0x04001DAE RID: 7598
		[ProtoEnum(Name = "GameFunctionType_SummonBroadCast", Value = 90)]
		GameFunctionType_SummonBroadCast,
		// Token: 0x04001DAF RID: 7599
		[ProtoEnum(Name = "GameFunctionType_SendDanmaku", Value = 91)]
		GameFunctionType_SendDanmaku,
		// Token: 0x04001DB0 RID: 7600
		[ProtoEnum(Name = "GameFunctionType_GetDanmaku", Value = 92)]
		GameFunctionType_GetDanmaku,
		// Token: 0x04001DB1 RID: 7601
		[ProtoEnum(Name = "GameFunctionType_PBTCBTFansRewards", Value = 93)]
		GameFunctionType_PBTCBTFansRewards,
		// Token: 0x04001DB2 RID: 7602
		[ProtoEnum(Name = "GameFunctionType_GuildMassiveCombat", Value = 94)]
		GameFunctionType_GuildMassiveCombat
	}
}
