using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000834 RID: 2100
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomQuitReq")]
	[Serializable]
	public class TeamRoomQuitReq : IExtensible
	{
		// Token: 0x06006972 RID: 26994 RVA: 0x001DAD74 File Offset: 0x001D8F74
		public TeamRoomQuitReq()
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

		// Token: 0x06006973 RID: 26995 RVA: 0x001DADDC File Offset: 0x001D8FDC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006974 RID: 26996 RVA: 0x001DADEC File Offset: 0x001D8FEC
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

		// Token: 0x06006975 RID: 26997 RVA: 0x001DAEB8 File Offset: 0x001D90B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomQuitReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400513F RID: 20799
		private IExtension extensionObject;

		// Token: 0x04005140 RID: 20800
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005141 RID: 20801
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005142 RID: 20802
		private LuaFunction m_ctor_hotfix;
	}
}
