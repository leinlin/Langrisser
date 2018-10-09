using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002BA RID: 698
	[ProtoContract(Name = "FightTag")]
	public enum FightTag
	{
		// Token: 0x04001C9A RID: 7322
		[ProtoEnum(Name = "FightTag_None", Value = 0)]
		FightTag_None,
		// Token: 0x04001C9B RID: 7323
		[ProtoEnum(Name = "FightTag_IngoreGuard", Value = 1)]
		FightTag_IngoreGuard,
		// Token: 0x04001C9C RID: 7324
		[ProtoEnum(Name = "FightTag_BanGuard", Value = 2)]
		FightTag_BanGuard,
		// Token: 0x04001C9D RID: 7325
		[ProtoEnum(Name = "FightTag_BanActiveSkill", Value = 3)]
		FightTag_BanActiveSkill,
		// Token: 0x04001C9E RID: 7326
		[ProtoEnum(Name = "FightTag_BanPassiveSkill", Value = 4)]
		FightTag_BanPassiveSkill,
		// Token: 0x04001C9F RID: 7327
		[ProtoEnum(Name = "FightTag_BanHeal", Value = 5)]
		FightTag_BanHeal,
		// Token: 0x04001CA0 RID: 7328
		[ProtoEnum(Name = "FightTag_BanDamage", Value = 6)]
		FightTag_BanDamage,
		// Token: 0x04001CA1 RID: 7329
		[ProtoEnum(Name = "FightTag_BanBuff", Value = 7)]
		FightTag_BanBuff,
		// Token: 0x04001CA2 RID: 7330
		[ProtoEnum(Name = "FightTag_BanDeBuff", Value = 8)]
		FightTag_BanDeBuff,
		// Token: 0x04001CA3 RID: 7331
		[ProtoEnum(Name = "FightTag_BanPunch", Value = 9)]
		FightTag_BanPunch,
		// Token: 0x04001CA4 RID: 7332
		[ProtoEnum(Name = "FightTag_Stun", Value = 10)]
		FightTag_Stun,
		// Token: 0x04001CA5 RID: 7333
		[ProtoEnum(Name = "FightTag_Hide", Value = 11)]
		FightTag_Hide,
		// Token: 0x04001CA6 RID: 7334
		[ProtoEnum(Name = "FightTag_BanPercentDamage", Value = 12)]
		FightTag_BanPercentDamage,
		// Token: 0x04001CA7 RID: 7335
		[ProtoEnum(Name = "FightTag_BanMeleePunish", Value = 13)]
		FightTag_BanMeleePunish,
		// Token: 0x04001CA8 RID: 7336
		[ProtoEnum(Name = "FightTag_OnlyAttackHero", Value = 14)]
		FightTag_OnlyAttackHero
	}
}
