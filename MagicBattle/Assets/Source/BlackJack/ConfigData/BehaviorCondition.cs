using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B7 RID: 695
	[ProtoContract(Name = "BehaviorCondition")]
	public enum BehaviorCondition
	{
		// Token: 0x04001C6A RID: 7274
		[ProtoEnum(Name = "BehaviorCondition_EnemyEnterMoveAndAttackRange", Value = 1)]
		BehaviorCondition_EnemyEnterMoveAndAttackRange = 1,
		// Token: 0x04001C6B RID: 7275
		[ProtoEnum(Name = "BehaviorCondition_LeaderStartAttack", Value = 2)]
		BehaviorCondition_LeaderStartAttack,
		// Token: 0x04001C6C RID: 7276
		[ProtoEnum(Name = "BehaviorCondition_EnemyHPPercentLessEqual", Value = 3)]
		BehaviorCondition_EnemyHPPercentLessEqual,
		// Token: 0x04001C6D RID: 7277
		[ProtoEnum(Name = "BehaviorCondition_NoEnemyEnterMoveAndAttackRange", Value = 4)]
		BehaviorCondition_NoEnemyEnterMoveAndAttackRange,
		// Token: 0x04001C6E RID: 7278
		[ProtoEnum(Name = "BehaviorCondition_EveryTurn", Value = 5)]
		BehaviorCondition_EveryTurn,
		// Token: 0x04001C6F RID: 7279
		[ProtoEnum(Name = "BehaviorCondition_Never", Value = 6)]
		BehaviorCondition_Never,
		// Token: 0x04001C70 RID: 7280
		[ProtoEnum(Name = "BehaviorCondition_TurnN", Value = 7)]
		BehaviorCondition_TurnN,
		// Token: 0x04001C71 RID: 7281
		[ProtoEnum(Name = "BehaviorCondition_AttackedByEnemy", Value = 8)]
		BehaviorCondition_AttackedByEnemy,
		// Token: 0x04001C72 RID: 7282
		[ProtoEnum(Name = "BehaviorCondition_EnemyEnterMoveAndAttackRangeOfMoveTarget", Value = 9)]
		BehaviorCondition_EnemyEnterMoveAndAttackRangeOfMoveTarget,
		// Token: 0x04001C73 RID: 7283
		[ProtoEnum(Name = "BehaviorCondition_NoEnemyEnterMoveAndAttackRangeOfMoveTarget", Value = 10)]
		BehaviorCondition_NoEnemyEnterMoveAndAttackRangeOfMoveTarget,
		// Token: 0x04001C74 RID: 7284
		[ProtoEnum(Name = "BehaviorCondition_DistanceToMoveTargetLestEqual", Value = 11)]
		BehaviorCondition_DistanceToMoveTargetLestEqual,
		// Token: 0x04001C75 RID: 7285
		[ProtoEnum(Name = "BehaviorCondition_SelfHPPercentLessEqual", Value = 12)]
		BehaviorCondition_SelfHPPercentLessEqual,
		// Token: 0x04001C76 RID: 7286
		[ProtoEnum(Name = "BehaviorCondition_LeaderStopAttack", Value = 13)]
		BehaviorCondition_LeaderStopAttack,
		// Token: 0x04001C77 RID: 7287
		[ProtoEnum(Name = "BehaviorCondition_DoingBehaviorN", Value = 14)]
		BehaviorCondition_DoingBehaviorN,
		// Token: 0x04001C78 RID: 7288
		[ProtoEnum(Name = "BehaviorCondition_AttackedByEnemyInLastTurn", Value = 15)]
		BehaviorCondition_AttackedByEnemyInLastTurn,
		// Token: 0x04001C79 RID: 7289
		[ProtoEnum(Name = "BehaviorCondition_FoundEnemyWithBuffN", Value = 16)]
		BehaviorCondition_FoundEnemyWithBuffN,
		// Token: 0x04001C7A RID: 7290
		[ProtoEnum(Name = "BehaviorCondition_NoEnemyWithBuffN", Value = 17)]
		BehaviorCondition_NoEnemyWithBuffN,
		// Token: 0x04001C7B RID: 7291
		[ProtoEnum(Name = "BehaviorCondition_MemberAttackedByEnemy", Value = 18)]
		BehaviorCondition_MemberAttackedByEnemy,
		// Token: 0x04001C7C RID: 7292
		[ProtoEnum(Name = "BehaviorCondition_MemberHPPercentLessEqual", Value = 19)]
		BehaviorCondition_MemberHPPercentLessEqual,
		// Token: 0x04001C7D RID: 7293
		[ProtoEnum(Name = "BehaviorCondition_EnemyEnterMoveAndAttackRangeExcept", Value = 20)]
		BehaviorCondition_EnemyEnterMoveAndAttackRangeExcept,
		// Token: 0x04001C7E RID: 7294
		[ProtoEnum(Name = "BehaviorCondition_NoEnemyEnterMoveAndAttackRangeExcept", Value = 21)]
		BehaviorCondition_NoEnemyEnterMoveAndAttackRangeExcept,
		// Token: 0x04001C7F RID: 7295
		[ProtoEnum(Name = "BehaviorCondition_SelfHPPercentGreaterEqual", Value = 22)]
		BehaviorCondition_SelfHPPercentGreaterEqual,
		// Token: 0x04001C80 RID: 7296
		[ProtoEnum(Name = "BehaviorCondition_HeroNExist", Value = 23)]
		BehaviorCondition_HeroNExist
	}
}
