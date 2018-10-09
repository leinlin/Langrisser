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
	// Token: 0x020008A3 RID: 2211
	[HotFix]
	public class CooperateBattleCompoment : CooperateBattleCompomentCommon
	{
		// Token: 0x06006EF8 RID: 28408 RVA: 0x001F1048 File Offset: 0x001EF248
		public CooperateBattleCompoment()
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

		// Token: 0x06006EF9 RID: 28409 RVA: 0x001F10B0 File Offset: 0x001EF2B0
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
			base.m_configDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
			base.Init();
		}

		// Token: 0x06006EFA RID: 28410 RVA: 0x001F112C File Offset: 0x001EF32C
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

		// Token: 0x06006EFB RID: 28411 RVA: 0x001F1194 File Offset: 0x001EF394
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

		// Token: 0x06006EFC RID: 28412 RVA: 0x001F11FC File Offset: 0x001EF3FC
		public void DeSerialize(DSCooperateBattleNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSCooperateBattleNtf_hotfix != null)
			{
				this.m_DeSerializeDSCooperateBattleNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cooperateBattleDS.ClearInitedData();
			this.m_cooperateBattleDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
			this.m_cooperateBattleDS.BattleCollections.ConfigDataLoader = base.m_configDataLoader;
			this.m_cooperateBattleDS.UpdateInstantiatedData(ntf);
		}

		// Token: 0x06006EFD RID: 28413 RVA: 0x001F12B4 File Offset: 0x001EF4B4
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
			return this.m_cooperateBattleDS.ClientVersion;
		}

		// Token: 0x06006EFE RID: 28414 RVA: 0x001F132C File Offset: 0x001EF52C
		public void SetSuccessCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo levelInfo, List<int> battleTreasures, List<int> heroes)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List`1_hotfix != null)
			{
				this.m_SetSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List`1_hotfix.call(new object[]
				{
					this,
					levelInfo,
					battleTreasures,
					heroes
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.SetCommonSuccessCooperateBattleLevel(levelInfo, heroes, battleTreasures);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExp);
			battleReward.Gold = levelInfo.Gold;
		}

		// Token: 0x17001BB7 RID: 7095
		// (get) Token: 0x06006EFF RID: 28415 RVA: 0x001F1408 File Offset: 0x001EF608
		// (set) Token: 0x06006F00 RID: 28416 RVA: 0x001F1428 File Offset: 0x001EF628
		[DoNotToLua]
		public new CooperateBattleCompoment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new CooperateBattleCompoment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006F01 RID: 28417 RVA: 0x001F1434 File Offset: 0x001EF634
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006F02 RID: 28418 RVA: 0x001F143C File Offset: 0x001EF63C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006F03 RID: 28419 RVA: 0x001F1444 File Offset: 0x001EF644
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006F04 RID: 28420 RVA: 0x001F144C File Offset: 0x001EF64C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006F05 RID: 28421 RVA: 0x001F1454 File Offset: 0x001EF654
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006F06 RID: 28422 RVA: 0x001F1460 File Offset: 0x001EF660
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006F07 RID: 28423 RVA: 0x001F1468 File Offset: 0x001EF668
		private bool __callBase_CheckCooperateBattleAvailable(int CooperateBattleID, ref int Err)
		{
			return base.CheckCooperateBattleAvailable(CooperateBattleID, ref Err);
		}

		// Token: 0x06006F08 RID: 28424 RVA: 0x001F1474 File Offset: 0x001EF674
		private bool __callBase_CheckCooperateBattleDisplayable(int CooperateBattleID)
		{
			return base.CheckCooperateBattleDisplayable(CooperateBattleID);
		}

		// Token: 0x06006F09 RID: 28425 RVA: 0x001F1480 File Offset: 0x001EF680
		private bool __callBase_IsLevelUnlocked(int LevelId)
		{
			return base.IsLevelUnlocked(LevelId);
		}

		// Token: 0x06006F0A RID: 28426 RVA: 0x001F148C File Offset: 0x001EF68C
		private bool __callBase_IsLevelFinished(int LevelId)
		{
			return base.IsLevelFinished(LevelId);
		}

		// Token: 0x06006F0B RID: 28427 RVA: 0x001F1498 File Offset: 0x001EF698
		private List<int> __callBase_GetAllUnlockedLevels()
		{
			return base.GetAllUnlockedLevels();
		}

		// Token: 0x06006F0C RID: 28428 RVA: 0x001F14A0 File Offset: 0x001EF6A0
		private List<int> __callBase_GetAllFinishedLevels()
		{
			return base.GetAllFinishedLevels();
		}

		// Token: 0x06006F0D RID: 28429 RVA: 0x001F14A8 File Offset: 0x001EF6A8
		private int __callBase_GetDailyChallengeNums(int BattleId)
		{
			return base.GetDailyChallengeNums(BattleId);
		}

		// Token: 0x06006F0E RID: 28430 RVA: 0x001F14B4 File Offset: 0x001EF6B4
		private bool __callBase_CheckCooperateBattleLevelAvailable(int BattleId, int LevelId, ref int Err)
		{
			return base.CheckCooperateBattleLevelAvailable(BattleId, LevelId, ref Err);
		}

		// Token: 0x06006F0F RID: 28431 RVA: 0x001F14C0 File Offset: 0x001EF6C0
		private bool __callBase_CheckPlayerOutOfBattle(ref int Err)
		{
			return base.CheckPlayerOutOfBattle(ref Err);
		}

		// Token: 0x06006F10 RID: 28432 RVA: 0x001F14CC File Offset: 0x001EF6CC
		private bool __callBase_CheckEnergy(int BattleId, int LevelId, ref int Err)
		{
			return base.CheckEnergy(BattleId, LevelId, ref Err);
		}

		// Token: 0x06006F11 RID: 28433 RVA: 0x001F14D8 File Offset: 0x001EF6D8
		private bool __callBase_CheckBag(int CooperateBattleId, int LevelId, ref int Err)
		{
			return base.CheckBag(CooperateBattleId, LevelId, ref Err);
		}

		// Token: 0x06006F12 RID: 28434 RVA: 0x001F14E4 File Offset: 0x001EF6E4
		private int __callBase_CanAttackCooperateBattleLevel(int BattleId, int LevelId)
		{
			return base.CanAttackCooperateBattleLevel(BattleId, LevelId);
		}

		// Token: 0x06006F13 RID: 28435 RVA: 0x001F14F0 File Offset: 0x001EF6F0
		private int __callBase_CanAttackCooperateBattleLevel(int LevelId)
		{
			return base.CanAttackCooperateBattleLevel(LevelId);
		}

		// Token: 0x06006F14 RID: 28436 RVA: 0x001F14FC File Offset: 0x001EF6FC
		private void __callBase_SetCommonSuccessCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo Level, List<int> Heroes, List<int> BattleTreasures)
		{
			base.SetCommonSuccessCooperateBattleLevel(Level, Heroes, BattleTreasures);
		}

		// Token: 0x06006F15 RID: 28437 RVA: 0x001F1508 File Offset: 0x001EF708
		private void __callBase_FinishedCooperateBattleLevel(CooperateBattleLevel Level, List<int> heroes)
		{
			base.FinishedCooperateBattleLevel(Level, heroes);
		}

		// Token: 0x06006F16 RID: 28438 RVA: 0x001F1514 File Offset: 0x001EF714
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
					this.m_DeSerializeDSCooperateBattleNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_SetSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List`1_hotfix = (luaObj.RawGet("SetSuccessCooperateBattleLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006F17 RID: 28439 RVA: 0x001F1678 File Offset: 0x001EF878
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(CooperateBattleCompoment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400545E RID: 21598
		[DoNotToLua]
		private CooperateBattleCompoment.LuaExportHelper luaExportHelper;

		// Token: 0x0400545F RID: 21599
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005460 RID: 21600
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005461 RID: 21601
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005462 RID: 21602
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005463 RID: 21603
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005464 RID: 21604
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005465 RID: 21605
		private LuaFunction m_DeSerializeDSCooperateBattleNtf_hotfix;

		// Token: 0x04005466 RID: 21606
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005467 RID: 21607
		private LuaFunction m_SetSuccessCooperateBattleLevelConfigDataCooperateBattleLevelInfoList`1List;

		// Token: 0x020008A4 RID: 2212
		public new class LuaExportHelper
		{
			// Token: 0x06006F18 RID: 28440 RVA: 0x001F16E0 File Offset: 0x001EF8E0
			public LuaExportHelper(CooperateBattleCompoment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006F19 RID: 28441 RVA: 0x001F16F0 File Offset: 0x001EF8F0
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006F1A RID: 28442 RVA: 0x001F1700 File Offset: 0x001EF900
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006F1B RID: 28443 RVA: 0x001F1710 File Offset: 0x001EF910
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006F1C RID: 28444 RVA: 0x001F1720 File Offset: 0x001EF920
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006F1D RID: 28445 RVA: 0x001F1730 File Offset: 0x001EF930
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006F1E RID: 28446 RVA: 0x001F1740 File Offset: 0x001EF940
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006F1F RID: 28447 RVA: 0x001F1750 File Offset: 0x001EF950
			public bool __callBase_CheckCooperateBattleAvailable(int CooperateBattleID, ref int Err)
			{
				return this.m_owner.__callBase_CheckCooperateBattleAvailable(CooperateBattleID, ref Err);
			}

			// Token: 0x06006F20 RID: 28448 RVA: 0x001F1760 File Offset: 0x001EF960
			public bool __callBase_CheckCooperateBattleDisplayable(int CooperateBattleID)
			{
				return this.m_owner.__callBase_CheckCooperateBattleDisplayable(CooperateBattleID);
			}

			// Token: 0x06006F21 RID: 28449 RVA: 0x001F1770 File Offset: 0x001EF970
			public bool __callBase_IsLevelUnlocked(int LevelId)
			{
				return this.m_owner.__callBase_IsLevelUnlocked(LevelId);
			}

			// Token: 0x06006F22 RID: 28450 RVA: 0x001F1780 File Offset: 0x001EF980
			public bool __callBase_IsLevelFinished(int LevelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(LevelId);
			}

			// Token: 0x06006F23 RID: 28451 RVA: 0x001F1790 File Offset: 0x001EF990
			public List<int> __callBase_GetAllUnlockedLevels()
			{
				return this.m_owner.__callBase_GetAllUnlockedLevels();
			}

			// Token: 0x06006F24 RID: 28452 RVA: 0x001F17A0 File Offset: 0x001EF9A0
			public List<int> __callBase_GetAllFinishedLevels()
			{
				return this.m_owner.__callBase_GetAllFinishedLevels();
			}

			// Token: 0x06006F25 RID: 28453 RVA: 0x001F17B0 File Offset: 0x001EF9B0
			public int __callBase_GetDailyChallengeNums(int BattleId)
			{
				return this.m_owner.__callBase_GetDailyChallengeNums(BattleId);
			}

			// Token: 0x06006F26 RID: 28454 RVA: 0x001F17C0 File Offset: 0x001EF9C0
			public bool __callBase_CheckCooperateBattleLevelAvailable(int BattleId, int LevelId, ref int Err)
			{
				return this.m_owner.__callBase_CheckCooperateBattleLevelAvailable(BattleId, LevelId, ref Err);
			}

			// Token: 0x06006F27 RID: 28455 RVA: 0x001F17D0 File Offset: 0x001EF9D0
			public bool __callBase_CheckPlayerOutOfBattle(ref int Err)
			{
				return this.m_owner.__callBase_CheckPlayerOutOfBattle(ref Err);
			}

			// Token: 0x06006F28 RID: 28456 RVA: 0x001F17E0 File Offset: 0x001EF9E0
			public bool __callBase_CheckEnergy(int BattleId, int LevelId, ref int Err)
			{
				return this.m_owner.__callBase_CheckEnergy(BattleId, LevelId, ref Err);
			}

			// Token: 0x06006F29 RID: 28457 RVA: 0x001F17F0 File Offset: 0x001EF9F0
			public bool __callBase_CheckBag(int CooperateBattleId, int LevelId, ref int Err)
			{
				return this.m_owner.__callBase_CheckBag(CooperateBattleId, LevelId, ref Err);
			}

			// Token: 0x06006F2A RID: 28458 RVA: 0x001F1800 File Offset: 0x001EFA00
			public int __callBase_CanAttackCooperateBattleLevel(int BattleId, int LevelId)
			{
				return this.m_owner.__callBase_CanAttackCooperateBattleLevel(BattleId, LevelId);
			}

			// Token: 0x06006F2B RID: 28459 RVA: 0x001F1810 File Offset: 0x001EFA10
			public int __callBase_CanAttackCooperateBattleLevel(int LevelId)
			{
				return this.m_owner.__callBase_CanAttackCooperateBattleLevel(LevelId);
			}

			// Token: 0x06006F2C RID: 28460 RVA: 0x001F1820 File Offset: 0x001EFA20
			public void __callBase_SetCommonSuccessCooperateBattleLevel(ConfigDataCooperateBattleLevelInfo Level, List<int> Heroes, List<int> BattleTreasures)
			{
				this.m_owner.__callBase_SetCommonSuccessCooperateBattleLevel(Level, Heroes, BattleTreasures);
			}

			// Token: 0x06006F2D RID: 28461 RVA: 0x001F1830 File Offset: 0x001EFA30
			public void __callBase_FinishedCooperateBattleLevel(CooperateBattleLevel Level, List<int> heroes)
			{
				this.m_owner.__callBase_FinishedCooperateBattleLevel(Level, heroes);
			}

			// Token: 0x04005468 RID: 21608
			private CooperateBattleCompoment m_owner;
		}
	}
}
