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
	// Token: 0x02000E22 RID: 3618
	[HotFix]
	public class HeroPhantomUITask : UITask
	{
		// Token: 0x06011733 RID: 71475 RVA: 0x0048512C File Offset: 0x0048332C
		public HeroPhantomUITask(string name) : base(name)
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

		// Token: 0x06011734 RID: 71476 RVA: 0x00485258 File Offset: 0x00483458
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
			this.InitDataFromUIIntent(intent);
			return base.OnStart(intent);
		}

		// Token: 0x06011735 RID: 71477 RVA: 0x004852E4 File Offset: 0x004834E4
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

		// Token: 0x06011736 RID: 71478 RVA: 0x00485370 File Offset: 0x00483570
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.m_heroPhantomInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_heroPhantomInfo = uiintentCustom.GetClassParam<ConfigDataHeroPhantomInfo>("HeroPhantomInfo");
			}
			if (this.m_heroPhantomInfo != null && !projectLPlayerContext.IsHeroPhantomDisplay(this.m_heroPhantomInfo.ID))
			{
				this.m_heroPhantomInfo = null;
			}
			if (this.m_heroPhantomInfo == null)
			{
				foreach (KeyValuePair<int, ConfigDataHeroPhantomInfo> keyValuePair in configDataLoader.GetAllConfigDataHeroPhantomInfo())
				{
					if (projectLPlayerContext.IsHeroPhantomDisplay(keyValuePair.Key))
					{
						this.m_heroPhantomInfo = keyValuePair.Value;
						break;
					}
				}
			}
		}

		// Token: 0x06011737 RID: 71479 RVA: 0x004854C8 File Offset: 0x004836C8
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
			base.ClearAssetList();
			if (this.m_heroPhantomInfo != null)
			{
				base.CollectAsset(this.m_heroPhantomInfo.Model);
				List<Goods> list = new List<Goods>();
				foreach (ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo in this.m_heroPhantomInfo.m_levels)
				{
					list.Clear();
					UIUtility.AppendRandomDropRewardGoodsToList(configDataHeroPhantomLevelInfo.DropID, list);
					list.AddRange(configDataHeroPhantomLevelInfo.FirstClearDropItems);
					foreach (Goods goods in list)
					{
						base.CollectSpriteAsset(UIUtility.GetGoodsIconName(goods.GoodsType, goods.Id));
					}
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06011738 RID: 71480 RVA: 0x00485624 File Offset: 0x00483824
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
			this.InitHeroPhantomUIController();
		}

		// Token: 0x06011739 RID: 71481 RVA: 0x00485690 File Offset: 0x00483890
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
			this.UninitHeroPhantomUIController();
		}

		// Token: 0x0601173A RID: 71482 RVA: 0x004856FC File Offset: 0x004838FC
		private void InitHeroPhantomUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitHeroPhantomUIController_hotfix != null)
			{
				this.m_InitHeroPhantomUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroPhantomUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroPhantomUIController = (this.m_uiCtrlArray[0] as HeroPhantomUIController);
				}
				if (!(this.m_heroPhantomUIController != null))
				{
					Debug.LogError("HeroPhantomUIController is null");
					return;
				}
				this.m_heroPhantomUIController.EventOnReturn += this.HeroPhantomUIController_OnReturn;
				this.m_heroPhantomUIController.EventOnHelp += this.HeroPhantomUIController_OnHelp;
				this.m_heroPhantomUIController.EventOnStartHeroPhantomLevel += this.HeroPhantomUIController_OnStartHeroTrainningLevel;
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

		// Token: 0x0601173B RID: 71483 RVA: 0x00485848 File Offset: 0x00483A48
		private void UninitHeroPhantomUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitHeroPhantomUIController_hotfix != null)
			{
				this.m_UninitHeroPhantomUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_heroPhantomUIController != null)
			{
				this.m_heroPhantomUIController.EventOnReturn -= this.HeroPhantomUIController_OnReturn;
				this.m_heroPhantomUIController.EventOnHelp -= this.HeroPhantomUIController_OnHelp;
				this.m_heroPhantomUIController.EventOnStartHeroPhantomLevel -= this.HeroPhantomUIController_OnStartHeroTrainningLevel;
			}
			if (this.m_playerResourceUIController != null)
			{
				this.m_playerResourceUIController = null;
			}
		}

		// Token: 0x0601173C RID: 71484 RVA: 0x00485918 File Offset: 0x00483B18
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
				this.m_heroPhantomUIController.Open();
			}
			this.m_playerResourceUIController.UpdatePlayerResource();
			if (this.m_heroPhantomInfo != null)
			{
				this.m_heroPhantomUIController.SetHeroPhantom(this.m_heroPhantomInfo);
				this.UpdateHeroPhantomLevels(this.m_heroPhantomInfo);
			}
		}

		// Token: 0x0601173D RID: 71485 RVA: 0x004859C4 File Offset: 0x00483BC4
		private void UpdateHeroPhantomLevels(ConfigDataHeroPhantomInfo heroPhantomInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateHeroPhantomLevelsConfigDataHeroPhantomInfo_hotfix != null)
			{
				this.m_UpdateHeroPhantomLevelsConfigDataHeroPhantomInfo_hotfix.call(new object[]
				{
					this,
					heroPhantomInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroPhantomUIController.ClearHeroPhantomLevelListItems();
			this.m_heroPhantomUIController.AddAllHeroPhantomLevelListItems(heroPhantomInfo.m_levels);
		}

		// Token: 0x0601173E RID: 71486 RVA: 0x00485A50 File Offset: 0x00483C50
		private void HeroPhantomUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroPhantomUIController_OnReturn_hotfix != null)
			{
				this.m_HeroPhantomUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x0601173F RID: 71487 RVA: 0x00485AD4 File Offset: 0x00483CD4
		private void HeroPhantomUIController_OnHelp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroPhantomUIController_OnHelp_hotfix != null)
			{
				this.m_HeroPhantomUIController_OnHelp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowExplanation(ExplanationId.ExplanationId_HeroPhantom);
		}

		// Token: 0x06011740 RID: 71488 RVA: 0x00485B40 File Offset: 0x00483D40
		private void HeroPhantomUIController_OnStartHeroTrainningLevel(ConfigDataHeroPhantomLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroPhantomUIController_OnStartHeroTrainningLevelConfigDataHeroPhantomLevelInfo_hotfix != null)
			{
				this.m_HeroPhantomUIController_OnStartHeroTrainningLevelConfigDataHeroPhantomLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanAttackHeroPhantomLevel(levelInfo.ID);
			if (num == 0)
			{
				WorldUITask.StartBattleHappening(BattleType.HeroPhantom, levelInfo.ID);
			}
			else
			{
				WorldUITask.HandleAttackFailResult(num, this.m_currIntent);
			}
		}

		// Token: 0x170035B3 RID: 13747
		// (get) Token: 0x06011741 RID: 71489 RVA: 0x00485BF4 File Offset: 0x00483DF4
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

		// Token: 0x170035B4 RID: 13748
		// (get) Token: 0x06011742 RID: 71490 RVA: 0x00485C68 File Offset: 0x00483E68
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

		// Token: 0x170035B5 RID: 13749
		// (get) Token: 0x06011743 RID: 71491 RVA: 0x00485CDC File Offset: 0x00483EDC
		// (set) Token: 0x06011744 RID: 71492 RVA: 0x00485CFC File Offset: 0x00483EFC
		[DoNotToLua]
		public new HeroPhantomUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPhantomUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06011745 RID: 71493 RVA: 0x00485D08 File Offset: 0x00483F08
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06011746 RID: 71494 RVA: 0x00485D14 File Offset: 0x00483F14
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06011747 RID: 71495 RVA: 0x00485D1C File Offset: 0x00483F1C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06011748 RID: 71496 RVA: 0x00485D24 File Offset: 0x00483F24
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06011749 RID: 71497 RVA: 0x00485D30 File Offset: 0x00483F30
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601174A RID: 71498 RVA: 0x00485D3C File Offset: 0x00483F3C
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601174B RID: 71499 RVA: 0x00485D48 File Offset: 0x00483F48
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601174C RID: 71500 RVA: 0x00485D50 File Offset: 0x00483F50
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0601174D RID: 71501 RVA: 0x00485D58 File Offset: 0x00483F58
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0601174E RID: 71502 RVA: 0x00485D60 File Offset: 0x00483F60
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0601174F RID: 71503 RVA: 0x00485D68 File Offset: 0x00483F68
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06011750 RID: 71504 RVA: 0x00485D70 File Offset: 0x00483F70
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06011751 RID: 71505 RVA: 0x00485D78 File Offset: 0x00483F78
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06011752 RID: 71506 RVA: 0x00485D80 File Offset: 0x00483F80
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06011753 RID: 71507 RVA: 0x00485D8C File Offset: 0x00483F8C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06011754 RID: 71508 RVA: 0x00485D98 File Offset: 0x00483F98
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06011755 RID: 71509 RVA: 0x00485DA4 File Offset: 0x00483FA4
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06011756 RID: 71510 RVA: 0x00485DB0 File Offset: 0x00483FB0
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06011757 RID: 71511 RVA: 0x00485DB8 File Offset: 0x00483FB8
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06011758 RID: 71512 RVA: 0x00485DC0 File Offset: 0x00483FC0
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06011759 RID: 71513 RVA: 0x00485DC8 File Offset: 0x00483FC8
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601175A RID: 71514 RVA: 0x00485DD0 File Offset: 0x00483FD0
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0601175B RID: 71515 RVA: 0x00485DD8 File Offset: 0x00483FD8
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0601175D RID: 71517 RVA: 0x00485DFC File Offset: 0x00483FFC
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitHeroPhantomUIController_hotfix = (luaObj.RawGet("InitHeroPhantomUIController") as LuaFunction);
					this.m_UninitHeroPhantomUIController_hotfix = (luaObj.RawGet("UninitHeroPhantomUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateHeroPhantomLevelsConfigDataHeroPhantomInfo_hotfix = (luaObj.RawGet("UpdateHeroPhantomLevels") as LuaFunction);
					this.m_HeroPhantomUIController_OnReturn_hotfix = (luaObj.RawGet("HeroPhantomUIController_OnReturn") as LuaFunction);
					this.m_HeroPhantomUIController_OnHelp_hotfix = (luaObj.RawGet("HeroPhantomUIController_OnHelp") as LuaFunction);
					this.m_HeroPhantomUIController_OnStartHeroTrainningLevelConfigDataHeroPhantomLevelInfo_hotfix = (luaObj.RawGet("HeroPhantomUIController_OnStartHeroTrainningLevel") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601175E RID: 71518 RVA: 0x00486040 File Offset: 0x00484240
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009F74 RID: 40820
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroPhantomUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Phantom_ABS/Prefab/PhantomUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009F75 RID: 40821
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroPhantomUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroPhantomUIController"),
				m_ctrlName = "HeroPhantomUIController"
			},
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroPhantomUILayer",
				m_attachPath = "./PlayerResource",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.PlayerResourceUIController"),
				m_ctrlName = "HeroPhantomPlayerResourceUIController"
			}
		};

		// Token: 0x04009F76 RID: 40822
		private HeroPhantomUIController m_heroPhantomUIController;

		// Token: 0x04009F77 RID: 40823
		private PlayerResourceUIController m_playerResourceUIController;

		// Token: 0x04009F78 RID: 40824
		private ConfigDataHeroPhantomInfo m_heroPhantomInfo;

		// Token: 0x04009F79 RID: 40825
		[DoNotToLua]
		private HeroPhantomUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009F7A RID: 40826
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009F7B RID: 40827
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009F7C RID: 40828
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009F7D RID: 40829
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009F7E RID: 40830
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009F7F RID: 40831
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009F80 RID: 40832
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009F81 RID: 40833
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009F82 RID: 40834
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009F83 RID: 40835
		private LuaFunction m_InitHeroPhantomUIController_hotfix;

		// Token: 0x04009F84 RID: 40836
		private LuaFunction m_UninitHeroPhantomUIController_hotfix;

		// Token: 0x04009F85 RID: 40837
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009F86 RID: 40838
		private LuaFunction m_UpdateHeroPhantomLevelsConfigDataHeroPhantomInfo_hotfix;

		// Token: 0x04009F87 RID: 40839
		private LuaFunction m_HeroPhantomUIController_OnReturn_hotfix;

		// Token: 0x04009F88 RID: 40840
		private LuaFunction m_HeroPhantomUIController_OnHelp_hotfix;

		// Token: 0x04009F89 RID: 40841
		private LuaFunction m_HeroPhantomUIController_OnStartHeroTrainningLevelConfigDataHeroPhantomLevelInfo_hotfix;

		// Token: 0x04009F8A RID: 40842
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009F8B RID: 40843
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000E23 RID: 3619
		public new class LuaExportHelper
		{
			// Token: 0x0601175F RID: 71519 RVA: 0x004860A8 File Offset: 0x004842A8
			public LuaExportHelper(HeroPhantomUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06011760 RID: 71520 RVA: 0x004860B8 File Offset: 0x004842B8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06011761 RID: 71521 RVA: 0x004860C8 File Offset: 0x004842C8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06011762 RID: 71522 RVA: 0x004860D8 File Offset: 0x004842D8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06011763 RID: 71523 RVA: 0x004860E8 File Offset: 0x004842E8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06011764 RID: 71524 RVA: 0x004860F8 File Offset: 0x004842F8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06011765 RID: 71525 RVA: 0x00486108 File Offset: 0x00484308
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06011766 RID: 71526 RVA: 0x00486118 File Offset: 0x00484318
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06011767 RID: 71527 RVA: 0x00486128 File Offset: 0x00484328
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06011768 RID: 71528 RVA: 0x00486138 File Offset: 0x00484338
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06011769 RID: 71529 RVA: 0x00486148 File Offset: 0x00484348
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0601176A RID: 71530 RVA: 0x00486158 File Offset: 0x00484358
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0601176B RID: 71531 RVA: 0x00486168 File Offset: 0x00484368
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0601176C RID: 71532 RVA: 0x00486178 File Offset: 0x00484378
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0601176D RID: 71533 RVA: 0x00486188 File Offset: 0x00484388
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0601176E RID: 71534 RVA: 0x00486198 File Offset: 0x00484398
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0601176F RID: 71535 RVA: 0x004861A8 File Offset: 0x004843A8
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06011770 RID: 71536 RVA: 0x004861B8 File Offset: 0x004843B8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06011771 RID: 71537 RVA: 0x004861C8 File Offset: 0x004843C8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06011772 RID: 71538 RVA: 0x004861D8 File Offset: 0x004843D8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06011773 RID: 71539 RVA: 0x004861E8 File Offset: 0x004843E8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06011774 RID: 71540 RVA: 0x004861F8 File Offset: 0x004843F8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06011775 RID: 71541 RVA: 0x00486208 File Offset: 0x00484408
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06011776 RID: 71542 RVA: 0x00486218 File Offset: 0x00484418
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170035B6 RID: 13750
			// (get) Token: 0x06011777 RID: 71543 RVA: 0x00486228 File Offset: 0x00484428
			// (set) Token: 0x06011778 RID: 71544 RVA: 0x00486238 File Offset: 0x00484438
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

			// Token: 0x170035B7 RID: 13751
			// (get) Token: 0x06011779 RID: 71545 RVA: 0x00486248 File Offset: 0x00484448
			// (set) Token: 0x0601177A RID: 71546 RVA: 0x00486258 File Offset: 0x00484458
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

			// Token: 0x170035B8 RID: 13752
			// (get) Token: 0x0601177B RID: 71547 RVA: 0x00486268 File Offset: 0x00484468
			// (set) Token: 0x0601177C RID: 71548 RVA: 0x00486278 File Offset: 0x00484478
			public HeroPhantomUIController m_heroPhantomUIController
			{
				get
				{
					return this.m_owner.m_heroPhantomUIController;
				}
				set
				{
					this.m_owner.m_heroPhantomUIController = value;
				}
			}

			// Token: 0x170035B9 RID: 13753
			// (get) Token: 0x0601177D RID: 71549 RVA: 0x00486288 File Offset: 0x00484488
			// (set) Token: 0x0601177E RID: 71550 RVA: 0x00486298 File Offset: 0x00484498
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

			// Token: 0x170035BA RID: 13754
			// (get) Token: 0x0601177F RID: 71551 RVA: 0x004862A8 File Offset: 0x004844A8
			// (set) Token: 0x06011780 RID: 71552 RVA: 0x004862B8 File Offset: 0x004844B8
			public ConfigDataHeroPhantomInfo m_heroPhantomInfo
			{
				get
				{
					return this.m_owner.m_heroPhantomInfo;
				}
				set
				{
					this.m_owner.m_heroPhantomInfo = value;
				}
			}

			// Token: 0x170035BB RID: 13755
			// (get) Token: 0x06011781 RID: 71553 RVA: 0x004862C8 File Offset: 0x004844C8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170035BC RID: 13756
			// (get) Token: 0x06011782 RID: 71554 RVA: 0x004862D8 File Offset: 0x004844D8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06011783 RID: 71555 RVA: 0x004862E8 File Offset: 0x004844E8
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06011784 RID: 71556 RVA: 0x004862F8 File Offset: 0x004844F8
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06011785 RID: 71557 RVA: 0x00486308 File Offset: 0x00484508
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06011786 RID: 71558 RVA: 0x00486318 File Offset: 0x00484518
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06011787 RID: 71559 RVA: 0x00486328 File Offset: 0x00484528
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06011788 RID: 71560 RVA: 0x00486338 File Offset: 0x00484538
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06011789 RID: 71561 RVA: 0x00486348 File Offset: 0x00484548
			public void InitHeroPhantomUIController()
			{
				this.m_owner.InitHeroPhantomUIController();
			}

			// Token: 0x0601178A RID: 71562 RVA: 0x00486358 File Offset: 0x00484558
			public void UninitHeroPhantomUIController()
			{
				this.m_owner.UninitHeroPhantomUIController();
			}

			// Token: 0x0601178B RID: 71563 RVA: 0x00486368 File Offset: 0x00484568
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0601178C RID: 71564 RVA: 0x00486378 File Offset: 0x00484578
			public void UpdateHeroPhantomLevels(ConfigDataHeroPhantomInfo heroPhantomInfo)
			{
				this.m_owner.UpdateHeroPhantomLevels(heroPhantomInfo);
			}

			// Token: 0x0601178D RID: 71565 RVA: 0x00486388 File Offset: 0x00484588
			public void HeroPhantomUIController_OnReturn()
			{
				this.m_owner.HeroPhantomUIController_OnReturn();
			}

			// Token: 0x0601178E RID: 71566 RVA: 0x00486398 File Offset: 0x00484598
			public void HeroPhantomUIController_OnHelp()
			{
				this.m_owner.HeroPhantomUIController_OnHelp();
			}

			// Token: 0x0601178F RID: 71567 RVA: 0x004863A8 File Offset: 0x004845A8
			public void HeroPhantomUIController_OnStartHeroTrainningLevel(ConfigDataHeroPhantomLevelInfo levelInfo)
			{
				this.m_owner.HeroPhantomUIController_OnStartHeroTrainningLevel(levelInfo);
			}

			// Token: 0x04009F8C RID: 40844
			private HeroPhantomUITask m_owner;
		}
	}
}
