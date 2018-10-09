using System;
using System.Collections.Generic;
using System.Diagnostics;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D4D RID: 3405
	public class NormalItemBuyUIController : UIControllerBase
	{
		// Token: 0x0600F9F1 RID: 63985 RVA: 0x0041C2B8 File Offset: 0x0041A4B8
		protected override void OnBindFiledsCompleted()
		{
			base.OnBindFiledsCompleted();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			this.m_playerContext = (GameManager.Instance.PlayerContext as ProjectLPlayerContext);
			this.m_itemBuyPanelCloseButton.onClick.AddListener(new UnityAction(this.OnBGButtonClick));
			this.m_itemBuyButton.onClick.AddListener(new UnityAction(this.OnBuyItemClick));
		}

		// Token: 0x0600F9F2 RID: 63986 RVA: 0x0041C330 File Offset: 0x0041A530
		public void Init(NormalItemBuyUITask normalItemBuyUITask)
		{
			this.m_normalItemBuyUITask = normalItemBuyUITask;
		}

		// Token: 0x0600F9F3 RID: 63987 RVA: 0x0041C33C File Offset: 0x0041A53C
		public void ClosePanel(Action OnCompleteClose)
		{
			UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "Close", OnCompleteClose, false, true);
		}

		// Token: 0x0600F9F4 RID: 63988 RVA: 0x0041C354 File Offset: 0x0041A554
		public void ShowItemBuyPanel(StoreId storeId, int fixedStoreItemId)
		{
			this.SetFiexdStoreItemBuyPanel(storeId, fixedStoreItemId);
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_EnchantStone)
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "ResonanceInfoShow", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x0600F9F5 RID: 63989 RVA: 0x0041C3B0 File Offset: 0x0041A5B0
		public void ShowSelfChooseITemBuyPlane(StoreId storeId, int fixedStoreItemId, int selfChooseIndex)
		{
			this.SetFiexdStoreSelfChooseItemBuyPanel(storeId, fixedStoreItemId, selfChooseIndex);
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_EnchantStone)
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "ResonanceInfoShow", null, false, true);
			}
			else
			{
				UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "Show", null, false, true);
			}
		}

		// Token: 0x0600F9F6 RID: 63990 RVA: 0x0041C40C File Offset: 0x0041A60C
		private void SetFiexdStoreItemBuyPanel(StoreId storeId, int fixedStoreItemId)
		{
			this.m_storeId = storeId;
			this.m_fixedStoreItemId = fixedStoreItemId;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			this.m_itemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId));
			this.m_itemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId));
			this.m_itemNameText.text = UIUtility.GetGoodsName(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId);
			this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(configDataFixedStoreItemInfo.CurrencyType, -1));
			if (configDataFixedStoreItemInfo.CurrencyType == GoodsType.GoodsType_Crystal)
			{
				this.m_itemPriceIconEffectGameObject.SetActive(true);
			}
			this.m_itemPriceText.text = configDataFixedStoreItemInfo.NormalPrice.ToString();
			this.SetEnchantStoneResonanceInfoPanel(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId);
			if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Crystal || configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Gold || configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_ArenaHonour)
			{
				this.m_itemGoodCountObj.SetActive(false);
			}
			else if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Equipment)
			{
				this.m_itemHaveCountText.text = this.m_playerContext.GetBagItemCountByTypeAndID(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			else
			{
				this.m_itemHaveCountText.text = UIUtility.GetGoodsCount(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			this.m_itemDescText.text = UIUtility.GetGoodsDesc(configDataFixedStoreItemInfo.ItemType, configDataFixedStoreItemInfo.ItemId);
			bool flag = UIUtility.GoodTypeHaveID(configDataFixedStoreItemInfo.ItemType);
			if (flag)
			{
				if (Convert.ToInt32(configDataFixedStoreItemInfo.Nums) > 1)
				{
					this.m_itemCountText.text = configDataFixedStoreItemInfo.Nums.ToString();
					this.m_itemCountText.gameObject.SetActive(true);
					this.m_itemCountBgGo.SetActive(true);
				}
				else
				{
					this.m_itemCountText.gameObject.SetActive(false);
					this.m_itemCountBgGo.SetActive(false);
				}
			}
			else
			{
				this.m_itemCountText.gameObject.SetActive(false);
				this.m_itemCountBgGo.SetActive(false);
			}
		}

		// Token: 0x0600F9F7 RID: 63991 RVA: 0x0041C684 File Offset: 0x0041A884
		public void SetFiexdStoreSelfChooseItemBuyPanel(StoreId storeId, int fixedStoreItemId, int selfChooseIndex)
		{
			this.m_storeId = storeId;
			this.m_fixedStoreItemId = fixedStoreItemId;
			this.m_selfChooseIndex = selfChooseIndex;
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			Goods selfChooseGoods = this.GetSelfChooseGoods(fixedStoreItemId, selfChooseIndex);
			this.SetFiexdStoreBuyPanel(selfChooseGoods, configDataFixedStoreItemInfo.CurrencyType, configDataFixedStoreItemInfo.NormalPrice);
		}

		// Token: 0x0600F9F8 RID: 63992 RVA: 0x0041C6D0 File Offset: 0x0041A8D0
		private void SetFiexdStoreBuyPanel(Goods goods, GoodsType currencyType, int price)
		{
			this.m_itemIconImage.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
			this.m_itemIconImage.material = AssetUtility.Instance.GetAsset<Material>(UIUtility.GetGoodsIconMaterialName(goods.GoodsType, goods.Id));
			this.m_itemNameText.text = UIUtility.GetGoodsName(goods.GoodsType, goods.Id);
			this.m_itemPriceIcon.sprite = AssetUtility.Instance.GetSprite(UIUtility.GetGoodsIconName(currencyType, -1));
			if (currencyType == GoodsType.GoodsType_Crystal)
			{
				this.m_itemPriceIconEffectGameObject.SetActive(true);
			}
			this.m_itemPriceText.text = price.ToString();
			this.SetEnchantStoneResonanceInfoPanel(goods.GoodsType, goods.Id);
			if (goods.GoodsType == GoodsType.GoodsType_Crystal || goods.GoodsType == GoodsType.GoodsType_Gold || goods.GoodsType == GoodsType.GoodsType_ArenaHonour)
			{
				this.m_itemGoodCountObj.SetActive(false);
			}
			else if (goods.GoodsType == GoodsType.GoodsType_Equipment)
			{
				this.m_itemHaveCountText.text = this.m_playerContext.GetBagItemCountByTypeAndID(goods.GoodsType, goods.Id).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			else
			{
				this.m_itemHaveCountText.text = UIUtility.GetGoodsCount(goods.GoodsType, goods.Id).ToString();
				this.m_itemGoodCountObj.SetActive(true);
			}
			this.m_itemDescText.text = UIUtility.GetGoodsDesc(goods.GoodsType, goods.Id);
			this.m_itemCountText.gameObject.SetActive(false);
			this.m_itemCountBgGo.SetActive(false);
			bool flag = UIUtility.GoodTypeHaveID(goods.GoodsType);
			if (flag && Convert.ToInt32(goods.Count) > 1)
			{
				this.m_itemCountText.text = goods.Count.ToString();
				this.m_itemCountText.gameObject.SetActive(true);
				this.m_itemCountBgGo.SetActive(true);
			}
		}

		// Token: 0x0600F9F9 RID: 63993 RVA: 0x0041C8F0 File Offset: 0x0041AAF0
		protected void SetEnchantStoneResonanceInfoPanel(GoodsType goodsType, int goodsID)
		{
			if (goodsType == GoodsType.GoodsType_EnchantStone)
			{
				ConfigDataEnchantStoneInfo configDataEnchantStoneInfo = this.m_configDataLoader.GetConfigDataEnchantStoneInfo(goodsID);
				if (configDataEnchantStoneInfo != null)
				{
					ConfigDataResonanceInfo configDataResonanceInfo = this.m_configDataLoader.GetConfigDataResonanceInfo(configDataEnchantStoneInfo.Resonance_ID);
					this.m_resonanceInfoPanelNameText.text = configDataResonanceInfo.Name;
					ConfigDataSkillInfo configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect1);
					this.m_resonanceInfoPanel2SuitInfoText.text = configDataSkillInfo.Desc;
					configDataSkillInfo = this.m_configDataLoader.GetConfigDataSkillInfo(configDataResonanceInfo.Effect2);
					this.m_resonanceInfoPanel4SuitInfoText.text = configDataSkillInfo.Desc;
				}
			}
			this.m_resonanceInfoPanel.SetActive(false);
		}

		// Token: 0x0600F9FA RID: 63994 RVA: 0x0041C990 File Offset: 0x0041AB90
		private void HandleBoxOpenNetTask(GoodsType type, int id, int count, Action<List<Goods>> successedCallback, Action failedCallback)
		{
			BagItemUseNetTask bagItemUseNetTask = new BagItemUseNetTask(type, id, count);
			bagItemUseNetTask.EventOnStop += delegate(Task task)
			{
				BagItemUseNetTask bagItemUseNetTask2 = task as BagItemUseNetTask;
				if (bagItemUseNetTask2.Result == 0)
				{
					if (successedCallback != null)
					{
						successedCallback(bagItemUseNetTask2.Reward);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemUseNetTask2.Result, 2f, null, true);
					if (failedCallback != null)
					{
						failedCallback();
					}
				}
			};
			bagItemUseNetTask.Start(null);
		}

		// Token: 0x0600F9FB RID: 63995 RVA: 0x0041C9D8 File Offset: 0x0041ABD8
		private List<Goods> GetStoreGoods(int fixedStoreItemId, int selfChooseIndex)
		{
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			List<Goods> list = new List<Goods>();
			if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Item)
			{
				ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
				if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_SelfSelectedBox)
				{
					Goods selfChooseGoods = this.GetSelfChooseGoods(fixedStoreItemId, selfChooseIndex);
					list.Add(selfChooseGoods);
					return list;
				}
			}
			list.Add(new Goods
			{
				GoodsType = configDataFixedStoreItemInfo.ItemType,
				Id = configDataFixedStoreItemInfo.ItemId,
				Count = configDataFixedStoreItemInfo.Nums
			});
			return list;
		}

		// Token: 0x0600F9FC RID: 63996 RVA: 0x0041CA6C File Offset: 0x0041AC6C
		private Goods GetSelfChooseGoods(int fixedStoreItemId, int selfChooseIndex)
		{
			ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemId);
			ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
			ConfigDataSelfSelectedBoxInfo configDataSelfSelectedBoxInfo = this.m_configDataLoader.GetConfigDataSelfSelectedBoxInfo(configDataItemInfo.FuncTypeParam1);
			return configDataSelfSelectedBoxInfo.Reward[selfChooseIndex];
		}

		// Token: 0x0600F9FD RID: 63997 RVA: 0x0041CAB8 File Offset: 0x0041ACB8
		private void StoreUIController_CrystalNotEnough()
		{
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok)
				{
				}
			}, (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x0600F9FE RID: 63998 RVA: 0x0041CAE8 File Offset: 0x0041ACE8
		public void OnBGButtonClick()
		{
			if (this.m_normalItemBuyUITask.IsSelfChoosePlaneActive())
			{
				base.gameObject.SetActive(false);
				return;
			}
			UIUtility.SetUIStateOpen(this.m_itemBuyPanelUIStateController, "Close", delegate
			{
				this.m_normalItemBuyUITask.Stop();
			}, false, true);
		}

		// Token: 0x0600F9FF RID: 63999 RVA: 0x0041CB28 File Offset: 0x0041AD28
		public void OnBuyItemClick()
		{
			int num = this.m_playerContext.CanBuyFixedStoreGoods((int)this.m_storeId, this.m_fixedStoreItemId, this.m_selfChooseIndex);
			if (num == 0)
			{
				FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask = new FixedStoreBuyStoreItemNetTask((int)this.m_storeId, this.m_fixedStoreItemId, this.m_selfChooseIndex);
				fixedStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask2 = task as FixedStoreBuyStoreItemNetTask;
					if (fixedStoreBuyStoreItemNetTask2.Result == 0)
					{
						ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = this.m_configDataLoader.GetConfigDataFixedStoreItemInfo(this.m_fixedStoreItemId);
						ConfigDataItemInfo configDataItemInfo = this.m_configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
						if (configDataItemInfo != null && (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox || configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_RandomBox))
						{
							this.HandleBoxOpenNetTask(GoodsType.GoodsType_Item, configDataFixedStoreItemInfo.ItemId, 1, delegate(List<Goods> goods)
							{
								GetRewardGoodsUITask.StartUITask(goods);
								if (this.EventOnBuySuccess != null)
								{
									this.EventOnBuySuccess();
								}
							}, delegate
							{
							});
						}
						else
						{
							List<Goods> storeGoods = this.GetStoreGoods(this.m_fixedStoreItemId, this.m_selfChooseIndex);
							GetRewardGoodsUITask.StartUITask(storeGoods);
							if (this.EventOnBuySuccess != null)
							{
								this.EventOnBuySuccess();
							}
						}
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(fixedStoreBuyStoreItemNetTask2.Result, 2f, null, true);
					}
				};
				fixedStoreBuyStoreItemNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_normalItemBuyUITask.CurrentIntent);
			}
			else if (num == -401)
			{
				this.StoreUIController_CrystalNotEnough();
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x1400034B RID: 843
		// (add) Token: 0x0600FA00 RID: 64000 RVA: 0x0041CBD8 File Offset: 0x0041ADD8
		// (remove) Token: 0x0600FA01 RID: 64001 RVA: 0x0041CC10 File Offset: 0x0041AE10
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public event Action EventOnBuySuccess;

		// Token: 0x040092B0 RID: 37552
		[AutoBind(".", AutoBindAttribute.InitState.NotInit, false)]
		private CommonUIStateController m_itemBuyPanelUIStateController;

		// Token: 0x040092B1 RID: 37553
		[AutoBind("./LayoutRoot/ItemGoodsDesc/Item/IconImage", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_itemIconImage;

		// Token: 0x040092B2 RID: 37554
		[AutoBind("./LayoutRoot/ItemGoodsDesc/Item/CountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemCountText;

		// Token: 0x040092B3 RID: 37555
		[AutoBind("./LayoutRoot/ItemGoodsDesc/Item/Image", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemCountBgGo;

		// Token: 0x040092B4 RID: 37556
		[AutoBind("./LayoutRoot/ItemGoodsDesc/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemNameText;

		// Token: 0x040092B5 RID: 37557
		[AutoBind("./LayoutRoot/ItemGoodsDesc/GoodCount", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemGoodCountObj;

		// Token: 0x040092B6 RID: 37558
		[AutoBind("./LayoutRoot/ItemGoodsDesc/GoodCount/HaveCountText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemHaveCountText;

		// Token: 0x040092B7 RID: 37559
		[AutoBind("./LayoutRoot/ItemGoodsDesc/DescPanel/DescText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemDescText;

		// Token: 0x040092B8 RID: 37560
		[AutoBind("./LayoutRoot/BuyPanel/Group/PriceIcon/PriceIcon", AutoBindAttribute.InitState.NotInit, false)]
		private Image m_itemPriceIcon;

		// Token: 0x040092B9 RID: 37561
		[AutoBind("./LayoutRoot/BuyPanel/Group/PriceIcon/PriceIcon/U_crystal", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_itemPriceIconEffectGameObject;

		// Token: 0x040092BA RID: 37562
		[AutoBind("./LayoutRoot/BuyPanel/Group/PriceText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_itemPriceText;

		// Token: 0x040092BB RID: 37563
		[AutoBind("./BGButton", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemBuyPanelCloseButton;

		// Token: 0x040092BC RID: 37564
		[AutoBind("./LayoutRoot/BuyPanel", AutoBindAttribute.InitState.NotInit, false)]
		private Button m_itemBuyButton;

		// Token: 0x040092BD RID: 37565
		[AutoBind("./ResonanceInfoPanel", AutoBindAttribute.InitState.NotInit, false)]
		private GameObject m_resonanceInfoPanel;

		// Token: 0x040092BE RID: 37566
		[AutoBind("./ResonanceInfoPanel/NameText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanelNameText;

		// Token: 0x040092BF RID: 37567
		[AutoBind("./ResonanceInfoPanel/SuitInfo/2SuitInfo/2SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanel2SuitInfoText;

		// Token: 0x040092C0 RID: 37568
		[AutoBind("./ResonanceInfoPanel/SuitInfo/4SuitInfo/4SuitInfoText", AutoBindAttribute.InitState.NotInit, false)]
		private Text m_resonanceInfoPanel4SuitInfoText;

		// Token: 0x040092C1 RID: 37569
		private ProjectLPlayerContext m_playerContext;

		// Token: 0x040092C2 RID: 37570
		private IConfigDataLoader m_configDataLoader;

		// Token: 0x040092C3 RID: 37571
		private NormalItemBuyUITask m_normalItemBuyUITask;

		// Token: 0x040092C4 RID: 37572
		private StoreId m_storeId;

		// Token: 0x040092C5 RID: 37573
		private int m_fixedStoreItemId;

		// Token: 0x040092C6 RID: 37574
		private int m_selfChooseIndex = -1;
	}
}
