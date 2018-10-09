using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200070A RID: 1802
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "RedeemInfoReq")]
	[Serializable]
	public class RedeemInfoReq : IExtensible
	{
		// Token: 0x06005F8F RID: 24463 RVA: 0x001B0F74 File Offset: 0x001AF174
		public RedeemInfoReq()
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

		// Token: 0x06005F90 RID: 24464 RVA: 0x001B0FDC File Offset: 0x001AF1DC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F91 RID: 24465 RVA: 0x001B0FEC File Offset: 0x001AF1EC
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

		// Token: 0x06005F92 RID: 24466 RVA: 0x001B10B8 File Offset: 0x001AF2B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RedeemInfoReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400478C RID: 18316
		private IExtension extensionObject;

		// Token: 0x0400478D RID: 18317
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400478E RID: 18318
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400478F RID: 18319
		private LuaFunction m_ctor_hotfix;
	}
}
