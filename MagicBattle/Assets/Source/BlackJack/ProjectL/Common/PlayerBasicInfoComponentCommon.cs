using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.UtilityTools;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x02000495 RID: 1173
	[HotFix]
	public class PlayerBasicInfoComponentCommon : IComponentBase
	{
		// Token: 0x06004643 RID: 17987 RVA: 0x001578B4 File Offset: 0x00155AB4
		public PlayerBasicInfoComponentCommon()
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

		// Token: 0x06004644 RID: 17988 RVA: 0x00157928 File Offset: 0x00155B28
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
			return "PlayerBasicInfo";
		}

		// Token: 0x06004645 RID: 17989 RVA: 0x0015799C File Offset: 0x00155B9C
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
			this.m_changedGoods = new List<BagItemBase>();
		}

		// Token: 0x06004646 RID: 17990 RVA: 0x00157A08 File Offset: 0x00155C08
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
			this.m_bag = (this.Owner.GetOwnerComponent("Bag") as BagComponentCommon);
			this.m_mission = (this.Owner.GetOwnerComponent("Mission") as MissionComponentCommon);
			this.m_rift = (this.Owner.GetOwnerComponent("Rift") as RiftComponentCommon);
			this.m_thearchyTrial = (this.Owner.GetOwnerComponent("ThearchyTrail") as ThearchyTrialCompomentCommon);
			this.m_level = (this.Owner.GetOwnerComponent("Level") as LevelComponentCommon);
			this.m_hero = (this.Owner.GetOwnerComponent("Hero") as HeroComponentCommon);
			this.m_resource = (this.Owner.GetOwnerComponent("Resource") as ResourceComponentCommon);
			this.m_guild = (this.Owner.GetOwnerComponent("Guild") as GuildComponentCommon);
		}

		// Token: 0x06004647 RID: 17991 RVA: 0x00157B40 File Offset: 0x00155D40
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

		// Token: 0x06004648 RID: 17992 RVA: 0x00157BA0 File Offset: 0x00155DA0
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
			this.FlushEnergy();
			this.TryUpdateSignedDays();
		}

		// Token: 0x06004649 RID: 17993 RVA: 0x00157C1C File Offset: 0x00155E1C
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

		// Token: 0x0600464A RID: 17994 RVA: 0x00157C9C File Offset: 0x00155E9C
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

		// Token: 0x0600464B RID: 17995 RVA: 0x00157D0C File Offset: 0x00155F0C
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

		// Token: 0x170011E1 RID: 4577
		// (get) Token: 0x0600464C RID: 17996 RVA: 0x00157D6C File Offset: 0x00155F6C
		// (set) Token: 0x0600464D RID: 17997 RVA: 0x00157DE0 File Offset: 0x00155FE0
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

		// Token: 0x0600464E RID: 17998 RVA: 0x00157E58 File Offset: 0x00156058
		protected void TryUpdateSignedDays()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryUpdateSignedDays_hotfix != null)
			{
				this.m_TryUpdateSignedDays_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime currentTime = this.GetCurrentTime();
			int passMonths = TimeCaculate.GetPassMonths(this.m_playerBasicDS.LastSignTime, currentTime);
			if (passMonths > 0)
			{
				this.m_playerBasicDS.ResetSignDays();
			}
		}

		// Token: 0x0600464F RID: 17999 RVA: 0x00157EE4 File Offset: 0x001560E4
		private ConfigDataGameFunctionOpenInfo GetGameFunctionOpenInfo(GameFunctionType gameFunctionType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGameFunctionOpenInfoGameFunctionType_hotfix != null)
			{
				return (ConfigDataGameFunctionOpenInfo)this.m_GetGameFunctionOpenInfoGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFunctionType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (KeyValuePair<int, ConfigDataGameFunctionOpenInfo> keyValuePair in this.m_configDataLoader.GetAllConfigDataGameFunctionOpenInfo())
			{
				if (keyValuePair.Value.GameFunctionType == gameFunctionType)
				{
					return keyValuePair.Value;
				}
			}
			return null;
		}

		// Token: 0x06004650 RID: 18000 RVA: 0x00157FCC File Offset: 0x001561CC
		public bool IsGameFunctionOpened(GameFunctionType gameFunctionType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGameFunctionOpenedGameFunctionType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGameFunctionOpenedGameFunctionType_hotfix.call(new object[]
				{
					this,
					gameFunctionType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataGameFunctionOpenInfo gameFunctionOpenInfo = this.GetGameFunctionOpenInfo(gameFunctionType);
			if (gameFunctionOpenInfo == null || gameFunctionOpenInfo.OpenConditionParam1 == 0)
			{
				return true;
			}
			if (gameFunctionOpenInfo.OpenCondition == GameFunctionOpenConditionType.GameFunctionOpenConditionType_PlayerLevel)
			{
				return this.m_playerBasicDS.PlayerLevel >= gameFunctionOpenInfo.OpenConditionParam1;
			}
			if (gameFunctionOpenInfo.OpenCondition == GameFunctionOpenConditionType.GameFunctionOpenConditionType_Scenario)
			{
				return this.m_level.IsScenarioFinished(gameFunctionOpenInfo.OpenConditionParam1);
			}
			if (gameFunctionOpenInfo.OpenCondition == GameFunctionOpenConditionType.GameFunctionOpenConditionType_WaypointEvent)
			{
				return this.m_level.IsWayPointArrived(gameFunctionOpenInfo.OpenConditionParam1);
			}
			return gameFunctionOpenInfo.OpenCondition == GameFunctionOpenConditionType.GameFunctionOpenConditionType_RiftLevel && this.m_rift.IsLevelFinished(gameFunctionOpenInfo.OpenConditionParam1);
		}

		// Token: 0x06004651 RID: 18001 RVA: 0x001580E4 File Offset: 0x001562E4
		public DateTime GetCreateTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCreateTime_hotfix != null)
			{
				return (DateTime)this.m_GetCreateTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.CreateTime;
		}

		// Token: 0x06004652 RID: 18002 RVA: 0x0015815C File Offset: 0x0015635C
		public DateTime GetCreateTimeUtc()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCreateTimeUtc_hotfix != null)
			{
				return (DateTime)this.m_GetCreateTimeUtc_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.CreateTimeUtc;
		}

		// Token: 0x06004653 RID: 18003 RVA: 0x001581D4 File Offset: 0x001563D4
		public DateTime GetLastLogoutTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLastLogoutTime_hotfix != null)
			{
				return (DateTime)this.m_GetLastLogoutTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.LogoutTime;
		}

		// Token: 0x06004654 RID: 18004 RVA: 0x0015824C File Offset: 0x0015644C
		public DateTime GetLoginTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLoginTime_hotfix != null)
			{
				return (DateTime)this.m_GetLoginTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.LoginTime;
		}

		// Token: 0x06004655 RID: 18005 RVA: 0x001582C4 File Offset: 0x001564C4
		public string GetPlayerName()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerName_hotfix != null)
			{
				return (string)this.m_GetPlayerName_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.PlayerName;
		}

		// Token: 0x06004656 RID: 18006 RVA: 0x0015833C File Offset: 0x0015653C
		public string GetUserId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetUserId_hotfix != null)
			{
				return (string)this.m_GetUserId_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.UserId;
		}

		// Token: 0x06004657 RID: 18007 RVA: 0x001583B4 File Offset: 0x001565B4
		public bool IsMe(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMeString_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMeString_hotfix.call(new object[]
				{
					this,
					userId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return userId == this.m_playerBasicDS.UserId;
		}

		// Token: 0x06004658 RID: 18008 RVA: 0x00158444 File Offset: 0x00156644
		public int GetCurrentLevelExp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentLevelExp_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCurrentLevelExp_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Exp;
		}

		// Token: 0x06004659 RID: 18009 RVA: 0x001584BC File Offset: 0x001566BC
		public int GetRechargedCsystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRechargedCsystal_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRechargedCsystal_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.RechargeCrystal;
		}

		// Token: 0x0600465A RID: 18010 RVA: 0x00158534 File Offset: 0x00156734
		public long GetRechargeRMB()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRechargeRMB_hotfix != null)
			{
				return Convert.ToInt64(this.m_GetRechargeRMB_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.RechargeRMB;
		}

		// Token: 0x0600465B RID: 18011 RVA: 0x001585AC File Offset: 0x001567AC
		public int GetHeadIcon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeadIcon_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeadIcon_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.HeadIcon;
		}

		// Token: 0x0600465C RID: 18012 RVA: 0x00158624 File Offset: 0x00156824
		public int GetDefaultHeadIcon()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetDefaultHeadIcon_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetDefaultHeadIcon_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return HeadIconTools.GetHeadIcon(this.m_configDataLoader.ConfigableConstId_ProtagonistHeroID, this.m_configDataLoader.ConfigableConstId_DefaultHeadFrameId);
		}

		// Token: 0x0600465D RID: 18013 RVA: 0x001586AC File Offset: 0x001568AC
		public int GetHeadPortrait()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeadPortrait_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeadPortrait_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return HeadIconTools.GetHeadPortrait(this.m_playerBasicDS.HeadIcon);
		}

		// Token: 0x0600465E RID: 18014 RVA: 0x00158728 File Offset: 0x00156928
		public int GetHeadFrame()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeadFrame_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeadFrame_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return HeadIconTools.GetHeadFrame(this.m_playerBasicDS.HeadIcon);
		}

		// Token: 0x0600465F RID: 18015 RVA: 0x001587A4 File Offset: 0x001569A4
		public bool IsPlayerLevelMax()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsPlayerLevelMax_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsPlayerLevelMax_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_configDataLoader.ConfigableConstId_PlayerLevelMaxLevel == this.m_playerBasicDS.PlayerLevel;
		}

		// Token: 0x06004660 RID: 18016 RVA: 0x00158828 File Offset: 0x00156A28
		private bool CanAddPlayerExp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAddPlayerExp_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanAddPlayerExp_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsPlayerLevelMax())
			{
				return true;
			}
			int nextLevelExpFromConfig = this.GetNextLevelExpFromConfig();
			return this.m_playerBasicDS.Exp < nextLevelExpFromConfig;
		}

		// Token: 0x06004661 RID: 18017 RVA: 0x001588B8 File Offset: 0x00156AB8
		public int AddPlayerExp(int exp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddPlayerExpInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddPlayerExpInt32_hotfix.call(new object[]
				{
					this,
					exp
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.CanAddPlayerExp())
			{
				return -405;
			}
			int num = 0;
			int num2 = this.m_playerBasicDS.Exp + exp;
			do
			{
				int nextLevelExpFromConfig = this.GetNextLevelExpFromConfig();
				if (this.IsPlayerLevelMax())
				{
					if (num2 >= nextLevelExpFromConfig)
					{
						num2 = nextLevelExpFromConfig;
					}
					this.m_playerBasicDS.SetPlayerExp(num2);
					num2 = 0;
				}
				else
				{
					int num3;
					if (num2 >= nextLevelExpFromConfig)
					{
						this.LevelUp();
						num++;
						num3 = nextLevelExpFromConfig;
					}
					else
					{
						this.m_playerBasicDS.SetPlayerExp(num2);
						num3 = num2;
					}
					num2 -= num3;
				}
			}
			while (num2 > 0);
			this.OnLevelChange(num, exp);
			this.OnRankingListPlayerInfoChange();
			return 0;
		}

		// Token: 0x06004662 RID: 18018 RVA: 0x001589C4 File Offset: 0x00156BC4
		protected virtual void OnLevelChange(int upLevel, int addExp)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnLevelChangeInt32Int32_hotfix != null)
			{
				this.m_OnLevelChangeInt32Int32_hotfix.call(new object[]
				{
					this,
					upLevel,
					addExp
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (upLevel > 0 && this.LevelUpPlayerLevelMissionEvent != null)
			{
				this.LevelUpPlayerLevelMissionEvent(upLevel);
			}
		}

		// Token: 0x06004663 RID: 18019 RVA: 0x00158A64 File Offset: 0x00156C64
		private void LevelUp()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LevelUp_hotfix != null)
			{
				this.m_LevelUp_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.PlayerLevelUp();
			int levelUpAddEnergyFromConfig = this.GetLevelUpAddEnergyFromConfig();
			this.IncreamentEnergy((long)levelUpAddEnergyFromConfig, true, GameFunctionType.GameFunctionType_PlayerLevelUp, null);
			if (this.LevelUpPlayerLevelEvent != null)
			{
				this.LevelUpPlayerLevelEvent(this.m_playerBasicDS.PlayerLevel);
			}
		}

		// Token: 0x06004664 RID: 18020 RVA: 0x00158B04 File Offset: 0x00156D04
		public virtual int AddGold(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGoldInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddGoldInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (nums < 0 && this.ConsumeGoldMissionEvent != null && causeId != GameFunctionType.GameFunctionType_GM)
			{
				this.ConsumeGoldMissionEvent(-nums);
			}
			return this.m_playerBasicDS.AddGold(nums);
		}

		// Token: 0x06004665 RID: 18021 RVA: 0x00158BD4 File Offset: 0x00156DD4
		public bool IsGoldEnough(int useGoldCount)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGoldEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGoldEnoughInt32_hotfix.call(new object[]
				{
					this,
					useGoldCount
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Gold >= useGoldCount;
		}

		// Token: 0x06004666 RID: 18022 RVA: 0x00158C64 File Offset: 0x00156E64
		public bool IsGoldOverFlow(int addNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGoldOverFlowInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGoldOverFlowInt32_hotfix.call(new object[]
				{
					this,
					addNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerBasicDS.Gold + addNums;
			return num < 0;
		}

		// Token: 0x06004667 RID: 18023 RVA: 0x00158CF4 File Offset: 0x00156EF4
		public int GetGold()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGold_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetGold_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Gold;
		}

		// Token: 0x06004668 RID: 18024 RVA: 0x00158D6C File Offset: 0x00156F6C
		public int AddBrillianceMithralStone(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBrillianceMithralStoneInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddBrillianceMithralStoneInt32_hotfix.call(new object[]
				{
					this,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddBrillianceMithralStone(nums);
		}

		// Token: 0x06004669 RID: 18025 RVA: 0x00158DF4 File Offset: 0x00156FF4
		public int AddMithralStone(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMithralStoneInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddMithralStoneInt32_hotfix.call(new object[]
				{
					this,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddMithralStone(nums);
		}

		// Token: 0x0600466A RID: 18026 RVA: 0x00158E7C File Offset: 0x0015707C
		public bool IsMithralStoneEnough(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMithralStoneEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMithralStoneEnoughInt32_hotfix.call(new object[]
				{
					this,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.MithralStone >= nums;
		}

		// Token: 0x0600466B RID: 18027 RVA: 0x00158F0C File Offset: 0x0015710C
		public bool IsBrillianceMithralStoneEnough(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBrillianceMithralStoneEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBrillianceMithralStoneEnoughInt32_hotfix.call(new object[]
				{
					this,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.BrillianceMithralStone >= nums;
		}

		// Token: 0x0600466C RID: 18028 RVA: 0x00158F9C File Offset: 0x0015719C
		public int IsCurrencyEnough(GoodsType currencyType, int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCurrencyEnoughGoodsTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsCurrencyEnoughGoodsTypeInt32_hotfix.call(new object[]
				{
					this,
					currencyType,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<Goods> conditions = new List<Goods>
			{
				new Goods
				{
					GoodsType = currencyType,
					Id = 0,
					Count = consumeNums
				}
			};
			List<BagItemBase> list;
			return this.m_bag.IsGoodsEnough(conditions, out list);
		}

		// Token: 0x0600466D RID: 18029 RVA: 0x00159060 File Offset: 0x00157260
		public int AddCurrency(GoodsType currencyType, int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddCurrencyGoodsTypeInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddCurrencyGoodsTypeInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					currencyType,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			switch (currencyType)
			{
			case GoodsType.GoodsType_SkinTicket:
				result = this.AddSkinTickets(nums, causeId, location);
				break;
			case GoodsType.GoodsType_RealTimePVPHonor:
				result = this.AddRealTimePVPHonor(nums, causeId, location);
				break;
			case GoodsType.GoodsType_MemoryEssence:
				result = this.AddMemoryEssence(nums, causeId, location);
				break;
			case GoodsType.GoodsType_MithralStone:
				result = this.AddMithralStone(nums, causeId, location);
				break;
			case GoodsType.GoodsType_BrillianceMithralStone:
				result = this.AddBrillianceMithralStone(nums, causeId, location);
				break;
			case GoodsType.GoodsType_GuildMedal:
				result = this.AddGuildMedal(nums, causeId, location);
				break;
			default:
				if (currencyType != GoodsType.GoodsType_Gold)
				{
					if (currencyType != GoodsType.GoodsType_Crystal)
					{
						switch (currencyType)
						{
						case GoodsType.GoodsType_ArenaHonour:
							result = this.AddArenaHonour(nums, causeId, location);
							break;
						case GoodsType.GoodsType_FriendshipPoints:
							result = this.AddFriendshipPoints(nums, causeId, location);
							break;
						}
					}
					else
					{
						result = this.AddCrystal(nums, causeId, location);
					}
				}
				else
				{
					result = this.AddGold(nums, causeId, location);
				}
				break;
			}
			return result;
		}

		// Token: 0x0600466E RID: 18030 RVA: 0x001591FC File Offset: 0x001573FC
		public virtual long AddRechargeRMB(int nums, DateTime rechargeTime, bool needSync2Client = false)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRechargeRMBInt32DateTimeBoolean_hotfix != null)
			{
				return Convert.ToInt64(this.m_AddRechargeRMBInt32DateTimeBoolean_hotfix.call(new object[]
				{
					this,
					nums,
					rechargeTime,
					needSync2Client
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.AddRechargeRMBEvent != null)
			{
				this.AddRechargeRMBEvent(nums, rechargeTime);
			}
			return this.m_playerBasicDS.AddRechargeRMB(nums);
		}

		// Token: 0x0600466F RID: 18031 RVA: 0x001592BC File Offset: 0x001574BC
		public virtual int AddCrystal(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddCrystalInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddCrystalInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (nums < 0 && this.ConsumeCrystalMissionEvent != null && causeId != GameFunctionType.GameFunctionType_GM)
			{
				this.ConsumeCrystalMissionEvent(-nums);
			}
			return this.m_playerBasicDS.AddCrystal(nums);
		}

		// Token: 0x06004670 RID: 18032 RVA: 0x0015938C File Offset: 0x0015758C
		public bool IsCrystalEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsCrystalEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsCrystalEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Crystal >= consumeNums;
		}

		// Token: 0x06004671 RID: 18033 RVA: 0x0015941C File Offset: 0x0015761C
		protected void InitEnergy(long secondPast)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitEnergyInt64_hotfix != null)
			{
				this.m_InitEnergyInt64_hotfix.call(new object[]
				{
					this,
					secondPast
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			long downIntegerByPeriod = MathCaculate.GetDownIntegerByPeriod(secondPast, this.m_configDataLoader.ConfigableConstId_EnergyAddPeriod);
			if (!this.IsReachEnergyMax((long)this.m_playerBasicDS.Energy))
			{
				this.IncreamentEnergy(downIntegerByPeriod, false, GameFunctionType.GameFunctionType_SystemRecoveyEnergy, null);
			}
			DateTime energyFlushTime = this.m_playerBasicDS.EnergyFlushTime.AddSeconds((double)(downIntegerByPeriod * (long)this.m_configDataLoader.ConfigableConstId_EnergyAddPeriod));
			this.m_playerBasicDS.SetEnergyFlushTime(energyFlushTime);
		}

		// Token: 0x06004672 RID: 18034 RVA: 0x001594F0 File Offset: 0x001576F0
		public bool IsReachEnergyMax(long currentEnergy)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsReachEnergyMaxInt64_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsReachEnergyMaxInt64_hotfix.call(new object[]
				{
					this,
					currentEnergy
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return currentEnergy >= (long)this.m_configDataLoader.ConfigableConstId_EnergyMax;
		}

		// Token: 0x06004673 RID: 18035 RVA: 0x00159580 File Offset: 0x00157780
		public void FlushEnergy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushEnergy_hotfix != null)
			{
				this.m_FlushEnergy_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CanFlushEnergy())
			{
				long passSeconds = TimeCaculate.GetPassSeconds(this.m_playerBasicDS.EnergyFlushTime, this.GetCurrentTime());
				this.InitEnergy(passSeconds);
			}
		}

		// Token: 0x06004674 RID: 18036 RVA: 0x0015960C File Offset: 0x0015780C
		public bool CanFlushEnergy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanFlushEnergy_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanFlushEnergy_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return TimeCaculate.GetPassSeconds(this.m_playerBasicDS.EnergyFlushTime, this.GetCurrentTime()) >= (long)this.m_configDataLoader.ConfigableConstId_EnergyAddPeriod;
		}

		// Token: 0x06004675 RID: 18037 RVA: 0x001596A0 File Offset: 0x001578A0
		public bool CanFlushPlayerAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanFlushPlayerAction_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CanFlushPlayerAction_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.GetCurrentTime() >= this.m_playerBasicDS.NextFlushPlayerActionTime;
		}

		// Token: 0x06004676 RID: 18038 RVA: 0x00159724 File Offset: 0x00157924
		public void ResetPlayerActionNextFlushTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ResetPlayerActionNextFlushTime_hotfix != null)
			{
				this.m_ResetPlayerActionNextFlushTime_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			DateTime nextFlushTime = TimeCaculate.GetNextFlushTime(this.GetCurrentTime(), this.m_configDataLoader.ConfigableConstId_FlushTime, this.m_configDataLoader.ConfigableConstId_FlushPeriodDay);
			this.m_playerBasicDS.SetNextPlayerActionFlushTime(nextFlushTime);
		}

		// Token: 0x06004677 RID: 18039 RVA: 0x001597B4 File Offset: 0x001579B4
		public virtual int IncreamentEnergy(long energyAddNums, bool canAboveMaxEnergy, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					energyAddNums,
					canAboveMaxEnergy,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsReachEnergyMax((long)this.m_playerBasicDS.Energy))
			{
				if (!canAboveMaxEnergy)
				{
					return this.m_playerBasicDS.Energy;
				}
				long num = (long)this.m_playerBasicDS.Energy + energyAddNums;
				this.m_playerBasicDS.SetEnergy((int)num);
			}
			else
			{
				long num2 = (long)this.m_playerBasicDS.Energy + energyAddNums;
				if (!canAboveMaxEnergy && this.IsReachEnergyMax(num2))
				{
					num2 = (long)this.m_configDataLoader.ConfigableConstId_EnergyMax;
				}
				this.m_playerBasicDS.SetEnergy((int)num2);
			}
			return this.m_playerBasicDS.Energy;
		}

		// Token: 0x06004678 RID: 18040 RVA: 0x001598F0 File Offset: 0x00157AF0
		public virtual int DecreaseEnergy(int energyCost, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DecreaseEnergyInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_DecreaseEnergyInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					energyCost,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_playerBasicDS.Energy - energyCost;
			this.m_playerBasicDS.SetEnergy(num);
			if (this.ConsumeEnergyMissionEvent != null && causeId != GameFunctionType.GameFunctionType_GM)
			{
				this.ConsumeEnergyMissionEvent(energyCost);
			}
			return num;
		}

		// Token: 0x06004679 RID: 18041 RVA: 0x001599C8 File Offset: 0x00157BC8
		public bool IsEnergyEnough(int consumeEnergy = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsEnergyEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsEnergyEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeEnergy
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Energy >= consumeEnergy;
		}

		// Token: 0x0600467A RID: 18042 RVA: 0x00159A58 File Offset: 0x00157C58
		public int GetEnergy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetEnergy_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetEnergy_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Energy;
		}

		// Token: 0x0600467B RID: 18043 RVA: 0x00159AD0 File Offset: 0x00157CD0
		public virtual DateTime GetCurrentTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCurrentTime_hotfix != null)
			{
				return (DateTime)this.m_GetCurrentTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return DateTime.Now;
		}

		// Token: 0x0600467C RID: 18044 RVA: 0x00159B44 File Offset: 0x00157D44
		public bool IsSigned()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSigned_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSigned_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = (int)(this.GetCurrentTime().Date - this.m_playerBasicDS.LastSignTime.Date).TotalDays;
			return num <= 0;
		}

		// Token: 0x0600467D RID: 18045 RVA: 0x00159BE8 File Offset: 0x00157DE8
		public int CanSignToday()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSignToday_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSignToday_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsSigned())
			{
				return -406;
			}
			if (this.m_bag.IsBagFullByCurrentSize())
			{
				return -500;
			}
			return 0;
		}

		// Token: 0x0600467E RID: 18046 RVA: 0x00159C7C File Offset: 0x00157E7C
		public int CanBuyEnergy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyEnergy_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyEnergy_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsBoughtNumsUsedOut())
			{
				return -414;
			}
			ConfigDataBuyEnergyInfo buyEnergyConfig = this.GetBuyEnergyConfig();
			if (buyEnergyConfig == null)
			{
				return -408;
			}
			if (!this.IsCrystalEnough(buyEnergyConfig.Price))
			{
				return -401;
			}
			return 0;
		}

		// Token: 0x0600467F RID: 18047 RVA: 0x00159D24 File Offset: 0x00157F24
		private ConfigDataBuyEnergyInfo GetBuyEnergyConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBuyEnergyConfig_hotfix != null)
			{
				return (ConfigDataBuyEnergyInfo)this.m_GetBuyEnergyConfig_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_configDataLoader.GetConfigDataBuyEnergyInfo(this.m_playerBasicDS.BuyEngryNums + 1);
		}

		// Token: 0x06004680 RID: 18048 RVA: 0x00159DA8 File Offset: 0x00157FA8
		private bool IsBoughtNumsUsedOut()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsBoughtNumsUsedOut_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsBoughtNumsUsedOut_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.BuyEngryNums >= this.m_configDataLoader.BuyEnergyMaxNums;
		}

		// Token: 0x06004681 RID: 18049 RVA: 0x00159E30 File Offset: 0x00158030
		public virtual int BuyEnergy()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyEnergy_hotfix != null)
			{
				return Convert.ToInt32(this.m_BuyEnergy_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanBuyEnergy();
			if (num != 0)
			{
				return num;
			}
			ConfigDataBuyEnergyInfo buyEnergyConfig = this.GetBuyEnergyConfig();
			this.AddCrystal(-buyEnergyConfig.Price, GameFunctionType.GameFunctionType_BuyEnergy, null);
			this.IncreamentEnergy((long)this.m_configDataLoader.ConfigableConstId_BuyEnergyCount, true, GameFunctionType.GameFunctionType_BuyEnergy, null);
			this.m_playerBasicDS.BuyEngry();
			if (this.AddBuyEnergyMissionEvent != null)
			{
				this.AddBuyEnergyMissionEvent(1);
			}
			return 0;
		}

		// Token: 0x06004682 RID: 18050 RVA: 0x00159F00 File Offset: 0x00158100
		public int CanBuyArenaTickets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanBuyArenaTickets_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanBuyArenaTickets_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBuyArenaTicketInfo buyArenaTicketConfig = this.GetBuyArenaTicketConfig();
			if (buyArenaTicketConfig == null)
			{
				return -410;
			}
			if (!this.IsCrystalEnough(buyArenaTicketConfig.Price))
			{
				return -401;
			}
			return 0;
		}

		// Token: 0x06004683 RID: 18051 RVA: 0x00159F98 File Offset: 0x00158198
		private ConfigDataBuyArenaTicketInfo GetBuyArenaTicketConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBuyArenaTicketConfig_hotfix != null)
			{
				return (ConfigDataBuyArenaTicketInfo)this.m_GetBuyArenaTicketConfig_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_configDataLoader.BuyArenaTicketMaxNums <= this.m_playerBasicDS.BuyArenaTicketsNums)
			{
				return this.m_configDataLoader.GetConfigDataBuyArenaTicketInfo(this.m_configDataLoader.BuyArenaTicketMaxNums);
			}
			return this.m_configDataLoader.GetConfigDataBuyArenaTicketInfo(this.m_playerBasicDS.BuyArenaTicketsNums + 1);
		}

		// Token: 0x06004684 RID: 18052 RVA: 0x0015A050 File Offset: 0x00158250
		public int BuyArenaTickets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BuyArenaTickets_hotfix != null)
			{
				return Convert.ToInt32(this.m_BuyArenaTickets_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanBuyArenaTickets();
			if (num != 0)
			{
				return num;
			}
			ConfigDataBuyArenaTicketInfo buyArenaTicketConfig = this.GetBuyArenaTicketConfig();
			this.AddCrystal(-buyArenaTicketConfig.Price, GameFunctionType.GameFunctionType_BuyArenaTicket, null);
			this.AddArenaTickets(this.m_configDataLoader.ConfigableConstId_BuyArenaTicketCount, false, GameFunctionType.GameFunctionType_BuyArenaTicket, null);
			this.m_playerBasicDS.BuyArenaTickets();
			return 0;
		}

		// Token: 0x06004685 RID: 18053 RVA: 0x0015A108 File Offset: 0x00158308
		public DateTime GetNextFlushPlayerActionTime()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextFlushPlayerActionTime_hotfix != null)
			{
				return (DateTime)this.m_GetNextFlushPlayerActionTime_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.NextFlushPlayerActionTime;
		}

		// Token: 0x06004686 RID: 18054 RVA: 0x0015A180 File Offset: 0x00158380
		public bool FlushPlayerAction()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FlushPlayerAction_hotfix != null)
			{
				return Convert.ToBoolean(this.m_FlushPlayerAction_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.CanFlushPlayerAction())
			{
				this.OnPlayerActionFlushEvent();
				this.ResetPlayerActionNextFlushTime();
				return true;
			}
			return false;
		}

		// Token: 0x06004687 RID: 18055 RVA: 0x0015A208 File Offset: 0x00158408
		protected virtual void OnPlayerActionFlushEvent()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnPlayerActionFlushEvent_hotfix != null)
			{
				this.m_OnPlayerActionFlushEvent_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.OnFlush();
			if (this.PlayerActionFlushEvent != null)
			{
				this.PlayerActionFlushEvent();
			}
		}

		// Token: 0x06004688 RID: 18056 RVA: 0x0015A284 File Offset: 0x00158484
		private void OnFlush()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnFlush_hotfix != null)
			{
				this.m_OnFlush_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.ResetBuyEngryNums();
			this.m_playerBasicDS.ResetBuyArenaTicketsNums();
		}

		// Token: 0x06004689 RID: 18057 RVA: 0x0015A2FC File Offset: 0x001584FC
		public bool IsArenaTicketsEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaTicketsEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArenaTicketsEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.ArenaTickets >= consumeNums;
		}

		// Token: 0x0600468A RID: 18058 RVA: 0x0015A38C File Offset: 0x0015858C
		public bool IsArenaTicketsFull()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaTicketsFull_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArenaTicketsFull_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.ArenaTickets >= this.m_configDataLoader.ConfigableConstId_ArenaGivenTicketMaxNums;
		}

		// Token: 0x0600468B RID: 18059 RVA: 0x0015A414 File Offset: 0x00158614
		public virtual int AddArenaTickets(int nums, bool arenaGiven = true, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					arenaGiven,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!arenaGiven)
			{
				this.m_playerBasicDS.AddArenaTickets(nums);
				return this.m_playerBasicDS.ArenaTickets;
			}
			if (this.IsArenaTicketsFull())
			{
				return this.m_playerBasicDS.ArenaTickets;
			}
			int num = this.m_playerBasicDS.ArenaTickets;
			num += nums;
			if (num > this.m_configDataLoader.ConfigableConstId_ArenaGivenTicketMaxNums)
			{
				num = this.m_configDataLoader.ConfigableConstId_ArenaGivenTicketMaxNums;
			}
			this.m_playerBasicDS.SetArenaTickets(num);
			return num;
		}

		// Token: 0x0600468C RID: 18060 RVA: 0x0015A530 File Offset: 0x00158730
		public int GetAreanaTicketNums()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetAreanaTicketNums_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetAreanaTicketNums_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.ArenaTickets;
		}

		// Token: 0x0600468D RID: 18061 RVA: 0x0015A5A8 File Offset: 0x001587A8
		public int AddRechargedCrystal(int nums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRechargedCrystalInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddRechargedCrystalInt32_hotfix.call(new object[]
				{
					this,
					nums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddRechargedCrystal(nums);
		}

		// Token: 0x0600468E RID: 18062 RVA: 0x0015A630 File Offset: 0x00158830
		public virtual int AddArenaHonour(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddArenaHonourInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddArenaHonourInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddArenaHonour(nums);
		}

		// Token: 0x0600468F RID: 18063 RVA: 0x0015A6D8 File Offset: 0x001588D8
		public int GetArenaHonour()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaHonour_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetArenaHonour_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.ArenaHonour;
		}

		// Token: 0x06004690 RID: 18064 RVA: 0x0015A750 File Offset: 0x00158950
		public virtual int AddRealTimePVPHonor(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddRealTimePVPHonorInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddRealTimePVPHonorInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddRealTimePVPHonor(nums);
		}

		// Token: 0x06004691 RID: 18065 RVA: 0x0015A7F8 File Offset: 0x001589F8
		public int GetRealTimePVPHonor()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRealTimePVPHonor_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRealTimePVPHonor_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.RealTimePVPHonor;
		}

		// Token: 0x06004692 RID: 18066 RVA: 0x0015A870 File Offset: 0x00158A70
		public int GetFriendshipPoints()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetFriendshipPoints_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetFriendshipPoints_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.FriendshipPoints;
		}

		// Token: 0x06004693 RID: 18067 RVA: 0x0015A8E8 File Offset: 0x00158AE8
		public int GetSkinTickets()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetSkinTickets_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetSkinTickets_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.SkinTickets;
		}

		// Token: 0x06004694 RID: 18068 RVA: 0x0015A960 File Offset: 0x00158B60
		public virtual int AddFriendshipPoints(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddFriendshipPointsInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddFriendshipPointsInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (nums < 0 && this.ConsumeFriendshipPointsEvent != null && causeId != GameFunctionType.GameFunctionType_GM)
			{
				this.ConsumeFriendshipPointsEvent(-nums);
			}
			return this.m_playerBasicDS.AddFriendshipPoints(nums);
		}

		// Token: 0x06004695 RID: 18069 RVA: 0x0015AA30 File Offset: 0x00158C30
		public virtual int AddSkinTickets(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddSkinTicketsInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddSkinTicketsInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddSkinTickets(nums);
		}

		// Token: 0x06004696 RID: 18070 RVA: 0x0015AAD8 File Offset: 0x00158CD8
		public virtual int AddMemoryEssence(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMemoryEssenceInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddMemoryEssenceInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddMemoryEssence(nums);
		}

		// Token: 0x06004697 RID: 18071 RVA: 0x0015AB80 File Offset: 0x00158D80
		public virtual int AddBrillianceMithralStone(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddBrillianceMithralStoneInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddBrillianceMithralStoneInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddBrillianceMithralStone(nums);
		}

		// Token: 0x06004698 RID: 18072 RVA: 0x0015AC28 File Offset: 0x00158E28
		public virtual int AddMithralStone(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddMithralStoneInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddMithralStoneInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddMithralStone(nums);
		}

		// Token: 0x06004699 RID: 18073 RVA: 0x0015ACD0 File Offset: 0x00158ED0
		public virtual int AddGuildMedal(int nums, GameFunctionType causeId = GameFunctionType.GameFunctionType_None, string location = null)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AddGuildMedalInt32GameFunctionTypeString_hotfix != null)
			{
				return Convert.ToInt32(this.m_AddGuildMedalInt32GameFunctionTypeString_hotfix.call(new object[]
				{
					this,
					nums,
					causeId,
					location
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.AddGuildMedal(nums);
		}

		// Token: 0x0600469A RID: 18074 RVA: 0x0015AD78 File Offset: 0x00158F78
		public bool IsGuildMedalEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsGuildMedalEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsGuildMedalEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.GuildMedal >= consumeNums;
		}

		// Token: 0x0600469B RID: 18075 RVA: 0x0015AE08 File Offset: 0x00159008
		public bool IsFriendshipPointsEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsFriendshipPointsEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsFriendshipPointsEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.FriendshipPoints >= consumeNums;
		}

		// Token: 0x0600469C RID: 18076 RVA: 0x0015AE98 File Offset: 0x00159098
		public bool IsArenaHonourEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsArenaHonourEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsArenaHonourEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.ArenaHonour >= consumeNums;
		}

		// Token: 0x0600469D RID: 18077 RVA: 0x0015AF28 File Offset: 0x00159128
		public bool IsRealTimePVPHonorEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRealTimePVPHonorEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRealTimePVPHonorEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.RealTimePVPHonor >= consumeNums;
		}

		// Token: 0x0600469E RID: 18078 RVA: 0x0015AFB8 File Offset: 0x001591B8
		public bool IsSkinTicketEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsSkinTicketEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsSkinTicketEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.SkinTickets >= consumeNums;
		}

		// Token: 0x0600469F RID: 18079 RVA: 0x0015B048 File Offset: 0x00159248
		public bool IsMemoryEssenceEnough(int consumeNums)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMemoryEssenceEnoughInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMemoryEssenceEnoughInt32_hotfix.call(new object[]
				{
					this,
					consumeNums
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.MemoryEssence >= consumeNums;
		}

		// Token: 0x060046A0 RID: 18080 RVA: 0x0015B0D8 File Offset: 0x001592D8
		public int CanSetUserGuide(List<int> completeStepIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetUserGuideList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSetUserGuideList`1_hotfix.call(new object[]
				{
					this,
					completeStepIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (int num in completeStepIds)
			{
				if (this.m_configDataLoader.GetConfigDataUserGuide(num) == null)
				{
					return -418;
				}
				if (this.IsUserGuideCompleted(num))
				{
					return -1512;
				}
			}
			return 0;
		}

		// Token: 0x060046A1 RID: 18081 RVA: 0x0015B1D0 File Offset: 0x001593D0
		public virtual int SetUserGuide(List<int> completeStepIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetUserGuideList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_SetUserGuideList`1_hotfix.call(new object[]
				{
					this,
					completeStepIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanSetUserGuide(completeStepIds);
			if (num != 0)
			{
				return num;
			}
			this.m_playerBasicDS.SetUserGuide(completeStepIds);
			return 0;
		}

		// Token: 0x060046A2 RID: 18082 RVA: 0x0015B26C File Offset: 0x0015946C
		public void CleanUserGuide(List<int> completeStepIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CleanUserGuideList`1_hotfix != null)
			{
				this.m_CleanUserGuideList`1_hotfix.call(new object[]
				{
					this,
					completeStepIds
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.CleanUserGuide(completeStepIds);
		}

		// Token: 0x060046A3 RID: 18083 RVA: 0x0015B2E8 File Offset: 0x001594E8
		public void CompleteAllUserGuides()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CompleteAllUserGuides_hotfix != null)
			{
				this.m_CompleteAllUserGuides_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			List<int> list = new List<int>();
			foreach (KeyValuePair<int, ConfigDataUserGuide> keyValuePair in this.m_configDataLoader.GetAllConfigDataUserGuide())
			{
				list.Add(keyValuePair.Value.ID);
			}
			this.m_playerBasicDS.SetUserGuide(list);
		}

		// Token: 0x060046A4 RID: 18084 RVA: 0x0015B3B8 File Offset: 0x001595B8
		public bool IsUserGuideCompleted(int stepId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsUserGuideCompletedInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsUserGuideCompletedInt32_hotfix.call(new object[]
				{
					this,
					stepId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.IsUserGuideCompleted(stepId);
		}

		// Token: 0x060046A5 RID: 18085 RVA: 0x0015B440 File Offset: 0x00159640
		public int GetLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevel_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLevel_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.PlayerLevel;
		}

		// Token: 0x060046A6 RID: 18086 RVA: 0x0015B4B8 File Offset: 0x001596B8
		public int GetRechargedCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRechargedCrystal_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRechargedCrystal_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.RechargeCrystal;
		}

		// Token: 0x060046A7 RID: 18087 RVA: 0x0015B530 File Offset: 0x00159730
		public int GetCrystal()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetCrystal_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetCrystal_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.Crystal;
		}

		// Token: 0x060046A8 RID: 18088 RVA: 0x0015B5A8 File Offset: 0x001597A8
		public bool CheckRankingListAddPlayerLevel()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckRankingListAddPlayerLevel_hotfix != null)
			{
				return Convert.ToBoolean(this.m_CheckRankingListAddPlayerLevel_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.m_configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_GlobalRankingListOpenPlayerLevel);
			return this.GetLevel() >= num;
		}

		// Token: 0x060046A9 RID: 18089 RVA: 0x0015B634 File Offset: 0x00159834
		public RankingPlayerInfo CreateRankingPlayerInfo(int championHeroId = 0)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateRankingPlayerInfoInt32_hotfix != null)
			{
				return (RankingPlayerInfo)this.m_CreateRankingPlayerInfoInt32_hotfix.call(new object[]
				{
					this,
					championHeroId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return new RankingPlayerInfo
			{
				UserId = this.GetUserId(),
				HeadIcon = this.GetHeadIcon(),
				Level = this.GetLevel(),
				Name = this.GetPlayerName(),
				ChampionHeroId = championHeroId
			};
		}

		// Token: 0x060046AA RID: 18090 RVA: 0x0015B6F0 File Offset: 0x001598F0
		public virtual void OnRankingListPlayerInfoChange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnRankingListPlayerInfoChange_hotfix != null)
			{
				this.m_OnRankingListPlayerInfoChange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
		}

		// Token: 0x060046AB RID: 18091 RVA: 0x0015B750 File Offset: 0x00159950
		public void OpenGameRating()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OpenGameRating_hotfix != null)
			{
				this.m_OpenGameRating_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.OpenGameRating = true;
		}

		// Token: 0x060046AC RID: 18092 RVA: 0x0015B7BC File Offset: 0x001599BC
		public bool IsOpenGameRating()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsOpenGameRating_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsOpenGameRating_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.OpenGameRating;
		}

		// Token: 0x060046AD RID: 18093 RVA: 0x0015B834 File Offset: 0x00159A34
		public void SetMemoryStoreOpenStatus(bool open)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMemoryStoreOpenStatusBoolean_hotfix != null)
			{
				this.m_SetMemoryStoreOpenStatusBoolean_hotfix.call(new object[]
				{
					this,
					open
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.SetMemoryStoreOpenStatus(open);
		}

		// Token: 0x060046AE RID: 18094 RVA: 0x0015B8B0 File Offset: 0x00159AB0
		public bool IsMemoryStoreOpen()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsMemoryStoreOpen_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsMemoryStoreOpen_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_playerBasicDS.MemoryStoreOpen;
		}

		// Token: 0x060046AF RID: 18095 RVA: 0x0015B928 File Offset: 0x00159B28
		public int GetLevelUpAddEnergyFromConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetLevelUpAddEnergyFromConfig_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetLevelUpAddEnergyFromConfig_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = 0;
			ConfigDataPlayerLevelInfo configDataPlayerLevelInfo = this.m_configDataLoader.GetConfigDataPlayerLevelInfo(this.m_playerBasicDS.PlayerLevel);
			if (configDataPlayerLevelInfo != null)
			{
				result = configDataPlayerLevelInfo.Energy;
			}
			return result;
		}

		// Token: 0x060046B0 RID: 18096 RVA: 0x0015B9BC File Offset: 0x00159BBC
		public int GetNextLevelExpFromConfig()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetNextLevelExpFromConfig_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetNextLevelExpFromConfig_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int result = int.MaxValue;
			ConfigDataPlayerLevelInfo configDataPlayerLevelInfo = this.m_configDataLoader.GetConfigDataPlayerLevelInfo(this.m_playerBasicDS.PlayerLevel);
			if (configDataPlayerLevelInfo != null)
			{
				result = configDataPlayerLevelInfo.Exp;
			}
			return result;
		}

		// Token: 0x060046B1 RID: 18097 RVA: 0x0015BA54 File Offset: 0x00159C54
		public int CanSetHeadPortraitAndHeadFrame(int headPortraitId, int headFrameId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetHeadPortraitAndHeadFrameInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSetHeadPortraitAndHeadFrameInt32Int32_hotfix.call(new object[]
				{
					this,
					headPortraitId,
					headFrameId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero.FindHero(headPortraitId) == null)
			{
				return -602;
			}
			if (!this.m_resource.HasHeadFrameId(headFrameId))
			{
				return -13;
			}
			return 0;
		}

		// Token: 0x060046B2 RID: 18098 RVA: 0x0015BB0C File Offset: 0x00159D0C
		public int SetHeadPortraitAndHeadFrame(int headPortraitId, int headFrameId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeadPortraitAndHeadFrameInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SetHeadPortraitAndHeadFrameInt32Int32_hotfix.call(new object[]
				{
					this,
					headPortraitId,
					headFrameId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanSetHeadPortraitAndHeadFrame(headPortraitId, headFrameId);
			if (num != 0)
			{
				return num;
			}
			int headIcon = HeadIconTools.GetHeadIcon(headPortraitId, headFrameId);
			this.m_playerBasicDS.SetHeadIcon(headIcon);
			this.OnHeadIconChange();
			return 0;
		}

		// Token: 0x060046B3 RID: 18099 RVA: 0x0015BBC4 File Offset: 0x00159DC4
		public int CanSetHeadPortrait(int headPortraitId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetHeadPortraitInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSetHeadPortraitInt32_hotfix.call(new object[]
				{
					this,
					headPortraitId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_hero.FindHero(headPortraitId) == null)
			{
				return -602;
			}
			return 0;
		}

		// Token: 0x060046B4 RID: 18100 RVA: 0x0015BC58 File Offset: 0x00159E58
		public int SetHeadPortrait(int headPortraitId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeadPortraitInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SetHeadPortraitInt32_hotfix.call(new object[]
				{
					this,
					headPortraitId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanSetHeadPortrait(headPortraitId);
			if (num != 0)
			{
				return num;
			}
			int headFrame = this.GetHeadFrame();
			int headIcon = HeadIconTools.GetHeadIcon(headPortraitId, headFrame);
			this.m_playerBasicDS.SetHeadIcon(headIcon);
			this.OnHeadIconChange();
			return 0;
		}

		// Token: 0x060046B5 RID: 18101 RVA: 0x0015BD08 File Offset: 0x00159F08
		public int CanSetHeadFrame(int headFrameId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanSetHeadFrameInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanSetHeadFrameInt32_hotfix.call(new object[]
				{
					this,
					headFrameId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.m_resource.HasHeadFrameId(headFrameId))
			{
				return -13;
			}
			int headFrame = this.GetHeadFrame();
			if (headFrame == headFrameId)
			{
				return -14;
			}
			return 0;
		}

		// Token: 0x060046B6 RID: 18102 RVA: 0x0015BDAC File Offset: 0x00159FAC
		public int SetHeadFrame(int headFrameId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetHeadFrameInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_SetHeadFrameInt32_hotfix.call(new object[]
				{
					this,
					headFrameId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanSetHeadFrame(headFrameId);
			if (num != 0)
			{
				return num;
			}
			int headPortrait = this.GetHeadPortrait();
			int headIcon = HeadIconTools.GetHeadIcon(headPortrait, headFrameId);
			this.m_playerBasicDS.SetHeadIcon(headIcon);
			this.OnHeadIconChange();
			return 0;
		}

		// Token: 0x060046B7 RID: 18103 RVA: 0x0015BE5C File Offset: 0x0015A05C
		protected virtual void OnHeadIconChange()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_OnHeadIconChange_hotfix != null)
			{
				this.m_OnHeadIconChange_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.SetHeadIconEvent != null)
			{
				this.SetHeadIconEvent(this.m_playerBasicDS.HeadIcon);
			}
			this.OnRankingListPlayerInfoChange();
		}

		// Token: 0x060046B8 RID: 18104 RVA: 0x0015BEE4 File Offset: 0x0015A0E4
		public int CanChangePlayerName(string newName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanChangePlayerNameString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanChangePlayerNameString_hotfix.call(new object[]
				{
					this,
					newName
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsCrystalEnough(this.m_configDataLoader.ConfigableConstId_ChangeNameCostNums))
			{
				return -401;
			}
			if (this.m_playerBasicDS.PlayerName.CompareTo(newName) == 0)
			{
				return -412;
			}
			return this.CheckPlayerName(newName);
		}

		// Token: 0x060046B9 RID: 18105 RVA: 0x0015BFA0 File Offset: 0x0015A1A0
		public int ChangePlayerName(string newName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangePlayerNameString_hotfix != null)
			{
				return Convert.ToInt32(this.m_ChangePlayerNameString_hotfix.call(new object[]
				{
					this,
					newName
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.CanChangePlayerName(newName);
			if (num != 0)
			{
				return num;
			}
			num = this.TryChangePlayerName(newName);
			if (num != 0)
			{
				return num;
			}
			this.AddCrystal(-this.m_configDataLoader.ConfigableConstId_ChangeNameCostNums, GameFunctionType.GameFunctionType_ChangeName, null);
			this.OnRankingListPlayerInfoChange();
			return 0;
		}

		// Token: 0x060046BA RID: 18106 RVA: 0x0015C05C File Offset: 0x0015A25C
		protected virtual int TryChangePlayerName(string newName)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_TryChangePlayerNameString_hotfix != null)
			{
				return Convert.ToInt32(this.m_TryChangePlayerNameString_hotfix.call(new object[]
				{
					this,
					newName
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_playerBasicDS.ChangePlayerName(newName);
			return 0;
		}

		// Token: 0x060046BB RID: 18107 RVA: 0x0015C0E8 File Offset: 0x0015A2E8
		public virtual int CheckPlayerName(string name)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CheckPlayerNameString_hotfix != null)
			{
				return Convert.ToInt32(this.m_CheckPlayerNameString_hotfix.call(new object[]
				{
					this,
					name
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (string.IsNullOrEmpty(name))
			{
				return -5;
			}
			if (!StringCheck.IsStringLegal(name))
			{
				return -5;
			}
			if (this.m_configDataLoader.UtilityGetSensitiveWords().IsSensitiveWord(name))
			{
				return -5;
			}
			return 0;
		}

		// Token: 0x060046BC RID: 18108 RVA: 0x0015C19C File Offset: 0x0015A39C
		public void DoShare()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DoShare_hotfix != null)
			{
				this.m_DoShare_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.DoShareEvent != null)
			{
				this.DoShareEvent();
			}
		}

		// Token: 0x1400004C RID: 76
		// (add) Token: 0x060046BD RID: 18109 RVA: 0x0015C214 File Offset: 0x0015A414
		// (remove) Token: 0x060046BE RID: 18110 RVA: 0x0015C2B0 File Offset: 0x0015A4B0
		public event Action<int> LevelUpPlayerLevelEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_LevelUpPlayerLevelEventAction`1_hotfix != null)
				{
					this.m_add_LevelUpPlayerLevelEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.LevelUpPlayerLevelEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.LevelUpPlayerLevelEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_LevelUpPlayerLevelEventAction`1_hotfix != null)
				{
					this.m_remove_LevelUpPlayerLevelEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.LevelUpPlayerLevelEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.LevelUpPlayerLevelEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400004D RID: 77
		// (add) Token: 0x060046BF RID: 18111 RVA: 0x0015C34C File Offset: 0x0015A54C
		// (remove) Token: 0x060046C0 RID: 18112 RVA: 0x0015C3E8 File Offset: 0x0015A5E8
		public event Action<int> ConsumeEnergyMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ConsumeEnergyMissionEventAction`1_hotfix != null)
				{
					this.m_add_ConsumeEnergyMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeEnergyMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeEnergyMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ConsumeEnergyMissionEventAction`1_hotfix != null)
				{
					this.m_remove_ConsumeEnergyMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeEnergyMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeEnergyMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400004E RID: 78
		// (add) Token: 0x060046C1 RID: 18113 RVA: 0x0015C484 File Offset: 0x0015A684
		// (remove) Token: 0x060046C2 RID: 18114 RVA: 0x0015C520 File Offset: 0x0015A720
		public event Action<int> ConsumeGoldMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ConsumeGoldMissionEventAction`1_hotfix != null)
				{
					this.m_add_ConsumeGoldMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeGoldMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeGoldMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ConsumeGoldMissionEventAction`1_hotfix != null)
				{
					this.m_remove_ConsumeGoldMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeGoldMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeGoldMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x1400004F RID: 79
		// (add) Token: 0x060046C3 RID: 18115 RVA: 0x0015C5BC File Offset: 0x0015A7BC
		// (remove) Token: 0x060046C4 RID: 18116 RVA: 0x0015C658 File Offset: 0x0015A858
		public event Action<int> ConsumeCrystalMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ConsumeCrystalMissionEventAction`1_hotfix != null)
				{
					this.m_add_ConsumeCrystalMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeCrystalMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeCrystalMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ConsumeCrystalMissionEventAction`1_hotfix != null)
				{
					this.m_remove_ConsumeCrystalMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeCrystalMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeCrystalMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000050 RID: 80
		// (add) Token: 0x060046C5 RID: 18117 RVA: 0x0015C6F4 File Offset: 0x0015A8F4
		// (remove) Token: 0x060046C6 RID: 18118 RVA: 0x0015C790 File Offset: 0x0015A990
		public event Action<int> LevelUpPlayerLevelMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_LevelUpPlayerLevelMissionEventAction`1_hotfix != null)
				{
					this.m_add_LevelUpPlayerLevelMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.LevelUpPlayerLevelMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.LevelUpPlayerLevelMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_LevelUpPlayerLevelMissionEventAction`1_hotfix != null)
				{
					this.m_remove_LevelUpPlayerLevelMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.LevelUpPlayerLevelMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.LevelUpPlayerLevelMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000051 RID: 81
		// (add) Token: 0x060046C7 RID: 18119 RVA: 0x0015C82C File Offset: 0x0015AA2C
		// (remove) Token: 0x060046C8 RID: 18120 RVA: 0x0015C8C8 File Offset: 0x0015AAC8
		public event Action<int> AddBuyEnergyMissionEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddBuyEnergyMissionEventAction`1_hotfix != null)
				{
					this.m_add_AddBuyEnergyMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddBuyEnergyMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddBuyEnergyMissionEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddBuyEnergyMissionEventAction`1_hotfix != null)
				{
					this.m_remove_AddBuyEnergyMissionEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.AddBuyEnergyMissionEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.AddBuyEnergyMissionEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000052 RID: 82
		// (add) Token: 0x060046C9 RID: 18121 RVA: 0x0015C964 File Offset: 0x0015AB64
		// (remove) Token: 0x060046CA RID: 18122 RVA: 0x0015CA00 File Offset: 0x0015AC00
		public event Action PlayerActionFlushEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_PlayerActionFlushEventAction_hotfix != null)
				{
					this.m_add_PlayerActionFlushEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.PlayerActionFlushEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.PlayerActionFlushEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_PlayerActionFlushEventAction_hotfix != null)
				{
					this.m_remove_PlayerActionFlushEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.PlayerActionFlushEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.PlayerActionFlushEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000053 RID: 83
		// (add) Token: 0x060046CB RID: 18123 RVA: 0x0015CA9C File Offset: 0x0015AC9C
		// (remove) Token: 0x060046CC RID: 18124 RVA: 0x0015CB38 File Offset: 0x0015AD38
		public event Action<int> ConsumeFriendshipPointsEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_ConsumeFriendshipPointsEventAction`1_hotfix != null)
				{
					this.m_add_ConsumeFriendshipPointsEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeFriendshipPointsEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeFriendshipPointsEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_ConsumeFriendshipPointsEventAction`1_hotfix != null)
				{
					this.m_remove_ConsumeFriendshipPointsEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.ConsumeFriendshipPointsEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.ConsumeFriendshipPointsEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000054 RID: 84
		// (add) Token: 0x060046CD RID: 18125 RVA: 0x0015CBD4 File Offset: 0x0015ADD4
		// (remove) Token: 0x060046CE RID: 18126 RVA: 0x0015CC70 File Offset: 0x0015AE70
		public event Action<int> SetHeadIconEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_SetHeadIconEventAction`1_hotfix != null)
				{
					this.m_add_SetHeadIconEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.SetHeadIconEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.SetHeadIconEvent, (Action<int>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_SetHeadIconEventAction`1_hotfix != null)
				{
					this.m_remove_SetHeadIconEventAction`1_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int> action = this.SetHeadIconEvent;
				Action<int> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int>>(ref this.SetHeadIconEvent, (Action<int>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000055 RID: 85
		// (add) Token: 0x060046CF RID: 18127 RVA: 0x0015CD0C File Offset: 0x0015AF0C
		// (remove) Token: 0x060046D0 RID: 18128 RVA: 0x0015CDA8 File Offset: 0x0015AFA8
		public event Action<int, DateTime> AddRechargeRMBEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_AddRechargeRMBEventAction`2_hotfix != null)
				{
					this.m_add_AddRechargeRMBEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, DateTime> action = this.AddRechargeRMBEvent;
				Action<int, DateTime> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, DateTime>>(ref this.AddRechargeRMBEvent, (Action<int, DateTime>)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_AddRechargeRMBEventAction`2_hotfix != null)
				{
					this.m_remove_AddRechargeRMBEventAction`2_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action<int, DateTime> action = this.AddRechargeRMBEvent;
				Action<int, DateTime> action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action<int, DateTime>>(ref this.AddRechargeRMBEvent, (Action<int, DateTime>)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x14000056 RID: 86
		// (add) Token: 0x060046D1 RID: 18129 RVA: 0x0015CE44 File Offset: 0x0015B044
		// (remove) Token: 0x060046D2 RID: 18130 RVA: 0x0015CEE0 File Offset: 0x0015B0E0
		public event Action DoShareEvent
		{
			add
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_add_DoShareEventAction_hotfix != null)
				{
					this.m_add_DoShareEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.DoShareEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.DoShareEvent, (Action)Delegate.Combine(action2, value), action);
				}
				while (action != action2);
			}
			remove
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_remove_DoShareEventAction_hotfix != null)
				{
					this.m_remove_DoShareEventAction_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				Action action = this.DoShareEvent;
				Action action2;
				do
				{
					action2 = action;
					action = Interlocked.CompareExchange<Action>(ref this.DoShareEvent, (Action)Delegate.Remove(action2, value), action);
				}
				while (action != action2);
			}
		}

		// Token: 0x170011E2 RID: 4578
		// (get) Token: 0x060046D3 RID: 18131 RVA: 0x0015CF7C File Offset: 0x0015B17C
		// (set) Token: 0x060046D4 RID: 18132 RVA: 0x0015CF9C File Offset: 0x0015B19C
		[DoNotToLua]
		public PlayerBasicInfoComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new PlayerBasicInfoComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x060046D5 RID: 18133 RVA: 0x0015CFA8 File Offset: 0x0015B1A8
		private void __callDele_LevelUpPlayerLevelEvent(int obj)
		{
			Action<int> levelUpPlayerLevelEvent = this.LevelUpPlayerLevelEvent;
			if (levelUpPlayerLevelEvent != null)
			{
				levelUpPlayerLevelEvent(obj);
			}
		}

		// Token: 0x060046D6 RID: 18134 RVA: 0x0015CFCC File Offset: 0x0015B1CC
		private void __clearDele_LevelUpPlayerLevelEvent(int obj)
		{
			this.LevelUpPlayerLevelEvent = null;
		}

		// Token: 0x060046D7 RID: 18135 RVA: 0x0015CFD8 File Offset: 0x0015B1D8
		private void __callDele_ConsumeEnergyMissionEvent(int obj)
		{
			Action<int> consumeEnergyMissionEvent = this.ConsumeEnergyMissionEvent;
			if (consumeEnergyMissionEvent != null)
			{
				consumeEnergyMissionEvent(obj);
			}
		}

		// Token: 0x060046D8 RID: 18136 RVA: 0x0015CFFC File Offset: 0x0015B1FC
		private void __clearDele_ConsumeEnergyMissionEvent(int obj)
		{
			this.ConsumeEnergyMissionEvent = null;
		}

		// Token: 0x060046D9 RID: 18137 RVA: 0x0015D008 File Offset: 0x0015B208
		private void __callDele_ConsumeGoldMissionEvent(int obj)
		{
			Action<int> consumeGoldMissionEvent = this.ConsumeGoldMissionEvent;
			if (consumeGoldMissionEvent != null)
			{
				consumeGoldMissionEvent(obj);
			}
		}

		// Token: 0x060046DA RID: 18138 RVA: 0x0015D02C File Offset: 0x0015B22C
		private void __clearDele_ConsumeGoldMissionEvent(int obj)
		{
			this.ConsumeGoldMissionEvent = null;
		}

		// Token: 0x060046DB RID: 18139 RVA: 0x0015D038 File Offset: 0x0015B238
		private void __callDele_ConsumeCrystalMissionEvent(int obj)
		{
			Action<int> consumeCrystalMissionEvent = this.ConsumeCrystalMissionEvent;
			if (consumeCrystalMissionEvent != null)
			{
				consumeCrystalMissionEvent(obj);
			}
		}

		// Token: 0x060046DC RID: 18140 RVA: 0x0015D05C File Offset: 0x0015B25C
		private void __clearDele_ConsumeCrystalMissionEvent(int obj)
		{
			this.ConsumeCrystalMissionEvent = null;
		}

		// Token: 0x060046DD RID: 18141 RVA: 0x0015D068 File Offset: 0x0015B268
		private void __callDele_LevelUpPlayerLevelMissionEvent(int obj)
		{
			Action<int> levelUpPlayerLevelMissionEvent = this.LevelUpPlayerLevelMissionEvent;
			if (levelUpPlayerLevelMissionEvent != null)
			{
				levelUpPlayerLevelMissionEvent(obj);
			}
		}

		// Token: 0x060046DE RID: 18142 RVA: 0x0015D08C File Offset: 0x0015B28C
		private void __clearDele_LevelUpPlayerLevelMissionEvent(int obj)
		{
			this.LevelUpPlayerLevelMissionEvent = null;
		}

		// Token: 0x060046DF RID: 18143 RVA: 0x0015D098 File Offset: 0x0015B298
		private void __callDele_AddBuyEnergyMissionEvent(int obj)
		{
			Action<int> addBuyEnergyMissionEvent = this.AddBuyEnergyMissionEvent;
			if (addBuyEnergyMissionEvent != null)
			{
				addBuyEnergyMissionEvent(obj);
			}
		}

		// Token: 0x060046E0 RID: 18144 RVA: 0x0015D0BC File Offset: 0x0015B2BC
		private void __clearDele_AddBuyEnergyMissionEvent(int obj)
		{
			this.AddBuyEnergyMissionEvent = null;
		}

		// Token: 0x060046E1 RID: 18145 RVA: 0x0015D0C8 File Offset: 0x0015B2C8
		private void __callDele_PlayerActionFlushEvent()
		{
			Action playerActionFlushEvent = this.PlayerActionFlushEvent;
			if (playerActionFlushEvent != null)
			{
				playerActionFlushEvent();
			}
		}

		// Token: 0x060046E2 RID: 18146 RVA: 0x0015D0E8 File Offset: 0x0015B2E8
		private void __clearDele_PlayerActionFlushEvent()
		{
			this.PlayerActionFlushEvent = null;
		}

		// Token: 0x060046E3 RID: 18147 RVA: 0x0015D0F4 File Offset: 0x0015B2F4
		private void __callDele_ConsumeFriendshipPointsEvent(int obj)
		{
			Action<int> consumeFriendshipPointsEvent = this.ConsumeFriendshipPointsEvent;
			if (consumeFriendshipPointsEvent != null)
			{
				consumeFriendshipPointsEvent(obj);
			}
		}

		// Token: 0x060046E4 RID: 18148 RVA: 0x0015D118 File Offset: 0x0015B318
		private void __clearDele_ConsumeFriendshipPointsEvent(int obj)
		{
			this.ConsumeFriendshipPointsEvent = null;
		}

		// Token: 0x060046E5 RID: 18149 RVA: 0x0015D124 File Offset: 0x0015B324
		private void __callDele_SetHeadIconEvent(int obj)
		{
			Action<int> setHeadIconEvent = this.SetHeadIconEvent;
			if (setHeadIconEvent != null)
			{
				setHeadIconEvent(obj);
			}
		}

		// Token: 0x060046E6 RID: 18150 RVA: 0x0015D148 File Offset: 0x0015B348
		private void __clearDele_SetHeadIconEvent(int obj)
		{
			this.SetHeadIconEvent = null;
		}

		// Token: 0x060046E7 RID: 18151 RVA: 0x0015D154 File Offset: 0x0015B354
		private void __callDele_AddRechargeRMBEvent(int arg1, DateTime arg2)
		{
			Action<int, DateTime> addRechargeRMBEvent = this.AddRechargeRMBEvent;
			if (addRechargeRMBEvent != null)
			{
				addRechargeRMBEvent(arg1, arg2);
			}
		}

		// Token: 0x060046E8 RID: 18152 RVA: 0x0015D178 File Offset: 0x0015B378
		private void __clearDele_AddRechargeRMBEvent(int arg1, DateTime arg2)
		{
			this.AddRechargeRMBEvent = null;
		}

		// Token: 0x060046E9 RID: 18153 RVA: 0x0015D184 File Offset: 0x0015B384
		private void __callDele_DoShareEvent()
		{
			Action doShareEvent = this.DoShareEvent;
			if (doShareEvent != null)
			{
				doShareEvent();
			}
		}

		// Token: 0x060046EA RID: 18154 RVA: 0x0015D1A4 File Offset: 0x0015B3A4
		private void __clearDele_DoShareEvent()
		{
			this.DoShareEvent = null;
		}

		// Token: 0x060046EB RID: 18155 RVA: 0x0015D1B0 File Offset: 0x0015B3B0
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
					this.m_TryUpdateSignedDays_hotfix = (luaObj.RawGet("TryUpdateSignedDays") as LuaFunction);
					this.m_GetGameFunctionOpenInfoGameFunctionType_hotfix = (luaObj.RawGet("GetGameFunctionOpenInfo") as LuaFunction);
					this.m_IsGameFunctionOpenedGameFunctionType_hotfix = (luaObj.RawGet("IsGameFunctionOpened") as LuaFunction);
					this.m_GetCreateTime_hotfix = (luaObj.RawGet("GetCreateTime") as LuaFunction);
					this.m_GetCreateTimeUtc_hotfix = (luaObj.RawGet("GetCreateTimeUtc") as LuaFunction);
					this.m_GetLastLogoutTime_hotfix = (luaObj.RawGet("GetLastLogoutTime") as LuaFunction);
					this.m_GetLoginTime_hotfix = (luaObj.RawGet("GetLoginTime") as LuaFunction);
					this.m_GetPlayerName_hotfix = (luaObj.RawGet("GetPlayerName") as LuaFunction);
					this.m_GetUserId_hotfix = (luaObj.RawGet("GetUserId") as LuaFunction);
					this.m_IsMeString_hotfix = (luaObj.RawGet("IsMe") as LuaFunction);
					this.m_GetCurrentLevelExp_hotfix = (luaObj.RawGet("GetCurrentLevelExp") as LuaFunction);
					this.m_GetRechargedCsystal_hotfix = (luaObj.RawGet("GetRechargedCsystal") as LuaFunction);
					this.m_GetRechargeRMB_hotfix = (luaObj.RawGet("GetRechargeRMB") as LuaFunction);
					this.m_GetHeadIcon_hotfix = (luaObj.RawGet("GetHeadIcon") as LuaFunction);
					this.m_GetDefaultHeadIcon_hotfix = (luaObj.RawGet("GetDefaultHeadIcon") as LuaFunction);
					this.m_GetHeadPortrait_hotfix = (luaObj.RawGet("GetHeadPortrait") as LuaFunction);
					this.m_GetHeadFrame_hotfix = (luaObj.RawGet("GetHeadFrame") as LuaFunction);
					this.m_IsPlayerLevelMax_hotfix = (luaObj.RawGet("IsPlayerLevelMax") as LuaFunction);
					this.m_CanAddPlayerExp_hotfix = (luaObj.RawGet("CanAddPlayerExp") as LuaFunction);
					this.m_AddPlayerExpInt32_hotfix = (luaObj.RawGet("AddPlayerExp") as LuaFunction);
					this.m_OnLevelChangeInt32Int32_hotfix = (luaObj.RawGet("OnLevelChange") as LuaFunction);
					this.m_LevelUp_hotfix = (luaObj.RawGet("LevelUp") as LuaFunction);
					this.m_AddGoldInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddGold") as LuaFunction);
					this.m_IsGoldEnoughInt32_hotfix = (luaObj.RawGet("IsGoldEnough") as LuaFunction);
					this.m_IsGoldOverFlowInt32_hotfix = (luaObj.RawGet("IsGoldOverFlow") as LuaFunction);
					this.m_GetGold_hotfix = (luaObj.RawGet("GetGold") as LuaFunction);
					this.m_AddBrillianceMithralStoneInt32_hotfix = (luaObj.RawGet("AddBrillianceMithralStone") as LuaFunction);
					this.m_AddMithralStoneInt32_hotfix = (luaObj.RawGet("AddMithralStone") as LuaFunction);
					this.m_IsMithralStoneEnoughInt32_hotfix = (luaObj.RawGet("IsMithralStoneEnough") as LuaFunction);
					this.m_IsBrillianceMithralStoneEnoughInt32_hotfix = (luaObj.RawGet("IsBrillianceMithralStoneEnough") as LuaFunction);
					this.m_IsCurrencyEnoughGoodsTypeInt32_hotfix = (luaObj.RawGet("IsCurrencyEnough") as LuaFunction);
					this.m_AddCurrencyGoodsTypeInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddCurrency") as LuaFunction);
					this.m_AddRechargeRMBInt32DateTimeBoolean_hotfix = (luaObj.RawGet("AddRechargeRMB") as LuaFunction);
					this.m_AddCrystalInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddCrystal") as LuaFunction);
					this.m_IsCrystalEnoughInt32_hotfix = (luaObj.RawGet("IsCrystalEnough") as LuaFunction);
					this.m_InitEnergyInt64_hotfix = (luaObj.RawGet("InitEnergy") as LuaFunction);
					this.m_IsReachEnergyMaxInt64_hotfix = (luaObj.RawGet("IsReachEnergyMax") as LuaFunction);
					this.m_FlushEnergy_hotfix = (luaObj.RawGet("FlushEnergy") as LuaFunction);
					this.m_CanFlushEnergy_hotfix = (luaObj.RawGet("CanFlushEnergy") as LuaFunction);
					this.m_CanFlushPlayerAction_hotfix = (luaObj.RawGet("CanFlushPlayerAction") as LuaFunction);
					this.m_ResetPlayerActionNextFlushTime_hotfix = (luaObj.RawGet("ResetPlayerActionNextFlushTime") as LuaFunction);
					this.m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix = (luaObj.RawGet("IncreamentEnergy") as LuaFunction);
					this.m_DecreaseEnergyInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("DecreaseEnergy") as LuaFunction);
					this.m_IsEnergyEnoughInt32_hotfix = (luaObj.RawGet("IsEnergyEnough") as LuaFunction);
					this.m_GetEnergy_hotfix = (luaObj.RawGet("GetEnergy") as LuaFunction);
					this.m_GetCurrentTime_hotfix = (luaObj.RawGet("GetCurrentTime") as LuaFunction);
					this.m_IsSigned_hotfix = (luaObj.RawGet("IsSigned") as LuaFunction);
					this.m_CanSignToday_hotfix = (luaObj.RawGet("CanSignToday") as LuaFunction);
					this.m_CanBuyEnergy_hotfix = (luaObj.RawGet("CanBuyEnergy") as LuaFunction);
					this.m_GetBuyEnergyConfig_hotfix = (luaObj.RawGet("GetBuyEnergyConfig") as LuaFunction);
					this.m_IsBoughtNumsUsedOut_hotfix = (luaObj.RawGet("IsBoughtNumsUsedOut") as LuaFunction);
					this.m_BuyEnergy_hotfix = (luaObj.RawGet("BuyEnergy") as LuaFunction);
					this.m_CanBuyArenaTickets_hotfix = (luaObj.RawGet("CanBuyArenaTickets") as LuaFunction);
					this.m_GetBuyArenaTicketConfig_hotfix = (luaObj.RawGet("GetBuyArenaTicketConfig") as LuaFunction);
					this.m_BuyArenaTickets_hotfix = (luaObj.RawGet("BuyArenaTickets") as LuaFunction);
					this.m_GetNextFlushPlayerActionTime_hotfix = (luaObj.RawGet("GetNextFlushPlayerActionTime") as LuaFunction);
					this.m_FlushPlayerAction_hotfix = (luaObj.RawGet("FlushPlayerAction") as LuaFunction);
					this.m_OnPlayerActionFlushEvent_hotfix = (luaObj.RawGet("OnPlayerActionFlushEvent") as LuaFunction);
					this.m_OnFlush_hotfix = (luaObj.RawGet("OnFlush") as LuaFunction);
					this.m_IsArenaTicketsEnoughInt32_hotfix = (luaObj.RawGet("IsArenaTicketsEnough") as LuaFunction);
					this.m_IsArenaTicketsFull_hotfix = (luaObj.RawGet("IsArenaTicketsFull") as LuaFunction);
					this.m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix = (luaObj.RawGet("AddArenaTickets") as LuaFunction);
					this.m_GetAreanaTicketNums_hotfix = (luaObj.RawGet("GetAreanaTicketNums") as LuaFunction);
					this.m_AddRechargedCrystalInt32_hotfix = (luaObj.RawGet("AddRechargedCrystal") as LuaFunction);
					this.m_AddArenaHonourInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddArenaHonour") as LuaFunction);
					this.m_GetArenaHonour_hotfix = (luaObj.RawGet("GetArenaHonour") as LuaFunction);
					this.m_AddRealTimePVPHonorInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddRealTimePVPHonor") as LuaFunction);
					this.m_GetRealTimePVPHonor_hotfix = (luaObj.RawGet("GetRealTimePVPHonor") as LuaFunction);
					this.m_GetFriendshipPoints_hotfix = (luaObj.RawGet("GetFriendshipPoints") as LuaFunction);
					this.m_GetSkinTickets_hotfix = (luaObj.RawGet("GetSkinTickets") as LuaFunction);
					this.m_AddFriendshipPointsInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddFriendshipPoints") as LuaFunction);
					this.m_AddSkinTicketsInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddSkinTickets") as LuaFunction);
					this.m_AddMemoryEssenceInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddMemoryEssence") as LuaFunction);
					this.m_AddBrillianceMithralStoneInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddBrillianceMithralStone") as LuaFunction);
					this.m_AddMithralStoneInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddMithralStone") as LuaFunction);
					this.m_AddGuildMedalInt32GameFunctionTypeString_hotfix = (luaObj.RawGet("AddGuildMedal") as LuaFunction);
					this.m_IsGuildMedalEnoughInt32_hotfix = (luaObj.RawGet("IsGuildMedalEnough") as LuaFunction);
					this.m_IsFriendshipPointsEnoughInt32_hotfix = (luaObj.RawGet("IsFriendshipPointsEnough") as LuaFunction);
					this.m_IsArenaHonourEnoughInt32_hotfix = (luaObj.RawGet("IsArenaHonourEnough") as LuaFunction);
					this.m_IsRealTimePVPHonorEnoughInt32_hotfix = (luaObj.RawGet("IsRealTimePVPHonorEnough") as LuaFunction);
					this.m_IsSkinTicketEnoughInt32_hotfix = (luaObj.RawGet("IsSkinTicketEnough") as LuaFunction);
					this.m_IsMemoryEssenceEnoughInt32_hotfix = (luaObj.RawGet("IsMemoryEssenceEnough") as LuaFunction);
					this.m_CanSetUserGuideList`1_hotfix = (luaObj.RawGet("CanSetUserGuide") as LuaFunction);
					this.m_SetUserGuideList`1_hotfix = (luaObj.RawGet("SetUserGuide") as LuaFunction);
					this.m_CleanUserGuideList`1_hotfix = (luaObj.RawGet("CleanUserGuide") as LuaFunction);
					this.m_CompleteAllUserGuides_hotfix = (luaObj.RawGet("CompleteAllUserGuides") as LuaFunction);
					this.m_IsUserGuideCompletedInt32_hotfix = (luaObj.RawGet("IsUserGuideCompleted") as LuaFunction);
					this.m_GetLevel_hotfix = (luaObj.RawGet("GetLevel") as LuaFunction);
					this.m_GetRechargedCrystal_hotfix = (luaObj.RawGet("GetRechargedCrystal") as LuaFunction);
					this.m_GetCrystal_hotfix = (luaObj.RawGet("GetCrystal") as LuaFunction);
					this.m_CheckRankingListAddPlayerLevel_hotfix = (luaObj.RawGet("CheckRankingListAddPlayerLevel") as LuaFunction);
					this.m_CreateRankingPlayerInfoInt32_hotfix = (luaObj.RawGet("CreateRankingPlayerInfo") as LuaFunction);
					this.m_OnRankingListPlayerInfoChange_hotfix = (luaObj.RawGet("OnRankingListPlayerInfoChange") as LuaFunction);
					this.m_OpenGameRating_hotfix = (luaObj.RawGet("OpenGameRating") as LuaFunction);
					this.m_IsOpenGameRating_hotfix = (luaObj.RawGet("IsOpenGameRating") as LuaFunction);
					this.m_SetMemoryStoreOpenStatusBoolean_hotfix = (luaObj.RawGet("SetMemoryStoreOpenStatus") as LuaFunction);
					this.m_IsMemoryStoreOpen_hotfix = (luaObj.RawGet("IsMemoryStoreOpen") as LuaFunction);
					this.m_GetLevelUpAddEnergyFromConfig_hotfix = (luaObj.RawGet("GetLevelUpAddEnergyFromConfig") as LuaFunction);
					this.m_GetNextLevelExpFromConfig_hotfix = (luaObj.RawGet("GetNextLevelExpFromConfig") as LuaFunction);
					this.m_CanSetHeadPortraitAndHeadFrameInt32Int32_hotfix = (luaObj.RawGet("CanSetHeadPortraitAndHeadFrame") as LuaFunction);
					this.m_SetHeadPortraitAndHeadFrameInt32Int32_hotfix = (luaObj.RawGet("SetHeadPortraitAndHeadFrame") as LuaFunction);
					this.m_CanSetHeadPortraitInt32_hotfix = (luaObj.RawGet("CanSetHeadPortrait") as LuaFunction);
					this.m_SetHeadPortraitInt32_hotfix = (luaObj.RawGet("SetHeadPortrait") as LuaFunction);
					this.m_CanSetHeadFrameInt32_hotfix = (luaObj.RawGet("CanSetHeadFrame") as LuaFunction);
					this.m_SetHeadFrameInt32_hotfix = (luaObj.RawGet("SetHeadFrame") as LuaFunction);
					this.m_OnHeadIconChange_hotfix = (luaObj.RawGet("OnHeadIconChange") as LuaFunction);
					this.m_CanChangePlayerNameString_hotfix = (luaObj.RawGet("CanChangePlayerName") as LuaFunction);
					this.m_ChangePlayerNameString_hotfix = (luaObj.RawGet("ChangePlayerName") as LuaFunction);
					this.m_TryChangePlayerNameString_hotfix = (luaObj.RawGet("TryChangePlayerName") as LuaFunction);
					this.m_CheckPlayerNameString_hotfix = (luaObj.RawGet("CheckPlayerName") as LuaFunction);
					this.m_DoShare_hotfix = (luaObj.RawGet("DoShare") as LuaFunction);
					this.m_add_LevelUpPlayerLevelEventAction`1_hotfix = (luaObj.RawGet("add_LevelUpPlayerLevelEvent") as LuaFunction);
					this.m_remove_LevelUpPlayerLevelEventAction`1_hotfix = (luaObj.RawGet("remove_LevelUpPlayerLevelEvent") as LuaFunction);
					this.m_add_ConsumeEnergyMissionEventAction`1_hotfix = (luaObj.RawGet("add_ConsumeEnergyMissionEvent") as LuaFunction);
					this.m_remove_ConsumeEnergyMissionEventAction`1_hotfix = (luaObj.RawGet("remove_ConsumeEnergyMissionEvent") as LuaFunction);
					this.m_add_ConsumeGoldMissionEventAction`1_hotfix = (luaObj.RawGet("add_ConsumeGoldMissionEvent") as LuaFunction);
					this.m_remove_ConsumeGoldMissionEventAction`1_hotfix = (luaObj.RawGet("remove_ConsumeGoldMissionEvent") as LuaFunction);
					this.m_add_ConsumeCrystalMissionEventAction`1_hotfix = (luaObj.RawGet("add_ConsumeCrystalMissionEvent") as LuaFunction);
					this.m_remove_ConsumeCrystalMissionEventAction`1_hotfix = (luaObj.RawGet("remove_ConsumeCrystalMissionEvent") as LuaFunction);
					this.m_add_LevelUpPlayerLevelMissionEventAction`1_hotfix = (luaObj.RawGet("add_LevelUpPlayerLevelMissionEvent") as LuaFunction);
					this.m_remove_LevelUpPlayerLevelMissionEventAction`1_hotfix = (luaObj.RawGet("remove_LevelUpPlayerLevelMissionEvent") as LuaFunction);
					this.m_add_AddBuyEnergyMissionEventAction`1_hotfix = (luaObj.RawGet("add_AddBuyEnergyMissionEvent") as LuaFunction);
					this.m_remove_AddBuyEnergyMissionEventAction`1_hotfix = (luaObj.RawGet("remove_AddBuyEnergyMissionEvent") as LuaFunction);
					this.m_add_PlayerActionFlushEventAction_hotfix = (luaObj.RawGet("add_PlayerActionFlushEvent") as LuaFunction);
					this.m_remove_PlayerActionFlushEventAction_hotfix = (luaObj.RawGet("remove_PlayerActionFlushEvent") as LuaFunction);
					this.m_add_ConsumeFriendshipPointsEventAction`1_hotfix = (luaObj.RawGet("add_ConsumeFriendshipPointsEvent") as LuaFunction);
					this.m_remove_ConsumeFriendshipPointsEventAction`1_hotfix = (luaObj.RawGet("remove_ConsumeFriendshipPointsEvent") as LuaFunction);
					this.m_add_SetHeadIconEventAction`1_hotfix = (luaObj.RawGet("add_SetHeadIconEvent") as LuaFunction);
					this.m_remove_SetHeadIconEventAction`1_hotfix = (luaObj.RawGet("remove_SetHeadIconEvent") as LuaFunction);
					this.m_add_AddRechargeRMBEventAction`2_hotfix = (luaObj.RawGet("add_AddRechargeRMBEvent") as LuaFunction);
					this.m_remove_AddRechargeRMBEventAction`2_hotfix = (luaObj.RawGet("remove_AddRechargeRMBEvent") as LuaFunction);
					this.m_add_DoShareEventAction_hotfix = (luaObj.RawGet("add_DoShareEvent") as LuaFunction);
					this.m_remove_DoShareEventAction_hotfix = (luaObj.RawGet("remove_DoShareEvent") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x060046EC RID: 18156 RVA: 0x0015E074 File Offset: 0x0015C274
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(PlayerBasicInfoComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x0400352D RID: 13613
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x0400352E RID: 13614
		protected LevelComponentCommon m_level;

		// Token: 0x0400352F RID: 13615
		protected BagComponentCommon m_bag;

		// Token: 0x04003530 RID: 13616
		protected MissionComponentCommon m_mission;

		// Token: 0x04003531 RID: 13617
		protected RiftComponentCommon m_rift;

		// Token: 0x04003532 RID: 13618
		protected HeroComponentCommon m_hero;

		// Token: 0x04003533 RID: 13619
		protected ThearchyTrialCompomentCommon m_thearchyTrial;

		// Token: 0x04003534 RID: 13620
		protected ResourceComponentCommon m_resource;

		// Token: 0x04003535 RID: 13621
		protected GuildComponentCommon m_guild;

		// Token: 0x04003536 RID: 13622
		protected List<BagItemBase> m_changedGoods;

		// Token: 0x04003538 RID: 13624
		public DataSectionPlayerBasicInfo m_playerBasicDS = new DataSectionPlayerBasicInfo();

		// Token: 0x04003543 RID: 13635
		[DoNotToLua]
		private PlayerBasicInfoComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003544 RID: 13636
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003545 RID: 13637
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003546 RID: 13638
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003547 RID: 13639
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003548 RID: 13640
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003549 RID: 13641
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400354A RID: 13642
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400354B RID: 13643
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x0400354C RID: 13644
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x0400354D RID: 13645
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x0400354E RID: 13646
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x0400354F RID: 13647
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x04003550 RID: 13648
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x04003551 RID: 13649
		private LuaFunction m_TryUpdateSignedDays_hotfix;

		// Token: 0x04003552 RID: 13650
		private LuaFunction m_GetGameFunctionOpenInfoGameFunctionType_hotfix;

		// Token: 0x04003553 RID: 13651
		private LuaFunction m_IsGameFunctionOpenedGameFunctionType_hotfix;

		// Token: 0x04003554 RID: 13652
		private LuaFunction m_GetCreateTime_hotfix;

		// Token: 0x04003555 RID: 13653
		private LuaFunction m_GetCreateTimeUtc_hotfix;

		// Token: 0x04003556 RID: 13654
		private LuaFunction m_GetLastLogoutTime_hotfix;

		// Token: 0x04003557 RID: 13655
		private LuaFunction m_GetLoginTime_hotfix;

		// Token: 0x04003558 RID: 13656
		private LuaFunction m_GetPlayerName_hotfix;

		// Token: 0x04003559 RID: 13657
		private LuaFunction m_GetUserId_hotfix;

		// Token: 0x0400355A RID: 13658
		private LuaFunction m_IsMeString_hotfix;

		// Token: 0x0400355B RID: 13659
		private LuaFunction m_GetCurrentLevelExp_hotfix;

		// Token: 0x0400355C RID: 13660
		private LuaFunction m_GetRechargedCsystal_hotfix;

		// Token: 0x0400355D RID: 13661
		private LuaFunction m_GetRechargeRMB_hotfix;

		// Token: 0x0400355E RID: 13662
		private LuaFunction m_GetHeadIcon_hotfix;

		// Token: 0x0400355F RID: 13663
		private LuaFunction m_GetDefaultHeadIcon_hotfix;

		// Token: 0x04003560 RID: 13664
		private LuaFunction m_GetHeadPortrait_hotfix;

		// Token: 0x04003561 RID: 13665
		private LuaFunction m_GetHeadFrame_hotfix;

		// Token: 0x04003562 RID: 13666
		private LuaFunction m_IsPlayerLevelMax_hotfix;

		// Token: 0x04003563 RID: 13667
		private LuaFunction m_CanAddPlayerExp_hotfix;

		// Token: 0x04003564 RID: 13668
		private LuaFunction m_AddPlayerExpInt32_hotfix;

		// Token: 0x04003565 RID: 13669
		private LuaFunction m_OnLevelChangeInt32Int32_hotfix;

		// Token: 0x04003566 RID: 13670
		private LuaFunction m_LevelUp_hotfix;

		// Token: 0x04003567 RID: 13671
		private LuaFunction m_AddGoldInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003568 RID: 13672
		private LuaFunction m_IsGoldEnoughInt32_hotfix;

		// Token: 0x04003569 RID: 13673
		private LuaFunction m_IsGoldOverFlowInt32_hotfix;

		// Token: 0x0400356A RID: 13674
		private LuaFunction m_GetGold_hotfix;

		// Token: 0x0400356B RID: 13675
		private LuaFunction m_AddBrillianceMithralStoneInt32_hotfix;

		// Token: 0x0400356C RID: 13676
		private LuaFunction m_AddMithralStoneInt32_hotfix;

		// Token: 0x0400356D RID: 13677
		private LuaFunction m_IsMithralStoneEnoughInt32_hotfix;

		// Token: 0x0400356E RID: 13678
		private LuaFunction m_IsBrillianceMithralStoneEnoughInt32_hotfix;

		// Token: 0x0400356F RID: 13679
		private LuaFunction m_IsCurrencyEnoughGoodsTypeInt32_hotfix;

		// Token: 0x04003570 RID: 13680
		private LuaFunction m_AddCurrencyGoodsTypeInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003571 RID: 13681
		private LuaFunction m_AddRechargeRMBInt32DateTimeBoolean_hotfix;

		// Token: 0x04003572 RID: 13682
		private LuaFunction m_AddCrystalInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003573 RID: 13683
		private LuaFunction m_IsCrystalEnoughInt32_hotfix;

		// Token: 0x04003574 RID: 13684
		private LuaFunction m_InitEnergyInt64_hotfix;

		// Token: 0x04003575 RID: 13685
		private LuaFunction m_IsReachEnergyMaxInt64_hotfix;

		// Token: 0x04003576 RID: 13686
		private LuaFunction m_FlushEnergy_hotfix;

		// Token: 0x04003577 RID: 13687
		private LuaFunction m_CanFlushEnergy_hotfix;

		// Token: 0x04003578 RID: 13688
		private LuaFunction m_CanFlushPlayerAction_hotfix;

		// Token: 0x04003579 RID: 13689
		private LuaFunction m_ResetPlayerActionNextFlushTime_hotfix;

		// Token: 0x0400357A RID: 13690
		private LuaFunction m_IncreamentEnergyInt64BooleanGameFunctionTypeString_hotfix;

		// Token: 0x0400357B RID: 13691
		private LuaFunction m_DecreaseEnergyInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400357C RID: 13692
		private LuaFunction m_IsEnergyEnoughInt32_hotfix;

		// Token: 0x0400357D RID: 13693
		private LuaFunction m_GetEnergy_hotfix;

		// Token: 0x0400357E RID: 13694
		private LuaFunction m_GetCurrentTime_hotfix;

		// Token: 0x0400357F RID: 13695
		private LuaFunction m_IsSigned_hotfix;

		// Token: 0x04003580 RID: 13696
		private LuaFunction m_CanSignToday_hotfix;

		// Token: 0x04003581 RID: 13697
		private LuaFunction m_CanBuyEnergy_hotfix;

		// Token: 0x04003582 RID: 13698
		private LuaFunction m_GetBuyEnergyConfig_hotfix;

		// Token: 0x04003583 RID: 13699
		private LuaFunction m_IsBoughtNumsUsedOut_hotfix;

		// Token: 0x04003584 RID: 13700
		private LuaFunction m_BuyEnergy_hotfix;

		// Token: 0x04003585 RID: 13701
		private LuaFunction m_CanBuyArenaTickets_hotfix;

		// Token: 0x04003586 RID: 13702
		private LuaFunction m_GetBuyArenaTicketConfig_hotfix;

		// Token: 0x04003587 RID: 13703
		private LuaFunction m_BuyArenaTickets_hotfix;

		// Token: 0x04003588 RID: 13704
		private LuaFunction m_GetNextFlushPlayerActionTime_hotfix;

		// Token: 0x04003589 RID: 13705
		private LuaFunction m_FlushPlayerAction_hotfix;

		// Token: 0x0400358A RID: 13706
		private LuaFunction m_OnPlayerActionFlushEvent_hotfix;

		// Token: 0x0400358B RID: 13707
		private LuaFunction m_OnFlush_hotfix;

		// Token: 0x0400358C RID: 13708
		private LuaFunction m_IsArenaTicketsEnoughInt32_hotfix;

		// Token: 0x0400358D RID: 13709
		private LuaFunction m_IsArenaTicketsFull_hotfix;

		// Token: 0x0400358E RID: 13710
		private LuaFunction m_AddArenaTicketsInt32BooleanGameFunctionTypeString_hotfix;

		// Token: 0x0400358F RID: 13711
		private LuaFunction m_GetAreanaTicketNums_hotfix;

		// Token: 0x04003590 RID: 13712
		private LuaFunction m_AddRechargedCrystalInt32_hotfix;

		// Token: 0x04003591 RID: 13713
		private LuaFunction m_AddArenaHonourInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003592 RID: 13714
		private LuaFunction m_GetArenaHonour_hotfix;

		// Token: 0x04003593 RID: 13715
		private LuaFunction m_AddRealTimePVPHonorInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003594 RID: 13716
		private LuaFunction m_GetRealTimePVPHonor_hotfix;

		// Token: 0x04003595 RID: 13717
		private LuaFunction m_GetFriendshipPoints_hotfix;

		// Token: 0x04003596 RID: 13718
		private LuaFunction m_GetSkinTickets_hotfix;

		// Token: 0x04003597 RID: 13719
		private LuaFunction m_AddFriendshipPointsInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003598 RID: 13720
		private LuaFunction m_AddSkinTicketsInt32GameFunctionTypeString_hotfix;

		// Token: 0x04003599 RID: 13721
		private LuaFunction m_AddMemoryEssenceInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400359A RID: 13722
		private LuaFunction m_AddBrillianceMithralStoneInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400359B RID: 13723
		private LuaFunction m_AddMithralStoneInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400359C RID: 13724
		private LuaFunction m_AddGuildMedalInt32GameFunctionTypeString_hotfix;

		// Token: 0x0400359D RID: 13725
		private LuaFunction m_IsGuildMedalEnoughInt32_hotfix;

		// Token: 0x0400359E RID: 13726
		private LuaFunction m_IsFriendshipPointsEnoughInt32_hotfix;

		// Token: 0x0400359F RID: 13727
		private LuaFunction m_IsArenaHonourEnoughInt32_hotfix;

		// Token: 0x040035A0 RID: 13728
		private LuaFunction m_IsRealTimePVPHonorEnoughInt32_hotfix;

		// Token: 0x040035A1 RID: 13729
		private LuaFunction m_IsSkinTicketEnoughInt32_hotfix;

		// Token: 0x040035A2 RID: 13730
		private LuaFunction m_IsMemoryEssenceEnoughInt32_hotfix;

		// Token: 0x040035A3 RID: 13731
		private LuaFunction m_CanSetUserGuideList;

		// Token: 0x040035A4 RID: 13732
		private LuaFunction m_SetUserGuideList;

		// Token: 0x040035A5 RID: 13733
		private LuaFunction m_CleanUserGuideList;

		// Token: 0x040035A6 RID: 13734
		private LuaFunction m_CompleteAllUserGuides_hotfix;

		// Token: 0x040035A7 RID: 13735
		private LuaFunction m_IsUserGuideCompletedInt32_hotfix;

		// Token: 0x040035A8 RID: 13736
		private LuaFunction m_GetLevel_hotfix;

		// Token: 0x040035A9 RID: 13737
		private LuaFunction m_GetRechargedCrystal_hotfix;

		// Token: 0x040035AA RID: 13738
		private LuaFunction m_GetCrystal_hotfix;

		// Token: 0x040035AB RID: 13739
		private LuaFunction m_CheckRankingListAddPlayerLevel_hotfix;

		// Token: 0x040035AC RID: 13740
		private LuaFunction m_CreateRankingPlayerInfoInt32_hotfix;

		// Token: 0x040035AD RID: 13741
		private LuaFunction m_OnRankingListPlayerInfoChange_hotfix;

		// Token: 0x040035AE RID: 13742
		private LuaFunction m_OpenGameRating_hotfix;

		// Token: 0x040035AF RID: 13743
		private LuaFunction m_IsOpenGameRating_hotfix;

		// Token: 0x040035B0 RID: 13744
		private LuaFunction m_SetMemoryStoreOpenStatusBoolean_hotfix;

		// Token: 0x040035B1 RID: 13745
		private LuaFunction m_IsMemoryStoreOpen_hotfix;

		// Token: 0x040035B2 RID: 13746
		private LuaFunction m_GetLevelUpAddEnergyFromConfig_hotfix;

		// Token: 0x040035B3 RID: 13747
		private LuaFunction m_GetNextLevelExpFromConfig_hotfix;

		// Token: 0x040035B4 RID: 13748
		private LuaFunction m_CanSetHeadPortraitAndHeadFrameInt32Int32_hotfix;

		// Token: 0x040035B5 RID: 13749
		private LuaFunction m_SetHeadPortraitAndHeadFrameInt32Int32_hotfix;

		// Token: 0x040035B6 RID: 13750
		private LuaFunction m_CanSetHeadPortraitInt32_hotfix;

		// Token: 0x040035B7 RID: 13751
		private LuaFunction m_SetHeadPortraitInt32_hotfix;

		// Token: 0x040035B8 RID: 13752
		private LuaFunction m_CanSetHeadFrameInt32_hotfix;

		// Token: 0x040035B9 RID: 13753
		private LuaFunction m_SetHeadFrameInt32_hotfix;

		// Token: 0x040035BA RID: 13754
		private LuaFunction m_OnHeadIconChange_hotfix;

		// Token: 0x040035BB RID: 13755
		private LuaFunction m_CanChangePlayerNameString_hotfix;

		// Token: 0x040035BC RID: 13756
		private LuaFunction m_ChangePlayerNameString_hotfix;

		// Token: 0x040035BD RID: 13757
		private LuaFunction m_TryChangePlayerNameString_hotfix;

		// Token: 0x040035BE RID: 13758
		private LuaFunction m_CheckPlayerNameString_hotfix;

		// Token: 0x040035BF RID: 13759
		private LuaFunction m_DoShare_hotfix;

		// Token: 0x040035C0 RID: 13760
		private LuaFunction m_add_LevelUpPlayerLevelEventAction;

		// Token: 0x040035C1 RID: 13761
		private LuaFunction m_remove_LevelUpPlayerLevelEventAction;

		// Token: 0x040035C2 RID: 13762
		private LuaFunction m_add_ConsumeEnergyMissionEventAction;

		// Token: 0x040035C3 RID: 13763
		private LuaFunction m_remove_ConsumeEnergyMissionEventAction;

		// Token: 0x040035C4 RID: 13764
		private LuaFunction m_add_ConsumeGoldMissionEventAction;

		// Token: 0x040035C5 RID: 13765
		private LuaFunction m_remove_ConsumeGoldMissionEventAction;

		// Token: 0x040035C6 RID: 13766
		private LuaFunction m_add_ConsumeCrystalMissionEventAction;

		// Token: 0x040035C7 RID: 13767
		private LuaFunction m_remove_ConsumeCrystalMissionEventAction;

		// Token: 0x040035C8 RID: 13768
		private LuaFunction m_add_LevelUpPlayerLevelMissionEventAction;

		// Token: 0x040035C9 RID: 13769
		private LuaFunction m_remove_LevelUpPlayerLevelMissionEventAction;

		// Token: 0x040035CA RID: 13770
		private LuaFunction m_add_AddBuyEnergyMissionEventAction;

		// Token: 0x040035CB RID: 13771
		private LuaFunction m_remove_AddBuyEnergyMissionEventAction;

		// Token: 0x040035CC RID: 13772
		private LuaFunction m_add_PlayerActionFlushEventAction_hotfix;

		// Token: 0x040035CD RID: 13773
		private LuaFunction m_remove_PlayerActionFlushEventAction_hotfix;

		// Token: 0x040035CE RID: 13774
		private LuaFunction m_add_ConsumeFriendshipPointsEventAction;

		// Token: 0x040035CF RID: 13775
		private LuaFunction m_remove_ConsumeFriendshipPointsEventAction;

		// Token: 0x040035D0 RID: 13776
		private LuaFunction m_add_SetHeadIconEventAction;

		// Token: 0x040035D1 RID: 13777
		private LuaFunction m_remove_SetHeadIconEventAction;

		// Token: 0x040035D2 RID: 13778
		private LuaFunction m_add_AddRechargeRMBEventAction;

		// Token: 0x040035D3 RID: 13779
		private LuaFunction m_remove_AddRechargeRMBEventAction;

		// Token: 0x040035D4 RID: 13780
		private LuaFunction m_add_DoShareEventAction_hotfix;

		// Token: 0x040035D5 RID: 13781
		private LuaFunction m_remove_DoShareEventAction_hotfix;

		// Token: 0x02000496 RID: 1174
		public class LuaExportHelper
		{
			// Token: 0x060046ED RID: 18157 RVA: 0x0015E0DC File Offset: 0x0015C2DC
			public LuaExportHelper(PlayerBasicInfoComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x060046EE RID: 18158 RVA: 0x0015E0EC File Offset: 0x0015C2EC
			public void __callDele_LevelUpPlayerLevelEvent(int obj)
			{
				this.m_owner.__callDele_LevelUpPlayerLevelEvent(obj);
			}

			// Token: 0x060046EF RID: 18159 RVA: 0x0015E0FC File Offset: 0x0015C2FC
			public void __clearDele_LevelUpPlayerLevelEvent(int obj)
			{
				this.m_owner.__clearDele_LevelUpPlayerLevelEvent(obj);
			}

			// Token: 0x060046F0 RID: 18160 RVA: 0x0015E10C File Offset: 0x0015C30C
			public void __callDele_ConsumeEnergyMissionEvent(int obj)
			{
				this.m_owner.__callDele_ConsumeEnergyMissionEvent(obj);
			}

			// Token: 0x060046F1 RID: 18161 RVA: 0x0015E11C File Offset: 0x0015C31C
			public void __clearDele_ConsumeEnergyMissionEvent(int obj)
			{
				this.m_owner.__clearDele_ConsumeEnergyMissionEvent(obj);
			}

			// Token: 0x060046F2 RID: 18162 RVA: 0x0015E12C File Offset: 0x0015C32C
			public void __callDele_ConsumeGoldMissionEvent(int obj)
			{
				this.m_owner.__callDele_ConsumeGoldMissionEvent(obj);
			}

			// Token: 0x060046F3 RID: 18163 RVA: 0x0015E13C File Offset: 0x0015C33C
			public void __clearDele_ConsumeGoldMissionEvent(int obj)
			{
				this.m_owner.__clearDele_ConsumeGoldMissionEvent(obj);
			}

			// Token: 0x060046F4 RID: 18164 RVA: 0x0015E14C File Offset: 0x0015C34C
			public void __callDele_ConsumeCrystalMissionEvent(int obj)
			{
				this.m_owner.__callDele_ConsumeCrystalMissionEvent(obj);
			}

			// Token: 0x060046F5 RID: 18165 RVA: 0x0015E15C File Offset: 0x0015C35C
			public void __clearDele_ConsumeCrystalMissionEvent(int obj)
			{
				this.m_owner.__clearDele_ConsumeCrystalMissionEvent(obj);
			}

			// Token: 0x060046F6 RID: 18166 RVA: 0x0015E16C File Offset: 0x0015C36C
			public void __callDele_LevelUpPlayerLevelMissionEvent(int obj)
			{
				this.m_owner.__callDele_LevelUpPlayerLevelMissionEvent(obj);
			}

			// Token: 0x060046F7 RID: 18167 RVA: 0x0015E17C File Offset: 0x0015C37C
			public void __clearDele_LevelUpPlayerLevelMissionEvent(int obj)
			{
				this.m_owner.__clearDele_LevelUpPlayerLevelMissionEvent(obj);
			}

			// Token: 0x060046F8 RID: 18168 RVA: 0x0015E18C File Offset: 0x0015C38C
			public void __callDele_AddBuyEnergyMissionEvent(int obj)
			{
				this.m_owner.__callDele_AddBuyEnergyMissionEvent(obj);
			}

			// Token: 0x060046F9 RID: 18169 RVA: 0x0015E19C File Offset: 0x0015C39C
			public void __clearDele_AddBuyEnergyMissionEvent(int obj)
			{
				this.m_owner.__clearDele_AddBuyEnergyMissionEvent(obj);
			}

			// Token: 0x060046FA RID: 18170 RVA: 0x0015E1AC File Offset: 0x0015C3AC
			public void __callDele_PlayerActionFlushEvent()
			{
				this.m_owner.__callDele_PlayerActionFlushEvent();
			}

			// Token: 0x060046FB RID: 18171 RVA: 0x0015E1BC File Offset: 0x0015C3BC
			public void __clearDele_PlayerActionFlushEvent()
			{
				this.m_owner.__clearDele_PlayerActionFlushEvent();
			}

			// Token: 0x060046FC RID: 18172 RVA: 0x0015E1CC File Offset: 0x0015C3CC
			public void __callDele_ConsumeFriendshipPointsEvent(int obj)
			{
				this.m_owner.__callDele_ConsumeFriendshipPointsEvent(obj);
			}

			// Token: 0x060046FD RID: 18173 RVA: 0x0015E1DC File Offset: 0x0015C3DC
			public void __clearDele_ConsumeFriendshipPointsEvent(int obj)
			{
				this.m_owner.__clearDele_ConsumeFriendshipPointsEvent(obj);
			}

			// Token: 0x060046FE RID: 18174 RVA: 0x0015E1EC File Offset: 0x0015C3EC
			public void __callDele_SetHeadIconEvent(int obj)
			{
				this.m_owner.__callDele_SetHeadIconEvent(obj);
			}

			// Token: 0x060046FF RID: 18175 RVA: 0x0015E1FC File Offset: 0x0015C3FC
			public void __clearDele_SetHeadIconEvent(int obj)
			{
				this.m_owner.__clearDele_SetHeadIconEvent(obj);
			}

			// Token: 0x06004700 RID: 18176 RVA: 0x0015E20C File Offset: 0x0015C40C
			public void __callDele_AddRechargeRMBEvent(int arg1, DateTime arg2)
			{
				this.m_owner.__callDele_AddRechargeRMBEvent(arg1, arg2);
			}

			// Token: 0x06004701 RID: 18177 RVA: 0x0015E21C File Offset: 0x0015C41C
			public void __clearDele_AddRechargeRMBEvent(int arg1, DateTime arg2)
			{
				this.m_owner.__clearDele_AddRechargeRMBEvent(arg1, arg2);
			}

			// Token: 0x06004702 RID: 18178 RVA: 0x0015E22C File Offset: 0x0015C42C
			public void __callDele_DoShareEvent()
			{
				this.m_owner.__callDele_DoShareEvent();
			}

			// Token: 0x06004703 RID: 18179 RVA: 0x0015E23C File Offset: 0x0015C43C
			public void __clearDele_DoShareEvent()
			{
				this.m_owner.__clearDele_DoShareEvent();
			}

			// Token: 0x170011E3 RID: 4579
			// (get) Token: 0x06004704 RID: 18180 RVA: 0x0015E24C File Offset: 0x0015C44C
			// (set) Token: 0x06004705 RID: 18181 RVA: 0x0015E25C File Offset: 0x0015C45C
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

			// Token: 0x170011E4 RID: 4580
			// (get) Token: 0x06004706 RID: 18182 RVA: 0x0015E26C File Offset: 0x0015C46C
			// (set) Token: 0x06004707 RID: 18183 RVA: 0x0015E27C File Offset: 0x0015C47C
			public LevelComponentCommon m_level
			{
				get
				{
					return this.m_owner.m_level;
				}
				set
				{
					this.m_owner.m_level = value;
				}
			}

			// Token: 0x170011E5 RID: 4581
			// (get) Token: 0x06004708 RID: 18184 RVA: 0x0015E28C File Offset: 0x0015C48C
			// (set) Token: 0x06004709 RID: 18185 RVA: 0x0015E29C File Offset: 0x0015C49C
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

			// Token: 0x170011E6 RID: 4582
			// (get) Token: 0x0600470A RID: 18186 RVA: 0x0015E2AC File Offset: 0x0015C4AC
			// (set) Token: 0x0600470B RID: 18187 RVA: 0x0015E2BC File Offset: 0x0015C4BC
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

			// Token: 0x170011E7 RID: 4583
			// (get) Token: 0x0600470C RID: 18188 RVA: 0x0015E2CC File Offset: 0x0015C4CC
			// (set) Token: 0x0600470D RID: 18189 RVA: 0x0015E2DC File Offset: 0x0015C4DC
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

			// Token: 0x170011E8 RID: 4584
			// (get) Token: 0x0600470E RID: 18190 RVA: 0x0015E2EC File Offset: 0x0015C4EC
			// (set) Token: 0x0600470F RID: 18191 RVA: 0x0015E2FC File Offset: 0x0015C4FC
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

			// Token: 0x170011E9 RID: 4585
			// (get) Token: 0x06004710 RID: 18192 RVA: 0x0015E30C File Offset: 0x0015C50C
			// (set) Token: 0x06004711 RID: 18193 RVA: 0x0015E31C File Offset: 0x0015C51C
			public ThearchyTrialCompomentCommon m_thearchyTrial
			{
				get
				{
					return this.m_owner.m_thearchyTrial;
				}
				set
				{
					this.m_owner.m_thearchyTrial = value;
				}
			}

			// Token: 0x170011EA RID: 4586
			// (get) Token: 0x06004712 RID: 18194 RVA: 0x0015E32C File Offset: 0x0015C52C
			// (set) Token: 0x06004713 RID: 18195 RVA: 0x0015E33C File Offset: 0x0015C53C
			public ResourceComponentCommon m_resource
			{
				get
				{
					return this.m_owner.m_resource;
				}
				set
				{
					this.m_owner.m_resource = value;
				}
			}

			// Token: 0x170011EB RID: 4587
			// (get) Token: 0x06004714 RID: 18196 RVA: 0x0015E34C File Offset: 0x0015C54C
			// (set) Token: 0x06004715 RID: 18197 RVA: 0x0015E35C File Offset: 0x0015C55C
			public GuildComponentCommon m_guild
			{
				get
				{
					return this.m_owner.m_guild;
				}
				set
				{
					this.m_owner.m_guild = value;
				}
			}

			// Token: 0x170011EC RID: 4588
			// (get) Token: 0x06004716 RID: 18198 RVA: 0x0015E36C File Offset: 0x0015C56C
			// (set) Token: 0x06004717 RID: 18199 RVA: 0x0015E37C File Offset: 0x0015C57C
			public List<BagItemBase> m_changedGoods
			{
				get
				{
					return this.m_owner.m_changedGoods;
				}
				set
				{
					this.m_owner.m_changedGoods = value;
				}
			}

			// Token: 0x06004718 RID: 18200 RVA: 0x0015E38C File Offset: 0x0015C58C
			public void TryUpdateSignedDays()
			{
				this.m_owner.TryUpdateSignedDays();
			}

			// Token: 0x06004719 RID: 18201 RVA: 0x0015E39C File Offset: 0x0015C59C
			public ConfigDataGameFunctionOpenInfo GetGameFunctionOpenInfo(GameFunctionType gameFunctionType)
			{
				return this.m_owner.GetGameFunctionOpenInfo(gameFunctionType);
			}

			// Token: 0x0600471A RID: 18202 RVA: 0x0015E3AC File Offset: 0x0015C5AC
			public bool CanAddPlayerExp()
			{
				return this.m_owner.CanAddPlayerExp();
			}

			// Token: 0x0600471B RID: 18203 RVA: 0x0015E3BC File Offset: 0x0015C5BC
			public void OnLevelChange(int upLevel, int addExp)
			{
				this.m_owner.OnLevelChange(upLevel, addExp);
			}

			// Token: 0x0600471C RID: 18204 RVA: 0x0015E3CC File Offset: 0x0015C5CC
			public void LevelUp()
			{
				this.m_owner.LevelUp();
			}

			// Token: 0x0600471D RID: 18205 RVA: 0x0015E3DC File Offset: 0x0015C5DC
			public void InitEnergy(long secondPast)
			{
				this.m_owner.InitEnergy(secondPast);
			}

			// Token: 0x0600471E RID: 18206 RVA: 0x0015E3EC File Offset: 0x0015C5EC
			public ConfigDataBuyEnergyInfo GetBuyEnergyConfig()
			{
				return this.m_owner.GetBuyEnergyConfig();
			}

			// Token: 0x0600471F RID: 18207 RVA: 0x0015E3FC File Offset: 0x0015C5FC
			public bool IsBoughtNumsUsedOut()
			{
				return this.m_owner.IsBoughtNumsUsedOut();
			}

			// Token: 0x06004720 RID: 18208 RVA: 0x0015E40C File Offset: 0x0015C60C
			public ConfigDataBuyArenaTicketInfo GetBuyArenaTicketConfig()
			{
				return this.m_owner.GetBuyArenaTicketConfig();
			}

			// Token: 0x06004721 RID: 18209 RVA: 0x0015E41C File Offset: 0x0015C61C
			public void OnPlayerActionFlushEvent()
			{
				this.m_owner.OnPlayerActionFlushEvent();
			}

			// Token: 0x06004722 RID: 18210 RVA: 0x0015E42C File Offset: 0x0015C62C
			public void OnFlush()
			{
				this.m_owner.OnFlush();
			}

			// Token: 0x06004723 RID: 18211 RVA: 0x0015E43C File Offset: 0x0015C63C
			public void OnHeadIconChange()
			{
				this.m_owner.OnHeadIconChange();
			}

			// Token: 0x06004724 RID: 18212 RVA: 0x0015E44C File Offset: 0x0015C64C
			public int TryChangePlayerName(string newName)
			{
				return this.m_owner.TryChangePlayerName(newName);
			}

			// Token: 0x040035D6 RID: 13782
			private PlayerBasicInfoComponentCommon m_owner;
		}
	}
}
