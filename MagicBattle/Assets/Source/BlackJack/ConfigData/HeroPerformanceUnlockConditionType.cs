using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002ED RID: 749
	[ProtoContract(Name = "HeroPerformanceUnlockConditionType")]
	public enum HeroPerformanceUnlockConditionType
	{
		// Token: 0x04002297 RID: 8855
		[ProtoEnum(Name = "HeroPerformanceUnlockConditionType_None", Value = 0)]
		HeroPerformanceUnlockConditionType_None,
		// Token: 0x04002298 RID: 8856
		[ProtoEnum(Name = "HeroPerformanceUnlockConditionType_HeroFavourabilityLevel", Value = 1)]
		HeroPerformanceUnlockConditionType_HeroFavourabilityLevel
	}
}
