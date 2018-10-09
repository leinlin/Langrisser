using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F5 RID: 757
	[ProtoContract(Name = "FlushRuleType")]
	public enum FlushRuleType
	{
		// Token: 0x04002315 RID: 8981
		[ProtoEnum(Name = "FlushRuleType_None", Value = 0)]
		FlushRuleType_None,
		// Token: 0x04002316 RID: 8982
		[ProtoEnum(Name = "FlushRuleType_Period", Value = 1)]
		FlushRuleType_Period,
		// Token: 0x04002317 RID: 8983
		[ProtoEnum(Name = "FlushRuleType_FixedTime", Value = 2)]
		FlushRuleType_FixedTime
	}
}
