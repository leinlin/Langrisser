using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B6F RID: 2927
	[HotFix]
	public class VoiceRecordHelper
	{
		// Token: 0x0600C70B RID: 50955 RVA: 0x003720B0 File Offset: 0x003702B0
		private VoiceRecordHelper(string deviceName)
		{
			this.m_deviceName = deviceName;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorString_hotfix != null)
			{
				this.m_ctorString_hotfix.call(new object[]
				{
					this,
					deviceName
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C70C RID: 50956 RVA: 0x00372180 File Offset: 0x00370380
		private void Init()
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
			if (Microphone.devices.Length == 0)
			{
				global::Debug.LogError("VoiceRecordHelper::Setup::No microphone detected; disabling voice capture");
				return;
			}
			if (string.IsNullOrEmpty(this.m_deviceName))
			{
				this.m_deviceName = null;
			}
			else if (!Microphone.devices.Contains(this.m_deviceName))
			{
				global::Debug.LogError(string.Format("VoiceRecordHelper::Setup::Cannot find mic, using default mic", this.m_deviceName));
				this.m_deviceName = null;
			}
			this.VoiceMaxLength = 20;
			this.VoiceMinLength = 1;
			this.EncodeAndDecodeFrameSize = 640;
			foreach (string text in Directory.GetFiles(Application.temporaryCachePath, "tempSaveAudio_*.wav", SearchOption.TopDirectoryOnly))
			{
				File.Delete(text);
				global::Debug.Log(string.Format("Delete {0}", text));
			}
		}

		// Token: 0x0600C70D RID: 50957 RVA: 0x003722A0 File Offset: 0x003704A0
		public void InitXFSDKManager(XunfeiSDKWrapper wrapper)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitXFSDKManagerXunfeiSDKWrapper_hotfix != null)
			{
				this.m_InitXFSDKManagerXunfeiSDKWrapper_hotfix.call(new object[]
				{
					this,
					wrapper
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_xfWrapper != null)
			{
				return;
			}
			if (wrapper != null)
			{
				this.m_xfWrapper = wrapper;
				this.m_xfWrapper.OnSpeechRecognized += this.OnXFSpeechRecognizedSuccess;
				this.m_xfWrapper.OnSpeechRecognizeFailed += this.OnXFSpeechRecognizeFailed;
				int num = this.ConfigDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_EnableXFVoiceTranslate);
				if (num == 1)
				{
					if (Application.platform == RuntimePlatform.Android)
					{
						this.m_xfWrapper.InitSDK(this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_XunfeiAppIdAndroid), 16000);
					}
					else if (Application.platform == RuntimePlatform.IPhonePlayer)
					{
						this.m_xfWrapper.InitSDK(this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_XunfeiAppIdIOS), 16000);
					}
					else if (Application.platform == RuntimePlatform.WindowsEditor || Application.platform == RuntimePlatform.WindowsPlayer)
					{
						this.m_xfWrapper.InitSDK(this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_XunfeiAppIdWindows), 16000);
					}
				}
			}
			global::Debug.Log("VoiceRecordHelper::InitXFSDKManager");
		}

		// Token: 0x0600C70E RID: 50958 RVA: 0x0037241C File Offset: 0x0037061C
		public void StartRecord(ChatChannel channel, Action onMicrophoneStarted)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartRecordChatChannelAction_hotfix != null)
			{
				this.m_StartRecordChatChannelAction_hotfix.call(new object[]
				{
					this,
					channel,
					onMicrophoneStarted
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isRunningStartRecord)
			{
				return;
			}
			this.m_isRunningStartRecord = true;
			AudioUtility.SetVolume("All_Game_Sounds", 0f, true);
			AudioUtility.Pause(true);
			if (Application.platform != RuntimePlatform.IPhonePlayer && this.m_eventStopRecord != null)
			{
				this.m_eventStopRecord();
				this.m_isRunningStartRecord = false;
				return;
			}
			this.m_eventStopRecord = null;
			if (Microphone.IsRecording(this.m_deviceName))
			{
				Microphone.End(this.m_deviceName);
				AudioUtility.Pause(true);
				AudioUtility.Pause(false);
			}
			this.ClearRecord();
			this.m_currRecordChannel = new ChatChannel?(channel);
			int num = 0;
			int num2 = 0;
			Microphone.GetDeviceCaps(this.m_deviceName, out num, out num2);
			this.m_frequency = 16000;
			if (num2 != 0 && this.m_frequency > num2)
			{
				this.m_frequency = num2;
			}
			if (this.m_xfWrapper != null)
			{
				this.m_xfWrapper.StartRecord();
			}
			this.m_recordClip = Microphone.Start(this.m_deviceName, false, this.VoiceMaxLength + 2, this.m_frequency);
			if (this.m_recordClip == null)
			{
				this.m_isRecording = false;
				AudioUtility.SetVolume("All_Game_Sounds", 1f, true);
				global::Debug.LogError("VoiceRecordHelper::StartRecord::Failed to start microphone capture");
				this.m_isRunningStartRecord = false;
				return;
			}
			if (onMicrophoneStarted != null)
			{
				onMicrophoneStarted();
			}
			this.m_startTime = BlackJack.BJFramework.Runtime.Timer.m_currTime;
			this.m_isRecording = true;
			this.m_isRunningStartRecord = false;
		}

		// Token: 0x0600C70F RID: 50959 RVA: 0x00372600 File Offset: 0x00370800
		public bool IsMicrophoneAvailable()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMicrophoneAvailable_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMicrophoneAvailable_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Microphone.devices.Length != 0;
		}

		// Token: 0x0600C710 RID: 50960 RVA: 0x0037267C File Offset: 0x0037087C
		private void OnStopRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnStopRecord_hotfix != null)
			{
				this.m_OnStopRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			AudioUtility.SetVolume("All_Game_Sounds", 1f, true);
			this.m_eventStopRecord -= this.OnStopRecord;
		}

		// Token: 0x0600C711 RID: 50961 RVA: 0x00372700 File Offset: 0x00370900
		public void StopRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StopRecord_hotfix != null)
			{
				this.m_StopRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isRunningStartRecord && this.m_eventStopRecord == null)
			{
				this.m_eventStopRecord += this.OnStopRecord;
			}
			if (!this.m_isRecording)
			{
				return;
			}
			this.m_endTime = BlackJack.BJFramework.Runtime.Timer.m_currTime;
			this.m_isRecording = false;
			int position = Microphone.GetPosition(this.m_deviceName);
			Microphone.End(this.m_deviceName);
			AudioUtility.Pause(true);
			AudioUtility.Pause(false);
			AudioUtility.SetVolume("All_Game_Sounds", 1f, true);
			bool flag = (this.m_endTime - this.m_startTime).TotalSeconds < (double)this.VoiceMinLength;
			if (this.m_recordClip == null || this.m_isCancelRecord || flag)
			{
				global::Debug.Log("StopRecord::I am Cancel");
				PlayerVoiceHandleThread.Instance.AddDataEndToInputBuffer(null, false);
				this.ClearRecord();
				return;
			}
			if (position > this.m_preRecordPos)
			{
				float[] array = new float[position - this.m_preRecordPos];
				this.m_recordClip.GetData(array, this.m_preRecordPos);
				PlayerVoiceHandleThread.Instance.AddDataContentToInputBuffer(array);
			}
			ChatVoiceInfo chatVoiceInfo = new ChatVoiceInfo();
			chatVoiceInfo.m_voiceRecordId = this.AllocRecordId();
			chatVoiceInfo.m_sampleLength = position / this.m_recordClip.channels;
			chatVoiceInfo.m_voiceFrequency = this.m_frequency;
			chatVoiceInfo.m_voiceSendChannel = (int)this.m_currRecordChannel.Value;
			chatVoiceInfo.m_voiceLength = this.GetRecordLength();
			PlayerVoiceHandleThread.Instance.AddDataEndToInputBuffer(chatVoiceInfo, true);
			if (this.m_xfWrapper != null)
			{
				string saveAudioFullPath = this.GetSaveAudioFullPath(chatVoiceInfo.m_voiceRecordId);
				SaveWav.Save(saveAudioFullPath, AudioUtility.ClipAudioByLength(this.m_recordClip, this.GetRecordLength()));
				this.m_xfWaitForRecognizeFilePathList.AddLast(saveAudioFullPath);
				this.StartXFRecognize();
			}
		}

		// Token: 0x0600C712 RID: 50962 RVA: 0x00372924 File Offset: 0x00370B24
		public bool IsRecording()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRecording_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRecording_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_isRecording;
		}

		// Token: 0x0600C713 RID: 50963 RVA: 0x00372998 File Offset: 0x00370B98
		public void Tick()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Tick_hotfix != null)
			{
				this.m_Tick_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.TickForRecordVoice();
		}

		// Token: 0x0600C714 RID: 50964 RVA: 0x00372A00 File Offset: 0x00370C00
		public bool IsArrivalMaxLength()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArrivalMaxLength_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArrivalMaxLength_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetRecordLength() >= (float)this.VoiceMaxLength;
		}

		// Token: 0x0600C715 RID: 50965 RVA: 0x00372A80 File Offset: 0x00370C80
		public bool IsTooShort()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTooShort_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTooShort_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetRecordLength() < (float)this.VoiceMinLength;
		}

		// Token: 0x0600C716 RID: 50966 RVA: 0x00372AFC File Offset: 0x00370CFC
		public float GetRecordLength()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRecordLength_hotfix != null)
			{
				return Convert.ToSingle(this.m_GetRecordLength_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_isRecording)
			{
				return (float)(BlackJack.BJFramework.Runtime.Timer.m_currTime - this.m_startTime).TotalSeconds;
			}
			if (this.m_startTime != DateTime.MinValue)
			{
				return (float)(this.m_endTime - this.m_startTime).TotalSeconds;
			}
			return 0f;
		}

		// Token: 0x0600C717 RID: 50967 RVA: 0x00372BC4 File Offset: 0x00370DC4
		public void CancelRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelRecord_hotfix != null)
			{
				this.m_CancelRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_isCancelRecord = true;
			this.StopRecord();
		}

		// Token: 0x0600C718 RID: 50968 RVA: 0x00372C34 File Offset: 0x00370E34
		public string GetSaveAudioFullPath(int voiceRecordId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSaveAudioFullPathInt32_hotfix != null)
			{
				return (string)this.m_GetSaveAudioFullPathInt32_hotfix.call(new object[]
				{
					this,
					voiceRecordId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return string.Format("{0}/tempSaveAudio_{1}.wav", Application.temporaryCachePath, voiceRecordId.ToString());
		}

		// Token: 0x0600C719 RID: 50969 RVA: 0x00372CCC File Offset: 0x00370ECC
		private void TickForRecordVoice()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickForRecordVoice_hotfix != null)
			{
				this.m_TickForRecordVoice_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_isRecording)
			{
				return;
			}
			if (this.GetRecordLength() >= (float)this.VoiceMaxLength)
			{
				if (this.EventOnVoiceRecordTimeout != null)
				{
					this.EventOnVoiceRecordTimeout(this.m_currRecordChannel.Value);
				}
				else
				{
					this.CancelRecord();
				}
			}
			else if (this.m_recordClip != null && this.m_recordNextTickTime <= BlackJack.BJFramework.Runtime.Timer.m_currTime)
			{
				int channels = this.m_recordClip.channels;
				int position = Microphone.GetPosition(this.m_deviceName);
				int num = position - this.m_preRecordPos;
				if (channels == 1 && num > this.EncodeAndDecodeFrameSize)
				{
					int num2 = position - num % this.EncodeAndDecodeFrameSize;
					float[] array = new float[num2 - this.m_preRecordPos];
					this.m_recordClip.GetData(array, this.m_preRecordPos);
					PlayerVoiceHandleThread.Instance.AddDataContentToInputBuffer(array);
					this.m_preRecordPos = num2;
				}
				else if (channels == 2 && num > this.EncodeAndDecodeFrameSize * 2)
				{
					int num3 = position - num % (this.EncodeAndDecodeFrameSize * 2);
					float[] array2 = new float[num3 - this.m_preRecordPos];
					this.m_recordClip.GetData(array2, this.m_preRecordPos);
					float[] array3 = new float[array2.Length / 2];
					int num4 = 0;
					for (int i = 0; i < array2.Length; i += 2)
					{
						array3[num4] = array2[i];
						num4++;
					}
					PlayerVoiceHandleThread.Instance.AddDataContentToInputBuffer(array3);
					this.m_preRecordPos = num3;
				}
				else if (channels > 2)
				{
					global::Debug.LogError("VoiceRecordHelper::RecordClip Channels > 2 ！");
				}
				this.m_recordNextTickTime = BlackJack.BJFramework.Runtime.Timer.m_currTime.AddMilliseconds(500.0);
			}
		}

		// Token: 0x0600C71A RID: 50970 RVA: 0x00372EE0 File Offset: 0x003710E0
		private void StartXFRecognize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartXFRecognize_hotfix != null)
			{
				this.m_StartXFRecognize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_xfWrapper == null)
			{
				global::Debug.LogError("StartXFRecognize::m_xfWrapper null");
				return;
			}
			if (this.m_isXFRecognizing)
			{
				return;
			}
			if (this.m_xfWaitForRecognizeFilePathList.Count > 0)
			{
				string value = this.m_xfWaitForRecognizeFilePathList.First.Value;
				this.m_isXFRecognizing = true;
				this.m_xfWrapper.StopRecord(value);
			}
		}

		// Token: 0x0600C71B RID: 50971 RVA: 0x00372FA0 File Offset: 0x003711A0
		private void OnXFSpeechRecognizedSuccess(string returnTxt)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnXFSpeechRecognizedSuccessString_hotfix != null)
			{
				this.m_OnXFSpeechRecognizedSuccessString_hotfix.call(new object[]
				{
					this,
					returnTxt
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.DeleteAudioTempFile();
			this.m_xfRecognizedResultList.AddLast(returnTxt);
			global::Debug.Log("OnXFSpeechRecognizedSuccess: " + returnTxt);
			this.m_isXFRecognizing = false;
			this.StartXFRecognize();
		}

		// Token: 0x0600C71C RID: 50972 RVA: 0x00373040 File Offset: 0x00371240
		private void OnXFSpeechRecognizeFailed()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnXFSpeechRecognizeFailed_hotfix != null)
			{
				this.m_OnXFSpeechRecognizeFailed_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			global::Debug.LogError("OnXFSpeechRecognizeFailed:识别失败。");
			this.DeleteAudioTempFile();
			this.m_xfRecognizedResultList.AddLast(this.ConfigDataLoader.UtilityGetStringByStringTable(StringTableId.StringTableId_Chat_VoiceTranslateToTextFail));
			this.m_isXFRecognizing = false;
			this.StartXFRecognize();
		}

		// Token: 0x0600C71D RID: 50973 RVA: 0x003730DC File Offset: 0x003712DC
		private void DeleteAudioTempFile()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeleteAudioTempFile_hotfix != null)
			{
				this.m_DeleteAudioTempFile_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_xfWaitForRecognizeFilePathList == null || this.m_xfWaitForRecognizeFilePathList.First == null)
			{
				return;
			}
			string value = this.m_xfWaitForRecognizeFilePathList.First.Value;
			this.m_xfWaitForRecognizeFilePathList.RemoveFirst();
		}

		// Token: 0x0600C71E RID: 50974 RVA: 0x00373174 File Offset: 0x00371374
		private void ClearRecord()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearRecord_hotfix != null)
			{
				this.m_ClearRecord_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_recordClip = null;
			this.m_startTime = (this.m_endTime = DateTime.MinValue);
			this.m_isCancelRecord = false;
			this.m_isRecording = false;
			this.m_preRecordPos = 0;
		}

		// Token: 0x0600C71F RID: 50975 RVA: 0x00373204 File Offset: 0x00371404
		private int AllocRecordId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AllocRecordId_hotfix != null)
			{
				return Convert.ToInt32(this.m_AllocRecordId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_recordIdSeed++;
		}

		// Token: 0x14000264 RID: 612
		// (add) Token: 0x0600C720 RID: 50976 RVA: 0x00373284 File Offset: 0x00371484
		// (remove) Token: 0x0600C721 RID: 50977 RVA: 0x00373320 File Offset: 0x00371520
		public event Action<ChatChannel> EventOnVoiceRecordTimeout
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_EventOnVoiceRecordTimeoutAction`1_hotfix != null)
				{
					this.m_add_EventOnVoiceRecordTimeoutAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatChannel> action = this.EventOnVoiceRecordTimeout;
				Action<ChatChannel> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatChannel>>(ref this.EventOnVoiceRecordTimeout, (Action<ChatChannel>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_EventOnVoiceRecordTimeoutAction`1_hotfix != null)
				{
					this.m_remove_EventOnVoiceRecordTimeoutAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<ChatChannel> action = this.EventOnVoiceRecordTimeout;
				Action<ChatChannel> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<ChatChannel>>(ref this.EventOnVoiceRecordTimeout, (Action<ChatChannel>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700279D RID: 10141
		// (get) Token: 0x0600C722 RID: 50978 RVA: 0x003733BC File Offset: 0x003715BC
		public LinkedList<string> XFRecognizedResultList
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_XFRecognizedResultList_hotfix != null)
				{
					return (LinkedList<string>)this.m_get_XFRecognizedResultList_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_xfRecognizedResultList;
			}
		}

		// Token: 0x1700279E RID: 10142
		// (get) Token: 0x0600C723 RID: 50979 RVA: 0x00373430 File Offset: 0x00371630
		private IConfigDataLoader ConfigDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_ConfigDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_ConfigDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			}
		}

		// Token: 0x1700279F RID: 10143
		// (get) Token: 0x0600C724 RID: 50980 RVA: 0x003734AC File Offset: 0x003716AC
		public static VoiceRecordHelper Instance
		{
			get
			{
				if (VoiceRecordHelper.m_instance == null)
				{
					VoiceRecordHelper.m_instance = new VoiceRecordHelper(null);
					VoiceRecordHelper.m_instance.Init();
				}
				return VoiceRecordHelper.m_instance;
			}
		}

		// Token: 0x14000265 RID: 613
		// (add) Token: 0x0600C725 RID: 50981 RVA: 0x003734D4 File Offset: 0x003716D4
		// (remove) Token: 0x0600C726 RID: 50982 RVA: 0x00373570 File Offset: 0x00371770
		private event Action m_eventStopRecord
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_m_eventStopRecordAction_hotfix != null)
				{
					this.m_add_m_eventStopRecordAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.m_eventStopRecord;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.m_eventStopRecord, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_m_eventStopRecordAction_hotfix != null)
				{
					this.m_remove_m_eventStopRecordAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.m_eventStopRecord;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.m_eventStopRecord, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170027A0 RID: 10144
		// (get) Token: 0x0600C727 RID: 50983 RVA: 0x0037360C File Offset: 0x0037180C
		// (set) Token: 0x0600C728 RID: 50984 RVA: 0x0037362C File Offset: 0x0037182C
		[DoNotToLua]
		public VoiceRecordHelper.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoiceRecordHelper.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C729 RID: 50985 RVA: 0x00373638 File Offset: 0x00371838
		private void __callDele_EventOnVoiceRecordTimeout(ChatChannel obj)
		{
			Action<ChatChannel> eventOnVoiceRecordTimeout = this.EventOnVoiceRecordTimeout;
			if (eventOnVoiceRecordTimeout != null)
			{
				eventOnVoiceRecordTimeout(obj);
			}
		}

		// Token: 0x0600C72A RID: 50986 RVA: 0x0037365C File Offset: 0x0037185C
		private void __clearDele_EventOnVoiceRecordTimeout(ChatChannel obj)
		{
			this.EventOnVoiceRecordTimeout = null;
		}

		// Token: 0x0600C72B RID: 50987 RVA: 0x00373668 File Offset: 0x00371868
		private void __callDele_m_eventStopRecord()
		{
			Action eventStopRecord = this.m_eventStopRecord;
			if (eventStopRecord != null)
			{
				eventStopRecord();
			}
		}

		// Token: 0x0600C72C RID: 50988 RVA: 0x00373688 File Offset: 0x00371888
		private void __clearDele_m_eventStopRecord()
		{
			this.m_eventStopRecord = null;
		}

		// Token: 0x0600C72D RID: 50989 RVA: 0x00373694 File Offset: 0x00371894
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_InitXFSDKManagerXunfeiSDKWrapper_hotfix = (luaObj.RawGet("InitXFSDKManager") as LuaFunction);
					this.m_StartRecordChatChannelAction_hotfix = (luaObj.RawGet("StartRecord") as LuaFunction);
					this.m_IsMicrophoneAvailable_hotfix = (luaObj.RawGet("IsMicrophoneAvailable") as LuaFunction);
					this.m_OnStopRecord_hotfix = (luaObj.RawGet("OnStopRecord") as LuaFunction);
					this.m_StopRecord_hotfix = (luaObj.RawGet("StopRecord") as LuaFunction);
					this.m_IsRecording_hotfix = (luaObj.RawGet("IsRecording") as LuaFunction);
					this.m_Tick_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_IsArrivalMaxLength_hotfix = (luaObj.RawGet("IsArrivalMaxLength") as LuaFunction);
					this.m_IsTooShort_hotfix = (luaObj.RawGet("IsTooShort") as LuaFunction);
					this.m_GetRecordLength_hotfix = (luaObj.RawGet("GetRecordLength") as LuaFunction);
					this.m_CancelRecord_hotfix = (luaObj.RawGet("CancelRecord") as LuaFunction);
					this.m_GetSaveAudioFullPathInt32_hotfix = (luaObj.RawGet("GetSaveAudioFullPath") as LuaFunction);
					this.m_TickForRecordVoice_hotfix = (luaObj.RawGet("TickForRecordVoice") as LuaFunction);
					this.m_StartXFRecognize_hotfix = (luaObj.RawGet("StartXFRecognize") as LuaFunction);
					this.m_OnXFSpeechRecognizedSuccessString_hotfix = (luaObj.RawGet("OnXFSpeechRecognizedSuccess") as LuaFunction);
					this.m_OnXFSpeechRecognizeFailed_hotfix = (luaObj.RawGet("OnXFSpeechRecognizeFailed") as LuaFunction);
					this.m_DeleteAudioTempFile_hotfix = (luaObj.RawGet("DeleteAudioTempFile") as LuaFunction);
					this.m_ClearRecord_hotfix = (luaObj.RawGet("ClearRecord") as LuaFunction);
					this.m_AllocRecordId_hotfix = (luaObj.RawGet("AllocRecordId") as LuaFunction);
					this.m_add_EventOnVoiceRecordTimeoutAction`1_hotfix = (luaObj.RawGet("add_EventOnVoiceRecordTimeout") as LuaFunction);
					this.m_remove_EventOnVoiceRecordTimeoutAction`1_hotfix = (luaObj.RawGet("remove_EventOnVoiceRecordTimeout") as LuaFunction);
					this.m_get_XFRecognizedResultList_hotfix = (luaObj.RawGet("get_XFRecognizedResultList") as LuaFunction);
					this.m_get_ConfigDataLoader_hotfix = (luaObj.RawGet("get_ConfigDataLoader") as LuaFunction);
					this.m_add_m_eventStopRecordAction_hotfix = (luaObj.RawGet("add_m_eventStopRecord") as LuaFunction);
					this.m_remove_m_eventStopRecordAction_hotfix = (luaObj.RawGet("remove_m_eventStopRecord") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C72E RID: 50990 RVA: 0x003739EC File Offset: 0x00371BEC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(VoiceRecordHelper));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007DF0 RID: 32240
		private int m_recordIdSeed;

		// Token: 0x04007DF1 RID: 32241
		private bool m_isRecording;

		// Token: 0x04007DF2 RID: 32242
		private bool m_isCancelRecord;

		// Token: 0x04007DF3 RID: 32243
		private int m_preRecordPos;

		// Token: 0x04007DF4 RID: 32244
		private AudioClip m_recordClip;

		// Token: 0x04007DF5 RID: 32245
		private int m_frequency;

		// Token: 0x04007DF6 RID: 32246
		private DateTime m_startTime = DateTime.MinValue;

		// Token: 0x04007DF7 RID: 32247
		private DateTime m_endTime = DateTime.MinValue;

		// Token: 0x04007DF8 RID: 32248
		private string m_deviceName;

		// Token: 0x04007DF9 RID: 32249
		private DateTime m_recordNextTickTime = DateTime.MinValue;

		// Token: 0x04007DFA RID: 32250
		private ChatChannel? m_currRecordChannel;

		// Token: 0x04007DFC RID: 32252
		private int VoiceMaxLength = 20;

		// Token: 0x04007DFD RID: 32253
		private int VoiceMinLength = 1;

		// Token: 0x04007DFE RID: 32254
		private int EncodeAndDecodeFrameSize = 640;

		// Token: 0x04007DFF RID: 32255
		private bool m_isXFRecognizing;

		// Token: 0x04007E00 RID: 32256
		private LinkedList<string> m_xfWaitForRecognizeFilePathList = new LinkedList<string>();

		// Token: 0x04007E01 RID: 32257
		private LinkedList<string> m_xfRecognizedResultList = new LinkedList<string>();

		// Token: 0x04007E02 RID: 32258
		private XunfeiSDKWrapper m_xfWrapper;

		// Token: 0x04007E03 RID: 32259
		private static VoiceRecordHelper m_instance;

		// Token: 0x04007E04 RID: 32260
		private bool m_isRunningStartRecord;

		// Token: 0x04007E06 RID: 32262
		[DoNotToLua]
		private VoiceRecordHelper.LuaExportHelper luaExportHelper;

		// Token: 0x04007E07 RID: 32263
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007E08 RID: 32264
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007E09 RID: 32265
		private LuaFunction m_ctorString_hotfix;

		// Token: 0x04007E0A RID: 32266
		private LuaFunction m_Init_hotfix;

		// Token: 0x04007E0B RID: 32267
		private LuaFunction m_InitXFSDKManagerXunfeiSDKWrapper_hotfix;

		// Token: 0x04007E0C RID: 32268
		private LuaFunction m_StartRecordChatChannelAction_hotfix;

		// Token: 0x04007E0D RID: 32269
		private LuaFunction m_IsMicrophoneAvailable_hotfix;

		// Token: 0x04007E0E RID: 32270
		private LuaFunction m_OnStopRecord_hotfix;

		// Token: 0x04007E0F RID: 32271
		private LuaFunction m_StopRecord_hotfix;

		// Token: 0x04007E10 RID: 32272
		private LuaFunction m_IsRecording_hotfix;

		// Token: 0x04007E11 RID: 32273
		private LuaFunction m_Tick_hotfix;

		// Token: 0x04007E12 RID: 32274
		private LuaFunction m_IsArrivalMaxLength_hotfix;

		// Token: 0x04007E13 RID: 32275
		private LuaFunction m_IsTooShort_hotfix;

		// Token: 0x04007E14 RID: 32276
		private LuaFunction m_GetRecordLength_hotfix;

		// Token: 0x04007E15 RID: 32277
		private LuaFunction m_CancelRecord_hotfix;

		// Token: 0x04007E16 RID: 32278
		private LuaFunction m_GetSaveAudioFullPathInt32_hotfix;

		// Token: 0x04007E17 RID: 32279
		private LuaFunction m_TickForRecordVoice_hotfix;

		// Token: 0x04007E18 RID: 32280
		private LuaFunction m_StartXFRecognize_hotfix;

		// Token: 0x04007E19 RID: 32281
		private LuaFunction m_OnXFSpeechRecognizedSuccessString_hotfix;

		// Token: 0x04007E1A RID: 32282
		private LuaFunction m_OnXFSpeechRecognizeFailed_hotfix;

		// Token: 0x04007E1B RID: 32283
		private LuaFunction m_DeleteAudioTempFile_hotfix;

		// Token: 0x04007E1C RID: 32284
		private LuaFunction m_ClearRecord_hotfix;

		// Token: 0x04007E1D RID: 32285
		private LuaFunction m_AllocRecordId_hotfix;

		// Token: 0x04007E1E RID: 32286
		private LuaFunction m_add_EventOnVoiceRecordTimeoutAction;

		// Token: 0x04007E1F RID: 32287
		private LuaFunction m_remove_EventOnVoiceRecordTimeoutAction;

		// Token: 0x04007E20 RID: 32288
		private LuaFunction m_get_XFRecognizedResultList_hotfix;

		// Token: 0x04007E21 RID: 32289
		private LuaFunction m_get_ConfigDataLoader_hotfix;

		// Token: 0x04007E22 RID: 32290
		private LuaFunction m_add_m_eventStopRecordAction_hotfix;

		// Token: 0x04007E23 RID: 32291
		private LuaFunction m_remove_m_eventStopRecordAction_hotfix;

		// Token: 0x02000B70 RID: 2928
		public class LuaExportHelper
		{
			// Token: 0x0600C72F RID: 50991 RVA: 0x00373A54 File Offset: 0x00371C54
			public LuaExportHelper(VoiceRecordHelper owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C730 RID: 50992 RVA: 0x00373A64 File Offset: 0x00371C64
			public void __callDele_EventOnVoiceRecordTimeout(ChatChannel obj)
			{
				this.m_owner.__callDele_EventOnVoiceRecordTimeout(obj);
			}

			// Token: 0x0600C731 RID: 50993 RVA: 0x00373A74 File Offset: 0x00371C74
			public void __clearDele_EventOnVoiceRecordTimeout(ChatChannel obj)
			{
				this.m_owner.__clearDele_EventOnVoiceRecordTimeout(obj);
			}

			// Token: 0x0600C732 RID: 50994 RVA: 0x00373A84 File Offset: 0x00371C84
			public void __callDele_m_eventStopRecord()
			{
				this.m_owner.__callDele_m_eventStopRecord();
			}

			// Token: 0x0600C733 RID: 50995 RVA: 0x00373A94 File Offset: 0x00371C94
			public void __clearDele_m_eventStopRecord()
			{
				this.m_owner.__clearDele_m_eventStopRecord();
			}

			// Token: 0x170027A1 RID: 10145
			// (get) Token: 0x0600C734 RID: 50996 RVA: 0x00373AA4 File Offset: 0x00371CA4
			// (set) Token: 0x0600C735 RID: 50997 RVA: 0x00373AB4 File Offset: 0x00371CB4
			public int m_recordIdSeed
			{
				get
				{
					return this.m_owner.m_recordIdSeed;
				}
				set
				{
					this.m_owner.m_recordIdSeed = value;
				}
			}

			// Token: 0x170027A2 RID: 10146
			// (get) Token: 0x0600C736 RID: 50998 RVA: 0x00373AC4 File Offset: 0x00371CC4
			// (set) Token: 0x0600C737 RID: 50999 RVA: 0x00373AD4 File Offset: 0x00371CD4
			public bool m_isRecording
			{
				get
				{
					return this.m_owner.m_isRecording;
				}
				set
				{
					this.m_owner.m_isRecording = value;
				}
			}

			// Token: 0x170027A3 RID: 10147
			// (get) Token: 0x0600C738 RID: 51000 RVA: 0x00373AE4 File Offset: 0x00371CE4
			// (set) Token: 0x0600C739 RID: 51001 RVA: 0x00373AF4 File Offset: 0x00371CF4
			public bool m_isCancelRecord
			{
				get
				{
					return this.m_owner.m_isCancelRecord;
				}
				set
				{
					this.m_owner.m_isCancelRecord = value;
				}
			}

			// Token: 0x170027A4 RID: 10148
			// (get) Token: 0x0600C73A RID: 51002 RVA: 0x00373B04 File Offset: 0x00371D04
			// (set) Token: 0x0600C73B RID: 51003 RVA: 0x00373B14 File Offset: 0x00371D14
			public int m_preRecordPos
			{
				get
				{
					return this.m_owner.m_preRecordPos;
				}
				set
				{
					this.m_owner.m_preRecordPos = value;
				}
			}

			// Token: 0x170027A5 RID: 10149
			// (get) Token: 0x0600C73C RID: 51004 RVA: 0x00373B24 File Offset: 0x00371D24
			// (set) Token: 0x0600C73D RID: 51005 RVA: 0x00373B34 File Offset: 0x00371D34
			public AudioClip m_recordClip
			{
				get
				{
					return this.m_owner.m_recordClip;
				}
				set
				{
					this.m_owner.m_recordClip = value;
				}
			}

			// Token: 0x170027A6 RID: 10150
			// (get) Token: 0x0600C73E RID: 51006 RVA: 0x00373B44 File Offset: 0x00371D44
			// (set) Token: 0x0600C73F RID: 51007 RVA: 0x00373B54 File Offset: 0x00371D54
			public int m_frequency
			{
				get
				{
					return this.m_owner.m_frequency;
				}
				set
				{
					this.m_owner.m_frequency = value;
				}
			}

			// Token: 0x170027A7 RID: 10151
			// (get) Token: 0x0600C740 RID: 51008 RVA: 0x00373B64 File Offset: 0x00371D64
			// (set) Token: 0x0600C741 RID: 51009 RVA: 0x00373B74 File Offset: 0x00371D74
			public DateTime m_startTime
			{
				get
				{
					return this.m_owner.m_startTime;
				}
				set
				{
					this.m_owner.m_startTime = value;
				}
			}

			// Token: 0x170027A8 RID: 10152
			// (get) Token: 0x0600C742 RID: 51010 RVA: 0x00373B84 File Offset: 0x00371D84
			// (set) Token: 0x0600C743 RID: 51011 RVA: 0x00373B94 File Offset: 0x00371D94
			public DateTime m_endTime
			{
				get
				{
					return this.m_owner.m_endTime;
				}
				set
				{
					this.m_owner.m_endTime = value;
				}
			}

			// Token: 0x170027A9 RID: 10153
			// (get) Token: 0x0600C744 RID: 51012 RVA: 0x00373BA4 File Offset: 0x00371DA4
			// (set) Token: 0x0600C745 RID: 51013 RVA: 0x00373BB4 File Offset: 0x00371DB4
			public string m_deviceName
			{
				get
				{
					return this.m_owner.m_deviceName;
				}
				set
				{
					this.m_owner.m_deviceName = value;
				}
			}

			// Token: 0x170027AA RID: 10154
			// (get) Token: 0x0600C746 RID: 51014 RVA: 0x00373BC4 File Offset: 0x00371DC4
			// (set) Token: 0x0600C747 RID: 51015 RVA: 0x00373BD4 File Offset: 0x00371DD4
			public DateTime m_recordNextTickTime
			{
				get
				{
					return this.m_owner.m_recordNextTickTime;
				}
				set
				{
					this.m_owner.m_recordNextTickTime = value;
				}
			}

			// Token: 0x170027AB RID: 10155
			// (get) Token: 0x0600C748 RID: 51016 RVA: 0x00373BE4 File Offset: 0x00371DE4
			// (set) Token: 0x0600C749 RID: 51017 RVA: 0x00373BF4 File Offset: 0x00371DF4
			public ChatChannel? m_currRecordChannel
			{
				get
				{
					return this.m_owner.m_currRecordChannel;
				}
				set
				{
					this.m_owner.m_currRecordChannel = value;
				}
			}

			// Token: 0x170027AC RID: 10156
			// (get) Token: 0x0600C74A RID: 51018 RVA: 0x00373C04 File Offset: 0x00371E04
			// (set) Token: 0x0600C74B RID: 51019 RVA: 0x00373C14 File Offset: 0x00371E14
			public int VoiceMaxLength
			{
				get
				{
					return this.m_owner.VoiceMaxLength;
				}
				set
				{
					this.m_owner.VoiceMaxLength = value;
				}
			}

			// Token: 0x170027AD RID: 10157
			// (get) Token: 0x0600C74C RID: 51020 RVA: 0x00373C24 File Offset: 0x00371E24
			// (set) Token: 0x0600C74D RID: 51021 RVA: 0x00373C34 File Offset: 0x00371E34
			public int VoiceMinLength
			{
				get
				{
					return this.m_owner.VoiceMinLength;
				}
				set
				{
					this.m_owner.VoiceMinLength = value;
				}
			}

			// Token: 0x170027AE RID: 10158
			// (get) Token: 0x0600C74E RID: 51022 RVA: 0x00373C44 File Offset: 0x00371E44
			// (set) Token: 0x0600C74F RID: 51023 RVA: 0x00373C54 File Offset: 0x00371E54
			public int EncodeAndDecodeFrameSize
			{
				get
				{
					return this.m_owner.EncodeAndDecodeFrameSize;
				}
				set
				{
					this.m_owner.EncodeAndDecodeFrameSize = value;
				}
			}

			// Token: 0x170027AF RID: 10159
			// (get) Token: 0x0600C750 RID: 51024 RVA: 0x00373C64 File Offset: 0x00371E64
			// (set) Token: 0x0600C751 RID: 51025 RVA: 0x00373C74 File Offset: 0x00371E74
			public bool m_isXFRecognizing
			{
				get
				{
					return this.m_owner.m_isXFRecognizing;
				}
				set
				{
					this.m_owner.m_isXFRecognizing = value;
				}
			}

			// Token: 0x170027B0 RID: 10160
			// (get) Token: 0x0600C752 RID: 51026 RVA: 0x00373C84 File Offset: 0x00371E84
			// (set) Token: 0x0600C753 RID: 51027 RVA: 0x00373C94 File Offset: 0x00371E94
			public LinkedList<string> m_xfWaitForRecognizeFilePathList
			{
				get
				{
					return this.m_owner.m_xfWaitForRecognizeFilePathList;
				}
				set
				{
					this.m_owner.m_xfWaitForRecognizeFilePathList = value;
				}
			}

			// Token: 0x170027B1 RID: 10161
			// (get) Token: 0x0600C754 RID: 51028 RVA: 0x00373CA4 File Offset: 0x00371EA4
			// (set) Token: 0x0600C755 RID: 51029 RVA: 0x00373CB4 File Offset: 0x00371EB4
			public LinkedList<string> m_xfRecognizedResultList
			{
				get
				{
					return this.m_owner.m_xfRecognizedResultList;
				}
				set
				{
					this.m_owner.m_xfRecognizedResultList = value;
				}
			}

			// Token: 0x170027B2 RID: 10162
			// (get) Token: 0x0600C756 RID: 51030 RVA: 0x00373CC4 File Offset: 0x00371EC4
			// (set) Token: 0x0600C757 RID: 51031 RVA: 0x00373CD4 File Offset: 0x00371ED4
			public XunfeiSDKWrapper m_xfWrapper
			{
				get
				{
					return this.m_owner.m_xfWrapper;
				}
				set
				{
					this.m_owner.m_xfWrapper = value;
				}
			}

			// Token: 0x170027B3 RID: 10163
			// (get) Token: 0x0600C758 RID: 51032 RVA: 0x00373CE4 File Offset: 0x00371EE4
			// (set) Token: 0x0600C759 RID: 51033 RVA: 0x00373CEC File Offset: 0x00371EEC
			public static VoiceRecordHelper m_instance
			{
				get
				{
					return VoiceRecordHelper.m_instance;
				}
				set
				{
					VoiceRecordHelper.m_instance = value;
				}
			}

			// Token: 0x170027B4 RID: 10164
			// (get) Token: 0x0600C75A RID: 51034 RVA: 0x00373CF4 File Offset: 0x00371EF4
			// (set) Token: 0x0600C75B RID: 51035 RVA: 0x00373D04 File Offset: 0x00371F04
			public bool m_isRunningStartRecord
			{
				get
				{
					return this.m_owner.m_isRunningStartRecord;
				}
				set
				{
					this.m_owner.m_isRunningStartRecord = value;
				}
			}

			// Token: 0x170027B5 RID: 10165
			// (get) Token: 0x0600C75C RID: 51036 RVA: 0x00373D14 File Offset: 0x00371F14
			public IConfigDataLoader ConfigDataLoader
			{
				get
				{
					return this.m_owner.ConfigDataLoader;
				}
			}

			// Token: 0x0600C75D RID: 51037 RVA: 0x00373D24 File Offset: 0x00371F24
			public void Init()
			{
				this.m_owner.Init();
			}

			// Token: 0x0600C75E RID: 51038 RVA: 0x00373D34 File Offset: 0x00371F34
			public void OnStopRecord()
			{
				this.m_owner.OnStopRecord();
			}

			// Token: 0x0600C75F RID: 51039 RVA: 0x00373D44 File Offset: 0x00371F44
			public void TickForRecordVoice()
			{
				this.m_owner.TickForRecordVoice();
			}

			// Token: 0x0600C760 RID: 51040 RVA: 0x00373D54 File Offset: 0x00371F54
			public void StartXFRecognize()
			{
				this.m_owner.StartXFRecognize();
			}

			// Token: 0x0600C761 RID: 51041 RVA: 0x00373D64 File Offset: 0x00371F64
			public void OnXFSpeechRecognizedSuccess(string returnTxt)
			{
				this.m_owner.OnXFSpeechRecognizedSuccess(returnTxt);
			}

			// Token: 0x0600C762 RID: 51042 RVA: 0x00373D74 File Offset: 0x00371F74
			public void OnXFSpeechRecognizeFailed()
			{
				this.m_owner.OnXFSpeechRecognizeFailed();
			}

			// Token: 0x0600C763 RID: 51043 RVA: 0x00373D84 File Offset: 0x00371F84
			public void DeleteAudioTempFile()
			{
				this.m_owner.DeleteAudioTempFile();
			}

			// Token: 0x0600C764 RID: 51044 RVA: 0x00373D94 File Offset: 0x00371F94
			public void ClearRecord()
			{
				this.m_owner.ClearRecord();
			}

			// Token: 0x0600C765 RID: 51045 RVA: 0x00373DA4 File Offset: 0x00371FA4
			public int AllocRecordId()
			{
				return this.m_owner.AllocRecordId();
			}

			// Token: 0x14000266 RID: 614
			// (add) Token: 0x0600C766 RID: 51046 RVA: 0x00373DB4 File Offset: 0x00371FB4
			// (remove) Token: 0x0600C767 RID: 51047 RVA: 0x00373DC4 File Offset: 0x00371FC4
			public event Action m_eventStopRecord
			{
				add
				{
					this.m_owner.m_eventStopRecord += value;
				}
				remove
				{
					this.m_owner.m_eventStopRecord += value;
				}
			}

			// Token: 0x04007E24 RID: 32292
			private VoiceRecordHelper m_owner;
		}
	}
}
