using System;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D47 RID: 3399
	public class GuildFixedStoreUIComponent
	{
		// Token: 0x0600F996 RID: 63894 RVA: 0x0041B548 File Offset: 0x00419748
		public void Init(GameObject itemPrefab, GameObject itemContent, CurrencyUIController currencyUIController)
		{
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_fixedStoreItemPool = new GameObjectPool<StoreItemUIController>();
			this.m_fixedStoreItemPool.Setup(itemPrefab, itemContent);
			this.m_itemPrefab = itemPrefab;
			this.m_content = itemContent;
			this.m_currencyUIController = currencyUIController;
		}

		// Token: 0x0600F997 RID: 63895 RVA: 0x0041B5AC File Offset: 0x004197AC
		public void SetFixedStoreInfo(StoreId fixedStoreID)
		{
			List<FixedStoreItem> fixedStoreItemList = this.m_playerContext.GetFixedStoreItemList((int)fixedStoreID);
			if (fixedStoreItemList == null)
			{
				return;
			}
			this.m_fixedStoreId = fixedStoreID;
			List<GoodsType> list = new List<GoodsType>();
			foreach (FixedStoreItem fixedStoreItemInfo in fixedStoreItemList)
			{
				bool flag;
				StoreItemUIController ctrl = this.m_fixedStoreItemPool.Allocate(out flag);
				if (ctrl != null)
				{
					if (flag)
					{
						ctrl.EventOnClick += this.OnStoreItemClick;
					}
					ctrl.SetFixedStoreItemInfo(fixedStoreItemInfo);
					if (ctrl.m_extraCurrencyType != GoodsType.GoodsType_None && list.Find((GoodsType item) => item == ctrl.m_extraCurrencyType) == GoodsType.GoodsType_None)
					{
						list.Add(ctrl.m_extraCurrencyType);
					}
				}
			}
			this.SetCurrencyState(list);
		}

		// Token: 0x0600F998 RID: 63896 RVA: 0x0041B6B8 File Offset: 0x004198B8
		private void SetCurrencyState(List<GoodsType> currencyList)
		{
			for (int i = 0; i < currencyList.Count; i++)
			{
				this.m_currencyUIController.RefreshCurrencyDisplay(2 - i, currencyList[i]);
			}
		}

		// Token: 0x0600F999 RID: 63897 RVA: 0x0041B6F4 File Offset: 0x004198F4
		public void ClearFiexdStoreItem()
		{
			this.m_fixedStoreItemPool.Deactive();
		}

		// Token: 0x0600F99A RID: 63898 RVA: 0x0041B704 File Offset: 0x00419904
		public void OnStoreItemClick(StoreItemUIController ctrl)
		{
			NormalItemBuyUITask normalItemBuyUITask = NormalItemBuyUITask.StartUITask(this.m_fixedStoreId, ctrl.m_fixedStoreItemGoodsID);
			normalItemBuyUITask.EventOnBuySuccess += this.OnBuyItemSuccess;
		}

		// Token: 0x0600F99B RID: 63899 RVA: 0x0041B738 File Offset: 0x00419938
		private void OnBuyItemSuccess()
		{
			if (this.EventOnBuyItemSuccess != null)
			{
				this.EventOnBuyItemSuccess();
			}
			this.ClearFiexdStoreItem();
			this.SetFixedStoreInfo(this.m_fixedStoreId);
		}

		// Token: 0x1400034A RID: 842
		// (add) Token: 0x0600F99C RID: 63900 RVA: 0x0041B764 File Offset: 0x00419964
		// (remove) Token: 0x0600F99D RID: 63901 RVA: 0x0041B79C File Offset: 0x0041999C
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action EventOnBuyItemSuccess;

		// Token: 0x04009291 RID: 37521
		private StoreId m_fixedStoreId;

		// Token: 0x04009292 RID: 37522
		private GameObject m_itemPrefab;

		// Token: 0x04009293 RID: 37523
		private GameObject m_content;

		// Token: 0x04009294 RID: 37524
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x04009295 RID: 37525
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x04009296 RID: 37526
		private CurrencyUIController m_currencyUIController;

		// Token: 0x04009297 RID: 37527
		private GameObjectPool<StoreItemUIController> m_fixedStoreItemPool;
	}
}
