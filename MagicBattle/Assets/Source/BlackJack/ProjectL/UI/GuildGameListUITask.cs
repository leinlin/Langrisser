using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000CEF RID: 3311
	[HotFix]
	public class GuildGameListUITask : UITask
	{
		// Token: 0x0600F247 RID: 62023 RVA: 0x004050CC File Offset: 0x004032CC
		public GuildGameListUITask(string name) : base(name)
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

		// Token: 0x0600F248 RID: 62024 RVA: 0x004051C0 File Offset: 0x004033C0
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

		// Token: 0x0600F249 RID: 62025 RVA: 0x00405248 File Offset: 0x00403448
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
			if (this.m_guildGameListUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_guildGameListUIController = (this.m_uiCtrlArray[0] as GuildGameListUIController);
				}
				if (this.m_guildGameListUIController != null)
				{
					this.m_guildGameListUIController.EventOnReturn += this.OnClose;
					this.m_guildGameListUIController.EventOnGuildPlayListItemClick += this.GuildGameListUIController_OnGuildPlayListItemClick;
				}
			}
		}

		// Token: 0x0600F24A RID: 62026 RVA: 0x00405320 File Offset: 0x00403520
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
			if (this.m_guildGameListUIController != null)
			{
				this.m_guildGameListUIController.EventOnReturn -= this.OnClose;
				this.m_guildGameListUIController.EventOnGuildPlayListItemClick -= this.GuildGameListUIController_OnGuildPlayListItemClick;
				this.m_guildGameListUIController = null;
			}
		}

		// Token: 0x0600F24B RID: 62027 RVA: 0x004053CC File Offset: 0x004035CC
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
				this.m_guildGameListUIController.Open();
			}
			this.m_guildGameListUIController.GuildGameListUpdateView();
		}

		// Token: 0x0600F24C RID: 62028 RVA: 0x00405450 File Offset: 0x00403650
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				bool structParam = uiintentCustom.GetStructParam<bool>("GoToGuildMassiveCombat");
				uiintentCustom.SetParam("GoToGuildMassiveCombat", false);
				if (structParam)
				{
					this.GuildGameListUIController_OnGuildPlayListItemClick();
				}
			}
			base.PostUpdateView();
		}

		// Token: 0x0600F24D RID: 62029 RVA: 0x004054F4 File Offset: 0x004036F4
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

		// Token: 0x0600F24E RID: 62030 RVA: 0x00405578 File Offset: 0x00403778
		private void GuildGameListUIController_OnGuildPlayListItemClick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildGameListUIController_OnGuildPlayListItemClick_hotfix != null)
			{
				this.m_GuildGameListUIController_OnGuildPlayListItemClick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			Guild guildInfo = projectLPlayerContext.GetGuildInfo();
			GuildMemberCacheObject guildMemberCacheObject = guildInfo.FindMember(projectLPlayerContext.GetUserId());
			GuildTitle guildTitle;
			if (guildMemberCacheObject != null)
			{
				guildTitle = guildMemberCacheObject.Member.Title;
			}
			else
			{
				guildTitle = GuildTitle.None;
			}
			GuildMassiveCombatInfo recentCombat = guildInfo.MassiveCombat.RecentCombat;
			bool flag = (guildTitle == GuildTitle.President || guildTitle == GuildTitle.VP) && recentCombat == null;
			if (flag)
			{
				CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
				{
					UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(GuildRaidUITask).Name, null);
					UIManager.Instance.StartUITask(intent, true, false, new Action(this.GuildRaidUITask_OnLoadAllResCompleted));
				}, FadeStyle.Black, -1f, -1f);
			}
			else
			{
				CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
				{
					UIIntentReturnable intent = new UIIntentReturnable(this.m_currIntent, typeof(GuildMassiveCombatUITask).Name, null);
					UIManager.Instance.StartUITask(intent, true, false, new Action(this.GuildMassiveCombatUITask_OnLoadAllResCompleted));
				}, FadeStyle.Black, -1f, -1f);
			}
		}

		// Token: 0x0600F24F RID: 62031 RVA: 0x00405688 File Offset: 0x00403888
		private void GuildRaidUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GuildRaidUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_GuildRaidUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(GuildRaidUITask));
			if (uitaskBase != null)
			{
				base.Pause();
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600F250 RID: 62032 RVA: 0x00405714 File Offset: 0x00403914
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

		// Token: 0x17002E87 RID: 11911
		// (get) Token: 0x0600F251 RID: 62033 RVA: 0x004057A0 File Offset: 0x004039A0
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

		// Token: 0x17002E88 RID: 11912
		// (get) Token: 0x0600F252 RID: 62034 RVA: 0x00405814 File Offset: 0x00403A14
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

		// Token: 0x17002E89 RID: 11913
		// (get) Token: 0x0600F253 RID: 62035 RVA: 0x00405888 File Offset: 0x00403A88
		// (set) Token: 0x0600F254 RID: 62036 RVA: 0x004058A8 File Offset: 0x00403AA8
		[DoNotToLua]
		public new GuildGameListUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildGameListUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600F255 RID: 62037 RVA: 0x004058B4 File Offset: 0x00403AB4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600F256 RID: 62038 RVA: 0x004058C0 File Offset: 0x00403AC0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600F257 RID: 62039 RVA: 0x004058C8 File Offset: 0x00403AC8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600F258 RID: 62040 RVA: 0x004058D0 File Offset: 0x00403AD0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600F259 RID: 62041 RVA: 0x004058DC File Offset: 0x00403ADC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600F25A RID: 62042 RVA: 0x004058E8 File Offset: 0x00403AE8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600F25B RID: 62043 RVA: 0x004058F4 File Offset: 0x00403AF4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600F25C RID: 62044 RVA: 0x004058FC File Offset: 0x00403AFC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600F25D RID: 62045 RVA: 0x00405904 File Offset: 0x00403B04
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600F25E RID: 62046 RVA: 0x0040590C File Offset: 0x00403B0C
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600F25F RID: 62047 RVA: 0x00405914 File Offset: 0x00403B14
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600F260 RID: 62048 RVA: 0x0040591C File Offset: 0x00403B1C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600F261 RID: 62049 RVA: 0x00405924 File Offset: 0x00403B24
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600F262 RID: 62050 RVA: 0x0040592C File Offset: 0x00403B2C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600F263 RID: 62051 RVA: 0x00405938 File Offset: 0x00403B38
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600F264 RID: 62052 RVA: 0x00405944 File Offset: 0x00403B44
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600F265 RID: 62053 RVA: 0x00405950 File Offset: 0x00403B50
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600F266 RID: 62054 RVA: 0x0040595C File Offset: 0x00403B5C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600F267 RID: 62055 RVA: 0x00405964 File Offset: 0x00403B64
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600F268 RID: 62056 RVA: 0x0040596C File Offset: 0x00403B6C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600F269 RID: 62057 RVA: 0x00405974 File Offset: 0x00403B74
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600F26A RID: 62058 RVA: 0x0040597C File Offset: 0x00403B7C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600F26B RID: 62059 RVA: 0x00405984 File Offset: 0x00403B84
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600F26F RID: 62063 RVA: 0x00405A30 File Offset: 0x00403C30
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
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_OnClose_hotfix = (luaObj.RawGet("OnClose") as LuaFunction);
					this.m_GuildGameListUIController_OnGuildPlayListItemClick_hotfix = (luaObj.RawGet("GuildGameListUIController_OnGuildPlayListItemClick") as LuaFunction);
					this.m_GuildRaidUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("GuildRaidUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_GuildMassiveCombatUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("GuildMassiveCombatUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600F270 RID: 62064 RVA: 0x00405C10 File Offset: 0x00403E10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildGameListUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04008FCA RID: 36810
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "GuildGameListUIUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Guild_ABS/Prefab/GuildGameListUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04008FCB RID: 36811
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "GuildGameListUIUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.GuildGameListUIController"),
				m_ctrlName = "GuildGameListUIController"
			}
		};

		// Token: 0x04008FCC RID: 36812
		private GuildGameListUIController m_guildGameListUIController;

		// Token: 0x04008FCD RID: 36813
		[DoNotToLua]
		private GuildGameListUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04008FCE RID: 36814
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04008FCF RID: 36815
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04008FD0 RID: 36816
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04008FD1 RID: 36817
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04008FD2 RID: 36818
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04008FD3 RID: 36819
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04008FD4 RID: 36820
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04008FD5 RID: 36821
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x04008FD6 RID: 36822
		private LuaFunction m_OnClose_hotfix;

		// Token: 0x04008FD7 RID: 36823
		private LuaFunction m_GuildGameListUIController_OnGuildPlayListItemClick_hotfix;

		// Token: 0x04008FD8 RID: 36824
		private LuaFunction m_GuildRaidUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04008FD9 RID: 36825
		private LuaFunction m_GuildMassiveCombatUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x04008FDA RID: 36826
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04008FDB RID: 36827
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000CF0 RID: 3312
		public new class LuaExportHelper
		{
			// Token: 0x0600F271 RID: 62065 RVA: 0x00405C78 File Offset: 0x00403E78
			public LuaExportHelper(GuildGameListUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600F272 RID: 62066 RVA: 0x00405C88 File Offset: 0x00403E88
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600F273 RID: 62067 RVA: 0x00405C98 File Offset: 0x00403E98
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600F274 RID: 62068 RVA: 0x00405CA8 File Offset: 0x00403EA8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600F275 RID: 62069 RVA: 0x00405CB8 File Offset: 0x00403EB8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600F276 RID: 62070 RVA: 0x00405CC8 File Offset: 0x00403EC8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600F277 RID: 62071 RVA: 0x00405CD8 File Offset: 0x00403ED8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600F278 RID: 62072 RVA: 0x00405CE8 File Offset: 0x00403EE8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F279 RID: 62073 RVA: 0x00405CF8 File Offset: 0x00403EF8
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600F27A RID: 62074 RVA: 0x00405D08 File Offset: 0x00403F08
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600F27B RID: 62075 RVA: 0x00405D18 File Offset: 0x00403F18
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600F27C RID: 62076 RVA: 0x00405D28 File Offset: 0x00403F28
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600F27D RID: 62077 RVA: 0x00405D38 File Offset: 0x00403F38
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600F27E RID: 62078 RVA: 0x00405D48 File Offset: 0x00403F48
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600F27F RID: 62079 RVA: 0x00405D58 File Offset: 0x00403F58
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600F280 RID: 62080 RVA: 0x00405D68 File Offset: 0x00403F68
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600F281 RID: 62081 RVA: 0x00405D78 File Offset: 0x00403F78
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600F282 RID: 62082 RVA: 0x00405D88 File Offset: 0x00403F88
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600F283 RID: 62083 RVA: 0x00405D98 File Offset: 0x00403F98
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600F284 RID: 62084 RVA: 0x00405DA8 File Offset: 0x00403FA8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600F285 RID: 62085 RVA: 0x00405DB8 File Offset: 0x00403FB8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600F286 RID: 62086 RVA: 0x00405DC8 File Offset: 0x00403FC8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600F287 RID: 62087 RVA: 0x00405DD8 File Offset: 0x00403FD8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600F288 RID: 62088 RVA: 0x00405DE8 File Offset: 0x00403FE8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x17002E8A RID: 11914
			// (get) Token: 0x0600F289 RID: 62089 RVA: 0x00405DF8 File Offset: 0x00403FF8
			// (set) Token: 0x0600F28A RID: 62090 RVA: 0x00405E08 File Offset: 0x00404008
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

			// Token: 0x17002E8B RID: 11915
			// (get) Token: 0x0600F28B RID: 62091 RVA: 0x00405E18 File Offset: 0x00404018
			// (set) Token: 0x0600F28C RID: 62092 RVA: 0x00405E28 File Offset: 0x00404028
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

			// Token: 0x17002E8C RID: 11916
			// (get) Token: 0x0600F28D RID: 62093 RVA: 0x00405E38 File Offset: 0x00404038
			// (set) Token: 0x0600F28E RID: 62094 RVA: 0x00405E48 File Offset: 0x00404048
			public GuildGameListUIController m_guildGameListUIController
			{
				get
				{
					return this.m_owner.m_guildGameListUIController;
				}
				set
				{
					this.m_owner.m_guildGameListUIController = value;
				}
			}

			// Token: 0x17002E8D RID: 11917
			// (get) Token: 0x0600F28F RID: 62095 RVA: 0x00405E58 File Offset: 0x00404058
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002E8E RID: 11918
			// (get) Token: 0x0600F290 RID: 62096 RVA: 0x00405E68 File Offset: 0x00404068
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600F291 RID: 62097 RVA: 0x00405E78 File Offset: 0x00404078
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600F292 RID: 62098 RVA: 0x00405E88 File Offset: 0x00404088
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600F293 RID: 62099 RVA: 0x00405E98 File Offset: 0x00404098
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600F294 RID: 62100 RVA: 0x00405EA8 File Offset: 0x004040A8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600F295 RID: 62101 RVA: 0x00405EB8 File Offset: 0x004040B8
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x0600F296 RID: 62102 RVA: 0x00405EC8 File Offset: 0x004040C8
			public void OnClose()
			{
				this.m_owner.OnClose();
			}

			// Token: 0x0600F297 RID: 62103 RVA: 0x00405ED8 File Offset: 0x004040D8
			public void GuildGameListUIController_OnGuildPlayListItemClick()
			{
				this.m_owner.GuildGameListUIController_OnGuildPlayListItemClick();
			}

			// Token: 0x0600F298 RID: 62104 RVA: 0x00405EE8 File Offset: 0x004040E8
			public void GuildRaidUITask_OnLoadAllResCompleted()
			{
				this.m_owner.GuildRaidUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600F299 RID: 62105 RVA: 0x00405EF8 File Offset: 0x004040F8
			public void GuildMassiveCombatUITask_OnLoadAllResCompleted()
			{
				this.m_owner.GuildMassiveCombatUITask_OnLoadAllResCompleted();
			}

			// Token: 0x04008FDC RID: 36828
			private GuildGameListUITask m_owner;
		}
	}
}
