using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002DD RID: 733
	[ProtoContract(Name = "UserGuideCondition")]
	public enum UserGuideCondition
	{
		// Token: 0x0400221B RID: 8731
		[ProtoEnum(Name = "UserGuideCondition_", Value = 0)]
		UserGuideCondition_,
		// Token: 0x0400221C RID: 8732
		[ProtoEnum(Name = "UserGuideCondition_StoryNFinished", Value = 1)]
		UserGuideCondition_StoryNFinished,
		// Token: 0x0400221D RID: 8733
		[ProtoEnum(Name = "UserGuideCondition_TodayIsSignedEqual", Value = 2)]
		UserGuideCondition_TodayIsSignedEqual,
		// Token: 0x0400221E RID: 8734
		[ProtoEnum(Name = "UserGuideCondition_GuideNFinished", Value = 3)]
		UserGuideCondition_GuideNFinished,
		// Token: 0x0400221F RID: 8735
		[ProtoEnum(Name = "UserGuideCondition_RiftChapterNUnlockable", Value = 4)]
		UserGuideCondition_RiftChapterNUnlockable,
		// Token: 0x04002220 RID: 8736
		[ProtoEnum(Name = "UserGuideCondition_RiftLevelNPassed", Value = 5)]
		UserGuideCondition_RiftLevelNPassed,
		// Token: 0x04002221 RID: 8737
		[ProtoEnum(Name = "UserGuideCondition_EventNHappened", Value = 6)]
		UserGuideCondition_EventNHappened,
		// Token: 0x04002222 RID: 8738
		[ProtoEnum(Name = "UserGuideCondition_IsRunningBattleN", Value = 7)]
		UserGuideCondition_IsRunningBattleN,
		// Token: 0x04002223 RID: 8739
		[ProtoEnum(Name = "UserGuideCondition_IsWayPointNArrived", Value = 8)]
		UserGuideCondition_IsWayPointNArrived,
		// Token: 0x04002224 RID: 8740
		[ProtoEnum(Name = "UserGuideCondition_IsHeroNComposable", Value = 9)]
		UserGuideCondition_IsHeroNComposable,
		// Token: 0x04002225 RID: 8741
		[ProtoEnum(Name = "UserGuideCondition_GuideNFinishedAndMNotFinished", Value = 10)]
		UserGuideCondition_GuideNFinishedAndMNotFinished,
		// Token: 0x04002226 RID: 8742
		[ProtoEnum(Name = "UserGuideCondition_NeverOpenedActivityNoticeAndPlayerLevelReachN", Value = 11)]
		UserGuideCondition_NeverOpenedActivityNoticeAndPlayerLevelReachN,
		// Token: 0x04002227 RID: 8743
		[ProtoEnum(Name = "UserGuideCondition_PlayerLevelReachN", Value = 12)]
		UserGuideCondition_PlayerLevelReachN,
		// Token: 0x04002228 RID: 8744
		[ProtoEnum(Name = "UserGuideCondition_GuideNUnfinished", Value = 13)]
		UserGuideCondition_GuideNUnfinished
	}
}
