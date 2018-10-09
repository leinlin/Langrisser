using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004B6 RID: 1206
	[HotFix]
	public class TreasureMapComponentCommon : IComponentBase
	{
		// Token: 0x060049A6 RID: 18854 RVA: 0x0016FBFC File Offset: 0x0016DDFC
		public TreasureMapComponentCommon()
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

		// Token: 0x060049A7 RID: 18855 RVA: 0x0016FC70 File Offset: 0x0016DE70
		public string GetName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetName_hotfix != null)
			{
				return (string)this.m_GetName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return "TreasureMap";
		}

		// Token: 0x060049A8 RID: 18856 RVA: 0x0016FCE4 File Offset: 0x0016DEE4
		public virtual void Init()
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
		}

		// Token: 0x060049A9 RID: 18857 RVA: 0x0016FD44 File Offset: 0x0016DF44
		public virtual void PostInit()
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
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
		}

		// Token: 0x060049AA RID: 18858 RVA: 0x0016FE10 File Offset: 0x0016E010
		public virtual void DeInit()
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
		}

		// Token: 0x060049AB RID: 18859 RVA: 0x0016FE70 File Offset: 0x0016E070
		public virtual void Tick(uint deltaMillisecond)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TickUInt32_hotfix != null)
			{
				this.m_TickUInt32_hotfix.call(new object[]
				{
					this,
					deltaMillisecond
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060049AC RID: 18860 RVA: 0x0016FEE0 File Offset: 0x0016E0E0
		public virtual bool Serialize<T>(T dest)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SerializeT_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SerializeT_hotfix.call(new object[]
				{
					this,
					dest
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return false;
		}

		// Token: 0x060049AD RID: 18861 RVA: 0x0016FF60 File Offset: 0x0016E160
		public virtual void DeSerialize<T>(T source)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeT_hotfix != null)
			{
				this.m_DeSerializeT_hotfix.call(new object[]
				{
					this,
					source
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060049AE RID: 18862 RVA: 0x0016FFD0 File Offset: 0x0016E1D0
		public virtual void PostDeSerialize()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PostDeSerialize_hotfix != null)
			{
				this.m_PostDeSerialize_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x1700124A RID: 4682
		// (get) Token: 0x060049AF RID: 18863 RVA: 0x00170030 File Offset: 0x0016E230
		// (set) Token: 0x060049B0 RID: 18864 RVA: 0x001700A4 File Offset: 0x0016E2A4
		public IComponentOwner Owner
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Owner_hotfix != null)
				{
					return (IComponentOwner)this.m_get_Owner_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Owner>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_OwnerIComponentOwner_hotfix != null)
				{
					this.m_set_OwnerIComponentOwner_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Owner>k__BackingField = value;
			}
		}

		// Token: 0x060049B1 RID: 18865 RVA: 0x0017011C File Offset: 0x0016E31C
		public bool IsLevelFinished(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelFinishedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelFinishedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_treasureMapDS.IsLevelFinished(levelId);
		}

		// Token: 0x060049B2 RID: 18866 RVA: 0x001701A4 File Offset: 0x0016E3A4
		public int AttackTreasureLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AttackTreasureLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AttackTreasureLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanAttackTreasureLevel(levelId);
			if (num != 0)
			{
				if (num == -900)
				{
					this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				}
				return num;
			}
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = this.m_configDataLoader.GetConfigDataTreasureLevelInfo(levelId);
			this.m_basicInfo.DecreaseEnergy(configDataTreasureLevelInfo.EnergyFail, GameFunctionType.GameFunctionType_TreasureMap, levelId.ToString());
			if (configDataTreasureLevelInfo.TicketCost > 0)
			{
				int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_TreasureMap);
				BagItemBase bagItem = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
				this.m_bag.RemoveBagItemDirectly(bagItem, configDataTreasureLevelInfo.TicketCost, GameFunctionType.GameFunctionType_TreasureMap, levelId.ToString());
			}
			this.m_battle.SetProcessingBattleInfo(BattleType.TreasureMap, levelId);
			return 0;
		}

		// Token: 0x060049B3 RID: 18867 RVA: 0x001702D0 File Offset: 0x0016E4D0
		private bool IsGameFunctionOpened()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGameFunctionOpened_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGameFunctionOpened_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_basicInfo.IsGameFunctionOpened(GameFunctionType.GameFunctionType_TreasureMap);
		}

		// Token: 0x060049B4 RID: 18868 RVA: 0x0017034C File Offset: 0x0016E54C
		public virtual int CanAttackTreasureLevel(int leveId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackTreasureLevelInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackTreasureLevelInt32_hotfix.call(new object[]
				{
					this,
					leveId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsGameFunctionOpened())
			{
				return -2603;
			}
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = this.m_configDataLoader.GetConfigDataTreasureLevelInfo(leveId);
			if (configDataTreasureLevelInfo == null)
			{
				return -2601;
			}
			if (configDataTreasureLevelInfo.m_battleInfo == null)
			{
				return -2602;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			int level = this.m_basicInfo.GetLevel();
			if (level < configDataTreasureLevelInfo.OpenPlayerLevel)
			{
				return -413;
			}
			return this.CanAttackLevelByEnergyAndSoOn(configDataTreasureLevelInfo);
		}

		// Token: 0x060049B5 RID: 18869 RVA: 0x00170440 File Offset: 0x0016E640
		private int CanAttackLevelByEnergyAndSoOn(ConfigDataTreasureLevelInfo levelInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackLevelByEnergyAndSoOnConfigDataTreasureLevelInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackLevelByEnergyAndSoOnConfigDataTreasureLevelInfo_hotfix.call(new object[]
				{
					this,
					levelInfo
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_TreasureMap);
			if (!this.m_bag.IsBagItemEnough(GoodsType.GoodsType_Item, ticketId, levelInfo.TicketCost))
			{
				return -2600;
			}
			if (!this.m_basicInfo.IsEnergyEnough(levelInfo.EnergySuccess))
			{
				return -402;
			}
			return 0;
		}

		// Token: 0x060049B6 RID: 18870 RVA: 0x00170508 File Offset: 0x0016E708
		protected virtual void SetSuccessTreasureMapLevel(ConfigDataTreasureLevelInfo levelInfo, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessTreasureMapLevelConfigDataTreasureLevelInfoList`1_hotfix != null)
			{
				this.m_SetSuccessTreasureMapLevelConfigDataTreasureLevelInfoList`1_hotfix.call(new object[]
				{
					this,
					levelInfo,
					battleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle.AddBattleTreasures(battleTreasures);
			this.m_basicInfo.AddPlayerExp(levelInfo.PlayerExp);
			this.m_basicInfo.DecreaseEnergy(levelInfo.EnergySuccess - levelInfo.EnergyFail, GameFunctionType.GameFunctionType_TreasureMap, levelInfo.ID.ToString());
			this.OnFinishedLevel(levelInfo.ID);
			List<int> pveTeam = this.m_battle.GetPveTeam();
			this.m_battle.AddFightHeroFightNumsAndExp(pveTeam, 0);
			this.m_battle.WinPveBattle(levelInfo.Battle_ID);
			if (this.CompleteTreasureMapMissionEvent != null)
			{
				this.CompleteTreasureMapMissionEvent(BattleType.TreasureMap, levelInfo.ID, pveTeam);
			}
		}

		// Token: 0x060049B7 RID: 18871 RVA: 0x0017062C File Offset: 0x0016E82C
		protected void OnFinishedLevel(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFinishedLevelInt32_hotfix != null)
			{
				this.m_OnFinishedLevelInt32_hotfix.call(new object[]
				{
					this,
					levelId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_treasureMapDS.AddFinishedLevel(levelId);
		}

		// Token: 0x14000066 RID: 102
		// (add) Token: 0x060049B8 RID: 18872 RVA: 0x001706A8 File Offset: 0x0016E8A8
		// (remove) Token: 0x060049B9 RID: 18873 RVA: 0x00170744 File Offset: 0x0016E944
		public event Action<BattleType, int, List<int>> CompleteTreasureMapMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_CompleteTreasureMapMissionEventAction`3_hotfix != null)
				{
					this.m_add_CompleteTreasureMapMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteTreasureMapMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteTreasureMapMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_CompleteTreasureMapMissionEventAction`3_hotfix != null)
				{
					this.m_remove_CompleteTreasureMapMissionEventAction`3_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<BattleType, int, List<int>> action = this.CompleteTreasureMapMissionEvent;
				Action<BattleType, int, List<int>> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<BattleType, int, List<int>>>(ref this.CompleteTreasureMapMissionEvent, (Action<BattleType, int, List<int>>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1700124B RID: 4683
		// (get) Token: 0x060049BA RID: 18874 RVA: 0x001707E0 File Offset: 0x0016E9E0
		// (set) Token: 0x060049BB RID: 18875 RVA: 0x00170800 File Offset: 0x0016EA00
		[DoNotToLua]
		public TreasureMapComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TreasureMapComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060049BC RID: 18876 RVA: 0x0017080C File Offset: 0x0016EA0C
		private void __callDele_CompleteTreasureMapMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			Action<BattleType, int, List<int>> completeTreasureMapMissionEvent = this.CompleteTreasureMapMissionEvent;
			if (completeTreasureMapMissionEvent != null)
			{
				completeTreasureMapMissionEvent(arg1, arg2, arg3);
			}
		}

		// Token: 0x060049BD RID: 18877 RVA: 0x00170830 File Offset: 0x0016EA30
		private void __clearDele_CompleteTreasureMapMissionEvent(BattleType arg1, int arg2, List<int> arg3)
		{
			this.CompleteTreasureMapMissionEvent = null;
		}

		// Token: 0x060049BE RID: 18878 RVA: 0x0017083C File Offset: 0x0016EA3C
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
					this.m_GetName_hotfix = (luaObj.RawGet("GetName") as LuaFunction);
					this.m_Init_hotfix = (luaObj.RawGet("Init") as LuaFunction);
					this.m_PostInit_hotfix = (luaObj.RawGet("PostInit") as LuaFunction);
					this.m_DeInit_hotfix = (luaObj.RawGet("DeInit") as LuaFunction);
					this.m_TickUInt32_hotfix = (luaObj.RawGet("Tick") as LuaFunction);
					this.m_SerializeT_hotfix = (luaObj.RawGet("Serialize") as LuaFunction);
					this.m_DeSerializeT_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_PostDeSerialize_hotfix = (luaObj.RawGet("PostDeSerialize") as LuaFunction);
					this.m_get_Owner_hotfix = (luaObj.RawGet("get_Owner") as LuaFunction);
					this.m_set_OwnerIComponentOwner_hotfix = (luaObj.RawGet("set_Owner") as LuaFunction);
					this.m_IsLevelFinishedInt32_hotfix = (luaObj.RawGet("IsLevelFinished") as LuaFunction);
					this.m_AttackTreasureLevelInt32_hotfix = (luaObj.RawGet("AttackTreasureLevel") as LuaFunction);
					this.m_IsGameFunctionOpened_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_CanAttackTreasureLevelInt32_hotfix = (luaObj.RawGet("CanAttackTreasureLevel") as LuaFunction);
					this.m_CanAttackLevelByEnergyAndSoOnConfigDataTreasureLevelInfo_hotfix = (luaObj.RawGet("CanAttackLevelByEnergyAndSoOn") as LuaFunction);
					this.m_SetSuccessTreasureMapLevelConfigDataTreasureLevelInfoList`1_hotfix = (luaObj.RawGet("SetSuccessTreasureMapLevel") as LuaFunction);
					this.m_OnFinishedLevelInt32_hotfix = (luaObj.RawGet("OnFinishedLevel") as LuaFunction);
					this.m_add_CompleteTreasureMapMissionEventAction`3_hotfix = (luaObj.RawGet("add_CompleteTreasureMapMissionEvent") as LuaFunction);
					this.m_remove_CompleteTreasureMapMissionEventAction`3_hotfix = (luaObj.RawGet("remove_CompleteTreasureMapMissionEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060049BF RID: 18879 RVA: 0x00170AE4 File Offset: 0x0016ECE4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureMapComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040037C3 RID: 14275
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x040037C4 RID: 14276
		protected DataSectionTreasureMap m_treasureMapDS = new DataSectionTreasureMap();

		// Token: 0x040037C5 RID: 14277
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040037C6 RID: 14278
		protected BattleComponentCommon m_battle;

		// Token: 0x040037C7 RID: 14279
		protected HeroComponentCommon m_hero;

		// Token: 0x040037C8 RID: 14280
		protected BagComponentCommon m_bag;

		// Token: 0x040037CA RID: 14282
		[DoNotToLua]
		private TreasureMapComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040037CB RID: 14283
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040037CC RID: 14284
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040037CD RID: 14285
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040037CE RID: 14286
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040037CF RID: 14287
		private LuaFunction m_Init_hotfix;

		// Token: 0x040037D0 RID: 14288
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040037D1 RID: 14289
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040037D2 RID: 14290
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040037D3 RID: 14291
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040037D4 RID: 14292
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040037D5 RID: 14293
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040037D6 RID: 14294
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040037D7 RID: 14295
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040037D8 RID: 14296
		private LuaFunction m_IsLevelFinishedInt32_hotfix;

		// Token: 0x040037D9 RID: 14297
		private LuaFunction m_AttackTreasureLevelInt32_hotfix;

		// Token: 0x040037DA RID: 14298
		private LuaFunction m_IsGameFunctionOpened_hotfix;

		// Token: 0x040037DB RID: 14299
		private LuaFunction m_CanAttackTreasureLevelInt32_hotfix;

		// Token: 0x040037DC RID: 14300
		private LuaFunction m_CanAttackLevelByEnergyAndSoOnConfigDataTreasureLevelInfo_hotfix;

		// Token: 0x040037DD RID: 14301
		private LuaFunction m_SetSuccessTreasureMapLevelConfigDataTreasureLevelInfoList;

		// Token: 0x040037DE RID: 14302
		private LuaFunction m_OnFinishedLevelInt32_hotfix;

		// Token: 0x040037DF RID: 14303
		private LuaFunction m_add_CompleteTreasureMapMissionEventAction;

		// Token: 0x040037E0 RID: 14304
		private LuaFunction m_remove_CompleteTreasureMapMissionEventAction;

		// Token: 0x020004B7 RID: 1207
		public class LuaExportHelper
		{
			// Token: 0x060049C0 RID: 18880 RVA: 0x00170B4C File Offset: 0x0016ED4C
			public LuaExportHelper(TreasureMapComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060049C1 RID: 18881 RVA: 0x00170B5C File Offset: 0x0016ED5C
			public void __callDele_CompleteTreasureMapMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__callDele_CompleteTreasureMapMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x060049C2 RID: 18882 RVA: 0x00170B6C File Offset: 0x0016ED6C
			public void __clearDele_CompleteTreasureMapMissionEvent(BattleType arg1, int arg2, List<int> arg3)
			{
				this.m_owner.__clearDele_CompleteTreasureMapMissionEvent(arg1, arg2, arg3);
			}

			// Token: 0x1700124C RID: 4684
			// (get) Token: 0x060049C3 RID: 18883 RVA: 0x00170B7C File Offset: 0x0016ED7C
			// (set) Token: 0x060049C4 RID: 18884 RVA: 0x00170B8C File Offset: 0x0016ED8C
			public IConfigDataLoader m_configDataLoader
			{
				get
				{
					return this.m_owner.m_configDataLoader;
				}
				set
				{
					this.m_owner.m_configDataLoader = value;
				}
			}

			// Token: 0x1700124D RID: 4685
			// (get) Token: 0x060049C5 RID: 18885 RVA: 0x00170B9C File Offset: 0x0016ED9C
			// (set) Token: 0x060049C6 RID: 18886 RVA: 0x00170BAC File Offset: 0x0016EDAC
			public DataSectionTreasureMap m_treasureMapDS
			{
				get
				{
					return this.m_owner.m_treasureMapDS;
				}
				set
				{
					this.m_owner.m_treasureMapDS = value;
				}
			}

			// Token: 0x1700124E RID: 4686
			// (get) Token: 0x060049C7 RID: 18887 RVA: 0x00170BBC File Offset: 0x0016EDBC
			// (set) Token: 0x060049C8 RID: 18888 RVA: 0x00170BCC File Offset: 0x0016EDCC
			public PlayerBasicInfoComponentCommon m_basicInfo
			{
				get
				{
					return this.m_owner.m_basicInfo;
				}
				set
				{
					this.m_owner.m_basicInfo = value;
				}
			}

			// Token: 0x1700124F RID: 4687
			// (get) Token: 0x060049C9 RID: 18889 RVA: 0x00170BDC File Offset: 0x0016EDDC
			// (set) Token: 0x060049CA RID: 18890 RVA: 0x00170BEC File Offset: 0x0016EDEC
			public BattleComponentCommon m_battle
			{
				get
				{
					return this.m_owner.m_battle;
				}
				set
				{
					this.m_owner.m_battle = value;
				}
			}

			// Token: 0x17001250 RID: 4688
			// (get) Token: 0x060049CB RID: 18891 RVA: 0x00170BFC File Offset: 0x0016EDFC
			// (set) Token: 0x060049CC RID: 18892 RVA: 0x00170C0C File Offset: 0x0016EE0C
			public HeroComponentCommon m_hero
			{
				get
				{
					return this.m_owner.m_hero;
				}
				set
				{
					this.m_owner.m_hero = value;
				}
			}

			// Token: 0x17001251 RID: 4689
			// (get) Token: 0x060049CD RID: 18893 RVA: 0x00170C1C File Offset: 0x0016EE1C
			// (set) Token: 0x060049CE RID: 18894 RVA: 0x00170C2C File Offset: 0x0016EE2C
			public BagComponentCommon m_bag
			{
				get
				{
					return this.m_owner.m_bag;
				}
				set
				{
					this.m_owner.m_bag = value;
				}
			}

			// Token: 0x060049CF RID: 18895 RVA: 0x00170C3C File Offset: 0x0016EE3C
			public bool IsGameFunctionOpened()
			{
				return this.m_owner.IsGameFunctionOpened();
			}

			// Token: 0x060049D0 RID: 18896 RVA: 0x00170C4C File Offset: 0x0016EE4C
			public int CanAttackLevelByEnergyAndSoOn(ConfigDataTreasureLevelInfo levelInfo)
			{
				return this.m_owner.CanAttackLevelByEnergyAndSoOn(levelInfo);
			}

			// Token: 0x060049D1 RID: 18897 RVA: 0x00170C5C File Offset: 0x0016EE5C
			public void SetSuccessTreasureMapLevel(ConfigDataTreasureLevelInfo levelInfo, List<int> battleTreasures)
			{
				this.m_owner.SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			}

			// Token: 0x060049D2 RID: 18898 RVA: 0x00170C6C File Offset: 0x0016EE6C
			public void OnFinishedLevel(int levelId)
			{
				this.m_owner.OnFinishedLevel(levelId);
			}

			// Token: 0x040037E1 RID: 14305
			private TreasureMapComponentCommon m_owner;
		}
	}
}
