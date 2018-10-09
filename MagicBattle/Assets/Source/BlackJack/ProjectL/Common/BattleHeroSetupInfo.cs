using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000369 RID: 873
	[CustomLuaClass]
	public class BattleHeroSetupInfo
	{
		// Token: 0x060031D4 RID: 12756 RVA: 0x000C42B4 File Offset: 0x000C24B4
		public bool HasFlag(SetupBattleHeroFlag flag)
		{
			return (this.Flag & flag) != SetupBattleHeroFlag.None;
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000C42C4 File Offset: 0x000C24C4
		public static ProBattleHeroSetupInfo BattleHeroSetupInfoToPbProBattleHeroSetupInfo(BattleHeroSetupInfo info)
		{
			return new ProBattleHeroSetupInfo
			{
				PlayerIndex = info.PlayerIndex,
				Position = info.Position,
				Hero = ((info.Hero == null) ? null : BattleHero.BattleHeroToPBBattleHero(info.Hero)),
				Flag = (int)info.Flag
			};
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000C4320 File Offset: 0x000C2520
		public static BattleHeroSetupInfo PbBattleHeroSetupInfoToProBattleHeroSetupInfo(ProBattleHeroSetupInfo pbInfo)
		{
			return new BattleHeroSetupInfo
			{
				PlayerIndex = pbInfo.PlayerIndex,
				Position = pbInfo.Position,
				Hero = ((pbInfo.Hero == null) ? null : BattleHero.PBBattleHeroToBattleHero(pbInfo.Hero)),
				Flag = (SetupBattleHeroFlag)pbInfo.Flag
			};
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000C437C File Offset: 0x000C257C
		public BattleHeroSetupInfo Copy()
		{
			return new BattleHeroSetupInfo
			{
				Flag = this.Flag,
				Hero = this.Hero,
				PlayerIndex = this.PlayerIndex,
				Position = this.Position
			};
		}

		// Token: 0x04002651 RID: 9809
		public int PlayerIndex;

		// Token: 0x04002652 RID: 9810
		public int Position;

		// Token: 0x04002653 RID: 9811
		public BattleHero Hero;

		// Token: 0x04002654 RID: 9812
		public SetupBattleHeroFlag Flag;
	}
}
