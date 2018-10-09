using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F2 RID: 754
	[ProtoContract(Name = "ItemFuncType")]
	public enum ItemFuncType
	{
		// Token: 0x040022E1 RID: 8929
		[ProtoEnum(Name = "ItemFuncType_None", Value = 0)]
		ItemFuncType_None,
		// Token: 0x040022E2 RID: 8930
		[ProtoEnum(Name = "ItemFuncType_Gold", Value = 1)]
		ItemFuncType_Gold,
		// Token: 0x040022E3 RID: 8931
		[ProtoEnum(Name = "ItemFuncType_Crystal", Value = 2)]
		ItemFuncType_Crystal,
		// Token: 0x040022E4 RID: 8932
		[ProtoEnum(Name = "ItemFuncType_Energy", Value = 3)]
		ItemFuncType_Energy,
		// Token: 0x040022E5 RID: 8933
		[ProtoEnum(Name = "ItemFuncType_HeroEXP", Value = 4)]
		ItemFuncType_HeroEXP,
		// Token: 0x040022E6 RID: 8934
		[ProtoEnum(Name = "ItemFuncType_PlayerEXP", Value = 5)]
		ItemFuncType_PlayerEXP,
		// Token: 0x040022E7 RID: 8935
		[ProtoEnum(Name = "ItemFuncType_HeroFragment", Value = 6)]
		ItemFuncType_HeroFragment,
		// Token: 0x040022E8 RID: 8936
		[ProtoEnum(Name = "ItemFuncType_JobMaterialFragment", Value = 7)]
		ItemFuncType_JobMaterialFragment,
		// Token: 0x040022E9 RID: 8937
		[ProtoEnum(Name = "ItemFuncType_StaticBox", Value = 8)]
		ItemFuncType_StaticBox,
		// Token: 0x040022EA RID: 8938
		[ProtoEnum(Name = "ItemFuncType_RandomBox", Value = 9)]
		ItemFuncType_RandomBox,
		// Token: 0x040022EB RID: 8939
		[ProtoEnum(Name = "ItemFuncType_NameChange", Value = 10)]
		ItemFuncType_NameChange,
		// Token: 0x040022EC RID: 8940
		[ProtoEnum(Name = "ItemFuncType_AddHeroFavorabilityExp", Value = 11)]
		ItemFuncType_AddHeroFavorabilityExp,
		// Token: 0x040022ED RID: 8941
		[ProtoEnum(Name = "ItemFuncType_SelfSelectedBox", Value = 12)]
		ItemFuncType_SelfSelectedBox
	}
}
