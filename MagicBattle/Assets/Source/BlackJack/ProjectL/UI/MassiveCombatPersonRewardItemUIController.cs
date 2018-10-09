using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D17 RID: 3351
	public class MassiveCombatPersonRewardItemUIController : UIControllerBase
	{
		// Token: 0x0600F69A RID: 63130 RVA: 0x004133A4 File Offset: 0x004115A4
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
		}

		// Token: 0x0600F69B RID: 63131 RVA: 0x004133D8 File Offset: 0x004115D8
		public void Init(ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo rewardInfo)
		{
			this.m_rewardInfo = rewardInfo;
			this.m_integralText.text = rewardInfo.Points.ToString();
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.m_playerContext.GetGuildPlayerMassiveCombatInfo();
			if (rewardInfo.Points < guildPlayerMassiveCombatInfo.Points)
			{
				this.m_itemAnimation.SetToUIState("Got", false, true);
			}
			GameObject prefab = this.m_resourceContainer.GetAsset("RewardGoods") as GameObject;
			RewardGoodsUIController.CreateRewardGoodsList(rewardInfo.RewardItems, this.m_rewardContent.transform, prefab, null, true, 0, true);
		}

		// Token: 0x0600F69C RID: 63132 RVA: 0x0041346C File Offset: 0x0041166C
		public void Refresh()
		{
			GuildPlayerMassiveCombatInfo guildPlayerMassiveCombatInfo = this.m_playerContext.GetGuildPlayerMassiveCombatInfo();
			if (this.m_rewardInfo.Points < guildPlayerMassiveCombatInfo.Points)
			{
				this.m_itemAnimation.SetToUIState("Got", false, true);
			}
		}

		// Token: 0x04009197 RID: 37271
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_itemAnimation;

		// Token: 0x04009198 RID: 37272
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private PrefabResourceContainer m_resourceContainer;

		// Token: 0x04009199 RID: 37273
		[AutoBind("./TargeTitleText/ValueText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_integralText;

		// Token: 0x0400919A RID: 37274
		[AutoBind("./RewardGroup", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_rewardContent;

		// Token: 0x0400919B RID: 37275
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400919C RID: 37276
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400919D RID: 37277
		private ConfigDataGuildMassiveCombatIndividualPointsRewardsInfo m_rewardInfo;
	}
}
