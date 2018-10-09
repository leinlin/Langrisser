using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x020009C2 RID: 2498
	[HotFix]
	public class ActivityNoticeInfo
	{
		// Token: 0x06009180 RID: 37248 RVA: 0x002A2158 File Offset: 0x002A0358
		public ActivityNoticeInfo()
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

		// Token: 0x17001E34 RID: 7732
		// (get) Token: 0x06009181 RID: 37249 RVA: 0x002A21C0 File Offset: 0x002A03C0
		// (set) Token: 0x06009182 RID: 37250 RVA: 0x002A21E0 File Offset: 0x002A03E0
		[DoNotToLua]
		public ActivityNoticeInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActivityNoticeInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06009183 RID: 37251 RVA: 0x002A21EC File Offset: 0x002A03EC
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

		// Token: 0x06009184 RID: 37252 RVA: 0x002A22B8 File Offset: 0x002A04B8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActivityNoticeInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040065F5 RID: 26101
		public int ActivityId;

		// Token: 0x040065F6 RID: 26102
		public bool IsLarge;

		// Token: 0x040065F7 RID: 26103
		public int SortId;

		// Token: 0x040065F8 RID: 26104
		public string ImageName;

		// Token: 0x040065F9 RID: 26105
		public string Desc;

		// Token: 0x040065FA RID: 26106
		[DoNotToLua]
		private ActivityNoticeInfo.LuaExportHelper luaExportHelper;

		// Token: 0x040065FB RID: 26107
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040065FC RID: 26108
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040065FD RID: 26109
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020009C3 RID: 2499
		public class LuaExportHelper
		{
			// Token: 0x06009185 RID: 37253 RVA: 0x002A2320 File Offset: 0x002A0520
			public LuaExportHelper(ActivityNoticeInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040065FE RID: 26110
			private ActivityNoticeInfo m_owner;
		}
	}
}
