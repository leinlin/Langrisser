using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C8 RID: 712
	[ProtoContract(Name = "StoreId")]
	public enum StoreId
	{
		// Token: 0x04001DC0 RID: 7616
		[ProtoEnum(Name = "StoreId_None", Value = 0)]
		StoreId_None,
		// Token: 0x04001DC1 RID: 7617
		[ProtoEnum(Name = "StoreId_BlackMarket", Value = 1)]
		StoreId_BlackMarket,
		// Token: 0x04001DC2 RID: 7618
		[ProtoEnum(Name = "StoreId_Crystal", Value = 2)]
		StoreId_Crystal,
		// Token: 0x04001DC3 RID: 7619
		[ProtoEnum(Name = "StoreId_Honor", Value = 3)]
		StoreId_Honor,
		// Token: 0x04001DC4 RID: 7620
		[ProtoEnum(Name = "StoreId_Friendship", Value = 4)]
		StoreId_Friendship,
		// Token: 0x04001DC5 RID: 7621
		[ProtoEnum(Name = "StoreId_SkinHero", Value = 5)]
		StoreId_SkinHero,
		// Token: 0x04001DC6 RID: 7622
		[ProtoEnum(Name = "StoreId_SkinSoldier", Value = 6)]
		StoreId_SkinSoldier,
		// Token: 0x04001DC7 RID: 7623
		[ProtoEnum(Name = "StoreId_Gift", Value = 7)]
		StoreId_Gift,
		// Token: 0x04001DC8 RID: 7624
		[ProtoEnum(Name = "StoreId_Privilege", Value = 8)]
		StoreId_Privilege,
		// Token: 0x04001DC9 RID: 7625
		[ProtoEnum(Name = "StoreId_Medal", Value = 9)]
		StoreId_Medal,
		// Token: 0x04001DCA RID: 7626
		[ProtoEnum(Name = "StoreId_Union", Value = 10)]
		StoreId_Union,
		// Token: 0x04001DCB RID: 7627
		[ProtoEnum(Name = "StoreId_Recharge", Value = 11)]
		StoreId_Recharge,
		// Token: 0x04001DCC RID: 7628
		[ProtoEnum(Name = "StoreId_Memory", Value = 12)]
		StoreId_Memory,
		// Token: 0x04001DCD RID: 7629
		[ProtoEnum(Name = "StoreId_Equipment", Value = 13)]
		StoreId_Equipment,
		// Token: 0x04001DCE RID: 7630
		[ProtoEnum(Name = "StoreId_GuildPerson", Value = 14)]
		StoreId_GuildPerson
	}
}
