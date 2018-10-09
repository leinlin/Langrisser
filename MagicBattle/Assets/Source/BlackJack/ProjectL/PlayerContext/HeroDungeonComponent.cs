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
	// Token: 0x020008BF RID: 2239
	[HotFix]
	public class HeroDungeonComponent : HeroDungeonComponentCommon
	{
		// Token: 0x060071F1 RID: 29169 RVA: 0x001F979C File Offset: 0x001F799C
		public HeroDungeonComponent()
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

		// Token: 0x060071F2 RID: 29170 RVA: 0x001F9804 File Offset: 0x001F7A04
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

		// Token: 0x060071F3 RID: 29171 RVA: 0x001F9880 File Offset: 0x001F7A80
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

		// Token: 0x060071F4 RID: 29172 RVA: 0x001F98E8 File Offset: 0x001F7AE8
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

		// Token: 0x060071F5 RID: 29173 RVA: 0x001F9950 File Offset: 0x001F7B50
		public void DeSerialize(DSHeroDungeonNtf ntf)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSHeroDungeonNtf_hotfix != null)
			{
				this.m_DeSerializeDSHeroDungeonNtf_hotfix.call(new object[]
				{
					this,
					ntf
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_heroDungeonDS.ClearInitedData();
			this.m_heroDungeonDS.InitVersion((ushort)ntf.Version, (ushort)ntf.Version);
			this.m_heroDungeonDS.InitAchievementRelationIds(ntf.AchievementRelationIds);
			this.m_heroDungeonDS.InitDailyChallengeNums(ntf.DailyChallengeNums);
			this.InitChapters(ntf.Chapters);
		}

		// Token: 0x060071F6 RID: 29174 RVA: 0x001F9A14 File Offset: 0x001F7C14
		private void InitChapters(List<ProHeroDungeonChapter> pbChapters)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitChaptersList`1_hotfix != null)
			{
				this.m_InitChaptersList`1_hotfix.call(new object[]
				{
					this,
					pbChapters
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ProHeroDungeonChapter pbChapter in pbChapters)
			{
				this.InitChapter(pbChapter);
			}
		}

		// Token: 0x060071F7 RID: 29175 RVA: 0x001F9AD0 File Offset: 0x001F7CD0
		private void InitChapter(ProHeroDungeonChapter pbChapter)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitChapterProHeroDungeonChapter_hotfix != null)
			{
				this.m_InitChapterProHeroDungeonChapter_hotfix.call(new object[]
				{
					this,
					pbChapter
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ProHeroDungeonLevel proHeroDungeonLevel in pbChapter.ChapterLevels)
			{
				ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(proHeroDungeonLevel.LevelId);
				if (configDataHeroDungeonLevelInfo != null && configDataHeroDungeonLevelInfo.m_chapterId != 0)
				{
					base.InitLevel(configDataHeroDungeonLevelInfo.m_chapterId, proHeroDungeonLevel.LevelId, proHeroDungeonLevel.Stars, proHeroDungeonLevel.Nums);
				}
			}
			this.m_heroDungeonDS.InitChapteStarRewardIndexes(pbChapter.ChapterId, pbChapter.StarRewardIndexes);
		}

		// Token: 0x060071F8 RID: 29176 RVA: 0x001F9BE0 File Offset: 0x001F7DE0
		public int FinishBattleHeroDungeonLevel(int levelId, List<int> gotAchievementIds, int stars, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FinishBattleHeroDungeonLevelInt32List`1Int32List`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_FinishBattleHeroDungeonLevelInt32List`1Int32List`1_hotfix.call(new object[]
				{
					this,
					levelId,
					gotAchievementIds,
					stars,
					battleTreasures
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
			if (configDataHeroDungeonLevelInfo == null)
			{
				this.m_battle.FightFinished(GameFunctionStatus.Error, false, true);
				return -2900;
			}
			if (stars > 0)
			{
				this.SetSuccessHeroDungeonLevel(configDataHeroDungeonLevelInfo, gotAchievementIds, stars, battleTreasures);
			}
			this.m_battle.FightFinished(GameFunctionStatus.End, stars > 0, true);
			return 0;
		}

		// Token: 0x060071F9 RID: 29177 RVA: 0x001F9CD8 File Offset: 0x001F7ED8
		protected override void SetSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo, List<int> newGotAchievementRelationInds, int stars, List<int> battleTreasures)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List`1_hotfix != null)
			{
				this.m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List`1_hotfix.call(new object[]
				{
					this,
					levelInfo,
					newGotAchievementRelationInds,
					stars,
					battleTreasures
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = levelInfo.PlayerExpReward;
			battleReward.HeroExp = this.m_hero.GetAdditiveHeroAddExp(levelInfo.HeroExpReward);
			battleReward.Gold = levelInfo.GoldReward;
		}

		// Token: 0x060071FA RID: 29178 RVA: 0x001F9DC4 File Offset: 0x001F7FC4
		public int RaidHeroDungeonLevel(int leveld, int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_RaidHeroDungeonLevelInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_RaidHeroDungeonLevelInt32Int32_hotfix.call(new object[]
				{
					this,
					leveld,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(leveld);
			if (configDataHeroDungeonLevelInfo == null)
			{
				return -2900;
			}
			for (int i = 0; i < nums; i++)
			{
				base.SetRaidSuccessHeroDungeonLevel(configDataHeroDungeonLevelInfo);
			}
			BattleReward battleReward = (this.m_battle as BattleComponent).GetBattleReward();
			battleReward.PlayerExp = configDataHeroDungeonLevelInfo.PlayerExpReward * nums;
			battleReward.HeroExp = 0;
			battleReward.Gold = configDataHeroDungeonLevelInfo.GoldReward * nums;
			return 0;
		}

		// Token: 0x060071FB RID: 29179 RVA: 0x001F9EB8 File Offset: 0x001F80B8
		public bool IsLevelChallenged(int levelId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelChallengedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelChallengedInt32_hotfix.call(new object[]
				{
					this,
					levelId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataHeroDungeonLevelInfo configDataHeroDungeonLevelInfo = this.m_configDataLoader.GetConfigDataHeroDungeonLevelInfo(levelId);
			return configDataHeroDungeonLevelInfo != null && this.m_heroDungeonDS.FindLevel(configDataHeroDungeonLevelInfo.m_chapterId, levelId) != null;
		}

		// Token: 0x060071FC RID: 29180 RVA: 0x001F9F64 File Offset: 0x001F8164
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
			return this.m_heroDungeonDS.ClientVersion;
		}

		// Token: 0x17001BD0 RID: 7120
		// (get) Token: 0x060071FD RID: 29181 RVA: 0x001F9FDC File Offset: 0x001F81DC
		// (set) Token: 0x060071FE RID: 29182 RVA: 0x001F9FFC File Offset: 0x001F81FC
		[DoNotToLua]
		public new HeroDungeonComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new HeroDungeonComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060071FF RID: 29183 RVA: 0x001FA008 File Offset: 0x001F8208
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007200 RID: 29184 RVA: 0x001FA010 File Offset: 0x001F8210
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007201 RID: 29185 RVA: 0x001FA018 File Offset: 0x001F8218
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007202 RID: 29186 RVA: 0x001FA020 File Offset: 0x001F8220
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007203 RID: 29187 RVA: 0x001FA028 File Offset: 0x001F8228
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007204 RID: 29188 RVA: 0x001FA034 File Offset: 0x001F8234
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007205 RID: 29189 RVA: 0x001FA03C File Offset: 0x001F823C
		private bool __callBase_HasGotAchievementRelationId(int achievementRelationId)
		{
			return base.HasGotAchievementRelationId(achievementRelationId);
		}

		// Token: 0x06007206 RID: 29190 RVA: 0x001FA048 File Offset: 0x001F8248
		private bool __callBase_IsLevelFirstPass(int levelId)
		{
			return base.IsLevelFirstPass(levelId);
		}

		// Token: 0x06007207 RID: 29191 RVA: 0x001FA054 File Offset: 0x001F8254
		private bool __callBase_IsFinishedLevel(int levelId)
		{
			return base.IsFinishedLevel(levelId);
		}

		// Token: 0x06007208 RID: 29192 RVA: 0x001FA060 File Offset: 0x001F8260
		private int __callBase_GetLevelCanChallengeMaxNums(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			return base.GetLevelCanChallengeMaxNums(levelInfo);
		}

		// Token: 0x06007209 RID: 29193 RVA: 0x001FA06C File Offset: 0x001F826C
		private int __callBase_GetDailyChallengeMaxNums()
		{
			return base.GetDailyChallengeMaxNums();
		}

		// Token: 0x0600720A RID: 29194 RVA: 0x001FA074 File Offset: 0x001F8274
		private void __callBase_InitLevel(int chapterId, int levelId, int stars, int nums)
		{
			base.InitLevel(chapterId, levelId, stars, nums);
		}

		// Token: 0x0600720B RID: 29195 RVA: 0x001FA084 File Offset: 0x001F8284
		private void __callBase_SetLevel(int chapterId, int LevelId, int stars, int nums)
		{
			base.SetLevel(chapterId, LevelId, stars, nums);
		}

		// Token: 0x0600720C RID: 29196 RVA: 0x001FA094 File Offset: 0x001F8294
		private HeroDungeonLevel __callBase_FindLevel(int chapterId, int levelId)
		{
			return base.FindLevel(chapterId, levelId);
		}

		// Token: 0x0600720D RID: 29197 RVA: 0x001FA0A0 File Offset: 0x001F82A0
		private int __callBase_AttackHeroDungeonLevel(int levelId)
		{
			return base.AttackHeroDungeonLevel(levelId);
		}

		// Token: 0x0600720E RID: 29198 RVA: 0x001FA0AC File Offset: 0x001F82AC
		private void __callBase_SetSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo, List<int> newGotAchievementRelationInds, int stars, List<int> battleTreasures)
		{
			base.SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
		}

		// Token: 0x0600720F RID: 29199 RVA: 0x001FA0BC File Offset: 0x001F82BC
		private void __callBase_SetRaidSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
		{
			base.SetRaidSuccessHeroDungeonLevel(levelInfo);
		}

		// Token: 0x06007210 RID: 29200 RVA: 0x001FA0C8 File Offset: 0x001F82C8
		private int __callBase_CanAttackHeroDungeonLevel(int levelId)
		{
			return base.CanAttackHeroDungeonLevel(levelId);
		}

		// Token: 0x06007211 RID: 29201 RVA: 0x001FA0D4 File Offset: 0x001F82D4
		private int __callBase_CanRaidHeroDungeonLevel(int levelId)
		{
			return base.CanRaidHeroDungeonLevel(levelId);
		}

		// Token: 0x06007212 RID: 29202 RVA: 0x001FA0E0 File Offset: 0x001F82E0
		private int __callBase_CanUnlockHeroDungeonLevel(int levelId)
		{
			return base.CanUnlockHeroDungeonLevel(levelId);
		}

		// Token: 0x06007213 RID: 29203 RVA: 0x001FA0EC File Offset: 0x001F82EC
		private int __callBase_GetHeroDungeonChapterStar(int chapterId)
		{
			return base.GetHeroDungeonChapterStar(chapterId);
		}

		// Token: 0x06007214 RID: 29204 RVA: 0x001FA0F8 File Offset: 0x001F82F8
		private bool __callBase_HasGotChapterStarReward(int chapterId, int index)
		{
			return base.HasGotChapterStarReward(chapterId, index);
		}

		// Token: 0x06007215 RID: 29205 RVA: 0x001FA104 File Offset: 0x001F8304
		private int __callBase_CanGainHeroDungeonChapterStarRewards(int chapterId, int index)
		{
			return base.CanGainHeroDungeonChapterStarRewards(chapterId, index);
		}

		// Token: 0x06007216 RID: 29206 RVA: 0x001FA110 File Offset: 0x001F8310
		private List<Goods> __callBase_GetHeroDungeonChapterStarRewards(ConfigDataHeroInformationInfo chapterInfo, int index)
		{
			return base.GetHeroDungeonChapterStarRewards(chapterInfo, index);
		}

		// Token: 0x06007217 RID: 29207 RVA: 0x001FA11C File Offset: 0x001F831C
		private int __callBase_GainHeroDungeonChapterStarRewards(int chapterId, int index, bool check)
		{
			return base.GainHeroDungeonChapterStarRewards(chapterId, index, check);
		}

		// Token: 0x06007218 RID: 29208 RVA: 0x001FA128 File Offset: 0x001F8328
		private void __callBase_GenerateHeroDungeonChapterStarRewards(int chapterId, int index)
		{
			base.GenerateHeroDungeonChapterStarRewards(chapterId, index);
		}

		// Token: 0x06007219 RID: 29209 RVA: 0x001FA134 File Offset: 0x001F8334
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
					this.m_DeSerializeDSHeroDungeonNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_InitChaptersList`1_hotfix = (luaObj.RawGet("InitChapters") as LuaFunction);
					this.m_InitChapterProHeroDungeonChapter_hotfix = (luaObj.RawGet("InitChapter") as LuaFunction);
					this.m_FinishBattleHeroDungeonLevelInt32List`1Int32List`1_hotfix = (luaObj.RawGet("FinishBattleHeroDungeonLevel") as LuaFunction);
					this.m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List`1_hotfix = (luaObj.RawGet("SetSuccessHeroDungeonLevel") as LuaFunction);
					this.m_RaidHeroDungeonLevelInt32Int32_hotfix = (luaObj.RawGet("RaidHeroDungeonLevel") as LuaFunction);
					this.m_IsLevelChallengedInt32_hotfix = (luaObj.RawGet("IsLevelChallenged") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x0600721A RID: 29210 RVA: 0x001FA314 File Offset: 0x001F8514
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(HeroDungeonComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400551E RID: 21790
		[DoNotToLua]
		private HeroDungeonComponent.LuaExportHelper luaExportHelper;

		// Token: 0x0400551F RID: 21791
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005520 RID: 21792
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005521 RID: 21793
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005522 RID: 21794
		private LuaFunction m_Init_hotfix;

		// Token: 0x04005523 RID: 21795
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04005524 RID: 21796
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04005525 RID: 21797
		private LuaFunction m_DeSerializeDSHeroDungeonNtf_hotfix;

		// Token: 0x04005526 RID: 21798
		private LuaFunction m_InitChaptersList;

		// Token: 0x04005527 RID: 21799
		private LuaFunction m_InitChapterProHeroDungeonChapter_hotfix;

		// Token: 0x04005528 RID: 21800
		private LuaFunction m_FinishBattleHeroDungeonLevelInt32List`1Int32List;

		// Token: 0x04005529 RID: 21801
		private LuaFunction m_SetSuccessHeroDungeonLevelConfigDataHeroDungeonLevelInfoList`1Int32List;

		// Token: 0x0400552A RID: 21802
		private LuaFunction m_RaidHeroDungeonLevelInt32Int32_hotfix;

		// Token: 0x0400552B RID: 21803
		private LuaFunction m_IsLevelChallengedInt32_hotfix;

		// Token: 0x0400552C RID: 21804
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x020008C0 RID: 2240
		public new class LuaExportHelper
		{
			// Token: 0x0600721B RID: 29211 RVA: 0x001FA37C File Offset: 0x001F857C
			public LuaExportHelper(HeroDungeonComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600721C RID: 29212 RVA: 0x001FA38C File Offset: 0x001F858C
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600721D RID: 29213 RVA: 0x001FA39C File Offset: 0x001F859C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600721E RID: 29214 RVA: 0x001FA3AC File Offset: 0x001F85AC
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600721F RID: 29215 RVA: 0x001FA3BC File Offset: 0x001F85BC
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007220 RID: 29216 RVA: 0x001FA3CC File Offset: 0x001F85CC
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007221 RID: 29217 RVA: 0x001FA3DC File Offset: 0x001F85DC
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007222 RID: 29218 RVA: 0x001FA3EC File Offset: 0x001F85EC
			public bool __callBase_HasGotAchievementRelationId(int achievementRelationId)
			{
				return this.m_owner.__callBase_HasGotAchievementRelationId(achievementRelationId);
			}

			// Token: 0x06007223 RID: 29219 RVA: 0x001FA3FC File Offset: 0x001F85FC
			public bool __callBase_IsLevelFirstPass(int levelId)
			{
				return this.m_owner.__callBase_IsLevelFirstPass(levelId);
			}

			// Token: 0x06007224 RID: 29220 RVA: 0x001FA40C File Offset: 0x001F860C
			public bool __callBase_IsFinishedLevel(int levelId)
			{
				return this.m_owner.__callBase_IsFinishedLevel(levelId);
			}

			// Token: 0x06007225 RID: 29221 RVA: 0x001FA41C File Offset: 0x001F861C
			public int __callBase_GetLevelCanChallengeMaxNums(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				return this.m_owner.__callBase_GetLevelCanChallengeMaxNums(levelInfo);
			}

			// Token: 0x06007226 RID: 29222 RVA: 0x001FA42C File Offset: 0x001F862C
			public int __callBase_GetDailyChallengeMaxNums()
			{
				return this.m_owner.__callBase_GetDailyChallengeMaxNums();
			}

			// Token: 0x06007227 RID: 29223 RVA: 0x001FA43C File Offset: 0x001F863C
			public void __callBase_InitLevel(int chapterId, int levelId, int stars, int nums)
			{
				this.m_owner.__callBase_InitLevel(chapterId, levelId, stars, nums);
			}

			// Token: 0x06007228 RID: 29224 RVA: 0x001FA450 File Offset: 0x001F8650
			public void __callBase_SetLevel(int chapterId, int LevelId, int stars, int nums)
			{
				this.m_owner.__callBase_SetLevel(chapterId, LevelId, stars, nums);
			}

			// Token: 0x06007229 RID: 29225 RVA: 0x001FA464 File Offset: 0x001F8664
			public HeroDungeonLevel __callBase_FindLevel(int chapterId, int levelId)
			{
				return this.m_owner.__callBase_FindLevel(chapterId, levelId);
			}

			// Token: 0x0600722A RID: 29226 RVA: 0x001FA474 File Offset: 0x001F8674
			public int __callBase_AttackHeroDungeonLevel(int levelId)
			{
				return this.m_owner.__callBase_AttackHeroDungeonLevel(levelId);
			}

			// Token: 0x0600722B RID: 29227 RVA: 0x001FA484 File Offset: 0x001F8684
			public void __callBase_SetSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo, List<int> newGotAchievementRelationInds, int stars, List<int> battleTreasures)
			{
				this.m_owner.__callBase_SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			}

			// Token: 0x0600722C RID: 29228 RVA: 0x001FA498 File Offset: 0x001F8698
			public void __callBase_SetRaidSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo)
			{
				this.m_owner.__callBase_SetRaidSuccessHeroDungeonLevel(levelInfo);
			}

			// Token: 0x0600722D RID: 29229 RVA: 0x001FA4A8 File Offset: 0x001F86A8
			public int __callBase_CanAttackHeroDungeonLevel(int levelId)
			{
				return this.m_owner.__callBase_CanAttackHeroDungeonLevel(levelId);
			}

			// Token: 0x0600722E RID: 29230 RVA: 0x001FA4B8 File Offset: 0x001F86B8
			public int __callBase_CanRaidHeroDungeonLevel(int levelId)
			{
				return this.m_owner.__callBase_CanRaidHeroDungeonLevel(levelId);
			}

			// Token: 0x0600722F RID: 29231 RVA: 0x001FA4C8 File Offset: 0x001F86C8
			public int __callBase_CanUnlockHeroDungeonLevel(int levelId)
			{
				return this.m_owner.__callBase_CanUnlockHeroDungeonLevel(levelId);
			}

			// Token: 0x06007230 RID: 29232 RVA: 0x001FA4D8 File Offset: 0x001F86D8
			public int __callBase_GetHeroDungeonChapterStar(int chapterId)
			{
				return this.m_owner.__callBase_GetHeroDungeonChapterStar(chapterId);
			}

			// Token: 0x06007231 RID: 29233 RVA: 0x001FA4E8 File Offset: 0x001F86E8
			public bool __callBase_HasGotChapterStarReward(int chapterId, int index)
			{
				return this.m_owner.__callBase_HasGotChapterStarReward(chapterId, index);
			}

			// Token: 0x06007232 RID: 29234 RVA: 0x001FA4F8 File Offset: 0x001F86F8
			public int __callBase_CanGainHeroDungeonChapterStarRewards(int chapterId, int index)
			{
				return this.m_owner.__callBase_CanGainHeroDungeonChapterStarRewards(chapterId, index);
			}

			// Token: 0x06007233 RID: 29235 RVA: 0x001FA508 File Offset: 0x001F8708
			public List<Goods> __callBase_GetHeroDungeonChapterStarRewards(ConfigDataHeroInformationInfo chapterInfo, int index)
			{
				return this.m_owner.__callBase_GetHeroDungeonChapterStarRewards(chapterInfo, index);
			}

			// Token: 0x06007234 RID: 29236 RVA: 0x001FA518 File Offset: 0x001F8718
			public int __callBase_GainHeroDungeonChapterStarRewards(int chapterId, int index, bool check)
			{
				return this.m_owner.__callBase_GainHeroDungeonChapterStarRewards(chapterId, index, check);
			}

			// Token: 0x06007235 RID: 29237 RVA: 0x001FA528 File Offset: 0x001F8728
			public void __callBase_GenerateHeroDungeonChapterStarRewards(int chapterId, int index)
			{
				this.m_owner.__callBase_GenerateHeroDungeonChapterStarRewards(chapterId, index);
			}

			// Token: 0x06007236 RID: 29238 RVA: 0x001FA538 File Offset: 0x001F8738
			public void InitChapters(List<ProHeroDungeonChapter> pbChapters)
			{
				this.m_owner.InitChapters(pbChapters);
			}

			// Token: 0x06007237 RID: 29239 RVA: 0x001FA548 File Offset: 0x001F8748
			public void InitChapter(ProHeroDungeonChapter pbChapter)
			{
				this.m_owner.InitChapter(pbChapter);
			}

			// Token: 0x06007238 RID: 29240 RVA: 0x001FA558 File Offset: 0x001F8758
			public void SetSuccessHeroDungeonLevel(ConfigDataHeroDungeonLevelInfo levelInfo, List<int> newGotAchievementRelationInds, int stars, List<int> battleTreasures)
			{
				this.m_owner.SetSuccessHeroDungeonLevel(levelInfo, newGotAchievementRelationInds, stars, battleTreasures);
			}

			// Token: 0x0400552D RID: 21805
			private HeroDungeonComponent m_owner;
		}
	}
}
