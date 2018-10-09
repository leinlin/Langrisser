using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E9 RID: 745
	[ProtoContract(Name = "FetterCompleteConditionType")]
	public enum FetterCompleteConditionType
	{
		// Token: 0x04002284 RID: 8836
		[ProtoEnum(Name = "FetterCompleteConditionType_None", Value = 0)]
		FetterCompleteConditionType_None,
		// Token: 0x04002285 RID: 8837
		[ProtoEnum(Name = "FetterCompleteConditionType_HeroFavorabilityLevel", Value = 1)]
		FetterCompleteConditionType_HeroFavorabilityLevel,
		// Token: 0x04002286 RID: 8838
		[ProtoEnum(Name = "FetterCompleteConditionType_Mission", Value = 2)]
		FetterCompleteConditionType_Mission
	}
}
