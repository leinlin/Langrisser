using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000710 RID: 1808
	[ProtoContract(Name = "FansRewardsFromPBTCBTClaimReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class FansRewardsFromPBTCBTClaimReq : IExtensible
	{
		// Token: 0x06005FBE RID: 24510 RVA: 0x001B1A6C File Offset: 0x001AFC6C
		public FansRewardsFromPBTCBTClaimReq()
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

		// Token: 0x06005FBF RID: 24511 RVA: 0x001B1AD4 File Offset: 0x001AFCD4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005FC0 RID: 24512 RVA: 0x001B1AE4 File Offset: 0x001AFCE4
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

		// Token: 0x06005FC1 RID: 24513 RVA: 0x001B1BB0 File Offset: 0x001AFDB0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(FansRewardsFromPBTCBTClaimReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040047B0 RID: 18352
		private IExtension extensionObject;

		// Token: 0x040047B1 RID: 18353
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040047B2 RID: 18354
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040047B3 RID: 18355
		private LuaFunction m_ctor_hotfix;
	}
}
