using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020003FB RID: 1019
	[HotFix]
	[CustomLuaClass]
	public class GuildMassiveCombatMemberInfo
	{
		// Token: 0x06003BD5 RID: 15317 RVA: 0x00110290 File Offset: 0x0010E490
		public GuildMassiveCombatMemberInfo()
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

		// Token: 0x17001043 RID: 4163
		// (get) Token: 0x06003BD6 RID: 15318 RVA: 0x00110304 File Offset: 0x0010E504
		// (set) Token: 0x06003BD7 RID: 15319 RVA: 0x00110378 File Offset: 0x0010E578
		public string UserId
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_UserId_hotfix != null)
				{
					return (string)this.m_get_UserId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<UserId>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_UserIdString_hotfix != null)
				{
					this.m_set_UserIdString_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<UserId>k__BackingField = value;
			}
		}

		// Token: 0x17001044 RID: 4164
		// (get) Token: 0x06003BD8 RID: 15320 RVA: 0x001103F0 File Offset: 0x0010E5F0
		// (set) Token: 0x06003BD9 RID: 15321 RVA: 0x00110464 File Offset: 0x0010E664
		public int Points
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Points_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_Points_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Points>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PointsInt32_hotfix != null)
				{
					this.m_set_PointsInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Points>k__BackingField = value;
			}
		}

		// Token: 0x17001045 RID: 4165
		// (get) Token: 0x06003BDA RID: 15322 RVA: 0x001104DC File Offset: 0x0010E6DC
		// (set) Token: 0x06003BDB RID: 15323 RVA: 0x00110550 File Offset: 0x0010E750
		public int PointsToday
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_PointsToday_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_PointsToday_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<PointsToday>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_PointsTodayInt32_hotfix != null)
				{
					this.m_set_PointsTodayInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<PointsToday>k__BackingField = value;
			}
		}

		// Token: 0x17001046 RID: 4166
		// (get) Token: 0x06003BDC RID: 15324 RVA: 0x001105C8 File Offset: 0x0010E7C8
		// (set) Token: 0x06003BDD RID: 15325 RVA: 0x0011063C File Offset: 0x0010E83C
		public GuildTitle Title
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Title_hotfix != null)
				{
					return (GuildTitle)this.m_get_Title_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Title>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_TitleGuildTitle_hotfix != null)
				{
					this.m_set_TitleGuildTitle_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Title>k__BackingField = value;
			}
		}

		// Token: 0x17001047 RID: 4167
		// (get) Token: 0x06003BDE RID: 15326 RVA: 0x001106B4 File Offset: 0x0010E8B4
		// (set) Token: 0x06003BDF RID: 15327 RVA: 0x001106D4 File Offset: 0x0010E8D4
		[DoNotToLua]
		public GuildMassiveCombatMemberInfo.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GuildMassiveCombatMemberInfo.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003BE0 RID: 15328 RVA: 0x001106E0 File Offset: 0x0010E8E0
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
					this.m_get_UserId_hotfix = (luaObj.RawGet("get_UserId") as LuaFunction);
					this.m_set_UserIdString_hotfix = (luaObj.RawGet("set_UserId") as LuaFunction);
					this.m_get_Points_hotfix = (luaObj.RawGet("get_Points") as LuaFunction);
					this.m_set_PointsInt32_hotfix = (luaObj.RawGet("set_Points") as LuaFunction);
					this.m_get_PointsToday_hotfix = (luaObj.RawGet("get_PointsToday") as LuaFunction);
					this.m_set_PointsTodayInt32_hotfix = (luaObj.RawGet("set_PointsToday") as LuaFunction);
					this.m_get_Title_hotfix = (luaObj.RawGet("get_Title") as LuaFunction);
					this.m_set_TitleGuildTitle_hotfix = (luaObj.RawGet("set_Title") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003BE1 RID: 15329 RVA: 0x00110874 File Offset: 0x0010EA74
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GuildMassiveCombatMemberInfo));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002DA2 RID: 11682
		public List<int> PointsRewardsClaimed = new List<int>();

		// Token: 0x04002DA4 RID: 11684
		public UserSummary Summary;

		// Token: 0x04002DA5 RID: 11685
		[DoNotToLua]
		private GuildMassiveCombatMemberInfo.LuaExportHelper luaExportHelper;

		// Token: 0x04002DA6 RID: 11686
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002DA7 RID: 11687
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002DA8 RID: 11688
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002DA9 RID: 11689
		private LuaFunction m_get_UserId_hotfix;

		// Token: 0x04002DAA RID: 11690
		private LuaFunction m_set_UserIdString_hotfix;

		// Token: 0x04002DAB RID: 11691
		private LuaFunction m_get_Points_hotfix;

		// Token: 0x04002DAC RID: 11692
		private LuaFunction m_set_PointsInt32_hotfix;

		// Token: 0x04002DAD RID: 11693
		private LuaFunction m_get_PointsToday_hotfix;

		// Token: 0x04002DAE RID: 11694
		private LuaFunction m_set_PointsTodayInt32_hotfix;

		// Token: 0x04002DAF RID: 11695
		private LuaFunction m_get_Title_hotfix;

		// Token: 0x04002DB0 RID: 11696
		private LuaFunction m_set_TitleGuildTitle_hotfix;

		// Token: 0x020003FC RID: 1020
		public class LuaExportHelper
		{
			// Token: 0x06003BE2 RID: 15330 RVA: 0x001108DC File Offset: 0x0010EADC
			public LuaExportHelper(GuildMassiveCombatMemberInfo owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002DB1 RID: 11697
			private GuildMassiveCombatMemberInfo m_owner;
		}
	}
}
