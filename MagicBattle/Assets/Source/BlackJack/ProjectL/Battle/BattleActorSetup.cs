using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.Battle
{
	// Token: 0x02000397 RID: 919
	[HotFix]
	public class BattleActorSetup
	{
		// Token: 0x060036A9 RID: 13993 RVA: 0x000F27EC File Offset: 0x000F09EC
		public BattleActorSetup()
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

		// Token: 0x17000F1B RID: 3867
		// (get) Token: 0x060036AA RID: 13994 RVA: 0x000F2868 File Offset: 0x000F0A68
		// (set) Token: 0x060036AB RID: 13995 RVA: 0x000F2888 File Offset: 0x000F0A88
		[DoNotToLua]
		public BattleActorSetup.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleActorSetup.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060036AC RID: 13996 RVA: 0x000F2894 File Offset: 0x000F0A94
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

		// Token: 0x060036AD RID: 13997 RVA: 0x000F2960 File Offset: 0x000F0B60
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleActorSetup));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040029C3 RID: 10691
		public ConfigDataHeroInfo HeroInfo;

		// Token: 0x040029C4 RID: 10692
		public ConfigDataJobConnectionInfo JobConnectionInfo;

		// Token: 0x040029C5 RID: 10693
		public ConfigDataSoldierInfo SoldierInfo;

		// Token: 0x040029C6 RID: 10694
		public ConfigDataSkillInfo[] SkillInfos;

		// Token: 0x040029C7 RID: 10695
		public ConfigDataJobInfo[] MasterJobInfos;

		// Token: 0x040029C8 RID: 10696
		public BattleActorEquipment[] Equipments;

		// Token: 0x040029C9 RID: 10697
		public ConfigDataSkillInfo[] ResonanceSkillInfos;

		// Token: 0x040029CA RID: 10698
		public ConfigDataSkillInfo[] FetterSkillInfos;

		// Token: 0x040029CB RID: 10699
		public int HeroLevel;

		// Token: 0x040029CC RID: 10700
		public int HeroStar;

		// Token: 0x040029CD RID: 10701
		public int JobLevel;

		// Token: 0x040029CE RID: 10702
		public int SoldierCount;

		// Token: 0x040029CF RID: 10703
		public GridPosition Position;

		// Token: 0x040029D0 RID: 10704
		public int Direction;

		// Token: 0x040029D1 RID: 10705
		public bool IsNpc;

		// Token: 0x040029D2 RID: 10706
		public int BehaviorId;

		// Token: 0x040029D3 RID: 10707
		public int GroupId;

		// Token: 0x040029D4 RID: 10708
		public int ActionValue;

		// Token: 0x040029D5 RID: 10709
		public ConfigDataCharImageSkinResourceInfo HeroCharImageSkinResourceInfo;

		// Token: 0x040029D6 RID: 10710
		public ConfigDataModelSkinResourceInfo HeroModelSkinResourceInfo;

		// Token: 0x040029D7 RID: 10711
		public ConfigDataModelSkinResourceInfo SoldierModelSkinResourceInfo;

		// Token: 0x040029D8 RID: 10712
		public List<ConfigDataSkillInfo> ExtraPassiveSkillInfos;

		// Token: 0x040029D9 RID: 10713
		public ConfigDataSkillInfo ExtraTalentSkillInfo;

		// Token: 0x040029DA RID: 10714
		public int HeroHealthPoint = -1;

		// Token: 0x040029DB RID: 10715
		public int SoldierHealthPoint = -1;

		// Token: 0x040029DC RID: 10716
		public int ActorId;

		// Token: 0x040029DD RID: 10717
		public int PlayerIndex = -1;

		// Token: 0x040029DE RID: 10718
		[DoNotToLua]
		private BattleActorSetup.LuaExportHelper luaExportHelper;

		// Token: 0x040029DF RID: 10719
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040029E0 RID: 10720
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040029E1 RID: 10721
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000398 RID: 920
		public class LuaExportHelper
		{
			// Token: 0x060036AE RID: 13998 RVA: 0x000F29C8 File Offset: 0x000F0BC8
			public LuaExportHelper(BattleActorSetup owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x040029E2 RID: 10722
			private BattleActorSetup m_owner;
		}
	}
}
