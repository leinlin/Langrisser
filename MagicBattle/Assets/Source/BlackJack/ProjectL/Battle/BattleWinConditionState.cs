using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200038F RID: 911
	[HotFix]
	public class BattleWinConditionState
	{
		// Token: 0x06003690 RID: 13968 RVA: 0x000F1FFC File Offset: 0x000F01FC
		public BattleWinConditionState()
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

		// Token: 0x17000F17 RID: 3863
		// (get) Token: 0x06003691 RID: 13969 RVA: 0x000F2064 File Offset: 0x000F0264
		// (set) Token: 0x06003692 RID: 13970 RVA: 0x000F2084 File Offset: 0x000F0284
		[DoNotToLua]
		public BattleWinConditionState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleWinConditionState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003693 RID: 13971 RVA: 0x000F2090 File Offset: 0x000F0290
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

		// Token: 0x06003694 RID: 13972 RVA: 0x000F215C File Offset: 0x000F035C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleWinConditionState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029A2 RID: 10658
		public int m_conditionId;

		// Token: 0x040029A3 RID: 10659
		public BattleConditionStatus m_status;

		// Token: 0x040029A4 RID: 10660
		public ConfigDataBattleWinConditionInfo m_winConditionInfo;

		// Token: 0x040029A5 RID: 10661
		[DoNotToLua]
		private BattleWinConditionState.LuaExportHelper luaExportHelper;

		// Token: 0x040029A6 RID: 10662
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029A7 RID: 10663
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029A8 RID: 10664
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000390 RID: 912
		public class LuaExportHelper
		{
			// Token: 0x06003695 RID: 13973 RVA: 0x000F21C4 File Offset: 0x000F03C4
			public LuaExportHelper(BattleWinConditionState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029A9 RID: 10665
			private BattleWinConditionState m_owner;
		}
	}
}
