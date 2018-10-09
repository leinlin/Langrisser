using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002BE RID: 702
	[ProtoContract(Name = "EventFuncType")]
	public enum EventFuncType
	{
		// Token: 0x04001CE2 RID: 7394
		[ProtoEnum(Name = "EventFuncType_None", Value = 0)]
		EventFuncType_None,
		// Token: 0x04001CE3 RID: 7395
		[ProtoEnum(Name = "EventFuncType_Monster", Value = 1)]
		EventFuncType_Monster,
		// Token: 0x04001CE4 RID: 7396
		[ProtoEnum(Name = "EventFuncType_Mission", Value = 2)]
		EventFuncType_Mission,
		// Token: 0x04001CE5 RID: 7397
		[ProtoEnum(Name = "EventFuncType_Dialog", Value = 3)]
		EventFuncType_Dialog,
		// Token: 0x04001CE6 RID: 7398
		[ProtoEnum(Name = "EventFuncType_Treasure", Value = 4)]
		EventFuncType_Treasure,
		// Token: 0x04001CE7 RID: 7399
		[ProtoEnum(Name = "EventFuncType_Shop", Value = 5)]
		EventFuncType_Shop
	}
}
