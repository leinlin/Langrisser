using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002EA RID: 746
	[ProtoContract(Name = "HeroBiographyUnlockConditionType")]
	public enum HeroBiographyUnlockConditionType
	{
		// Token: 0x04002288 RID: 8840
		[ProtoEnum(Name = "HeroBiographyUnlockConditionType_None", Value = 0)]
		HeroBiographyUnlockConditionType_None,
		// Token: 0x04002289 RID: 8841
		[ProtoEnum(Name = "HeroBiographyUnlockConditionType_HeroFavorabilityLevel", Value = 1)]
		HeroBiographyUnlockConditionType_HeroFavorabilityLevel
	}
}
