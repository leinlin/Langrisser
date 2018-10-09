using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002BB RID: 699
	[ProtoContract(Name = "BuffConditionType")]
	public enum BuffConditionType
	{
		// Token: 0x04001CAA RID: 7338
		[ProtoEnum(Name = "BuffConditionType_None", Value = 0)]
		BuffConditionType_None,
		// Token: 0x04001CAB RID: 7339
		[ProtoEnum(Name = "BuffConditionType_IsAlone", Value = 1)]
		BuffConditionType_IsAlone,
		// Token: 0x04001CAC RID: 7340
		[ProtoEnum(Name = "BuffConditionType_NotAlone", Value = 2)]
		BuffConditionType_NotAlone,
		// Token: 0x04001CAD RID: 7341
		[ProtoEnum(Name = "BuffConditionType_Terrain", Value = 3)]
		BuffConditionType_Terrain,
		// Token: 0x04001CAE RID: 7342
		[ProtoEnum(Name = "BuffConditionType_HeroArmy", Value = 4)]
		BuffConditionType_HeroArmy,
		// Token: 0x04001CAF RID: 7343
		[ProtoEnum(Name = "BuffConditionType_TerrainIsDF", Value = 5)]
		BuffConditionType_TerrainIsDF
	}
}
