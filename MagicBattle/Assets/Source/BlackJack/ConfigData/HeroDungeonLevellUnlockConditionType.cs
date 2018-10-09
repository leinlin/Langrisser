using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E8 RID: 744
	[ProtoContract(Name = "HeroDungeonLevellUnlockConditionType")]
	public enum HeroDungeonLevellUnlockConditionType
	{
		// Token: 0x04002281 RID: 8833
		[ProtoEnum(Name = "HeroDungeonLevellUnlockConditionType_None", Value = 0)]
		HeroDungeonLevellUnlockConditionType_None,
		// Token: 0x04002282 RID: 8834
		[ProtoEnum(Name = "HeroDungeonLevellUnlockConditionType_HeroFavorabilityLevel", Value = 1)]
		HeroDungeonLevellUnlockConditionType_HeroFavorabilityLevel
	}
}
