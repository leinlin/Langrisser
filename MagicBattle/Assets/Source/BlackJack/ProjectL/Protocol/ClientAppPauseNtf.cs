using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000690 RID: 1680
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ClientAppPauseNtf")]
	[Serializable]
	public class ClientAppPauseNtf : IExtensible
	{
		// Token: 0x06005B4D RID: 23373 RVA: 0x001A29E4 File Offset: 0x001A0BE4
		public ClientAppPauseNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctor_hotfix != null)
			{
				this.m_ctor_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06005B4E RID: 23374 RVA: 0x001A2A4C File Offset: 0x001A0C4C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B4F RID: 23375 RVA: 0x001A2A5C File Offset: 0x001A0C5C
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
					this.m_ctor_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06005B50 RID: 23376 RVA: 0x001A2B28 File Offset: 0x001A0D28
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientAppPauseNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400445C RID: 17500
		private IExtension extensionObject;

		// Token: 0x0400445D RID: 17501
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400445E RID: 17502
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400445F RID: 17503
		private LuaFunction m_ctor_hotfix;
	}
}
