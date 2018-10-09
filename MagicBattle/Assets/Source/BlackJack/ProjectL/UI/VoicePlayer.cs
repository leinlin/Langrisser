using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.BJFramework.Runtime.TaskNs;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B69 RID: 2921
	[HotFix]
	public class VoicePlayer
	{
		// Token: 0x0600C6E2 RID: 50914 RVA: 0x00371688 File Offset: 0x0036F888
		public VoicePlayer()
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

		// Token: 0x0600C6E3 RID: 50915 RVA: 0x003716F0 File Offset: 0x0036F8F0
		public static void GetVoiceContentAndPlayVoice(ChatVoiceMessage chatInfo, Action onStartPlayVoice = null)
		{
			if (chatInfo.VoiceData != null)
			{
				VoicePlayer.PlayPlayerVoice(chatInfo, onStartPlayVoice);
			}
			else if (chatInfo.InstanceId != 0UL)
			{
				GetVoiceContentNetTask getVoiceContentNetTask = new GetVoiceContentNetTask(chatInfo.ChannelId, chatInfo.InstanceId);
				getVoiceContentNetTask.EventOnStop += delegate(Task task)
				{
					GetVoiceContentNetTask getVoiceContentNetTask2 = task as GetVoiceContentNetTask;
					chatInfo.VoiceData = getVoiceContentNetTask2.VoiceContent.VoiceData;
					chatInfo.AudioFrequency = getVoiceContentNetTask2.VoiceContent.AudioFrequency;
					chatInfo.SampleLength = getVoiceContentNetTask2.VoiceContent.SampleLength;
					VoicePlayer.PlayPlayerVoice(chatInfo, onStartPlayVoice);
				};
				getVoiceContentNetTask.Start(null);
			}
		}

		// Token: 0x0600C6E4 RID: 50916 RVA: 0x00371780 File Offset: 0x0036F980
		public static void PlayPlayerVoice(ChatVoiceMessage chatInfo, Action onStartPlayVoice = null)
		{
			if (chatInfo.VoiceData != null && chatInfo.VoiceData.Length != 0)
			{
				float[] data = AudioUtility.NormalizeVolume(VoiceChatCompression.Instance.Decompress(chatInfo.VoiceData, chatInfo.SampleLength, VoiceChatCompressionType.Speex));
				AudioClip audioClip = AudioClip.Create("TempClip", chatInfo.SampleLength, 1, chatInfo.AudioFrequency, false);
				audioClip.SetData(data, 0);
				if (CommonUIController.Instance != null)
				{
					AudioUtility.SetVolume("All_Game_Sounds", 0.05f, true);
				}
				GameManager.Instance.AudioManager.PlayPlayerVoice(audioClip, 1f);
				if (CommonUIController.Instance != null)
				{
					float soundEndTime = Time.unscaledTime + (float)chatInfo.VoiceLength;
					CommonUIController.Instance.StartCoroutine(new WaitUntil(delegate()
					{
						if (Time.unscaledTime > soundEndTime)
						{
							AudioUtility.SetVolume("All_Game_Sounds", 1f, true);
							return true;
						}
						return false;
					}));
				}
				if (onStartPlayVoice != null)
				{
					onStartPlayVoice();
				}
			}
		}

		// Token: 0x17002797 RID: 10135
		// (get) Token: 0x0600C6E5 RID: 50917 RVA: 0x0037186C File Offset: 0x0036FA6C
		// (set) Token: 0x0600C6E6 RID: 50918 RVA: 0x0037188C File Offset: 0x0036FA8C
		[DoNotToLua]
		public VoicePlayer.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new VoicePlayer.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C6E7 RID: 50919 RVA: 0x00371898 File Offset: 0x0036FA98
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C6E8 RID: 50920 RVA: 0x00371964 File Offset: 0x0036FB64
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(VoicePlayer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007DDB RID: 32219
		[DoNotToLua]
		private VoicePlayer.LuaExportHelper luaExportHelper;

		// Token: 0x04007DDC RID: 32220
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007DDD RID: 32221
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007DDE RID: 32222
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000B6A RID: 2922
		public class LuaExportHelper
		{
			// Token: 0x0600C6E9 RID: 50921 RVA: 0x003719CC File Offset: 0x0036FBCC
			public LuaExportHelper(VoicePlayer owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04007DDF RID: 32223
			private VoicePlayer m_owner;
		}
	}
}
