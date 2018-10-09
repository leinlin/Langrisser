using System;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200090B RID: 2315
	public enum HappeningStep
	{
		// Token: 0x04005F29 RID: 24361
		None,
		// Token: 0x04005F2A RID: 24362
		Init,
		// Token: 0x04005F2B RID: 24363
		DialogBefore,
		// Token: 0x04005F2C RID: 24364
		Battle,
		// Token: 0x04005F2D RID: 24365
		DialogAfter,
		// Token: 0x04005F2E RID: 24366
		BattleLoseOrCancel,
		// Token: 0x04005F2F RID: 24367
		MoveToWaypoint,
		// Token: 0x04005F30 RID: 24368
		MoveToPrevWaypoint
	}
}
