using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000D44 RID: 3396
	[HotFix]
	public class GuildRaidUITask : UITask
	{
		// Token: 0x0600F93D RID: 63805 RVA: 0x0041A6D4 File Offset: 0x004188D4
		public GuildRaidUITask(string name) : base(name)
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

		// Token: 0x0600F93E RID: 63806 RVA: 0x0041A7C8 File Offset: 0x004189C8
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
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F93F RID: 63807 RVA: 0x0041A850 File Offset: 0x00418A50
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
			if (this.m_guildRaidUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_guildRaidUIController = (this.m_uiCtrlArray[0] as GuildRaidUIController);
				}
				if (this.m_guildRaidUIController != null)
				{
					this.m_guildRaidUIController.EventOnReturn += this.OnClose;
					this.m_guildRaidUIController.EventOnGuildRaidListItemClick += this.GuildRaidUIController_OnGuildRaidListItemClick;
				}
			}
		}

		// Token: 0x0600F940 RID: 63808 RVA: 0x0041A928 File Offset: 0x00418B28
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
			if (this.m_guildRaidUIController != null)
			{
				this.m_guildRaidUIController.EventOnReturn -= this.OnClose;
				this.m_guildRaidUIController.EventOnGuildRaidListItemClick -= this.GuildRaidUIController_OnGuildRaidListItemClick;
				this.m_guildRaidUIController = null;
			}
		}

		// Token: 0x0600F941 RID: 63809 RVA: 0x0041A9D4 File Offset: 0x00418BD4
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
				this.m_guildRaidUIController.Open();
			}
			this.m_guildRaidUIController.GuildRaidUpdateView();
		}

		// Token: 0x0600F942 RID: 63810 RVA: 0x0041AA58 File Offset: 0x00418C58
		private void OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnClose_hotfix != null)
			{
				this.m_OnClose_hotfix.call(new object[]
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

		// Token: 0x0600F943 RID: 63811 RVA: 0x0041AADC File Offset: 0x00418CDC
		private void GuildRaidUIController_OnGuildRaidListItemClick(ConfigDataGuildMassiveCombatDifficultyInfo info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildRaidUIController_OnGuildRaidListItemClickConfigDataGuildMassiveCombatDifficultyInfo_hotfix != null)
			{
				this.m_GuildRaidUIController_OnGuildRaidListItemClickConfigDataGuildMassiveCombatDifficultyInfo_hotfix.call(new object[]
				{
					this,
					info
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GuildMassiveCombatStartNetTask guildMassiveCombatStartNetTask = new GuildMassiveCombatStartNetTask(info.ID);
			guildMassiveCombatStartNetTask.EventOnStop += delegate(Task task)
			{
				GuildMassiveCombatStartNetTask guildMassiveCombatStartNetTask2 = task as GuildMassiveCombatStartNetTask;
				if (guildMassiveCombatStartNetTask2.Result == 0)
				{
					this.GotoGuildMassiveCombatUITask();
				}
				else
				{
					CommonUIController.Instance.ShowErrorMessage(guildMassiveCombatStartNetTask2.Result, 2f, null, true);
				}
			};
			guildMassiveCombatStartNetTask.Start(null);
		}

		// Token: 0x0600F944 RID: 63812 RVA: 0x0041AB74 File Offset: 0x00418D74
		private void GotoGuildMassiveCombatUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GotoGuildMassiveCombatUITask_hotfix != null)
			{
				this.m_GotoGuildMassiveCombatUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntentReturnable uiintentReturnable = this.m_currIntent as UIIntentReturnable;
				UIIntentReturnable intent = new UIIntentReturnable(uiintentReturnable.PrevTaskIntent, typeof(GuildMassiveCombatUITask).Name, null);
				UIManager.Instance.StartUITask(intent, true, false, new Action(this.GuildMassiveCombatUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600F945 RID: 63813 RVA: 0x0041ABF8 File Offset: 0x00418DF8
		private void GuildMassiveCombatUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildMassiveCombatUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_GuildMassiveCombatUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GuildMassiveCombatUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x17002F98 RID: 12184
		// (get) Token: 0x0600F946 RID: 63814 RVA: 0x0041AC84 File Offset: 0x00418E84
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

		// Token: 0x17002F99 RID: 12185
		// (get) Token: 0x0600F947 RID: 63815 RVA: 0x0041ACF8 File Offset: 0x00418EF8
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

		// Token: 0x17002F9A RID: 12186
		// (get) Token: 0x0600F948 RID: 63816 RVA: 0x0041AD6C File Offset: 0x00418F6C
		// (set) Token: 0x0600F949 RID: 63817 RVA: 0x0041AD8C File Offset: 0x00418F8C
		[DoNotToLua]
		public new GuildRaidUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildRaidUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F94A RID: 63818 RVA: 0x0041AD98 File Offset: 0x00418F98
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600F94B RID: 63819 RVA: 0x0041ADA4 File Offset: 0x00418FA4
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600F94C RID: 63820 RVA: 0x0041ADAC File Offset: 0x00418FAC
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600F94D RID: 63821 RVA: 0x0041ADB4 File Offset: 0x00418FB4
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600F94E RID: 63822 RVA: 0x0041ADC0 File Offset: 0x00418FC0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600F94F RID: 63823 RVA: 0x0041ADCC File Offset: 0x00418FCC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600F950 RID: 63824 RVA: 0x0041ADD8 File Offset: 0x00418FD8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F951 RID: 63825 RVA: 0x0041ADE0 File Offset: 0x00418FE0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600F952 RID: 63826 RVA: 0x0041ADE8 File Offset: 0x00418FE8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600F953 RID: 63827 RVA: 0x0041ADF0 File Offset: 0x00418FF0
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600F954 RID: 63828 RVA: 0x0041ADF8 File Offset: 0x00418FF8
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600F955 RID: 63829 RVA: 0x0041AE00 File Offset: 0x00419000
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600F956 RID: 63830 RVA: 0x0041AE08 File Offset: 0x00419008
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600F957 RID: 63831 RVA: 0x0041AE10 File Offset: 0x00419010
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600F958 RID: 63832 RVA: 0x0041AE1C File Offset: 0x0041901C
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600F959 RID: 63833 RVA: 0x0041AE28 File Offset: 0x00419028
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600F95A RID: 63834 RVA: 0x0041AE34 File Offset: 0x00419034
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600F95B RID: 63835 RVA: 0x0041AE40 File Offset: 0x00419040
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600F95C RID: 63836 RVA: 0x0041AE48 File Offset: 0x00419048
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600F95D RID: 63837 RVA: 0x0041AE50 File Offset: 0x00419050
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600F95E RID: 63838 RVA: 0x0041AE58 File Offset: 0x00419058
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600F95F RID: 63839 RVA: 0x0041AE60 File Offset: 0x00419060
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600F960 RID: 63840 RVA: 0x0041AE68 File Offset: 0x00419068
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600F964 RID: 63844 RVA: 0x0041AF20 File Offset: 0x00419120
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
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_OnClose_hotfix = (luaObj.RawGet("OnClose") as LuaFunction);
					this.m_GuildRaidUIController_OnGuildRaidListItemClickConfigDataGuildMassiveCombatDifficultyInfo_hotfix = (luaObj.RawGet("GuildRaidUIController_OnGuildRaidListItemClick") as LuaFunction);
					this.m_GotoGuildMassiveCombatUITask_hotfix = (luaObj.RawGet("GotoGuildMassiveCombatUITask") as LuaFunction);
					this.m_GuildMassiveCombatUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("GuildMassiveCombatUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F965 RID: 63845 RVA: 0x0041B0E8 File Offset: 0x004192E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildRaidUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04009275 RID: 37493
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GuildRaidUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/GuildRaidUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04009276 RID: 37494
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildRaidUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildRaidUIController"),
				m_ctrlName = "GuildRaidUIController"
			}
		};

		// Token: 0x04009277 RID: 37495
		private GuildRaidUIController m_guildRaidUIController;

		// Token: 0x04009278 RID: 37496
		[DoNotToLua]
		private GuildRaidUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04009279 RID: 37497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400927A RID: 37498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400927B RID: 37499
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400927C RID: 37500
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400927D RID: 37501
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400927E RID: 37502
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400927F RID: 37503
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04009280 RID: 37504
		private LuaFunction m_OnClose_hotfix;

		// Token: 0x04009281 RID: 37505
		private LuaFunction m_GuildRaidUIController_OnGuildRaidListItemClickConfigDataGuildMassiveCombatDifficultyInfo_hotfix;

		// Token: 0x04009282 RID: 37506
		private LuaFunction m_GotoGuildMassiveCombatUITask_hotfix;

		// Token: 0x04009283 RID: 37507
		private LuaFunction m_GuildMassiveCombatUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04009284 RID: 37508
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04009285 RID: 37509
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000D45 RID: 3397
		public new class LuaExportHelper
		{
			// Token: 0x0600F966 RID: 63846 RVA: 0x0041B150 File Offset: 0x00419350
			public LuaExportHelper(GuildRaidUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F967 RID: 63847 RVA: 0x0041B160 File Offset: 0x00419360
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600F968 RID: 63848 RVA: 0x0041B170 File Offset: 0x00419370
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600F969 RID: 63849 RVA: 0x0041B180 File Offset: 0x00419380
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600F96A RID: 63850 RVA: 0x0041B190 File Offset: 0x00419390
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600F96B RID: 63851 RVA: 0x0041B1A0 File Offset: 0x004193A0
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600F96C RID: 63852 RVA: 0x0041B1B0 File Offset: 0x004193B0
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600F96D RID: 63853 RVA: 0x0041B1C0 File Offset: 0x004193C0
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F96E RID: 63854 RVA: 0x0041B1D0 File Offset: 0x004193D0
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600F96F RID: 63855 RVA: 0x0041B1E0 File Offset: 0x004193E0
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600F970 RID: 63856 RVA: 0x0041B1F0 File Offset: 0x004193F0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600F971 RID: 63857 RVA: 0x0041B200 File Offset: 0x00419400
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600F972 RID: 63858 RVA: 0x0041B210 File Offset: 0x00419410
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600F973 RID: 63859 RVA: 0x0041B220 File Offset: 0x00419420
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600F974 RID: 63860 RVA: 0x0041B230 File Offset: 0x00419430
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600F975 RID: 63861 RVA: 0x0041B240 File Offset: 0x00419440
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600F976 RID: 63862 RVA: 0x0041B250 File Offset: 0x00419450
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600F977 RID: 63863 RVA: 0x0041B260 File Offset: 0x00419460
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600F978 RID: 63864 RVA: 0x0041B270 File Offset: 0x00419470
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600F979 RID: 63865 RVA: 0x0041B280 File Offset: 0x00419480
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600F97A RID: 63866 RVA: 0x0041B290 File Offset: 0x00419490
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600F97B RID: 63867 RVA: 0x0041B2A0 File Offset: 0x004194A0
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600F97C RID: 63868 RVA: 0x0041B2B0 File Offset: 0x004194B0
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600F97D RID: 63869 RVA: 0x0041B2C0 File Offset: 0x004194C0
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002F9B RID: 12187
			// (get) Token: 0x0600F97E RID: 63870 RVA: 0x0041B2D0 File Offset: 0x004194D0
			// (set) Token: 0x0600F97F RID: 63871 RVA: 0x0041B2E0 File Offset: 0x004194E0
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

			// Token: 0x17002F9C RID: 12188
			// (get) Token: 0x0600F980 RID: 63872 RVA: 0x0041B2F0 File Offset: 0x004194F0
			// (set) Token: 0x0600F981 RID: 63873 RVA: 0x0041B300 File Offset: 0x00419500
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

			// Token: 0x17002F9D RID: 12189
			// (get) Token: 0x0600F982 RID: 63874 RVA: 0x0041B310 File Offset: 0x00419510
			// (set) Token: 0x0600F983 RID: 63875 RVA: 0x0041B320 File Offset: 0x00419520
			public GuildRaidUIController m_guildRaidUIController
			{
				get
				{
					return this.m_owner.m_guildRaidUIController;
				}
				set
				{
					this.m_owner.m_guildRaidUIController = value;
				}
			}

			// Token: 0x17002F9E RID: 12190
			// (get) Token: 0x0600F984 RID: 63876 RVA: 0x0041B330 File Offset: 0x00419530
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002F9F RID: 12191
			// (get) Token: 0x0600F985 RID: 63877 RVA: 0x0041B340 File Offset: 0x00419540
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600F986 RID: 63878 RVA: 0x0041B350 File Offset: 0x00419550
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F987 RID: 63879 RVA: 0x0041B360 File Offset: 0x00419560
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600F988 RID: 63880 RVA: 0x0041B370 File Offset: 0x00419570
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600F989 RID: 63881 RVA: 0x0041B380 File Offset: 0x00419580
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600F98A RID: 63882 RVA: 0x0041B390 File Offset: 0x00419590
			public void OnClose()
			{
				this.m_owner.OnClose();
			}

			// Token: 0x0600F98B RID: 63883 RVA: 0x0041B3A0 File Offset: 0x004195A0
			public void GuildRaidUIController_OnGuildRaidListItemClick(ConfigDataGuildMassiveCombatDifficultyInfo info)
			{
				this.m_owner.GuildRaidUIController_OnGuildRaidListItemClick(info);
			}

			// Token: 0x0600F98C RID: 63884 RVA: 0x0041B3B0 File Offset: 0x004195B0
			public void GotoGuildMassiveCombatUITask()
			{
				this.m_owner.GotoGuildMassiveCombatUITask();
			}

			// Token: 0x0600F98D RID: 63885 RVA: 0x0041B3C0 File Offset: 0x004195C0
			public void GuildMassiveCombatUITask_OnLoadAllResCompleted()
			{
				this.m_owner.GuildMassiveCombatUITask_OnLoadAllResCompleted();
			}

			// Token: 0x04009286 RID: 37510
			private GuildRaidUITask m_owner;
		}
	}
}
