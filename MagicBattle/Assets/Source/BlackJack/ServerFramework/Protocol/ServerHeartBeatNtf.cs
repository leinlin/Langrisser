using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ServerFramework.Protocol
{
	// Token: 0x020007E4 RID: 2020
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ServerHeartBeatNtf")]
	[Serializable]
	public class ServerHeartBeatNtf : IExtensible
	{
		// Token: 0x060066E1 RID: 26337 RVA: 0x001CA5E8 File Offset: 0x001C87E8
		public ServerHeartBeatNtf()
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

		// Token: 0x060066E2 RID: 26338 RVA: 0x001CA650 File Offset: 0x001C8850
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060066E3 RID: 26339 RVA: 0x001CA660 File Offset: 0x001C8860
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

		// Token: 0x060066E4 RID: 26340 RVA: 0x001CA72C File Offset: 0x001C892C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ServerHeartBeatNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D0E RID: 19726
		private IExtension extensionObject;

		// Token: 0x04004D0F RID: 19727
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D10 RID: 19728
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D11 RID: 19729
		private LuaFunction m_ctor_hotfix;
	}
}
