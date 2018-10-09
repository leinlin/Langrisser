using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000847 RID: 2119
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "TeamRoomSelfKickOutNtf")]
	[Serializable]
	public class TeamRoomSelfKickOutNtf : IExtensible
	{
		// Token: 0x060069F1 RID: 27121 RVA: 0x001DCF54 File Offset: 0x001DB154
		public TeamRoomSelfKickOutNtf()
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

		// Token: 0x060069F2 RID: 27122 RVA: 0x001DCFBC File Offset: 0x001DB1BC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060069F3 RID: 27123 RVA: 0x001DCFCC File Offset: 0x001DB1CC
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

		// Token: 0x060069F4 RID: 27124 RVA: 0x001DD098 File Offset: 0x001DB298
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamRoomSelfKickOutNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040051A6 RID: 20902
		private IExtension extensionObject;

		// Token: 0x040051A7 RID: 20903
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040051A8 RID: 20904
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040051A9 RID: 20905
		private LuaFunction m_ctor_hotfix;
	}
}
