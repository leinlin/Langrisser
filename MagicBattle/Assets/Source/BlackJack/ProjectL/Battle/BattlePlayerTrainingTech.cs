using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x020003A9 RID: 937
	[HotFix]
	public class BattlePlayerTrainingTech
	{
		// Token: 0x06003714 RID: 14100 RVA: 0x000F5754 File Offset: 0x000F3954
		public BattlePlayerTrainingTech()
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

		// Token: 0x17000F2B RID: 3883
		// (get) Token: 0x06003715 RID: 14101 RVA: 0x000F57BC File Offset: 0x000F39BC
		// (set) Token: 0x06003716 RID: 14102 RVA: 0x000F57DC File Offset: 0x000F39DC
		[DoNotToLua]
		public BattlePlayerTrainingTech.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattlePlayerTrainingTech.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003717 RID: 14103 RVA: 0x000F57E8 File Offset: 0x000F39E8
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

		// Token: 0x06003718 RID: 14104 RVA: 0x000F58B4 File Offset: 0x000F3AB4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattlePlayerTrainingTech));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A58 RID: 10840
		public ConfigDataTrainingTechInfo TrainingTechInfo;

		// Token: 0x04002A59 RID: 10841
		public int Level;

		// Token: 0x04002A5A RID: 10842
		[DoNotToLua]
		private BattlePlayerTrainingTech.LuaExportHelper luaExportHelper;

		// Token: 0x04002A5B RID: 10843
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A5C RID: 10844
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A5D RID: 10845
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020003AA RID: 938
		public class LuaExportHelper
		{
			// Token: 0x06003719 RID: 14105 RVA: 0x000F591C File Offset: 0x000F3B1C
			public LuaExportHelper(BattlePlayerTrainingTech owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002A5E RID: 10846
			private BattlePlayerTrainingTech m_owner;
		}
	}
}
