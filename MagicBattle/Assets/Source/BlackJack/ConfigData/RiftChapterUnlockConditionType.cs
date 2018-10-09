using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002E0 RID: 736
	[ProtoContract(Name = "RiftChapterUnlockConditionType")]
	public enum RiftChapterUnlockConditionType
	{
		// Token: 0x04002249 RID: 8777
		[ProtoEnum(Name = "RiftChapterUnlockConditionType_None", Value = 0)]
		RiftChapterUnlockConditionType_None,
		// Token: 0x0400224A RID: 8778
		[ProtoEnum(Name = "RiftChapterUnlockConditionType_PlayerLevel", Value = 1)]
		RiftChapterUnlockConditionType_PlayerLevel,
		// Token: 0x0400224B RID: 8779
		[ProtoEnum(Name = "RiftChapterUnlockConditionType_Scenario", Value = 2)]
		RiftChapterUnlockConditionType_Scenario,
		// Token: 0x0400224C RID: 8780
		[ProtoEnum(Name = "RiftChapterUnlockConditionType_ChapterStar", Value = 3)]
		RiftChapterUnlockConditionType_ChapterStar
	}
}
