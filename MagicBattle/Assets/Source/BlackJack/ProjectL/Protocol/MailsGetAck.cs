using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007E9 RID: 2025
	[ProtoContract(Name = "MailsGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailsGetAck : IExtensible
	{
		// Token: 0x0600670D RID: 26381 RVA: 0x001CAF34 File Offset: 0x001C9134
		public MailsGetAck()
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

		// Token: 0x17001A74 RID: 6772
		// (get) Token: 0x0600670E RID: 26382 RVA: 0x001CAFA8 File Offset: 0x001C91A8
		[ProtoMember(1, Name = "Mails", DataFormat = DataFormat.Default)]
		public List<ProMail> Mails
		{
			get
			{
				return this._Mails;
			}
		}

		// Token: 0x0600670F RID: 26383 RVA: 0x001CAFB0 File Offset: 0x001C91B0
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006710 RID: 26384 RVA: 0x001CAFC0 File Offset: 0x001C91C0
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

		// Token: 0x06006711 RID: 26385 RVA: 0x001CB08C File Offset: 0x001C928C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailsGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D2E RID: 19758
		private readonly List<ProMail> _Mails = new List<ProMail>();

		// Token: 0x04004D2F RID: 19759
		private IExtension extensionObject;

		// Token: 0x04004D30 RID: 19760
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D31 RID: 19761
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D32 RID: 19762
		private LuaFunction m_ctor_hotfix;
	}
}
