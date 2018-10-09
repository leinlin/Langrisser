using System;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AF1 RID: 2801
	public enum BattleUIState
	{
		// Token: 0x0400783D RID: 30781
		None,
		// Token: 0x0400783E RID: 30782
		SelectActionActor,
		// Token: 0x0400783F RID: 30783
		Move,
		// Token: 0x04007840 RID: 30784
		ExtraMove,
		// Token: 0x04007841 RID: 30785
		SelectSkillTarget,
		// Token: 0x04007842 RID: 30786
		ConfirmSkill,
		// Token: 0x04007843 RID: 30787
		SelectTeleportPosition,
		// Token: 0x04007844 RID: 30788
		WaitOtherPlayer,
		// Token: 0x04007845 RID: 30789
		Regret
	}
}
