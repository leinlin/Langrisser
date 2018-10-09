using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002DA RID: 730
	[ProtoContract(Name = "CardPoolType")]
	public enum CardPoolType
	{
		// Token: 0x0400220E RID: 8718
		[ProtoEnum(Name = "CardPoolType_FreeCardPool", Value = 1)]
		CardPoolType_FreeCardPool = 1,
		// Token: 0x0400220F RID: 8719
		[ProtoEnum(Name = "CardPoolType_CrystalCardPool", Value = 2)]
		CardPoolType_CrystalCardPool,
		// Token: 0x04002210 RID: 8720
		[ProtoEnum(Name = "CardPoolType_ActivityCardPool", Value = 3)]
		CardPoolType_ActivityCardPool
	}
}
