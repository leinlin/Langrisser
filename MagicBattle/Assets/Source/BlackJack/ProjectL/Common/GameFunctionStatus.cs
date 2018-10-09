using System;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000356 RID: 854
	public enum GameFunctionStatus
	{
		// Token: 0x040025AF RID: 9647
		Start = 1,
		// Token: 0x040025B0 RID: 9648
		End,
		// Token: 0x040025B1 RID: 9649
		Cancel,
		// Token: 0x040025B2 RID: 9650
		FightOutTime,
		// Token: 0x040025B3 RID: 9651
		Error,
		// Token: 0x040025B4 RID: 9652
		Inteam,
		// Token: 0x040025B5 RID: 9653
		OutTeam,
		// Token: 0x040025B6 RID: 9654
		MatchmakingStart,
		// Token: 0x040025B7 RID: 9655
		MatchmakingCancel,
		// Token: 0x040025B8 RID: 9656
		ProtectHero,
		// Token: 0x040025B9 RID: 9657
		BanHero,
		// Token: 0x040025BA RID: 9658
		RealTimePVPStart
	}
}
