using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ProjectL.Common;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008B5 RID: 2229
	[HotFix]
	public class GlobalRankingListComponent : GlobalRankingListComponentCommon
	{
		// Token: 0x06007036 RID: 28726 RVA: 0x001F5AA8 File Offset: 0x001F3CA8
		public GlobalRankingListComponent()
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

		// Token: 0x06007037 RID: 28727 RVA: 0x001F5B24 File Offset: 0x001F3D24
		public void AddRankingListInfoToCache(RankingListType rankingType, RankingListInfo rankingListInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRankingListInfoToCacheRankingListTypeRankingListInfo_hotfix != null)
			{
				this.m_AddRankingListInfoToCacheRankingListTypeRankingListInfo_hotfix.call(new object[]
				{
					this,
					rankingType,
					rankingListInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cachedRankingListDict[rankingType] = new GlobalRankingListComponent.CachedRankingListInfo
			{
				m_outDateTime = Timer.m_currTime.AddSeconds(15.0),
				m_rankingListInfo = rankingListInfo
			};
			base.UpdateLastRankingListQueryTime(rankingType, Timer.m_currTime);
		}

		// Token: 0x06007038 RID: 28728 RVA: 0x001F5BE4 File Offset: 0x001F3DE4
		public RankingListInfo GetRankingListInfoByType(RankingListType rankingType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRankingListInfoByTypeRankingListType_hotfix != null)
			{
				return (RankingListInfo)this.m_GetRankingListInfoByTypeRankingListType_hotfix.call(new object[]
				{
					this,
					rankingType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GlobalRankingListComponent.CachedRankingListInfo cachedRankingListInfo;
			if (!this.m_cachedRankingListDict.TryGetValue(rankingType, out cachedRankingListInfo))
			{
				return null;
			}
			if (cachedRankingListInfo.m_outDateTime < Timer.m_currTime)
			{
				return null;
			}
			return cachedRankingListInfo.m_rankingListInfo;
		}

		// Token: 0x06007039 RID: 28729 RVA: 0x001F5C94 File Offset: 0x001F3E94
		public bool IsRankingListInfoValid(RankingListType rankingListType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRankingListInfoValidRankingListType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRankingListInfoValidRankingListType_hotfix.call(new object[]
				{
					this,
					rankingListType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetRankingListInfoByType(rankingListType) != null;
		}

		// Token: 0x0600703A RID: 28730 RVA: 0x001F5D24 File Offset: 0x001F3F24
		public void AddSingleHeroRankingListInfoToCache(int heroId, RankingListInfo rankingListInfo)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSingleHeroRankingListInfoToCacheInt32RankingListInfo_hotfix != null)
			{
				this.m_AddSingleHeroRankingListInfoToCacheInt32RankingListInfo_hotfix.call(new object[]
				{
					this,
					heroId,
					rankingListInfo
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_cachedSingleHeroRankListDict[heroId] = new GlobalRankingListComponent.CachedRankingListInfo
			{
				m_outDateTime = Timer.m_currTime.AddSeconds(15.0),
				m_rankingListInfo = rankingListInfo
			};
			base.UpdateLastRankingListQueryTime(RankingListType.SingleHero, Timer.m_currTime);
		}

		// Token: 0x0600703B RID: 28731 RVA: 0x001F5DE4 File Offset: 0x001F3FE4
		public RankingListInfo GetSingleHeroRankingListInfoByHeroId(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSingleHeroRankingListInfoByHeroIdInt32_hotfix != null)
			{
				return (RankingListInfo)this.m_GetSingleHeroRankingListInfoByHeroIdInt32_hotfix.call(new object[]
				{
					this,
					heroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			GlobalRankingListComponent.CachedRankingListInfo cachedRankingListInfo;
			if (!this.m_cachedSingleHeroRankListDict.TryGetValue(heroId, out cachedRankingListInfo))
			{
				return null;
			}
			if (cachedRankingListInfo.m_outDateTime < Timer.m_currTime)
			{
				return null;
			}
			return cachedRankingListInfo.m_rankingListInfo;
		}

		// Token: 0x0600703C RID: 28732 RVA: 0x001F5E94 File Offset: 0x001F4094
		public bool IsAbleQueryRankingListInfo(RankingListType rankingListType, out int errorCode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAbleQueryRankingListInfoRankingListTypeInt32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_PlayerContext_GlobalRankingListComponent_IsAbleQueryRankingListInfo_RankingListType_Int32(this, this.m_IsAbleQueryRankingListInfoRankingListTypeInt32__hotfix, rankingListType, out errorCode);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.CheckRankingListInfoQuery(rankingListType, out errorCode);
		}

		// Token: 0x0600703D RID: 28733 RVA: 0x001F5EF8 File Offset: 0x001F40F8
		public bool IsSingleHeroRankingListInfoValid(int heroId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSingleHeroRankingListInfoValidInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSingleHeroRankingListInfoValidInt32_hotfix.call(new object[]
				{
					this,
					heroId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetSingleHeroRankingListInfoByHeroId(heroId) != null;
		}

		// Token: 0x17001BC9 RID: 7113
		// (get) Token: 0x0600703E RID: 28734 RVA: 0x001F5F88 File Offset: 0x001F4188
		// (set) Token: 0x0600703F RID: 28735 RVA: 0x001F5FA8 File Offset: 0x001F41A8
		[DoNotToLua]
		public new GlobalRankingListComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GlobalRankingListComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007040 RID: 28736 RVA: 0x001F5FB4 File Offset: 0x001F41B4
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007041 RID: 28737 RVA: 0x001F5FBC File Offset: 0x001F41BC
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007042 RID: 28738 RVA: 0x001F5FC4 File Offset: 0x001F41C4
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007043 RID: 28739 RVA: 0x001F5FCC File Offset: 0x001F41CC
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007044 RID: 28740 RVA: 0x001F5FD4 File Offset: 0x001F41D4
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007045 RID: 28741 RVA: 0x001F5FE0 File Offset: 0x001F41E0
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007046 RID: 28742 RVA: 0x001F5FE8 File Offset: 0x001F41E8
		private bool __callBase_CheckRankingListInfoQuery(RankingListType rankingListType, out int errCode)
		{
			return base.CheckRankingListInfoQuery(rankingListType, out errCode);
		}

		// Token: 0x06007047 RID: 28743 RVA: 0x001F5FF4 File Offset: 0x001F41F4
		private void __callBase_UpdateLastRankingListQueryTime(RankingListType rankingListType, DateTime currTime)
		{
			base.UpdateLastRankingListQueryTime(rankingListType, currTime);
		}

		// Token: 0x06007048 RID: 28744 RVA: 0x001F6000 File Offset: 0x001F4200
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
					this.m_AddRankingListInfoToCacheRankingListTypeRankingListInfo_hotfix = (luaObj.RawGet("AddRankingListInfoToCache") as LuaFunction);
					this.m_GetRankingListInfoByTypeRankingListType_hotfix = (luaObj.RawGet("GetRankingListInfoByType") as LuaFunction);
					this.m_IsRankingListInfoValidRankingListType_hotfix = (luaObj.RawGet("IsRankingListInfoValid") as LuaFunction);
					this.m_AddSingleHeroRankingListInfoToCacheInt32RankingListInfo_hotfix = (luaObj.RawGet("AddSingleHeroRankingListInfoToCache") as LuaFunction);
					this.m_GetSingleHeroRankingListInfoByHeroIdInt32_hotfix = (luaObj.RawGet("GetSingleHeroRankingListInfoByHeroId") as LuaFunction);
					this.m_IsAbleQueryRankingListInfoRankingListTypeInt32__hotfix = (luaObj.RawGet("IsAbleQueryRankingListInfo") as LuaFunction);
					this.m_IsSingleHeroRankingListInfoValidInt32_hotfix = (luaObj.RawGet("IsSingleHeroRankingListInfoValid") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007049 RID: 28745 RVA: 0x001F617C File Offset: 0x001F437C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GlobalRankingListComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040054D8 RID: 21720
		protected Dictionary<RankingListType, GlobalRankingListComponent.CachedRankingListInfo> m_cachedRankingListDict = new Dictionary<RankingListType, GlobalRankingListComponent.CachedRankingListInfo>();

		// Token: 0x040054D9 RID: 21721
		protected Dictionary<int, GlobalRankingListComponent.CachedRankingListInfo> m_cachedSingleHeroRankListDict = new Dictionary<int, GlobalRankingListComponent.CachedRankingListInfo>();

		// Token: 0x040054DA RID: 21722
		protected const float OutDateTime = 15f;

		// Token: 0x040054DB RID: 21723
		[DoNotToLua]
		private GlobalRankingListComponent.LuaExportHelper luaExportHelper;

		// Token: 0x040054DC RID: 21724
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040054DD RID: 21725
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040054DE RID: 21726
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040054DF RID: 21727
		private LuaFunction m_AddRankingListInfoToCacheRankingListTypeRankingListInfo_hotfix;

		// Token: 0x040054E0 RID: 21728
		private LuaFunction m_GetRankingListInfoByTypeRankingListType_hotfix;

		// Token: 0x040054E1 RID: 21729
		private LuaFunction m_IsRankingListInfoValidRankingListType_hotfix;

		// Token: 0x040054E2 RID: 21730
		private LuaFunction m_AddSingleHeroRankingListInfoToCacheInt32RankingListInfo_hotfix;

		// Token: 0x040054E3 RID: 21731
		private LuaFunction m_GetSingleHeroRankingListInfoByHeroIdInt32_hotfix;

		// Token: 0x040054E4 RID: 21732
		private LuaFunction m_IsAbleQueryRankingListInfoRankingListTypeInt32__hotfix;

		// Token: 0x040054E5 RID: 21733
		private LuaFunction m_IsSingleHeroRankingListInfoValidInt32_hotfix;

		// Token: 0x020008B6 RID: 2230
		[HotFix]
		public class CachedRankingListInfo
		{
			// Token: 0x040054E6 RID: 21734
			public DateTime m_outDateTime;

			// Token: 0x040054E7 RID: 21735
			public RankingListInfo m_rankingListInfo;
		}

		// Token: 0x020008B7 RID: 2231
		public new class LuaExportHelper
		{
			// Token: 0x0600704B RID: 28747 RVA: 0x001F61EC File Offset: 0x001F43EC
			public LuaExportHelper(GlobalRankingListComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x0600704C RID: 28748 RVA: 0x001F61FC File Offset: 0x001F43FC
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600704D RID: 28749 RVA: 0x001F620C File Offset: 0x001F440C
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600704E RID: 28750 RVA: 0x001F621C File Offset: 0x001F441C
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600704F RID: 28751 RVA: 0x001F622C File Offset: 0x001F442C
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06007050 RID: 28752 RVA: 0x001F623C File Offset: 0x001F443C
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06007051 RID: 28753 RVA: 0x001F624C File Offset: 0x001F444C
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06007052 RID: 28754 RVA: 0x001F625C File Offset: 0x001F445C
			public bool __callBase_CheckRankingListInfoQuery(RankingListType rankingListType, out int errCode)
			{
				return this.m_owner.__callBase_CheckRankingListInfoQuery(rankingListType, out errCode);
			}

			// Token: 0x06007053 RID: 28755 RVA: 0x001F626C File Offset: 0x001F446C
			public void __callBase_UpdateLastRankingListQueryTime(RankingListType rankingListType, DateTime currTime)
			{
				this.m_owner.__callBase_UpdateLastRankingListQueryTime(rankingListType, currTime);
			}

			// Token: 0x17001BCA RID: 7114
			// (get) Token: 0x06007054 RID: 28756 RVA: 0x001F627C File Offset: 0x001F447C
			// (set) Token: 0x06007055 RID: 28757 RVA: 0x001F628C File Offset: 0x001F448C
			public Dictionary<RankingListType, GlobalRankingListComponent.CachedRankingListInfo> m_cachedRankingListDict
			{
				get
				{
					return this.m_owner.m_cachedRankingListDict;
				}
				set
				{
					this.m_owner.m_cachedRankingListDict = value;
				}
			}

			// Token: 0x17001BCB RID: 7115
			// (get) Token: 0x06007056 RID: 28758 RVA: 0x001F629C File Offset: 0x001F449C
			// (set) Token: 0x06007057 RID: 28759 RVA: 0x001F62AC File Offset: 0x001F44AC
			public Dictionary<int, GlobalRankingListComponent.CachedRankingListInfo> m_cachedSingleHeroRankListDict
			{
				get
				{
					return this.m_owner.m_cachedSingleHeroRankListDict;
				}
				set
				{
					this.m_owner.m_cachedSingleHeroRankListDict = value;
				}
			}

			// Token: 0x17001BCC RID: 7116
			// (get) Token: 0x06007058 RID: 28760 RVA: 0x001F62BC File Offset: 0x001F44BC
			public static float OutDateTime
			{
				get
				{
					return 15f;
				}
			}

			// Token: 0x040054E8 RID: 21736
			private GlobalRankingListComponent m_owner;
		}
	}
}
