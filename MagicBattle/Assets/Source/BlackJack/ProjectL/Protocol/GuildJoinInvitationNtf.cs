using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000786 RID: 1926
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "GuildJoinInvitationNtf")]
	[Serializable]
	public class GuildJoinInvitationNtf : IExtensible
	{
		// Token: 0x06006390 RID: 25488 RVA: 0x001BF57C File Offset: 0x001BD77C
		public GuildJoinInvitationNtf()
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

		// Token: 0x06006391 RID: 25489 RVA: 0x001BF5E4 File Offset: 0x001BD7E4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006392 RID: 25490 RVA: 0x001BF5F4 File Offset: 0x001BD7F4
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

		// Token: 0x06006393 RID: 25491 RVA: 0x001BF6C0 File Offset: 0x001BD8C0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildJoinInvitationNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004A9F RID: 19103
		private IExtension extensionObject;

		// Token: 0x04004AA0 RID: 19104
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004AA1 RID: 19105
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004AA2 RID: 19106
		private LuaFunction m_ctor_hotfix;
	}
}
