using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D46 RID: 3398
	public class GuildStoreUIController : UIControllerBase
	{
		// Token: 0x0600F98F RID: 63887 RVA: 0x0041B3D8 File Offset: 0x004195D8
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_closeButton.onClick.AddListener(new UnityAction(this.OnCloseClick));
			this.m_currencyUIController = GameObjectUtility.AddControllerToGameObject<CurrencyUIController>(this.m_playerCurrencyNode);
			this.m_currencyUIController.EventOnAddButtonClick += this.OnAddCurrencyClick;
			this.m_guildFixedStoreUIComponent = new GuildFixedStoreUIComponent();
			this.m_guildFixedStoreUIComponent.Init(this.m_storeItem, this.m_storeItemContent, this.m_currencyUIController);
			this.m_guildFixedStoreUIComponent.SetFixedStoreInfo(StoreId.StoreId_GuildPerson);
		}

		// Token: 0x0600F990 RID: 63888 RVA: 0x0041B490 File Offset: 0x00419690
		public void Init(GuildStoreUITask guildStoreUITask)
		{
			this.m_guildStoreUITask = guildStoreUITask;
		}

		// Token: 0x0600F991 RID: 63889 RVA: 0x0041B49C File Offset: 0x0041969C
		private void OnCloseClick()
		{
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				this.m_guildStoreUITask.ReturnLastScene();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F992 RID: 63890 RVA: 0x0041B4C0 File Offset: 0x004196C0
		public void OnAddCurrencyClick(GoodsType currencyType)
		{
			if (currencyType != GoodsType.GoodsType_Gold)
			{
				if (currencyType == GoodsType.GoodsType_Crystal)
				{
					StoreUITask.StartUITask(this.m_guildStoreUITask.CurrentIntent, StoreId.StoreId_Recharge, null, false);
				}
			}
			else
			{
				StoreUITask.StartUITask(this.m_guildStoreUITask.CurrentIntent, StoreId.StoreId_Crystal, null, false);
			}
		}

		// Token: 0x0600F993 RID: 63891 RVA: 0x0041B524 File Offset: 0x00419724
		private void OnBuyItemSuccess()
		{
		}

		// Token: 0x04009287 RID: 37511
		[AutoBind("./StoreUIPanel/CloseBtn", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_closeButton;

		// Token: 0x04009288 RID: 37512
		[AutoBind("./StoreUIPanel/UnderItemList/StoreList/ListScrollView/Viewport/Content", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storeItemContent;

		// Token: 0x04009289 RID: 37513
		[AutoBind("./Prefab/StoreItem", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_storeItem;

		// Token: 0x0400928A RID: 37514
		[AutoBind("./StoreUIPanel/PlayerResource", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_playerCurrencyNode;

		// Token: 0x0400928B RID: 37515
		private GuildStoreUITask m_guildStoreUITask;

		// Token: 0x0400928C RID: 37516
		private CurrencyUIController m_currencyUIController;

		// Token: 0x0400928D RID: 37517
		private GuildFixedStoreUIComponent m_guildFixedStoreUIComponent;

		// Token: 0x0400928E RID: 37518
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x0400928F RID: 37519
		private IConfigDataLoader m_configDataLoader;
	}
}
