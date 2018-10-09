using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C9 RID: 713
	[ProtoContract(Name = "LabelType")]
	public enum LabelType
	{
		// Token: 0x04001DD0 RID: 7632
		[ProtoEnum(Name = "LabelType_None", Value = 0)]
		LabelType_None,
		// Token: 0x04001DD1 RID: 7633
		[ProtoEnum(Name = "LabelType_FixedTime", Value = 1)]
		LabelType_FixedTime,
		// Token: 0x04001DD2 RID: 7634
		[ProtoEnum(Name = "LabelType_Recommand", Value = 2)]
		LabelType_Recommand,
		// Token: 0x04001DD3 RID: 7635
		[ProtoEnum(Name = "LabelType_Discount", Value = 3)]
		LabelType_Discount,
		// Token: 0x04001DD4 RID: 7636
		[ProtoEnum(Name = "LabelType_FirstDiscount", Value = 4)]
		LabelType_FirstDiscount
	}
}
