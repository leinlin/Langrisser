using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C2 RID: 706
	[ProtoContract(Name = "MissionColumnType")]
	public enum MissionColumnType
	{
		// Token: 0x04001D24 RID: 7460
		[ProtoEnum(Name = "MissionColumnType_Everyday", Value = 1)]
		MissionColumnType_Everyday = 1,
		// Token: 0x04001D25 RID: 7461
		[ProtoEnum(Name = "MissionColumnType_Challenge", Value = 2)]
		MissionColumnType_Challenge,
		// Token: 0x04001D26 RID: 7462
		[ProtoEnum(Name = "MissionColumnType_Achievements", Value = 3)]
		MissionColumnType_Achievements,
		// Token: 0x04001D27 RID: 7463
		[ProtoEnum(Name = "MissionColumnType_HeroFetter", Value = 4)]
		MissionColumnType_HeroFetter,
		// Token: 0x04001D28 RID: 7464
		[ProtoEnum(Name = "MissionColumnType_BeginningOfTheLegend", Value = 5)]
		MissionColumnType_BeginningOfTheLegend
	}
}
