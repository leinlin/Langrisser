using System;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000528 RID: 1320
	[CustomLuaClass]
	public class ChatMessageFactory
	{
		// Token: 0x06004EC8 RID: 20168 RVA: 0x0017D7F4 File Offset: 0x0017B9F4
		public static ChatMessage CreateChatMessageByProtocol(ChatMessageNtf chatMessage)
		{
			ChatMessage chatMessage2 = null;
			switch (chatMessage.ChatInfo.ChatContentType)
			{
			case 0:
			case 3:
				chatMessage2 = new ChatTextMessage
				{
					Text = chatMessage.Content.Text,
					SystemContentTemplateId = chatMessage.Content.SystemContentTemplateId
				};
				break;
			case 1:
				switch (chatMessage.ChannelId)
				{
				case 0:
				case 1:
				case 3:
				case 5:
				{
					ChatVoiceMessage chatVoiceMessage = new ChatVoiceMessage();
					if (chatMessage.JustForSelf)
					{
						chatVoiceMessage.InstanceId = 0UL;
						chatVoiceMessage.VoiceData = chatMessage.VoiceInfo.Voice;
						chatVoiceMessage.VoiceLength = chatMessage.VoiceInfo.VoiceLenth;
						chatVoiceMessage.SampleLength = chatMessage.VoiceInfo.AudioSampleLength;
						chatVoiceMessage.AudioFrequency = chatMessage.VoiceInfo.AudioFrequency;
						chatVoiceMessage.TranslateText = chatMessage.VoiceInfo.TranslateText;
						chatVoiceMessage.IsOverdued = false;
					}
					else
					{
						chatVoiceMessage.InstanceId = chatMessage.VoiceSimpleInfo.InstanceId;
						chatVoiceMessage.VoiceLength = chatMessage.VoiceSimpleInfo.VoiceLength;
						chatVoiceMessage.TranslateText = chatMessage.VoiceSimpleInfo.TranslateText;
					}
					chatMessage2 = chatVoiceMessage;
					break;
				}
				case 2:
				case 4:
					chatMessage2 = new ChatVoiceMessage
					{
						InstanceId = 0UL,
						VoiceData = chatMessage.VoiceInfo.Voice,
						VoiceLength = chatMessage.VoiceInfo.VoiceLenth,
						SampleLength = chatMessage.VoiceInfo.AudioSampleLength,
						AudioFrequency = chatMessage.VoiceInfo.AudioFrequency,
						TranslateText = chatMessage.VoiceInfo.TranslateText,
						IsOverdued = false
					};
					break;
				}
				break;
			case 2:
				chatMessage2 = new ChatEnterRoomMessage
				{
					RoomId = chatMessage.EnterRoomInfo.RoomId,
					PlayerCount = chatMessage.EnterRoomInfo.PlayerCount
				};
				break;
			}
			if (chatMessage2 != null)
			{
				chatMessage2.ChannelId = (ChatChannel)chatMessage.ChannelId;
				chatMessage2.ChatSrcType = (ChatSrcType)chatMessage.ChatInfo.ChatSrcType;
				chatMessage2.SrcName = chatMessage.ChatInfo.SrcName;
				chatMessage2.AvatarId = chatMessage.ChatInfo.AvatarId;
				chatMessage2.ChatContentType = (ChatContentType)chatMessage.ChatInfo.ChatContentType;
				chatMessage2.SrcPlayerLevel = chatMessage.ChatInfo.SrcPlayerLevel;
				chatMessage2.SrcGameUserID = chatMessage.ChatInfo.SrcGameUserID;
				chatMessage2.SendTime = new DateTime(chatMessage.SendTime);
				chatMessage2.DestGameUserId = chatMessage.DestGameUserId;
				chatMessage2.DestChatGroupId = chatMessage.ChatGroupId;
			}
			return chatMessage2;
		}
	}
}
