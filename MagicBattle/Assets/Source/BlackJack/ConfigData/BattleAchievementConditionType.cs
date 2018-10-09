using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D5 RID: 725
	[ProtoContract(Name = "BattleAchievementConditionType")]
	public enum BattleAchievementConditionType
	{
		// Token: 0x040021CA RID: 8650
		[ProtoEnum(Name = "BattleAchievementConditionType_None", Value = 0)]
		BattleAchievementConditionType_None,
		// Token: 0x040021CB RID: 8651
		[ProtoEnum(Name = "BattleAchievementConditionType_ActorNotDead", Value = 1)]
		BattleAchievementConditionType_ActorNotDead,
		// Token: 0x040021CC RID: 8652
		[ProtoEnum(Name = "BattleAchievementConditionType_KillActor", Value = 2)]
		BattleAchievementConditionType_KillActor,
		// Token: 0x040021CD RID: 8653
		[ProtoEnum(Name = "BattleAchievementConditionType_TurnCount", Value = 3)]
		BattleAchievementConditionType_TurnCount,
		// Token: 0x040021CE RID: 8654
		[ProtoEnum(Name = "BattleAchievementConditionType_SkillKillActor", Value = 4)]
		BattleAchievementConditionType_SkillKillActor,
		// Token: 0x040021CF RID: 8655
		[ProtoEnum(Name = "BattleAchievementConditionType_ActorCount", Value = 5)]
		BattleAchievementConditionType_ActorCount,
		// Token: 0x040021D0 RID: 8656
		[ProtoEnum(Name = "BattleAchievementConditionType_Dialog", Value = 6)]
		BattleAchievementConditionType_Dialog,
		// Token: 0x040021D1 RID: 8657
		[ProtoEnum(Name = "BattleAchievementConditionType_ActorReachPosition", Value = 7)]
		BattleAchievementConditionType_ActorReachPosition,
		// Token: 0x040021D2 RID: 8658
		[ProtoEnum(Name = "BattleAchievementConditionType_ActorNotReachPosition", Value = 8)]
		BattleAchievementConditionType_ActorNotReachPosition,
		// Token: 0x040021D3 RID: 8659
		[ProtoEnum(Name = "BattleAchievementConditionType_ActorNotDamage", Value = 9)]
		BattleAchievementConditionType_ActorNotDamage,
		// Token: 0x040021D4 RID: 8660
		[ProtoEnum(Name = "BattleAchievementConditionType_KillCount", Value = 10)]
		BattleAchievementConditionType_KillCount,
		// Token: 0x040021D5 RID: 8661
		[ProtoEnum(Name = "BattleAchievementConditionType_ActorHpLess", Value = 11)]
		BattleAchievementConditionType_ActorHpLess,
		// Token: 0x040021D6 RID: 8662
		[ProtoEnum(Name = "BattleAchievementConditionType_PlayerDieLess", Value = 12)]
		BattleAchievementConditionType_PlayerDieLess,
		// Token: 0x040021D7 RID: 8663
		[ProtoEnum(Name = "BattleAchievementConditionType_NpcDieLess", Value = 13)]
		BattleAchievementConditionType_NpcDieLess
	}
}
