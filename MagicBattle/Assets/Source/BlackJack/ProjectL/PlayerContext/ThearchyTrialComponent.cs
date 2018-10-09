using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008E9 RID: 2281
	[HotFix]
	public class ThearchyTrialComponent : ThearchyTrialCompomentCommon
	{
		// Token: 0x0600778D RID: 30605 RVA: 0x00209E00 File Offset: 0x00208000
		public ThearchyTrialComponent()
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

		// Token: 0x0600778E RID: 30606 RVA: 0x00209E68 File Offset: 0x00208068
		public override void Init()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Init_hotfix != null)
			{
				this.m_Init_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x0600778F RID: 30607 RVA: 0x00209EE4 File Offset: 0x002080E4
		public override void PostInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostInit_hotfix != null)
			{
				this.m_PostInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.PostInit();
		}

		// Token: 0x06007790 RID: 30608 RVA: 0x00209F4C File Offset: 0x0020814C
		public override void DeInit()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeInit_hotfix != null)
			{
				this.m_DeInit_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeInit();
		}

		// Token: 0x06007791 RID: 30609 RVA: 0x00209FB4 File Offset: 0x002081B4
		public void DeSerialize(DSThearchyTrialNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSThearchyTrialNtf_hotfix != null)
			{
				this.m_DeSerializeDSThearchyTrialNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_thearchyTrial.ClearInitedData();
			this.m_thearchyTrial.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_thearchyTrial.InitFinishedLevels(msg.FinishedLeves);
			this.m_thearchyTrial.InitChallengedNums(msg.ChallengedNums);
		}

		// Token: 0x06007792 RID: 30610 RVA: 0x0020A06C File Offset: 0x0020826C
		public ushort GetDSVersion()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDSVersion_hotfix != null)
			{
				return Convert.ToUInt16(this.m_GetDSVersion_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_thearchyTrial.ClientVersion;
		}

		// Token: 0x06007793 RID: 30611 RVA: 0x0020A0E4 File Offset: 0x002082E4
		public int GetCurrentTicketNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentTicketNums_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCurrentTicketNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_ThearchyTrial);
			BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
			return (bagItemBase != null) ? bagItemBase.Nums : 0;
		}

		// Token: 0x06007794 RID: 30612 RVA: 0x0020A180 File Offset: 0x00208380
		public int FinishedThearchyTrialLevel(int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedThearchyTrialLevelInt32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedThearchyTrialLevelInt32BooleanList`1_hotfix.call(new object[]
				{
					this,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
			if (configDataThearchyTrialLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -1801;
			}
			if (isWin)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.SetSuccessThearchyTrialLevel(configDataThearchyTrialLevelInfo, battleTreasures, pveTeam, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06007795 RID: 30613 RVA: 0x0020A270 File Offset: 0x00208470
		public void SetSuccessThearchyTrialLevel(ConfigDataThearchyTrialLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, bool isTeamBattle = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List`1Boolean_hotfix != null)
			{
				this.m_SetSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List`1Boolean_hotfix.call(new object[]
				{
					this,
					levelInfo,
					battleTreasures,
					heroes,
					isTeamBattle
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int energyCost = 0;
			if (!isTeamBattle)
			{
				energyCost = levelInfo.EnergySuccess - levelInfo.EnergyFail;
			}
			this.SetCommonSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, energyCost, isTeamBattle);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.Gold;
		}

		// Token: 0x06007796 RID: 30614 RVA: 0x0020A374 File Offset: 0x00208574
		public bool IsThearchyOpened(int thearchyId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsThearchyOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsThearchyOpenedInt32_hotfix.call(new object[]
				{
					this,
					thearchyId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int thearchyId = thearchyId2;
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataThearchyTrialInfo> list;
			return this.m_configDataLoader.ThearchyTrialData.ThearchyTrailOfWeekDict.TryGetValue(key, out list) && list.Find((ConfigDataThearchyTrialInfo t) => t.ID == thearchyId) != null;
		}

		// Token: 0x06007797 RID: 30615 RVA: 0x0020A45C File Offset: 0x0020865C
		public bool IsThearchyLevelOpened(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsThearchyLevelOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsThearchyLevelOpenedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataThearchyTrialLevelInfo configDataThearchyTrialLevelInfo = this.m_configDataLoader.GetConfigDataThearchyTrialLevelInfo(levelId);
			return configDataThearchyTrialLevelInfo != null && (configDataThearchyTrialLevelInfo.PreLevel == 0 || this.m_thearchyTrial.IsLevelFinished(configDataThearchyTrialLevelInfo.PreLevel));
		}

		// Token: 0x17001BE8 RID: 7144
		// (get) Token: 0x06007798 RID: 30616 RVA: 0x0020A514 File Offset: 0x00208714
		// (set) Token: 0x06007799 RID: 30617 RVA: 0x0020A534 File Offset: 0x00208734
		[DoNotToLua]
		public new ThearchyTrialComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ThearchyTrialComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600779A RID: 30618 RVA: 0x0020A540 File Offset: 0x00208740
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x0600779B RID: 30619 RVA: 0x0020A548 File Offset: 0x00208748
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x0600779C RID: 30620 RVA: 0x0020A550 File Offset: 0x00208750
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x0600779D RID: 30621 RVA: 0x0020A558 File Offset: 0x00208758
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x0600779E RID: 30622 RVA: 0x0020A560 File Offset: 0x00208760
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600779F RID: 30623 RVA: 0x0020A56C File Offset: 0x0020876C
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x060077A0 RID: 30624 RVA: 0x0020A574 File Offset: 0x00208774
		private int __callBase_AttackThearchyTrialLevel(int levelId)
		{
			return base.AttackThearchyTrialLevel(levelId);
		}

		// Token: 0x060077A1 RID: 30625 RVA: 0x0020A580 File Offset: 0x00208780
		private bool __callBase_IsLevelFinished(int levelId)
		{
			return base.IsLevelFinished(levelId);
		}

		// Token: 0x060077A2 RID: 30626 RVA: 0x0020A58C File Offset: 0x0020878C
		private int __callBase_CanAttackThearchyTrialLevel(int levelId, bool isTeamBattle)
		{
			return base.CanAttackThearchyTrialLevel(levelId, isTeamBattle);
		}

		// Token: 0x060077A3 RID: 30627 RVA: 0x0020A598 File Offset: 0x00208798
		private int __callBase_CanAttackLevelByEnergyAndSoOn(ConfigDataThearchyTrialLevelInfo levelInfo, bool isTeamBattle)
		{
			return base.CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
		}

		// Token: 0x060077A4 RID: 30628 RVA: 0x0020A5A4 File Offset: 0x002087A4
		private void __callBase_SetCommonSuccessThearchyTrialLevel(ConfigDataThearchyTrialLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			base.SetCommonSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
		}

		// Token: 0x060077A5 RID: 30629 RVA: 0x0020A5B4 File Offset: 0x002087B4
		private HashSet<int> __callBase_GetAllFinishedLevels()
		{
			return base.GetAllFinishedLevels();
		}

		// Token: 0x060077A6 RID: 30630 RVA: 0x0020A5BC File Offset: 0x002087BC
		private bool __callBase_IsDailyChallenge()
		{
			return base.IsDailyChallenge();
		}

		// Token: 0x060077A7 RID: 30631 RVA: 0x0020A5C4 File Offset: 0x002087C4
		private int __callBase_GetDailyChallengNums()
		{
			return base.GetDailyChallengNums();
		}

		// Token: 0x060077A8 RID: 30632 RVA: 0x0020A5CC File Offset: 0x002087CC
		private void __callBase_AddChallengedNums(int nums)
		{
			base.AddChallengedNums(nums);
		}

		// Token: 0x060077A9 RID: 30633 RVA: 0x0020A5D8 File Offset: 0x002087D8
		private List<int> __callBase_GetAllUnlockedLevels()
		{
			return base.GetAllUnlockedLevels();
		}

		// Token: 0x060077AA RID: 30634 RVA: 0x0020A5E0 File Offset: 0x002087E0
		private bool __callBase_IsLevelUnlocked(int levelId)
		{
			return base.IsLevelUnlocked(levelId);
		}

		// Token: 0x060077AB RID: 30635 RVA: 0x0020A5EC File Offset: 0x002087EC
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
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_DeSerializeDSThearchyTrialNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetCurrentTicketNums_hotfix = (luaObj.RawGet("GetCurrentTicketNums") as LuaFunction);
					this.m_FinishedThearchyTrialLevelInt32BooleanList`1_hotfix = (luaObj.RawGet("FinishedThearchyTrialLevel") as LuaFunction);
					this.m_SetSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List`1Boolean_hotfix = (luaObj.RawGet("SetSuccessThearchyTrialLevel") as LuaFunction);
					this.m_IsThearchyOpenedInt32_hotfix = (luaObj.RawGet("IsThearchyOpened") as LuaFunction);
					this.m_IsThearchyLevelOpenedInt32_hotfix = (luaObj.RawGet("IsThearchyLevelOpened") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060077AC RID: 30636 RVA: 0x0020A7B4 File Offset: 0x002089B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ThearchyTrialComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400565E RID: 22110
		[DoNotToLua]
		private ThearchyTrialComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400565F RID: 22111
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005660 RID: 22112
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005661 RID: 22113
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005662 RID: 22114
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005663 RID: 22115
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005664 RID: 22116
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005665 RID: 22117
		private LuaFunction m_DeSerializeDSThearchyTrialNtf_hotfix;

		// Token: 0x04005666 RID: 22118
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005667 RID: 22119
		private LuaFunction m_GetCurrentTicketNums_hotfix;

		// Token: 0x04005668 RID: 22120
		private LuaFunction m_FinishedThearchyTrialLevelInt32BooleanList;

		// Token: 0x04005669 RID: 22121
		private LuaFunction m_SetSuccessThearchyTrialLevelConfigDataThearchyTrialLevelInfoList`1List;

		// Token: 0x0400566A RID: 22122
		private LuaFunction m_IsThearchyOpenedInt32_hotfix;

		// Token: 0x0400566B RID: 22123
		private LuaFunction m_IsThearchyLevelOpenedInt32_hotfix;

		// Token: 0x020008EA RID: 2282
		public new class LuaExportHelper
		{
			// Token: 0x060077AD RID: 30637 RVA: 0x0020A81C File Offset: 0x00208A1C
			public LuaExportHelper(ThearchyTrialComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060077AE RID: 30638 RVA: 0x0020A82C File Offset: 0x00208A2C
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x060077AF RID: 30639 RVA: 0x0020A83C File Offset: 0x00208A3C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x060077B0 RID: 30640 RVA: 0x0020A84C File Offset: 0x00208A4C
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x060077B1 RID: 30641 RVA: 0x0020A85C File Offset: 0x00208A5C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x060077B2 RID: 30642 RVA: 0x0020A86C File Offset: 0x00208A6C
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x060077B3 RID: 30643 RVA: 0x0020A87C File Offset: 0x00208A7C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x060077B4 RID: 30644 RVA: 0x0020A88C File Offset: 0x00208A8C
			public int __callBase_AttackThearchyTrialLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackThearchyTrialLevel(levelId);
			}

			// Token: 0x060077B5 RID: 30645 RVA: 0x0020A89C File Offset: 0x00208A9C
			public bool __callBase_IsLevelFinished(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(levelId);
			}

			// Token: 0x060077B6 RID: 30646 RVA: 0x0020A8AC File Offset: 0x00208AAC
			public int __callBase_CanAttackThearchyTrialLevel(int levelId, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CanAttackThearchyTrialLevel(levelId, isTeamBattle);
			}

			// Token: 0x060077B7 RID: 30647 RVA: 0x0020A8BC File Offset: 0x00208ABC
			public int __callBase_CanAttackLevelByEnergyAndSoOn(ConfigDataThearchyTrialLevelInfo levelInfo, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CanAttackLevelByEnergyAndSoOn(levelInfo, isTeamBattle);
			}

			// Token: 0x060077B8 RID: 30648 RVA: 0x0020A8CC File Offset: 0x00208ACC
			public void __callBase_SetCommonSuccessThearchyTrialLevel(ConfigDataThearchyTrialLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.__callBase_SetCommonSuccessThearchyTrialLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x060077B9 RID: 30649 RVA: 0x0020A8E0 File Offset: 0x00208AE0
			public HashSet<int> __callBase_GetAllFinishedLevels()
			{
				return this.m_owner.__callBase_GetAllFinishedLevels();
			}

			// Token: 0x060077BA RID: 30650 RVA: 0x0020A8F0 File Offset: 0x00208AF0
			public bool __callBase_IsDailyChallenge()
			{
				return this.m_owner.__callBase_IsDailyChallenge();
			}

			// Token: 0x060077BB RID: 30651 RVA: 0x0020A900 File Offset: 0x00208B00
			public int __callBase_GetDailyChallengNums()
			{
				return this.m_owner.__callBase_GetDailyChallengNums();
			}

			// Token: 0x060077BC RID: 30652 RVA: 0x0020A910 File Offset: 0x00208B10
			public void __callBase_AddChallengedNums(int nums)
			{
				this.m_owner.__callBase_AddChallengedNums(nums);
			}

			// Token: 0x060077BD RID: 30653 RVA: 0x0020A920 File Offset: 0x00208B20
			public List<int> __callBase_GetAllUnlockedLevels()
			{
				return this.m_owner.__callBase_GetAllUnlockedLevels();
			}

			// Token: 0x060077BE RID: 30654 RVA: 0x0020A930 File Offset: 0x00208B30
			public bool __callBase_IsLevelUnlocked(int levelId)
			{
				return this.m_owner.__callBase_IsLevelUnlocked(levelId);
			}

			// Token: 0x0400566C RID: 22124
			private ThearchyTrialComponent m_owner;
		}
	}
}
