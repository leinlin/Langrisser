using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E1 RID: 737
	[ProtoContract(Name = "RiftLevelUnlockConditionType")]
	public enum RiftLevelUnlockConditionType
	{
		// Token: 0x0400224E RID: 8782
		[ProtoEnum(Name = "RiftLevelUnlockConditionType_None", Value = 0)]
		RiftLevelUnlockConditionType_None,
		// Token: 0x0400224F RID: 8783
		[ProtoEnum(Name = "RiftLevelUnlockConditionType_Scenario", Value = 1)]
		RiftLevelUnlockConditionType_Scenario,
		// Token: 0x04002250 RID: 8784
		[ProtoEnum(Name = "RiftLevelUnlockConditionType_Achievement", Value = 2)]
		RiftLevelUnlockConditionType_Achievement,
		// Token: 0x04002251 RID: 8785
		[ProtoEnum(Name = "RiftLevelUnlockConditionType_Hero", Value = 3)]
		RiftLevelUnlockConditionType_Hero,
		// Token: 0x04002252 RID: 8786
		[ProtoEnum(Name = "RiftLevelUnlockConditionType_RiftLevel", Value = 4)]
		RiftLevelUnlockConditionType_RiftLevel
	}
}
