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
	// Token: 0x02000FEB RID: 4075
	[HotFix]
	public class UnchartedUITask : UITask
	{
		// Token: 0x06014737 RID: 83767 RVA: 0x00531CBC File Offset: 0x0052FEBC
		public UnchartedUITask(string name) : base(name)
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

		// Token: 0x06014738 RID: 83768 RVA: 0x00531DB8 File Offset: 0x0052FFB8
		protected override void Finalize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Finalize_hotfix != null)
			{
				this.m_Finalize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			try
			{
			}
			finally
			{
				base.Finalize();
			}
		}

		// Token: 0x06014739 RID: 83769 RVA: 0x00531E34 File Offset: 0x00530034
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
			foreach (KeyValuePair<int, ConfigDataCooperateBattleInfo> keyValuePair in configDataLoader.GetAllConfigDataCooperateBattleInfo())
			{
				base.CollectSpriteAsset(keyValuePair.Value.Image);
			}
			foreach (KeyValuePair<int, ConfigDataHeroPhantomInfo> keyValuePair2 in configDataLoader.GetAllConfigDataHeroPhantomInfo())
			{
				base.CollectSpriteAsset(keyValuePair2.Value.Image);
			}
			foreach (KeyValuePair<int, ConfigDataUnchartedScoreInfo> keyValuePair3 in configDataLoader.GetAllConfigDataUnchartedScoreInfo())
			{
				base.CollectSpriteAsset(keyValuePair3.Value.PageImage);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601473A RID: 83770 RVA: 0x00531FC4 File Offset: 0x005301C4
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
			this.InitUnchartedUIController();
		}

		// Token: 0x0601473B RID: 83771 RVA: 0x00532030 File Offset: 0x00530230
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
			this.UninitUnchartedUIController();
		}

		// Token: 0x0601473C RID: 83772 RVA: 0x0053209C File Offset: 0x0053029C
		private void InitUnchartedUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitUnchartedUIController_hotfix != null)
			{
				this.m_InitUnchartedUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_unchartedUIController = (this.m_uiCtrlArray[0] as UnchartedUIController);
				}
				if (!(this.m_unchartedUIController != null))
				{
					Debug.LogError("UnchartedUIController is null");
					return;
				}
				this.m_unchartedUIController.EventOnShowUncharted += this.UnchartedUIController_OnShowUncharted;
				this.m_unchartedUIController.EventOnShowTeam += this.UnchartedUIController_OnShowTeam;
				this.m_unchartedUIController.EventOnReturn += this.UnchartedUIController_OnReturn;
			}
		}

		// Token: 0x0601473D RID: 83773 RVA: 0x00532194 File Offset: 0x00530394
		private void UninitUnchartedUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitUnchartedUIController_hotfix != null)
			{
				this.m_UninitUnchartedUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_unchartedUIController != null)
			{
				this.m_unchartedUIController.EventOnShowUncharted -= this.UnchartedUIController_OnShowUncharted;
				this.m_unchartedUIController.EventOnShowTeam -= this.UnchartedUIController_OnShowTeam;
				this.m_unchartedUIController.EventOnReturn -= this.UnchartedUIController_OnReturn;
				this.m_unchartedUIController = null;
			}
		}

		// Token: 0x0601473E RID: 83774 RVA: 0x00532254 File Offset: 0x00530454
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
			if (this.m_unchartedUIController == null)
			{
				return;
			}
			int second = DateTime.Now.Second;
			if (second != this.m_nowSeconds)
			{
				this.m_nowSeconds = second;
				this.UpdateClimbTowerFlushTime();
			}
		}

		// Token: 0x0601473F RID: 83775 RVA: 0x005322F4 File Offset: 0x005304F4
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
				this.m_unchartedUIController.Open();
			}
			this.m_unchartedUIController.SetUnchartedInfo();
			this.UpdateClimbTowerFlushTime();
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				BattleType structParam = uiintentCustom.GetStructParam<BattleType>("BattleType");
				int structParam2 = uiintentCustom.GetStructParam<int>("ChapterId");
				int structParam3 = uiintentCustom.GetStructParam<int>("TabIndex");
				uiintentCustom.SetParam("BattleType", BattleType.None);
				uiintentCustom.SetParam("ChapterId", 0);
				uiintentCustom.SetParam("TabIndex", 0);
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (structParam != BattleType.None)
				{
					if (structParam == BattleType.AnikiGym || structParam == BattleType.HeroTrainning || structParam == BattleType.ThearchyTrial || structParam == BattleType.TreasureMap || structParam == BattleType.MemoryCorridor || structParam == BattleType.ClimbTower)
					{
						this.m_unchartedUIController.SetUnchartedToggle(1);
						this.UnchartedUIController_OnShowUncharted(structParam, structParam2);
					}
					else
					{
						this.m_unchartedUIController.SetUnchartedToggle(2);
						bool flag = structParam == BattleType.CooperateBattle && projectLPlayerContext.IsCooperateBattleOpened(structParam2);
						bool flag2 = structParam == BattleType.HeroPhantom && projectLPlayerContext.IsHeroPhantomOpened(structParam2);
						bool flag3 = (structParam == BattleType.UnchartedScore_ScoreLevel || structParam == BattleType.UnchartedScore_ChallengeLevel) && projectLPlayerContext.IsUnchartedScoreOpened(structParam2);
						if (flag || flag2 || flag3)
						{
							this.UnchartedUIController_OnShowUncharted(structParam, structParam2);
						}
					}
				}
				if (structParam3 != 0)
				{
					this.m_unchartedUIController.SetUnchartedToggle(structParam3);
				}
			}
		}

		// Token: 0x06014740 RID: 83776 RVA: 0x005324C4 File Offset: 0x005306C4
		private void UpdateClimbTowerFlushTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateClimbTowerFlushTime_hotfix != null)
			{
				this.m_UpdateClimbTowerFlushTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			TimeSpan climbTowerFlushTime = projectLPlayerContext.GetClimbTowerNextFlushTime() - projectLPlayerContext.GetServerTime();
			if (climbTowerFlushTime.Ticks <= 0L)
			{
				climbTowerFlushTime = TimeSpan.Zero;
			}
			this.m_unchartedUIController.SetClimbTowerFlushTime(climbTowerFlushTime);
			DateTime now = DateTime.Now;
			if (now >= this.m_nextCheckClimbTowerFlushTime)
			{
				if (climbTowerFlushTime.Ticks <= 0L)
				{
					this.FlushClimbTower();
				}
				else
				{
					this.m_nextCheckClimbTowerFlushTime = now.AddSeconds(5.0);
				}
			}
		}

		// Token: 0x06014741 RID: 83777 RVA: 0x005325AC File Offset: 0x005307AC
		private void FlushClimbTower()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushClimbTower_hotfix != null)
			{
				this.m_FlushClimbTower_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_nextCheckClimbTowerFlushTime = DateTime.MaxValue;
			ClimbTowerGetNetTask climbTowerGetNetTask = new ClimbTowerGetNetTask();
			climbTowerGetNetTask.EventOnStop += delegate(Task task)
			{
				ClimbTowerGetNetTask climbTowerGetNetTask2 = task as ClimbTowerGetNetTask;
				if (climbTowerGetNetTask2.Result == 0)
				{
					base.StartUpdatePipeLine(null, false, false, true);
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(climbTowerGetNetTask2.Result, 2f, null, true);
				}
				this.m_nextCheckClimbTowerFlushTime = DateTime.Now.AddSeconds(5.0);
			};
			climbTowerGetNetTask.Start(null);
		}

		// Token: 0x06014742 RID: 83778 RVA: 0x00532638 File Offset: 0x00530838
		private void UnchartedUIController_OnShowUncharted(BattleType battleType, int chapterId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedUIController_OnShowUnchartedBattleTypeInt32_hotfix != null)
			{
				this.m_UnchartedUIController_OnShowUnchartedBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					battleType2,
					chapterId2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleType battleType = battleType2;
			int chapterId = chapterId2;
			UnchartedUITask $this = this;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				$this.Pause();
				WorldUITask.StartUnchartedSubUITask(battleType, chapterId, $this.m_currIntent);
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06014743 RID: 83779 RVA: 0x005326F4 File Offset: 0x005308F4
		private void UnchartedUIController_OnShowTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedUIController_OnShowTeam_hotfix != null)
			{
				this.m_UnchartedUIController_OnShowTeam_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable intent = TeamUITask.CreateIntent(this.m_currIntent, GameFunctionType.GameFunctionType_None, 0, 0);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.TeamUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06014744 RID: 83780 RVA: 0x00532778 File Offset: 0x00530978
		private void TeamUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TeamUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_TeamUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(TeamUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x06014745 RID: 83781 RVA: 0x00532804 File Offset: 0x00530A04
		private void UnchartedUIController_OnReturn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnchartedUIController_OnReturn_hotfix != null)
			{
				this.m_UnchartedUIController_OnReturn_hotfix.call(new object[]
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

		// Token: 0x17003CA4 RID: 15524
		// (get) Token: 0x06014746 RID: 83782 RVA: 0x00532888 File Offset: 0x00530A88
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

		// Token: 0x17003CA5 RID: 15525
		// (get) Token: 0x06014747 RID: 83783 RVA: 0x005328FC File Offset: 0x00530AFC
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

		// Token: 0x17003CA6 RID: 15526
		// (get) Token: 0x06014748 RID: 83784 RVA: 0x00532970 File Offset: 0x00530B70
		// (set) Token: 0x06014749 RID: 83785 RVA: 0x00532990 File Offset: 0x00530B90
		[DoNotToLua]
		public new UnchartedUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UnchartedUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0601474A RID: 83786 RVA: 0x0053299C File Offset: 0x00530B9C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0601474B RID: 83787 RVA: 0x005329A8 File Offset: 0x00530BA8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601474C RID: 83788 RVA: 0x005329B0 File Offset: 0x00530BB0
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0601474D RID: 83789 RVA: 0x005329B8 File Offset: 0x00530BB8
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601474E RID: 83790 RVA: 0x005329C4 File Offset: 0x00530BC4
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601474F RID: 83791 RVA: 0x005329D0 File Offset: 0x00530BD0
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06014750 RID: 83792 RVA: 0x005329DC File Offset: 0x00530BDC
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014751 RID: 83793 RVA: 0x005329E4 File Offset: 0x00530BE4
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06014752 RID: 83794 RVA: 0x005329EC File Offset: 0x00530BEC
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06014753 RID: 83795 RVA: 0x005329F4 File Offset: 0x00530BF4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06014754 RID: 83796 RVA: 0x005329FC File Offset: 0x00530BFC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06014755 RID: 83797 RVA: 0x00532A04 File Offset: 0x00530C04
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06014756 RID: 83798 RVA: 0x00532A0C File Offset: 0x00530C0C
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06014757 RID: 83799 RVA: 0x00532A14 File Offset: 0x00530C14
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06014758 RID: 83800 RVA: 0x00532A20 File Offset: 0x00530C20
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06014759 RID: 83801 RVA: 0x00532A2C File Offset: 0x00530C2C
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0601475A RID: 83802 RVA: 0x00532A38 File Offset: 0x00530C38
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0601475B RID: 83803 RVA: 0x00532A44 File Offset: 0x00530C44
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0601475C RID: 83804 RVA: 0x00532A4C File Offset: 0x00530C4C
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0601475D RID: 83805 RVA: 0x00532A54 File Offset: 0x00530C54
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0601475E RID: 83806 RVA: 0x00532A5C File Offset: 0x00530C5C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0601475F RID: 83807 RVA: 0x00532A64 File Offset: 0x00530C64
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06014760 RID: 83808 RVA: 0x00532A6C File Offset: 0x00530C6C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06014764 RID: 83812 RVA: 0x00532B2C File Offset: 0x00530D2C
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
					this.m_Finalize_hotfix = (luaObj.RawGet("Finalize") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitUnchartedUIController_hotfix = (luaObj.RawGet("InitUnchartedUIController") as LuaFunction);
					this.m_UninitUnchartedUIController_hotfix = (luaObj.RawGet("UninitUnchartedUIController") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_UpdateClimbTowerFlushTime_hotfix = (luaObj.RawGet("UpdateClimbTowerFlushTime") as LuaFunction);
					this.m_FlushClimbTower_hotfix = (luaObj.RawGet("FlushClimbTower") as LuaFunction);
					this.m_UnchartedUIController_OnShowUnchartedBattleTypeInt32_hotfix = (luaObj.RawGet("UnchartedUIController_OnShowUncharted") as LuaFunction);
					this.m_UnchartedUIController_OnShowTeam_hotfix = (luaObj.RawGet("UnchartedUIController_OnShowTeam") as LuaFunction);
					this.m_TeamUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("TeamUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_UnchartedUIController_OnReturn_hotfix = (luaObj.RawGet("UnchartedUIController_OnReturn") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06014765 RID: 83813 RVA: 0x00532D88 File Offset: 0x00530F88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UnchartedUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B414 RID: 46100
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "UnchartedUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Uncharted_ABS/Prefab/UnchartedUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B415 RID: 46101
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "UnchartedUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.UnchartedUIController"),
				m_ctrlName = "UnchartedUIController"
			}
		};

		// Token: 0x0400B416 RID: 46102
		private UnchartedUIController m_unchartedUIController;

		// Token: 0x0400B417 RID: 46103
		private int m_nowSeconds;

		// Token: 0x0400B418 RID: 46104
		private DateTime m_nextCheckClimbTowerFlushTime = DateTime.MinValue;

		// Token: 0x0400B419 RID: 46105
		[DoNotToLua]
		private UnchartedUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B41A RID: 46106
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B41B RID: 46107
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B41C RID: 46108
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B41D RID: 46109
		private LuaFunction m_Finalize_hotfix;

		// Token: 0x0400B41E RID: 46110
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B41F RID: 46111
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B420 RID: 46112
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B421 RID: 46113
		private LuaFunction m_InitUnchartedUIController_hotfix;

		// Token: 0x0400B422 RID: 46114
		private LuaFunction m_UninitUnchartedUIController_hotfix;

		// Token: 0x0400B423 RID: 46115
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x0400B424 RID: 46116
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B425 RID: 46117
		private LuaFunction m_UpdateClimbTowerFlushTime_hotfix;

		// Token: 0x0400B426 RID: 46118
		private LuaFunction m_FlushClimbTower_hotfix;

		// Token: 0x0400B427 RID: 46119
		private LuaFunction m_UnchartedUIController_OnShowUnchartedBattleTypeInt32_hotfix;

		// Token: 0x0400B428 RID: 46120
		private LuaFunction m_UnchartedUIController_OnShowTeam_hotfix;

		// Token: 0x0400B429 RID: 46121
		private LuaFunction m_TeamUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x0400B42A RID: 46122
		private LuaFunction m_UnchartedUIController_OnReturn_hotfix;

		// Token: 0x0400B42B RID: 46123
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B42C RID: 46124
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000FEC RID: 4076
		public new class LuaExportHelper
		{
			// Token: 0x06014766 RID: 83814 RVA: 0x00532DF0 File Offset: 0x00530FF0
			public LuaExportHelper(UnchartedUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06014767 RID: 83815 RVA: 0x00532E00 File Offset: 0x00531000
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06014768 RID: 83816 RVA: 0x00532E10 File Offset: 0x00531010
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06014769 RID: 83817 RVA: 0x00532E20 File Offset: 0x00531020
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601476A RID: 83818 RVA: 0x00532E30 File Offset: 0x00531030
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0601476B RID: 83819 RVA: 0x00532E40 File Offset: 0x00531040
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0601476C RID: 83820 RVA: 0x00532E50 File Offset: 0x00531050
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0601476D RID: 83821 RVA: 0x00532E60 File Offset: 0x00531060
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0601476E RID: 83822 RVA: 0x00532E70 File Offset: 0x00531070
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0601476F RID: 83823 RVA: 0x00532E80 File Offset: 0x00531080
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06014770 RID: 83824 RVA: 0x00532E90 File Offset: 0x00531090
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06014771 RID: 83825 RVA: 0x00532EA0 File Offset: 0x005310A0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06014772 RID: 83826 RVA: 0x00532EB0 File Offset: 0x005310B0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06014773 RID: 83827 RVA: 0x00532EC0 File Offset: 0x005310C0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06014774 RID: 83828 RVA: 0x00532ED0 File Offset: 0x005310D0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06014775 RID: 83829 RVA: 0x00532EE0 File Offset: 0x005310E0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06014776 RID: 83830 RVA: 0x00532EF0 File Offset: 0x005310F0
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06014777 RID: 83831 RVA: 0x00532F00 File Offset: 0x00531100
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06014778 RID: 83832 RVA: 0x00532F10 File Offset: 0x00531110
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06014779 RID: 83833 RVA: 0x00532F20 File Offset: 0x00531120
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0601477A RID: 83834 RVA: 0x00532F30 File Offset: 0x00531130
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0601477B RID: 83835 RVA: 0x00532F40 File Offset: 0x00531140
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0601477C RID: 83836 RVA: 0x00532F50 File Offset: 0x00531150
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0601477D RID: 83837 RVA: 0x00532F60 File Offset: 0x00531160
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17003CA7 RID: 15527
			// (get) Token: 0x0601477E RID: 83838 RVA: 0x00532F70 File Offset: 0x00531170
			// (set) Token: 0x0601477F RID: 83839 RVA: 0x00532F80 File Offset: 0x00531180
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

			// Token: 0x17003CA8 RID: 15528
			// (get) Token: 0x06014780 RID: 83840 RVA: 0x00532F90 File Offset: 0x00531190
			// (set) Token: 0x06014781 RID: 83841 RVA: 0x00532FA0 File Offset: 0x005311A0
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

			// Token: 0x17003CA9 RID: 15529
			// (get) Token: 0x06014782 RID: 83842 RVA: 0x00532FB0 File Offset: 0x005311B0
			// (set) Token: 0x06014783 RID: 83843 RVA: 0x00532FC0 File Offset: 0x005311C0
			public UnchartedUIController m_unchartedUIController
			{
				get
				{
					return this.m_owner.m_unchartedUIController;
				}
				set
				{
					this.m_owner.m_unchartedUIController = value;
				}
			}

			// Token: 0x17003CAA RID: 15530
			// (get) Token: 0x06014784 RID: 83844 RVA: 0x00532FD0 File Offset: 0x005311D0
			// (set) Token: 0x06014785 RID: 83845 RVA: 0x00532FE0 File Offset: 0x005311E0
			public int m_nowSeconds
			{
				get
				{
					return this.m_owner.m_nowSeconds;
				}
				set
				{
					this.m_owner.m_nowSeconds = value;
				}
			}

			// Token: 0x17003CAB RID: 15531
			// (get) Token: 0x06014786 RID: 83846 RVA: 0x00532FF0 File Offset: 0x005311F0
			// (set) Token: 0x06014787 RID: 83847 RVA: 0x00533000 File Offset: 0x00531200
			public DateTime m_nextCheckClimbTowerFlushTime
			{
				get
				{
					return this.m_owner.m_nextCheckClimbTowerFlushTime;
				}
				set
				{
					this.m_owner.m_nextCheckClimbTowerFlushTime = value;
				}
			}

			// Token: 0x17003CAC RID: 15532
			// (get) Token: 0x06014788 RID: 83848 RVA: 0x00533010 File Offset: 0x00531210
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003CAD RID: 15533
			// (get) Token: 0x06014789 RID: 83849 RVA: 0x00533020 File Offset: 0x00531220
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0601478A RID: 83850 RVA: 0x00533030 File Offset: 0x00531230
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0601478B RID: 83851 RVA: 0x00533040 File Offset: 0x00531240
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0601478C RID: 83852 RVA: 0x00533050 File Offset: 0x00531250
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0601478D RID: 83853 RVA: 0x00533060 File Offset: 0x00531260
			public void InitUnchartedUIController()
			{
				this.m_owner.InitUnchartedUIController();
			}

			// Token: 0x0601478E RID: 83854 RVA: 0x00533070 File Offset: 0x00531270
			public void UninitUnchartedUIController()
			{
				this.m_owner.UninitUnchartedUIController();
			}

			// Token: 0x0601478F RID: 83855 RVA: 0x00533080 File Offset: 0x00531280
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x06014790 RID: 83856 RVA: 0x00533090 File Offset: 0x00531290
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06014791 RID: 83857 RVA: 0x005330A0 File Offset: 0x005312A0
			public void UpdateClimbTowerFlushTime()
			{
				this.m_owner.UpdateClimbTowerFlushTime();
			}

			// Token: 0x06014792 RID: 83858 RVA: 0x005330B0 File Offset: 0x005312B0
			public void FlushClimbTower()
			{
				this.m_owner.FlushClimbTower();
			}

			// Token: 0x06014793 RID: 83859 RVA: 0x005330C0 File Offset: 0x005312C0
			public void UnchartedUIController_OnShowUncharted(BattleType battleType, int chapterId)
			{
				this.m_owner.UnchartedUIController_OnShowUncharted(battleType, chapterId);
			}

			// Token: 0x06014794 RID: 83860 RVA: 0x005330D0 File Offset: 0x005312D0
			public void UnchartedUIController_OnShowTeam()
			{
				this.m_owner.UnchartedUIController_OnShowTeam();
			}

			// Token: 0x06014795 RID: 83861 RVA: 0x005330E0 File Offset: 0x005312E0
			public void TeamUITask_OnLoadAllResCompleted()
			{
				this.m_owner.TeamUITask_OnLoadAllResCompleted();
			}

			// Token: 0x06014796 RID: 83862 RVA: 0x005330F0 File Offset: 0x005312F0
			public void UnchartedUIController_OnReturn()
			{
				this.m_owner.UnchartedUIController_OnReturn();
			}

			// Token: 0x0400B42D RID: 46125
			private UnchartedUITask m_owner;
		}
	}
}
