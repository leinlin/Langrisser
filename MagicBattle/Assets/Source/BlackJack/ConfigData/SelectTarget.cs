using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B6 RID: 694
	[ProtoContract(Name = "SelectTarget")]
	public enum SelectTarget
	{
		// Token: 0x04001C5D RID: 7261
		[ProtoEnum(Name = "SelectTarget_EnemyNearest", Value = 1)]
		SelectTarget_EnemyNearest = 1,
		// Token: 0x04001C5E RID: 7262
		[ProtoEnum(Name = "SelectTarget_SelfPosition", Value = 2)]
		SelectTarget_SelfPosition,
		// Token: 0x04001C5F RID: 7263
		[ProtoEnum(Name = "SelectTarget_DefaultSelection", Value = 3)]
		SelectTarget_DefaultSelection,
		// Token: 0x04001C60 RID: 7264
		[ProtoEnum(Name = "SelectTarget_SameAsLeader", Value = 4)]
		SelectTarget_SameAsLeader,
		// Token: 0x04001C61 RID: 7265
		[ProtoEnum(Name = "SelectTarget_PositionNearest", Value = 5)]
		SelectTarget_PositionNearest,
		// Token: 0x04001C62 RID: 7266
		[ProtoEnum(Name = "SelectTarget_MemberIndex", Value = 6)]
		SelectTarget_MemberIndex,
		// Token: 0x04001C63 RID: 7267
		[ProtoEnum(Name = "SelectTarget_MemberHeroID", Value = 7)]
		SelectTarget_MemberHeroID,
		// Token: 0x04001C64 RID: 7268
		[ProtoEnum(Name = "SelectTarget_TargetInSkillRange", Value = 8)]
		SelectTarget_TargetInSkillRange,
		// Token: 0x04001C65 RID: 7269
		[ProtoEnum(Name = "SelectTarget_EnemyWithBuffN", Value = 9)]
		SelectTarget_EnemyWithBuffN,
		// Token: 0x04001C66 RID: 7270
		[ProtoEnum(Name = "SelectTarget_EnemyIDFilter", Value = 10)]
		SelectTarget_EnemyIDFilter,
		// Token: 0x04001C67 RID: 7271
		[ProtoEnum(Name = "SelectTarget_Leader", Value = 11)]
		SelectTarget_Leader,
		// Token: 0x04001C68 RID: 7272
		[ProtoEnum(Name = "SelectTarget_RandomReachableEmptyPosition", Value = 12)]
		SelectTarget_RandomReachableEmptyPosition
	}
}
