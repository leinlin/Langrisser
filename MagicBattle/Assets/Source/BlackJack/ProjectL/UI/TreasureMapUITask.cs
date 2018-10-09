using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FD1 RID: 4049
	[HotFix]
	public class TreasureMapUITask : UITask
	{
		// Token: 0x06014422 RID: 82978 RVA: 0x00527074 File Offset: 0x00525274
		public TreasureMapUITask(string name) : base(name)
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

		// Token: 0x06014423 RID: 82979 RVA: 0x005271A0 File Offset: 0x005253A0
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
			base.ClearAssetList();
			foreach (KeyValuePair<int, ConfigDataTreasureLevelInfo> keyValuePair in configDataLoader.GetAllConfigDataTreasureLevelInfo())
			{
				ConfigDataTreasureLevelInfo value = keyValuePair.Value;
				base.CollectSpriteAsset(value.IconResource);
				foreach (Goods goods in value.RewardList)
				{
					base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
				}
			}
			base.CollectAsset("Spine/General/Goblin_ABS/Goblin_1_Prefab.prefab");
			base.CollectAsset("Spine/General/Goblin_ABS/Goblin_2_Prefab.prefab");
			base.CollectAsset("Spine/General/Goblin_ABS/Goblin_3_Prefab.prefab");
			base.CollectAsset("Spine/General/Goblin_ABS/Goblin_4_Prefab.prefab");
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014424 RID: 82980 RVA: 0x0052730C File Offset: 0x0052550C
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
			this.InitTreasureMapUIController();
		}

		// Token: 0x06014425 RID: 82981 RVA: 0x00527378 File Offset: 0x00525578
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
			this.UninitTreasureMapUIController();
		}

		// Token: 0x06014426 RID: 82982 RVA: 0x005273E4 File Offset: 0x005255E4
		private void InitTreasureMapUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitTreasureMapUIController_hotfix != null)
			{
				this.m_InitTreasureMapUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_treasureMapUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_treasureMapUIController = (this.m_uiCtrlArray[0] as TreasureMapUIController);
				}
				if (!(this.m_treasureMapUIController != null))
				{
					Debug.LogError("TreasureMapUIController is null");
					return;
				}
				this.m_treasureMapUIController.EventOnReturn += this.TreasureMapUIController_OnReturn;
				this.m_treasureMapUIController.EventOnShowHelp += this.TreasureMapUIController_OnShowHelp;
				this.m_treasureMapUIController.EventOnAddTicket += this.TreasureMapUIController_OnAddTicket;
				this.m_treasureMapUIController.EventOnStartTreasureLevel += this.TreasureMapUIcontroller_OnStartTreasureLevel;
			}
			if (this.m_playerResourceUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 1)
				{
					this.m_playerResourceUIController = (this.m_uiCtrlArray[1] as PlayerResourceUIController);
				}
				if (!(this.m_playerResourceUIController != null))
				{
					Debug.LogError("PlayerResourceUIController is null");
					return;
				}
			}
		}

		// Token: 0x06014427 RID: 82983 RVA: 0x00527548 File Offset: 0x00525748
		private void UninitTreasureMapUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitTreasureMapUIController_hotfix != null)
			{
				this.m_UninitTreasureMapUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_treasureMapUIController != null)
			{
				this.m_treasureMapUIController.EventOnReturn -= this.TreasureMapUIController_OnReturn;
				this.m_treasureMapUIController.EventOnShowHelp -= this.TreasureMapUIController_OnShowHelp;
				this.m_treasureMapUIController.EventOnAddTicket -= this.TreasureMapUIController_OnAddTicket;
				this.m_treasureMapUIController.EventOnStartTreasureLevel -= this.TreasureMapUIcontroller_OnStartTreasureLevel;
				this.m_treasureMapUIController = null;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x06014428 RID: 82984 RVA: 0x00527634 File Offset: 0x00525834
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
				this.m_treasureMapUIController.Open();
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_treasureMapUIController.SetTicketCount(projectLPlayerContext.GetTreasureTicketCount(), configDataLoader.GetConfigDataTicketLimitInfo(41).MaxNums);
			this.m_playerResourceUIController.UpdatePlayerResource();
			this.m_treasureMapUIController.ClearTreasureLevelButtons();
			foreach (KeyValuePair<int, ConfigDataTreasureLevelInfo> keyValuePair in configDataLoader.GetAllConfigDataTreasureLevelInfo())
			{
				this.m_treasureMapUIController.AddTreasureLevelButton(keyValuePair.Value, projectLPlayerContext.IsTreasureLevelOpened(keyValuePair.Value.ID));
			}
		}

		// Token: 0x06014429 RID: 82985 RVA: 0x00527768 File Offset: 0x00525968
		private void TreasureMapUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TreasureMapUIController_OnReturn_hotfix != null)
			{
				this.m_TreasureMapUIController_OnReturn_hotfix.call(new object[]
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
				base.ReturnPrevUITask();
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0601442A RID: 82986 RVA: 0x005277EC File Offset: 0x005259EC
		private void TreasureMapUIController_OnShowHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TreasureMapUIController_OnShowHelp_hotfix != null)
			{
				this.m_TreasureMapUIController_OnShowHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_TreasureMap);
		}

		// Token: 0x0601442B RID: 82987 RVA: 0x00527858 File Offset: 0x00525A58
		private void TreasureMapUIController_OnAddTicket()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TreasureMapUIController_OnAddTicket_hotfix != null)
			{
				this.m_TreasureMapUIController_OnAddTicket_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0601442C RID: 82988 RVA: 0x005278B8 File Offset: 0x00525AB8
		private void TreasureMapUIcontroller_OnStartTreasureLevel(ConfigDataTreasureLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TreasureMapUIcontroller_OnStartTreasureLevelConfigDataTreasureLevelInfo_hotfix != null)
			{
				this.m_TreasureMapUIcontroller_OnStartTreasureLevelConfigDataTreasureLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackTreasureLevel(levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.TreasureMap, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x17003C4D RID: 15437
		// (get) Token: 0x0601442D RID: 82989 RVA: 0x00527968 File Offset: 0x00525B68
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

		// Token: 0x17003C4E RID: 15438
		// (get) Token: 0x0601442E RID: 82990 RVA: 0x005279DC File Offset: 0x00525BDC
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

		// Token: 0x17003C4F RID: 15439
		// (get) Token: 0x0601442F RID: 82991 RVA: 0x00527A50 File Offset: 0x00525C50
		// (set) Token: 0x06014430 RID: 82992 RVA: 0x00527A70 File Offset: 0x00525C70
		[DoNotToLua]
		public new TreasureMapUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TreasureMapUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014431 RID: 82993 RVA: 0x00527A7C File Offset: 0x00525C7C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014432 RID: 82994 RVA: 0x00527A88 File Offset: 0x00525C88
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06014433 RID: 82995 RVA: 0x00527A90 File Offset: 0x00525C90
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06014434 RID: 82996 RVA: 0x00527A98 File Offset: 0x00525C98
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06014435 RID: 82997 RVA: 0x00527AA4 File Offset: 0x00525CA4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06014436 RID: 82998 RVA: 0x00527AB0 File Offset: 0x00525CB0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014437 RID: 82999 RVA: 0x00527ABC File Offset: 0x00525CBC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014438 RID: 83000 RVA: 0x00527AC4 File Offset: 0x00525CC4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014439 RID: 83001 RVA: 0x00527ACC File Offset: 0x00525CCC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601443A RID: 83002 RVA: 0x00527AD4 File Offset: 0x00525CD4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601443B RID: 83003 RVA: 0x00527ADC File Offset: 0x00525CDC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0601443C RID: 83004 RVA: 0x00527AE4 File Offset: 0x00525CE4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0601443D RID: 83005 RVA: 0x00527AEC File Offset: 0x00525CEC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0601443E RID: 83006 RVA: 0x00527AF4 File Offset: 0x00525CF4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0601443F RID: 83007 RVA: 0x00527B00 File Offset: 0x00525D00
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06014440 RID: 83008 RVA: 0x00527B0C File Offset: 0x00525D0C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06014441 RID: 83009 RVA: 0x00527B18 File Offset: 0x00525D18
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06014442 RID: 83010 RVA: 0x00527B24 File Offset: 0x00525D24
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06014443 RID: 83011 RVA: 0x00527B2C File Offset: 0x00525D2C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06014444 RID: 83012 RVA: 0x00527B34 File Offset: 0x00525D34
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06014445 RID: 83013 RVA: 0x00527B3C File Offset: 0x00525D3C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06014446 RID: 83014 RVA: 0x00527B44 File Offset: 0x00525D44
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014447 RID: 83015 RVA: 0x00527B4C File Offset: 0x00525D4C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014449 RID: 83017 RVA: 0x00527B70 File Offset: 0x00525D70
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
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitTreasureMapUIController_hotfix = (luaObj.RawGet("InitTreasureMapUIController") as LuaFunction);
					this.m_UninitTreasureMapUIController_hotfix = (luaObj.RawGet("UninitTreasureMapUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_TreasureMapUIController_OnReturn_hotfix = (luaObj.RawGet("TreasureMapUIController_OnReturn") as LuaFunction);
					this.m_TreasureMapUIController_OnShowHelp_hotfix = (luaObj.RawGet("TreasureMapUIController_OnShowHelp") as LuaFunction);
					this.m_TreasureMapUIController_OnAddTicket_hotfix = (luaObj.RawGet("TreasureMapUIController_OnAddTicket") as LuaFunction);
					this.m_TreasureMapUIcontroller_OnStartTreasureLevelConfigDataTreasureLevelInfo_hotfix = (luaObj.RawGet("TreasureMapUIcontroller_OnStartTreasureLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601444A RID: 83018 RVA: 0x00527D68 File Offset: 0x00525F68
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureMapUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B2B9 RID: 45753
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "TreasureMapUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/TreasureMap_ABS/Prefab/TreasureMapUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B2BA RID: 45754
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TreasureMapUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.TreasureMapUIController"),
				m_ctrlName = "TreasureMapUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "TreasureMapUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "ThearchyPlayerResourceUIController"
			}
		};

		// Token: 0x0400B2BB RID: 45755
		private TreasureMapUIController m_treasureMapUIController;

		// Token: 0x0400B2BC RID: 45756
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x0400B2BD RID: 45757
		[DoNotToLua]
		private TreasureMapUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B2BE RID: 45758
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B2BF RID: 45759
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B2C0 RID: 45760
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B2C1 RID: 45761
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B2C2 RID: 45762
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B2C3 RID: 45763
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B2C4 RID: 45764
		private LuaFunction m_InitTreasureMapUIController_hotfix;

		// Token: 0x0400B2C5 RID: 45765
		private LuaFunction m_UninitTreasureMapUIController_hotfix;

		// Token: 0x0400B2C6 RID: 45766
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B2C7 RID: 45767
		private LuaFunction m_TreasureMapUIController_OnReturn_hotfix;

		// Token: 0x0400B2C8 RID: 45768
		private LuaFunction m_TreasureMapUIController_OnShowHelp_hotfix;

		// Token: 0x0400B2C9 RID: 45769
		private LuaFunction m_TreasureMapUIController_OnAddTicket_hotfix;

		// Token: 0x0400B2CA RID: 45770
		private LuaFunction m_TreasureMapUIcontroller_OnStartTreasureLevelConfigDataTreasureLevelInfo_hotfix;

		// Token: 0x0400B2CB RID: 45771
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B2CC RID: 45772
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000FD2 RID: 4050
		public new class LuaExportHelper
		{
			// Token: 0x0601444B RID: 83019 RVA: 0x00527DD0 File Offset: 0x00525FD0
			public LuaExportHelper(TreasureMapUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601444C RID: 83020 RVA: 0x00527DE0 File Offset: 0x00525FE0
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0601444D RID: 83021 RVA: 0x00527DF0 File Offset: 0x00525FF0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601444E RID: 83022 RVA: 0x00527E00 File Offset: 0x00526000
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601444F RID: 83023 RVA: 0x00527E10 File Offset: 0x00526010
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06014450 RID: 83024 RVA: 0x00527E20 File Offset: 0x00526020
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06014451 RID: 83025 RVA: 0x00527E30 File Offset: 0x00526030
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06014452 RID: 83026 RVA: 0x00527E40 File Offset: 0x00526040
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06014453 RID: 83027 RVA: 0x00527E50 File Offset: 0x00526050
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06014454 RID: 83028 RVA: 0x00527E60 File Offset: 0x00526060
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014455 RID: 83029 RVA: 0x00527E70 File Offset: 0x00526070
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014456 RID: 83030 RVA: 0x00527E80 File Offset: 0x00526080
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014457 RID: 83031 RVA: 0x00527E90 File Offset: 0x00526090
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014458 RID: 83032 RVA: 0x00527EA0 File Offset: 0x005260A0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014459 RID: 83033 RVA: 0x00527EB0 File Offset: 0x005260B0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601445A RID: 83034 RVA: 0x00527EC0 File Offset: 0x005260C0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601445B RID: 83035 RVA: 0x00527ED0 File Offset: 0x005260D0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0601445C RID: 83036 RVA: 0x00527EE0 File Offset: 0x005260E0
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0601445D RID: 83037 RVA: 0x00527EF0 File Offset: 0x005260F0
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0601445E RID: 83038 RVA: 0x00527F00 File Offset: 0x00526100
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601445F RID: 83039 RVA: 0x00527F10 File Offset: 0x00526110
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06014460 RID: 83040 RVA: 0x00527F20 File Offset: 0x00526120
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06014461 RID: 83041 RVA: 0x00527F30 File Offset: 0x00526130
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06014462 RID: 83042 RVA: 0x00527F40 File Offset: 0x00526140
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003C50 RID: 15440
			// (get) Token: 0x06014463 RID: 83043 RVA: 0x00527F50 File Offset: 0x00526150
			// (set) Token: 0x06014464 RID: 83044 RVA: 0x00527F60 File Offset: 0x00526160
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

			// Token: 0x17003C51 RID: 15441
			// (get) Token: 0x06014465 RID: 83045 RVA: 0x00527F70 File Offset: 0x00526170
			// (set) Token: 0x06014466 RID: 83046 RVA: 0x00527F80 File Offset: 0x00526180
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

			// Token: 0x17003C52 RID: 15442
			// (get) Token: 0x06014467 RID: 83047 RVA: 0x00527F90 File Offset: 0x00526190
			// (set) Token: 0x06014468 RID: 83048 RVA: 0x00527FA0 File Offset: 0x005261A0
			public TreasureMapUIController m_treasureMapUIController
			{
				get
				{
					return this.m_owner.m_treasureMapUIController;
				}
				set
				{
					this.m_owner.m_treasureMapUIController = value;
				}
			}

			// Token: 0x17003C53 RID: 15443
			// (get) Token: 0x06014469 RID: 83049 RVA: 0x00527FB0 File Offset: 0x005261B0
			// (set) Token: 0x0601446A RID: 83050 RVA: 0x00527FC0 File Offset: 0x005261C0
			public PlayerResourceUIController m_playerResourceUIController
			{
				get
				{
					return this.m_owner.m_playerResourceUIController;
				}
				set
				{
					this.m_owner.m_playerResourceUIController = value;
				}
			}

			// Token: 0x17003C54 RID: 15444
			// (get) Token: 0x0601446B RID: 83051 RVA: 0x00527FD0 File Offset: 0x005261D0
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003C55 RID: 15445
			// (get) Token: 0x0601446C RID: 83052 RVA: 0x00527FE0 File Offset: 0x005261E0
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601446D RID: 83053 RVA: 0x00527FF0 File Offset: 0x005261F0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601446E RID: 83054 RVA: 0x00528000 File Offset: 0x00526200
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0601446F RID: 83055 RVA: 0x00528010 File Offset: 0x00526210
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06014470 RID: 83056 RVA: 0x00528020 File Offset: 0x00526220
			public void InitTreasureMapUIController()
			{
				this.m_owner.InitTreasureMapUIController();
			}

			// Token: 0x06014471 RID: 83057 RVA: 0x00528030 File Offset: 0x00526230
			public void UninitTreasureMapUIController()
			{
				this.m_owner.UninitTreasureMapUIController();
			}

			// Token: 0x06014472 RID: 83058 RVA: 0x00528040 File Offset: 0x00526240
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014473 RID: 83059 RVA: 0x00528050 File Offset: 0x00526250
			public void TreasureMapUIController_OnReturn()
			{
				this.m_owner.TreasureMapUIController_OnReturn();
			}

			// Token: 0x06014474 RID: 83060 RVA: 0x00528060 File Offset: 0x00526260
			public void TreasureMapUIController_OnShowHelp()
			{
				this.m_owner.TreasureMapUIController_OnShowHelp();
			}

			// Token: 0x06014475 RID: 83061 RVA: 0x00528070 File Offset: 0x00526270
			public void TreasureMapUIController_OnAddTicket()
			{
				this.m_owner.TreasureMapUIController_OnAddTicket();
			}

			// Token: 0x06014476 RID: 83062 RVA: 0x00528080 File Offset: 0x00526280
			public void TreasureMapUIcontroller_OnStartTreasureLevel(ConfigDataTreasureLevelInfo levelInfo)
			{
				this.m_owner.TreasureMapUIcontroller_OnStartTreasureLevel(levelInfo);
			}

			// Token: 0x0400B2CD RID: 45773
			private TreasureMapUITask m_owner;
		}
	}
}
