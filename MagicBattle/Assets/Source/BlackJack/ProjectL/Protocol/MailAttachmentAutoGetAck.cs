using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007F0 RID: 2032
	[ProtoContract(Name = "MailAttachmentAutoGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailAttachmentAutoGetAck : IExtensible
	{
		// Token: 0x06006739 RID: 26425 RVA: 0x001CBB9C File Offset: 0x001C9D9C
		public MailAttachmentAutoGetAck()
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

		// Token: 0x17001A7D RID: 6781
		// (get) Token: 0x0600673A RID: 26426 RVA: 0x001CBC04 File Offset: 0x001C9E04
		// (set) Token: 0x0600673B RID: 26427 RVA: 0x001CBC0C File Offset: 0x001C9E0C
		[ProtoMember(1, IsRequired = true, Name = "Result", DataFormat = DataFormat.TwosComplement)]
		public int Result
		{
			get
			{
				return this._Result;
			}
			set
			{
				this._Result = value;
			}
		}

		// Token: 0x17001A7E RID: 6782
		// (get) Token: 0x0600673C RID: 26428 RVA: 0x001CBC18 File Offset: 0x001C9E18
		// (set) Token: 0x0600673D RID: 26429 RVA: 0x001CBC20 File Offset: 0x001C9E20
		[DefaultValue(null)]
		[ProtoMember(2, IsRequired = false, Name = "ntf", DataFormat = DataFormat.Default)]
		public ProChangedGoodsNtf Ntf
		{
			get
			{
				return this._ntf;
			}
			set
			{
				this._ntf = value;
			}
		}

		// Token: 0x0600673E RID: 26430 RVA: 0x001CBC2C File Offset: 0x001C9E2C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600673F RID: 26431 RVA: 0x001CBC3C File Offset: 0x001C9E3C
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

		// Token: 0x06006740 RID: 26432 RVA: 0x001CBD08 File Offset: 0x001C9F08
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailAttachmentAutoGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D53 RID: 19795
		private int _Result;

		// Token: 0x04004D54 RID: 19796
		private ProChangedGoodsNtf _ntf;

		// Token: 0x04004D55 RID: 19797
		private IExtension extensionObject;

		// Token: 0x04004D56 RID: 19798
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D57 RID: 19799
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D58 RID: 19800
		private LuaFunction m_ctor_hotfix;
	}
}
