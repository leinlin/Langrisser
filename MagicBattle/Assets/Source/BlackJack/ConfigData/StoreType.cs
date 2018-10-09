using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C7 RID: 711
	[ProtoContract(Name = "StoreType")]
	public enum StoreType
	{
		// Token: 0x04001DBA RID: 7610
		[ProtoEnum(Name = "StoreType_None", Value = 0)]
		StoreType_None,
		// Token: 0x04001DBB RID: 7611
		[ProtoEnum(Name = "StoreType_Static", Value = 1)]
		StoreType_Static,
		// Token: 0x04001DBC RID: 7612
		[ProtoEnum(Name = "StoreType_Random", Value = 2)]
		StoreType_Random,
		// Token: 0x04001DBD RID: 7613
		[ProtoEnum(Name = "StoreType_Recharge", Value = 3)]
		StoreType_Recharge,
		// Token: 0x04001DBE RID: 7614
		[ProtoEnum(Name = "StoreType_Gift", Value = 4)]
		StoreType_Gift
	}
}
