using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200040A RID: 1034
	[CustomLuaClass]
	public class BattleRoomBattleLog
	{
		// Token: 0x17001079 RID: 4217
		// (get) Token: 0x06003C8F RID: 15503 RVA: 0x0011304C File Offset: 0x0011124C
		// (set) Token: 0x06003C90 RID: 15504 RVA: 0x00113054 File Offset: 0x00111254
		public ulong RoomId { get; set; }

		// Token: 0x1700107A RID: 4218
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x00113060 File Offset: 0x00111260
		// (set) Token: 0x06003C92 RID: 15506 RVA: 0x00113068 File Offset: 0x00111268
		public int BattleRoomType { get; set; }

		// Token: 0x1700107B RID: 4219
		// (get) Token: 0x06003C93 RID: 15507 RVA: 0x00113074 File Offset: 0x00111274
		// (set) Token: 0x06003C94 RID: 15508 RVA: 0x0011307C File Offset: 0x0011127C
		public int BattleId { get; set; }

		// Token: 0x1700107C RID: 4220
		// (get) Token: 0x06003C95 RID: 15509 RVA: 0x00113088 File Offset: 0x00111288
		// (set) Token: 0x06003C96 RID: 15510 RVA: 0x00113090 File Offset: 0x00111290
		public int RandomNumberSeed { get; set; }

		// Token: 0x1700107D RID: 4221
		// (get) Token: 0x06003C97 RID: 15511 RVA: 0x0011309C File Offset: 0x0011129C
		// (set) Token: 0x06003C98 RID: 15512 RVA: 0x001130A4 File Offset: 0x001112A4
		public int ArmyRandomNumberSeed { get; set; }

		// Token: 0x1700107E RID: 4222
		// (get) Token: 0x06003C99 RID: 15513 RVA: 0x001130B0 File Offset: 0x001112B0
		// (set) Token: 0x06003C9A RID: 15514 RVA: 0x001130B8 File Offset: 0x001112B8
		public List<BattleActorSetup> Team0 { get; set; }

		// Token: 0x1700107F RID: 4223
		// (get) Token: 0x06003C9B RID: 15515 RVA: 0x001130C4 File Offset: 0x001112C4
		// (set) Token: 0x06003C9C RID: 15516 RVA: 0x001130CC File Offset: 0x001112CC
		public List<BattleActorSetup> Team1 { get; set; }

		// Token: 0x17001080 RID: 4224
		// (get) Token: 0x06003C9D RID: 15517 RVA: 0x001130D8 File Offset: 0x001112D8
		// (set) Token: 0x06003C9E RID: 15518 RVA: 0x001130E0 File Offset: 0x001112E0
		public List<BattlePlayer> Players { get; set; }
	}
}
