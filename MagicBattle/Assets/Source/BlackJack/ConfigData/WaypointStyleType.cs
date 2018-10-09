using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002F0 RID: 752
	[ProtoContract(Name = "WaypointStyleType")]
	public enum WaypointStyleType
	{
		// Token: 0x040022C2 RID: 8898
		[ProtoEnum(Name = "WaypointStyleType_None", Value = 0)]
		WaypointStyleType_None,
		// Token: 0x040022C3 RID: 8899
		[ProtoEnum(Name = "WaypointStyleType_Forest", Value = 1)]
		WaypointStyleType_Forest,
		// Token: 0x040022C4 RID: 8900
		[ProtoEnum(Name = "WaypointStyleType_Mountain", Value = 2)]
		WaypointStyleType_Mountain,
		// Token: 0x040022C5 RID: 8901
		[ProtoEnum(Name = "WaypointStyleType_Cave", Value = 3)]
		WaypointStyleType_Cave,
		// Token: 0x040022C6 RID: 8902
		[ProtoEnum(Name = "WaypointStyleType_Village", Value = 4)]
		WaypointStyleType_Village
	}
}
