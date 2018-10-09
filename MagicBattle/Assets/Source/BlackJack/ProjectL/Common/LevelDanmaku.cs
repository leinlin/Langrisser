using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000538 RID: 1336
	[CustomLuaClass]
	public class LevelDanmaku
	{
		// Token: 0x06004F5E RID: 20318 RVA: 0x0017EC78 File Offset: 0x0017CE78
		public LevelDanmaku()
		{
			this.Turns = new List<TurnDanmaku>();
		}

		// Token: 0x06004F5F RID: 20319 RVA: 0x0017EC8C File Offset: 0x0017CE8C
		public LevelDanmaku(LevelDanmaku other) : this()
		{
			foreach (TurnDanmaku other2 in other.Turns)
			{
				this.Turns.Add(new TurnDanmaku(other2));
			}
		}

		// Token: 0x06004F60 RID: 20320 RVA: 0x0017ECF8 File Offset: 0x0017CEF8
		public static LevelDanmaku PBLevelDanmakuToLevelDanmaku(ProLevelDanmaku pbDanmaku)
		{
			LevelDanmaku levelDanmaku = new LevelDanmaku();
			foreach (ProTurnDanmaku pbTurnDanmaku in pbDanmaku.Turns)
			{
				levelDanmaku.Turns.Add(TurnDanmaku.PBTurnDanmakuToTurnDanmaku(pbTurnDanmaku));
			}
			return levelDanmaku;
		}

		// Token: 0x06004F61 RID: 20321 RVA: 0x0017ED68 File Offset: 0x0017CF68
		public static ProLevelDanmaku LevelDanmakuToPBLevelDanmaku(LevelDanmaku danmaku)
		{
			ProLevelDanmaku proLevelDanmaku = new ProLevelDanmaku();
			foreach (TurnDanmaku turnDanmaku in danmaku.Turns)
			{
				proLevelDanmaku.Turns.Add(TurnDanmaku.TurnDanmakuToPBTurnDanmaku(turnDanmaku));
			}
			return proLevelDanmaku;
		}

		// Token: 0x040039B2 RID: 14770
		public List<TurnDanmaku> Turns;
	}
}
