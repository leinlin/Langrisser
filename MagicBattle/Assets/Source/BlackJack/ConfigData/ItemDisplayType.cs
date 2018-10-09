using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F3 RID: 755
	[ProtoContract(Name = "ItemDisplayType")]
	public enum ItemDisplayType
	{
		// Token: 0x040022EF RID: 8943
		[ProtoEnum(Name = "ItemDisplayType_None", Value = 0)]
		ItemDisplayType_None,
		// Token: 0x040022F0 RID: 8944
		[ProtoEnum(Name = "ItemDisplayType_Consumable", Value = 1)]
		ItemDisplayType_Consumable,
		// Token: 0x040022F1 RID: 8945
		[ProtoEnum(Name = "ItemDisplayType_HeroFragment", Value = 2)]
		ItemDisplayType_HeroFragment,
		// Token: 0x040022F2 RID: 8946
		[ProtoEnum(Name = "ItemDisplayType_JobMaterialFragment", Value = 3)]
		ItemDisplayType_JobMaterialFragment,
		// Token: 0x040022F3 RID: 8947
		[ProtoEnum(Name = "ItemDisplayType_Goblin", Value = 4)]
		ItemDisplayType_Goblin,
		// Token: 0x040022F4 RID: 8948
		[ProtoEnum(Name = "ItemDisplayType_UnchartedScore", Value = 5)]
		ItemDisplayType_UnchartedScore
	}
}
