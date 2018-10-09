using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002BF RID: 703
	[ProtoContract(Name = "EventDisappearConditionType")]
	public enum EventDisappearConditionType
	{
		// Token: 0x04001CE9 RID: 7401
		[ProtoEnum(Name = "EventDisappearConditionType_None", Value = 0)]
		EventDisappearConditionType_None,
		// Token: 0x04001CEA RID: 7402
		[ProtoEnum(Name = "EventDisappearConditionType_Complete", Value = 1)]
		EventDisappearConditionType_Complete,
		// Token: 0x04001CEB RID: 7403
		[ProtoEnum(Name = "EventDisappearConditionType_LifeTime", Value = 2)]
		EventDisappearConditionType_LifeTime
	}
}
