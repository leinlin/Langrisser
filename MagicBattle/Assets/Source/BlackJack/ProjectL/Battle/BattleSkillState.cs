using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000385 RID: 901
	[HotFix]
	public class BattleSkillState
	{
		// Token: 0x06003484 RID: 13444 RVA: 0x000DF6E8 File Offset: 0x000DD8E8
		public BattleSkillState()
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

		// Token: 0x17000EB9 RID: 3769
		// (get) Token: 0x06003485 RID: 13445 RVA: 0x000DF750 File Offset: 0x000DD950
		// (set) Token: 0x06003486 RID: 13446 RVA: 0x000DF770 File Offset: 0x000DD970
		[DoNotToLua]
		public BattleSkillState.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleSkillState.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003487 RID: 13447 RVA: 0x000DF77C File Offset: 0x000DD97C
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

		// Token: 0x06003488 RID: 13448 RVA: 0x000DF848 File Offset: 0x000DDA48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleSkillState));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002846 RID: 10310
		public ConfigDataSkillInfo m_skillInfo;

		// Token: 0x04002847 RID: 10311
		public int m_cooldown;

		// Token: 0x04002848 RID: 10312
		public bool m_isSkillUseable;

		// Token: 0x04002849 RID: 10313
		[DoNotToLua]
		private BattleSkillState.LuaExportHelper luaExportHelper;

		// Token: 0x0400284A RID: 10314
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400284B RID: 10315
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400284C RID: 10316
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000386 RID: 902
		public class LuaExportHelper
		{
			// Token: 0x06003489 RID: 13449 RVA: 0x000DF8B0 File Offset: 0x000DDAB0
			public LuaExportHelper(BattleSkillState owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0400284D RID: 10317
			private BattleSkillState m_owner;
		}
	}
}
