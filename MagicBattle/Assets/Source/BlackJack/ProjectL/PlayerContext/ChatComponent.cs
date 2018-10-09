using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000895 RID: 2197
	[HotFix]
	public class ChatComponent : ChatComponentCommon
	{
		// Token: 0x06006DE5 RID: 28133 RVA: 0x001EABB0 File Offset: 0x001E8DB0
		public ChatComponent()
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

		// Token: 0x06006DE6 RID: 28134 RVA: 0x001EACB8 File Offset: 0x001E8EB8
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.Init();
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			ChatComponent.s_chatRecentLinkManMaxCount = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ChatPrivateChatRecentLinkPlayerCountLimit);
			ChatComponent.s_chatRecentLinkChatGroupCount = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ChatPrivateChatRecentLinkGroupCountLimit);
			ChatComponent.s_chatHistoryRecordTimeLimit = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ChatHistoryRecordStoreTimeLimit);
			ChatComponent.s_chatHistoryRecordCountLimit = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ChatHistoryRecordStoreMessageLengthLimit);
			ChatComponent.s_chatSaveHistoryRecordCountOnClear = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_ChatHistoryRecordSaveMessageLengthOnClear);
		}

		// Token: 0x06006DE7 RID: 28135 RVA: 0x001EAD9C File Offset: 0x001E8F9C
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
			this.m_chatGroupComponent = (base.Owner.GetOwnerComponent("ChatGroup") as ChatGroupComponent);
			this.m_friendComponent = base.Owner.GetOwnerComponent<FriendComponent>();
		}

		// Token: 0x06006DE8 RID: 28136 RVA: 0x001EAE30 File Offset: 0x001E9030
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x06006DE9 RID: 28137 RVA: 0x001EAE98 File Offset: 0x001E9098
		public void DeSerialize(DSChatNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSChatNtf_hotfix != null)
			{
				this.m_DeSerializeDSChatNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_chatDS.InitBannedTime(msg.BannedTime);
			this.m_chatDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
		}

		// Token: 0x06006DEA RID: 28138 RVA: 0x001EAF34 File Offset: 0x001E9134
		public void ReadChatBeforeDate(ChatChannel type, DateTime date)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReadChatBeforeDateChatChannelDateTime_hotfix != null)
			{
				this.m_ReadChatBeforeDateChatChannelDateTime_hotfix.call(new object[]
				{
					this,
					type,
					date
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<ChatComponent.ChatMessageClient> chatMessageList = this.GetChatMessageList(type);
			foreach (ChatComponent.ChatMessageClient chatMessageClient in chatMessageList)
			{
				if (chatMessageClient.ChatMessageInfo.SendTime < date)
				{
					chatMessageClient.isRead = true;
				}
			}
		}

		// Token: 0x06006DEB RID: 28139 RVA: 0x001EB01C File Offset: 0x001E921C
		public override int CanSendChatMessage(int channelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSendChatMessageInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSendChatMessageInt32_hotfix.call(new object[]
				{
					this,
					channelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = base.CanSendChatMessage(channelId);
			if (num == 0)
			{
				if (channelId != 3)
				{
					if (channelId == 4)
					{
						if (string.IsNullOrEmpty(this.m_currPrivateChatPlayerGameUserId))
						{
							return -1415;
						}
					}
				}
				else if (string.IsNullOrEmpty(this.m_currGroupChatGroupId))
				{
					return -1416;
				}
			}
			return num;
		}

		// Token: 0x06006DEC RID: 28140 RVA: 0x001EB0F4 File Offset: 0x001E92F4
		public void NotifyGetPlayerInfo(List<ProUserSummary> userInfoList)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyGetPlayerInfoList`1_hotfix != null)
			{
				this.m_NotifyGetPlayerInfoList`1_hotfix.call(new object[]
				{
					this,
					userInfoList
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (userInfoList != null && userInfoList.Count != 0)
			{
				foreach (ProUserSummary proUserSummary in userInfoList)
				{
					if (proUserSummary != null)
					{
						this.m_recentLinkPlayerInfoDict[proUserSummary.UserId] = proUserSummary.ToUserSummary();
					}
				}
			}
		}

		// Token: 0x06006DED RID: 28141 RVA: 0x001EB1D8 File Offset: 0x001E93D8
		public ChatMessage NotifyChatMessage(ChatMessageNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyChatMessageChatMessageNtf_hotfix != null)
			{
				return (ChatMessage)this.m_NotifyChatMessageChatMessageNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ChatMessage chatMessage = ChatMessageFactory.CreateChatMessageByProtocol(msg);
			ChatComponent.ChatMessageClient chatMessageClient = new ChatComponent.ChatMessageClient(chatMessage);
			if (chatMessageClient.ChatMessageInfo.ChatContentType == ChatContentType.EnterRoomInfo)
			{
				chatMessageClient.isRead = true;
			}
			switch (chatMessage.ChannelId)
			{
			case ChatChannel.World:
				chatMessage = this.NotifyWorldChatMessage(chatMessage);
				this.m_worldChatMsgList.Add(chatMessageClient);
				break;
			case ChatChannel.Sys:
				chatMessage = this.NotifySystemChatMessage(chatMessage as ChatTextMessage);
				this.m_sysChatMsgList.Add(chatMessageClient);
				break;
			case ChatChannel.Team:
				chatMessage = this.NotifyTeamChatMessage(chatMessage);
				this.m_teamChatMsgList.Add(chatMessageClient);
				break;
			case ChatChannel.Group:
				chatMessage = this.NotifyGroupChatMessage(chatMessage);
				this.AddMsgToGroupChatDict(chatMessageClient);
				break;
			case ChatChannel.Private:
				chatMessage = this.NotifyPrivateChatMessage(chatMessage);
				this.AddMsgToPrivateChatDict(chatMessageClient);
				break;
			case ChatChannel.Guild:
				chatMessage = this.NotifyGuildChatMessage(chatMessage);
				this.m_guildChatMsgList.Add(chatMessageClient);
				break;
			}
			return chatMessage;
		}

		// Token: 0x06006DEE RID: 28142 RVA: 0x001EB33C File Offset: 0x001E953C
		public ChatComponent.ChatMessageClient CreateASystemTip(ChatChannel channel, string tips)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateASystemTipChatChannelString_hotfix != null)
			{
				return (ChatComponent.ChatMessageClient)this.m_CreateASystemTipChatChannelString_hotfix.call(new object[]
				{
					this,
					channel,
					tips
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new ChatComponent.ChatMessageClient(new ChatTextMessage
			{
				ChannelId = channel,
				ChatContentType = ChatContentType.Text,
				ChatSrcType = ChatSrcType.ChannelLocalSys,
				Text = tips
			})
			{
				isLocalSystemTip = true,
				isRead = true
			};
		}

		// Token: 0x06006DEF RID: 28143 RVA: 0x001EB400 File Offset: 0x001E9600
		public bool IsHasHistoryRecord4Chat(ChatChannel channel, string id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHasHistoryRecord4ChatChatChannelString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHasHistoryRecord4ChatChatChannelString_hotfix.call(new object[]
				{
					this,
					channel,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (channel != ChatChannel.Private)
			{
				if (channel == ChatChannel.Group)
				{
					if (this.m_groupChatHistoryStateList.ContainsKey(id))
					{
						return true;
					}
				}
			}
			else if (this.m_privateChatHistoryStateList.ContainsKey(id))
			{
				return true;
			}
			return false;
		}

		// Token: 0x06006DF0 RID: 28144 RVA: 0x001EB4D0 File Offset: 0x001E96D0
		public void LoadChatHistoryData(DateTime currTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LoadChatHistoryDataDateTime_hotfix != null)
			{
				this.m_LoadChatHistoryDataDateTime_hotfix.call(new object[]
				{
					this,
					currTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isLoadHistoryRecordSuccess)
			{
				return;
			}
			FileStream fileStream = null;
			try
			{
				this.s_chatDataSavePath = this.GetSaveFileName(this.m_basicInfo.GetUserId());
				this.m_chatDirectoryPath = string.Format("{0}/{1}", Application.temporaryCachePath, this.m_basicInfo.GetUserId());
				if (File.Exists(this.s_chatDataSavePath))
				{
					fileStream = File.OpenRead(this.s_chatDataSavePath);
					this.m_loadChatHistoryMessageCount = 0;
					DateTime t = currTime.AddDays((double)(-(double)ChatComponent.s_chatHistoryRecordTimeLimit));
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					ChatComponent.ChatSaveData chatSaveData = binaryFormatter.Deserialize(fileStream) as ChatComponent.ChatSaveData;
					if (chatSaveData != null && chatSaveData.m_userId == this.m_basicInfo.GetUserId())
					{
						if (chatSaveData.m_recentLinkManIdList != null && chatSaveData.m_recentLinkManIdList.Count != 0)
						{
							this.m_recentPrivateChatPlayerIdList.AddRange(chatSaveData.m_recentLinkManIdList);
						}
						if (chatSaveData.m_recentLinkGroupIdList != null && chatSaveData.m_recentLinkGroupIdList.Count != 0)
						{
							this.m_recentLinkChatGroupIdList.AddRange(chatSaveData.m_recentLinkGroupIdList);
						}
						this.m_guildChatLastReadTime = chatSaveData.m_guildChatLastReadTime;
						int num = 0;
						foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair in chatSaveData.m_privateChatDataDict)
						{
							List<ChatComponent.ChatMessageClient> list = new List<ChatComponent.ChatMessageClient>();
							foreach (ChatComponent.ChatMessageClient chatMessageClient in keyValuePair.Value)
							{
								if (!chatMessageClient.isLocalSystemTip)
								{
									if (!(chatMessageClient.ChatMessageInfo.SendTime < t))
									{
										list.Add(chatMessageClient);
										this.m_loadChatHistoryMessageCount++;
									}
								}
							}
							if (list.Count != 0)
							{
								list.Add(this.CreateASystemTip(ChatChannel.Private, this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_AboveHistoryMessage)));
								this.m_privateChatHistoryStateList.Add(keyValuePair.Key, true);
							}
							this.m_privateChatMsgDict.Add(keyValuePair.Key, list);
							num++;
						}
						num = 0;
						foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair2 in chatSaveData.m_groupChatDataDict)
						{
							List<ChatComponent.ChatMessageClient> list2 = new List<ChatComponent.ChatMessageClient>();
							foreach (ChatComponent.ChatMessageClient chatMessageClient2 in keyValuePair2.Value)
							{
								if (!chatMessageClient2.isLocalSystemTip)
								{
									if (!(chatMessageClient2.ChatMessageInfo.SendTime < t))
									{
										list2.Add(chatMessageClient2);
										this.m_loadChatHistoryMessageCount++;
									}
								}
							}
							if (list2.Count != 0)
							{
								list2.Add(this.CreateASystemTip(ChatChannel.Group, this.m_configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_AboveHistoryMessage)));
								this.m_groupChatHistoryStateList.Add(keyValuePair2.Key, true);
							}
							this.m_groupChatMsgDict.Add(keyValuePair2.Key, list2);
							num++;
						}
						if (this.m_loadChatHistoryMessageCount != 0 && this.m_loadChatHistoryMessageCount >= ChatComponent.s_chatHistoryRecordCountLimit)
						{
							float num2 = ((float)this.m_loadChatHistoryMessageCount - (float)ChatComponent.s_chatSaveHistoryRecordCountOnClear) / (float)this.m_loadChatHistoryMessageCount;
							if (num2 < 0f)
							{
								num2 = 0f;
							}
							if (num2 > 1f)
							{
								num2 = 1f;
							}
							foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair3 in this.m_privateChatMsgDict)
							{
								List<ChatComponent.ChatMessageClient> value = keyValuePair3.Value;
								int count = (int)(num2 * (float)value.Count);
								value.RemoveRange(0, count);
							}
							foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair4 in this.m_groupChatMsgDict)
							{
								List<ChatComponent.ChatMessageClient> value2 = keyValuePair4.Value;
								int count2 = (int)(num2 * (float)value2.Count);
								value2.RemoveRange(0, count2);
							}
							this.m_dataDirtyState = true;
						}
					}
					global::Debug.Log("ChatComponent::File Path: " + this.s_chatDataSavePath);
				}
			}
			catch (Exception ex)
			{
				global::Debug.LogError("ChatComponent::Load ChatData Fail, Error Msg: " + ex.Message);
				try
				{
					if (fileStream != null)
					{
						fileStream.Close();
						fileStream = null;
					}
					File.Delete(this.s_chatDataSavePath);
				}
				catch (Exception ex2)
				{
					global::Debug.LogError("ChatComponent::Load Delete Fail, Error Msg: " + ex2.Message);
				}
				this.m_recentPrivateChatPlayerIdList = new List<string>();
				this.m_recentLinkChatGroupIdList = new List<string>();
				this.m_privateChatMsgDict = new Dictionary<string, List<ChatComponent.ChatMessageClient>>();
				this.m_groupChatMsgDict = new Dictionary<string, List<ChatComponent.ChatMessageClient>>();
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
					fileStream = null;
				}
			}
			this.m_isLoadHistoryRecordSuccess = true;
		}

		// Token: 0x06006DF1 RID: 28145 RVA: 0x001EBB2C File Offset: 0x001E9D2C
		public void SaveChatHistoryData()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SaveChatHistoryData_hotfix != null)
			{
				this.m_SaveChatHistoryData_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			FileStream fileStream = null;
			try
			{
				if (!Directory.Exists(this.m_chatDirectoryPath))
				{
					Directory.CreateDirectory(this.m_chatDirectoryPath);
				}
				FileStream fileStream2 = File.Create(this.s_chatDataSavePath);
				if (fileStream2 != null)
				{
					ChatComponent.ChatSaveData chatSaveData = new ChatComponent.ChatSaveData();
					chatSaveData.m_userId = this.m_basicInfo.GetUserId();
					chatSaveData.m_recentLinkManIdList = this.m_recentPrivateChatPlayerIdList;
					chatSaveData.m_privateChatDataDict = this.m_privateChatMsgDict;
					chatSaveData.m_recentLinkGroupIdList = this.m_recentLinkChatGroupIdList;
					chatSaveData.m_groupChatDataDict = this.m_groupChatMsgDict;
					chatSaveData.m_guildChatLastReadTime = this.m_guildChatLastReadTime;
					foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair in chatSaveData.m_privateChatDataDict)
					{
						foreach (ChatComponent.ChatMessageClient chatMessageClient in keyValuePair.Value)
						{
							chatMessageClient.isRead = true;
							chatMessageClient.isHistoryRecord = true;
						}
					}
					foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair2 in chatSaveData.m_groupChatDataDict)
					{
						foreach (ChatComponent.ChatMessageClient chatMessageClient2 in keyValuePair2.Value)
						{
							chatMessageClient2.isRead = true;
							chatMessageClient2.isHistoryRecord = true;
						}
					}
					BinaryFormatter binaryFormatter = new BinaryFormatter();
					binaryFormatter.Serialize(fileStream2, chatSaveData);
				}
				this.m_dataDirtyState = false;
				global::Debug.Log("ChatComponent::SaveChatData");
			}
			catch (Exception ex)
			{
				global::Debug.LogError("ChatComponent::SaveChatData Fail, Error Msg: " + ex.Message);
			}
			finally
			{
				if (fileStream != null)
				{
					fileStream.Close();
				}
			}
		}

		// Token: 0x06006DF2 RID: 28146 RVA: 0x001EBDFC File Offset: 0x001E9FFC
		public string GetSaveFileName(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSaveFileNameString_hotfix != null)
			{
				return (string)this.m_GetSaveFileNameString_hotfix.call(new object[]
				{
					this,
					userId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Format("{0}/{1}/PrivateChatData.data", Application.temporaryCachePath, userId);
		}

		// Token: 0x06006DF3 RID: 28147 RVA: 0x001EBE88 File Offset: 0x001EA088
		public string GetGroupChatTarget()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGroupChatTarget_hotfix != null)
			{
				return (string)this.m_GetGroupChatTarget_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_chatGroupComponent.GetChatGroupSimpleInfo(this.m_currGroupChatGroupId) == null)
			{
				return string.Empty;
			}
			return this.m_currGroupChatGroupId;
		}

		// Token: 0x06006DF4 RID: 28148 RVA: 0x001EBF18 File Offset: 0x001EA118
		public void SetGroupChatTarget(string newGroupId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGroupChatTargetString_hotfix != null)
			{
				this.m_SetGroupChatTargetString_hotfix.call(new object[]
				{
					this,
					newGroupId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currGroupChatGroupId = newGroupId;
			if (this.m_recentLinkChatGroupIdList.Contains(newGroupId))
			{
				return;
			}
			if (this.m_recentLinkChatGroupIdList.Count >= ChatComponent.s_chatRecentLinkChatGroupCount)
			{
				string key = this.m_recentLinkChatGroupIdList[0];
				this.m_recentLinkChatGroupIdList.RemoveAt(0);
				if (this.m_groupChatMsgDict.ContainsKey(key))
				{
					this.m_groupChatMsgDict.Remove(key);
				}
			}
			this.m_recentLinkChatGroupIdList.Add(newGroupId);
			List<ChatComponent.ChatMessageClient> value = new List<ChatComponent.ChatMessageClient>();
			this.m_groupChatMsgDict.Add(newGroupId, value);
			this.m_dataDirtyState = true;
		}

		// Token: 0x06006DF5 RID: 28149 RVA: 0x001EC014 File Offset: 0x001EA214
		public void SetPrivateChatTarget(string gameUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPrivateChatTargetString_hotfix != null)
			{
				this.m_SetPrivateChatTargetString_hotfix.call(new object[]
				{
					this,
					gameUserId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currPrivateChatPlayerGameUserId = gameUserId;
			if (this.m_recentPrivateChatPlayerIdList.Contains(gameUserId))
			{
				return;
			}
			if (this.m_recentPrivateChatPlayerIdList.Count >= ChatComponent.s_chatRecentLinkManMaxCount)
			{
				string key = this.m_recentPrivateChatPlayerIdList[0];
				this.m_recentPrivateChatPlayerIdList.RemoveAt(0);
				if (this.m_privateChatMsgDict.ContainsKey(key))
				{
					this.m_privateChatMsgDict.Remove(key);
				}
			}
			this.m_recentPrivateChatPlayerIdList.Add(gameUserId);
			List<ChatComponent.ChatMessageClient> value = new List<ChatComponent.ChatMessageClient>();
			this.m_privateChatMsgDict.Add(gameUserId, value);
			this.m_dataDirtyState = true;
		}

		// Token: 0x06006DF6 RID: 28150 RVA: 0x001EC110 File Offset: 0x001EA310
		public UserSummary GetUserInfo(string gameUserId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUserInfoString_hotfix != null)
			{
				return (UserSummary)this.m_GetUserInfoString_hotfix.call(new object[]
				{
					this,
					gameUserId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UserSummary userSummary;
			if (this.m_recentLinkPlayerInfoDict.TryGetValue(gameUserId, out userSummary) && userSummary != null)
			{
				return userSummary;
			}
			return null;
		}

		// Token: 0x06006DF7 RID: 28151 RVA: 0x001EC1A8 File Offset: 0x001EA3A8
		public void AddUserInfo(UserSummary userSummary)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddUserInfoUserSummary_hotfix != null)
			{
				this.m_AddUserInfoUserSummary_hotfix.call(new object[]
				{
					this,
					userSummary
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_recentLinkPlayerInfoDict[userSummary.UserId] = userSummary;
		}

		// Token: 0x06006DF8 RID: 28152 RVA: 0x001EC22C File Offset: 0x001EA42C
		public void NotifyEnterNewRoom(int roomindex)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyEnterNewRoomInt32_hotfix != null)
			{
				this.m_NotifyEnterNewRoomInt32_hotfix.call(new object[]
				{
					this,
					roomindex
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_currRoomIndex = roomindex;
		}

		// Token: 0x06006DF9 RID: 28153 RVA: 0x001EC2A4 File Offset: 0x001EA4A4
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_chatDS.ClientVersion;
		}

		// Token: 0x06006DFA RID: 28154 RVA: 0x001EC31C File Offset: 0x001EA51C
		public List<ChatComponent.ChatMessageClient> GetChatMessageList(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChatMessageListChatChannel_hotfix != null)
			{
				return (List<ChatComponent.ChatMessageClient>)this.m_GetChatMessageListChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			switch (channel)
			{
			case ChatChannel.World:
				return this.m_worldChatMsgList;
			case ChatChannel.Sys:
				return this.m_sysChatMsgList;
			case ChatChannel.Team:
				return this.m_teamChatMsgList;
			case ChatChannel.Group:
			{
				List<ChatComponent.ChatMessageClient> result;
				if (this.m_groupChatMsgDict.TryGetValue(this.m_currGroupChatGroupId, out result))
				{
					return result;
				}
				break;
			}
			case ChatChannel.Private:
			{
				List<ChatComponent.ChatMessageClient> result2;
				if (this.m_privateChatMsgDict.TryGetValue(this.m_currPrivateChatPlayerGameUserId, out result2))
				{
					return result2;
				}
				break;
			}
			case ChatChannel.Guild:
				return this.m_guildChatMsgList;
			}
			return new List<ChatComponent.ChatMessageClient>();
		}

		// Token: 0x06006DFB RID: 28155 RVA: 0x001EC41C File Offset: 0x001EA61C
		public int GetUnReadChatMsgCount4PointPlayerOrGroup(ChatChannel channel, string id)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUnReadChatMsgCount4PointPlayerOrGroupChatChannelString_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetUnReadChatMsgCount4PointPlayerOrGroupChatChannelString_hotfix.call(new object[]
				{
					this,
					channel,
					id
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (channel != ChatChannel.Group)
			{
				if (channel != ChatChannel.Private)
				{
					return 0;
				}
				List<ChatComponent.ChatMessageClient> list;
				if (this.m_privateChatMsgDict.TryGetValue(id, out list))
				{
					return list.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
				}
				return 0;
			}
			else
			{
				List<ChatComponent.ChatMessageClient> list2;
				if (this.m_groupChatMsgDict.TryGetValue(id, out list2))
				{
					return list2.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
				}
				return 0;
			}
		}

		// Token: 0x06006DFC RID: 28156 RVA: 0x001EC538 File Offset: 0x001EA738
		public KeyValuePair<List<string>, List<string>> GetRecentChatTargetList(ChatChannel channel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRecentChatTargetListChatChannel_hotfix != null)
			{
				return (KeyValuePair<List<string>, List<string>>)this.m_GetRecentChatTargetListChatChannel_hotfix.call(new object[]
				{
					this,
					channel
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (channel == ChatChannel.Group)
			{
				List<string> list = new List<string>();
				for (int i = 0; i < this.m_recentLinkChatGroupIdList.Count; i++)
				{
					ChatGroupCompactInfo chatGroupSimpleInfo = this.m_chatGroupComponent.GetChatGroupSimpleInfo(this.m_recentLinkChatGroupIdList[i]);
					if (chatGroupSimpleInfo != null)
					{
						list.Add(chatGroupSimpleInfo.ChatGroupName);
					}
					else
					{
						this.m_groupChatMsgDict.Remove(this.m_recentLinkChatGroupIdList[i]);
						this.m_recentLinkChatGroupIdList.RemoveAt(i);
						i--;
					}
				}
				return new KeyValuePair<List<string>, List<string>>(this.m_recentLinkChatGroupIdList, list);
			}
			if (channel != ChatChannel.Private)
			{
				return new KeyValuePair<List<string>, List<string>>(null, null);
			}
			List<UserSummary> blacklist = this.m_friendComponent.Blacklist;
			List<string> list2 = new List<string>();
			for (int j = 0; j < this.m_recentPrivateChatPlayerIdList.Count; j++)
			{
				bool flag = false;
				foreach (UserSummary userSummary in blacklist)
				{
					if (userSummary.UserId == this.m_recentPrivateChatPlayerIdList[j])
					{
						flag = true;
						this.m_privateChatMsgDict.Remove(this.m_recentPrivateChatPlayerIdList[j]);
						this.m_recentPrivateChatPlayerIdList.RemoveAt(j);
						j--;
						break;
					}
				}
				if (!flag)
				{
					UserSummary userSummary2 = null;
					if (!this.m_recentLinkPlayerInfoDict.TryGetValue(this.m_recentPrivateChatPlayerIdList[j], out userSummary2))
					{
						list2.Add(string.Empty);
					}
					if (userSummary2 != null)
					{
						list2.Add(userSummary2.Name);
					}
				}
			}
			return new KeyValuePair<List<string>, List<string>>(this.m_recentPrivateChatPlayerIdList, list2);
		}

		// Token: 0x06006DFD RID: 28157 RVA: 0x001EC780 File Offset: 0x001EA980
		public int GetAllUnReadChatMsgCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAllUnReadChatMsgCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAllUnReadChatMsgCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			num = this.m_worldChatMsgList.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			num += this.m_sysChatMsgList.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			num += this.m_teamChatMsgList.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair in this.m_groupChatMsgDict)
			{
				num += keyValuePair.Value.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			}
			foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair2 in this.m_privateChatMsgDict)
			{
				num += keyValuePair2.Value.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			}
			return num;
		}

		// Token: 0x06006DFE RID: 28158 RVA: 0x001EC96C File Offset: 0x001EAB6C
		public int GetGroupUnreadChatMsgCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGroupUnreadChatMsgCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGroupUnreadChatMsgCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair in this.m_groupChatMsgDict)
			{
				num += keyValuePair.Value.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			}
			return num;
		}

		// Token: 0x06006DFF RID: 28159 RVA: 0x001ECA54 File Offset: 0x001EAC54
		public int GetAssignGroupUnreadChatMsgCount(string groupID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAssignGroupUnreadChatMsgCountString_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAssignGroupUnreadChatMsgCountString_hotfix.call(new object[]
				{
					this,
					groupID
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (this.m_groupChatMsgDict.ContainsKey(groupID))
			{
				result = this.m_groupChatMsgDict[groupID].FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			}
			return result;
		}

		// Token: 0x06006E00 RID: 28160 RVA: 0x001ECB18 File Offset: 0x001EAD18
		public int GetAssignPrivateUnreadChatMsgCount(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAssignPrivateUnreadChatMsgCountString_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAssignPrivateUnreadChatMsgCountString_hotfix.call(new object[]
				{
					this,
					userID
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			if (this.m_privateChatMsgDict.ContainsKey(userID))
			{
				result = this.m_privateChatMsgDict[userID].FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			}
			return result;
		}

		// Token: 0x06006E01 RID: 28161 RVA: 0x001ECBDC File Offset: 0x001EADDC
		public int GetPrivateUnreadChatMsgCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPrivateUnreadChatMsgCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPrivateUnreadChatMsgCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (KeyValuePair<string, List<ChatComponent.ChatMessageClient>> keyValuePair in this.m_privateChatMsgDict)
			{
				num += keyValuePair.Value.FindAll((ChatComponent.ChatMessageClient msg) => !msg.isRead).Count;
			}
			return num;
		}

		// Token: 0x06006E02 RID: 28162 RVA: 0x001ECCC4 File Offset: 0x001EAEC4
		public int GetGuildUnreadChatMsgCount()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGuildUnreadChatMsgCount_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGuildUnreadChatMsgCount_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_guildChatMsgList.FindAll((ChatComponent.ChatMessageClient item) => !item.isRead).Count;
		}

		// Token: 0x06006E03 RID: 28163 RVA: 0x001ECD64 File Offset: 0x001EAF64
		public void ReadChat(ChatComponent.ChatMessageClient msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ReadChatChatMessageClient_hotfix != null)
			{
				this.m_ReadChatChatMessageClient_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			msg.isRead = true;
		}

		// Token: 0x06006E04 RID: 28164 RVA: 0x001ECDDC File Offset: 0x001EAFDC
		public void SetRecentTeamMsgRead()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRecentTeamMsgRead_hotfix != null)
			{
				this.m_SetRecentTeamMsgRead_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamChatMsgList.Count > 0)
			{
				this.m_teamChatMsgList[this.m_teamChatMsgList.Count - 1].isRead = true;
			}
		}

		// Token: 0x06006E05 RID: 28165 RVA: 0x001ECE6C File Offset: 0x001EB06C
		public void SetGroupChatMsgReadByID(string groupID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetGroupChatMsgReadByIDString_hotfix != null)
			{
				this.m_SetGroupChatMsgReadByIDString_hotfix.call(new object[]
				{
					this,
					groupID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_groupChatMsgDict.ContainsKey(groupID))
			{
				List<ChatComponent.ChatMessageClient> list = this.m_groupChatMsgDict[groupID];
				foreach (ChatComponent.ChatMessageClient chatMessageClient in list)
				{
					chatMessageClient.isRead = true;
				}
			}
		}

		// Token: 0x06006E06 RID: 28166 RVA: 0x001ECF44 File Offset: 0x001EB144
		public void SetPrivateChatMsgReadByID(string userID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetPrivateChatMsgReadByIDString_hotfix != null)
			{
				this.m_SetPrivateChatMsgReadByIDString_hotfix.call(new object[]
				{
					this,
					userID
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_privateChatMsgDict.ContainsKey(userID))
			{
				List<ChatComponent.ChatMessageClient> list = this.m_privateChatMsgDict[userID];
				foreach (ChatComponent.ChatMessageClient chatMessageClient in list)
				{
					chatMessageClient.isRead = true;
				}
			}
		}

		// Token: 0x06006E07 RID: 28167 RVA: 0x001ED01C File Offset: 0x001EB21C
		private void ClearChatMessage4LimitCondition(DateTime currTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearChatMessage4LimitConditionDateTime_hotfix != null)
			{
				this.m_ClearChatMessage4LimitConditionDateTime_hotfix.call(new object[]
				{
					this,
					currTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x06006E08 RID: 28168 RVA: 0x001ED08C File Offset: 0x001EB28C
		private void AddMsgToGroupChatDict(ChatComponent.ChatMessageClient chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMsgToGroupChatDictChatMessageClient_hotfix != null)
			{
				this.m_AddMsgToGroupChatDictChatMessageClient_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string destChatGroupId = chatMessage.ChatMessageInfo.DestChatGroupId;
			if (this.m_recentLinkChatGroupIdList.Contains(destChatGroupId))
			{
				List<ChatComponent.ChatMessageClient> list;
				if (this.m_groupChatMsgDict.TryGetValue(destChatGroupId, out list) && list != null && chatMessage != null)
				{
					list.Add(chatMessage);
				}
			}
			else
			{
				if (this.m_recentLinkChatGroupIdList.Count >= ChatComponent.s_chatRecentLinkChatGroupCount)
				{
					string key = this.m_recentLinkChatGroupIdList[0];
					this.m_recentLinkChatGroupIdList.RemoveAt(0);
					if (this.m_groupChatMsgDict.ContainsKey(key))
					{
						this.m_groupChatMsgDict.Remove(key);
					}
				}
				this.m_recentLinkChatGroupIdList.Add(destChatGroupId);
				List<ChatComponent.ChatMessageClient> list2 = new List<ChatComponent.ChatMessageClient>();
				if (chatMessage != null)
				{
					list2.Add(chatMessage);
				}
				this.m_groupChatMsgDict[destChatGroupId] = list2;
			}
			this.m_dataDirtyState = true;
		}

		// Token: 0x06006E09 RID: 28169 RVA: 0x001ED1C4 File Offset: 0x001EB3C4
		private void AddMsgToPrivateChatDict(ChatComponent.ChatMessageClient chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMsgToPrivateChatDictChatMessageClient_hotfix != null)
			{
				this.m_AddMsgToPrivateChatDictChatMessageClient_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string text = string.Empty;
			if (chatMessage.ChatMessageInfo.SrcGameUserID == this.m_basicInfo.GetUserId())
			{
				text = chatMessage.ChatMessageInfo.DestGameUserId;
			}
			else
			{
				text = chatMessage.ChatMessageInfo.SrcGameUserID;
			}
			if (this.m_recentPrivateChatPlayerIdList.Contains(text))
			{
				List<ChatComponent.ChatMessageClient> list;
				if (this.m_privateChatMsgDict.TryGetValue(text, out list) && list != null && chatMessage != null)
				{
					list.Add(chatMessage);
				}
			}
			else
			{
				if (this.m_recentPrivateChatPlayerIdList.Count >= ChatComponent.s_chatRecentLinkManMaxCount)
				{
					string key = this.m_recentPrivateChatPlayerIdList[0];
					this.m_recentPrivateChatPlayerIdList.RemoveAt(0);
					if (this.m_recentLinkPlayerInfoDict.ContainsKey(key))
					{
						this.m_recentLinkPlayerInfoDict.Remove(key);
					}
					if (this.m_privateChatMsgDict.ContainsKey(key))
					{
						this.m_privateChatMsgDict.Remove(key);
					}
				}
				this.m_recentPrivateChatPlayerIdList.Add(text);
				List<ChatComponent.ChatMessageClient> list2 = new List<ChatComponent.ChatMessageClient>();
				if (chatMessage != null)
				{
					list2.Add(chatMessage);
				}
				this.m_privateChatMsgDict.Add(text, list2);
			}
			this.m_dataDirtyState = true;
		}

		// Token: 0x06006E0A RID: 28170 RVA: 0x001ED350 File Offset: 0x001EB550
		private ChatMessage NotifySystemChatMessage(ChatTextMessage chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifySystemChatMessageChatTextMessage_hotfix != null)
			{
				return (ChatMessage)this.m_NotifySystemChatMessageChatTextMessage_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatMessage.SystemContentTemplateId == this.m_configDataLoader.ConfigableConstId_SystemSelectCardHeroBroadcast)
			{
				chatMessage.Text = this.CombineSystemSelectHeroMessage(this.m_configDataLoader.ConfigableConstId_SystemSelectCardHeroBroadcast, chatMessage.Text);
			}
			else if (chatMessage.SystemContentTemplateId == this.m_configDataLoader.ConfigableConstId_SystemSelectCardEquipmentBroadcast)
			{
				chatMessage.Text = this.CombineSystemSelectEquipmentMessage(this.m_configDataLoader.ConfigableConstId_SystemSelectCardEquipmentBroadcast, chatMessage.Text);
			}
			return chatMessage;
		}

		// Token: 0x06006E0B RID: 28171 RVA: 0x001ED438 File Offset: 0x001EB638
		private string CombineSystemSelectHeroMessage(int contentId, string sourceContent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombineSystemSelectHeroMessageInt32String_hotfix != null)
			{
				return (string)this.m_CombineSystemSelectHeroMessageInt32String_hotfix.call(new object[]
				{
					this,
					contentId,
					sourceContent
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSystemBroadcastInfo configDataSystemBroadcastInfo = this.m_configDataLoader.GetConfigDataSystemBroadcastInfo(contentId);
			string[] array = sourceContent.Split(new char[]
			{
				'|'
			});
			int key = int.Parse(array[1]);
			ConfigDataHeroInfo configDataHeroInfo = this.m_configDataLoader.GetConfigDataHeroInfo(key);
			ConfigDataRankInfo configDataRankInfo = this.m_configDataLoader.GetConfigDataRankInfo(configDataHeroInfo.GetRank(configDataHeroInfo.Star));
			sourceContent = CombineStringTools.BuildParam(new object[]
			{
				array[0],
				configDataRankInfo.Desc,
				configDataHeroInfo.Name
			});
			return CombineStringTools.ReplaceHasParamContent(configDataSystemBroadcastInfo.Content, sourceContent);
		}

		// Token: 0x06006E0C RID: 28172 RVA: 0x001ED544 File Offset: 0x001EB744
		private string CombineSystemSelectEquipmentMessage(int contentId, string sourceContent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CombineSystemSelectEquipmentMessageInt32String_hotfix != null)
			{
				return (string)this.m_CombineSystemSelectEquipmentMessageInt32String_hotfix.call(new object[]
				{
					this,
					contentId,
					sourceContent
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataSystemBroadcastInfo configDataSystemBroadcastInfo = this.m_configDataLoader.GetConfigDataSystemBroadcastInfo(contentId);
			string[] array = sourceContent.Split(new char[]
			{
				'|'
			});
			int key = int.Parse(array[1]);
			ConfigDataEquipmentInfo configDataEquipmentInfo = this.m_configDataLoader.GetConfigDataEquipmentInfo(key);
			ConfigDataRankInfo configDataRankInfo = this.m_configDataLoader.GetConfigDataRankInfo(configDataEquipmentInfo.Rank);
			sourceContent = CombineStringTools.BuildParam(new object[]
			{
				array[0],
				configDataRankInfo.Desc,
				configDataEquipmentInfo.Name
			});
			return CombineStringTools.ReplaceHasParamContent(configDataSystemBroadcastInfo.Content, sourceContent);
		}

		// Token: 0x06006E0D RID: 28173 RVA: 0x001ED64C File Offset: 0x001EB84C
		private ChatMessage NotifyWorldChatMessage(ChatMessage chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyWorldChatMessageChatMessage_hotfix != null)
			{
				return (ChatMessage)this.m_NotifyWorldChatMessageChatMessage_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatMessage.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = chatMessage as ChatTextMessage;
				chatTextMessage.Text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatTextMessage.Text, '*');
			}
			else if (chatMessage.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = chatMessage as ChatVoiceMessage;
				chatVoiceMessage.TranslateText = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatVoiceMessage.TranslateText, '*');
			}
			if (this.m_basicInfo.IsMe(chatMessage.SrcGameUserID))
			{
				this.m_chatDS.LastWorldChannelChatSendTime = chatMessage.SendTime;
			}
			return chatMessage;
		}

		// Token: 0x06006E0E RID: 28174 RVA: 0x001ED758 File Offset: 0x001EB958
		private ChatMessage NotifyTeamChatMessage(ChatMessage chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyTeamChatMessageChatMessage_hotfix != null)
			{
				return (ChatMessage)this.m_NotifyTeamChatMessageChatMessage_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatMessage.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = chatMessage as ChatTextMessage;
				chatTextMessage.Text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatTextMessage.Text, '*');
			}
			else if (chatMessage.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = chatMessage as ChatVoiceMessage;
				chatVoiceMessage.TranslateText = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatVoiceMessage.TranslateText, '*');
			}
			if (this.m_basicInfo.IsMe(chatMessage.SrcGameUserID))
			{
				this.m_chatDS.LastWorldChannelChatSendTime = chatMessage.SendTime;
			}
			return chatMessage;
		}

		// Token: 0x06006E0F RID: 28175 RVA: 0x001ED864 File Offset: 0x001EBA64
		private ChatMessage NotifyGroupChatMessage(ChatMessage chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyGroupChatMessageChatMessage_hotfix != null)
			{
				return (ChatMessage)this.m_NotifyGroupChatMessageChatMessage_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatMessage.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = chatMessage as ChatTextMessage;
				chatTextMessage.Text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatTextMessage.Text, '*');
			}
			else if (chatMessage.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = chatMessage as ChatVoiceMessage;
				chatVoiceMessage.TranslateText = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatVoiceMessage.TranslateText, '*');
			}
			if (this.m_basicInfo.IsMe(chatMessage.SrcGameUserID))
			{
				this.m_chatDS.LastWorldChannelChatSendTime = chatMessage.SendTime;
			}
			return chatMessage;
		}

		// Token: 0x06006E10 RID: 28176 RVA: 0x001ED970 File Offset: 0x001EBB70
		private ChatMessage NotifyPrivateChatMessage(ChatMessage chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyPrivateChatMessageChatMessage_hotfix != null)
			{
				return (ChatMessage)this.m_NotifyPrivateChatMessageChatMessage_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatMessage.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = chatMessage as ChatTextMessage;
				chatTextMessage.Text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatTextMessage.Text, '*');
			}
			else if (chatMessage.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = chatMessage as ChatVoiceMessage;
				chatVoiceMessage.TranslateText = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatVoiceMessage.TranslateText, '*');
			}
			if (this.m_basicInfo.IsMe(chatMessage.SrcGameUserID))
			{
				this.m_chatDS.LastWorldChannelChatSendTime = chatMessage.SendTime;
			}
			return chatMessage;
		}

		// Token: 0x06006E11 RID: 28177 RVA: 0x001EDA7C File Offset: 0x001EBC7C
		private ChatMessage NotifyGuildChatMessage(ChatMessage chatMessage)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyGuildChatMessageChatMessage_hotfix != null)
			{
				return (ChatMessage)this.m_NotifyGuildChatMessageChatMessage_hotfix.call(new object[]
				{
					this,
					chatMessage
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (chatMessage.ChatContentType == ChatContentType.Text)
			{
				ChatTextMessage chatTextMessage = chatMessage as ChatTextMessage;
				chatTextMessage.Text = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatTextMessage.Text, '*');
				if (chatMessage.ChatSrcType == ChatSrcType.ChannelLocalSys)
				{
					string paramContent = this.m_configDataLoader.UtilityGetStringByStringTable((StringTableId)chatTextMessage.SystemContentTemplateId);
					chatTextMessage.Text = CombineStringTools.ReplaceHasParamContent(paramContent, chatTextMessage.Text);
				}
			}
			else if (chatMessage.ChatContentType == ChatContentType.Voice)
			{
				ChatVoiceMessage chatVoiceMessage = chatMessage as ChatVoiceMessage;
				chatVoiceMessage.TranslateText = this.m_configDataLoader.UtilityGetSensitiveWords().ReplaceSensitiveWord(chatVoiceMessage.TranslateText, '*');
			}
			if (this.m_basicInfo.IsMe(chatMessage.SrcGameUserID))
			{
				this.m_chatDS.LastWorldChannelChatSendTime = chatMessage.SendTime;
			}
			return chatMessage;
		}

		// Token: 0x17001B9F RID: 7071
		// (get) Token: 0x06006E12 RID: 28178 RVA: 0x001EDBB8 File Offset: 0x001EBDB8
		public int RoomIndex
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RoomIndex_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_RoomIndex_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_currRoomIndex;
			}
		}

		// Token: 0x17001BA0 RID: 7072
		// (get) Token: 0x06006E13 RID: 28179 RVA: 0x001EDC2C File Offset: 0x001EBE2C
		// (set) Token: 0x06006E14 RID: 28180 RVA: 0x001EDCA0 File Offset: 0x001EBEA0
		public bool DataDirty
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_DataDirty_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_DataDirty_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_dataDirtyState;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_DataDirtyBoolean_hotfix != null)
				{
					this.m_set_DataDirtyBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_dataDirtyState = value;
			}
		}

		// Token: 0x17001BA1 RID: 7073
		// (get) Token: 0x06006E15 RID: 28181 RVA: 0x001EDD18 File Offset: 0x001EBF18
		// (set) Token: 0x06006E16 RID: 28182 RVA: 0x001EDD38 File Offset: 0x001EBF38
		[DoNotToLua]
		public new ChatComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006E17 RID: 28183 RVA: 0x001EDD44 File Offset: 0x001EBF44
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006E18 RID: 28184 RVA: 0x001EDD4C File Offset: 0x001EBF4C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006E19 RID: 28185 RVA: 0x001EDD54 File Offset: 0x001EBF54
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006E1A RID: 28186 RVA: 0x001EDD5C File Offset: 0x001EBF5C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006E1B RID: 28187 RVA: 0x001EDD64 File Offset: 0x001EBF64
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006E1C RID: 28188 RVA: 0x001EDD70 File Offset: 0x001EBF70
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006E1D RID: 28189 RVA: 0x001EDD78 File Offset: 0x001EBF78
		private int __callBase_CanSendChatMessage(int channelId)
		{
			return base.CanSendChatMessage(channelId);
		}

		// Token: 0x06006E1E RID: 28190 RVA: 0x001EDD84 File Offset: 0x001EBF84
		private string __callBase_TruncateChatMessage(string content)
		{
			return base.TruncateChatMessage(content);
		}

		// Token: 0x06006E1F RID: 28191 RVA: 0x001EDD90 File Offset: 0x001EBF90
		private bool __callBase_IsBanned()
		{
			return base.IsBanned();
		}

		// Token: 0x06006E20 RID: 28192 RVA: 0x001EDD98 File Offset: 0x001EBF98
		private void __callBase_Ban(DateTime bannedTime)
		{
			base.Ban(bannedTime);
		}

		// Token: 0x06006E21 RID: 28193 RVA: 0x001EDDA4 File Offset: 0x001EBFA4
		private void __callBase_OnBan()
		{
			base.OnBan();
		}

		// Token: 0x06006E22 RID: 28194 RVA: 0x001EDDAC File Offset: 0x001EBFAC
		private void __callBase_OnUnBan()
		{
			base.OnUnBan();
		}

		// Token: 0x06006E30 RID: 28208 RVA: 0x001EDE54 File Offset: 0x001EC054
		private bool InitHotFix(LuaTable A_1)
		{
			this.m_luaObjHelper = new BJLuaObjHelper();
			this.m_luaObjHelper.InitInCS(this, A_1);
			LuaFunction luaFunction = A_1.RawGet("HotFixObject") as LuaFunction;
			bool result;
			if (luaFunction == null)
			{
				global::Debug.LogError("Can't find HotFixObject Func");
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSChatNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_ReadChatBeforeDateChatChannelDateTime_hotfix = (luaObj.RawGet("ReadChatBeforeDate") as LuaFunction);
					this.m_CanSendChatMessageInt32_hotfix = (luaObj.RawGet("CanSendChatMessage") as LuaFunction);
					this.m_NotifyGetPlayerInfoList`1_hotfix = (luaObj.RawGet("NotifyGetPlayerInfo") as LuaFunction);
					this.m_NotifyChatMessageChatMessageNtf_hotfix = (luaObj.RawGet("NotifyChatMessage") as LuaFunction);
					this.m_CreateASystemTipChatChannelString_hotfix = (luaObj.RawGet("CreateASystemTip") as LuaFunction);
					this.m_IsHasHistoryRecord4ChatChatChannelString_hotfix = (luaObj.RawGet("IsHasHistoryRecord4Chat") as LuaFunction);
					this.m_LoadChatHistoryDataDateTime_hotfix = (luaObj.RawGet("LoadChatHistoryData") as LuaFunction);
					this.m_SaveChatHistoryData_hotfix = (luaObj.RawGet("SaveChatHistoryData") as LuaFunction);
					this.m_GetSaveFileNameString_hotfix = (luaObj.RawGet("GetSaveFileName") as LuaFunction);
					this.m_GetGroupChatTarget_hotfix = (luaObj.RawGet("GetGroupChatTarget") as LuaFunction);
					this.m_SetGroupChatTargetString_hotfix = (luaObj.RawGet("SetGroupChatTarget") as LuaFunction);
					this.m_SetPrivateChatTargetString_hotfix = (luaObj.RawGet("SetPrivateChatTarget") as LuaFunction);
					this.m_GetUserInfoString_hotfix = (luaObj.RawGet("GetUserInfo") as LuaFunction);
					this.m_AddUserInfoUserSummary_hotfix = (luaObj.RawGet("AddUserInfo") as LuaFunction);
					this.m_NotifyEnterNewRoomInt32_hotfix = (luaObj.RawGet("NotifyEnterNewRoom") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetChatMessageListChatChannel_hotfix = (luaObj.RawGet("GetChatMessageList") as LuaFunction);
					this.m_GetUnReadChatMsgCount4PointPlayerOrGroupChatChannelString_hotfix = (luaObj.RawGet("GetUnReadChatMsgCount4PointPlayerOrGroup") as LuaFunction);
					this.m_GetRecentChatTargetListChatChannel_hotfix = (luaObj.RawGet("GetRecentChatTargetList") as LuaFunction);
					this.m_GetAllUnReadChatMsgCount_hotfix = (luaObj.RawGet("GetAllUnReadChatMsgCount") as LuaFunction);
					this.m_GetGroupUnreadChatMsgCount_hotfix = (luaObj.RawGet("GetGroupUnreadChatMsgCount") as LuaFunction);
					this.m_GetAssignGroupUnreadChatMsgCountString_hotfix = (luaObj.RawGet("GetAssignGroupUnreadChatMsgCount") as LuaFunction);
					this.m_GetAssignPrivateUnreadChatMsgCountString_hotfix = (luaObj.RawGet("GetAssignPrivateUnreadChatMsgCount") as LuaFunction);
					this.m_GetPrivateUnreadChatMsgCount_hotfix = (luaObj.RawGet("GetPrivateUnreadChatMsgCount") as LuaFunction);
					this.m_GetGuildUnreadChatMsgCount_hotfix = (luaObj.RawGet("GetGuildUnreadChatMsgCount") as LuaFunction);
					this.m_ReadChatChatMessageClient_hotfix = (luaObj.RawGet("ReadChat") as LuaFunction);
					this.m_SetRecentTeamMsgRead_hotfix = (luaObj.RawGet("SetRecentTeamMsgRead") as LuaFunction);
					this.m_SetGroupChatMsgReadByIDString_hotfix = (luaObj.RawGet("SetGroupChatMsgReadByID") as LuaFunction);
					this.m_SetPrivateChatMsgReadByIDString_hotfix = (luaObj.RawGet("SetPrivateChatMsgReadByID") as LuaFunction);
					this.m_ClearChatMessage4LimitConditionDateTime_hotfix = (luaObj.RawGet("ClearChatMessage4LimitCondition") as LuaFunction);
					this.m_AddMsgToGroupChatDictChatMessageClient_hotfix = (luaObj.RawGet("AddMsgToGroupChatDict") as LuaFunction);
					this.m_AddMsgToPrivateChatDictChatMessageClient_hotfix = (luaObj.RawGet("AddMsgToPrivateChatDict") as LuaFunction);
					this.m_NotifySystemChatMessageChatTextMessage_hotfix = (luaObj.RawGet("NotifySystemChatMessage") as LuaFunction);
					this.m_CombineSystemSelectHeroMessageInt32String_hotfix = (luaObj.RawGet("CombineSystemSelectHeroMessage") as LuaFunction);
					this.m_CombineSystemSelectEquipmentMessageInt32String_hotfix = (luaObj.RawGet("CombineSystemSelectEquipmentMessage") as LuaFunction);
					this.m_NotifyWorldChatMessageChatMessage_hotfix = (luaObj.RawGet("NotifyWorldChatMessage") as LuaFunction);
					this.m_NotifyTeamChatMessageChatMessage_hotfix = (luaObj.RawGet("NotifyTeamChatMessage") as LuaFunction);
					this.m_NotifyGroupChatMessageChatMessage_hotfix = (luaObj.RawGet("NotifyGroupChatMessage") as LuaFunction);
					this.m_NotifyPrivateChatMessageChatMessage_hotfix = (luaObj.RawGet("NotifyPrivateChatMessage") as LuaFunction);
					this.m_NotifyGuildChatMessageChatMessage_hotfix = (luaObj.RawGet("NotifyGuildChatMessage") as LuaFunction);
					this.m_get_RoomIndex_hotfix = (luaObj.RawGet("get_RoomIndex") as LuaFunction);
					this.m_get_DataDirty_hotfix = (luaObj.RawGet("get_DataDirty") as LuaFunction);
					this.m_set_DataDirtyBoolean_hotfix = (luaObj.RawGet("set_DataDirty") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006E31 RID: 28209 RVA: 0x001EE3B8 File Offset: 0x001EC5B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040053AF RID: 21423
		public int m_loadChatHistoryMessageCount;

		// Token: 0x040053B0 RID: 21424
		public List<ChatComponent.ChatMessageClient> m_worldChatMsgList = new List<ChatComponent.ChatMessageClient>();

		// Token: 0x040053B1 RID: 21425
		public List<ChatComponent.ChatMessageClient> m_sysChatMsgList = new List<ChatComponent.ChatMessageClient>();

		// Token: 0x040053B2 RID: 21426
		public List<ChatComponent.ChatMessageClient> m_teamChatMsgList = new List<ChatComponent.ChatMessageClient>();

		// Token: 0x040053B3 RID: 21427
		public List<ChatComponent.ChatMessageClient> m_guildChatMsgList = new List<ChatComponent.ChatMessageClient>();

		// Token: 0x040053B4 RID: 21428
		public Dictionary<string, List<ChatComponent.ChatMessageClient>> m_groupChatMsgDict = new Dictionary<string, List<ChatComponent.ChatMessageClient>>();

		// Token: 0x040053B5 RID: 21429
		public List<string> m_recentLinkChatGroupIdList = new List<string>();

		// Token: 0x040053B6 RID: 21430
		public Dictionary<string, List<ChatComponent.ChatMessageClient>> m_privateChatMsgDict = new Dictionary<string, List<ChatComponent.ChatMessageClient>>();

		// Token: 0x040053B7 RID: 21431
		public List<string> m_recentPrivateChatPlayerIdList = new List<string>();

		// Token: 0x040053B8 RID: 21432
		public Dictionary<string, UserSummary> m_recentLinkPlayerInfoDict = new Dictionary<string, UserSummary>();

		// Token: 0x040053B9 RID: 21433
		public Dictionary<string, bool> m_privateChatHistoryStateList = new Dictionary<string, bool>();

		// Token: 0x040053BA RID: 21434
		public Dictionary<string, bool> m_groupChatHistoryStateList = new Dictionary<string, bool>();

		// Token: 0x040053BB RID: 21435
		public string m_currGroupChatGroupId = string.Empty;

		// Token: 0x040053BC RID: 21436
		public string m_currPrivateChatPlayerGameUserId = string.Empty;

		// Token: 0x040053BD RID: 21437
		public ChatGroupComponent m_chatGroupComponent;

		// Token: 0x040053BE RID: 21438
		public FriendComponent m_friendComponent;

		// Token: 0x040053BF RID: 21439
		public DateTime m_guildChatLastReadTime = DateTime.MinValue;

		// Token: 0x040053C0 RID: 21440
		public int m_currRoomIndex = -1;

		// Token: 0x040053C1 RID: 21441
		private bool m_dataDirtyState;

		// Token: 0x040053C2 RID: 21442
		private bool m_isLoadHistoryRecordSuccess;

		// Token: 0x040053C3 RID: 21443
		private string m_chatDirectoryPath;

		// Token: 0x040053C4 RID: 21444
		private string s_chatDataSavePath;

		// Token: 0x040053C5 RID: 21445
		private static int s_chatRecentLinkManMaxCount = 10;

		// Token: 0x040053C6 RID: 21446
		private static int s_chatRecentLinkChatGroupCount = 10;

		// Token: 0x040053C7 RID: 21447
		protected static int s_chatHistoryRecordTimeLimit;

		// Token: 0x040053C8 RID: 21448
		protected static int s_chatHistoryRecordCountLimit;

		// Token: 0x040053C9 RID: 21449
		protected static int s_chatSaveHistoryRecordCountOnClear;

		// Token: 0x040053CA RID: 21450
		[DoNotToLua]
		private ChatComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040053D7 RID: 21463
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040053D8 RID: 21464
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040053D9 RID: 21465
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040053DA RID: 21466
		private LuaFunction m_Init_hotfix;

		// Token: 0x040053DB RID: 21467
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040053DC RID: 21468
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040053DD RID: 21469
		private LuaFunction m_DeSerializeDSChatNtf_hotfix;

		// Token: 0x040053DE RID: 21470
		private LuaFunction m_ReadChatBeforeDateChatChannelDateTime_hotfix;

		// Token: 0x040053DF RID: 21471
		private LuaFunction m_CanSendChatMessageInt32_hotfix;

		// Token: 0x040053E0 RID: 21472
		private LuaFunction m_NotifyGetPlayerInfoList;

		// Token: 0x040053E1 RID: 21473
		private LuaFunction m_NotifyChatMessageChatMessageNtf_hotfix;

		// Token: 0x040053E2 RID: 21474
		private LuaFunction m_CreateASystemTipChatChannelString_hotfix;

		// Token: 0x040053E3 RID: 21475
		private LuaFunction m_IsHasHistoryRecord4ChatChatChannelString_hotfix;

		// Token: 0x040053E4 RID: 21476
		private LuaFunction m_LoadChatHistoryDataDateTime_hotfix;

		// Token: 0x040053E5 RID: 21477
		private LuaFunction m_SaveChatHistoryData_hotfix;

		// Token: 0x040053E6 RID: 21478
		private LuaFunction m_GetSaveFileNameString_hotfix;

		// Token: 0x040053E7 RID: 21479
		private LuaFunction m_GetGroupChatTarget_hotfix;

		// Token: 0x040053E8 RID: 21480
		private LuaFunction m_SetGroupChatTargetString_hotfix;

		// Token: 0x040053E9 RID: 21481
		private LuaFunction m_SetPrivateChatTargetString_hotfix;

		// Token: 0x040053EA RID: 21482
		private LuaFunction m_GetUserInfoString_hotfix;

		// Token: 0x040053EB RID: 21483
		private LuaFunction m_AddUserInfoUserSummary_hotfix;

		// Token: 0x040053EC RID: 21484
		private LuaFunction m_NotifyEnterNewRoomInt32_hotfix;

		// Token: 0x040053ED RID: 21485
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x040053EE RID: 21486
		private LuaFunction m_GetChatMessageListChatChannel_hotfix;

		// Token: 0x040053EF RID: 21487
		private LuaFunction m_GetUnReadChatMsgCount4PointPlayerOrGroupChatChannelString_hotfix;

		// Token: 0x040053F0 RID: 21488
		private LuaFunction m_GetRecentChatTargetListChatChannel_hotfix;

		// Token: 0x040053F1 RID: 21489
		private LuaFunction m_GetAllUnReadChatMsgCount_hotfix;

		// Token: 0x040053F2 RID: 21490
		private LuaFunction m_GetGroupUnreadChatMsgCount_hotfix;

		// Token: 0x040053F3 RID: 21491
		private LuaFunction m_GetAssignGroupUnreadChatMsgCountString_hotfix;

		// Token: 0x040053F4 RID: 21492
		private LuaFunction m_GetAssignPrivateUnreadChatMsgCountString_hotfix;

		// Token: 0x040053F5 RID: 21493
		private LuaFunction m_GetPrivateUnreadChatMsgCount_hotfix;

		// Token: 0x040053F6 RID: 21494
		private LuaFunction m_GetGuildUnreadChatMsgCount_hotfix;

		// Token: 0x040053F7 RID: 21495
		private LuaFunction m_ReadChatChatMessageClient_hotfix;

		// Token: 0x040053F8 RID: 21496
		private LuaFunction m_SetRecentTeamMsgRead_hotfix;

		// Token: 0x040053F9 RID: 21497
		private LuaFunction m_SetGroupChatMsgReadByIDString_hotfix;

		// Token: 0x040053FA RID: 21498
		private LuaFunction m_SetPrivateChatMsgReadByIDString_hotfix;

		// Token: 0x040053FB RID: 21499
		private LuaFunction m_ClearChatMessage4LimitConditionDateTime_hotfix;

		// Token: 0x040053FC RID: 21500
		private LuaFunction m_AddMsgToGroupChatDictChatMessageClient_hotfix;

		// Token: 0x040053FD RID: 21501
		private LuaFunction m_AddMsgToPrivateChatDictChatMessageClient_hotfix;

		// Token: 0x040053FE RID: 21502
		private LuaFunction m_NotifySystemChatMessageChatTextMessage_hotfix;

		// Token: 0x040053FF RID: 21503
		private LuaFunction m_CombineSystemSelectHeroMessageInt32String_hotfix;

		// Token: 0x04005400 RID: 21504
		private LuaFunction m_CombineSystemSelectEquipmentMessageInt32String_hotfix;

		// Token: 0x04005401 RID: 21505
		private LuaFunction m_NotifyWorldChatMessageChatMessage_hotfix;

		// Token: 0x04005402 RID: 21506
		private LuaFunction m_NotifyTeamChatMessageChatMessage_hotfix;

		// Token: 0x04005403 RID: 21507
		private LuaFunction m_NotifyGroupChatMessageChatMessage_hotfix;

		// Token: 0x04005404 RID: 21508
		private LuaFunction m_NotifyPrivateChatMessageChatMessage_hotfix;

		// Token: 0x04005405 RID: 21509
		private LuaFunction m_NotifyGuildChatMessageChatMessage_hotfix;

		// Token: 0x04005406 RID: 21510
		private LuaFunction m_get_RoomIndex_hotfix;

		// Token: 0x04005407 RID: 21511
		private LuaFunction m_get_DataDirty_hotfix;

		// Token: 0x04005408 RID: 21512
		private LuaFunction m_set_DataDirtyBoolean_hotfix;

		// Token: 0x02000896 RID: 2198
		[HotFix]
		[Serializable]
		public class ChatMessageClient
		{
			// Token: 0x06006E32 RID: 28210 RVA: 0x001EE420 File Offset: 0x001EC620
			public ChatMessageClient(ChatMessage msgInfo)
			{
				this.ChatMessageInfo = msgInfo;
				this.isRead = false;
				this.isHistoryRecord = false;
			}

			// Token: 0x04005409 RID: 21513
			public ChatMessage ChatMessageInfo;

			// Token: 0x0400540A RID: 21514
			public bool isRead;

			// Token: 0x0400540B RID: 21515
			public bool isHistoryRecord;

			// Token: 0x0400540C RID: 21516
			public bool isLocalSystemTip;
		}

		// Token: 0x02000897 RID: 2199
		[HotFix]
		[Serializable]
		public class ChatSaveData
		{
			// Token: 0x0400540D RID: 21517
			public string m_userId;

			// Token: 0x0400540E RID: 21518
			public DateTime m_guildChatLastReadTime;

			// Token: 0x0400540F RID: 21519
			public List<string> m_recentLinkManIdList = new List<string>();

			// Token: 0x04005410 RID: 21520
			public List<string> m_recentLinkGroupIdList = new List<string>();

			// Token: 0x04005411 RID: 21521
			public Dictionary<string, List<ChatComponent.ChatMessageClient>> m_privateChatDataDict = new Dictionary<string, List<ChatComponent.ChatMessageClient>>();

			// Token: 0x04005412 RID: 21522
			public Dictionary<string, List<ChatComponent.ChatMessageClient>> m_groupChatDataDict = new Dictionary<string, List<ChatComponent.ChatMessageClient>>();
		}

		// Token: 0x02000898 RID: 2200
		public new class LuaExportHelper
		{
			// Token: 0x06006E34 RID: 28212 RVA: 0x001EE474 File Offset: 0x001EC674
			public LuaExportHelper(ChatComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006E35 RID: 28213 RVA: 0x001EE484 File Offset: 0x001EC684
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006E36 RID: 28214 RVA: 0x001EE494 File Offset: 0x001EC694
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006E37 RID: 28215 RVA: 0x001EE4A4 File Offset: 0x001EC6A4
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006E38 RID: 28216 RVA: 0x001EE4B4 File Offset: 0x001EC6B4
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006E39 RID: 28217 RVA: 0x001EE4C4 File Offset: 0x001EC6C4
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006E3A RID: 28218 RVA: 0x001EE4D4 File Offset: 0x001EC6D4
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006E3B RID: 28219 RVA: 0x001EE4E4 File Offset: 0x001EC6E4
			public int __callBase_CanSendChatMessage(int channelId)
			{
				return this.m_owner.__callBase_CanSendChatMessage(channelId);
			}

			// Token: 0x06006E3C RID: 28220 RVA: 0x001EE4F4 File Offset: 0x001EC6F4
			public string __callBase_TruncateChatMessage(string content)
			{
				return this.m_owner.__callBase_TruncateChatMessage(content);
			}

			// Token: 0x06006E3D RID: 28221 RVA: 0x001EE504 File Offset: 0x001EC704
			public bool __callBase_IsBanned()
			{
				return this.m_owner.__callBase_IsBanned();
			}

			// Token: 0x06006E3E RID: 28222 RVA: 0x001EE514 File Offset: 0x001EC714
			public void __callBase_Ban(DateTime bannedTime)
			{
				this.m_owner.__callBase_Ban(bannedTime);
			}

			// Token: 0x06006E3F RID: 28223 RVA: 0x001EE524 File Offset: 0x001EC724
			public void __callBase_OnBan()
			{
				this.m_owner.__callBase_OnBan();
			}

			// Token: 0x06006E40 RID: 28224 RVA: 0x001EE534 File Offset: 0x001EC734
			public void __callBase_OnUnBan()
			{
				this.m_owner.__callBase_OnUnBan();
			}

			// Token: 0x17001BA2 RID: 7074
			// (get) Token: 0x06006E41 RID: 28225 RVA: 0x001EE544 File Offset: 0x001EC744
			// (set) Token: 0x06006E42 RID: 28226 RVA: 0x001EE554 File Offset: 0x001EC754
			public bool m_dataDirtyState
			{
				get
				{
					return this.m_owner.m_dataDirtyState;
				}
				set
				{
					this.m_owner.m_dataDirtyState = value;
				}
			}

			// Token: 0x17001BA3 RID: 7075
			// (get) Token: 0x06006E43 RID: 28227 RVA: 0x001EE564 File Offset: 0x001EC764
			// (set) Token: 0x06006E44 RID: 28228 RVA: 0x001EE574 File Offset: 0x001EC774
			public bool m_isLoadHistoryRecordSuccess
			{
				get
				{
					return this.m_owner.m_isLoadHistoryRecordSuccess;
				}
				set
				{
					this.m_owner.m_isLoadHistoryRecordSuccess = value;
				}
			}

			// Token: 0x17001BA4 RID: 7076
			// (get) Token: 0x06006E45 RID: 28229 RVA: 0x001EE584 File Offset: 0x001EC784
			// (set) Token: 0x06006E46 RID: 28230 RVA: 0x001EE594 File Offset: 0x001EC794
			public string m_chatDirectoryPath
			{
				get
				{
					return this.m_owner.m_chatDirectoryPath;
				}
				set
				{
					this.m_owner.m_chatDirectoryPath = value;
				}
			}

			// Token: 0x17001BA5 RID: 7077
			// (get) Token: 0x06006E47 RID: 28231 RVA: 0x001EE5A4 File Offset: 0x001EC7A4
			// (set) Token: 0x06006E48 RID: 28232 RVA: 0x001EE5B4 File Offset: 0x001EC7B4
			public string s_chatDataSavePath
			{
				get
				{
					return this.m_owner.s_chatDataSavePath;
				}
				set
				{
					this.m_owner.s_chatDataSavePath = value;
				}
			}

			// Token: 0x17001BA6 RID: 7078
			// (get) Token: 0x06006E49 RID: 28233 RVA: 0x001EE5C4 File Offset: 0x001EC7C4
			// (set) Token: 0x06006E4A RID: 28234 RVA: 0x001EE5CC File Offset: 0x001EC7CC
			public static int s_chatRecentLinkManMaxCount
			{
				get
				{
					return ChatComponent.s_chatRecentLinkManMaxCount;
				}
				set
				{
					ChatComponent.s_chatRecentLinkManMaxCount = value;
				}
			}

			// Token: 0x17001BA7 RID: 7079
			// (get) Token: 0x06006E4B RID: 28235 RVA: 0x001EE5D4 File Offset: 0x001EC7D4
			// (set) Token: 0x06006E4C RID: 28236 RVA: 0x001EE5DC File Offset: 0x001EC7DC
			public static int s_chatRecentLinkChatGroupCount
			{
				get
				{
					return ChatComponent.s_chatRecentLinkChatGroupCount;
				}
				set
				{
					ChatComponent.s_chatRecentLinkChatGroupCount = value;
				}
			}

			// Token: 0x17001BA8 RID: 7080
			// (get) Token: 0x06006E4D RID: 28237 RVA: 0x001EE5E4 File Offset: 0x001EC7E4
			// (set) Token: 0x06006E4E RID: 28238 RVA: 0x001EE5EC File Offset: 0x001EC7EC
			public static int s_chatHistoryRecordTimeLimit
			{
				get
				{
					return ChatComponent.s_chatHistoryRecordTimeLimit;
				}
				set
				{
					ChatComponent.s_chatHistoryRecordTimeLimit = value;
				}
			}

			// Token: 0x17001BA9 RID: 7081
			// (get) Token: 0x06006E4F RID: 28239 RVA: 0x001EE5F4 File Offset: 0x001EC7F4
			// (set) Token: 0x06006E50 RID: 28240 RVA: 0x001EE5FC File Offset: 0x001EC7FC
			public static int s_chatHistoryRecordCountLimit
			{
				get
				{
					return ChatComponent.s_chatHistoryRecordCountLimit;
				}
				set
				{
					ChatComponent.s_chatHistoryRecordCountLimit = value;
				}
			}

			// Token: 0x17001BAA RID: 7082
			// (get) Token: 0x06006E51 RID: 28241 RVA: 0x001EE604 File Offset: 0x001EC804
			// (set) Token: 0x06006E52 RID: 28242 RVA: 0x001EE60C File Offset: 0x001EC80C
			public static int s_chatSaveHistoryRecordCountOnClear
			{
				get
				{
					return ChatComponent.s_chatSaveHistoryRecordCountOnClear;
				}
				set
				{
					ChatComponent.s_chatSaveHistoryRecordCountOnClear = value;
				}
			}

			// Token: 0x06006E53 RID: 28243 RVA: 0x001EE614 File Offset: 0x001EC814
			public void ClearChatMessage4LimitCondition(DateTime currTime)
			{
				this.m_owner.ClearChatMessage4LimitCondition(currTime);
			}

			// Token: 0x06006E54 RID: 28244 RVA: 0x001EE624 File Offset: 0x001EC824
			public void AddMsgToGroupChatDict(ChatComponent.ChatMessageClient chatMessage)
			{
				this.m_owner.AddMsgToGroupChatDict(chatMessage);
			}

			// Token: 0x06006E55 RID: 28245 RVA: 0x001EE634 File Offset: 0x001EC834
			public void AddMsgToPrivateChatDict(ChatComponent.ChatMessageClient chatMessage)
			{
				this.m_owner.AddMsgToPrivateChatDict(chatMessage);
			}

			// Token: 0x06006E56 RID: 28246 RVA: 0x001EE644 File Offset: 0x001EC844
			public ChatMessage NotifySystemChatMessage(ChatTextMessage chatMessage)
			{
				return this.m_owner.NotifySystemChatMessage(chatMessage);
			}

			// Token: 0x06006E57 RID: 28247 RVA: 0x001EE654 File Offset: 0x001EC854
			public string CombineSystemSelectHeroMessage(int contentId, string sourceContent)
			{
				return this.m_owner.CombineSystemSelectHeroMessage(contentId, sourceContent);
			}

			// Token: 0x06006E58 RID: 28248 RVA: 0x001EE664 File Offset: 0x001EC864
			public string CombineSystemSelectEquipmentMessage(int contentId, string sourceContent)
			{
				return this.m_owner.CombineSystemSelectEquipmentMessage(contentId, sourceContent);
			}

			// Token: 0x06006E59 RID: 28249 RVA: 0x001EE674 File Offset: 0x001EC874
			public ChatMessage NotifyWorldChatMessage(ChatMessage chatMessage)
			{
				return this.m_owner.NotifyWorldChatMessage(chatMessage);
			}

			// Token: 0x06006E5A RID: 28250 RVA: 0x001EE684 File Offset: 0x001EC884
			public ChatMessage NotifyTeamChatMessage(ChatMessage chatMessage)
			{
				return this.m_owner.NotifyTeamChatMessage(chatMessage);
			}

			// Token: 0x06006E5B RID: 28251 RVA: 0x001EE694 File Offset: 0x001EC894
			public ChatMessage NotifyGroupChatMessage(ChatMessage chatMessage)
			{
				return this.m_owner.NotifyGroupChatMessage(chatMessage);
			}

			// Token: 0x06006E5C RID: 28252 RVA: 0x001EE6A4 File Offset: 0x001EC8A4
			public ChatMessage NotifyPrivateChatMessage(ChatMessage chatMessage)
			{
				return this.m_owner.NotifyPrivateChatMessage(chatMessage);
			}

			// Token: 0x06006E5D RID: 28253 RVA: 0x001EE6B4 File Offset: 0x001EC8B4
			public ChatMessage NotifyGuildChatMessage(ChatMessage chatMessage)
			{
				return this.m_owner.NotifyGuildChatMessage(chatMessage);
			}

			// Token: 0x04005413 RID: 21523
			private ChatComponent m_owner;
		}
	}
}
