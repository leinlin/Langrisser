using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002D9 RID: 729
	[ProtoContract(Name = "TrackType")]
	public enum TrackType
	{
		// Token: 0x04002208 RID: 8712
		[ProtoEnum(Name = "TrackType_None", Value = 0)]
		TrackType_None,
		// Token: 0x04002209 RID: 8713
		[ProtoEnum(Name = "TrackType_Parabolic", Value = 1)]
		TrackType_Parabolic,
		// Token: 0x0400220A RID: 8714
		[ProtoEnum(Name = "TrackType_Straight", Value = 2)]
		TrackType_Straight,
		// Token: 0x0400220B RID: 8715
		[ProtoEnum(Name = "TrackType_DownStraight", Value = 3)]
		TrackType_DownStraight,
		// Token: 0x0400220C RID: 8716
		[ProtoEnum(Name = "TrackType_UpStraight", Value = 4)]
		TrackType_UpStraight
	}
}
