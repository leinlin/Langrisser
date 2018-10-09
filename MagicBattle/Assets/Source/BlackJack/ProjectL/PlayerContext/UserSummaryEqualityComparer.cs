using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008B1 RID: 2225
	[HotFix]
	public class UserSummaryEqualityComparer : IEqualityComparer<UserSummary>
	{
		// Token: 0x06006FFE RID: 28670 RVA: 0x001F4CC0 File Offset: 0x001F2EC0
		public UserSummaryEqualityComparer()
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

		// Token: 0x06006FFF RID: 28671 RVA: 0x001F4D28 File Offset: 0x001F2F28
		public bool Equals(UserSummary x, UserSummary y)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_EqualsUserSummaryUserSummary_hotfix != null)
			{
				return Convert.ToBoolean(this.m_EqualsUserSummaryUserSummary_hotfix.call(new object[]
				{
					this,
					x,
					y
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return x.UserId == y.UserId;
		}

		// Token: 0x06007000 RID: 28672 RVA: 0x001F4DC8 File Offset: 0x001F2FC8
		public int GetHashCode(UserSummary obj)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHashCodeUserSummary_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHashCodeUserSummary_hotfix.call(new object[]
				{
					this,
					obj
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return obj.GetHashCode();
		}

		// Token: 0x17001BC7 RID: 7111
		// (get) Token: 0x06007001 RID: 28673 RVA: 0x001F4E4C File Offset: 0x001F304C
		// (set) Token: 0x06007002 RID: 28674 RVA: 0x001F4E6C File Offset: 0x001F306C
		[DoNotToLua]
		public UserSummaryEqualityComparer.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new UserSummaryEqualityComparer.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007003 RID: 28675 RVA: 0x001F4E78 File Offset: 0x001F3078
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
					this.m_EqualsUserSummaryUserSummary_hotfix = (luaObj.RawGet("Equals") as LuaFunction);
					this.m_GetHashCodeUserSummary_hotfix = (luaObj.RawGet("GetHashCode") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007004 RID: 28676 RVA: 0x001F4F78 File Offset: 0x001F3178
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(UserSummaryEqualityComparer));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040054C4 RID: 21700
		[DoNotToLua]
		private UserSummaryEqualityComparer.LuaExportHelper luaExportHelper;

		// Token: 0x040054C5 RID: 21701
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040054C6 RID: 21702
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040054C7 RID: 21703
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040054C8 RID: 21704
		private LuaFunction m_EqualsUserSummaryUserSummary_hotfix;

		// Token: 0x040054C9 RID: 21705
		private LuaFunction m_GetHashCodeUserSummary_hotfix;

		// Token: 0x020008B2 RID: 2226
		public class LuaExportHelper
		{
			// Token: 0x06007005 RID: 28677 RVA: 0x001F4FE0 File Offset: 0x001F31E0
			public LuaExportHelper(UserSummaryEqualityComparer owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040054CA RID: 21706
			private UserSummaryEqualityComparer m_owner;
		}
	}
}
