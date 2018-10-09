using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000836 RID: 2102
	[ProtoContract(Name = "TeamRoomGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class TeamRoomGetReq : IExtensible
	{
		// Token: 0x0600697C RID: 27004 RVA: 0x001DB0E0 File Offset: 0x001D92E0
		public TeamRoomGetReq()
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

		// Token: 0x0600697D RID: 27005 RVA: 0x001DB148 File Offset: 0x001D9348
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600697E RID: 27006 RVA: 0x001DB158 File Offset: 0x001D9358
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

		// Token: 0x0600697F RID: 27007 RVA: 0x001DB224 File Offset: 0x001D9424
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005148 RID: 20808
		private IExtension extensionObject;

		// Token: 0x04005149 RID: 20809
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400514A RID: 20810
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400514B RID: 20811
		private LuaFunction m_ctor_hotfix;
	}
}
