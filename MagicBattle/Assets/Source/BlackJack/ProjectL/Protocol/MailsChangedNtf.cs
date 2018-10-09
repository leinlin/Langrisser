using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007EA RID: 2026
	[ProtoContract(Name = "MailsChangedNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailsChangedNtf : IExtensible
	{
		// Token: 0x06006712 RID: 26386 RVA: 0x001CB0F4 File Offset: 0x001C92F4
		public MailsChangedNtf()
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

		// Token: 0x17001A75 RID: 6773
		// (get) Token: 0x06006713 RID: 26387 RVA: 0x001CB168 File Offset: 0x001C9368
		[ProtoMember(1, Name = "Mails", DataFormat = DataFormat.Default)]
		public List<ProMail> Mails
		{
			get
			{
				return this._Mails;
			}
		}

		// Token: 0x06006714 RID: 26388 RVA: 0x001CB170 File Offset: 0x001C9370
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006715 RID: 26389 RVA: 0x001CB180 File Offset: 0x001C9380
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

		// Token: 0x06006716 RID: 26390 RVA: 0x001CB24C File Offset: 0x001C944C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailsChangedNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D33 RID: 19763
		private readonly List<ProMail> _Mails = new List<ProMail>();

		// Token: 0x04004D34 RID: 19764
		private IExtension extensionObject;

		// Token: 0x04004D35 RID: 19765
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D36 RID: 19766
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D37 RID: 19767
		private LuaFunction m_ctor_hotfix;
	}
}
