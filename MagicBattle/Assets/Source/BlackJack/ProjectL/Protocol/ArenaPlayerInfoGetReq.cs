using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005B2 RID: 1458
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaPlayerInfoGetReq")]
	[Serializable]
	public class ArenaPlayerInfoGetReq : IExtensible
	{
		// Token: 0x060052B6 RID: 21174 RVA: 0x00187F1C File Offset: 0x0018611C
		public ArenaPlayerInfoGetReq()
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

		// Token: 0x060052B7 RID: 21175 RVA: 0x00187F84 File Offset: 0x00186184
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x060052B8 RID: 21176 RVA: 0x00187F94 File Offset: 0x00186194
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

		// Token: 0x060052B9 RID: 21177 RVA: 0x00188060 File Offset: 0x00186260
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaPlayerInfoGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003E20 RID: 15904
		private IExtension extensionObject;

		// Token: 0x04003E21 RID: 15905
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003E22 RID: 15906
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003E23 RID: 15907
		private LuaFunction m_ctor_hotfix;
	}
}
