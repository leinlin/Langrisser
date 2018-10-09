using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectLBasic;
using PD.SDK;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000BAF RID: 2991
	[HotFix]
	public class CommonUITask : UITask
	{
		// Token: 0x0600CD5B RID: 52571 RVA: 0x00387CDC File Offset: 0x00385EDC
		public CommonUITask(string name) : base(name)
		{
			this.m_state = 0;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					name
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600CD5C RID: 52572 RVA: 0x00387DEC File Offset: 0x00385FEC
		protected override void InitAllUIControllers()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitAllUIControllers_hotfix != null)
			{
				this.m_InitAllUIControllers_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.InitAllUIControllers();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (this.m_commonUIController == null)
			{
				if (this.m_uiCtrlArray.Length > 0)
				{
					this.m_commonUIController = (this.m_uiCtrlArray[0] as CommonUIController);
				}
				if (this.m_commonUIController == null)
				{
					global::Debug.LogError("CommonUIController is null");
					return;
				}
				projectLPlayerContext.EventOnNewMarqueeNtf += this.PlayerContext_OnNewMarqueeNtf;
				projectLPlayerContext.EventOnClientCheatNtf += this.PlayerContext_OnClientCheatNtf;
				projectLPlayerContext.EventOnServerDisconnectNtf += this.PlayerContext_OnServerDisconnectNtf;
				projectLPlayerContext.EventOnGuildUpdateInfo += this.PlayerContext_EventOnGuildUpdateInfo;
				ProjectLPlayerContext projectLPlayerContext2 = projectLPlayerContext;
				if (CommonUITask.<>f__mg$cache0 == null)
				{
					CommonUITask.<>f__mg$cache0 = new Action(LoginUITask.SetLocalPushNotifications);
				}
				projectLPlayerContext2.EventOnResetPushNotification += CommonUITask.<>f__mg$cache0;
				PlayerVoiceHandleThread.Instance.Start();
				VoiceRecordHelper.Instance.InitXFSDKManager(this.m_commonUIController.m_xfWrapper);
				if (LocalConfig.Instance.Data.ScreenRecordOn)
				{
					bool flag = Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.WindowsEditor;
					CommonUIController.Instance.EnableScreenRecordFunction = (flag && LocalConfig.Instance.Data.ScreenRecordOn);
				}
				this.m_commonUIController.InitTouchFx();
				this.m_disconnectedByServerMessageId = StringTableId.StringTableId_DisconnectedByServer;
			}
			PDSDK instance = PDSDK.Instance;
			instance.m_eventOnSDKPromotingPaySuccess = (Action<string>)Delegate.Combine(instance.m_eventOnSDKPromotingPaySuccess, new Action<string>(this.EventOnSDKPromotingPlaySuccess));
			if (PDSDK.Instance.promotingPayGoodsRegisterID != string.Empty)
			{
				this.EventOnSDKPromotingPlaySuccess(PDSDK.Instance.promotingPayGoodsRegisterID);
			}
			DateTime guildChatLastReadTime = projectLPlayerContext.GetGuildChatLastReadTime();
			projectLPlayerContext.ReadChatBeforeDate(ChatChannel.Guild, guildChatLastReadTime);
			this.InitNetReq();
		}

		// Token: 0x0600CD5D RID: 52573 RVA: 0x00388004 File Offset: 0x00386204
		protected override void ClearAllContextAndRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAllContextAndRes_hotfix != null)
			{
				this.m_ClearAllContextAndRes_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.ClearAllContextAndRes();
			if (this.m_commonUIController != null)
			{
				ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
				if (projectLPlayerContext != null)
				{
					projectLPlayerContext.EventOnNewMarqueeNtf -= this.PlayerContext_OnNewMarqueeNtf;
					projectLPlayerContext.EventOnClientCheatNtf -= this.PlayerContext_OnClientCheatNtf;
					projectLPlayerContext.EventOnServerDisconnectNtf -= this.PlayerContext_OnServerDisconnectNtf;
					projectLPlayerContext.EventOnGuildUpdateInfo -= this.PlayerContext_EventOnGuildUpdateInfo;
					ProjectLPlayerContext projectLPlayerContext2 = projectLPlayerContext;
					if (CommonUITask.<>f__mg$cache1 == null)
					{
						CommonUITask.<>f__mg$cache1 = new Action(LoginUITask.SetLocalPushNotifications);
					}
					projectLPlayerContext2.EventOnResetPushNotification -= CommonUITask.<>f__mg$cache1;
				}
				this.m_commonUIController = null;
			}
			PDSDK instance = PDSDK.Instance;
			instance.m_eventOnSDKPromotingPaySuccess = (Action<string>)Delegate.Remove(instance.m_eventOnSDKPromotingPaySuccess, new Action<string>(this.EventOnSDKPromotingPlaySuccess));
		}

		// Token: 0x0600CD5E RID: 52574 RVA: 0x0038812C File Offset: 0x0038632C
		protected override bool OnStart(UIIntent intent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStartUIIntent_hotfix != null)
			{
				return Convert.ToBoolean(this.m_OnStartUIIntent_hotfix.call(new object[]
				{
					this,
					intent
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			CommonUITask.s_instance = this;
			return base.OnStart(intent);
		}

		// Token: 0x0600CD5F RID: 52575 RVA: 0x003881B8 File Offset: 0x003863B8
		protected override void OnStop()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStop_hotfix != null)
			{
				this.m_OnStop_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			PlayerVoiceHandleThread.Instance.Stop();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null && projectLPlayerContext.GetChatComponent().DataDirty)
			{
				projectLPlayerContext.GetChatComponent().SaveChatHistoryData();
			}
			AssetUtility.Instance.ClearAllLruCache();
			this.m_commonUIController.DisposeTouchFx();
			CommonUITask.s_instance = null;
			base.OnStop();
		}

		// Token: 0x0600CD60 RID: 52576 RVA: 0x00388274 File Offset: 0x00386474
		protected override void OnTick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnTick_hotfix != null)
			{
				this.m_OnTick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.OnTick();
			if (this.m_commonUIController == null)
			{
				return;
			}
			this.TickChatVoice();
			this.TickClientHeartBeat();
			this.TickCheckClientVersion();
			UIUtility.CheckLongFrame();
		}

		// Token: 0x0600CD61 RID: 52577 RVA: 0x00388304 File Offset: 0x00386504
		private void InitNetReq()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitNetReq_hotfix != null)
			{
				this.m_InitNetReq_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			string guildId = playerContext.GetGuildId();
			Guild.GuildMemberCountMax = configDataLoader.ConfigableConstId_GuildMemberCountMax;
			if (!string.IsNullOrEmpty(guildId))
			{
				GuildGetReqNetTask guildGetReqNetTask = new GuildGetReqNetTask(guildId);
				guildGetReqNetTask.EventOnStop += delegate(Task task)
				{
					GuildGetReqNetTask guildGetReqNetTask2 = task as GuildGetReqNetTask;
					if (guildGetReqNetTask2.Result == 0)
					{
						Guild guildInfo = guildGetReqNetTask2.GuildInfo;
						GuildMemberCacheObject guildMemberCacheObject = guildInfo.FindMember(playerContext.GetUserId());
						if (guildMemberCacheObject != null)
						{
							GuildTitle title = guildMemberCacheObject.Member.Title;
							if (title == GuildTitle.President || title == GuildTitle.VP)
							{
								GuildJoinApplyGetReqNetTask guildJoinApplyGetReqNetTask = new GuildJoinApplyGetReqNetTask();
								guildJoinApplyGetReqNetTask.EventOnStop += delegate(Task task2)
								{
								};
								guildJoinApplyGetReqNetTask.Start(null);
							}
						}
					}
				};
				guildGetReqNetTask.Start(null);
			}
			else
			{
				GuildJoinInvitationGetReqNetTask guildJoinInvitationGetReqNetTask = new GuildJoinInvitationGetReqNetTask();
				guildJoinInvitationGetReqNetTask.EventOnStop += delegate(Task task2)
				{
				};
				guildJoinInvitationGetReqNetTask.Start(null);
			}
		}

		// Token: 0x0600CD62 RID: 52578 RVA: 0x0038840C File Offset: 0x0038660C
		private void TickCheckClientVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickCheckClientVersion_hotfix != null)
			{
				this.m_TickCheckClientVersion_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Time.unscaledTime > this.m_lastCheckClientVersionTime + 600f && this.m_commonUIController != null)
			{
				this.m_commonUIController.StartCoroutine(LoginUITask.CheckClientVersion());
				this.m_lastCheckClientVersionTime = Time.unscaledTime;
			}
		}

		// Token: 0x0600CD63 RID: 52579 RVA: 0x003884B0 File Offset: 0x003866B0
		private void TickChatVoice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickChatVoice_hotfix != null)
			{
				this.m_TickChatVoice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			VoiceRecordHelper.Instance.Tick();
			if (Application.platform == RuntimePlatform.Android || Application.platform == RuntimePlatform.IPhonePlayer || Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
			{
				if (VoiceRecordHelper.Instance.XFRecognizedResultList.Count > 0)
				{
					PlayerVoiceHandleThread.VoicePacket outputBufferData = PlayerVoiceHandleThread.Instance.GetOutputBufferData();
					if (outputBufferData != null)
					{
						string value = VoiceRecordHelper.Instance.XFRecognizedResultList.First.Value;
						VoiceRecordHelper.Instance.XFRecognizedResultList.RemoveFirst();
						if (outputBufferData.m_chatInfo != null)
						{
							string userID = string.Empty;
							ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
							if (outputBufferData.m_chatInfo.m_voiceSendChannel == 4)
							{
								userID = projectLPlayerContext.GetPrivateChatPlayerId();
							}
							else if (outputBufferData.m_chatInfo.m_voiceSendChannel == 3)
							{
								userID = projectLPlayerContext.GetGroupChatId();
							}
							ChatMessageSendNetTask chatMessageSendNetTask = new ChatMessageSendNetTask((ChatChannel)outputBufferData.m_chatInfo.m_voiceSendChannel, outputBufferData.m_chatInfo.m_voiceBytes, (int)outputBufferData.m_chatInfo.m_voiceLength, outputBufferData.m_chatInfo.m_voiceFrequency, outputBufferData.m_chatInfo.m_sampleLength, value, userID);
							chatMessageSendNetTask.Start(null);
						}
					}
				}
			}
			else
			{
				PlayerVoiceHandleThread.VoicePacket outputBufferData2 = PlayerVoiceHandleThread.Instance.GetOutputBufferData();
				if (outputBufferData2 != null && outputBufferData2.m_chatInfo != null)
				{
					ChatVoiceMessage chatVoiceMessage = new ChatVoiceMessage();
					chatVoiceMessage.VoiceData = outputBufferData2.m_chatInfo.m_voiceBytes;
					chatVoiceMessage.VoiceLength = (int)outputBufferData2.m_chatInfo.m_voiceLength;
					chatVoiceMessage.AudioFrequency = outputBufferData2.m_chatInfo.m_voiceFrequency;
					chatVoiceMessage.SampleLength = outputBufferData2.m_chatInfo.m_sampleLength;
					ProjectLPlayerContext projectLPlayerContext2 = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
					string userID2 = string.Empty;
					if (outputBufferData2.m_chatInfo.m_voiceSendChannel == 4)
					{
						userID2 = projectLPlayerContext2.GetPrivateChatPlayerId();
					}
					else if (outputBufferData2.m_chatInfo.m_voiceSendChannel == 3)
					{
						userID2 = projectLPlayerContext2.GetGroupChatId();
					}
					ChatMessageSendNetTask chatMessageSendNetTask2 = new ChatMessageSendNetTask((ChatChannel)outputBufferData2.m_chatInfo.m_voiceSendChannel, outputBufferData2.m_chatInfo.m_voiceBytes, (int)outputBufferData2.m_chatInfo.m_voiceLength, outputBufferData2.m_chatInfo.m_voiceFrequency, outputBufferData2.m_chatInfo.m_sampleLength, string.Empty, userID2);
					chatMessageSendNetTask2.Start(null);
				}
			}
		}

		// Token: 0x0600CD64 RID: 52580 RVA: 0x00388750 File Offset: 0x00386950
		private void TickClientHeartBeat()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickClientHeartBeat_hotfix != null)
			{
				this.m_TickClientHeartBeat_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext == null)
			{
				return;
			}
			if (Time.timeScale > SystemUtility.TimeScale * 1.1f || Time.timeScale < SystemUtility.TimeScale / 1.1f)
			{
				global::Debug.LogError("CommonUITask.TickClientHeartBeat I'm ...");
				Application.Quit();
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			int configableConstId_ClientSendHeartBeatPeriod = configDataLoader.ConfigableConstId_ClientSendHeartBeatPeriod;
			float deltaTime = Time.deltaTime;
			if (configableConstId_ClientSendHeartBeatPeriod > 0 && deltaTime > 0f)
			{
				this.m_sendHeartBeatTime += deltaTime;
				if (this.m_sendHeartBeatTime >= (float)configableConstId_ClientSendHeartBeatPeriod)
				{
					projectLPlayerContext.SendClientHeartBeatNtf();
					this.m_sendHeartBeatTime = 0f;
				}
			}
		}

		// Token: 0x0600CD65 RID: 52581 RVA: 0x00388860 File Offset: 0x00386A60
		public static void TickCheckOnline()
		{
			if (CommonUITask.s_instance != null)
			{
				CommonUITask.s_instance._TickCheckOnline();
			}
		}

		// Token: 0x0600CD66 RID: 52582 RVA: 0x00388878 File Offset: 0x00386A78
		private void _TickCheckOnline()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m__TickCheckOnline_hotfix != null)
			{
				this.m__TickCheckOnline_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (DateTime.Now >= this.m_nextCheckOnlineTime)
			{
				if (UIUtility.FindUITaskWithType(typeof(ReloginUITask)) != null)
				{
					return;
				}
				if (this.m_commonUIController != null && this.m_commonUIController.IsFrameworkNetTaskDisableInput())
				{
					return;
				}
				this.m_nextCheckOnlineTime = DateTime.MaxValue;
				CheckOnlineNetTask checkOnlineNetTask = new CheckOnlineNetTask();
				checkOnlineNetTask.EventOnStop += delegate(Task task)
				{
					CheckOnlineNetTask checkOnlineNetTask2 = task as CheckOnlineNetTask;
					if (checkOnlineNetTask2.IsReloginSuccess)
					{
					}
					ClientConfigDataLoader clientConfigDataLoader = GameManager.Instance.ConfigDataLoader as ClientConfigDataLoader;
					this.m_nextCheckOnlineTime = DateTime.Now.AddSeconds((double)clientConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_Battle_ClientCheckOnlinePeriod));
				};
				checkOnlineNetTask.Start(null);
			}
		}

		// Token: 0x0600CD67 RID: 52583 RVA: 0x00388950 File Offset: 0x00386B50
		protected override void UpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateView_hotfix != null)
			{
				this.m_UpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.IsOpeningUI())
			{
				this.m_commonUIController.ShowLoading(FadeStyle.Black);
				this.m_commonUIController.StartCoroutine(LoginUITask.CheckClientVersion());
			}
		}

		// Token: 0x0600CD68 RID: 52584 RVA: 0x003889D8 File Offset: 0x00386BD8
		protected override bool IsNeedLoadDynamicRes()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsNeedLoadDynamicRes_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsNeedLoadDynamicRes_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (PDSDK.IsIosReview && this.m_state == 1)
			{
				base.CollectPreloadResourceList();
			}
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CD69 RID: 52585 RVA: 0x00388A68 File Offset: 0x00386C68
		protected override void PostUpdateView()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostUpdateView_hotfix != null)
			{
				this.m_PostUpdateView_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_state == 0)
			{
				this.m_state = 1;
				base.StartUpdatePipeLine(null, false, false, true);
			}
			else if (this.m_state == 1 && !this.CheckEnterBattle())
			{
				this.StartWorldUITask();
			}
			base.PostUpdateView();
		}

		// Token: 0x0600CD6A RID: 52586 RVA: 0x00388B10 File Offset: 0x00386D10
		private void PlayerContext_OnNewMarqueeNtf(Marquee marquee)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnNewMarqueeNtfMarquee_hotfix != null)
			{
				this.m_PlayerContext_OnNewMarqueeNtfMarquee_hotfix.call(new object[]
				{
					this,
					marquee
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_commonUIController.ShowNotice(marquee.Content);
		}

		// Token: 0x0600CD6B RID: 52587 RVA: 0x00388B94 File Offset: 0x00386D94
		private void PlayerContext_OnServerDisconnectNtf(int errorCode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnServerDisconnectNtfInt32_hotfix != null)
			{
				this.m_PlayerContext_OnServerDisconnectNtfInt32_hotfix.call(new object[]
				{
					this,
					errorCode
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_commonUIController == null)
			{
				return;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ReloginUITask.Enable = false;
			if (errorCode == -2)
			{
				this.m_disconnectedByServerMessageId = StringTableId.StringTableId_DisconnectedBySameAccountLogin;
			}
			if (errorCode == -3)
			{
				LocalProcessingBattle.Instance.Delete();
				LocalProcessingBattle.ArenaInstance.Delete();
			}
			this.m_commonUIController.ShowDialogBox(configDataLoader.UtilityGetStringByStringTable(this.m_disconnectedByServerMessageId), delegate(DialogBoxResult ret)
			{
				if (GameManager.Instance != null)
				{
					GameManager.Instance.Return2Login(true);
				}
				ReloginUITask.Enable = true;
			}, configDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_DialogBox_Ok), string.Empty);
		}

		// Token: 0x0600CD6C RID: 52588 RVA: 0x00388CA4 File Offset: 0x00386EA4
		private void PlayerContext_OnClientCheatNtf()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_OnClientCheatNtf_hotfix != null)
			{
				this.m_PlayerContext_OnClientCheatNtf_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_disconnectedByServerMessageId = StringTableId.StringTableId_DisconnectedByServerForCheat;
		}

		// Token: 0x0600CD6D RID: 52589 RVA: 0x00388D10 File Offset: 0x00386F10
		private void PlayerContext_EventOnGuildUpdateInfo(GuildLog log)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix != null)
			{
				this.m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix.call(new object[]
				{
					this,
					log
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			string guildLogContent = projectLPlayerContext.GetGuildLogContent(log);
			CommonUIController.Instance.ShowTip(guildLogContent);
			switch (log.ModeId)
			{
			case 20011:
				projectLPlayerContext.GetGuildJoinApplyList().Clear();
				projectLPlayerContext.ResetComponentGuildData();
				break;
			case 20013:
				projectLPlayerContext.GetGuildJoinApplyList().Clear();
				break;
			}
		}

		// Token: 0x0600CD6E RID: 52590 RVA: 0x00388DFC File Offset: 0x00386FFC
		private void EventOnSDKPromotingPlaySuccess(string goodsRegisterID)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EventOnSDKPromotingPlaySuccessString_hotfix != null)
			{
				this.m_EventOnSDKPromotingPlaySuccessString_hotfix.call(new object[]
				{
					this,
					goodsRegisterID2
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string goodsRegisterID = goodsRegisterID2;
			PDSDK.Instance.promotingPayGoodsRegisterID = string.Empty;
			PDSDK.m_eventOnGetProductsListAck = delegate(bool isSuccess)
			{
				PDSDK.m_eventOnGetProductsListAck = null;
				if (!isSuccess)
				{
					return;
				}
				List<PDSDKGood> list = new List<PDSDKGood>();
				if (PDSDK.goodlistjson != null)
				{
					for (int i = 0; i < PDSDK.goodlistjson.Count; i++)
					{
						list.Add(new PDSDKGood
						{
							m_ID = PDSDK.goodlistjson[i]["goods_id"].ToString(),
							m_price = double.Parse(PDSDK.goodlistjson[i]["goods_price"].ToString()),
							m_type = (PDSDKGoodType)int.Parse(PDSDK.goodlistjson[i]["type"].ToString()),
							m_registerID = PDSDK.goodlistjson[i]["goods_register_id"].ToString(),
							m_name = PDSDK.goodlistjson[i]["goods_name"].ToString(),
							m_desc = PDSDK.goodlistjson[i]["goods_describe"].ToString()
						});
					}
				}
				PDSDKGood goods = list.Find((PDSDKGood item) => item.m_registerID == goodsRegisterID);
				IosPromotingPay.SendIosPromotingReq(goods);
			};
			PDSDK.Instance.GetProductsList();
		}

		// Token: 0x170028B2 RID: 10418
		// (get) Token: 0x0600CD6F RID: 52591 RVA: 0x00388EA4 File Offset: 0x003870A4
		protected override UITaskBase.LayerDesc[] LayerDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LayerDescArray_hotfix != null)
				{
					return (UITaskBase.LayerDesc[])this.m_get_LayerDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_layerDescArray;
			}
		}

		// Token: 0x170028B3 RID: 10419
		// (get) Token: 0x0600CD70 RID: 52592 RVA: 0x00388F18 File Offset: 0x00387118
		protected override UITaskBase.UIControllerDesc[] UICtrlDescArray
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UICtrlDescArray_hotfix != null)
				{
					return (UITaskBase.UIControllerDesc[])this.m_get_UICtrlDescArray_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_uiCtrlDescArray;
			}
		}

		// Token: 0x0600CD71 RID: 52593 RVA: 0x00388F8C File Offset: 0x0038718C
		private void StartWorldUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartWorldUITask_hotfix != null)
			{
				this.m_StartWorldUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Utility.LogMemorySize("CommonUITask.StartWorldUITask");
			Shader.WarmupAllShaders();
			this.m_commonUIController.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntent intent = new UIIntent(typeof(WorldUITask).Name, null);
				UIManager.Instance.StartUITask(intent, true, true, new Action(this.WorldUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600CD72 RID: 52594 RVA: 0x00389020 File Offset: 0x00387220
		private void WorldUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_WorldUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_WorldUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_commonUIController.HideFadeOutLoadingFadeIn();
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(WorldUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600CD73 RID: 52595 RVA: 0x003890A8 File Offset: 0x003872A8
		private void StartBattleUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartBattleUITask_hotfix != null)
			{
				this.m_StartBattleUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Shader.WarmupAllShaders();
			this.m_commonUIController.StartShowFadeOutLoadingFadeIn(delegate
			{
				UIIntent intent = new UIIntent(typeof(BattleUITask).Name, null);
				UIManager.Instance.StartUITask(intent, true, true, new Action(this.BattleUITask_OnLoadAllResCompleted));
			}, FadeStyle.Black, -1f, -1f);
		}

		// Token: 0x0600CD74 RID: 52596 RVA: 0x00389130 File Offset: 0x00387330
		private void BattleUITask_OnLoadAllResCompleted()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleUITask_OnLoadAllResCompleted_hotfix != null)
			{
				this.m_BattleUITask_OnLoadAllResCompleted_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			UITaskBase uitaskBase = UIUtility.FindUITaskWithType(typeof(BattleUITask));
			if (uitaskBase != null)
			{
				uitaskBase.ReturnFromRedirectPipLineOnLoadAllResCompleted();
			}
		}

		// Token: 0x0600CD75 RID: 52597 RVA: 0x003891AC File Offset: 0x003873AC
		private bool StartArenaBattleUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleUITask_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartArenaBattleUITask_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ArenaOpponentDefensiveBattleInfo arenaOpponentDefensiveBattleInfo = projectLPlayerContext.GetArenaOpponentDefensiveBattleInfo();
			if (arenaOpponentDefensiveBattleInfo == null)
			{
				global::Debug.LogError("CommonUITask.StartArenaBattleUITask fail, defensiveInfo is null");
				return false;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			ConfigDataArenaBattleInfo configDataArenaBattleInfo = configDataLoader.GetConfigDataArenaBattleInfo(arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.BattleId);
			if (configDataArenaBattleInfo == null)
			{
				global::Debug.LogError("CommonUITask.StartArenaBattleUITask fail, arenaBattleInfo is null, Id:" + arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.BattleId);
				return false;
			}
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = configDataLoader.GetConfigDataArenaDefendRuleInfo(arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.ArenaDefenderRuleId);
			if (configDataArenaDefendRuleInfo == null)
			{
				global::Debug.LogError("CommonUITask.StartArenaBattleUITask fail, defendRuleInfo is null, Id:" + arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.ArenaDefenderRuleId);
				return false;
			}
			projectLPlayerContext.SetCurrentArenaBattle(configDataArenaBattleInfo, configDataArenaDefendRuleInfo, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.PlayerLevel, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.DefenderHeroes, arenaOpponentDefensiveBattleInfo.BattleTeamSnapshot.Techs, false);
			projectLPlayerContext.SetArenaBattleRandomSeed(arenaOpponentDefensiveBattleInfo.BattleRandomSeed);
			this.StartBattleUITask();
			return true;
		}

		// Token: 0x0600CD76 RID: 52598 RVA: 0x00389304 File Offset: 0x00387504
		private bool CheckEnterBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckEnterBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckEnterBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.Log("CommonUITask.CheckEnterBattle");
			ProjectLPlayerContext playerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			LocalConfigData data = LocalConfig.Instance.Data;
			if (!playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_AutoBattle))
			{
				LocalConfig.Instance.ClearAutoBattle();
			}
			if (!playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_FastBattle))
			{
				data.IsFasBattle = false;
			}
			if (!playerContext.IsGameFunctionOpened(GameFunctionType.GameFunctionType_SkipBattleAnimation))
			{
				data.SkipCombatMode = 0;
			}
			if (playerContext.IsInBattleRoom())
			{
				global::Debug.Log("CommonUITask.CheckEnterBattle, IsInBattleRoom");
				CommonUITask.StartBattleRoomGetNetTask(delegate(int result)
				{
					if (result == 0)
					{
						BattleRoom battleRoom = playerContext.GetBattleRoom();
						if (battleRoom.IsRealTimePVPBattleRoomType())
						{
							CommonUITask.StartRealTimePVPGetInfoNetTask(delegate(int result2)
							{
								if (result2 == 0)
								{
									if (this.RebuildBattleRoom())
									{
										playerContext.SetNeedRebuildBattle(true);
										this.StartBattleUITask();
									}
									else
									{
										this.StartWorldUITask();
									}
								}
								else
								{
									this.StartWorldUITask();
								}
							});
						}
						else if (this.RebuildBattleRoom())
						{
							playerContext.SetNeedRebuildBattle(true);
							this.StartBattleUITask();
						}
						else
						{
							this.StartWorldUITask();
						}
					}
					else
					{
						this.StartWorldUITask();
					}
				});
				return true;
			}
			if (playerContext.GetArenaBattleStatus() != ArenaBattleStatus.None)
			{
				global::Debug.Log("CommonUITask.CheckEnterBattle, IsInArenaBattle");
				if (!this.RebuildArenaBattle())
				{
					LocalProcessingBattle.ArenaInstance.Delete();
				}
				CommonUITask.StartArenaPlayerInfoGetNetTask(delegate(int result)
				{
					if (result == 0)
					{
						CommonUITask.StartArenaBattleReconnectNetTask(delegate(int result2)
						{
							if (result2 == 0)
							{
								playerContext.SetNeedRebuildBattle(true);
								if (!this.StartArenaBattleUITask())
								{
									playerContext.SetNeedRebuildBattle(false);
									this.StartArenaBattleCancelNetTaskAndStartWorldUITask();
								}
							}
							else
							{
								this.StartArenaBattleCancelNetTaskAndStartWorldUITask();
							}
						});
					}
					else
					{
						this.StartArenaBattleCancelNetTaskAndStartWorldUITask();
					}
				});
				return true;
			}
			ProcessingBattle processingBattle = playerContext.GetProcessingBattle();
			if (processingBattle.Type == BattleType.None)
			{
				int step = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_FirstBattleUserGuideID);
				if ((!playerContext.IsUserGuideComplete(step) && !LocalConfig.Instance.Data.IsFastEnterGame) || LoginUIController.IsTestFirstBattle)
				{
					int key = configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_FirstBattleID);
					ConfigDataBattleInfo configDataBattleInfo = configDataLoader.GetConfigDataBattleInfo(key);
					if (configDataBattleInfo != null)
					{
						playerContext.Happening.Clear();
						playerContext.Happening.BattleInfo = configDataBattleInfo;
						playerContext.Happening.BattleType = BattleType.Scenario;
						playerContext.SetCurrentBattle(playerContext.Happening.BattleInfo, playerContext.Happening.BattleType);
						this.StartBattleUITask();
						return true;
					}
				}
				return false;
			}
			global::Debug.Log("CommonUITask.CheckEnterBattle, IsInBattle");
			if (this.RebuildBattle())
			{
				playerContext.SetNeedRebuildBattle(true);
				this.StartBattleUITask();
				return true;
			}
			CommonUITask.StartBattleCancelNetTask(null);
			LocalProcessingBattle.Instance.Delete();
			return false;
		}

		// Token: 0x0600CD77 RID: 52599 RVA: 0x00389588 File Offset: 0x00387788
		private bool RebuildBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RebuildBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RebuildBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LocalProcessingBattle.Instance.Load())
			{
				global::Debug.LogError("CommonUITask.RebuildBattle fail, LocalProcessingBattle.Instance.Load fail");
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			ProcessingBattle processingBattle = projectLPlayerContext.GetProcessingBattle();
			LocalProcessingBattleData data = LocalProcessingBattle.Instance.Data;
			if (data.Type != (int)processingBattle.Type)
			{
				global::Debug.LogError("CommonUITask.RebuildBattle fail, Type is wrong:" + data.Type);
				return false;
			}
			if (data.TypeId != processingBattle.TypeId)
			{
				global::Debug.LogError("CommonUITask.RebuildBattle fail, TypeId is wrong:" + data.TypeId);
				return false;
			}
			if (data.RandomSeed != processingBattle.RandomSeed)
			{
				global::Debug.LogError("CommonUITask.RebuildBattle fail, RandomSeed is wrong:" + data.RandomSeed);
				return false;
			}
			if (data.ArmyRandomSeed != processingBattle.ArmyRandomSeed)
			{
				global::Debug.LogError("CommonUITask.RebuildBattle fail, ArmyRandomSeed is wrong:" + data.ArmyRandomSeed);
				return false;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (data.Version != configDataLoader.UtilityGetVersion(VersionInfoId.VersionInfoId_BattleReport))
			{
				global::Debug.LogError("CommonUITask.RebuildArenaBattle fail, Version is wrong:" + data.Version);
				return false;
			}
			if (this.RebuildBattleHappening(processingBattle.Type, processingBattle.TypeId))
			{
				projectLPlayerContext.SetRemainBattleRegretCount(data.RegretCount);
				return true;
			}
			return false;
		}

		// Token: 0x0600CD78 RID: 52600 RVA: 0x0038974C File Offset: 0x0038794C
		private bool RebuildBattleHappening(BattleType battleType, int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RebuildBattleHappeningBattleTypeInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RebuildBattleHappeningBattleTypeInt32_hotfix.call(new object[]
				{
					this,
					battleType,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			Happening happening = projectLPlayerContext.Happening;
			happening.Clear();
			if (battleType == BattleType.WayPoint)
			{
				ConfigDataWaypointInfo configDataWaypointInfo = configDataLoader.GetConfigDataWaypointInfo(levelId);
				if (configDataWaypointInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, WaypointInfo is null, Id:" + levelId);
					return false;
				}
				projectLPlayerContext.UpdateCurrentWaypointEvents();
				ConfigDataEventInfo currentWaypointEventInfo = projectLPlayerContext.GetCurrentWaypointEventInfo(configDataWaypointInfo.ID);
				if (currentWaypointEventInfo == null)
				{
					return false;
				}
				happening.WaypointInfo = configDataWaypointInfo;
				happening.EventInfo = currentWaypointEventInfo;
				happening.InitBattleAndDialog(battleType, currentWaypointEventInfo.m_battleInfo, currentWaypointEventInfo.MonsterLevel, null, currentWaypointEventInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.Scenario)
			{
				ConfigDataScenarioInfo configDataScenarioInfo = configDataLoader.GetConfigDataScenarioInfo(levelId);
				if (configDataScenarioInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, ScenarioInfo is null, Id:" + levelId);
					return false;
				}
				happening.WaypointInfo = configDataScenarioInfo.m_waypointInfo;
				happening.ScenarioInfo = configDataScenarioInfo;
				happening.InitBattleAndDialog(battleType, configDataScenarioInfo.m_battleInfo, configDataScenarioInfo.MonsterLevel, null, configDataScenarioInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.Rift)
			{
				ConfigDataRiftLevelInfo configDataRiftLevelInfo = configDataLoader.GetConfigDataRiftLevelInfo(levelId);
				if (configDataRiftLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, RiftLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.RiftLevelInfo = configDataRiftLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataRiftLevelInfo.m_battleInfo, configDataRiftLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.HeroDungeon)
			{
				ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
				if (configDataHeroDungeonLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, HeroDungeonLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.HeroDungeonLevelInfo = configDataHeroDungeonLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataHeroDungeonLevelInfo.m_battleInfo, configDataHeroDungeonLevelInfo.MonsterLevel, null, configDataHeroDungeonLevelInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.ThearchyTrial)
			{
				ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
				if (configDataThearchyTrialLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, ThearchyTrialLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.ThearchyLevelInfo = configDataThearchyTrialLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataThearchyTrialLevelInfo.m_battleInfo, configDataThearchyTrialLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.AnikiGym)
			{
				ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = configDataLoader.GetConfigDataAnikiLevelInfo(levelId);
				if (configDataAnikiLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, AnikiLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.AnikiLevelInfo = configDataAnikiLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataAnikiLevelInfo.m_battleInfo, configDataAnikiLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.TreasureMap)
			{
				ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = configDataLoader.GetConfigDataTreasureLevelInfo(levelId);
				if (configDataTreasureLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, TreasureLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.TreasureLevelInfo = configDataTreasureLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataTreasureLevelInfo.m_battleInfo, configDataTreasureLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.MemoryCorridor)
			{
				ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
				if (configDataMemoryCorridorLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, MemoryCorridorLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.MemoryCorridorLevelInfo = configDataMemoryCorridorLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataMemoryCorridorLevelInfo.m_battleInfo, configDataMemoryCorridorLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.HeroTrainning)
			{
				ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
				if (configDataHeroTrainningLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, HeroTrainningLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.HeroTrainningLevelInfo = configDataHeroTrainningLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataHeroTrainningLevelInfo.m_battleInfo, configDataHeroTrainningLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.HeroPhantom)
			{
				ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = configDataLoader.GetConfigDataHeroPhantomLevelInfo(levelId);
				if (configDataHeroPhantomLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, HeroPhantomLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.HeroPhantomLevelInfo = configDataHeroPhantomLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataHeroPhantomLevelInfo.m_battleInfo, configDataHeroPhantomLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.CooperateBattle)
			{
				ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = configDataLoader.GetConfigDataCooperateBattleLevelInfo(levelId);
				if (configDataCooperateBattleLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, CooperateBattleLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.CooperateBattleLevelInfo = configDataCooperateBattleLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataCooperateBattleLevelInfo.m_battleInfo, configDataCooperateBattleLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.UnchartedScore_ScoreLevel)
			{
				ConfigDataScoreLevelInfo configDataScoreLevelInfo = configDataLoader.GetConfigDataScoreLevelInfo(levelId);
				if (configDataScoreLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, ScoreLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.ScoreLevelInfo = configDataScoreLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataScoreLevelInfo.BattleInfo, configDataScoreLevelInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.UnchartedScore_ChallengeLevel)
			{
				ConfigDataChallengeLevelInfo configDataChallengeLevelInfo = configDataLoader.GetConfigDataChallengeLevelInfo(levelId);
				if (configDataChallengeLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, ChallengeLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.ChallengeLevelInfo = configDataChallengeLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataChallengeLevelInfo.BattleInfo, configDataChallengeLevelInfo.MonsterLevel, null, configDataChallengeLevelInfo.m_dialogInfoAfter);
			}
			else if (battleType == BattleType.ClimbTower)
			{
				int num = levelId;
				ClimberTowerProcessingBattleParamInterface climberTowerProcessingBattleParamInterface = new ClimberTowerProcessingBattleParamInterface(projectLPlayerContext.GetProcessingBattle());
				levelId = climberTowerProcessingBattleParamInterface.GetLevelId();
				ConfigDataTowerFloorInfo configDataTowerFloorInfo = configDataLoader.GetConfigDataTowerFloorInfo(num);
				if (configDataTowerFloorInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, TowerFloorInfo is null, Id:" + num);
					return false;
				}
				ConfigDataTowerLevelInfo configDataTowerLevelInfo = configDataLoader.GetConfigDataTowerLevelInfo(levelId);
				if (configDataTowerLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, TowerLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.TowerFloorInfo = configDataTowerFloorInfo;
				happening.InitBattleAndDialog(battleType, configDataTowerLevelInfo.BattleInfo, configDataTowerFloorInfo.MonsterLevel, null, null);
			}
			else if (battleType == BattleType.GuildMassiveCombat)
			{
				ConfigDataGuildMassiveCombatLevelInfo configDataGuildMassiveCombatLevelInfo = configDataLoader.GetConfigDataGuildMassiveCombatLevelInfo(levelId);
				if (configDataGuildMassiveCombatLevelInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleHappening fail, GuildMassiveCombatLevelInfo is null, Id:" + levelId);
					return false;
				}
				happening.GuildMassiveCombatLevelInfo = configDataGuildMassiveCombatLevelInfo;
				happening.InitBattleAndDialog(battleType, configDataGuildMassiveCombatLevelInfo.m_battleInfo, configDataGuildMassiveCombatLevelInfo.m_strongholdInfo.EnemyLevel, null, null);
			}
			if (happening.BattleInfo != null)
			{
				happening.Step = HappeningStep.Battle;
				projectLPlayerContext.SetCurrentBattle(happening.BattleInfo, happening.BattleType);
				return true;
			}
			return false;
		}

		// Token: 0x0600CD79 RID: 52601 RVA: 0x00389D8C File Offset: 0x00387F8C
		private bool RebuildArenaBattle()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RebuildArenaBattle_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RebuildArenaBattle_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!LocalProcessingBattle.ArenaInstance.Load())
			{
				global::Debug.LogError("CommonUITask.RebuildArenaBattle fail, LocalProcessingBattle.ArenaInstance.Load fail");
				return false;
			}
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext.GetArenaBattleStatus() != ArenaBattleStatus.Fighting)
			{
				global::Debug.LogError("CommonUITask.RebuildArenaBattle fail, arenaBattleStatus is not Fighting");
				return false;
			}
			LocalProcessingBattleData data = LocalProcessingBattle.ArenaInstance.Data;
			if (data.TypeId != projectLPlayerContext.GetArenaBattleId())
			{
				global::Debug.LogError("CommonUITask.RebuildArenaBattle fail, arenaBattleId is wrong:" + data.TypeId);
				return false;
			}
			if (data.RandomSeed != projectLPlayerContext.GetArenaBattleRandomSeed())
			{
				global::Debug.LogError("CommonUITask.RebuildArenaBattle fail, arenaBattleRandomSeed is wrong:" + data.RandomSeed);
				return false;
			}
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			if (data.Version != configDataLoader.UtilityGetVersion(VersionInfoId.VersionInfoId_BattleReport))
			{
				global::Debug.LogError("CommonUITask.RebuildArenaBattle fail, Version is wrong:" + data.Version);
				return false;
			}
			return true;
		}

		// Token: 0x0600CD7A RID: 52602 RVA: 0x00389EE0 File Offset: 0x003880E0
		private bool RebuildBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RebuildBattleRoom_hotfix != null)
			{
				return Convert.ToBoolean(this.m_RebuildBattleRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			BattleRoom battleRoom = projectLPlayerContext.GetBattleRoom();
			if (battleRoom.IsTeamOrGuildMassiveCombatRoomType())
			{
				GameFunctionType gameFunctionType = battleRoom.GameFunctionType;
				int locationId = battleRoom.LocationId;
				if (gameFunctionType == GameFunctionType.GameFunctionType_ThearchyTrial)
				{
					return this.RebuildBattleHappening(BattleType.ThearchyTrial, locationId);
				}
				if (gameFunctionType == GameFunctionType.GameFunctionType_AnikiGym)
				{
					return this.RebuildBattleHappening(BattleType.AnikiGym, locationId);
				}
				if (gameFunctionType == GameFunctionType.GameFunctionType_MemoryCorridor)
				{
					return this.RebuildBattleHappening(BattleType.MemoryCorridor, locationId);
				}
				if (gameFunctionType == GameFunctionType.GameFunctionType_HeroTrainning)
				{
					return this.RebuildBattleHappening(BattleType.HeroTrainning, locationId);
				}
				if (gameFunctionType == GameFunctionType.GameFunctionType_CooperateBattle)
				{
					return this.RebuildBattleHappening(BattleType.CooperateBattle, locationId);
				}
				if (gameFunctionType == GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
				{
					return this.RebuildBattleHappening(BattleType.UnchartedScore_ScoreLevel, locationId);
				}
				if (gameFunctionType == GameFunctionType.GameFunctionType_GuildMassiveCombat)
				{
					return this.RebuildBattleHappening(BattleType.GuildMassiveCombat, locationId);
				}
			}
			else if (battleRoom.BattleRoomType == BattleRoomType.PVP)
			{
				ConfigDataPVPBattleInfo configDataPVPBattleInfo = configDataLoader.GetConfigDataPVPBattleInfo(battleRoom.BattleId);
				if (configDataPVPBattleInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleRoom fail, PVPBattleInfo is null, Id:" + battleRoom.BattleId);
					return false;
				}
				projectLPlayerContext.SetCurrentPVPBattle(configDataPVPBattleInfo);
				return true;
			}
			else if (battleRoom.IsRealTimePVPBattleRoomType())
			{
				ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = configDataLoader.GetConfigDataRealTimePVPBattleInfo(battleRoom.BattleId);
				if (configDataRealTimePVPBattleInfo == null)
				{
					global::Debug.LogError("CommonUITask.RebuildBattleRoom fail, RealTimePVPBattleInfo is null, Id:" + battleRoom.BattleId);
					return false;
				}
				projectLPlayerContext.SetCurrentRealTimePVPBattle(configDataRealTimePVPBattleInfo);
				return true;
			}
			return false;
		}

		// Token: 0x0600CD7B RID: 52603 RVA: 0x0038A0A4 File Offset: 0x003882A4
		private static void StartBattleCancelNetTask(Action<int> onEnd = null)
		{
			BattleCancelNetTask battleCancelNetTask = new BattleCancelNetTask();
			battleCancelNetTask.EventOnStop += delegate(Task task)
			{
				BattleCancelNetTask battleCancelNetTask2 = task as BattleCancelNetTask;
				if (onEnd != null)
				{
					onEnd(battleCancelNetTask2.Result);
				}
			};
			battleCancelNetTask.Start(null);
		}

		// Token: 0x0600CD7C RID: 52604 RVA: 0x0038A0E0 File Offset: 0x003882E0
		private void StartArenaBattleCancelNetTaskAndStartWorldUITask()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartArenaBattleCancelNetTaskAndStartWorldUITask_hotfix != null)
			{
				this.m_StartArenaBattleCancelNetTaskAndStartWorldUITask_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			LocalProcessingBattle.ArenaInstance.Delete();
			CommonUITask.StartBattleCancelNetTask(delegate(int result)
			{
				this.StartWorldUITask();
			});
		}

		// Token: 0x0600CD7D RID: 52605 RVA: 0x0038A15C File Offset: 0x0038835C
		private static void StartArenaPlayerInfoGetNetTask(Action<int> onEnd = null)
		{
			ArenaPlayerInfoGetNetTask arenaPlayerInfoGetNetTask = new ArenaPlayerInfoGetNetTask();
			arenaPlayerInfoGetNetTask.EventOnStop += delegate(Task task)
			{
				ArenaPlayerInfoGetNetTask arenaPlayerInfoGetNetTask2 = task as ArenaPlayerInfoGetNetTask;
				if (onEnd != null)
				{
					onEnd(arenaPlayerInfoGetNetTask2.Result);
				}
			};
			arenaPlayerInfoGetNetTask.Start(null);
		}

		// Token: 0x0600CD7E RID: 52606 RVA: 0x0038A198 File Offset: 0x00388398
		private static void StartArenaBattleReconnectNetTask(Action<int> onEnd = null)
		{
			ArenaBattleReconnectNetTask arenaBattleReconnectNetTask = new ArenaBattleReconnectNetTask();
			arenaBattleReconnectNetTask.EventOnStop += delegate(Task task)
			{
				ArenaBattleReconnectNetTask arenaBattleReconnectNetTask2 = task as ArenaBattleReconnectNetTask;
				if (onEnd != null)
				{
					onEnd(arenaBattleReconnectNetTask2.Result);
				}
			};
			arenaBattleReconnectNetTask.Start(null);
		}

		// Token: 0x0600CD7F RID: 52607 RVA: 0x0038A1D4 File Offset: 0x003883D4
		private static void StartBattleRoomGetNetTask(Action<int> onEnd = null)
		{
			BattleRoomGetNetTask battleRoomGetNetTask = new BattleRoomGetNetTask();
			battleRoomGetNetTask.EventOnStop += delegate(Task task)
			{
				BattleRoomGetNetTask battleRoomGetNetTask2 = task as BattleRoomGetNetTask;
				if (onEnd != null)
				{
					onEnd(battleRoomGetNetTask2.Result);
				}
			};
			battleRoomGetNetTask.Start(null);
		}

		// Token: 0x0600CD80 RID: 52608 RVA: 0x0038A210 File Offset: 0x00388410
		private static void StartRealTimePVPGetInfoNetTask(Action<int> onEnd = null)
		{
			RealTimePVPGetInfoNetTask realTimePVPGetInfoNetTask = new RealTimePVPGetInfoNetTask();
			realTimePVPGetInfoNetTask.EventOnStop += delegate(Task task)
			{
				RealTimePVPGetInfoNetTask realTimePVPGetInfoNetTask2 = task as RealTimePVPGetInfoNetTask;
				if (onEnd != null)
				{
					onEnd(realTimePVPGetInfoNetTask2.Result);
				}
			};
			realTimePVPGetInfoNetTask.Start(null);
		}

		// Token: 0x170028B4 RID: 10420
		// (get) Token: 0x0600CD81 RID: 52609 RVA: 0x0038A24C File Offset: 0x0038844C
		// (set) Token: 0x0600CD82 RID: 52610 RVA: 0x0038A26C File Offset: 0x0038846C
		[DoNotToLua]
		public new CommonUITask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CommonUITask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600CD83 RID: 52611 RVA: 0x0038A278 File Offset: 0x00388478
		private bool __callBase_OnStart(UIIntent intent)
		{
			return base.OnStart(intent);
		}

		// Token: 0x0600CD84 RID: 52612 RVA: 0x0038A284 File Offset: 0x00388484
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600CD85 RID: 52613 RVA: 0x0038A28C File Offset: 0x0038848C
		private void __callBase_OnPause()
		{
			base.OnPause();
		}

		// Token: 0x0600CD86 RID: 52614 RVA: 0x0038A294 File Offset: 0x00388494
		private bool __callBase_OnResume(UIIntent intent)
		{
			return base.OnResume(intent);
		}

		// Token: 0x0600CD87 RID: 52615 RVA: 0x0038A2A0 File Offset: 0x003884A0
		private bool __callBase_OnNewIntent(UIIntent intent)
		{
			return base.OnNewIntent(intent);
		}

		// Token: 0x0600CD88 RID: 52616 RVA: 0x0038A2AC File Offset: 0x003884AC
		private void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
		{
			base.EnableUIInput(isEnable, isGlobalEnable);
		}

		// Token: 0x0600CD89 RID: 52617 RVA: 0x0038A2B8 File Offset: 0x003884B8
		private bool __callBase_IsNeedLoadDynamicRes()
		{
			return base.IsNeedLoadDynamicRes();
		}

		// Token: 0x0600CD8A RID: 52618 RVA: 0x0038A2C0 File Offset: 0x003884C0
		private List<string> __callBase_CollectAllDynamicResForLoad()
		{
			return base.CollectAllDynamicResForLoad();
		}

		// Token: 0x0600CD8B RID: 52619 RVA: 0x0038A2C8 File Offset: 0x003884C8
		private void __callBase_RegisterPlayerContextEvents()
		{
			base.RegisterPlayerContextEvents();
		}

		// Token: 0x0600CD8C RID: 52620 RVA: 0x0038A2D0 File Offset: 0x003884D0
		private void __callBase_UnregisterPlayerContextEvents()
		{
			base.UnregisterPlayerContextEvents();
		}

		// Token: 0x0600CD8D RID: 52621 RVA: 0x0038A2D8 File Offset: 0x003884D8
		private void __callBase_PostUpdateView()
		{
			base.PostUpdateView();
		}

		// Token: 0x0600CD8E RID: 52622 RVA: 0x0038A2E0 File Offset: 0x003884E0
		private void __callBase_CollectPreloadResourceList()
		{
			base.CollectPreloadResourceList();
		}

		// Token: 0x0600CD8F RID: 52623 RVA: 0x0038A2E8 File Offset: 0x003884E8
		private void __callBase_ClearAssetList()
		{
			base.ClearAssetList();
		}

		// Token: 0x0600CD90 RID: 52624 RVA: 0x0038A2F0 File Offset: 0x003884F0
		private void __callBase_CollectAsset(string assetName)
		{
			base.CollectAsset(assetName);
		}

		// Token: 0x0600CD91 RID: 52625 RVA: 0x0038A2FC File Offset: 0x003884FC
		private void __callBase_CollectSpriteAsset(string assetName)
		{
			base.CollectSpriteAsset(assetName);
		}

		// Token: 0x0600CD92 RID: 52626 RVA: 0x0038A308 File Offset: 0x00388508
		private void __callBase_CollectFxAsset(string assetName)
		{
			base.CollectFxAsset(assetName);
		}

		// Token: 0x0600CD93 RID: 52627 RVA: 0x0038A314 File Offset: 0x00388514
		private void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
		{
			base.StartLoadCustomAssets(onLoadCompleted);
		}

		// Token: 0x0600CD94 RID: 52628 RVA: 0x0038A320 File Offset: 0x00388520
		private bool __callBase_IsLoadingCustomAssets()
		{
			return base.IsLoadingCustomAssets();
		}

		// Token: 0x0600CD95 RID: 52629 RVA: 0x0038A328 File Offset: 0x00388528
		private bool __callBase_IsPipeLineRunning()
		{
			return base.IsPipeLineRunning();
		}

		// Token: 0x0600CD96 RID: 52630 RVA: 0x0038A330 File Offset: 0x00388530
		private bool __callBase_IsOpeningUI()
		{
			return base.IsOpeningUI();
		}

		// Token: 0x0600CD97 RID: 52631 RVA: 0x0038A338 File Offset: 0x00388538
		private UITaskBase __callBase_ReturnPrevUITask()
		{
			return base.ReturnPrevUITask();
		}

		// Token: 0x0600CD98 RID: 52632 RVA: 0x0038A340 File Offset: 0x00388540
		private void __callBase_ClearUnusedDynamicResourceCache()
		{
			base.ClearUnusedDynamicResourceCache();
		}

		// Token: 0x0600CD99 RID: 52633 RVA: 0x0038A348 File Offset: 0x00388548
		private void __callBase_OnMemoryWarning()
		{
			base.OnMemoryWarning();
		}

		// Token: 0x0600CDA0 RID: 52640 RVA: 0x0038A44C File Offset: 0x0038864C
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
					this.m_ctorString_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_InitAllUIControllers_hotfix = (luaObj.RawGet("InitAllUIControllers") as LuaFunction);
					this.m_ClearAllContextAndRes_hotfix = (luaObj.RawGet("ClearAllContextAndRes") as LuaFunction);
					this.m_OnStartUIIntent_hotfix = (luaObj.RawGet("OnStart") as LuaFunction);
					this.m_OnStop_hotfix = (luaObj.RawGet("OnStop") as LuaFunction);
					this.m_OnTick_hotfix = (luaObj.RawGet("OnTick") as LuaFunction);
					this.m_InitNetReq_hotfix = (luaObj.RawGet("InitNetReq") as LuaFunction);
					this.m_TickCheckClientVersion_hotfix = (luaObj.RawGet("TickCheckClientVersion") as LuaFunction);
					this.m_TickChatVoice_hotfix = (luaObj.RawGet("TickChatVoice") as LuaFunction);
					this.m_TickClientHeartBeat_hotfix = (luaObj.RawGet("TickClientHeartBeat") as LuaFunction);
					this.m__TickCheckOnline_hotfix = (luaObj.RawGet("_TickCheckOnline") as LuaFunction);
					this.m_UpdateView_hotfix = (luaObj.RawGet("UpdateView") as LuaFunction);
					this.m_IsNeedLoadDynamicRes_hotfix = (luaObj.RawGet("IsNeedLoadDynamicRes") as LuaFunction);
					this.m_PostUpdateView_hotfix = (luaObj.RawGet("PostUpdateView") as LuaFunction);
					this.m_PlayerContext_OnNewMarqueeNtfMarquee_hotfix = (luaObj.RawGet("PlayerContext_OnNewMarqueeNtf") as LuaFunction);
					this.m_PlayerContext_OnServerDisconnectNtfInt32_hotfix = (luaObj.RawGet("PlayerContext_OnServerDisconnectNtf") as LuaFunction);
					this.m_PlayerContext_OnClientCheatNtf_hotfix = (luaObj.RawGet("PlayerContext_OnClientCheatNtf") as LuaFunction);
					this.m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix = (luaObj.RawGet("PlayerContext_EventOnGuildUpdateInfo") as LuaFunction);
					this.m_EventOnSDKPromotingPlaySuccessString_hotfix = (luaObj.RawGet("EventOnSDKPromotingPlaySuccess") as LuaFunction);
					this.m_get_LayerDescArray_hotfix = (luaObj.RawGet("get_LayerDescArray") as LuaFunction);
					this.m_get_UICtrlDescArray_hotfix = (luaObj.RawGet("get_UICtrlDescArray") as LuaFunction);
					this.m_StartWorldUITask_hotfix = (luaObj.RawGet("StartWorldUITask") as LuaFunction);
					this.m_WorldUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("WorldUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartBattleUITask_hotfix = (luaObj.RawGet("StartBattleUITask") as LuaFunction);
					this.m_BattleUITask_OnLoadAllResCompleted_hotfix = (luaObj.RawGet("BattleUITask_OnLoadAllResCompleted") as LuaFunction);
					this.m_StartArenaBattleUITask_hotfix = (luaObj.RawGet("StartArenaBattleUITask") as LuaFunction);
					this.m_CheckEnterBattle_hotfix = (luaObj.RawGet("CheckEnterBattle") as LuaFunction);
					this.m_RebuildBattle_hotfix = (luaObj.RawGet("RebuildBattle") as LuaFunction);
					this.m_RebuildBattleHappeningBattleTypeInt32_hotfix = (luaObj.RawGet("RebuildBattleHappening") as LuaFunction);
					this.m_RebuildArenaBattle_hotfix = (luaObj.RawGet("RebuildArenaBattle") as LuaFunction);
					this.m_RebuildBattleRoom_hotfix = (luaObj.RawGet("RebuildBattleRoom") as LuaFunction);
					this.m_StartArenaBattleCancelNetTaskAndStartWorldUITask_hotfix = (luaObj.RawGet("StartArenaBattleCancelNetTaskAndStartWorldUITask") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600CDA1 RID: 52641 RVA: 0x0038A820 File Offset: 0x00388A20
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CommonUITask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040080C1 RID: 32961
		private int m_state;

		// Token: 0x040080C2 RID: 32962
		private static CommonUITask s_instance;

		// Token: 0x040080C3 RID: 32963
		private UITaskBase.LayerDesc[] m_layerDescArray = new UITaskBase.LayerDesc[]
		{
			new UITaskBase.LayerDesc
			{
				m_layerName = "CommonUILayer",
				m_layerResPath = "Assets/GameProject/RuntimeAssets/UI/Common_ABS/Prefab/CommonUIPrefab.prefab",
				m_isUILayer = true
			}
		};

		// Token: 0x040080C4 RID: 32964
		private UITaskBase.UIControllerDesc[] m_uiCtrlDescArray = new UITaskBase.UIControllerDesc[]
		{
			new UITaskBase.UIControllerDesc
			{
				m_attachLayerName = "CommonUILayer",
				m_attachPath = "./",
				m_ctrlTypeDNName = new TypeDNName("BlackJack.ProjectL.UI.CommonUIController"),
				m_ctrlName = "CommonUIController"
			}
		};

		// Token: 0x040080C5 RID: 32965
		private CommonUIController m_commonUIController;

		// Token: 0x040080C6 RID: 32966
		private float m_sendHeartBeatTime;

		// Token: 0x040080C7 RID: 32967
		private DateTime m_nextCheckOnlineTime = DateTime.MinValue;

		// Token: 0x040080C8 RID: 32968
		private StringTableId m_disconnectedByServerMessageId = StringTableId.StringTableId_DisconnectedByServer;

		// Token: 0x040080C9 RID: 32969
		private float m_lastCheckClientVersionTime;

		// Token: 0x040080CA RID: 32970
		[DoNotToLua]
		private CommonUITask.LuaExportHelper luaExportHelper;

		// Token: 0x040080CB RID: 32971
		[CompilerGenerated]
		private static Action <>f__mg$cache0;

		// Token: 0x040080CC RID: 32972
		[CompilerGenerated]
		private static Action <>f__mg$cache1;

		// Token: 0x040080CF RID: 32975
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040080D0 RID: 32976
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040080D1 RID: 32977
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x040080D2 RID: 32978
		private LuaFunction m_InitAllUIControllers_hotfix;

		// Token: 0x040080D3 RID: 32979
		private LuaFunction m_ClearAllContextAndRes_hotfix;

		// Token: 0x040080D4 RID: 32980
		private LuaFunction m_OnStartUIIntent_hotfix;

		// Token: 0x040080D5 RID: 32981
		private LuaFunction m_OnStop_hotfix;

		// Token: 0x040080D6 RID: 32982
		private LuaFunction m_OnTick_hotfix;

		// Token: 0x040080D7 RID: 32983
		private LuaFunction m_InitNetReq_hotfix;

		// Token: 0x040080D8 RID: 32984
		private LuaFunction m_TickCheckClientVersion_hotfix;

		// Token: 0x040080D9 RID: 32985
		private LuaFunction m_TickChatVoice_hotfix;

		// Token: 0x040080DA RID: 32986
		private LuaFunction m_TickClientHeartBeat_hotfix;

		// Token: 0x040080DB RID: 32987
		private LuaFunction m__TickCheckOnline_hotfix;

		// Token: 0x040080DC RID: 32988
		private LuaFunction m_UpdateView_hotfix;

		// Token: 0x040080DD RID: 32989
		private LuaFunction m_IsNeedLoadDynamicRes_hotfix;

		// Token: 0x040080DE RID: 32990
		private LuaFunction m_PostUpdateView_hotfix;

		// Token: 0x040080DF RID: 32991
		private LuaFunction m_PlayerContext_OnNewMarqueeNtfMarquee_hotfix;

		// Token: 0x040080E0 RID: 32992
		private LuaFunction m_PlayerContext_OnServerDisconnectNtfInt32_hotfix;

		// Token: 0x040080E1 RID: 32993
		private LuaFunction m_PlayerContext_OnClientCheatNtf_hotfix;

		// Token: 0x040080E2 RID: 32994
		private LuaFunction m_PlayerContext_EventOnGuildUpdateInfoGuildLog_hotfix;

		// Token: 0x040080E3 RID: 32995
		private LuaFunction m_EventOnSDKPromotingPlaySuccessString_hotfix;

		// Token: 0x040080E4 RID: 32996
		private LuaFunction m_get_LayerDescArray_hotfix;

		// Token: 0x040080E5 RID: 32997
		private LuaFunction m_get_UICtrlDescArray_hotfix;

		// Token: 0x040080E6 RID: 32998
		private LuaFunction m_StartWorldUITask_hotfix;

		// Token: 0x040080E7 RID: 32999
		private LuaFunction m_WorldUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x040080E8 RID: 33000
		private LuaFunction m_StartBattleUITask_hotfix;

		// Token: 0x040080E9 RID: 33001
		private LuaFunction m_BattleUITask_OnLoadAllResCompleted_hotfix;

		// Token: 0x040080EA RID: 33002
		private LuaFunction m_StartArenaBattleUITask_hotfix;

		// Token: 0x040080EB RID: 33003
		private LuaFunction m_CheckEnterBattle_hotfix;

		// Token: 0x040080EC RID: 33004
		private LuaFunction m_RebuildBattle_hotfix;

		// Token: 0x040080ED RID: 33005
		private LuaFunction m_RebuildBattleHappeningBattleTypeInt32_hotfix;

		// Token: 0x040080EE RID: 33006
		private LuaFunction m_RebuildArenaBattle_hotfix;

		// Token: 0x040080EF RID: 33007
		private LuaFunction m_RebuildBattleRoom_hotfix;

		// Token: 0x040080F0 RID: 33008
		private LuaFunction m_StartArenaBattleCancelNetTaskAndStartWorldUITask_hotfix;

		// Token: 0x02000BB0 RID: 2992
		public new class LuaExportHelper
		{
			// Token: 0x0600CDA2 RID: 52642 RVA: 0x0038A888 File Offset: 0x00388A88
			public LuaExportHelper(CommonUITask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600CDA3 RID: 52643 RVA: 0x0038A898 File Offset: 0x00388A98
			public bool __callBase_OnStart(UIIntent intent)
			{
				return this.m_owner.__callBase_OnStart(intent);
			}

			// Token: 0x0600CDA4 RID: 52644 RVA: 0x0038A8A8 File Offset: 0x00388AA8
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600CDA5 RID: 52645 RVA: 0x0038A8B8 File Offset: 0x00388AB8
			public void __callBase_OnPause()
			{
				this.m_owner.__callBase_OnPause();
			}

			// Token: 0x0600CDA6 RID: 52646 RVA: 0x0038A8C8 File Offset: 0x00388AC8
			public bool __callBase_OnResume(UIIntent intent)
			{
				return this.m_owner.__callBase_OnResume(intent);
			}

			// Token: 0x0600CDA7 RID: 52647 RVA: 0x0038A8D8 File Offset: 0x00388AD8
			public bool __callBase_OnNewIntent(UIIntent intent)
			{
				return this.m_owner.__callBase_OnNewIntent(intent);
			}

			// Token: 0x0600CDA8 RID: 52648 RVA: 0x0038A8E8 File Offset: 0x00388AE8
			public void __callBase_EnableUIInput(bool isEnable, bool? isGlobalEnable)
			{
				this.m_owner.__callBase_EnableUIInput(isEnable, isGlobalEnable);
			}

			// Token: 0x0600CDA9 RID: 52649 RVA: 0x0038A8F8 File Offset: 0x00388AF8
			public bool __callBase_IsNeedLoadDynamicRes()
			{
				return this.m_owner.__callBase_IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CDAA RID: 52650 RVA: 0x0038A908 File Offset: 0x00388B08
			public List<string> __callBase_CollectAllDynamicResForLoad()
			{
				return this.m_owner.__callBase_CollectAllDynamicResForLoad();
			}

			// Token: 0x0600CDAB RID: 52651 RVA: 0x0038A918 File Offset: 0x00388B18
			public void __callBase_RegisterPlayerContextEvents()
			{
				this.m_owner.__callBase_RegisterPlayerContextEvents();
			}

			// Token: 0x0600CDAC RID: 52652 RVA: 0x0038A928 File Offset: 0x00388B28
			public void __callBase_UnregisterPlayerContextEvents()
			{
				this.m_owner.__callBase_UnregisterPlayerContextEvents();
			}

			// Token: 0x0600CDAD RID: 52653 RVA: 0x0038A938 File Offset: 0x00388B38
			public void __callBase_PostUpdateView()
			{
				this.m_owner.__callBase_PostUpdateView();
			}

			// Token: 0x0600CDAE RID: 52654 RVA: 0x0038A948 File Offset: 0x00388B48
			public void __callBase_CollectPreloadResourceList()
			{
				this.m_owner.__callBase_CollectPreloadResourceList();
			}

			// Token: 0x0600CDAF RID: 52655 RVA: 0x0038A958 File Offset: 0x00388B58
			public void __callBase_ClearAssetList()
			{
				this.m_owner.__callBase_ClearAssetList();
			}

			// Token: 0x0600CDB0 RID: 52656 RVA: 0x0038A968 File Offset: 0x00388B68
			public void __callBase_CollectAsset(string assetName)
			{
				this.m_owner.__callBase_CollectAsset(assetName);
			}

			// Token: 0x0600CDB1 RID: 52657 RVA: 0x0038A978 File Offset: 0x00388B78
			public void __callBase_CollectSpriteAsset(string assetName)
			{
				this.m_owner.__callBase_CollectSpriteAsset(assetName);
			}

			// Token: 0x0600CDB2 RID: 52658 RVA: 0x0038A988 File Offset: 0x00388B88
			public void __callBase_CollectFxAsset(string assetName)
			{
				this.m_owner.__callBase_CollectFxAsset(assetName);
			}

			// Token: 0x0600CDB3 RID: 52659 RVA: 0x0038A998 File Offset: 0x00388B98
			public void __callBase_StartLoadCustomAssets(Action onLoadCompleted)
			{
				this.m_owner.__callBase_StartLoadCustomAssets(onLoadCompleted);
			}

			// Token: 0x0600CDB4 RID: 52660 RVA: 0x0038A9A8 File Offset: 0x00388BA8
			public bool __callBase_IsLoadingCustomAssets()
			{
				return this.m_owner.__callBase_IsLoadingCustomAssets();
			}

			// Token: 0x0600CDB5 RID: 52661 RVA: 0x0038A9B8 File Offset: 0x00388BB8
			public bool __callBase_IsPipeLineRunning()
			{
				return this.m_owner.__callBase_IsPipeLineRunning();
			}

			// Token: 0x0600CDB6 RID: 52662 RVA: 0x0038A9C8 File Offset: 0x00388BC8
			public bool __callBase_IsOpeningUI()
			{
				return this.m_owner.__callBase_IsOpeningUI();
			}

			// Token: 0x0600CDB7 RID: 52663 RVA: 0x0038A9D8 File Offset: 0x00388BD8
			public UITaskBase __callBase_ReturnPrevUITask()
			{
				return this.m_owner.__callBase_ReturnPrevUITask();
			}

			// Token: 0x0600CDB8 RID: 52664 RVA: 0x0038A9E8 File Offset: 0x00388BE8
			public void __callBase_ClearUnusedDynamicResourceCache()
			{
				this.m_owner.__callBase_ClearUnusedDynamicResourceCache();
			}

			// Token: 0x0600CDB9 RID: 52665 RVA: 0x0038A9F8 File Offset: 0x00388BF8
			public void __callBase_OnMemoryWarning()
			{
				this.m_owner.__callBase_OnMemoryWarning();
			}

			// Token: 0x170028B5 RID: 10421
			// (get) Token: 0x0600CDBA RID: 52666 RVA: 0x0038AA08 File Offset: 0x00388C08
			// (set) Token: 0x0600CDBB RID: 52667 RVA: 0x0038AA18 File Offset: 0x00388C18
			public int m_state
			{
				get
				{
					return this.m_owner.m_state;
				}
				set
				{
					this.m_owner.m_state = value;
				}
			}

			// Token: 0x170028B6 RID: 10422
			// (get) Token: 0x0600CDBC RID: 52668 RVA: 0x0038AA28 File Offset: 0x00388C28
			// (set) Token: 0x0600CDBD RID: 52669 RVA: 0x0038AA30 File Offset: 0x00388C30
			public static CommonUITask s_instance
			{
				get
				{
					return CommonUITask.s_instance;
				}
				set
				{
					CommonUITask.s_instance = value;
				}
			}

			// Token: 0x170028B7 RID: 10423
			// (get) Token: 0x0600CDBE RID: 52670 RVA: 0x0038AA38 File Offset: 0x00388C38
			// (set) Token: 0x0600CDBF RID: 52671 RVA: 0x0038AA48 File Offset: 0x00388C48
			public UITaskBase.LayerDesc[] m_layerDescArray
			{
				get
				{
					return this.m_owner.m_layerDescArray;
				}
				set
				{
					this.m_owner.m_layerDescArray = value;
				}
			}

			// Token: 0x170028B8 RID: 10424
			// (get) Token: 0x0600CDC0 RID: 52672 RVA: 0x0038AA58 File Offset: 0x00388C58
			// (set) Token: 0x0600CDC1 RID: 52673 RVA: 0x0038AA68 File Offset: 0x00388C68
			public UITaskBase.UIControllerDesc[] m_uiCtrlDescArray
			{
				get
				{
					return this.m_owner.m_uiCtrlDescArray;
				}
				set
				{
					this.m_owner.m_uiCtrlDescArray = value;
				}
			}

			// Token: 0x170028B9 RID: 10425
			// (get) Token: 0x0600CDC2 RID: 52674 RVA: 0x0038AA78 File Offset: 0x00388C78
			// (set) Token: 0x0600CDC3 RID: 52675 RVA: 0x0038AA88 File Offset: 0x00388C88
			public CommonUIController m_commonUIController
			{
				get
				{
					return this.m_owner.m_commonUIController;
				}
				set
				{
					this.m_owner.m_commonUIController = value;
				}
			}

			// Token: 0x170028BA RID: 10426
			// (get) Token: 0x0600CDC4 RID: 52676 RVA: 0x0038AA98 File Offset: 0x00388C98
			// (set) Token: 0x0600CDC5 RID: 52677 RVA: 0x0038AAA8 File Offset: 0x00388CA8
			public float m_sendHeartBeatTime
			{
				get
				{
					return this.m_owner.m_sendHeartBeatTime;
				}
				set
				{
					this.m_owner.m_sendHeartBeatTime = value;
				}
			}

			// Token: 0x170028BB RID: 10427
			// (get) Token: 0x0600CDC6 RID: 52678 RVA: 0x0038AAB8 File Offset: 0x00388CB8
			// (set) Token: 0x0600CDC7 RID: 52679 RVA: 0x0038AAC8 File Offset: 0x00388CC8
			public DateTime m_nextCheckOnlineTime
			{
				get
				{
					return this.m_owner.m_nextCheckOnlineTime;
				}
				set
				{
					this.m_owner.m_nextCheckOnlineTime = value;
				}
			}

			// Token: 0x170028BC RID: 10428
			// (get) Token: 0x0600CDC8 RID: 52680 RVA: 0x0038AAD8 File Offset: 0x00388CD8
			// (set) Token: 0x0600CDC9 RID: 52681 RVA: 0x0038AAE8 File Offset: 0x00388CE8
			public StringTableId m_disconnectedByServerMessageId
			{
				get
				{
					return this.m_owner.m_disconnectedByServerMessageId;
				}
				set
				{
					this.m_owner.m_disconnectedByServerMessageId = value;
				}
			}

			// Token: 0x170028BD RID: 10429
			// (get) Token: 0x0600CDCA RID: 52682 RVA: 0x0038AAF8 File Offset: 0x00388CF8
			// (set) Token: 0x0600CDCB RID: 52683 RVA: 0x0038AB08 File Offset: 0x00388D08
			public float m_lastCheckClientVersionTime
			{
				get
				{
					return this.m_owner.m_lastCheckClientVersionTime;
				}
				set
				{
					this.m_owner.m_lastCheckClientVersionTime = value;
				}
			}

			// Token: 0x170028BE RID: 10430
			// (get) Token: 0x0600CDCC RID: 52684 RVA: 0x0038AB18 File Offset: 0x00388D18
			public UITaskBase.LayerDesc[] LayerDescArray
			{
				get
				{
					return this.m_owner.LayerDescArray;
				}
			}

			// Token: 0x170028BF RID: 10431
			// (get) Token: 0x0600CDCD RID: 52685 RVA: 0x0038AB28 File Offset: 0x00388D28
			public UITaskBase.UIControllerDesc[] UICtrlDescArray
			{
				get
				{
					return this.m_owner.UICtrlDescArray;
				}
			}

			// Token: 0x0600CDCE RID: 52686 RVA: 0x0038AB38 File Offset: 0x00388D38
			public void InitAllUIControllers()
			{
				this.m_owner.InitAllUIControllers();
			}

			// Token: 0x0600CDCF RID: 52687 RVA: 0x0038AB48 File Offset: 0x00388D48
			public void ClearAllContextAndRes()
			{
				this.m_owner.ClearAllContextAndRes();
			}

			// Token: 0x0600CDD0 RID: 52688 RVA: 0x0038AB58 File Offset: 0x00388D58
			public bool OnStart(UIIntent intent)
			{
				return this.m_owner.OnStart(intent);
			}

			// Token: 0x0600CDD1 RID: 52689 RVA: 0x0038AB68 File Offset: 0x00388D68
			public void OnStop()
			{
				this.m_owner.OnStop();
			}

			// Token: 0x0600CDD2 RID: 52690 RVA: 0x0038AB78 File Offset: 0x00388D78
			public void OnTick()
			{
				this.m_owner.OnTick();
			}

			// Token: 0x0600CDD3 RID: 52691 RVA: 0x0038AB88 File Offset: 0x00388D88
			public void InitNetReq()
			{
				this.m_owner.InitNetReq();
			}

			// Token: 0x0600CDD4 RID: 52692 RVA: 0x0038AB98 File Offset: 0x00388D98
			public void TickCheckClientVersion()
			{
				this.m_owner.TickCheckClientVersion();
			}

			// Token: 0x0600CDD5 RID: 52693 RVA: 0x0038ABA8 File Offset: 0x00388DA8
			public void TickChatVoice()
			{
				this.m_owner.TickChatVoice();
			}

			// Token: 0x0600CDD6 RID: 52694 RVA: 0x0038ABB8 File Offset: 0x00388DB8
			public void TickClientHeartBeat()
			{
				this.m_owner.TickClientHeartBeat();
			}

			// Token: 0x0600CDD7 RID: 52695 RVA: 0x0038ABC8 File Offset: 0x00388DC8
			public void _TickCheckOnline()
			{
				this.m_owner._TickCheckOnline();
			}

			// Token: 0x0600CDD8 RID: 52696 RVA: 0x0038ABD8 File Offset: 0x00388DD8
			public void UpdateView()
			{
				this.m_owner.UpdateView();
			}

			// Token: 0x0600CDD9 RID: 52697 RVA: 0x0038ABE8 File Offset: 0x00388DE8
			public bool IsNeedLoadDynamicRes()
			{
				return this.m_owner.IsNeedLoadDynamicRes();
			}

			// Token: 0x0600CDDA RID: 52698 RVA: 0x0038ABF8 File Offset: 0x00388DF8
			public void PostUpdateView()
			{
				this.m_owner.PostUpdateView();
			}

			// Token: 0x0600CDDB RID: 52699 RVA: 0x0038AC08 File Offset: 0x00388E08
			public void PlayerContext_OnNewMarqueeNtf(Marquee marquee)
			{
				this.m_owner.PlayerContext_OnNewMarqueeNtf(marquee);
			}

			// Token: 0x0600CDDC RID: 52700 RVA: 0x0038AC18 File Offset: 0x00388E18
			public void PlayerContext_OnServerDisconnectNtf(int errorCode)
			{
				this.m_owner.PlayerContext_OnServerDisconnectNtf(errorCode);
			}

			// Token: 0x0600CDDD RID: 52701 RVA: 0x0038AC28 File Offset: 0x00388E28
			public void PlayerContext_OnClientCheatNtf()
			{
				this.m_owner.PlayerContext_OnClientCheatNtf();
			}

			// Token: 0x0600CDDE RID: 52702 RVA: 0x0038AC38 File Offset: 0x00388E38
			public void PlayerContext_EventOnGuildUpdateInfo(GuildLog log)
			{
				this.m_owner.PlayerContext_EventOnGuildUpdateInfo(log);
			}

			// Token: 0x0600CDDF RID: 52703 RVA: 0x0038AC48 File Offset: 0x00388E48
			public void EventOnSDKPromotingPlaySuccess(string goodsRegisterID)
			{
				this.m_owner.EventOnSDKPromotingPlaySuccess(goodsRegisterID);
			}

			// Token: 0x0600CDE0 RID: 52704 RVA: 0x0038AC58 File Offset: 0x00388E58
			public void StartWorldUITask()
			{
				this.m_owner.StartWorldUITask();
			}

			// Token: 0x0600CDE1 RID: 52705 RVA: 0x0038AC68 File Offset: 0x00388E68
			public void WorldUITask_OnLoadAllResCompleted()
			{
				this.m_owner.WorldUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600CDE2 RID: 52706 RVA: 0x0038AC78 File Offset: 0x00388E78
			public void StartBattleUITask()
			{
				this.m_owner.StartBattleUITask();
			}

			// Token: 0x0600CDE3 RID: 52707 RVA: 0x0038AC88 File Offset: 0x00388E88
			public void BattleUITask_OnLoadAllResCompleted()
			{
				this.m_owner.BattleUITask_OnLoadAllResCompleted();
			}

			// Token: 0x0600CDE4 RID: 52708 RVA: 0x0038AC98 File Offset: 0x00388E98
			public bool StartArenaBattleUITask()
			{
				return this.m_owner.StartArenaBattleUITask();
			}

			// Token: 0x0600CDE5 RID: 52709 RVA: 0x0038ACA8 File Offset: 0x00388EA8
			public bool CheckEnterBattle()
			{
				return this.m_owner.CheckEnterBattle();
			}

			// Token: 0x0600CDE6 RID: 52710 RVA: 0x0038ACB8 File Offset: 0x00388EB8
			public bool RebuildBattle()
			{
				return this.m_owner.RebuildBattle();
			}

			// Token: 0x0600CDE7 RID: 52711 RVA: 0x0038ACC8 File Offset: 0x00388EC8
			public bool RebuildBattleHappening(BattleType battleType, int levelId)
			{
				return this.m_owner.RebuildBattleHappening(battleType, levelId);
			}

			// Token: 0x0600CDE8 RID: 52712 RVA: 0x0038ACD8 File Offset: 0x00388ED8
			public bool RebuildArenaBattle()
			{
				return this.m_owner.RebuildArenaBattle();
			}

			// Token: 0x0600CDE9 RID: 52713 RVA: 0x0038ACE8 File Offset: 0x00388EE8
			public bool RebuildBattleRoom()
			{
				return this.m_owner.RebuildBattleRoom();
			}

			// Token: 0x0600CDEA RID: 52714 RVA: 0x0038ACF8 File Offset: 0x00388EF8
			public static void StartBattleCancelNetTask(Action<int> onEnd)
			{
				CommonUITask.StartBattleCancelNetTask(onEnd);
			}

			// Token: 0x0600CDEB RID: 52715 RVA: 0x0038AD00 File Offset: 0x00388F00
			public void StartArenaBattleCancelNetTaskAndStartWorldUITask()
			{
				this.m_owner.StartArenaBattleCancelNetTaskAndStartWorldUITask();
			}

			// Token: 0x0600CDEC RID: 52716 RVA: 0x0038AD10 File Offset: 0x00388F10
			public static void StartArenaPlayerInfoGetNetTask(Action<int> onEnd)
			{
				CommonUITask.StartArenaPlayerInfoGetNetTask(onEnd);
			}

			// Token: 0x0600CDED RID: 52717 RVA: 0x0038AD18 File Offset: 0x00388F18
			public static void StartArenaBattleReconnectNetTask(Action<int> onEnd)
			{
				CommonUITask.StartArenaBattleReconnectNetTask(onEnd);
			}

			// Token: 0x0600CDEE RID: 52718 RVA: 0x0038AD20 File Offset: 0x00388F20
			public static void StartBattleRoomGetNetTask(Action<int> onEnd)
			{
				CommonUITask.StartBattleRoomGetNetTask(onEnd);
			}

			// Token: 0x0600CDEF RID: 52719 RVA: 0x0038AD28 File Offset: 0x00388F28
			public static void StartRealTimePVPGetInfoNetTask(Action<int> onEnd)
			{
				CommonUITask.StartRealTimePVPGetInfoNetTask(onEnd);
			}

			// Token: 0x040080F1 RID: 33009
			private CommonUITask m_owner;
		}
	}
}
