using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B9 RID: 697
	[ProtoContract(Name = "SkillAIType")]
	public enum SkillAIType
	{
		// Token: 0x04001C87 RID: 7303
		[ProtoEnum(Name = "SkillAIType_DamageSingle", Value = 1)]
		SkillAIType_DamageSingle = 1,
		// Token: 0x04001C88 RID: 7304
		[ProtoEnum(Name = "SkillAIType_DamageAssault", Value = 2)]
		SkillAIType_DamageAssault,
		// Token: 0x04001C89 RID: 7305
		[ProtoEnum(Name = "SkillAIType_DamageAOE", Value = 3)]
		SkillAIType_DamageAOE,
		// Token: 0x04001C8A RID: 7306
		[ProtoEnum(Name = "SkillAIType_DamageAOESelf", Value = 4)]
		SkillAIType_DamageAOESelf,
		// Token: 0x04001C8B RID: 7307
		[ProtoEnum(Name = "SkillAIType_Heal", Value = 5)]
		SkillAIType_Heal,
		// Token: 0x04001C8C RID: 7308
		[ProtoEnum(Name = "SkillAIType_HealRange", Value = 6)]
		SkillAIType_HealRange,
		// Token: 0x04001C8D RID: 7309
		[ProtoEnum(Name = "SkillAIType_HealRangeSelf", Value = 7)]
		SkillAIType_HealRangeSelf,
		// Token: 0x04001C8E RID: 7310
		[ProtoEnum(Name = "SkillAIType_BuffSingle", Value = 8)]
		SkillAIType_BuffSingle,
		// Token: 0x04001C8F RID: 7311
		[ProtoEnum(Name = "SkillAIType_BuffAOE", Value = 9)]
		SkillAIType_BuffAOE,
		// Token: 0x04001C90 RID: 7312
		[ProtoEnum(Name = "SkillAIType_Dispel", Value = 10)]
		SkillAIType_Dispel,
		// Token: 0x04001C91 RID: 7313
		[ProtoEnum(Name = "SkillAIType_BuffSelf1", Value = 11)]
		SkillAIType_BuffSelf1,
		// Token: 0x04001C92 RID: 7314
		[ProtoEnum(Name = "SkillAIType_BuffSelf2", Value = 12)]
		SkillAIType_BuffSelf2,
		// Token: 0x04001C93 RID: 7315
		[ProtoEnum(Name = "SkillAIType_Guard", Value = 13)]
		SkillAIType_Guard,
		// Token: 0x04001C94 RID: 7316
		[ProtoEnum(Name = "SkillAIType_NewTurn", Value = 14)]
		SkillAIType_NewTurn,
		// Token: 0x04001C95 RID: 7317
		[ProtoEnum(Name = "SkillAIType_RemoveCD", Value = 15)]
		SkillAIType_RemoveCD,
		// Token: 0x04001C96 RID: 7318
		[ProtoEnum(Name = "SkillAIType_Summon", Value = 16)]
		SkillAIType_Summon,
		// Token: 0x04001C97 RID: 7319
		[ProtoEnum(Name = "SkillAIType_Teleport", Value = 17)]
		SkillAIType_Teleport,
		// Token: 0x04001C98 RID: 7320
		[ProtoEnum(Name = "SkillAIType_DamageAOESelfSingle", Value = 18)]
		SkillAIType_DamageAOESelfSingle
	}
}
