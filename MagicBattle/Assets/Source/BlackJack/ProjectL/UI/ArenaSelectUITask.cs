using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A22 RID: 2594
	[HotFix]
	public class ArenaSelectUITask : UITask
	{
		// Token: 0x06009BB9 RID: 39865 RVA: 0x002C4BB8 File Offset: 0x002C2DB8
		public ArenaSelectUITask(string name) : base(name)
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

		// Token: 0x06009BBA RID: 39866 RVA: 0x002C4CAC File Offset: 0x002C2EAC
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
			WorldUITask.ShowWorld(true);
			return base.OnResume(intent);
		}

		// Token: 0x06009BBB RID: 39867 RVA: 0x002C4D38 File Offset: 0x002C2F38
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
			this.InitArenaSelectUIController();
		}

		// Token: 0x06009BBC RID: 39868 RVA: 0x002C4DA4 File Offset: 0x002C2FA4
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
			this.UninitArenaSelectUIController();
		}

		// Token: 0x06009BBD RID: 39869 RVA: 0x002C4E10 File Offset: 0x002C3010
		private void InitArenaSelectUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitArenaSelectUIController_hotfix != null)
			{
				this.m_InitArenaSelectUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaSelectUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_arenaSelectUIController = (this.m_uiCtrlArray[0] as ArenaSelectUIController);
				}
				if (!(this.m_arenaSelectUIController != null))
				{
					Debug.LogError("ArenaSelectUIController is null");
					return;
				}
				this.m_arenaSelectUIController.EventOnClose += this.ArenaSelectUIController_OnClose;
				this.m_arenaSelectUIController.EventOnShowOfflineArena += this.ArenaSelectUIController_OnShowOfflineArena;
				this.m_arenaSelectUIController.EventOnShowOnlineArena += this.ArenaSelectUIController_OnShowOnlineArena;
			}
		}

		// Token: 0x06009BBE RID: 39870 RVA: 0x002C4F08 File Offset: 0x002C3108
		private void UninitArenaSelectUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitArenaSelectUIController_hotfix != null)
			{
				this.m_UninitArenaSelectUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_arenaSelectUIController != null)
			{
				this.m_arenaSelectUIController.EventOnClose -= this.ArenaSelectUIController_OnClose;
				this.m_arenaSelectUIController.EventOnShowOfflineArena -= this.ArenaSelectUIController_OnShowOfflineArena;
				this.m_arenaSelectUIController.EventOnShowOnlineArena -= this.ArenaSelectUIController_OnShowOnlineArena;
				this.m_arenaSelectUIController = null;
			}
		}

		// Token: 0x06009BBF RID: 39871 RVA: 0x002C4FC8 File Offset: 0x002C31C8
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
				this.m_arenaSelectUIController.Open();
				WorldUITask.WorldUIController_ShowHide(false, false);
			}
			UIIntentCustom uiintentCustom = this.m_currIntent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				ArenaUIType structParam = uiintentCustom.GetStructParam<ArenaUIType>("ArenaUIType");
				this.m_isBattleReport = uiintentCustom.GetStructParam<bool>("IsBattleReport");
				uiintentCustom.SetParam("ArenaUIType", ArenaUIType.None);
				uiintentCustom.SetParam("IsBattleReport", false);
				if (structParam != ArenaUIType.None)
				{
					if (structParam == ArenaUIType.Offline)
					{
						this.ArenaSelectUIController_OnShowOfflineArena();
					}
					else if (structParam == ArenaUIType.Online)
					{
						this.ArenaSelectUIController_OnShowOnlineArena();
					}
				}
			}
		}

		// Token: 0x06009BC0 RID: 39872 RVA: 0x002C50BC File Offset: 0x002C32BC
		private void ArenaSelectUIController_OnShowOfflineArena()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaSelectUIController_OnShowOfflineArena_hotfix != null)
			{
				this.m_ArenaSelectUIController_OnShowOfflineArena_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsArenaInSettleTime())
			{
				CommonUIController.Instance.ShowErrorMessage(-2017, 2f, null, true);
				return;
			}
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				WorldUITask.WorldUIController_ShowHide(true, false);
				base.Pause();
				if (this.EventOnShowArena != null)
				{
					this.EventOnShowArena(ArenaUIType.Offline, this.m_isBattleReport, this.m_currIntent);
				}
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06009BC1 RID: 39873 RVA: 0x002C5170 File Offset: 0x002C3370
		private void ArenaSelectUIController_OnShowOnlineArena()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaSelectUIController_OnShowOnlineArena_hotfix != null)
			{
				this.m_ArenaSelectUIController_OnShowOnlineArena_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.StartShowFadeOutLoadingFadeIn(delegate
			{
				CommonUIController.Instance.HideFadeOutLoadingFadeIn();
				WorldUITask.WorldUIController_ShowHide(true, false);
				base.Pause();
				if (this.EventOnShowArena != null)
				{
					this.EventOnShowArena(ArenaUIType.Online, this.m_isBattleReport, this.m_currIntent);
				}
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x06009BC2 RID: 39874 RVA: 0x002C51F4 File Offset: 0x002C33F4
		private void ArenaSelectUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ArenaSelectUIController_OnClose_hotfix != null)
			{
				this.m_ArenaSelectUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			WorldUITask.WorldUIController_ShowHide(true, false);
			this.m_arenaSelectUIController.Close(delegate
			{
				base.Pause();
				base.ReturnPrevUITask();
			});
		}

		// Token: 0x140001C4 RID: 452
		// (add) Token: 0x06009BC3 RID: 39875 RVA: 0x002C5274 File Offset: 0x002C3474
		// (remove) Token: 0x06009BC4 RID: 39876 RVA: 0x002C5310 File Offset: 0x002C3510
		public event Action<ArenaUIType, bool, UIIntent> EventOnShowArena
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnShowArenaAction`3_hotfix != null)
				{
					this.m_add_EventOnShowArenaAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaUIType, bool, UIIntent> action = this.EventOnShowArena;
				Action<ArenaUIType, bool, UIIntent> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaUIType, bool, UIIntent>>(ref this.EventOnShowArena, (Action<ArenaUIType, bool, UIIntent>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnShowArenaAction`3_hotfix != null)
				{
					this.m_remove_EventOnShowArenaAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ArenaUIType, bool, UIIntent> action = this.EventOnShowArena;
				Action<ArenaUIType, bool, UIIntent> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ArenaUIType, bool, UIIntent>>(ref this.EventOnShowArena, (Action<ArenaUIType, bool, UIIntent>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x17001FB1 RID: 8113
		// (get) Token: 0x06009BC5 RID: 39877 RVA: 0x002C53AC File Offset: 0x002C35AC
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

		// Token: 0x17001FB2 RID: 8114
		// (get) Token: 0x06009BC6 RID: 39878 RVA: 0x002C5420 File Offset: 0x002C3620
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

		// Token: 0x17001FB3 RID: 8115
		// (get) Token: 0x06009BC7 RID: 39879 RVA: 0x002C5494 File Offset: 0x002C3694
		// (set) Token: 0x06009BC8 RID: 39880 RVA: 0x002C54B4 File Offset: 0x002C36B4
		[DoNotToLua]
		public new ArenaSelectUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ArenaSelectUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009BC9 RID: 39881 RVA: 0x002C54C0 File Offset: 0x002C36C0
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06009BCA RID: 39882 RVA: 0x002C54CC File Offset: 0x002C36CC
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x06009BCB RID: 39883 RVA: 0x002C54D4 File Offset: 0x002C36D4
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x06009BCC RID: 39884 RVA: 0x002C54DC File Offset: 0x002C36DC
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x06009BCD RID: 39885 RVA: 0x002C54E8 File Offset: 0x002C36E8
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x06009BCE RID: 39886 RVA: 0x002C54F4 File Offset: 0x002C36F4
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x06009BCF RID: 39887 RVA: 0x002C5500 File Offset: 0x002C3700
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06009BD0 RID: 39888 RVA: 0x002C5508 File Offset: 0x002C3708
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x06009BD1 RID: 39889 RVA: 0x002C5510 File Offset: 0x002C3710
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x06009BD2 RID: 39890 RVA: 0x002C5518 File Offset: 0x002C3718
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x06009BD3 RID: 39891 RVA: 0x002C5520 File Offset: 0x002C3720
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x06009BD4 RID: 39892 RVA: 0x002C5528 File Offset: 0x002C3728
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x06009BD5 RID: 39893 RVA: 0x002C5530 File Offset: 0x002C3730
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x06009BD6 RID: 39894 RVA: 0x002C5538 File Offset: 0x002C3738
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x06009BD7 RID: 39895 RVA: 0x002C5544 File Offset: 0x002C3744
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x06009BD8 RID: 39896 RVA: 0x002C5550 File Offset: 0x002C3750
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x06009BD9 RID: 39897 RVA: 0x002C555C File Offset: 0x002C375C
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x06009BDA RID: 39898 RVA: 0x002C5568 File Offset: 0x002C3768
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x06009BDB RID: 39899 RVA: 0x002C5570 File Offset: 0x002C3770
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x06009BDC RID: 39900 RVA: 0x002C5578 File Offset: 0x002C3778
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x06009BDD RID: 39901 RVA: 0x002C5580 File Offset: 0x002C3780
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x06009BDE RID: 39902 RVA: 0x002C5588 File Offset: 0x002C3788
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x06009BDF RID: 39903 RVA: 0x002C5590 File Offset: 0x002C3790
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x06009BE0 RID: 39904 RVA: 0x002C5598 File Offset: 0x002C3798
		private void __callDele_EventOnShowArena(ArenaUIType arg1, bool arg2, UIIntent arg3)
		{
			Action<ArenaUIType, bool, UIIntent> eventOnShowArena = this.EventOnShowArena;
			if (eventOnShowArena != null)
			{
				eventOnShowArena(arg1, arg2, arg3);
			}
		}

		// Token: 0x06009BE1 RID: 39905 RVA: 0x002C55BC File Offset: 0x002C37BC
		private void __clearDele_EventOnShowArena(ArenaUIType arg1, bool arg2, UIIntent arg3)
		{
			this.EventOnShowArena = null;
		}

		// Token: 0x06009BE5 RID: 39909 RVA: 0x002C5650 File Offset: 0x002C3850
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
					this.m_OnResumeUIIntent_hotfix = (luaObj.RawGet("OnResume") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_InitArenaSelectUIController_hotfix = (luaObj.RawGet("InitArenaSelectUIController") as LuaFunction);
					this.m_UninitArenaSelectUIController_hotfix = (luaObj.RawGet("UninitArenaSelectUIController") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_ArenaSelectUIController_OnShowOfflineArena_hotfix = (luaObj.RawGet("ArenaSelectUIController_OnShowOfflineArena") as LuaFunction);
					this.m_ArenaSelectUIController_OnShowOnlineArena_hotfix = (luaObj.RawGet("ArenaSelectUIController_OnShowOnlineArena") as LuaFunction);
					this.m_ArenaSelectUIController_OnClose_hotfix = (luaObj.RawGet("ArenaSelectUIController_OnClose") as LuaFunction);
					this.m_add_EventOnShowArenaAction`3_hotfix = (luaObj.RawGet("add_EventOnShowArena") as LuaFunction);
					this.m_remove_EventOnShowArenaAction`3_hotfix = (luaObj.RawGet("remove_EventOnShowArena") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06009BE6 RID: 39910 RVA: 0x002C5860 File Offset: 0x002C3A60
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaSelectUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040069E9 RID: 27113
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "ArenaSelectUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Arena_ABS/Prefab/ArenaSelectUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040069EA RID: 27114
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "ArenaSelectUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.ArenaSelectUIController"),
				m_ctrlName = "ArenaSelectUIController"
			}
		};

		// Token: 0x040069EB RID: 27115
		private ArenaSelectUIController m_arenaSelectUIController;

		// Token: 0x040069EC RID: 27116
		private bool m_isBattleReport;

		// Token: 0x040069ED RID: 27117
		[DoNotToLua]
		private ArenaSelectUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040069EE RID: 27118
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040069EF RID: 27119
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040069F0 RID: 27120
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040069F1 RID: 27121
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x040069F2 RID: 27122
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040069F3 RID: 27123
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040069F4 RID: 27124
		private LuaFunction m_InitArenaSelectUIController_hotfix;

		// Token: 0x040069F5 RID: 27125
		private LuaFunction m_UninitArenaSelectUIController_hotfix;

		// Token: 0x040069F6 RID: 27126
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040069F7 RID: 27127
		private LuaFunction m_ArenaSelectUIController_OnShowOfflineArena_hotfix;

		// Token: 0x040069F8 RID: 27128
		private LuaFunction m_ArenaSelectUIController_OnShowOnlineArena_hotfix;

		// Token: 0x040069F9 RID: 27129
		private LuaFunction m_ArenaSelectUIController_OnClose_hotfix;

		// Token: 0x040069FA RID: 27130
		private LuaFunction m_add_EventOnShowArenaAction;

		// Token: 0x040069FB RID: 27131
		private LuaFunction m_remove_EventOnShowArenaAction;

		// Token: 0x040069FC RID: 27132
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040069FD RID: 27133
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000A23 RID: 2595
		public new class LuaExportHelper
		{
			// Token: 0x06009BE7 RID: 39911 RVA: 0x002C58C8 File Offset: 0x002C3AC8
			public LuaExportHelper(ArenaSelectUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06009BE8 RID: 39912 RVA: 0x002C58D8 File Offset: 0x002C3AD8
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x06009BE9 RID: 39913 RVA: 0x002C58E8 File Offset: 0x002C3AE8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x06009BEA RID: 39914 RVA: 0x002C58F8 File Offset: 0x002C3AF8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x06009BEB RID: 39915 RVA: 0x002C5908 File Offset: 0x002C3B08
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x06009BEC RID: 39916 RVA: 0x002C5918 File Offset: 0x002C3B18
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x06009BED RID: 39917 RVA: 0x002C5928 File Offset: 0x002C3B28
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x06009BEE RID: 39918 RVA: 0x002C5938 File Offset: 0x002C3B38
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x06009BEF RID: 39919 RVA: 0x002C5948 File Offset: 0x002C3B48
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x06009BF0 RID: 39920 RVA: 0x002C5958 File Offset: 0x002C3B58
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x06009BF1 RID: 39921 RVA: 0x002C5968 File Offset: 0x002C3B68
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x06009BF2 RID: 39922 RVA: 0x002C5978 File Offset: 0x002C3B78
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x06009BF3 RID: 39923 RVA: 0x002C5988 File Offset: 0x002C3B88
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x06009BF4 RID: 39924 RVA: 0x002C5998 File Offset: 0x002C3B98
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x06009BF5 RID: 39925 RVA: 0x002C59A8 File Offset: 0x002C3BA8
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x06009BF6 RID: 39926 RVA: 0x002C59B8 File Offset: 0x002C3BB8
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x06009BF7 RID: 39927 RVA: 0x002C59C8 File Offset: 0x002C3BC8
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x06009BF8 RID: 39928 RVA: 0x002C59D8 File Offset: 0x002C3BD8
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x06009BF9 RID: 39929 RVA: 0x002C59E8 File Offset: 0x002C3BE8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x06009BFA RID: 39930 RVA: 0x002C59F8 File Offset: 0x002C3BF8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x06009BFB RID: 39931 RVA: 0x002C5A08 File Offset: 0x002C3C08
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x06009BFC RID: 39932 RVA: 0x002C5A18 File Offset: 0x002C3C18
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x06009BFD RID: 39933 RVA: 0x002C5A28 File Offset: 0x002C3C28
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x06009BFE RID: 39934 RVA: 0x002C5A38 File Offset: 0x002C3C38
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x06009BFF RID: 39935 RVA: 0x002C5A48 File Offset: 0x002C3C48
			public void __callDele_EventOnShowArena(ArenaUIType arg1, bool arg2, UIIntent arg3)
			{
				this.m_owner.__callDele_EventOnShowArena(arg1, arg2, arg3);
			}

			// Token: 0x06009C00 RID: 39936 RVA: 0x002C5A58 File Offset: 0x002C3C58
			public void __clearDele_EventOnShowArena(ArenaUIType arg1, bool arg2, UIIntent arg3)
			{
				this.m_owner.__clearDele_EventOnShowArena(arg1, arg2, arg3);
			}

			// Token: 0x17001FB4 RID: 8116
			// (get) Token: 0x06009C01 RID: 39937 RVA: 0x002C5A68 File Offset: 0x002C3C68
			// (set) Token: 0x06009C02 RID: 39938 RVA: 0x002C5A78 File Offset: 0x002C3C78
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

			// Token: 0x17001FB5 RID: 8117
			// (get) Token: 0x06009C03 RID: 39939 RVA: 0x002C5A88 File Offset: 0x002C3C88
			// (set) Token: 0x06009C04 RID: 39940 RVA: 0x002C5A98 File Offset: 0x002C3C98
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

			// Token: 0x17001FB6 RID: 8118
			// (get) Token: 0x06009C05 RID: 39941 RVA: 0x002C5AA8 File Offset: 0x002C3CA8
			// (set) Token: 0x06009C06 RID: 39942 RVA: 0x002C5AB8 File Offset: 0x002C3CB8
			public ArenaSelectUIController m_arenaSelectUIController
			{
				get
				{
					return this.m_owner.m_arenaSelectUIController;
				}
				set
				{
					this.m_owner.m_arenaSelectUIController = value;
				}
			}

			// Token: 0x17001FB7 RID: 8119
			// (get) Token: 0x06009C07 RID: 39943 RVA: 0x002C5AC8 File Offset: 0x002C3CC8
			// (set) Token: 0x06009C08 RID: 39944 RVA: 0x002C5AD8 File Offset: 0x002C3CD8
			public bool m_isBattleReport
			{
				get
				{
					return this.m_owner.m_isBattleReport;
				}
				set
				{
					this.m_owner.m_isBattleReport = value;
				}
			}

			// Token: 0x17001FB8 RID: 8120
			// (get) Token: 0x06009C09 RID: 39945 RVA: 0x002C5AE8 File Offset: 0x002C3CE8
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17001FB9 RID: 8121
			// (get) Token: 0x06009C0A RID: 39946 RVA: 0x002C5AF8 File Offset: 0x002C3CF8
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x06009C0B RID: 39947 RVA: 0x002C5B08 File Offset: 0x002C3D08
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x06009C0C RID: 39948 RVA: 0x002C5B18 File Offset: 0x002C3D18
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x06009C0D RID: 39949 RVA: 0x002C5B28 File Offset: 0x002C3D28
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x06009C0E RID: 39950 RVA: 0x002C5B38 File Offset: 0x002C3D38
			public void InitArenaSelectUIController()
			{
				this.m_owner.InitArenaSelectUIController();
			}

			// Token: 0x06009C0F RID: 39951 RVA: 0x002C5B48 File Offset: 0x002C3D48
			public void UninitArenaSelectUIController()
			{
				this.m_owner.UninitArenaSelectUIController();
			}

			// Token: 0x06009C10 RID: 39952 RVA: 0x002C5B58 File Offset: 0x002C3D58
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x06009C11 RID: 39953 RVA: 0x002C5B68 File Offset: 0x002C3D68
			public void ArenaSelectUIController_OnShowOfflineArena()
			{
				this.m_owner.ArenaSelectUIController_OnShowOfflineArena();
			}

			// Token: 0x06009C12 RID: 39954 RVA: 0x002C5B78 File Offset: 0x002C3D78
			public void ArenaSelectUIController_OnShowOnlineArena()
			{
				this.m_owner.ArenaSelectUIController_OnShowOnlineArena();
			}

			// Token: 0x06009C13 RID: 39955 RVA: 0x002C5B88 File Offset: 0x002C3D88
			public void ArenaSelectUIController_OnClose()
			{
				this.m_owner.ArenaSelectUIController_OnClose();
			}

			// Token: 0x040069FE RID: 27134
			private ArenaSelectUITask m_owner;
		}
	}
}
