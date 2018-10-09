using System;
using System.Collections.Generic;
using System.Linq;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02001016 RID: 4118
	[HotFix]
	public class BuyEnergyUITask : UITask
	{
		// Token: 0x06014CA7 RID: 85159 RVA: 0x00545FB8 File Offset: 0x005441B8
		public BuyEnergyUITask(string name) : base(name)
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

		// Token: 0x06014CA8 RID: 85160 RVA: 0x005460AC File Offset: 0x005442AC
		public static BuyEnergyUITask StartUITask(bool showEnergyNotEnoughTips = true)
		{
			UIIntentCustom uiintentCustom = new UIIntentCustom(typeof(BuyEnergyUITask).Name, null);
			uiintentCustom.SetParam("NeedShowEnergyNotEnoughTips", showEnergyNotEnoughTips);
			return UIManager.Instance.StartUITask(uiintentCustom, true, false, null) as BuyEnergyUITask;
		}

		// Token: 0x06014CA9 RID: 85161 RVA: 0x005460F4 File Offset: 0x005442F4
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
			if (this.m_buyEnergyUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_buyEnergyUIController = (this.m_uiCtrlArray[0] as BuyEnergyUIController);
				}
				if (!(this.m_buyEnergyUIController != null))
				{
					Debug.LogError("BuyEnergyUIController is null");
					return;
				}
				this.m_buyEnergyUIController.EventOnUseEnergyMedicine += this.BuyEnergyUIController_OnUseEnergyMedicine;
				this.m_buyEnergyUIController.EventOnBuyEnergy += this.BuyEnergyUIController_OnBuyEnergy;
				this.m_buyEnergyUIController.EventOnClose += this.BuyEnergyUIController_OnClose;
			}
		}

		// Token: 0x06014CAA RID: 85162 RVA: 0x005461F4 File Offset: 0x005443F4
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
			if (this.m_buyEnergyUIController != null)
			{
				this.m_buyEnergyUIController.EventOnUseEnergyMedicine -= this.BuyEnergyUIController_OnUseEnergyMedicine;
				this.m_buyEnergyUIController.EventOnBuyEnergy -= this.BuyEnergyUIController_OnBuyEnergy;
				this.m_buyEnergyUIController.EventOnClose -= this.BuyEnergyUIController_OnClose;
				this.m_buyEnergyUIController = null;
			}
		}

		// Token: 0x06014CAB RID: 85163 RVA: 0x005462B8 File Offset: 0x005444B8
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
				this.m_buyEnergyUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int num = configDataLoader.GetAllConfigDataBuyEnergyInfo().Count<KeyValuePair<int, ConfigDataBuyEnergyInfo>>();
			ConfigDataBuyEnergyInfo configDataBuyEnergyInfo;
			if (projectLPlayerContext.GetBuyEnergyNums() + 1 >= num)
			{
				configDataBuyEnergyInfo = configDataLoader.GetConfigDataBuyEnergyInfo(num);
			}
			else
			{
				configDataBuyEnergyInfo = configDataLoader.GetConfigDataBuyEnergyInfo(projectLPlayerContext.GetBuyEnergyNums() + 1);
			}
			if (configDataBuyEnergyInfo != null)
			{
				int energyCount = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_BuyEnergyCount);
				int num2 = projectLPlayerContext.CanBuyEnergy();
				this.m_buyEnergyUIController.SetEnergy(energyCount, configDataBuyEnergyInfo.Price, num2 == -414);
			}
			else
			{
				this.m_buyEnergyUIController.SetEnergy(0, 0, false);
			}
			ConfigDataItemInfo configDataItemInfo = null;
			foreach (KeyValuePair<int, ConfigDataItemInfo> keyValuePair in configDataLoader.GetAllConfigDataItemInfo())
			{
				if (keyValuePair.Value.FuncType == ItemFuncType.ItemFuncType_Energy)
				{
					configDataItemInfo = keyValuePair.Value;
					break;
				}
			}
			if (configDataItemInfo != null)
			{
				this.m_getEnergyByUseEnergyMedicine = configDataItemInfo.FuncTypeParam1;
				int bagItemCountByType = projectLPlayerContext.GetBagItemCountByType(GoodsType.GoodsType_Item, configDataItemInfo.ID);
				if (bagItemCountByType > 0)
				{
					this.m_energyMedicineItemID = configDataItemInfo.ID;
					this.m_buyEnergyUIController.SetMedicine(this.m_getEnergyByUseEnergyMedicine, 1, bagItemCountByType);
				}
				else
				{
					this.m_buyEnergyUIController.SetMedicine(this.m_getEnergyByUseEnergyMedicine, 1, 0);
				}
			}
			else
			{
				this.m_buyEnergyUIController.SetMedicine(0, 1, 0);
			}
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			object obj;
			if (uiintentCustom != null && uiintentCustom.TryGetParam("NeedShowEnergyNotEnoughTips", out obj) && obj != null && (bool)obj)
			{
				string s = (configDataLoader as ClientConfigDataLoader).UtilityGetErrorCodeString(-402);
				this.m_buyEnergyUIController.ShowEnergyNotEnoughTip(s);
				uiintentCustom.SetParam("NeedShowEnergyNotEnoughTips", null);
			}
		}

		// Token: 0x06014CAC RID: 85164 RVA: 0x00546518 File Offset: 0x00544718
		private void StartBuyEnergyNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBuyEnergyNetTask_hotfix != null)
			{
				this.m_StartBuyEnergyNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BuyEnergyNetTask buyEnergyNetTask = new BuyEnergyNetTask();
			buyEnergyNetTask.EventOnStop += delegate(Task task)
			{
				BuyEnergyNetTask buyEnergyNetTask2 = task as BuyEnergyNetTask;
				if (buyEnergyNetTask2.Result == 0)
				{
					IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
					int energy = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_BuyEnergyCount);
					this.ShowEnergyRewardGoodsUITask(energy);
					base.Pause();
					this.m_buyEnergyUIController.Close();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(buyEnergyNetTask2.Result, 2f, null, true);
				}
				if (buyEnergyNetTask2.Result != -99)
				{
					this.UpdateView();
				}
			};
			buyEnergyNetTask.Start(null);
		}

		// Token: 0x06014CAD RID: 85165 RVA: 0x00546598 File Offset: 0x00544798
		private void StartUseEnergyMedicineNetTask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartUseEnergyMedicineNetTask_hotfix != null)
			{
				this.m_StartUseEnergyMedicineNetTask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BagItemUseNetTask bagItemUseNetTask = new BagItemUseNetTask(GoodsType.GoodsType_Item, this.m_energyMedicineItemID, 1);
			bagItemUseNetTask.EventOnStop += delegate(Task task)
			{
				BagItemUseNetTask bagItemUseNetTask2 = task as BagItemUseNetTask;
				if (bagItemUseNetTask2.Result == 0)
				{
					this.ShowEnergyRewardGoodsUITask(this.m_getEnergyByUseEnergyMedicine);
					base.Pause();
					this.m_buyEnergyUIController.Close();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(bagItemUseNetTask2.Result, 2f, null, true);
				}
			};
			bagItemUseNetTask.Start(null);
		}

		// Token: 0x06014CAE RID: 85166 RVA: 0x00546620 File Offset: 0x00544820
		private void ShowEnergyRewardGoodsUITask(int energy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ShowEnergyRewardGoodsUITaskInt32_hotfix != null)
			{
				this.m_ShowEnergyRewardGoodsUITaskInt32_hotfix.call(new object[]
				{
					this,
					energy
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Goods goods = new Goods();
			goods.GoodsType = GoodsType.GoodsType_Energy;
			goods.Count = energy;
			GetRewardGoodsUITask getRewardGoodsUITask = GetRewardGoodsUITask.StartUITask(new List<Goods>
			{
				goods
			});
			if (this.m_getRewardGoodsUITask == null)
			{
				this.m_getRewardGoodsUITask = getRewardGoodsUITask;
				this.m_getRewardGoodsUITask.EventOnClose += this.GetRewardGoodsUITask_OnClose;
			}
		}

		// Token: 0x06014CAF RID: 85167 RVA: 0x005466E4 File Offset: 0x005448E4
		private void GetRewardGoodsUITask_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardGoodsUITask_OnClose_hotfix != null)
			{
				this.m_GetRewardGoodsUITask_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_getRewardGoodsUITask == null)
			{
				return;
			}
			this.m_getRewardGoodsUITask.EventOnClose -= this.GetRewardGoodsUITask_OnClose;
			this.m_getRewardGoodsUITask = null;
			this.UpdateView();
		}

		// Token: 0x06014CB0 RID: 85168 RVA: 0x00546774 File Offset: 0x00544974
		private void BuyEnergyUIController_OnUseEnergyMedicine()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyEnergyUIController_OnUseEnergyMedicine_hotfix != null)
			{
				this.m_BuyEnergyUIController_OnUseEnergyMedicine_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanUseEnergyMedicine(this.m_energyMedicineItemID, 1);
			if (num == 0)
			{
				this.StartUseEnergyMedicineNetTask();
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06014CB1 RID: 85169 RVA: 0x00546818 File Offset: 0x00544A18
		private void BuyEnergyUIController_OnBuyEnergy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyEnergyUIController_OnBuyEnergy_hotfix != null)
			{
				this.m_BuyEnergyUIController_OnBuyEnergy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanBuyEnergy();
			if (num == 0)
			{
				this.StartBuyEnergyNetTask();
			}
			else if (num == -401)
			{
				CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Msg_CrystalNotEnough, delegate(DialogBoxResult dialogResult)
				{
					if (dialogResult == DialogBoxResult.Ok)
					{
						StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Recharge, null, false);
					}
				}, (StringTableId)0, (StringTableId)0);
			}
			else
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
			}
		}

		// Token: 0x06014CB2 RID: 85170 RVA: 0x005468E0 File Offset: 0x00544AE0
		private void BuyEnergyUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyEnergyUIController_OnClose_hotfix != null)
			{
				this.m_BuyEnergyUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Pause();
		}

		// Token: 0x17003D6E RID: 15726
		// (get) Token: 0x06014CB3 RID: 85171 RVA: 0x00546948 File Offset: 0x00544B48
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

		// Token: 0x17003D6F RID: 15727
		// (get) Token: 0x06014CB4 RID: 85172 RVA: 0x005469BC File Offset: 0x00544BBC
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

		// Token: 0x17003D70 RID: 15728
		// (get) Token: 0x06014CB5 RID: 85173 RVA: 0x00546A30 File Offset: 0x00544C30
		// (set) Token: 0x06014CB6 RID: 85174 RVA: 0x00546A50 File Offset: 0x00544C50
		[DoNotToLua]
		public new BuyEnergyUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BuyEnergyUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014CB7 RID: 85175 RVA: 0x00546A5C File Offset: 0x00544C5C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014CB8 RID: 85176 RVA: 0x00546A68 File Offset: 0x00544C68
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06014CB9 RID: 85177 RVA: 0x00546A70 File Offset: 0x00544C70
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014CBA RID: 85178 RVA: 0x00546A78 File Offset: 0x00544C78
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014CBB RID: 85179 RVA: 0x00546A84 File Offset: 0x00544C84
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014CBC RID: 85180 RVA: 0x00546A90 File Offset: 0x00544C90
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014CBD RID: 85181 RVA: 0x00546A9C File Offset: 0x00544C9C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014CBE RID: 85182 RVA: 0x00546AA4 File Offset: 0x00544CA4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014CBF RID: 85183 RVA: 0x00546AAC File Offset: 0x00544CAC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014CC0 RID: 85184 RVA: 0x00546AB4 File Offset: 0x00544CB4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06014CC1 RID: 85185 RVA: 0x00546ABC File Offset: 0x00544CBC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06014CC2 RID: 85186 RVA: 0x00546AC4 File Offset: 0x00544CC4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06014CC3 RID: 85187 RVA: 0x00546ACC File Offset: 0x00544CCC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06014CC4 RID: 85188 RVA: 0x00546AD4 File Offset: 0x00544CD4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06014CC5 RID: 85189 RVA: 0x00546AE0 File Offset: 0x00544CE0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06014CC6 RID: 85190 RVA: 0x00546AEC File Offset: 0x00544CEC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06014CC7 RID: 85191 RVA: 0x00546AF8 File Offset: 0x00544CF8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06014CC8 RID: 85192 RVA: 0x00546B04 File Offset: 0x00544D04
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06014CC9 RID: 85193 RVA: 0x00546B0C File Offset: 0x00544D0C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014CCA RID: 85194 RVA: 0x00546B14 File Offset: 0x00544D14
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014CCB RID: 85195 RVA: 0x00546B1C File Offset: 0x00544D1C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014CCC RID: 85196 RVA: 0x00546B24 File Offset: 0x00544D24
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014CCD RID: 85197 RVA: 0x00546B2C File Offset: 0x00544D2C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014CD1 RID: 85201 RVA: 0x00546C38 File Offset: 0x00544E38
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				Debug.LogError("Can't find HotFixObject Func");
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
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_StartBuyEnergyNetTask_hotfix = (luaObj.RawGet("StartBuyEnergyNetTask") as LuaFunction);
					this.m_StartUseEnergyMedicineNetTask_hotfix = (luaObj.RawGet("StartUseEnergyMedicineNetTask") as LuaFunction);
					this.m_ShowEnergyRewardGoodsUITaskInt32_hotfix = (luaObj.RawGet("ShowEnergyRewardGoodsUITask") as LuaFunction);
					this.m_GetRewardGoodsUITask_OnClose_hotfix = (luaObj.RawGet("GetRewardGoodsUITask_OnClose") as LuaFunction);
					this.m_BuyEnergyUIController_OnUseEnergyMedicine_hotfix = (luaObj.RawGet("BuyEnergyUIController_OnUseEnergyMedicine") as LuaFunction);
					this.m_BuyEnergyUIController_OnBuyEnergy_hotfix = (luaObj.RawGet("BuyEnergyUIController_OnBuyEnergy") as LuaFunction);
					this.m_BuyEnergyUIController_OnClose_hotfix = (luaObj.RawGet("BuyEnergyUIController_OnClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014CD2 RID: 85202 RVA: 0x00546E30 File Offset: 0x00545030
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BuyEnergyUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B649 RID: 46665
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BuyEnergyUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/BuyEnergyUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B64A RID: 46666
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BuyEnergyUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BuyEnergyUIController"),
				m_ctrlName = "BuyEnergyUIController"
			}
		};

		// Token: 0x0400B64B RID: 46667
		private BuyEnergyUIController m_buyEnergyUIController;

		// Token: 0x0400B64C RID: 46668
		private GetRewardGoodsUITask m_getRewardGoodsUITask;

		// Token: 0x0400B64D RID: 46669
		private int m_energyMedicineItemID;

		// Token: 0x0400B64E RID: 46670
		private int m_getEnergyByUseEnergyMedicine;

		// Token: 0x0400B64F RID: 46671
		public const string Params_NeedEnergyNotEnoughTips = "NeedShowEnergyNotEnoughTips";

		// Token: 0x0400B650 RID: 46672
		[DoNotToLua]
		private BuyEnergyUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B651 RID: 46673
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B652 RID: 46674
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B653 RID: 46675
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B654 RID: 46676
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B655 RID: 46677
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B656 RID: 46678
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B657 RID: 46679
		private LuaFunction m_StartBuyEnergyNetTask_hotfix;

		// Token: 0x0400B658 RID: 46680
		private LuaFunction m_StartUseEnergyMedicineNetTask_hotfix;

		// Token: 0x0400B659 RID: 46681
		private LuaFunction m_ShowEnergyRewardGoodsUITaskInt32_hotfix;

		// Token: 0x0400B65A RID: 46682
		private LuaFunction m_GetRewardGoodsUITask_OnClose_hotfix;

		// Token: 0x0400B65B RID: 46683
		private LuaFunction m_BuyEnergyUIController_OnUseEnergyMedicine_hotfix;

		// Token: 0x0400B65C RID: 46684
		private LuaFunction m_BuyEnergyUIController_OnBuyEnergy_hotfix;

		// Token: 0x0400B65D RID: 46685
		private LuaFunction m_BuyEnergyUIController_OnClose_hotfix;

		// Token: 0x0400B65E RID: 46686
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B65F RID: 46687
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02001017 RID: 4119
		public new class LuaExportHelper
		{
			// Token: 0x06014CD3 RID: 85203 RVA: 0x00546E98 File Offset: 0x00545098
			public LuaExportHelper(BuyEnergyUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014CD4 RID: 85204 RVA: 0x00546EA8 File Offset: 0x005450A8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06014CD5 RID: 85205 RVA: 0x00546EB8 File Offset: 0x005450B8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06014CD6 RID: 85206 RVA: 0x00546EC8 File Offset: 0x005450C8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06014CD7 RID: 85207 RVA: 0x00546ED8 File Offset: 0x005450D8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014CD8 RID: 85208 RVA: 0x00546EE8 File Offset: 0x005450E8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014CD9 RID: 85209 RVA: 0x00546EF8 File Offset: 0x005450F8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014CDA RID: 85210 RVA: 0x00546F08 File Offset: 0x00545108
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014CDB RID: 85211 RVA: 0x00546F18 File Offset: 0x00545118
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014CDC RID: 85212 RVA: 0x00546F28 File Offset: 0x00545128
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014CDD RID: 85213 RVA: 0x00546F38 File Offset: 0x00545138
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014CDE RID: 85214 RVA: 0x00546F48 File Offset: 0x00545148
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014CDF RID: 85215 RVA: 0x00546F58 File Offset: 0x00545158
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014CE0 RID: 85216 RVA: 0x00546F68 File Offset: 0x00545168
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014CE1 RID: 85217 RVA: 0x00546F78 File Offset: 0x00545178
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06014CE2 RID: 85218 RVA: 0x00546F88 File Offset: 0x00545188
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06014CE3 RID: 85219 RVA: 0x00546F98 File Offset: 0x00545198
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06014CE4 RID: 85220 RVA: 0x00546FA8 File Offset: 0x005451A8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06014CE5 RID: 85221 RVA: 0x00546FB8 File Offset: 0x005451B8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06014CE6 RID: 85222 RVA: 0x00546FC8 File Offset: 0x005451C8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06014CE7 RID: 85223 RVA: 0x00546FD8 File Offset: 0x005451D8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06014CE8 RID: 85224 RVA: 0x00546FE8 File Offset: 0x005451E8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06014CE9 RID: 85225 RVA: 0x00546FF8 File Offset: 0x005451F8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06014CEA RID: 85226 RVA: 0x00547008 File Offset: 0x00545208
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003D71 RID: 15729
			// (get) Token: 0x06014CEB RID: 85227 RVA: 0x00547018 File Offset: 0x00545218
			// (set) Token: 0x06014CEC RID: 85228 RVA: 0x00547028 File Offset: 0x00545228
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

			// Token: 0x17003D72 RID: 15730
			// (get) Token: 0x06014CED RID: 85229 RVA: 0x00547038 File Offset: 0x00545238
			// (set) Token: 0x06014CEE RID: 85230 RVA: 0x00547048 File Offset: 0x00545248
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

			// Token: 0x17003D73 RID: 15731
			// (get) Token: 0x06014CEF RID: 85231 RVA: 0x00547058 File Offset: 0x00545258
			// (set) Token: 0x06014CF0 RID: 85232 RVA: 0x00547068 File Offset: 0x00545268
			public BuyEnergyUIController m_buyEnergyUIController
			{
				get
				{
					return this.m_owner.m_buyEnergyUIController;
				}
				set
				{
					this.m_owner.m_buyEnergyUIController = value;
				}
			}

			// Token: 0x17003D74 RID: 15732
			// (get) Token: 0x06014CF1 RID: 85233 RVA: 0x00547078 File Offset: 0x00545278
			// (set) Token: 0x06014CF2 RID: 85234 RVA: 0x00547088 File Offset: 0x00545288
			public GetRewardGoodsUITask m_getRewardGoodsUITask
			{
				get
				{
					return this.m_owner.m_getRewardGoodsUITask;
				}
				set
				{
					this.m_owner.m_getRewardGoodsUITask = value;
				}
			}

			// Token: 0x17003D75 RID: 15733
			// (get) Token: 0x06014CF3 RID: 85235 RVA: 0x00547098 File Offset: 0x00545298
			// (set) Token: 0x06014CF4 RID: 85236 RVA: 0x005470A8 File Offset: 0x005452A8
			public int m_energyMedicineItemID
			{
				get
				{
					return this.m_owner.m_energyMedicineItemID;
				}
				set
				{
					this.m_owner.m_energyMedicineItemID = value;
				}
			}

			// Token: 0x17003D76 RID: 15734
			// (get) Token: 0x06014CF5 RID: 85237 RVA: 0x005470B8 File Offset: 0x005452B8
			// (set) Token: 0x06014CF6 RID: 85238 RVA: 0x005470C8 File Offset: 0x005452C8
			public int m_getEnergyByUseEnergyMedicine
			{
				get
				{
					return this.m_owner.m_getEnergyByUseEnergyMedicine;
				}
				set
				{
					this.m_owner.m_getEnergyByUseEnergyMedicine = value;
				}
			}

			// Token: 0x17003D77 RID: 15735
			// (get) Token: 0x06014CF7 RID: 85239 RVA: 0x005470D8 File Offset: 0x005452D8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003D78 RID: 15736
			// (get) Token: 0x06014CF8 RID: 85240 RVA: 0x005470E8 File Offset: 0x005452E8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06014CF9 RID: 85241 RVA: 0x005470F8 File Offset: 0x005452F8
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06014CFA RID: 85242 RVA: 0x00547108 File Offset: 0x00545308
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014CFB RID: 85243 RVA: 0x00547118 File Offset: 0x00545318
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014CFC RID: 85244 RVA: 0x00547128 File Offset: 0x00545328
			public void StartBuyEnergyNetTask()
			{
				this.m_owner.StartBuyEnergyNetTask();
			}

			// Token: 0x06014CFD RID: 85245 RVA: 0x00547138 File Offset: 0x00545338
			public void StartUseEnergyMedicineNetTask()
			{
				this.m_owner.StartUseEnergyMedicineNetTask();
			}

			// Token: 0x06014CFE RID: 85246 RVA: 0x00547148 File Offset: 0x00545348
			public void ShowEnergyRewardGoodsUITask(int energy)
			{
				this.m_owner.ShowEnergyRewardGoodsUITask(energy);
			}

			// Token: 0x06014CFF RID: 85247 RVA: 0x00547158 File Offset: 0x00545358
			public void GetRewardGoodsUITask_OnClose()
			{
				this.m_owner.GetRewardGoodsUITask_OnClose();
			}

			// Token: 0x06014D00 RID: 85248 RVA: 0x00547168 File Offset: 0x00545368
			public void BuyEnergyUIController_OnUseEnergyMedicine()
			{
				this.m_owner.BuyEnergyUIController_OnUseEnergyMedicine();
			}

			// Token: 0x06014D01 RID: 85249 RVA: 0x00547178 File Offset: 0x00545378
			public void BuyEnergyUIController_OnBuyEnergy()
			{
				this.m_owner.BuyEnergyUIController_OnBuyEnergy();
			}

			// Token: 0x06014D02 RID: 85250 RVA: 0x00547188 File Offset: 0x00545388
			public void BuyEnergyUIController_OnClose()
			{
				this.m_owner.BuyEnergyUIController_OnClose();
			}

			// Token: 0x0400B660 RID: 46688
			private BuyEnergyUITask m_owner;
		}
	}
}
