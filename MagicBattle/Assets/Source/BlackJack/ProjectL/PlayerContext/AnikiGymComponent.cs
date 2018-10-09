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
	// Token: 0x02000883 RID: 2179
	[HotFix]
	public class AnikiGymComponent : AnikiGymComponentCommon
	{
		// Token: 0x06006BEB RID: 27627 RVA: 0x001E39D8 File Offset: 0x001E1BD8
		public AnikiGymComponent()
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

		// Token: 0x06006BEC RID: 27628 RVA: 0x001E3A40 File Offset: 0x001E1C40
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

		// Token: 0x06006BED RID: 27629 RVA: 0x001E3ABC File Offset: 0x001E1CBC
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

		// Token: 0x06006BEE RID: 27630 RVA: 0x001E3B24 File Offset: 0x001E1D24
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

		// Token: 0x06006BEF RID: 27631 RVA: 0x001E3B8C File Offset: 0x001E1D8C
		public void DeSerialize(DSAnikiGymNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSAnikiGymNtf_hotfix != null)
			{
				this.m_DeSerializeDSAnikiGymNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_anikiGymDS.ClearInitedData();
			this.m_anikiGymDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_anikiGymDS.InitChallengedNums(msg.ChallengedNums);
			this.m_anikiGymDS.InitFinishedLevels(msg.FinishedLeves);
		}

		// Token: 0x06006BF0 RID: 27632 RVA: 0x001E3C44 File Offset: 0x001E1E44
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
			return this.m_anikiGymDS.ClientVersion;
		}

		// Token: 0x06006BF1 RID: 27633 RVA: 0x001E3CBC File Offset: 0x001E1EBC
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
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_AnikiGym);
			BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
			return (bagItemBase != null) ? bagItemBase.Nums : 0;
		}

		// Token: 0x06006BF2 RID: 27634 RVA: 0x001E3D58 File Offset: 0x001E1F58
		public int FinishedAnikiGymLevel(int levelId, bool isWin, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedAnikiGymLevelInt32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedAnikiGymLevelInt32BooleanList`1_hotfix.call(new object[]
				{
					this,
					levelId,
					isWin,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(levelId);
			if (configDataAnikiLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -1901;
			}
			if (isWin)
			{
				List<int> pveTeam = this.m_battle.GetPveTeam();
				this.SetSuccessAnikiGymLevel(configDataAnikiLevelInfo, battleTreasures, pveTeam, false);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06006BF3 RID: 27635 RVA: 0x001E3E48 File Offset: 0x001E2048
		public void SetSuccessAnikiGymLevel(ConfigDataAnikiLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, bool isTeamBattle)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List`1Boolean_hotfix != null)
			{
				this.m_SetSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List`1Boolean_hotfix.call(new object[]
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
			base.SetCommonSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, energyCost, isTeamBattle);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.Gold;
		}

		// Token: 0x06006BF4 RID: 27636 RVA: 0x001E3F4C File Offset: 0x001E214C
		public bool IsAnikiGymOpened(int anikiGymId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAnikiGymOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAnikiGymOpenedInt32_hotfix.call(new object[]
				{
					this,
					anikiGymId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int anikiGymId = anikiGymId2;
			int dayOfWeek = (int)this.m_basicInfo.GetCurrentTime().DayOfWeek;
			int key = (dayOfWeek != 0) ? dayOfWeek : 7;
			List<ConfigDataAnikiGymInfo> list;
			return this.m_configDataLoader.AnikiGymData.AnikiGymOfWeekDict.TryGetValue(key, out list) && list.Find((ConfigDataAnikiGymInfo t) => t.ID == anikiGymId) != null;
		}

		// Token: 0x06006BF5 RID: 27637 RVA: 0x001E4034 File Offset: 0x001E2234
		public bool IsAnikiLevelOpened(int anikiLevelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAnikiLevelOpenedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAnikiLevelOpenedInt32_hotfix.call(new object[]
				{
					this,
					anikiLevelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataAnikiLevelInfo configDataAnikiLevelInfo = this.m_configDataLoader.GetConfigDataAnikiLevelInfo(anikiLevelId);
			return configDataAnikiLevelInfo != null && (configDataAnikiLevelInfo.PreLevel == 0 || this.m_anikiGymDS.IsLevelFinished(configDataAnikiLevelInfo.PreLevel));
		}

		// Token: 0x17001B97 RID: 7063
		// (get) Token: 0x06006BF6 RID: 27638 RVA: 0x001E40EC File Offset: 0x001E22EC
		// (set) Token: 0x06006BF7 RID: 27639 RVA: 0x001E410C File Offset: 0x001E230C
		[DoNotToLua]
		public new AnikiGymComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new AnikiGymComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006BF8 RID: 27640 RVA: 0x001E4118 File Offset: 0x001E2318
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006BF9 RID: 27641 RVA: 0x001E4120 File Offset: 0x001E2320
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006BFA RID: 27642 RVA: 0x001E4128 File Offset: 0x001E2328
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006BFB RID: 27643 RVA: 0x001E4130 File Offset: 0x001E2330
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006BFC RID: 27644 RVA: 0x001E4138 File Offset: 0x001E2338
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006BFD RID: 27645 RVA: 0x001E4144 File Offset: 0x001E2344
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006BFE RID: 27646 RVA: 0x001E414C File Offset: 0x001E234C
		private int __callBase_AttackAnikiGymLevel(int levelId)
		{
			return base.AttackAnikiGymLevel(levelId);
		}

		// Token: 0x06006BFF RID: 27647 RVA: 0x001E4158 File Offset: 0x001E2358
		private int __callBase_CanAttackAnikiGymLevel(int levelId, bool isTeamBattle)
		{
			return base.CanAttackAnikiGymLevel(levelId, isTeamBattle);
		}

		// Token: 0x06006C00 RID: 27648 RVA: 0x001E4164 File Offset: 0x001E2364
		private bool __callBase_IsLevelFinished(int levelId)
		{
			return base.IsLevelFinished(levelId);
		}

		// Token: 0x06006C01 RID: 27649 RVA: 0x001E4170 File Offset: 0x001E2370
		private void __callBase_SetCommonSuccessAnikiGymLevel(ConfigDataAnikiLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
		{
			base.SetCommonSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
		}

		// Token: 0x06006C02 RID: 27650 RVA: 0x001E4180 File Offset: 0x001E2380
		private HashSet<int> __callBase_GetAllFinishedLevels()
		{
			return base.GetAllFinishedLevels();
		}

		// Token: 0x06006C03 RID: 27651 RVA: 0x001E4188 File Offset: 0x001E2388
		private bool __callBase_IsDailyChallenge()
		{
			return base.IsDailyChallenge();
		}

		// Token: 0x06006C04 RID: 27652 RVA: 0x001E4190 File Offset: 0x001E2390
		private int __callBase_GetDailyChallengNums()
		{
			return base.GetDailyChallengNums();
		}

		// Token: 0x06006C05 RID: 27653 RVA: 0x001E4198 File Offset: 0x001E2398
		private void __callBase_AddChallengedNums(int nums)
		{
			base.AddChallengedNums(nums);
		}

		// Token: 0x06006C06 RID: 27654 RVA: 0x001E41A4 File Offset: 0x001E23A4
		private List<int> __callBase_GetAllUnlockedLevels()
		{
			return base.GetAllUnlockedLevels();
		}

		// Token: 0x06006C07 RID: 27655 RVA: 0x001E41AC File Offset: 0x001E23AC
		private bool __callBase_IsLevelUnlocked(int levelId)
		{
			return base.IsLevelUnlocked(levelId);
		}

		// Token: 0x06006C08 RID: 27656 RVA: 0x001E41B8 File Offset: 0x001E23B8
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
					this.m_DeSerializeDSAnikiGymNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetCurrentTicketNums_hotfix = (luaObj.RawGet("GetCurrentTicketNums") as LuaFunction);
					this.m_FinishedAnikiGymLevelInt32BooleanList`1_hotfix = (luaObj.RawGet("FinishedAnikiGymLevel") as LuaFunction);
					this.m_SetSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List`1Boolean_hotfix = (luaObj.RawGet("SetSuccessAnikiGymLevel") as LuaFunction);
					this.m_IsAnikiGymOpenedInt32_hotfix = (luaObj.RawGet("IsAnikiGymOpened") as LuaFunction);
					this.m_IsAnikiLevelOpenedInt32_hotfix = (luaObj.RawGet("IsAnikiLevelOpened") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006C09 RID: 27657 RVA: 0x001E4380 File Offset: 0x001E2580
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(AnikiGymComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040052FF RID: 21247
		[DoNotToLua]
		private AnikiGymComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005300 RID: 21248
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005301 RID: 21249
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005302 RID: 21250
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005303 RID: 21251
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005304 RID: 21252
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005305 RID: 21253
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005306 RID: 21254
		private LuaFunction m_DeSerializeDSAnikiGymNtf_hotfix;

		// Token: 0x04005307 RID: 21255
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005308 RID: 21256
		private LuaFunction m_GetCurrentTicketNums_hotfix;

		// Token: 0x04005309 RID: 21257
		private LuaFunction m_FinishedAnikiGymLevelInt32BooleanList;

		// Token: 0x0400530A RID: 21258
		private LuaFunction m_SetSuccessAnikiGymLevelConfigDataAnikiLevelInfoList`1List;

		// Token: 0x0400530B RID: 21259
		private LuaFunction m_IsAnikiGymOpenedInt32_hotfix;

		// Token: 0x0400530C RID: 21260
		private LuaFunction m_IsAnikiLevelOpenedInt32_hotfix;

		// Token: 0x02000884 RID: 2180
		public new class LuaExportHelper
		{
			// Token: 0x06006C0A RID: 27658 RVA: 0x001E43E8 File Offset: 0x001E25E8
			public LuaExportHelper(AnikiGymComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006C0B RID: 27659 RVA: 0x001E43F8 File Offset: 0x001E25F8
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006C0C RID: 27660 RVA: 0x001E4408 File Offset: 0x001E2608
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006C0D RID: 27661 RVA: 0x001E4418 File Offset: 0x001E2618
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006C0E RID: 27662 RVA: 0x001E4428 File Offset: 0x001E2628
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006C0F RID: 27663 RVA: 0x001E4438 File Offset: 0x001E2638
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006C10 RID: 27664 RVA: 0x001E4448 File Offset: 0x001E2648
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006C11 RID: 27665 RVA: 0x001E4458 File Offset: 0x001E2658
			public int __callBase_AttackAnikiGymLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackAnikiGymLevel(levelId);
			}

			// Token: 0x06006C12 RID: 27666 RVA: 0x001E4468 File Offset: 0x001E2668
			public int __callBase_CanAttackAnikiGymLevel(int levelId, bool isTeamBattle)
			{
				return this.m_owner.__callBase_CanAttackAnikiGymLevel(levelId, isTeamBattle);
			}

			// Token: 0x06006C13 RID: 27667 RVA: 0x001E4478 File Offset: 0x001E2678
			public bool __callBase_IsLevelFinished(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(levelId);
			}

			// Token: 0x06006C14 RID: 27668 RVA: 0x001E4488 File Offset: 0x001E2688
			public void __callBase_SetCommonSuccessAnikiGymLevel(ConfigDataAnikiLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes, int energyCost, bool isBattleTeam)
			{
				this.m_owner.__callBase_SetCommonSuccessAnikiGymLevel(levelInfo, battleTreasures, heroes, energyCost, isBattleTeam);
			}

			// Token: 0x06006C15 RID: 27669 RVA: 0x001E449C File Offset: 0x001E269C
			public HashSet<int> __callBase_GetAllFinishedLevels()
			{
				return this.m_owner.__callBase_GetAllFinishedLevels();
			}

			// Token: 0x06006C16 RID: 27670 RVA: 0x001E44AC File Offset: 0x001E26AC
			public bool __callBase_IsDailyChallenge()
			{
				return this.m_owner.__callBase_IsDailyChallenge();
			}

			// Token: 0x06006C17 RID: 27671 RVA: 0x001E44BC File Offset: 0x001E26BC
			public int __callBase_GetDailyChallengNums()
			{
				return this.m_owner.__callBase_GetDailyChallengNums();
			}

			// Token: 0x06006C18 RID: 27672 RVA: 0x001E44CC File Offset: 0x001E26CC
			public void __callBase_AddChallengedNums(int nums)
			{
				this.m_owner.__callBase_AddChallengedNums(nums);
			}

			// Token: 0x06006C19 RID: 27673 RVA: 0x001E44DC File Offset: 0x001E26DC
			public List<int> __callBase_GetAllUnlockedLevels()
			{
				return this.m_owner.__callBase_GetAllUnlockedLevels();
			}

			// Token: 0x06006C1A RID: 27674 RVA: 0x001E44EC File Offset: 0x001E26EC
			public bool __callBase_IsLevelUnlocked(int levelId)
			{
				return this.m_owner.__callBase_IsLevelUnlocked(levelId);
			}

			// Token: 0x0400530D RID: 21261
			private AnikiGymComponent m_owner;
		}
	}
}
