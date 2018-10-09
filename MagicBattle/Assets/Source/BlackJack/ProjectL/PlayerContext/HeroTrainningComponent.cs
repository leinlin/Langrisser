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
	// Token: 0x020008C3 RID: 2243
	[HotFix]
	public class HeroTrainningComponent : HeroTrainningComponentCommon
	{
		// Token: 0x0600726C RID: 29292 RVA: 0x001FAE6C File Offset: 0x001F906C
		public HeroTrainningComponent()
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

		// Token: 0x0600726D RID: 29293 RVA: 0x001FAED4 File Offset: 0x001F90D4
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

		// Token: 0x0600726E RID: 29294 RVA: 0x001FAF50 File Offset: 0x001F9150
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

		// Token: 0x0600726F RID: 29295 RVA: 0x001FAFB8 File Offset: 0x001F91B8
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

		// Token: 0x06007270 RID: 29296 RVA: 0x001FB020 File Offset: 0x001F9220
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
			return this.m_heroTrainningDS.ClientVersion;
		}

		// Token: 0x06007271 RID: 29297 RVA: 0x001FB098 File Offset: 0x001F9298
		public void DeSerialize(DSHeroTrainningNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSHeroTrainningNtf_hotfix != null)
			{
				this.m_DeSerializeDSHeroTrainningNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroTrainningDS.ClearInitedData();
			this.m_heroTrainningDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_heroTrainningDS.InitFinishedLevels(msg.FinishedLeves);
			this.m_heroTrainningDS.InitChallengedNums(msg.ChallengedNums);
		}

		// Token: 0x06007272 RID: 29298 RVA: 0x001FB150 File Offset: 0x001F9350
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
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_HeroTrainning);
			BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
			return (bagItemBase != null) ? bagItemBase.Nums : 0;
		}

		// Token: 0x06007273 RID: 29299 RVA: 0x001FB1EC File Offset: 0x001F93EC
		public int FinishedHeroTrainningLevel(int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedHeroTrainningLevelInt32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedHeroTrainningLevelInt32BooleanList`1_hotfix.call(new object[]
				{
					this,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
			if (configDataHeroTrainningLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -4201;
			}
			if (isWin)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.SetSuccessHeroTrainningLevel(configDataHeroTrainningLevelInfo, battleTreasures, pveTeam, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06007274 RID: 29300 RVA: 0x001FB2DC File Offset: 0x001F94DC
		public void SetSuccessHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List`1Boolean_hotfix != null)
			{
				this.m_SetSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List`1Boolean_hotfix.call(new object[]
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
			base.SetCommonSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, energyCost, isTeamBattle);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.Gold;
		}

		// Token: 0x06007275 RID: 29301 RVA: 0x001FB3E0 File Offset: 0x001F95E0
		public bool IsHeroTrainningOpened(int heroTrainningId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeroTrainningOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeroTrainningOpenedInt32_hotfix.call(new object[]
				{
					this,
					heroTrainningId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroTrainningId = heroTrainningId2;
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataHeroTrainningInfo> list;
			return this.m_configDataLoader.HeroTrainningData.HeroTrainningOfWeekDict.TryGetValue(key, out list) && list.Find((ConfigDataHeroTrainningInfo t) => t.ID == heroTrainningId) != null;
		}

		// Token: 0x06007276 RID: 29302 RVA: 0x001FB4C8 File Offset: 0x001F96C8
		public bool IsHeroTrainningLevelOpened(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeroTrainningLevelOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeroTrainningLevelOpenedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroTrainningLevelInfo configDataHeroTrainningLevelInfo = this.m_configDataLoader.GetConfigDataHeroTrainningLevelInfo(levelId);
			return configDataHeroTrainningLevelInfo != null && this.m_basicInfo.GetLevel() >= configDataHeroTrainningLevelInfo.OpenPlayerLevel;
		}

		// Token: 0x17001BD2 RID: 7122
		// (get) Token: 0x06007277 RID: 29303 RVA: 0x001FB570 File Offset: 0x001F9770
		// (set) Token: 0x06007278 RID: 29304 RVA: 0x001FB590 File Offset: 0x001F9790
		[DoNotToLua]
		public new HeroTrainningComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroTrainningComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007279 RID: 29305 RVA: 0x001FB59C File Offset: 0x001F979C
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x0600727A RID: 29306 RVA: 0x001FB5A4 File Offset: 0x001F97A4
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x0600727B RID: 29307 RVA: 0x001FB5AC File Offset: 0x001F97AC
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x0600727C RID: 29308 RVA: 0x001FB5B4 File Offset: 0x001F97B4
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x0600727D RID: 29309 RVA: 0x001FB5BC File Offset: 0x001F97BC
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600727E RID: 29310 RVA: 0x001FB5C8 File Offset: 0x001F97C8
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600727F RID: 29311 RVA: 0x001FB5D0 File Offset: 0x001F97D0
		private int __callBase_AttackHeroTrainningLevel(int levelId)
		{
			return base.AttackHeroTrainningLevel(levelId);
		}

		// Token: 0x06007280 RID: 29312 RVA: 0x001FB5DC File Offset: 0x001F97DC
		private int __callBase_CanAttackHeroTrainningLevel(int levelId, bool isTeamBattle)
		{
			return base.CanAttackHeroTrainningLevel(levelId, isTeamBattle);
		}

		// Token: 0x06007281 RID: 29313 RVA: 0x001FB5E8 File Offset: 0x001F97E8
		private bool __callBase_IsLevelFinished(int levelId)
		{
			return base.IsLevelFinished(levelId);
		}

		// Token: 0x06007282 RID: 29314 RVA: 0x001FB5F4 File Offset: 0x001F97F4
		private void __callBase_SetCommonSuccessHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			base.SetCommonSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
		}

		// Token: 0x06007283 RID: 29315 RVA: 0x001FB604 File Offset: 0x001F9804
		private HashSet<int> __callBase_GetAllFinishedLevels()
		{
			return base.GetAllFinishedLevels();
		}

		// Token: 0x06007284 RID: 29316 RVA: 0x001FB60C File Offset: 0x001F980C
		private bool __callBase_IsDailyChallenge()
		{
			return base.IsDailyChallenge();
		}

		// Token: 0x06007285 RID: 29317 RVA: 0x001FB614 File Offset: 0x001F9814
		private int __callBase_GetDailyChallengNums()
		{
			return base.GetDailyChallengNums();
		}

		// Token: 0x06007286 RID: 29318 RVA: 0x001FB61C File Offset: 0x001F981C
		private void __callBase_AddChallengedNums(int nums)
		{
			base.AddChallengedNums(nums);
		}

		// Token: 0x06007287 RID: 29319 RVA: 0x001FB628 File Offset: 0x001F9828
		private List<int> __callBase_GetAllUnlockedLevels()
		{
			return base.GetAllUnlockedLevels();
		}

		// Token: 0x06007288 RID: 29320 RVA: 0x001FB630 File Offset: 0x001F9830
		private bool __callBase_IsLevelUnlocked(int levelId)
		{
			return base.IsLevelUnlocked(levelId);
		}

		// Token: 0x06007289 RID: 29321 RVA: 0x001FB63C File Offset: 0x001F983C
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
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_DeSerializeDSHeroTrainningNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetCurrentTicketNums_hotfix = (luaObj.RawGet("GetCurrentTicketNums") as LuaFunction);
					this.m_FinishedHeroTrainningLevelInt32BooleanList`1_hotfix = (luaObj.RawGet("FinishedHeroTrainningLevel") as LuaFunction);
					this.m_SetSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List`1Boolean_hotfix = (luaObj.RawGet("SetSuccessHeroTrainningLevel") as LuaFunction);
					this.m_IsHeroTrainningOpenedInt32_hotfix = (luaObj.RawGet("IsHeroTrainningOpened") as LuaFunction);
					this.m_IsHeroTrainningLevelOpenedInt32_hotfix = (luaObj.RawGet("IsHeroTrainningLevelOpened") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600728A RID: 29322 RVA: 0x001FB804 File Offset: 0x001F9A04
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroTrainningComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400553A RID: 21818
		[DoNotToLua]
		private HeroTrainningComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400553B RID: 21819
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400553C RID: 21820
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400553D RID: 21821
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400553E RID: 21822
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400553F RID: 21823
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005540 RID: 21824
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005541 RID: 21825
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005542 RID: 21826
		private LuaFunction m_DeSerializeDSHeroTrainningNtf_hotfix;

		// Token: 0x04005543 RID: 21827
		private LuaFunction m_GetCurrentTicketNums_hotfix;

		// Token: 0x04005544 RID: 21828
		private LuaFunction m_FinishedHeroTrainningLevelInt32BooleanList;

		// Token: 0x04005545 RID: 21829
		private LuaFunction m_SetSuccessHeroTrainningLevelConfigDataHeroTrainningLevelInfoList`1List;

		// Token: 0x04005546 RID: 21830
		private LuaFunction m_IsHeroTrainningOpenedInt32_hotfix;

		// Token: 0x04005547 RID: 21831
		private LuaFunction m_IsHeroTrainningLevelOpenedInt32_hotfix;

		// Token: 0x020008C4 RID: 2244
		public new class LuaExportHelper
		{
			// Token: 0x0600728B RID: 29323 RVA: 0x001FB86C File Offset: 0x001F9A6C
			public LuaExportHelper(HeroTrainningComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600728C RID: 29324 RVA: 0x001FB87C File Offset: 0x001F9A7C
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600728D RID: 29325 RVA: 0x001FB88C File Offset: 0x001F9A8C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600728E RID: 29326 RVA: 0x001FB89C File Offset: 0x001F9A9C
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600728F RID: 29327 RVA: 0x001FB8AC File Offset: 0x001F9AAC
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007290 RID: 29328 RVA: 0x001FB8BC File Offset: 0x001F9ABC
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007291 RID: 29329 RVA: 0x001FB8CC File Offset: 0x001F9ACC
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007292 RID: 29330 RVA: 0x001FB8DC File Offset: 0x001F9ADC
			public int __callBase_AttackHeroTrainningLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackHeroTrainningLevel(levelId);
			}

			// Token: 0x06007293 RID: 29331 RVA: 0x001FB8EC File Offset: 0x001F9AEC
			public int __callBase_CanAttackHeroTrainningLevel(int levelId, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CanAttackHeroTrainningLevel(levelId, isTeamBattle);
			}

			// Token: 0x06007294 RID: 29332 RVA: 0x001FB8FC File Offset: 0x001F9AFC
			public bool __callBase_IsLevelFinished(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(levelId);
			}

			// Token: 0x06007295 RID: 29333 RVA: 0x001FB90C File Offset: 0x001F9B0C
			public void __callBase_SetCommonSuccessHeroTrainningLevel(ConfigDataHeroTrainningLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.__callBase_SetCommonSuccessHeroTrainningLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x06007296 RID: 29334 RVA: 0x001FB920 File Offset: 0x001F9B20
			public HashSet<int> __callBase_GetAllFinishedLevels()
			{
				return this.m_owner.__callBase_GetAllFinishedLevels();
			}

			// Token: 0x06007297 RID: 29335 RVA: 0x001FB930 File Offset: 0x001F9B30
			public bool __callBase_IsDailyChallenge()
			{
				return this.m_owner.__callBase_IsDailyChallenge();
			}

			// Token: 0x06007298 RID: 29336 RVA: 0x001FB940 File Offset: 0x001F9B40
			public int __callBase_GetDailyChallengNums()
			{
				return this.m_owner.__callBase_GetDailyChallengNums();
			}

			// Token: 0x06007299 RID: 29337 RVA: 0x001FB950 File Offset: 0x001F9B50
			public void __callBase_AddChallengedNums(int nums)
			{
				this.m_owner.__callBase_AddChallengedNums(nums);
			}

			// Token: 0x0600729A RID: 29338 RVA: 0x001FB960 File Offset: 0x001F9B60
			public List<int> __callBase_GetAllUnlockedLevels()
			{
				return this.m_owner.__callBase_GetAllUnlockedLevels();
			}

			// Token: 0x0600729B RID: 29339 RVA: 0x001FB970 File Offset: 0x001F9B70
			public bool __callBase_IsLevelUnlocked(int levelId)
			{
				return this.m_owner.__callBase_IsLevelUnlocked(levelId);
			}

			// Token: 0x04005548 RID: 21832
			private HeroTrainningComponent m_owner;
		}
	}
}
