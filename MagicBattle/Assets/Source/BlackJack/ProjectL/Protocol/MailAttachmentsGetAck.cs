using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x020007EE RID: 2030
	[ProtoContract(Name = "MailAttachmentsGetAck")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class MailAttachmentsGetAck : IExtensible
	{
		// Token: 0x0600672B RID: 26411 RVA: 0x001CB808 File Offset: 0x001C9A08
		public MailAttachmentsGetAck()
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

		// Token: 0x17001A7A RID: 6778
		// (get) Token: 0x0600672C RID: 26412 RVA: 0x001CB870 File Offset: 0x001C9A70
		// (set) Token: 0x0600672D RID: 26413 RVA: 0x001CB878 File Offset: 0x001C9A78
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

		// Token: 0x17001A7B RID: 6779
		// (get) Token: 0x0600672E RID: 26414 RVA: 0x001CB884 File Offset: 0x001C9A84
		// (set) Token: 0x0600672F RID: 26415 RVA: 0x001CB88C File Offset: 0x001C9A8C
		[ProtoMember(2, IsRequired = true, Name = "InstanceId", DataFormat = DataFormat.TwosComplement)]
		public ulong InstanceId
		{
			get
			{
				return this._InstanceId;
			}
			set
			{
				this._InstanceId = value;
			}
		}

		// Token: 0x17001A7C RID: 6780
		// (get) Token: 0x06006730 RID: 26416 RVA: 0x001CB898 File Offset: 0x001C9A98
		// (set) Token: 0x06006731 RID: 26417 RVA: 0x001CB8A0 File Offset: 0x001C9AA0
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "ntf", DataFormat = DataFormat.Default)]
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

		// Token: 0x06006732 RID: 26418 RVA: 0x001CB8AC File Offset: 0x001C9AAC
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x06006733 RID: 26419 RVA: 0x001CB8BC File Offset: 0x001C9ABC
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

		// Token: 0x06006734 RID: 26420 RVA: 0x001CB988 File Offset: 0x001C9B88
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MailAttachmentsGetAck));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04004D48 RID: 19784
		private int _Result;

		// Token: 0x04004D49 RID: 19785
		private ulong _InstanceId;

		// Token: 0x04004D4A RID: 19786
		private ProChangedGoodsNtf _ntf;

		// Token: 0x04004D4B RID: 19787
		private IExtension extensionObject;

		// Token: 0x04004D4C RID: 19788
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04004D4D RID: 19789
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04004D4E RID: 19790
		private LuaFunction m_ctor_hotfix;
	}
}
