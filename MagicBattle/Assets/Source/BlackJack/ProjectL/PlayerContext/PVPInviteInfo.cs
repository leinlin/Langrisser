using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008AF RID: 2223
	[HotFix]
	public class PVPInviteInfo
	{
		// Token: 0x06006FF8 RID: 28664 RVA: 0x001F4AE8 File Offset: 0x001F2CE8
		public PVPInviteInfo()
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

		// Token: 0x17001BC6 RID: 7110
		// (get) Token: 0x06006FF9 RID: 28665 RVA: 0x001F4B50 File Offset: 0x001F2D50
		// (set) Token: 0x06006FFA RID: 28666 RVA: 0x001F4B70 File Offset: 0x001F2D70
		[DoNotToLua]
		public PVPInviteInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PVPInviteInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006FFB RID: 28667 RVA: 0x001F4B7C File Offset: 0x001F2D7C
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006FFC RID: 28668 RVA: 0x001F4C48 File Offset: 0x001F2E48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PVPInviteInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040054BD RID: 21693
		public UserSummary Inviter;

		// Token: 0x040054BE RID: 21694
		public DateTime Timeout;

		// Token: 0x040054BF RID: 21695
		[DoNotToLua]
		private PVPInviteInfo.LuaExportHelper luaExportHelper;

		// Token: 0x040054C0 RID: 21696
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040054C1 RID: 21697
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040054C2 RID: 21698
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020008B0 RID: 2224
		public class LuaExportHelper
		{
			// Token: 0x06006FFD RID: 28669 RVA: 0x001F4CB0 File Offset: 0x001F2EB0
			public LuaExportHelper(PVPInviteInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040054C3 RID: 21699
			private PVPInviteInfo m_owner;
		}
	}
}
