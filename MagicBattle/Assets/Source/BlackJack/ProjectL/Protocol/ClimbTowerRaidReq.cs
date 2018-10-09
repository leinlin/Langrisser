using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000635 RID: 1589
	[ProtoContract(Name = "ClimbTowerRaidReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ClimbTowerRaidReq : IExtensible
	{
		// Token: 0x06005711 RID: 22289 RVA: 0x0019731C File Offset: 0x0019551C
		public ClimbTowerRaidReq()
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

		// Token: 0x06005712 RID: 22290 RVA: 0x00197384 File Offset: 0x00195584
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005713 RID: 22291 RVA: 0x00197394 File Offset: 0x00195594
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

		// Token: 0x06005714 RID: 22292 RVA: 0x00197460 File Offset: 0x00195660
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ClimbTowerRaidReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004169 RID: 16745
		private IExtension extensionObject;

		// Token: 0x0400416A RID: 16746
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400416B RID: 16747
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400416C RID: 16748
		private LuaFunction m_ctor_hotfix;
	}
}
