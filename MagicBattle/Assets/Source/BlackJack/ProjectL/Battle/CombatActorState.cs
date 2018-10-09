using System;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003BB RID: 955
	public enum CombatActorState
	{
		// Token: 0x04002B91 RID: 11153
		None,
		// Token: 0x04002B92 RID: 11154
		Enter,
		// Token: 0x04002B93 RID: 11155
		Exit,
		// Token: 0x04002B94 RID: 11156
		Idle,
		// Token: 0x04002B95 RID: 11157
		Fight,
		// Token: 0x04002B96 RID: 11158
		FightEnd,
		// Token: 0x04002B97 RID: 11159
		FightAgain,
		// Token: 0x04002B98 RID: 11160
		Skill,
		// Token: 0x04002B99 RID: 11161
		Die,
		// Token: 0x04002B9A RID: 11162
		Return,
		// Token: 0x04002B9B RID: 11163
		Stop
	}
}
