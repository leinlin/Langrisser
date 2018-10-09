using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F3A RID: 3898
	public class StoreSelfChooseUIController : UIControllerBase
	{
		// Token: 0x06013694 RID: 79508 RVA: 0x004F256C File Offset: 0x004F076C
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBgClick));
		}

		// Token: 0x06013695 RID: 79509 RVA: 0x004F25A8 File Offset: 0x004F07A8
		public void Init(StoreListUIController storeListUIController)
		{
			this.m_storeListUIController = storeListUIController;
			this.m_storeListUIController.EventOnFixedStoreItemBuyClick += this.OnFixedStoreItemBuyClick;
		}

		// Token: 0x06013696 RID: 79510 RVA: 0x004F25C8 File Offset: 0x004F07C8
		public void SetSelfChooseItemID(StoreId storeID, StoreItemUIController storeItemUIController)
		{
			UIUtility.SetUIStateOpen(this.m_uiStateController, "Show", null, false, true);
			foreach (GoodsUIController goodsUIController in this.m_goodUIController)
			{
				UnityEngine.Object.Destroy(goodsUIController.gameObject);
			}
			this.m_goodUIController.Clear();
			this.m_storeItemUIController = storeItemUIController;
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(storeItemUIController.m_goodsID);
			ConfigDataSelfSelectedBoxInfo configDataSelfSelectedBoxInfo = this.m_configDataLoader.GetConfigDataSelfSelectedBoxInfo(configDataItemInfo.FuncTypeParam1);
			foreach (Goods g in configDataSelfSelectedBoxInfo.Reward)
			{
				GoodsUIController item = GoodsUIController.CreateRewardGoods(g, this.m_content, this.m_itemTemplate, true, new Action<GoodsUIController>(this.OnGoodsClick));
				this.m_goodUIController.Add(item);
			}
		}

		// Token: 0x06013697 RID: 79511 RVA: 0x004F26E8 File Offset: 0x004F08E8
		private void OnBgClick()
		{
			this.m_storeListUIController.m_selfChooseItemIndex = -1;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
		}

		// Token: 0x06013698 RID: 79512 RVA: 0x004F270C File Offset: 0x004F090C
		private void OnGoodsClick(GoodsUIController goodsUIController)
		{
			int selfChooseItemIndex = -1;
			for (int i = 0; i < this.m_goodUIController.Count; i++)
			{
				if (this.m_goodUIController[i] == goodsUIController)
				{
					selfChooseItemIndex = i;
					break;
				}
			}
			this.m_storeListUIController.m_selfChooseItemIndex = selfChooseItemIndex;
			this.m_storeListUIController.SetNormalItemBuyPanel(goodsUIController.m_goods, this.m_storeItemUIController);
		}

		// Token: 0x06013699 RID: 79513 RVA: 0x004F2778 File Offset: 0x004F0978
		private void OnFixedStoreItemBuyClick(StoreId fixedStoreID, int fixedStoreItemGoodsID, int goodsID, int selfChooseItemIndex, List<Goods> gainGoodsList)
		{
			this.m_storeListUIController.m_selfChooseItemIndex = -1;
			UIUtility.SetUIStateClose(this.m_uiStateController, "Close", null, false, true);
		}

		// Token: 0x0400AC6E RID: 44142
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x0400AC6F RID: 44143
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x0400AC70 RID: 44144
		[AutoBind("./LayoutRoot/Prefab/Item", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemTemplate;

		// Token: 0x0400AC71 RID: 44145
		[AutoBind("./LayoutRoot/ListScrollView /Mask/Content", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_content;

		// Token: 0x0400AC72 RID: 44146
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x0400AC73 RID: 44147
		private List<GoodsUIController> m_goodUIController = new List<GoodsUIController>();

		// Token: 0x0400AC74 RID: 44148
		private StoreListUIController m_storeListUIController;

		// Token: 0x0400AC75 RID: 44149
		private StoreItemUIController m_storeItemUIController;
	}
}
