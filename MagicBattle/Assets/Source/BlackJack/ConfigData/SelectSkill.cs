using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002B8 RID: 696
	[ProtoContract(Name = "SelectSkill")]
	public enum SelectSkill
	{
		// Token: 0x04001C82 RID: 7298
		[ProtoEnum(Name = "SelectSkill_DefaultSelection", Value = 1)]
		SelectSkill_DefaultSelection = 1,
		// Token: 0x04001C83 RID: 7299
		[ProtoEnum(Name = "SelectSkill_DirectReachTargetSkill", Value = 2)]
		SelectSkill_DirectReachTargetSkill,
		// Token: 0x04001C84 RID: 7300
		[ProtoEnum(Name = "SelectSkill_ExcludeSkillID", Value = 3)]
		SelectSkill_ExcludeSkillID,
		// Token: 0x04001C85 RID: 7301
		[ProtoEnum(Name = "SelectSkill_IncludeSkillID", Value = 4)]
		SelectSkill_IncludeSkillID
	}
}
