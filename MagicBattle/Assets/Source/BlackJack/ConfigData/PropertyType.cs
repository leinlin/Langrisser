using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002CD RID: 717
	[ProtoContract(Name = "PropertyType")]
	public enum PropertyType
	{
		// Token: 0x04001FD1 RID: 8145
		[ProtoEnum(Name = "PropertyType_None", Value = 0)]
		PropertyType_None,
		// Token: 0x04001FD2 RID: 8146
		[ProtoEnum(Name = "PropertyType_HP", Value = 1)]
		PropertyType_HP,
		// Token: 0x04001FD3 RID: 8147
		[ProtoEnum(Name = "PropertyType_AT", Value = 2)]
		PropertyType_AT,
		// Token: 0x04001FD4 RID: 8148
		[ProtoEnum(Name = "PropertyType_DF", Value = 3)]
		PropertyType_DF,
		// Token: 0x04001FD5 RID: 8149
		[ProtoEnum(Name = "PropertyType_Magic", Value = 4)]
		PropertyType_Magic,
		// Token: 0x04001FD6 RID: 8150
		[ProtoEnum(Name = "PropertyType_MagicDF", Value = 5)]
		PropertyType_MagicDF,
		// Token: 0x04001FD7 RID: 8151
		[ProtoEnum(Name = "PropertyType_DEX", Value = 6)]
		PropertyType_DEX,
		// Token: 0x04001FD8 RID: 8152
		[ProtoEnum(Name = "PropertyType_BFMovePoint", Value = 7)]
		PropertyType_BFMovePoint,
		// Token: 0x04001FD9 RID: 8153
		[ProtoEnum(Name = "PropertyType_BFAttackDistance", Value = 8)]
		PropertyType_BFAttackDistance
	}
}
