using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Battle;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000409 RID: 1033
	[CustomLuaClass]
	public class BattleReportLog
	{
		// Token: 0x1700106D RID: 4205
		// (get) Token: 0x06003C76 RID: 15478 RVA: 0x00112F54 File Offset: 0x00111154
		// (set) Token: 0x06003C77 RID: 15479 RVA: 0x00112F5C File Offset: 0x0011115C
		public string UserId { get; set; }

		// Token: 0x1700106E RID: 4206
		// (get) Token: 0x06003C78 RID: 15480 RVA: 0x00112F68 File Offset: 0x00111168
		// (set) Token: 0x06003C79 RID: 15481 RVA: 0x00112F70 File Offset: 0x00111170
		public string PlayerName { get; set; }

		// Token: 0x1700106F RID: 4207
		// (get) Token: 0x06003C7A RID: 15482 RVA: 0x00112F7C File Offset: 0x0011117C
		// (set) Token: 0x06003C7B RID: 15483 RVA: 0x00112F84 File Offset: 0x00111184
		public BattleType Type { get; set; }

		// Token: 0x17001070 RID: 4208
		// (get) Token: 0x06003C7C RID: 15484 RVA: 0x00112F90 File Offset: 0x00111190
		// (set) Token: 0x06003C7D RID: 15485 RVA: 0x00112F98 File Offset: 0x00111198
		public int BattleId { get; set; }

		// Token: 0x17001071 RID: 4209
		// (get) Token: 0x06003C7E RID: 15486 RVA: 0x00112FA4 File Offset: 0x001111A4
		// (set) Token: 0x06003C7F RID: 15487 RVA: 0x00112FAC File Offset: 0x001111AC
		public int RandomNumberSeed { get; set; }

		// Token: 0x17001072 RID: 4210
		// (get) Token: 0x06003C80 RID: 15488 RVA: 0x00112FB8 File Offset: 0x001111B8
		// (set) Token: 0x06003C81 RID: 15489 RVA: 0x00112FC0 File Offset: 0x001111C0
		public int ArmyRandomNumberSeed { get; set; }

		// Token: 0x17001073 RID: 4211
		// (get) Token: 0x06003C82 RID: 15490 RVA: 0x00112FCC File Offset: 0x001111CC
		// (set) Token: 0x06003C83 RID: 15491 RVA: 0x00112FD4 File Offset: 0x001111D4
		public List<BattleActorSetup> MineTeam { get; set; }

		// Token: 0x17001074 RID: 4212
		// (get) Token: 0x06003C84 RID: 15492 RVA: 0x00112FE0 File Offset: 0x001111E0
		// (set) Token: 0x06003C85 RID: 15493 RVA: 0x00112FE8 File Offset: 0x001111E8
		public List<BattleActorSetup> OpponentTeam { get; set; }

		// Token: 0x17001075 RID: 4213
		// (get) Token: 0x06003C86 RID: 15494 RVA: 0x00112FF4 File Offset: 0x001111F4
		// (set) Token: 0x06003C87 RID: 15495 RVA: 0x00112FFC File Offset: 0x001111FC
		public List<BattlePlayer> Players { get; set; }

		// Token: 0x17001076 RID: 4214
		// (get) Token: 0x06003C88 RID: 15496 RVA: 0x00113008 File Offset: 0x00111208
		// (set) Token: 0x06003C89 RID: 15497 RVA: 0x00113010 File Offset: 0x00111210
		public List<BattleCommand> MineCommands { get; set; }

		// Token: 0x17001077 RID: 4215
		// (get) Token: 0x06003C8A RID: 15498 RVA: 0x0011301C File Offset: 0x0011121C
		// (set) Token: 0x06003C8B RID: 15499 RVA: 0x00113024 File Offset: 0x00111224
		public List<BattleCommand> OpponentCommands { get; set; }

		// Token: 0x17001078 RID: 4216
		// (get) Token: 0x06003C8C RID: 15500 RVA: 0x00113030 File Offset: 0x00111230
		// (set) Token: 0x06003C8D RID: 15501 RVA: 0x00113038 File Offset: 0x00111238
		public List<int> CheckSums { get; set; }
	}
}
