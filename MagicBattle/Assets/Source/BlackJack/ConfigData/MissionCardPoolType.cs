using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002DC RID: 732
	[ProtoContract(Name = "MissionCardPoolType")]
	public enum MissionCardPoolType
	{
		// Token: 0x04002216 RID: 8726
		[ProtoEnum(Name = "MissionCardPoolType_None", Value = 0)]
		MissionCardPoolType_None,
		// Token: 0x04002217 RID: 8727
		[ProtoEnum(Name = "MissionCardPoolType_Free", Value = 1)]
		MissionCardPoolType_Free,
		// Token: 0x04002218 RID: 8728
		[ProtoEnum(Name = "MissionCardPoolType_Hero", Value = 2)]
		MissionCardPoolType_Hero,
		// Token: 0x04002219 RID: 8729
		[ProtoEnum(Name = "MissionCardPoolType_Equipment", Value = 3)]
		MissionCardPoolType_Equipment
	}
}
