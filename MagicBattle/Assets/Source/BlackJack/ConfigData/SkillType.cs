using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D7 RID: 727
	[ProtoContract(Name = "SkillType")]
	public enum SkillType
	{
		// Token: 0x040021EF RID: 8687
		[ProtoEnum(Name = "SkillType_None", Value = 0)]
		SkillType_None,
		// Token: 0x040021F0 RID: 8688
		[ProtoEnum(Name = "SkillType_Slash", Value = 1)]
		SkillType_Slash,
		// Token: 0x040021F1 RID: 8689
		[ProtoEnum(Name = "SkillType_Shoot", Value = 2)]
		SkillType_Shoot,
		// Token: 0x040021F2 RID: 8690
		[ProtoEnum(Name = "SkillType_Charge", Value = 3)]
		SkillType_Charge,
		// Token: 0x040021F3 RID: 8691
		[ProtoEnum(Name = "SkillType_MagicDamage", Value = 4)]
		SkillType_MagicDamage,
		// Token: 0x040021F4 RID: 8692
		[ProtoEnum(Name = "SkillType_BF_Heal", Value = 5)]
		SkillType_BF_Heal,
		// Token: 0x040021F5 RID: 8693
		[ProtoEnum(Name = "SkillType_BF_HealRemoveCD", Value = 6)]
		SkillType_BF_HealRemoveCD,
		// Token: 0x040021F6 RID: 8694
		[ProtoEnum(Name = "SkillType_BF_HealNewTurn", Value = 7)]
		SkillType_BF_HealNewTurn,
		// Token: 0x040021F7 RID: 8695
		[ProtoEnum(Name = "SkillType_BF_Teleport", Value = 8)]
		SkillType_BF_Teleport,
		// Token: 0x040021F8 RID: 8696
		[ProtoEnum(Name = "SkillType_BF_Summon", Value = 9)]
		SkillType_BF_Summon,
		// Token: 0x040021F9 RID: 8697
		[ProtoEnum(Name = "SkillType_BF_MagicDamage", Value = 10)]
		SkillType_BF_MagicDamage,
		// Token: 0x040021FA RID: 8698
		[ProtoEnum(Name = "SkillType_Passive", Value = 11)]
		SkillType_Passive,
		// Token: 0x040021FB RID: 8699
		[ProtoEnum(Name = "SkillType_BF_DamageHeal", Value = 12)]
		SkillType_BF_DamageHeal,
		// Token: 0x040021FC RID: 8700
		[ProtoEnum(Name = "SkillType_BF_HealPercent", Value = 13)]
		SkillType_BF_HealPercent,
		// Token: 0x040021FD RID: 8701
		[ProtoEnum(Name = "SkillType_BF_AddBuff", Value = 14)]
		SkillType_BF_AddBuff
	}
}
