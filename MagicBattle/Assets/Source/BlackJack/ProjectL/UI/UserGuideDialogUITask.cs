using System;
using System.Collections.Generic;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FFD RID: 4093
	[HotFix]
	public class UserGuideDialogUITask : UITask
	{
		// Token: 0x06014983 RID: 84355 RVA: 0x005392C8 File Offset: 0x005374C8
		public UserGuideDialogUITask(string name) : base(name)
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

		// Token: 0x06014984 RID: 84356 RVA: 0x005393BC File Offset: 0x005375BC
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

		// Token: 0x06014985 RID: 84357 RVA: 0x00539448 File Offset: 0x00537648
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

		// Token: 0x06014986 RID: 84358 RVA: 0x005394D4 File Offset: 0x005376D4
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
			this.m_userGuideDialogInfo = null;
			UIIntentCustom uiintentCustom = intent as UIIntentCustom;
			if (intent != null)
			{
				this.m_userGuideDialogInfo = uiintentCustom.GetClassParam<ConfigDataUserGuideDialogInfo>("UserGuideDialogInfo");
			}
		}

		// Token: 0x06014987 RID: 84359 RVA: 0x0053956C File Offset: 0x0053776C
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
			if (this.m_userGuideDialogInfo != null && this.m_userGuideDialogInfo.m_charImageInfo != null)
			{
				base.CollectAsset(this.m_userGuideDialogInfo.m_charImageInfo.Spine);
				base.CollectSpriteAsset(this.m_userGuideDialogInfo.m_charImageInfo.Image);
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x06014988 RID: 84360 RVA: 0x0053962C File Offset: 0x0053782C
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
			this.InitUserGuideDialogUIController();
		}

		// Token: 0x06014989 RID: 84361 RVA: 0x00539698 File Offset: 0x00537898
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
			this.UninitUserGuideDialogUIController();
		}

		// Token: 0x0601498A RID: 84362 RVA: 0x00539704 File Offset: 0x00537904
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

		// Token: 0x0601498B RID: 84363 RVA: 0x0053976C File Offset: 0x0053796C
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
				this.m_userGuideDialogUIController.DialogOpenTweenPlay();
			}
			if (this.m_userGuideDialogInfo != null)
			{
				this.m_userGuideDialogUIController.SetDialog(this.m_userGuideDialogInfo);
			}
		}

		// Token: 0x0601498C RID: 84364 RVA: 0x00539800 File Offset: 0x00537A00
		private void InitUserGuideDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitUserGuideDialogUIController_hotfix != null)
			{
				this.m_InitUserGuideDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideDialogUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_userGuideDialogUIController = (this.m_uiCtrlArray[0] as UserGuideDialogUIController);
				}
				if (!(this.m_userGuideDialogUIController != null))
				{
					Debug.LogError("UserGuideUIController is null");
					return;
				}
				this.m_userGuideDialogUIController.EventOnNext += this.UserGuideUIController_OnNext;
				this.m_userGuideDialogUIController.EventOnClose += this.UserGuideUIController_OnClose;
			}
		}

		// Token: 0x0601498D RID: 84365 RVA: 0x005398E4 File Offset: 0x00537AE4
		private void UninitUserGuideDialogUIController()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UninitUserGuideDialogUIController_hotfix != null)
			{
				this.m_UninitUserGuideDialogUIController_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideDialogUIController != null)
			{
				this.m_userGuideDialogUIController.EventOnNext -= this.UserGuideUIController_OnNext;
				this.m_userGuideDialogUIController.EventOnClose -= this.UserGuideUIController_OnClose;
				this.m_userGuideDialogUIController = null;
			}
		}

		// Token: 0x0601498E RID: 84366 RVA: 0x0053998C File Offset: 0x00537B8C
		private void UserGuideUIController_OnNext()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuideUIController_OnNext_hotfix != null)
			{
				this.m_UserGuideUIController_OnNext_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_userGuideDialogInfo != null && this.m_userGuideDialogInfo.m_nextDialogInfo != null)
			{
				this.m_userGuideDialogInfo = this.m_userGuideDialogInfo.m_nextDialogInfo;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else
			{
				this.m_userGuideDialogUIController.CloseDialog();
			}
		}

		// Token: 0x0601498F RID: 84367 RVA: 0x00539A34 File Offset: 0x00537C34
		private void UserGuideUIController_OnClose()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UserGuideUIController_OnClose_hotfix != null)
			{
				this.m_UserGuideUIController_OnClose_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Stop();
			if (this.EventOnClose != null)
			{
				this.EventOnClose();
			}
			if (this.EventOnUserGuideClose != null)
			{
				this.EventOnUserGuideClose();
			}
		}

		// Token: 0x14000488 RID: 1160
		// (add) Token: 0x06014990 RID: 84368 RVA: 0x00539AC8 File Offset: 0x00537CC8
		// (remove) Token: 0x06014991 RID: 84369 RVA: 0x00539B64 File Offset: 0x00537D64
		public event Action EventOnClose
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnCloseAction_hotfix != null)
				{
					this.m_add_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnCloseAction_hotfix != null)
				{
					this.m_remove_EventOnCloseAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.EventOnClose;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.EventOnClose, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000489 RID: 1161
		// (add) Token: 0x06014992 RID: 84370 RVA: 0x00539C00 File Offset: 0x00537E00
		// (remove) Token: 0x06014993 RID: 84371 RVA: 0x00539C9C File Offset: 0x00537E9C
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

		// Token: 0x17003CF5 RID: 15605
		// (get) Token: 0x06014994 RID: 84372 RVA: 0x00539D38 File Offset: 0x00537F38
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

		// Token: 0x17003CF6 RID: 15606
		// (get) Token: 0x06014995 RID: 84373 RVA: 0x00539DAC File Offset: 0x00537FAC
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

		// Token: 0x17003CF7 RID: 15607
		// (get) Token: 0x06014996 RID: 84374 RVA: 0x00539E20 File Offset: 0x00538020
		// (set) Token: 0x06014997 RID: 84375 RVA: 0x00539E40 File Offset: 0x00538040
		[DoNotToLua]
		public new UserGuideDialogUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UserGuideDialogUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014998 RID: 84376 RVA: 0x00539E4C File Offset: 0x0053804C
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x06014999 RID: 84377 RVA: 0x00539E58 File Offset: 0x00538058
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601499A RID: 84378 RVA: 0x00539E60 File Offset: 0x00538060
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0601499B RID: 84379 RVA: 0x00539E68 File Offset: 0x00538068
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0601499C RID: 84380 RVA: 0x00539E74 File Offset: 0x00538074
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0601499D RID: 84381 RVA: 0x00539E80 File Offset: 0x00538080
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0601499E RID: 84382 RVA: 0x00539E8C File Offset: 0x0053808C
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0601499F RID: 84383 RVA: 0x00539E94 File Offset: 0x00538094
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x060149A0 RID: 84384 RVA: 0x00539E9C File Offset: 0x0053809C
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x060149A1 RID: 84385 RVA: 0x00539EA4 File Offset: 0x005380A4
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x060149A2 RID: 84386 RVA: 0x00539EAC File Offset: 0x005380AC
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x060149A3 RID: 84387 RVA: 0x00539EB4 File Offset: 0x005380B4
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x060149A4 RID: 84388 RVA: 0x00539EBC File Offset: 0x005380BC
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x060149A5 RID: 84389 RVA: 0x00539EC4 File Offset: 0x005380C4
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x060149A6 RID: 84390 RVA: 0x00539ED0 File Offset: 0x005380D0
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x060149A7 RID: 84391 RVA: 0x00539EDC File Offset: 0x005380DC
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x060149A8 RID: 84392 RVA: 0x00539EE8 File Offset: 0x005380E8
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x060149A9 RID: 84393 RVA: 0x00539EF4 File Offset: 0x005380F4
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x060149AA RID: 84394 RVA: 0x00539EFC File Offset: 0x005380FC
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x060149AB RID: 84395 RVA: 0x00539F04 File Offset: 0x00538104
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x060149AC RID: 84396 RVA: 0x00539F0C File Offset: 0x0053810C
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x060149AD RID: 84397 RVA: 0x00539F14 File Offset: 0x00538114
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x060149AE RID: 84398 RVA: 0x00539F1C File Offset: 0x0053811C
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x060149AF RID: 84399 RVA: 0x00539F24 File Offset: 0x00538124
		private void __callDele_EventOnClose()
		{
			Action eventOnClose = this.EventOnClose;
			if (eventOnClose != null)
			{
				eventOnClose();
			}
		}

		// Token: 0x060149B0 RID: 84400 RVA: 0x00539F44 File Offset: 0x00538144
		private void __clearDele_EventOnClose()
		{
			this.EventOnClose = null;
		}

		// Token: 0x060149B1 RID: 84401 RVA: 0x00539F50 File Offset: 0x00538150
		private void __callDele_EventOnUserGuideClose()
		{
			Action eventOnUserGuideClose = this.EventOnUserGuideClose;
			if (eventOnUserGuideClose != null)
			{
				eventOnUserGuideClose();
			}
		}

		// Token: 0x060149B2 RID: 84402 RVA: 0x00539F70 File Offset: 0x00538170
		private void __clearDele_EventOnUserGuideClose()
		{
			this.EventOnUserGuideClose = null;
		}

		// Token: 0x060149B3 RID: 84403 RVA: 0x00539F7C File Offset: 0x0053817C
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
					this.m_InitUserGuideDialogUIController_hotfix = (luaObj.RawGet("InitUserGuideDialogUIController") as LuaFunction);
					this.m_UninitUserGuideDialogUIController_hotfix = (luaObj.RawGet("UninitUserGuideDialogUIController") as LuaFunction);
					this.m_UserGuideUIController_OnNext_hotfix = (luaObj.RawGet("UserGuideUIController_OnNext") as LuaFunction);
					this.m_UserGuideUIController_OnClose_hotfix = (luaObj.RawGet("UserGuideUIController_OnClose") as LuaFunction);
					this.m_add_EventOnCloseAction_hotfix = (luaObj.RawGet("add_EventOnClose") as LuaFunction);
					this.m_remove_EventOnCloseAction_hotfix = (luaObj.RawGet("remove_EventOnClose") as LuaFunction);
					this.m_add_EventOnUserGuideCloseAction_hotfix = (luaObj.RawGet("add_EventOnUserGuideClose") as LuaFunction);
					this.m_remove_EventOnUserGuideCloseAction_hotfix = (luaObj.RawGet("remove_EventOnUserGuideClose") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060149B4 RID: 84404 RVA: 0x0053A20C File Offset: 0x0053840C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserGuideDialogUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B4E6 RID: 46310
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "UserGuideDialogUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/UserGuide_ABS/Prefab/UserGuideDialogUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x0400B4E7 RID: 46311
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "UserGuideDialogUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.UserGuideDialogUIController"),
				m_ctrlName = "UserGuideDialogUIController"
			}
		};

		// Token: 0x0400B4E8 RID: 46312
		private UserGuideDialogUIController m_userGuideDialogUIController;

		// Token: 0x0400B4E9 RID: 46313
		private ConfigDataUserGuideDialogInfo m_userGuideDialogInfo;

		// Token: 0x0400B4EA RID: 46314
		[DoNotToLua]
		private UserGuideDialogUITask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B4EB RID: 46315
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B4EC RID: 46316
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B4ED RID: 46317
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x0400B4EE RID: 46318
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x0400B4EF RID: 46319
		private LuaFunction m_OnResumeUIIntent_hotfix;

		// Token: 0x0400B4F0 RID: 46320
		private LuaFunction m_InitDataFromUIIntentUIIntent_hotfix;

		// Token: 0x0400B4F1 RID: 46321
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x0400B4F2 RID: 46322
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x0400B4F3 RID: 46323
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x0400B4F4 RID: 46324
		private LuaFunction m_OnMemoryWarning_hotfix;

		// Token: 0x0400B4F5 RID: 46325
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x0400B4F6 RID: 46326
		private LuaFunction m_InitUserGuideDialogUIController_hotfix;

		// Token: 0x0400B4F7 RID: 46327
		private LuaFunction m_UninitUserGuideDialogUIController_hotfix;

		// Token: 0x0400B4F8 RID: 46328
		private LuaFunction m_UserGuideUIController_OnNext_hotfix;

		// Token: 0x0400B4F9 RID: 46329
		private LuaFunction m_UserGuideUIController_OnClose_hotfix;

		// Token: 0x0400B4FA RID: 46330
		private LuaFunction m_add_EventOnCloseAction_hotfix;

		// Token: 0x0400B4FB RID: 46331
		private LuaFunction m_remove_EventOnCloseAction_hotfix;

		// Token: 0x0400B4FC RID: 46332
		private LuaFunction m_add_EventOnUserGuideCloseAction_hotfix;

		// Token: 0x0400B4FD RID: 46333
		private LuaFunction m_remove_EventOnUserGuideCloseAction_hotfix;

		// Token: 0x0400B4FE RID: 46334
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x0400B4FF RID: 46335
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x02000FFE RID: 4094
		public new class LuaExportHelper
		{
			// Token: 0x060149B5 RID: 84405 RVA: 0x0053A274 File Offset: 0x00538474
			public LuaExportHelper(UserGuideDialogUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060149B6 RID: 84406 RVA: 0x0053A284 File Offset: 0x00538484
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x060149B7 RID: 84407 RVA: 0x0053A294 File Offset: 0x00538494
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x060149B8 RID: 84408 RVA: 0x0053A2A4 File Offset: 0x005384A4
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x060149B9 RID: 84409 RVA: 0x0053A2B4 File Offset: 0x005384B4
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x060149BA RID: 84410 RVA: 0x0053A2C4 File Offset: 0x005384C4
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x060149BB RID: 84411 RVA: 0x0053A2D4 File Offset: 0x005384D4
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x060149BC RID: 84412 RVA: 0x0053A2E4 File Offset: 0x005384E4
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x060149BD RID: 84413 RVA: 0x0053A2F4 File Offset: 0x005384F4
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x060149BE RID: 84414 RVA: 0x0053A304 File Offset: 0x00538504
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x060149BF RID: 84415 RVA: 0x0053A314 File Offset: 0x00538514
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x060149C0 RID: 84416 RVA: 0x0053A324 File Offset: 0x00538524
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x060149C1 RID: 84417 RVA: 0x0053A334 File Offset: 0x00538534
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x060149C2 RID: 84418 RVA: 0x0053A344 File Offset: 0x00538544
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x060149C3 RID: 84419 RVA: 0x0053A354 File Offset: 0x00538554
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x060149C4 RID: 84420 RVA: 0x0053A364 File Offset: 0x00538564
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x060149C5 RID: 84421 RVA: 0x0053A374 File Offset: 0x00538574
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x060149C6 RID: 84422 RVA: 0x0053A384 File Offset: 0x00538584
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x060149C7 RID: 84423 RVA: 0x0053A394 File Offset: 0x00538594
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x060149C8 RID: 84424 RVA: 0x0053A3A4 File Offset: 0x005385A4
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x060149C9 RID: 84425 RVA: 0x0053A3B4 File Offset: 0x005385B4
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x060149CA RID: 84426 RVA: 0x0053A3C4 File Offset: 0x005385C4
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x060149CB RID: 84427 RVA: 0x0053A3D4 File Offset: 0x005385D4
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x060149CC RID: 84428 RVA: 0x0053A3E4 File Offset: 0x005385E4
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x060149CD RID: 84429 RVA: 0x0053A3F4 File Offset: 0x005385F4
			public void __callDele_EventOnClose()
			{
				this.m_owner.__callDele_EventOnClose();
			}

			// Token: 0x060149CE RID: 84430 RVA: 0x0053A404 File Offset: 0x00538604
			public void __clearDele_EventOnClose()
			{
				this.m_owner.__clearDele_EventOnClose();
			}

			// Token: 0x060149CF RID: 84431 RVA: 0x0053A414 File Offset: 0x00538614
			public void __callDele_EventOnUserGuideClose()
			{
				this.m_owner.__callDele_EventOnUserGuideClose();
			}

			// Token: 0x060149D0 RID: 84432 RVA: 0x0053A424 File Offset: 0x00538624
			public void __clearDele_EventOnUserGuideClose()
			{
				this.m_owner.__clearDele_EventOnUserGuideClose();
			}

			// Token: 0x17003CF8 RID: 15608
			// (get) Token: 0x060149D1 RID: 84433 RVA: 0x0053A434 File Offset: 0x00538634
			// (set) Token: 0x060149D2 RID: 84434 RVA: 0x0053A444 File Offset: 0x00538644
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

			// Token: 0x17003CF9 RID: 15609
			// (get) Token: 0x060149D3 RID: 84435 RVA: 0x0053A454 File Offset: 0x00538654
			// (set) Token: 0x060149D4 RID: 84436 RVA: 0x0053A464 File Offset: 0x00538664
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

			// Token: 0x17003CFA RID: 15610
			// (get) Token: 0x060149D5 RID: 84437 RVA: 0x0053A474 File Offset: 0x00538674
			// (set) Token: 0x060149D6 RID: 84438 RVA: 0x0053A484 File Offset: 0x00538684
			public UserGuideDialogUIController m_userGuideDialogUIController
			{
				get
				{
					return this.m_owner.m_userGuideDialogUIController;
				}
				set
				{
					this.m_owner.m_userGuideDialogUIController = value;
				}
			}

			// Token: 0x17003CFB RID: 15611
			// (get) Token: 0x060149D7 RID: 84439 RVA: 0x0053A494 File Offset: 0x00538694
			// (set) Token: 0x060149D8 RID: 84440 RVA: 0x0053A4A4 File Offset: 0x005386A4
			public ConfigDataUserGuideDialogInfo m_userGuideDialogInfo
			{
				get
				{
					return this.m_owner.m_userGuideDialogInfo;
				}
				set
				{
					this.m_owner.m_userGuideDialogInfo = value;
				}
			}

			// Token: 0x17003CFC RID: 15612
			// (get) Token: 0x060149D9 RID: 84441 RVA: 0x0053A4B4 File Offset: 0x005386B4
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x17003CFD RID: 15613
			// (get) Token: 0x060149DA RID: 84442 RVA: 0x0053A4C4 File Offset: 0x005386C4
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x060149DB RID: 84443 RVA: 0x0053A4D4 File Offset: 0x005386D4
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x060149DC RID: 84444 RVA: 0x0053A4E4 File Offset: 0x005386E4
			public bool OnResume(UIIntent intent)
			{
				return this.m_owner.OnResume(intent);
			}

			// Token: 0x060149DD RID: 84445 RVA: 0x0053A4F4 File Offset: 0x005386F4
			public void InitDataFromUIIntent(UIIntent intent)
			{
				this.m_owner.InitDataFromUIIntent(intent);
			}

			// Token: 0x060149DE RID: 84446 RVA: 0x0053A504 File Offset: 0x00538704
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x060149DF RID: 84447 RVA: 0x0053A514 File Offset: 0x00538714
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x060149E0 RID: 84448 RVA: 0x0053A524 File Offset: 0x00538724
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x060149E1 RID: 84449 RVA: 0x0053A534 File Offset: 0x00538734
			public void OnMemoryWarning()
			{
				this.m_owner.OnMemoryWarning();
			}

			// Token: 0x060149E2 RID: 84450 RVA: 0x0053A544 File Offset: 0x00538744
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x060149E3 RID: 84451 RVA: 0x0053A554 File Offset: 0x00538754
			public void InitUserGuideDialogUIController()
			{
				this.m_owner.InitUserGuideDialogUIController();
			}

			// Token: 0x060149E4 RID: 84452 RVA: 0x0053A564 File Offset: 0x00538764
			public void UninitUserGuideDialogUIController()
			{
				this.m_owner.UninitUserGuideDialogUIController();
			}

			// Token: 0x060149E5 RID: 84453 RVA: 0x0053A574 File Offset: 0x00538774
			public void UserGuideUIController_OnNext()
			{
				this.m_owner.UserGuideUIController_OnNext();
			}

			// Token: 0x060149E6 RID: 84454 RVA: 0x0053A584 File Offset: 0x00538784
			public void UserGuideUIController_OnClose()
			{
				this.m_owner.UserGuideUIController_OnClose();
			}

			// Token: 0x0400B500 RID: 46336
			private UserGuideDialogUITask m_owner;
		}
	}
}
