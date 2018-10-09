using System;
using ProtoBuf;

namespace BlackJack.ConfigData
{
	// Token: 0x020002DE RID: 734
	[ProtoContract(Name = "UserGuideTrigger")]
	public enum UserGuideTrigger
	{
		// Token: 0x0400222A RID: 8746
		[ProtoEnum(Name = "UserGuideTrigger_", Value = 0)]
		UserGuideTrigger_,
		// Token: 0x0400222B RID: 8747
		[ProtoEnum(Name = "UserGuideTrigger_ShowObject", Value = 1)]
		UserGuideTrigger_ShowObject,
		// Token: 0x0400222C RID: 8748
		[ProtoEnum(Name = "UserGuideTrigger_FinishGuideStepN", Value = 2)]
		UserGuideTrigger_FinishGuideStepN,
		// Token: 0x0400222D RID: 8749
		[ProtoEnum(Name = "UserGuideTrigger_HideObject", Value = 3)]
		UserGuideTrigger_HideObject,
		// Token: 0x0400222E RID: 8750
		[ProtoEnum(Name = "UserGuideTrigger_EndUIState", Value = 4)]
		UserGuideTrigger_EndUIState,
		// Token: 0x0400222F RID: 8751
		[ProtoEnum(Name = "UserGuideTrigger_SelectBattleHeroN", Value = 5)]
		UserGuideTrigger_SelectBattleHeroN,
		// Token: 0x04002230 RID: 8752
		[ProtoEnum(Name = "UserGuideTrigger_DeselectBattleHeroN", Value = 6)]
		UserGuideTrigger_DeselectBattleHeroN,
		// Token: 0x04002231 RID: 8753
		[ProtoEnum(Name = "UserGuideTrigger_FinishUserGuideN", Value = 7)]
		UserGuideTrigger_FinishUserGuideN,
		// Token: 0x04002232 RID: 8754
		[ProtoEnum(Name = "UserGuideTrigger_WorldUIGetReady", Value = 8)]
		UserGuideTrigger_WorldUIGetReady,
		// Token: 0x04002233 RID: 8755
		[ProtoEnum(Name = "UserGuideTrigger_BuyGiftStoreGoodsN", Value = 9)]
		UserGuideTrigger_BuyGiftStoreGoodsN
	}
}
