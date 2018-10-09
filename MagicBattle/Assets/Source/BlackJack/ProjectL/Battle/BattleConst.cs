using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200039B RID: 923
	[HotFix]
	public class BattleConst
	{
		// Token: 0x060036B5 RID: 14005 RVA: 0x000F2BB0 File Offset: 0x000F0DB0
		public BattleConst()
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

		// Token: 0x17000F1D RID: 3869
		// (get) Token: 0x060036B6 RID: 14006 RVA: 0x000F2C18 File Offset: 0x000F0E18
		// (set) Token: 0x060036B7 RID: 14007 RVA: 0x000F2C38 File Offset: 0x000F0E38
		[DoNotToLua]
		public BattleConst.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleConst.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036B8 RID: 14008 RVA: 0x000F2C44 File Offset: 0x000F0E44
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

		// Token: 0x060036B9 RID: 14009 RVA: 0x000F2D10 File Offset: 0x000F0F10
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleConst));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029EB RID: 10731
		[DoNotToLua]
		private BattleConst.LuaExportHelper luaExportHelper;

		// Token: 0x040029EC RID: 10732
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029ED RID: 10733
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029EE RID: 10734
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0200039C RID: 924
		public class LuaExportHelper
		{
			// Token: 0x060036BA RID: 14010 RVA: 0x000F2D78 File Offset: 0x000F0F78
			public LuaExportHelper(BattleConst owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029EF RID: 10735
			private BattleConst m_owner;
		}
	}
}
