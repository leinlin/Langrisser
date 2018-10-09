using System;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007EF RID: 2031
	[ProtoContract(Name = "MailAttachmentAutoGetReq")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailAttachmentAutoGetReq : IExtensible
	{
		// Token: 0x06006735 RID: 26421 RVA: 0x001CB9F0 File Offset: 0x001C9BF0
		public MailAttachmentAutoGetReq()
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

		// Token: 0x06006736 RID: 26422 RVA: 0x001CBA58 File Offset: 0x001C9C58
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006737 RID: 26423 RVA: 0x001CBA68 File Offset: 0x001C9C68
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

		// Token: 0x06006738 RID: 26424 RVA: 0x001CBB34 File Offset: 0x001C9D34
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailAttachmentAutoGetReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D4F RID: 19791
		private IExtension extensionObject;

		// Token: 0x04004D50 RID: 19792
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D51 RID: 19793
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D52 RID: 19794
		private LuaFunction m_ctor_hotfix;
	}
}
