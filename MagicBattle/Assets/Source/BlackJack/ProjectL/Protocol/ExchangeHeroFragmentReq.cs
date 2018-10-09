using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007D3 RID: 2003
	[ProtoContract(Name = "ExchangeHeroFragmentReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ExchangeHeroFragmentReq : IExtensible
	{
		// Token: 0x0600664A RID: 26186 RVA: 0x001C85F4 File Offset: 0x001C67F4
		public ExchangeHeroFragmentReq()
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

		// Token: 0x0600664B RID: 26187 RVA: 0x001C865C File Offset: 0x001C685C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600664C RID: 26188 RVA: 0x001C866C File Offset: 0x001C686C
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

		// Token: 0x0600664D RID: 26189 RVA: 0x001C8738 File Offset: 0x001C6938
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ExchangeHeroFragmentReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004C9D RID: 19613
		private IExtension extensionObject;

		// Token: 0x04004C9E RID: 19614
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004C9F RID: 19615
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004CA0 RID: 19616
		private LuaFunction m_ctor_hotfix;
	}
}
