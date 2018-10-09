using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000529 RID: 1321
	[CustomLuaClass]
	[Serializable]
	public class ChatMessage
	{
		// Token: 0x17001334 RID: 4916
		// (get) Token: 0x06004ECA RID: 20170 RVA: 0x0017DAA4 File Offset: 0x0017BCA4
		// (set) Token: 0x06004ECB RID: 20171 RVA: 0x0017DAAC File Offset: 0x0017BCAC
		public ChatChannel ChannelId { get; set; }

		// Token: 0x17001335 RID: 4917
		// (get) Token: 0x06004ECC RID: 20172 RVA: 0x0017DAB8 File Offset: 0x0017BCB8
		// (set) Token: 0x06004ECD RID: 20173 RVA: 0x0017DAC0 File Offset: 0x0017BCC0
		public ChatSrcType ChatSrcType { get; set; }

		// Token: 0x17001336 RID: 4918
		// (get) Token: 0x06004ECE RID: 20174 RVA: 0x0017DACC File Offset: 0x0017BCCC
		// (set) Token: 0x06004ECF RID: 20175 RVA: 0x0017DAD4 File Offset: 0x0017BCD4
		public string SrcName { get; set; }

		// Token: 0x17001337 RID: 4919
		// (get) Token: 0x06004ED0 RID: 20176 RVA: 0x0017DAE0 File Offset: 0x0017BCE0
		// (set) Token: 0x06004ED1 RID: 20177 RVA: 0x0017DAE8 File Offset: 0x0017BCE8
		public int AvatarId { get; set; }

		// Token: 0x17001338 RID: 4920
		// (get) Token: 0x06004ED2 RID: 20178 RVA: 0x0017DAF4 File Offset: 0x0017BCF4
		// (set) Token: 0x06004ED3 RID: 20179 RVA: 0x0017DAFC File Offset: 0x0017BCFC
		public ChatContentType ChatContentType { get; set; }

		// Token: 0x17001339 RID: 4921
		// (get) Token: 0x06004ED4 RID: 20180 RVA: 0x0017DB08 File Offset: 0x0017BD08
		// (set) Token: 0x06004ED5 RID: 20181 RVA: 0x0017DB10 File Offset: 0x0017BD10
		public int SrcPlayerLevel { get; set; }

		// Token: 0x1700133A RID: 4922
		// (get) Token: 0x06004ED6 RID: 20182 RVA: 0x0017DB1C File Offset: 0x0017BD1C
		// (set) Token: 0x06004ED7 RID: 20183 RVA: 0x0017DB24 File Offset: 0x0017BD24
		public string SrcGameUserID { get; set; }

		// Token: 0x1700133B RID: 4923
		// (get) Token: 0x06004ED8 RID: 20184 RVA: 0x0017DB30 File Offset: 0x0017BD30
		// (set) Token: 0x06004ED9 RID: 20185 RVA: 0x0017DB38 File Offset: 0x0017BD38
		public DateTime SendTime { get; set; }

		// Token: 0x1700133C RID: 4924
		// (get) Token: 0x06004EDA RID: 20186 RVA: 0x0017DB44 File Offset: 0x0017BD44
		// (set) Token: 0x06004EDB RID: 20187 RVA: 0x0017DB4C File Offset: 0x0017BD4C
		public string DestGameUserId { get; set; }

		// Token: 0x1700133D RID: 4925
		// (get) Token: 0x06004EDC RID: 20188 RVA: 0x0017DB58 File Offset: 0x0017BD58
		// (set) Token: 0x06004EDD RID: 20189 RVA: 0x0017DB60 File Offset: 0x0017BD60
		public string DestChatGroupId { get; set; }

		// Token: 0x06004EDE RID: 20190 RVA: 0x0017DB6C File Offset: 0x0017BD6C
		public ChatMessageNtf ToPbChatMessage()
		{
			ChatMessageNtf chatMessageNtf = new ChatMessageNtf();
			chatMessageNtf.ChatInfo = new ProChatInfo();
			chatMessageNtf.ChannelId = (int)this.ChannelId;
			chatMessageNtf.ChatInfo.ChatSrcType = (int)this.ChatSrcType;
			chatMessageNtf.ChatInfo.SrcName = this.SrcName;
			chatMessageNtf.ChatInfo.AvatarId = this.AvatarId;
			chatMessageNtf.ChatInfo.ChatContentType = (int)this.ChatContentType;
			chatMessageNtf.ChatInfo.SrcPlayerLevel = this.SrcPlayerLevel;
			chatMessageNtf.ChatInfo.SrcGameUserID = this.SrcGameUserID;
			chatMessageNtf.ChatGroupId = this.DestChatGroupId;
			chatMessageNtf.DestGameUserId = this.DestGameUserId;
			chatMessageNtf.SendTime = this.SendTime.Ticks;
			switch (this.ChatContentType)
			{
			case ChatContentType.Text:
			{
				ChatTextMessage chatTextMessage = this as ChatTextMessage;
				chatMessageNtf.Content = new ProChatContentText();
				chatMessageNtf.Content.Text = chatTextMessage.Text;
				chatMessageNtf.Content.SystemContentTemplateId = chatTextMessage.SystemContentTemplateId;
				break;
			}
			case ChatContentType.Voice:
				switch (this.ChannelId)
				{
				case ChatChannel.World:
				case ChatChannel.Sys:
				case ChatChannel.Group:
				case ChatChannel.Guild:
				{
					ChatVoiceMessage chatVoiceMessage = this as ChatVoiceMessage;
					chatMessageNtf.VoiceSimpleInfo.InstanceId = chatVoiceMessage.InstanceId;
					chatMessageNtf.VoiceSimpleInfo.VoiceLength = chatVoiceMessage.VoiceLength;
					chatMessageNtf.VoiceSimpleInfo.TranslateText = chatVoiceMessage.TranslateText;
					break;
				}
				case ChatChannel.Team:
				case ChatChannel.Private:
				{
					ChatVoiceMessage chatVoiceMessage2 = this as ChatVoiceMessage;
					chatMessageNtf.VoiceInfo.InstanceId = chatVoiceMessage2.InstanceId;
					chatMessageNtf.VoiceInfo.Voice = chatVoiceMessage2.VoiceData;
					chatMessageNtf.VoiceInfo.VoiceLenth = chatVoiceMessage2.VoiceLength;
					chatMessageNtf.VoiceInfo.AudioSampleLength = chatVoiceMessage2.SampleLength;
					chatMessageNtf.VoiceInfo.AudioFrequency = chatVoiceMessage2.AudioFrequency;
					chatMessageNtf.VoiceInfo.TranslateText = chatVoiceMessage2.TranslateText;
					break;
				}
				}
				break;
			case ChatContentType.EnterRoomInfo:
			{
				ChatEnterRoomMessage chatEnterRoomMessage = new ChatEnterRoomMessage();
				chatMessageNtf.EnterRoomInfo.RoomId = chatEnterRoomMessage.RoomId;
				chatMessageNtf.EnterRoomInfo.PlayerCount = chatEnterRoomMessage.PlayerCount;
				break;
			}
			}
			return chatMessageNtf;
		}
	}
}
