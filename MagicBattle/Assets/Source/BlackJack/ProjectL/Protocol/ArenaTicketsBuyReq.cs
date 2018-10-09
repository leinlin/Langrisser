using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020006F9 RID: 1785
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ArenaTicketsBuyReq")]
	[Serializable]
	public class ArenaTicketsBuyReq : IExtensible
	{
		// Token: 0x06005F1F RID: 24351 RVA: 0x001AF13C File Offset: 0x001AD33C
		public ArenaTicketsBuyReq()
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

		// Token: 0x06005F20 RID: 24352 RVA: 0x001AF1A4 File Offset: 0x001AD3A4
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06005F21 RID: 24353 RVA: 0x001AF1B4 File Offset: 0x001AD3B4
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

		// Token: 0x06005F22 RID: 24354 RVA: 0x001AF280 File Offset: 0x001AD480
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ArenaTicketsBuyReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004731 RID: 18225
		private IExtension extensionObject;

		// Token: 0x04004732 RID: 18226
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004733 RID: 18227
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004734 RID: 18228
		private LuaFunction m_ctor_hotfix;
	}
}
