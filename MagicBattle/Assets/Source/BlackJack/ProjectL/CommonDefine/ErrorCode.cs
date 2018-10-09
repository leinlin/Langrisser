using System;
using SLua;

namespace BlackJack.ProjectL.CommonDefine
{
	// Token: 0x0200059D RID: 1437
	[CustomLuaClass]
	public class ErrorCode
	{
		// Token: 0x04003AC6 RID: 15046
		public const int ErrCodeOk = 0;

		// Token: 0x04003AC7 RID: 15047
		public const int ErrCodeUnknow = -2147483648;

		// Token: 0x04003AC8 RID: 15048
		public const int ErrorCodeNeedCreateCharacter = -1;

		// Token: 0x04003AC9 RID: 15049
		public const int ErrCodePlayerNameInvalid = -2;

		// Token: 0x04003ACA RID: 15050
		public const int ErrCodePlayerNameRepeated = -3;

		// Token: 0x04003ACB RID: 15051
		public const int ErrCodePlayerNameLengthAboveMax = -4;

		// Token: 0x04003ACC RID: 15052
		public const int ErrCodePlayerNameIsIllegal = -5;

		// Token: 0x04003ACD RID: 15053
		public const int ErrCodePlayerSave2DBOperationFail = -6;

		// Token: 0x04003ACE RID: 15054
		public const int ErrCodeNameIllegal = -7;

		// Token: 0x04003ACF RID: 15055
		public const int ErrCodePlayerNotExist = -8;

		// Token: 0x04003AD0 RID: 15056
		public const int ErrCodeNameEmptyNotAllowed = -9;

		// Token: 0x04003AD1 RID: 15057
		public const int ErrCodeOrderHasDelivered = -10;

		// Token: 0x04003AD2 RID: 15058
		public const int ErrCodeWrite2DBFail = -11;

		// Token: 0x04003AD3 RID: 15059
		public const int ErrCodeRMBStoreTypeNotExist = -12;

		// Token: 0x04003AD4 RID: 15060
		public const int ErrCodeNotHasThisHeadFrame = -13;

		// Token: 0x04003AD5 RID: 15061
		public const int ErrCodeIsSameHeadFrame = -14;

		// Token: 0x04003AD6 RID: 15062
		public const int ErrCodeWritePlayerData2DBFail = -15;

		// Token: 0x04003AD7 RID: 15063
		public const int ErrCodeErrorOrder = -16;

		// Token: 0x04003AD8 RID: 15064
		public const int ErrCodeOrderduplicate = -17;

		// Token: 0x04003AD9 RID: 15065
		public const int ErrCodeNetworkError = -99;

		// Token: 0x04003ADA RID: 15066
		public const int ErrCodeGMMessageError = -300;

		// Token: 0x04003ADB RID: 15067
		public const int ErrCodeGMOptionTypeError = -301;

		// Token: 0x04003ADC RID: 15068
		public const int ErrCodeGMOptionDataError = -302;

		// Token: 0x04003ADD RID: 15069
		public const int ErrCodeGMOptionDataNotDigit = -303;

		// Token: 0x04003ADE RID: 15070
		public const int ErrCodeHeroIdNotExistOrHeroExist = -304;

		// Token: 0x04003ADF RID: 15071
		public const int ErrCodeHeroIdNotExistOrHeroNotExist = -305;

		// Token: 0x04003AE0 RID: 15072
		public const int ErrCodeFlushConfigFail = -306;

		// Token: 0x04003AE1 RID: 15073
		public const int ErrCodePlayerIsOffLine = -307;

		// Token: 0x04003AE2 RID: 15074
		public const int ErrCodeGMOperationDataNotDateTime = -308;

		// Token: 0x04003AE3 RID: 15075
		public const int ErrCodeAdvertisementFlowLayoutIsEmpty = -309;

		// Token: 0x04003AE4 RID: 15076
		public const int ErrCodeAdvertisementFlowLayoutActivityNotExist = -310;

		// Token: 0x04003AE5 RID: 15077
		public const int ErrCodeInstanceItemNumsAboveBagCapacity = -311;

		// Token: 0x04003AE6 RID: 15078
		public const int ErrCodePlayerListIsEmpty = -312;

		// Token: 0x04003AE7 RID: 15079
		public const int ErrCodeUserGuideListIsEmpty = -313;

		// Token: 0x04003AE8 RID: 15080
		public const int ErrCodeGoldNotEnough = -400;

		// Token: 0x04003AE9 RID: 15081
		public const int ErrCodeCrystalNotEnough = -401;

		// Token: 0x04003AEA RID: 15082
		public const int ErrCodeEnergyNotEnough = -402;

		// Token: 0x04003AEB RID: 15083
		public const int ErrCodeGoodsTypeIdError = -403;

		// Token: 0x04003AEC RID: 15084
		public const int ErrCodeCurrencyNotEnough = -404;

		// Token: 0x04003AED RID: 15085
		public const int ErrCodePlayerLevelExpIsMax = -405;

		// Token: 0x04003AEE RID: 15086
		public const int ErrCodePlayerRepeatSign = -406;

		// Token: 0x04003AEF RID: 15087
		public const int ErrCodeSignRewardConfigNotExist = -407;

		// Token: 0x04003AF0 RID: 15088
		public const int ErrCodeBuyEngryConfigError = -408;

		// Token: 0x04003AF1 RID: 15089
		public const int ErrCodeArenaHonourNotEnough = -409;

		// Token: 0x04003AF2 RID: 15090
		public const int ErrCodeBuyArenaTickrtConfigError = -410;

		// Token: 0x04003AF3 RID: 15091
		public const int ErrCodeGuideStepIdOutOfRange = -411;

		// Token: 0x04003AF4 RID: 15092
		public const int ErrCodeChangedNameEqualToCurrentName = -412;

		// Token: 0x04003AF5 RID: 15093
		public const int ErrCodePlayerLevelNotEnough = -413;

		// Token: 0x04003AF6 RID: 15094
		public const int ErrCodeBuyEnergyNumsUsedOut = -414;

		// Token: 0x04003AF7 RID: 15095
		public const int ErrCodeRealTimePVPHonorNotEnough = -415;

		// Token: 0x04003AF8 RID: 15096
		public const int ErrCodeSkinTicketNotEnough = -416;

		// Token: 0x04003AF9 RID: 15097
		public const int ErrCodeFriendShipPointsNotEnough = -417;

		// Token: 0x04003AFA RID: 15098
		public const int ErrCodeUserGuideNotExist = -418;

		// Token: 0x04003AFB RID: 15099
		public const int ErrCodeMemoryEssenceNotEnough = -419;

		// Token: 0x04003AFC RID: 15100
		public const int ErrCodeBrillianceMithralStoneNotEnough = -420;

		// Token: 0x04003AFD RID: 15101
		public const int ErrCodeMithralStoneNotEnough = -421;

		// Token: 0x04003AFE RID: 15102
		public const int ErrCodeGoldOverFlow = -422;

		// Token: 0x04003AFF RID: 15103
		public const int ErrCodeExchangeGiftCDKeyGoodsNotExist = -423;

		// Token: 0x04003B00 RID: 15104
		public const int ErrCodeExchangeGiftCDKeyGoodsParamError = -424;

		// Token: 0x04003B01 RID: 15105
		public const int ErrCodeBagCapcityNotEnough = -500;

		// Token: 0x04003B02 RID: 15106
		public const int ErrCodeBagItemNumsNotEnough = -501;

		// Token: 0x04003B03 RID: 15107
		public const int ErrCodeBagItemNotExsit = -502;

		// Token: 0x04003B04 RID: 15108
		public const int ErrCodeBagItemsNotEnough = -503;

		// Token: 0x04003B05 RID: 15109
		public const int ErrCodeBagItemJobMaterialIdNotExsit = -504;

		// Token: 0x04003B06 RID: 15110
		public const int ErrCodeBagItemItemIdNotExsit = -505;

		// Token: 0x04003B07 RID: 15111
		public const int ErrCodeBagItemItemCanNotUse = -506;

		// Token: 0x04003B08 RID: 15112
		public const int ErrCodeBagItemTypeCanNotSell = -507;

		// Token: 0x04003B09 RID: 15113
		public const int ErrCodeBagItemCreateError = -508;

		// Token: 0x04003B0A RID: 15114
		public const int ErrCodeBagItemNotMatchGoodsType = -509;

		// Token: 0x04003B0B RID: 15115
		public const int ErrCodeBagItemEnhanceEquipmentMaterialOutofRange = -510;

		// Token: 0x04003B0C RID: 15116
		public const int ErrCodeBagItemEquipmentLocked = -511;

		// Token: 0x04003B0D RID: 15117
		public const int ErrCodeBagItemEnhanceEquipmentMaterialEnhanced = -512;

		// Token: 0x04003B0E RID: 15118
		public const int ErrCodeBagItemEnhanceEquipmentMaterialLevelUpStar = -513;

		// Token: 0x04003B0F RID: 15119
		public const int ErrCodeBagItemEnhanceEquipmentLevelExpMax = -514;

		// Token: 0x04003B10 RID: 15120
		public const int ErrCodeBagItemEnhanceEquipmentTypeError = -515;

		// Token: 0x04003B11 RID: 15121
		public const int ErrCodeBagItemLevelUpStarEquipmentMatrialTypeError = -516;

		// Token: 0x04003B12 RID: 15122
		public const int ErrCodeBagItemEquipmentLevelUpStarRankDifferent = -517;

		// Token: 0x04003B13 RID: 15123
		public const int ErrCodeBagItemEquipmentLevelUpStarMax = -518;

		// Token: 0x04003B14 RID: 15124
		public const int ErrCodeBagItemEquipmentLevelUpLevelNotEnough = -519;

		// Token: 0x04003B15 RID: 15125
		public const int ErrCodeBagItemEquipmentAndMaterialIsSame = -520;

		// Token: 0x04003B16 RID: 15126
		public const int ErrCodeIllegalUseBagItemNums = -521;

		// Token: 0x04003B17 RID: 15127
		public const int ErrCodeBagItemEquipmentIdNotExsit = -522;

		// Token: 0x04003B18 RID: 15128
		public const int ErrCodeConsumeItemNumsError = -523;

		// Token: 0x04003B19 RID: 15129
		public const int ErrCodeStarLeveUpEquipmentCannotEnhanceEquipment = -524;

		// Token: 0x04003B1A RID: 15130
		public const int ErrCodeBagItemStarLevelUpEquipmentTypeError = -525;

		// Token: 0x04003B1B RID: 15131
		public const int ErrCodeCannotEquipmentThisEquipment = -526;

		// Token: 0x04003B1C RID: 15132
		public const int ErrCodeBagItemCannotDecompose = -527;

		// Token: 0x04003B1D RID: 15133
		public const int ErrCodeBagItemNotStacking = -528;

		// Token: 0x04003B1E RID: 15134
		public const int ErrCodeNotItemTypeCannotUse = -529;

		// Token: 0x04003B1F RID: 15135
		public const int ErrCodeHeroFavorabilityExpItemNotEnough = -530;

		// Token: 0x04003B20 RID: 15136
		public const int ErrCodeItemUseNumsError = -531;

		// Token: 0x04003B21 RID: 15137
		public const int ErrCodeBagItemSaveEnchantingEquipmentNotExist = -532;

		// Token: 0x04003B22 RID: 15138
		public const int ErrCodeOpenBoxNumReachMax = -533;

		// Token: 0x04003B23 RID: 15139
		public const int ErrCodeEnergyMedicineNotEnough = -534;

		// Token: 0x04003B24 RID: 15140
		public const int ErrCodeAlchemyOutOfRange = -535;

		// Token: 0x04003B25 RID: 15141
		public const int ErrCodeStaticBoxNotExist = -536;

		// Token: 0x04003B26 RID: 15142
		public const int ErrCodeRandomBoxNotExist = -537;

		// Token: 0x04003B27 RID: 15143
		public const int ErrCodeSelfSelectedBoxNotExist = -538;

		// Token: 0x04003B28 RID: 15144
		public const int ErrCodeSelfSelectedBoxItemIndexNotExist = -539;

		// Token: 0x04003B29 RID: 15145
		public const int ErrCodeNotSelfSelectedBoxCanHaveIndexParm = -540;

		// Token: 0x04003B2A RID: 15146
		public const int ErrCodeHeroJobIsExsit = -600;

		// Token: 0x04003B2B RID: 15147
		public const int ErrCodeHeroJobNotExsit = -601;

		// Token: 0x04003B2C RID: 15148
		public const int ErrCodeHeroNotExsit = -602;

		// Token: 0x04003B2D RID: 15149
		public const int ErrCodeHeroExsit = -603;

		// Token: 0x04003B2E RID: 15150
		public const int ErrCodeJobMaterialRemoveError = -604;

		// Token: 0x04003B2F RID: 15151
		public const int ErrCodeJobMaterialSlotNotMatch = -605;

		// Token: 0x04003B30 RID: 15152
		public const int ErrCodeJobMaterialHadEquiped = -606;

		// Token: 0x04003B31 RID: 15153
		public const int ErrCodeJobMaterialNotEnough = -607;

		// Token: 0x04003B32 RID: 15154
		public const int ErrCodeBagNotHaveJobMaterial = -608;

		// Token: 0x04003B33 RID: 15155
		public const int ErrCodeSlotIdError = -609;

		// Token: 0x04003B34 RID: 15156
		public const int ErrCodeLevelUpStarLevelConfigNotExsit = -610;

		// Token: 0x04003B35 RID: 15157
		public const int ErrCodeJobLevelNotEnough = -611;

		// Token: 0x04003B36 RID: 15158
		public const int ErrCodeJobLevelOutOfRange = -612;

		// Token: 0x04003B37 RID: 15159
		public const int ErrCodeJobIdNotExsit = -613;

		// Token: 0x04003B38 RID: 15160
		public const int ErrCodeJobRankError = -614;

		// Token: 0x04003B39 RID: 15161
		public const int ErrCodeJobRelatedIdError = -615;

		// Token: 0x04003B3A RID: 15162
		public const int ErrCodeJobLevelIdNotExist = -616;

		// Token: 0x04003B3B RID: 15163
		public const int ErrCodeHeroTransferJobRankOutOfRange = -617;

		// Token: 0x04003B3C RID: 15164
		public const int ErrCodeHeroIdNotExist = -618;

		// Token: 0x04003B3D RID: 15165
		public const int ErrCodeHeroNotHaveThisSoldier = -619;

		// Token: 0x04003B3E RID: 15166
		public const int ErrCodeHeroNotHaveThisSkill = -620;

		// Token: 0x04003B3F RID: 15167
		public const int ErrCodeSkillIdError = -621;

		// Token: 0x04003B40 RID: 15168
		public const int ErrCodeMaterialNotEnough = -622;

		// Token: 0x04003B41 RID: 15169
		public const int ErrCodeHeroLevelNotEnough = -623;

		// Token: 0x04003B42 RID: 15170
		public const int ErrCodeHeroGetSkillEneryError = -624;

		// Token: 0x04003B43 RID: 15171
		public const int ErrCodeHeroSkillEneryNotEnough = -625;

		// Token: 0x04003B44 RID: 15172
		public const int ErrCodeHeroSlectedSkillCountOutOfRange = -626;

		// Token: 0x04003B45 RID: 15173
		public const int ErrCodeComposeMaterialNotExist = -627;

		// Token: 0x04003B46 RID: 15174
		public const int ErrCodeNoJobMaterialCanEquiped = -628;

		// Token: 0x04003B47 RID: 15175
		public const int ErrCodeFragmentItemIdError = -629;

		// Token: 0x04003B48 RID: 15176
		public const int ErrCodeHeroStarLevelAboveHeroStarLevelMax = -630;

		// Token: 0x04003B49 RID: 15177
		public const int ErrCodeHeroExpIsFull = -631;

		// Token: 0x04003B4A RID: 15178
		public const int ErrCodeSkillIdRepeated = -632;

		// Token: 0x04003B4B RID: 15179
		public const int ErrCodeHeroJobCannotTransferSelfJob = -633;

		// Token: 0x04003B4C RID: 15180
		public const int ErrCodeHeroTransferJobsNotContainThisJob = -634;

		// Token: 0x04003B4D RID: 15181
		public const int ErrCodeHeroStarIdError = -635;

		// Token: 0x04003B4E RID: 15182
		public const int ErrCodePreJobNotOPen = -636;

		// Token: 0x04003B4F RID: 15183
		public const int ErrCodeHeroJobLocked = -637;

		// Token: 0x04003B50 RID: 15184
		public const int ErrCodeHeroJobRepeateUnlock = -638;

		// Token: 0x04003B51 RID: 15185
		public const int ErrCodeHeroJobUnlockItemCostNotEnough = -639;

		// Token: 0x04003B52 RID: 15186
		public const int ErrCodeHeroJobUnlockAcgievementsNotReach = -640;

		// Token: 0x04003B53 RID: 15187
		public const int ErrCodeHeroJobNotNeedUnlock = -641;

		// Token: 0x04003B54 RID: 15188
		public const int ErrCodePreHeroJobNotExist = -642;

		// Token: 0x04003B55 RID: 15189
		public const int ErrCodeCurrentJobCannotEquipThisSkill = -643;

		// Token: 0x04003B56 RID: 15190
		public const int ErrCodeProtagonistIdError = -644;

		// Token: 0x04003B57 RID: 15191
		public const int ErrCodeProtagonistHasSetDown = -645;

		// Token: 0x04003B58 RID: 15192
		public const int ErrCodeHeroEquipmentHasWeared = -646;

		// Token: 0x04003B59 RID: 15193
		public const int ErrCodeHeroEquipmentSoldierNotmatch = -647;

		// Token: 0x04003B5A RID: 15194
		public const int ErrCodeHeroEquipmentJobNotmatch = -648;

		// Token: 0x04003B5B RID: 15195
		public const int ErrCodeHeroEquipmentHasNotWeared = -649;

		// Token: 0x04003B5C RID: 15196
		public const int ErrCodePreHeroJobNotMaster = -650;

		// Token: 0x04003B5D RID: 15197
		public const int ErrCodeCannotWearThisTypeEquipment = -651;

		// Token: 0x04003B5E RID: 15198
		public const int ErrCodeHeroFragmentNumsNotEnough = -652;

		// Token: 0x04003B5F RID: 15199
		public const int ErrCodeHeroAutoEquipmentTimeTooClose = -653;

		// Token: 0x04003B60 RID: 15200
		public const int ErrCodeHeroAutoEquipmentDontUpdate = -654;

		// Token: 0x04003B61 RID: 15201
		public const int ErrCodeProtagonistHeroCannotAddFavorabilityExp = -655;

		// Token: 0x04003B62 RID: 15202
		public const int ErrCodeHeroFavorabilityExpIsFull = -656;

		// Token: 0x04003B63 RID: 15203
		public const int ErrCodeHeroInformationNotExist = -657;

		// Token: 0x04003B64 RID: 15204
		public const int ErrCodeUnlockHeroFetterFavorabilityLevelNotEnough = -658;

		// Token: 0x04003B65 RID: 15205
		public const int ErrCodeUnlockMissionNotComplete = -659;

		// Token: 0x04003B66 RID: 15206
		public const int ErrCodeUnlockFetterConditionTypeError = -660;

		// Token: 0x04003B67 RID: 15207
		public const int ErrCodeHeroFetterLocked = -661;

		// Token: 0x04003B68 RID: 15208
		public const int ErrCodeHeroNotHaveThisFetter = -662;

		// Token: 0x04003B69 RID: 15209
		public const int ErrCodeHeroRepeatedlyUnlock = -663;

		// Token: 0x04003B6A RID: 15210
		public const int ErrCodeHeroFetterLevelReachMax = -664;

		// Token: 0x04003B6B RID: 15211
		public const int ErrCodeHeroPerformanceIdError = -665;

		// Token: 0x04003B6C RID: 15212
		public const int ErrCodeUnlockHeroPerformanceFavorabilityLevelNotEnough = -666;

		// Token: 0x04003B6D RID: 15213
		public const int ErrCodeUnlockHeroPerformanceConditionTypeError = -667;

		// Token: 0x04003B6E RID: 15214
		public const int ErrCodeHeroBiographyIdError = -668;

		// Token: 0x04003B6F RID: 15215
		public const int ErrCodeUnlockHeroBiographyFavorabilityLevelNotEnough = -669;

		// Token: 0x04003B70 RID: 15216
		public const int ErrCodeUnlockHeroBiographyConditionTypeError = -670;

		// Token: 0x04003B71 RID: 15217
		public const int ErrCodeHeroConfessRepeatedly = -671;

		// Token: 0x04003B72 RID: 15218
		public const int ErrCodeHeroFetterLevelNotReachConfessLevel = -672;

		// Token: 0x04003B73 RID: 15219
		public const int ErrCodeHeroConfessionIdError = -673;

		// Token: 0x04003B74 RID: 15220
		public const int ErrCodeProtagonistHeroCannotBeConfessed = -674;

		// Token: 0x04003B75 RID: 15221
		public const int ErrCodeHeroInteractNumsNotEnough = -675;

		// Token: 0x04003B76 RID: 15222
		public const int ErrCodeHeroInteractIdError = -676;

		// Token: 0x04003B77 RID: 15223
		public const int ErrCodeHeroInteractBigUpResultNotExist = -677;

		// Token: 0x04003B78 RID: 15224
		public const int ErrCodeHeroInteractResultConfigError = -678;

		// Token: 0x04003B79 RID: 15225
		public const int ErrCodeHeroJobNotOpen = -679;

		// Token: 0x04003B7A RID: 15226
		public const int ErrCodeNotExistExtralHeroFragement = -680;

		// Token: 0x04003B7B RID: 15227
		public const int ErrCodeScenarioIdError = -700;

		// Token: 0x04003B7C RID: 15228
		public const int ErrCodeUnlockScenarioPlayerLevelNotEnough = -701;

		// Token: 0x04003B7D RID: 15229
		public const int ErrCodeUnlockScenarioRiftProgressNotEnough = -702;

		// Token: 0x04003B7E RID: 15230
		public const int ErrCodeScenarioStageIdError = -703;

		// Token: 0x04003B7F RID: 15231
		public const int ErrCodeNextScenarioIsEmpty = -704;

		// Token: 0x04003B80 RID: 15232
		public const int ErrCodeWayPointIdError = -705;

		// Token: 0x04003B81 RID: 15233
		public const int ErrCodeWayPointHaveScenario = -706;

		// Token: 0x04003B82 RID: 15234
		public const int ErrCodeCanNotMoveToThisWayPoint = -707;

		// Token: 0x04003B83 RID: 15235
		public const int ErrCodeWayPointHaveEvent = -708;

		// Token: 0x04003B84 RID: 15236
		public const int ErrCodeTreasureIsEmpty = -709;

		// Token: 0x04003B85 RID: 15237
		public const int ErrCodeWayPointEventIdError = -710;

		// Token: 0x04003B86 RID: 15238
		public const int ErrCodeNotHaveFight = -711;

		// Token: 0x04003B87 RID: 15239
		public const int ErrCodeEventFunctionTypeNotExsit = -712;

		// Token: 0x04003B88 RID: 15240
		public const int ErrCodeUnlockScenarioNotCompleteRiftLevel = -713;

		// Token: 0x04003B89 RID: 15241
		public const int ErrCodeRandomEventOperationNotOpen = -714;

		// Token: 0x04003B8A RID: 15242
		public const int ErrCodeAboveMapRandomEventMaxCount = -715;

		// Token: 0x04003B8B RID: 15243
		public const int ErrCodeActionRandomEventComplete = -716;

		// Token: 0x04003B8C RID: 15244
		public const int ErrCodeRandomEventIdError = -717;

		// Token: 0x04003B8D RID: 15245
		public const int ErrCodeNotHaveWayPointPlaceRandomEvent = -718;

		// Token: 0x04003B8E RID: 15246
		public const int ErrCodeScenarioChapterNotOpen = -719;

		// Token: 0x04003B8F RID: 15247
		public const int ErrCodeRiftLevelUnlock = -800;

		// Token: 0x04003B90 RID: 15248
		public const int ErrCodeRiftLevelAttackNumsNotEnough = -801;

		// Token: 0x04003B91 RID: 15249
		public const int ErrCodeRiftLevelRaidStarNotEnough = -802;

		// Token: 0x04003B92 RID: 15250
		public const int ErrCodeRiftLevelRaidParamError = -803;

		// Token: 0x04003B93 RID: 15251
		public const int ErrCodeRiftLevelHasGainChapterReward = -804;

		// Token: 0x04003B94 RID: 15252
		public const int ErrCodeRiftChapterIdError = -805;

		// Token: 0x04003B95 RID: 15253
		public const int ErrCodeRiftChapterPlayerLevelNotEnough = -806;

		// Token: 0x04003B96 RID: 15254
		public const int ErrCodeRiftChapterScenarioProcessNotEnough = -807;

		// Token: 0x04003B97 RID: 15255
		public const int ErrCodeRiftLevelIdError = -808;

		// Token: 0x04003B98 RID: 15256
		public const int ErrCodePreRiftLevelNotCompleted = -809;

		// Token: 0x04003B99 RID: 15257
		public const int ErrCodeNotHaveThisAchievement = -810;

		// Token: 0x04003B9A RID: 15258
		public const int ErrCodeNotHaveThisHero = 811;

		// Token: 0x04003B9B RID: 15259
		public const int ErrCodeUnlockChapterParamError = -812;

		// Token: 0x04003B9C RID: 15260
		public const int ErrCodeUnlockRiftLevelParamError = -813;

		// Token: 0x04003B9D RID: 15261
		public const int ErrCodeRiftGainChapterRewardStarNotEnough = -814;

		// Token: 0x04003B9E RID: 15262
		public const int ErrCodeRiftGainChapterRewardIndexError = -815;

		// Token: 0x04003B9F RID: 15263
		public const int ErrCodeRiftLevelBattleIdError = -816;

		// Token: 0x04003BA0 RID: 15264
		public const int ErrCodeNotHaveUnlockedChapter = -817;

		// Token: 0x04003BA1 RID: 15265
		public const int ErrCodeRiftLevelNotComplete = -818;

		// Token: 0x04003BA2 RID: 15266
		public const int ErrCodeRiftLevelPlayerLevelNotEnough = -819;

		// Token: 0x04003BA3 RID: 15267
		public const int ErrCodeRiftLevelRelatedAchievementIdError = -820;

		// Token: 0x04003BA4 RID: 15268
		public const int ErrCodeLevelRaidTicketNotEnough = -821;

		// Token: 0x04003BA5 RID: 15269
		public const int ErrCodeChapterStarNotEnough = -822;

		// Token: 0x04003BA6 RID: 15270
		public const int ErrCodeRiftAchievementRepeatelyComplete = -823;

		// Token: 0x04003BA7 RID: 15271
		public const int ErrCodeRiftFunctionNotOpen = -824;

		// Token: 0x04003BA8 RID: 15272
		public const int ErrCodeRiftGainChapterIndexParmOutOfRange = -825;

		// Token: 0x04003BA9 RID: 15273
		public const int ErrCodeRiftChapterNotOpen = -826;

		// Token: 0x04003BAA RID: 15274
		public const int ErrCodeBattleAttackIsFighting = -900;

		// Token: 0x04003BAB RID: 15275
		public const int ErrCodeBattleFinishedIsNotFighting = -901;

		// Token: 0x04003BAC RID: 15276
		public const int ErrCodeBattleAttacklWayPointNotExist = -902;

		// Token: 0x04003BAD RID: 15277
		public const int ErrCodeBattleAttackRiftLevelNotExist = -903;

		// Token: 0x04003BAE RID: 15278
		public const int ErrCodeBattleCancelIsNotFighting = -904;

		// Token: 0x04003BAF RID: 15279
		public const int ErrCodeBattleIdNotExist = -905;

		// Token: 0x04003BB0 RID: 15280
		public const int ErrorCodeBattleReportError = -906;

		// Token: 0x04003BB1 RID: 15281
		public const int ErrorCodeBattleHeroesNumsOutOfRange = -907;

		// Token: 0x04003BB2 RID: 15282
		public const int ErrorCodeBattleHeroPositionError = -908;

		// Token: 0x04003BB3 RID: 15283
		public const int ErrorCodeBattleCreatMapError = -909;

		// Token: 0x04003BB4 RID: 15284
		public const int ErrorCodeBattleBattleReportError = -910;

		// Token: 0x04003BB5 RID: 15285
		public const int ErrorCodeBattleInitError = -911;

		// Token: 0x04003BB6 RID: 15286
		public const int ErrCodeUnknownBattle = -912;

		// Token: 0x04003BB7 RID: 15287
		public const int ErrCodeUnknownBattleMonsterLevel = -913;

		// Token: 0x04003BB8 RID: 15288
		public const int ErrCodeArenaBattleIdNotExist = -914;

		// Token: 0x04003BB9 RID: 15289
		public const int ErrCodeBattleTypeError = -915;

		// Token: 0x04003BBA RID: 15290
		public const int ErrCodeBattleAttackHeroDungeonLevelNotExist = -916;

		// Token: 0x04003BBB RID: 15291
		public const int ErrCodeBattleActionPositionIndexOutOfRange = -917;

		// Token: 0x04003BBC RID: 15292
		public const int ErrCodeBattleActionValueOutOfRange = -918;

		// Token: 0x04003BBD RID: 15293
		public const int ErrCodeRandomBattleArmyNotExist = -919;

		// Token: 0x04003BBE RID: 15294
		public const int ErrCodeRandomBattleArmyRoleWeightError = -920;

		// Token: 0x04003BBF RID: 15295
		public const int ErrCodeEventRiftLevelCannotBeRepeatedlyAttacked = -921;

		// Token: 0x04003BC0 RID: 15296
		public const int ErrCodeNecessaryHeroNotInBattle = -922;

		// Token: 0x04003BC1 RID: 15297
		public const int ErrCodeBattleAlreadyInBattleServer = -923;

		// Token: 0x04003BC2 RID: 15298
		public const int ErrCodeBattleRoomCreateBattleTypeError = -924;

		// Token: 0x04003BC3 RID: 15299
		public const int ErrCodeBattleServerNetError = -925;

		// Token: 0x04003BC4 RID: 15300
		public const int ErrCodeBattleNotFightingInBattleServer = -926;

		// Token: 0x04003BC5 RID: 15301
		public const int ErrCodeBattleChangePlayerBattleStatusOutOfRange = -927;

		// Token: 0x04003BC6 RID: 15302
		public const int ErrCodeBattleSetupHeroError = -928;

		// Token: 0x04003BC7 RID: 15303
		public const int ErrCodeBattleRoomNotExist = -929;

		// Token: 0x04003BC8 RID: 15304
		public const int ErrCodeBattleCommandError = -930;

		// Token: 0x04003BC9 RID: 15305
		public const int ErrCodeBattleRoomPlayerNotExist = -931;

		// Token: 0x04003BCA RID: 15306
		public const int ErrCodeBattleRoomIdError = -932;

		// Token: 0x04003BCB RID: 15307
		public const int ErrCodeBattleRoomHasSendActionBegin = -933;

		// Token: 0x04003BCC RID: 15308
		public const int ErrCodePVPBattleIdNotExist = -934;

		// Token: 0x04003BCD RID: 15309
		public const int ErrCodeRealTimePVPBattleIdNotExist = -935;

		// Token: 0x04003BCE RID: 15310
		public const int ErrCodeBattleRoomPutdownHeroError = -936;

		// Token: 0x04003BCF RID: 15311
		public const int ErrCodeBattleGuildMassiveCombatSetupHeroNotEnough = -937;

		// Token: 0x04003BD0 RID: 15312
		public const int ErrCodeMailIdRepeated = -1000;

		// Token: 0x04003BD1 RID: 15313
		public const int ErrCodeMailNotExist = -1001;

		// Token: 0x04003BD2 RID: 15314
		public const int ErrCodeMailHadRead = -1002;

		// Token: 0x04003BD3 RID: 15315
		public const int ErrCodeMailAttachmentHadGot = -1003;

		// Token: 0x04003BD4 RID: 15316
		public const int ErrCodeMailIsExpired = -1004;

		// Token: 0x04003BD5 RID: 15317
		public const int ErrCodeMailTemplateIdError = -1005;

		// Token: 0x04003BD6 RID: 15318
		public const int ErrCodeNotHaveMailExistAttachment = -1006;

		// Token: 0x04003BD7 RID: 15319
		public const int ErrCodeMailNotHaveAttachment = -1007;

		// Token: 0x04003BD8 RID: 15320
		public const int ErrCodeRandomStoreNotExist = -1100;

		// Token: 0x04003BD9 RID: 15321
		public const int ErrCodeRandomStoreBuyItemIndexOutOfRange = -1101;

		// Token: 0x04003BDA RID: 15322
		public const int ErrCodeRandomStoreItemIsBought = -1102;

		// Token: 0x04003BDB RID: 15323
		public const int ErrCodeRandomStoreIdNotExist = -1103;

		// Token: 0x04003BDC RID: 15324
		public const int ErrCodeRandomStoreBuyItemStoreHasFlushed = -1104;

		// Token: 0x04003BDD RID: 15325
		public const int ErrCodeManualFlushNumsUsedOut = -1105;

		// Token: 0x04003BDE RID: 15326
		public const int ErrCodeRandomEventLevelConfigError = -1200;

		// Token: 0x04003BDF RID: 15327
		public const int ErrCodeDefiniteGroupRandomEventGroupNotExist = -1201;

		// Token: 0x04003BE0 RID: 15328
		public const int ErrCodeEventIdError = -1202;

		// Token: 0x04003BE1 RID: 15329
		public const int ErrCodeCurrentWayPointHaveUnfinishedRandomEvent = -1203;

		// Token: 0x04003BE2 RID: 15330
		public const int ErrCodeRandomEventTimeOut = -1204;

		// Token: 0x04003BE3 RID: 15331
		public const int ErrCodeRandomEventGroupIdError = -1205;

		// Token: 0x04003BE4 RID: 15332
		public const int ErrCodeFixedStoreNotExistThisStore = -1300;

		// Token: 0x04003BE5 RID: 15333
		public const int ErrCodeFixedStoreNotExistThisGoods = -1301;

		// Token: 0x04003BE6 RID: 15334
		public const int ErrCodeFixedStoreThisGoodsHasSoldOut = -1302;

		// Token: 0x04003BE7 RID: 15335
		public const int ErrCodeFixedStoreGoodsNotInSellTime = -1303;

		// Token: 0x04003BE8 RID: 15336
		public const int ErrCodeChatPlayerNotEnoughLevel = -1400;

		// Token: 0x04003BE9 RID: 15337
		public const int ErrCodeChatSendTooOften = -1401;

		// Token: 0x04003BEA RID: 15338
		public const int ErrCodeChatBanned = -1402;

		// Token: 0x04003BEB RID: 15339
		public const int ErrCodeChatChannelNotPermission = -1403;

		// Token: 0x04003BEC RID: 15340
		public const int ErrCodeChatPlayerOffline = -1404;

		// Token: 0x04003BED RID: 15341
		public const int ErrCodeChatWorldChannelAllocRoomPlayerAlreadyInsideRoom = -1405;

		// Token: 0x04003BEE RID: 15342
		public const int ErrCodeChatWorldChannelAllocRoomAllRoomsFull = -1406;

		// Token: 0x04003BEF RID: 15343
		public const int ErrCodeChatWorldChannelRemovePlayerNotExist = -1407;

		// Token: 0x04003BF0 RID: 15344
		public const int ErrCodeChatWorldChannelEnterRoomSameTwice = -1408;

		// Token: 0x04003BF1 RID: 15345
		public const int ErrCodeChatWorldChannelEnterRoomFull = -1409;

		// Token: 0x04003BF2 RID: 15346
		public const int ErrCodeChatWorldChannelEnterRoomIllegalRoomId = -1410;

		// Token: 0x04003BF3 RID: 15347
		public const int ErrCodeChatTeamChannelTeamRoomNotExist = -1411;

		// Token: 0x04003BF4 RID: 15348
		public const int ErrCodeChatGroupChannelGroupNotExist = -1412;

		// Token: 0x04003BF5 RID: 15349
		public const int ErrCodeChatGroupChannelPlayerNotBelongToGroup = -1413;

		// Token: 0x04003BF6 RID: 15350
		public const int ErrCodeChatVoiceContentTimeout = -1414;

		// Token: 0x04003BF7 RID: 15351
		public const int ErrCodeChatPrivateChannelNotSelectTargetPlayer = -1415;

		// Token: 0x04003BF8 RID: 15352
		public const int ErrCodeChatGroupChannelNotSelectTargetGroup = -1416;

		// Token: 0x04003BF9 RID: 15353
		public const int ErrCodeChatPrivateChannelSrcPlayerBlockDestPlayer = -1417;

		// Token: 0x04003BFA RID: 15354
		public const int ErrCodeChatPrivateChannelDestPlayerBlockSrcPlayer = -1418;

		// Token: 0x04003BFB RID: 15355
		public const int ErrCodeChatWorldChannelServerBusy = -1419;

		// Token: 0x04003BFC RID: 15356
		public const int ErrCodeChatGuildChannelHaveNoGuild = -1420;

		// Token: 0x04003BFD RID: 15357
		public const int ErrCodeActivityCardPoolNotOpenInCurrentTime = -1500;

		// Token: 0x04003BFE RID: 15358
		public const int ErrCodeActivityCardPoolSelectCountUsedOut = -1501;

		// Token: 0x04003BFF RID: 15359
		public const int ErrCodeSelectCardTicketNotEnough = -1502;

		// Token: 0x04003C00 RID: 15360
		public const int ErrCodeSelectCardPoolNotExistById = -1503;

		// Token: 0x04003C01 RID: 15361
		public const int ErrCodeCardPoolCannotUseTenSelect = -1504;

		// Token: 0x04003C02 RID: 15362
		public const int ErrCodeSelectCardPoolCannotUseCrystal = -1505;

		// Token: 0x04003C03 RID: 15363
		public const int ErrCodeFreeCardPoolJustUseTicket = -1506;

		// Token: 0x04003C04 RID: 15364
		public const int ErrCodeFreeCardJustCanUseTicketsTenSelect = -1507;

		// Token: 0x04003C05 RID: 15365
		public const int ErrCodeUserGuidSelectCardStepHasCompleted = -1508;

		// Token: 0x04003C06 RID: 15366
		public const int ErrCodeSameGroupIdExistBetweenCrystalCardPoolGroupTableAndFreeCardPooGroupTable = -1509;

		// Token: 0x04003C07 RID: 15367
		public const int ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndFreeCardPooGroupTable = -1510;

		// Token: 0x04003C08 RID: 15368
		public const int ErrCodeSameGroupIdExistBetweenActivityCardPoolGroupTableAndCrystalCardPooGroupTable = -1511;

		// Token: 0x04003C09 RID: 15369
		public const int ErrCodeUserGuideRepeatedCompleted = -1512;

		// Token: 0x04003C0A RID: 15370
		public const int ErrCodeCrystalCardPoolJustCanUseTicket = -1513;

		// Token: 0x04003C0B RID: 15371
		public const int ErrCodeCrstalCardPoolSelectConsumeMaterialNotEnough = -1514;

		// Token: 0x04003C0C RID: 15372
		public const int ErrCodeCrystalCardPoolUseTicketNotEnoughButCrystalEnough = -1515;

		// Token: 0x04003C0D RID: 15373
		public const int ErrCodeActivityCardPoolJustCanUseTicket = -1516;

		// Token: 0x04003C0E RID: 15374
		public const int ErrCodeMissionIdError = -1600;

		// Token: 0x04003C0F RID: 15375
		public const int ErrCodeMissionNotComplete = -1601;

		// Token: 0x04003C10 RID: 15376
		public const int ErrCodeMissionLocked = -1602;

		// Token: 0x04003C11 RID: 15377
		public const int ErrCodeMissionNotExist = -1603;

		// Token: 0x04003C12 RID: 15378
		public const int ErrCodeMissionServerDataHasSync2Client = -1604;

		// Token: 0x04003C13 RID: 15379
		public const int ErrCodeMissionRewardHasGot = -1605;

		// Token: 0x04003C14 RID: 15380
		public const int ErrCodeCommentHeroNumsIsMax = -1700;

		// Token: 0x04003C15 RID: 15381
		public const int ErrCodeCommentHeroNotExist = -1701;

		// Token: 0x04003C16 RID: 15382
		public const int ErrCodeCommentEntryHasPraised = -1702;

		// Token: 0x04003C17 RID: 15383
		public const int ErrCodeCommentPraiseEntryNotExist = -1703;

		// Token: 0x04003C18 RID: 15384
		public const int ErrCodeCommentViewCommenterHeroNotExsit = -1704;

		// Token: 0x04003C19 RID: 15385
		public const int ErrCodeCommentBanned = -1705;

		// Token: 0x04003C1A RID: 15386
		public const int ErrCodeThearchyTrialNotOpen = -1800;

		// Token: 0x04003C1B RID: 15387
		public const int ErrCodeThearchyTrialLevelNotExist = -1801;

		// Token: 0x04003C1C RID: 15388
		public const int ErrCodeThearchyTrialLevelNotOpenInCurrentTime = -1802;

		// Token: 0x04003C1D RID: 15389
		public const int ErrCodeThearchyTrialLevelPreLevelUnfinished = -1803;

		// Token: 0x04003C1E RID: 15390
		public const int ErrCodeThearchyTrialChallengeNumsReachMax = -1804;

		// Token: 0x04003C1F RID: 15391
		public const int ErrCodeThearchyTrialLevelIdError = -1805;

		// Token: 0x04003C20 RID: 15392
		public const int ErrCodeThearchyTrialChallengeCountUseOut = -1806;

		// Token: 0x04003C21 RID: 15393
		public const int ErrCodeThearchyTrialLevelBattleIdError = -1807;

		// Token: 0x04003C22 RID: 15394
		public const int ErrCodeThearchyTrialTicketNotEnough = -1808;

		// Token: 0x04003C23 RID: 15395
		public const int ErrCodeThearchyTrialFunctionNotOpen = -1809;

		// Token: 0x04003C24 RID: 15396
		public const int ErrCodeAnikiGymNotOpen = -1900;

		// Token: 0x04003C25 RID: 15397
		public const int ErrCodeAnikiGymLevelNotExist = -1901;

		// Token: 0x04003C26 RID: 15398
		public const int ErrCodeAnikiGymLevelNotOpenInCurrentTime = -1902;

		// Token: 0x04003C27 RID: 15399
		public const int ErrCodeAnikiGymlLevelPreLevelUnfinished = -1903;

		// Token: 0x04003C28 RID: 15400
		public const int ErrCodeAnikiGymChallengeNumsReachMax = -1904;

		// Token: 0x04003C29 RID: 15401
		public const int ErrCodeAnikiGymLevelIdError = -1905;

		// Token: 0x04003C2A RID: 15402
		public const int ErrCodeAnikiGymChallengeCountUseOut = -1906;

		// Token: 0x04003C2B RID: 15403
		public const int ErrCodeAnikiGymLevelBattleIdError = -1907;

		// Token: 0x04003C2C RID: 15404
		public const int ErrCodeAnikiGymTicketNotEnough = -1908;

		// Token: 0x04003C2D RID: 15405
		public const int ErrCodeAnikiGymFunctionNotOpen = -1909;

		// Token: 0x04003C2E RID: 15406
		public const int ErrCodeArenaNotEnoughTicket = -2000;

		// Token: 0x04003C2F RID: 15407
		public const int ErrCodeArenaPlayerNotEnoughLevel = -2001;

		// Token: 0x04003C30 RID: 15408
		public const int ErrCodeArenaOpponentIndexOutOfRange = -2002;

		// Token: 0x04003C31 RID: 15409
		public const int ErrCodeArenaOpponentHasAttacked = -2003;

		// Token: 0x04003C32 RID: 15410
		public const int ErrCodeArenaNotOpen = -2004;

		// Token: 0x04003C33 RID: 15411
		public const int ErrCodeArenaManualFlushTimeNotReached = -2005;

		// Token: 0x04003C34 RID: 15412
		public const int ErrCodeArenaAttackOpponentGetDefensiveTeamInfoFail = -2006;

		// Token: 0x04003C35 RID: 15413
		public const int ErrCodeArenaBattleReportNotExist = -2007;

		// Token: 0x04003C36 RID: 15414
		public const int ErrCodeArenaBattleTimeOut = -2008;

		// Token: 0x04003C37 RID: 15415
		public const int ErrCodeArenaNotExistHostility = -2009;

		// Token: 0x04003C38 RID: 15416
		public const int ErrCodeArenaRevengedOpponent = -2010;

		// Token: 0x04003C39 RID: 15417
		public const int ErrCodeArenaReportBattleReportFail = -2011;

		// Token: 0x04003C3A RID: 15418
		public const int ErrCodeArenaVictoryPointsRewardRepeatedlyGot = -2012;

		// Token: 0x04003C3B RID: 15419
		public const int ErrCodeArenaVictoryRewardIndexError = -2013;

		// Token: 0x04003C3C RID: 15420
		public const int ErrCodeArenaVictoryPointsNotEnough = -2014;

		// Token: 0x04003C3D RID: 15421
		public const int ErrCodeArenaIsNotFighting = -2015;

		// Token: 0x04003C3E RID: 15422
		public const int ErrCodeArenaOpponentHasNotAttacked = -2016;

		// Token: 0x04003C3F RID: 15423
		public const int ErrCodeArenaInSettleTime = -2017;

		// Token: 0x04003C40 RID: 15424
		public const int ErrCodeArenaNotInReady = -2018;

		// Token: 0x04003C41 RID: 15425
		public const int ErrCodeArenaRevengeCheat = -2019;

		// Token: 0x04003C42 RID: 15426
		public const int ErrCodeArenaException = -2020;

		// Token: 0x04003C43 RID: 15427
		public const int ErrCodeHeroAssistantTaskLocked = -2101;

		// Token: 0x04003C44 RID: 15428
		public const int ErrCodeHeroAssistantTaskNotExist = -2102;

		// Token: 0x04003C45 RID: 15429
		public const int ErrCodeHeroAssistantHeroNotExist = -2103;

		// Token: 0x04003C46 RID: 15430
		public const int ErrCodeHeroAssistantHeroAssigned = -2104;

		// Token: 0x04003C47 RID: 15431
		public const int ErrCodeHeroAssistantTaskInProcess = -2105;

		// Token: 0x04003C48 RID: 15432
		public const int ErrCodeHeroAssistantHeroUnAssigned = -2106;

		// Token: 0x04003C49 RID: 15433
		public const int ErrCodeHeroAssistantHeroTaskUnfinished = -2107;

		// Token: 0x04003C4A RID: 15434
		public const int ErrCodeHeroAssistantHeroTaskRewardsClaimed = -2108;

		// Token: 0x04003C4B RID: 15435
		public const int ErrCodeHeroAssistantHeroAssignCountMax = -2109;

		// Token: 0x04003C4C RID: 15436
		public const int ErrCodeHeroAssistantWorkHourTooShort = -2110;

		// Token: 0x04003C4D RID: 15437
		public const int ErrCodeHeroAssistantNoHeroAssigned = -2111;

		// Token: 0x04003C4E RID: 15438
		public const int ErrCodeHeroAssistantTaskAssignmentSlotFull = -2112;

		// Token: 0x04003C4F RID: 15439
		public const int ErrCodeLimitedTimeExchangeOperationalActivityNotExistThisItemExchanger = -2200;

		// Token: 0x04003C50 RID: 15440
		public const int ErrCodeLimitedTimeExchangeOperationalActivityThisItemExchangeTimesNotEnough = -2201;

		// Token: 0x04003C51 RID: 15441
		public const int ErrCodeAwardOperationalActivityNotThisReward = -2202;

		// Token: 0x04003C52 RID: 15442
		public const int ErrCodeOperationalActivityRewardRepeatedlyGain = -2203;

		// Token: 0x04003C53 RID: 15443
		public const int ErrCodeThisOperationalActivityNotExist = -2204;

		// Token: 0x04003C54 RID: 15444
		public const int ErrCodeNotAwardOperationalActivityCannotGainReward = -2205;

		// Token: 0x04003C55 RID: 15445
		public const int ErrCodeOperationalActivityIsNotInOperationPeriod = -2206;

		// Token: 0x04003C56 RID: 15446
		public const int ErrCodeAwardOperationalActivityCannotGainRewardInCurrentTime = -2207;

		// Token: 0x04003C57 RID: 15447
		public const int ErrCodeAwardOperationalActivityPlayerLevelIsTooLow = -2208;

		// Token: 0x04003C58 RID: 15448
		public const int ErrCodeAwardOperationalActivityNotLoginSpecificDays = -2209;

		// Token: 0x04003C59 RID: 15449
		public const int ErrCodeAwardOperationalActivityNotReachAccumulateLoginDays = -2209;

		// Token: 0x04003C5A RID: 15450
		public const int ErrCodeAwardOperationalActivityRewardItemGroupIdError = -2210;

		// Token: 0x04003C5B RID: 15451
		public const int ErrCodeAwardOperationalActivityGainRewardTimeOut = -2211;

		// Token: 0x04003C5C RID: 15452
		public const int ErrCodeNotLimitedTimeExchangeOperationalActivityCanExchangeItem = -2212;

		// Token: 0x04003C5D RID: 15453
		public const int ErrCodeUnknownOperationalActivity = -2213;

		// Token: 0x04003C5E RID: 15454
		public const int ErroCodeOperationalActivityTimeConflict = -2214;

		// Token: 0x04003C5F RID: 15455
		public const int ErrCodeAnnouncementTimeOut = -2215;

		// Token: 0x04003C60 RID: 15456
		public const int ErrCodeOperactionalActivityTimeOut = -2216;

		// Token: 0x04003C61 RID: 15457
		public const int ErrCodeAnnouncementNotExist = -2217;

		// Token: 0x04003C62 RID: 15458
		public const int ErrCodeRaffleItemsAllDrawd = -2218;

		// Token: 0x04003C63 RID: 15459
		public const int ErrCodeRaffleNotEnoughDrawItem = -2219;

		// Token: 0x04003C64 RID: 15460
		public const int ErrCodeNotRechargeEnoughRMB = -2220;

		// Token: 0x04003C65 RID: 15461
		public const int ErrCodeNotConsumeEnoughCrystal = -2221;

		// Token: 0x04003C66 RID: 15462
		public const int ErrCodeAddSameEffectOpaerationalActivity = -2222;

		// Token: 0x04003C67 RID: 15463
		public const int ErrCodeOpeningServerActivityCannotUpdate = -2223;

		// Token: 0x04003C68 RID: 15464
		public const int ErrCodeOperacitivityTimeParmError = -2224;

		// Token: 0x04003C69 RID: 15465
		public const int ErrCodeGmPlayerNotExist = -2400;

		// Token: 0x04003C6A RID: 15466
		public const int ErrCodeGmDecreaseMoneyNumsError = -2401;

		// Token: 0x04003C6B RID: 15467
		public const int ErrCodeGmMoneyTypeError = -2402;

		// Token: 0x04003C6C RID: 15468
		public const int ErrCodeGmDecreaseGoodsTypeError = -2403;

		// Token: 0x04003C6D RID: 15469
		public const int ErrCodeGmDecreaseGoodsNumsError = -2404;

		// Token: 0x04003C6E RID: 15470
		public const int ErrCodeGameFunctionIsLocked = -2405;

		// Token: 0x04003C6F RID: 15471
		public const int ErrCodeSurveyRewardRepeatedlyGain = -2500;

		// Token: 0x04003C70 RID: 15472
		public const int ErrCodeSurveyNotExist = -2501;

		// Token: 0x04003C71 RID: 15473
		public const int ErrCodeSurveyNotOpen = -2502;

		// Token: 0x04003C72 RID: 15474
		public const int ErrCodeRepeatedOpen = -2503;

		// Token: 0x04003C73 RID: 15475
		public const int ErrCodeWriteSurveyPlayerLevelNotEnought = -2504;

		// Token: 0x04003C74 RID: 15476
		public const int ErrCodeSurveyTimeConflict = -2505;

		// Token: 0x04003C75 RID: 15477
		public const int ErrCodeGlobalSurveyRepeatedlyAdd = -2506;

		// Token: 0x04003C76 RID: 15478
		public const int ErrorCodeTreasureMapNotEnough = -2600;

		// Token: 0x04003C77 RID: 15479
		public const int ErrCodeTreasureLevelNotExist = -2601;

		// Token: 0x04003C78 RID: 15480
		public const int ErrCodeTreasureLevelBattleIdError = -2602;

		// Token: 0x04003C79 RID: 15481
		public const int ErrCodeTeasureMapFunctionNotOpen = -2603;

		// Token: 0x04003C7A RID: 15482
		public const int ErrCodeDanmakuGameFunctionTypeError = -2700;

		// Token: 0x04003C7B RID: 15483
		public const int ErrCodeDanmakuLocationIdNotExsit = -2701;

		// Token: 0x04003C7C RID: 15484
		public const int ErrCodeDanmakuBattleTurnOutOfRange = -2702;

		// Token: 0x04003C7D RID: 15485
		public const int ErrCodeDanmakuNotUniqueOrSorted = -2703;

		// Token: 0x04003C7E RID: 15486
		public const int ErrorCodeMemoryCorridorTicketNotEnough = -2800;

		// Token: 0x04003C7F RID: 15487
		public const int ErrCodeMemoryCorridorLevelNotExist = -2801;

		// Token: 0x04003C80 RID: 15488
		public const int ErrCodeMemoryCorridorLevelBattleIdError = -2802;

		// Token: 0x04003C81 RID: 15489
		public const int ErrCodeMemoryCorridorLevelNotOpenInCurrentTime = -2803;

		// Token: 0x04003C82 RID: 15490
		public const int ErrCodeMemoryCorridorNotOpen = -2804;

		// Token: 0x04003C83 RID: 15491
		public const int ErrCodeMemoryCorridorFunctionNotOpen = -2805;

		// Token: 0x04003C84 RID: 15492
		public const int ErrCodeHeroDungeonLevelNotExist = -2900;

		// Token: 0x04003C85 RID: 15493
		public const int ErrCodePreHeroDungeonLevelNotComplete = -2901;

		// Token: 0x04003C86 RID: 15494
		public const int ErrCodeHeroDungeonLevelUnlockConditionTypeError = -2902;

		// Token: 0x04003C87 RID: 15495
		public const int ErrCodeUnlockHeroDungeonLevelHeroFavorabilityLevelNotEnough = -2903;

		// Token: 0x04003C88 RID: 15496
		public const int ErrCodeHeroDungeonLevelBattleIdError = -2904;

		// Token: 0x04003C89 RID: 15497
		public const int ErrCodeHeroDungeonLevelAttackNumsNotEnough = -2905;

		// Token: 0x04003C8A RID: 15498
		public const int ErrCodeHeroDungeonLevelNotComplete = -2906;

		// Token: 0x04003C8B RID: 15499
		public const int ErrCodeHeroDungeonLevelStarNotEnough = -2907;

		// Token: 0x04003C8C RID: 15500
		public const int ErrCodeHeroDungeonChapterNotAttack = -2908;

		// Token: 0x04003C8D RID: 15501
		public const int ErrCodeHeroDungeonLevelChapterIdError = -2909;

		// Token: 0x04003C8E RID: 15502
		public const int ErrCodeGainHeroDungeonChapterStarRewardIndexError = -2910;

		// Token: 0x04003C8F RID: 15503
		public const int ErrCodeHeroDungeonChapterStarsNotEnough = -2911;

		// Token: 0x04003C90 RID: 15504
		public const int ErrCodeHeroDungeonChapterStarRewardRepeatedlyGot = -2912;

		// Token: 0x04003C91 RID: 15505
		public const int ErrCodeHeroDungeonLevelRaidParamError = -2913;

		// Token: 0x04003C92 RID: 15506
		public const int ErrCodeHeroDungeonFunctioinNotOpen = -2914;

		// Token: 0x04003C93 RID: 15507
		public const int ErrCodeHeroDungeonGainChapterIndexParmOutOfRange = -2915;

		// Token: 0x04003C94 RID: 15508
		public const int ErrCodeHeroFetterFunctioinNotOpen = -2916;

		// Token: 0x04003C95 RID: 15509
		public const int ErrCodeTodayChallengeNumsUsedOut = -2917;

		// Token: 0x04003C96 RID: 15510
		public const int ErrCodeTeamGameFunctionTypeError = -3000;

		// Token: 0x04003C97 RID: 15511
		public const int ErrCodeTeamLocationIdNotFinished = -3001;

		// Token: 0x04003C98 RID: 15512
		public const int ErrCodeTeamLevelOutofRange = -3002;

		// Token: 0x04003C99 RID: 15513
		public const int ErrCodeTeamMemberNumsIsFull = -3003;

		// Token: 0x04003C9A RID: 15514
		public const int ErrCodeTeamPlayerHasBeenJoined = 3004;

		// Token: 0x04003C9B RID: 15515
		public const int ErrCodeTeamTheyAreNotSocialRelation = -3005;

		// Token: 0x04003C9C RID: 15516
		public const int ErrCodeTeamRoomNotPublic = -3006;

		// Token: 0x04003C9D RID: 15517
		public const int ErrCodeTeamLevelNotFinished = -3007;

		// Token: 0x04003C9E RID: 15518
		public const int ErrCodeTeamAlreadyInTeam = -3008;

		// Token: 0x04003C9F RID: 15519
		public const int ErrCodeTeamServerNetError = -3009;

		// Token: 0x04003CA0 RID: 15520
		public const int ErrCodeTeamRoomSettingAuthorityOutOfRange = -3010;

		// Token: 0x04003CA1 RID: 15521
		public const int ErrCodeTeamRoomSettingLevelOutOfRange = -3011;

		// Token: 0x04003CA2 RID: 15522
		public const int ErrCodeTeamViewTeamRoomGameFunctionTypeError = -3012;

		// Token: 0x04003CA3 RID: 15523
		public const int ErrCodeTeamCancelAutoMatchNotInWaiting = -3013;

		// Token: 0x04003CA4 RID: 15524
		public const int ErrCodeTeamNotInRoom = -3014;

		// Token: 0x04003CA5 RID: 15525
		public const int ErrCodeTeamChangeAuthorityNotLeader = -3015;

		// Token: 0x04003CA6 RID: 15526
		public const int ErrCodeTeamRoomIdNotExist = -3016;

		// Token: 0x04003CA7 RID: 15527
		public const int ErrCodeTeamJoinRoomSettingNotMatch = -3017;

		// Token: 0x04003CA8 RID: 15528
		public const int ErrCodeTeamJoinRoomAuthorityNotEnough = -3018;

		// Token: 0x04003CA9 RID: 15529
		public const int ErrCodeTeamNotInTeam = 3019;

		// Token: 0x04003CAA RID: 15530
		public const int ErrCodeTeamChannelIdNotExist = -3020;

		// Token: 0x04003CAB RID: 15531
		public const int ErrCodeTeamInvitationNotExist = -3021;

		// Token: 0x04003CAC RID: 15532
		public const int ErrCodeTeamInviteFriendNotOnline = -3022;

		// Token: 0x04003CAD RID: 15533
		public const int ErrCodeTeamInviteTooBusy = -3023;

		// Token: 0x04003CAE RID: 15534
		public const int ErrCodeTeamCreateBattleRoomPermissionDenied = -3024;

		// Token: 0x04003CAF RID: 15535
		public const int ErrCodeTeamCannotFindSuitableBattleServer = -3025;

		// Token: 0x04003CB0 RID: 15536
		public const int ErrCodeTeamCreateBattleRoomPlayerNumsNotEnough = -3026;

		// Token: 0x04003CB1 RID: 15537
		public const int ErrCodeTeamViewTeamRoomChapterIdNotExist = -3027;

		// Token: 0x04003CB2 RID: 15538
		public const int ErrCodeTeamGetInviteeLevelInfoNumsOutOfRange = -3028;

		// Token: 0x04003CB3 RID: 15539
		public const int ErrCodeTeamChangePositionNotLeader = -3029;

		// Token: 0x04003CB4 RID: 15540
		public const int ErrCodeTeamChangePositionParamError = -3030;

		// Token: 0x04003CB5 RID: 15541
		public const int ErrCodeFriendFriendsFullError = -4000;

		// Token: 0x04003CB6 RID: 15542
		public const int ErrCodeFriendTargetFriendsFullError = -4001;

		// Token: 0x04003CB7 RID: 15543
		public const int ErrCodeFriendInvitationFullError = -4002;

		// Token: 0x04003CB8 RID: 15544
		public const int ErrCodeFriendAlreadyFriendError = -4003;

		// Token: 0x04003CB9 RID: 15545
		public const int ErrCodeFriendCannotBecomeFriendsWhenBlocked = -4004;

		// Token: 0x04003CBA RID: 15546
		public const int ErrCodeFriendCannotInviteBlockedPlayer = -4005;

		// Token: 0x04003CBB RID: 15547
		public const int ErrCodeFriendCannotInviteWhenBlocked = -4006;

		// Token: 0x04003CBC RID: 15548
		public const int ErrCodeFriendCannotBlockFriend = -4007;

		// Token: 0x04003CBD RID: 15549
		public const int ErrCodeFriendServerNetError = -4008;

		// Token: 0x04003CBE RID: 15550
		public const int ErrCodeCannotSendLikesToSelf = -4009;

		// Token: 0x04003CBF RID: 15551
		public const int ErrCodeHasSendLikesToday = -4010;

		// Token: 0x04003CC0 RID: 15552
		public const int ErrCodeSelectPlayerNotExist = -4011;

		// Token: 0x04003CC1 RID: 15553
		public const int ErrCodeBusinessCardDescIsNullOrIllegal = -4012;

		// Token: 0x04003CC2 RID: 15554
		public const int ErrCodeBusineddCardDescTooLong = -4013;

		// Token: 0x04003CC3 RID: 15555
		public const int ErrCodeBusinessCardHeroSetIsNull = -4014;

		// Token: 0x04003CC4 RID: 15556
		public const int ErrCodeFriendServerNotFound = -4015;

		// Token: 0x04003CC5 RID: 15557
		public const int ErrCodeTargetGameServerNotFound = -4016;

		// Token: 0x04003CC6 RID: 15558
		public const int ErrCodeGSToFSRpcOperationFail = -4017;

		// Token: 0x04003CC7 RID: 15559
		public const int ErrCodeFriendCannotInviteYourself = -4018;

		// Token: 0x04003CC8 RID: 15560
		public const int ErrCodeFriendInviteSameUser = -4019;

		// Token: 0x04003CC9 RID: 15561
		public const int ErrCodeFriendAlreadyInvited = -4020;

		// Token: 0x04003CCA RID: 15562
		public const int ErrCodeFriendPracticeTargetNotOnline = -4021;

		// Token: 0x04003CCB RID: 15563
		public const int ErrCodeFriendNotYourFriend = -4022;

		// Token: 0x04003CCC RID: 15564
		public const int ErrCodeFriendAlreadySentFriendshipPoints = -4023;

		// Token: 0x04003CCD RID: 15565
		public const int ErrCodeFriendAlreadyReceivedFriendshipPoints = -4024;

		// Token: 0x04003CCE RID: 15566
		public const int ErrCodeFriendSentFriendshipPointsTooManyTimes = -4025;

		// Token: 0x04003CCF RID: 15567
		public const int ErrCodeFriendReceiveFriendshipPointsTooManyTimes = -4026;

		// Token: 0x04003CD0 RID: 15568
		public const int ErrCodeFriendReceiveFriendshipPointsSenderNotExist = -4027;

		// Token: 0x04003CD1 RID: 15569
		public const int ErrCodeFriendBlackListFull = -4028;

		// Token: 0x04003CD2 RID: 15570
		public const int ErrCodeFriendTargetFriendsFullErrorBatch = -4029;

		// Token: 0x04003CD3 RID: 15571
		public const int ErrCodeFriendInvitationFullErrorBatch = -4030;

		// Token: 0x04003CD4 RID: 15572
		public const int ErrCodeFriendAlreadyFriendErrorBatch = -4031;

		// Token: 0x04003CD5 RID: 15573
		public const int ErrCodeFriendCannotInviteBlockedPlayerBatch = -4032;

		// Token: 0x04003CD6 RID: 15574
		public const int ErrCodeFriendCannotInviteWhenBlockedBatch = -4033;

		// Token: 0x04003CD7 RID: 15575
		public const int ErrCodeFriendCannotInviteYourselfBatch = -4034;

		// Token: 0x04003CD8 RID: 15576
		public const int ErrCodeFriendInviteSameUserBatch = -4035;

		// Token: 0x04003CD9 RID: 15577
		public const int ErrCodeFriendAlreadyInvitedBatch = -4036;

		// Token: 0x04003CDA RID: 15578
		public const int ErrCodeFriendFriendsFullErrorBatch = -4037;

		// Token: 0x04003CDB RID: 15579
		public const int ErrCodeFriendCannotBecomeFriendsWhenBlockedBatch = -4038;

		// Token: 0x04003CDC RID: 15580
		public const int ErrCodeFriendCannotBlockMyself = -4039;

		// Token: 0x04003CDD RID: 15581
		public const int ErrCodeFriendBusinessCardDescBanned = -4040;

		// Token: 0x04003CDE RID: 15582
		public const int ErrCodeFriendUnknown = -4099;

		// Token: 0x04003CDF RID: 15583
		public const int ErrCodeRankingListQuerySingleHeroIdError = -4100;

		// Token: 0x04003CE0 RID: 15584
		public const int ErrCodeRankingListQueryLevelLimit = -4101;

		// Token: 0x04003CE1 RID: 15585
		public const int ErrCodeRankingListQueryPeriodLimit = -4102;

		// Token: 0x04003CE2 RID: 15586
		public const int ErrCodeRankingListQueryUnknown = -4103;

		// Token: 0x04003CE3 RID: 15587
		public const int ErrCodeSearchRankingListTypeError = -4104;

		// Token: 0x04003CE4 RID: 15588
		public const int ErrCodeHeroTrainningNotOpen = -4200;

		// Token: 0x04003CE5 RID: 15589
		public const int ErrCodeHeroTrainningLevelNotExist = -4201;

		// Token: 0x04003CE6 RID: 15590
		public const int ErrCodeHeroTrainningLevelNotOpenInCurrentTime = -4202;

		// Token: 0x04003CE7 RID: 15591
		public const int ErrCodeHeroTrainningChallengeNumsReachMax = -4203;

		// Token: 0x04003CE8 RID: 15592
		public const int ErrCodeHeroTrainningLevelIdError = -4204;

		// Token: 0x04003CE9 RID: 15593
		public const int ErrCodeHeroTrainningChallengeCountUseOut = -4205;

		// Token: 0x04003CEA RID: 15594
		public const int ErrCodeHeroTrainningLevelBattleIdError = -4206;

		// Token: 0x04003CEB RID: 15595
		public const int ErrCodeHeroTrainningTicketNotEnough = -4207;

		// Token: 0x04003CEC RID: 15596
		public const int ErrCodeHeroTrainningFunctionNotOpen = -4208;

		// Token: 0x04003CED RID: 15597
		public const int ErrCodeChatGroupCreateFailed = -4300;

		// Token: 0x04003CEE RID: 15598
		public const int ErrCodeChatGroupFull = -4301;

		// Token: 0x04003CEF RID: 15599
		public const int ErrCodeChatGroupMemberFull = -4302;

		// Token: 0x04003CF0 RID: 15600
		public const int ErrCodeChatGroupNotOwner = -4303;

		// Token: 0x04003CF1 RID: 15601
		public const int ErrCodeChangeGroupOwnerFailed = -4304;

		// Token: 0x04003CF2 RID: 15602
		public const int ErrCodeChatGroupOwnerCannotLeave = -4305;

		// Token: 0x04003CF3 RID: 15603
		public const int ErrCodeChatGroupNameIllegal = -4306;

		// Token: 0x04003CF4 RID: 15604
		public const int ErrCodeChatGroupNameTooLong = -4307;

		// Token: 0x04003CF5 RID: 15605
		public const int ErrCodeChatGroupTargetChatGroupFull = -4308;

		// Token: 0x04003CF6 RID: 15606
		public const int ErrCodeChatGroupNotExist = -4309;

		// Token: 0x04003CF7 RID: 15607
		public const int ErrCodeChatGroupMemberFullBatch = -4310;

		// Token: 0x04003CF8 RID: 15608
		public const int ErrCodeChatGroupTargetChatGroupFullBatch = -4311;

		// Token: 0x04003CF9 RID: 15609
		public const int ErrCodeHeroPhantomNotOpen = -4400;

		// Token: 0x04003CFA RID: 15610
		public const int ErrCodeHeroPhantomLevelNotAvailable = -4401;

		// Token: 0x04003CFB RID: 15611
		public const int ErrCodeHeroPhantomLevelNotExist = -4402;

		// Token: 0x04003CFC RID: 15612
		public const int ErrCodeCooperateBattleNotOpen = -4500;

		// Token: 0x04003CFD RID: 15613
		public const int ErrCodeCooperateBattleLevelNotAvailable = -4501;

		// Token: 0x04003CFE RID: 15614
		public const int ErrCodeCooperateBattleLevelNotExist = -4502;

		// Token: 0x04003CFF RID: 15615
		public const int ErrCodeCooperateBattleFunctionNotOpen = -4503;

		// Token: 0x04003D00 RID: 15616
		public const int ErrCodeNoviceRewardNotExist = -4600;

		// Token: 0x04003D01 RID: 15617
		public const int ErrCodeNoviceRewardAlreadyClaimed = -4601;

		// Token: 0x04003D02 RID: 15618
		public const int ErrCodeNoviceMissionPointsNotEnough = -4602;

		// Token: 0x04003D03 RID: 15619
		public const int ErrCodeMatchmakingTimeout = -4700;

		// Token: 0x04003D04 RID: 15620
		public const int ErrCodeMatchmakingCancelFailed = -4701;

		// Token: 0x04003D05 RID: 15621
		public const int ErrCodeRealTimePVPWinsBonusNotExist = -4702;

		// Token: 0x04003D06 RID: 15622
		public const int ErrCodeRealTimePVPWinsBonusAlreadyAcquired = -4703;

		// Token: 0x04003D07 RID: 15623
		public const int ErrCodeRealTimePVPWinsBonusNotEnoughWins = -4704;

		// Token: 0x04003D08 RID: 15624
		public const int ErrCodeRealTimePVPGameFunctionLocked = -4705;

		// Token: 0x04003D09 RID: 15625
		public const int ErrCodeRealTimePVPArenaClosed = -4706;

		// Token: 0x04003D0A RID: 15626
		public const int ErrCodeMatchmakingAlreadyMatchmaking = -4707;

		// Token: 0x04003D0B RID: 15627
		public const int ErrCodeRechargeStoreGoodsNotExist = -4800;

		// Token: 0x04003D0C RID: 15628
		public const int ErrCodeRechargeStoreGoodsIsOnBanBuyingPeriod = -4801;

		// Token: 0x04003D0D RID: 15629
		public const int ErrCodeRechargeStoreGoodsNotOnBanBuyingPeriod = -4802;

		// Token: 0x04003D0E RID: 15630
		public const int ErrCodeRafflePoolNotOpenInCurrentTime = -4900;

		// Token: 0x04003D0F RID: 15631
		public const int ErrCodeRafflePoolNotExist = -4901;

		// Token: 0x04003D10 RID: 15632
		public const int ErrCodeResourceSkinNotExsit = -5000;

		// Token: 0x04003D11 RID: 15633
		public const int ErrCodeResourceSkinNotMatchHero = -5001;

		// Token: 0x04003D12 RID: 15634
		public const int ErrCodeResourceSkinNotMatchJob = -5002;

		// Token: 0x04003D13 RID: 15635
		public const int ErrCodeResourceSkinNotMatchSoldier = -5003;

		// Token: 0x04003D14 RID: 15636
		public const int ErrCodeResourceNoSkinWeared = -5004;

		// Token: 0x04003D15 RID: 15637
		public const int ErrCodeGiftStoreItemNotExist = -5100;

		// Token: 0x04003D16 RID: 15638
		public const int ErrCodeGiftStoreItemNotOnSaleTime = -5101;

		// Token: 0x04003D17 RID: 15639
		public const int ErrCodeGiftStoreItemIsSellOut = -5102;

		// Token: 0x04003D18 RID: 15640
		public const int ErrCodeNotExistThisWaitPayingGoods = -5103;

		// Token: 0x04003D19 RID: 15641
		public const int ErrCodeCheatBuyingFirstBuyGoods = -5104;

		// Token: 0x04003D1A RID: 15642
		public const int ErrCodeGiftStoreItemAppleSubscribeAttributeError = -5105;

		// Token: 0x04003D1B RID: 15643
		public const int ErrCodeJustMonthCardCanBeAppleSubscribed = -5106;

		// Token: 0x04003D1C RID: 15644
		public const int ErrCodeAppleSubscribeRepeatly = -5107;

		// Token: 0x04003D1D RID: 15645
		public const int ErrCodeCheatBuyingGiftStoreItem = -5108;

		// Token: 0x04003D1E RID: 15646
		public const int ErrCodeOperationalGoodsListIsEmpty = -5109;

		// Token: 0x04003D1F RID: 15647
		public const int ErrCodeNotGiftStoreOperationalGoods = -5110;

		// Token: 0x04003D20 RID: 15648
		public const int ErrCodeAppleSubscribeGoodsNotEqualToOne = -5111;

		// Token: 0x04003D21 RID: 15649
		public const int ErrCodeWaitZilongCheckGoodsSubscribing = -5112;

		// Token: 0x04003D22 RID: 15650
		public const int ErrCodeGiftStoreGoodsIsOnBanBuyingPeriod = -5113;

		// Token: 0x04003D23 RID: 15651
		public const int ErrCodeGiftStoreGoodsNotOnBanBuyingPeriod = -5114;

		// Token: 0x04003D24 RID: 15652
		public const int ErrCodeOrderNotExist = -5115;

		// Token: 0x04003D25 RID: 15653
		public const int ErrCodeGuildCreateLevelNotEnough = -5200;

		// Token: 0x04003D26 RID: 15654
		public const int ErrCodeGuildHasOwnGuild = -5201;

		// Token: 0x04003D27 RID: 15655
		public const int ErrCodeGuildPlayerNotExist = -5202;

		// Token: 0x04003D28 RID: 15656
		public const int ErrCodeGuildJoinCoolDown = -5203;

		// Token: 0x04003D29 RID: 15657
		public const int ErrCodeGuildNameDuplicate = -5204;

		// Token: 0x04003D2A RID: 15658
		public const int ErrCodeGuildSearchTimeLimit = -5205;

		// Token: 0x04003D2B RID: 15659
		public const int ErrCodeGuildNameIllegal = -5206;

		// Token: 0x04003D2C RID: 15660
		public const int ErrCodePlayerNotInGuild = -5207;

		// Token: 0x04003D2D RID: 15661
		public const int ErrCodePlayerNotPresidentOrVicePresident = -5208;

		// Token: 0x04003D2E RID: 15662
		public const int ErrCodeHiringDeclarationContentIsIllegal = -5209;

		// Token: 0x04003D2F RID: 15663
		public const int ErrCodeHiringDeclarationLengthIsIllegal = -5210;

		// Token: 0x04003D30 RID: 15664
		public const int ErrCodeHiringDeclarationIsEmpty = -5211;

		// Token: 0x04003D31 RID: 15665
		public const int ErrCodeGuildNameOutOfRange = -5212;

		// Token: 0x04003D32 RID: 15666
		public const int ErrCodePlayerNotPresident = -5213;

		// Token: 0x04003D33 RID: 15667
		public const int ErrCodePlayerIsAlreadyVicePresident = -5214;

		// Token: 0x04003D34 RID: 15668
		public const int ErrCodeDestPlayerNotVicePresident = -5215;

		// Token: 0x04003D35 RID: 15669
		public const int ErrCodeGuildVicePresidentNumsReachMax = -5216;

		// Token: 0x04003D36 RID: 15670
		public const int ErrCodeDestPlayerNotPresident = -5217;

		// Token: 0x04003D37 RID: 15671
		public const int ErrCodePlayerNotVicePresidentOrElite = -5218;

		// Token: 0x04003D38 RID: 15672
		public const int ErrCodeGuildPresidentNotOfflineTooLong = -5219;

		// Token: 0x04003D39 RID: 15673
		public const int ErrCodeGuildNotExist = -5220;

		// Token: 0x04003D3A RID: 15674
		public const int ErrCodePlayerNotHaveThisGuildOperateJurisdiction = -5221;

		// Token: 0x04003D3B RID: 15675
		public const int ErrCodeGuildAnnouncementContentIsIllegal = -5222;

		// Token: 0x04003D3C RID: 15676
		public const int ErrCodeGuildAnnouncementLengthIsIllegal = -5223;

		// Token: 0x04003D3D RID: 15677
		public const int ErrCodeGuildMemberIsFull = -5224;

		// Token: 0x04003D3E RID: 15678
		public const int ErrCodeGuildJoinLevelNotEnough = -5225;

		// Token: 0x04003D3F RID: 15679
		public const int ErrCodeGuildJoinInvationNotExist = -5226;

		// Token: 0x04003D40 RID: 15680
		public const int ErrCodeGuildApplyNotExist = -5227;

		// Token: 0x04003D41 RID: 15681
		public const int ErrCodeSetPlayerJoinLevelError = -5228;

		// Token: 0x04003D42 RID: 15682
		public const int ErrCodeGuildPresidentCannotAppointSelf = -5229;

		// Token: 0x04003D43 RID: 15683
		public const int ErrCodeGuildMassiveCombatMaxCombatsPerWeekExceeded = -5230;

		// Token: 0x04003D44 RID: 15684
		public const int ErrCodeGuildMassiveCombatOnlyPresidentCanStartCombat = -5231;

		// Token: 0x04003D45 RID: 15685
		public const int ErrCodeGuildMassiveCombatMoreThanOneCombatNotAllowed = -5232;

		// Token: 0x04003D46 RID: 15686
		public const int ErrCodeGuildMassiveCombatAvailableMembersNotEnough = -5233;

		// Token: 0x04003D47 RID: 15687
		public const int ErrCodeGuildMassiveCombatInvalidDifficulty = -5234;

		// Token: 0x04003D48 RID: 15688
		public const int ErrCodeGuildMassiveCombatNoExist = -5235;

		// Token: 0x04003D49 RID: 15689
		public const int ErrCodeGuildMassiveCombatCannotParticipateInDifferentGuild = -5236;

		// Token: 0x04003D4A RID: 15690
		public const int ErrCodeGuildMassiveCombatHeroAlreadyUsed = -5237;

		// Token: 0x04003D4B RID: 15691
		public const int ErrCodeGuildMassiveCombatStrongholdTaken = -5238;

		// Token: 0x04003D4C RID: 15692
		public const int ErrCodeGuildMedalNotEnough = -5239;

		// Token: 0x04003D4D RID: 15693
		public const int ErrCodeGuildMassiveCombatLevelNotExist = -5240;

		// Token: 0x04003D4E RID: 15694
		public const int ErrCodeGuildMassiveCombatOnlyPresidentAndVPCanSurrender = -5241;

		// Token: 0x04003D4F RID: 15695
		public const int ErrCodeUnchartedScoreNotOpenInCurrentTime = -5300;

		// Token: 0x04003D50 RID: 15696
		public const int ErrCodeUnchartedScoreNotExist = -5301;

		// Token: 0x04003D51 RID: 15697
		public const int ErrCodeUnchartedScoreChallengeLevelNotContains = -5302;

		// Token: 0x04003D52 RID: 15698
		public const int ErrCodeUnchartedScoreChallengeLevelNotExist = -5303;

		// Token: 0x04003D53 RID: 15699
		public const int ErrCodeUnchartedScoreChallengeLevelNotUnlock = -5304;

		// Token: 0x04003D54 RID: 15700
		public const int ErrCodeUnchartedScoreChallengeLevelAlreadyAttack = -5305;

		// Token: 0x04003D55 RID: 15701
		public const int ErrCodeUnchartedScoreChallengeLevelPrevLevelNotComplete = -5306;

		// Token: 0x04003D56 RID: 15702
		public const int ErrCodeUnchartedScoreScoreLevelNotContains = -5307;

		// Token: 0x04003D57 RID: 15703
		public const int ErrCodeUnchartedScoreScoreLevelNotExist = -5308;

		// Token: 0x04003D58 RID: 15704
		public const int ErrCodeUnchartedScoreScoreLevelPlayerLimit = -5309;

		// Token: 0x04003D59 RID: 15705
		public const int ErrCodeUnchartedScoreScoreLevelAlreadyAttack = -5310;

		// Token: 0x04003D5A RID: 15706
		public const int ErrCodeUnchartedScoreScoreLevelUnLock = -5311;

		// Token: 0x04003D5B RID: 15707
		public const int ErrCodeUnchartedScoreRewardNotExist = -5312;

		// Token: 0x04003D5C RID: 15708
		public const int ErrCodeUnchartedScoreRewardScoreNotEnough = -5313;

		// Token: 0x04003D5D RID: 15709
		public const int ErrCodeUnchartedScoreRewardGained = -5314;

		// Token: 0x04003D5E RID: 15710
		public const int ErrCodeClimbTowerFloorIdInvalid = -5400;

		// Token: 0x04003D5F RID: 15711
		public const int ErrCodeClimbTowerPrevFloorNotComplete = -5401;

		// Token: 0x04003D60 RID: 15712
		public const int ErrCodeClimbTowerLevelNotExist = -5402;

		// Token: 0x04003D61 RID: 15713
		public const int ErrCodeClimbTowerAlreadyFlush = -5403;

		// Token: 0x04003D62 RID: 15714
		public const int ErrCodeClimbTowerAttackCurFloorInvalid = -5404;

		// Token: 0x04003D63 RID: 15715
		public const int ErrCodeClimbTowerFloorNotExist = -5405;

		// Token: 0x04003D64 RID: 15716
		public const int ErrCodeClimbTowerBonusHeroGroupNotExist = -5406;

		// Token: 0x04003D65 RID: 15717
		public const int ErrCodeClimbTowerFloorConfigError = -5407;

		// Token: 0x04003D66 RID: 15718
		public const int ErrCodeClimbTowerBattleFinishFloorError = -5408;

		// Token: 0x04003D67 RID: 15719
		public const int ErrCodeClimbTowerFloorCantRaid = -5409;

		// Token: 0x04003D68 RID: 15720
		public const int ErrCodeClimbTowerAlreadyReachTopTower = -5410;

		// Token: 0x04003D69 RID: 15721
		public const int ErrCodeGoodsTypeRelatedIdError = -10000;

		// Token: 0x04003D6A RID: 15722
		public const int ErrCodeSignRewardIdError = -100001;

		// Token: 0x04003D6B RID: 15723
		public const int ErrCodeChapterRewardIdError = -10002;

		// Token: 0x04003D6C RID: 15724
		public const int ErrCodeEventRewardIdError = -10003;

		// Token: 0x04003D6D RID: 15725
		public const int ErrCodeRiftRewardIdError = -10004;

		// Token: 0x04003D6E RID: 15726
		public const int ErrCodeInitInfoRewardIdError = -10005;

		// Token: 0x04003D6F RID: 15727
		public const int ErrCodeRandomDropRewardIdError = -10006;

		// Token: 0x04003D70 RID: 15728
		public const int ErrCodeScenarioRewardIdError = -10007;

		// Token: 0x04003D71 RID: 15729
		public const int ErrCodeFreeCardPoolGoodsIdError = -10008;

		// Token: 0x04003D72 RID: 15730
		public const int ErrCodeCrystalCardPoolGoodsIdError = -10009;

		// Token: 0x04003D73 RID: 15731
		public const int ErrCodeActivityCardPoolGoodsIdError = -10010;

		// Token: 0x04003D74 RID: 15732
		public const int ErrCodeDefiniteGroupRandomEventTotalWeightNotEqualMax = -10011;

		// Token: 0x04003D75 RID: 15733
		public const int ErrCodeRandomGroupTotalWeightNotEqualMax = -10012;

		// Token: 0x04003D76 RID: 15734
		public const int ErrCodeRandomGroupRandomEventTotalWeightNotEqualMax = -10013;

		// Token: 0x04003D77 RID: 15735
		public const int ErrCodeStoreWeightError = -10014;

		// Token: 0x04003D78 RID: 15736
		public const int ErrCodeFirstScenarioIdError = -10015;

		// Token: 0x04003D79 RID: 15737
		public const int ErrCodeSkillHitMaxAboveZeroTime_MultiHitCountBelowZero = -10016;

		// Token: 0x04003D7A RID: 15738
		public const int ErrCodeFlyItemSpeedNotAboveZero = -10017;

		// Token: 0x04003D7B RID: 15739
		public const int ErrCodeHeroDefaultSkillsCostAboveHeroFirstLevelSkillPoint = -10018;

		// Token: 0x04003D7C RID: 15740
		public const int ErrCodeDefiniteGroupLevelZoneNotEqualRandomEventLevelZoneConfig = -10019;

		// Token: 0x04003D7D RID: 15741
		public const int ErrCodeRandomGroupLevelZoneNotEqualRandomEventLevelZoneConfig = -10020;

		// Token: 0x04003D7E RID: 15742
		public const int ErrCodeCardPoolGroupTenSelectTotalMinCountIsAboveTen = -10021;

		// Token: 0x04003D7F RID: 15743
		public const int ErrCodeConstRandomEventTimeConfigError = -10022;

		// Token: 0x04003D80 RID: 15744
		public const int ErrCodeHeroJobUnlockConditionItemCostIdError = -10023;

		// Token: 0x04003D81 RID: 15745
		public const int ErrCodeHeroJobUnlockConditionAchievementIdError = -10024;

		// Token: 0x04003D82 RID: 15746
		public const int ErrCodeHeroJobUnlockPreJobNotExist = -10025;

		// Token: 0x04003D83 RID: 15747
		public const int ErrCodeStaticBoxIdError = -10026;

		// Token: 0x04003D84 RID: 15748
		public const int ErrCodeRandomBoxIdError = -10027;

		// Token: 0x04003D85 RID: 15749
		public const int ErrCodeRandomBoxMinCountAboveMaxCount = -10028;

		// Token: 0x04003D86 RID: 15750
		public const int ErrCodeThearchyTrialLevelRepeated = -10029;

		// Token: 0x04003D87 RID: 15751
		public const int ErrCodeAnikiGymLevelRepeated = -10030;

		// Token: 0x04003D88 RID: 15752
		public const int ErrCodeHeroDefaultSkillIdCannotBeEquipedByDefaultJob = -10031;

		// Token: 0x04003D89 RID: 15753
		public const int ErrCodeFixedStoreItemShowTimeFormError = -10032;

		// Token: 0x04003D8A RID: 15754
		public const int ErrCodeFixedStoreItemFirstRewardIdError = -10033;

		// Token: 0x04003D8B RID: 15755
		public const int ErrCodeFixedStoreSellItemIdError = -10034;

		// Token: 0x04003D8C RID: 15756
		public const int ErrCodeFixedStoreItemDiscountTimeFormError = -10035;

		// Token: 0x04003D8D RID: 15757
		public const int ErrCodeTrainingHouseArmyListError = -10036;

		// Token: 0x04003D8E RID: 15758
		public const int ErrCodeTrainingHouseCoachNotExist = -10037;

		// Token: 0x04003D8F RID: 15759
		public const int ErrCodeCoachFavorabilityCoachNotExist = -10038;

		// Token: 0x04003D90 RID: 15760
		public const int ErrCodeCoachFavorabilityLevelError = -10039;

		// Token: 0x04003D91 RID: 15761
		public const int ErrCodeCoachFavorabilityLevelUpCostItemIdError = -10040;

		// Token: 0x04003D92 RID: 15762
		public const int ErrCodeAboveTwoTrainingHouseHasSameCoach = -10041;

		// Token: 0x04003D93 RID: 15763
		public const int ErrCodeTrainingInstrumentStartLevelError = -10042;

		// Token: 0x04003D94 RID: 15764
		public const int ErrCodeCoachFavorabilityStartLevelError = -10043;

		// Token: 0x04003D95 RID: 15765
		public const int ErrCodeCoachFavorabilityTableCoachTotalNumberNotEqualCoachTableNumbers = -10044;

		// Token: 0x04003D96 RID: 15766
		public const int ErrCodeCoachFavorabilityUnlockInstrumentIdNotInTrainingHouseInstrumentIDList = -10045;

		// Token: 0x04003D97 RID: 15767
		public const int ErrCodeInitInfoContainProtagonistHeroId = -10046;

		// Token: 0x04003D98 RID: 15768
		public const int ErrCodeHeroInteractionInitialPleasureValueError = -10047;

		// Token: 0x04003D99 RID: 15769
		public const int ErrCodeHeroBodyZoneInitialToleranceValueError = -10048;

		// Token: 0x04003D9A RID: 15770
		public const int ErrCodeFirstInitInfoNotExist = -10049;

		// Token: 0x04003D9B RID: 15771
		public const int ErrCodeHerMaxLevelBelowPlayerMaxLevelCelling = -10050;

		// Token: 0x04003D9C RID: 15772
		public const int ErrCodeRiftChapterContainsSameLevel = -10051;

		// Token: 0x04003D9D RID: 15773
		public const int ErrCodeHeroHasInstanceLevelRepeated = -10052;

		// Token: 0x04003D9E RID: 15774
		public const int ErrCodeHeroDungeonStarRewardItemIdError = -10053;

		// Token: 0x04003D9F RID: 15775
		public const int ErrCodeHeroDungeonLevelAchievementRewardItemIdError = -10054;

		// Token: 0x04003DA0 RID: 15776
		public const int ErrCodePlayerMaxLevelAboveRandomEventLevelZoneMaxLeve = -10055;

		// Token: 0x04003DA1 RID: 15777
		public const int ErrCodeHeroHasFetterRepeated = -10056;

		// Token: 0x04003DA2 RID: 15778
		public const int ErrCodeRandomStoreItemInfoLevelZoneIDError = -10057;

		// Token: 0x04003DA3 RID: 15779
		public const int ErrCodePlayerLevelUpOperationalActivityItemGroupRewardParmError = -10058;

		// Token: 0x04003DA4 RID: 15780
		public const int ErrCodeLimitedTimeExchangeOperationalActivityItemItemGroupParmError = -10059;

		// Token: 0x04003DA5 RID: 15781
		public const int ErrCodeSpecificDaysLoginOperationalActivityItemGroupRewardParmError = -10060;

		// Token: 0x04003DA6 RID: 15782
		public const int ErrCodeAccumulateDaysLoginOperationalActivityItemGroupRewardParmError = -10061;

		// Token: 0x04003DA7 RID: 15783
		public const int ErrCodeRewardAddOperationalActivityPlayParmError = -10062;

		// Token: 0x04003DA8 RID: 15784
		public const int ErrCodeChallengeNumsAddOperationalActivityPlayParmError = -10063;

		// Token: 0x04003DA9 RID: 15785
		public const int ErrCodeCardPoolOperationalActivityCardPoolParmError = -10064;

		// Token: 0x04003DAA RID: 15786
		public const int ErrCodeOperationalItemGroupItemIdError = -10065;

		// Token: 0x04003DAB RID: 15787
		public const int ErrCodeLimitedTimeExchangeOperationalActivityParmItemCannotBeEquipment = -10066;

		// Token: 0x04003DAC RID: 15788
		public const int ErrCodeRandomBoxRewardsGoodsIdError = -10067;

		// Token: 0x04003DAD RID: 15789
		public const int ErrCodeStaticBoxRewardsGoodsIdError = -10068;

		// Token: 0x04003DAE RID: 15790
		public const int ErrCodeEquipmentLevelTableRankNextExpsCountBelowEquipmentTableEquipmentMaxRank = -10069;

		// Token: 0x04003DAF RID: 15791
		public const int ErrCodeBattleTreasureRewardGoodsIdError = -10070;

		// Token: 0x04003DB0 RID: 15792
		public const int ErrCodeHeroInformationFetterIdError = -10071;

		// Token: 0x04003DB1 RID: 15793
		public const int ErrCodeHeroInformationConfessionIdError = -10072;

		// Token: 0x04003DB2 RID: 15794
		public const int ErrCodeHeroInitialJobConnectionNotExist = -10073;

		// Token: 0x04003DB3 RID: 15795
		public const int ErrCodeJobConnnectionTalentSkillError = -10074;

		// Token: 0x04003DB4 RID: 15796
		public const int ErrCodeTrainingGroundTechLevelMax = -10075;

		// Token: 0x04003DB5 RID: 15797
		public const int ErrCodeTrainingGroundTechLevelupResourceNotEnough = -10076;

		// Token: 0x04003DB6 RID: 15798
		public const int ErrCodeTrainingGroundTechLevelupFail = -10077;

		// Token: 0x04003DB7 RID: 15799
		public const int ErrCodeFreeCardPoolGroupFirstSingleSelectWeightIsZero = -10078;

		// Token: 0x04003DB8 RID: 15800
		public const int ErrCodeFreeCardPoolGroupFirstTenSelectWeightIsZero = -1007;

		// Token: 0x04003DB9 RID: 15801
		public const int ErrCodeCrystalCardPoolGroupFirstSingleSelectWeightIsZero = -10080;

		// Token: 0x04003DBA RID: 15802
		public const int ErrCodeCrystalCardPoolGroupFirstTenSelectWeightIsZero = -10081;

		// Token: 0x04003DBB RID: 15803
		public const int ErrCodeActivityCardPoolGroupFirstSingleSelectWeightIsZero = -10082;

		// Token: 0x04003DBC RID: 15804
		public const int ErrCodeActivityCardPoolGroupFirstTenSelectWeightIsZero = -10083;

		// Token: 0x04003DBD RID: 15805
		public const int ErrCodeHeroFetterTypeMissionCannotHaveReward = -10084;

		// Token: 0x04003DBE RID: 15806
		public const int ErrCodeMissionRewardIsEmpty = -10085;

		// Token: 0x04003DBF RID: 15807
		public const int ErrCodeItemNumsError = -10086;

		// Token: 0x04003DC0 RID: 15808
		public const int ErrCodeGiftStoreItemShowTimeFormError = -10087;

		// Token: 0x04003DC1 RID: 15809
		public const int ErrCodeAppleSubscribeGoodsJustBeMonthCard = -10088;

		// Token: 0x04003DC2 RID: 15810
		public const int ErrCodeNotMonthCardCannotBeSubscribed = -10089;

		// Token: 0x04003DC3 RID: 15811
		public const int ErrCodeGiftStoreGoodsTypeRelatedIdError = -10090;

		// Token: 0x04003DC4 RID: 15812
		public const int ErrCodeGiftStoreFirstRewardTypeRelatedIdError = -10091;

		// Token: 0x04003DC5 RID: 15813
		public const int ErrCodeRaffleOperationaRaffleParmError = -10092;

		// Token: 0x04003DC6 RID: 15814
		public const int ErrCodeAccumulateRechargeOperationalActivityItemGroupRewardParmError = -10093;

		// Token: 0x04003DC7 RID: 15815
		public const int ErrCodeAccumulateConsumeCrystalOperationalActivityItemGroupRewardParmError = -10094;

		// Token: 0x04003DC8 RID: 15816
		public const int ErrCodeMonthCardMissionError = -10095;

		// Token: 0x04003DC9 RID: 15817
		public const int ErrCodeNewUserAccumulatedValueError = -10096;

		// Token: 0x04003DCA RID: 15818
		public const int ErrCodeOldUserAccumulatedValueError = -10097;

		// Token: 0x04003DCB RID: 15819
		public const int ErrCodeCardPoolTenSelectGuaranteedMinCountError = -10098;

		// Token: 0x04003DCC RID: 15820
		public const int ErrCodeCardPoolDefaultSingleSelectWeightIsZero = -10099;

		// Token: 0x04003DCD RID: 15821
		public const int ErrCodeCardPoolDefaultTenSelectWeightIsZero = -10100;

		// Token: 0x04003DCE RID: 15822
		public const int ErrCodeCardPoolFirstSingleSelectWeightIsZero = -10101;

		// Token: 0x04003DCF RID: 15823
		public const int ErrCodeCardPoolFirstTenSelectWeightIsZero = -10102;

		// Token: 0x04003DD0 RID: 15824
		public const int ErrCodeCardPoolTenSelectAccumulateWeightIsZero = -10103;

		// Token: 0x04003DD1 RID: 15825
		public const int ErrCodeCardPoolGroupAllItemWeightIsZero = -10104;

		// Token: 0x04003DD2 RID: 15826
		public const int ErrCodeUnchartedScoreOperationaUnchartedScoreIdParmError = -10105;

		// Token: 0x04003DD3 RID: 15827
		public const int ErrCodeOperactionalActivityDaysAfterServerOpenError = -10106;

		// Token: 0x04003DD4 RID: 15828
		public const int ErrCodeOperactionalActivityDaysAfterPlayerCreatedError = -10107;

		// Token: 0x04003DD5 RID: 15829
		public const int ErrCodeSrcCopyAccountNotExist = -10108;

		// Token: 0x04003DD6 RID: 15830
		public const int ErrCodeDestCopyPlayerNotExist = -10109;

		// Token: 0x04003DD7 RID: 15831
		public const int ErrCodeSrcCopyPlayerNotExist = -10110;
	}
}
