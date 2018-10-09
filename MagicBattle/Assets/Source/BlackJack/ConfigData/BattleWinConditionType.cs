using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D0 RID: 720
	[ProtoContract(Name = "BattleWinConditionType")]
	public enum BattleWinConditionType
	{
		// Token: 0x0400218B RID: 8587
		[ProtoEnum(Name = "BattleWinConditionType_None", Value = 0)]
		BattleWinConditionType_None,
		// Token: 0x0400218C RID: 8588
		[ProtoEnum(Name = "BattleWinConditionType_KillAll", Value = 1)]
		BattleWinConditionType_KillAll,
		// Token: 0x0400218D RID: 8589
		[ProtoEnum(Name = "BattleWinConditionType_KillActor", Value = 2)]
		BattleWinConditionType_KillActor,
		// Token: 0x0400218E RID: 8590
		[ProtoEnum(Name = "BattleWinConditionType_ActorReachPosition", Value = 3)]
		BattleWinConditionType_ActorReachPosition,
		// Token: 0x0400218F RID: 8591
		[ProtoEnum(Name = "BattleWinConditionType_ActorNotDead", Value = 4)]
		BattleWinConditionType_ActorNotDead,
		// Token: 0x04002190 RID: 8592
		[ProtoEnum(Name = "BattleWinConditionType_Turn", Value = 5)]
		BattleWinConditionType_Turn,
		// Token: 0x04002191 RID: 8593
		[ProtoEnum(Name = "BattleWinConditionType_KillCount", Value = 6)]
		BattleWinConditionType_KillCount,
		// Token: 0x04002192 RID: 8594
		[ProtoEnum(Name = "BattleWinConditionType_KillOthers", Value = 7)]
		BattleWinConditionType_KillOthers,
		// Token: 0x04002193 RID: 8595
		[ProtoEnum(Name = "BattleWinConditionType_ActorHpLess", Value = 8)]
		BattleWinConditionType_ActorHpLess,
		// Token: 0x04002194 RID: 8596
		[ProtoEnum(Name = "BattleWinConditionType_EventTrigger", Value = 9)]
		BattleWinConditionType_EventTrigger
	}
}
