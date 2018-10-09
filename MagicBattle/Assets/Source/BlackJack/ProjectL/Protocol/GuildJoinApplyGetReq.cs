using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200075F RID: 1887
	[ProtoContract(Name = "GuildJoinApplyGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class GuildJoinApplyGetReq : IExtensible
	{
		// Token: 0x06006278 RID: 25208 RVA: 0x001BAF20 File Offset: 0x001B9120
		public GuildJoinApplyGetReq()
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

		// Token: 0x06006279 RID: 25209 RVA: 0x001BAF88 File Offset: 0x001B9188
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600627A RID: 25210 RVA: 0x001BAF98 File Offset: 0x001B9198
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

		// Token: 0x0600627B RID: 25211 RVA: 0x001BB064 File Offset: 0x001B9264
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinApplyGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049C2 RID: 18882
		private IExtension extensionObject;

		// Token: 0x040049C3 RID: 18883
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049C4 RID: 18884
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049C5 RID: 18885
		private LuaFunction m_ctor_hotfix;
	}
}
