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
	// Token: 0x020008CA RID: 2250
	[HotFix]
	public class MemoryCorridorCompoment : MemoryCorridorCompomentCommon
	{
		// Token: 0x06007364 RID: 29540 RVA: 0x001FDBCC File Offset: 0x001FBDCC
		public MemoryCorridorCompoment()
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

		// Token: 0x06007365 RID: 29541 RVA: 0x001FDC34 File Offset: 0x001FBE34
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

		// Token: 0x06007366 RID: 29542 RVA: 0x001FDCB0 File Offset: 0x001FBEB0
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

		// Token: 0x06007367 RID: 29543 RVA: 0x001FDD18 File Offset: 0x001FBF18
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

		// Token: 0x06007368 RID: 29544 RVA: 0x001FDD80 File Offset: 0x001FBF80
		public void DeSerialize(DSMemoryCorridorNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSMemoryCorridorNtf_hotfix != null)
			{
				this.m_DeSerializeDSMemoryCorridorNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_memoryCorridorDS.ClearInitedData();
			this.m_memoryCorridorDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_memoryCorridorDS.InitFinishedLevels(msg.FinishedLeves);
			this.m_memoryCorridorDS.InitChallengedNums(msg.ChallengedNums);
		}

		// Token: 0x06007369 RID: 29545 RVA: 0x001FDE38 File Offset: 0x001FC038
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
			return this.m_memoryCorridorDS.ClientVersion;
		}

		// Token: 0x0600736A RID: 29546 RVA: 0x001FDEB0 File Offset: 0x001FC0B0
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
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_MemoryCorridor);
			BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
			return (bagItemBase != null) ? bagItemBase.Nums : 0;
		}

		// Token: 0x0600736B RID: 29547 RVA: 0x001FDF4C File Offset: 0x001FC14C
		public int FinishedMemoryCorridorLevel(int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedMemoryCorridorLevelInt32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedMemoryCorridorLevelInt32BooleanList`1_hotfix.call(new object[]
				{
					this,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
			if (configDataMemoryCorridorLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -2801;
			}
			if (isWin)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.SetSuccessMemoryCorridorLevel(configDataMemoryCorridorLevelInfo, battleTreasures, pveTeam, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x0600736C RID: 29548 RVA: 0x001FE03C File Offset: 0x001FC23C
		public void SetSuccessMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List`1Boolean_hotfix != null)
			{
				this.m_SetSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List`1Boolean_hotfix.call(new object[]
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
			base.SetCommonSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, energyCost, isTeamBattle);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.Gold;
		}

		// Token: 0x0600736D RID: 29549 RVA: 0x001FE140 File Offset: 0x001FC340
		public bool IsMemoryCorridorOpened(int memoryCorridorId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMemoryCorridorOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMemoryCorridorOpenedInt32_hotfix.call(new object[]
				{
					this,
					memoryCorridorId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int memoryCorridorId = memoryCorridorId2;
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataMemoryCorridorInfo> list;
			return this.m_configDataLoader.MemoryCorridorData.MemoryCorridorOfWeekDict.TryGetValue(key, out list) && list.Find((ConfigDataMemoryCorridorInfo t) => t.ID == memoryCorridorId) != null;
		}

		// Token: 0x0600736E RID: 29550 RVA: 0x001FE228 File Offset: 0x001FC428
		public bool IsMemoryCorridorLevelOpened(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMemoryCorridorLevelOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMemoryCorridorLevelOpenedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataMemoryCorridorLevelInfo configDataMemoryCorridorLevelInfo = this.m_configDataLoader.GetConfigDataMemoryCorridorLevelInfo(levelId);
			return configDataMemoryCorridorLevelInfo != null && this.m_basicInfo.GetLevel() >= configDataMemoryCorridorLevelInfo.OpenPlayerLevel;
		}

		// Token: 0x17001BD5 RID: 7125
		// (get) Token: 0x0600736F RID: 29551 RVA: 0x001FE2D0 File Offset: 0x001FC4D0
		// (set) Token: 0x06007370 RID: 29552 RVA: 0x001FE2F0 File Offset: 0x001FC4F0
		[DoNotToLua]
		public new MemoryCorridorCompoment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new MemoryCorridorCompoment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007371 RID: 29553 RVA: 0x001FE2FC File Offset: 0x001FC4FC
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007372 RID: 29554 RVA: 0x001FE304 File Offset: 0x001FC504
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007373 RID: 29555 RVA: 0x001FE30C File Offset: 0x001FC50C
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007374 RID: 29556 RVA: 0x001FE314 File Offset: 0x001FC514
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007375 RID: 29557 RVA: 0x001FE31C File Offset: 0x001FC51C
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007376 RID: 29558 RVA: 0x001FE328 File Offset: 0x001FC528
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007377 RID: 29559 RVA: 0x001FE330 File Offset: 0x001FC530
		private bool __callBase_IsLevelFinished(int levelId)
		{
			return base.IsLevelFinished(levelId);
		}

		// Token: 0x06007378 RID: 29560 RVA: 0x001FE33C File Offset: 0x001FC53C
		private int __callBase_AttackMemoryCorridorLevel(int levelId)
		{
			return base.AttackMemoryCorridorLevel(levelId);
		}

		// Token: 0x06007379 RID: 29561 RVA: 0x001FE348 File Offset: 0x001FC548
		private int __callBase_CanAttackMemoryCorridorLevel(int levelId, bool isTeamBattle)
		{
			return base.CanAttackMemoryCorridorLevel(levelId, isTeamBattle);
		}

		// Token: 0x0600737A RID: 29562 RVA: 0x001FE354 File Offset: 0x001FC554
		private void __callBase_SetCommonSuccessMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			base.SetCommonSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
		}

		// Token: 0x0600737B RID: 29563 RVA: 0x001FE364 File Offset: 0x001FC564
		private HashSet<int> __callBase_GetAllFinishedLevels()
		{
			return base.GetAllFinishedLevels();
		}

		// Token: 0x0600737C RID: 29564 RVA: 0x001FE36C File Offset: 0x001FC56C
		private bool __callBase_IsDailyChallenge()
		{
			return base.IsDailyChallenge();
		}

		// Token: 0x0600737D RID: 29565 RVA: 0x001FE374 File Offset: 0x001FC574
		private int __callBase_GetDailyChallengNums()
		{
			return base.GetDailyChallengNums();
		}

		// Token: 0x0600737E RID: 29566 RVA: 0x001FE37C File Offset: 0x001FC57C
		private void __callBase_AddChallengedNums(int nums)
		{
			base.AddChallengedNums(nums);
		}

		// Token: 0x0600737F RID: 29567 RVA: 0x001FE388 File Offset: 0x001FC588
		private List<int> __callBase_GetAllUnlockedLevels()
		{
			return base.GetAllUnlockedLevels();
		}

		// Token: 0x06007380 RID: 29568 RVA: 0x001FE390 File Offset: 0x001FC590
		private bool __callBase_IsLevelUnlocked(int levelId)
		{
			return base.IsLevelUnlocked(levelId);
		}

		// Token: 0x06007381 RID: 29569 RVA: 0x001FE39C File Offset: 0x001FC59C
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
					this.m_DeSerializeDSMemoryCorridorNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetCurrentTicketNums_hotfix = (luaObj.RawGet("GetCurrentTicketNums") as LuaFunction);
					this.m_FinishedMemoryCorridorLevelInt32BooleanList`1_hotfix = (luaObj.RawGet("FinishedMemoryCorridorLevel") as LuaFunction);
					this.m_SetSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List`1Boolean_hotfix = (luaObj.RawGet("SetSuccessMemoryCorridorLevel") as LuaFunction);
					this.m_IsMemoryCorridorOpenedInt32_hotfix = (luaObj.RawGet("IsMemoryCorridorOpened") as LuaFunction);
					this.m_IsMemoryCorridorLevelOpenedInt32_hotfix = (luaObj.RawGet("IsMemoryCorridorLevelOpened") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007382 RID: 29570 RVA: 0x001FE564 File Offset: 0x001FC764
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(MemoryCorridorCompoment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005571 RID: 21873
		[DoNotToLua]
		private MemoryCorridorCompoment.LuaExportHelper luaExportHelper;

		// Token: 0x04005572 RID: 21874
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005573 RID: 21875
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005574 RID: 21876
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005575 RID: 21877
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005576 RID: 21878
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005577 RID: 21879
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005578 RID: 21880
		private LuaFunction m_DeSerializeDSMemoryCorridorNtf_hotfix;

		// Token: 0x04005579 RID: 21881
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400557A RID: 21882
		private LuaFunction m_GetCurrentTicketNums_hotfix;

		// Token: 0x0400557B RID: 21883
		private LuaFunction m_FinishedMemoryCorridorLevelInt32BooleanList;

		// Token: 0x0400557C RID: 21884
		private LuaFunction m_SetSuccessMemoryCorridorLevelConfigDataMemoryCorridorLevelInfoList`1List;

		// Token: 0x0400557D RID: 21885
		private LuaFunction m_IsMemoryCorridorOpenedInt32_hotfix;

		// Token: 0x0400557E RID: 21886
		private LuaFunction m_IsMemoryCorridorLevelOpenedInt32_hotfix;

		// Token: 0x020008CB RID: 2251
		public new class LuaExportHelper
		{
			// Token: 0x06007383 RID: 29571 RVA: 0x001FE5CC File Offset: 0x001FC7CC
			public LuaExportHelper(MemoryCorridorCompoment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007384 RID: 29572 RVA: 0x001FE5DC File Offset: 0x001FC7DC
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007385 RID: 29573 RVA: 0x001FE5EC File Offset: 0x001FC7EC
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007386 RID: 29574 RVA: 0x001FE5FC File Offset: 0x001FC7FC
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007387 RID: 29575 RVA: 0x001FE60C File Offset: 0x001FC80C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007388 RID: 29576 RVA: 0x001FE61C File Offset: 0x001FC81C
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007389 RID: 29577 RVA: 0x001FE62C File Offset: 0x001FC82C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600738A RID: 29578 RVA: 0x001FE63C File Offset: 0x001FC83C
			public bool __callBase_IsLevelFinished(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(levelId);
			}

			// Token: 0x0600738B RID: 29579 RVA: 0x001FE64C File Offset: 0x001FC84C
			public int __callBase_AttackMemoryCorridorLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackMemoryCorridorLevel(levelId);
			}

			// Token: 0x0600738C RID: 29580 RVA: 0x001FE65C File Offset: 0x001FC85C
			public int __callBase_CanAttackMemoryCorridorLevel(int levelId, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CanAttackMemoryCorridorLevel(levelId, isTeamBattle);
			}

			// Token: 0x0600738D RID: 29581 RVA: 0x001FE66C File Offset: 0x001FC86C
			public void __callBase_SetCommonSuccessMemoryCorridorLevel(ConfigDataMemoryCorridorLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.__callBase_SetCommonSuccessMemoryCorridorLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x0600738E RID: 29582 RVA: 0x001FE680 File Offset: 0x001FC880
			public HashSet<int> __callBase_GetAllFinishedLevels()
			{
				return this.m_owner.__callBase_GetAllFinishedLevels();
			}

			// Token: 0x0600738F RID: 29583 RVA: 0x001FE690 File Offset: 0x001FC890
			public bool __callBase_IsDailyChallenge()
			{
				return this.m_owner.__callBase_IsDailyChallenge();
			}

			// Token: 0x06007390 RID: 29584 RVA: 0x001FE6A0 File Offset: 0x001FC8A0
			public int __callBase_GetDailyChallengNums()
			{
				return this.m_owner.__callBase_GetDailyChallengNums();
			}

			// Token: 0x06007391 RID: 29585 RVA: 0x001FE6B0 File Offset: 0x001FC8B0
			public void __callBase_AddChallengedNums(int nums)
			{
				this.m_owner.__callBase_AddChallengedNums(nums);
			}

			// Token: 0x06007392 RID: 29586 RVA: 0x001FE6C0 File Offset: 0x001FC8C0
			public List<int> __callBase_GetAllUnlockedLevels()
			{
				return this.m_owner.__callBase_GetAllUnlockedLevels();
			}

			// Token: 0x06007393 RID: 29587 RVA: 0x001FE6D0 File Offset: 0x001FC8D0
			public bool __callBase_IsLevelUnlocked(int levelId)
			{
				return this.m_owner.__callBase_IsLevelUnlocked(levelId);
			}

			// Token: 0x0400557F RID: 21887
			private MemoryCorridorCompoment m_owner;
		}
	}
}
