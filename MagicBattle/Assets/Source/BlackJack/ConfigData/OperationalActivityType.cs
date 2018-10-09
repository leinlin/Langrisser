using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E3 RID: 739
	[ProtoContract(Name = "OperationalActivityType")]
	public enum OperationalActivityType
	{
		// Token: 0x04002258 RID: 8792
		[ProtoEnum(Name = "OperationalActivityType_PlayerLevelUp", Value = 1)]
		OperationalActivityType_PlayerLevelUp = 1,
		// Token: 0x04002259 RID: 8793
		[ProtoEnum(Name = "OperationalActivityType_LimitedTimeExchange", Value = 2)]
		OperationalActivityType_LimitedTimeExchange,
		// Token: 0x0400225A RID: 8794
		[ProtoEnum(Name = "OperationalActivityType_SpecificDaysLogin", Value = 3)]
		OperationalActivityType_SpecificDaysLogin,
		// Token: 0x0400225B RID: 8795
		[ProtoEnum(Name = "OperationalActivityType_AccumulateDaysLogin", Value = 4)]
		OperationalActivityType_AccumulateDaysLogin,
		// Token: 0x0400225C RID: 8796
		[ProtoEnum(Name = "OperationalActivityType_RewardAdd", Value = 5)]
		OperationalActivityType_RewardAdd,
		// Token: 0x0400225D RID: 8797
		[ProtoEnum(Name = "OperationalActivityType_ChallengeNumsAdd", Value = 6)]
		OperationalActivityType_ChallengeNumsAdd,
		// Token: 0x0400225E RID: 8798
		[ProtoEnum(Name = "OperationalActivityType_ActivitySelectCard", Value = 7)]
		OperationalActivityType_ActivitySelectCard,
		// Token: 0x0400225F RID: 8799
		[ProtoEnum(Name = "OperationalActivityType_Raffle", Value = 8)]
		OperationalActivityType_Raffle,
		// Token: 0x04002260 RID: 8800
		[ProtoEnum(Name = "OperationalActivityType_AccumulateRecharge", Value = 9)]
		OperationalActivityType_AccumulateRecharge,
		// Token: 0x04002261 RID: 8801
		[ProtoEnum(Name = "OperationalActivityType_AccumulateConsumeCrystal", Value = 10)]
		OperationalActivityType_AccumulateConsumeCrystal,
		// Token: 0x04002262 RID: 8802
		[ProtoEnum(Name = "OperationalActivityType_UnchartedScore", Value = 11)]
		OperationalActivityType_UnchartedScore,
		// Token: 0x04002263 RID: 8803
		[ProtoEnum(Name = "OperationalActivityType_Redeem", Value = 12)]
		OperationalActivityType_Redeem,
		// Token: 0x04002264 RID: 8804
		[ProtoEnum(Name = "OperationalActivityType_Web", Value = 13)]
		OperationalActivityType_Web,
		// Token: 0x04002265 RID: 8805
		[ProtoEnum(Name = "OperationalActivityType_BuyItemGuide", Value = 14)]
		OperationalActivityType_BuyItemGuide,
		// Token: 0x04002266 RID: 8806
		[ProtoEnum(Name = "OperationalActivityType_PBTCBTFansRewards", Value = 15)]
		OperationalActivityType_PBTCBTFansRewards
	}
}
