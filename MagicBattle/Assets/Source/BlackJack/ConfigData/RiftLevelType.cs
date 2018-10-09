using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E2 RID: 738
	[ProtoContract(Name = "RiftLevelType")]
	public enum RiftLevelType
	{
		// Token: 0x04002254 RID: 8788
		[ProtoEnum(Name = "RiftLevelType_None", Value = 0)]
		RiftLevelType_None,
		// Token: 0x04002255 RID: 8789
		[ProtoEnum(Name = "RiftLevelType_Scenario", Value = 1)]
		RiftLevelType_Scenario,
		// Token: 0x04002256 RID: 8790
		[ProtoEnum(Name = "RiftLevelType_Event", Value = 2)]
		RiftLevelType_Event
	}
}
