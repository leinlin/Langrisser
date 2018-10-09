using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000395 RID: 917
	[HotFix]
	public class BattleTeamSetup
	{
		// Token: 0x060036A2 RID: 13986 RVA: 0x000F2584 File Offset: 0x000F0784
		public BattleTeamSetup()
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

		// Token: 0x060036A3 RID: 13987 RVA: 0x000F25F8 File Offset: 0x000F07F8
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_actors.Clear();
		}

		// Token: 0x17000F1A RID: 3866
		// (get) Token: 0x060036A4 RID: 13988 RVA: 0x000F2664 File Offset: 0x000F0864
		// (set) Token: 0x060036A5 RID: 13989 RVA: 0x000F2684 File Offset: 0x000F0884
		[DoNotToLua]
		public BattleTeamSetup.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleTeamSetup.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036A6 RID: 13990 RVA: 0x000F2690 File Offset: 0x000F0890
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060036A7 RID: 13991 RVA: 0x000F2774 File Offset: 0x000F0974
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTeamSetup));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029BC RID: 10684
		public List<BattleActorSetup> m_actors = new List<BattleActorSetup>();

		// Token: 0x040029BD RID: 10685
		[DoNotToLua]
		private BattleTeamSetup.LuaExportHelper luaExportHelper;

		// Token: 0x040029BE RID: 10686
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029BF RID: 10687
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029C0 RID: 10688
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040029C1 RID: 10689
		private LuaFunction m_Clear_hotfix;

		// Token: 0x02000396 RID: 918
		public class LuaExportHelper
		{
			// Token: 0x060036A8 RID: 13992 RVA: 0x000F27DC File Offset: 0x000F09DC
			public LuaExportHelper(BattleTeamSetup owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029C2 RID: 10690
			private BattleTeamSetup m_owner;
		}
	}
}
