using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CE9 RID: 3305
	public class GuildContributionUIController : UIControllerBase
	{
		// Token: 0x0600F1BD RID: 61885 RVA: 0x0040383C File Offset: 0x00401A3C
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseClick));
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBgClick));
			for (int i = 0; i < this.m_rankingInfinityGrid.MinAmount; i++)
			{
				GameObject go = GameObjectUtility.CloneGameObject(this.m_contributionRankingItemPrefab, this.m_rankingInfinityGrid.transform);
				GuildContributionRankingItemUIController guildContributionRankingItemUIController = GameObjectUtility.AddControllerToGameObject<GuildContributionRankingItemUIController>(go);
			}
			InfinityGridLayoutGroup rankingInfinityGrid = this.m_rankingInfinityGrid;
			rankingInfinityGrid.updateChildrenCallback = (InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate)Delegate.Combine(rankingInfinityGrid.updateChildrenCallback, new InfinityGridLayoutGroup.UpdateChildrenCallbackDelegate(this.OnItemUpdate));
			GuildMassiveCombatInfo currentGuildMassiveCombatInfo = this.m_playerContext.GetCurrentGuildMassiveCombatInfo();
			this.m_guildMassiveCombatMemberList = currentGuildMassiveCombatInfo.Members;
			this.m_guildMassiveCombatMemberList.Sort(new Comparison<GuildMassiveCombatMemberInfo>(this.RankCompare));
		}

		// Token: 0x0600F1BE RID: 61886 RVA: 0x00403944 File Offset: 0x00401B44
		private void OnEnable()
		{
			this.Refresh();
		}

		// Token: 0x0600F1BF RID: 61887 RVA: 0x0040394C File Offset: 0x00401B4C
		private void Refresh()
		{
			this.m_rankingInfinityGrid.SetAmount(this.m_guildMassiveCombatMemberList.Count);
			this.m_guildMassiveCombatMemberList.Sort(new Comparison<GuildMassiveCombatMemberInfo>(this.RankCompare));
		}

		// Token: 0x0600F1C0 RID: 61888 RVA: 0x0040397C File Offset: 0x00401B7C
		private int RankCompare(GuildMassiveCombatMemberInfo left, GuildMassiveCombatMemberInfo right)
		{
			int num = right.Points - left.Points;
			if (num != 0)
			{
				return num;
			}
			return right.PointsToday - left.PointsToday;
		}

		// Token: 0x0600F1C1 RID: 61889 RVA: 0x004039B0 File Offset: 0x00401BB0
		public void OnItemUpdate(int index, Transform trans)
		{
			GuildContributionRankingItemUIController component = trans.GetComponent<GuildContributionRankingItemUIController>();
			component.SetData(this.m_guildMassiveCombatMemberList[index], index + 1);
		}

		// Token: 0x0600F1C2 RID: 61890 RVA: 0x004039DC File Offset: 0x00401BDC
		public void OnCloseClick()
		{
			UIUtility.SetUIStateClose(this.m_contributionPanelAnimation, "Close", null, false, true);
		}

		// Token: 0x0600F1C3 RID: 61891 RVA: 0x004039F4 File Offset: 0x00401BF4
		public void OnBgClick()
		{
			UIUtility.SetUIStateClose(this.m_contributionPanelAnimation, "Close", null, false, true);
		}

		// Token: 0x04008F91 RID: 36753
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_contributionPanelAnimation;

		// Token: 0x04008F92 RID: 36754
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x04008F93 RID: 36755
		[AutoBind("./Detail/ScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private InfinityGridLayoutGroup m_rankingInfinityGrid;

		// Token: 0x04008F94 RID: 36756
		[AutoBind("./Detail/Prefab/ContributionRankingListItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_contributionRankingItemPrefab;

		// Token: 0x04008F95 RID: 36757
		[AutoBind("./Detail/CloseButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x04008F96 RID: 36758
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04008F97 RID: 36759
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04008F98 RID: 36760
		private List<GuildMassiveCombatMemberInfo> m_guildMassiveCombatMemberList;
	}
}
