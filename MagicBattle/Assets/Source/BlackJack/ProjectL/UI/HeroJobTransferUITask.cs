using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000DCC RID: 3532
	[HotFix]
	public class HeroJobTransferUITask : UITask
	{
		// Token: 0x06010E14 RID: 69140 RVA: 0x0045E724 File Offset: 0x0045C924
		public HeroJobTransferUITask(string name) : base(name)
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

		// Token: 0x06010E15 RID: 69141 RVA: 0x0045E818 File Offset: 0x0045CA18
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
			base.CollectSpriteAsset("UI/JobTransfer_ABS/Pattern_Job_01.png");
			base.CollectSpriteAsset("UI/JobTransfer_ABS/Pattern_Job_02.png");
			base.CollectSpriteAsset("UI/JobTransfer_ABS/Pattern_Job_03.png");
			base.CollectSpriteAsset("UI/JobTransfer_ABS/Pattern_Job_04.png");
			base.CollectSpriteAsset("UI/JobTransfer_ABS/Pattern_Job_05.png");
			base.CollectSpriteAsset("UI/Common_New_ABS/Icon_Up.png");
			base.CollectSpriteAsset("UI/Common_New_ABS/Icon_Minus.png");
			base.CollectSpriteAsset("UI/Common_New_ABS/Icon_Down.png");
			ConfigDataJobConnectionInfo curJobConnectionInfo = this.m_curJobConnectionInfo;
			if (curJobConnectionInfo == null)
			{
				return false;
			}
			base.CollectAsset(curJobConnectionInfo.Model);
			foreach (ConfigDataJobLevelInfo configDataJobLevelInfo in curJobConnectionInfo.m_jobLevelInfos)
			{
				if (configDataJobLevelInfo.m_gotSoldierInfo != null)
				{
					base.CollectAsset(configDataJobLevelInfo.m_gotSoldierInfo.Model);
				}
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06010E16 RID: 69142 RVA: 0x0045E940 File Offset: 0x0045CB40
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
			if (this.m_heroJobTransferUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_heroJobTransferUIController = (this.m_uiCtrlArray[0] as HeroJobTransferUIController);
				}
				if (!(this.m_heroJobTransferUIController != null))
				{
					Debug.LogError("HeroJobTransferUIController is null");
					return;
				}
				this.m_heroJobTransferUIController.EventOnReturn += this.HeroJobTransferUIController_OnReturn;
				this.m_heroJobTransferUIController.EventOnAddGold += this.HeroJobTransferUIController_OnAddGold;
				this.m_heroJobTransferUIController.EventOnHeroJobTransfer += this.HeroJobTransferUIController_OnJobTransfer;
				this.m_heroJobTransferUIController.EventOnHeroJobUnlock += this.HeroJobTransferUIController_OnHeroJobUnlock;
				this.m_heroJobTransferUIController.EventOnHeroJobCardClick += this.HeroJobTransferUIController_OnHeroJobCardClick;
			}
		}

		// Token: 0x06010E17 RID: 69143 RVA: 0x0045EA6C File Offset: 0x0045CC6C
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
			if (this.m_heroJobTransferUIController != null)
			{
				this.m_heroJobTransferUIController.EventOnReturn -= this.HeroJobTransferUIController_OnReturn;
				this.m_heroJobTransferUIController.EventOnAddGold -= this.HeroJobTransferUIController_OnAddGold;
				this.m_heroJobTransferUIController.EventOnHeroJobTransfer -= this.HeroJobTransferUIController_OnJobTransfer;
				this.m_heroJobTransferUIController.EventOnHeroJobUnlock -= this.HeroJobTransferUIController_OnHeroJobUnlock;
				this.m_heroJobTransferUIController.EventOnHeroJobCardClick -= this.HeroJobTransferUIController_OnHeroJobCardClick;
				this.m_heroJobTransferUIController = null;
			}
		}

		// Token: 0x06010E18 RID: 69144 RVA: 0x0045EB60 File Offset: 0x0045CD60
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

		// Token: 0x06010E19 RID: 69145 RVA: 0x0045EBEC File Offset: 0x0045CDEC
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

		// Token: 0x06010E1A RID: 69146 RVA: 0x0045EC78 File Offset: 0x0045CE78
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
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				Hero classParam = uiintentCustom.GetClassParam<Hero>("hero");
				ConfigDataJobConnectionInfo classParam2 = uiintentCustom.GetClassParam<ConfigDataJobConnectionInfo>("jobConnectionInfo");
				if (this.m_hero != classParam && classParam != null)
				{
					this.m_hero = classParam;
				}
				if (this.m_curJobConnectionInfo != classParam2 && classParam2 != null)
				{
					this.m_curJobConnectionInfo = classParam2;
				}
				else
				{
					this.m_curJobConnectionInfo = this.m_hero.GetActiveJob().JobConnectionInfo;
				}
			}
		}

		// Token: 0x06010E1B RID: 69147 RVA: 0x0045ED5C File Offset: 0x0045CF5C
		protected override void OnMemoryWarning()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMemoryWarning_hotfix != null)
			{
				this.m_OnMemoryWarning_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06010E1C RID: 69148 RVA: 0x0045EDC4 File Offset: 0x0045CFC4
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
			this.m_heroJobTransferUIController.SetHero(this.m_hero, this.m_curJobConnectionInfo);
			this.m_heroJobTransferUIController.UpdateViewInHeroJobTransfer();
		}

		// Token: 0x06010E1D RID: 69149 RVA: 0x0045EE48 File Offset: 0x0045D048
		private void HeroJobTransferUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobTransferUIController_OnReturn_hotfix != null)
			{
				this.m_HeroJobTransferUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x06010E1E RID: 69150 RVA: 0x0045EECC File Offset: 0x0045D0CC
		private void HeroJobTransferUIController_OnJobTransfer(int heroId, int jobConnectionId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobTransferUIController_OnJobTransferInt32Int32Action_hotfix != null)
			{
				this.m_HeroJobTransferUIController_OnJobTransferInt32Int32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					jobConnectionId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			HeroJobTransferUITask $this = this;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			int num = projectLPlayerContext.CanHeroJobTransfer(heroId, jobConnectionId);
			if (num != 0)
			{
				CommonUIController.Instance.ShowErrorMessage(num, 2f, null, true);
				return;
			}
			HeroJobTransferNetTask heroJobTransferNetTask = new HeroJobTransferNetTask(heroId, jobConnectionId);
			heroJobTransferNetTask.EventOnStop += delegate(Task task)
			{
				HeroJobTransferNetTask heroJobTransferNetTask2 = task as HeroJobTransferNetTask;
				if (heroJobTransferNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroJobTransferNetTask2.Result, 2f, null, true);
				}
			};
			heroJobTransferNetTask.Start(null);
		}

		// Token: 0x06010E1F RID: 69151 RVA: 0x0045EFC4 File Offset: 0x0045D1C4
		private void HeroJobTransferUIController_OnHeroJobUnlock(int heroId, int jobRelatedId, Action OnSucceed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobTransferUIController_OnHeroJobUnlockInt32Int32Action_hotfix != null)
			{
				this.m_HeroJobTransferUIController_OnHeroJobUnlockInt32Int32Action_hotfix.call(new object[]
				{
					this,
					heroId,
					jobRelatedId,
					OnSucceed2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Action OnSucceed = OnSucceed2;
			HeroJobTransferUITask $this = this;
			HeroJobUnlockNetTask heroJobUnlockNetTask = new HeroJobUnlockNetTask(heroId, jobRelatedId);
			heroJobUnlockNetTask.EventOnStop += delegate(Task task)
			{
				HeroJobUnlockNetTask heroJobUnlockNetTask2 = task as HeroJobUnlockNetTask;
				if (heroJobUnlockNetTask2.Result == 0)
				{
					$this.StartUpdatePipeLine(null, false, false, true);
					OnSucceed();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(heroJobUnlockNetTask2.Result, 2f, null, true);
				}
			};
			heroJobUnlockNetTask.Start(null);
		}

		// Token: 0x06010E20 RID: 69152 RVA: 0x0045F08C File Offset: 0x0045D28C
		private void HeroJobTransferUIController_OnHeroJobCardClick(ConfigDataJobConnectionInfo jci)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobTransferUIController_OnHeroJobCardClickConfigDataJobConnectionInfo_hotfix != null)
			{
				this.m_HeroJobTransferUIController_OnHeroJobCardClickConfigDataJobConnectionInfo_hotfix.call(new object[]
				{
					this,
					jci
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_curJobConnectionInfo = jci;
			base.StartUpdatePipeLine(null, false, false, true);
		}

		// Token: 0x06010E21 RID: 69153 RVA: 0x0045F110 File Offset: 0x0045D310
		private void HeroJobTransferUIController_OnAddGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_HeroJobTransferUIController_OnAddGold_hotfix != null)
			{
				this.m_HeroJobTransferUIController_OnAddGold_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			StoreUITask.StartUITask(this.m_currIntent, StoreId.StoreId_Crystal, null, false);
		}

		// Token: 0x17003457 RID: 13399
		// (get) Token: 0x06010E22 RID: 69154 RVA: 0x0045F188 File Offset: 0x0045D388
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

		// Token: 0x17003458 RID: 13400
		// (get) Token: 0x06010E23 RID: 69155 RVA: 0x0045F1FC File Offset: 0x0045D3FC
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

		// Token: 0x17003459 RID: 13401
		// (get) Token: 0x06010E24 RID: 69156 RVA: 0x0045F270 File Offset: 0x0045D470
		// (set) Token: 0x06010E25 RID: 69157 RVA: 0x0045F290 File Offset: 0x0045D490
		[DoNotToLua]
		public new HeroJobTransferUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroJobTransferUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06010E26 RID: 69158 RVA: 0x0045F29C File Offset: 0x0045D49C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06010E27 RID: 69159 RVA: 0x0045F2A8 File Offset: 0x0045D4A8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06010E28 RID: 69160 RVA: 0x0045F2B0 File Offset: 0x0045D4B0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06010E29 RID: 69161 RVA: 0x0045F2B8 File Offset: 0x0045D4B8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06010E2A RID: 69162 RVA: 0x0045F2C4 File Offset: 0x0045D4C4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06010E2B RID: 69163 RVA: 0x0045F2D0 File Offset: 0x0045D4D0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06010E2C RID: 69164 RVA: 0x0045F2DC File Offset: 0x0045D4DC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06010E2D RID: 69165 RVA: 0x0045F2E4 File Offset: 0x0045D4E4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06010E2E RID: 69166 RVA: 0x0045F2EC File Offset: 0x0045D4EC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06010E2F RID: 69167 RVA: 0x0045F2F4 File Offset: 0x0045D4F4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06010E30 RID: 69168 RVA: 0x0045F2FC File Offset: 0x0045D4FC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06010E31 RID: 69169 RVA: 0x0045F304 File Offset: 0x0045D504
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06010E32 RID: 69170 RVA: 0x0045F30C File Offset: 0x0045D50C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06010E33 RID: 69171 RVA: 0x0045F314 File Offset: 0x0045D514
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06010E34 RID: 69172 RVA: 0x0045F320 File Offset: 0x0045D520
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06010E35 RID: 69173 RVA: 0x0045F32C File Offset: 0x0045D52C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06010E36 RID: 69174 RVA: 0x0045F338 File Offset: 0x0045D538
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06010E37 RID: 69175 RVA: 0x0045F344 File Offset: 0x0045D544
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06010E38 RID: 69176 RVA: 0x0045F34C File Offset: 0x0045D54C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06010E39 RID: 69177 RVA: 0x0045F354 File Offset: 0x0045D554
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06010E3A RID: 69178 RVA: 0x0045F35C File Offset: 0x0045D55C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06010E3B RID: 69179 RVA: 0x0045F364 File Offset: 0x0045D564
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06010E3C RID: 69180 RVA: 0x0045F36C File Offset: 0x0045D56C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06010E3E RID: 69182 RVA: 0x0045F390 File Offset: 0x0045D590
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
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitDataFromUIIntentUIIntent_hotfix = (luaObj.RawGet("InitDataFromUIIntent") as LuaFunction);
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_HeroJobTransferUIController_OnReturn_hotfix = (luaObj.RawGet("HeroJobTransferUIController_OnReturn") as LuaFunction);
					this.m_HeroJobTransferUIController_OnJobTransferInt32Int32Action_hotfix = (luaObj.RawGet("HeroJobTransferUIController_OnJobTransfer") as LuaFunction);
					this.m_HeroJobTransferUIController_OnHeroJobUnlockInt32Int32Action_hotfix = (luaObj.RawGet("HeroJobTransferUIController_OnHeroJobUnlock") as LuaFunction);
					this.m_HeroJobTransferUIController_OnHeroJobCardClickConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("HeroJobTransferUIController_OnHeroJobCardClick") as LuaFunction);
					this.m_HeroJobTransferUIController_OnAddGold_hotfix = (luaObj.RawGet("HeroJobTransferUIController_OnAddGold") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06010E3F RID: 69183 RVA: 0x0045F5D4 File Offset: 0x0045D7D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroJobTransferUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009B81 RID: 39809
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "HeroJobTransferUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Hero_ABS/Prefab/HeroJobTransferUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009B82 RID: 39810
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "HeroJobTransferUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.HeroJobTransferUIController"),
				m_ctrlName = "HeroJobTransferUIController"
			}
		};

		// Token: 0x04009B83 RID: 39811
		private Hero m_hero;

		// Token: 0x04009B84 RID: 39812
		private ConfigDataJobConnectionInfo m_curJobConnectionInfo;

		// Token: 0x04009B85 RID: 39813
		private HeroJobTransferUIController m_heroJobTransferUIController;

		// Token: 0x04009B86 RID: 39814
		[DoNotToLua]
		private HeroJobTransferUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009B87 RID: 39815
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04009B88 RID: 39816
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04009B89 RID: 39817
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04009B8A RID: 39818
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04009B8B RID: 39819
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04009B8C RID: 39820
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04009B8D RID: 39821
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04009B8E RID: 39822
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04009B8F RID: 39823
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04009B90 RID: 39824
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04009B91 RID: 39825
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009B92 RID: 39826
		private LuaFunction m_HeroJobTransferUIController_OnReturn_hotfix;

		// Token: 0x04009B93 RID: 39827
		private LuaFunction m_HeroJobTransferUIController_OnJobTransferInt32Int32Action_hotfix;

		// Token: 0x04009B94 RID: 39828
		private LuaFunction m_HeroJobTransferUIController_OnHeroJobUnlockInt32Int32Action_hotfix;

		// Token: 0x04009B95 RID: 39829
		private LuaFunction m_HeroJobTransferUIController_OnHeroJobCardClickConfigDataJobConnectionInfo_hotfix;

		// Token: 0x04009B96 RID: 39830
		private LuaFunction m_HeroJobTransferUIController_OnAddGold_hotfix;

		// Token: 0x04009B97 RID: 39831
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009B98 RID: 39832
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000DCD RID: 3533
		public new class LuaExportHelper
		{
			// Token: 0x06010E40 RID: 69184 RVA: 0x0045F63C File Offset: 0x0045D83C
			public LuaExportHelper(HeroJobTransferUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06010E41 RID: 69185 RVA: 0x0045F64C File Offset: 0x0045D84C
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06010E42 RID: 69186 RVA: 0x0045F65C File Offset: 0x0045D85C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06010E43 RID: 69187 RVA: 0x0045F66C File Offset: 0x0045D86C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06010E44 RID: 69188 RVA: 0x0045F67C File Offset: 0x0045D87C
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06010E45 RID: 69189 RVA: 0x0045F68C File Offset: 0x0045D88C
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06010E46 RID: 69190 RVA: 0x0045F69C File Offset: 0x0045D89C
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06010E47 RID: 69191 RVA: 0x0045F6AC File Offset: 0x0045D8AC
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06010E48 RID: 69192 RVA: 0x0045F6BC File Offset: 0x0045D8BC
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06010E49 RID: 69193 RVA: 0x0045F6CC File Offset: 0x0045D8CC
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06010E4A RID: 69194 RVA: 0x0045F6DC File Offset: 0x0045D8DC
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06010E4B RID: 69195 RVA: 0x0045F6EC File Offset: 0x0045D8EC
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06010E4C RID: 69196 RVA: 0x0045F6FC File Offset: 0x0045D8FC
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06010E4D RID: 69197 RVA: 0x0045F70C File Offset: 0x0045D90C
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06010E4E RID: 69198 RVA: 0x0045F71C File Offset: 0x0045D91C
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06010E4F RID: 69199 RVA: 0x0045F72C File Offset: 0x0045D92C
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06010E50 RID: 69200 RVA: 0x0045F73C File Offset: 0x0045D93C
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06010E51 RID: 69201 RVA: 0x0045F74C File Offset: 0x0045D94C
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06010E52 RID: 69202 RVA: 0x0045F75C File Offset: 0x0045D95C
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06010E53 RID: 69203 RVA: 0x0045F76C File Offset: 0x0045D96C
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06010E54 RID: 69204 RVA: 0x0045F77C File Offset: 0x0045D97C
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06010E55 RID: 69205 RVA: 0x0045F78C File Offset: 0x0045D98C
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06010E56 RID: 69206 RVA: 0x0045F79C File Offset: 0x0045D99C
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06010E57 RID: 69207 RVA: 0x0045F7AC File Offset: 0x0045D9AC
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x1700345A RID: 13402
			// (get) Token: 0x06010E58 RID: 69208 RVA: 0x0045F7BC File Offset: 0x0045D9BC
			// (set) Token: 0x06010E59 RID: 69209 RVA: 0x0045F7CC File Offset: 0x0045D9CC
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

			// Token: 0x1700345B RID: 13403
			// (get) Token: 0x06010E5A RID: 69210 RVA: 0x0045F7DC File Offset: 0x0045D9DC
			// (set) Token: 0x06010E5B RID: 69211 RVA: 0x0045F7EC File Offset: 0x0045D9EC
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

			// Token: 0x1700345C RID: 13404
			// (get) Token: 0x06010E5C RID: 69212 RVA: 0x0045F7FC File Offset: 0x0045D9FC
			// (set) Token: 0x06010E5D RID: 69213 RVA: 0x0045F80C File Offset: 0x0045DA0C
			public Hero m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x1700345D RID: 13405
			// (get) Token: 0x06010E5E RID: 69214 RVA: 0x0045F81C File Offset: 0x0045DA1C
			// (set) Token: 0x06010E5F RID: 69215 RVA: 0x0045F82C File Offset: 0x0045DA2C
			public ConfigDataJobConnectionInfo m_curJobConnectionInfo
			{
				get
				{
					return this.m_owner.m_curJobConnectionInfo;
				}
				set
				{
					this.m_owner.m_curJobConnectionInfo = value;
				}
			}

			// Token: 0x1700345E RID: 13406
			// (get) Token: 0x06010E60 RID: 69216 RVA: 0x0045F83C File Offset: 0x0045DA3C
			// (set) Token: 0x06010E61 RID: 69217 RVA: 0x0045F84C File Offset: 0x0045DA4C
			public HeroJobTransferUIController m_heroJobTransferUIController
			{
				get
				{
					return this.m_owner.m_heroJobTransferUIController;
				}
				set
				{
					this.m_owner.m_heroJobTransferUIController = value;
				}
			}

			// Token: 0x1700345F RID: 13407
			// (get) Token: 0x06010E62 RID: 69218 RVA: 0x0045F85C File Offset: 0x0045DA5C
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003460 RID: 13408
			// (get) Token: 0x06010E63 RID: 69219 RVA: 0x0045F86C File Offset: 0x0045DA6C
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06010E64 RID: 69220 RVA: 0x0045F87C File Offset: 0x0045DA7C
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x06010E65 RID: 69221 RVA: 0x0045F88C File Offset: 0x0045DA8C
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06010E66 RID: 69222 RVA: 0x0045F89C File Offset: 0x0045DA9C
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06010E67 RID: 69223 RVA: 0x0045F8AC File Offset: 0x0045DAAC
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x06010E68 RID: 69224 RVA: 0x0045F8BC File Offset: 0x0045DABC
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06010E69 RID: 69225 RVA: 0x0045F8CC File Offset: 0x0045DACC
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x06010E6A RID: 69226 RVA: 0x0045F8DC File Offset: 0x0045DADC
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x06010E6B RID: 69227 RVA: 0x0045F8EC File Offset: 0x0045DAEC
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06010E6C RID: 69228 RVA: 0x0045F8FC File Offset: 0x0045DAFC
			public void HeroJobTransferUIController_OnReturn()
			{
				this.m_owner.HeroJobTransferUIController_OnReturn();
			}

			// Token: 0x06010E6D RID: 69229 RVA: 0x0045F90C File Offset: 0x0045DB0C
			public void HeroJobTransferUIController_OnJobTransfer(int heroId, int jobConnectionId, Action OnSucceed)
			{
				this.m_owner.HeroJobTransferUIController_OnJobTransfer(heroId, jobConnectionId, OnSucceed);
			}

			// Token: 0x06010E6E RID: 69230 RVA: 0x0045F91C File Offset: 0x0045DB1C
			public void HeroJobTransferUIController_OnHeroJobUnlock(int heroId, int jobRelatedId, Action OnSucceed)
			{
				this.m_owner.HeroJobTransferUIController_OnHeroJobUnlock(heroId, jobRelatedId, OnSucceed);
			}

			// Token: 0x06010E6F RID: 69231 RVA: 0x0045F92C File Offset: 0x0045DB2C
			public void HeroJobTransferUIController_OnHeroJobCardClick(ConfigDataJobConnectionInfo jci)
			{
				this.m_owner.HeroJobTransferUIController_OnHeroJobCardClick(jci);
			}

			// Token: 0x06010E70 RID: 69232 RVA: 0x0045F93C File Offset: 0x0045DB3C
			public void HeroJobTransferUIController_OnAddGold()
			{
				this.m_owner.HeroJobTransferUIController_OnAddGold();
			}

			// Token: 0x04009B99 RID: 39833
			private HeroJobTransferUITask m_owner;
		}
	}
}
