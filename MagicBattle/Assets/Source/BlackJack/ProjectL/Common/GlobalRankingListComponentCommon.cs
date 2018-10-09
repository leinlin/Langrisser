using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200045C RID: 1116
	[HotFix]
	public class GlobalRankingListComponentCommon : IComponentBase
	{
		// Token: 0x060040F8 RID: 16632 RVA: 0x001302A8 File Offset: 0x0012E4A8
		public GlobalRankingListComponentCommon()
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

		// Token: 0x060040F9 RID: 16633 RVA: 0x0013031C File Offset: 0x0012E51C
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
			return "GlobalRankingListComponent";
		}

		// Token: 0x060040FA RID: 16634 RVA: 0x00130390 File Offset: 0x0012E590
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

		// Token: 0x060040FB RID: 16635 RVA: 0x001303F0 File Offset: 0x0012E5F0
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
		}

		// Token: 0x060040FC RID: 16636 RVA: 0x001304A4 File Offset: 0x0012E6A4
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

		// Token: 0x060040FD RID: 16637 RVA: 0x00130504 File Offset: 0x0012E704
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

		// Token: 0x060040FE RID: 16638 RVA: 0x00130574 File Offset: 0x0012E774
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

		// Token: 0x060040FF RID: 16639 RVA: 0x001305F4 File Offset: 0x0012E7F4
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

		// Token: 0x06004100 RID: 16640 RVA: 0x00130664 File Offset: 0x0012E864
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

		// Token: 0x17001139 RID: 4409
		// (get) Token: 0x06004101 RID: 16641 RVA: 0x001306C4 File Offset: 0x0012E8C4
		// (set) Token: 0x06004102 RID: 16642 RVA: 0x00130738 File Offset: 0x0012E938
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

		// Token: 0x06004103 RID: 16643 RVA: 0x001307B0 File Offset: 0x0012E9B0
		public bool CheckRankingListInfoQuery(RankingListType rankingListType, out int errCode)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckRankingListInfoQueryRankingListTypeInt32__hotfix != null)
			{
				return LuaDelegation.Lua_BlackJack_ProjectL_Common_GlobalRankingListComponentCommon_CheckRankingListInfoQuery_RankingListType_Int32(this, this.m_CheckRankingListInfoQueryRankingListTypeInt32__hotfix, rankingListType, out errCode);
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			errCode = 0;
			if (this.LastRankingListQueryTime[(int)rankingListType].AddMilliseconds(3000.0) >= this.m_basicInfo.GetCurrentTime())
			{
				errCode = -4102;
				return false;
			}
			if (!this.m_basicInfo.CheckRankingListAddPlayerLevel())
			{
				errCode = -4101;
				return false;
			}
			return true;
		}

		// Token: 0x06004104 RID: 16644 RVA: 0x00130864 File Offset: 0x0012EA64
		public void UpdateLastRankingListQueryTime(RankingListType rankingListType, DateTime currTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateLastRankingListQueryTimeRankingListTypeDateTime_hotfix != null)
			{
				this.m_UpdateLastRankingListQueryTimeRankingListTypeDateTime_hotfix.call(new object[]
				{
					this,
					rankingListType,
					currTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.LastRankingListQueryTime[(int)rankingListType] = currTime;
		}

		// Token: 0x1700113A RID: 4410
		// (get) Token: 0x06004105 RID: 16645 RVA: 0x001308F8 File Offset: 0x0012EAF8
		// (set) Token: 0x06004106 RID: 16646 RVA: 0x00130918 File Offset: 0x0012EB18
		[DoNotToLua]
		public GlobalRankingListComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new GlobalRankingListComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004107 RID: 16647 RVA: 0x00130924 File Offset: 0x0012EB24
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
					this.m_CheckRankingListInfoQueryRankingListTypeInt32__hotfix = (luaObj.RawGet("CheckRankingListInfoQuery") as LuaFunction);
					this.m_UpdateLastRankingListQueryTimeRankingListTypeDateTime_hotfix = (luaObj.RawGet("UpdateLastRankingListQueryTime") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004108 RID: 16648 RVA: 0x00130B1C File Offset: 0x0012ED1C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(GlobalRankingListComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003188 RID: 12680
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003189 RID: 12681
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x0400318A RID: 12682
		protected RiftComponentCommon m_rift;

		// Token: 0x0400318B RID: 12683
		protected HeroComponentCommon m_hero;

		// Token: 0x0400318C RID: 12684
		private DateTime[] LastRankingListQueryTime = new DateTime[6];

		// Token: 0x0400318D RID: 12685
		[DoNotToLua]
		private GlobalRankingListComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x0400318E RID: 12686
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400318F RID: 12687
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003190 RID: 12688
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003191 RID: 12689
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003192 RID: 12690
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003193 RID: 12691
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003194 RID: 12692
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003195 RID: 12693
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003196 RID: 12694
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x04003197 RID: 12695
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x04003198 RID: 12696
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x04003199 RID: 12697
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400319A RID: 12698
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400319B RID: 12699
		private LuaFunction m_CheckRankingListInfoQueryRankingListTypeInt32__hotfix;

		// Token: 0x0400319C RID: 12700
		private LuaFunction m_UpdateLastRankingListQueryTimeRankingListTypeDateTime_hotfix;

		// Token: 0x0200045D RID: 1117
		public class LuaExportHelper
		{
			// Token: 0x06004109 RID: 16649 RVA: 0x00130B84 File Offset: 0x0012ED84
			public LuaExportHelper(GlobalRankingListComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x1700113B RID: 4411
			// (get) Token: 0x0600410A RID: 16650 RVA: 0x00130B94 File Offset: 0x0012ED94
			// (set) Token: 0x0600410B RID: 16651 RVA: 0x00130BA4 File Offset: 0x0012EDA4
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

			// Token: 0x1700113C RID: 4412
			// (get) Token: 0x0600410C RID: 16652 RVA: 0x00130BB4 File Offset: 0x0012EDB4
			// (set) Token: 0x0600410D RID: 16653 RVA: 0x00130BC4 File Offset: 0x0012EDC4
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

			// Token: 0x1700113D RID: 4413
			// (get) Token: 0x0600410E RID: 16654 RVA: 0x00130BD4 File Offset: 0x0012EDD4
			// (set) Token: 0x0600410F RID: 16655 RVA: 0x00130BE4 File Offset: 0x0012EDE4
			public RiftComponentCommon m_rift
			{
				get
				{
					return this.m_owner.m_rift;
				}
				set
				{
					this.m_owner.m_rift = value;
				}
			}

			// Token: 0x1700113E RID: 4414
			// (get) Token: 0x06004110 RID: 16656 RVA: 0x00130BF4 File Offset: 0x0012EDF4
			// (set) Token: 0x06004111 RID: 16657 RVA: 0x00130C04 File Offset: 0x0012EE04
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

			// Token: 0x1700113F RID: 4415
			// (get) Token: 0x06004112 RID: 16658 RVA: 0x00130C14 File Offset: 0x0012EE14
			// (set) Token: 0x06004113 RID: 16659 RVA: 0x00130C24 File Offset: 0x0012EE24
			public DateTime[] LastRankingListQueryTime
			{
				get
				{
					return this.m_owner.LastRankingListQueryTime;
				}
				set
				{
					this.m_owner.LastRankingListQueryTime = value;
				}
			}

			// Token: 0x0400319D RID: 12701
			private GlobalRankingListComponentCommon m_owner;
		}
	}
}
