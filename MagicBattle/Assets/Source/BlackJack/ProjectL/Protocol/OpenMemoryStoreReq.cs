using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000714 RID: 1812
	[ProtoContract(Name = "OpenMemoryStoreReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class OpenMemoryStoreReq : IExtensible
	{
		// Token: 0x06005FD6 RID: 24534 RVA: 0x001B216C File Offset: 0x001B036C
		public OpenMemoryStoreReq()
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

		// Token: 0x06005FD7 RID: 24535 RVA: 0x001B21D4 File Offset: 0x001B03D4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FD8 RID: 24536 RVA: 0x001B21E4 File Offset: 0x001B03E4
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

		// Token: 0x06005FD9 RID: 24537 RVA: 0x001B22B0 File Offset: 0x001B04B0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(OpenMemoryStoreReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047C4 RID: 18372
		private IExtension extensionObject;

		// Token: 0x040047C5 RID: 18373
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047C6 RID: 18374
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047C7 RID: 18375
		private LuaFunction m_ctor_hotfix;
	}
}
