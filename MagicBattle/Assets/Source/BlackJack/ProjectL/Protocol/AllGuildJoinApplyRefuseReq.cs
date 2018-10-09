using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200075D RID: 1885
	[ProtoContract(Name = "AllGuildJoinApplyRefuseReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class AllGuildJoinApplyRefuseReq : IExtensible
	{
		// Token: 0x0600626E RID: 25198 RVA: 0x001BABB4 File Offset: 0x001B8DB4
		public AllGuildJoinApplyRefuseReq()
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

		// Token: 0x0600626F RID: 25199 RVA: 0x001BAC1C File Offset: 0x001B8E1C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006270 RID: 25200 RVA: 0x001BAC2C File Offset: 0x001B8E2C
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

		// Token: 0x06006271 RID: 25201 RVA: 0x001BACF8 File Offset: 0x001B8EF8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AllGuildJoinApplyRefuseReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040049B9 RID: 18873
		private IExtension extensionObject;

		// Token: 0x040049BA RID: 18874
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040049BB RID: 18875
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040049BC RID: 18876
		private LuaFunction m_ctor_hotfix;
	}
}
