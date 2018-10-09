using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200068F RID: 1679
	[ProtoContract(Name = "ClientCheatNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ClientCheatNtf : IExtensible
	{
		// Token: 0x06005B49 RID: 23369 RVA: 0x001A2838 File Offset: 0x001A0A38
		public ClientCheatNtf()
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

		// Token: 0x06005B4A RID: 23370 RVA: 0x001A28A0 File Offset: 0x001A0AA0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005B4B RID: 23371 RVA: 0x001A28B0 File Offset: 0x001A0AB0
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

		// Token: 0x06005B4C RID: 23372 RVA: 0x001A297C File Offset: 0x001A0B7C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClientCheatNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004458 RID: 17496
		private IExtension extensionObject;

		// Token: 0x04004459 RID: 17497
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400445A RID: 17498
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400445B RID: 17499
		private LuaFunction m_ctor_hotfix;
	}
}
