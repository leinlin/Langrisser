using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000767 RID: 1895
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinInvitationGetReq")]
	[Serializable]
	public class GuildJoinInvitationGetReq : IExtensible
	{
		// Token: 0x060062AD RID: 25261 RVA: 0x001BBD5C File Offset: 0x001B9F5C
		public GuildJoinInvitationGetReq()
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

		// Token: 0x060062AE RID: 25262 RVA: 0x001BBDC4 File Offset: 0x001B9FC4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062AF RID: 25263 RVA: 0x001BBDD4 File Offset: 0x001B9FD4
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

		// Token: 0x060062B0 RID: 25264 RVA: 0x001BBEA0 File Offset: 0x001BA0A0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049ED RID: 18925
		private IExtension extensionObject;

		// Token: 0x040049EE RID: 18926
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049EF RID: 18927
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049F0 RID: 18928
		private LuaFunction m_ctor_hotfix;
	}
}
