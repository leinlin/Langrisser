using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E5 RID: 741
	[ProtoContract(Name = "MonthType")]
	public enum MonthType
	{
		// Token: 0x0400226C RID: 8812
		[ProtoEnum(Name = "MonthType_January", Value = 1)]
		MonthType_January = 1,
		// Token: 0x0400226D RID: 8813
		[ProtoEnum(Name = "MonthType_February", Value = 2)]
		MonthType_February,
		// Token: 0x0400226E RID: 8814
		[ProtoEnum(Name = "MonthType_March", Value = 3)]
		MonthType_March,
		// Token: 0x0400226F RID: 8815
		[ProtoEnum(Name = "MonthType_April", Value = 4)]
		MonthType_April,
		// Token: 0x04002270 RID: 8816
		[ProtoEnum(Name = "MonthType_May", Value = 5)]
		MonthType_May,
		// Token: 0x04002271 RID: 8817
		[ProtoEnum(Name = "MonthType_June", Value = 6)]
		MonthType_June,
		// Token: 0x04002272 RID: 8818
		[ProtoEnum(Name = "MonthType_July", Value = 7)]
		MonthType_July,
		// Token: 0x04002273 RID: 8819
		[ProtoEnum(Name = "MonthType_August", Value = 8)]
		MonthType_August,
		// Token: 0x04002274 RID: 8820
		[ProtoEnum(Name = "MonthType_September", Value = 9)]
		MonthType_September,
		// Token: 0x04002275 RID: 8821
		[ProtoEnum(Name = "MonthType_October", Value = 10)]
		MonthType_October,
		// Token: 0x04002276 RID: 8822
		[ProtoEnum(Name = "MonthType_November", Value = 11)]
		MonthType_November,
		// Token: 0x04002277 RID: 8823
		[ProtoEnum(Name = "MonthType_December", Value = 12)]
		MonthType_December
	}
}
