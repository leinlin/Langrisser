using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200070E RID: 1806
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "FansRewardsFromPBTCBTInfoReq")]
	[Serializable]
	public class FansRewardsFromPBTCBTInfoReq : IExtensible
	{
		// Token: 0x06005FAC RID: 24492 RVA: 0x001B16B0 File Offset: 0x001AF8B0
		public FansRewardsFromPBTCBTInfoReq()
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

		// Token: 0x06005FAD RID: 24493 RVA: 0x001B1718 File Offset: 0x001AF918
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FAE RID: 24494 RVA: 0x001B1728 File Offset: 0x001AF928
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

		// Token: 0x06005FAF RID: 24495 RVA: 0x001B17F4 File Offset: 0x001AF9F4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FansRewardsFromPBTCBTInfoReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047A3 RID: 18339
		private IExtension extensionObject;

		// Token: 0x040047A4 RID: 18340
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047A5 RID: 18341
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047A6 RID: 18342
		private LuaFunction m_ctor_hotfix;
	}
}
