using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000765 RID: 1893
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "AllGuildJoinInvitationRefuseReq")]
	[Serializable]
	public class AllGuildJoinInvitationRefuseReq : IExtensible
	{
		// Token: 0x060062A3 RID: 25251 RVA: 0x001BB9F0 File Offset: 0x001B9BF0
		public AllGuildJoinInvitationRefuseReq()
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

		// Token: 0x060062A4 RID: 25252 RVA: 0x001BBA58 File Offset: 0x001B9C58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060062A5 RID: 25253 RVA: 0x001BBA68 File Offset: 0x001B9C68
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

		// Token: 0x060062A6 RID: 25254 RVA: 0x001BBB34 File Offset: 0x001B9D34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AllGuildJoinInvitationRefuseReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049E4 RID: 18916
		private IExtension extensionObject;

		// Token: 0x040049E5 RID: 18917
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049E6 RID: 18918
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049E7 RID: 18919
		private LuaFunction m_ctor_hotfix;
	}
}
