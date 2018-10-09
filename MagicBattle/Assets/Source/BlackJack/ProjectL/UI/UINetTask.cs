using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000FD7 RID: 4055
	[HotFix]
	public class UINetTask : NetWorkTransactionTask
	{
		// Token: 0x0601447E RID: 83070 RVA: 0x00528184 File Offset: 0x00526384
		public UINetTask(float timeout = 10f, UITaskBase blockedUITask = null, bool autoRetry = true) : base(timeout, blockedUITask, autoRetry)
		{
			this.Result = -99;
			this.IsReloginSuccess = false;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorSingleUITaskBaseBoolean_hotfix != null)
			{
				this.m_ctorSingleUITaskBaseBoolean_hotfix.call(new object[]
				{
					this,
					timeout,
					blockedUITask,
					autoRetry
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0601447F RID: 83071 RVA: 0x00528234 File Offset: 0x00526434
		protected override bool OnStart(object param)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartObject_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartObject_hotfix.call(new object[]
				{
					this,
					param
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.IsLocalGame())
			{
				return false;
			}
			if (this.m_isDisableInput && CommonUIController.Instance != null)
			{
				CommonUIController.Instance.FrameworkNetTaskEnableInput(false);
			}
			return base.OnStart(param);
		}

		// Token: 0x06014480 RID: 83072 RVA: 0x005282FC File Offset: 0x005264FC
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isDisableInput && CommonUIController.Instance != null)
			{
				CommonUIController.Instance.FrameworkNetTaskEnableInput(true);
			}
			if (this.Result != 0)
			{
				Debug.LogError(string.Format("{0}.OnStop, result:{1}", base.GetType().Name, this.Result));
			}
			base.OnStop();
		}

		// Token: 0x06014481 RID: 83073 RVA: 0x005283B8 File Offset: 0x005265B8
		protected override void OnTimeOut()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTimeOut_hotfix != null)
			{
				this.m_OnTimeOut_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log(string.Format("{0}.OnTimeOut", base.GetType().Name));
			base.OnTimeOut();
		}

		// Token: 0x06014482 RID: 83074 RVA: 0x00528438 File Offset: 0x00526638
		protected override void OnReLoginSuccess()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnReLoginSuccess_hotfix != null)
			{
				this.m_OnReLoginSuccess_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Debug.Log(string.Format("{0}.OnReLoginSuccess", base.GetType().Name));
			this.IsReloginSuccess = true;
			base.OnReLoginSuccess();
		}

		// Token: 0x17003C56 RID: 15446
		// (get) Token: 0x06014484 RID: 83076 RVA: 0x00528538 File Offset: 0x00526738
		// (set) Token: 0x06014483 RID: 83075 RVA: 0x005284C0 File Offset: 0x005266C0
		public int Result
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Result_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Result_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Result>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_ResultInt32_hotfix != null)
				{
					this.m_set_ResultInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Result>k__BackingField = value;
			}
		}

		// Token: 0x17003C57 RID: 15447
		// (get) Token: 0x06014486 RID: 83078 RVA: 0x00528624 File Offset: 0x00526824
		// (set) Token: 0x06014485 RID: 83077 RVA: 0x005285AC File Offset: 0x005267AC
		public bool IsReloginSuccess
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsReloginSuccess_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsReloginSuccess_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsReloginSuccess>k__BackingField;
			}
			[CompilerGenerated]
			protected set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsReloginSuccessBoolean_hotfix != null)
				{
					this.m_set_IsReloginSuccessBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsReloginSuccess>k__BackingField = value;
			}
		}

		// Token: 0x17003C58 RID: 15448
		// (get) Token: 0x06014487 RID: 83079 RVA: 0x00528698 File Offset: 0x00526898
		// (set) Token: 0x06014488 RID: 83080 RVA: 0x005286B8 File Offset: 0x005268B8
		[DoNotToLua]
		public new UINetTask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UINetTask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06014489 RID: 83081 RVA: 0x005286C4 File Offset: 0x005268C4
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x0601448A RID: 83082 RVA: 0x005286D0 File Offset: 0x005268D0
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0601448B RID: 83083 RVA: 0x005286D8 File Offset: 0x005268D8
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0601448C RID: 83084 RVA: 0x005286E0 File Offset: 0x005268E0
		private bool __callBase_OnResume(object param)
		{
			return base.OnResume(param);
		}

		// Token: 0x0601448D RID: 83085 RVA: 0x005286EC File Offset: 0x005268EC
		private bool __callBase_StartNetWorking()
		{
			return base.StartNetWorking();
		}

		// Token: 0x0601448E RID: 83086 RVA: 0x005286F4 File Offset: 0x005268F4
		private void __callBase_OnTransactionComplete()
		{
			base.OnTransactionComplete();
		}

		// Token: 0x0601448F RID: 83087 RVA: 0x005286FC File Offset: 0x005268FC
		private void __callBase_RegisterNetworkEvent()
		{
			base.RegisterNetworkEvent();
		}

		// Token: 0x06014490 RID: 83088 RVA: 0x00528704 File Offset: 0x00526904
		private void __callBase_UnregisterNetworkEvent()
		{
			base.UnregisterNetworkEvent();
		}

		// Token: 0x06014491 RID: 83089 RVA: 0x0052870C File Offset: 0x0052690C
		private void __callBase_OnTick()
		{
			base.OnTick();
		}

		// Token: 0x06014492 RID: 83090 RVA: 0x00528714 File Offset: 0x00526914
		private void __callBase_OnTimeOut()
		{
			base.OnTimeOut();
		}

		// Token: 0x06014493 RID: 83091 RVA: 0x0052871C File Offset: 0x0052691C
		private void __callBase_OnGameServerDataUnsyncNotify()
		{
			base.OnGameServerDataUnsyncNotify();
		}

		// Token: 0x06014494 RID: 83092 RVA: 0x00528724 File Offset: 0x00526924
		private void __callBase_OnGameServerNetworkError()
		{
			base.OnGameServerNetworkError();
		}

		// Token: 0x06014495 RID: 83093 RVA: 0x0052872C File Offset: 0x0052692C
		private void __callBase_OnGameServerDisconnected()
		{
			base.OnGameServerDisconnected();
		}

		// Token: 0x06014496 RID: 83094 RVA: 0x00528734 File Offset: 0x00526934
		private void __callBase_OnNetworkError()
		{
			base.OnNetworkError();
		}

		// Token: 0x06014497 RID: 83095 RVA: 0x0052873C File Offset: 0x0052693C
		private void __callBase_OnReLoginSuccess()
		{
			base.OnReLoginSuccess();
		}

		// Token: 0x06014498 RID: 83096 RVA: 0x00528744 File Offset: 0x00526944
		private void __callBase_OnUIManagerReturnToLoginUI(bool obj)
		{
			base.OnUIManagerReturnToLoginUI(obj);
		}

		// Token: 0x06014499 RID: 83097 RVA: 0x00528750 File Offset: 0x00526950
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
					this.m_ctorSingleUITaskBaseBoolean_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnStartObject_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnTimeOut_hotfix = (luaObj.RawGet("OnTimeOut") as LuaFunction);
					this.m_OnReLoginSuccess_hotfix = (luaObj.RawGet("OnReLoginSuccess") as LuaFunction);
					this.m_set_ResultInt32_hotfix = (luaObj.RawGet("set_Result") as LuaFunction);
					this.m_get_Result_hotfix = (luaObj.RawGet("get_Result") as LuaFunction);
					this.m_set_IsReloginSuccessBoolean_hotfix = (luaObj.RawGet("set_IsReloginSuccess") as LuaFunction);
					this.m_get_IsReloginSuccess_hotfix = (luaObj.RawGet("get_IsReloginSuccess") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0601449A RID: 83098 RVA: 0x005288E4 File Offset: 0x00526AE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UINetTask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400B343 RID: 45891
		protected bool m_isDisableInput = true;

		// Token: 0x0400B344 RID: 45892
		[DoNotToLua]
		private UINetTask.LuaExportHelper luaExportHelper;

		// Token: 0x0400B345 RID: 45893
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400B346 RID: 45894
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400B347 RID: 45895
		private LuaFunction m_ctorSingleUITaskBaseBoolean_hotfix;

		// Token: 0x0400B348 RID: 45896
		private LuaFunction m_OnStartObject_hotfix;

		// Token: 0x0400B349 RID: 45897
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x0400B34A RID: 45898
		private LuaFunction m_OnTimeOut_hotfix;

		// Token: 0x0400B34B RID: 45899
		private LuaFunction m_OnReLoginSuccess_hotfix;

		// Token: 0x0400B34C RID: 45900
		private LuaFunction m_set_ResultInt32_hotfix;

		// Token: 0x0400B34D RID: 45901
		private LuaFunction m_get_Result_hotfix;

		// Token: 0x0400B34E RID: 45902
		private LuaFunction m_set_IsReloginSuccessBoolean_hotfix;

		// Token: 0x0400B34F RID: 45903
		private LuaFunction m_get_IsReloginSuccess_hotfix;

		// Token: 0x02000FD8 RID: 4056
		public new class LuaExportHelper
		{
			// Token: 0x0601449B RID: 83099 RVA: 0x0052894C File Offset: 0x00526B4C
			public LuaExportHelper(UINetTask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0601449C RID: 83100 RVA: 0x0052895C File Offset: 0x00526B5C
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x0601449D RID: 83101 RVA: 0x0052896C File Offset: 0x00526B6C
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0601449E RID: 83102 RVA: 0x0052897C File Offset: 0x00526B7C
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0601449F RID: 83103 RVA: 0x0052898C File Offset: 0x00526B8C
			public bool __callBase_OnResume(object param)
			{
				return this.m_owner.__callBase_OnResume(param);
			}

			// Token: 0x060144A0 RID: 83104 RVA: 0x0052899C File Offset: 0x00526B9C
			public bool __callBase_StartNetWorking()
			{
				return this.m_owner.__callBase_StartNetWorking();
			}

			// Token: 0x060144A1 RID: 83105 RVA: 0x005289AC File Offset: 0x00526BAC
			public void __callBase_OnTransactionComplete()
			{
				this.m_owner.__callBase_OnTransactionComplete();
			}

			// Token: 0x060144A2 RID: 83106 RVA: 0x005289BC File Offset: 0x00526BBC
			public void __callBase_RegisterNetworkEvent()
			{
				this.m_owner.__callBase_RegisterNetworkEvent();
			}

			// Token: 0x060144A3 RID: 83107 RVA: 0x005289CC File Offset: 0x00526BCC
			public void __callBase_UnregisterNetworkEvent()
			{
				this.m_owner.__callBase_UnregisterNetworkEvent();
			}

			// Token: 0x060144A4 RID: 83108 RVA: 0x005289DC File Offset: 0x00526BDC
			public void __callBase_OnTick()
			{
				this.m_owner.__callBase_OnTick();
			}

			// Token: 0x060144A5 RID: 83109 RVA: 0x005289EC File Offset: 0x00526BEC
			public void __callBase_OnTimeOut()
			{
				this.m_owner.__callBase_OnTimeOut();
			}

			// Token: 0x060144A6 RID: 83110 RVA: 0x005289FC File Offset: 0x00526BFC
			public void __callBase_OnGameServerDataUnsyncNotify()
			{
				this.m_owner.__callBase_OnGameServerDataUnsyncNotify();
			}

			// Token: 0x060144A7 RID: 83111 RVA: 0x00528A0C File Offset: 0x00526C0C
			public void __callBase_OnGameServerNetworkError()
			{
				this.m_owner.__callBase_OnGameServerNetworkError();
			}

			// Token: 0x060144A8 RID: 83112 RVA: 0x00528A1C File Offset: 0x00526C1C
			public void __callBase_OnGameServerDisconnected()
			{
				this.m_owner.__callBase_OnGameServerDisconnected();
			}

			// Token: 0x060144A9 RID: 83113 RVA: 0x00528A2C File Offset: 0x00526C2C
			public void __callBase_OnNetworkError()
			{
				this.m_owner.__callBase_OnNetworkError();
			}

			// Token: 0x060144AA RID: 83114 RVA: 0x00528A3C File Offset: 0x00526C3C
			public void __callBase_OnReLoginSuccess()
			{
				this.m_owner.__callBase_OnReLoginSuccess();
			}

			// Token: 0x060144AB RID: 83115 RVA: 0x00528A4C File Offset: 0x00526C4C
			public void __callBase_OnUIManagerReturnToLoginUI(bool obj)
			{
				this.m_owner.__callBase_OnUIManagerReturnToLoginUI(obj);
			}

			// Token: 0x17003C59 RID: 15449
			// (get) Token: 0x060144AC RID: 83116 RVA: 0x00528A5C File Offset: 0x00526C5C
			// (set) Token: 0x060144AD RID: 83117 RVA: 0x00528A6C File Offset: 0x00526C6C
			public bool m_isDisableInput
			{
				get
				{
					return this.m_owner.m_isDisableInput;
				}
				set
				{
					this.m_owner.m_isDisableInput = value;
				}
			}

			// Token: 0x17003C5A RID: 15450
			// (set) Token: 0x060144AE RID: 83118 RVA: 0x00528A7C File Offset: 0x00526C7C
			public int Result
			{
				set
				{
					this.m_owner.Result = value;
				}
			}

			// Token: 0x17003C5B RID: 15451
			// (set) Token: 0x060144AF RID: 83119 RVA: 0x00528A8C File Offset: 0x00526C8C
			public bool IsReloginSuccess
			{
				set
				{
					this.m_owner.IsReloginSuccess = value;
				}
			}

			// Token: 0x060144B0 RID: 83120 RVA: 0x00528A9C File Offset: 0x00526C9C
			public bool OnStart(object param)
			{
				return this.m_owner.OnStart(param);
			}

			// Token: 0x060144B1 RID: 83121 RVA: 0x00528AAC File Offset: 0x00526CAC
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x060144B2 RID: 83122 RVA: 0x00528ABC File Offset: 0x00526CBC
			public void OnTimeOut()
			{
				this.m_owner.OnTimeOut();
			}

			// Token: 0x060144B3 RID: 83123 RVA: 0x00528ACC File Offset: 0x00526CCC
			public void OnReLoginSuccess()
			{
				this.m_owner.OnReLoginSuccess();
			}

			// Token: 0x0400B350 RID: 45904
			private UINetTask m_owner;
		}
	}
}
