using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x0200061F RID: 1567
	[HotFix(true, m_isCtorOnly = true)]
	[ProtoContract(Name = "ChatMessageSendReq")]
	[Serializable]
	public class ChatMessageSendReq : IExtensible
	{
		// Token: 0x0600563C RID: 22076 RVA: 0x00194904 File Offset: 0x00192B04
		public ChatMessageSendReq()
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

		// Token: 0x1700153E RID: 5438
		// (get) Token: 0x0600563D RID: 22077 RVA: 0x00194980 File Offset: 0x00192B80
		// (set) Token: 0x0600563E RID: 22078 RVA: 0x00194988 File Offset: 0x00192B88
		[ProtoMember(1, IsRequired = true, Name = "ChannelId", DataFormat = DataFormat.TwosComplement)]
		public int ChannelId
		{
			get
			{
				return this._ChannelId;
			}
			set
			{
				this._ChannelId = value;
			}
		}

		// Token: 0x1700153F RID: 5439
		// (get) Token: 0x0600563F RID: 22079 RVA: 0x00194994 File Offset: 0x00192B94
		// (set) Token: 0x06005640 RID: 22080 RVA: 0x0019499C File Offset: 0x00192B9C
		[ProtoMember(2, IsRequired = true, Name = "ChatInfo", DataFormat = DataFormat.Default)]
		public ProChatInfo ChatInfo
		{
			get
			{
				return this._ChatInfo;
			}
			set
			{
				this._ChatInfo = value;
			}
		}

		// Token: 0x17001540 RID: 5440
		// (get) Token: 0x06005641 RID: 22081 RVA: 0x001949A8 File Offset: 0x00192BA8
		// (set) Token: 0x06005642 RID: 22082 RVA: 0x001949B0 File Offset: 0x00192BB0
		[ProtoMember(3, IsRequired = false, Name = "Content", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
		public ProChatContentText Content
		{
			get
			{
				return this._Content;
			}
			set
			{
				this._Content = value;
			}
		}

		// Token: 0x17001541 RID: 5441
		// (get) Token: 0x06005643 RID: 22083 RVA: 0x001949BC File Offset: 0x00192BBC
		// (set) Token: 0x06005644 RID: 22084 RVA: 0x001949C4 File Offset: 0x00192BC4
		[DefaultValue(null)]
		[ProtoMember(4, IsRequired = false, Name = "VoiceInfo", DataFormat = DataFormat.Default)]
		public ProChatContentVoice VoiceInfo
		{
			get
			{
				return this._VoiceInfo;
			}
			set
			{
				this._VoiceInfo = value;
			}
		}

		// Token: 0x17001542 RID: 5442
		// (get) Token: 0x06005645 RID: 22085 RVA: 0x001949D0 File Offset: 0x00192BD0
		// (set) Token: 0x06005646 RID: 22086 RVA: 0x001949D8 File Offset: 0x00192BD8
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "EnterRoomInfo", DataFormat = DataFormat.Default)]
		public ProChatEnterRoomInfo EnterRoomInfo
		{
			get
			{
				return this._EnterRoomInfo;
			}
			set
			{
				this._EnterRoomInfo = value;
			}
		}

		// Token: 0x17001543 RID: 5443
		// (get) Token: 0x06005647 RID: 22087 RVA: 0x001949E4 File Offset: 0x00192BE4
		// (set) Token: 0x06005648 RID: 22088 RVA: 0x001949EC File Offset: 0x00192BEC
		[DefaultValue("")]
		[ProtoMember(6, IsRequired = false, Name = "DestGameUserId", DataFormat = DataFormat.Default)]
		public string DestGameUserId
		{
			get
			{
				return this._DestGameUserId;
			}
			set
			{
				this._DestGameUserId = value;
			}
		}

		// Token: 0x17001544 RID: 5444
		// (get) Token: 0x06005649 RID: 22089 RVA: 0x001949F8 File Offset: 0x00192BF8
		// (set) Token: 0x0600564A RID: 22090 RVA: 0x00194A00 File Offset: 0x00192C00
		[DefaultValue("")]
		[ProtoMember(7, IsRequired = false, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
		public string ChatGroupId
		{
			get
			{
				return this._ChatGroupId;
			}
			set
			{
				this._ChatGroupId = value;
			}
		}

		// Token: 0x0600564B RID: 22091 RVA: 0x00194A0C File Offset: 0x00192C0C
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600564C RID: 22092 RVA: 0x00194A1C File Offset: 0x00192C1C
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

		// Token: 0x0600564D RID: 22093 RVA: 0x00194AE8 File Offset: 0x00192CE8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatMessageSendReq));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040D0 RID: 16592
		private int _ChannelId;

		// Token: 0x040040D1 RID: 16593
		private ProChatInfo _ChatInfo;

		// Token: 0x040040D2 RID: 16594
		private ProChatContentText _Content;

		// Token: 0x040040D3 RID: 16595
		private ProChatContentVoice _VoiceInfo;

		// Token: 0x040040D4 RID: 16596
		private ProChatEnterRoomInfo _EnterRoomInfo;

		// Token: 0x040040D5 RID: 16597
		private string _DestGameUserId = string.Empty;

		// Token: 0x040040D6 RID: 16598
		private string _ChatGroupId = string.Empty;

		// Token: 0x040040D7 RID: 16599
		private IExtension extensionObject;

		// Token: 0x040040D8 RID: 16600
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040D9 RID: 16601
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040DA RID: 16602
		private LuaFunction m_ctor_hotfix;
	}
}
