using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002C0 RID: 704
	[ProtoContract(Name = "MissionPeriodType")]
	public enum MissionPeriodType
	{
		// Token: 0x04001CED RID: 7405
		[ProtoEnum(Name = "MissionPeriodType_Everyday", Value = 1)]
		MissionPeriodType_Everyday = 1,
		// Token: 0x04001CEE RID: 7406
		[ProtoEnum(Name = "MissionPeriodType_OneOff", Value = 2)]
		MissionPeriodType_OneOff
	}
}
