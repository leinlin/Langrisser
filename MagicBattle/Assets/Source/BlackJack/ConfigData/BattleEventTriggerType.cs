using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D3 RID: 723
	[ProtoContract(Name = "BattleEventTriggerType")]
	public enum BattleEventTriggerType
	{
		// Token: 0x040021A4 RID: 8612
		[ProtoEnum(Name = "BattleEventTriggerType_None", Value = 0)]
		BattleEventTriggerType_None,
		// Token: 0x040021A5 RID: 8613
		[ProtoEnum(Name = "BattleEventTriggerType_TurnCount", Value = 1)]
		BattleEventTriggerType_TurnCount,
		// Token: 0x040021A6 RID: 8614
		[ProtoEnum(Name = "BattleEventTriggerType_ActorDie", Value = 2)]
		BattleEventTriggerType_ActorDie,
		// Token: 0x040021A7 RID: 8615
		[ProtoEnum(Name = "BattleEventTriggerType_ActorNeighbor", Value = 3)]
		BattleEventTriggerType_ActorNeighbor,
		// Token: 0x040021A8 RID: 8616
		[ProtoEnum(Name = "BattleEventTriggerType_ActorReachPosition", Value = 4)]
		BattleEventTriggerType_ActorReachPosition,
		// Token: 0x040021A9 RID: 8617
		[ProtoEnum(Name = "BattleEventTriggerType_ActorOverPosition", Value = 5)]
		BattleEventTriggerType_ActorOverPosition,
		// Token: 0x040021AA RID: 8618
		[ProtoEnum(Name = "BattleEventTriggerType_Achievement", Value = 6)]
		BattleEventTriggerType_Achievement,
		// Token: 0x040021AB RID: 8619
		[ProtoEnum(Name = "BattleEventTriggerType_Win", Value = 7)]
		BattleEventTriggerType_Win,
		// Token: 0x040021AC RID: 8620
		[ProtoEnum(Name = "BattleEventTriggerType_ActorHpLess", Value = 8)]
		BattleEventTriggerType_ActorHpLess,
		// Token: 0x040021AD RID: 8621
		[ProtoEnum(Name = "BattleEventTriggerType_ActorFirstAction", Value = 9)]
		BattleEventTriggerType_ActorFirstAction,
		// Token: 0x040021AE RID: 8622
		[ProtoEnum(Name = "BattleEventTriggerType_ActorFirstAttack", Value = 10)]
		BattleEventTriggerType_ActorFirstAttack,
		// Token: 0x040021AF RID: 8623
		[ProtoEnum(Name = "BattleEventTriggerType_ActorFirstAttackAfter", Value = 11)]
		BattleEventTriggerType_ActorFirstAttackAfter,
		// Token: 0x040021B0 RID: 8624
		[ProtoEnum(Name = "BattleEventTriggerType_ActorFirstSkill", Value = 12)]
		BattleEventTriggerType_ActorFirstSkill,
		// Token: 0x040021B1 RID: 8625
		[ProtoEnum(Name = "BattleEventTriggerType_ActorFirstBeAttack", Value = 13)]
		BattleEventTriggerType_ActorFirstBeAttack,
		// Token: 0x040021B2 RID: 8626
		[ProtoEnum(Name = "BattleEventTriggerType_KillCount", Value = 14)]
		BattleEventTriggerType_KillCount,
		// Token: 0x040021B3 RID: 8627
		[ProtoEnum(Name = "BattleEventTriggerType_ActorCountLess", Value = 15)]
		BattleEventTriggerType_ActorCountLess,
		// Token: 0x040021B4 RID: 8628
		[ProtoEnum(Name = "BattleEventTriggerType_GroupDie", Value = 16)]
		BattleEventTriggerType_GroupDie,
		// Token: 0x040021B5 RID: 8629
		[ProtoEnum(Name = "BattleEventTriggerType_MultiTrigger", Value = 17)]
		BattleEventTriggerType_MultiTrigger,
		// Token: 0x040021B6 RID: 8630
		[ProtoEnum(Name = "BattleEventTriggerType_NotTrigger", Value = 18)]
		BattleEventTriggerType_NotTrigger,
		// Token: 0x040021B7 RID: 8631
		[ProtoEnum(Name = "BattleEventTriggerType_TriggerTurnCount", Value = 19)]
		BattleEventTriggerType_TriggerTurnCount,
		// Token: 0x040021B8 RID: 8632
		[ProtoEnum(Name = "BattleEventTriggerType_ActorAttackTarget", Value = 20)]
		BattleEventTriggerType_ActorAttackTarget,
		// Token: 0x040021B9 RID: 8633
		[ProtoEnum(Name = "BattleEventTriggerType_ActorAttackTargetAfter", Value = 21)]
		BattleEventTriggerType_ActorAttackTargetAfter
	}
}
