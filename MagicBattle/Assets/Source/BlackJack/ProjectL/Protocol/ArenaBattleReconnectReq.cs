using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020005CB RID: 1483
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaBattleReconnectReq")]
	[Serializable]
	public class ArenaBattleReconnectReq : IExtensible
	{
		// Token: 0x0600537A RID: 21370 RVA: 0x0018ACE4 File Offset: 0x00188EE4
		public ArenaBattleReconnectReq()
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

		// Token: 0x0600537B RID: 21371 RVA: 0x0018AD4C File Offset: 0x00188F4C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600537C RID: 21372 RVA: 0x0018AD5C File Offset: 0x00188F5C
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

		// Token: 0x0600537D RID: 21373 RVA: 0x0018AE28 File Offset: 0x00189028
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaBattleReconnectReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003EB7 RID: 16055
		private IExtension extensionObject;

		// Token: 0x04003EB8 RID: 16056
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003EB9 RID: 16057
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003EBA RID: 16058
		private LuaFunction m_ctor_hotfix;
	}
}
