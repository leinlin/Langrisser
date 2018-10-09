using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002CF RID: 719
	[ProtoContract(Name = "ConfigableConstId")]
	public enum ConfigableConstId
	{
		// Token: 0x0400204B RID: 8267
		[ProtoEnum(Name = "ConfigableConstId_Battle_StartDelay", Value = 1)]
		ConfigableConstId_Battle_StartDelay = 1,
		// Token: 0x0400204C RID: 8268
		[ProtoEnum(Name = "ConfigableConstId_Battle_StopDelay", Value = 2)]
		ConfigableConstId_Battle_StopDelay,
		// Token: 0x0400204D RID: 8269
		[ProtoEnum(Name = "ConfigableConstId_Battle_NextTurnTime", Value = 3)]
		ConfigableConstId_Battle_NextTurnTime,
		// Token: 0x0400204E RID: 8270
		[ProtoEnum(Name = "ConfigableConstId_Battle_NextTeamTime", Value = 4)]
		ConfigableConstId_Battle_NextTeamTime,
		// Token: 0x0400204F RID: 8271
		[ProtoEnum(Name = "ConfigableConstId_Battle_NextPlayerTime", Value = 5)]
		ConfigableConstId_Battle_NextPlayerTime,
		// Token: 0x04002050 RID: 8272
		[ProtoEnum(Name = "ConfigableConstId_Combat_StartDelay", Value = 6)]
		ConfigableConstId_Combat_StartDelay,
		// Token: 0x04002051 RID: 8273
		[ProtoEnum(Name = "ConfigableConstId_Combat_StopDelay", Value = 7)]
		ConfigableConstId_Combat_StopDelay,
		// Token: 0x04002052 RID: 8274
		[ProtoEnum(Name = "ConfigableConstId_Combat_HeroDistance", Value = 8)]
		ConfigableConstId_Combat_HeroDistance,
		// Token: 0x04002053 RID: 8275
		[ProtoEnum(Name = "ConfigableConstId_Combat_SplitScreenDistance", Value = 9)]
		ConfigableConstId_Combat_SplitScreenDistance,
		// Token: 0x04002054 RID: 8276
		[ProtoEnum(Name = "ConfigableConstId_Battle_ActorMoveSpeed", Value = 10)]
		ConfigableConstId_Battle_ActorMoveSpeed,
		// Token: 0x04002055 RID: 8277
		[ProtoEnum(Name = "ConfigableConstId_Battle_CameraMoveSpeed", Value = 11)]
		ConfigableConstId_Battle_CameraMoveSpeed,
		// Token: 0x04002056 RID: 8278
		[ProtoEnum(Name = "ConfigableConstId_Battle_CameraSize", Value = 12)]
		ConfigableConstId_Battle_CameraSize,
		// Token: 0x04002057 RID: 8279
		[ProtoEnum(Name = "ConfigableConstId_Battle_CameraSizeMin", Value = 13)]
		ConfigableConstId_Battle_CameraSizeMin,
		// Token: 0x04002058 RID: 8280
		[ProtoEnum(Name = "ConfigableConstId_Battle_CameraSizeMax", Value = 14)]
		ConfigableConstId_Battle_CameraSizeMax,
		// Token: 0x04002059 RID: 8281
		[ProtoEnum(Name = "ConfigableConstId_World_CameraHeight", Value = 15)]
		ConfigableConstId_World_CameraHeight,
		// Token: 0x0400205A RID: 8282
		[ProtoEnum(Name = "ConfigableConstId_World_CameraHeightMin", Value = 16)]
		ConfigableConstId_World_CameraHeightMin,
		// Token: 0x0400205B RID: 8283
		[ProtoEnum(Name = "ConfigableConstId_World_CameraHeightMax", Value = 17)]
		ConfigableConstId_World_CameraHeightMax,
		// Token: 0x0400205C RID: 8284
		[ProtoEnum(Name = "ConfigableConstId_IsSoundOn", Value = 18)]
		ConfigableConstId_IsSoundOn,
		// Token: 0x0400205D RID: 8285
		[ProtoEnum(Name = "ConfigableConstId_IsMusicOn", Value = 19)]
		ConfigableConstId_IsMusicOn,
		// Token: 0x0400205E RID: 8286
		[ProtoEnum(Name = "ConfigableConstId_Battle_SoldierCountMax", Value = 20)]
		ConfigableConstId_Battle_SoldierCountMax,
		// Token: 0x0400205F RID: 8287
		[ProtoEnum(Name = "ConfigableConstId_Combat_SoldierMoveDelay", Value = 21)]
		ConfigableConstId_Combat_SoldierMoveDelay,
		// Token: 0x04002060 RID: 8288
		[ProtoEnum(Name = "ConfigableConstId_Combat_SoldierReturnDelay", Value = 22)]
		ConfigableConstId_Combat_SoldierReturnDelay,
		// Token: 0x04002061 RID: 8289
		[ProtoEnum(Name = "ConfigableConstId_Combat_TimeScale", Value = 23)]
		ConfigableConstId_Combat_TimeScale,
		// Token: 0x04002062 RID: 8290
		[ProtoEnum(Name = "ConfigableConstId_Battle_MeleeATKPunish_Mult", Value = 24)]
		ConfigableConstId_Battle_MeleeATKPunish_Mult,
		// Token: 0x04002063 RID: 8291
		[ProtoEnum(Name = "ConfigableConstId_Combat_HeroDieToPauseTime", Value = 25)]
		ConfigableConstId_Combat_HeroDieToPauseTime,
		// Token: 0x04002064 RID: 8292
		[ProtoEnum(Name = "ConfigableConstId_Combat_HeroDiePauseTime", Value = 26)]
		ConfigableConstId_Combat_HeroDiePauseTime,
		// Token: 0x04002065 RID: 8293
		[ProtoEnum(Name = "ConfigableConstId_Combat_HeroDieSlowMotionTime", Value = 27)]
		ConfigableConstId_Combat_HeroDieSlowMotionTime,
		// Token: 0x04002066 RID: 8294
		[ProtoEnum(Name = "ConfigableConstId_Combat_HeroDieNormalMotionTime", Value = 28)]
		ConfigableConstId_Combat_HeroDieNormalMotionTime,
		// Token: 0x04002067 RID: 8295
		[ProtoEnum(Name = "ConfigableConstId_Combat_HeroDieSlowMotionSpeed", Value = 29)]
		ConfigableConstId_Combat_HeroDieSlowMotionSpeed,
		// Token: 0x04002068 RID: 8296
		[ProtoEnum(Name = "ConfigableConstId_Combat_HitFlashTime", Value = 30)]
		ConfigableConstId_Combat_HitFlashTime,
		// Token: 0x04002069 RID: 8297
		[ProtoEnum(Name = "ConfigableConstId_Combat_HitFlashIntensity", Value = 31)]
		ConfigableConstId_Combat_HitFlashIntensity,
		// Token: 0x0400206A RID: 8298
		[ProtoEnum(Name = "ConfigableConstId_Combat_HitFlashRepeat", Value = 32)]
		ConfigableConstId_Combat_HitFlashRepeat,
		// Token: 0x0400206B RID: 8299
		[ProtoEnum(Name = "ConfigableConstId_Combat_ChargeGhostCount", Value = 33)]
		ConfigableConstId_Combat_ChargeGhostCount,
		// Token: 0x0400206C RID: 8300
		[ProtoEnum(Name = "ConfigableConstId_Combat_ChargeGhostDistance", Value = 34)]
		ConfigableConstId_Combat_ChargeGhostDistance,
		// Token: 0x0400206D RID: 8301
		[ProtoEnum(Name = "ConfigableConstId_Combat_ChargeGhostFadeOut", Value = 35)]
		ConfigableConstId_Combat_ChargeGhostFadeOut,
		// Token: 0x0400206E RID: 8302
		[ProtoEnum(Name = "ConfigableConstId_Battle_SkillPauseTime", Value = 36)]
		ConfigableConstId_Battle_SkillPauseTime,
		// Token: 0x0400206F RID: 8303
		[ProtoEnum(Name = "ConfigableConstId_Battle_SkillPreCastDelay", Value = 37)]
		ConfigableConstId_Battle_SkillPreCastDelay,
		// Token: 0x04002070 RID: 8304
		[ProtoEnum(Name = "ConfigableConstId_Battle_DamagePostDelay", Value = 38)]
		ConfigableConstId_Battle_DamagePostDelay,
		// Token: 0x04002071 RID: 8305
		[ProtoEnum(Name = "ConfigableConstId_Battle_BuffHitPostDelay", Value = 39)]
		ConfigableConstId_Battle_BuffHitPostDelay,
		// Token: 0x04002072 RID: 8306
		[ProtoEnum(Name = "ConfigableConstId_Combat_HPBarFxAccumulateTime", Value = 40)]
		ConfigableConstId_Combat_HPBarFxAccumulateTime,
		// Token: 0x04002073 RID: 8307
		[ProtoEnum(Name = "ConfigableConstId_Combat_HPBarFxAccumulateDamage", Value = 41)]
		ConfigableConstId_Combat_HPBarFxAccumulateDamage,
		// Token: 0x04002074 RID: 8308
		[ProtoEnum(Name = "ConfigableConstId_RageEndTurn_INI", Value = 42)]
		ConfigableConstId_RageEndTurn_INI,
		// Token: 0x04002075 RID: 8309
		[ProtoEnum(Name = "ConfigableConstId_RageBeAttack_INI", Value = 43)]
		ConfigableConstId_RageBeAttack_INI,
		// Token: 0x04002076 RID: 8310
		[ProtoEnum(Name = "ConfigableConstId_RageKill_INI", Value = 44)]
		ConfigableConstId_RageKill_INI,
		// Token: 0x04002077 RID: 8311
		[ProtoEnum(Name = "ConfigableConstId_FlushTime", Value = 45)]
		ConfigableConstId_FlushTime,
		// Token: 0x04002078 RID: 8312
		[ProtoEnum(Name = "ConfigableConstId_FlushPeriodDay", Value = 46)]
		ConfigableConstId_FlushPeriodDay,
		// Token: 0x04002079 RID: 8313
		[ProtoEnum(Name = "ConfigableConstId_TimeEventStartTime", Value = 47)]
		ConfigableConstId_TimeEventStartTime,
		// Token: 0x0400207A RID: 8314
		[ProtoEnum(Name = "ConfigableConstId_TimeEventEndTime", Value = 48)]
		ConfigableConstId_TimeEventEndTime,
		// Token: 0x0400207B RID: 8315
		[ProtoEnum(Name = "ConfigableConstId_TimeEventMinCount", Value = 49)]
		ConfigableConstId_TimeEventMinCount,
		// Token: 0x0400207C RID: 8316
		[ProtoEnum(Name = "ConfigableConstId_TimeEventMaxCount", Value = 50)]
		ConfigableConstId_TimeEventMaxCount,
		// Token: 0x0400207D RID: 8317
		[ProtoEnum(Name = "ConfigableConstId_RiftLevelActionEventProbality", Value = 51)]
		ConfigableConstId_RiftLevelActionEventProbality,
		// Token: 0x0400207E RID: 8318
		[ProtoEnum(Name = "ConfigableConstId_ScenarioActionEventProbality", Value = 52)]
		ConfigableConstId_ScenarioActionEventProbality,
		// Token: 0x0400207F RID: 8319
		[ProtoEnum(Name = "ConfigableConstId_EventActionEventProbality", Value = 53)]
		ConfigableConstId_EventActionEventProbality,
		// Token: 0x04002080 RID: 8320
		[ProtoEnum(Name = "ConfigableConstId_ProbalityMax", Value = 54)]
		ConfigableConstId_ProbalityMax,
		// Token: 0x04002081 RID: 8321
		[ProtoEnum(Name = "ConfigableConstId_ActionEventMaxCount", Value = 55)]
		ConfigableConstId_ActionEventMaxCount,
		// Token: 0x04002082 RID: 8322
		[ProtoEnum(Name = "ConfigableConstId_MapRandomEventMaxCount", Value = 56)]
		ConfigableConstId_MapRandomEventMaxCount,
		// Token: 0x04002083 RID: 8323
		[ProtoEnum(Name = "ConfigableConstId_EnergyAddPeriod", Value = 57)]
		ConfigableConstId_EnergyAddPeriod,
		// Token: 0x04002084 RID: 8324
		[ProtoEnum(Name = "ConfigableConstId_EnergyMax", Value = 58)]
		ConfigableConstId_EnergyMax,
		// Token: 0x04002085 RID: 8325
		[ProtoEnum(Name = "ConfigableConstId_BuyEnergyCount", Value = 59)]
		ConfigableConstId_BuyEnergyCount,
		// Token: 0x04002086 RID: 8326
		[ProtoEnum(Name = "ConfigableConstId_BagMaxCapacity", Value = 60)]
		ConfigableConstId_BagMaxCapacity,
		// Token: 0x04002087 RID: 8327
		[ProtoEnum(Name = "ConfigableConstId_HeroJobRankMax", Value = 61)]
		ConfigableConstId_HeroJobRankMax,
		// Token: 0x04002088 RID: 8328
		[ProtoEnum(Name = "ConfigableConstId_HeroLevelUpCeiling", Value = 62)]
		ConfigableConstId_HeroLevelUpCeiling,
		// Token: 0x04002089 RID: 8329
		[ProtoEnum(Name = "ConfigableConstId_SelectSkillsMaxCount", Value = 63)]
		ConfigableConstId_SelectSkillsMaxCount,
		// Token: 0x0400208A RID: 8330
		[ProtoEnum(Name = "ConfigableConstId_BagGridMaxCapacity", Value = 64)]
		ConfigableConstId_BagGridMaxCapacity,
		// Token: 0x0400208B RID: 8331
		[ProtoEnum(Name = "ConfigableConstId_HeroStarLevelMax", Value = 65)]
		ConfigableConstId_HeroStarLevelMax,
		// Token: 0x0400208C RID: 8332
		[ProtoEnum(Name = "ConfigableConstId_RiftLevelMaxStar", Value = 66)]
		ConfigableConstId_RiftLevelMaxStar,
		// Token: 0x0400208D RID: 8333
		[ProtoEnum(Name = "ConfigableConstId_JobStartLevel", Value = 67)]
		ConfigableConstId_JobStartLevel,
		// Token: 0x0400208E RID: 8334
		[ProtoEnum(Name = "ConfigableConstId_FirstScenarioId", Value = 68)]
		ConfigableConstId_FirstScenarioId,
		// Token: 0x0400208F RID: 8335
		[ProtoEnum(Name = "ConfigableConstId_FirstWayPointId", Value = 69)]
		ConfigableConstId_FirstWayPointId,
		// Token: 0x04002090 RID: 8336
		[ProtoEnum(Name = "ConfigableConstId_MailBoxMaxSize", Value = 70)]
		ConfigableConstId_MailBoxMaxSize,
		// Token: 0x04002091 RID: 8337
		[ProtoEnum(Name = "ConfigableConstId_FirstInitId", Value = 71)]
		ConfigableConstId_FirstInitId,
		// Token: 0x04002092 RID: 8338
		[ProtoEnum(Name = "ConfigableConstId_UnLockRandomEventPlayerLevel", Value = 72)]
		ConfigableConstId_UnLockRandomEventPlayerLevel,
		// Token: 0x04002093 RID: 8339
		[ProtoEnum(Name = "ConfigableConstId_UnLockRandomEventSecnarioId", Value = 73)]
		ConfigableConstId_UnLockRandomEventSecnarioId,
		// Token: 0x04002094 RID: 8340
		[ProtoEnum(Name = "ConfigableConstId_ChatMessageMaxLength", Value = 74)]
		ConfigableConstId_ChatMessageMaxLength,
		// Token: 0x04002095 RID: 8341
		[ProtoEnum(Name = "ConfigableConstId_WorldChatIntervalTime", Value = 75)]
		ConfigableConstId_WorldChatIntervalTime,
		// Token: 0x04002096 RID: 8342
		[ProtoEnum(Name = "ConfigableConstId_AllowChatPlayerLevel", Value = 76)]
		ConfigableConstId_AllowChatPlayerLevel,
		// Token: 0x04002097 RID: 8343
		[ProtoEnum(Name = "ConfigableConstId_SystemSelectCardHeroBroadcast", Value = 77)]
		ConfigableConstId_SystemSelectCardHeroBroadcast,
		// Token: 0x04002098 RID: 8344
		[ProtoEnum(Name = "ConfigableConstId_MagicStoneId", Value = 78)]
		ConfigableConstId_MagicStoneId,
		// Token: 0x04002099 RID: 8345
		[ProtoEnum(Name = "ConfigableConstId_HeroCommentMaxLength", Value = 79)]
		ConfigableConstId_HeroCommentMaxLength,
		// Token: 0x0400209A RID: 8346
		[ProtoEnum(Name = "ConfigableConstId_HeroCommentMaxNums", Value = 80)]
		ConfigableConstId_HeroCommentMaxNums,
		// Token: 0x0400209B RID: 8347
		[ProtoEnum(Name = "ConfigableConstId_PlayerSingleHeroCommentMaxNums", Value = 81)]
		ConfigableConstId_PlayerSingleHeroCommentMaxNums,
		// Token: 0x0400209C RID: 8348
		[ProtoEnum(Name = "ConfigableConstId_MaxPopularCommentEntry", Value = 82)]
		ConfigableConstId_MaxPopularCommentEntry,
		// Token: 0x0400209D RID: 8349
		[ProtoEnum(Name = "ConfigableConstId_AllowArenaPlayerLevel", Value = 83)]
		ConfigableConstId_AllowArenaPlayerLevel,
		// Token: 0x0400209E RID: 8350
		[ProtoEnum(Name = "ConfigableConstId_ArenaGivenTicketMaxNums", Value = 84)]
		ConfigableConstId_ArenaGivenTicketMaxNums,
		// Token: 0x0400209F RID: 8351
		[ProtoEnum(Name = "ConfigableConstId_ArenaFindOpponentExpandPecent", Value = 85)]
		ConfigableConstId_ArenaFindOpponentExpandPecent,
		// Token: 0x040020A0 RID: 8352
		[ProtoEnum(Name = "ConfigableConstId_ArenaDowngradeMinAttackVictoriesNums", Value = 86)]
		ConfigableConstId_ArenaDowngradeMinAttackVictoriesNums,
		// Token: 0x040020A1 RID: 8353
		[ProtoEnum(Name = "ConfigableConstId_LevelRaidTicketID", Value = 87)]
		ConfigableConstId_LevelRaidTicketID,
		// Token: 0x040020A2 RID: 8354
		[ProtoEnum(Name = "ConfigableConstId_ArenaFightExpiredTimeInterval", Value = 88)]
		ConfigableConstId_ArenaFightExpiredTimeInterval,
		// Token: 0x040020A3 RID: 8355
		[ProtoEnum(Name = "ConfigableConstId_ProtagonistHeroID", Value = 89)]
		ConfigableConstId_ProtagonistHeroID,
		// Token: 0x040020A4 RID: 8356
		[ProtoEnum(Name = "ConfigableConstId_PlayerNameMaxLength", Value = 90)]
		ConfigableConstId_PlayerNameMaxLength,
		// Token: 0x040020A5 RID: 8357
		[ProtoEnum(Name = "ConfigableConstId_ArenaTopRankPlayerNums", Value = 91)]
		ConfigableConstId_ArenaTopRankPlayerNums,
		// Token: 0x040020A6 RID: 8358
		[ProtoEnum(Name = "ConfigableConstId_ArenaBattleReportMaxNums", Value = 92)]
		ConfigableConstId_ArenaBattleReportMaxNums,
		// Token: 0x040020A7 RID: 8359
		[ProtoEnum(Name = "ConfigableConstId_ArenaSelectGuardDeltaPoints", Value = 93)]
		ConfigableConstId_ArenaSelectGuardDeltaPoints,
		// Token: 0x040020A8 RID: 8360
		[ProtoEnum(Name = "ConfigableConstId_ArenaChallengeGuardWinPoints", Value = 94)]
		ConfigableConstId_ArenaChallengeGuardWinPoints,
		// Token: 0x040020A9 RID: 8361
		[ProtoEnum(Name = "ConfigableConstId_ArenaChallengeGuardLosePoints", Value = 95)]
		ConfigableConstId_ArenaChallengeGuardLosePoints,
		// Token: 0x040020AA RID: 8362
		[ProtoEnum(Name = "ConfigableConstId_ArenaOneTimeGiveTicketsNums", Value = 96)]
		ConfigableConstId_ArenaOneTimeGiveTicketsNums,
		// Token: 0x040020AB RID: 8363
		[ProtoEnum(Name = "ConfigableConstId_ArenaInitialPoints", Value = 97)]
		ConfigableConstId_ArenaInitialPoints,
		// Token: 0x040020AC RID: 8364
		[ProtoEnum(Name = "ConfigableConstId_ArenaOneTimeAttackUseTicketsNums", Value = 98)]
		ConfigableConstId_ArenaOneTimeAttackUseTicketsNums,
		// Token: 0x040020AD RID: 8365
		[ProtoEnum(Name = "ConfigableConstId_ArenaAttackSuccessRandomDropRewardID", Value = 99)]
		ConfigableConstId_ArenaAttackSuccessRandomDropRewardID,
		// Token: 0x040020AE RID: 8366
		[ProtoEnum(Name = "ConfigableConstId_ArenaRealWeekSettleDeltaTime", Value = 100)]
		ConfigableConstId_ArenaRealWeekSettleDeltaTime,
		// Token: 0x040020AF RID: 8367
		[ProtoEnum(Name = "ConfigableConstId_ArenaFindOpponentOneDirectionMaxOpponentNums", Value = 101)]
		ConfigableConstId_ArenaFindOpponentOneDirectionMaxOpponentNums,
		// Token: 0x040020B0 RID: 8368
		[ProtoEnum(Name = "ConfigableConstId_ChangeNameCostNums", Value = 102)]
		ConfigableConstId_ChangeNameCostNums,
		// Token: 0x040020B1 RID: 8369
		[ProtoEnum(Name = "ConfigableConstId_PlayerInitialHeroInteractNums", Value = 103)]
		ConfigableConstId_PlayerInitialHeroInteractNums,
		// Token: 0x040020B2 RID: 8370
		[ProtoEnum(Name = "ConfigableConstId_HeroInteractNumsRecoveryPeriod", Value = 104)]
		ConfigableConstId_HeroInteractNumsRecoveryPeriod,
		// Token: 0x040020B3 RID: 8371
		[ProtoEnum(Name = "ConfigableConstId_HeroIteractMaxNums", Value = 105)]
		ConfigableConstId_HeroIteractMaxNums,
		// Token: 0x040020B4 RID: 8372
		[ProtoEnum(Name = "ConfigableConstId_HeroIntimateMaxValue", Value = 106)]
		ConfigableConstId_HeroIntimateMaxValue,
		// Token: 0x040020B5 RID: 8373
		[ProtoEnum(Name = "ConfigableConstId_EnhanceEquipmentConsumeGoldPerExp", Value = 107)]
		ConfigableConstId_EnhanceEquipmentConsumeGoldPerExp,
		// Token: 0x040020B6 RID: 8374
		[ProtoEnum(Name = "ConfigableConstId_LevelUpEquipmentStarConsumeGoldPerStar", Value = 108)]
		ConfigableConstId_LevelUpEquipmentStarConsumeGoldPerStar,
		// Token: 0x040020B7 RID: 8375
		[ProtoEnum(Name = "ConfigableConstId_BuyArenaTicketCount", Value = 109)]
		ConfigableConstId_BuyArenaTicketCount,
		// Token: 0x040020B8 RID: 8376
		[ProtoEnum(Name = "ConfigableConstId_ArenaPointsParameter", Value = 110)]
		ConfigableConstId_ArenaPointsParameter,
		// Token: 0x040020B9 RID: 8377
		[ProtoEnum(Name = "ConfigableConstId_HeroDungeonLevelMaxStar", Value = 111)]
		ConfigableConstId_HeroDungeonLevelMaxStar,
		// Token: 0x040020BA RID: 8378
		[ProtoEnum(Name = "ConfigableConstId_ArenaAddHeroExp", Value = 112)]
		ConfigableConstId_ArenaAddHeroExp,
		// Token: 0x040020BB RID: 8379
		[ProtoEnum(Name = "ConfigableConstId_ArenaAddPlayerExp", Value = 113)]
		ConfigableConstId_ArenaAddPlayerExp,
		// Token: 0x040020BC RID: 8380
		[ProtoEnum(Name = "ConfigableConstId_OpenUILoadingFadeoutTime", Value = 114)]
		ConfigableConstId_OpenUILoadingFadeoutTime,
		// Token: 0x040020BD RID: 8381
		[ProtoEnum(Name = "ConfigableConstId_OpenUILoadingFadeinTime", Value = 115)]
		ConfigableConstId_OpenUILoadingFadeinTime,
		// Token: 0x040020BE RID: 8382
		[ProtoEnum(Name = "ConfigableConstId_SystemSelectCardEquipmentBroadcast", Value = 116)]
		ConfigableConstId_SystemSelectCardEquipmentBroadcast,
		// Token: 0x040020BF RID: 8383
		[ProtoEnum(Name = "ConfigableConstId_GoldRank", Value = 117)]
		ConfigableConstId_GoldRank,
		// Token: 0x040020C0 RID: 8384
		[ProtoEnum(Name = "ConfigableConstId_CrystalRank", Value = 118)]
		ConfigableConstId_CrystalRank,
		// Token: 0x040020C1 RID: 8385
		[ProtoEnum(Name = "ConfigableConstId_ArenaHonourRank", Value = 119)]
		ConfigableConstId_ArenaHonourRank,
		// Token: 0x040020C2 RID: 8386
		[ProtoEnum(Name = "ConfigableConstId_UserGuideSelectCardGotHeroId", Value = 120)]
		ConfigableConstId_UserGuideSelectCardGotHeroId,
		// Token: 0x040020C3 RID: 8387
		[ProtoEnum(Name = "ConfigableConstId_EnergyRank", Value = 121)]
		ConfigableConstId_EnergyRank,
		// Token: 0x040020C4 RID: 8388
		[ProtoEnum(Name = "ConfigableConstId_PlayerTeleportDistance", Value = 122)]
		ConfigableConstId_PlayerTeleportDistance,
		// Token: 0x040020C5 RID: 8389
		[ProtoEnum(Name = "ConfigableConstId_PlayerExpRank", Value = 123)]
		ConfigableConstId_PlayerExpRank,
		// Token: 0x040020C6 RID: 8390
		[ProtoEnum(Name = "ConfigableConstId_UserGuideRandomEventId", Value = 124)]
		ConfigableConstId_UserGuideRandomEventId,
		// Token: 0x040020C7 RID: 8391
		[ProtoEnum(Name = "ConfigableConstId_FirstBattleID", Value = 125)]
		ConfigableConstId_FirstBattleID,
		// Token: 0x040020C8 RID: 8392
		[ProtoEnum(Name = "ConfigableConstId_IsVoiceOn", Value = 126)]
		ConfigableConstId_IsVoiceOn,
		// Token: 0x040020C9 RID: 8393
		[ProtoEnum(Name = "ConfigableConstId_ArenaTicketRank", Value = 127)]
		ConfigableConstId_ArenaTicketRank,
		// Token: 0x040020CA RID: 8394
		[ProtoEnum(Name = "ConfigableConstId_ArenaDowngradeMinLevelId", Value = 128)]
		ConfigableConstId_ArenaDowngradeMinLevelId,
		// Token: 0x040020CB RID: 8395
		[ProtoEnum(Name = "ConfigableConstId_ArenaGuardMinLevelId", Value = 129)]
		ConfigableConstId_ArenaGuardMinLevelId,
		// Token: 0x040020CC RID: 8396
		[ProtoEnum(Name = "ConfigableConstId_WriteSurveyPlayerLevel", Value = 130)]
		ConfigableConstId_WriteSurveyPlayerLevel,
		// Token: 0x040020CD RID: 8397
		[ProtoEnum(Name = "ConfigableConstId_AutoEquipmentDeltaTime", Value = 131)]
		ConfigableConstId_AutoEquipmentDeltaTime,
		// Token: 0x040020CE RID: 8398
		[ProtoEnum(Name = "ConfigableConstId_MaxLevelDanmakuEntryLength", Value = 132)]
		ConfigableConstId_MaxLevelDanmakuEntryLength,
		// Token: 0x040020CF RID: 8399
		[ProtoEnum(Name = "ConfigableConstId_MaxLevelDanmakuEntryNumsPerTurn", Value = 133)]
		ConfigableConstId_MaxLevelDanmakuEntryNumsPerTurn,
		// Token: 0x040020D0 RID: 8400
		[ProtoEnum(Name = "ConfigableConstId_DanmakuIntervalTime", Value = 134)]
		ConfigableConstId_DanmakuIntervalTime,
		// Token: 0x040020D1 RID: 8401
		[ProtoEnum(Name = "ConfigableConstId_DanmakuMoveSpeedMax", Value = 135)]
		ConfigableConstId_DanmakuMoveSpeedMax,
		// Token: 0x040020D2 RID: 8402
		[ProtoEnum(Name = "ConfigableConstId_DanmakuMoveSpeedMin", Value = 136)]
		ConfigableConstId_DanmakuMoveSpeedMin,
		// Token: 0x040020D3 RID: 8403
		[ProtoEnum(Name = "ConfigableConstId_GuaranteedAccumulatedValueResetHeroRank", Value = 137)]
		ConfigableConstId_GuaranteedAccumulatedValueResetHeroRank,
		// Token: 0x040020D4 RID: 8404
		[ProtoEnum(Name = "ConfigableConstId_ArenaDefenderBehaviorID", Value = 138)]
		ConfigableConstId_ArenaDefenderBehaviorID,
		// Token: 0x040020D5 RID: 8405
		[ProtoEnum(Name = "ConfigableConstId_ArenaDefenderGroupBehaviorID", Value = 139)]
		ConfigableConstId_ArenaDefenderGroupBehaviorID,
		// Token: 0x040020D6 RID: 8406
		[ProtoEnum(Name = "ConfigableConstId_MovePixelToSliderRatio", Value = 140)]
		ConfigableConstId_MovePixelToSliderRatio,
		// Token: 0x040020D7 RID: 8407
		[ProtoEnum(Name = "ConfigableConstId_PublicTeamRoomLeaderKickOutDeltaTime", Value = 141)]
		ConfigableConstId_PublicTeamRoomLeaderKickOutDeltaTime,
		// Token: 0x040020D8 RID: 8408
		[ProtoEnum(Name = "ConfigableConstId_NonPublicTeamRoomLeaderKickOutDeltaTime", Value = 142)]
		ConfigableConstId_NonPublicTeamRoomLeaderKickOutDeltaTime,
		// Token: 0x040020D9 RID: 8409
		[ProtoEnum(Name = "ConfigableConstId_ViewTeamRoomMaxNums", Value = 143)]
		ConfigableConstId_ViewTeamRoomMaxNums,
		// Token: 0x040020DA RID: 8410
		[ProtoEnum(Name = "ConfigableConstId_GlobalRankingListOpenPlayerLevel", Value = 144)]
		ConfigableConstId_GlobalRankingListOpenPlayerLevel,
		// Token: 0x040020DB RID: 8411
		[ProtoEnum(Name = "ConfigableConstId_HeroRankingListOpenHeroLevel", Value = 145)]
		ConfigableConstId_HeroRankingListOpenHeroLevel,
		// Token: 0x040020DC RID: 8412
		[ProtoEnum(Name = "ConfigableConstId_TeamRoomInviteDeltaTime", Value = 146)]
		ConfigableConstId_TeamRoomInviteDeltaTime,
		// Token: 0x040020DD RID: 8413
		[ProtoEnum(Name = "ConfigableConstId_BusinessCardDescMaxLength", Value = 147)]
		ConfigableConstId_BusinessCardDescMaxLength,
		// Token: 0x040020DE RID: 8414
		[ProtoEnum(Name = "ConfigableConstId_BusinessCardHeroMaxNums", Value = 148)]
		ConfigableConstId_BusinessCardHeroMaxNums,
		// Token: 0x040020DF RID: 8415
		[ProtoEnum(Name = "ConfigableConstId_SendFriendShipPointsEverytime", Value = 149)]
		ConfigableConstId_SendFriendShipPointsEverytime,
		// Token: 0x040020E0 RID: 8416
		[ProtoEnum(Name = "ConfigableConstId_SendFriendShipPointsMaxTimes", Value = 150)]
		ConfigableConstId_SendFriendShipPointsMaxTimes,
		// Token: 0x040020E1 RID: 8417
		[ProtoEnum(Name = "ConfigableConstId_ReceiveFriendShipPointsMaxTimes", Value = 151)]
		ConfigableConstId_ReceiveFriendShipPointsMaxTimes,
		// Token: 0x040020E2 RID: 8418
		[ProtoEnum(Name = "ConfigableConstId_PixelIntervalForVoice", Value = 152)]
		ConfigableConstId_PixelIntervalForVoice,
		// Token: 0x040020E3 RID: 8419
		[ProtoEnum(Name = "ConfigableConstId_SearchUserByNameResultMax", Value = 153)]
		ConfigableConstId_SearchUserByNameResultMax,
		// Token: 0x040020E4 RID: 8420
		[ProtoEnum(Name = "ConfigableConstId_MaxDomesticFriends", Value = 154)]
		ConfigableConstId_MaxDomesticFriends,
		// Token: 0x040020E5 RID: 8421
		[ProtoEnum(Name = "ConfigableConstId_MaxForeignFriends", Value = 155)]
		ConfigableConstId_MaxForeignFriends,
		// Token: 0x040020E6 RID: 8422
		[ProtoEnum(Name = "ConfigableConstId_MaxBlacklist", Value = 156)]
		ConfigableConstId_MaxBlacklist,
		// Token: 0x040020E7 RID: 8423
		[ProtoEnum(Name = "ConfigableConstId_MaxInvites", Value = 157)]
		ConfigableConstId_MaxInvites,
		// Token: 0x040020E8 RID: 8424
		[ProtoEnum(Name = "ConfigableConstId_MaxSuggestedUsers", Value = 158)]
		ConfigableConstId_MaxSuggestedUsers,
		// Token: 0x040020E9 RID: 8425
		[ProtoEnum(Name = "ConfigableConstId_SuggestedUserLevelDiff", Value = 159)]
		ConfigableConstId_SuggestedUserLevelDiff,
		// Token: 0x040020EA RID: 8426
		[ProtoEnum(Name = "ConfigableConstId_MaxLevelDiffMultiply", Value = 160)]
		ConfigableConstId_MaxLevelDiffMultiply,
		// Token: 0x040020EB RID: 8427
		[ProtoEnum(Name = "ConfigableConstId_InviteExpireSeconds", Value = 161)]
		ConfigableConstId_InviteExpireSeconds,
		// Token: 0x040020EC RID: 8428
		[ProtoEnum(Name = "ConfigableConstId_RecentContactsMaxCount", Value = 162)]
		ConfigableConstId_RecentContactsMaxCount,
		// Token: 0x040020ED RID: 8429
		[ProtoEnum(Name = "ConfigableConstId_HeroAssistantTaskHeroAssignMaxCount", Value = 163)]
		ConfigableConstId_HeroAssistantTaskHeroAssignMaxCount,
		// Token: 0x040020EE RID: 8430
		[ProtoEnum(Name = "ConfigableConstId_BattleRoomReadyTimeOutTime", Value = 164)]
		ConfigableConstId_BattleRoomReadyTimeOutTime,
		// Token: 0x040020EF RID: 8431
		[ProtoEnum(Name = "ConfigableConstId_MaxGroupsPerUser", Value = 165)]
		ConfigableConstId_MaxGroupsPerUser,
		// Token: 0x040020F0 RID: 8432
		[ProtoEnum(Name = "ConfigableConstId_MaxGroupMembers", Value = 166)]
		ConfigableConstId_MaxGroupMembers,
		// Token: 0x040020F1 RID: 8433
		[ProtoEnum(Name = "ConfigableConstId_BattleInviteFriendsToPracticeMaxWaitInterval", Value = 167)]
		ConfigableConstId_BattleInviteFriendsToPracticeMaxWaitInterval,
		// Token: 0x040020F2 RID: 8434
		[ProtoEnum(Name = "ConfigableConstId_DecomposeEquipmentBackGoldPercent", Value = 168)]
		ConfigableConstId_DecomposeEquipmentBackGoldPercent,
		// Token: 0x040020F3 RID: 8435
		[ProtoEnum(Name = "ConfigableConstId_DayBonusNum_Aniki", Value = 169)]
		ConfigableConstId_DayBonusNum_Aniki,
		// Token: 0x040020F4 RID: 8436
		[ProtoEnum(Name = "ConfigableConstId_DayBonusNum_ThearchyTrial", Value = 170)]
		ConfigableConstId_DayBonusNum_ThearchyTrial,
		// Token: 0x040020F5 RID: 8437
		[ProtoEnum(Name = "ConfigableConstId_DayBonusNum_HeroTrain", Value = 171)]
		ConfigableConstId_DayBonusNum_HeroTrain,
		// Token: 0x040020F6 RID: 8438
		[ProtoEnum(Name = "ConfigableConstId_DayBonusNum_MemoryCorridor", Value = 172)]
		ConfigableConstId_DayBonusNum_MemoryCorridor,
		// Token: 0x040020F7 RID: 8439
		[ProtoEnum(Name = "ConfigableConstId_DayBonusNum_Crusade", Value = 173)]
		ConfigableConstId_DayBonusNum_Crusade,
		// Token: 0x040020F8 RID: 8440
		[ProtoEnum(Name = "ConfigableConstId_AlchemyMaxNum", Value = 174)]
		ConfigableConstId_AlchemyMaxNum,
		// Token: 0x040020F9 RID: 8441
		[ProtoEnum(Name = "ConfigableConstId_FriendPointsFightWithFriends", Value = 175)]
		ConfigableConstId_FriendPointsFightWithFriends,
		// Token: 0x040020FA RID: 8442
		[ProtoEnum(Name = "ConfigableConstId_MaxFriendPointsFightWithFriendsEveryday", Value = 176)]
		ConfigableConstId_MaxFriendPointsFightWithFriendsEveryday,
		// Token: 0x040020FB RID: 8443
		[ProtoEnum(Name = "ConfigableConstId_BattleRoomPlayerReconnectTimeOutTime", Value = 177)]
		ConfigableConstId_BattleRoomPlayerReconnectTimeOutTime,
		// Token: 0x040020FC RID: 8444
		[ProtoEnum(Name = "ConfigableConstId_TeamBattleRoomPlayerActionClientTimeOutTime", Value = 178)]
		ConfigableConstId_TeamBattleRoomPlayerActionClientTimeOutTime,
		// Token: 0x040020FD RID: 8445
		[ProtoEnum(Name = "ConfigableConstId_PVPBattleRoomPlayerActionClientTimeOutTime", Value = 179)]
		ConfigableConstId_PVPBattleRoomPlayerActionClientTimeOutTime,
		// Token: 0x040020FE RID: 8446
		[ProtoEnum(Name = "ConfigableConstId_TeamBattleRoomPlayerActionServerTimeOutTime", Value = 180)]
		ConfigableConstId_TeamBattleRoomPlayerActionServerTimeOutTime,
		// Token: 0x040020FF RID: 8447
		[ProtoEnum(Name = "ConfigableConstId_PVPBattleRoomPlayerActionServerTimeOutTime", Value = 181)]
		ConfigableConstId_PVPBattleRoomPlayerActionServerTimeOutTime,
		// Token: 0x04002100 RID: 8448
		[ProtoEnum(Name = "ConfigableConstId_ChatVoiceToTextTimeOutTime", Value = 182)]
		ConfigableConstId_ChatVoiceToTextTimeOutTime,
		// Token: 0x04002101 RID: 8449
		[ProtoEnum(Name = "ConfigableConstId_TeamFriendShipPointRewardPerFriend", Value = 183)]
		ConfigableConstId_TeamFriendShipPointRewardPerFriend,
		// Token: 0x04002102 RID: 8450
		[ProtoEnum(Name = "ConfigableConstId_MaxEnchantSamePropertyNums", Value = 184)]
		ConfigableConstId_MaxEnchantSamePropertyNums,
		// Token: 0x04002103 RID: 8451
		[ProtoEnum(Name = "ConfigableConstId_ChatHistoryRecordStoreTimeLimit", Value = 185)]
		ConfigableConstId_ChatHistoryRecordStoreTimeLimit,
		// Token: 0x04002104 RID: 8452
		[ProtoEnum(Name = "ConfigableConstId_ChatHistoryRecordStoreMessageLengthLimit", Value = 186)]
		ConfigableConstId_ChatHistoryRecordStoreMessageLengthLimit,
		// Token: 0x04002105 RID: 8453
		[ProtoEnum(Name = "ConfigableConstId_ChatHistoryRecordSaveMessageLengthOnClear", Value = 187)]
		ConfigableConstId_ChatHistoryRecordSaveMessageLengthOnClear,
		// Token: 0x04002106 RID: 8454
		[ProtoEnum(Name = "ConfigableConstId_ChatPrivateChatRecentLinkPlayerCountLimit", Value = 188)]
		ConfigableConstId_ChatPrivateChatRecentLinkPlayerCountLimit,
		// Token: 0x04002107 RID: 8455
		[ProtoEnum(Name = "ConfigableConstId_ChatPrivateChatRecentLinkGroupCountLimit", Value = 189)]
		ConfigableConstId_ChatPrivateChatRecentLinkGroupCountLimit,
		// Token: 0x04002108 RID: 8456
		[ProtoEnum(Name = "ConfigableConstId_TeamInvitationTimeoutTime", Value = 190)]
		ConfigableConstId_TeamInvitationTimeoutTime,
		// Token: 0x04002109 RID: 8457
		[ProtoEnum(Name = "ConfigableConstId_RecentContactsChatMaxCount", Value = 191)]
		ConfigableConstId_RecentContactsChatMaxCount,
		// Token: 0x0400210A RID: 8458
		[ProtoEnum(Name = "ConfigableConstId_RecentContactsTeamBattleMaxCount", Value = 192)]
		ConfigableConstId_RecentContactsTeamBattleMaxCount,
		// Token: 0x0400210B RID: 8459
		[ProtoEnum(Name = "ConfigableConstId_DayBonusNum_CooperateBattle", Value = 193)]
		ConfigableConstId_DayBonusNum_CooperateBattle,
		// Token: 0x0400210C RID: 8460
		[ProtoEnum(Name = "ConfigableConstId_HeroAssistantTaskSlotCount", Value = 194)]
		ConfigableConstId_HeroAssistantTaskSlotCount,
		// Token: 0x0400210D RID: 8461
		[ProtoEnum(Name = "ConfigableConstId_ChatGroupNameMaxLength", Value = 195)]
		ConfigableConstId_ChatGroupNameMaxLength,
		// Token: 0x0400210E RID: 8462
		[ProtoEnum(Name = "ConfigableConstId_FirstBattleUserGuideID", Value = 196)]
		ConfigableConstId_FirstBattleUserGuideID,
		// Token: 0x0400210F RID: 8463
		[ProtoEnum(Name = "ConfigableConstId_TeamChatBubbleStayTime", Value = 197)]
		ConfigableConstId_TeamChatBubbleStayTime,
		// Token: 0x04002110 RID: 8464
		[ProtoEnum(Name = "ConfigableConstId_ChatGroupCreateMinUserCount", Value = 198)]
		ConfigableConstId_ChatGroupCreateMinUserCount,
		// Token: 0x04002111 RID: 8465
		[ProtoEnum(Name = "ConfigableConstId_ChatGroupDisbandUserCount", Value = 199)]
		ConfigableConstId_ChatGroupDisbandUserCount,
		// Token: 0x04002112 RID: 8466
		[ProtoEnum(Name = "ConfigableConstId_OpenServiceActivityUnlockLevel", Value = 200)]
		ConfigableConstId_OpenServiceActivityUnlockLevel,
		// Token: 0x04002113 RID: 8467
		[ProtoEnum(Name = "ConfigableConstId_UseBoxItemMaxCount", Value = 201)]
		ConfigableConstId_UseBoxItemMaxCount,
		// Token: 0x04002114 RID: 8468
		[ProtoEnum(Name = "ConfigableConstId_ServerTolerateClientSpeedUpMaxNums", Value = 202)]
		ConfigableConstId_ServerTolerateClientSpeedUpMaxNums,
		// Token: 0x04002115 RID: 8469
		[ProtoEnum(Name = "ConfigableConstId_ServerCheckClientHeartBeatReachMinPeriod", Value = 203)]
		ConfigableConstId_ServerCheckClientHeartBeatReachMinPeriod,
		// Token: 0x04002116 RID: 8470
		[ProtoEnum(Name = "ConfigableConstId_ClientSendHeartBeatPeriod", Value = 204)]
		ConfigableConstId_ClientSendHeartBeatPeriod,
		// Token: 0x04002117 RID: 8471
		[ProtoEnum(Name = "ConfigableConstId_DragHeroToBattleUserGuideID", Value = 205)]
		ConfigableConstId_DragHeroToBattleUserGuideID,
		// Token: 0x04002118 RID: 8472
		[ProtoEnum(Name = "ConfigableConstId_FriendshipPointsRank", Value = 206)]
		ConfigableConstId_FriendshipPointsRank,
		// Token: 0x04002119 RID: 8473
		[ProtoEnum(Name = "ConfigableConstId_ClientPauseReloginTimeout", Value = 207)]
		ConfigableConstId_ClientPauseReloginTimeout,
		// Token: 0x0400211A RID: 8474
		[ProtoEnum(Name = "ConfigableConstId_ClientLogFileExpireDays", Value = 208)]
		ConfigableConstId_ClientLogFileExpireDays,
		// Token: 0x0400211B RID: 8475
		[ProtoEnum(Name = "ConfigableConstId_BuffDisplayTime", Value = 209)]
		ConfigableConstId_BuffDisplayTime,
		// Token: 0x0400211C RID: 8476
		[ProtoEnum(Name = "ConfigableConstId_TeamRoomInviteeLevelInfoGetTime", Value = 210)]
		ConfigableConstId_TeamRoomInviteeLevelInfoGetTime,
		// Token: 0x0400211D RID: 8477
		[ProtoEnum(Name = "ConfigableConstId_ArenaNewbiePoints", Value = 211)]
		ConfigableConstId_ArenaNewbiePoints,
		// Token: 0x0400211E RID: 8478
		[ProtoEnum(Name = "ConfigableConstId_ArenaFindingOpponentDeltaLevel", Value = 212)]
		ConfigableConstId_ArenaFindingOpponentDeltaLevel,
		// Token: 0x0400211F RID: 8479
		[ProtoEnum(Name = "ConfigableConstId_ArenaFlushOpponentDeltaTime", Value = 213)]
		ConfigableConstId_ArenaFlushOpponentDeltaTime,
		// Token: 0x04002120 RID: 8480
		[ProtoEnum(Name = "ConfigableConstId_BattleRegretCountMax", Value = 214)]
		ConfigableConstId_BattleRegretCountMax,
		// Token: 0x04002121 RID: 8481
		[ProtoEnum(Name = "ConfigableConstId_ChatRoomPlayerMaxNums", Value = 215)]
		ConfigableConstId_ChatRoomPlayerMaxNums,
		// Token: 0x04002122 RID: 8482
		[ProtoEnum(Name = "ConfigableConstId_ArenaLevelMaxPoints", Value = 216)]
		ConfigableConstId_ArenaLevelMaxPoints,
		// Token: 0x04002123 RID: 8483
		[ProtoEnum(Name = "ConfigableConstId_DefaultHeadFrameId", Value = 217)]
		ConfigableConstId_DefaultHeadFrameId,
		// Token: 0x04002124 RID: 8484
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPInitialScore", Value = 218)]
		ConfigableConstId_RealTimePVPInitialScore,
		// Token: 0x04002125 RID: 8485
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPMinRequiredLevel", Value = 219)]
		ConfigableConstId_RealTimePVPMinRequiredLevel,
		// Token: 0x04002126 RID: 8486
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverHeroCount_Turn1", Value = 220)]
		ConfigableConstId_RealTimePVPSilverHeroCount_Turn1,
		// Token: 0x04002127 RID: 8487
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverHeroCount_Turn2", Value = 221)]
		ConfigableConstId_RealTimePVPSilverHeroCount_Turn2,
		// Token: 0x04002128 RID: 8488
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverHeroCount_Turn3", Value = 222)]
		ConfigableConstId_RealTimePVPSilverHeroCount_Turn3,
		// Token: 0x04002129 RID: 8489
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverHeroCount_Turn4", Value = 223)]
		ConfigableConstId_RealTimePVPSilverHeroCount_Turn4,
		// Token: 0x0400212A RID: 8490
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverHeroCount_Turn5", Value = 224)]
		ConfigableConstId_RealTimePVPSilverHeroCount_Turn5,
		// Token: 0x0400212B RID: 8491
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverHeroCount_Turn6", Value = 225)]
		ConfigableConstId_RealTimePVPSilverHeroCount_Turn6,
		// Token: 0x0400212C RID: 8492
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn1", Value = 226)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn1,
		// Token: 0x0400212D RID: 8493
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn2", Value = 227)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn2,
		// Token: 0x0400212E RID: 8494
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn3", Value = 228)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn3,
		// Token: 0x0400212F RID: 8495
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn4", Value = 229)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn4,
		// Token: 0x04002130 RID: 8496
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn5", Value = 230)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn5,
		// Token: 0x04002131 RID: 8497
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn6", Value = 231)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn6,
		// Token: 0x04002132 RID: 8498
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldHeroCount_Turn7", Value = 232)]
		ConfigableConstId_RealTimePVPGoldHeroCount_Turn7,
		// Token: 0x04002133 RID: 8499
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldProtectHeroCount", Value = 233)]
		ConfigableConstId_RealTimePVPGoldProtectHeroCount,
		// Token: 0x04002134 RID: 8500
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldBanHeroCount", Value = 234)]
		ConfigableConstId_RealTimePVPGoldBanHeroCount,
		// Token: 0x04002135 RID: 8501
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPTurnInterval", Value = 235)]
		ConfigableConstId_RealTimePVPTurnInterval,
		// Token: 0x04002136 RID: 8502
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSilverCountdown", Value = 236)]
		ConfigableConstId_RealTimePVPSilverCountdown,
		// Token: 0x04002137 RID: 8503
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPGoldCountdown", Value = 237)]
		ConfigableConstId_RealTimePVPGoldCountdown,
		// Token: 0x04002138 RID: 8504
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPBattleStartTime", Value = 238)]
		ConfigableConstId_RealTimePVPBattleStartTime,
		// Token: 0x04002139 RID: 8505
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPMatchmakingExpectedTime", Value = 239)]
		ConfigableConstId_RealTimePVPMatchmakingExpectedTime,
		// Token: 0x0400213A RID: 8506
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPMatchmakingExpectedTimeAdjust", Value = 240)]
		ConfigableConstId_RealTimePVPMatchmakingExpectedTimeAdjust,
		// Token: 0x0400213B RID: 8507
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPTopRankPlayerNums", Value = 241)]
		ConfigableConstId_RealTimePVPTopRankPlayerNums,
		// Token: 0x0400213C RID: 8508
		[ProtoEnum(Name = "ConfigableConstId_RequestAppReviewInScenario", Value = 242)]
		ConfigableConstId_RequestAppReviewInScenario,
		// Token: 0x0400213D RID: 8509
		[ProtoEnum(Name = "ConfigableConstId_IsRequestAppReviewOn", Value = 243)]
		ConfigableConstId_IsRequestAppReviewOn,
		// Token: 0x0400213E RID: 8510
		[ProtoEnum(Name = "ConfigableConstId_GainMaximum", Value = 244)]
		ConfigableConstId_GainMaximum,
		// Token: 0x0400213F RID: 8511
		[ProtoEnum(Name = "ConfigableConstId_UpdateServerListIntervalSeconds", Value = 245)]
		ConfigableConstId_UpdateServerListIntervalSeconds,
		// Token: 0x04002140 RID: 8512
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPPromotionSucceedScoreBonus", Value = 246)]
		ConfigableConstId_RealTimePVPPromotionSucceedScoreBonus,
		// Token: 0x04002141 RID: 8513
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPPromotionFailedScorePenalty", Value = 247)]
		ConfigableConstId_RealTimePVPPromotionFailedScorePenalty,
		// Token: 0x04002142 RID: 8514
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPScoreMax", Value = 248)]
		ConfigableConstId_RealTimePVPScoreMax,
		// Token: 0x04002143 RID: 8515
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPBattleCameraSize", Value = 249)]
		ConfigableConstId_RealTimePVPBattleCameraSize,
		// Token: 0x04002144 RID: 8516
		[ProtoEnum(Name = "ConfigableConstId_SkinTicketRank", Value = 250)]
		ConfigableConstId_SkinTicketRank,
		// Token: 0x04002145 RID: 8517
		[ProtoEnum(Name = "ConfigableConstId_UnLockJobUpTipScenarioId", Value = 251)]
		ConfigableConstId_UnLockJobUpTipScenarioId,
		// Token: 0x04002146 RID: 8518
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPAvailableTime", Value = 252)]
		ConfigableConstId_RealTimePVPAvailableTime,
		// Token: 0x04002147 RID: 8519
		[ProtoEnum(Name = "ConfigableConstId_PrivilegeItemRank", Value = 253)]
		ConfigableConstId_PrivilegeItemRank,
		// Token: 0x04002148 RID: 8520
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPBotPlayDeadIntervalMin", Value = 254)]
		ConfigableConstId_RealTimePVPBotPlayDeadIntervalMin,
		// Token: 0x04002149 RID: 8521
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPBotPlayDeadIntervalMax", Value = 255)]
		ConfigableConstId_RealTimePVPBotPlayDeadIntervalMax,
		// Token: 0x0400214A RID: 8522
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPBattleReportMaxNums", Value = 256)]
		ConfigableConstId_RealTimePVPBattleReportMaxNums,
		// Token: 0x0400214B RID: 8523
		[ProtoEnum(Name = "ConfigableConstId_Battle_ClientCheckOnlinePeriod", Value = 257)]
		ConfigableConstId_Battle_ClientCheckOnlinePeriod,
		// Token: 0x0400214C RID: 8524
		[ProtoEnum(Name = "ConfigableConstId_BattleRoomPlayerPauseDisconnectTime", Value = 258)]
		ConfigableConstId_BattleRoomPlayerPauseDisconnectTime,
		// Token: 0x0400214D RID: 8525
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVPSystemPlayerCountForNewSeasonAutoGeneration", Value = 259)]
		ConfigableConstId_RealTimePVPSystemPlayerCountForNewSeasonAutoGeneration,
		// Token: 0x0400214E RID: 8526
		[ProtoEnum(Name = "ConfigableConstId_Rift_FirstChapterId", Value = 260)]
		ConfigableConstId_Rift_FirstChapterId,
		// Token: 0x0400214F RID: 8527
		[ProtoEnum(Name = "ConfigableConstId_NewUserAccumulatedMinValue", Value = 261)]
		ConfigableConstId_NewUserAccumulatedMinValue,
		// Token: 0x04002150 RID: 8528
		[ProtoEnum(Name = "ConfigableConstId_NewUserAccumulatedMaxValue", Value = 262)]
		ConfigableConstId_NewUserAccumulatedMaxValue,
		// Token: 0x04002151 RID: 8529
		[ProtoEnum(Name = "ConfigableConstId_OldUserAccumulatedMinValue", Value = 263)]
		ConfigableConstId_OldUserAccumulatedMinValue,
		// Token: 0x04002152 RID: 8530
		[ProtoEnum(Name = "ConfigableConstId_OldUserAccumulatedMaxValue", Value = 264)]
		ConfigableConstId_OldUserAccumulatedMaxValue,
		// Token: 0x04002153 RID: 8531
		[ProtoEnum(Name = "ConfigableConstId_PVPBattleRoomPlayerOfflineAutoBattleTimeOutTime", Value = 265)]
		ConfigableConstId_PVPBattleRoomPlayerOfflineAutoBattleTimeOutTime,
		// Token: 0x04002154 RID: 8532
		[ProtoEnum(Name = "ConfigableConstId_BattleRoomPlayerActionCountdownBigNumberTime", Value = 266)]
		ConfigableConstId_BattleRoomPlayerActionCountdownBigNumberTime,
		// Token: 0x04002155 RID: 8533
		[ProtoEnum(Name = "ConfigableConstId_MemoryEssenceRank", Value = 267)]
		ConfigableConstId_MemoryEssenceRank,
		// Token: 0x04002156 RID: 8534
		[ProtoEnum(Name = "ConfigableConstId_TeamRoomViewRefreshClientTime", Value = 268)]
		ConfigableConstId_TeamRoomViewRefreshClientTime,
		// Token: 0x04002157 RID: 8535
		[ProtoEnum(Name = "ConfigableConstId_GoddessCharImageId", Value = 269)]
		ConfigableConstId_GoddessCharImageId,
		// Token: 0x04002158 RID: 8536
		[ProtoEnum(Name = "ConfigableConstId_GuildCreateJoinLevel", Value = 270)]
		ConfigableConstId_GuildCreateJoinLevel,
		// Token: 0x04002159 RID: 8537
		[ProtoEnum(Name = "ConfigableConstId_GuildCreateItemId", Value = 271)]
		ConfigableConstId_GuildCreateItemId,
		// Token: 0x0400215A RID: 8538
		[ProtoEnum(Name = "ConfigableConstId_GuildMemberCountMax", Value = 272)]
		ConfigableConstId_GuildMemberCountMax,
		// Token: 0x0400215B RID: 8539
		[ProtoEnum(Name = "ConfigableConstId_GuildReJoinCoolDownTime", Value = 273)]
		ConfigableConstId_GuildReJoinCoolDownTime,
		// Token: 0x0400215C RID: 8540
		[ProtoEnum(Name = "ConfigableConstId_GuildJoinApplicationPlayerCountMax", Value = 274)]
		ConfigableConstId_GuildJoinApplicationPlayerCountMax,
		// Token: 0x0400215D RID: 8541
		[ProtoEnum(Name = "ConfigableConstId_GuildInviteCountMax", Value = 275)]
		ConfigableConstId_GuildInviteCountMax,
		// Token: 0x0400215E RID: 8542
		[ProtoEnum(Name = "ConfigableConstId_GuildChatHistoryCount", Value = 276)]
		ConfigableConstId_GuildChatHistoryCount,
		// Token: 0x0400215F RID: 8543
		[ProtoEnum(Name = "ConfigableConstId_GuildHiringDeclarationMaxLength", Value = 277)]
		ConfigableConstId_GuildHiringDeclarationMaxLength,
		// Token: 0x04002160 RID: 8544
		[ProtoEnum(Name = "ConfigableConstId_GuildVicePresidentMaxNums", Value = 278)]
		ConfigableConstId_GuildVicePresidentMaxNums,
		// Token: 0x04002161 RID: 8545
		[ProtoEnum(Name = "ConfigableConstId_GuildEliteMinTotalActivities", Value = 279)]
		ConfigableConstId_GuildEliteMinTotalActivities,
		// Token: 0x04002162 RID: 8546
		[ProtoEnum(Name = "ConfigableConstId_RankListGuildNums", Value = 280)]
		ConfigableConstId_RankListGuildNums,
		// Token: 0x04002163 RID: 8547
		[ProtoEnum(Name = "ConfigableConstId_GuildVicePresidentCanUsurpTime", Value = 281)]
		ConfigableConstId_GuildVicePresidentCanUsurpTime,
		// Token: 0x04002164 RID: 8548
		[ProtoEnum(Name = "ConfigableConstId_GuildEliteCanUsurpTime", Value = 282)]
		ConfigableConstId_GuildEliteCanUsurpTime,
		// Token: 0x04002165 RID: 8549
		[ProtoEnum(Name = "ConfigableConstId_GuildChangeNameCrystalCost", Value = 283)]
		ConfigableConstId_GuildChangeNameCrystalCost,
		// Token: 0x04002166 RID: 8550
		[ProtoEnum(Name = "ConfigableConstId_GuildDailyMaxActivities", Value = 284)]
		ConfigableConstId_GuildDailyMaxActivities,
		// Token: 0x04002167 RID: 8551
		[ProtoEnum(Name = "ConfigableConstId_GuildAnnouncementMaxLength", Value = 285)]
		ConfigableConstId_GuildAnnouncementMaxLength,
		// Token: 0x04002168 RID: 8552
		[ProtoEnum(Name = "ConfigableConstId_GuildWeeklyMaxActivities", Value = 286)]
		ConfigableConstId_GuildWeeklyMaxActivities,
		// Token: 0x04002169 RID: 8553
		[ProtoEnum(Name = "ConfigableConstId_GuildNameMaxLength", Value = 287)]
		ConfigableConstId_GuildNameMaxLength,
		// Token: 0x0400216A RID: 8554
		[ProtoEnum(Name = "ConfigableConstId_GuildLogMaxNUms", Value = 288)]
		ConfigableConstId_GuildLogMaxNUms,
		// Token: 0x0400216B RID: 8555
		[ProtoEnum(Name = "ConfigableConstId_NewUserSecondAccumulatedMinValue", Value = 289)]
		ConfigableConstId_NewUserSecondAccumulatedMinValue,
		// Token: 0x0400216C RID: 8556
		[ProtoEnum(Name = "ConfigableConstId_NewUserSecondAccumulatedMaxValue", Value = 290)]
		ConfigableConstId_NewUserSecondAccumulatedMaxValue,
		// Token: 0x0400216D RID: 8557
		[ProtoEnum(Name = "ConfigableConstId_RealTimePVP_ClientGlobalRankingEnable", Value = 291)]
		ConfigableConstId_RealTimePVP_ClientGlobalRankingEnable,
		// Token: 0x0400216E RID: 8558
		[ProtoEnum(Name = "ConfigableConstId_GenericPauseDisconnectTime", Value = 292)]
		ConfigableConstId_GenericPauseDisconnectTime,
		// Token: 0x0400216F RID: 8559
		[ProtoEnum(Name = "ConfigableConstId_RandomStoreManualFlushMaxNums", Value = 293)]
		ConfigableConstId_RandomStoreManualFlushMaxNums,
		// Token: 0x04002170 RID: 8560
		[ProtoEnum(Name = "ConfigableConstId_AutoClimbFactor", Value = 294)]
		ConfigableConstId_AutoClimbFactor,
		// Token: 0x04002171 RID: 8561
		[ProtoEnum(Name = "ConfigableConstId_AutoClimbMax", Value = 295)]
		ConfigableConstId_AutoClimbMax,
		// Token: 0x04002172 RID: 8562
		[ProtoEnum(Name = "ConfigableConstId_ClimbTowerFloorMax", Value = 296)]
		ConfigableConstId_ClimbTowerFloorMax,
		// Token: 0x04002173 RID: 8563
		[ProtoEnum(Name = "ConfigableConstId_CanAutoClimbTowerHistoryFloorMax", Value = 297)]
		ConfigableConstId_CanAutoClimbTowerHistoryFloorMax,
		// Token: 0x04002174 RID: 8564
		[ProtoEnum(Name = "ConfigableConstId_PrimaryHammer", Value = 298)]
		ConfigableConstId_PrimaryHammer,
		// Token: 0x04002175 RID: 8565
		[ProtoEnum(Name = "ConfigableConstId_MiddleLevelHammer", Value = 299)]
		ConfigableConstId_MiddleLevelHammer,
		// Token: 0x04002176 RID: 8566
		[ProtoEnum(Name = "ConfigableConstId_AdvancedHammer", Value = 300)]
		ConfigableConstId_AdvancedHammer,
		// Token: 0x04002177 RID: 8567
		[ProtoEnum(Name = "ConfigableConstId_SpecialHammer", Value = 301)]
		ConfigableConstId_SpecialHammer,
		// Token: 0x04002178 RID: 8568
		[ProtoEnum(Name = "ConfigableConstId_MithralStoneRank", Value = 302)]
		ConfigableConstId_MithralStoneRank,
		// Token: 0x04002179 RID: 8569
		[ProtoEnum(Name = "ConfigableConstId_BrillianceMithralStoneRank", Value = 303)]
		ConfigableConstId_BrillianceMithralStoneRank,
		// Token: 0x0400217A RID: 8570
		[ProtoEnum(Name = "ConfigableConstId_GuildPresidentRelieveMailTemplateId", Value = 304)]
		ConfigableConstId_GuildPresidentRelieveMailTemplateId,
		// Token: 0x0400217B RID: 8571
		[ProtoEnum(Name = "ConfigableConstId_HeroDungeonDailyChallengeMaxNums", Value = 305)]
		ConfigableConstId_HeroDungeonDailyChallengeMaxNums,
		// Token: 0x0400217C RID: 8572
		[ProtoEnum(Name = "ConfigableConstId_Battle_CriticalDamage_Base", Value = 306)]
		ConfigableConstId_Battle_CriticalDamage_Base,
		// Token: 0x0400217D RID: 8573
		[ProtoEnum(Name = "ConfigableConstId_UseCenceredAsset", Value = 307)]
		ConfigableConstId_UseCenceredAsset,
		// Token: 0x0400217E RID: 8574
		[ProtoEnum(Name = "ConfigableConstId_IsShowClientDanmakuIcon", Value = 308)]
		ConfigableConstId_IsShowClientDanmakuIcon,
		// Token: 0x0400217F RID: 8575
		[ProtoEnum(Name = "ConfigableConstId_CanSendCommentMinLevel", Value = 309)]
		ConfigableConstId_CanSendCommentMinLevel,
		// Token: 0x04002180 RID: 8576
		[ProtoEnum(Name = "ConfigableConstId_EnableXFVoiceTranslate", Value = 310)]
		ConfigableConstId_EnableXFVoiceTranslate,
		// Token: 0x04002181 RID: 8577
		[ProtoEnum(Name = "ConfigableConstId_GuildWarTeamRoomLeaderKickOutDeltaTime", Value = 311)]
		ConfigableConstId_GuildWarTeamRoomLeaderKickOutDeltaTime,
		// Token: 0x04002182 RID: 8578
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek", Value = 312)]
		ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek,
		// Token: 0x04002183 RID: 8579
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatRandomHeroTagIds", Value = 313)]
		ConfigableConstId_GuildMassiveCombatRandomHeroTagIds,
		// Token: 0x04002184 RID: 8580
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatMinTitleToStart", Value = 314)]
		ConfigableConstId_GuildMassiveCombatMinTitleToStart,
		// Token: 0x04002185 RID: 8581
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatMinTitleToSurrender", Value = 315)]
		ConfigableConstId_GuildMassiveCombatMinTitleToSurrender,
		// Token: 0x04002186 RID: 8582
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatMinMemberToStart", Value = 316)]
		ConfigableConstId_GuildMassiveCombatMinMemberToStart,
		// Token: 0x04002187 RID: 8583
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatMinMemberLevelToStart", Value = 317)]
		ConfigableConstId_GuildMassiveCombatMinMemberLevelToStart,
		// Token: 0x04002188 RID: 8584
		[ProtoEnum(Name = "ConfigableConstId_GuildMassiveCombatMaxHeroTagIdForStronghold", Value = 318)]
		ConfigableConstId_GuildMassiveCombatMaxHeroTagIdForStronghold,
		// Token: 0x04002189 RID: 8585
		[ProtoEnum(Name = "ConfigableConstId_GuildMedalRank", Value = 319)]
		ConfigableConstId_GuildMedalRank
	}
}
