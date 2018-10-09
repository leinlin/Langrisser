using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000507 RID: 1287
	[CustomLuaClass]
	public class ArenaOpponent
	{
		// Token: 0x170012F0 RID: 4848
		// (get) Token: 0x06004DE3 RID: 19939 RVA: 0x0017B904 File Offset: 0x00179B04
		// (set) Token: 0x06004DE4 RID: 19940 RVA: 0x0017B90C File Offset: 0x00179B0C
		public string UserId { get; set; }

		// Token: 0x170012F1 RID: 4849
		// (get) Token: 0x06004DE5 RID: 19941 RVA: 0x0017B918 File Offset: 0x00179B18
		// (set) Token: 0x06004DE6 RID: 19942 RVA: 0x0017B920 File Offset: 0x00179B20
		public string Name { get; set; }

		// Token: 0x170012F2 RID: 4850
		// (get) Token: 0x06004DE7 RID: 19943 RVA: 0x0017B92C File Offset: 0x00179B2C
		// (set) Token: 0x06004DE8 RID: 19944 RVA: 0x0017B934 File Offset: 0x00179B34
		public int Level { get; set; }

		// Token: 0x170012F3 RID: 4851
		// (get) Token: 0x06004DE9 RID: 19945 RVA: 0x0017B940 File Offset: 0x00179B40
		// (set) Token: 0x06004DEA RID: 19946 RVA: 0x0017B948 File Offset: 0x00179B48
		public ushort ArenaPoints { get; set; }

		// Token: 0x170012F4 RID: 4852
		// (get) Token: 0x06004DEB RID: 19947 RVA: 0x0017B954 File Offset: 0x00179B54
		// (set) Token: 0x06004DEC RID: 19948 RVA: 0x0017B95C File Offset: 0x00179B5C
		public int HeadIcon { get; set; }

		// Token: 0x06004DED RID: 19949 RVA: 0x0017B968 File Offset: 0x00179B68
		public static ProArenaOpponent ArenaOpponentToPBArenaOpponent(ArenaOpponent arenaOpponent)
		{
			return new ProArenaOpponent
			{
				Name = arenaOpponent.Name,
				PlayerLevel = arenaOpponent.Level,
				ArenaPoints = (uint)arenaOpponent.ArenaPoints,
				HeadIcon = arenaOpponent.HeadIcon
			};
		}

		// Token: 0x06004DEE RID: 19950 RVA: 0x0017B9AC File Offset: 0x00179BAC
		public static ArenaOpponent PBArenaOpponentToArenaOpponent(ProArenaOpponent pbArenaOpponent)
		{
			return new ArenaOpponent
			{
				Name = pbArenaOpponent.Name,
				Level = pbArenaOpponent.PlayerLevel,
				ArenaPoints = (ushort)pbArenaOpponent.ArenaPoints,
				HeadIcon = pbArenaOpponent.HeadIcon
			};
		}
	}
}
