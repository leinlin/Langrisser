using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E4 RID: 740
	[ProtoContract(Name = "VersionInfoId")]
	public enum VersionInfoId
	{
		// Token: 0x04002268 RID: 8808
		[ProtoEnum(Name = "VersionInfoId_ClientProgram", Value = 1)]
		VersionInfoId_ClientProgram = 1,
		// Token: 0x04002269 RID: 8809
		[ProtoEnum(Name = "VersionInfoId_AssetBundle", Value = 2)]
		VersionInfoId_AssetBundle,
		// Token: 0x0400226A RID: 8810
		[ProtoEnum(Name = "VersionInfoId_BattleReport", Value = 3)]
		VersionInfoId_BattleReport
	}
}
