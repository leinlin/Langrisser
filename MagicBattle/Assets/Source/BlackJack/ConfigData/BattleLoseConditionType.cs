using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D1 RID: 721
	[ProtoContract(Name = "BattleLoseConditionType")]
	public enum BattleLoseConditionType
	{
		// Token: 0x04002196 RID: 8598
		[ProtoEnum(Name = "BattleLoseConditionType_None", Value = 0)]
		BattleLoseConditionType_None,
		// Token: 0x04002197 RID: 8599
		[ProtoEnum(Name = "BattleLoseConditionType_DieAll", Value = 1)]
		BattleLoseConditionType_DieAll,
		// Token: 0x04002198 RID: 8600
		[ProtoEnum(Name = "BattleLoseConditionType_ActorDie", Value = 2)]
		BattleLoseConditionType_ActorDie,
		// Token: 0x04002199 RID: 8601
		[ProtoEnum(Name = "BattleLoseConditionType_ActorReachPosition", Value = 3)]
		BattleLoseConditionType_ActorReachPosition,
		// Token: 0x0400219A RID: 8602
		[ProtoEnum(Name = "BattleLoseConditionType_DieCount", Value = 4)]
		BattleLoseConditionType_DieCount,
		// Token: 0x0400219B RID: 8603
		[ProtoEnum(Name = "BattleLoseConditionType_PlayerDieCount", Value = 5)]
		BattleLoseConditionType_PlayerDieCount,
		// Token: 0x0400219C RID: 8604
		[ProtoEnum(Name = "BattleLoseConditionType_NpcDieCount", Value = 6)]
		BattleLoseConditionType_NpcDieCount,
		// Token: 0x0400219D RID: 8605
		[ProtoEnum(Name = "BattleLoseConditionType_EventTrigger", Value = 7)]
		BattleLoseConditionType_EventTrigger
	}
}
