using System;
using System.Collections.Generic;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000546 RID: 1350
	[CustomLuaClass]
	public class HeroAssistantsTask
	{
		// Token: 0x1700138C RID: 5004
		// (get) Token: 0x06004FAF RID: 20399 RVA: 0x0017F5B8 File Offset: 0x0017D7B8
		// (set) Token: 0x06004FB0 RID: 20400 RVA: 0x0017F5C0 File Offset: 0x0017D7C0
		public int ConfigId { get; set; }

		// Token: 0x1700138D RID: 5005
		// (get) Token: 0x06004FB1 RID: 20401 RVA: 0x0017F5CC File Offset: 0x0017D7CC
		public int Weekday
		{
			get
			{
				return this.Config.m_schedule.Weekday % 7;
			}
		}

		// Token: 0x1700138E RID: 5006
		// (get) Token: 0x06004FB2 RID: 20402 RVA: 0x0017F5E0 File Offset: 0x0017D7E0
		public List<int> RecommendHeroIds
		{
			get
			{
				return this.Config.m_schedule.RecommendHeroes;
			}
		}

		// Token: 0x1700138F RID: 5007
		// (get) Token: 0x06004FB3 RID: 20403 RVA: 0x0017F5F4 File Offset: 0x0017D7F4
		public List<int> SoldierTypes
		{
			get
			{
				return this.Config.m_schedule.SoldierTypeList;
			}
		}

		// Token: 0x17001390 RID: 5008
		// (get) Token: 0x06004FB4 RID: 20404 RVA: 0x0017F608 File Offset: 0x0017D808
		public int CompletePoints
		{
			get
			{
				return this.Config.CompletePoints;
			}
		}

		// Token: 0x17001391 RID: 5009
		// (get) Token: 0x06004FB5 RID: 20405 RVA: 0x0017F618 File Offset: 0x0017D818
		public int RequiredUserLevel
		{
			get
			{
				return this.Config.RequiredUserLevel;
			}
		}

		// Token: 0x17001392 RID: 5010
		// (get) Token: 0x06004FB6 RID: 20406 RVA: 0x0017F628 File Offset: 0x0017D828
		public List<int> RewardCompleteRate
		{
			get
			{
				return this.Config.m_rewardCompleteRate;
			}
		}

		// Token: 0x17001393 RID: 5011
		// (get) Token: 0x06004FB7 RID: 20407 RVA: 0x0017F638 File Offset: 0x0017D838
		public List<int> RewardDropId
		{
			get
			{
				return this.Config.m_rewardDropId;
			}
		}

		// Token: 0x17001394 RID: 5012
		// (get) Token: 0x06004FB8 RID: 20408 RVA: 0x0017F648 File Offset: 0x0017D848
		public List<CompleteValueDropID> Rewards
		{
			get
			{
				return this.Config.Rewards;
			}
		}

		// Token: 0x17001395 RID: 5013
		// (get) Token: 0x06004FB9 RID: 20409 RVA: 0x0017F658 File Offset: 0x0017D858
		public List<int> RewardWorkSeconds
		{
			get
			{
				return this.Config.m_rewardWorkSeconds;
			}
		}

		// Token: 0x17001396 RID: 5014
		// (get) Token: 0x06004FBA RID: 20410 RVA: 0x0017F668 File Offset: 0x0017D868
		public List<int> RewardDropCount
		{
			get
			{
				return this.Config.m_rewardDropCount;
			}
		}

		// Token: 0x17001397 RID: 5015
		// (get) Token: 0x06004FBB RID: 20411 RVA: 0x0017F678 File Offset: 0x0017D878
		public int RecommendHeroMultiply
		{
			get
			{
				return this.Config.m_general.RecommandHeroMultiply;
			}
		}

		// Token: 0x17001398 RID: 5016
		// (get) Token: 0x06004FBC RID: 20412 RVA: 0x0017F68C File Offset: 0x0017D88C
		public int RecommendHeroAdd
		{
			get
			{
				return this.Config.m_general.RecommandHeroAdd;
			}
		}

		// Token: 0x17001399 RID: 5017
		// (get) Token: 0x06004FBD RID: 20413 RVA: 0x0017F6A0 File Offset: 0x0017D8A0
		public bool Locked
		{
			get
			{
				return this.WhichHeroAssistants.GetLevel() < this.RequiredUserLevel || this.WhichHeroAssistants.Now().DayOfWeek != (DayOfWeek)this.Weekday;
			}
		}

		// Token: 0x1700139A RID: 5018
		// (get) Token: 0x06004FBE RID: 20414 RVA: 0x0017F6F0 File Offset: 0x0017D8F0
		// (set) Token: 0x06004FBF RID: 20415 RVA: 0x0017F6F8 File Offset: 0x0017D8F8
		public IConfigDataLoader ConfigDataLoader { get; set; }

		// Token: 0x1700139B RID: 5019
		// (get) Token: 0x06004FC0 RID: 20416 RVA: 0x0017F704 File Offset: 0x0017D904
		public ConfigDataHeroAssistantTaskInfo Config
		{
			get
			{
				return this.ConfigDataLoader.GetConfigDataHeroAssistantTaskInfo(this.ConfigId);
			}
		}

		// Token: 0x06004FC1 RID: 20417 RVA: 0x0017F718 File Offset: 0x0017D918
		public int GetHeroAssignPoints(Hero H)
		{
			int num = this.WhichHeroAssistants.Compute(H);
			if (this.RecommendHeroIds.Exists((int hid) => hid == H.HeroId))
			{
				num += num * this.RecommendHeroMultiply / 10000 + this.RecommendHeroAdd;
			}
			return num;
		}

		// Token: 0x06004FC2 RID: 20418 RVA: 0x0017F780 File Offset: 0x0017D980
		public int GetHeroAssignPoints(int HeroId)
		{
			Hero h = this.WhichHeroAssistants.Finder(HeroId);
			return this.GetHeroAssignPoints(h);
		}

		// Token: 0x06004FC3 RID: 20419 RVA: 0x0017F7A8 File Offset: 0x0017D9A8
		public int GetHeroAssignPoints(List<Hero> Heroes)
		{
			int num = 0;
			foreach (Hero h in Heroes)
			{
				num += this.GetHeroAssignPoints(h);
			}
			return num;
		}

		// Token: 0x06004FC4 RID: 20420 RVA: 0x0017F808 File Offset: 0x0017DA08
		public int GetHeroAssignPoints(List<int> HeroIds)
		{
			int num = 0;
			foreach (int heroId in HeroIds)
			{
				num += this.GetHeroAssignPoints(heroId);
			}
			return num;
		}

		// Token: 0x040039D1 RID: 14801
		public HeroAssistants WhichHeroAssistants;
	}
}
