using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000393 RID: 915
	[HotFix]
	public class BattleEventTriggerState
	{
		// Token: 0x0600369C RID: 13980 RVA: 0x000F23AC File Offset: 0x000F05AC
		public BattleEventTriggerState()
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

		// Token: 0x17000F19 RID: 3865
		// (get) Token: 0x0600369D RID: 13981 RVA: 0x000F2414 File Offset: 0x000F0614
		// (set) Token: 0x0600369E RID: 13982 RVA: 0x000F2434 File Offset: 0x000F0634
		[DoNotToLua]
		public BattleEventTriggerState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleEventTriggerState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600369F RID: 13983 RVA: 0x000F2440 File Offset: 0x000F0640
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

		// Token: 0x060036A0 RID: 13984 RVA: 0x000F250C File Offset: 0x000F070C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleEventTriggerState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029B2 RID: 10674
		public int m_conditionId;

		// Token: 0x040029B3 RID: 10675
		public BattleConditionStatus m_status;

		// Token: 0x040029B4 RID: 10676
		public int m_triggerCount;

		// Token: 0x040029B5 RID: 10677
		public int m_triggerTurn;

		// Token: 0x040029B6 RID: 10678
		public ConfigDataBattleEventTriggerInfo m_triggerInfo;

		// Token: 0x040029B7 RID: 10679
		[DoNotToLua]
		private BattleEventTriggerState.LuaExportHelper luaExportHelper;

		// Token: 0x040029B8 RID: 10680
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029B9 RID: 10681
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029BA RID: 10682
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000394 RID: 916
		public class LuaExportHelper
		{
			// Token: 0x060036A1 RID: 13985 RVA: 0x000F2574 File Offset: 0x000F0774
			public LuaExportHelper(BattleEventTriggerState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029BB RID: 10683
			private BattleEventTriggerState m_owner;
		}
	}
}
