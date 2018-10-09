using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002BC RID: 700
	[ProtoContract(Name = "BuffType")]
	public enum BuffType
	{
		// Token: 0x04001CB1 RID: 7345
		[ProtoEnum(Name = "BuffType_None", Value = 0)]
		BuffType_None,
		// Token: 0x04001CB2 RID: 7346
		[ProtoEnum(Name = "BuffType_PropertiesModify", Value = 1)]
		BuffType_PropertiesModify,
		// Token: 0x04001CB3 RID: 7347
		[ProtoEnum(Name = "BuffType_Charge", Value = 2)]
		BuffType_Charge,
		// Token: 0x04001CB4 RID: 7348
		[ProtoEnum(Name = "BuffType_FieldArmy", Value = 3)]
		BuffType_FieldArmy,
		// Token: 0x04001CB5 RID: 7349
		[ProtoEnum(Name = "BuffType_Immune", Value = 4)]
		BuffType_Immune,
		// Token: 0x04001CB6 RID: 7350
		[ProtoEnum(Name = "BuffType_DamageRebound", Value = 5)]
		BuffType_DamageRebound,
		// Token: 0x04001CB7 RID: 7351
		[ProtoEnum(Name = "BuffType_CombatPropertiesModify", Value = 6)]
		BuffType_CombatPropertiesModify,
		// Token: 0x04001CB8 RID: 7352
		[ProtoEnum(Name = "BuffType_CombatAttachBuff", Value = 7)]
		BuffType_CombatAttachBuff,
		// Token: 0x04001CB9 RID: 7353
		[ProtoEnum(Name = "BuffType_DamageAttachBuff", Value = 8)]
		BuffType_DamageAttachBuff,
		// Token: 0x04001CBA RID: 7354
		[ProtoEnum(Name = "BuffType_DamageRemoveBuff", Value = 9)]
		BuffType_DamageRemoveBuff,
		// Token: 0x04001CBB RID: 7355
		[ProtoEnum(Name = "BuffType_CombatHeal", Value = 10)]
		BuffType_CombatHeal,
		// Token: 0x04001CBC RID: 7356
		[ProtoEnum(Name = "BuffType_Guard", Value = 11)]
		BuffType_Guard,
		// Token: 0x04001CBD RID: 7357
		[ProtoEnum(Name = "BuffType_DoubleAttack", Value = 12)]
		BuffType_DoubleAttack,
		// Token: 0x04001CBE RID: 7358
		[ProtoEnum(Name = "BuffType_DoubleMove", Value = 13)]
		BuffType_DoubleMove,
		// Token: 0x04001CBF RID: 7359
		[ProtoEnum(Name = "BuffType_Punch", Value = 14)]
		BuffType_Punch,
		// Token: 0x04001CC0 RID: 7360
		[ProtoEnum(Name = "BuffType_DamageRemoveCD", Value = 15)]
		BuffType_DamageRemoveCD,
		// Token: 0x04001CC1 RID: 7361
		[ProtoEnum(Name = "BuffType_HealOverTime", Value = 16)]
		BuffType_HealOverTime,
		// Token: 0x04001CC2 RID: 7362
		[ProtoEnum(Name = "BuffType_DamageOverTime", Value = 17)]
		BuffType_DamageOverTime,
		// Token: 0x04001CC3 RID: 7363
		[ProtoEnum(Name = "BuffType_NewTurn", Value = 18)]
		BuffType_NewTurn,
		// Token: 0x04001CC4 RID: 7364
		[ProtoEnum(Name = "BuffType_RemoveDebuff", Value = 19)]
		BuffType_RemoveDebuff,
		// Token: 0x04001CC5 RID: 7365
		[ProtoEnum(Name = "BuffType_TerrainAdv", Value = 20)]
		BuffType_TerrainAdv,
		// Token: 0x04001CC6 RID: 7366
		[ProtoEnum(Name = "BuffType_Restrain", Value = 21)]
		BuffType_Restrain,
		// Token: 0x04001CC7 RID: 7367
		[ProtoEnum(Name = "BuffType_CombatHealOther", Value = 22)]
		BuffType_CombatHealOther,
		// Token: 0x04001CC8 RID: 7368
		[ProtoEnum(Name = "BuffType_AddBuff", Value = 23)]
		BuffType_AddBuff,
		// Token: 0x04001CC9 RID: 7369
		[ProtoEnum(Name = "BuffType_CombatDamage", Value = 24)]
		BuffType_CombatDamage,
		// Token: 0x04001CCA RID: 7370
		[ProtoEnum(Name = "BuffType_MagicAttack", Value = 25)]
		BuffType_MagicAttack,
		// Token: 0x04001CCB RID: 7371
		[ProtoEnum(Name = "BuffType_TeamBuff", Value = 26)]
		BuffType_TeamBuff,
		// Token: 0x04001CCC RID: 7372
		[ProtoEnum(Name = "BuffType_BFSkillAttachBuff", Value = 27)]
		BuffType_BFSkillAttachBuff,
		// Token: 0x04001CCD RID: 7373
		[ProtoEnum(Name = "BuffType_BFSkill", Value = 28)]
		BuffType_BFSkill,
		// Token: 0x04001CCE RID: 7374
		[ProtoEnum(Name = "BuffType_NerverDie", Value = 29)]
		BuffType_NerverDie,
		// Token: 0x04001CCF RID: 7375
		[ProtoEnum(Name = "BuffType_BattlePropertiesSet", Value = 30)]
		BuffType_BattlePropertiesSet,
		// Token: 0x04001CD0 RID: 7376
		[ProtoEnum(Name = "BuffType_Drag", Value = 31)]
		BuffType_Drag,
		// Token: 0x04001CD1 RID: 7377
		[ProtoEnum(Name = "BuffType_PropertiesExchange", Value = 32)]
		BuffType_PropertiesExchange,
		// Token: 0x04001CD2 RID: 7378
		[ProtoEnum(Name = "BuffType_DamageAfterDamage", Value = 33)]
		BuffType_DamageAfterDamage,
		// Token: 0x04001CD3 RID: 7379
		[ProtoEnum(Name = "BuffType_HeroAura", Value = 34)]
		BuffType_HeroAura,
		// Token: 0x04001CD4 RID: 7380
		[ProtoEnum(Name = "BuffType_TagAura", Value = 35)]
		BuffType_TagAura,
		// Token: 0x04001CD5 RID: 7381
		[ProtoEnum(Name = "BuffType_RelationModify", Value = 36)]
		BuffType_RelationModify,
		// Token: 0x04001CD6 RID: 7382
		[ProtoEnum(Name = "BuffType_BuffPropertiesModify", Value = 37)]
		BuffType_BuffPropertiesModify,
		// Token: 0x04001CD7 RID: 7383
		[ProtoEnum(Name = "BuffType_AddBuffSuper", Value = 38)]
		BuffType_AddBuffSuper,
		// Token: 0x04001CD8 RID: 7384
		[ProtoEnum(Name = "BuffType_Removebuff", Value = 39)]
		BuffType_Removebuff,
		// Token: 0x04001CD9 RID: 7385
		[ProtoEnum(Name = "BuffType_BuffPack", Value = 40)]
		BuffType_BuffPack,
		// Token: 0x04001CDA RID: 7386
		[ProtoEnum(Name = "BuffType_Replace", Value = 41)]
		BuffType_Replace,
		// Token: 0x04001CDB RID: 7387
		[ProtoEnum(Name = "BuffType_ArmyChange", Value = 42)]
		BuffType_ArmyChange
	}
}
