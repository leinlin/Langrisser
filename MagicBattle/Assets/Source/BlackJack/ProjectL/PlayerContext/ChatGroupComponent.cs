using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x02000899 RID: 2201
	[HotFix]
	public class ChatGroupComponent : ChatGroupComponentCommon
	{
		// Token: 0x06006E5E RID: 28254 RVA: 0x001EE6C4 File Offset: 0x001EC8C4
		public ChatGroupComponent()
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

		// Token: 0x06006E5F RID: 28255 RVA: 0x001EE738 File Offset: 0x001EC938
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
			this.m_basicInfo = (base.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponent);
			this.m_chatComponent = (base.Owner.GetOwnerComponent("Chat") as ChatComponent);
		}

		// Token: 0x06006E60 RID: 28256 RVA: 0x001EE7D4 File Offset: 0x001EC9D4
		public ChatGroupCompactInfo GetChatGroupSimpleInfo(string groupId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetChatGroupSimpleInfoString_hotfix != null)
			{
				return (ChatGroupCompactInfo)this.m_GetChatGroupSimpleInfoString_hotfix.call(new object[]
				{
					this,
					groupId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_currChatGroupDict.ContainsKey(groupId))
			{
				return this.m_currChatGroupDict[groupId];
			}
			return null;
		}

		// Token: 0x06006E61 RID: 28257 RVA: 0x001EE870 File Offset: 0x001ECA70
		public void NotifyChatGroupInfo(List<ProChatGroupCompactInfo> chatGroupInfoList, DateTime nowServerTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NotifyChatGroupInfoList`1DateTime_hotfix != null)
			{
				this.m_NotifyChatGroupInfoList`1DateTime_hotfix.call(new object[]
				{
					this,
					chatGroupInfoList,
					nowServerTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ProChatGroupCompactInfo proChatGroupCompactInfo in chatGroupInfoList)
			{
				this.m_currChatGroupDict[proChatGroupCompactInfo.ChatGroupId] = new ChatGroupCompactInfo(proChatGroupCompactInfo);
			}
			this.m_dataLastUpdateTime = nowServerTime;
		}

		// Token: 0x06006E62 RID: 28258 RVA: 0x001EE954 File Offset: 0x001ECB54
		public void ChatGroupStateChangedNtf(ProChatGroupInfo groupInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChatGroupStateChangedNtfProChatGroupInfo_hotfix != null)
			{
				this.m_ChatGroupStateChangedNtfProChatGroupInfo_hotfix.call(new object[]
				{
					this,
					groupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			bool flag = false;
			foreach (ProChatUserInfo proChatUserInfo in groupInfo.Members)
			{
				if (proChatUserInfo.CompactInfo.UserId == this.m_basicInfo.GetUserId())
				{
					flag = true;
				}
			}
			if (flag)
			{
				this.m_currChatGroupDict[groupInfo.CompactInfo.ChatGroupId] = new ChatGroupCompactInfo(groupInfo.CompactInfo);
			}
			else if (this.m_currChatGroupDict.ContainsKey(groupInfo.CompactInfo.ChatGroupId))
			{
				this.m_currChatGroupDict.Remove(groupInfo.CompactInfo.ChatGroupId);
				this.m_chatComponent.m_currGroupChatGroupId = string.Empty;
			}
		}

		// Token: 0x17001BAB RID: 7083
		// (get) Token: 0x06006E63 RID: 28259 RVA: 0x001EEAA0 File Offset: 0x001ECCA0
		public DateTime DataLastUpdateTime
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_DataLastUpdateTime_hotfix != null)
				{
					return (DateTime)this.m_get_DataLastUpdateTime_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_dataLastUpdateTime;
			}
		}

		// Token: 0x17001BAC RID: 7084
		// (get) Token: 0x06006E64 RID: 28260 RVA: 0x001EEB14 File Offset: 0x001ECD14
		// (set) Token: 0x06006E65 RID: 28261 RVA: 0x001EEB34 File Offset: 0x001ECD34
		[DoNotToLua]
		public new ChatGroupComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatGroupComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006E66 RID: 28262 RVA: 0x001EEB40 File Offset: 0x001ECD40
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006E67 RID: 28263 RVA: 0x001EEB48 File Offset: 0x001ECD48
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006E68 RID: 28264 RVA: 0x001EEB50 File Offset: 0x001ECD50
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006E69 RID: 28265 RVA: 0x001EEB58 File Offset: 0x001ECD58
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006E6A RID: 28266 RVA: 0x001EEB60 File Offset: 0x001ECD60
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006E6B RID: 28267 RVA: 0x001EEB6C File Offset: 0x001ECD6C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006E6C RID: 28268 RVA: 0x001EEB74 File Offset: 0x001ECD74
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
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_GetChatGroupSimpleInfoString_hotfix = (luaObj.RawGet("GetChatGroupSimpleInfo") as LuaFunction);
					this.m_NotifyChatGroupInfoList`1DateTime_hotfix = (luaObj.RawGet("NotifyChatGroupInfo") as LuaFunction);
					this.m_ChatGroupStateChangedNtfProChatGroupInfo_hotfix = (luaObj.RawGet("ChatGroupStateChangedNtf") as LuaFunction);
					this.m_get_DataLastUpdateTime_hotfix = (luaObj.RawGet("get_DataLastUpdateTime") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006E6D RID: 28269 RVA: 0x001EECBC File Offset: 0x001ECEBC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005414 RID: 21524
		public DateTime m_dataLastUpdateTime;

		// Token: 0x04005415 RID: 21525
		private Dictionary<string, ChatGroupCompactInfo> m_currChatGroupDict = new Dictionary<string, ChatGroupCompactInfo>();

		// Token: 0x04005416 RID: 21526
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x04005417 RID: 21527
		protected ChatComponent m_chatComponent;

		// Token: 0x04005418 RID: 21528
		[DoNotToLua]
		private ChatGroupComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005419 RID: 21529
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400541A RID: 21530
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400541B RID: 21531
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400541C RID: 21532
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400541D RID: 21533
		private LuaFunction m_GetChatGroupSimpleInfoString_hotfix;

		// Token: 0x0400541E RID: 21534
		private LuaFunction m_NotifyChatGroupInfoList;

		// Token: 0x0400541F RID: 21535
		private LuaFunction m_ChatGroupStateChangedNtfProChatGroupInfo_hotfix;

		// Token: 0x04005420 RID: 21536
		private LuaFunction m_get_DataLastUpdateTime_hotfix;

		// Token: 0x0200089A RID: 2202
		public new class LuaExportHelper
		{
			// Token: 0x06006E6E RID: 28270 RVA: 0x001EED24 File Offset: 0x001ECF24
			public LuaExportHelper(ChatGroupComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006E6F RID: 28271 RVA: 0x001EED34 File Offset: 0x001ECF34
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006E70 RID: 28272 RVA: 0x001EED44 File Offset: 0x001ECF44
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006E71 RID: 28273 RVA: 0x001EED54 File Offset: 0x001ECF54
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006E72 RID: 28274 RVA: 0x001EED64 File Offset: 0x001ECF64
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006E73 RID: 28275 RVA: 0x001EED74 File Offset: 0x001ECF74
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006E74 RID: 28276 RVA: 0x001EED84 File Offset: 0x001ECF84
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x17001BAD RID: 7085
			// (get) Token: 0x06006E75 RID: 28277 RVA: 0x001EED94 File Offset: 0x001ECF94
			// (set) Token: 0x06006E76 RID: 28278 RVA: 0x001EEDA4 File Offset: 0x001ECFA4
			public Dictionary<string, ChatGroupCompactInfo> m_currChatGroupDict
			{
				get
				{
					return this.m_owner.m_currChatGroupDict;
				}
				set
				{
					this.m_owner.m_currChatGroupDict = value;
				}
			}

			// Token: 0x17001BAE RID: 7086
			// (get) Token: 0x06006E77 RID: 28279 RVA: 0x001EEDB4 File Offset: 0x001ECFB4
			// (set) Token: 0x06006E78 RID: 28280 RVA: 0x001EEDC4 File Offset: 0x001ECFC4
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x17001BAF RID: 7087
			// (get) Token: 0x06006E79 RID: 28281 RVA: 0x001EEDD4 File Offset: 0x001ECFD4
			// (set) Token: 0x06006E7A RID: 28282 RVA: 0x001EEDE4 File Offset: 0x001ECFE4
			public ChatComponent m_chatComponent
			{
				get
				{
					return this.m_owner.m_chatComponent;
				}
				set
				{
					this.m_owner.m_chatComponent = value;
				}
			}

			// Token: 0x04005421 RID: 21537
			private ChatGroupComponent m_owner;
		}
	}
}
