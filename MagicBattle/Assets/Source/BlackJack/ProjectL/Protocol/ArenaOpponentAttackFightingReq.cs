using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B8 RID: 1464
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaOpponentAttackFightingReq")]
	[Serializable]
	public class ArenaOpponentAttackFightingReq : IExtensible
	{
		// Token: 0x060052E3 RID: 21219 RVA: 0x00188A00 File Offset: 0x00186C00
		public ArenaOpponentAttackFightingReq()
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

		// Token: 0x060052E4 RID: 21220 RVA: 0x00188A68 File Offset: 0x00186C68
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052E5 RID: 21221 RVA: 0x00188A78 File Offset: 0x00186C78
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

		// Token: 0x060052E6 RID: 21222 RVA: 0x00188B44 File Offset: 0x00186D44
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaOpponentAttackFightingReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E43 RID: 15939
		private IExtension extensionObject;

		// Token: 0x04003E44 RID: 15940
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E45 RID: 15941
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E46 RID: 15942
		private LuaFunction m_ctor_hotfix;
	}
}
