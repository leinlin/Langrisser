using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.UI
{
	// Token: 0x02000AF4 RID: 2804
	[HotFix]
	public class StagePosition
	{
		// Token: 0x0600BB1A RID: 47898 RVA: 0x00348520 File Offset: 0x00346720
		public StagePosition()
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

		// Token: 0x1700256C RID: 9580
		// (get) Token: 0x0600BB1B RID: 47899 RVA: 0x00348588 File Offset: 0x00346788
		// (set) Token: 0x0600BB1C RID: 47900 RVA: 0x003485A8 File Offset: 0x003467A8
		[DoNotToLua]
		public StagePosition.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new StagePosition.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600BB1D RID: 47901 RVA: 0x003485B4 File Offset: 0x003467B4
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

		// Token: 0x0600BB1E RID: 47902 RVA: 0x00348680 File Offset: 0x00346880
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(StagePosition));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400784C RID: 30796
		public GridPosition Position;

		// Token: 0x0400784D RID: 30797
		public int Direction;

		// Token: 0x0400784E RID: 30798
		public StagePositionType PositionType;

		// Token: 0x0400784F RID: 30799
		public BattleHero Hero;

		// Token: 0x04007850 RID: 30800
		public int PlayerIndex;

		// Token: 0x04007851 RID: 30801
		[DoNotToLua]
		private StagePosition.LuaExportHelper luaExportHelper;

		// Token: 0x04007852 RID: 30802
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04007853 RID: 30803
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04007854 RID: 30804
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000AF5 RID: 2805
		public class LuaExportHelper
		{
			// Token: 0x0600BB1F RID: 47903 RVA: 0x003486E8 File Offset: 0x003468E8
			public LuaExportHelper(StagePosition owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04007855 RID: 30805
			private StagePosition m_owner;
		}
	}
}
