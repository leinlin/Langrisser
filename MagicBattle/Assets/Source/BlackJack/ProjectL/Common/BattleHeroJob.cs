using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000366 RID: 870
	[HotFix]
	public class BattleHeroJob
	{
		// Token: 0x060031AA RID: 12714 RVA: 0x000C33DC File Offset: 0x000C15DC
		public BattleHeroJob()
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

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x060031AC RID: 12716 RVA: 0x000C34C4 File Offset: 0x000C16C4
		// (set) Token: 0x060031AB RID: 12715 RVA: 0x000C3444 File Offset: 0x000C1644
		public int JobRelatedId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobRelatedId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_JobRelatedId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_jobRelatedId;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_JobRelatedIdInt32_hotfix != null)
				{
					this.m_set_JobRelatedIdInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.m_jobRelatedId = value;
				this.UpdateJobConnectionInfo();
			}
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x060031AD RID: 12717 RVA: 0x000C3538 File Offset: 0x000C1738
		// (set) Token: 0x060031AE RID: 12718 RVA: 0x000C35AC File Offset: 0x000C17AC
		public int JobLevel
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobLevel_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_JobLevel_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<JobLevel>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_JobLevelInt32_hotfix != null)
				{
					this.m_set_JobLevelInt32_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<JobLevel>k__BackingField = value;
			}
		}

		// Token: 0x060031AF RID: 12719 RVA: 0x000C3624 File Offset: 0x000C1824
		public static HeroJob BattleHeroJobToHeroJob(BattleHeroJob battleHeroJob)
		{
			return new HeroJob
			{
				JobRelatedId = battleHeroJob.JobRelatedId,
				JobLevel = battleHeroJob.JobLevel
			};
		}

		// Token: 0x060031B0 RID: 12720 RVA: 0x000C3650 File Offset: 0x000C1850
		public static BattleHeroJob HeroJobToBattleHeroJob(HeroJob heroJob)
		{
			return new BattleHeroJob
			{
				JobRelatedId = heroJob.JobRelatedId,
				JobLevel = heroJob.JobLevel
			};
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000C367C File Offset: 0x000C187C
		public static BattleHeroJob PBBattleHeroJobToBattleHeroJob(ProBattleHeroJob pbBattleHeroJob)
		{
			return new BattleHeroJob
			{
				JobRelatedId = pbBattleHeroJob.JobRelatedId,
				JobLevel = pbBattleHeroJob.JobLevel
			};
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000C36A8 File Offset: 0x000C18A8
		public static ProBattleHeroJob BattleHeroJobToPBBattleHeroJob(BattleHeroJob battleHeroJob)
		{
			return new ProBattleHeroJob
			{
				JobRelatedId = battleHeroJob.JobRelatedId,
				JobLevel = battleHeroJob.JobLevel
			};
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000C36D4 File Offset: 0x000C18D4
		private void UpdateJobConnectionInfo()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_UpdateJobConnectionInfo_hotfix != null)
			{
				this.m_UpdateJobConnectionInfo_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			this.JobConnectionInfo = configDataLoader.GetConfigDataJobConnectionInfo(this.JobRelatedId);
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x060031B5 RID: 12725 RVA: 0x000C37D0 File Offset: 0x000C19D0
		// (set) Token: 0x060031B4 RID: 12724 RVA: 0x000C3758 File Offset: 0x000C1958
		public ConfigDataJobConnectionInfo JobConnectionInfo
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_JobConnectionInfo_hotfix != null)
				{
					return (ConfigDataJobConnectionInfo)this.m_get_JobConnectionInfo_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<JobConnectionInfo>k__BackingField;
			}
			[CompilerGenerated]
			private set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix != null)
				{
					this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<JobConnectionInfo>k__BackingField = value;
			}
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x000C3844 File Offset: 0x000C1A44
		public bool IsLevelMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelMax_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsLevelMax(this.JobLevel);
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x000C38BC File Offset: 0x000C1ABC
		public bool IsLevelMax(int jobLevel)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelMaxInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsLevelMaxInt32_hotfix.call(new object[]
				{
					this,
					jobLevel
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.JobConnectionInfo.IsJobLevelMax(jobLevel);
		}

		// Token: 0x17000E33 RID: 3635
		// (get) Token: 0x060031B8 RID: 12728 RVA: 0x000C3944 File Offset: 0x000C1B44
		// (set) Token: 0x060031B9 RID: 12729 RVA: 0x000C3964 File Offset: 0x000C1B64
		[DoNotToLua]
		public BattleHeroJob.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleHeroJob.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x000C3970 File Offset: 0x000C1B70
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
					this.m_set_JobRelatedIdInt32_hotfix = (luaObj.RawGet("set_JobRelatedId") as LuaFunction);
					this.m_get_JobRelatedId_hotfix = (luaObj.RawGet("get_JobRelatedId") as LuaFunction);
					this.m_get_JobLevel_hotfix = (luaObj.RawGet("get_JobLevel") as LuaFunction);
					this.m_set_JobLevelInt32_hotfix = (luaObj.RawGet("set_JobLevel") as LuaFunction);
					this.m_UpdateJobConnectionInfo_hotfix = (luaObj.RawGet("UpdateJobConnectionInfo") as LuaFunction);
					this.m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix = (luaObj.RawGet("set_JobConnectionInfo") as LuaFunction);
					this.m_get_JobConnectionInfo_hotfix = (luaObj.RawGet("get_JobConnectionInfo") as LuaFunction);
					this.m_IsLevelMax_hotfix = (luaObj.RawGet("IsLevelMax") as LuaFunction);
					this.m_IsLevelMaxInt32_hotfix = (luaObj.RawGet("IsLevelMax") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x000C3B1C File Offset: 0x000C1D1C
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleHeroJob));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400263E RID: 9790
		private int m_jobRelatedId;

		// Token: 0x04002641 RID: 9793
		[DoNotToLua]
		private BattleHeroJob.LuaExportHelper luaExportHelper;

		// Token: 0x04002642 RID: 9794
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04002643 RID: 9795
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04002644 RID: 9796
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04002645 RID: 9797
		private LuaFunction m_set_JobRelatedIdInt32_hotfix;

		// Token: 0x04002646 RID: 9798
		private LuaFunction m_get_JobRelatedId_hotfix;

		// Token: 0x04002647 RID: 9799
		private LuaFunction m_get_JobLevel_hotfix;

		// Token: 0x04002648 RID: 9800
		private LuaFunction m_set_JobLevelInt32_hotfix;

		// Token: 0x04002649 RID: 9801
		private LuaFunction m_UpdateJobConnectionInfo_hotfix;

		// Token: 0x0400264A RID: 9802
		private LuaFunction m_set_JobConnectionInfoConfigDataJobConnectionInfo_hotfix;

		// Token: 0x0400264B RID: 9803
		private LuaFunction m_get_JobConnectionInfo_hotfix;

		// Token: 0x0400264C RID: 9804
		private LuaFunction m_IsLevelMax_hotfix;

		// Token: 0x0400264D RID: 9805
		private LuaFunction m_IsLevelMaxInt32_hotfix;

		// Token: 0x02000367 RID: 871
		public class LuaExportHelper
		{
			// Token: 0x060031BC RID: 12732 RVA: 0x000C3B84 File Offset: 0x000C1D84
			public LuaExportHelper(BattleHeroJob owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x17000E34 RID: 3636
			// (get) Token: 0x060031BD RID: 12733 RVA: 0x000C3B94 File Offset: 0x000C1D94
			// (set) Token: 0x060031BE RID: 12734 RVA: 0x000C3BA4 File Offset: 0x000C1DA4
			public int m_jobRelatedId
			{
				get
				{
					return this.m_owner.m_jobRelatedId;
				}
				set
				{
					this.m_owner.m_jobRelatedId = value;
				}
			}

			// Token: 0x17000E35 RID: 3637
			// (set) Token: 0x060031BF RID: 12735 RVA: 0x000C3BB4 File Offset: 0x000C1DB4
			public ConfigDataJobConnectionInfo JobConnectionInfo
			{
				set
				{
					this.m_owner.JobConnectionInfo = value;
				}
			}

			// Token: 0x060031C0 RID: 12736 RVA: 0x000C3BC4 File Offset: 0x000C1DC4
			public void UpdateJobConnectionInfo()
			{
				this.m_owner.UpdateJobConnectionInfo();
			}

			// Token: 0x0400264E RID: 9806
			private BattleHeroJob m_owner;
		}
	}
}
