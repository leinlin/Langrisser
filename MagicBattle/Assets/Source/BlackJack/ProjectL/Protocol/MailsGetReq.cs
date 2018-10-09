using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007E8 RID: 2024
	[ProtoContract(Name = "MailsGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailsGetReq : IExtensible
	{
		// Token: 0x06006709 RID: 26377 RVA: 0x001CAD88 File Offset: 0x001C8F88
		public MailsGetReq()
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

		// Token: 0x0600670A RID: 26378 RVA: 0x001CADF0 File Offset: 0x001C8FF0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600670B RID: 26379 RVA: 0x001CAE00 File Offset: 0x001C9000
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

		// Token: 0x0600670C RID: 26380 RVA: 0x001CAECC File Offset: 0x001C90CC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailsGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D2A RID: 19754
		private IExtension extensionObject;

		// Token: 0x04004D2B RID: 19755
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D2C RID: 19756
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D2D RID: 19757
		private LuaFunction m_ctor_hotfix;
	}
}
