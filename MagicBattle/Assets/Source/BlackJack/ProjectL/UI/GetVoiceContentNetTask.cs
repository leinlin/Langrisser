using System;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000B6D RID: 2925
	[HotFix]
	public class GetVoiceContentNetTask : UINetTask
	{
		// Token: 0x0600C6EE RID: 50926 RVA: 0x00371A7C File Offset: 0x0036FC7C
		public GetVoiceContentNetTask(ChatChannel channel, ulong instanceId) : base(10f, null, true)
		{
			this.m_channel = channel;
			this.m_instanceId = instanceId;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorChatChannelUInt64_hotfix != null)
			{
				this.m_ctorChatChannelUInt64_hotfix.call(new object[]
				{
					this,
					channel,
					instanceId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x0600C6EF RID: 50927 RVA: 0x00371B18 File Offset: 0x0036FD18
		protected override void RegisterNetworkEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RegisterNetworkEvent_hotfix != null)
			{
				this.m_RegisterNetworkEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.RegisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			projectLPlayerContext.EventOnChatGetVoiceContentAck += this.OnGetVoiceContentAck;
		}

		// Token: 0x0600C6F0 RID: 50928 RVA: 0x00371BA0 File Offset: 0x0036FDA0
		protected override void UnregisterNetworkEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UnregisterNetworkEvent_hotfix != null)
			{
				this.m_UnregisterNetworkEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.UnregisterNetworkEvent();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			if (projectLPlayerContext != null)
			{
				projectLPlayerContext.EventOnChatGetVoiceContentAck -= this.OnGetVoiceContentAck;
			}
		}

		// Token: 0x0600C6F1 RID: 50929 RVA: 0x00371C30 File Offset: 0x0036FE30
		protected override bool StartNetWorking()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_StartNetWorking_hotfix != null)
			{
				return Convert.ToBoolean(this.m_StartNetWorking_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.StartNetWorking();
			ProjectLPlayerContext projectLPlayerContext = GameManager.Instance.PlayerContext as ProjectLPlayerContext;
			return projectLPlayerContext.SendGetVoiceContentMessage(this.m_channel, this.m_instanceId);
		}

		// Token: 0x0600C6F2 RID: 50930 RVA: 0x00371CCC File Offset: 0x0036FECC
		private void OnGetVoiceContentAck(ChatVoiceMessage voiceContent)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnGetVoiceContentAckChatVoiceMessage_hotfix != null)
			{
				this.m_OnGetVoiceContentAckChatVoiceMessage_hotfix.call(new object[]
				{
					this,
					voiceContent
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_voiceContent = voiceContent;
			base.Stop();
		}

		// Token: 0x17002798 RID: 10136
		// (get) Token: 0x0600C6F3 RID: 50931 RVA: 0x00371D4C File Offset: 0x0036FF4C
		public ChatVoiceMessage VoiceContent
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_VoiceContent_hotfix != null)
				{
					return (ChatVoiceMessage)this.m_get_VoiceContent_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_voiceContent;
			}
		}

		// Token: 0x17002799 RID: 10137
		// (get) Token: 0x0600C6F4 RID: 50932 RVA: 0x00371DC0 File Offset: 0x0036FFC0
		// (set) Token: 0x0600C6F5 RID: 50933 RVA: 0x00371DE0 File Offset: 0x0036FFE0
		[DoNotToLua]
		public new GetVoiceContentNetTask.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GetVoiceContentNetTask.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600C6F6 RID: 50934 RVA: 0x00371DEC File Offset: 0x0036FFEC
		private bool __callBase_OnStart(object param)
		{
			return base.OnStart(param);
		}

		// Token: 0x0600C6F7 RID: 50935 RVA: 0x00371DF8 File Offset: 0x0036FFF8
		private void __callBase_OnStop()
		{
			base.OnStop();
		}

		// Token: 0x0600C6F8 RID: 50936 RVA: 0x00371E00 File Offset: 0x00370000
		private void __callBase_OnTimeOut()
		{
			base.OnTimeOut();
		}

		// Token: 0x0600C6F9 RID: 50937 RVA: 0x00371E08 File Offset: 0x00370008
		private void __callBase_OnReLoginSuccess()
		{
			base.OnReLoginSuccess();
		}

		// Token: 0x0600C6FA RID: 50938 RVA: 0x00371E10 File Offset: 0x00370010
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
					this.m_ctorChatChannelUInt64_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_RegisterNetworkEvent_hotfix = (luaObj.RawGet("RegisterNetworkEvent") as LuaFunction);
					this.m_UnregisterNetworkEvent_hotfix = (luaObj.RawGet("UnregisterNetworkEvent") as LuaFunction);
					this.m_StartNetWorking_hotfix = (luaObj.RawGet("StartNetWorking") as LuaFunction);
					this.m_OnGetVoiceContentAckChatVoiceMessage_hotfix = (luaObj.RawGet("OnGetVoiceContentAck") as LuaFunction);
					this.m_get_VoiceContent_hotfix = (luaObj.RawGet("get_VoiceContent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600C6FB RID: 50939 RVA: 0x00371F58 File Offset: 0x00370158
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GetVoiceContentNetTask));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04007DE3 RID: 32227
		private ulong m_instanceId;

		// Token: 0x04007DE4 RID: 32228
		private ChatChannel m_channel;

		// Token: 0x04007DE5 RID: 32229
		private ChatVoiceMessage m_voiceContent;

		// Token: 0x04007DE6 RID: 32230
		[DoNotToLua]
		private GetVoiceContentNetTask.LuaExportHelper luaExportHelper;

		// Token: 0x04007DE7 RID: 32231
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007DE8 RID: 32232
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007DE9 RID: 32233
		private LuaFunction m_ctorChatChannelUInt64_hotfix;

		// Token: 0x04007DEA RID: 32234
		private LuaFunction m_RegisterNetworkEvent_hotfix;

		// Token: 0x04007DEB RID: 32235
		private LuaFunction m_UnregisterNetworkEvent_hotfix;

		// Token: 0x04007DEC RID: 32236
		private LuaFunction m_StartNetWorking_hotfix;

		// Token: 0x04007DED RID: 32237
		private LuaFunction m_OnGetVoiceContentAckChatVoiceMessage_hotfix;

		// Token: 0x04007DEE RID: 32238
		private LuaFunction m_get_VoiceContent_hotfix;

		// Token: 0x02000B6E RID: 2926
		public new class LuaExportHelper
		{
			// Token: 0x0600C6FC RID: 50940 RVA: 0x00371FC0 File Offset: 0x003701C0
			public LuaExportHelper(GetVoiceContentNetTask owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600C6FD RID: 50941 RVA: 0x00371FD0 File Offset: 0x003701D0
			public bool __callBase_OnStart(object param)
			{
				return this.m_owner.__callBase_OnStart(param);
			}

			// Token: 0x0600C6FE RID: 50942 RVA: 0x00371FE0 File Offset: 0x003701E0
			public void __callBase_OnStop()
			{
				this.m_owner.__callBase_OnStop();
			}

			// Token: 0x0600C6FF RID: 50943 RVA: 0x00371FF0 File Offset: 0x003701F0
			public void __callBase_OnTimeOut()
			{
				this.m_owner.__callBase_OnTimeOut();
			}

			// Token: 0x0600C700 RID: 50944 RVA: 0x00372000 File Offset: 0x00370200
			public void __callBase_OnReLoginSuccess()
			{
				this.m_owner.__callBase_OnReLoginSuccess();
			}

			// Token: 0x1700279A RID: 10138
			// (get) Token: 0x0600C701 RID: 50945 RVA: 0x00372010 File Offset: 0x00370210
			// (set) Token: 0x0600C702 RID: 50946 RVA: 0x00372020 File Offset: 0x00370220
			public ulong m_instanceId
			{
				get
				{
					return this.m_owner.m_instanceId;
				}
				set
				{
					this.m_owner.m_instanceId = value;
				}
			}

			// Token: 0x1700279B RID: 10139
			// (get) Token: 0x0600C703 RID: 50947 RVA: 0x00372030 File Offset: 0x00370230
			// (set) Token: 0x0600C704 RID: 50948 RVA: 0x00372040 File Offset: 0x00370240
			public ChatChannel m_channel
			{
				get
				{
					return this.m_owner.m_channel;
				}
				set
				{
					this.m_owner.m_channel = value;
				}
			}

			// Token: 0x1700279C RID: 10140
			// (get) Token: 0x0600C705 RID: 50949 RVA: 0x00372050 File Offset: 0x00370250
			// (set) Token: 0x0600C706 RID: 50950 RVA: 0x00372060 File Offset: 0x00370260
			public ChatVoiceMessage m_voiceContent
			{
				get
				{
					return this.m_owner.m_voiceContent;
				}
				set
				{
					this.m_owner.m_voiceContent = value;
				}
			}

			// Token: 0x0600C707 RID: 50951 RVA: 0x00372070 File Offset: 0x00370270
			public void RegisterNetworkEvent()
			{
				this.m_owner.RegisterNetworkEvent();
			}

			// Token: 0x0600C708 RID: 50952 RVA: 0x00372080 File Offset: 0x00370280
			public void UnregisterNetworkEvent()
			{
				this.m_owner.UnregisterNetworkEvent();
			}

			// Token: 0x0600C709 RID: 50953 RVA: 0x00372090 File Offset: 0x00370290
			public bool StartNetWorking()
			{
				return this.m_owner.StartNetWorking();
			}

			// Token: 0x0600C70A RID: 50954 RVA: 0x003720A0 File Offset: 0x003702A0
			public void OnGetVoiceContentAck(ChatVoiceMessage voiceContent)
			{
				this.m_owner.OnGetVoiceContentAck(voiceContent);
			}

			// Token: 0x04007DEF RID: 32239
			private GetVoiceContentNetTask m_owner;
		}
	}
}
