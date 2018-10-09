using System;
using BlackJack.BJFramework.Runtime.Lua;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000445 RID: 1093
	[HotFix]
	public class ComponentConstDefine
	{
		// Token: 0x06003FED RID: 16365 RVA: 0x00128674 File Offset: 0x00126874
		public ComponentConstDefine()
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

		// Token: 0x17001115 RID: 4373
		// (get) Token: 0x06003FEE RID: 16366 RVA: 0x001286DC File Offset: 0x001268DC
		// (set) Token: 0x06003FEF RID: 16367 RVA: 0x001286FC File Offset: 0x001268FC
		[DoNotToLua]
		public ComponentConstDefine.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new ComponentConstDefine.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06003FF0 RID: 16368 RVA: 0x00128708 File Offset: 0x00126908
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
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06003FF1 RID: 16369 RVA: 0x001287D4 File Offset: 0x001269D4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(ComponentConstDefine));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003029 RID: 12329
		public const string PlayerBasicInfoComponentName = "PlayerBasicInfo";

		// Token: 0x0400302A RID: 12330
		public const string BagComponentName = "Bag";

		// Token: 0x0400302B RID: 12331
		public const string HeroComponentName = "Hero";

		// Token: 0x0400302C RID: 12332
		public const string BattleComponentName = "Battle";

		// Token: 0x0400302D RID: 12333
		public const string LevelComponentName = "Level";

		// Token: 0x0400302E RID: 12334
		public const string RiftComponentName = "Rift";

		// Token: 0x0400302F RID: 12335
		public const string MailComponentName = "Mail";

		// Token: 0x04003030 RID: 12336
		public const string RandomStoreComponentName = "RandomStore";

		// Token: 0x04003031 RID: 12337
		public const string FixedStoreComponentName = "FixedStore";

		// Token: 0x04003032 RID: 12338
		public const string ChatComponentName = "Chat";

		// Token: 0x04003033 RID: 12339
		public const string ChatGroupComponentName = "ChatGroup";

		// Token: 0x04003034 RID: 12340
		public const string SelectCardComponentName = "SelectCard";

		// Token: 0x04003035 RID: 12341
		public const string RaffleComponentName = "Raffle";

		// Token: 0x04003036 RID: 12342
		public const string SurveyComponentName = "Survey";

		// Token: 0x04003037 RID: 12343
		public const string MissionComponentName = "Mission";

		// Token: 0x04003038 RID: 12344
		public const string CommentComponentName = "Comment";

		// Token: 0x04003039 RID: 12345
		public const string StatisticalDataComponentName = "StatisticalData";

		// Token: 0x0400303A RID: 12346
		public const string ThearchyTrailComponentName = "ThearchyTrail";

		// Token: 0x0400303B RID: 12347
		public const string AnikiGymComponentName = "AnikiGym";

		// Token: 0x0400303C RID: 12348
		public const string HeroDungeonComponentName = "HeroDungeon";

		// Token: 0x0400303D RID: 12349
		public const string HeroTrainningComponentName = "HeroTrainning";

		// Token: 0x0400303E RID: 12350
		public const string TreasureMapComponentName = "TreasureMap";

		// Token: 0x0400303F RID: 12351
		public const string TrainingGroundComponentName = "TrainingGround";

		// Token: 0x04003040 RID: 12352
		public const string HeroAssistantsComponentName = "HeroAssistants";

		// Token: 0x04003041 RID: 12353
		public const string MemoryCorridorComponentName = "MemoryCorridor";

		// Token: 0x04003042 RID: 12354
		public const string ArenaComponentName = "Arena";

		// Token: 0x04003043 RID: 12355
		public const string OperationalActivityComponentName = "OperationalActivity";

		// Token: 0x04003044 RID: 12356
		public const string DanmakuComponentName = "Danmaku";

		// Token: 0x04003045 RID: 12357
		public const string TeamComponentName = "Team";

		// Token: 0x04003046 RID: 12358
		public const string GlobalRankingListComponentName = "GlobalRankingListComponent";

		// Token: 0x04003047 RID: 12359
		public const string FriendComponentName = "Friend";

		// Token: 0x04003048 RID: 12360
		public const string HeroPhantomComponentName = "HeroPhantom";

		// Token: 0x04003049 RID: 12361
		public const string CooperateBattleComponentName = "CooperateBattle";

		// Token: 0x0400304A RID: 12362
		public const string NoviceComponentName = "Novice";

		// Token: 0x0400304B RID: 12363
		public const string RechargeStoreComponentName = "RechargeStore";

		// Token: 0x0400304C RID: 12364
		public const string GiftStoreComponentName = "GiftStore";

		// Token: 0x0400304D RID: 12365
		public const string ResourceComponentName = "Resource";

		// Token: 0x0400304E RID: 12366
		public const string RealTimePVPComponentName = "RealTimePVP";

		// Token: 0x0400304F RID: 12367
		public const string GuildComponentName = "Guild";

		// Token: 0x04003050 RID: 12368
		public const string UnchartedScoreComponentName = "UnchartedScore";

		// Token: 0x04003051 RID: 12369
		public const string ClimbTowerComponentName = "ClimbTower";

		// Token: 0x04003052 RID: 12370
		public const int PlayerStartLvl = 1;

		// Token: 0x04003053 RID: 12371
		public const int CustomMailTemplateId = 0;

		// Token: 0x04003054 RID: 12372
		public const int MailStatusUnread = 0;

		// Token: 0x04003055 RID: 12373
		public const int MailStatusReaded = 1;

		// Token: 0x04003056 RID: 12374
		public const int MailStatusGotAttachments = 2;

		// Token: 0x04003057 RID: 12375
		public const int SelectOneTimes = 1;

		// Token: 0x04003058 RID: 12376
		public const int SelectTenTimes = 10;

		// Token: 0x04003059 RID: 12377
		public const int InsignificanceParam = 0;

		// Token: 0x0400305A RID: 12378
		public const int AnyTypeParam = 0;

		// Token: 0x0400305B RID: 12379
		public const int RiftLevelSimpleDifficulty = 1;

		// Token: 0x0400305C RID: 12380
		public const int RiftLevelDiffcultDiffculty = 2;

		// Token: 0x0400305D RID: 12381
		public const int ArenaOpponentNumsPerZone = 1;

		// Token: 0x0400305E RID: 12382
		public const int ArenaOpponentNums = 3;

		// Token: 0x0400305F RID: 12383
		public const int CoachStartLvl = 1;

		// Token: 0x04003060 RID: 12384
		public const int InstrumentStartLvl = 1;

		// Token: 0x04003061 RID: 12385
		public const int CoachFavorabilityStartLvl = 1;

		// Token: 0x04003062 RID: 12386
		public const int HotCommentNumInAllComments = 3;

		// Token: 0x04003063 RID: 12387
		public const int ArenaRevengeOpponentPointZoneId = 2;

		// Token: 0x04003064 RID: 12388
		public const int ArenaThisWeekBattleIdNums = 3;

		// Token: 0x04003065 RID: 12389
		public const int ArenaMinArenaPoints = 100;

		// Token: 0x04003066 RID: 12390
		public const int MaxEnhanceMaterialNums = 5;

		// Token: 0x04003067 RID: 12391
		public const uint ChatVoiceTimeLengthMax = 20u;

		// Token: 0x04003068 RID: 12392
		public const uint ChatVoiceTimeLengthMin = 1u;

		// Token: 0x04003069 RID: 12393
		public const int ChatRecordFrequency = 16000;

		// Token: 0x0400306A RID: 12394
		public const int ChatEncodeAndDecodeSampleSize = 640;

		// Token: 0x0400306B RID: 12395
		public const int ChatTextLengthLimit = 50;

		// Token: 0x0400306C RID: 12396
		public const int ChatVoiceCacheCountMaxInWorldChannel = 10000;

		// Token: 0x0400306D RID: 12397
		public const int ChatVoiceTimeoutInWorldChannel = 7200000;

		// Token: 0x0400306E RID: 12398
		public const int ChatVoiceCacheCountMaxInGuildChannel = 10000;

		// Token: 0x0400306F RID: 12399
		public const int ChatVoiceTimeoutInGuildChannel = 7200000;

		// Token: 0x04003070 RID: 12400
		public const int ChatRoomCountMaxInWorldChannel = 999;

		// Token: 0x04003071 RID: 12401
		public const int RankingListForTopHeroNum = 5;

		// Token: 0x04003072 RID: 12402
		public const int RankingListQueryPeriod = 3000;

		// Token: 0x04003073 RID: 12403
		public const int ZilongCheckAdvencePeriodSeconds = 0;

		// Token: 0x04003074 RID: 12404
		public const int GuildSearchPeriod = 3000;

		// Token: 0x04003075 RID: 12405
		[DoNotToLua]
		private ComponentConstDefine.LuaExportHelper luaExportHelper;

		// Token: 0x04003076 RID: 12406
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003077 RID: 12407
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003078 RID: 12408
		private LuaFunction m_ctor_hotfix;

		// Token: 0x02000446 RID: 1094
		public class LuaExportHelper
		{
			// Token: 0x06003FF2 RID: 16370 RVA: 0x0012883C File Offset: 0x00126A3C
			public LuaExportHelper(ComponentConstDefine owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04003079 RID: 12409
			private ComponentConstDefine m_owner;
		}
	}
}
