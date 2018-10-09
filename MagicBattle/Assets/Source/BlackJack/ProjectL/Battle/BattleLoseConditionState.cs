using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000391 RID: 913
	[HotFix]
	public class BattleLoseConditionState
	{
		// Token: 0x06003696 RID: 13974 RVA: 0x000F21D4 File Offset: 0x000F03D4
		public BattleLoseConditionState()
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

		// Token: 0x17000F18 RID: 3864
		// (get) Token: 0x06003697 RID: 13975 RVA: 0x000F223C File Offset: 0x000F043C
		// (set) Token: 0x06003698 RID: 13976 RVA: 0x000F225C File Offset: 0x000F045C
		[DoNotToLua]
		public BattleLoseConditionState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleLoseConditionState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003699 RID: 13977 RVA: 0x000F2268 File Offset: 0x000F0468
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

		// Token: 0x0600369A RID: 13978 RVA: 0x000F2334 File Offset: 0x000F0534
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleLoseConditionState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029AA RID: 10666
		public int m_conditionId;

		// Token: 0x040029AB RID: 10667
		public BattleConditionStatus m_status;

		// Token: 0x040029AC RID: 10668
		public ConfigDataBattleLoseConditionInfo m_loseConditionInfo;

		// Token: 0x040029AD RID: 10669
		[DoNotToLua]
		private BattleLoseConditionState.LuaExportHelper luaExportHelper;

		// Token: 0x040029AE RID: 10670
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029AF RID: 10671
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029B0 RID: 10672
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000392 RID: 914
		public class LuaExportHelper
		{
			// Token: 0x0600369B RID: 13979 RVA: 0x000F239C File Offset: 0x000F059C
			public LuaExportHelper(BattleLoseConditionState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029B1 RID: 10673
			private BattleLoseConditionState m_owner;
		}
	}
}
