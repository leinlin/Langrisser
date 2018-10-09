using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x0200048A RID: 1162
	[HotFix]
	public class NoviceComponentCommon : IComponentBase
	{
		// Token: 0x060045AC RID: 17836 RVA: 0x00153CDC File Offset: 0x00151EDC
		public NoviceComponentCommon()
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

		// Token: 0x060045AD RID: 17837 RVA: 0x00153D64 File Offset: 0x00151F64
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
			return "Novice";
		}

		// Token: 0x060045AE RID: 17838 RVA: 0x00153DD8 File Offset: 0x00151FD8
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

		// Token: 0x060045AF RID: 17839 RVA: 0x00153E38 File Offset: 0x00152038
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
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_mission = (this.Owner.GetOwnerComponent("Mission") as MissionComponentCommon);
		}

		// Token: 0x060045B0 RID: 17840 RVA: 0x00153F04 File Offset: 0x00152104
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

		// Token: 0x060045B1 RID: 17841 RVA: 0x00153F64 File Offset: 0x00152164
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

		// Token: 0x060045B2 RID: 17842 RVA: 0x00153FD4 File Offset: 0x001521D4
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

		// Token: 0x060045B3 RID: 17843 RVA: 0x00154054 File Offset: 0x00152254
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

		// Token: 0x060045B4 RID: 17844 RVA: 0x001540C4 File Offset: 0x001522C4
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

		// Token: 0x170011C3 RID: 4547
		// (get) Token: 0x060045B5 RID: 17845 RVA: 0x00154124 File Offset: 0x00152324
		// (set) Token: 0x060045B6 RID: 17846 RVA: 0x00154198 File Offset: 0x00152398
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

		// Token: 0x060045B7 RID: 17847 RVA: 0x00154210 File Offset: 0x00152410
		public int GetMissionPoints()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissionPoints_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMissionPoints_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_noviceDS.MissionPoints;
		}

		// Token: 0x060045B8 RID: 17848 RVA: 0x00154288 File Offset: 0x00152488
		public void AddMissionPoints(int Delta)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMissionPointsInt32_hotfix != null)
			{
				this.m_AddMissionPointsInt32_hotfix.call(new object[]
				{
					this,
					Delta
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_noviceDS.AddMissionPoints(Delta);
		}

		// Token: 0x060045B9 RID: 17849 RVA: 0x00154304 File Offset: 0x00152504
		public List<int> GetRewardClaimedSlots()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRewardClaimedSlots_hotfix != null)
			{
				return (List<int>)this.m_GetRewardClaimedSlots_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_noviceDS.RewardClaimedSlots;
		}

		// Token: 0x060045BA RID: 17850 RVA: 0x0015437C File Offset: 0x0015257C
		public bool IsRewardClaimed(int Slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRewardClaimedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRewardClaimedInt32_hotfix.call(new object[]
				{
					this,
					Slot
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_noviceDS.RewardClaimedSlots.Contains(Slot);
		}

		// Token: 0x060045BB RID: 17851 RVA: 0x0015440C File Offset: 0x0015260C
		public int CanClaimReward(int Slot)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanClaimRewardInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanClaimRewardInt32_hotfix.call(new object[]
				{
					this,
					Slot
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (Slot < 0 || Slot >= this.m_novicePointsRewards.Count)
			{
				return -4600;
			}
			if (this.IsRewardClaimed(Slot))
			{
				return -4601;
			}
			ConfigDataNoviceRewardInfo configDataNoviceRewardInfo = this.m_novicePointsRewards[Slot];
			if (configDataNoviceRewardInfo.NovicePoints > this.GetMissionPoints())
			{
				return -4602;
			}
			return 0;
		}

		// Token: 0x060045BC RID: 17852 RVA: 0x001544E0 File Offset: 0x001526E0
		public virtual int ClaimReward(int Slot, bool NoCheck = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClaimRewardInt32Boolean_hotfix != null)
			{
				return Convert.ToInt32(this.m_ClaimRewardInt32Boolean_hotfix.call(new object[]
				{
					this,
					Slot,
					NoCheck
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			if (!NoCheck)
			{
				num = this.CanClaimReward(Slot);
				if (num != 0)
				{
					return num;
				}
			}
			this.m_noviceDS.AddRewardClaimSlot(Slot);
			return num;
		}

		// Token: 0x060045BD RID: 17853 RVA: 0x00154594 File Offset: 0x00152794
		public List<ConfigDataNoviceRewardInfo> GetNovicePointsRewardsConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNovicePointsRewardsConfig_hotfix != null)
			{
				return (List<ConfigDataNoviceRewardInfo>)this.m_GetNovicePointsRewardsConfig_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_novicePointsRewards;
		}

		// Token: 0x060045BE RID: 17854 RVA: 0x00154608 File Offset: 0x00152808
		public int GetDaysAfterCreation()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDaysAfterCreation_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDaysAfterCreation_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (int)((this.m_basicInfo.GetCurrentTime() - this.m_basicInfo.GetCreateTime().Date).TotalDays + 1.0);
		}

		// Token: 0x060045BF RID: 17855 RVA: 0x001546AC File Offset: 0x001528AC
		public List<Mission> GetProcessingMissions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetProcessingMissions_hotfix != null)
			{
				return (List<Mission>)this.m_GetProcessingMissions_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mission.GetAllProcessingNoviceMissionList();
		}

		// Token: 0x060045C0 RID: 17856 RVA: 0x00154724 File Offset: 0x00152924
		public List<Mission> GetFinishedMissions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFinishedMissions_hotfix != null)
			{
				return (List<Mission>)this.m_GetFinishedMissions_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_mission.GetAllFinishedNoviceMissionList();
		}

		// Token: 0x060045C1 RID: 17857 RVA: 0x0015479C File Offset: 0x0015299C
		public int GetMissionDay(ConfigDataMissionInfo Mission)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissionDayConfigDataMissionInfo_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetMissionDayConfigDataMissionInfo_hotfix.call(new object[]
				{
					this,
					Mission
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return Mission.m_Novice.ActivateTime / 60 / 60 / 24 + 1;
		}

		// Token: 0x060045C2 RID: 17858 RVA: 0x00154830 File Offset: 0x00152A30
		public Dictionary<int, List<int>> GetMissions()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissions_hotfix != null)
			{
				return (Dictionary<int, List<int>>)this.m_GetMissions_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			Dictionary<int, List<int>> dictionary = new Dictionary<int, List<int>>();
			foreach (KeyValuePair<int, ConfigDataMissionInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataMissionInfo())
			{
				if (keyValuePair.Value.m_Novice != null)
				{
					int key = keyValuePair.Value.m_Novice.ActivateTime / 60 / 60 / 24 + 1;
					List<int> list = null;
					if (!dictionary.TryGetValue(key, out list))
					{
						list = new List<int>();
						dictionary.Add(key, list);
					}
					list.Add(keyValuePair.Key);
				}
			}
			return dictionary;
		}

		// Token: 0x060045C3 RID: 17859 RVA: 0x00154950 File Offset: 0x00152B50
		public TimeSpan GetMissionsEndTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMissionsEndTime_hotfix != null)
			{
				return (TimeSpan)this.m_GetMissionsEndTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime dateTime = this.m_basicInfo.GetCreateTime().Date + this.m_noviceMissionDuration;
			DateTime currentTime = this.m_basicInfo.GetCurrentTime();
			return (!(currentTime >= dateTime)) ? (dateTime - currentTime) : TimeSpan.Zero;
		}

		// Token: 0x170011C4 RID: 4548
		// (get) Token: 0x060045C4 RID: 17860 RVA: 0x00154A04 File Offset: 0x00152C04
		// (set) Token: 0x060045C5 RID: 17861 RVA: 0x00154A78 File Offset: 0x00152C78
		protected IConfigDataLoader m_configDataLoader
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_m_configDataLoader_hotfix != null)
				{
					return (IConfigDataLoader)this.m_get_m_configDataLoader_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this._configDataLoader;
			}
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_m_configDataLoaderIConfigDataLoader_hotfix != null)
				{
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				bool flag = this._configDataLoader == null;
				this._configDataLoader = value;
				if (flag)
				{
					this.m_novicePointsRewards.Clear();
					foreach (KeyValuePair<int, ConfigDataNoviceRewardInfo> keyValuePair in this._configDataLoader.GetAllConfigDataNoviceRewardInfo())
					{
						this.m_novicePointsRewards.InsertInOrder(keyValuePair.Value, (ConfigDataNoviceRewardInfo x, ConfigDataNoviceRewardInfo y) => x.NovicePoints - y.NovicePoints, true);
					}
					int num = 0;
					int num2 = int.MaxValue;
					foreach (KeyValuePair<int, ConfigDataMissionInfo> keyValuePair2 in this.m_configDataLoader.GetAllConfigDataMissionInfo())
					{
						if (keyValuePair2.Value.m_Novice != null)
						{
							num2 = Math.Min(keyValuePair2.Value.m_Novice.ActivateTime, num2);
							num = Math.Max(keyValuePair2.Value.m_Novice.DeactivateTime, num);
						}
					}
					this.m_noviceMissionDuration = new TimeSpan((long)(num - num2) * 10000000L);
				}
			}
		}

		// Token: 0x170011C5 RID: 4549
		// (get) Token: 0x060045C6 RID: 17862 RVA: 0x00154C3C File Offset: 0x00152E3C
		// (set) Token: 0x060045C7 RID: 17863 RVA: 0x00154C5C File Offset: 0x00152E5C
		[DoNotToLua]
		public NoviceComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new NoviceComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060045C9 RID: 17865 RVA: 0x00154C78 File Offset: 0x00152E78
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
					this.m_GetMissionPoints_hotfix = (luaObj.RawGet("GetMissionPoints") as LuaFunction);
					this.m_AddMissionPointsInt32_hotfix = (luaObj.RawGet("AddMissionPoints") as LuaFunction);
					this.m_GetRewardClaimedSlots_hotfix = (luaObj.RawGet("GetRewardClaimedSlots") as LuaFunction);
					this.m_IsRewardClaimedInt32_hotfix = (luaObj.RawGet("IsRewardClaimed") as LuaFunction);
					this.m_CanClaimRewardInt32_hotfix = (luaObj.RawGet("CanClaimReward") as LuaFunction);
					this.m_ClaimRewardInt32Boolean_hotfix = (luaObj.RawGet("ClaimReward") as LuaFunction);
					this.m_GetNovicePointsRewardsConfig_hotfix = (luaObj.RawGet("GetNovicePointsRewardsConfig") as LuaFunction);
					this.m_GetDaysAfterCreation_hotfix = (luaObj.RawGet("GetDaysAfterCreation") as LuaFunction);
					this.m_GetProcessingMissions_hotfix = (luaObj.RawGet("GetProcessingMissions") as LuaFunction);
					this.m_GetFinishedMissions_hotfix = (luaObj.RawGet("GetFinishedMissions") as LuaFunction);
					this.m_GetMissionDayConfigDataMissionInfo_hotfix = (luaObj.RawGet("GetMissionDay") as LuaFunction);
					this.m_GetMissions_hotfix = (luaObj.RawGet("GetMissions") as LuaFunction);
					this.m_GetMissionsEndTime_hotfix = (luaObj.RawGet("GetMissionsEndTime") as LuaFunction);
					this.m_get_m_configDataLoader_hotfix = (luaObj.RawGet("get_m_configDataLoader") as LuaFunction);
					this.m_set_m_configDataLoaderIConfigDataLoader_hotfix = (luaObj.RawGet("set_m_configDataLoader") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060045CA RID: 17866 RVA: 0x00154FB4 File Offset: 0x001531B4
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(NoviceComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x040034C2 RID: 13506
		private IConfigDataLoader _configDataLoader;

		// Token: 0x040034C3 RID: 13507
		protected List<ConfigDataNoviceRewardInfo> m_novicePointsRewards = new List<ConfigDataNoviceRewardInfo>();

		// Token: 0x040034C4 RID: 13508
		protected TimeSpan m_noviceMissionDuration = TimeSpan.Zero;

		// Token: 0x040034C5 RID: 13509
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x040034C6 RID: 13510
		protected HeroComponentCommon m_hero;

		// Token: 0x040034C7 RID: 13511
		protected BagComponentCommon m_bag;

		// Token: 0x040034C8 RID: 13512
		protected MissionComponentCommon m_mission;

		// Token: 0x040034C9 RID: 13513
		protected DataSectionNovice m_noviceDS = new DataSectionNovice();

		// Token: 0x040034CA RID: 13514
		[DoNotToLua]
		private NoviceComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x040034CC RID: 13516
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x040034CD RID: 13517
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x040034CE RID: 13518
		private LuaFunction m_ctor_hotfix;

		// Token: 0x040034CF RID: 13519
		private LuaFunction m_GetName_hotfix;

		// Token: 0x040034D0 RID: 13520
		private LuaFunction m_Init_hotfix;

		// Token: 0x040034D1 RID: 13521
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x040034D2 RID: 13522
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x040034D3 RID: 13523
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x040034D4 RID: 13524
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x040034D5 RID: 13525
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x040034D6 RID: 13526
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x040034D7 RID: 13527
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x040034D8 RID: 13528
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x040034D9 RID: 13529
		private LuaFunction m_GetMissionPoints_hotfix;

		// Token: 0x040034DA RID: 13530
		private LuaFunction m_AddMissionPointsInt32_hotfix;

		// Token: 0x040034DB RID: 13531
		private LuaFunction m_GetRewardClaimedSlots_hotfix;

		// Token: 0x040034DC RID: 13532
		private LuaFunction m_IsRewardClaimedInt32_hotfix;

		// Token: 0x040034DD RID: 13533
		private LuaFunction m_CanClaimRewardInt32_hotfix;

		// Token: 0x040034DE RID: 13534
		private LuaFunction m_ClaimRewardInt32Boolean_hotfix;

		// Token: 0x040034DF RID: 13535
		private LuaFunction m_GetNovicePointsRewardsConfig_hotfix;

		// Token: 0x040034E0 RID: 13536
		private LuaFunction m_GetDaysAfterCreation_hotfix;

		// Token: 0x040034E1 RID: 13537
		private LuaFunction m_GetProcessingMissions_hotfix;

		// Token: 0x040034E2 RID: 13538
		private LuaFunction m_GetFinishedMissions_hotfix;

		// Token: 0x040034E3 RID: 13539
		private LuaFunction m_GetMissionDayConfigDataMissionInfo_hotfix;

		// Token: 0x040034E4 RID: 13540
		private LuaFunction m_GetMissions_hotfix;

		// Token: 0x040034E5 RID: 13541
		private LuaFunction m_GetMissionsEndTime_hotfix;

		// Token: 0x040034E6 RID: 13542
		private LuaFunction m_get_m_configDataLoader_hotfix;

		// Token: 0x040034E7 RID: 13543
		private LuaFunction m_set_m_configDataLoaderIConfigDataLoader_hotfix;

		// Token: 0x0200048B RID: 1163
		public class LuaExportHelper
		{
			// Token: 0x060045CB RID: 17867 RVA: 0x0015501C File Offset: 0x0015321C
			public LuaExportHelper(NoviceComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x170011C6 RID: 4550
			// (get) Token: 0x060045CC RID: 17868 RVA: 0x0015502C File Offset: 0x0015322C
			// (set) Token: 0x060045CD RID: 17869 RVA: 0x0015503C File Offset: 0x0015323C
			public IConfigDataLoader _configDataLoader
			{
				get
				{
					return this.m_owner._configDataLoader;
				}
				set
				{
					this.m_owner._configDataLoader = value;
				}
			}

			// Token: 0x170011C7 RID: 4551
			// (get) Token: 0x060045CE RID: 17870 RVA: 0x0015504C File Offset: 0x0015324C
			// (set) Token: 0x060045CF RID: 17871 RVA: 0x0015505C File Offset: 0x0015325C
			public List<ConfigDataNoviceRewardInfo> m_novicePointsRewards
			{
				get
				{
					return this.m_owner.m_novicePointsRewards;
				}
				set
				{
					this.m_owner.m_novicePointsRewards = value;
				}
			}

			// Token: 0x170011C8 RID: 4552
			// (get) Token: 0x060045D0 RID: 17872 RVA: 0x0015506C File Offset: 0x0015326C
			// (set) Token: 0x060045D1 RID: 17873 RVA: 0x0015507C File Offset: 0x0015327C
			public TimeSpan m_noviceMissionDuration
			{
				get
				{
					return this.m_owner.m_noviceMissionDuration;
				}
				set
				{
					this.m_owner.m_noviceMissionDuration = value;
				}
			}

			// Token: 0x170011C9 RID: 4553
			// (get) Token: 0x060045D2 RID: 17874 RVA: 0x0015508C File Offset: 0x0015328C
			// (set) Token: 0x060045D3 RID: 17875 RVA: 0x0015509C File Offset: 0x0015329C
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

			// Token: 0x170011CA RID: 4554
			// (get) Token: 0x060045D4 RID: 17876 RVA: 0x001550AC File Offset: 0x001532AC
			// (set) Token: 0x060045D5 RID: 17877 RVA: 0x001550BC File Offset: 0x001532BC
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

			// Token: 0x170011CB RID: 4555
			// (get) Token: 0x060045D6 RID: 17878 RVA: 0x001550CC File Offset: 0x001532CC
			// (set) Token: 0x060045D7 RID: 17879 RVA: 0x001550DC File Offset: 0x001532DC
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

			// Token: 0x170011CC RID: 4556
			// (get) Token: 0x060045D8 RID: 17880 RVA: 0x001550EC File Offset: 0x001532EC
			// (set) Token: 0x060045D9 RID: 17881 RVA: 0x001550FC File Offset: 0x001532FC
			public MissionComponentCommon m_mission
			{
				get
				{
					return this.m_owner.m_mission;
				}
				set
				{
					this.m_owner.m_mission = value;
				}
			}

			// Token: 0x170011CD RID: 4557
			// (get) Token: 0x060045DA RID: 17882 RVA: 0x0015510C File Offset: 0x0015330C
			// (set) Token: 0x060045DB RID: 17883 RVA: 0x0015511C File Offset: 0x0015331C
			public DataSectionNovice m_noviceDS
			{
				get
				{
					return this.m_owner.m_noviceDS;
				}
				set
				{
					this.m_owner.m_noviceDS = value;
				}
			}

			// Token: 0x170011CE RID: 4558
			// (get) Token: 0x060045DC RID: 17884 RVA: 0x0015512C File Offset: 0x0015332C
			// (set) Token: 0x060045DD RID: 17885 RVA: 0x0015513C File Offset: 0x0015333C
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

			// Token: 0x040034E8 RID: 13544
			private NoviceComponentCommon m_owner;
		}
	}
}
