using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E7 RID: 743
	[ProtoContract(Name = "ExpressionPurposeType")]
	public enum ExpressionPurposeType
	{
		// Token: 0x0400227E RID: 8830
		[ProtoEnum(Name = "ExpressionPurposeType_Chat", Value = 1)]
		ExpressionPurposeType_Chat = 1,
		// Token: 0x0400227F RID: 8831
		[ProtoEnum(Name = "ExpressionPurposeType_Combat", Value = 2)]
		ExpressionPurposeType_Combat
	}
}
