using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using BlackJack.UtilityTools;
using PD.SDK;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000F44 RID: 3908
	[HotFix]
	public class StoreUITask : UITask
	{
		// Token: 0x0601376A RID: 79722 RVA: 0x004F5550 File Offset: 0x004F3750
		public StoreUITask(string name) : base(name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0601376B RID: 79723 RVA: 0x004F566C File Offset: 0x004F386C
		public static void StartUITask(UIIntent fromIntent, StoreId storeId, int? itemId = null, bool isNeedOpenMemoryExtractionPanel = false)
		{
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				if (fromIntent != null)
				{
					UITaskBase uitaskBase = UIManager.Instance.FindUITaskWithName(fromIntent.TargetTaskName);
					if (uitaskBase != null)
					{
						uitaskBase.Pause();
					}
				}
				UIIntentReturnable uiintentReturnable = new UIIntentReturnable(fromIntent, typeof(StoreUITask).Name, null);
				uiintentReturnable.SetParam("StoreInfoID", (int)storeId);
				if (itemId != null)
				{
					uiintentReturnable.SetParam("StoreItemId", itemId.Value);
				}
				if (isNeedOpenMemoryExtractionPanel)
				{
					uiintentReturnable.SetParam("IsShowExtractionPanel", isNeedOpenMemoryExtractionPanel);
				}
				UIManager instance = UIManager.Instance;
				UIIntent intent = uiintentReturnable;
				bool pushIntentToStack = true;
				bool clearIntentStack = false;
				if (StoreUITask.<>f__mg$cache0 == null)
				{
					StoreUITask.<>f__mg$cache0 = new Action(StoreUITask.StoreUIUITask_OnLoadAllResCompleted);
				}
				instance.StartUITask(intent, pushIntentToStack, clearIntentStack, StoreUITask.<>f__mg$cache0);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0601376C RID: 79724 RVA: 0x004F56BC File Offset: 0x004F38BC
		public static void SpecialStartStoreUITask(UIIntent uiIntent, StoreId storeId)
		{
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(StoreUITask));
			if (uitaskBase != null && uitaskBase.State == Task.TaskState.Running)
			{
				UIIntentCustom uiintentCustom = uitaskBase.CurrentIntent as UIIntentCustom;
				uiintentCustom.SetParam("StoreInfoID", (int)storeId);
				UIManager instance = UIManager.Instance;
				UIIntent intent = uiintentCustom;
				bool pushIntentToStack = true;
				bool clearIntentStack = false;
				if (StoreUITask.<>f__mg$cache1 == null)
				{
					StoreUITask.<>f__mg$cache1 = new Action(StoreUITask.StoreUIUITask_OnLoadAllResCompleted);
				}
				instance.StartUITask(intent, pushIntentToStack, clearIntentStack, StoreUITask.<>f__mg$cache1);
			}
			else
			{
				StoreUITask.StartUITask(uiIntent, storeId, null, false);
			}
		}

		// Token: 0x0601376D RID: 79725 RVA: 0x004F574C File Offset: 0x004F394C
		public static void StoreUIUITask_OnLoadAllResCompleted()
		{
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(StoreUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0601376E RID: 79726 RVA: 0x004F5780 File Offset: 0x004F3980
		public static void PDSDKRequestBuyGoods(string goodID, PDSDKGoodType goodType, int number)
		{
			if (number < 1)
			{
				global::Debug.LogError(string.Format("StoreUITask.PDSDKRequestBuyGoods number={0} is less than 1.", number));
				return;
			}
			List<PDSDKGood> list = StoreUITask.m_pdsdkGoods.FindAll((PDSDKGood g) => g.m_ID == goodID && g.m_type == goodType);
			if (list.Count == 0)
			{
				global::Debug.LogError(string.Format("StoreUITask.PDSDKRequestBuyGoods failed to find goodid={0} goodtype={1}", goodID, goodType));
				return;
			}
			if (list.Count > 1)
			{
				global::Debug.LogError(string.Format("StoreUITask.PDSDKRequestBuyGoods more than 1 good with goodid={0} goodtype={1}", goodID, goodType));
				return;
			}
			PDSDKGood pdsdkgood = list[0];
			PDSDK.Instance.DoPay(pdsdkgood.m_name, number, pdsdkgood.m_ID, pdsdkgood.m_registerID, pdsdkgood.m_price, string.Empty, pdsdkgood.m_desc);
		}

		// Token: 0x0601376F RID: 79727 RVA: 0x004F586C File Offset: 0x004F3A6C
		public static List<PDSDKGood> PDSDKGetGoods()
		{
			return StoreUITask.m_pdsdkGoods;
		}

		// Token: 0x06013770 RID: 79728 RVA: 0x004F5874 File Offset: 0x004F3A74
		public static void PDSDKRequestGoods()
		{
			if (PDSDK.Instance != null && PDSDK.IsInit && PDSDK.IsLogin)
			{
				if (StoreUITask.<>f__mg$cache2 == null)
				{
					StoreUITask.<>f__mg$cache2 = new Action<bool>(StoreUITask.OnPDSDKReqGoodsAck);
				}
				PDSDK.m_eventOnGetProductsListAck = StoreUITask.<>f__mg$cache2;
				PDSDK.Instance.GetProductsList();
			}
			else
			{
				global::Debug.LogError("StoreUITask.PDSDKRequestGoods pdsdk is not ready yet.");
			}
		}

		// Token: 0x06013771 RID: 79729 RVA: 0x004F58E0 File Offset: 0x004F3AE0
		public void OnPDSDKPayCancel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPDSDKPayCancel_hotfix != null)
			{
				this.m_OnPDSDKPayCancel_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SendStoreItemCancelBuyReq();
		}

		// Token: 0x06013772 RID: 79730 RVA: 0x004F5948 File Offset: 0x004F3B48
		public void OnPDSDKPayFailed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPDSDKPayFailed_hotfix != null)
			{
				this.m_OnPDSDKPayFailed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowMessage(StringTableId.StringTableId_RechargePayFailed, 2f, null, true);
			this.SendStoreItemCancelBuyReq();
		}

		// Token: 0x06013773 RID: 79731 RVA: 0x004F59C4 File Offset: 0x004F3BC4
		public void OnPDSDKPaySuccess()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPDSDKPaySuccess_hotfix != null)
			{
				this.m_OnPDSDKPaySuccess_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SendCheckOnlineReq();
			this.ClearBuyingGoodsCache();
		}

		// Token: 0x06013774 RID: 79732 RVA: 0x004F5A30 File Offset: 0x004F3C30
		public static void OnPDSDKReqGoodsAck(bool isSuccess)
		{
			PDSDK.m_eventOnGetProductsListAck = null;
			if (!isSuccess)
			{
				return;
			}
			StoreUITask.m_pdsdkGoods.Clear();
			try
			{
				if (PDSDK.goodlistjson != null)
				{
					for (int i = 0; i < PDSDK.goodlistjson.Count; i++)
					{
						PDSDKGood item = default(PDSDKGood);
						item.m_ID = PDSDK.goodlistjson[i]["goods_id"].ToString();
						item.m_price = double.Parse(PDSDK.goodlistjson[i]["goods_price"].ToString());
						item.m_type = (PDSDKGoodType)int.Parse(PDSDK.goodlistjson[i]["type"].ToString());
						item.m_registerID = PDSDK.goodlistjson[i]["goods_register_id"].ToString();
						item.m_name = PDSDK.goodlistjson[i]["goods_name"].ToString();
						item.m_desc = PDSDK.goodlistjson[i]["goods_describe"].ToString();
						StoreUITask.m_pdsdkGoods.Add(item);
					}
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError(string.Format("StoreUITask.OnPDSDKREuGoodsAck exception = {0}", ex.Message));
			}
		}

		// Token: 0x06013775 RID: 79733 RVA: 0x004F5B98 File Offset: 0x004F3D98
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.PDSDKRequestGoods();
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x06013776 RID: 79734 RVA: 0x004F5C28 File Offset: 0x004F3E28
		public override bool OnNewIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnNewIntentUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnNewIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnNewIntent(intent);
		}

		// Token: 0x06013777 RID: 79735 RVA: 0x004F5CB4 File Offset: 0x004F3EB4
		protected override bool OnResume(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnResumeUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnResumeUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.InitDataFromUIIntent(intent);
			return base.OnResume(intent);
		}

		// Token: 0x06013778 RID: 79736 RVA: 0x004F5D40 File Offset: 0x004F3F40
		private void InitDataFromUIIntent(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitDataFromUIIntentUIIntent_hotfix != null)
			{
				this.m_InitDataFromUIIntentUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeId = StoreId.StoreId_None;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			object obj;
			if (uiintentCustom != null && uiintentCustom.TryGetParam("StoreInfoID", out obj))
			{
				this.m_storeId = (StoreId)obj;
				uiintentCustom.SetParam("StoreInfoID", null);
			}
			if (this.m_storeId == StoreId.StoreId_None)
			{
				this.m_storeId = StoreId.StoreId_BlackMarket;
			}
		}

		// Token: 0x06013779 RID: 79737 RVA: 0x004F5E00 File Offset: 0x004F4000
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_storeListUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSecond)
			{
				if (this.m_storeListUIController.IsNeedRefreshPanel())
				{
					this.m_storeListUIController.SetRandomStoreCountDown();
				}
				this.m_storeListUIController.UpdateHeroSkinItemLimitTime();
			}
		}

		// Token: 0x0601377A RID: 79738 RVA: 0x004F5EB8 File Offset: 0x004F40B8
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			base.ClearAssetList();
			if (this.m_storeId == StoreId.StoreId_SkinHero)
			{
				List<FixedStoreItem> fixedStoreItemList = projectLPlayerContext.GetFixedStoreItemList(5);
				foreach (FixedStoreItem fixedStoreItem in fixedStoreItemList)
				{
					ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItem.Id);
					ConfigDataHeroSkinInfo configDataHeroSkinInfo = configDataLoader.GetConfigDataHeroSkinInfo(configDataFixedStoreItemInfo.ItemId);
					ConfigDataCharImageSkinResourceInfo configDataCharImageSkinResourceInfo = configDataLoader.GetConfigDataCharImageSkinResourceInfo(configDataHeroSkinInfo.CharImageSkinResource_ID);
					base.CollectSpriteAsset(configDataCharImageSkinResourceInfo.Image);
				}
			}
			else if (this.m_storeId == StoreId.StoreId_SkinSoldier)
			{
				List<FixedStoreItem> fixedStoreItemList2 = projectLPlayerContext.GetFixedStoreItemList(6);
				foreach (FixedStoreItem fixedStoreItem2 in fixedStoreItemList2)
				{
					ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo2 = configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItem2.Id);
					ConfigDataSoldierSkinInfo configDataSoldierSkinInfo = configDataLoader.GetConfigDataSoldierSkinInfo(configDataFixedStoreItemInfo2.ItemId);
					ConfigDataModelSkinResourceInfo configDataModelSkinResourceInfo = configDataLoader.GetConfigDataModelSkinResourceInfo(configDataSoldierSkinInfo.ShowInListSkinResInfo[0].SkinResourceId);
					base.CollectAsset(configDataModelSkinResourceInfo.Model);
				}
			}
			else if (this.m_storeId == StoreId.StoreId_Recharge)
			{
				foreach (KeyValuePair<int, ConfigDataRechargeStoreItemInfo> keyValuePair in configDataLoader.GetAllConfigDataRechargeStoreItemInfo())
				{
					base.CollectSpriteAsset(keyValuePair.Value.Icon);
				}
			}
			else if (this.m_storeId == StoreId.StoreId_Gift || this.m_storeId == StoreId.StoreId_Privilege)
			{
				List<GiftStoreItem> giftStoreItemList = projectLPlayerContext.GetGiftStoreItemList();
				foreach (GiftStoreItem giftStoreItem in giftStoreItemList)
				{
					ConfigDataGiftStoreItemInfo config = giftStoreItem.Config;
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(config.ItemType, config.ItemId));
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601377B RID: 79739 RVA: 0x004F6178 File Offset: 0x004F4378
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			if (this.m_storeListUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_storeListUIController = (this.m_uiCtrlArray[0] as StoreListUIController);
				}
				if (!(this.m_storeListUIController != null))
				{
					global::Debug.LogError("StoreListUIController is null");
					return;
				}
				this.m_storeListUIController.EventOnClose += this.StoreUIController_OnClose;
				this.m_storeListUIController.EventOnChangeStore += this.StoreUIController_OnChangeStore;
				this.m_storeListUIController.EventOnFixedStoreItemBuyClick += this.StoreUIController_OnFixedStoreItemBuy;
				this.m_storeListUIController.EventOnFixedStoreBoxBuyClick += this.StoreUIController_OnFixedStoreBoxBuy;
				this.m_storeListUIController.EventOnRandomStoreItemBuyClick += this.StoreUIController_OnRandomStoreItemBuy;
				this.m_storeListUIController.EventOnRandomStoreBoxBuyClick += this.StoreUIController_OnRandomStoreBoxBuy;
				this.m_storeListUIController.EventOnRechargeStoreBuyClick += this.StoreUIController_OnRechargeStoreBuy;
				this.m_storeListUIController.EventOnGiftStoreBuyClick += this.StoreUIController_OnGiftStoreBuy;
				this.m_storeListUIController.EventOnGetRandomStore += this.StoreUIController_GetRandomStore;
				this.m_storeListUIController.EventOnRefreshRandomStore += this.StoreUIController_RefreshRandomStore;
				this.m_storeListUIController.EventOnCrystalNotEnough += this.StoreUIController_CrystalNotEnough;
				this.m_storeListUIController.EventOnFixedStoreHeroSkinItemClick += this.StoreUIController_OnFixedStoreHeroSkinItemClick;
				this.m_storeListUIController.EventOnFixedStoreSoldierSkinItemClick += this.StoreUIController_OnFixedStoreSoldierSkinItemClick;
				this.m_storeListUIController.EventOnExtraButtonClick += this.StoreUIController_OnExtraCurrencyBuy;
				this.m_storeListUIController.EventOnMemoryExtraction += this.StoreUIController_OMemoryExtractionButtonClick;
				this.m_storeListUIController.EventOnSkinItemOutOfDate += this.StoreListUIController_OnSkinItemOutOfDate;
				PDSDK.m_eventOnPayCancel = new Action(this.OnPDSDKPayCancel);
				PDSDK.m_eventOnPayFailed = new Action(this.OnPDSDKPayFailed);
				PDSDK.m_eventOnPaySuccess = new Action(this.OnPDSDKPaySuccess);
				this.m_playerContext.EventOnRechargeBoughtSuccessNtf += this.PlayerContext_OnRechargeNoughtSuccessNtf;
				this.m_playerContext.EventOnGiftStoreBuyGoodsNtf += this.PlayerContex_OnGiftStoreBuyNtf;
				this.m_playerContext.EventOnGiftStoreOperationalGoodsUpdateNtf += this.PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf;
				this.m_playerContext.EventOnPlayerInfoInitEnd += this.PlayerContext_OnPlayerInfoInitEnd;
			}
		}

		// Token: 0x0601377C RID: 79740 RVA: 0x004F6430 File Offset: 0x004F4630
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_storeListUIController != null)
			{
				this.m_storeListUIController.EventOnClose -= this.StoreUIController_OnClose;
				this.m_storeListUIController.EventOnChangeStore -= this.StoreUIController_OnChangeStore;
				this.m_storeListUIController.EventOnFixedStoreItemBuyClick -= this.StoreUIController_OnFixedStoreItemBuy;
				this.m_storeListUIController.EventOnFixedStoreBoxBuyClick -= this.StoreUIController_OnFixedStoreBoxBuy;
				this.m_storeListUIController.EventOnRandomStoreItemBuyClick -= this.StoreUIController_OnRandomStoreItemBuy;
				this.m_storeListUIController.EventOnRandomStoreBoxBuyClick -= this.StoreUIController_OnRandomStoreBoxBuy;
				this.m_storeListUIController.EventOnRechargeStoreBuyClick -= this.StoreUIController_OnRechargeStoreBuy;
				this.m_storeListUIController.EventOnGiftStoreBuyClick -= this.StoreUIController_OnGiftStoreBuy;
				this.m_storeListUIController.EventOnGetRandomStore -= this.StoreUIController_GetRandomStore;
				this.m_storeListUIController.EventOnRefreshRandomStore -= this.StoreUIController_RefreshRandomStore;
				this.m_storeListUIController.EventOnCrystalNotEnough -= this.StoreUIController_CrystalNotEnough;
				this.m_storeListUIController.EventOnFixedStoreHeroSkinItemClick -= this.StoreUIController_OnFixedStoreHeroSkinItemClick;
				this.m_storeListUIController.EventOnFixedStoreSoldierSkinItemClick -= this.StoreUIController_OnFixedStoreSoldierSkinItemClick;
				this.m_storeListUIController.EventOnExtraButtonClick -= this.StoreUIController_OnExtraCurrencyBuy;
				this.m_storeListUIController.EventOnMemoryExtraction -= this.StoreUIController_OMemoryExtractionButtonClick;
				this.m_storeListUIController.EventOnSkinItemOutOfDate -= this.StoreListUIController_OnSkinItemOutOfDate;
				PDSDK.m_eventOnPayCancel = null;
				PDSDK.m_eventOnPayFailed = null;
				PDSDK.m_eventOnPaySuccess = null;
				this.m_storeListUIController = null;
			}
			this.m_playerContext.EventOnRechargeBoughtSuccessNtf -= this.PlayerContext_OnRechargeNoughtSuccessNtf;
			this.m_playerContext.EventOnGiftStoreBuyGoodsNtf -= this.PlayerContex_OnGiftStoreBuyNtf;
			this.m_playerContext.EventOnGiftStoreOperationalGoodsUpdateNtf -= this.PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf;
			this.m_playerContext.EventOnPlayerInfoInitEnd -= this.PlayerContext_OnPlayerInfoInitEnd;
		}

		// Token: 0x0601377D RID: 79741 RVA: 0x004F668C File Offset: 0x004F488C
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsOpeningUI())
			{
				this.m_storeListUIController.StoreOpenTween();
			}
			this.m_storeListUIController.UpdateStore(this.m_storeId);
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				object obj = null;
				if (uiintentCustom.TryGetParam("StoreItemId", out obj) && obj != null)
				{
					this.m_storeListUIController.OpenBuyPanel(this.m_storeId, (int)obj);
				}
				object obj2 = false;
				if (uiintentCustom.TryGetParam("IsShowExtractionPanel", out obj2) && obj2 != null && (bool)obj2)
				{
					this.m_storeListUIController.OnMemoryEntranceButtonClick();
				}
				uiintentCustom.SetParam("StoreItemId", null);
				uiintentCustom.SetParam("IsShowExtractionPanel", null);
			}
		}

		// Token: 0x0601377E RID: 79742 RVA: 0x004F67A4 File Offset: 0x004F49A4
		private void StoreUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnClose_hotfix != null)
			{
				this.m_StoreUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				base.Pause();
				UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
				if (uiintentReturnable != null)
				{
					if (uiintentReturnable.PrevTaskIntent.TargetTaskName == typeof(HeroSkinChangeUITask).Name)
					{
						HeroSkinChangeUITask heroSkinChangeUITask = UIUtility.FindUITaskWithType(typeof(HeroSkinChangeUITask)) as HeroSkinChangeUITask;
						if (heroSkinChangeUITask != null)
						{
							HeroListUITask heroListUITask = UIUtility.FindUITaskWithType(typeof(HeroListUITask)) as HeroListUITask;
							if (heroListUITask != null)
							{
								heroSkinChangeUITask.EventOnClose += heroListUITask.HeroCharChangeTask_EventOnClose;
								heroSkinChangeUITask.EventOnSkinChangedPreview += heroListUITask.HeroCharChangeTask_OnSkinChangedPreview;
								HeroSoldierSkinUITask heroSoldierSkinUITask = UIUtility.FindUITaskWithType(typeof(HeroSoldierSkinUITask)) as HeroSoldierSkinUITask;
								if (heroSoldierSkinUITask != null)
								{
									heroSkinChangeUITask.EventOnClose += heroSoldierSkinUITask.HeroSoldierSkinUIController_OnCloseHeroCharChangeTask;
								}
							}
						}
					}
					else if (uiintentReturnable.PrevTaskIntent.TargetTaskName == typeof(StoreSoldierSkinDetailUITask).Name)
					{
						StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = UIUtility.FindUITaskWithType(typeof(StoreSoldierSkinDetailUITask)) as StoreSoldierSkinDetailUITask;
						if (storeSoldierSkinDetailUITask != null)
						{
							HeroListUITask heroListUITask2 = UIUtility.FindUITaskWithType(typeof(HeroListUITask)) as HeroListUITask;
							if (heroListUITask2 != null)
							{
								storeSoldierSkinDetailUITask.EventOnClose += heroListUITask2.StoreSoldierSkinDetailUITask_EventOnClose;
								storeSoldierSkinDetailUITask.EventOnBuySuccessEnd += heroListUITask2.StoreSoldierSkinDetailUITask_EventOnBuySuccessEnd;
							}
						}
					}
				}
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0601377F RID: 79743 RVA: 0x004F6828 File Offset: 0x004F4A28
		private void StoreUIController_OnChangeStore(StoreId storeId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnChangeStoreStoreId_hotfix != null)
			{
				this.m_StoreUIController_OnChangeStoreStoreId_hotfix.call(new object[]
				{
					this,
					storeId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeId = storeId;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06013780 RID: 79744 RVA: 0x004F68AC File Offset: 0x004F4AAC
		protected void StoreUIController_OnFixedStoreHeroSkinItemClick(StoreHeroSkinItemUIController itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnFixedStoreHeroSkinItemClickStoreHeroSkinItemUIController_hotfix != null)
			{
				this.m_StoreUIController_OnFixedStoreHeroSkinItemClickStoreHeroSkinItemUIController_hotfix.call(new object[]
				{
					this,
					itemCtrl
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.HasOwn(itemCtrl.m_storeItemConfig.ItemType, itemCtrl.m_storeItemConfig.ItemId))
			{
				return;
			}
			HeroSkinChangeUITask heroSkinChangeUITask = HeroSkinChangeUITask.StartUITask("SkinBuyMode", itemCtrl.m_storeItemConfig.ItemId, null, null);
			if (heroSkinChangeUITask != null)
			{
				heroSkinChangeUITask.EventOnBuySkinSucceed += delegate(int fixedStoreItemId)
				{
					this.m_storeListUIController.SetSkinTicketCountText();
					StoreHeroSkinItemUIController heroSkinItemCtrlByFixedStoreItemId = this.m_storeListUIController.GetHeroSkinItemCtrlByFixedStoreItemId(fixedStoreItemId);
					if (heroSkinItemCtrlByFixedStoreItemId != null)
					{
						heroSkinItemCtrlByFixedStoreItemId.SetItemState();
					}
					else
					{
						global::Debug.LogError("StoreUIController_OnFixedStoreHeroSkinItemClicr::Can Not Get Item Ctrl !");
					}
				};
				heroSkinChangeUITask.EventOnAddSkinTicket += delegate()
				{
					this.m_storeId = StoreId.StoreId_Gift;
					base.StartUpdatePipeLine(null, false, false, true);
				};
			}
		}

		// Token: 0x06013781 RID: 79745 RVA: 0x004F6990 File Offset: 0x004F4B90
		protected void StoreUIController_OnFixedStoreSoldierSkinItemClick(StoreSoldierSkinItemUIController itemCtrl)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnFixedStoreSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix != null)
			{
				this.m_StoreUIController_OnFixedStoreSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix.call(new object[]
				{
					this,
					itemCtrl2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreSoldierSkinItemUIController itemCtrl = itemCtrl2;
			StoreUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.HasOwn(itemCtrl.m_storeItemConfig.ItemType, itemCtrl.m_storeItemConfig.ItemId))
			{
				return;
			}
			StoreSoldierSkinDetailUITask storeSoldierSkinDetailUITask = StoreSoldierSkinDetailUITask.StartSoldierSkinDetailPanel(itemCtrl.m_storeItemConfig.ItemId, StoreSoldierSkinDetailUITask.StartTaskFromType.StartTaskFromStore, null);
			if (storeSoldierSkinDetailUITask != null)
			{
				storeSoldierSkinDetailUITask.EventOnBuySuccessEnd += delegate()
				{
					$this.m_storeListUIController.SetSkinTicketCountText();
					itemCtrl.SetItemState();
				};
			}
		}

		// Token: 0x06013782 RID: 79746 RVA: 0x004F6A80 File Offset: 0x004F4C80
		private void StoreUIController_OnFixedStoreItemBuy(StoreId fixedStoreID, int fixedStoreItemGoodsID, int goodsId, int selfChooseItemIndex, List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnFixedStoreItemBuyStoreIdInt32Int32Int32List`1_hotfix != null)
			{
				this.m_StoreUIController_OnFixedStoreItemBuyStoreIdInt32Int32Int32List`1_hotfix.call(new object[]
				{
					this,
					fixedStoreID,
					fixedStoreItemGoodsID,
					goodsId2,
					selfChooseItemIndex,
					gainGoodsList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int goodsId = goodsId2;
			List<Goods> gainGoodsList = gainGoodsList2;
			StoreUITask $this = this;
			int num = this.m_playerContext.CanBuyFixedStoreGoods((int)fixedStoreID, fixedStoreItemGoodsID, selfChooseItemIndex);
			if (num == 0)
			{
				IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
				ConfigDataFixedStoreItemInfo configDataFixedStoreItemInfo = configDataLoader.GetConfigDataFixedStoreItemInfo(fixedStoreItemGoodsID);
				if (configDataFixedStoreItemInfo.ItemType == GoodsType.GoodsType_Item)
				{
					ConfigDataItemInfo configDataItemInfo = configDataLoader.GetConfigDataItemInfo(configDataFixedStoreItemInfo.ItemId);
					if (configDataItemInfo.FuncType != ItemFuncType.ItemFuncType_SelfSelectedBox)
					{
						selfChooseItemIndex = -1;
					}
				}
				else
				{
					selfChooseItemIndex = -1;
				}
				FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask = new FixedStoreBuyStoreItemNetTask((int)fixedStoreID, fixedStoreItemGoodsID, selfChooseItemIndex);
				fixedStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask2 = task as FixedStoreBuyStoreItemNetTask;
					if (fixedStoreBuyStoreItemNetTask2.Result == 0)
					{
						ConfigDataItemInfo configDataItemInfo2 = $this.m_configdataLoader.GetConfigDataItemInfo(goodsId);
						if (configDataItemInfo2 != null && (configDataItemInfo2.FuncType == ItemFuncType.ItemFuncType_StaticBox || configDataItemInfo2.FuncType == ItemFuncType.ItemFuncType_RandomBox))
						{
							$this.HandleBoxOpenNetTask(GoodsType.GoodsType_Item, goodsId, 1, delegate(List<Goods> goods)
							{
								$this.UpdateViewAndOpenRewardGoodsUI(goods);
							}, delegate
							{
								$this.UpdateViewAndOpenRewardGoodsUI(gainGoodsList);
							});
						}
						else
						{
							$this.UpdateViewAndOpenRewardGoodsUI(gainGoodsList);
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
				BagFullUITask.StartUITask(this.m_currIntent);
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

		// Token: 0x06013783 RID: 79747 RVA: 0x004F6C1C File Offset: 0x004F4E1C
		private void StoreUIController_OnFixedStoreBoxBuy(StoreId fixedStoreID, int fixedStoreItemGoodsID, int goodsID, List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnFixedStoreBoxBuyStoreIdInt32Int32List`1_hotfix != null)
			{
				this.m_StoreUIController_OnFixedStoreBoxBuyStoreIdInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					fixedStoreID,
					fixedStoreItemGoodsID,
					goodsID2,
					gainGoodsList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int goodsID = goodsID2;
			List<Goods> gainGoodsList = gainGoodsList2;
			StoreUITask $this = this;
			int num = this.m_playerContext.CanBuyFixedStoreGoods((int)fixedStoreID, fixedStoreItemGoodsID, -1);
			if (num == 0)
			{
				FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask = new FixedStoreBuyStoreItemNetTask((int)fixedStoreID, fixedStoreItemGoodsID, -1);
				fixedStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					FixedStoreBuyStoreItemNetTask fixedStoreBuyStoreItemNetTask2 = task as FixedStoreBuyStoreItemNetTask;
					if (fixedStoreBuyStoreItemNetTask2.Result == 0)
					{
						$this.HandleBoxOpenNetTask(GoodsType.GoodsType_Item, goodsID, 1, delegate(List<Goods> goods)
						{
							$this.UpdateViewAndOpenRewardGoodsUI(goods);
						}, delegate
						{
							$this.UpdateViewAndOpenRewardGoodsUI(gainGoodsList);
						});
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
				BagFullUITask.StartUITask(this.m_currIntent);
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

		// Token: 0x06013784 RID: 79748 RVA: 0x004F6D58 File Offset: 0x004F4F58
		private void StoreUIController_OnRandomStoreItemBuy(StoreId randomStoreId, int index, List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnRandomStoreItemBuyStoreIdInt32List`1_hotfix != null)
			{
				this.m_StoreUIController_OnRandomStoreItemBuyStoreIdInt32List`1_hotfix.call(new object[]
				{
					this,
					randomStoreId,
					index,
					gainGoodsList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> gainGoodsList = gainGoodsList2;
			StoreUITask $this = this;
			int num = this.m_playerContext.CanBuyRandomStoreGoods((int)randomStoreId, index, -1);
			if (num == 0)
			{
				RandomStoreBuyStoreItemNetTask randomStoreBuyStoreItemNetTask = new RandomStoreBuyStoreItemNetTask((int)randomStoreId, index);
				randomStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					RandomStoreBuyStoreItemNetTask randomStoreBuyStoreItemNetTask2 = task as RandomStoreBuyStoreItemNetTask;
					if (randomStoreBuyStoreItemNetTask2.Result == 0)
					{
						$this.UpdateViewAndOpenRewardGoodsUI(gainGoodsList);
					}
					else if (randomStoreBuyStoreItemNetTask2.Result == -1104)
					{
						CommonUIController.Instance.ShowErrorMessage(randomStoreBuyStoreItemNetTask2.Result, 2f, null, true);
						$this.UpdateView();
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(randomStoreBuyStoreItemNetTask2.Result, 2f, null, true);
					}
				};
				randomStoreBuyStoreItemNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
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

		// Token: 0x06013785 RID: 79749 RVA: 0x004F6E7C File Offset: 0x004F507C
		private void StoreUIController_OnRandomStoreBoxBuy(StoreId randomStoreId, int index, int goodsID, List<Goods> gainGoodsList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnRandomStoreBoxBuyStoreIdInt32Int32List`1_hotfix != null)
			{
				this.m_StoreUIController_OnRandomStoreBoxBuyStoreIdInt32Int32List`1_hotfix.call(new object[]
				{
					this,
					randomStoreId,
					index,
					goodsID2,
					gainGoodsList2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int goodsID = goodsID2;
			List<Goods> gainGoodsList = gainGoodsList2;
			StoreUITask $this = this;
			int num = this.m_playerContext.CanBuyRandomStoreGoods((int)randomStoreId, index, -1);
			if (num == 0)
			{
				RandomStoreBuyStoreItemNetTask randomStoreBuyStoreItemNetTask = new RandomStoreBuyStoreItemNetTask((int)randomStoreId, index);
				randomStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
				{
					RandomStoreBuyStoreItemNetTask randomStoreBuyStoreItemNetTask2 = task as RandomStoreBuyStoreItemNetTask;
					if (randomStoreBuyStoreItemNetTask2.Result == 0)
					{
						$this.HandleBoxOpenNetTask(GoodsType.GoodsType_Item, goodsID, 1, delegate(List<Goods> goods)
						{
							$this.UpdateViewAndOpenRewardGoodsUI(goods);
						}, delegate
						{
							$this.UpdateViewAndOpenRewardGoodsUI(gainGoodsList);
						});
					}
					else
					{
						CommonUIController.Instance.ShowErrorMessage(randomStoreBuyStoreItemNetTask2.Result, 2f, null, true);
					}
				};
				randomStoreBuyStoreItemNetTask.Start(null);
			}
			else if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
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

		// Token: 0x06013786 RID: 79750 RVA: 0x004F6FB8 File Offset: 0x004F51B8
		private void StoreUIController_GetRandomStore(StoreId randomStoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_GetRandomStoreStoreId_hotfix != null)
			{
				this.m_StoreUIController_GetRandomStoreStoreId_hotfix.call(new object[]
				{
					this,
					randomStoreId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GetRandomStoreItemListNetTask getRandomStoreItemListNetTask = new GetRandomStoreItemListNetTask((int)randomStoreId);
			getRandomStoreItemListNetTask.EventOnStop += delegate(Task task)
			{
				GetRandomStoreItemListNetTask getRandomStoreItemListNetTask2 = task as GetRandomStoreItemListNetTask;
				if (getRandomStoreItemListNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(getRandomStoreItemListNetTask2.Result, 2f, null, true);
				}
			};
			getRandomStoreItemListNetTask.Start(null);
		}

		// Token: 0x06013787 RID: 79751 RVA: 0x004F704C File Offset: 0x004F524C
		private void StoreUIController_RefreshRandomStore(StoreId randomStoreId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_RefreshRandomStoreStoreId_hotfix != null)
			{
				this.m_StoreUIController_RefreshRandomStoreStoreId_hotfix.call(new object[]
				{
					this,
					randomStoreId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			RandomStoreFlushNetTask randomStoreFlushNetTask = new RandomStoreFlushNetTask((int)randomStoreId);
			randomStoreFlushNetTask.EventOnStop += delegate(Task task)
			{
				RandomStoreFlushNetTask randomStoreFlushNetTask2 = task as RandomStoreFlushNetTask;
				if (randomStoreFlushNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(randomStoreFlushNetTask2.Result, 2f, null, true);
				}
			};
			randomStoreFlushNetTask.Start(null);
		}

		// Token: 0x06013788 RID: 79752 RVA: 0x004F70E0 File Offset: 0x004F52E0
		private void StoreUIController_OMemoryExtractionButtonClick(Action OnSucced)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OMemoryExtractionButtonClickAction_hotfix != null)
			{
				this.m_StoreUIController_OMemoryExtractionButtonClickAction_hotfix.call(new object[]
				{
					this,
					OnSucced2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucced = OnSucced2;
			StoreUITask $this = this;
			ExchangeHeroFragementNetTask exchangeHeroFragementNetTask = new ExchangeHeroFragementNetTask();
			exchangeHeroFragementNetTask.EventOnStop += delegate(Task task)
			{
				ExchangeHeroFragementNetTask exchangeHeroFragementNetTask2 = task as ExchangeHeroFragementNetTask;
				if (exchangeHeroFragementNetTask2.Result == 0)
				{
					if (OnSucced != null)
					{
						OnSucced();
					}
					$this.UpdateView();
					List<Goods> rewards = exchangeHeroFragementNetTask2.Rewards;
					if (rewards != null && rewards.Count > 0)
					{
						GetRewardGoodsUITask.StartUITask(rewards);
					}
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(exchangeHeroFragementNetTask2.Result, 2f, null, true);
				}
			};
			exchangeHeroFragementNetTask.Start(null);
		}

		// Token: 0x06013789 RID: 79753 RVA: 0x004F7184 File Offset: 0x004F5384
		private void StoreListUIController_OnSkinItemOutOfDate()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreListUIController_OnSkinItemOutOfDate_hotfix != null)
			{
				this.m_StoreListUIController_OnSkinItemOutOfDate_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.StartUpdateView();
		}

		// Token: 0x0601378A RID: 79754 RVA: 0x004F71EC File Offset: 0x004F53EC
		private void StoreUIController_OnRechargeStoreBuy(StoreType storeType, int itemGoodsId, int number)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnRechargeStoreBuyStoreTypeInt32Int32_hotfix != null)
			{
				this.m_StoreUIController_OnRechargeStoreBuyStoreTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					storeType,
					itemGoodsId,
					number
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.SendRechargeStoreBuyStoreItemReq(storeType, itemGoodsId, number, PDSDKGoodType.Normal);
		}

		// Token: 0x0601378B RID: 79755 RVA: 0x004F7288 File Offset: 0x004F5488
		private void SendStoreItemCancelBuyReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendStoreItemCancelBuyReq_hotfix != null)
			{
				this.m_SendStoreItemCancelBuyReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(this.m_curBuyingGoodsId))
			{
				return;
			}
			int storeTypeId = RMBStoreoreGoodsIdTools.GetStoreTypeId(this.m_curBuyingGoodsId);
			int realGoodsId = RMBStoreoreGoodsIdTools.GetRealGoodsId(this.m_curBuyingGoodsId);
			if (storeTypeId == 4)
			{
				GiftStoreCancelBuyNetTask giftStoreCancelBuyNetTask = new GiftStoreCancelBuyNetTask(realGoodsId);
				giftStoreCancelBuyNetTask.EventOnStop += delegate(Task task)
				{
					GiftStoreCancelBuyNetTask giftStoreCancelBuyNetTask2 = task as GiftStoreCancelBuyNetTask;
					if (giftStoreCancelBuyNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(giftStoreCancelBuyNetTask2.Result, 2f, null, true);
					}
				};
				giftStoreCancelBuyNetTask.Start(null);
			}
			else if (storeTypeId == 3)
			{
				RechargeStoreCancelBuyNetTask rechargeStoreCancelBuyNetTask = new RechargeStoreCancelBuyNetTask(realGoodsId);
				rechargeStoreCancelBuyNetTask.EventOnStop += delegate(Task task)
				{
					RechargeStoreCancelBuyNetTask rechargeStoreCancelBuyNetTask2 = task as RechargeStoreCancelBuyNetTask;
					if (rechargeStoreCancelBuyNetTask2.Result != 0)
					{
						CommonUIController.Instance.ShowErrorMessage(rechargeStoreCancelBuyNetTask2.Result, 2f, null, true);
					}
				};
				rechargeStoreCancelBuyNetTask.Start(null);
			}
			this.ClearBuyingGoodsCache();
		}

		// Token: 0x0601378C RID: 79756 RVA: 0x004F7390 File Offset: 0x004F5590
		private void SendCheckOnlineReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendCheckOnlineReq_hotfix != null)
			{
				this.m_SendCheckOnlineReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CheckOnlineNetTask checkOnlineNetTask = new CheckOnlineNetTask();
			checkOnlineNetTask.EventOnStop += delegate(Task task)
			{
			};
			checkOnlineNetTask.Start(null);
		}

		// Token: 0x0601378D RID: 79757 RVA: 0x004F7424 File Offset: 0x004F5624
		private void ClearBuyingGoodsCache()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearBuyingGoodsCache_hotfix != null)
			{
				this.m_ClearBuyingGoodsCache_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curBuyingGoodsId = null;
		}

		// Token: 0x0601378E RID: 79758 RVA: 0x004F748C File Offset: 0x004F568C
		private void StoreUIController_OnGiftStoreBuy(ConfigDataGiftStoreItemInfo giftStoreItem, bool isfristBuy, int number)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnGiftStoreBuyConfigDataGiftStoreItemInfoBooleanInt32_hotfix != null)
			{
				this.m_StoreUIController_OnGiftStoreBuyConfigDataGiftStoreItemInfoBooleanInt32_hotfix.call(new object[]
				{
					this,
					giftStoreItem,
					isfristBuy,
					number
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerContext.CanBuyGiftStoreGoods(giftStoreItem.ID);
			if (num == -500)
			{
				BagFullUITask.StartUITask(this.m_currIntent);
				return;
			}
			if (num != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				return;
			}
			PDSDKGoodType giftItemPdsdkGoodType = UIUtility.GetGiftItemPdsdkGoodType(giftStoreItem.FirstPrice, giftStoreItem.NormalPrice, isfristBuy, giftStoreItem.IsAppleSubscribe);
			if (giftItemPdsdkGoodType != PDSDKGoodType.IosSubscribe)
			{
				this.SendGiftStoreBuyStoreItemReq(StoreType.StoreType_Gift, giftStoreItem.ID, number, giftItemPdsdkGoodType);
			}
			else
			{
				this.SendGiftStoreAppleSubscribeItemReq(StoreType.StoreType_Gift, giftStoreItem.ID, number, giftItemPdsdkGoodType);
			}
		}

		// Token: 0x0601378F RID: 79759 RVA: 0x004F75AC File Offset: 0x004F57AC
		private void SendGiftStoreBuyStoreItemReq(StoreType storeType, int goodsId, int number, PDSDKGoodType pdsdkGoodType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendGiftStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix != null)
			{
				this.m_SendGiftStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix.call(new object[]
				{
					this,
					storeType2,
					goodsId3,
					number2,
					pdsdkGoodType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreType storeType = storeType2;
			int goodsId = goodsId3;
			PDSDKGoodType pdsdkGoodType = pdsdkGoodType2;
			int number = number2;
			StoreUITask $this = this;
			GiftStoreBuyStoreItemNetTask giftStoreBuyStoreItemNetTask = new GiftStoreBuyStoreItemNetTask(goodsId);
			giftStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
			{
				int result = (task as GiftStoreBuyStoreItemNetTask).Result;
				if (result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
				else
				{
					string goodsId2 = RMBStoreoreGoodsIdTools.GetGoodsId((int)storeType, goodsId);
					$this.m_curBuyingGoodsId = goodsId2;
					StoreUITask.PDSDKRequestBuyGoods(goodsId2, pdsdkGoodType, number);
				}
			};
			giftStoreBuyStoreItemNetTask.Start(null);
		}

		// Token: 0x06013790 RID: 79760 RVA: 0x004F769C File Offset: 0x004F589C
		private void SendGiftStoreAppleSubscribeItemReq(StoreType storeType, int goodsId, int number, PDSDKGoodType pdsdkGoodType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendGiftStoreAppleSubscribeItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix != null)
			{
				this.m_SendGiftStoreAppleSubscribeItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix.call(new object[]
				{
					this,
					storeType2,
					goodsId3,
					number2,
					pdsdkGoodType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreType storeType = storeType2;
			int goodsId = goodsId3;
			PDSDKGoodType pdsdkGoodType = pdsdkGoodType2;
			int number = number2;
			StoreUITask $this = this;
			GiftStoreAppleSubscribeNetTask giftStoreAppleSubscribeNetTask = new GiftStoreAppleSubscribeNetTask(goodsId);
			giftStoreAppleSubscribeNetTask.EventOnStop += delegate(Task task)
			{
				int result = (task as GiftStoreAppleSubscribeNetTask).Result;
				if (result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
				else
				{
					string goodsId2 = RMBStoreoreGoodsIdTools.GetGoodsId((int)storeType, goodsId);
					$this.m_curBuyingGoodsId = goodsId2;
					StoreUITask.PDSDKRequestBuyGoods(goodsId2, pdsdkGoodType, number);
				}
			};
			giftStoreAppleSubscribeNetTask.Start(null);
		}

		// Token: 0x06013791 RID: 79761 RVA: 0x004F778C File Offset: 0x004F598C
		private void SendRechargeStoreBuyStoreItemReq(StoreType storeType, int goodsId, int number, PDSDKGoodType pdsdkGoodType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SendRechargeStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix != null)
			{
				this.m_SendRechargeStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix.call(new object[]
				{
					this,
					storeType2,
					goodsId3,
					number2,
					pdsdkGoodType2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreType storeType = storeType2;
			int goodsId = goodsId3;
			PDSDKGoodType pdsdkGoodType = pdsdkGoodType2;
			int number = number2;
			StoreUITask $this = this;
			RechargeStoreBuyStoreItemNetTask rechargeStoreBuyStoreItemNetTask = new RechargeStoreBuyStoreItemNetTask(goodsId);
			rechargeStoreBuyStoreItemNetTask.EventOnStop += delegate(Task task)
			{
				int result = (task as RechargeStoreBuyStoreItemNetTask).Result;
				if (result != 0)
				{
					CommonUIController.Instance.ShowErrorMessage(result, 2f, null, true);
				}
				else
				{
					string goodsId2 = RMBStoreoreGoodsIdTools.GetGoodsId((int)storeType, goodsId);
					$this.m_curBuyingGoodsId = goodsId2;
					StoreUITask.PDSDKRequestBuyGoods(goodsId2, pdsdkGoodType, number);
				}
			};
			rechargeStoreBuyStoreItemNetTask.Start(null);
		}

		// Token: 0x06013792 RID: 79762 RVA: 0x004F787C File Offset: 0x004F5A7C
		private void PlayerContex_OnGiftStoreBuyNtf(string orderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContex_OnGiftStoreBuyNtfString_hotfix != null)
			{
				this.m_PlayerContex_OnGiftStoreBuyNtfString_hotfix.call(new object[]
				{
					this,
					orderId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.CheckOrderReward();
			if (base.State == Task.TaskState.Running)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x06013793 RID: 79763 RVA: 0x004F7908 File Offset: 0x004F5B08
		private void PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf_hotfix != null)
			{
				this.m_PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06013794 RID: 79764 RVA: 0x004F7968 File Offset: 0x004F5B68
		private void PlayerContext_OnPlayerInfoInitEnd()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix != null)
			{
				this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.State == Task.TaskState.Running)
			{
				this.UpdateView();
			}
		}

		// Token: 0x06013795 RID: 79765 RVA: 0x004F79DC File Offset: 0x004F5BDC
		private void HandleBoxOpenNetTask(GoodsType type, int id, int count, Action<List<Goods>> successedCallback, Action failedCallback)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HandleBoxOpenNetTaskGoodsTypeInt32Int32Action`1Action_hotfix != null)
			{
				this.m_HandleBoxOpenNetTaskGoodsTypeInt32Int32Action`1Action_hotfix.call(new object[]
				{
					this,
					type,
					id,
					count,
					successedCallback2,
					failedCallback2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action<List<Goods>> successedCallback = successedCallback2;
			Action failedCallback = failedCallback2;
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

		// Token: 0x06013796 RID: 79766 RVA: 0x004F7AC8 File Offset: 0x004F5CC8
		private void PlayerContext_OnRechargeNoughtSuccessNtf(string orderId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnRechargeNoughtSuccessNtfString_hotfix != null)
			{
				this.m_PlayerContext_OnRechargeNoughtSuccessNtfString_hotfix.call(new object[]
				{
					this,
					orderId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.CheckOrderReward();
			if (base.State == Task.TaskState.Running)
			{
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x06013797 RID: 79767 RVA: 0x004F7B54 File Offset: 0x004F5D54
		private void StoreListUIController_OpenAddGoldStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreListUIController_OpenAddGoldStore_hotfix != null)
			{
				this.m_StoreListUIController_OpenAddGoldStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeId = StoreId.StoreId_Crystal;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06013798 RID: 79768 RVA: 0x004F7BC8 File Offset: 0x004F5DC8
		private void StoreListUIController_OpenAddCrystalStore()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreListUIController_OpenAddCrystalStore_hotfix != null)
			{
				this.m_StoreListUIController_OpenAddCrystalStore_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_storeId = StoreId.StoreId_Recharge;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06013799 RID: 79769 RVA: 0x004F7C3C File Offset: 0x004F5E3C
		private void StoreUIController_CrystalNotEnough()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_CrystalNotEnough_hotfix != null)
			{
				this.m_StoreUIController_CrystalNotEnough_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
			{
				if (dialogResult == DialogBoxResult.Ok)
				{
					this.m_storeId = StoreId.StoreId_Recharge;
					base.StartUpdatePipeLine(null, false, false, true);
				}
			}, (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x0601379A RID: 79770 RVA: 0x004F7CBC File Offset: 0x004F5EBC
		private void StoreUIController_OnExtraCurrencyBuy(GoodsType goodsType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StoreUIController_OnExtraCurrencyBuyGoodsType_hotfix != null)
			{
				this.m_StoreUIController_OnExtraCurrencyBuyGoodsType_hotfix.call(new object[]
				{
					this,
					goodsType
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (goodsType == GoodsType.GoodsType_SkinTicket)
			{
				this.m_storeId = StoreId.StoreId_Gift;
				base.StartUpdatePipeLine(null, false, false, true);
			}
		}

		// Token: 0x0601379B RID: 79771 RVA: 0x004F7D50 File Offset: 0x004F5F50
		private void UpdateViewAndOpenRewardGoodsUI(List<Goods> rewardGoods = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateViewAndOpenRewardGoodsUIList`1_hotfix != null)
			{
				this.m_UpdateViewAndOpenRewardGoodsUIList`1_hotfix.call(new object[]
				{
					this,
					rewardGoods
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.UpdateView();
			if (rewardGoods != null)
			{
				GetRewardGoodsUITask.StartUITask(rewardGoods);
			}
		}

		// Token: 0x0601379C RID: 79772 RVA: 0x004F7DD4 File Offset: 0x004F5FD4
		public static void CheckOrderReward()
		{
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			List<OrderReward> allOrderRewards = projectLPlayerContext.GetAllOrderRewards();
			if (allOrderRewards == null || allOrderRewards.Count == 0)
			{
				return;
			}
			OrderReward orderReward = allOrderRewards[0];
			StoreUITask.SendPullOrderRewardReq(orderReward.OrderId, delegate
			{
				StoreUITask.CheckOrderReward();
			}, null);
		}

		// Token: 0x0601379D RID: 79773 RVA: 0x004F7E3C File Offset: 0x004F603C
		public static void SendPullOrderRewardReq(string orderId, Action successedCallback = null, Action failedCallback = null)
		{
			PullOrderRewardNetTask pullOrderRewardNetTask = new PullOrderRewardNetTask(orderId);
			pullOrderRewardNetTask.EventOnStop += delegate(Task task)
			{
				PullOrderRewardNetTask pullOrderRewardNetTask2 = task as PullOrderRewardNetTask;
				if (pullOrderRewardNetTask2.Result != 0)
				{
					global::Debug.LogError(string.Format("SendPullOrderRewardAck Error: {0}", pullOrderRewardNetTask2.Result));
					if (failedCallback != null)
					{
						failedCallback();
					}
				}
				else
				{
					StoreUITask.ProcessOrderRewards(pullOrderRewardNetTask2.Reward.Rewards, successedCallback);
				}
			};
			pullOrderRewardNetTask.Start(null);
		}

		// Token: 0x0601379E RID: 79774 RVA: 0x004F7E80 File Offset: 0x004F6080
		public static void ProcessOrderRewards(List<Goods> rewardList, Action successedCallback)
		{
			List<Goods> m_rewards = new List<Goods>();
			int m_leftReward = rewardList.Count;
			using (List<Goods>.Enumerator enumerator = rewardList.GetEnumerator())
			{
				while (enumerator.MoveNext())
				{
					Goods goods = enumerator.Current;
					GoodsType goodsType = goods.GoodsType;
					if (goodsType != GoodsType.GoodsType_Item)
					{
						m_rewards.Add(goods);
						StoreUITask.HandleOneGiftStoreBuyItems(ref m_leftReward, m_rewards, successedCallback);
					}
					else
					{
						ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
						ConfigDataItemInfo configDataItemInfo = clientConfigDataLoader.GetConfigDataItemInfo(goods.Id);
						if (configDataItemInfo == null)
						{
							global::Debug.LogError(string.Format("ProcessOrderRewards does not exist item id: {0}", goods.Id));
							m_leftReward--;
							continue;
						}
						if (configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_StaticBox || configDataItemInfo.FuncType == ItemFuncType.ItemFuncType_RandomBox)
						{
							BagItemUseNetTask bagItemUseNetTask = new BagItemUseNetTask(goods.GoodsType, goods.Id, goods.Count);
							bagItemUseNetTask.EventOnStop += delegate(Task task)
							{
								BagItemUseNetTask bagItemUseNetTask2 = task as BagItemUseNetTask;
								if (bagItemUseNetTask2.Result == 0)
								{
									m_rewards.AddRange(bagItemUseNetTask2.Reward);
								}
								else
								{
									m_rewards.Add(goods);
								}
								StoreUITask.HandleOneGiftStoreBuyItems(ref m_leftReward, m_rewards, successedCallback);
							};
							bagItemUseNetTask.Start(null);
						}
						else
						{
							m_rewards.Add(goods);
							StoreUITask.HandleOneGiftStoreBuyItems(ref m_leftReward, m_rewards, successedCallback);
						}
					}
					UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(StoreUITask));
					if (uitaskBase != null && uitaskBase.State == Task.TaskState.Running && StoreUITask.m_onBuyGiftStoreGoodsEvent != null)
					{
						StoreUITask.m_onBuyGiftStoreGoodsEvent(goods.Id);
					}
				}
			}
		}

		// Token: 0x0601379F RID: 79775 RVA: 0x004F808C File Offset: 0x004F628C
		public static void HandleOneGiftStoreBuyItems(ref int hasBoxNotHandle, List<Goods> rewards, Action successedCallback)
		{
			hasBoxNotHandle--;
			if (hasBoxNotHandle == 0)
			{
				UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(StoreUITask));
				if (uitaskBase != null && uitaskBase.State == Task.TaskState.Running)
				{
					GetRewardGoodsUITask orderGetRewardGoodsUITask = GetRewardGoodsUITask.StartUITask(rewards);
					if (StoreUITask.m_orderGetRewardGoodsUITask == null)
					{
						StoreUITask.m_orderGetRewardUICloseCallback = successedCallback;
						StoreUITask.m_orderGetRewardGoodsUITask = orderGetRewardGoodsUITask;
						Task orderGetRewardGoodsUITask2 = StoreUITask.m_orderGetRewardGoodsUITask;
						if (StoreUITask.<>f__mg$cache3 == null)
						{
							StoreUITask.<>f__mg$cache3 = new Action<Task>(StoreUITask.StaticGetRewardGoodsUITask_OnStop);
						}
						orderGetRewardGoodsUITask2.EventOnStop += StoreUITask.<>f__mg$cache3;
						GetRewardGoodsUITask orderGetRewardGoodsUITask3 = StoreUITask.m_orderGetRewardGoodsUITask;
						if (StoreUITask.<>f__mg$cache4 == null)
						{
							StoreUITask.<>f__mg$cache4 = new Action(StoreUITask.StaticGetRewardGoodsUITask_OnClose);
						}
						orderGetRewardGoodsUITask3.EventOnClose += StoreUITask.<>f__mg$cache4;
					}
				}
				else if (successedCallback != null)
				{
					successedCallback();
				}
			}
		}

		// Token: 0x060137A0 RID: 79776 RVA: 0x004F8144 File Offset: 0x004F6344
		public static void StaticGetRewardGoodsUITask_OnStop(Task task)
		{
			if (StoreUITask.m_orderGetRewardGoodsUITask == task)
			{
				Task orderGetRewardGoodsUITask = StoreUITask.m_orderGetRewardGoodsUITask;
				if (StoreUITask.<>f__mg$cache5 == null)
				{
					StoreUITask.<>f__mg$cache5 = new Action<Task>(StoreUITask.StaticGetRewardGoodsUITask_OnStop);
				}
				orderGetRewardGoodsUITask.EventOnStop -= StoreUITask.<>f__mg$cache5;
				GetRewardGoodsUITask orderGetRewardGoodsUITask2 = StoreUITask.m_orderGetRewardGoodsUITask;
				if (StoreUITask.<>f__mg$cache6 == null)
				{
					StoreUITask.<>f__mg$cache6 = new Action(StoreUITask.StaticGetRewardGoodsUITask_OnClose);
				}
				orderGetRewardGoodsUITask2.EventOnClose -= StoreUITask.<>f__mg$cache6;
				StoreUITask.m_orderGetRewardGoodsUITask = null;
				if (StoreUITask.m_orderGetRewardUICloseCallback != null)
				{
					StoreUITask.m_orderGetRewardUICloseCallback();
					StoreUITask.m_orderGetRewardUICloseCallback = null;
				}
			}
		}

		// Token: 0x060137A1 RID: 79777 RVA: 0x004F81CC File Offset: 0x004F63CC
		public static void StaticGetRewardGoodsUITask_OnClose()
		{
			if (StoreUITask.m_orderGetRewardGoodsUITask != null)
			{
				StoreUITask.StaticGetRewardGoodsUITask_OnStop(StoreUITask.m_orderGetRewardGoodsUITask);
			}
		}

		// Token: 0x17003A9B RID: 15003
		// (get) Token: 0x060137A2 RID: 79778 RVA: 0x004F81E4 File Offset: 0x004F63E4
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x17003A9C RID: 15004
		// (get) Token: 0x060137A3 RID: 79779 RVA: 0x004F8258 File Offset: 0x004F6458
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x14000441 RID: 1089
		// (add) Token: 0x060137A4 RID: 79780 RVA: 0x004F82CC File Offset: 0x004F64CC
		// (remove) Token: 0x060137A5 RID: 79781 RVA: 0x004F8300 File Offset: 0x004F6500
		[DebuggerBrowsable(DebuggerBrowsableState.Never)]
		public static event Action<int> m_onBuyGiftStoreGoodsEvent;

		// Token: 0x17003A9D RID: 15005
		// (get) Token: 0x060137A6 RID: 79782 RVA: 0x004F8334 File Offset: 0x004F6534
		// (set) Token: 0x060137A7 RID: 79783 RVA: 0x004F8354 File Offset: 0x004F6554
		[DoNotToLua]
		public new StoreUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StoreUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060137A8 RID: 79784 RVA: 0x004F8360 File Offset: 0x004F6560
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x060137A9 RID: 79785 RVA: 0x004F836C File Offset: 0x004F656C
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x060137AA RID: 79786 RVA: 0x004F8374 File Offset: 0x004F6574
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x060137AB RID: 79787 RVA: 0x004F837C File Offset: 0x004F657C
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x060137AC RID: 79788 RVA: 0x004F8388 File Offset: 0x004F6588
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x060137AD RID: 79789 RVA: 0x004F8394 File Offset: 0x004F6594
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x060137AE RID: 79790 RVA: 0x004F83A0 File Offset: 0x004F65A0
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x060137AF RID: 79791 RVA: 0x004F83A8 File Offset: 0x004F65A8
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060137B0 RID: 79792 RVA: 0x004F83B0 File Offset: 0x004F65B0
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060137B1 RID: 79793 RVA: 0x004F83B8 File Offset: 0x004F65B8
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060137B2 RID: 79794 RVA: 0x004F83C0 File Offset: 0x004F65C0
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060137B3 RID: 79795 RVA: 0x004F83C8 File Offset: 0x004F65C8
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060137B4 RID: 79796 RVA: 0x004F83D0 File Offset: 0x004F65D0
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060137B5 RID: 79797 RVA: 0x004F83D8 File Offset: 0x004F65D8
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060137B6 RID: 79798 RVA: 0x004F83E4 File Offset: 0x004F65E4
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060137B7 RID: 79799 RVA: 0x004F83F0 File Offset: 0x004F65F0
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060137B8 RID: 79800 RVA: 0x004F83FC File Offset: 0x004F65FC
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060137B9 RID: 79801 RVA: 0x004F8408 File Offset: 0x004F6608
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060137BA RID: 79802 RVA: 0x004F8410 File Offset: 0x004F6610
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060137BB RID: 79803 RVA: 0x004F8418 File Offset: 0x004F6618
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060137BC RID: 79804 RVA: 0x004F8420 File Offset: 0x004F6620
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060137BD RID: 79805 RVA: 0x004F8428 File Offset: 0x004F6628
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060137BE RID: 79806 RVA: 0x004F8430 File Offset: 0x004F6630
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060137BF RID: 79807 RVA: 0x004F8438 File Offset: 0x004F6638
		private static void __callDele_m_onBuyGiftStoreGoodsEvent(int obj)
		{
			Action<int> onBuyGiftStoreGoodsEvent = StoreUITask.m_onBuyGiftStoreGoodsEvent;
			if (onBuyGiftStoreGoodsEvent != null)
			{
				onBuyGiftStoreGoodsEvent(obj);
			}
		}

		// Token: 0x060137C0 RID: 79808 RVA: 0x004F8458 File Offset: 0x004F6658
		private static void __clearDele_m_onBuyGiftStoreGoodsEvent(int obj)
		{
			StoreUITask.m_onBuyGiftStoreGoodsEvent = null;
		}

		// Token: 0x060137CC RID: 79820 RVA: 0x004F8764 File Offset: 0x004F6964
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
				result = false;
			}
			else
			{
				luaFunction.call(new object[]
				{
					this,
					this.m_luaObjHelper
				});
				LuaTable luaObj = this.m_luaObjHelper.GetLuaObj();
				if (luaObj == null)
				{
					result = false;
				}
				else
				{
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnPDSDKPayCancel_hotfix = (luaObj.RawGet("OnPDSDKPayCancel") as LuaFunction);
					this.m_OnPDSDKPayFailed_hotfix = (luaObj.RawGet("OnPDSDKPayFailed") as LuaFunction);
					this.m_OnPDSDKPaySuccess_hotfix = (luaObj.RawGet("OnPDSDKPaySuccess") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnNewIntentUIIntent_hotfix = (luaObj.RawGet("OnNewIntent") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_StoreUIController_OnClose_hotfix = (luaObj.RawGet("StoreUIController_OnClose") as LuaFunction);
					this.m_StoreUIController_OnChangeStoreStoreId_hotfix = (luaObj.RawGet("StoreUIController_OnChangeStore") as LuaFunction);
					this.m_StoreUIController_OnFixedStoreHeroSkinItemClickStoreHeroSkinItemUIController_hotfix = (luaObj.RawGet("StoreUIController_OnFixedStoreHeroSkinItemClick") as LuaFunction);
					this.m_StoreUIController_OnFixedStoreSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix = (luaObj.RawGet("StoreUIController_OnFixedStoreSoldierSkinItemClick") as LuaFunction);
					this.m_StoreUIController_OnFixedStoreItemBuyStoreIdInt32Int32Int32List`1_hotfix = (luaObj.RawGet("StoreUIController_OnFixedStoreItemBuy") as LuaFunction);
					this.m_StoreUIController_OnFixedStoreBoxBuyStoreIdInt32Int32List`1_hotfix = (luaObj.RawGet("StoreUIController_OnFixedStoreBoxBuy") as LuaFunction);
					this.m_StoreUIController_OnRandomStoreItemBuyStoreIdInt32List`1_hotfix = (luaObj.RawGet("StoreUIController_OnRandomStoreItemBuy") as LuaFunction);
					this.m_StoreUIController_OnRandomStoreBoxBuyStoreIdInt32Int32List`1_hotfix = (luaObj.RawGet("StoreUIController_OnRandomStoreBoxBuy") as LuaFunction);
					this.m_StoreUIController_GetRandomStoreStoreId_hotfix = (luaObj.RawGet("StoreUIController_GetRandomStore") as LuaFunction);
					this.m_StoreUIController_RefreshRandomStoreStoreId_hotfix = (luaObj.RawGet("StoreUIController_RefreshRandomStore") as LuaFunction);
					this.m_StoreUIController_OMemoryExtractionButtonClickAction_hotfix = (luaObj.RawGet("StoreUIController_OMemoryExtractionButtonClick") as LuaFunction);
					this.m_StoreListUIController_OnSkinItemOutOfDate_hotfix = (luaObj.RawGet("StoreListUIController_OnSkinItemOutOfDate") as LuaFunction);
					this.m_StoreUIController_OnRechargeStoreBuyStoreTypeInt32Int32_hotfix = (luaObj.RawGet("StoreUIController_OnRechargeStoreBuy") as LuaFunction);
					this.m_SendStoreItemCancelBuyReq_hotfix = (luaObj.RawGet("SendStoreItemCancelBuyReq") as LuaFunction);
					this.m_SendCheckOnlineReq_hotfix = (luaObj.RawGet("SendCheckOnlineReq") as LuaFunction);
					this.m_ClearBuyingGoodsCache_hotfix = (luaObj.RawGet("ClearBuyingGoodsCache") as LuaFunction);
					this.m_StoreUIController_OnGiftStoreBuyConfigDataGiftStoreItemInfoBooleanInt32_hotfix = (luaObj.RawGet("StoreUIController_OnGiftStoreBuy") as LuaFunction);
					this.m_SendGiftStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix = (luaObj.RawGet("SendGiftStoreBuyStoreItemReq") as LuaFunction);
					this.m_SendGiftStoreAppleSubscribeItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix = (luaObj.RawGet("SendGiftStoreAppleSubscribeItemReq") as LuaFunction);
					this.m_SendRechargeStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix = (luaObj.RawGet("SendRechargeStoreBuyStoreItemReq") as LuaFunction);
					this.m_PlayerContex_OnGiftStoreBuyNtfString_hotfix = (luaObj.RawGet("PlayerContex_OnGiftStoreBuyNtf") as LuaFunction);
					this.m_PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf_hotfix = (luaObj.RawGet("PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf") as LuaFunction);
					this.m_PlayerContext_OnPlayerInfoInitEnd_hotfix = (luaObj.RawGet("PlayerContext_OnPlayerInfoInitEnd") as LuaFunction);
					this.m_HandleBoxOpenNetTaskGoodsTypeInt32Int32Action`1Action_hotfix = (luaObj.RawGet("HandleBoxOpenNetTask") as LuaFunction);
					this.m_PlayerContext_OnRechargeNoughtSuccessNtfString_hotfix = (luaObj.RawGet("PlayerContext_OnRechargeNoughtSuccessNtf") as LuaFunction);
					this.m_StoreListUIController_OpenAddGoldStore_hotfix = (luaObj.RawGet("StoreListUIController_OpenAddGoldStore") as LuaFunction);
					this.m_StoreListUIController_OpenAddCrystalStore_hotfix = (luaObj.RawGet("StoreListUIController_OpenAddCrystalStore") as LuaFunction);
					this.m_StoreUIController_CrystalNotEnough_hotfix = (luaObj.RawGet("StoreUIController_CrystalNotEnough") as LuaFunction);
					this.m_StoreUIController_OnExtraCurrencyBuyGoodsType_hotfix = (luaObj.RawGet("StoreUIController_OnExtraCurrencyBuy") as LuaFunction);
					this.m_UpdateViewAndOpenRewardGoodsUIList`1_hotfix = (luaObj.RawGet("UpdateViewAndOpenRewardGoodsUI") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060137CD RID: 79821 RVA: 0x004F8C7C File Offset: 0x004F6E7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StoreUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400ACD3 RID: 44243
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "StoreListUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Store_ABS/Prefab/StoreUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400ACD4 RID: 44244
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "StoreListUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.StoreListUIController"),
				m_ctrlName = "StoreListUIController"
			}
		};

		// Token: 0x0400ACD5 RID: 44245
		private StoreListUIController m_storeListUIController;

		// Token: 0x0400ACD6 RID: 44246
		private int m_nowSecond;

		// Token: 0x0400ACD7 RID: 44247
		private ProjectLPlayerContext m_playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;

		// Token: 0x0400ACD8 RID: 44248
		private ClientConfigDataLoader m_configdataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;

		// Token: 0x0400ACD9 RID: 44249
		private static List<PDSDKGood> m_pdsdkGoods = new List<PDSDKGood>();

		// Token: 0x0400ACDA RID: 44250
		private string m_curBuyingGoodsId;

		// Token: 0x0400ACDB RID: 44251
		public const string ParamsKey_StoreInfoId = "StoreInfoID";

		// Token: 0x0400ACDC RID: 44252
		public const string ParamsKey_StoreItemId = "StoreItemId";

		// Token: 0x0400ACDD RID: 44253
		public const string ParamsKey_IsShowExtractionPanel = "IsShowExtractionPanel";

		// Token: 0x0400ACDE RID: 44254
		private StoreId m_storeId;

		// Token: 0x0400ACE0 RID: 44256
		public static GetRewardGoodsUITask m_orderGetRewardGoodsUITask;

		// Token: 0x0400ACE1 RID: 44257
		public static Action m_orderGetRewardUICloseCallback;

		// Token: 0x0400ACE2 RID: 44258
		[DoNotToLua]
		private StoreUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400ACE3 RID: 44259
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x0400ACE4 RID: 44260
		[CompilerGenerated]
		private static Action <>f__mg$cache1;

		// Token: 0x0400ACE5 RID: 44261
		[CompilerGenerated]
		private static Action<bool> <>f__mg$cache2;

		// Token: 0x0400ACEA RID: 44266
		[CompilerGenerated]
		private static Action<Task> <>f__mg$cache3;

		// Token: 0x0400ACEB RID: 44267
		[CompilerGenerated]
		private static Action <>f__mg$cache4;

		// Token: 0x0400ACEC RID: 44268
		[CompilerGenerated]
		private static Action<Task> <>f__mg$cache5;

		// Token: 0x0400ACED RID: 44269
		[CompilerGenerated]
		private static Action <>f__mg$cache6;

		// Token: 0x0400ACEE RID: 44270
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400ACEF RID: 44271
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400ACF0 RID: 44272
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400ACF1 RID: 44273
		private LuaFunction m_OnPDSDKPayCancel_hotfix;

		// Token: 0x0400ACF2 RID: 44274
		private LuaFunction m_OnPDSDKPayFailed_hotfix;

		// Token: 0x0400ACF3 RID: 44275
		private LuaFunction m_OnPDSDKPaySuccess_hotfix;

		// Token: 0x0400ACF4 RID: 44276
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400ACF5 RID: 44277
		private LuaFunction m_OnNewIntentUIIntent_hotfix;

		// Token: 0x0400ACF6 RID: 44278
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400ACF7 RID: 44279
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400ACF8 RID: 44280
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400ACF9 RID: 44281
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400ACFA RID: 44282
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400ACFB RID: 44283
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400ACFC RID: 44284
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400ACFD RID: 44285
		private LuaFunction m_StoreUIController_OnClose_hotfix;

		// Token: 0x0400ACFE RID: 44286
		private LuaFunction m_StoreUIController_OnChangeStoreStoreId_hotfix;

		// Token: 0x0400ACFF RID: 44287
		private LuaFunction m_StoreUIController_OnFixedStoreHeroSkinItemClickStoreHeroSkinItemUIController_hotfix;

		// Token: 0x0400AD00 RID: 44288
		private LuaFunction m_StoreUIController_OnFixedStoreSoldierSkinItemClickStoreSoldierSkinItemUIController_hotfix;

		// Token: 0x0400AD01 RID: 44289
		private LuaFunction m_StoreUIController_OnFixedStoreItemBuyStoreIdInt32Int32Int32List;

		// Token: 0x0400AD02 RID: 44290
		private LuaFunction m_StoreUIController_OnFixedStoreBoxBuyStoreIdInt32Int32List;

		// Token: 0x0400AD03 RID: 44291
		private LuaFunction m_StoreUIController_OnRandomStoreItemBuyStoreIdInt32List;

		// Token: 0x0400AD04 RID: 44292
		private LuaFunction m_StoreUIController_OnRandomStoreBoxBuyStoreIdInt32Int32List;

		// Token: 0x0400AD05 RID: 44293
		private LuaFunction m_StoreUIController_GetRandomStoreStoreId_hotfix;

		// Token: 0x0400AD06 RID: 44294
		private LuaFunction m_StoreUIController_RefreshRandomStoreStoreId_hotfix;

		// Token: 0x0400AD07 RID: 44295
		private LuaFunction m_StoreUIController_OMemoryExtractionButtonClickAction_hotfix;

		// Token: 0x0400AD08 RID: 44296
		private LuaFunction m_StoreListUIController_OnSkinItemOutOfDate_hotfix;

		// Token: 0x0400AD09 RID: 44297
		private LuaFunction m_StoreUIController_OnRechargeStoreBuyStoreTypeInt32Int32_hotfix;

		// Token: 0x0400AD0A RID: 44298
		private LuaFunction m_SendStoreItemCancelBuyReq_hotfix;

		// Token: 0x0400AD0B RID: 44299
		private LuaFunction m_SendCheckOnlineReq_hotfix;

		// Token: 0x0400AD0C RID: 44300
		private LuaFunction m_ClearBuyingGoodsCache_hotfix;

		// Token: 0x0400AD0D RID: 44301
		private LuaFunction m_StoreUIController_OnGiftStoreBuyConfigDataGiftStoreItemInfoBooleanInt32_hotfix;

		// Token: 0x0400AD0E RID: 44302
		private LuaFunction m_SendGiftStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix;

		// Token: 0x0400AD0F RID: 44303
		private LuaFunction m_SendGiftStoreAppleSubscribeItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix;

		// Token: 0x0400AD10 RID: 44304
		private LuaFunction m_SendRechargeStoreBuyStoreItemReqStoreTypeInt32Int32PDSDKGoodType_hotfix;

		// Token: 0x0400AD11 RID: 44305
		private LuaFunction m_PlayerContex_OnGiftStoreBuyNtfString_hotfix;

		// Token: 0x0400AD12 RID: 44306
		private LuaFunction m_PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf_hotfix;

		// Token: 0x0400AD13 RID: 44307
		private LuaFunction m_PlayerContext_OnPlayerInfoInitEnd_hotfix;

		// Token: 0x0400AD14 RID: 44308
		private LuaFunction m_HandleBoxOpenNetTaskGoodsTypeInt32Int32Action;

		// Token: 0x0400AD15 RID: 44309
		private LuaFunction m_PlayerContext_OnRechargeNoughtSuccessNtfString_hotfix;

		// Token: 0x0400AD16 RID: 44310
		private LuaFunction m_StoreListUIController_OpenAddGoldStore_hotfix;

		// Token: 0x0400AD17 RID: 44311
		private LuaFunction m_StoreListUIController_OpenAddCrystalStore_hotfix;

		// Token: 0x0400AD18 RID: 44312
		private LuaFunction m_StoreUIController_CrystalNotEnough_hotfix;

		// Token: 0x0400AD19 RID: 44313
		private LuaFunction m_StoreUIController_OnExtraCurrencyBuyGoodsType_hotfix;

		// Token: 0x0400AD1A RID: 44314
		private LuaFunction m_UpdateViewAndOpenRewardGoodsUIList;

		// Token: 0x0400AD1B RID: 44315
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400AD1C RID: 44316
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000F45 RID: 3909
		public new class LuaExportHelper
		{
			// Token: 0x060137CE RID: 79822 RVA: 0x004F8CE4 File Offset: 0x004F6EE4
			public LuaExportHelper(StoreUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060137CF RID: 79823 RVA: 0x004F8CF4 File Offset: 0x004F6EF4
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060137D0 RID: 79824 RVA: 0x004F8D04 File Offset: 0x004F6F04
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060137D1 RID: 79825 RVA: 0x004F8D14 File Offset: 0x004F6F14
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060137D2 RID: 79826 RVA: 0x004F8D24 File Offset: 0x004F6F24
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060137D3 RID: 79827 RVA: 0x004F8D34 File Offset: 0x004F6F34
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060137D4 RID: 79828 RVA: 0x004F8D44 File Offset: 0x004F6F44
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060137D5 RID: 79829 RVA: 0x004F8D54 File Offset: 0x004F6F54
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060137D6 RID: 79830 RVA: 0x004F8D64 File Offset: 0x004F6F64
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060137D7 RID: 79831 RVA: 0x004F8D74 File Offset: 0x004F6F74
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060137D8 RID: 79832 RVA: 0x004F8D84 File Offset: 0x004F6F84
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060137D9 RID: 79833 RVA: 0x004F8D94 File Offset: 0x004F6F94
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060137DA RID: 79834 RVA: 0x004F8DA4 File Offset: 0x004F6FA4
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060137DB RID: 79835 RVA: 0x004F8DB4 File Offset: 0x004F6FB4
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060137DC RID: 79836 RVA: 0x004F8DC4 File Offset: 0x004F6FC4
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060137DD RID: 79837 RVA: 0x004F8DD4 File Offset: 0x004F6FD4
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060137DE RID: 79838 RVA: 0x004F8DE4 File Offset: 0x004F6FE4
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060137DF RID: 79839 RVA: 0x004F8DF4 File Offset: 0x004F6FF4
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060137E0 RID: 79840 RVA: 0x004F8E04 File Offset: 0x004F7004
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060137E1 RID: 79841 RVA: 0x004F8E14 File Offset: 0x004F7014
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060137E2 RID: 79842 RVA: 0x004F8E24 File Offset: 0x004F7024
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060137E3 RID: 79843 RVA: 0x004F8E34 File Offset: 0x004F7034
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060137E4 RID: 79844 RVA: 0x004F8E44 File Offset: 0x004F7044
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060137E5 RID: 79845 RVA: 0x004F8E54 File Offset: 0x004F7054
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060137E6 RID: 79846 RVA: 0x004F8E64 File Offset: 0x004F7064
			public static void __callDele_m_onBuyGiftStoreGoodsEvent(int obj)
			{
				StoreUITask.__callDele_m_onBuyGiftStoreGoodsEvent(obj);
			}

			// Token: 0x060137E7 RID: 79847 RVA: 0x004F8E6C File Offset: 0x004F706C
			public static void __clearDele_m_onBuyGiftStoreGoodsEvent(int obj)
			{
				StoreUITask.__clearDele_m_onBuyGiftStoreGoodsEvent(obj);
			}

			// Token: 0x17003A9E RID: 15006
			// (get) Token: 0x060137E8 RID: 79848 RVA: 0x004F8E74 File Offset: 0x004F7074
			// (set) Token: 0x060137E9 RID: 79849 RVA: 0x004F8E84 File Offset: 0x004F7084
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x17003A9F RID: 15007
			// (get) Token: 0x060137EA RID: 79850 RVA: 0x004F8E94 File Offset: 0x004F7094
			// (set) Token: 0x060137EB RID: 79851 RVA: 0x004F8EA4 File Offset: 0x004F70A4
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x17003AA0 RID: 15008
			// (get) Token: 0x060137EC RID: 79852 RVA: 0x004F8EB4 File Offset: 0x004F70B4
			// (set) Token: 0x060137ED RID: 79853 RVA: 0x004F8EC4 File Offset: 0x004F70C4
			public StoreListUIController m_storeListUIController
			{
				get
				{
					return this.m_owner.m_storeListUIController;
				}
				set
				{
					this.m_owner.m_storeListUIController = value;
				}
			}

			// Token: 0x17003AA1 RID: 15009
			// (get) Token: 0x060137EE RID: 79854 RVA: 0x004F8ED4 File Offset: 0x004F70D4
			// (set) Token: 0x060137EF RID: 79855 RVA: 0x004F8EE4 File Offset: 0x004F70E4
			public int m_nowSecond
			{
				get
				{
					return this.m_owner.m_nowSecond;
				}
				set
				{
					this.m_owner.m_nowSecond = value;
				}
			}

			// Token: 0x17003AA2 RID: 15010
			// (get) Token: 0x060137F0 RID: 79856 RVA: 0x004F8EF4 File Offset: 0x004F70F4
			// (set) Token: 0x060137F1 RID: 79857 RVA: 0x004F8F04 File Offset: 0x004F7104
			public ProjectLPlayerContext m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x17003AA3 RID: 15011
			// (get) Token: 0x060137F2 RID: 79858 RVA: 0x004F8F14 File Offset: 0x004F7114
			// (set) Token: 0x060137F3 RID: 79859 RVA: 0x004F8F24 File Offset: 0x004F7124
			public ClientConfigDataLoader m_configdataLoader
			{
				get
				{
					return this.m_owner.m_configdataLoader;
				}
				set
				{
					this.m_owner.m_configdataLoader = value;
				}
			}

			// Token: 0x17003AA4 RID: 15012
			// (get) Token: 0x060137F4 RID: 79860 RVA: 0x004F8F34 File Offset: 0x004F7134
			// (set) Token: 0x060137F5 RID: 79861 RVA: 0x004F8F3C File Offset: 0x004F713C
			public static List<PDSDKGood> m_pdsdkGoods
			{
				get
				{
					return StoreUITask.m_pdsdkGoods;
				}
				set
				{
					StoreUITask.m_pdsdkGoods = value;
				}
			}

			// Token: 0x17003AA5 RID: 15013
			// (get) Token: 0x060137F6 RID: 79862 RVA: 0x004F8F44 File Offset: 0x004F7144
			// (set) Token: 0x060137F7 RID: 79863 RVA: 0x004F8F54 File Offset: 0x004F7154
			public string m_curBuyingGoodsId
			{
				get
				{
					return this.m_owner.m_curBuyingGoodsId;
				}
				set
				{
					this.m_owner.m_curBuyingGoodsId = value;
				}
			}

			// Token: 0x17003AA6 RID: 15014
			// (get) Token: 0x060137F8 RID: 79864 RVA: 0x004F8F64 File Offset: 0x004F7164
			// (set) Token: 0x060137F9 RID: 79865 RVA: 0x004F8F74 File Offset: 0x004F7174
			public StoreId m_storeId
			{
				get
				{
					return this.m_owner.m_storeId;
				}
				set
				{
					this.m_owner.m_storeId = value;
				}
			}

			// Token: 0x17003AA7 RID: 15015
			// (get) Token: 0x060137FA RID: 79866 RVA: 0x004F8F84 File Offset: 0x004F7184
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003AA8 RID: 15016
			// (get) Token: 0x060137FB RID: 79867 RVA: 0x004F8F94 File Offset: 0x004F7194
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060137FC RID: 79868 RVA: 0x004F8FA4 File Offset: 0x004F71A4
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060137FD RID: 79869 RVA: 0x004F8FB4 File Offset: 0x004F71B4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060137FE RID: 79870 RVA: 0x004F8FC4 File Offset: 0x004F71C4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060137FF RID: 79871 RVA: 0x004F8FD4 File Offset: 0x004F71D4
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06013800 RID: 79872 RVA: 0x004F8FE4 File Offset: 0x004F71E4
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06013801 RID: 79873 RVA: 0x004F8FF4 File Offset: 0x004F71F4
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06013802 RID: 79874 RVA: 0x004F9004 File Offset: 0x004F7204
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06013803 RID: 79875 RVA: 0x004F9014 File Offset: 0x004F7214
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06013804 RID: 79876 RVA: 0x004F9024 File Offset: 0x004F7224
			public void StoreUIController_OnClose()
			{
				this.m_owner.StoreUIController_OnClose();
			}

			// Token: 0x06013805 RID: 79877 RVA: 0x004F9034 File Offset: 0x004F7234
			public void StoreUIController_OnChangeStore(StoreId storeId)
			{
				this.m_owner.StoreUIController_OnChangeStore(storeId);
			}

			// Token: 0x06013806 RID: 79878 RVA: 0x004F9044 File Offset: 0x004F7244
			public void StoreUIController_OnFixedStoreHeroSkinItemClick(StoreHeroSkinItemUIController itemCtrl)
			{
				this.m_owner.StoreUIController_OnFixedStoreHeroSkinItemClick(itemCtrl);
			}

			// Token: 0x06013807 RID: 79879 RVA: 0x004F9054 File Offset: 0x004F7254
			public void StoreUIController_OnFixedStoreSoldierSkinItemClick(StoreSoldierSkinItemUIController itemCtrl)
			{
				this.m_owner.StoreUIController_OnFixedStoreSoldierSkinItemClick(itemCtrl);
			}

			// Token: 0x06013808 RID: 79880 RVA: 0x004F9064 File Offset: 0x004F7264
			public void StoreUIController_OnFixedStoreItemBuy(StoreId fixedStoreID, int fixedStoreItemGoodsID, int goodsId, int selfChooseItemIndex, List<Goods> gainGoodsList)
			{
				this.m_owner.StoreUIController_OnFixedStoreItemBuy(fixedStoreID, fixedStoreItemGoodsID, goodsId, selfChooseItemIndex, gainGoodsList);
			}

			// Token: 0x06013809 RID: 79881 RVA: 0x004F9078 File Offset: 0x004F7278
			public void StoreUIController_OnFixedStoreBoxBuy(StoreId fixedStoreID, int fixedStoreItemGoodsID, int goodsID, List<Goods> gainGoodsList)
			{
				this.m_owner.StoreUIController_OnFixedStoreBoxBuy(fixedStoreID, fixedStoreItemGoodsID, goodsID, gainGoodsList);
			}

			// Token: 0x0601380A RID: 79882 RVA: 0x004F908C File Offset: 0x004F728C
			public void StoreUIController_OnRandomStoreItemBuy(StoreId randomStoreId, int index, List<Goods> gainGoodsList)
			{
				this.m_owner.StoreUIController_OnRandomStoreItemBuy(randomStoreId, index, gainGoodsList);
			}

			// Token: 0x0601380B RID: 79883 RVA: 0x004F909C File Offset: 0x004F729C
			public void StoreUIController_OnRandomStoreBoxBuy(StoreId randomStoreId, int index, int goodsID, List<Goods> gainGoodsList)
			{
				this.m_owner.StoreUIController_OnRandomStoreBoxBuy(randomStoreId, index, goodsID, gainGoodsList);
			}

			// Token: 0x0601380C RID: 79884 RVA: 0x004F90B0 File Offset: 0x004F72B0
			public void StoreUIController_GetRandomStore(StoreId randomStoreId)
			{
				this.m_owner.StoreUIController_GetRandomStore(randomStoreId);
			}

			// Token: 0x0601380D RID: 79885 RVA: 0x004F90C0 File Offset: 0x004F72C0
			public void StoreUIController_RefreshRandomStore(StoreId randomStoreId)
			{
				this.m_owner.StoreUIController_RefreshRandomStore(randomStoreId);
			}

			// Token: 0x0601380E RID: 79886 RVA: 0x004F90D0 File Offset: 0x004F72D0
			public void StoreUIController_OMemoryExtractionButtonClick(Action OnSucced)
			{
				this.m_owner.StoreUIController_OMemoryExtractionButtonClick(OnSucced);
			}

			// Token: 0x0601380F RID: 79887 RVA: 0x004F90E0 File Offset: 0x004F72E0
			public void StoreListUIController_OnSkinItemOutOfDate()
			{
				this.m_owner.StoreListUIController_OnSkinItemOutOfDate();
			}

			// Token: 0x06013810 RID: 79888 RVA: 0x004F90F0 File Offset: 0x004F72F0
			public void StoreUIController_OnRechargeStoreBuy(StoreType storeType, int itemGoodsId, int number)
			{
				this.m_owner.StoreUIController_OnRechargeStoreBuy(storeType, itemGoodsId, number);
			}

			// Token: 0x06013811 RID: 79889 RVA: 0x004F9100 File Offset: 0x004F7300
			public void SendStoreItemCancelBuyReq()
			{
				this.m_owner.SendStoreItemCancelBuyReq();
			}

			// Token: 0x06013812 RID: 79890 RVA: 0x004F9110 File Offset: 0x004F7310
			public void SendCheckOnlineReq()
			{
				this.m_owner.SendCheckOnlineReq();
			}

			// Token: 0x06013813 RID: 79891 RVA: 0x004F9120 File Offset: 0x004F7320
			public void ClearBuyingGoodsCache()
			{
				this.m_owner.ClearBuyingGoodsCache();
			}

			// Token: 0x06013814 RID: 79892 RVA: 0x004F9130 File Offset: 0x004F7330
			public void StoreUIController_OnGiftStoreBuy(ConfigDataGiftStoreItemInfo giftStoreItem, bool isfristBuy, int number)
			{
				this.m_owner.StoreUIController_OnGiftStoreBuy(giftStoreItem, isfristBuy, number);
			}

			// Token: 0x06013815 RID: 79893 RVA: 0x004F9140 File Offset: 0x004F7340
			public void SendGiftStoreBuyStoreItemReq(StoreType storeType, int goodsId, int number, PDSDKGoodType pdsdkGoodType)
			{
				this.m_owner.SendGiftStoreBuyStoreItemReq(storeType, goodsId, number, pdsdkGoodType);
			}

			// Token: 0x06013816 RID: 79894 RVA: 0x004F9154 File Offset: 0x004F7354
			public void SendGiftStoreAppleSubscribeItemReq(StoreType storeType, int goodsId, int number, PDSDKGoodType pdsdkGoodType)
			{
				this.m_owner.SendGiftStoreAppleSubscribeItemReq(storeType, goodsId, number, pdsdkGoodType);
			}

			// Token: 0x06013817 RID: 79895 RVA: 0x004F9168 File Offset: 0x004F7368
			public void SendRechargeStoreBuyStoreItemReq(StoreType storeType, int goodsId, int number, PDSDKGoodType pdsdkGoodType)
			{
				this.m_owner.SendRechargeStoreBuyStoreItemReq(storeType, goodsId, number, pdsdkGoodType);
			}

			// Token: 0x06013818 RID: 79896 RVA: 0x004F917C File Offset: 0x004F737C
			public void PlayerContex_OnGiftStoreBuyNtf(string orderId)
			{
				this.m_owner.PlayerContex_OnGiftStoreBuyNtf(orderId);
			}

			// Token: 0x06013819 RID: 79897 RVA: 0x004F918C File Offset: 0x004F738C
			public void PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf()
			{
				this.m_owner.PlayerContex_OnGiftStoreOperationalGoodsUpdateNtf();
			}

			// Token: 0x0601381A RID: 79898 RVA: 0x004F919C File Offset: 0x004F739C
			public void PlayerContext_OnPlayerInfoInitEnd()
			{
				this.m_owner.PlayerContext_OnPlayerInfoInitEnd();
			}

			// Token: 0x0601381B RID: 79899 RVA: 0x004F91AC File Offset: 0x004F73AC
			public void HandleBoxOpenNetTask(GoodsType type, int id, int count, Action<List<Goods>> successedCallback, Action failedCallback)
			{
				this.m_owner.HandleBoxOpenNetTask(type, id, count, successedCallback, failedCallback);
			}

			// Token: 0x0601381C RID: 79900 RVA: 0x004F91C0 File Offset: 0x004F73C0
			public void PlayerContext_OnRechargeNoughtSuccessNtf(string orderId)
			{
				this.m_owner.PlayerContext_OnRechargeNoughtSuccessNtf(orderId);
			}

			// Token: 0x0601381D RID: 79901 RVA: 0x004F91D0 File Offset: 0x004F73D0
			public void StoreListUIController_OpenAddGoldStore()
			{
				this.m_owner.StoreListUIController_OpenAddGoldStore();
			}

			// Token: 0x0601381E RID: 79902 RVA: 0x004F91E0 File Offset: 0x004F73E0
			public void StoreListUIController_OpenAddCrystalStore()
			{
				this.m_owner.StoreListUIController_OpenAddCrystalStore();
			}

			// Token: 0x0601381F RID: 79903 RVA: 0x004F91F0 File Offset: 0x004F73F0
			public void StoreUIController_CrystalNotEnough()
			{
				this.m_owner.StoreUIController_CrystalNotEnough();
			}

			// Token: 0x06013820 RID: 79904 RVA: 0x004F9200 File Offset: 0x004F7400
			public void StoreUIController_OnExtraCurrencyBuy(GoodsType goodsType)
			{
				this.m_owner.StoreUIController_OnExtraCurrencyBuy(goodsType);
			}

			// Token: 0x06013821 RID: 79905 RVA: 0x004F9210 File Offset: 0x004F7410
			public void UpdateViewAndOpenRewardGoodsUI(List<Goods> rewardGoods)
			{
				this.m_owner.UpdateViewAndOpenRewardGoodsUI(rewardGoods);
			}

			// Token: 0x0400AD1D RID: 44317
			private StoreUITask m_owner;
		}
	}
}
