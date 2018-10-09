using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200089D RID: 2205
	[HotFix]
	public class ChatUserCompactInfo
	{
		// Token: 0x06006E81 RID: 28289 RVA: 0x001EF01C File Offset: 0x001ED21C
		public ChatUserCompactInfo(ProChatUserCompactInfo userInfo)
		{
			this.UserId = userInfo.UserId;
			this.UserName = userInfo.Name;
			this.HeadIcon = userInfo.HeadIcon;
			this.IsOnline = userInfo.Online;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorProChatUserCompactInfo_hotfix != null)
			{
				this.m_ctorProChatUserCompactInfo_hotfix.call(new object[]
				{
					this,
					userInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001BB1 RID: 7089
		// (get) Token: 0x06006E82 RID: 28290 RVA: 0x001EF0C4 File Offset: 0x001ED2C4
		// (set) Token: 0x06006E83 RID: 28291 RVA: 0x001EF138 File Offset: 0x001ED338
		public int HeadIcon
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_HeadIcon_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_HeadIcon_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<HeadIcon>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_HeadIconInt32_hotfix != null)
				{
					this.m_set_HeadIconInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<HeadIcon>k__BackingField = value;
			}
		}

		// Token: 0x17001BB2 RID: 7090
		// (get) Token: 0x06006E84 RID: 28292 RVA: 0x001EF1B0 File Offset: 0x001ED3B0
		// (set) Token: 0x06006E85 RID: 28293 RVA: 0x001EF224 File Offset: 0x001ED424
		public bool IsOnline
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsOnline_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsOnline_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsOnline>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsOnlineBoolean_hotfix != null)
				{
					this.m_set_IsOnlineBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsOnline>k__BackingField = value;
			}
		}

		// Token: 0x17001BB3 RID: 7091
		// (get) Token: 0x06006E86 RID: 28294 RVA: 0x001EF29C File Offset: 0x001ED49C
		// (set) Token: 0x06006E87 RID: 28295 RVA: 0x001EF2BC File Offset: 0x001ED4BC
		[DoNotToLua]
		public ChatUserCompactInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatUserCompactInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006E88 RID: 28296 RVA: 0x001EF2C8 File Offset: 0x001ED4C8
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
					this.m_ctorProChatUserCompactInfo_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					this.m_get_HeadIcon_hotfix = (luaObj.RawGet("get_HeadIcon") as LuaFunction);
					this.m_set_HeadIconInt32_hotfix = (luaObj.RawGet("set_HeadIcon") as LuaFunction);
					this.m_get_IsOnline_hotfix = (luaObj.RawGet("get_IsOnline") as LuaFunction);
					this.m_set_IsOnlineBoolean_hotfix = (luaObj.RawGet("set_IsOnline") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006E89 RID: 28297 RVA: 0x001EF3F8 File Offset: 0x001ED5F8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatUserCompactInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400542C RID: 21548
		public string UserId;

		// Token: 0x0400542D RID: 21549
		public string UserName;

		// Token: 0x04005430 RID: 21552
		[DoNotToLua]
		private ChatUserCompactInfo.LuaExportHelper luaExportHelper;

		// Token: 0x04005431 RID: 21553
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005432 RID: 21554
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005433 RID: 21555
		private LuaFunction m_ctorProChatUserCompactInfo_hotfix;

		// Token: 0x04005434 RID: 21556
		private LuaFunction m_get_HeadIcon_hotfix;

		// Token: 0x04005435 RID: 21557
		private LuaFunction m_set_HeadIconInt32_hotfix;

		// Token: 0x04005436 RID: 21558
		private LuaFunction m_get_IsOnline_hotfix;

		// Token: 0x04005437 RID: 21559
		private LuaFunction m_set_IsOnlineBoolean_hotfix;

		// Token: 0x0200089E RID: 2206
		public class LuaExportHelper
		{
			// Token: 0x06006E8A RID: 28298 RVA: 0x001EF460 File Offset: 0x001ED660
			public LuaExportHelper(ChatUserCompactInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04005438 RID: 21560
			private ChatUserCompactInfo m_owner;
		}
	}
}
