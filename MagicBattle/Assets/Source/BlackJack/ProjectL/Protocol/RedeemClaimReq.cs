using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200070C RID: 1804
	[ProtoContract(Name = "RedeemClaimReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class RedeemClaimReq : IExtensible
	{
		// Token: 0x06005FA2 RID: 24482 RVA: 0x001B1344 File Offset: 0x001AF544
		public RedeemClaimReq()
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

		// Token: 0x06005FA3 RID: 24483 RVA: 0x001B13AC File Offset: 0x001AF5AC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FA4 RID: 24484 RVA: 0x001B13BC File Offset: 0x001AF5BC
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

		// Token: 0x06005FA5 RID: 24485 RVA: 0x001B1488 File Offset: 0x001AF688
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(RedeemClaimReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400479A RID: 18330
		private IExtension extensionObject;

		// Token: 0x0400479B RID: 18331
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400479C RID: 18332
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400479D RID: 18333
		private LuaFunction m_ctor_hotfix;
	}
}
