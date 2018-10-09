using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002CA RID: 714
	[ProtoContract(Name = "BuyRuleType")]
	public enum BuyRuleType
	{
		// Token: 0x04001DD6 RID: 7638
		[ProtoEnum(Name = "BuyRuleType_FixedTime", Value = 1)]
		BuyRuleType_FixedTime = 1,
		// Token: 0x04001DD7 RID: 7639
		[ProtoEnum(Name = "BuyRuleType_WeekTime", Value = 2)]
		BuyRuleType_WeekTime,
		// Token: 0x04001DD8 RID: 7640
		[ProtoEnum(Name = "BuyRuleType_MonthTime", Value = 3)]
		BuyRuleType_MonthTime,
		// Token: 0x04001DD9 RID: 7641
		[ProtoEnum(Name = "BuyRuleType_Forever", Value = 4)]
		BuyRuleType_Forever
	}
}
