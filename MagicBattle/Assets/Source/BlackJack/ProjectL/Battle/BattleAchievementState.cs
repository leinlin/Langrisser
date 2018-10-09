using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200038B RID: 907
	[HotFix]
	public class BattleAchievementState
	{
		// Token: 0x0600368A RID: 13962 RVA: 0x000F1E24 File Offset: 0x000F0024
		public BattleAchievementState()
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

		// Token: 0x17000F16 RID: 3862
		// (get) Token: 0x0600368B RID: 13963 RVA: 0x000F1E8C File Offset: 0x000F008C
		// (set) Token: 0x0600368C RID: 13964 RVA: 0x000F1EAC File Offset: 0x000F00AC
		[DoNotToLua]
		public BattleAchievementState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleAchievementState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600368D RID: 13965 RVA: 0x000F1EB8 File Offset: 0x000F00B8
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

		// Token: 0x0600368E RID: 13966 RVA: 0x000F1F84 File Offset: 0x000F0184
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleAchievementState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002990 RID: 10640
		public int m_conditionId;

		// Token: 0x04002991 RID: 10641
		public BattleConditionStatus m_status;

		// Token: 0x04002992 RID: 10642
		public ConfigDataBattleAchievementRelatedInfo m_achievementRelatedInfo;

		// Token: 0x04002993 RID: 10643
		public int m_turnCount;

		// Token: 0x04002994 RID: 10644
		[DoNotToLua]
		private BattleAchievementState.LuaExportHelper luaExportHelper;

		// Token: 0x04002995 RID: 10645
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002996 RID: 10646
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002997 RID: 10647
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0200038C RID: 908
		public class LuaExportHelper
		{
			// Token: 0x0600368F RID: 13967 RVA: 0x000F1FEC File Offset: 0x000F01EC
			public LuaExportHelper(BattleAchievementState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002998 RID: 10648
			private BattleAchievementState m_owner;
		}
	}
}
