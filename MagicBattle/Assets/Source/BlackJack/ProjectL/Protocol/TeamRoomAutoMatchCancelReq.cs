using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200082E RID: 2094
	[ProtoContract(Name = "TeamRoomAutoMatchCancelReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomAutoMatchCancelReq : IExtensible
	{
		// Token: 0x06006946 RID: 26950 RVA: 0x001DA2A4 File Offset: 0x001D84A4
		public TeamRoomAutoMatchCancelReq()
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

		// Token: 0x06006947 RID: 26951 RVA: 0x001DA30C File Offset: 0x001D850C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006948 RID: 26952 RVA: 0x001DA31C File Offset: 0x001D851C
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

		// Token: 0x06006949 RID: 26953 RVA: 0x001DA3E8 File Offset: 0x001D85E8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomAutoMatchCancelReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400511D RID: 20765
		private IExtension extensionObject;

		// Token: 0x0400511E RID: 20766
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400511F RID: 20767
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005120 RID: 20768
		private LuaFunction m_ctor_hotfix;
	}
}
