using System;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200090C RID: 2316
	[HotFix]
	public class Happening
	{
		// Token: 0x0600864F RID: 34383 RVA: 0x00268494 File Offset: 0x00266694
		public Happening()
		{
			this.Clear();
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

		// Token: 0x06008650 RID: 34384 RVA: 0x00268500 File Offset: 0x00266700
		public void InitBattleAndDialog(BattleType battleType, ConfigDataBattleInfo battleInfo, int monsterLevel, ConfigDataDialogInfo dialogBefore = null, ConfigDataDialogInfo dialogAfter = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleAndDialogBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix != null)
			{
				this.m_InitBattleAndDialogBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix.call(new object[]
				{
					this,
					battleType,
					battleInfo,
					monsterLevel,
					dialogBefore,
					dialogAfter
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (battleInfo == null)
			{
				battleType = BattleType.None;
			}
			this.BattleType = battleType;
			this.BattleInfo = battleInfo;
			this.MonsterLevel = monsterLevel;
			this.DialogInfoBefore = dialogBefore;
			this.DialogInfoAfter = dialogAfter;
			this.Step = HappeningStep.Init;
		}

		// Token: 0x06008651 RID: 34385 RVA: 0x002685E8 File Offset: 0x002667E8
		public void NextStep()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_NextStep_hotfix != null)
			{
				this.m_NextStep_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Step == HappeningStep.Init)
			{
				if (this.DialogInfoBefore != null)
				{
					this.Step = HappeningStep.DialogBefore;
				}
				else if (this.BattleInfo != null)
				{
					this.Step = HappeningStep.Battle;
				}
				else if (this.DialogInfoAfter != null)
				{
					this.Step = HappeningStep.DialogAfter;
				}
				else if (this.WaypointInfo != null)
				{
					this.Step = HappeningStep.MoveToWaypoint;
				}
				else
				{
					this.Clear();
				}
			}
			else if (this.Step == HappeningStep.DialogBefore)
			{
				if (this.BattleInfo != null)
				{
					this.Step = HappeningStep.Battle;
				}
				else if (this.DialogInfoAfter != null)
				{
					this.Step = HappeningStep.DialogAfter;
				}
				else if (this.WaypointInfo != null)
				{
					this.Step = HappeningStep.MoveToWaypoint;
				}
				else
				{
					this.Clear();
				}
			}
			else if (this.Step == HappeningStep.Battle)
			{
				if (this.DialogInfoAfter != null)
				{
					this.Step = HappeningStep.DialogAfter;
				}
				else
				{
					this.Clear();
				}
			}
			else if (this.Step == HappeningStep.DialogAfter)
			{
				this.Step = HappeningStep.None;
				if (this.BattleInfo == null && this.WaypointInfo != null)
				{
					this.Step = HappeningStep.MoveToWaypoint;
				}
				else
				{
					this.Clear();
				}
			}
			else if (this.Step == HappeningStep.BattleLoseOrCancel)
			{
				if (this.PrevWaypointInfo != null && this.IsLevelInfoNull())
				{
					this.Step = HappeningStep.MoveToPrevWaypoint;
				}
				else
				{
					this.Clear();
				}
			}
			else
			{
				this.Clear();
			}
		}

		// Token: 0x06008652 RID: 34386 RVA: 0x002687C4 File Offset: 0x002669C4
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Step = HappeningStep.None;
			this.ScenarioInfo = null;
			this.EventInfo = null;
			this.RiftLevelInfo = null;
			this.HeroDungeonLevelInfo = null;
			this.HeroPhantomLevelInfo = null;
			this.ThearchyLevelInfo = null;
			this.AnikiLevelInfo = null;
			this.TreasureLevelInfo = null;
			this.MemoryCorridorLevelInfo = null;
			this.HeroTrainningLevelInfo = null;
			this.CooperateBattleLevelInfo = null;
			this.ScoreLevelInfo = null;
			this.ChallengeLevelInfo = null;
			this.TowerFloorInfo = null;
			this.GuildMassiveCombatLevelInfo = null;
			this.WaypointInfo = null;
			this.PrevWaypointInfo = null;
			this.DialogInfoBefore = null;
			this.DialogInfoAfter = null;
			this.BattleInfo = null;
			this.BattleType = BattleType.None;
			this.MonsterLevel = 0;
		}

		// Token: 0x06008653 RID: 34387 RVA: 0x002688C8 File Offset: 0x00266AC8
		private bool IsLevelInfoNull()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelInfoNull_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelInfoNull_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.RiftLevelInfo == null && this.HeroDungeonLevelInfo == null && this.HeroPhantomLevelInfo == null && this.ThearchyLevelInfo == null && this.AnikiLevelInfo == null && this.TreasureLevelInfo == null && this.MemoryCorridorLevelInfo == null && this.HeroTrainningLevelInfo == null && this.CooperateBattleLevelInfo == null && this.ScoreLevelInfo == null && this.ChallengeLevelInfo == null && this.TowerFloorInfo == null && this.GuildMassiveCombatLevelInfo == null;
		}

		// Token: 0x06008654 RID: 34388 RVA: 0x002689C4 File Offset: 0x00266BC4
		public bool GetGameFunctionTypeAndLocationId(out GameFunctionType gameFunctionType, out int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGameFunctionTypeAndLocationIdGameFunctionType_Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_PlayerContext_Happening_GetGameFunctionTypeAndLocationId_GameFunctionType_Int32(this, this.m_GetGameFunctionTypeAndLocationIdGameFunctionType_Int32__hotfix, out gameFunctionType, out locationId);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			gameFunctionType = GameFunctionType.GameFunctionType_None;
			locationId = 0;
			if (this.ScenarioInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_Scenario;
				locationId = this.ScenarioInfo.ID;
				return true;
			}
			if (this.EventInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_Event;
				locationId = this.EventInfo.ID;
				return true;
			}
			if (this.RiftLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_Rift;
				locationId = this.RiftLevelInfo.ID;
				return true;
			}
			if (this.HeroDungeonLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_HeroDungeon;
				locationId = this.HeroDungeonLevelInfo.ID;
				return true;
			}
			if (this.HeroPhantomLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_HeroPhantom;
				locationId = this.HeroPhantomLevelInfo.ID;
				return true;
			}
			if (this.ThearchyLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_ThearchyTrial;
				locationId = this.ThearchyLevelInfo.ID;
				return true;
			}
			if (this.AnikiLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_AnikiGym;
				locationId = this.AnikiLevelInfo.ID;
				return true;
			}
			if (this.TreasureLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_TreasureMap;
				locationId = this.TreasureLevelInfo.ID;
				return true;
			}
			if (this.MemoryCorridorLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_MemoryCorridor;
				locationId = this.MemoryCorridorLevelInfo.ID;
				return true;
			}
			if (this.HeroTrainningLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_HeroTrainning;
				locationId = this.HeroTrainningLevelInfo.ID;
				return true;
			}
			if (this.CooperateBattleLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_CooperateBattle;
				locationId = this.CooperateBattleLevelInfo.ID;
				return true;
			}
			if (this.ScoreLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel;
				locationId = this.ScoreLevelInfo.ID;
				return true;
			}
			if (this.ChallengeLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_UnchartedScoreChallengeLevel;
				locationId = this.ChallengeLevelInfo.ID;
				return true;
			}
			if (this.TowerFloorInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_ClimbTower;
				locationId = this.TowerFloorInfo.ID;
				return true;
			}
			if (this.GuildMassiveCombatLevelInfo != null)
			{
				gameFunctionType = GameFunctionType.GameFunctionType_GuildMassiveCombat;
				locationId = this.GuildMassiveCombatLevelInfo.ID;
				return true;
			}
			return false;
		}

		// Token: 0x06008655 RID: 34389 RVA: 0x00268BEC File Offset: 0x00266DEC
		public string GetStrategy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStrategy_hotfix != null)
			{
				return (string)this.m_GetStrategy_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.ScenarioInfo != null)
			{
				return this.ScenarioInfo.Strategy;
			}
			if (this.EventInfo != null)
			{
				return this.EventInfo.Strategy;
			}
			if (this.RiftLevelInfo != null)
			{
				return this.RiftLevelInfo.Strategy;
			}
			if (this.HeroDungeonLevelInfo != null)
			{
				return this.HeroDungeonLevelInfo.Strategy;
			}
			if (this.HeroPhantomLevelInfo != null)
			{
				return this.HeroPhantomLevelInfo.Strategy;
			}
			if (this.ThearchyLevelInfo != null)
			{
				return this.ThearchyLevelInfo.Strategy;
			}
			if (this.AnikiLevelInfo != null)
			{
				return this.AnikiLevelInfo.Strategy;
			}
			if (this.TreasureLevelInfo != null)
			{
				return this.TreasureLevelInfo.Strategy;
			}
			if (this.MemoryCorridorLevelInfo != null)
			{
				return this.MemoryCorridorLevelInfo.Strategy;
			}
			if (this.HeroTrainningLevelInfo != null)
			{
				return this.HeroTrainningLevelInfo.Strategy;
			}
			if (this.CooperateBattleLevelInfo == null)
			{
				if (this.ScoreLevelInfo == null)
				{
					if (this.ChallengeLevelInfo == null)
					{
						if (this.TowerFloorInfo == null)
						{
							if (this.GuildMassiveCombatLevelInfo != null)
							{
								return this.GuildMassiveCombatLevelInfo.Strategy;
							}
						}
					}
				}
			}
			return string.Empty;
		}

		// Token: 0x06008656 RID: 34390 RVA: 0x00268D9C File Offset: 0x00266F9C
		public bool GetStarCondition(out int starTurnMax, out int starDeadMax)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetStarConditionInt32_Int32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_PlayerContext_Happening_GetStarCondition_Int32_Int32(this, this.m_GetStarConditionInt32_Int32__hotfix, out starTurnMax, out starDeadMax);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			starTurnMax = (starDeadMax = 0);
			if (this.RiftLevelInfo != null)
			{
				starTurnMax = this.RiftLevelInfo.StarTurnMax;
				starDeadMax = this.RiftLevelInfo.StarDeadMax;
				return true;
			}
			if (this.HeroDungeonLevelInfo != null)
			{
				starTurnMax = this.HeroDungeonLevelInfo.StarTurnMax;
				starDeadMax = this.HeroDungeonLevelInfo.StarDeadMax;
				return true;
			}
			return false;
		}

		// Token: 0x06008657 RID: 34391 RVA: 0x00268E50 File Offset: 0x00267050
		public BattleLevelAchievement[] GetBattleLevelAchievements()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleLevelAchievements_hotfix != null)
			{
				return (BattleLevelAchievement[])this.m_GetBattleLevelAchievements_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.RiftLevelInfo != null)
			{
				return this.RiftLevelInfo.m_achievements;
			}
			if (this.HeroDungeonLevelInfo != null)
			{
				return this.HeroDungeonLevelInfo.m_achievements;
			}
			if (this.HeroPhantomLevelInfo != null)
			{
				return this.HeroPhantomLevelInfo.m_achievements;
			}
			return null;
		}

		// Token: 0x17001C4E RID: 7246
		// (get) Token: 0x06008658 RID: 34392 RVA: 0x00268F04 File Offset: 0x00267104
		// (set) Token: 0x06008659 RID: 34393 RVA: 0x00268F24 File Offset: 0x00267124
		[DoNotToLua]
		public Happening.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new Happening.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x0600865A RID: 34394 RVA: 0x00268F30 File Offset: 0x00267130
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
					this.m_InitBattleAndDialogBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix = (luaObj.RawGet("InitBattleAndDialog") as LuaFunction);
					this.m_NextStep_hotfix = (luaObj.RawGet("NextStep") as LuaFunction);
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_IsLevelInfoNull_hotfix = (luaObj.RawGet("IsLevelInfoNull") as LuaFunction);
					this.m_GetGameFunctionTypeAndLocationIdGameFunctionType_Int32__hotfix = (luaObj.RawGet("GetGameFunctionTypeAndLocationId") as LuaFunction);
					this.m_GetStrategy_hotfix = (luaObj.RawGet("GetStrategy") as LuaFunction);
					this.m_GetStarConditionInt32_Int32__hotfix = (luaObj.RawGet("GetStarCondition") as LuaFunction);
					this.m_GetBattleLevelAchievements_hotfix = (luaObj.RawGet("GetBattleLevelAchievements") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600865B RID: 34395 RVA: 0x002690C4 File Offset: 0x002672C4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(Happening));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005F31 RID: 24369
		public HappeningStep Step;

		// Token: 0x04005F32 RID: 24370
		public ConfigDataScenarioInfo ScenarioInfo;

		// Token: 0x04005F33 RID: 24371
		public ConfigDataEventInfo EventInfo;

		// Token: 0x04005F34 RID: 24372
		public ConfigDataRiftLevelInfo RiftLevelInfo;

		// Token: 0x04005F35 RID: 24373
		public ConfigDataHeroDungeonLevelInfo HeroDungeonLevelInfo;

		// Token: 0x04005F36 RID: 24374
		public ConfigDataHeroPhantomLevelInfo HeroPhantomLevelInfo;

		// Token: 0x04005F37 RID: 24375
		public ConfigDataAnikiLevelInfo AnikiLevelInfo;

		// Token: 0x04005F38 RID: 24376
		public ConfigDataThearchyTrialLevelInfo ThearchyLevelInfo;

		// Token: 0x04005F39 RID: 24377
		public ConfigDataTreasureLevelInfo TreasureLevelInfo;

		// Token: 0x04005F3A RID: 24378
		public ConfigDataMemoryCorridorLevelInfo MemoryCorridorLevelInfo;

		// Token: 0x04005F3B RID: 24379
		public ConfigDataHeroTrainningLevelInfo HeroTrainningLevelInfo;

		// Token: 0x04005F3C RID: 24380
		public ConfigDataCooperateBattleLevelInfo CooperateBattleLevelInfo;

		// Token: 0x04005F3D RID: 24381
		public ConfigDataScoreLevelInfo ScoreLevelInfo;

		// Token: 0x04005F3E RID: 24382
		public ConfigDataChallengeLevelInfo ChallengeLevelInfo;

		// Token: 0x04005F3F RID: 24383
		public ConfigDataTowerFloorInfo TowerFloorInfo;

		// Token: 0x04005F40 RID: 24384
		public ConfigDataGuildMassiveCombatLevelInfo GuildMassiveCombatLevelInfo;

		// Token: 0x04005F41 RID: 24385
		public ConfigDataWaypointInfo WaypointInfo;

		// Token: 0x04005F42 RID: 24386
		public ConfigDataWaypointInfo PrevWaypointInfo;

		// Token: 0x04005F43 RID: 24387
		public ConfigDataDialogInfo DialogInfoBefore;

		// Token: 0x04005F44 RID: 24388
		public ConfigDataDialogInfo DialogInfoAfter;

		// Token: 0x04005F45 RID: 24389
		public ConfigDataBattleInfo BattleInfo;

		// Token: 0x04005F46 RID: 24390
		public int MonsterLevel;

		// Token: 0x04005F47 RID: 24391
		public BattleType BattleType;

		// Token: 0x04005F48 RID: 24392
		[DoNotToLua]
		private Happening.LuaExportHelper luaExportHelper;

		// Token: 0x04005F49 RID: 24393
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005F4A RID: 24394
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005F4B RID: 24395
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005F4C RID: 24396
		private LuaFunction m_InitBattleAndDialogBattleTypeConfigDataBattleInfoInt32ConfigDataDialogInfoConfigDataDialogInfo_hotfix;

		// Token: 0x04005F4D RID: 24397
		private LuaFunction m_NextStep_hotfix;

		// Token: 0x04005F4E RID: 24398
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04005F4F RID: 24399
		private LuaFunction m_IsLevelInfoNull_hotfix;

		// Token: 0x04005F50 RID: 24400
		private LuaFunction m_GetGameFunctionTypeAndLocationIdGameFunctionType_Int32__hotfix;

		// Token: 0x04005F51 RID: 24401
		private LuaFunction m_GetStrategy_hotfix;

		// Token: 0x04005F52 RID: 24402
		private LuaFunction m_GetStarConditionInt32_Int32__hotfix;

		// Token: 0x04005F53 RID: 24403
		private LuaFunction m_GetBattleLevelAchievements_hotfix;

		// Token: 0x0200090D RID: 2317
		public class LuaExportHelper
		{
			// Token: 0x0600865C RID: 34396 RVA: 0x0026912C File Offset: 0x0026732C
			public LuaExportHelper(Happening owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600865D RID: 34397 RVA: 0x0026913C File Offset: 0x0026733C
			public bool IsLevelInfoNull()
			{
				return this.m_owner.IsLevelInfoNull();
			}

			// Token: 0x04005F54 RID: 24404
			private Happening m_owner;
		}
	}
}
