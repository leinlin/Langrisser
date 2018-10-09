using System;
using System.Collections.Generic;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000368 RID: 872
	[CustomLuaClass]
	public class BattleRoomPlayerHeroSetup
	{
		// Token: 0x060031C2 RID: 12738 RVA: 0x000C3BE8 File Offset: 0x000C1DE8
		public bool InitTeamBattle(int playerCount, int heroPosCount)
		{
			if (playerCount < 2 || playerCount > 3)
			{
				return false;
			}
			if (heroPosCount < 4 || heroPosCount > 6)
			{
				return false;
			}
			this.m_pvpHeroPositionCount0 = 0;
			this.m_battleHeroSetupInfos.Clear();
			for (int i = 0; i < heroPosCount; i++)
			{
				this.m_battleHeroSetupInfos.Add(new BattleHeroSetupInfo());
				this.m_battleHeroSetupInfos[i].Position = i;
			}
			if (heroPosCount == 4)
			{
				if (playerCount == 2)
				{
					this.InitPlayerIndex(0, 0, 2);
					this.InitPlayerIndex(1, 2, 2);
				}
				else if (playerCount == 3)
				{
					this.InitPlayerIndex(0, 0, 2);
					this.InitPlayerIndex(1, 2, 1);
					this.InitPlayerIndex(2, 3, 1);
				}
			}
			else if (heroPosCount == 5)
			{
				if (playerCount == 2)
				{
					this.InitPlayerIndex(0, 0, 3);
					this.InitPlayerIndex(1, 3, 2);
				}
				else if (playerCount == 3)
				{
					this.InitPlayerIndex(0, 0, 2);
					this.InitPlayerIndex(1, 2, 2);
					this.InitPlayerIndex(2, 4, 1);
				}
			}
			else if (heroPosCount == 6)
			{
				if (playerCount == 2)
				{
					this.InitPlayerIndex(0, 0, 3);
					this.InitPlayerIndex(1, 3, 3);
				}
				else if (playerCount == 3)
				{
					this.InitPlayerIndex(0, 0, 2);
					this.InitPlayerIndex(1, 2, 2);
					this.InitPlayerIndex(2, 4, 2);
				}
			}
			return true;
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000C3D3C File Offset: 0x000C1F3C
		public bool InitPVPBattle(int heroPosCount0, int heroPosCount1)
		{
			if (heroPosCount0 <= 0 || heroPosCount1 <= 0)
			{
				return false;
			}
			this.m_pvpHeroPositionCount0 = heroPosCount0;
			this.m_battleHeroSetupInfos.Clear();
			for (int i = 0; i < heroPosCount0 + heroPosCount1; i++)
			{
				this.m_battleHeroSetupInfos.Add(new BattleHeroSetupInfo());
				this.m_battleHeroSetupInfos[i].Position = i;
			}
			this.InitPlayerIndex(0, 0, heroPosCount0);
			this.InitPlayerIndex(1, heroPosCount0, heroPosCount1);
			return true;
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000C3DB4 File Offset: 0x000C1FB4
		private void InitPlayerIndex(int playerIdx, int heroPos, int heroPosCount)
		{
			for (int i = 0; i < heroPosCount; i++)
			{
				this.m_battleHeroSetupInfos[i + heroPos].PlayerIndex = playerIdx;
			}
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000C3DE8 File Offset: 0x000C1FE8
		public void Clear()
		{
			this.m_battleHeroSetupInfos.Clear();
			this.m_pvpHeroPositionCount0 = 0;
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x000C3DFC File Offset: 0x000C1FFC
		public int GetCount()
		{
			return this.m_battleHeroSetupInfos.Count;
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x000C3E0C File Offset: 0x000C200C
		public bool SetHero(int playerIdx, int heroPos, BattleHero hero, bool checkHeroDup = true)
		{
			if (heroPos < 0 || heroPos >= this.m_battleHeroSetupInfos.Count)
			{
				return false;
			}
			if (this.m_battleHeroSetupInfos[heroPos].PlayerIndex != playerIdx)
			{
				return false;
			}
			if (hero != null && checkHeroDup)
			{
				int num = this.FindHeroPosition(playerIdx, hero.HeroId);
				if (num >= 0 && num != heroPos)
				{
					return false;
				}
			}
			this.m_battleHeroSetupInfos[heroPos].Hero = hero;
			this.UpdateBattleHeroActionPositionIndex(heroPos);
			return true;
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x000C3E94 File Offset: 0x000C2094
		public bool SwapHeros(int playerIdx, int heroPos1, int heroPos2, bool checkPos2HeroExist)
		{
			if (heroPos1 < 0 || heroPos1 >= this.m_battleHeroSetupInfos.Count)
			{
				return false;
			}
			if (heroPos2 < 0 || heroPos2 >= this.m_battleHeroSetupInfos.Count)
			{
				return false;
			}
			if (this.m_battleHeroSetupInfos[heroPos1].PlayerIndex != playerIdx)
			{
				return false;
			}
			if (this.m_battleHeroSetupInfos[heroPos2].PlayerIndex != playerIdx)
			{
				return false;
			}
			if (this.m_battleHeroSetupInfos[heroPos1].Hero == null)
			{
				return false;
			}
			if (checkPos2HeroExist && this.m_battleHeroSetupInfos[heroPos2].Hero == null)
			{
				return false;
			}
			BattleHero hero = this.m_battleHeroSetupInfos[heroPos1].Hero;
			this.m_battleHeroSetupInfos[heroPos1].Hero = this.m_battleHeroSetupInfos[heroPos2].Hero;
			this.m_battleHeroSetupInfos[heroPos2].Hero = hero;
			this.UpdateBattleHeroActionPositionIndex(heroPos1);
			this.UpdateBattleHeroActionPositionIndex(heroPos2);
			return true;
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000C3F94 File Offset: 0x000C2194
		private void UpdateBattleHeroActionPositionIndex(int heroPos)
		{
			BattleHeroSetupInfo battleHeroSetupInfo = this.GetBattleHeroSetupInfo(heroPos);
			if (battleHeroSetupInfo == null)
			{
				return;
			}
			if (battleHeroSetupInfo.Hero != null)
			{
				if (this.m_pvpHeroPositionCount0 > 0)
				{
					battleHeroSetupInfo.Hero.ActionPositionIndex = this.PVPRoomPositionToTeamPosition(battleHeroSetupInfo.PlayerIndex, battleHeroSetupInfo.Position);
				}
				else
				{
					battleHeroSetupInfo.Hero.ActionPositionIndex = battleHeroSetupInfo.Position;
				}
			}
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000C3FFC File Offset: 0x000C21FC
		public bool MarkSetupHeroFlag(int playerIdx, int heroPos, SetupBattleHeroFlag Flag)
		{
			if (heroPos < 0 || heroPos >= this.m_battleHeroSetupInfos.Count)
			{
				return false;
			}
			if (this.m_battleHeroSetupInfos[heroPos].PlayerIndex != playerIdx)
			{
				return false;
			}
			if (this.m_battleHeroSetupInfos[heroPos].Hero == null)
			{
				return false;
			}
			this.m_battleHeroSetupInfos[heroPos].Flag = Flag;
			return true;
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000C4068 File Offset: 0x000C2268
		public BattleHeroSetupInfo GetBattleHeroSetupInfo(int heroPos)
		{
			if (heroPos < 0 || heroPos >= this.m_battleHeroSetupInfos.Count)
			{
				return null;
			}
			return this.m_battleHeroSetupInfos[heroPos];
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000C4090 File Offset: 0x000C2290
		public int FindHeroPosition(int playerIdx, int heroId)
		{
			foreach (BattleHeroSetupInfo battleHeroSetupInfo in this.m_battleHeroSetupInfos)
			{
				if (battleHeroSetupInfo.PlayerIndex == playerIdx && battleHeroSetupInfo.Hero != null && battleHeroSetupInfo.Hero.HeroId == heroId)
				{
					return battleHeroSetupInfo.Position;
				}
			}
			return -1;
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x000C411C File Offset: 0x000C231C
		public int GetHeroCountByPlayerIndex(int playerIdx)
		{
			int num = 0;
			foreach (BattleHeroSetupInfo battleHeroSetupInfo in this.m_battleHeroSetupInfos)
			{
				if (battleHeroSetupInfo.PlayerIndex == playerIdx && battleHeroSetupInfo.Hero != null)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000C4190 File Offset: 0x000C2390
		public List<int> GetHeroIdsByPlayerIndex(int playerIdx)
		{
			List<int> list = new List<int>();
			foreach (BattleHeroSetupInfo battleHeroSetupInfo in this.m_battleHeroSetupInfos)
			{
				if (battleHeroSetupInfo.PlayerIndex == playerIdx && battleHeroSetupInfo.Hero != null)
				{
					list.Add(battleHeroSetupInfo.Hero.HeroId);
				}
			}
			return list;
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x000C4214 File Offset: 0x000C2414
		public int GetHeroPositionCountByPlayerIndex(int playerIdx)
		{
			int num = 0;
			foreach (BattleHeroSetupInfo battleHeroSetupInfo in this.m_battleHeroSetupInfos)
			{
				if (battleHeroSetupInfo.PlayerIndex == playerIdx)
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000C427C File Offset: 0x000C247C
		public List<BattleHeroSetupInfo> GetBattleHeroSetupInfos()
		{
			return this.m_battleHeroSetupInfos;
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x000C4284 File Offset: 0x000C2484
		public int PVPRoomPositionToTeamPosition(int playerIndex, int heroPos)
		{
			if (playerIndex == 0)
			{
				return heroPos;
			}
			return heroPos - this.m_pvpHeroPositionCount0;
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000C4298 File Offset: 0x000C2498
		public int PVPTeamPositionToRoomPosition(int playerIndex, int heroPos)
		{
			if (playerIndex == 0)
			{
				return heroPos;
			}
			return heroPos + this.m_pvpHeroPositionCount0;
		}

		// Token: 0x0400264F RID: 9807
		private List<BattleHeroSetupInfo> m_battleHeroSetupInfos = new List<BattleHeroSetupInfo>();

		// Token: 0x04002650 RID: 9808
		private int m_pvpHeroPositionCount0;
	}
}
