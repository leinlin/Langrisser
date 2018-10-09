using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F1 RID: 753
	[ProtoContract(Name = "GoodsType")]
	public enum GoodsType
	{
		// Token: 0x040022C8 RID: 8904
		[ProtoEnum(Name = "GoodsType_None", Value = 0)]
		GoodsType_None,
		// Token: 0x040022C9 RID: 8905
		[ProtoEnum(Name = "GoodsType_Gold", Value = 1)]
		GoodsType_Gold,
		// Token: 0x040022CA RID: 8906
		[ProtoEnum(Name = "GoodsType_Crystal", Value = 2)]
		GoodsType_Crystal,
		// Token: 0x040022CB RID: 8907
		[ProtoEnum(Name = "GoodsType_Energy", Value = 3)]
		GoodsType_Energy,
		// Token: 0x040022CC RID: 8908
		[ProtoEnum(Name = "GoodsType_Hero", Value = 4)]
		GoodsType_Hero,
		// Token: 0x040022CD RID: 8909
		[ProtoEnum(Name = "GoodsType_JobMaterial", Value = 5)]
		GoodsType_JobMaterial,
		// Token: 0x040022CE RID: 8910
		[ProtoEnum(Name = "GoodsType_Item", Value = 6)]
		GoodsType_Item,
		// Token: 0x040022CF RID: 8911
		[ProtoEnum(Name = "GoodsType_Equipment", Value = 7)]
		GoodsType_Equipment,
		// Token: 0x040022D0 RID: 8912
		[ProtoEnum(Name = "GoodsType_ArenaTicket", Value = 8)]
		GoodsType_ArenaTicket,
		// Token: 0x040022D1 RID: 8913
		[ProtoEnum(Name = "GoodsType_ArenaHonour", Value = 9)]
		GoodsType_ArenaHonour,
		// Token: 0x040022D2 RID: 8914
		[ProtoEnum(Name = "GoodsType_PlayerExp", Value = 10)]
		GoodsType_PlayerExp,
		// Token: 0x040022D3 RID: 8915
		[ProtoEnum(Name = "GoodsType_TrainingGroundTechMaterial", Value = 11)]
		GoodsType_TrainingGroundTechMaterial,
		// Token: 0x040022D4 RID: 8916
		[ProtoEnum(Name = "GoodsType_FriendshipPoints", Value = 12)]
		GoodsType_FriendshipPoints,
		// Token: 0x040022D5 RID: 8917
		[ProtoEnum(Name = "GoodsType_EnchantStone", Value = 13)]
		GoodsType_EnchantStone,
		// Token: 0x040022D6 RID: 8918
		[ProtoEnum(Name = "GoodsType_MonthCard", Value = 14)]
		GoodsType_MonthCard,
		// Token: 0x040022D7 RID: 8919
		[ProtoEnum(Name = "GoodsType_HeadFrame", Value = 15)]
		GoodsType_HeadFrame,
		// Token: 0x040022D8 RID: 8920
		[ProtoEnum(Name = "GoodsType_HeroSkin", Value = 16)]
		GoodsType_HeroSkin,
		// Token: 0x040022D9 RID: 8921
		[ProtoEnum(Name = "GoodsType_SoldierSkin", Value = 17)]
		GoodsType_SoldierSkin,
		// Token: 0x040022DA RID: 8922
		[ProtoEnum(Name = "GoodsType_SkinTicket", Value = 18)]
		GoodsType_SkinTicket,
		// Token: 0x040022DB RID: 8923
		[ProtoEnum(Name = "GoodsType_RealTimePVPHonor", Value = 19)]
		GoodsType_RealTimePVPHonor,
		// Token: 0x040022DC RID: 8924
		[ProtoEnum(Name = "GoodsType_MemoryEssence", Value = 20)]
		GoodsType_MemoryEssence,
		// Token: 0x040022DD RID: 8925
		[ProtoEnum(Name = "GoodsType_MithralStone", Value = 21)]
		GoodsType_MithralStone,
		// Token: 0x040022DE RID: 8926
		[ProtoEnum(Name = "GoodsType_BrillianceMithralStone", Value = 22)]
		GoodsType_BrillianceMithralStone,
		// Token: 0x040022DF RID: 8927
		[ProtoEnum(Name = "GoodsType_GuildMedal", Value = 23)]
		GoodsType_GuildMedal
	}
}
