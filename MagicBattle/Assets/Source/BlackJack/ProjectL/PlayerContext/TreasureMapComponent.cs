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
	// Token: 0x020008EE RID: 2286
	[HotFix]
	public class TreasureMapComponent : TreasureMapComponentCommon
	{
		// Token: 0x060077FC RID: 30716 RVA: 0x0020B0B0 File Offset: 0x002092B0
		public TreasureMapComponent()
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

		// Token: 0x060077FD RID: 30717 RVA: 0x0020B118 File Offset: 0x00209318
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

		// Token: 0x060077FE RID: 30718 RVA: 0x0020B194 File Offset: 0x00209394
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

		// Token: 0x060077FF RID: 30719 RVA: 0x0020B1FC File Offset: 0x002093FC
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

		// Token: 0x06007800 RID: 30720 RVA: 0x0020B264 File Offset: 0x00209464
		public void DeSerialize(DSTreasureMapNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSTreasureMapNtf_hotfix != null)
			{
				this.m_DeSerializeDSTreasureMapNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_treasureMapDS.ClearInitedData();
			this.m_treasureMapDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_treasureMapDS.InitFinishedLevels(msg.FinishedLeves);
		}

		// Token: 0x06007801 RID: 30721 RVA: 0x0020B30C File Offset: 0x0020950C
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
			return this.m_treasureMapDS.ClientVersion;
		}

		// Token: 0x06007802 RID: 30722 RVA: 0x0020B384 File Offset: 0x00209584
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
			int ticketId = this.m_bag.GetTicketId(GameFunctionType.GameFunctionType_TreasureMap);
			BagItemBase bagItemBase = this.m_bag.FindBagItemByType(GoodsType.GoodsType_Item, ticketId);
			return (bagItemBase != null) ? bagItemBase.Nums : 0;
		}

		// Token: 0x06007803 RID: 30723 RVA: 0x0020B420 File Offset: 0x00209620
		public int FinishedTreasureLevel(int levelId, bool isWin, List<int> battleTreasureIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedTreasureLevelInt32BooleanList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedTreasureLevelInt32BooleanList`1_hotfix.call(new object[]
				{
					this,
					levelId,
					isWin,
					battleTreasureIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataTreasureLevelInfo configDataTreasureLevelInfo = this.m_configDataLoader.GetConfigDataTreasureLevelInfo(levelId);
			if (configDataTreasureLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -2601;
			}
			if (isWin)
			{
				this.SetSuccessTreasureMapLevel(configDataTreasureLevelInfo, battleTreasureIds);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, isWin, true);
			return 0;
		}

		// Token: 0x06007804 RID: 30724 RVA: 0x0020B500 File Offset: 0x00209700
		protected override void SetSuccessTreasureMapLevel(ConfigDataTreasureLevelInfo levelInfo, List<int> battleTreasures)
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
			base.SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExp;
		}

		// Token: 0x17001BEA RID: 7146
		// (get) Token: 0x06007805 RID: 30725 RVA: 0x0020B5A8 File Offset: 0x002097A8
		// (set) Token: 0x06007806 RID: 30726 RVA: 0x0020B5C8 File Offset: 0x002097C8
		[DoNotToLua]
		public new TreasureMapComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TreasureMapComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007807 RID: 30727 RVA: 0x0020B5D4 File Offset: 0x002097D4
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007808 RID: 30728 RVA: 0x0020B5DC File Offset: 0x002097DC
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007809 RID: 30729 RVA: 0x0020B5E4 File Offset: 0x002097E4
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x0600780A RID: 30730 RVA: 0x0020B5EC File Offset: 0x002097EC
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x0600780B RID: 30731 RVA: 0x0020B5F4 File Offset: 0x002097F4
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x0600780C RID: 30732 RVA: 0x0020B600 File Offset: 0x00209800
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x0600780D RID: 30733 RVA: 0x0020B608 File Offset: 0x00209808
		private bool __callBase_IsLevelFinished(int levelId)
		{
			return base.IsLevelFinished(levelId);
		}

		// Token: 0x0600780E RID: 30734 RVA: 0x0020B614 File Offset: 0x00209814
		private int __callBase_AttackTreasureLevel(int levelId)
		{
			return base.AttackTreasureLevel(levelId);
		}

		// Token: 0x0600780F RID: 30735 RVA: 0x0020B620 File Offset: 0x00209820
		private int __callBase_CanAttackTreasureLevel(int leveId)
		{
			return base.CanAttackTreasureLevel(leveId);
		}

		// Token: 0x06007810 RID: 30736 RVA: 0x0020B62C File Offset: 0x0020982C
		private void __callBase_SetSuccessTreasureMapLevel(ConfigDataTreasureLevelInfo levelInfo, List<int> battleTreasures)
		{
			base.SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
		}

		// Token: 0x06007811 RID: 30737 RVA: 0x0020B638 File Offset: 0x00209838
		private void __callBase_OnFinishedLevel(int levelId)
		{
			base.OnFinishedLevel(levelId);
		}

		// Token: 0x06007812 RID: 30738 RVA: 0x0020B644 File Offset: 0x00209844
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
					this.m_DeSerializeDSTreasureMapNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_GetCurrentTicketNums_hotfix = (luaObj.RawGet("GetCurrentTicketNums") as LuaFunction);
					this.m_FinishedTreasureLevelInt32BooleanList`1_hotfix = (luaObj.RawGet("FinishedTreasureLevel") as LuaFunction);
					this.m_SetSuccessTreasureMapLevelConfigDataTreasureLevelInfoList`1_hotfix = (luaObj.RawGet("SetSuccessTreasureMapLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007813 RID: 30739 RVA: 0x0020B7D8 File Offset: 0x002099D8
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TreasureMapComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005678 RID: 22136
		[DoNotToLua]
		private TreasureMapComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005679 RID: 22137
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400567A RID: 22138
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400567B RID: 22139
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400567C RID: 22140
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400567D RID: 22141
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400567E RID: 22142
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400567F RID: 22143
		private LuaFunction m_DeSerializeDSTreasureMapNtf_hotfix;

		// Token: 0x04005680 RID: 22144
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005681 RID: 22145
		private LuaFunction m_GetCurrentTicketNums_hotfix;

		// Token: 0x04005682 RID: 22146
		private LuaFunction m_FinishedTreasureLevelInt32BooleanList;

		// Token: 0x04005683 RID: 22147
		private LuaFunction m_SetSuccessTreasureMapLevelConfigDataTreasureLevelInfoList;

		// Token: 0x020008EF RID: 2287
		public new class LuaExportHelper
		{
			// Token: 0x06007814 RID: 30740 RVA: 0x0020B840 File Offset: 0x00209A40
			public LuaExportHelper(TreasureMapComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007815 RID: 30741 RVA: 0x0020B850 File Offset: 0x00209A50
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06007816 RID: 30742 RVA: 0x0020B860 File Offset: 0x00209A60
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06007817 RID: 30743 RVA: 0x0020B870 File Offset: 0x00209A70
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06007818 RID: 30744 RVA: 0x0020B880 File Offset: 0x00209A80
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007819 RID: 30745 RVA: 0x0020B890 File Offset: 0x00209A90
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600781A RID: 30746 RVA: 0x0020B8A0 File Offset: 0x00209AA0
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600781B RID: 30747 RVA: 0x0020B8B0 File Offset: 0x00209AB0
			public bool __callBase_IsLevelFinished(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFinished(levelId);
			}

			// Token: 0x0600781C RID: 30748 RVA: 0x0020B8C0 File Offset: 0x00209AC0
			public int __callBase_AttackTreasureLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackTreasureLevel(levelId);
			}

			// Token: 0x0600781D RID: 30749 RVA: 0x0020B8D0 File Offset: 0x00209AD0
			public int __callBase_CanAttackTreasureLevel(int leveId)
			{
				return this.m_owner.__callBase_CanAttackTreasureLevel(leveId);
			}

			// Token: 0x0600781E RID: 30750 RVA: 0x0020B8E0 File Offset: 0x00209AE0
			public void __callBase_SetSuccessTreasureMapLevel(ConfigDataTreasureLevelInfo levelInfo, List<int> battleTreasures)
			{
				this.m_owner.__callBase_SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			}

			// Token: 0x0600781F RID: 30751 RVA: 0x0020B8F0 File Offset: 0x00209AF0
			public void __callBase_OnFinishedLevel(int levelId)
			{
				this.m_owner.__callBase_OnFinishedLevel(levelId);
			}

			// Token: 0x06007820 RID: 30752 RVA: 0x0020B900 File Offset: 0x00209B00
			public void SetSuccessTreasureMapLevel(ConfigDataTreasureLevelInfo levelInfo, List<int> battleTreasures)
			{
				this.m_owner.SetSuccessTreasureMapLevel(levelInfo, battleTreasures);
			}

			// Token: 0x04005684 RID: 22148
			private TreasureMapComponent m_owner;
		}
	}
}
