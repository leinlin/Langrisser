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
	// Token: 0x020008C1 RID: 2241
	[HotFix]
	public class HeroPhantomCompoment : HeroPhantomCompomentCommon
	{
		// Token: 0x06007239 RID: 29241 RVA: 0x001FA56C File Offset: 0x001F876C
		public HeroPhantomCompoment()
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

		// Token: 0x0600723A RID: 29242 RVA: 0x001FA5D4 File Offset: 0x001F87D4
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

		// Token: 0x0600723B RID: 29243 RVA: 0x001FA650 File Offset: 0x001F8850
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

		// Token: 0x0600723C RID: 29244 RVA: 0x001FA6B8 File Offset: 0x001F88B8
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

		// Token: 0x0600723D RID: 29245 RVA: 0x001FA720 File Offset: 0x001F8920
		public void DeSerialize(DSHeroPhantomNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSHeroPhantomNtf_hotfix != null)
			{
				this.m_DeSerializeDSHeroPhantomNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroPhantomDS.ClearInitedData();
			this.m_heroPhantomDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
			this.m_heroPhantomDS.PhantomCollections.ConfigDataLoader = base.m_configDataLoader;
			this.m_heroPhantomDS.UpdateInstantiatedData(ntf);
		}

		// Token: 0x0600723E RID: 29246 RVA: 0x001FA7D8 File Offset: 0x001F89D8
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
			return this.m_heroPhantomDS.ClientVersion;
		}

		// Token: 0x0600723F RID: 29247 RVA: 0x001FA850 File Offset: 0x001F8A50
		public void SetSuccessHeroPhantomLevel(HeroPhantomLevel Level, List<int> Heroes, List<int> BattleTreasures, List<int> newAchievementIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List`1_hotfix != null)
			{
				this.m_SetSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List`1_hotfix.call(new object[]
				{
					this,
					Level,
					Heroes,
					BattleTreasures,
					newAchievementIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.SetCommonSuccessHeroPhantomLevel(Level, Heroes, BattleTreasures, newAchievementIds);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = Level.UserExp;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(Level.HeroExp);
			battleReward.Gold = Level.GoldBonus;
		}

		// Token: 0x06007240 RID: 29248 RVA: 0x001FA93C File Offset: 0x001F8B3C
		public int FinishedHeroPhantomLevel(HeroPhantomLevel Level, bool IsWin, List<int> Heroes, List<int> BattleTreasures, List<int> achievementIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishedHeroPhantomLevelHeroPhantomLevelBooleanList`1List`1List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishedHeroPhantomLevelHeroPhantomLevelBooleanList`1List`1List`1_hotfix.call(new object[]
				{
					this,
					Level,
					IsWin,
					Heroes,
					BattleTreasures,
					achievementIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (base.m_configDataLoader.GetConfigDataHeroPhantomLevelInfo(Level.ID) == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -4402;
			}
			if (IsWin)
			{
				this.SetSuccessHeroPhantomLevel(Level, Heroes, BattleTreasures, achievementIds);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, IsWin, true);
			return 0;
		}

		// Token: 0x17001BD1 RID: 7121
		// (get) Token: 0x06007241 RID: 29249 RVA: 0x001FAA48 File Offset: 0x001F8C48
		// (set) Token: 0x06007242 RID: 29250 RVA: 0x001FAA68 File Offset: 0x001F8C68
		[DoNotToLua]
		public new HeroPhantomCompoment.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroPhantomCompoment.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007243 RID: 29251 RVA: 0x001FAA74 File Offset: 0x001F8C74
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007244 RID: 29252 RVA: 0x001FAA7C File Offset: 0x001F8C7C
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007245 RID: 29253 RVA: 0x001FAA84 File Offset: 0x001F8C84
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007246 RID: 29254 RVA: 0x001FAA8C File Offset: 0x001F8C8C
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007247 RID: 29255 RVA: 0x001FAA94 File Offset: 0x001F8C94
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007248 RID: 29256 RVA: 0x001FAAA0 File Offset: 0x001F8CA0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007249 RID: 29257 RVA: 0x001FAAA8 File Offset: 0x001F8CA8
		private bool __callBase_CheckHeroPhantomAvailable(int HeroPhantomId, ref int Err)
		{
			return base.CheckHeroPhantomAvailable(HeroPhantomId, ref Err);
		}

		// Token: 0x0600724A RID: 29258 RVA: 0x001FAAB4 File Offset: 0x001F8CB4
		private bool __callBase_CheckHeroPhantomLevelAvailable(int LevelId, ref int Err)
		{
			return base.CheckHeroPhantomLevelAvailable(LevelId, ref Err);
		}

		// Token: 0x0600724B RID: 29259 RVA: 0x001FAAC0 File Offset: 0x001F8CC0
		private bool __callBase_CheckPlayerOutOfBattle(ref int Err)
		{
			return base.CheckPlayerOutOfBattle(ref Err);
		}

		// Token: 0x0600724C RID: 29260 RVA: 0x001FAACC File Offset: 0x001F8CCC
		private bool __callBase_CheckEnergy(int LevelId, ref int Err)
		{
			return base.CheckEnergy(LevelId, ref Err);
		}

		// Token: 0x0600724D RID: 29261 RVA: 0x001FAAD8 File Offset: 0x001F8CD8
		private bool __callBase_CheckBag(int LevelId, ref int Err)
		{
			return base.CheckBag(LevelId, ref Err);
		}

		// Token: 0x0600724E RID: 29262 RVA: 0x001FAAE4 File Offset: 0x001F8CE4
		private int __callBase_CheckChallengeHeroPhantomLevel(int LevelId)
		{
			return base.CheckChallengeHeroPhantomLevel(LevelId);
		}

		// Token: 0x0600724F RID: 29263 RVA: 0x001FAAF0 File Offset: 0x001F8CF0
		private int __callBase_ChallengeHeroPhantomLevel(int LevelId, bool NoCheck)
		{
			return base.ChallengeHeroPhantomLevel(LevelId, NoCheck);
		}

		// Token: 0x06007250 RID: 29264 RVA: 0x001FAAFC File Offset: 0x001F8CFC
		private void __callBase_SetCommonSuccessHeroPhantomLevel(HeroPhantomLevel Level, List<int> Heroes, List<int> BattleTreasures, List<int> newAchievementIds)
		{
			base.SetCommonSuccessHeroPhantomLevel(Level, Heroes, BattleTreasures, newAchievementIds);
		}

		// Token: 0x06007251 RID: 29265 RVA: 0x001FAB0C File Offset: 0x001F8D0C
		private void __callBase_FinishedHeroPhantomLevel(HeroPhantomLevel Level, List<int> heroes)
		{
			base.FinishedHeroPhantomLevel(Level, heroes);
		}

		// Token: 0x06007252 RID: 29266 RVA: 0x001FAB18 File Offset: 0x001F8D18
		private HeroPhantom __callBase_GetHeroPhantom(int HeroPhantomId)
		{
			return base.GetHeroPhantom(HeroPhantomId);
		}

		// Token: 0x06007253 RID: 29267 RVA: 0x001FAB24 File Offset: 0x001F8D24
		private HeroPhantomLevel __callBase_GetHeroPhantomLevel(int LevelId)
		{
			return base.GetHeroPhantomLevel(LevelId);
		}

		// Token: 0x06007254 RID: 29268 RVA: 0x001FAB30 File Offset: 0x001F8D30
		private bool __callBase_IsCompleteHeroPhantomLevelAchievement(int achievementRelatedInfoID)
		{
			return base.IsCompleteHeroPhantomLevelAchievement(achievementRelatedInfoID);
		}

		// Token: 0x06007255 RID: 29269 RVA: 0x001FAB3C File Offset: 0x001F8D3C
		private List<int> __callBase_GetAllFinishedLevels()
		{
			return base.GetAllFinishedLevels();
		}

		// Token: 0x06007256 RID: 29270 RVA: 0x001FAB44 File Offset: 0x001F8D44
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
					this.m_DeSerializeDSHeroPhantomNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_SetSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List`1_hotfix = (luaObj.RawGet("SetSuccessHeroPhantomLevel") as LuaFunction);
					this.m_FinishedHeroPhantomLevelHeroPhantomLevelBooleanList`1List`1List`1_hotfix = (luaObj.RawGet("FinishedHeroPhantomLevel") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007257 RID: 29271 RVA: 0x001FACC0 File Offset: 0x001F8EC0
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroPhantomCompoment));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400552E RID: 21806
		[DoNotToLua]
		private HeroPhantomCompoment.LuaExportHelper luaExportHelper;

		// Token: 0x0400552F RID: 21807
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005530 RID: 21808
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005531 RID: 21809
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005532 RID: 21810
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005533 RID: 21811
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005534 RID: 21812
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005535 RID: 21813
		private LuaFunction m_DeSerializeDSHeroPhantomNtf_hotfix;

		// Token: 0x04005536 RID: 21814
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x04005537 RID: 21815
		private LuaFunction m_SetSuccessHeroPhantomLevelHeroPhantomLevelList`1List`1List;

		// Token: 0x04005538 RID: 21816
		private LuaFunction m_FinishedHeroPhantomLevelHeroPhantomLevelBooleanList`1List`1List;

		// Token: 0x020008C2 RID: 2242
		public new class LuaExportHelper
		{
			// Token: 0x06007258 RID: 29272 RVA: 0x001FAD28 File Offset: 0x001F8F28
			public LuaExportHelper(HeroPhantomCompoment owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007259 RID: 29273 RVA: 0x001FAD38 File Offset: 0x001F8F38
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600725A RID: 29274 RVA: 0x001FAD48 File Offset: 0x001F8F48
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600725B RID: 29275 RVA: 0x001FAD58 File Offset: 0x001F8F58
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600725C RID: 29276 RVA: 0x001FAD68 File Offset: 0x001F8F68
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600725D RID: 29277 RVA: 0x001FAD78 File Offset: 0x001F8F78
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600725E RID: 29278 RVA: 0x001FAD88 File Offset: 0x001F8F88
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600725F RID: 29279 RVA: 0x001FAD98 File Offset: 0x001F8F98
			public bool __callBase_CheckHeroPhantomAvailable(int HeroPhantomId, ref int Err)
			{
				return this.m_owner.__callBase_CheckHeroPhantomAvailable(HeroPhantomId, ref Err);
			}

			// Token: 0x06007260 RID: 29280 RVA: 0x001FADA8 File Offset: 0x001F8FA8
			public bool __callBase_CheckHeroPhantomLevelAvailable(int LevelId, ref int Err)
			{
				return this.m_owner.__callBase_CheckHeroPhantomLevelAvailable(LevelId, ref Err);
			}

			// Token: 0x06007261 RID: 29281 RVA: 0x001FADB8 File Offset: 0x001F8FB8
			public bool __callBase_CheckPlayerOutOfBattle(ref int Err)
			{
				return this.m_owner.__callBase_CheckPlayerOutOfBattle(ref Err);
			}

			// Token: 0x06007262 RID: 29282 RVA: 0x001FADC8 File Offset: 0x001F8FC8
			public bool __callBase_CheckEnergy(int LevelId, ref int Err)
			{
				return this.m_owner.__callBase_CheckEnergy(LevelId, ref Err);
			}

			// Token: 0x06007263 RID: 29283 RVA: 0x001FADD8 File Offset: 0x001F8FD8
			public bool __callBase_CheckBag(int LevelId, ref int Err)
			{
				return this.m_owner.__callBase_CheckBag(LevelId, ref Err);
			}

			// Token: 0x06007264 RID: 29284 RVA: 0x001FADE8 File Offset: 0x001F8FE8
			public int __callBase_CheckChallengeHeroPhantomLevel(int LevelId)
			{
				return this.m_owner.__callBase_CheckChallengeHeroPhantomLevel(LevelId);
			}

			// Token: 0x06007265 RID: 29285 RVA: 0x001FADF8 File Offset: 0x001F8FF8
			public int __callBase_ChallengeHeroPhantomLevel(int LevelId, bool NoCheck)
			{
				return this.m_owner.__callBase_ChallengeHeroPhantomLevel(LevelId, NoCheck);
			}

			// Token: 0x06007266 RID: 29286 RVA: 0x001FAE08 File Offset: 0x001F9008
			public void __callBase_SetCommonSuccessHeroPhantomLevel(HeroPhantomLevel Level, List<int> Heroes, List<int> BattleTreasures, List<int> newAchievementIds)
			{
				this.m_owner.__callBase_SetCommonSuccessHeroPhantomLevel(Level, Heroes, BattleTreasures, newAchievementIds);
			}

			// Token: 0x06007267 RID: 29287 RVA: 0x001FAE1C File Offset: 0x001F901C
			public void __callBase_FinishedHeroPhantomLevel(HeroPhantomLevel Level, List<int> heroes)
			{
				this.m_owner.__callBase_FinishedHeroPhantomLevel(Level, heroes);
			}

			// Token: 0x06007268 RID: 29288 RVA: 0x001FAE2C File Offset: 0x001F902C
			public HeroPhantom __callBase_GetHeroPhantom(int HeroPhantomId)
			{
				return this.m_owner.__callBase_GetHeroPhantom(HeroPhantomId);
			}

			// Token: 0x06007269 RID: 29289 RVA: 0x001FAE3C File Offset: 0x001F903C
			public HeroPhantomLevel __callBase_GetHeroPhantomLevel(int LevelId)
			{
				return this.m_owner.__callBase_GetHeroPhantomLevel(LevelId);
			}

			// Token: 0x0600726A RID: 29290 RVA: 0x001FAE4C File Offset: 0x001F904C
			public bool __callBase_IsCompleteHeroPhantomLevelAchievement(int achievementRelatedInfoID)
			{
				return this.m_owner.__callBase_IsCompleteHeroPhantomLevelAchievement(achievementRelatedInfoID);
			}

			// Token: 0x0600726B RID: 29291 RVA: 0x001FAE5C File Offset: 0x001F905C
			public List<int> __callBase_GetAllFinishedLevels()
			{
				return this.m_owner.__callBase_GetAllFinishedLevels();
			}

			// Token: 0x04005539 RID: 21817
			private HeroPhantomCompoment m_owner;
		}
	}
}
