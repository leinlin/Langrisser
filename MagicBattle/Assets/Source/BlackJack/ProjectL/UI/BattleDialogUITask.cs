using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectLBasic;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000A74 RID: 2676
	[HotFix]
	public class BattleDialogUITask : UITask
	{
		// Token: 0x0600A80E RID: 43022 RVA: 0x002EFBEC File Offset: 0x002EDDEC
		public BattleDialogUITask(string name) : base(name)
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

		// Token: 0x0600A80F RID: 43023 RVA: 0x002EFCE0 File Offset: 0x002EDEE0
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

		// Token: 0x0600A810 RID: 43024 RVA: 0x002EFD6C File Offset: 0x002EDF6C
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

		// Token: 0x0600A811 RID: 43025 RVA: 0x002EFDF8 File Offset: 0x002EDFF8
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
			this.m_battleDialogInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (uiintentCustom != null)
			{
				this.m_battleDialogInfo = uiintentCustom.GetClassParam<ConfigDataBattleDialogInfo>("BattleDialogInfo");
			}
		}

		// Token: 0x0600A812 RID: 43026 RVA: 0x002EFE90 File Offset: 0x002EE090
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
			if (this.m_battleDialogInfo != null && this.m_battleDialogInfo.m_charImageInfo != null)
			{
				base.CollectAsset(this.m_battleDialogInfo.m_charImageInfo.Spine);
				base.CollectSpriteAsset(this.m_battleDialogInfo.m_charImageInfo.Image);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A813 RID: 43027 RVA: 0x002EFF50 File Offset: 0x002EE150
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
			this.InitBattleDialogUIController();
		}

		// Token: 0x0600A814 RID: 43028 RVA: 0x002EFFBC File Offset: 0x002EE1BC
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
			this.UninitBattleDialogUIController();
		}

		// Token: 0x0600A815 RID: 43029 RVA: 0x002F0028 File Offset: 0x002EE228
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

		// Token: 0x0600A816 RID: 43030 RVA: 0x002F0090 File Offset: 0x002EE290
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
			if (this.m_battleDialogInfo != null)
			{
				this.m_battleDialogUIController.SetDialog(this.m_battleDialogInfo);
			}
		}

		// Token: 0x0600A817 RID: 43031 RVA: 0x002F010C File Offset: 0x002EE30C
		private void InitBattleDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleDialogUIController_hotfix != null)
			{
				this.m_InitBattleDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDialogUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_battleDialogUIController = (this.m_uiCtrlArray[0] as BattleDialogUIController);
				}
				if (!(this.m_battleDialogUIController != null))
				{
					Debug.LogError("BattleDialogUIController is null");
					return;
				}
				this.m_battleDialogUIController.EventOnSkip += this.BattleDialogUIController_OnSkip;
				this.m_battleDialogUIController.EventOnNext += this.BattleDialogUIController_OnNext;
				this.m_battleDialogUIController.EventOnClose += this.BattleDialogUIController_OnClose;
			}
		}

		// Token: 0x0600A818 RID: 43032 RVA: 0x002F0204 File Offset: 0x002EE404
		private void UninitBattleDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitBattleDialogUIController_hotfix != null)
			{
				this.m_UninitBattleDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDialogUIController != null)
			{
				this.m_battleDialogUIController.EventOnSkip -= this.BattleDialogUIController_OnSkip;
				this.m_battleDialogUIController.EventOnNext -= this.BattleDialogUIController_OnNext;
				this.m_battleDialogUIController.EventOnClose -= this.BattleDialogUIController_OnClose;
				this.m_battleDialogUIController = null;
			}
		}

		// Token: 0x0600A819 RID: 43033 RVA: 0x002F02C4 File Offset: 0x002EE4C4
		private void BattleDialogUIController_OnSkip()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUIController_OnSkip_hotfix != null)
			{
				this.m_BattleDialogUIController_OnSkip_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUIController.Instance.ShowDialogBox(StringTableId.StringTableId_Dialog_SkipDialog, new Action<DialogBoxResult>(this.SkipDialogDialogBoxCallback), (StringTableId)0, (StringTableId)0);
		}

		// Token: 0x0600A81A RID: 43034 RVA: 0x002F0344 File Offset: 0x002EE544
		private void SkipDialogDialogBoxCallback(DialogBoxResult r)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix != null)
			{
				this.m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix.call(new object[]
				{
					this,
					r
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (r == DialogBoxResult.Ok)
			{
				this.m_isSkipClose = true;
				this.m_battleDialogUIController.CloseDialog();
			}
		}

		// Token: 0x0600A81B RID: 43035 RVA: 0x002F03D0 File Offset: 0x002EE5D0
		private void BattleDialogUIController_OnNext()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUIController_OnNext_hotfix != null)
			{
				this.m_BattleDialogUIController_OnNext_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_battleDialogInfo != null && this.m_battleDialogInfo.m_nextDialogInfo != null)
			{
				this.m_battleDialogInfo = this.m_battleDialogInfo.m_nextDialogInfo;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else
			{
				this.m_isSkipClose = false;
				this.m_battleDialogUIController.CloseDialog();
			}
		}

		// Token: 0x0600A81C RID: 43036 RVA: 0x002F0480 File Offset: 0x002EE680
		private void BattleDialogUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleDialogUIController_OnClose_hotfix != null)
			{
				this.m_BattleDialogUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Stop();
			base.ReturnPrevUITask();
			if (this.EventOnClose != null)
			{
				this.EventOnClose(this.m_isSkipClose);
			}
			if (this.EventOnUserGuideClose != null)
			{
				this.EventOnUserGuideClose();
			}
		}

		// Token: 0x140001F2 RID: 498
		// (add) Token: 0x0600A81D RID: 43037 RVA: 0x002F0520 File Offset: 0x002EE720
		// (remove) Token: 0x0600A81E RID: 43038 RVA: 0x002F05BC File Offset: 0x002EE7BC
		public event Action<bool> EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction`1_hotfix != null)
				{
					this.m_add_EventOnCloseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnClose;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnClose, (Action<bool>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction`1_hotfix != null)
				{
					this.m_remove_EventOnCloseAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<bool> action = this.EventOnClose;
				Action<bool> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<bool>>(ref this.EventOnClose, (Action<bool>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x140001F3 RID: 499
		// (add) Token: 0x0600A81F RID: 43039 RVA: 0x002F0658 File Offset: 0x002EE858
		// (remove) Token: 0x0600A820 RID: 43040 RVA: 0x002F06F4 File Offset: 0x002EE8F4
		public event Action EventOnUserGuideClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnUserGuideCloseAction_hotfix != null)
				{
					this.m_add_EventOnUserGuideCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUserGuideClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUserGuideClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnUserGuideCloseAction_hotfix != null)
				{
					this.m_remove_EventOnUserGuideCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnUserGuideClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnUserGuideClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700221A RID: 8730
		// (get) Token: 0x0600A821 RID: 43041 RVA: 0x002F0790 File Offset: 0x002EE990
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

		// Token: 0x1700221B RID: 8731
		// (get) Token: 0x0600A822 RID: 43042 RVA: 0x002F0804 File Offset: 0x002EEA04
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

		// Token: 0x1700221C RID: 8732
		// (get) Token: 0x0600A823 RID: 43043 RVA: 0x002F0878 File Offset: 0x002EEA78
		// (set) Token: 0x0600A824 RID: 43044 RVA: 0x002F0898 File Offset: 0x002EEA98
		[DoNotToLua]
		public new BattleDialogUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleDialogUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600A825 RID: 43045 RVA: 0x002F08A4 File Offset: 0x002EEAA4
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600A826 RID: 43046 RVA: 0x002F08B0 File Offset: 0x002EEAB0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600A827 RID: 43047 RVA: 0x002F08B8 File Offset: 0x002EEAB8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600A828 RID: 43048 RVA: 0x002F08C0 File Offset: 0x002EEAC0
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600A829 RID: 43049 RVA: 0x002F08CC File Offset: 0x002EEACC
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600A82A RID: 43050 RVA: 0x002F08D8 File Offset: 0x002EEAD8
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600A82B RID: 43051 RVA: 0x002F08E4 File Offset: 0x002EEAE4
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600A82C RID: 43052 RVA: 0x002F08EC File Offset: 0x002EEAEC
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600A82D RID: 43053 RVA: 0x002F08F4 File Offset: 0x002EEAF4
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600A82E RID: 43054 RVA: 0x002F08FC File Offset: 0x002EEAFC
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600A82F RID: 43055 RVA: 0x002F0904 File Offset: 0x002EEB04
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600A830 RID: 43056 RVA: 0x002F090C File Offset: 0x002EEB0C
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600A831 RID: 43057 RVA: 0x002F0914 File Offset: 0x002EEB14
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600A832 RID: 43058 RVA: 0x002F091C File Offset: 0x002EEB1C
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600A833 RID: 43059 RVA: 0x002F0928 File Offset: 0x002EEB28
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600A834 RID: 43060 RVA: 0x002F0934 File Offset: 0x002EEB34
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600A835 RID: 43061 RVA: 0x002F0940 File Offset: 0x002EEB40
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600A836 RID: 43062 RVA: 0x002F094C File Offset: 0x002EEB4C
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600A837 RID: 43063 RVA: 0x002F0954 File Offset: 0x002EEB54
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600A838 RID: 43064 RVA: 0x002F095C File Offset: 0x002EEB5C
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600A839 RID: 43065 RVA: 0x002F0964 File Offset: 0x002EEB64
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600A83A RID: 43066 RVA: 0x002F096C File Offset: 0x002EEB6C
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600A83B RID: 43067 RVA: 0x002F0974 File Offset: 0x002EEB74
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600A83C RID: 43068 RVA: 0x002F097C File Offset: 0x002EEB7C
		private void __callDele_EventOnClose(bool obj)
		{
			Action<bool> eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose(obj);
			}
		}

		// Token: 0x0600A83D RID: 43069 RVA: 0x002F09A0 File Offset: 0x002EEBA0
		private void __clearDele_EventOnClose(bool obj)
		{
			this.EventOnClose = null;
		}

		// Token: 0x0600A83E RID: 43070 RVA: 0x002F09AC File Offset: 0x002EEBAC
		private void __callDele_EventOnUserGuideClose()
		{
			Action eventOnUserGuideClose = this.EventOnUserGuideClose;
			if (eventOnUserGuideClose != null)
			{
				eventOnUserGuideClose();
			}
		}

		// Token: 0x0600A83F RID: 43071 RVA: 0x002F09CC File Offset: 0x002EEBCC
		private void __clearDele_EventOnUserGuideClose()
		{
			this.EventOnUserGuideClose = null;
		}

		// Token: 0x0600A840 RID: 43072 RVA: 0x002F09D8 File Offset: 0x002EEBD8
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
					this.m_OnMemoryWarning_hotfix = (luaObj.RawGet("OnMemoryWarning") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_InitBattleDialogUIController_hotfix = (luaObj.RawGet("InitBattleDialogUIController") as LuaFunction);
					this.m_UninitBattleDialogUIController_hotfix = (luaObj.RawGet("UninitBattleDialogUIController") as LuaFunction);
					this.m_BattleDialogUIController_OnSkip_hotfix = (luaObj.RawGet("BattleDialogUIController_OnSkip") as LuaFunction);
					this.m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix = (luaObj.RawGet("SkipDialogDialogBoxCallback") as LuaFunction);
					this.m_BattleDialogUIController_OnNext_hotfix = (luaObj.RawGet("BattleDialogUIController_OnNext") as LuaFunction);
					this.m_BattleDialogUIController_OnClose_hotfix = (luaObj.RawGet("BattleDialogUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction`1_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction`1_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnUserGuideCloseAction_hotfix = (luaObj.RawGet("add_EventOnUserGuideClose") as LuaFunction);
					this.m_remove_EventOnUserGuideCloseAction_hotfix = (luaObj.RawGet("remove_EventOnUserGuideClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600A841 RID: 43073 RVA: 0x002F0C98 File Offset: 0x002EEE98
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleDialogUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04006F1E RID: 28446
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "BattleDialogUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Battle_ABS/Prefab/BattleDialogUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x04006F1F RID: 28447
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "BattleDialogUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.BattleDialogUIController"),
				m_ctrlName = "BattleDialogUIController"
			}
		};

		// Token: 0x04006F20 RID: 28448
		private BattleDialogUIController m_battleDialogUIController;

		// Token: 0x04006F21 RID: 28449
		private ConfigDataBattleDialogInfo m_battleDialogInfo;

		// Token: 0x04006F22 RID: 28450
		private bool m_isSkipClose;

		// Token: 0x04006F23 RID: 28451
		[DoNotToLua]
		private BattleDialogUITask.LuaExportHelper luaExportHelper;

		// Token: 0x04006F24 RID: 28452
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04006F25 RID: 28453
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04006F26 RID: 28454
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04006F27 RID: 28455
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x04006F28 RID: 28456
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x04006F29 RID: 28457
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x04006F2A RID: 28458
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x04006F2B RID: 28459
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x04006F2C RID: 28460
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x04006F2D RID: 28461
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x04006F2E RID: 28462
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x04006F2F RID: 28463
		private LuaFunction m_InitBattleDialogUIController_hotfix;

		// Token: 0x04006F30 RID: 28464
		private LuaFunction m_UninitBattleDialogUIController_hotfix;

		// Token: 0x04006F31 RID: 28465
		private LuaFunction m_BattleDialogUIController_OnSkip_hotfix;

		// Token: 0x04006F32 RID: 28466
		private LuaFunction m_SkipDialogDialogBoxCallbackDialogBoxResult_hotfix;

		// Token: 0x04006F33 RID: 28467
		private LuaFunction m_BattleDialogUIController_OnNext_hotfix;

		// Token: 0x04006F34 RID: 28468
		private LuaFunction m_BattleDialogUIController_OnClose_hotfix;

		// Token: 0x04006F35 RID: 28469
		private LuaFunction m_add_EventOnCloseAction;

		// Token: 0x04006F36 RID: 28470
		private LuaFunction m_remove_EventOnCloseAction;

		// Token: 0x04006F37 RID: 28471
		private LuaFunction m_add_EventOnUserGuideCloseAction_hotfix;

		// Token: 0x04006F38 RID: 28472
		private LuaFunction m_remove_EventOnUserGuideCloseAction_hotfix;

		// Token: 0x04006F39 RID: 28473
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x04006F3A RID: 28474
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000A75 RID: 2677
		public new class LuaExportHelper
		{
			// Token: 0x0600A842 RID: 43074 RVA: 0x002F0D00 File Offset: 0x002EEF00
			public LuaExportHelper(BattleDialogUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600A843 RID: 43075 RVA: 0x002F0D10 File Offset: 0x002EEF10
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600A844 RID: 43076 RVA: 0x002F0D20 File Offset: 0x002EEF20
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600A845 RID: 43077 RVA: 0x002F0D30 File Offset: 0x002EEF30
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600A846 RID: 43078 RVA: 0x002F0D40 File Offset: 0x002EEF40
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600A847 RID: 43079 RVA: 0x002F0D50 File Offset: 0x002EEF50
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600A848 RID: 43080 RVA: 0x002F0D60 File Offset: 0x002EEF60
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600A849 RID: 43081 RVA: 0x002F0D70 File Offset: 0x002EEF70
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A84A RID: 43082 RVA: 0x002F0D80 File Offset: 0x002EEF80
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600A84B RID: 43083 RVA: 0x002F0D90 File Offset: 0x002EEF90
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600A84C RID: 43084 RVA: 0x002F0DA0 File Offset: 0x002EEFA0
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600A84D RID: 43085 RVA: 0x002F0DB0 File Offset: 0x002EEFB0
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600A84E RID: 43086 RVA: 0x002F0DC0 File Offset: 0x002EEFC0
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600A84F RID: 43087 RVA: 0x002F0DD0 File Offset: 0x002EEFD0
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600A850 RID: 43088 RVA: 0x002F0DE0 File Offset: 0x002EEFE0
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600A851 RID: 43089 RVA: 0x002F0DF0 File Offset: 0x002EEFF0
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600A852 RID: 43090 RVA: 0x002F0E00 File Offset: 0x002EF000
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600A853 RID: 43091 RVA: 0x002F0E10 File Offset: 0x002EF010
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600A854 RID: 43092 RVA: 0x002F0E20 File Offset: 0x002EF020
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600A855 RID: 43093 RVA: 0x002F0E30 File Offset: 0x002EF030
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600A856 RID: 43094 RVA: 0x002F0E40 File Offset: 0x002EF040
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600A857 RID: 43095 RVA: 0x002F0E50 File Offset: 0x002EF050
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600A858 RID: 43096 RVA: 0x002F0E60 File Offset: 0x002EF060
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600A859 RID: 43097 RVA: 0x002F0E70 File Offset: 0x002EF070
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x0600A85A RID: 43098 RVA: 0x002F0E80 File Offset: 0x002EF080
			public void __callDele_EventOnClose(bool obj)
			{
				this.m_owner.__callDele_EventOnClose(obj);
			}

			// Token: 0x0600A85B RID: 43099 RVA: 0x002F0E90 File Offset: 0x002EF090
			public void __clearDele_EventOnClose(bool obj)
			{
				this.m_owner.__clearDele_EventOnClose(obj);
			}

			// Token: 0x0600A85C RID: 43100 RVA: 0x002F0EA0 File Offset: 0x002EF0A0
			public void __callDele_EventOnUserGuideClose()
			{
				this.m_owner.__callDele_EventOnUserGuideClose();
			}

			// Token: 0x0600A85D RID: 43101 RVA: 0x002F0EB0 File Offset: 0x002EF0B0
			public void __clearDele_EventOnUserGuideClose()
			{
				this.m_owner.__clearDele_EventOnUserGuideClose();
			}

			// Token: 0x1700221D RID: 8733
			// (get) Token: 0x0600A85E RID: 43102 RVA: 0x002F0EC0 File Offset: 0x002EF0C0
			// (set) Token: 0x0600A85F RID: 43103 RVA: 0x002F0ED0 File Offset: 0x002EF0D0
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

			// Token: 0x1700221E RID: 8734
			// (get) Token: 0x0600A860 RID: 43104 RVA: 0x002F0EE0 File Offset: 0x002EF0E0
			// (set) Token: 0x0600A861 RID: 43105 RVA: 0x002F0EF0 File Offset: 0x002EF0F0
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

			// Token: 0x1700221F RID: 8735
			// (get) Token: 0x0600A862 RID: 43106 RVA: 0x002F0F00 File Offset: 0x002EF100
			// (set) Token: 0x0600A863 RID: 43107 RVA: 0x002F0F10 File Offset: 0x002EF110
			public BattleDialogUIController m_battleDialogUIController
			{
				get
				{
					return this.m_owner.m_battleDialogUIController;
				}
				set
				{
					this.m_owner.m_battleDialogUIController = value;
				}
			}

			// Token: 0x17002220 RID: 8736
			// (get) Token: 0x0600A864 RID: 43108 RVA: 0x002F0F20 File Offset: 0x002EF120
			// (set) Token: 0x0600A865 RID: 43109 RVA: 0x002F0F30 File Offset: 0x002EF130
			public ConfigDataBattleDialogInfo m_battleDialogInfo
			{
				get
				{
					return this.m_owner.m_battleDialogInfo;
				}
				set
				{
					this.m_owner.m_battleDialogInfo = value;
				}
			}

			// Token: 0x17002221 RID: 8737
			// (get) Token: 0x0600A866 RID: 43110 RVA: 0x002F0F40 File Offset: 0x002EF140
			// (set) Token: 0x0600A867 RID: 43111 RVA: 0x002F0F50 File Offset: 0x002EF150
			public bool m_isSkipClose
			{
				get
				{
					return this.m_owner.m_isSkipClose;
				}
				set
				{
					this.m_owner.m_isSkipClose = value;
				}
			}

			// Token: 0x17002222 RID: 8738
			// (get) Token: 0x0600A868 RID: 43112 RVA: 0x002F0F60 File Offset: 0x002EF160
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17002223 RID: 8739
			// (get) Token: 0x0600A869 RID: 43113 RVA: 0x002F0F70 File Offset: 0x002EF170
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600A86A RID: 43114 RVA: 0x002F0F80 File Offset: 0x002EF180
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600A86B RID: 43115 RVA: 0x002F0F90 File Offset: 0x002EF190
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x0600A86C RID: 43116 RVA: 0x002F0FA0 File Offset: 0x002EF1A0
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x0600A86D RID: 43117 RVA: 0x002F0FB0 File Offset: 0x002EF1B0
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600A86E RID: 43118 RVA: 0x002F0FC0 File Offset: 0x002EF1C0
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600A86F RID: 43119 RVA: 0x002F0FD0 File Offset: 0x002EF1D0
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600A870 RID: 43120 RVA: 0x002F0FE0 File Offset: 0x002EF1E0
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x0600A871 RID: 43121 RVA: 0x002F0FF0 File Offset: 0x002EF1F0
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600A872 RID: 43122 RVA: 0x002F1000 File Offset: 0x002EF200
			public void InitBattleDialogUIController()
			{
				this.m_owner.InitBattleDialogUIController();
			}

			// Token: 0x0600A873 RID: 43123 RVA: 0x002F1010 File Offset: 0x002EF210
			public void UninitBattleDialogUIController()
			{
				this.m_owner.UninitBattleDialogUIController();
			}

			// Token: 0x0600A874 RID: 43124 RVA: 0x002F1020 File Offset: 0x002EF220
			public void BattleDialogUIController_OnSkip()
			{
				this.m_owner.BattleDialogUIController_OnSkip();
			}

			// Token: 0x0600A875 RID: 43125 RVA: 0x002F1030 File Offset: 0x002EF230
			public void SkipDialogDialogBoxCallback(DialogBoxResult r)
			{
				this.m_owner.SkipDialogDialogBoxCallback(r);
			}

			// Token: 0x0600A876 RID: 43126 RVA: 0x002F1040 File Offset: 0x002EF240
			public void BattleDialogUIController_OnNext()
			{
				this.m_owner.BattleDialogUIController_OnNext();
			}

			// Token: 0x0600A877 RID: 43127 RVA: 0x002F1050 File Offset: 0x002EF250
			public void BattleDialogUIController_OnClose()
			{
				this.m_owner.BattleDialogUIController_OnClose();
			}

			// Token: 0x04006F3B RID: 28475
			private BattleDialogUITask m_owner;
		}
	}
}
