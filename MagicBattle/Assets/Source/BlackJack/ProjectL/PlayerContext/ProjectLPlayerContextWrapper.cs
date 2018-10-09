using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.PlayerContext;
using BlackJack.ProjectL.LibClient;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000914 RID: 2324
	[HotFix]
	public class ProjectLPlayerContextWrapper : IClientEventHandler
	{
		// Token: 0x06008666 RID: 34406 RVA: 0x00269350 File Offset: 0x00267550
		public ProjectLPlayerContextWrapper(IPlayerContextNetworkEventHandler playerContext)
		{
			this.m_playerContext = playerContext;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorIPlayerContextNetworkEventHandler_hotfix != null)
			{
				this.m_ctorIPlayerContextNetworkEventHandler_hotfix.call(new object[]
				{
					this,
					playerContext
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06008667 RID: 34407 RVA: 0x002693D0 File Offset: 0x002675D0
		public void OnConnected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnConnected_hotfix != null)
			{
				this.m_OnConnected_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.OnGameServerConnected();
		}

		// Token: 0x06008668 RID: 34408 RVA: 0x0026943C File Offset: 0x0026763C
		public void OnDisconnected()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnDisconnected_hotfix != null)
			{
				this.m_OnDisconnected_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.OnGameServerDisconnected();
		}

		// Token: 0x06008669 RID: 34409 RVA: 0x002694A8 File Offset: 0x002676A8
		public void OnError(int err, string excepionInfo = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnErrorInt32String_hotfix != null)
			{
				this.m_OnErrorInt32String_hotfix.call(new object[]
				{
					this,
					err,
					excepionInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.OnGameServerError(err, excepionInfo);
		}

		// Token: 0x0600866A RID: 34410 RVA: 0x00269538 File Offset: 0x00267738
		public void OnLoginByAuthTokenAck(int result, bool needRedirect, string sessionToken)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginByAuthTokenAckInt32BooleanString_hotfix != null)
			{
				this.m_OnLoginByAuthTokenAckInt32BooleanString_hotfix.call(new object[]
				{
					this,
					result,
					needRedirect,
					sessionToken
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.OnLoginByAuthTokenAck(result, needRedirect, sessionToken);
		}

		// Token: 0x0600866B RID: 34411 RVA: 0x002695D8 File Offset: 0x002677D8
		public void OnLoginBySessionTokenAck(int result)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLoginBySessionTokenAckInt32_hotfix != null)
			{
				this.m_OnLoginBySessionTokenAckInt32_hotfix.call(new object[]
				{
					this,
					result
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.OnLoginBySessionTokenAck(result);
		}

		// Token: 0x0600866C RID: 34412 RVA: 0x00269654 File Offset: 0x00267854
		public void OnMessage(object msg, int msgId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnMessageObjectInt32_hotfix != null)
			{
				this.m_OnMessageObjectInt32_hotfix.call(new object[]
				{
					this,
					msg,
					msgId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerContext.OnGameServerMessage(msg, msgId);
		}

		// Token: 0x17001C50 RID: 7248
		// (get) Token: 0x0600866D RID: 34413 RVA: 0x002696E4 File Offset: 0x002678E4
		// (set) Token: 0x0600866E RID: 34414 RVA: 0x00269704 File Offset: 0x00267904
		[DoNotToLua]
		public ProjectLPlayerContextWrapper.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ProjectLPlayerContextWrapper.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600866F RID: 34415 RVA: 0x00269710 File Offset: 0x00267910
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
					this.m_ctorIPlayerContextNetworkEventHandler_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_OnConnected_hotfix = (luaObj.RawGet("OnConnected") as LuaFunction);
					this.m_OnDisconnected_hotfix = (luaObj.RawGet("OnDisconnected") as LuaFunction);
					this.m_OnErrorInt32String_hotfix = (luaObj.RawGet("OnError") as LuaFunction);
					this.m_OnLoginByAuthTokenAckInt32BooleanString_hotfix = (luaObj.RawGet("OnLoginByAuthTokenAck") as LuaFunction);
					this.m_OnLoginBySessionTokenAckInt32_hotfix = (luaObj.RawGet("OnLoginBySessionTokenAck") as LuaFunction);
					this.m_OnMessageObjectInt32_hotfix = (luaObj.RawGet("OnMessage") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06008670 RID: 34416 RVA: 0x00269874 File Offset: 0x00267A74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ProjectLPlayerContextWrapper));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005F76 RID: 24438
		private IPlayerContextNetworkEventHandler m_playerContext;

		// Token: 0x04005F77 RID: 24439
		[DoNotToLua]
		private ProjectLPlayerContextWrapper.LuaExportHelper luaExportHelper;

		// Token: 0x04005F78 RID: 24440
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005F79 RID: 24441
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005F7A RID: 24442
		private LuaFunction m_ctorIPlayerContextNetworkEventHandler_hotfix;

		// Token: 0x04005F7B RID: 24443
		private LuaFunction m_OnConnected_hotfix;

		// Token: 0x04005F7C RID: 24444
		private LuaFunction m_OnDisconnected_hotfix;

		// Token: 0x04005F7D RID: 24445
		private LuaFunction m_OnErrorInt32String_hotfix;

		// Token: 0x04005F7E RID: 24446
		private LuaFunction m_OnLoginByAuthTokenAckInt32BooleanString_hotfix;

		// Token: 0x04005F7F RID: 24447
		private LuaFunction m_OnLoginBySessionTokenAckInt32_hotfix;

		// Token: 0x04005F80 RID: 24448
		private LuaFunction m_OnMessageObjectInt32_hotfix;

		// Token: 0x02000915 RID: 2325
		public class LuaExportHelper
		{
			// Token: 0x06008671 RID: 34417 RVA: 0x002698DC File Offset: 0x00267ADC
			public LuaExportHelper(ProjectLPlayerContextWrapper owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17001C51 RID: 7249
			// (get) Token: 0x06008672 RID: 34418 RVA: 0x002698EC File Offset: 0x00267AEC
			// (set) Token: 0x06008673 RID: 34419 RVA: 0x002698FC File Offset: 0x00267AFC
			public IPlayerContextNetworkEventHandler m_playerContext
			{
				get
				{
					return this.m_owner.m_playerContext;
				}
				set
				{
					this.m_owner.m_playerContext = value;
				}
			}

			// Token: 0x04005F81 RID: 24449
			private ProjectLPlayerContextWrapper m_owner;
		}
	}
}
