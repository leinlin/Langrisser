using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200089B RID: 2203
	[HotFix]
	public class ChatGroupCompactInfo
	{
		// Token: 0x06006E7B RID: 28283 RVA: 0x001EEDF4 File Offset: 0x001ECFF4
		public ChatGroupCompactInfo(ProChatGroupCompactInfo pbGroupInfo)
		{
			this.ChatGroupId = pbGroupInfo.ChatGroupId;
			this.ChatGroupName = pbGroupInfo.ChatGroupName;
			this.Owner = new ChatUserCompactInfo(pbGroupInfo.Owner);
			this.UserCount = pbGroupInfo.UserCount;
			this.OnlineUserCount = pbGroupInfo.OnlineUserCount;
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ctorProChatGroupCompactInfo_hotfix != null)
			{
				this.m_ctorProChatGroupCompactInfo_hotfix.call(new object[]
				{
					this,
					pbGroupInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x17001BB0 RID: 7088
		// (get) Token: 0x06006E7C RID: 28284 RVA: 0x001EEEAC File Offset: 0x001ED0AC
		// (set) Token: 0x06006E7D RID: 28285 RVA: 0x001EEECC File Offset: 0x001ED0CC
		[DoNotToLua]
		public ChatGroupCompactInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ChatGroupCompactInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006E7E RID: 28286 RVA: 0x001EEED8 File Offset: 0x001ED0D8
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
					this.m_ctorProChatGroupCompactInfo_hotfix = (luaObj.RawGet("ctor") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006E7F RID: 28287 RVA: 0x001EEFA4 File Offset: 0x001ED1A4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ChatGroupCompactInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005422 RID: 21538
		public string ChatGroupId;

		// Token: 0x04005423 RID: 21539
		public string ChatGroupName;

		// Token: 0x04005424 RID: 21540
		public ChatUserCompactInfo Owner;

		// Token: 0x04005425 RID: 21541
		public int UserCount;

		// Token: 0x04005426 RID: 21542
		public int OnlineUserCount;

		// Token: 0x04005427 RID: 21543
		[DoNotToLua]
		private ChatGroupCompactInfo.LuaExportHelper luaExportHelper;

		// Token: 0x04005428 RID: 21544
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005429 RID: 21545
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400542A RID: 21546
		private LuaFunction m_ctorProChatGroupCompactInfo_hotfix;

		// Token: 0x0200089C RID: 2204
		public class LuaExportHelper
		{
			// Token: 0x06006E80 RID: 28288 RVA: 0x001EF00C File Offset: 0x001ED20C
			public LuaExportHelper(ChatGroupCompactInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400542B RID: 21547
			private ChatGroupCompactInfo m_owner;
		}
	}
}
