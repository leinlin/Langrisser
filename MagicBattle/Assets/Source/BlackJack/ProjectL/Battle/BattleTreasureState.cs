using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000399 RID: 921
	[HotFix]
	public class BattleTreasureState
	{
		// Token: 0x060036AF RID: 13999 RVA: 0x000F29D8 File Offset: 0x000F0BD8
		public BattleTreasureState()
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

		// Token: 0x17000F1C RID: 3868
		// (get) Token: 0x060036B0 RID: 14000 RVA: 0x000F2A40 File Offset: 0x000F0C40
		// (set) Token: 0x060036B1 RID: 14001 RVA: 0x000F2A60 File Offset: 0x000F0C60
		[DoNotToLua]
		public BattleTreasureState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleTreasureState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036B2 RID: 14002 RVA: 0x000F2A6C File Offset: 0x000F0C6C
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

		// Token: 0x060036B3 RID: 14003 RVA: 0x000F2B38 File Offset: 0x000F0D38
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleTreasureState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029E3 RID: 10723
		public ConfigDataBattleTreasureInfo m_battleTreasureInfo;

		// Token: 0x040029E4 RID: 10724
		public bool m_isOpened;

		// Token: 0x040029E5 RID: 10725
		public bool m_isGain;

		// Token: 0x040029E6 RID: 10726
		[DoNotToLua]
		private BattleTreasureState.LuaExportHelper luaExportHelper;

		// Token: 0x040029E7 RID: 10727
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029E8 RID: 10728
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029E9 RID: 10729
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0200039A RID: 922
		public class LuaExportHelper
		{
			// Token: 0x060036B4 RID: 14004 RVA: 0x000F2BA0 File Offset: 0x000F0DA0
			public LuaExportHelper(BattleTreasureState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029EA RID: 10730
			private BattleTreasureState m_owner;
		}
	}
}
