using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002DB RID: 731
	[ProtoContract(Name = "CardSelectType")]
	public enum CardSelectType
	{
		// Token: 0x04002212 RID: 8722
		[ProtoEnum(Name = "CardSelectType_SingleSelect", Value = 1)]
		CardSelectType_SingleSelect = 1,
		// Token: 0x04002213 RID: 8723
		[ProtoEnum(Name = "CardSelectType_TenSelect", Value = 2)]
		CardSelectType_TenSelect,
		// Token: 0x04002214 RID: 8724
		[ProtoEnum(Name = "CardSelectType_BothSelect", Value = 3)]
		CardSelectType_BothSelect
	}
}
