using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200039F RID: 927
	[HotFix]
	public class ActorAnim
	{
		// Token: 0x060036C2 RID: 14018 RVA: 0x000F2F7C File Offset: 0x000F117C
		public ActorAnim()
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

		// Token: 0x17000F1F RID: 3871
		// (get) Token: 0x060036C3 RID: 14019 RVA: 0x000F2FE4 File Offset: 0x000F11E4
		// (set) Token: 0x060036C4 RID: 14020 RVA: 0x000F3004 File Offset: 0x000F1204
		[DoNotToLua]
		public ActorAnim.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ActorAnim.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036C5 RID: 14021 RVA: 0x000F3010 File Offset: 0x000F1210
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

		// Token: 0x060036C6 RID: 14022 RVA: 0x000F30DC File Offset: 0x000F12DC
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ActorAnim));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04002A0E RID: 10766
		public const string Idle = "idle";

		// Token: 0x04002A0F RID: 10767
		public const string Walk = "walk";

		// Token: 0x04002A10 RID: 10768
		public const string Run = "run";

		// Token: 0x04002A11 RID: 10769
		public const string Attack = "attack1";

		// Token: 0x04002A12 RID: 10770
		public const string SuperAttack = "superattack";

		// Token: 0x04002A13 RID: 10771
		public const string Sing = "sing";

		// Token: 0x04002A14 RID: 10772
		public const string Cast = "cast";

		// Token: 0x04002A15 RID: 10773
		public const string Hurt = "hurt";

		// Token: 0x04002A16 RID: 10774
		public const string Stun = "stun";

		// Token: 0x04002A17 RID: 10775
		public const string Die = "death";

		// Token: 0x04002A18 RID: 10776
		public const string Die1 = "death1";

		// Token: 0x04002A19 RID: 10777
		public const string Die2 = "death2";

		// Token: 0x04002A1A RID: 10778
		[DoNotToLua]
		private ActorAnim.LuaExportHelper luaExportHelper;

		// Token: 0x04002A1B RID: 10779
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A1C RID: 10780
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A1D RID: 10781
		private LuaFunction m_ctor_hotfix;

		// Token: 0x020003A0 RID: 928
		public class LuaExportHelper
		{
			// Token: 0x060036C7 RID: 14023 RVA: 0x000F3144 File Offset: 0x000F1344
			public LuaExportHelper(ActorAnim owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002A1E RID: 10782
			private ActorAnim m_owner;
		}
	}
}
