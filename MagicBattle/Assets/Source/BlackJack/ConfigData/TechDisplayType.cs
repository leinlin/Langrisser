using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E6 RID: 742
	[ProtoContract(Name = "TechDisplayType")]
	public enum TechDisplayType
	{
		// Token: 0x04002279 RID: 8825
		[ProtoEnum(Name = "TechDisplayType_None", Value = 0)]
		TechDisplayType_None,
		// Token: 0x0400227A RID: 8826
		[ProtoEnum(Name = "TechDisplayType_SoldierTypeLevelUp", Value = 1)]
		TechDisplayType_SoldierTypeLevelUp,
		// Token: 0x0400227B RID: 8827
		[ProtoEnum(Name = "TechDisplayType_SoldierLevelUp", Value = 2)]
		TechDisplayType_SoldierLevelUp,
		// Token: 0x0400227C RID: 8828
		[ProtoEnum(Name = "TechDisplayType_SkillLevelUp", Value = 3)]
		TechDisplayType_SkillLevelUp
	}
}
