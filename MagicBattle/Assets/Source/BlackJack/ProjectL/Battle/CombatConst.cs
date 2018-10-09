using System;
using BlackJack.BJFramework.Runtime.Lua;
using FixMath.NET;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x0200039D RID: 925
	[HotFix]
	public class CombatConst
	{
		// Token: 0x060036BB RID: 14011 RVA: 0x000F2D88 File Offset: 0x000F0F88
		public CombatConst()
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

		// Token: 0x17000F1E RID: 3870
		// (get) Token: 0x060036BC RID: 14012 RVA: 0x000F2DF0 File Offset: 0x000F0FF0
		// (set) Token: 0x060036BD RID: 14013 RVA: 0x000F2E10 File Offset: 0x000F1010
		[DoNotToLua]
		public CombatConst.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CombatConst.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036BF RID: 14015 RVA: 0x000F2E38 File Offset: 0x000F1038
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

		// Token: 0x060036C0 RID: 14016 RVA: 0x000F2F04 File Offset: 0x000F1104
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CombatConst));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029F0 RID: 10736
		public const int TickRate = 30;

		// Token: 0x040029F1 RID: 10737
		public static readonly Fix64 TickTime = Fix64.One / (Fix64)30L;

		// Token: 0x040029F2 RID: 10738
		public const int CameraAngle = 30;

		// Token: 0x040029F3 RID: 10739
		public const float CameraAngleSin = 0.5f;

		// Token: 0x040029F4 RID: 10740
		public const float CameraAngleCos = 0.866f;

		// Token: 0x040029F5 RID: 10741
		public const float CombatToWorldXScale = 0.02f;

		// Token: 0x040029F6 RID: 10742
		public const float CombatToWorldYScale = 0.01f;

		// Token: 0x040029F7 RID: 10743
		public const float CombatToWorldZScale = 0.01732f;

		// Token: 0x040029F8 RID: 10744
		public const float CombatToWorldXOblique = -0.005f;

		// Token: 0x040029F9 RID: 10745
		public const float CombatToWorldZOffset = 0.005f;

		// Token: 0x040029FA RID: 10746
		public const int HeroInitY = -20;

		// Token: 0x040029FB RID: 10747
		public const int HeroSoldierColumnSpace = 60;

		// Token: 0x040029FC RID: 10748
		public const int SoldierColumnSpace = 50;

		// Token: 0x040029FD RID: 10749
		public const int SoldierRowSpace = 40;

		// Token: 0x040029FE RID: 10750
		public const int EnterMoveDistance = 500;

		// Token: 0x040029FF RID: 10751
		public const int EnterMoveTime = 250;

		// Token: 0x04002A00 RID: 10752
		public const int ChargeReturnDistance = 300;

		// Token: 0x04002A01 RID: 10753
		public const int HitMaxDistance = 100;

		// Token: 0x04002A02 RID: 10754
		public const int SkillFadeZOffset = 25;

		// Token: 0x04002A03 RID: 10755
		public const int FlyObjectDownStraightZ = 80;

		// Token: 0x04002A04 RID: 10756
		public const int FlyObjectUpStraightZ = 150;

		// Token: 0x04002A05 RID: 10757
		public const int SkillFxTag = 1;

		// Token: 0x04002A06 RID: 10758
		public const int BuffFxTag = 2;

		// Token: 0x04002A07 RID: 10759
		public const int SkillFxTagMask = 2;

		// Token: 0x04002A08 RID: 10760
		public const int BuffFxTagMask = 4;

		// Token: 0x04002A09 RID: 10761
		[DoNotToLua]
		private CombatConst.LuaExportHelper luaExportHelper;

		// Token: 0x04002A0A RID: 10762
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002A0B RID: 10763
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002A0C RID: 10764
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0200039E RID: 926
		public class LuaExportHelper
		{
			// Token: 0x060036C1 RID: 14017 RVA: 0x000F2F6C File Offset: 0x000F116C
			public LuaExportHelper(CombatConst owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04002A0D RID: 10765
			private CombatConst m_owner;
		}
	}
}
