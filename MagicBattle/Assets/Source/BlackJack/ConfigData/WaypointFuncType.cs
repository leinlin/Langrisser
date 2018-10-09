using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002EF RID: 751
	[ProtoContract(Name = "WaypointFuncType")]
	public enum WaypointFuncType
	{
		// Token: 0x040022BD RID: 8893
		[ProtoEnum(Name = "WaypointFuncType_None", Value = 0)]
		WaypointFuncType_None,
		// Token: 0x040022BE RID: 8894
		[ProtoEnum(Name = "WaypointFuncType_Scenario", Value = 1)]
		WaypointFuncType_Scenario,
		// Token: 0x040022BF RID: 8895
		[ProtoEnum(Name = "WaypointFuncType_Portal", Value = 2)]
		WaypointFuncType_Portal,
		// Token: 0x040022C0 RID: 8896
		[ProtoEnum(Name = "WaypointFuncType_Event", Value = 3)]
		WaypointFuncType_Event
	}
}
