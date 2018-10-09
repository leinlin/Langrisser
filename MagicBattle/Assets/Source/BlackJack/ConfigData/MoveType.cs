using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C4 RID: 708
	[ProtoContract(Name = "MoveType")]
	public enum MoveType
	{
		// Token: 0x04001D4E RID: 7502
		[ProtoEnum(Name = "MoveType_None", Value = 0)]
		MoveType_None,
		// Token: 0x04001D4F RID: 7503
		[ProtoEnum(Name = "MoveType_Ride", Value = 1)]
		MoveType_Ride,
		// Token: 0x04001D50 RID: 7504
		[ProtoEnum(Name = "MoveType_Walk", Value = 2)]
		MoveType_Walk,
		// Token: 0x04001D51 RID: 7505
		[ProtoEnum(Name = "MoveType_Water", Value = 3)]
		MoveType_Water,
		// Token: 0x04001D52 RID: 7506
		[ProtoEnum(Name = "MoveType_Fly", Value = 4)]
		MoveType_Fly
	}
}
