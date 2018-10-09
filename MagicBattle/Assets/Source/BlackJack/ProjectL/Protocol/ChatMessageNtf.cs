using System;
using System.ComponentModel;
using BlackJack.BJFramework.Runtime.Lua;
using ProtoBuf;
using SLua;

namespace BlackJack.ProjectL.Protocol
{
	// Token: 0x02000621 RID: 1569
	[ProtoContract(Name = "ChatMessageNtf")]
	[HotFix(true, m_isCtorOnly = true)]
	[Serializable]
	public class ChatMessageNtf : IExtensible
	{
		// Token: 0x06005654 RID: 22100 RVA: 0x00194D10 File Offset: 0x00192F10
		public ChatMessageNtf()
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

		// Token: 0x17001546 RID: 5446
		// (get) Token: 0x06005655 RID: 22101 RVA: 0x00194D8C File Offset: 0x00192F8C
		// (set) Token: 0x06005656 RID: 22102 RVA: 0x00194D94 File Offset: 0x00192F94
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

		// Token: 0x17001547 RID: 5447
		// (get) Token: 0x06005657 RID: 22103 RVA: 0x00194DA0 File Offset: 0x00192FA0
		// (set) Token: 0x06005658 RID: 22104 RVA: 0x00194DA8 File Offset: 0x00192FA8
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

		// Token: 0x17001548 RID: 5448
		// (get) Token: 0x06005659 RID: 22105 RVA: 0x00194DB4 File Offset: 0x00192FB4
		// (set) Token: 0x0600565A RID: 22106 RVA: 0x00194DBC File Offset: 0x00192FBC
		[DefaultValue(null)]
		[ProtoMember(3, IsRequired = false, Name = "Content", DataFormat = DataFormat.Default)]
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

		// Token: 0x17001549 RID: 5449
		// (get) Token: 0x0600565B RID: 22107 RVA: 0x00194DC8 File Offset: 0x00192FC8
		// (set) Token: 0x0600565C RID: 22108 RVA: 0x00194DD0 File Offset: 0x00192FD0
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

		// Token: 0x1700154A RID: 5450
		// (get) Token: 0x0600565D RID: 22109 RVA: 0x00194DDC File Offset: 0x00192FDC
		// (set) Token: 0x0600565E RID: 22110 RVA: 0x00194DE4 File Offset: 0x00192FE4
		[DefaultValue(null)]
		[ProtoMember(5, IsRequired = false, Name = "VoiceSimpleInfo", DataFormat = DataFormat.Default)]
		public ProChatVoiceSimpleInfo VoiceSimpleInfo
		{
			get
			{
				return this._VoiceSimpleInfo;
			}
			set
			{
				this._VoiceSimpleInfo = value;
			}
		}

		// Token: 0x1700154B RID: 5451
		// (get) Token: 0x0600565F RID: 22111 RVA: 0x00194DF0 File Offset: 0x00192FF0
		// (set) Token: 0x06005660 RID: 22112 RVA: 0x00194DF8 File Offset: 0x00192FF8
		[ProtoMember(6, IsRequired = false, Name = "EnterRoomInfo", DataFormat = DataFormat.Default)]
		[DefaultValue(null)]
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

		// Token: 0x1700154C RID: 5452
		// (get) Token: 0x06005661 RID: 22113 RVA: 0x00194E04 File Offset: 0x00193004
		// (set) Token: 0x06005662 RID: 22114 RVA: 0x00194E0C File Offset: 0x0019300C
		[DefaultValue("")]
		[ProtoMember(7, IsRequired = false, Name = "DestGameUserId", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700154D RID: 5453
		// (get) Token: 0x06005663 RID: 22115 RVA: 0x00194E18 File Offset: 0x00193018
		// (set) Token: 0x06005664 RID: 22116 RVA: 0x00194E20 File Offset: 0x00193020
		[ProtoMember(8, IsRequired = false, Name = "SendTime", DataFormat = DataFormat.TwosComplement)]
		[DefaultValue(0L)]
		public long SendTime
		{
			get
			{
				return this._SendTime;
			}
			set
			{
				this._SendTime = value;
			}
		}

		// Token: 0x1700154E RID: 5454
		// (get) Token: 0x06005665 RID: 22117 RVA: 0x00194E2C File Offset: 0x0019302C
		// (set) Token: 0x06005666 RID: 22118 RVA: 0x00194E34 File Offset: 0x00193034
		[DefaultValue("")]
		[ProtoMember(9, IsRequired = false, Name = "ChatGroupId", DataFormat = DataFormat.Default)]
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

		// Token: 0x1700154F RID: 5455
		// (get) Token: 0x06005667 RID: 22119 RVA: 0x00194E40 File Offset: 0x00193040
		// (set) Token: 0x06005668 RID: 22120 RVA: 0x00194E48 File Offset: 0x00193048
		[ProtoMember(10, IsRequired = false, Name = "JustForSelf", DataFormat = DataFormat.Default)]
		[DefaultValue(false)]
		public bool JustForSelf
		{
			get
			{
				return this._JustForSelf;
			}
			set
			{
				this._JustForSelf = value;
			}
		}

		// Token: 0x06005669 RID: 22121 RVA: 0x00194E54 File Offset: 0x00193054
		IExtension IExtensible.GetExtensionObject(bool createIfMissing)
		{
			return Extensible.GetExtensionObject(ref this.extensionObject, createIfMissing);
		}

		// Token: 0x0600566A RID: 22122 RVA: 0x00194E64 File Offset: 0x00193064
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

		// Token: 0x0600566B RID: 22123 RVA: 0x00194F30 File Offset: 0x00193130
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatMessageNtf));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040040E0 RID: 16608
		private int _ChannelId;

		// Token: 0x040040E1 RID: 16609
		private ProChatInfo _ChatInfo;

		// Token: 0x040040E2 RID: 16610
		private ProChatContentText _Content;

		// Token: 0x040040E3 RID: 16611
		private ProChatContentVoice _VoiceInfo;

		// Token: 0x040040E4 RID: 16612
		private ProChatVoiceSimpleInfo _VoiceSimpleInfo;

		// Token: 0x040040E5 RID: 16613
		private ProChatEnterRoomInfo _EnterRoomInfo;

		// Token: 0x040040E6 RID: 16614
		private string _DestGameUserId = string.Empty;

		// Token: 0x040040E7 RID: 16615
		private long _SendTime;

		// Token: 0x040040E8 RID: 16616
		private string _ChatGroupId = string.Empty;

		// Token: 0x040040E9 RID: 16617
		private bool _JustForSelf;

		// Token: 0x040040EA RID: 16618
		private IExtension extensionObject;

		// Token: 0x040040EB RID: 16619
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040040EC RID: 16620
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040040ED RID: 16621
		private LuaFunction m_ctor_hotfix;
	}
}
