using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002DF RID: 735
	[ProtoContract(Name = "UserGuideAction")]
	public enum UserGuideAction
	{
		// Token: 0x04002235 RID: 8757
		[ProtoEnum(Name = "UserGuideAction_", Value = 0)]
		UserGuideAction_,
		// Token: 0x04002236 RID: 8758
		[ProtoEnum(Name = "UserGuideAction_Click", Value = 1)]
		UserGuideAction_Click,
		// Token: 0x04002237 RID: 8759
		[ProtoEnum(Name = "UserGuideAction_ShowSignOn", Value = 2)]
		UserGuideAction_ShowSignOn,
		// Token: 0x04002238 RID: 8760
		[ProtoEnum(Name = "UserGuideAction_EndStep", Value = 3)]
		UserGuideAction_EndStep,
		// Token: 0x04002239 RID: 8761
		[ProtoEnum(Name = "UserGuideAction_MoveWorldCameraTo", Value = 4)]
		UserGuideAction_MoveWorldCameraTo,
		// Token: 0x0400223A RID: 8762
		[ProtoEnum(Name = "UserGuideAction_MoveBattleCameraTo", Value = 5)]
		UserGuideAction_MoveBattleCameraTo,
		// Token: 0x0400223B RID: 8763
		[ProtoEnum(Name = "UserGuideAction_ClickBattleGrid", Value = 6)]
		UserGuideAction_ClickBattleGrid,
		// Token: 0x0400223C RID: 8764
		[ProtoEnum(Name = "UserGuideAction_TemporaryDisableObject", Value = 7)]
		UserGuideAction_TemporaryDisableObject,
		// Token: 0x0400223D RID: 8765
		[ProtoEnum(Name = "UserGuideAction_TemporaryDeactiveObject", Value = 8)]
		UserGuideAction_TemporaryDeactiveObject,
		// Token: 0x0400223E RID: 8766
		[ProtoEnum(Name = "UserGuideAction_ScrollToItem", Value = 9)]
		UserGuideAction_ScrollToItem,
		// Token: 0x0400223F RID: 8767
		[ProtoEnum(Name = "UserGuideAction_WaitSeconds", Value = 10)]
		UserGuideAction_WaitSeconds,
		// Token: 0x04002240 RID: 8768
		[ProtoEnum(Name = "UserGuideAction_WaitObjectClickable", Value = 11)]
		UserGuideAction_WaitObjectClickable,
		// Token: 0x04002241 RID: 8769
		[ProtoEnum(Name = "UserGuideAction_TemporaryDisableMoveBattleCamera", Value = 12)]
		UserGuideAction_TemporaryDisableMoveBattleCamera,
		// Token: 0x04002242 RID: 8770
		[ProtoEnum(Name = "UserGuideAction_FinishUserGuide", Value = 13)]
		UserGuideAction_FinishUserGuide,
		// Token: 0x04002243 RID: 8771
		[ProtoEnum(Name = "UserGuideAction_EnableMoveBattleCamera", Value = 14)]
		UserGuideAction_EnableMoveBattleCamera,
		// Token: 0x04002244 RID: 8772
		[ProtoEnum(Name = "UserGuideAction_EnableInput", Value = 15)]
		UserGuideAction_EnableInput,
		// Token: 0x04002245 RID: 8773
		[ProtoEnum(Name = "UserGuideAction_ShowActivityNotice", Value = 16)]
		UserGuideAction_ShowActivityNotice,
		// Token: 0x04002246 RID: 8774
		[ProtoEnum(Name = "UserGuideAction_IfSeflActiveThenGoto", Value = 17)]
		UserGuideAction_IfSeflActiveThenGoto,
		// Token: 0x04002247 RID: 8775
		[ProtoEnum(Name = "UserGuideAction_Trigger", Value = 18)]
		UserGuideAction_Trigger
	}
}
