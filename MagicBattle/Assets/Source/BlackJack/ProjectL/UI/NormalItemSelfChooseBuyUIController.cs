using System;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D50 RID: 3408
	public class NormalItemSelfChooseBuyUIController : UIControllerBase
	{
		// Token: 0x0600FA19 RID: 64025 RVA: 0x0041D250 File Offset: 0x0041B450
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_bgButton.onClick.AddListener(new UnityAction(this.OnBGButtonClick));
		}

		// Token: 0x0600FA1A RID: 64026 RVA: 0x0041D2AC File Offset: 0x0041B4AC
		public void Init(NormalItemBuyUITask normalItemBuyUITask)
		{
			this.m_normalItemBuyUITask = normalItemBuyUITask;
		}

		// Token: 0x0600FA1B RID: 64027 RVA: 0x0041D2B8 File Offset: 0x0041B4B8
		public void SetSelfChooseItemBuyPlane(StoreId storeId, int fixedStoreItemId)
		{
			this.m_storeId = storeId;
			this.m_fixedStoreItemId = fixedStoreItemId;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
			ConfigDataSelfSelectedBoxInfo configDataSelfSelectedBoxInfo = this.m_configDataLoader.GetConfigDataSelfSelectedBoxInfo(configDataItemInfo.FuncTypeParam1);
			foreach (Goods g in configDataSelfSelectedBoxInfo.Reward)
			{
				GoodsUIController item = GoodsUIController.CreateRewardGoods(g, this.m_content, this.m_itemTemplate, true, new Action<GoodsUIController>(this.OnGoodsClick));
				this.m_goodUIControllerList.Add(item);
			}
		}

		// Token: 0x0600FA1C RID: 64028 RVA: 0x0041D37C File Offset: 0x0041B57C
		private void OnGoodsClick(GoodsUIController goodsUIController)
		{
			int arg = -1;
			for (int i = 0; i < this.m_goodUIControllerList.Count; i++)
			{
				if (this.m_goodUIControllerList[i] == goodsUIController)
				{
					arg = i;
					break;
				}
			}
			if (this.EventOnSelfBoxChoose != null)
			{
				this.EventOnSelfBoxChoose(this.m_storeId, this.m_fixedStoreItemId, arg);
			}
		}

		// Token: 0x0600FA1D RID: 64029 RVA: 0x0041D3E8 File Offset: 0x0041B5E8
		public void OnBGButtonClick()
		{
			this.m_normalItemBuyUITask.Stop();
		}

		// Token: 0x1400034D RID: 845
		// (add) Token: 0x0600FA1E RID: 64030 RVA: 0x0041D3F8 File Offset: 0x0041B5F8
		// (remove) Token: 0x0600FA1F RID: 64031 RVA: 0x0041D430 File Offset: 0x0041B630
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action<StoreId, int, int> EventOnSelfBoxChoose;

		// Token: 0x040092D4 RID: 37588
		[AutoBind("./", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_uiStateController;

		// Token: 0x040092D5 RID: 37589
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_bgButton;

		// Token: 0x040092D6 RID: 37590
		[AutoBind("./LayoutRoot/Prefab/Item", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemTemplate;

		// Token: 0x040092D7 RID: 37591
		[AutoBind("./LayoutRoot/ListScrollView /Mask/Content", AutoBindAttribute.InitState.NotInit, false)]
		private Transform m_content;

		// Token: 0x040092D8 RID: 37592
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040092D9 RID: 37593
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040092DA RID: 37594
		private List<GoodsUIController> m_goodUIControllerList = new List<GoodsUIController>();

		// Token: 0x040092DB RID: 37595
		private NormalItemBuyUIController m_normalItemBuyUIController;

		// Token: 0x040092DC RID: 37596
		private NormalItemBuyUITask m_normalItemBuyUITask;

		// Token: 0x040092DD RID: 37597
		private StoreId m_storeId;

		// Token: 0x040092DE RID: 37598
		private int m_fixedStoreItemId;
	}
}
