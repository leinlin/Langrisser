using System;
using System.Collections;
using System.Collections.Generic;
using BlackJack.UtilityTools;

namespace BlackJack.ConfigData
{
	// Token: 0x020001F2 RID: 498
	public interface IConfigDataLoader
	{
		// Token: 0x060018E6 RID: 6374
		ConfigDataActivityCardPoolGroupInfo GetConfigDataActivityCardPoolGroupInfo(int key);

		// Token: 0x060018E7 RID: 6375
		IEnumerable LuaGetAllConfigDataActivityCardPoolGroupInfo();

		// Token: 0x060018E8 RID: 6376
		IEnumerable<KeyValuePair<int, ConfigDataActivityCardPoolGroupInfo>> GetAllConfigDataActivityCardPoolGroupInfo();

		// Token: 0x060018E9 RID: 6377
		ConfigDataAnikiGymInfo GetConfigDataAnikiGymInfo(int key);

		// Token: 0x060018EA RID: 6378
		IEnumerable LuaGetAllConfigDataAnikiGymInfo();

		// Token: 0x060018EB RID: 6379
		IEnumerable<KeyValuePair<int, ConfigDataAnikiGymInfo>> GetAllConfigDataAnikiGymInfo();

		// Token: 0x060018EC RID: 6380
		ConfigDataAnikiLevelInfo GetConfigDataAnikiLevelInfo(int key);

		// Token: 0x060018ED RID: 6381
		IEnumerable LuaGetAllConfigDataAnikiLevelInfo();

		// Token: 0x060018EE RID: 6382
		IEnumerable<KeyValuePair<int, ConfigDataAnikiLevelInfo>> GetAllConfigDataAnikiLevelInfo();

		// Token: 0x060018EF RID: 6383
		ConfigDataArenaBattleInfo GetConfigDataArenaBattleInfo(int key);

		// Token: 0x060018F0 RID: 6384
		IEnumerable LuaGetAllConfigDataArenaBattleInfo();

		// Token: 0x060018F1 RID: 6385
		IEnumerable<KeyValuePair<int, ConfigDataArenaBattleInfo>> GetAllConfigDataArenaBattleInfo();

		// Token: 0x060018F2 RID: 6386
		ConfigDataArenaDefendRuleInfo GetConfigDataArenaDefendRuleInfo(int key);

		// Token: 0x060018F3 RID: 6387
		IEnumerable LuaGetAllConfigDataArenaDefendRuleInfo();

		// Token: 0x060018F4 RID: 6388
		IEnumerable<KeyValuePair<int, ConfigDataArenaDefendRuleInfo>> GetAllConfigDataArenaDefendRuleInfo();

		// Token: 0x060018F5 RID: 6389
		ConfigDataArenaLevelInfo GetConfigDataArenaLevelInfo(int key);

		// Token: 0x060018F6 RID: 6390
		IEnumerable LuaGetAllConfigDataArenaLevelInfo();

		// Token: 0x060018F7 RID: 6391
		IEnumerable<KeyValuePair<int, ConfigDataArenaLevelInfo>> GetAllConfigDataArenaLevelInfo();

		// Token: 0x060018F8 RID: 6392
		ConfigDataArenaOpponentPointZoneInfo GetConfigDataArenaOpponentPointZoneInfo(int key);

		// Token: 0x060018F9 RID: 6393
		IEnumerable LuaGetAllConfigDataArenaOpponentPointZoneInfo();

		// Token: 0x060018FA RID: 6394
		IEnumerable<KeyValuePair<int, ConfigDataArenaOpponentPointZoneInfo>> GetAllConfigDataArenaOpponentPointZoneInfo();

		// Token: 0x060018FB RID: 6395
		ConfigDataArenaRankRewardInfo GetConfigDataArenaRankRewardInfo(int key);

		// Token: 0x060018FC RID: 6396
		IEnumerable LuaGetAllConfigDataArenaRankRewardInfo();

		// Token: 0x060018FD RID: 6397
		IEnumerable<KeyValuePair<int, ConfigDataArenaRankRewardInfo>> GetAllConfigDataArenaRankRewardInfo();

		// Token: 0x060018FE RID: 6398
		ConfigDataArenaRobotInfo GetConfigDataArenaRobotInfo(int key);

		// Token: 0x060018FF RID: 6399
		IEnumerable LuaGetAllConfigDataArenaRobotInfo();

		// Token: 0x06001900 RID: 6400
		IEnumerable<KeyValuePair<int, ConfigDataArenaRobotInfo>> GetAllConfigDataArenaRobotInfo();

		// Token: 0x06001901 RID: 6401
		ConfigDataArenaSettleTimeInfo GetConfigDataArenaSettleTimeInfo(int key);

		// Token: 0x06001902 RID: 6402
		IEnumerable LuaGetAllConfigDataArenaSettleTimeInfo();

		// Token: 0x06001903 RID: 6403
		IEnumerable<KeyValuePair<int, ConfigDataArenaSettleTimeInfo>> GetAllConfigDataArenaSettleTimeInfo();

		// Token: 0x06001904 RID: 6404
		ConfigDataArenaVictoryPointsRewardInfo GetConfigDataArenaVictoryPointsRewardInfo(int key);

		// Token: 0x06001905 RID: 6405
		IEnumerable LuaGetAllConfigDataArenaVictoryPointsRewardInfo();

		// Token: 0x06001906 RID: 6406
		IEnumerable<KeyValuePair<int, ConfigDataArenaVictoryPointsRewardInfo>> GetAllConfigDataArenaVictoryPointsRewardInfo();

		// Token: 0x06001907 RID: 6407
		ConfigDataArmyInfo GetConfigDataArmyInfo(int key);

		// Token: 0x06001908 RID: 6408
		IEnumerable LuaGetAllConfigDataArmyInfo();

		// Token: 0x06001909 RID: 6409
		IEnumerable<KeyValuePair<int, ConfigDataArmyInfo>> GetAllConfigDataArmyInfo();

		// Token: 0x0600190A RID: 6410
		ConfigDataArmyRelation GetConfigDataArmyRelation(int key);

		// Token: 0x0600190B RID: 6411
		IEnumerable LuaGetAllConfigDataArmyRelation();

		// Token: 0x0600190C RID: 6412
		IEnumerable<KeyValuePair<int, ConfigDataArmyRelation>> GetAllConfigDataArmyRelation();

		// Token: 0x0600190D RID: 6413
		ConfigDataAssetReplaceInfo GetConfigDataAssetReplaceInfo(int key);

		// Token: 0x0600190E RID: 6414
		IEnumerable LuaGetAllConfigDataAssetReplaceInfo();

		// Token: 0x0600190F RID: 6415
		IEnumerable<KeyValuePair<int, ConfigDataAssetReplaceInfo>> GetAllConfigDataAssetReplaceInfo();

		// Token: 0x06001910 RID: 6416
		ConfigDataBanditInfo GetConfigDataBanditInfo(int key);

		// Token: 0x06001911 RID: 6417
		IEnumerable LuaGetAllConfigDataBanditInfo();

		// Token: 0x06001912 RID: 6418
		IEnumerable<KeyValuePair<int, ConfigDataBanditInfo>> GetAllConfigDataBanditInfo();

		// Token: 0x06001913 RID: 6419
		ConfigDataBattleAchievementInfo GetConfigDataBattleAchievementInfo(int key);

		// Token: 0x06001914 RID: 6420
		IEnumerable LuaGetAllConfigDataBattleAchievementInfo();

		// Token: 0x06001915 RID: 6421
		IEnumerable<KeyValuePair<int, ConfigDataBattleAchievementInfo>> GetAllConfigDataBattleAchievementInfo();

		// Token: 0x06001916 RID: 6422
		ConfigDataBattleAchievementRelatedInfo GetConfigDataBattleAchievementRelatedInfo(int key);

		// Token: 0x06001917 RID: 6423
		IEnumerable LuaGetAllConfigDataBattleAchievementRelatedInfo();

		// Token: 0x06001918 RID: 6424
		IEnumerable<KeyValuePair<int, ConfigDataBattleAchievementRelatedInfo>> GetAllConfigDataBattleAchievementRelatedInfo();

		// Token: 0x06001919 RID: 6425
		ConfigDataBattleDialogInfo GetConfigDataBattleDialogInfo(int key);

		// Token: 0x0600191A RID: 6426
		IEnumerable LuaGetAllConfigDataBattleDialogInfo();

		// Token: 0x0600191B RID: 6427
		IEnumerable<KeyValuePair<int, ConfigDataBattleDialogInfo>> GetAllConfigDataBattleDialogInfo();

		// Token: 0x0600191C RID: 6428
		ConfigDataBattleEventActionInfo GetConfigDataBattleEventActionInfo(int key);

		// Token: 0x0600191D RID: 6429
		IEnumerable LuaGetAllConfigDataBattleEventActionInfo();

		// Token: 0x0600191E RID: 6430
		IEnumerable<KeyValuePair<int, ConfigDataBattleEventActionInfo>> GetAllConfigDataBattleEventActionInfo();

		// Token: 0x0600191F RID: 6431
		ConfigDataBattleEventTriggerInfo GetConfigDataBattleEventTriggerInfo(int key);

		// Token: 0x06001920 RID: 6432
		IEnumerable LuaGetAllConfigDataBattleEventTriggerInfo();

		// Token: 0x06001921 RID: 6433
		IEnumerable<KeyValuePair<int, ConfigDataBattleEventTriggerInfo>> GetAllConfigDataBattleEventTriggerInfo();

		// Token: 0x06001922 RID: 6434
		ConfigDataBattlefieldInfo GetConfigDataBattlefieldInfo(int key);

		// Token: 0x06001923 RID: 6435
		IEnumerable LuaGetAllConfigDataBattlefieldInfo();

		// Token: 0x06001924 RID: 6436
		IEnumerable<KeyValuePair<int, ConfigDataBattlefieldInfo>> GetAllConfigDataBattlefieldInfo();

		// Token: 0x06001925 RID: 6437
		ConfigDataBattleInfo GetConfigDataBattleInfo(int key);

		// Token: 0x06001926 RID: 6438
		IEnumerable LuaGetAllConfigDataBattleInfo();

		// Token: 0x06001927 RID: 6439
		IEnumerable<KeyValuePair<int, ConfigDataBattleInfo>> GetAllConfigDataBattleInfo();

		// Token: 0x06001928 RID: 6440
		ConfigDataBattleLoseConditionInfo GetConfigDataBattleLoseConditionInfo(int key);

		// Token: 0x06001929 RID: 6441
		IEnumerable LuaGetAllConfigDataBattleLoseConditionInfo();

		// Token: 0x0600192A RID: 6442
		IEnumerable<KeyValuePair<int, ConfigDataBattleLoseConditionInfo>> GetAllConfigDataBattleLoseConditionInfo();

		// Token: 0x0600192B RID: 6443
		ConfigDataBattlePerformInfo GetConfigDataBattlePerformInfo(int key);

		// Token: 0x0600192C RID: 6444
		IEnumerable LuaGetAllConfigDataBattlePerformInfo();

		// Token: 0x0600192D RID: 6445
		IEnumerable<KeyValuePair<int, ConfigDataBattlePerformInfo>> GetAllConfigDataBattlePerformInfo();

		// Token: 0x0600192E RID: 6446
		ConfigDataBattleRandomArmyInfo GetConfigDataBattleRandomArmyInfo(int key);

		// Token: 0x0600192F RID: 6447
		IEnumerable LuaGetAllConfigDataBattleRandomArmyInfo();

		// Token: 0x06001930 RID: 6448
		IEnumerable<KeyValuePair<int, ConfigDataBattleRandomArmyInfo>> GetAllConfigDataBattleRandomArmyInfo();

		// Token: 0x06001931 RID: 6449
		ConfigDataBattleRandomTalentInfo GetConfigDataBattleRandomTalentInfo(int key);

		// Token: 0x06001932 RID: 6450
		IEnumerable LuaGetAllConfigDataBattleRandomTalentInfo();

		// Token: 0x06001933 RID: 6451
		IEnumerable<KeyValuePair<int, ConfigDataBattleRandomTalentInfo>> GetAllConfigDataBattleRandomTalentInfo();

		// Token: 0x06001934 RID: 6452
		ConfigDataBattleTreasureInfo GetConfigDataBattleTreasureInfo(int key);

		// Token: 0x06001935 RID: 6453
		IEnumerable LuaGetAllConfigDataBattleTreasureInfo();

		// Token: 0x06001936 RID: 6454
		IEnumerable<KeyValuePair<int, ConfigDataBattleTreasureInfo>> GetAllConfigDataBattleTreasureInfo();

		// Token: 0x06001937 RID: 6455
		ConfigDataBattleWinConditionInfo GetConfigDataBattleWinConditionInfo(int key);

		// Token: 0x06001938 RID: 6456
		IEnumerable LuaGetAllConfigDataBattleWinConditionInfo();

		// Token: 0x06001939 RID: 6457
		IEnumerable<KeyValuePair<int, ConfigDataBattleWinConditionInfo>> GetAllConfigDataBattleWinConditionInfo();

		// Token: 0x0600193A RID: 6458
		ConfigDataBehavior GetConfigDataBehavior(int key);

		// Token: 0x0600193B RID: 6459
		IEnumerable LuaGetAllConfigDataBehavior();

		// Token: 0x0600193C RID: 6460
		IEnumerable<KeyValuePair<int, ConfigDataBehavior>> GetAllConfigDataBehavior();

		// Token: 0x0600193D RID: 6461
		ConfigDataBehaviorChangeRule GetConfigDataBehaviorChangeRule(int key);

		// Token: 0x0600193E RID: 6462
		IEnumerable LuaGetAllConfigDataBehaviorChangeRule();

		// Token: 0x0600193F RID: 6463
		IEnumerable<KeyValuePair<int, ConfigDataBehaviorChangeRule>> GetAllConfigDataBehaviorChangeRule();

		// Token: 0x06001940 RID: 6464
		ConfigDataBigExpressionInfo GetConfigDataBigExpressionInfo(int key);

		// Token: 0x06001941 RID: 6465
		IEnumerable LuaGetAllConfigDataBigExpressionInfo();

		// Token: 0x06001942 RID: 6466
		IEnumerable<KeyValuePair<int, ConfigDataBigExpressionInfo>> GetAllConfigDataBigExpressionInfo();

		// Token: 0x06001943 RID: 6467
		ConfigDataBuffInfo GetConfigDataBuffInfo(int key);

		// Token: 0x06001944 RID: 6468
		IEnumerable LuaGetAllConfigDataBuffInfo();

		// Token: 0x06001945 RID: 6469
		IEnumerable<KeyValuePair<int, ConfigDataBuffInfo>> GetAllConfigDataBuffInfo();

		// Token: 0x06001946 RID: 6470
		ConfigDataBuyArenaTicketInfo GetConfigDataBuyArenaTicketInfo(int key);

		// Token: 0x06001947 RID: 6471
		IEnumerable LuaGetAllConfigDataBuyArenaTicketInfo();

		// Token: 0x06001948 RID: 6472
		IEnumerable<KeyValuePair<int, ConfigDataBuyArenaTicketInfo>> GetAllConfigDataBuyArenaTicketInfo();

		// Token: 0x06001949 RID: 6473
		ConfigDataBuyEnergyInfo GetConfigDataBuyEnergyInfo(int key);

		// Token: 0x0600194A RID: 6474
		IEnumerable LuaGetAllConfigDataBuyEnergyInfo();

		// Token: 0x0600194B RID: 6475
		IEnumerable<KeyValuePair<int, ConfigDataBuyEnergyInfo>> GetAllConfigDataBuyEnergyInfo();

		// Token: 0x0600194C RID: 6476
		ConfigDataCardPoolGroupInfo GetConfigDataCardPoolGroupInfo(int key);

		// Token: 0x0600194D RID: 6477
		IEnumerable LuaGetAllConfigDataCardPoolGroupInfo();

		// Token: 0x0600194E RID: 6478
		IEnumerable<KeyValuePair<int, ConfigDataCardPoolGroupInfo>> GetAllConfigDataCardPoolGroupInfo();

		// Token: 0x0600194F RID: 6479
		ConfigDataCardPoolInfo GetConfigDataCardPoolInfo(int key);

		// Token: 0x06001950 RID: 6480
		IEnumerable LuaGetAllConfigDataCardPoolInfo();

		// Token: 0x06001951 RID: 6481
		IEnumerable<KeyValuePair<int, ConfigDataCardPoolInfo>> GetAllConfigDataCardPoolInfo();

		// Token: 0x06001952 RID: 6482
		ConfigDataChallengeLevelInfo GetConfigDataChallengeLevelInfo(int key);

		// Token: 0x06001953 RID: 6483
		IEnumerable LuaGetAllConfigDataChallengeLevelInfo();

		// Token: 0x06001954 RID: 6484
		IEnumerable<KeyValuePair<int, ConfigDataChallengeLevelInfo>> GetAllConfigDataChallengeLevelInfo();

		// Token: 0x06001955 RID: 6485
		ConfigDataCharImageInfo GetConfigDataCharImageInfo(int key);

		// Token: 0x06001956 RID: 6486
		IEnumerable LuaGetAllConfigDataCharImageInfo();

		// Token: 0x06001957 RID: 6487
		IEnumerable<KeyValuePair<int, ConfigDataCharImageInfo>> GetAllConfigDataCharImageInfo();

		// Token: 0x06001958 RID: 6488
		ConfigDataCharImageSkinResourceInfo GetConfigDataCharImageSkinResourceInfo(int key);

		// Token: 0x06001959 RID: 6489
		IEnumerable LuaGetAllConfigDataCharImageSkinResourceInfo();

		// Token: 0x0600195A RID: 6490
		IEnumerable<KeyValuePair<int, ConfigDataCharImageSkinResourceInfo>> GetAllConfigDataCharImageSkinResourceInfo();

		// Token: 0x0600195B RID: 6491
		ConfigDataConfigableConst GetConfigDataConfigableConst(int key);

		// Token: 0x0600195C RID: 6492
		IEnumerable LuaGetAllConfigDataConfigableConst();

		// Token: 0x0600195D RID: 6493
		IEnumerable<KeyValuePair<int, ConfigDataConfigableConst>> GetAllConfigDataConfigableConst();

		// Token: 0x0600195E RID: 6494
		ConfigDataConfigIDRangeInfo GetConfigDataConfigIDRangeInfo(int key);

		// Token: 0x0600195F RID: 6495
		IEnumerable LuaGetAllConfigDataConfigIDRangeInfo();

		// Token: 0x06001960 RID: 6496
		IEnumerable<KeyValuePair<int, ConfigDataConfigIDRangeInfo>> GetAllConfigDataConfigIDRangeInfo();

		// Token: 0x06001961 RID: 6497
		ConfigDataCooperateBattleInfo GetConfigDataCooperateBattleInfo(int key);

		// Token: 0x06001962 RID: 6498
		IEnumerable LuaGetAllConfigDataCooperateBattleInfo();

		// Token: 0x06001963 RID: 6499
		IEnumerable<KeyValuePair<int, ConfigDataCooperateBattleInfo>> GetAllConfigDataCooperateBattleInfo();

		// Token: 0x06001964 RID: 6500
		ConfigDataCooperateBattleLevelInfo GetConfigDataCooperateBattleLevelInfo(int key);

		// Token: 0x06001965 RID: 6501
		IEnumerable LuaGetAllConfigDataCooperateBattleLevelInfo();

		// Token: 0x06001966 RID: 6502
		IEnumerable<KeyValuePair<int, ConfigDataCooperateBattleLevelInfo>> GetAllConfigDataCooperateBattleLevelInfo();

		// Token: 0x06001967 RID: 6503
		ConfigDataCrystalCardPoolGroupInfo GetConfigDataCrystalCardPoolGroupInfo(int key);

		// Token: 0x06001968 RID: 6504
		IEnumerable LuaGetAllConfigDataCrystalCardPoolGroupInfo();

		// Token: 0x06001969 RID: 6505
		IEnumerable<KeyValuePair<int, ConfigDataCrystalCardPoolGroupInfo>> GetAllConfigDataCrystalCardPoolGroupInfo();

		// Token: 0x0600196A RID: 6506
		ConfigDataCutsceneInfo GetConfigDataCutsceneInfo(int key);

		// Token: 0x0600196B RID: 6507
		IEnumerable LuaGetAllConfigDataCutsceneInfo();

		// Token: 0x0600196C RID: 6508
		IEnumerable<KeyValuePair<int, ConfigDataCutsceneInfo>> GetAllConfigDataCutsceneInfo();

		// Token: 0x0600196D RID: 6509
		ConfigDataDailyPushNotification GetConfigDataDailyPushNotification(int key);

		// Token: 0x0600196E RID: 6510
		IEnumerable LuaGetAllConfigDataDailyPushNotification();

		// Token: 0x0600196F RID: 6511
		IEnumerable<KeyValuePair<int, ConfigDataDailyPushNotification>> GetAllConfigDataDailyPushNotification();

		// Token: 0x06001970 RID: 6512
		ConfigDataDeviceSetting GetConfigDataDeviceSetting(int key);

		// Token: 0x06001971 RID: 6513
		IEnumerable LuaGetAllConfigDataDeviceSetting();

		// Token: 0x06001972 RID: 6514
		IEnumerable<KeyValuePair<int, ConfigDataDeviceSetting>> GetAllConfigDataDeviceSetting();

		// Token: 0x06001973 RID: 6515
		ConfigDataDialogInfo GetConfigDataDialogInfo(int key);

		// Token: 0x06001974 RID: 6516
		IEnumerable LuaGetAllConfigDataDialogInfo();

		// Token: 0x06001975 RID: 6517
		IEnumerable<KeyValuePair<int, ConfigDataDialogInfo>> GetAllConfigDataDialogInfo();

		// Token: 0x06001976 RID: 6518
		ConfigDataEnchantStoneInfo GetConfigDataEnchantStoneInfo(int key);

		// Token: 0x06001977 RID: 6519
		IEnumerable LuaGetAllConfigDataEnchantStoneInfo();

		// Token: 0x06001978 RID: 6520
		IEnumerable<KeyValuePair<int, ConfigDataEnchantStoneInfo>> GetAllConfigDataEnchantStoneInfo();

		// Token: 0x06001979 RID: 6521
		ConfigDataEnchantTemplateInfo GetConfigDataEnchantTemplateInfo(int key);

		// Token: 0x0600197A RID: 6522
		IEnumerable LuaGetAllConfigDataEnchantTemplateInfo();

		// Token: 0x0600197B RID: 6523
		IEnumerable<KeyValuePair<int, ConfigDataEnchantTemplateInfo>> GetAllConfigDataEnchantTemplateInfo();

		// Token: 0x0600197C RID: 6524
		ConfigDataEquipmentInfo GetConfigDataEquipmentInfo(int key);

		// Token: 0x0600197D RID: 6525
		IEnumerable LuaGetAllConfigDataEquipmentInfo();

		// Token: 0x0600197E RID: 6526
		IEnumerable<KeyValuePair<int, ConfigDataEquipmentInfo>> GetAllConfigDataEquipmentInfo();

		// Token: 0x0600197F RID: 6527
		ConfigDataEquipmentLevelInfo GetConfigDataEquipmentLevelInfo(int key);

		// Token: 0x06001980 RID: 6528
		IEnumerable LuaGetAllConfigDataEquipmentLevelInfo();

		// Token: 0x06001981 RID: 6529
		IEnumerable<KeyValuePair<int, ConfigDataEquipmentLevelInfo>> GetAllConfigDataEquipmentLevelInfo();

		// Token: 0x06001982 RID: 6530
		ConfigDataEquipmentLevelLimitInfo GetConfigDataEquipmentLevelLimitInfo(int key);

		// Token: 0x06001983 RID: 6531
		IEnumerable LuaGetAllConfigDataEquipmentLevelLimitInfo();

		// Token: 0x06001984 RID: 6532
		IEnumerable<KeyValuePair<int, ConfigDataEquipmentLevelLimitInfo>> GetAllConfigDataEquipmentLevelLimitInfo();

		// Token: 0x06001985 RID: 6533
		ConfigDataErrorCodeStringTable GetConfigDataErrorCodeStringTable(int key);

		// Token: 0x06001986 RID: 6534
		IEnumerable LuaGetAllConfigDataErrorCodeStringTable();

		// Token: 0x06001987 RID: 6535
		IEnumerable<KeyValuePair<int, ConfigDataErrorCodeStringTable>> GetAllConfigDataErrorCodeStringTable();

		// Token: 0x06001988 RID: 6536
		ConfigDataEventInfo GetConfigDataEventInfo(int key);

		// Token: 0x06001989 RID: 6537
		IEnumerable LuaGetAllConfigDataEventInfo();

		// Token: 0x0600198A RID: 6538
		IEnumerable<KeyValuePair<int, ConfigDataEventInfo>> GetAllConfigDataEventInfo();

		// Token: 0x0600198B RID: 6539
		ConfigDataExplanationInfo GetConfigDataExplanationInfo(int key);

		// Token: 0x0600198C RID: 6540
		IEnumerable LuaGetAllConfigDataExplanationInfo();

		// Token: 0x0600198D RID: 6541
		IEnumerable<KeyValuePair<int, ConfigDataExplanationInfo>> GetAllConfigDataExplanationInfo();

		// Token: 0x0600198E RID: 6542
		ConfigDataFixedStoreItemInfo GetConfigDataFixedStoreItemInfo(int key);

		// Token: 0x0600198F RID: 6543
		IEnumerable LuaGetAllConfigDataFixedStoreItemInfo();

		// Token: 0x06001990 RID: 6544
		IEnumerable<KeyValuePair<int, ConfigDataFixedStoreItemInfo>> GetAllConfigDataFixedStoreItemInfo();

		// Token: 0x06001991 RID: 6545
		ConfigDataFlyObjectInfo GetConfigDataFlyObjectInfo(int key);

		// Token: 0x06001992 RID: 6546
		IEnumerable LuaGetAllConfigDataFlyObjectInfo();

		// Token: 0x06001993 RID: 6547
		IEnumerable<KeyValuePair<int, ConfigDataFlyObjectInfo>> GetAllConfigDataFlyObjectInfo();

		// Token: 0x06001994 RID: 6548
		ConfigDataFreeCardPoolGroupInfo GetConfigDataFreeCardPoolGroupInfo(int key);

		// Token: 0x06001995 RID: 6549
		IEnumerable LuaGetAllConfigDataFreeCardPoolGroupInfo();

		// Token: 0x06001996 RID: 6550
		IEnumerable<KeyValuePair<int, ConfigDataFreeCardPoolGroupInfo>> GetAllConfigDataFreeCardPoolGroupInfo();

		// Token: 0x06001997 RID: 6551
		ConfigDataFxFlipInfo GetConfigDataFxFlipInfo(int key);

		// Token: 0x06001998 RID: 6552
		IEnumerable LuaGetAllConfigDataFxFlipInfo();

		// Token: 0x06001999 RID: 6553
		IEnumerable<KeyValuePair<int, ConfigDataFxFlipInfo>> GetAllConfigDataFxFlipInfo();

		// Token: 0x0600199A RID: 6554
		ConfigDataGameFunctionOpenInfo GetConfigDataGameFunctionOpenInfo(int key);

		// Token: 0x0600199B RID: 6555
		IEnumerable LuaGetAllConfigDataGameFunctionOpenInfo();

		// Token: 0x0600199C RID: 6556
		IEnumerable<KeyValuePair<int, ConfigDataGameFunctionOpenInfo>> GetAllConfigDataGameFunctionOpenInfo();

		// Token: 0x0600199D RID: 6557
		ConfigDataGamePlayTeamTypeInfo GetConfigDataGamePlayTeamTypeInfo(int key);

		// Token: 0x0600199E RID: 6558
		IEnumerable LuaGetAllConfigDataGamePlayTeamTypeInfo();

		// Token: 0x0600199F RID: 6559
		IEnumerable<KeyValuePair<int, ConfigDataGamePlayTeamTypeInfo>> GetAllConfigDataGamePlayTeamTypeInfo();

		// Token: 0x060019A0 RID: 6560
		ConfigDataGiftCDKeyInfo GetConfigDataGiftCDKeyInfo(int key);

		// Token: 0x060019A1 RID: 6561
		IEnumerable LuaGetAllConfigDataGiftCDKeyInfo();

		// Token: 0x060019A2 RID: 6562
		IEnumerable<KeyValuePair<int, ConfigDataGiftCDKeyInfo>> GetAllConfigDataGiftCDKeyInfo();

		// Token: 0x060019A3 RID: 6563
		ConfigDataGiftStoreItemInfo GetConfigDataGiftStoreItemInfo(int key);

		// Token: 0x060019A4 RID: 6564
		IEnumerable LuaGetAllConfigDataGiftStoreItemInfo();

		// Token: 0x060019A5 RID: 6565
		IEnumerable<KeyValuePair<int, ConfigDataGiftStoreItemInfo>> GetAllConfigDataGiftStoreItemInfo();

		// Token: 0x060019A6 RID: 6566
		ConfigDataGoddessDialogInfo GetConfigDataGoddessDialogInfo(int key);

		// Token: 0x060019A7 RID: 6567
		IEnumerable LuaGetAllConfigDataGoddessDialogInfo();

		// Token: 0x060019A8 RID: 6568
		IEnumerable<KeyValuePair<int, ConfigDataGoddessDialogInfo>> GetAllConfigDataGoddessDialogInfo();

		// Token: 0x060019A9 RID: 6569
		ConfigDataGroupBehavior GetConfigDataGroupBehavior(int key);

		// Token: 0x060019AA RID: 6570
		IEnumerable LuaGetAllConfigDataGroupBehavior();

		// Token: 0x060019AB RID: 6571
		IEnumerable<KeyValuePair<int, ConfigDataGroupBehavior>> GetAllConfigDataGroupBehavior();

		// Token: 0x060019AC RID: 6572
		ConfigDataGuildMassiveCombatDifficultyInfo GetConfigDataGuildMassiveCombatDifficultyInfo(int key);

		// Token: 0x060019AD RID: 6573
		IEnumerable LuaGetAllConfigDataGuildMassiveCombatDifficultyInfo();

		// Token: 0x060019AE RID: 6574
		IEnumerable<KeyValuePair<int, ConfigDataGuildMassiveCombatDifficultyInfo>> GetAllConfigDataGuildMassiveCombatDifficultyInfo();

		// Token: 0x060019AF RID: 6575
		ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo GetConfigDataGuildMassiveCombatIndividualPointsRewardsInfo(int key);

		// Token: 0x060019B0 RID: 6576
		IEnumerable LuaGetAllConfigDataGuildMassiveCombatIndividualPointsRewardsInfo();

		// Token: 0x060019B1 RID: 6577
		IEnumerable<KeyValuePair<int, ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo>> GetAllConfigDataGuildMassiveCombatIndividualPointsRewardsInfo();

		// Token: 0x060019B2 RID: 6578
		ConfigDataGuildMassiveCombatLevelInfo GetConfigDataGuildMassiveCombatLevelInfo(int key);

		// Token: 0x060019B3 RID: 6579
		IEnumerable LuaGetAllConfigDataGuildMassiveCombatLevelInfo();

		// Token: 0x060019B4 RID: 6580
		IEnumerable<KeyValuePair<int, ConfigDataGuildMassiveCombatLevelInfo>> GetAllConfigDataGuildMassiveCombatLevelInfo();

		// Token: 0x060019B5 RID: 6581
		ConfigDataGuildMassiveCombatRewardsInfo GetConfigDataGuildMassiveCombatRewardsInfo(int key);

		// Token: 0x060019B6 RID: 6582
		IEnumerable LuaGetAllConfigDataGuildMassiveCombatRewardsInfo();

		// Token: 0x060019B7 RID: 6583
		IEnumerable<KeyValuePair<int, ConfigDataGuildMassiveCombatRewardsInfo>> GetAllConfigDataGuildMassiveCombatRewardsInfo();

		// Token: 0x060019B8 RID: 6584
		ConfigDataGuildMassiveCombatStrongholdInfo GetConfigDataGuildMassiveCombatStrongholdInfo(int key);

		// Token: 0x060019B9 RID: 6585
		IEnumerable LuaGetAllConfigDataGuildMassiveCombatStrongholdInfo();

		// Token: 0x060019BA RID: 6586
		IEnumerable<KeyValuePair<int, ConfigDataGuildMassiveCombatStrongholdInfo>> GetAllConfigDataGuildMassiveCombatStrongholdInfo();

		// Token: 0x060019BB RID: 6587
		ConfigDataHeadFrameInfo GetConfigDataHeadFrameInfo(int key);

		// Token: 0x060019BC RID: 6588
		IEnumerable LuaGetAllConfigDataHeadFrameInfo();

		// Token: 0x060019BD RID: 6589
		IEnumerable<KeyValuePair<int, ConfigDataHeadFrameInfo>> GetAllConfigDataHeadFrameInfo();

		// Token: 0x060019BE RID: 6590
		ConfigDataHeroAssistantTaskGeneralInfo GetConfigDataHeroAssistantTaskGeneralInfo(int key);

		// Token: 0x060019BF RID: 6591
		IEnumerable LuaGetAllConfigDataHeroAssistantTaskGeneralInfo();

		// Token: 0x060019C0 RID: 6592
		IEnumerable<KeyValuePair<int, ConfigDataHeroAssistantTaskGeneralInfo>> GetAllConfigDataHeroAssistantTaskGeneralInfo();

		// Token: 0x060019C1 RID: 6593
		ConfigDataHeroAssistantTaskInfo GetConfigDataHeroAssistantTaskInfo(int key);

		// Token: 0x060019C2 RID: 6594
		IEnumerable LuaGetAllConfigDataHeroAssistantTaskInfo();

		// Token: 0x060019C3 RID: 6595
		IEnumerable<KeyValuePair<int, ConfigDataHeroAssistantTaskInfo>> GetAllConfigDataHeroAssistantTaskInfo();

		// Token: 0x060019C4 RID: 6596
		ConfigDataHeroAssistantTaskScheduleInfo GetConfigDataHeroAssistantTaskScheduleInfo(int key);

		// Token: 0x060019C5 RID: 6597
		IEnumerable LuaGetAllConfigDataHeroAssistantTaskScheduleInfo();

		// Token: 0x060019C6 RID: 6598
		IEnumerable<KeyValuePair<int, ConfigDataHeroAssistantTaskScheduleInfo>> GetAllConfigDataHeroAssistantTaskScheduleInfo();

		// Token: 0x060019C7 RID: 6599
		ConfigDataHeroBiographyInfo GetConfigDataHeroBiographyInfo(int key);

		// Token: 0x060019C8 RID: 6600
		IEnumerable LuaGetAllConfigDataHeroBiographyInfo();

		// Token: 0x060019C9 RID: 6601
		IEnumerable<KeyValuePair<int, ConfigDataHeroBiographyInfo>> GetAllConfigDataHeroBiographyInfo();

		// Token: 0x060019CA RID: 6602
		ConfigDataHeroConfessionInfo GetConfigDataHeroConfessionInfo(int key);

		// Token: 0x060019CB RID: 6603
		IEnumerable LuaGetAllConfigDataHeroConfessionInfo();

		// Token: 0x060019CC RID: 6604
		IEnumerable<KeyValuePair<int, ConfigDataHeroConfessionInfo>> GetAllConfigDataHeroConfessionInfo();

		// Token: 0x060019CD RID: 6605
		ConfigDataHeroDungeonLevelInfo GetConfigDataHeroDungeonLevelInfo(int key);

		// Token: 0x060019CE RID: 6606
		IEnumerable LuaGetAllConfigDataHeroDungeonLevelInfo();

		// Token: 0x060019CF RID: 6607
		IEnumerable<KeyValuePair<int, ConfigDataHeroDungeonLevelInfo>> GetAllConfigDataHeroDungeonLevelInfo();

		// Token: 0x060019D0 RID: 6608
		ConfigDataHeroFavorabilityLevelInfo GetConfigDataHeroFavorabilityLevelInfo(int key);

		// Token: 0x060019D1 RID: 6609
		IEnumerable LuaGetAllConfigDataHeroFavorabilityLevelInfo();

		// Token: 0x060019D2 RID: 6610
		IEnumerable<KeyValuePair<int, ConfigDataHeroFavorabilityLevelInfo>> GetAllConfigDataHeroFavorabilityLevelInfo();

		// Token: 0x060019D3 RID: 6611
		ConfigDataHeroFetterInfo GetConfigDataHeroFetterInfo(int key);

		// Token: 0x060019D4 RID: 6612
		IEnumerable LuaGetAllConfigDataHeroFetterInfo();

		// Token: 0x060019D5 RID: 6613
		IEnumerable<KeyValuePair<int, ConfigDataHeroFetterInfo>> GetAllConfigDataHeroFetterInfo();

		// Token: 0x060019D6 RID: 6614
		ConfigDataHeroInfo GetConfigDataHeroInfo(int key);

		// Token: 0x060019D7 RID: 6615
		IEnumerable LuaGetAllConfigDataHeroInfo();

		// Token: 0x060019D8 RID: 6616
		IEnumerable<KeyValuePair<int, ConfigDataHeroInfo>> GetAllConfigDataHeroInfo();

		// Token: 0x060019D9 RID: 6617
		ConfigDataHeroInformationInfo GetConfigDataHeroInformationInfo(int key);

		// Token: 0x060019DA RID: 6618
		IEnumerable LuaGetAllConfigDataHeroInformationInfo();

		// Token: 0x060019DB RID: 6619
		IEnumerable<KeyValuePair<int, ConfigDataHeroInformationInfo>> GetAllConfigDataHeroInformationInfo();

		// Token: 0x060019DC RID: 6620
		ConfigDataHeroInteractionInfo GetConfigDataHeroInteractionInfo(int key);

		// Token: 0x060019DD RID: 6621
		IEnumerable LuaGetAllConfigDataHeroInteractionInfo();

		// Token: 0x060019DE RID: 6622
		IEnumerable<KeyValuePair<int, ConfigDataHeroInteractionInfo>> GetAllConfigDataHeroInteractionInfo();

		// Token: 0x060019DF RID: 6623
		ConfigDataHeroLevelInfo GetConfigDataHeroLevelInfo(int key);

		// Token: 0x060019E0 RID: 6624
		IEnumerable LuaGetAllConfigDataHeroLevelInfo();

		// Token: 0x060019E1 RID: 6625
		IEnumerable<KeyValuePair<int, ConfigDataHeroLevelInfo>> GetAllConfigDataHeroLevelInfo();

		// Token: 0x060019E2 RID: 6626
		ConfigDataHeroPerformanceInfo GetConfigDataHeroPerformanceInfo(int key);

		// Token: 0x060019E3 RID: 6627
		IEnumerable LuaGetAllConfigDataHeroPerformanceInfo();

		// Token: 0x060019E4 RID: 6628
		IEnumerable<KeyValuePair<int, ConfigDataHeroPerformanceInfo>> GetAllConfigDataHeroPerformanceInfo();

		// Token: 0x060019E5 RID: 6629
		ConfigDataHeroPerformanceWordInfo GetConfigDataHeroPerformanceWordInfo(int key);

		// Token: 0x060019E6 RID: 6630
		IEnumerable LuaGetAllConfigDataHeroPerformanceWordInfo();

		// Token: 0x060019E7 RID: 6631
		IEnumerable<KeyValuePair<int, ConfigDataHeroPerformanceWordInfo>> GetAllConfigDataHeroPerformanceWordInfo();

		// Token: 0x060019E8 RID: 6632
		ConfigDataHeroPhantomInfo GetConfigDataHeroPhantomInfo(int key);

		// Token: 0x060019E9 RID: 6633
		IEnumerable LuaGetAllConfigDataHeroPhantomInfo();

		// Token: 0x060019EA RID: 6634
		IEnumerable<KeyValuePair<int, ConfigDataHeroPhantomInfo>> GetAllConfigDataHeroPhantomInfo();

		// Token: 0x060019EB RID: 6635
		ConfigDataHeroPhantomLevelInfo GetConfigDataHeroPhantomLevelInfo(int key);

		// Token: 0x060019EC RID: 6636
		IEnumerable LuaGetAllConfigDataHeroPhantomLevelInfo();

		// Token: 0x060019ED RID: 6637
		IEnumerable<KeyValuePair<int, ConfigDataHeroPhantomLevelInfo>> GetAllConfigDataHeroPhantomLevelInfo();

		// Token: 0x060019EE RID: 6638
		ConfigDataHeroSkinInfo GetConfigDataHeroSkinInfo(int key);

		// Token: 0x060019EF RID: 6639
		IEnumerable LuaGetAllConfigDataHeroSkinInfo();

		// Token: 0x060019F0 RID: 6640
		IEnumerable<KeyValuePair<int, ConfigDataHeroSkinInfo>> GetAllConfigDataHeroSkinInfo();

		// Token: 0x060019F1 RID: 6641
		ConfigDataHeroStarInfo GetConfigDataHeroStarInfo(int key);

		// Token: 0x060019F2 RID: 6642
		IEnumerable LuaGetAllConfigDataHeroStarInfo();

		// Token: 0x060019F3 RID: 6643
		IEnumerable<KeyValuePair<int, ConfigDataHeroStarInfo>> GetAllConfigDataHeroStarInfo();

		// Token: 0x060019F4 RID: 6644
		ConfigDataHeroTagInfo GetConfigDataHeroTagInfo(int key);

		// Token: 0x060019F5 RID: 6645
		IEnumerable LuaGetAllConfigDataHeroTagInfo();

		// Token: 0x060019F6 RID: 6646
		IEnumerable<KeyValuePair<int, ConfigDataHeroTagInfo>> GetAllConfigDataHeroTagInfo();

		// Token: 0x060019F7 RID: 6647
		ConfigDataHeroTrainningInfo GetConfigDataHeroTrainningInfo(int key);

		// Token: 0x060019F8 RID: 6648
		IEnumerable LuaGetAllConfigDataHeroTrainningInfo();

		// Token: 0x060019F9 RID: 6649
		IEnumerable<KeyValuePair<int, ConfigDataHeroTrainningInfo>> GetAllConfigDataHeroTrainningInfo();

		// Token: 0x060019FA RID: 6650
		ConfigDataHeroTrainningLevelInfo GetConfigDataHeroTrainningLevelInfo(int key);

		// Token: 0x060019FB RID: 6651
		IEnumerable LuaGetAllConfigDataHeroTrainningLevelInfo();

		// Token: 0x060019FC RID: 6652
		IEnumerable<KeyValuePair<int, ConfigDataHeroTrainningLevelInfo>> GetAllConfigDataHeroTrainningLevelInfo();

		// Token: 0x060019FD RID: 6653
		ConfigDataInitInfo GetConfigDataInitInfo(int key);

		// Token: 0x060019FE RID: 6654
		IEnumerable LuaGetAllConfigDataInitInfo();

		// Token: 0x060019FF RID: 6655
		IEnumerable<KeyValuePair<int, ConfigDataInitInfo>> GetAllConfigDataInitInfo();

		// Token: 0x06001A00 RID: 6656
		ConfigDataItemInfo GetConfigDataItemInfo(int key);

		// Token: 0x06001A01 RID: 6657
		IEnumerable LuaGetAllConfigDataItemInfo();

		// Token: 0x06001A02 RID: 6658
		IEnumerable<KeyValuePair<int, ConfigDataItemInfo>> GetAllConfigDataItemInfo();

		// Token: 0x06001A03 RID: 6659
		ConfigDataJobConnectionInfo GetConfigDataJobConnectionInfo(int key);

		// Token: 0x06001A04 RID: 6660
		IEnumerable LuaGetAllConfigDataJobConnectionInfo();

		// Token: 0x06001A05 RID: 6661
		IEnumerable<KeyValuePair<int, ConfigDataJobConnectionInfo>> GetAllConfigDataJobConnectionInfo();

		// Token: 0x06001A06 RID: 6662
		ConfigDataJobInfo GetConfigDataJobInfo(int key);

		// Token: 0x06001A07 RID: 6663
		IEnumerable LuaGetAllConfigDataJobInfo();

		// Token: 0x06001A08 RID: 6664
		IEnumerable<KeyValuePair<int, ConfigDataJobInfo>> GetAllConfigDataJobInfo();

		// Token: 0x06001A09 RID: 6665
		ConfigDataJobLevelInfo GetConfigDataJobLevelInfo(int key);

		// Token: 0x06001A0A RID: 6666
		IEnumerable LuaGetAllConfigDataJobLevelInfo();

		// Token: 0x06001A0B RID: 6667
		IEnumerable<KeyValuePair<int, ConfigDataJobLevelInfo>> GetAllConfigDataJobLevelInfo();

		// Token: 0x06001A0C RID: 6668
		ConfigDataJobMaterialInfo GetConfigDataJobMaterialInfo(int key);

		// Token: 0x06001A0D RID: 6669
		IEnumerable LuaGetAllConfigDataJobMaterialInfo();

		// Token: 0x06001A0E RID: 6670
		IEnumerable<KeyValuePair<int, ConfigDataJobMaterialInfo>> GetAllConfigDataJobMaterialInfo();

		// Token: 0x06001A0F RID: 6671
		ConfigDataJobUnlockConditionInfo GetConfigDataJobUnlockConditionInfo(int key);

		// Token: 0x06001A10 RID: 6672
		IEnumerable LuaGetAllConfigDataJobUnlockConditionInfo();

		// Token: 0x06001A11 RID: 6673
		IEnumerable<KeyValuePair<int, ConfigDataJobUnlockConditionInfo>> GetAllConfigDataJobUnlockConditionInfo();

		// Token: 0x06001A12 RID: 6674
		ConfigDataMailInfo GetConfigDataMailInfo(int key);

		// Token: 0x06001A13 RID: 6675
		IEnumerable LuaGetAllConfigDataMailInfo();

		// Token: 0x06001A14 RID: 6676
		IEnumerable<KeyValuePair<int, ConfigDataMailInfo>> GetAllConfigDataMailInfo();

		// Token: 0x06001A15 RID: 6677
		ConfigDataMemoryCorridorInfo GetConfigDataMemoryCorridorInfo(int key);

		// Token: 0x06001A16 RID: 6678
		IEnumerable LuaGetAllConfigDataMemoryCorridorInfo();

		// Token: 0x06001A17 RID: 6679
		IEnumerable<KeyValuePair<int, ConfigDataMemoryCorridorInfo>> GetAllConfigDataMemoryCorridorInfo();

		// Token: 0x06001A18 RID: 6680
		ConfigDataMemoryCorridorLevelInfo GetConfigDataMemoryCorridorLevelInfo(int key);

		// Token: 0x06001A19 RID: 6681
		IEnumerable LuaGetAllConfigDataMemoryCorridorLevelInfo();

		// Token: 0x06001A1A RID: 6682
		IEnumerable<KeyValuePair<int, ConfigDataMemoryCorridorLevelInfo>> GetAllConfigDataMemoryCorridorLevelInfo();

		// Token: 0x06001A1B RID: 6683
		ConfigDataMissionExtNoviceInfo GetConfigDataMissionExtNoviceInfo(int key);

		// Token: 0x06001A1C RID: 6684
		IEnumerable LuaGetAllConfigDataMissionExtNoviceInfo();

		// Token: 0x06001A1D RID: 6685
		IEnumerable<KeyValuePair<int, ConfigDataMissionExtNoviceInfo>> GetAllConfigDataMissionExtNoviceInfo();

		// Token: 0x06001A1E RID: 6686
		ConfigDataMissionInfo GetConfigDataMissionInfo(int key);

		// Token: 0x06001A1F RID: 6687
		IEnumerable LuaGetAllConfigDataMissionInfo();

		// Token: 0x06001A20 RID: 6688
		IEnumerable<KeyValuePair<int, ConfigDataMissionInfo>> GetAllConfigDataMissionInfo();

		// Token: 0x06001A21 RID: 6689
		ConfigDataModelSkinResourceInfo GetConfigDataModelSkinResourceInfo(int key);

		// Token: 0x06001A22 RID: 6690
		IEnumerable LuaGetAllConfigDataModelSkinResourceInfo();

		// Token: 0x06001A23 RID: 6691
		IEnumerable<KeyValuePair<int, ConfigDataModelSkinResourceInfo>> GetAllConfigDataModelSkinResourceInfo();

		// Token: 0x06001A24 RID: 6692
		ConfigDataMonthCardInfo GetConfigDataMonthCardInfo(int key);

		// Token: 0x06001A25 RID: 6693
		IEnumerable LuaGetAllConfigDataMonthCardInfo();

		// Token: 0x06001A26 RID: 6694
		IEnumerable<KeyValuePair<int, ConfigDataMonthCardInfo>> GetAllConfigDataMonthCardInfo();

		// Token: 0x06001A27 RID: 6695
		ConfigDataNoviceRewardInfo GetConfigDataNoviceRewardInfo(int key);

		// Token: 0x06001A28 RID: 6696
		IEnumerable LuaGetAllConfigDataNoviceRewardInfo();

		// Token: 0x06001A29 RID: 6697
		IEnumerable<KeyValuePair<int, ConfigDataNoviceRewardInfo>> GetAllConfigDataNoviceRewardInfo();

		// Token: 0x06001A2A RID: 6698
		ConfigDataOperationalActivityInfo GetConfigDataOperationalActivityInfo(int key);

		// Token: 0x06001A2B RID: 6699
		IEnumerable LuaGetAllConfigDataOperationalActivityInfo();

		// Token: 0x06001A2C RID: 6700
		IEnumerable<KeyValuePair<int, ConfigDataOperationalActivityInfo>> GetAllConfigDataOperationalActivityInfo();

		// Token: 0x06001A2D RID: 6701
		ConfigDataOperationalActivityItemGroupInfo GetConfigDataOperationalActivityItemGroupInfo(int key);

		// Token: 0x06001A2E RID: 6702
		IEnumerable LuaGetAllConfigDataOperationalActivityItemGroupInfo();

		// Token: 0x06001A2F RID: 6703
		IEnumerable<KeyValuePair<int, ConfigDataOperationalActivityItemGroupInfo>> GetAllConfigDataOperationalActivityItemGroupInfo();

		// Token: 0x06001A30 RID: 6704
		ConfigDataPerformanceInfo GetConfigDataPerformanceInfo(int key);

		// Token: 0x06001A31 RID: 6705
		IEnumerable LuaGetAllConfigDataPerformanceInfo();

		// Token: 0x06001A32 RID: 6706
		IEnumerable<KeyValuePair<int, ConfigDataPerformanceInfo>> GetAllConfigDataPerformanceInfo();

		// Token: 0x06001A33 RID: 6707
		ConfigDataPlayerLevelInfo GetConfigDataPlayerLevelInfo(int key);

		// Token: 0x06001A34 RID: 6708
		IEnumerable LuaGetAllConfigDataPlayerLevelInfo();

		// Token: 0x06001A35 RID: 6709
		IEnumerable<KeyValuePair<int, ConfigDataPlayerLevelInfo>> GetAllConfigDataPlayerLevelInfo();

		// Token: 0x06001A36 RID: 6710
		ConfigDataPrefabStateInfo GetConfigDataPrefabStateInfo(int key);

		// Token: 0x06001A37 RID: 6711
		IEnumerable LuaGetAllConfigDataPrefabStateInfo();

		// Token: 0x06001A38 RID: 6712
		IEnumerable<KeyValuePair<int, ConfigDataPrefabStateInfo>> GetAllConfigDataPrefabStateInfo();

		// Token: 0x06001A39 RID: 6713
		ConfigDataPropertyModifyInfo GetConfigDataPropertyModifyInfo(int key);

		// Token: 0x06001A3A RID: 6714
		IEnumerable LuaGetAllConfigDataPropertyModifyInfo();

		// Token: 0x06001A3B RID: 6715
		IEnumerable<KeyValuePair<int, ConfigDataPropertyModifyInfo>> GetAllConfigDataPropertyModifyInfo();

		// Token: 0x06001A3C RID: 6716
		ConfigDataProtagonistInfo GetConfigDataProtagonistInfo(int key);

		// Token: 0x06001A3D RID: 6717
		IEnumerable LuaGetAllConfigDataProtagonistInfo();

		// Token: 0x06001A3E RID: 6718
		IEnumerable<KeyValuePair<int, ConfigDataProtagonistInfo>> GetAllConfigDataProtagonistInfo();

		// Token: 0x06001A3F RID: 6719
		ConfigDataPVPBattleInfo GetConfigDataPVPBattleInfo(int key);

		// Token: 0x06001A40 RID: 6720
		IEnumerable LuaGetAllConfigDataPVPBattleInfo();

		// Token: 0x06001A41 RID: 6721
		IEnumerable<KeyValuePair<int, ConfigDataPVPBattleInfo>> GetAllConfigDataPVPBattleInfo();

		// Token: 0x06001A42 RID: 6722
		ConfigDataRafflePoolInfo GetConfigDataRafflePoolInfo(int key);

		// Token: 0x06001A43 RID: 6723
		IEnumerable LuaGetAllConfigDataRafflePoolInfo();

		// Token: 0x06001A44 RID: 6724
		IEnumerable<KeyValuePair<int, ConfigDataRafflePoolInfo>> GetAllConfigDataRafflePoolInfo();

		// Token: 0x06001A45 RID: 6725
		ConfigDataRandomBoxInfo GetConfigDataRandomBoxInfo(int key);

		// Token: 0x06001A46 RID: 6726
		IEnumerable LuaGetAllConfigDataRandomBoxInfo();

		// Token: 0x06001A47 RID: 6727
		IEnumerable<KeyValuePair<int, ConfigDataRandomBoxInfo>> GetAllConfigDataRandomBoxInfo();

		// Token: 0x06001A48 RID: 6728
		ConfigDataRandomDropRewardInfo GetConfigDataRandomDropRewardInfo(int key);

		// Token: 0x06001A49 RID: 6729
		IEnumerable LuaGetAllConfigDataRandomDropRewardInfo();

		// Token: 0x06001A4A RID: 6730
		IEnumerable<KeyValuePair<int, ConfigDataRandomDropRewardInfo>> GetAllConfigDataRandomDropRewardInfo();

		// Token: 0x06001A4B RID: 6731
		ConfigDataRandomNameHead GetConfigDataRandomNameHead(int key);

		// Token: 0x06001A4C RID: 6732
		IEnumerable LuaGetAllConfigDataRandomNameHead();

		// Token: 0x06001A4D RID: 6733
		IEnumerable<KeyValuePair<int, ConfigDataRandomNameHead>> GetAllConfigDataRandomNameHead();

		// Token: 0x06001A4E RID: 6734
		ConfigDataRandomNameMiddle GetConfigDataRandomNameMiddle(int key);

		// Token: 0x06001A4F RID: 6735
		IEnumerable LuaGetAllConfigDataRandomNameMiddle();

		// Token: 0x06001A50 RID: 6736
		IEnumerable<KeyValuePair<int, ConfigDataRandomNameMiddle>> GetAllConfigDataRandomNameMiddle();

		// Token: 0x06001A51 RID: 6737
		ConfigDataRandomNameTail GetConfigDataRandomNameTail(int key);

		// Token: 0x06001A52 RID: 6738
		IEnumerable LuaGetAllConfigDataRandomNameTail();

		// Token: 0x06001A53 RID: 6739
		IEnumerable<KeyValuePair<int, ConfigDataRandomNameTail>> GetAllConfigDataRandomNameTail();

		// Token: 0x06001A54 RID: 6740
		ConfigDataRandomStoreInfo GetConfigDataRandomStoreInfo(int key);

		// Token: 0x06001A55 RID: 6741
		IEnumerable LuaGetAllConfigDataRandomStoreInfo();

		// Token: 0x06001A56 RID: 6742
		IEnumerable<KeyValuePair<int, ConfigDataRandomStoreInfo>> GetAllConfigDataRandomStoreInfo();

		// Token: 0x06001A57 RID: 6743
		ConfigDataRandomStoreItemInfo GetConfigDataRandomStoreItemInfo(int key);

		// Token: 0x06001A58 RID: 6744
		IEnumerable LuaGetAllConfigDataRandomStoreItemInfo();

		// Token: 0x06001A59 RID: 6745
		IEnumerable<KeyValuePair<int, ConfigDataRandomStoreItemInfo>> GetAllConfigDataRandomStoreItemInfo();

		// Token: 0x06001A5A RID: 6746
		ConfigDataRandomStoreLevelZoneInfo GetConfigDataRandomStoreLevelZoneInfo(int key);

		// Token: 0x06001A5B RID: 6747
		IEnumerable LuaGetAllConfigDataRandomStoreLevelZoneInfo();

		// Token: 0x06001A5C RID: 6748
		IEnumerable<KeyValuePair<int, ConfigDataRandomStoreLevelZoneInfo>> GetAllConfigDataRandomStoreLevelZoneInfo();

		// Token: 0x06001A5D RID: 6749
		ConfigDataRankInfo GetConfigDataRankInfo(int key);

		// Token: 0x06001A5E RID: 6750
		IEnumerable LuaGetAllConfigDataRankInfo();

		// Token: 0x06001A5F RID: 6751
		IEnumerable<KeyValuePair<int, ConfigDataRankInfo>> GetAllConfigDataRankInfo();

		// Token: 0x06001A60 RID: 6752
		ConfigDataRealTimePVPBattleInfo GetConfigDataRealTimePVPBattleInfo(int key);

		// Token: 0x06001A61 RID: 6753
		IEnumerable LuaGetAllConfigDataRealTimePVPBattleInfo();

		// Token: 0x06001A62 RID: 6754
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPBattleInfo>> GetAllConfigDataRealTimePVPBattleInfo();

		// Token: 0x06001A63 RID: 6755
		ConfigDataRealTimePVPDanInfo GetConfigDataRealTimePVPDanInfo(int key);

		// Token: 0x06001A64 RID: 6756
		IEnumerable LuaGetAllConfigDataRealTimePVPDanInfo();

		// Token: 0x06001A65 RID: 6757
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPDanInfo>> GetAllConfigDataRealTimePVPDanInfo();

		// Token: 0x06001A66 RID: 6758
		ConfigDataRealTimePVPDanRewardInfo GetConfigDataRealTimePVPDanRewardInfo(int key);

		// Token: 0x06001A67 RID: 6759
		IEnumerable LuaGetAllConfigDataRealTimePVPDanRewardInfo();

		// Token: 0x06001A68 RID: 6760
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPDanRewardInfo>> GetAllConfigDataRealTimePVPDanRewardInfo();

		// Token: 0x06001A69 RID: 6761
		ConfigDataRealTimePVPLocalRankingRewardInfo GetConfigDataRealTimePVPLocalRankingRewardInfo(int key);

		// Token: 0x06001A6A RID: 6762
		IEnumerable LuaGetAllConfigDataRealTimePVPLocalRankingRewardInfo();

		// Token: 0x06001A6B RID: 6763
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPLocalRankingRewardInfo>> GetAllConfigDataRealTimePVPLocalRankingRewardInfo();

		// Token: 0x06001A6C RID: 6764
		ConfigDataRealTimePVPNoviceMatchmakingInfo GetConfigDataRealTimePVPNoviceMatchmakingInfo(int key);

		// Token: 0x06001A6D RID: 6765
		IEnumerable LuaGetAllConfigDataRealTimePVPNoviceMatchmakingInfo();

		// Token: 0x06001A6E RID: 6766
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPNoviceMatchmakingInfo>> GetAllConfigDataRealTimePVPNoviceMatchmakingInfo();

		// Token: 0x06001A6F RID: 6767
		ConfigDataRealTimePVPRankingRewardInfo GetConfigDataRealTimePVPRankingRewardInfo(int key);

		// Token: 0x06001A70 RID: 6768
		IEnumerable LuaGetAllConfigDataRealTimePVPRankingRewardInfo();

		// Token: 0x06001A71 RID: 6769
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPRankingRewardInfo>> GetAllConfigDataRealTimePVPRankingRewardInfo();

		// Token: 0x06001A72 RID: 6770
		ConfigDataRealTimePVPSettleTimeInfo GetConfigDataRealTimePVPSettleTimeInfo(int key);

		// Token: 0x06001A73 RID: 6771
		IEnumerable LuaGetAllConfigDataRealTimePVPSettleTimeInfo();

		// Token: 0x06001A74 RID: 6772
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPSettleTimeInfo>> GetAllConfigDataRealTimePVPSettleTimeInfo();

		// Token: 0x06001A75 RID: 6773
		ConfigDataRealTimePVPWinsBonusInfo GetConfigDataRealTimePVPWinsBonusInfo(int key);

		// Token: 0x06001A76 RID: 6774
		IEnumerable LuaGetAllConfigDataRealTimePVPWinsBonusInfo();

		// Token: 0x06001A77 RID: 6775
		IEnumerable<KeyValuePair<int, ConfigDataRealTimePVPWinsBonusInfo>> GetAllConfigDataRealTimePVPWinsBonusInfo();

		// Token: 0x06001A78 RID: 6776
		ConfigDataRechargeStoreItemInfo GetConfigDataRechargeStoreItemInfo(int key);

		// Token: 0x06001A79 RID: 6777
		IEnumerable LuaGetAllConfigDataRechargeStoreItemInfo();

		// Token: 0x06001A7A RID: 6778
		IEnumerable<KeyValuePair<int, ConfigDataRechargeStoreItemInfo>> GetAllConfigDataRechargeStoreItemInfo();

		// Token: 0x06001A7B RID: 6779
		ConfigDataRegionInfo GetConfigDataRegionInfo(int key);

		// Token: 0x06001A7C RID: 6780
		IEnumerable LuaGetAllConfigDataRegionInfo();

		// Token: 0x06001A7D RID: 6781
		IEnumerable<KeyValuePair<int, ConfigDataRegionInfo>> GetAllConfigDataRegionInfo();

		// Token: 0x06001A7E RID: 6782
		ConfigDataResonanceInfo GetConfigDataResonanceInfo(int key);

		// Token: 0x06001A7F RID: 6783
		IEnumerable LuaGetAllConfigDataResonanceInfo();

		// Token: 0x06001A80 RID: 6784
		IEnumerable<KeyValuePair<int, ConfigDataResonanceInfo>> GetAllConfigDataResonanceInfo();

		// Token: 0x06001A81 RID: 6785
		ConfigDataRiftChapterInfo GetConfigDataRiftChapterInfo(int key);

		// Token: 0x06001A82 RID: 6786
		IEnumerable LuaGetAllConfigDataRiftChapterInfo();

		// Token: 0x06001A83 RID: 6787
		IEnumerable<KeyValuePair<int, ConfigDataRiftChapterInfo>> GetAllConfigDataRiftChapterInfo();

		// Token: 0x06001A84 RID: 6788
		ConfigDataRiftLevelInfo GetConfigDataRiftLevelInfo(int key);

		// Token: 0x06001A85 RID: 6789
		IEnumerable LuaGetAllConfigDataRiftLevelInfo();

		// Token: 0x06001A86 RID: 6790
		IEnumerable<KeyValuePair<int, ConfigDataRiftLevelInfo>> GetAllConfigDataRiftLevelInfo();

		// Token: 0x06001A87 RID: 6791
		ConfigDataScenarioInfo GetConfigDataScenarioInfo(int key);

		// Token: 0x06001A88 RID: 6792
		IEnumerable LuaGetAllConfigDataScenarioInfo();

		// Token: 0x06001A89 RID: 6793
		IEnumerable<KeyValuePair<int, ConfigDataScenarioInfo>> GetAllConfigDataScenarioInfo();

		// Token: 0x06001A8A RID: 6794
		ConfigDataScoreLevelInfo GetConfigDataScoreLevelInfo(int key);

		// Token: 0x06001A8B RID: 6795
		IEnumerable LuaGetAllConfigDataScoreLevelInfo();

		// Token: 0x06001A8C RID: 6796
		IEnumerable<KeyValuePair<int, ConfigDataScoreLevelInfo>> GetAllConfigDataScoreLevelInfo();

		// Token: 0x06001A8D RID: 6797
		ConfigDataSelectContentInfo GetConfigDataSelectContentInfo(int key);

		// Token: 0x06001A8E RID: 6798
		IEnumerable LuaGetAllConfigDataSelectContentInfo();

		// Token: 0x06001A8F RID: 6799
		IEnumerable<KeyValuePair<int, ConfigDataSelectContentInfo>> GetAllConfigDataSelectContentInfo();

		// Token: 0x06001A90 RID: 6800
		ConfigDataSelectProbabilityInfo GetConfigDataSelectProbabilityInfo(int key);

		// Token: 0x06001A91 RID: 6801
		IEnumerable LuaGetAllConfigDataSelectProbabilityInfo();

		// Token: 0x06001A92 RID: 6802
		IEnumerable<KeyValuePair<int, ConfigDataSelectProbabilityInfo>> GetAllConfigDataSelectProbabilityInfo();

		// Token: 0x06001A93 RID: 6803
		ConfigDataSelfSelectedBoxInfo GetConfigDataSelfSelectedBoxInfo(int key);

		// Token: 0x06001A94 RID: 6804
		IEnumerable LuaGetAllConfigDataSelfSelectedBoxInfo();

		// Token: 0x06001A95 RID: 6805
		IEnumerable<KeyValuePair<int, ConfigDataSelfSelectedBoxInfo>> GetAllConfigDataSelfSelectedBoxInfo();

		// Token: 0x06001A96 RID: 6806
		ConfigDataSensitiveWords GetConfigDataSensitiveWords(int key);

		// Token: 0x06001A97 RID: 6807
		IEnumerable LuaGetAllConfigDataSensitiveWords();

		// Token: 0x06001A98 RID: 6808
		IEnumerable<KeyValuePair<int, ConfigDataSensitiveWords>> GetAllConfigDataSensitiveWords();

		// Token: 0x06001A99 RID: 6809
		ConfigDataSignRewardInfo GetConfigDataSignRewardInfo(int key);

		// Token: 0x06001A9A RID: 6810
		IEnumerable LuaGetAllConfigDataSignRewardInfo();

		// Token: 0x06001A9B RID: 6811
		IEnumerable<KeyValuePair<int, ConfigDataSignRewardInfo>> GetAllConfigDataSignRewardInfo();

		// Token: 0x06001A9C RID: 6812
		ConfigDataSkillInfo GetConfigDataSkillInfo(int key);

		// Token: 0x06001A9D RID: 6813
		IEnumerable LuaGetAllConfigDataSkillInfo();

		// Token: 0x06001A9E RID: 6814
		IEnumerable<KeyValuePair<int, ConfigDataSkillInfo>> GetAllConfigDataSkillInfo();

		// Token: 0x06001A9F RID: 6815
		ConfigDataSmallExpressionPathInfo GetConfigDataSmallExpressionPathInfo(int key);

		// Token: 0x06001AA0 RID: 6816
		IEnumerable LuaGetAllConfigDataSmallExpressionPathInfo();

		// Token: 0x06001AA1 RID: 6817
		IEnumerable<KeyValuePair<int, ConfigDataSmallExpressionPathInfo>> GetAllConfigDataSmallExpressionPathInfo();

		// Token: 0x06001AA2 RID: 6818
		ConfigDataSoldierInfo GetConfigDataSoldierInfo(int key);

		// Token: 0x06001AA3 RID: 6819
		IEnumerable LuaGetAllConfigDataSoldierInfo();

		// Token: 0x06001AA4 RID: 6820
		IEnumerable<KeyValuePair<int, ConfigDataSoldierInfo>> GetAllConfigDataSoldierInfo();

		// Token: 0x06001AA5 RID: 6821
		ConfigDataSoldierSkinInfo GetConfigDataSoldierSkinInfo(int key);

		// Token: 0x06001AA6 RID: 6822
		IEnumerable LuaGetAllConfigDataSoldierSkinInfo();

		// Token: 0x06001AA7 RID: 6823
		IEnumerable<KeyValuePair<int, ConfigDataSoldierSkinInfo>> GetAllConfigDataSoldierSkinInfo();

		// Token: 0x06001AA8 RID: 6824
		ConfigDataSoundTable GetConfigDataSoundTable(int key);

		// Token: 0x06001AA9 RID: 6825
		IEnumerable LuaGetAllConfigDataSoundTable();

		// Token: 0x06001AAA RID: 6826
		IEnumerable<KeyValuePair<int, ConfigDataSoundTable>> GetAllConfigDataSoundTable();

		// Token: 0x06001AAB RID: 6827
		ConfigDataSpineAnimationSoundTable GetConfigDataSpineAnimationSoundTable(int key);

		// Token: 0x06001AAC RID: 6828
		IEnumerable LuaGetAllConfigDataSpineAnimationSoundTable();

		// Token: 0x06001AAD RID: 6829
		IEnumerable<KeyValuePair<int, ConfigDataSpineAnimationSoundTable>> GetAllConfigDataSpineAnimationSoundTable();

		// Token: 0x06001AAE RID: 6830
		ConfigDataSST_0_CN GetConfigDataSST_0_CN(int key);

		// Token: 0x06001AAF RID: 6831
		IEnumerable LuaGetAllConfigDataSST_0_CN();

		// Token: 0x06001AB0 RID: 6832
		IEnumerable<KeyValuePair<int, ConfigDataSST_0_CN>> GetAllConfigDataSST_0_CN();

		// Token: 0x06001AB1 RID: 6833
		ConfigDataSST_0_EN GetConfigDataSST_0_EN(int key);

		// Token: 0x06001AB2 RID: 6834
		IEnumerable LuaGetAllConfigDataSST_0_EN();

		// Token: 0x06001AB3 RID: 6835
		IEnumerable<KeyValuePair<int, ConfigDataSST_0_EN>> GetAllConfigDataSST_0_EN();

		// Token: 0x06001AB4 RID: 6836
		ConfigDataSST_1_CN GetConfigDataSST_1_CN(int key);

		// Token: 0x06001AB5 RID: 6837
		IEnumerable LuaGetAllConfigDataSST_1_CN();

		// Token: 0x06001AB6 RID: 6838
		IEnumerable<KeyValuePair<int, ConfigDataSST_1_CN>> GetAllConfigDataSST_1_CN();

		// Token: 0x06001AB7 RID: 6839
		ConfigDataSST_1_EN GetConfigDataSST_1_EN(int key);

		// Token: 0x06001AB8 RID: 6840
		IEnumerable LuaGetAllConfigDataSST_1_EN();

		// Token: 0x06001AB9 RID: 6841
		IEnumerable<KeyValuePair<int, ConfigDataSST_1_EN>> GetAllConfigDataSST_1_EN();

		// Token: 0x06001ABA RID: 6842
		ConfigDataStaticBoxInfo GetConfigDataStaticBoxInfo(int key);

		// Token: 0x06001ABB RID: 6843
		IEnumerable LuaGetAllConfigDataStaticBoxInfo();

		// Token: 0x06001ABC RID: 6844
		IEnumerable<KeyValuePair<int, ConfigDataStaticBoxInfo>> GetAllConfigDataStaticBoxInfo();

		// Token: 0x06001ABD RID: 6845
		ConfigDataStoreInfo GetConfigDataStoreInfo(int key);

		// Token: 0x06001ABE RID: 6846
		IEnumerable LuaGetAllConfigDataStoreInfo();

		// Token: 0x06001ABF RID: 6847
		IEnumerable<KeyValuePair<int, ConfigDataStoreInfo>> GetAllConfigDataStoreInfo();

		// Token: 0x06001AC0 RID: 6848
		ConfigDataStringTable GetConfigDataStringTable(int key);

		// Token: 0x06001AC1 RID: 6849
		IEnumerable LuaGetAllConfigDataStringTable();

		// Token: 0x06001AC2 RID: 6850
		IEnumerable<KeyValuePair<int, ConfigDataStringTable>> GetAllConfigDataStringTable();

		// Token: 0x06001AC3 RID: 6851
		ConfigDataStringTableForListInfo GetConfigDataStringTableForListInfo(int key);

		// Token: 0x06001AC4 RID: 6852
		IEnumerable LuaGetAllConfigDataStringTableForListInfo();

		// Token: 0x06001AC5 RID: 6853
		IEnumerable<KeyValuePair<int, ConfigDataStringTableForListInfo>> GetAllConfigDataStringTableForListInfo();

		// Token: 0x06001AC6 RID: 6854
		ConfigDataSurveyInfo GetConfigDataSurveyInfo(int key);

		// Token: 0x06001AC7 RID: 6855
		IEnumerable LuaGetAllConfigDataSurveyInfo();

		// Token: 0x06001AC8 RID: 6856
		IEnumerable<KeyValuePair<int, ConfigDataSurveyInfo>> GetAllConfigDataSurveyInfo();

		// Token: 0x06001AC9 RID: 6857
		ConfigDataSystemBroadcastInfo GetConfigDataSystemBroadcastInfo(int key);

		// Token: 0x06001ACA RID: 6858
		IEnumerable LuaGetAllConfigDataSystemBroadcastInfo();

		// Token: 0x06001ACB RID: 6859
		IEnumerable<KeyValuePair<int, ConfigDataSystemBroadcastInfo>> GetAllConfigDataSystemBroadcastInfo();

		// Token: 0x06001ACC RID: 6860
		ConfigDataTerrainInfo GetConfigDataTerrainInfo(int key);

		// Token: 0x06001ACD RID: 6861
		IEnumerable LuaGetAllConfigDataTerrainInfo();

		// Token: 0x06001ACE RID: 6862
		IEnumerable<KeyValuePair<int, ConfigDataTerrainInfo>> GetAllConfigDataTerrainInfo();

		// Token: 0x06001ACF RID: 6863
		ConfigDataThearchyTrialInfo GetConfigDataThearchyTrialInfo(int key);

		// Token: 0x06001AD0 RID: 6864
		IEnumerable LuaGetAllConfigDataThearchyTrialInfo();

		// Token: 0x06001AD1 RID: 6865
		IEnumerable<KeyValuePair<int, ConfigDataThearchyTrialInfo>> GetAllConfigDataThearchyTrialInfo();

		// Token: 0x06001AD2 RID: 6866
		ConfigDataThearchyTrialLevelInfo GetConfigDataThearchyTrialLevelInfo(int key);

		// Token: 0x06001AD3 RID: 6867
		IEnumerable LuaGetAllConfigDataThearchyTrialLevelInfo();

		// Token: 0x06001AD4 RID: 6868
		IEnumerable<KeyValuePair<int, ConfigDataThearchyTrialLevelInfo>> GetAllConfigDataThearchyTrialLevelInfo();

		// Token: 0x06001AD5 RID: 6869
		ConfigDataTicketLimitGameFunctionTypeInfo GetConfigDataTicketLimitGameFunctionTypeInfo(int key);

		// Token: 0x06001AD6 RID: 6870
		IEnumerable LuaGetAllConfigDataTicketLimitGameFunctionTypeInfo();

		// Token: 0x06001AD7 RID: 6871
		IEnumerable<KeyValuePair<int, ConfigDataTicketLimitGameFunctionTypeInfo>> GetAllConfigDataTicketLimitGameFunctionTypeInfo();

		// Token: 0x06001AD8 RID: 6872
		ConfigDataTicketLimitInfo GetConfigDataTicketLimitInfo(int key);

		// Token: 0x06001AD9 RID: 6873
		IEnumerable LuaGetAllConfigDataTicketLimitInfo();

		// Token: 0x06001ADA RID: 6874
		IEnumerable<KeyValuePair<int, ConfigDataTicketLimitInfo>> GetAllConfigDataTicketLimitInfo();

		// Token: 0x06001ADB RID: 6875
		ConfigDataTowerBattleRuleInfo GetConfigDataTowerBattleRuleInfo(int key);

		// Token: 0x06001ADC RID: 6876
		IEnumerable LuaGetAllConfigDataTowerBattleRuleInfo();

		// Token: 0x06001ADD RID: 6877
		IEnumerable<KeyValuePair<int, ConfigDataTowerBattleRuleInfo>> GetAllConfigDataTowerBattleRuleInfo();

		// Token: 0x06001ADE RID: 6878
		ConfigDataTowerBonusHeroGroupInfo GetConfigDataTowerBonusHeroGroupInfo(int key);

		// Token: 0x06001ADF RID: 6879
		IEnumerable LuaGetAllConfigDataTowerBonusHeroGroupInfo();

		// Token: 0x06001AE0 RID: 6880
		IEnumerable<KeyValuePair<int, ConfigDataTowerBonusHeroGroupInfo>> GetAllConfigDataTowerBonusHeroGroupInfo();

		// Token: 0x06001AE1 RID: 6881
		ConfigDataTowerFloorInfo GetConfigDataTowerFloorInfo(int key);

		// Token: 0x06001AE2 RID: 6882
		IEnumerable LuaGetAllConfigDataTowerFloorInfo();

		// Token: 0x06001AE3 RID: 6883
		IEnumerable<KeyValuePair<int, ConfigDataTowerFloorInfo>> GetAllConfigDataTowerFloorInfo();

		// Token: 0x06001AE4 RID: 6884
		ConfigDataTowerLevelInfo GetConfigDataTowerLevelInfo(int key);

		// Token: 0x06001AE5 RID: 6885
		IEnumerable LuaGetAllConfigDataTowerLevelInfo();

		// Token: 0x06001AE6 RID: 6886
		IEnumerable<KeyValuePair<int, ConfigDataTowerLevelInfo>> GetAllConfigDataTowerLevelInfo();

		// Token: 0x06001AE7 RID: 6887
		ConfigDataTrainingCourseInfo GetConfigDataTrainingCourseInfo(int key);

		// Token: 0x06001AE8 RID: 6888
		IEnumerable LuaGetAllConfigDataTrainingCourseInfo();

		// Token: 0x06001AE9 RID: 6889
		IEnumerable<KeyValuePair<int, ConfigDataTrainingCourseInfo>> GetAllConfigDataTrainingCourseInfo();

		// Token: 0x06001AEA RID: 6890
		ConfigDataTrainingRoomInfo GetConfigDataTrainingRoomInfo(int key);

		// Token: 0x06001AEB RID: 6891
		IEnumerable LuaGetAllConfigDataTrainingRoomInfo();

		// Token: 0x06001AEC RID: 6892
		IEnumerable<KeyValuePair<int, ConfigDataTrainingRoomInfo>> GetAllConfigDataTrainingRoomInfo();

		// Token: 0x06001AED RID: 6893
		ConfigDataTrainingRoomLevelInfo GetConfigDataTrainingRoomLevelInfo(int key);

		// Token: 0x06001AEE RID: 6894
		IEnumerable LuaGetAllConfigDataTrainingRoomLevelInfo();

		// Token: 0x06001AEF RID: 6895
		IEnumerable<KeyValuePair<int, ConfigDataTrainingRoomLevelInfo>> GetAllConfigDataTrainingRoomLevelInfo();

		// Token: 0x06001AF0 RID: 6896
		ConfigDataTrainingTechInfo GetConfigDataTrainingTechInfo(int key);

		// Token: 0x06001AF1 RID: 6897
		IEnumerable LuaGetAllConfigDataTrainingTechInfo();

		// Token: 0x06001AF2 RID: 6898
		IEnumerable<KeyValuePair<int, ConfigDataTrainingTechInfo>> GetAllConfigDataTrainingTechInfo();

		// Token: 0x06001AF3 RID: 6899
		ConfigDataTrainingTechLevelInfo GetConfigDataTrainingTechLevelInfo(int key);

		// Token: 0x06001AF4 RID: 6900
		IEnumerable LuaGetAllConfigDataTrainingTechLevelInfo();

		// Token: 0x06001AF5 RID: 6901
		IEnumerable<KeyValuePair<int, ConfigDataTrainingTechLevelInfo>> GetAllConfigDataTrainingTechLevelInfo();

		// Token: 0x06001AF6 RID: 6902
		ConfigDataTranslate GetConfigDataTranslate(int key);

		// Token: 0x06001AF7 RID: 6903
		IEnumerable LuaGetAllConfigDataTranslate();

		// Token: 0x06001AF8 RID: 6904
		IEnumerable<KeyValuePair<int, ConfigDataTranslate>> GetAllConfigDataTranslate();

		// Token: 0x06001AF9 RID: 6905
		ConfigDataTreasureLevelInfo GetConfigDataTreasureLevelInfo(int key);

		// Token: 0x06001AFA RID: 6906
		IEnumerable LuaGetAllConfigDataTreasureLevelInfo();

		// Token: 0x06001AFB RID: 6907
		IEnumerable<KeyValuePair<int, ConfigDataTreasureLevelInfo>> GetAllConfigDataTreasureLevelInfo();

		// Token: 0x06001AFC RID: 6908
		ConfigDataUnchartedScoreInfo GetConfigDataUnchartedScoreInfo(int key);

		// Token: 0x06001AFD RID: 6909
		IEnumerable LuaGetAllConfigDataUnchartedScoreInfo();

		// Token: 0x06001AFE RID: 6910
		IEnumerable<KeyValuePair<int, ConfigDataUnchartedScoreInfo>> GetAllConfigDataUnchartedScoreInfo();

		// Token: 0x06001AFF RID: 6911
		ConfigDataUnchartedScoreModelInfo GetConfigDataUnchartedScoreModelInfo(int key);

		// Token: 0x06001B00 RID: 6912
		IEnumerable LuaGetAllConfigDataUnchartedScoreModelInfo();

		// Token: 0x06001B01 RID: 6913
		IEnumerable<KeyValuePair<int, ConfigDataUnchartedScoreModelInfo>> GetAllConfigDataUnchartedScoreModelInfo();

		// Token: 0x06001B02 RID: 6914
		ConfigDataUnchartedScoreRewardGroupInfo GetConfigDataUnchartedScoreRewardGroupInfo(int key);

		// Token: 0x06001B03 RID: 6915
		IEnumerable LuaGetAllConfigDataUnchartedScoreRewardGroupInfo();

		// Token: 0x06001B04 RID: 6916
		IEnumerable<KeyValuePair<int, ConfigDataUnchartedScoreRewardGroupInfo>> GetAllConfigDataUnchartedScoreRewardGroupInfo();

		// Token: 0x06001B05 RID: 6917
		ConfigDataUserGuide GetConfigDataUserGuide(int key);

		// Token: 0x06001B06 RID: 6918
		IEnumerable LuaGetAllConfigDataUserGuide();

		// Token: 0x06001B07 RID: 6919
		IEnumerable<KeyValuePair<int, ConfigDataUserGuide>> GetAllConfigDataUserGuide();

		// Token: 0x06001B08 RID: 6920
		ConfigDataUserGuideDialogInfo GetConfigDataUserGuideDialogInfo(int key);

		// Token: 0x06001B09 RID: 6921
		IEnumerable LuaGetAllConfigDataUserGuideDialogInfo();

		// Token: 0x06001B0A RID: 6922
		IEnumerable<KeyValuePair<int, ConfigDataUserGuideDialogInfo>> GetAllConfigDataUserGuideDialogInfo();

		// Token: 0x06001B0B RID: 6923
		ConfigDataUserGuideStep GetConfigDataUserGuideStep(int key);

		// Token: 0x06001B0C RID: 6924
		IEnumerable LuaGetAllConfigDataUserGuideStep();

		// Token: 0x06001B0D RID: 6925
		IEnumerable<KeyValuePair<int, ConfigDataUserGuideStep>> GetAllConfigDataUserGuideStep();

		// Token: 0x06001B0E RID: 6926
		ConfigDataVersionInfo GetConfigDataVersionInfo(int key);

		// Token: 0x06001B0F RID: 6927
		IEnumerable LuaGetAllConfigDataVersionInfo();

		// Token: 0x06001B10 RID: 6928
		IEnumerable<KeyValuePair<int, ConfigDataVersionInfo>> GetAllConfigDataVersionInfo();

		// Token: 0x06001B11 RID: 6929
		ConfigDataWaypointInfo GetConfigDataWaypointInfo(int key);

		// Token: 0x06001B12 RID: 6930
		IEnumerable LuaGetAllConfigDataWaypointInfo();

		// Token: 0x06001B13 RID: 6931
		IEnumerable<KeyValuePair<int, ConfigDataWaypointInfo>> GetAllConfigDataWaypointInfo();

		// Token: 0x06001B14 RID: 6932
		ConfigDataWorldMapInfo GetConfigDataWorldMapInfo(int key);

		// Token: 0x06001B15 RID: 6933
		IEnumerable LuaGetAllConfigDataWorldMapInfo();

		// Token: 0x06001B16 RID: 6934
		IEnumerable<KeyValuePair<int, ConfigDataWorldMapInfo>> GetAllConfigDataWorldMapInfo();

		// Token: 0x06001B17 RID: 6935
		ConfigDataST_CN GetConfigDataST_CN(int key);

		// Token: 0x06001B18 RID: 6936
		IEnumerable<KeyValuePair<int, ConfigDataST_CN>> GetAllConfigDataST_CN();

		// Token: 0x06001B19 RID: 6937
		IEnumerable LuaGetAllConfigDataST_CN();

		// Token: 0x06001B1A RID: 6938
		IEnumerator GetConfigDataST_CN(int key, Action<ConfigDataST_CN> onResult);

		// Token: 0x06001B1B RID: 6939
		ConfigDataST_EN GetConfigDataST_EN(int key);

		// Token: 0x06001B1C RID: 6940
		IEnumerable<KeyValuePair<int, ConfigDataST_EN>> GetAllConfigDataST_EN();

		// Token: 0x06001B1D RID: 6941
		IEnumerable LuaGetAllConfigDataST_EN();

		// Token: 0x06001B1E RID: 6942
		IEnumerator GetConfigDataST_EN(int key, Action<ConfigDataST_EN> onResult);

		// Token: 0x06001B1F RID: 6943
		int UtilityInitialize();

		// Token: 0x06001B20 RID: 6944
		ArmyRelationData UtilityGetArmyRelationData(ArmyTag attacker, ArmyTag target);

		// Token: 0x06001B21 RID: 6945
		int UtilityGetConfigableConst(ConfigableConstId id);

		// Token: 0x06001B22 RID: 6946
		string UtilityGetConfigableConstString(ConfigableConstId id);

		// Token: 0x06001B23 RID: 6947
		string UtilityGetStringByStringTable(StringTableId id);

		// Token: 0x06001B24 RID: 6948
		int UtilityGetVersion(VersionInfoId id);

		// Token: 0x06001B25 RID: 6949
		string UtilityGetVersionString(VersionInfoId id);

		// Token: 0x06001B26 RID: 6950
		string UtilityGetSound(SoundTableId id);

		// Token: 0x06001B27 RID: 6951
		string UtilityGetFxFlipName(string fxName);

		// Token: 0x06001B28 RID: 6952
		SensitiveWords UtilityGetSensitiveWords();

		// Token: 0x17000484 RID: 1156
		// (get) Token: 0x06001B29 RID: 6953
		// (set) Token: 0x06001B2A RID: 6954
		int Const_BattleActorMoveSpeed { get; set; }

		// Token: 0x17000485 RID: 1157
		// (get) Token: 0x06001B2B RID: 6955
		// (set) Token: 0x06001B2C RID: 6956
		int Const_CombatHeroDistance { get; set; }

		// Token: 0x17000486 RID: 1158
		// (get) Token: 0x06001B2D RID: 6957
		// (set) Token: 0x06001B2E RID: 6958
		int Const_CombatSplitScreenDistance { get; set; }

		// Token: 0x17000487 RID: 1159
		// (get) Token: 0x06001B2F RID: 6959
		// (set) Token: 0x06001B30 RID: 6960
		int Const_MeleeATKPunish_Mult { get; set; }

		// Token: 0x17000488 RID: 1160
		// (get) Token: 0x06001B31 RID: 6961
		// (set) Token: 0x06001B32 RID: 6962
		int Const_SoldierMoveDelay { get; set; }

		// Token: 0x17000489 RID: 1161
		// (get) Token: 0x06001B33 RID: 6963
		// (set) Token: 0x06001B34 RID: 6964
		int Const_SoldierReturnDelay { get; set; }

		// Token: 0x1700048A RID: 1162
		// (get) Token: 0x06001B35 RID: 6965
		// (set) Token: 0x06001B36 RID: 6966
		int Const_SkillPauseTime { get; set; }

		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06001B37 RID: 6967
		// (set) Token: 0x06001B38 RID: 6968
		int Const_SkillPreCastDelay { get; set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06001B39 RID: 6969
		// (set) Token: 0x06001B3A RID: 6970
		int Const_DamagePostDelay { get; set; }

		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06001B3B RID: 6971
		// (set) Token: 0x06001B3C RID: 6972
		int Const_BuffHitPostDelay { get; set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06001B3D RID: 6973
		// (set) Token: 0x06001B3E RID: 6974
		int Const_SoldierCountMax { get; set; }

		// Token: 0x1700048F RID: 1167
		// (get) Token: 0x06001B3F RID: 6975
		// (set) Token: 0x06001B40 RID: 6976
		int Const_HPBarFxAccumulateTime { get; set; }

		// Token: 0x17000490 RID: 1168
		// (get) Token: 0x06001B41 RID: 6977
		// (set) Token: 0x06001B42 RID: 6978
		int Const_HPBarFxAccumulateDamage { get; set; }

		// Token: 0x17000491 RID: 1169
		// (get) Token: 0x06001B43 RID: 6979
		// (set) Token: 0x06001B44 RID: 6980
		int Const_CriticalDamageBase { get; set; }

		// Token: 0x17000492 RID: 1170
		// (get) Token: 0x06001B45 RID: 6981
		// (set) Token: 0x06001B46 RID: 6982
		int ConfigableConstId_FlushTime { get; set; }

		// Token: 0x17000493 RID: 1171
		// (get) Token: 0x06001B47 RID: 6983
		// (set) Token: 0x06001B48 RID: 6984
		int ConfigableConstId_FlushPeriodDay { get; set; }

		// Token: 0x17000494 RID: 1172
		// (get) Token: 0x06001B49 RID: 6985
		// (set) Token: 0x06001B4A RID: 6986
		int ConfigableConstId_TimeEventStartTime { get; set; }

		// Token: 0x17000495 RID: 1173
		// (get) Token: 0x06001B4B RID: 6987
		// (set) Token: 0x06001B4C RID: 6988
		int ConfigableConstId_TimeEventEndTime { get; set; }

		// Token: 0x17000496 RID: 1174
		// (get) Token: 0x06001B4D RID: 6989
		// (set) Token: 0x06001B4E RID: 6990
		int ConfigableConstId_TimeEventMinCount { get; set; }

		// Token: 0x17000497 RID: 1175
		// (get) Token: 0x06001B4F RID: 6991
		// (set) Token: 0x06001B50 RID: 6992
		int ConfigableConstId_TimeEventMaxCount { get; set; }

		// Token: 0x17000498 RID: 1176
		// (get) Token: 0x06001B51 RID: 6993
		// (set) Token: 0x06001B52 RID: 6994
		int ConfigableConstId_RiftLevelActionEventProbality { get; set; }

		// Token: 0x17000499 RID: 1177
		// (get) Token: 0x06001B53 RID: 6995
		// (set) Token: 0x06001B54 RID: 6996
		int ConfigableConstId_ScenarioActionEventProbality { get; set; }

		// Token: 0x1700049A RID: 1178
		// (get) Token: 0x06001B55 RID: 6997
		// (set) Token: 0x06001B56 RID: 6998
		int ConfigableConstId_EventActionEventProbality { get; set; }

		// Token: 0x1700049B RID: 1179
		// (get) Token: 0x06001B57 RID: 6999
		// (set) Token: 0x06001B58 RID: 7000
		int ConfigableConstId_ProbalityMax { get; set; }

		// Token: 0x1700049C RID: 1180
		// (get) Token: 0x06001B59 RID: 7001
		// (set) Token: 0x06001B5A RID: 7002
		int ConfigableConstId_ActionEventMaxCount { get; set; }

		// Token: 0x1700049D RID: 1181
		// (get) Token: 0x06001B5B RID: 7003
		// (set) Token: 0x06001B5C RID: 7004
		int ConfigableConstId_MapRandomEventMaxCount { get; set; }

		// Token: 0x1700049E RID: 1182
		// (get) Token: 0x06001B5D RID: 7005
		// (set) Token: 0x06001B5E RID: 7006
		int ConfigableConstId_EnergyAddPeriod { get; set; }

		// Token: 0x1700049F RID: 1183
		// (get) Token: 0x06001B5F RID: 7007
		// (set) Token: 0x06001B60 RID: 7008
		int ConfigableConstId_EnergyMax { get; set; }

		// Token: 0x170004A0 RID: 1184
		// (get) Token: 0x06001B61 RID: 7009
		// (set) Token: 0x06001B62 RID: 7010
		int ConfigableConstId_BagMaxCapacity { get; set; }

		// Token: 0x170004A1 RID: 1185
		// (get) Token: 0x06001B63 RID: 7011
		// (set) Token: 0x06001B64 RID: 7012
		int ConfigableConstId_HeroJobRankMax { get; set; }

		// Token: 0x170004A2 RID: 1186
		// (get) Token: 0x06001B65 RID: 7013
		// (set) Token: 0x06001B66 RID: 7014
		int ConfigableConstId_HeroLevelUpCeiling { get; set; }

		// Token: 0x170004A3 RID: 1187
		// (get) Token: 0x06001B67 RID: 7015
		// (set) Token: 0x06001B68 RID: 7016
		int ConfigableConstId_SelectSkillsMaxCount { get; set; }

		// Token: 0x170004A4 RID: 1188
		// (get) Token: 0x06001B69 RID: 7017
		// (set) Token: 0x06001B6A RID: 7018
		int ConfigableConstId_BagGridMaxCapacity { get; set; }

		// Token: 0x170004A5 RID: 1189
		// (get) Token: 0x06001B6B RID: 7019
		// (set) Token: 0x06001B6C RID: 7020
		int ConfigableConstId_HeroStarLevelMax { get; set; }

		// Token: 0x170004A6 RID: 1190
		// (get) Token: 0x06001B6D RID: 7021
		// (set) Token: 0x06001B6E RID: 7022
		int ConfigableConstId_RiftLevelMaxStar { get; set; }

		// Token: 0x170004A7 RID: 1191
		// (get) Token: 0x06001B6F RID: 7023
		// (set) Token: 0x06001B70 RID: 7024
		int ConfigableConstId_JobStartLeve { get; set; }

		// Token: 0x170004A8 RID: 1192
		// (get) Token: 0x06001B71 RID: 7025
		// (set) Token: 0x06001B72 RID: 7026
		int ConfigableConstId_FirstScenarioId { get; set; }

		// Token: 0x170004A9 RID: 1193
		// (get) Token: 0x06001B73 RID: 7027
		// (set) Token: 0x06001B74 RID: 7028
		int ConfigableConstId_FirstWayPointId { get; set; }

		// Token: 0x170004AA RID: 1194
		// (get) Token: 0x06001B75 RID: 7029
		// (set) Token: 0x06001B76 RID: 7030
		int ConfigableConstId_MailBoxMaxSize { get; set; }

		// Token: 0x170004AB RID: 1195
		// (get) Token: 0x06001B77 RID: 7031
		// (set) Token: 0x06001B78 RID: 7032
		int ConfigableConstId_WeaponSlotId { get; set; }

		// Token: 0x170004AC RID: 1196
		// (get) Token: 0x06001B79 RID: 7033
		// (set) Token: 0x06001B7A RID: 7034
		int ConfigableConstId_ArmorSlotId { get; set; }

		// Token: 0x170004AD RID: 1197
		// (get) Token: 0x06001B7B RID: 7035
		// (set) Token: 0x06001B7C RID: 7036
		int ConfigableConstId_OrnamentSlotId { get; set; }

		// Token: 0x170004AE RID: 1198
		// (get) Token: 0x06001B7D RID: 7037
		// (set) Token: 0x06001B7E RID: 7038
		int ConfigableConstId_ShoeSlotId { get; set; }

		// Token: 0x170004AF RID: 1199
		// (get) Token: 0x06001B7F RID: 7039
		// (set) Token: 0x06001B80 RID: 7040
		int ConfigableConstId_FirstInitId { get; set; }

		// Token: 0x170004B0 RID: 1200
		// (get) Token: 0x06001B81 RID: 7041
		// (set) Token: 0x06001B82 RID: 7042
		int ConfigableConstId_PlayerLevelMaxLevel { get; set; }

		// Token: 0x170004B1 RID: 1201
		// (get) Token: 0x06001B83 RID: 7043
		// (set) Token: 0x06001B84 RID: 7044
		int ConfigableConstId_ChatMessageMaxLength { get; set; }

		// Token: 0x170004B2 RID: 1202
		// (get) Token: 0x06001B85 RID: 7045
		// (set) Token: 0x06001B86 RID: 7046
		int ConfigableConstId_WorldChatIntervalTime { get; set; }

		// Token: 0x170004B3 RID: 1203
		// (get) Token: 0x06001B87 RID: 7047
		// (set) Token: 0x06001B88 RID: 7048
		int ConfigableConstId_AllowChatPlayerLevel { get; set; }

		// Token: 0x170004B4 RID: 1204
		// (get) Token: 0x06001B89 RID: 7049
		// (set) Token: 0x06001B8A RID: 7050
		int ConfigableConstId_SystemSelectCardHeroBroadcast { get; set; }

		// Token: 0x170004B5 RID: 1205
		// (get) Token: 0x06001B8B RID: 7051
		// (set) Token: 0x06001B8C RID: 7052
		int ConfigableConstId_MagicStoneId { get; set; }

		// Token: 0x170004B6 RID: 1206
		// (get) Token: 0x06001B8D RID: 7053
		// (set) Token: 0x06001B8E RID: 7054
		int ConfigableConstId_BuyEnergyCount { get; set; }

		// Token: 0x170004B7 RID: 1207
		// (get) Token: 0x06001B8F RID: 7055
		// (set) Token: 0x06001B90 RID: 7056
		int ConfigableConstId_HeroCommentMaxLength { get; set; }

		// Token: 0x170004B8 RID: 1208
		// (get) Token: 0x06001B91 RID: 7057
		// (set) Token: 0x06001B92 RID: 7058
		int ConfigableConstId_HeroCommentMaxNums { get; set; }

		// Token: 0x170004B9 RID: 1209
		// (get) Token: 0x06001B93 RID: 7059
		// (set) Token: 0x06001B94 RID: 7060
		int ConfigableConstId_PlayerSingleHeroCommentMaxNums { get; set; }

		// Token: 0x170004BA RID: 1210
		// (get) Token: 0x06001B95 RID: 7061
		// (set) Token: 0x06001B96 RID: 7062
		int ConfigableConstId_MaxPopularCommentEntry { get; set; }

		// Token: 0x170004BB RID: 1211
		// (get) Token: 0x06001B97 RID: 7063
		// (set) Token: 0x06001B98 RID: 7064
		int ConfigableConstId_AllowArenaPlayerLevel { get; set; }

		// Token: 0x170004BC RID: 1212
		// (get) Token: 0x06001B99 RID: 7065
		// (set) Token: 0x06001B9A RID: 7066
		int ConfigableConstId_ArenaGivenTicketMaxNums { get; set; }

		// Token: 0x170004BD RID: 1213
		// (get) Token: 0x06001B9B RID: 7067
		// (set) Token: 0x06001B9C RID: 7068
		int ConfigableConstId_LevelRaidTicketID { get; set; }

		// Token: 0x170004BE RID: 1214
		// (get) Token: 0x06001B9D RID: 7069
		// (set) Token: 0x06001B9E RID: 7070
		int ConfigableConstId_ArenaFightExpiredTimeInterval { get; set; }

		// Token: 0x170004BF RID: 1215
		// (get) Token: 0x06001B9F RID: 7071
		// (set) Token: 0x06001BA0 RID: 7072
		int ConfigableConstId_ProtagonistHeroID { get; set; }

		// Token: 0x170004C0 RID: 1216
		// (get) Token: 0x06001BA1 RID: 7073
		// (set) Token: 0x06001BA2 RID: 7074
		int ConfigableConstId_PlayerNameMaxLength { get; set; }

		// Token: 0x170004C1 RID: 1217
		// (get) Token: 0x06001BA3 RID: 7075
		// (set) Token: 0x06001BA4 RID: 7076
		int ConfigableConstId_ArenaBattleReportMaxNums { get; set; }

		// Token: 0x170004C2 RID: 1218
		// (get) Token: 0x06001BA5 RID: 7077
		// (set) Token: 0x06001BA6 RID: 7078
		int ConfigableConstId_ArenaVictoryPointsRewardMaxVictionaryPoints { get; set; }

		// Token: 0x170004C3 RID: 1219
		// (get) Token: 0x06001BA7 RID: 7079
		// (set) Token: 0x06001BA8 RID: 7080
		int ConfigableConstId_ArenaOneTimeGiveTicketsNums { get; set; }

		// Token: 0x170004C4 RID: 1220
		// (get) Token: 0x06001BA9 RID: 7081
		// (set) Token: 0x06001BAA RID: 7082
		int ConfigableConstId_ArenaInitialPoints { get; set; }

		// Token: 0x170004C5 RID: 1221
		// (get) Token: 0x06001BAB RID: 7083
		// (set) Token: 0x06001BAC RID: 7084
		int ConfigableConstId_ArenaOneTimeAttackUseTicketsNums { get; set; }

		// Token: 0x170004C6 RID: 1222
		// (get) Token: 0x06001BAD RID: 7085
		// (set) Token: 0x06001BAE RID: 7086
		int ConfigableConstId_ArenaAttackSuccessRandomDropRewardID { get; set; }

		// Token: 0x170004C7 RID: 1223
		// (get) Token: 0x06001BAF RID: 7087
		// (set) Token: 0x06001BB0 RID: 7088
		int ConfigableConstId_ArenaRealWeekSettleDeltaTime { get; set; }

		// Token: 0x170004C8 RID: 1224
		// (get) Token: 0x06001BB1 RID: 7089
		// (set) Token: 0x06001BB2 RID: 7090
		int ConfigableConstId_ChangeNameCostNums { get; set; }

		// Token: 0x170004C9 RID: 1225
		// (get) Token: 0x06001BB3 RID: 7091
		// (set) Token: 0x06001BB4 RID: 7092
		int ConfigableConstId_PlayerInitialHeroInteractNums { get; set; }

		// Token: 0x170004CA RID: 1226
		// (get) Token: 0x06001BB5 RID: 7093
		// (set) Token: 0x06001BB6 RID: 7094
		int ConfigableConstId_HeroInteractNumsRecoveryPeriod { get; set; }

		// Token: 0x170004CB RID: 1227
		// (get) Token: 0x06001BB7 RID: 7095
		// (set) Token: 0x06001BB8 RID: 7096
		int ConfigableConstId_HeroIteractMaxNums { get; set; }

		// Token: 0x170004CC RID: 1228
		// (get) Token: 0x06001BB9 RID: 7097
		// (set) Token: 0x06001BBA RID: 7098
		int ConfigableConstId_HeroIntimateMaxValue { get; set; }

		// Token: 0x170004CD RID: 1229
		// (get) Token: 0x06001BBB RID: 7099
		// (set) Token: 0x06001BBC RID: 7100
		int ConfigableConstId_EnhanceEquipmentConsumeGoldPerExp { get; set; }

		// Token: 0x170004CE RID: 1230
		// (get) Token: 0x06001BBD RID: 7101
		// (set) Token: 0x06001BBE RID: 7102
		int ConfigableConstId_LevelUpEquipmentStarConsumeGoldPerStar { get; set; }

		// Token: 0x170004CF RID: 1231
		// (get) Token: 0x06001BBF RID: 7103
		// (set) Token: 0x06001BC0 RID: 7104
		int ConfigableConstId_BuyArenaTicketCount { get; set; }

		// Token: 0x170004D0 RID: 1232
		// (get) Token: 0x06001BC1 RID: 7105
		// (set) Token: 0x06001BC2 RID: 7106
		int ConfigableConstId_HeroDungeonLevelMaxStar { get; set; }

		// Token: 0x170004D1 RID: 1233
		// (get) Token: 0x06001BC3 RID: 7107
		// (set) Token: 0x06001BC4 RID: 7108
		int ConfigableConstId_ArenaAddHeroExp { get; set; }

		// Token: 0x170004D2 RID: 1234
		// (get) Token: 0x06001BC5 RID: 7109
		// (set) Token: 0x06001BC6 RID: 7110
		int ConfigableConstId_ArenaAddPlayerExp { get; set; }

		// Token: 0x170004D3 RID: 1235
		// (get) Token: 0x06001BC7 RID: 7111
		// (set) Token: 0x06001BC8 RID: 7112
		int ConfigableConstId_SystemSelectCardEquipmentBroadcast { get; set; }

		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x06001BC9 RID: 7113
		// (set) Token: 0x06001BCA RID: 7114
		int ConfigableConstId_UserGuideRandomEventId { get; set; }

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x06001BCB RID: 7115
		// (set) Token: 0x06001BCC RID: 7116
		int ConfigableConstId_WriteSurveyPlayerLevel { get; set; }

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06001BCD RID: 7117
		// (set) Token: 0x06001BCE RID: 7118
		int ConfigableConstId_AutoEquipmentDeltaTime { get; set; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06001BCF RID: 7119
		// (set) Token: 0x06001BD0 RID: 7120
		int ConfigableConstId_MaxLevelDanmakuEntryLength { get; set; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06001BD1 RID: 7121
		// (set) Token: 0x06001BD2 RID: 7122
		int ConfigableConstId_MaxLevelDanmakuEntryNumsPerTurn { get; set; }

		// Token: 0x170004D9 RID: 1241
		// (get) Token: 0x06001BD3 RID: 7123
		// (set) Token: 0x06001BD4 RID: 7124
		int ConfigableConstId_TeamRoomInviteDeltaTime { get; set; }

		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06001BD5 RID: 7125
		// (set) Token: 0x06001BD6 RID: 7126
		int BuyEnergyMaxNums { get; set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06001BD7 RID: 7127
		// (set) Token: 0x06001BD8 RID: 7128
		int BuyArenaTicketMaxNums { get; set; }

		// Token: 0x170004DC RID: 1244
		// (get) Token: 0x06001BD9 RID: 7129
		// (set) Token: 0x06001BDA RID: 7130
		int ConfigableConstId_BusinessCardDescMaxLength { get; set; }

		// Token: 0x170004DD RID: 1245
		// (get) Token: 0x06001BDB RID: 7131
		// (set) Token: 0x06001BDC RID: 7132
		int ConfigableConstId_BusinessCardHeroMaxNums { get; set; }

		// Token: 0x170004DE RID: 1246
		// (get) Token: 0x06001BDD RID: 7133
		// (set) Token: 0x06001BDE RID: 7134
		int ConfigableConstId_SendFriendShipPointsEverytime { get; set; }

		// Token: 0x170004DF RID: 1247
		// (get) Token: 0x06001BDF RID: 7135
		// (set) Token: 0x06001BE0 RID: 7136
		int ConfigableConstId_SendFriendShipPointsMaxTimes { get; set; }

		// Token: 0x170004E0 RID: 1248
		// (get) Token: 0x06001BE1 RID: 7137
		// (set) Token: 0x06001BE2 RID: 7138
		int ConfigableConstId_ReceiveFriendShipPointsMaxTimes { get; set; }

		// Token: 0x170004E1 RID: 1249
		// (get) Token: 0x06001BE3 RID: 7139
		// (set) Token: 0x06001BE4 RID: 7140
		int ConfigableConstId_UseBoxItemMaxCount { get; set; }

		// Token: 0x170004E2 RID: 1250
		// (get) Token: 0x06001BE5 RID: 7141
		// (set) Token: 0x06001BE6 RID: 7142
		int ConfigableConstId_ServerTolerateClientSpeedUpMaxNums { get; set; }

		// Token: 0x170004E3 RID: 1251
		// (get) Token: 0x06001BE7 RID: 7143
		// (set) Token: 0x06001BE8 RID: 7144
		int ConfigableConstId_ServerCheckClientHeartBeatReachMinPeriod { get; set; }

		// Token: 0x170004E4 RID: 1252
		// (get) Token: 0x06001BE9 RID: 7145
		// (set) Token: 0x06001BEA RID: 7146
		int ConfigableConstId_ClientSendHeartBeatPeriod { get; set; }

		// Token: 0x170004E5 RID: 1253
		// (get) Token: 0x06001BEB RID: 7147
		// (set) Token: 0x06001BEC RID: 7148
		int ConfigableConstId_SearchUserByNameResultMax { get; set; }

		// Token: 0x170004E6 RID: 1254
		// (get) Token: 0x06001BED RID: 7149
		// (set) Token: 0x06001BEE RID: 7150
		int ConfigableConstId_MaxDomesticFriends { get; set; }

		// Token: 0x170004E7 RID: 1255
		// (get) Token: 0x06001BEF RID: 7151
		// (set) Token: 0x06001BF0 RID: 7152
		int ConfigableConstId_MaxForeignFriends { get; set; }

		// Token: 0x170004E8 RID: 1256
		// (get) Token: 0x06001BF1 RID: 7153
		// (set) Token: 0x06001BF2 RID: 7154
		int ConfigableConstId_MaxBlacklist { get; set; }

		// Token: 0x170004E9 RID: 1257
		// (get) Token: 0x06001BF3 RID: 7155
		// (set) Token: 0x06001BF4 RID: 7156
		int ConfigableConstId_MaxInvites { get; set; }

		// Token: 0x170004EA RID: 1258
		// (get) Token: 0x06001BF5 RID: 7157
		// (set) Token: 0x06001BF6 RID: 7158
		int ConfigableConstId_MaxSuggestedUsers { get; set; }

		// Token: 0x170004EB RID: 1259
		// (get) Token: 0x06001BF7 RID: 7159
		// (set) Token: 0x06001BF8 RID: 7160
		int ConfigableConstId_MaxLevelDiffMultiply { get; set; }

		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06001BF9 RID: 7161
		// (set) Token: 0x06001BFA RID: 7162
		int ConfigableConstId_SuggestedUserLevelDiff { get; set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06001BFB RID: 7163
		// (set) Token: 0x06001BFC RID: 7164
		int ConfigableConstId_InviteExpireSeconds { get; set; }

		// Token: 0x170004EE RID: 1262
		// (get) Token: 0x06001BFD RID: 7165
		// (set) Token: 0x06001BFE RID: 7166
		int ConfigableConstId_RecentContactsMaxCount { get; set; }

		// Token: 0x170004EF RID: 1263
		// (get) Token: 0x06001BFF RID: 7167
		// (set) Token: 0x06001C00 RID: 7168
		int ConfigableConstId_HeroAssistantTaskHeroAssignMaxCount { get; set; }

		// Token: 0x170004F0 RID: 1264
		// (get) Token: 0x06001C01 RID: 7169
		// (set) Token: 0x06001C02 RID: 7170
		int ConfigableConstId_MaxGroupsPerUser { get; set; }

		// Token: 0x170004F1 RID: 1265
		// (get) Token: 0x06001C03 RID: 7171
		// (set) Token: 0x06001C04 RID: 7172
		int ConfigableConstId_MaxGroupMembers { get; set; }

		// Token: 0x170004F2 RID: 1266
		// (get) Token: 0x06001C05 RID: 7173
		// (set) Token: 0x06001C06 RID: 7174
		int ConfigableConstId_BattleInviteFriendsToPracticeMaxWaitInterval { get; set; }

		// Token: 0x170004F3 RID: 1267
		// (get) Token: 0x06001C07 RID: 7175
		// (set) Token: 0x06001C08 RID: 7176
		int ConfigableConstId_DayBonusNum_Aniki { get; set; }

		// Token: 0x170004F4 RID: 1268
		// (get) Token: 0x06001C09 RID: 7177
		// (set) Token: 0x06001C0A RID: 7178
		int ConfigableConstId_DayBonusNum_ThearchyTrial { get; set; }

		// Token: 0x170004F5 RID: 1269
		// (get) Token: 0x06001C0B RID: 7179
		// (set) Token: 0x06001C0C RID: 7180
		int ConfigableConstId_DayBonusNum_HeroTrain { get; set; }

		// Token: 0x170004F6 RID: 1270
		// (get) Token: 0x06001C0D RID: 7181
		// (set) Token: 0x06001C0E RID: 7182
		int ConfigableConstId_DayBonusNum_MemoryCorridor { get; set; }

		// Token: 0x170004F7 RID: 1271
		// (get) Token: 0x06001C0F RID: 7183
		// (set) Token: 0x06001C10 RID: 7184
		int ConfigableConstId_DayBonusNum_Crusade { get; set; }

		// Token: 0x170004F8 RID: 1272
		// (get) Token: 0x06001C11 RID: 7185
		// (set) Token: 0x06001C12 RID: 7186
		int ConfigableConstId_FriendPointsFightWithFriends { get; set; }

		// Token: 0x170004F9 RID: 1273
		// (get) Token: 0x06001C13 RID: 7187
		// (set) Token: 0x06001C14 RID: 7188
		int ConfigableConstId_MaxFriendPointsFightWithFriendsEveryday { get; set; }

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x06001C15 RID: 7189
		// (set) Token: 0x06001C16 RID: 7190
		int ConfigableConstId_BattleRoomPlayerReconnectTimeOutTime { get; set; }

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x06001C17 RID: 7191
		// (set) Token: 0x06001C18 RID: 7192
		int ConfigableConstId_TeamBattleRoomPlayerActionClientTimeOutTime { get; set; }

		// Token: 0x170004FC RID: 1276
		// (get) Token: 0x06001C19 RID: 7193
		// (set) Token: 0x06001C1A RID: 7194
		int ConfigableConstId_PVPBattleRoomPlayerActionClientTimeOutTime { get; set; }

		// Token: 0x170004FD RID: 1277
		// (get) Token: 0x06001C1B RID: 7195
		// (set) Token: 0x06001C1C RID: 7196
		int ConfigableConstId_TeamBattleRoomPlayerActionServerTimeOutTime { get; set; }

		// Token: 0x170004FE RID: 1278
		// (get) Token: 0x06001C1D RID: 7197
		// (set) Token: 0x06001C1E RID: 7198
		int ConfigableConstId_PVPBattleRoomPlayerActionServerTimeOutTime { get; set; }

		// Token: 0x170004FF RID: 1279
		// (get) Token: 0x06001C1F RID: 7199
		// (set) Token: 0x06001C20 RID: 7200
		int ConfigableConstId_TeamFriendShipPointRewardPerFriend { get; set; }

		// Token: 0x17000500 RID: 1280
		// (get) Token: 0x06001C21 RID: 7201
		// (set) Token: 0x06001C22 RID: 7202
		int ConfigableConstId_MaxEnchantSamePropertyNums { get; set; }

		// Token: 0x17000501 RID: 1281
		// (get) Token: 0x06001C23 RID: 7203
		// (set) Token: 0x06001C24 RID: 7204
		int ConfigableConstId_TeamInvitationTimeoutTime { get; set; }

		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06001C25 RID: 7205
		// (set) Token: 0x06001C26 RID: 7206
		int ConfigableConstId_PVPInvitationTimeoutTime { get; set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06001C27 RID: 7207
		// (set) Token: 0x06001C28 RID: 7208
		int ConfigableConstId_DecomposeEquipmentBackGoldPercent { get; set; }

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06001C29 RID: 7209
		// (set) Token: 0x06001C2A RID: 7210
		int ConfigableConstId_RecentContactsChatMaxCount { get; set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06001C2B RID: 7211
		// (set) Token: 0x06001C2C RID: 7212
		int ConfigableConstId_RecentContactsTeamBattleMaxCount { get; set; }

		// Token: 0x17000506 RID: 1286
		// (get) Token: 0x06001C2D RID: 7213
		// (set) Token: 0x06001C2E RID: 7214
		int ConfigableConstId_DayBonusNum_CooperateBattle { get; set; }

		// Token: 0x17000507 RID: 1287
		// (get) Token: 0x06001C2F RID: 7215
		// (set) Token: 0x06001C30 RID: 7216
		int ConfigableConstId_HeroAssistantTaskSlotCount { get; set; }

		// Token: 0x17000508 RID: 1288
		// (get) Token: 0x06001C31 RID: 7217
		// (set) Token: 0x06001C32 RID: 7218
		int ConfigableConstId_ChatGroupNameMaxLength { get; set; }

		// Token: 0x17000509 RID: 1289
		// (get) Token: 0x06001C33 RID: 7219
		// (set) Token: 0x06001C34 RID: 7220
		int ConfigableConstId_ChatGroupCreateMinUserCount { get; set; }

		// Token: 0x1700050A RID: 1290
		// (get) Token: 0x06001C35 RID: 7221
		// (set) Token: 0x06001C36 RID: 7222
		int ConfigableConstId_ChatGroupDisbandUserCount { get; set; }

		// Token: 0x1700050B RID: 1291
		// (get) Token: 0x06001C37 RID: 7223
		// (set) Token: 0x06001C38 RID: 7224
		int ConfigableConstId_DefaultHeadFrameId { get; set; }

		// Token: 0x1700050C RID: 1292
		// (get) Token: 0x06001C39 RID: 7225
		// (set) Token: 0x06001C3A RID: 7226
		int ConfigableConstId_RequestAppReviewInScenario { get; set; }

		// Token: 0x1700050D RID: 1293
		// (get) Token: 0x06001C3B RID: 7227
		// (set) Token: 0x06001C3C RID: 7228
		int ConfigableConstId_IsRequestAppReviewOn { get; set; }

		// Token: 0x1700050E RID: 1294
		// (get) Token: 0x06001C3D RID: 7229
		// (set) Token: 0x06001C3E RID: 7230
		int ConfigableConstId_GainMaximum { get; set; }

		// Token: 0x1700050F RID: 1295
		// (get) Token: 0x06001C3F RID: 7231
		// (set) Token: 0x06001C40 RID: 7232
		int RealTimePVPInclusiveMinDan { get; set; }

		// Token: 0x17000510 RID: 1296
		// (get) Token: 0x06001C41 RID: 7233
		// (set) Token: 0x06001C42 RID: 7234
		int RealTimePVPExclusiveMaxDan { get; set; }

		// Token: 0x17000511 RID: 1297
		// (get) Token: 0x06001C43 RID: 7235
		// (set) Token: 0x06001C44 RID: 7236
		int RealTimeArenaNewPlayerMatchCount { get; set; }

		// Token: 0x17000512 RID: 1298
		// (get) Token: 0x06001C45 RID: 7237
		// (set) Token: 0x06001C46 RID: 7238
		int ConfigableConstId_RealTimePVPMinRequiredLevel { get; set; }

		// Token: 0x17000513 RID: 1299
		// (get) Token: 0x06001C47 RID: 7239
		// (set) Token: 0x06001C48 RID: 7240
		int ConfigableConstId_RealTimePVPBotPlayDeadIntervalMin { get; set; }

		// Token: 0x17000514 RID: 1300
		// (get) Token: 0x06001C49 RID: 7241
		// (set) Token: 0x06001C4A RID: 7242
		int ConfigableConstId_RealTimePVPBotPlayDeadIntervalMax { get; set; }

		// Token: 0x17000515 RID: 1301
		// (get) Token: 0x06001C4B RID: 7243
		// (set) Token: 0x06001C4C RID: 7244
		int ConfigableConstId_AlchemyMaxNum { get; set; }

		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06001C4D RID: 7245
		// (set) Token: 0x06001C4E RID: 7246
		int ConfigableConstId_RealTimePVPBattleReportMaxNums { get; set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06001C4F RID: 7247
		// (set) Token: 0x06001C50 RID: 7248
		int ConfigableConstId_NewUserAccumulatedMinValue { get; set; }

		// Token: 0x17000518 RID: 1304
		// (get) Token: 0x06001C51 RID: 7249
		// (set) Token: 0x06001C52 RID: 7250
		int ConfigableConstId_NewUserAccumulatedMaxValue { get; set; }

		// Token: 0x17000519 RID: 1305
		// (get) Token: 0x06001C53 RID: 7251
		// (set) Token: 0x06001C54 RID: 7252
		int ConfigableConstId_OldUserAccumulatedMinValue { get; set; }

		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06001C55 RID: 7253
		// (set) Token: 0x06001C56 RID: 7254
		int ConfigableConstId_OldUserAccumulatedMaxValue { get; set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06001C57 RID: 7255
		// (set) Token: 0x06001C58 RID: 7256
		int ConfigableConstId_GuildCreateJoinLevel { get; set; }

		// Token: 0x1700051C RID: 1308
		// (get) Token: 0x06001C59 RID: 7257
		// (set) Token: 0x06001C5A RID: 7258
		int ConfigableConstId_GuildCreateItemId { get; set; }

		// Token: 0x1700051D RID: 1309
		// (get) Token: 0x06001C5B RID: 7259
		// (set) Token: 0x06001C5C RID: 7260
		int ConfigableConstId_GuildMemberCountMax { get; set; }

		// Token: 0x1700051E RID: 1310
		// (get) Token: 0x06001C5D RID: 7261
		// (set) Token: 0x06001C5E RID: 7262
		int ConfigableConstId_GuildReJoinCoolDownTime { get; set; }

		// Token: 0x1700051F RID: 1311
		// (get) Token: 0x06001C5F RID: 7263
		// (set) Token: 0x06001C60 RID: 7264
		int ConfigableConstId_GuildJoinApplicationPlayerCountMax { get; set; }

		// Token: 0x17000520 RID: 1312
		// (get) Token: 0x06001C61 RID: 7265
		// (set) Token: 0x06001C62 RID: 7266
		int ConfigableConstId_GuildInviteCountMax { get; set; }

		// Token: 0x17000521 RID: 1313
		// (get) Token: 0x06001C63 RID: 7267
		// (set) Token: 0x06001C64 RID: 7268
		int ConfigableConstId_GuildChatHistoryCount { get; set; }

		// Token: 0x17000522 RID: 1314
		// (get) Token: 0x06001C65 RID: 7269
		// (set) Token: 0x06001C66 RID: 7270
		int ConfigableConstId_GuildHiringDeclarationMaxLength { get; set; }

		// Token: 0x17000523 RID: 1315
		// (get) Token: 0x06001C67 RID: 7271
		// (set) Token: 0x06001C68 RID: 7272
		int ConfigableConstId_GuildVicePresidentMaxNums { get; set; }

		// Token: 0x17000524 RID: 1316
		// (get) Token: 0x06001C69 RID: 7273
		// (set) Token: 0x06001C6A RID: 7274
		int ConfigableConstId_GuildEliteMinTotalActivities { get; set; }

		// Token: 0x17000525 RID: 1317
		// (get) Token: 0x06001C6B RID: 7275
		// (set) Token: 0x06001C6C RID: 7276
		int ConfigableConstId_RankListGuildNums { get; set; }

		// Token: 0x17000526 RID: 1318
		// (get) Token: 0x06001C6D RID: 7277
		// (set) Token: 0x06001C6E RID: 7278
		int ConfigableConstId_GuildVicePresidentCanUsurpTime { get; set; }

		// Token: 0x17000527 RID: 1319
		// (get) Token: 0x06001C6F RID: 7279
		// (set) Token: 0x06001C70 RID: 7280
		int ConfigableConstId_GuildEliteCanUsurpTime { get; set; }

		// Token: 0x17000528 RID: 1320
		// (get) Token: 0x06001C71 RID: 7281
		// (set) Token: 0x06001C72 RID: 7282
		int ConfigableConstId_GuildChangeNameCrystalCost { get; set; }

		// Token: 0x17000529 RID: 1321
		// (get) Token: 0x06001C73 RID: 7283
		// (set) Token: 0x06001C74 RID: 7284
		int ConfigableConstId_GuildDailyMaxActivities { get; set; }

		// Token: 0x1700052A RID: 1322
		// (get) Token: 0x06001C75 RID: 7285
		// (set) Token: 0x06001C76 RID: 7286
		int ConfigableConstId_GuildAnnouncementMaxLength { get; set; }

		// Token: 0x1700052B RID: 1323
		// (get) Token: 0x06001C77 RID: 7287
		// (set) Token: 0x06001C78 RID: 7288
		int ConfigableConstId_GuildWeeklyMaxActivities { get; set; }

		// Token: 0x1700052C RID: 1324
		// (get) Token: 0x06001C79 RID: 7289
		// (set) Token: 0x06001C7A RID: 7290
		int ConfigableConstId_GuildNameMaxLength { get; set; }

		// Token: 0x1700052D RID: 1325
		// (get) Token: 0x06001C7B RID: 7291
		// (set) Token: 0x06001C7C RID: 7292
		int ConfigableConstId_GuildLogMaxNUms { get; set; }

		// Token: 0x1700052E RID: 1326
		// (get) Token: 0x06001C7D RID: 7293
		// (set) Token: 0x06001C7E RID: 7294
		int ConfigableConstId_NewUserSecondAccumulatedMinValue { get; set; }

		// Token: 0x1700052F RID: 1327
		// (get) Token: 0x06001C7F RID: 7295
		// (set) Token: 0x06001C80 RID: 7296
		int ConfigableConstId_NewUserSecondAccumulatedMaxValue { get; set; }

		// Token: 0x17000530 RID: 1328
		// (get) Token: 0x06001C81 RID: 7297
		// (set) Token: 0x06001C82 RID: 7298
		int ConfigableConstId_RandomStoreManualFlushMaxNums { get; set; }

		// Token: 0x17000531 RID: 1329
		// (get) Token: 0x06001C83 RID: 7299
		// (set) Token: 0x06001C84 RID: 7300
		int ConfigableConstId_HeroDungeonDailyChallengeMaxNums { get; set; }

		// Token: 0x17000532 RID: 1330
		// (get) Token: 0x06001C85 RID: 7301
		// (set) Token: 0x06001C86 RID: 7302
		int ConfigableConstId_GuildMassiveCombatAvailableCountPerWeek { get; set; }

		// Token: 0x17000533 RID: 1331
		// (get) Token: 0x06001C87 RID: 7303
		// (set) Token: 0x06001C88 RID: 7304
		int[] GuildMassiveCombatRandomHeroTagIds { get; set; }

		// Token: 0x17000534 RID: 1332
		// (get) Token: 0x06001C89 RID: 7305
		// (set) Token: 0x06001C8A RID: 7306
		RandomStoreData RandomStoreData { get; set; }

		// Token: 0x17000535 RID: 1333
		// (get) Token: 0x06001C8B RID: 7307
		// (set) Token: 0x06001C8C RID: 7308
		RandomDropDataInfo RandomDropData { get; set; }

		// Token: 0x17000536 RID: 1334
		// (get) Token: 0x06001C8D RID: 7309
		// (set) Token: 0x06001C8E RID: 7310
		FixedStoreDataInfo FixedStoreData { get; set; }

		// Token: 0x17000537 RID: 1335
		// (get) Token: 0x06001C8F RID: 7311
		// (set) Token: 0x06001C90 RID: 7312
		SignRewardDataInfo SignRewardData { get; set; }

		// Token: 0x17000538 RID: 1336
		// (get) Token: 0x06001C91 RID: 7313
		// (set) Token: 0x06001C92 RID: 7314
		MissionDataInfo MissionData { get; set; }

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06001C93 RID: 7315
		// (set) Token: 0x06001C94 RID: 7316
		ThearchyTrialDataInfo ThearchyTrialData { get; set; }

		// Token: 0x1700053A RID: 1338
		// (get) Token: 0x06001C95 RID: 7317
		// (set) Token: 0x06001C96 RID: 7318
		AnikiGymDataInfo AnikiGymData { get; set; }

		// Token: 0x1700053B RID: 1339
		// (get) Token: 0x06001C97 RID: 7319
		// (set) Token: 0x06001C98 RID: 7320
		MemoryCorridorDataInfo MemoryCorridorData { get; set; }

		// Token: 0x1700053C RID: 1340
		// (get) Token: 0x06001C99 RID: 7321
		// (set) Token: 0x06001C9A RID: 7322
		HeroTrainningDataInfo HeroTrainningData { get; set; }

		// Token: 0x1700053D RID: 1341
		// (get) Token: 0x06001C9B RID: 7323
		// (set) Token: 0x06001C9C RID: 7324
		Dictionary<int, ConfigDataTicketLimitInfo> TicketId2TicketLimitInfo { get; set; }

		// Token: 0x1700053E RID: 1342
		// (get) Token: 0x06001C9D RID: 7325
		// (set) Token: 0x06001C9E RID: 7326
		RealTimePVPAvailableTime[] RealTimePVPAvailableTime { get; set; }
	}
}
