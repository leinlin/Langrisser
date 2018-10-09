using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000509 RID: 1289
	[CustomLuaClass]
	public class ArenaTopRankPlayer
	{
		// Token: 0x170012F7 RID: 4855
		// (get) Token: 0x06004DF6 RID: 19958 RVA: 0x0017BA6C File Offset: 0x00179C6C
		// (set) Token: 0x06004DF7 RID: 19959 RVA: 0x0017BA74 File Offset: 0x00179C74
		public string Name { get; set; }

		// Token: 0x170012F8 RID: 4856
		// (get) Token: 0x06004DF8 RID: 19960 RVA: 0x0017BA80 File Offset: 0x00179C80
		// (set) Token: 0x06004DF9 RID: 19961 RVA: 0x0017BA88 File Offset: 0x00179C88
		public ushort ArenaPoints { get; set; }

		// Token: 0x170012F9 RID: 4857
		// (get) Token: 0x06004DFA RID: 19962 RVA: 0x0017BA94 File Offset: 0x00179C94
		// (set) Token: 0x06004DFB RID: 19963 RVA: 0x0017BA9C File Offset: 0x00179C9C
		public byte LevelId { get; set; }

		// Token: 0x170012FA RID: 4858
		// (get) Token: 0x06004DFC RID: 19964 RVA: 0x0017BAA8 File Offset: 0x00179CA8
		// (set) Token: 0x06004DFD RID: 19965 RVA: 0x0017BAB0 File Offset: 0x00179CB0
		public int HeadIcon { get; set; }

		// Token: 0x170012FB RID: 4859
		// (get) Token: 0x06004DFE RID: 19966 RVA: 0x0017BABC File Offset: 0x00179CBC
		// (set) Token: 0x06004DFF RID: 19967 RVA: 0x0017BAC4 File Offset: 0x00179CC4
		public int Level { get; set; }

		// Token: 0x06004E00 RID: 19968 RVA: 0x0017BAD0 File Offset: 0x00179CD0
		public static ProArenaTopRankPlayer ArenaTopRankPlayerToPBArenaTopRankPlayer(ArenaTopRankPlayer topRankPlayer)
		{
			return new ProArenaTopRankPlayer
			{
				Name = topRankPlayer.Name,
				ArenaLevel = (int)topRankPlayer.LevelId,
				ArenaPoints = (uint)topRankPlayer.ArenaPoints,
				HeadIcon = topRankPlayer.HeadIcon,
				Level = topRankPlayer.Level
			};
		}

		// Token: 0x06004E01 RID: 19969 RVA: 0x0017BB24 File Offset: 0x00179D24
		public static ArenaTopRankPlayer PBArenaTopRankPlayerToArenaTopRankPlayer(ProArenaTopRankPlayer pbTopRankPlayer)
		{
			return new ArenaTopRankPlayer
			{
				Name = pbTopRankPlayer.Name,
				LevelId = (byte)pbTopRankPlayer.ArenaLevel,
				ArenaPoints = (ushort)pbTopRankPlayer.ArenaPoints,
				HeadIcon = pbTopRankPlayer.HeadIcon,
				Level = pbTopRankPlayer.Level
			};
		}
	}
}
