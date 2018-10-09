using System;
using System.Collections.Generic;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000539 RID: 1337
	[CustomLuaClass]
	public class TurnDanmaku
	{
		// Token: 0x06004F62 RID: 20322 RVA: 0x0017EDD8 File Offset: 0x0017CFD8
		public TurnDanmaku()
		{
			this.Entries = new List<DanmakuEntry>();
		}

		// Token: 0x06004F63 RID: 20323 RVA: 0x0017EDEC File Offset: 0x0017CFEC
		public TurnDanmaku(TurnDanmaku other) : this()
		{
			this.Turn = other.Turn;
			this.NextIndex = other.NextIndex;
			foreach (DanmakuEntry other2 in other.Entries)
			{
				this.Entries.Add(new DanmakuEntry(other2));
			}
		}

		// Token: 0x1700137A RID: 4986
		// (get) Token: 0x06004F64 RID: 20324 RVA: 0x0017EE70 File Offset: 0x0017D070
		// (set) Token: 0x06004F65 RID: 20325 RVA: 0x0017EE78 File Offset: 0x0017D078
		public int Turn { get; set; }

		// Token: 0x1700137B RID: 4987
		// (get) Token: 0x06004F66 RID: 20326 RVA: 0x0017EE84 File Offset: 0x0017D084
		// (set) Token: 0x06004F67 RID: 20327 RVA: 0x0017EE8C File Offset: 0x0017D08C
		public int NextIndex { get; set; }

		// Token: 0x06004F68 RID: 20328 RVA: 0x0017EE98 File Offset: 0x0017D098
		public static TurnDanmaku PBTurnDanmakuToTurnDanmaku(ProTurnDanmaku pbTurnDanmaku)
		{
			TurnDanmaku turnDanmaku = new TurnDanmaku
			{
				Turn = pbTurnDanmaku.Turn,
				NextIndex = pbTurnDanmaku.NextIndex
			};
			foreach (ProDanmakuEntry pbEntry in pbTurnDanmaku.Entries)
			{
				turnDanmaku.Entries.Add(DanmakuEntry.PBLevelDanmakuToLevelDanmaku(pbEntry));
			}
			return turnDanmaku;
		}

		// Token: 0x06004F69 RID: 20329 RVA: 0x0017EF20 File Offset: 0x0017D120
		public static ProTurnDanmaku TurnDanmakuToPBTurnDanmaku(TurnDanmaku turnDanmaku)
		{
			ProTurnDanmaku proTurnDanmaku = new ProTurnDanmaku
			{
				Turn = turnDanmaku.Turn,
				NextIndex = turnDanmaku.NextIndex
			};
			foreach (DanmakuEntry entry in turnDanmaku.Entries)
			{
				proTurnDanmaku.Entries.Add(DanmakuEntry.LevelDanmakuToPBLevelDanmaku(entry));
			}
			return proTurnDanmaku;
		}

		// Token: 0x040039B5 RID: 14773
		public List<DanmakuEntry> Entries;
	}
}
