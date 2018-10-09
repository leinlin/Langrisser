using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.Common
{
	// Token: 0x020004AC RID: 1196
	[HotFix]
	public class TeamComponentCommon : IComponentBase
	{
		// Token: 0x060048E4 RID: 18660 RVA: 0x0016A184 File Offset: 0x00168384
		public TeamComponentCommon()
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

		// Token: 0x060048E5 RID: 18661 RVA: 0x0016A1F8 File Offset: 0x001683F8
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
			return "Team";
		}

		// Token: 0x060048E6 RID: 18662 RVA: 0x0016A26C File Offset: 0x0016846C
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

		// Token: 0x060048E7 RID: 18663 RVA: 0x0016A2CC File Offset: 0x001684CC
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
			this.m_anikiGym = (this.Owner.GetOwnerComponent("AnikiGym") as AnikiGymComponentCommon);
			this.m_memoryCorridor = (this.Owner.GetOwnerComponent("MemoryCorridor") as MemoryCorridorCompomentCommon);
			this.m_thearchyTrial = (this.Owner.GetOwnerComponent("ThearchyTrail") as ThearchyTrialCompomentCommon);
			this.m_basicInfo = (this.Owner.GetOwnerComponent("PlayerBasicInfo") as PlayerBasicInfoComponentCommon);
			this.m_heroTrainning = (this.Owner.GetOwnerComponent("HeroTrainning") as HeroTrainningComponentCommon);
			this.m_cooperateBattle = (this.Owner.GetOwnerComponent("CooperateBattle") as CooperateBattleCompomentCommon);
			this.m_battle = (this.Owner.GetOwnerComponent("Battle") as BattleComponentCommon);
			this.m_unchartedScore = (this.Owner.GetOwnerComponent("UnchartedScore") as UnchartedScoreComponentCommon);
		}

		// Token: 0x060048E8 RID: 18664 RVA: 0x0016A420 File Offset: 0x00168620
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

		// Token: 0x060048E9 RID: 18665 RVA: 0x0016A480 File Offset: 0x00168680
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

		// Token: 0x060048EA RID: 18666 RVA: 0x0016A4F0 File Offset: 0x001686F0
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

		// Token: 0x060048EB RID: 18667 RVA: 0x0016A570 File Offset: 0x00168770
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

		// Token: 0x060048EC RID: 18668 RVA: 0x0016A5E0 File Offset: 0x001687E0
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

		// Token: 0x17001225 RID: 4645
		// (get) Token: 0x060048ED RID: 18669 RVA: 0x0016A640 File Offset: 0x00168840
		// (set) Token: 0x060048EE RID: 18670 RVA: 0x0016A6B4 File Offset: 0x001688B4
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

		// Token: 0x060048EF RID: 18671 RVA: 0x0016A72C File Offset: 0x0016892C
		public int IsLevelUnlocked(GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsLevelUnlockedGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_IsLevelUnlockedGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (gameFunctionTypeId != GameFunctionType.GameFunctionType_AnikiGym)
			{
				if (gameFunctionTypeId != GameFunctionType.GameFunctionType_ThearchyTrial)
				{
					if (gameFunctionTypeId != GameFunctionType.GameFunctionType_MemoryCorridor)
					{
						if (gameFunctionTypeId != GameFunctionType.GameFunctionType_HeroTrainning)
						{
							if (gameFunctionTypeId != GameFunctionType.GameFunctionType_CooperateBattle)
							{
								if (gameFunctionTypeId != GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
								{
									return -3000;
								}
								if (!this.m_unchartedScore.IsScoreLevelUnlock(locationId))
								{
									return -3001;
								}
							}
							else if (!this.m_cooperateBattle.IsLevelUnlocked(locationId))
							{
								return -3001;
							}
						}
						else if (!this.m_heroTrainning.IsLevelUnlocked(locationId))
						{
							return -3001;
						}
					}
					else if (!this.m_memoryCorridor.IsLevelUnlocked(locationId))
					{
						return -3001;
					}
				}
				else if (!this.m_thearchyTrial.IsLevelUnlocked(locationId))
				{
					return -3001;
				}
			}
			else if (!this.m_anikiGym.IsLevelUnlocked(locationId))
			{
				return -3001;
			}
			return 0;
		}

		// Token: 0x060048F0 RID: 18672 RVA: 0x0016A89C File Offset: 0x00168A9C
		public int CanCreateTeam(ProTeamRoomSetting setting)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCreateTeamProTeamRoomSetting_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCreateTeamProTeamRoomSetting_hotfix.call(new object[]
				{
					this,
					setting
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsTeamRoomAuthorityValid(setting.Authority))
			{
				return -3010;
			}
			int joinMaxLevel = setting.JoinMaxLevel;
			int joinMinLevel = setting.JoinMinLevel;
			if (joinMaxLevel != 0 && this.m_configDataLoader.GetConfigDataPlayerLevelInfo(joinMaxLevel) == null)
			{
				return -3011;
			}
			if (joinMinLevel != 0 && this.m_configDataLoader.GetConfigDataPlayerLevelInfo(joinMinLevel) == null)
			{
				return -3011;
			}
			GameFunctionType gameFunctionTypeId = (GameFunctionType)setting.GameFunctionTypeId;
			int locationId = setting.LocationId;
			return this.CanJoinTeamRoom(gameFunctionTypeId, locationId);
		}

		// Token: 0x060048F1 RID: 18673 RVA: 0x0016A990 File Offset: 0x00168B90
		public void CreateTeam(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateTeamInt32GameFunctionTypeInt32_hotfix != null)
			{
				this.m_CreateTeamInt32GameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					roomId,
					gameFunctionTypeId,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.RoomId = roomId;
			this.m_teamDS.GameFunctionTypeId = gameFunctionTypeId;
			this.m_teamDS.LocationId = locationId;
		}

		// Token: 0x060048F2 RID: 18674 RVA: 0x0016AA44 File Offset: 0x00168C44
		private bool IsTeamRoomAuthorityValid(int authority)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTeamRoomAuthorityValidInt32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTeamRoomAuthorityValidInt32_hotfix.call(new object[]
				{
					this,
					authority
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return authority > 0 && authority < 100;
		}

		// Token: 0x060048F3 RID: 18675 RVA: 0x0016AAD0 File Offset: 0x00168CD0
		public int CanAttackTeamGameFunction(GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAttackTeamGameFunctionGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAttackTeamGameFunctionGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (gameFunctionTypeId == GameFunctionType.GameFunctionType_AnikiGym)
			{
				return this.m_anikiGym.CanAttackAnikiGymLevel(locationId, true);
			}
			if (gameFunctionTypeId == GameFunctionType.GameFunctionType_ThearchyTrial)
			{
				return this.m_thearchyTrial.CanAttackThearchyTrialLevel(locationId, true);
			}
			if (gameFunctionTypeId == GameFunctionType.GameFunctionType_MemoryCorridor)
			{
				return this.m_memoryCorridor.CanAttackMemoryCorridorLevel(locationId, true);
			}
			if (gameFunctionTypeId == GameFunctionType.GameFunctionType_HeroTrainning)
			{
				return this.m_heroTrainning.CanAttackHeroTrainningLevel(locationId, true);
			}
			if (gameFunctionTypeId == GameFunctionType.GameFunctionType_CooperateBattle)
			{
				return this.m_cooperateBattle.CanAttackCooperateBattleLevel(locationId);
			}
			if (gameFunctionTypeId != GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
			{
				return 0;
			}
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = this.m_configDataLoader.GetConfigDataScoreLevelInfo(locationId);
			if (configDataScoreLevelInfo == null)
			{
				return -5308;
			}
			return this.m_unchartedScore.CanAttackScoreLevel(configDataScoreLevelInfo.UnchartedScoreInfo.ID, locationId, true);
		}

		// Token: 0x060048F4 RID: 18676 RVA: 0x0016AC0C File Offset: 0x00168E0C
		public int CanViewTeamRoom(GameFunctionType gameFunctionTypeId, int chapterId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanViewTeamRoomGameFunctionTypeInt32Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanViewTeamRoomGameFunctionTypeInt32Int32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					chapterId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsInTeam())
			{
				return -3008;
			}
			if (gameFunctionTypeId != GameFunctionType.GameFunctionType_None)
			{
				if (gameFunctionTypeId != GameFunctionType.GameFunctionType_AnikiGym)
				{
					if (gameFunctionTypeId != GameFunctionType.GameFunctionType_ThearchyTrial)
					{
						if (gameFunctionTypeId != GameFunctionType.GameFunctionType_MemoryCorridor)
						{
							if (gameFunctionTypeId != GameFunctionType.GameFunctionType_HeroTrainning)
							{
								if (gameFunctionTypeId != GameFunctionType.GameFunctionType_CooperateBattle)
								{
									if (gameFunctionTypeId != GameFunctionType.GameFunctionType_UnchartedScoreScoreLevel)
									{
										return -3012;
									}
									if (this.m_configDataLoader.GetConfigDataUnchartedScoreInfo(chapterId) == null)
									{
										return -3027;
									}
								}
								else if (this.m_configDataLoader.GetConfigDataCooperateBattleInfo(chapterId) == null)
								{
									return -3027;
								}
							}
							else if (this.m_configDataLoader.GetConfigDataHeroTrainningInfo(chapterId) == null)
							{
								return -3027;
							}
						}
						else if (this.m_configDataLoader.GetConfigDataMemoryCorridorInfo(chapterId) == null)
						{
							return -3027;
						}
					}
					else if (this.m_configDataLoader.GetConfigDataThearchyTrialInfo(chapterId) == null)
					{
						return -3027;
					}
				}
				else if (this.m_configDataLoader.GetConfigDataAnikiGymInfo(chapterId) == null)
				{
					return -3027;
				}
				if (locationId != 0)
				{
					int num = this.IsLevelUnlocked(gameFunctionTypeId, locationId);
					if (num != 0)
					{
						return num;
					}
				}
			}
			return 0;
		}

		// Token: 0x060048F5 RID: 18677 RVA: 0x0016ADD0 File Offset: 0x00168FD0
		public int CanAutoMatchTeamRoom(GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanAutoMatchTeamRoomGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanAutoMatchTeamRoomGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.CanJoinTeamRoom(gameFunctionTypeId, locationId);
		}

		// Token: 0x060048F6 RID: 18678 RVA: 0x0016AE64 File Offset: 0x00169064
		public void AutoMatchTeamRoom(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoMatchTeamRoomInt32GameFunctionTypeInt32_hotfix != null)
			{
				this.m_AutoMatchTeamRoomInt32GameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					roomId,
					gameFunctionTypeId,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (roomId == 0)
			{
				this.m_teamDS.WaitingFunctionTypeId = gameFunctionTypeId;
				this.m_teamDS.WaitingLocationId = locationId;
			}
			else
			{
				this.JoinTeamRoom(roomId, gameFunctionTypeId, locationId);
			}
		}

		// Token: 0x060048F7 RID: 18679 RVA: 0x0016AF20 File Offset: 0x00169120
		public void JoinTeamRoom(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JoinTeamRoomInt32GameFunctionTypeInt32_hotfix != null)
			{
				this.m_JoinTeamRoomInt32GameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					roomId,
					gameFunctionTypeId,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.RoomId = roomId;
			this.m_teamDS.GameFunctionTypeId = gameFunctionTypeId;
			this.m_teamDS.LocationId = locationId;
			this.m_teamDS.ClearInviteInfos();
		}

		// Token: 0x060048F8 RID: 18680 RVA: 0x0016AFE0 File Offset: 0x001691E0
		public void GetTeamRoomInfo(out GameFunctionType typeId, out int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetTeamRoomInfoGameFunctionType_Int32__hotfix != null)
			{
				LuaDelegation.Lua_BlackJack_ProjectL_Common_TeamComponentCommon_GetTeamRoomInfo_GameFunctionType_Int32(this, this.m_GetTeamRoomInfoGameFunctionType_Int32__hotfix, out typeId, out locationId);
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			typeId = this.m_teamDS.GameFunctionTypeId;
			locationId = this.m_teamDS.LocationId;
		}

		// Token: 0x060048F9 RID: 18681 RVA: 0x0016B050 File Offset: 0x00169250
		public virtual void QuitTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_QuitTeamRoom_hotfix != null)
			{
				this.m_QuitTeamRoom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.RoomId = 0;
			this.m_teamDS.GameFunctionTypeId = GameFunctionType.GameFunctionType_None;
			this.m_teamDS.LocationId = 0;
		}

		// Token: 0x060048FA RID: 18682 RVA: 0x0016B0D4 File Offset: 0x001692D4
		public int CanCancelAutoMatchTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanCancelAutoMatchTeamRoom_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanCancelAutoMatchTeamRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.IsInWaitingList()) ? -3013 : 0;
		}

		// Token: 0x060048FB RID: 18683 RVA: 0x0016B158 File Offset: 0x00169358
		public int CanChangeTeamRoomAuthority(int authority)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanChangeTeamRoomAuthorityInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanChangeTeamRoomAuthorityInt32_hotfix.call(new object[]
				{
					this,
					authority
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (!this.IsTeamRoomAuthorityValid(authority))
			{
				return -3010;
			}
			if (!this.IsInRoom())
			{
				return -3014;
			}
			return 0;
		}

		// Token: 0x060048FC RID: 18684 RVA: 0x0016B1F8 File Offset: 0x001693F8
		public bool IsInTeam()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInTeam_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInTeam_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.IsInRoom() || this.IsInWaitingList();
		}

		// Token: 0x060048FD RID: 18685 RVA: 0x0016B278 File Offset: 0x00169478
		public bool IsInRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInRoom_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teamDS.RoomId != 0;
		}

		// Token: 0x060048FE RID: 18686 RVA: 0x0016B2F8 File Offset: 0x001694F8
		public bool IsInWaitingList()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInWaitingList_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInWaitingList_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teamDS.WaitingFunctionTypeId != GameFunctionType.GameFunctionType_None;
		}

		// Token: 0x060048FF RID: 18687 RVA: 0x0016B378 File Offset: 0x00169578
		public void CancelAutoMatchTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CancelAutoMatchTeamRoom_hotfix != null)
			{
				this.m_CancelAutoMatchTeamRoom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.WaitingFunctionTypeId = GameFunctionType.GameFunctionType_None;
			this.m_teamDS.WaitingLocationId = 0;
		}

		// Token: 0x06004900 RID: 18688 RVA: 0x0016B3F0 File Offset: 0x001695F0
		public int CanJoinTeamRoom(GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanJoinTeamRoomGameFunctionTypeInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanJoinTeamRoomGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.IsInTeam())
			{
				return -3008;
			}
			if (this.m_battle.IsFighting())
			{
				return -900;
			}
			return this.CanAttackTeamGameFunction(gameFunctionTypeId, locationId);
		}

		// Token: 0x06004901 RID: 18689 RVA: 0x0016B4AC File Offset: 0x001696AC
		public int CanQuitTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanQuitTeamRoom_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanQuitTeamRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.IsInRoom()) ? -3014 : 0;
		}

		// Token: 0x06004902 RID: 18690 RVA: 0x0016B530 File Offset: 0x00169730
		public int CanGetTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetTeamRoom_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetTeamRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.IsInTeam()) ? 3019 : 0;
		}

		// Token: 0x06004903 RID: 18691 RVA: 0x0016B5B4 File Offset: 0x001697B4
		public int CanChangeTeamRoomPlayerPosition()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanChangeTeamRoomPlayerPosition_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanChangeTeamRoomPlayerPosition_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.IsInTeam()) ? 3019 : 0;
		}

		// Token: 0x06004904 RID: 18692 RVA: 0x0016B638 File Offset: 0x00169838
		public virtual int CanInviteTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanInviteTeamRoom_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanInviteTeamRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.m_teamDS.LastInviteSendTime != DateTime.MinValue && this.m_basicInfo.GetCurrentTime() < this.m_teamDS.LastInviteSendTime.AddSeconds((double)this.m_configDataLoader.ConfigableConstId_TeamRoomInviteDeltaTime))
			{
				return -3023;
			}
			return (!this.IsInRoom()) ? -3014 : 0;
		}

		// Token: 0x06004905 RID: 18693 RVA: 0x0016B710 File Offset: 0x00169910
		public void InviteTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InviteTeamRoom_hotfix != null)
			{
				this.m_InviteTeamRoom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.LastInviteSendTime = this.m_basicInfo.GetCurrentTime();
		}

		// Token: 0x06004906 RID: 18694 RVA: 0x0016B788 File Offset: 0x00169988
		public bool SetTeamRoomInviteInfo(TeamRoomInviteInfo info)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetTeamRoomInviteInfoTeamRoomInviteInfo_hotfix != null)
			{
				return Convert.ToBoolean(this.m_SetTeamRoomInviteInfoTeamRoomInviteInfo_hotfix.call(new object[]
				{
					this,
					info
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teamDS.SetTeamRoomInviteInfo(info);
		}

		// Token: 0x06004907 RID: 18695 RVA: 0x0016B810 File Offset: 0x00169A10
		public bool IsInvited(ulong sessionId, int roomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInvitedUInt64Int32_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInvitedUInt64Int32_hotfix.call(new object[]
				{
					this,
					sessionId,
					roomId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teamDS.IsInvited(sessionId, roomId);
		}

		// Token: 0x06004908 RID: 18696 RVA: 0x0016B8AC File Offset: 0x00169AAC
		public void ClearAInviteInfo(ulong sessionId, int roomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearAInviteInfoUInt64Int32_hotfix != null)
			{
				this.m_ClearAInviteInfoUInt64Int32_hotfix.call(new object[]
				{
					this,
					sessionId,
					roomId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.ClearAInviteInfo(sessionId, roomId);
		}

		// Token: 0x06004909 RID: 18697 RVA: 0x0016B93C File Offset: 0x00169B3C
		public void ClearTeamRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearTeamRoom_hotfix != null)
			{
				this.m_ClearTeamRoom_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.ClearTeamRoom();
		}

		// Token: 0x0600490A RID: 18698 RVA: 0x0016B9A8 File Offset: 0x00169BA8
		public int CanRefuseInvitation(ulong sessionId, int roomId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanRefuseInvitationUInt64Int32_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanRefuseInvitationUInt64Int32_hotfix.call(new object[]
				{
					this,
					sessionId,
					roomId
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return (!this.m_teamDS.IsInvited(sessionId, roomId)) ? -3021 : 0;
		}

		// Token: 0x0600490B RID: 18699 RVA: 0x0016BA54 File Offset: 0x00169C54
		public List<TeamRoomInviteInfo> GetInviteInfos()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetInviteInfos_hotfix != null)
			{
				return (List<TeamRoomInviteInfo>)this.m_GetInviteInfos_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_teamDS.GetInviteInfos();
		}

		// Token: 0x0600490C RID: 18700 RVA: 0x0016BACC File Offset: 0x00169CCC
		public void DeductTeamPveBattleEnergy(GameFunctionType gameFunctionTypeId, int locationId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeductTeamPveBattleEnergyGameFunctionTypeInt32_hotfix != null)
			{
				this.m_DeductTeamPveBattleEnergyGameFunctionTypeInt32_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int teamPveBattleFailEnergyCost = this.m_battle.GetTeamPveBattleFailEnergyCost(gameFunctionTypeId, locationId);
			if (teamPveBattleFailEnergyCost > 0)
			{
				this.m_basicInfo.DecreaseEnergy(teamPveBattleFailEnergyCost, gameFunctionTypeId, locationId.ToString());
			}
		}

		// Token: 0x0600490D RID: 18701 RVA: 0x0016BB7C File Offset: 0x00169D7C
		public int CanGetInviteeInfo(List<string> userIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CanGetInviteeInfoList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_CanGetInviteeInfoList`1_hotfix.call(new object[]
				{
					this,
					userIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (userIds.Count > this.m_configDataLoader.ConfigableConstId_MaxDomesticFriends + this.m_configDataLoader.ConfigableConstId_MaxForeignFriends)
			{
				return -3028;
			}
			return (!this.IsInTeam()) ? 3019 : 0;
		}

		// Token: 0x17001226 RID: 4646
		// (get) Token: 0x0600490E RID: 18702 RVA: 0x0016BC38 File Offset: 0x00169E38
		public GameFunctionType WaitingFunctionTypeId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WaitingFunctionTypeId_hotfix != null)
				{
					return (GameFunctionType)this.m_get_WaitingFunctionTypeId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_teamDS.WaitingFunctionTypeId;
			}
		}

		// Token: 0x17001227 RID: 4647
		// (get) Token: 0x0600490F RID: 18703 RVA: 0x0016BCB0 File Offset: 0x00169EB0
		public int WaitingLocationId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_WaitingLocationId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_WaitingLocationId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_teamDS.WaitingLocationId;
			}
		}

		// Token: 0x17001228 RID: 4648
		// (get) Token: 0x06004910 RID: 18704 RVA: 0x0016BD28 File Offset: 0x00169F28
		public int RoomId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_RoomId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_RoomId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_teamDS.RoomId;
			}
		}

		// Token: 0x17001229 RID: 4649
		// (get) Token: 0x06004911 RID: 18705 RVA: 0x0016BDA0 File Offset: 0x00169FA0
		public GameFunctionType GameFunctionTypeId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_GameFunctionTypeId_hotfix != null)
				{
					return (GameFunctionType)this.m_get_GameFunctionTypeId_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_teamDS.GameFunctionTypeId;
			}
		}

		// Token: 0x1700122A RID: 4650
		// (get) Token: 0x06004912 RID: 18706 RVA: 0x0016BE18 File Offset: 0x0016A018
		public int LocationId
		{
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_LocationId_hotfix != null)
				{
					return Convert.ToInt32(this.m_get_LocationId_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.m_teamDS.LocationId;
			}
		}

		// Token: 0x1700122B RID: 4651
		// (get) Token: 0x06004913 RID: 18707 RVA: 0x0016BE90 File Offset: 0x0016A090
		// (set) Token: 0x06004914 RID: 18708 RVA: 0x0016BEB0 File Offset: 0x0016A0B0
		[DoNotToLua]
		public TeamComponentCommon.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamComponentCommon.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06004915 RID: 18709 RVA: 0x0016BEBC File Offset: 0x0016A0BC
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
					this.m_IsLevelUnlockedGameFunctionTypeInt32_hotfix = (luaObj.RawGet("IsLevelUnlocked") as LuaFunction);
					this.m_CanCreateTeamProTeamRoomSetting_hotfix = (luaObj.RawGet("CanCreateTeam") as LuaFunction);
					this.m_CreateTeamInt32GameFunctionTypeInt32_hotfix = (luaObj.RawGet("CreateTeam") as LuaFunction);
					this.m_IsTeamRoomAuthorityValidInt32_hotfix = (luaObj.RawGet("IsTeamRoomAuthorityValid") as LuaFunction);
					this.m_CanAttackTeamGameFunctionGameFunctionTypeInt32_hotfix = (luaObj.RawGet("CanAttackTeamGameFunction") as LuaFunction);
					this.m_CanViewTeamRoomGameFunctionTypeInt32Int32_hotfix = (luaObj.RawGet("CanViewTeamRoom") as LuaFunction);
					this.m_CanAutoMatchTeamRoomGameFunctionTypeInt32_hotfix = (luaObj.RawGet("CanAutoMatchTeamRoom") as LuaFunction);
					this.m_AutoMatchTeamRoomInt32GameFunctionTypeInt32_hotfix = (luaObj.RawGet("AutoMatchTeamRoom") as LuaFunction);
					this.m_JoinTeamRoomInt32GameFunctionTypeInt32_hotfix = (luaObj.RawGet("JoinTeamRoom") as LuaFunction);
					this.m_GetTeamRoomInfoGameFunctionType_Int32__hotfix = (luaObj.RawGet("GetTeamRoomInfo") as LuaFunction);
					this.m_QuitTeamRoom_hotfix = (luaObj.RawGet("QuitTeamRoom") as LuaFunction);
					this.m_CanCancelAutoMatchTeamRoom_hotfix = (luaObj.RawGet("CanCancelAutoMatchTeamRoom") as LuaFunction);
					this.m_CanChangeTeamRoomAuthorityInt32_hotfix = (luaObj.RawGet("CanChangeTeamRoomAuthority") as LuaFunction);
					this.m_IsInTeam_hotfix = (luaObj.RawGet("IsInTeam") as LuaFunction);
					this.m_IsInRoom_hotfix = (luaObj.RawGet("IsInRoom") as LuaFunction);
					this.m_IsInWaitingList_hotfix = (luaObj.RawGet("IsInWaitingList") as LuaFunction);
					this.m_CancelAutoMatchTeamRoom_hotfix = (luaObj.RawGet("CancelAutoMatchTeamRoom") as LuaFunction);
					this.m_CanJoinTeamRoomGameFunctionTypeInt32_hotfix = (luaObj.RawGet("CanJoinTeamRoom") as LuaFunction);
					this.m_CanQuitTeamRoom_hotfix = (luaObj.RawGet("CanQuitTeamRoom") as LuaFunction);
					this.m_CanGetTeamRoom_hotfix = (luaObj.RawGet("CanGetTeamRoom") as LuaFunction);
					this.m_CanChangeTeamRoomPlayerPosition_hotfix = (luaObj.RawGet("CanChangeTeamRoomPlayerPosition") as LuaFunction);
					this.m_CanInviteTeamRoom_hotfix = (luaObj.RawGet("CanInviteTeamRoom") as LuaFunction);
					this.m_InviteTeamRoom_hotfix = (luaObj.RawGet("InviteTeamRoom") as LuaFunction);
					this.m_SetTeamRoomInviteInfoTeamRoomInviteInfo_hotfix = (luaObj.RawGet("SetTeamRoomInviteInfo") as LuaFunction);
					this.m_IsInvitedUInt64Int32_hotfix = (luaObj.RawGet("IsInvited") as LuaFunction);
					this.m_ClearAInviteInfoUInt64Int32_hotfix = (luaObj.RawGet("ClearAInviteInfo") as LuaFunction);
					this.m_ClearTeamRoom_hotfix = (luaObj.RawGet("ClearTeamRoom") as LuaFunction);
					this.m_CanRefuseInvitationUInt64Int32_hotfix = (luaObj.RawGet("CanRefuseInvitation") as LuaFunction);
					this.m_GetInviteInfos_hotfix = (luaObj.RawGet("GetInviteInfos") as LuaFunction);
					this.m_DeductTeamPveBattleEnergyGameFunctionTypeInt32_hotfix = (luaObj.RawGet("DeductTeamPveBattleEnergy") as LuaFunction);
					this.m_CanGetInviteeInfoList`1_hotfix = (luaObj.RawGet("CanGetInviteeInfo") as LuaFunction);
					this.m_get_WaitingFunctionTypeId_hotfix = (luaObj.RawGet("get_WaitingFunctionTypeId") as LuaFunction);
					this.m_get_WaitingLocationId_hotfix = (luaObj.RawGet("get_WaitingLocationId") as LuaFunction);
					this.m_get_RoomId_hotfix = (luaObj.RawGet("get_RoomId") as LuaFunction);
					this.m_get_GameFunctionTypeId_hotfix = (luaObj.RawGet("get_GameFunctionTypeId") as LuaFunction);
					this.m_get_LocationId_hotfix = (luaObj.RawGet("get_LocationId") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06004916 RID: 18710 RVA: 0x0016C408 File Offset: 0x0016A608
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamComponentCommon));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04003724 RID: 14116
		protected IConfigDataLoader m_configDataLoader;

		// Token: 0x04003725 RID: 14117
		protected DataSectionTeam m_teamDS = new DataSectionTeam();

		// Token: 0x04003726 RID: 14118
		protected BagComponentCommon m_bag;

		// Token: 0x04003727 RID: 14119
		protected AnikiGymComponentCommon m_anikiGym;

		// Token: 0x04003728 RID: 14120
		protected MemoryCorridorCompomentCommon m_memoryCorridor;

		// Token: 0x04003729 RID: 14121
		protected ThearchyTrialCompomentCommon m_thearchyTrial;

		// Token: 0x0400372A RID: 14122
		protected PlayerBasicInfoComponentCommon m_basicInfo;

		// Token: 0x0400372B RID: 14123
		protected HeroTrainningComponentCommon m_heroTrainning;

		// Token: 0x0400372C RID: 14124
		protected CooperateBattleCompomentCommon m_cooperateBattle;

		// Token: 0x0400372D RID: 14125
		protected UnchartedScoreComponentCommon m_unchartedScore;

		// Token: 0x0400372E RID: 14126
		protected BattleComponentCommon m_battle;

		// Token: 0x0400372F RID: 14127
		public Action FinishTeamBattleMissionEvent;

		// Token: 0x04003730 RID: 14128
		[DoNotToLua]
		private TeamComponentCommon.LuaExportHelper luaExportHelper;

		// Token: 0x04003731 RID: 14129
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04003732 RID: 14130
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04003733 RID: 14131
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04003734 RID: 14132
		private LuaFunction m_GetName_hotfix;

		// Token: 0x04003735 RID: 14133
		private LuaFunction m_Init_hotfix;

		// Token: 0x04003736 RID: 14134
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x04003737 RID: 14135
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x04003738 RID: 14136
		private LuaFunction m_TickUInt32_hotfix;

		// Token: 0x04003739 RID: 14137
		private LuaFunction m_SerializeT_hotfix;

		// Token: 0x0400373A RID: 14138
		private LuaFunction m_DeSerializeT_hotfix;

		// Token: 0x0400373B RID: 14139
		private LuaFunction m_PostDeSerialize_hotfix;

		// Token: 0x0400373C RID: 14140
		private LuaFunction m_get_Owner_hotfix;

		// Token: 0x0400373D RID: 14141
		private LuaFunction m_set_OwnerIComponentOwner_hotfix;

		// Token: 0x0400373E RID: 14142
		private LuaFunction m_IsLevelUnlockedGameFunctionTypeInt32_hotfix;

		// Token: 0x0400373F RID: 14143
		private LuaFunction m_CanCreateTeamProTeamRoomSetting_hotfix;

		// Token: 0x04003740 RID: 14144
		private LuaFunction m_CreateTeamInt32GameFunctionTypeInt32_hotfix;

		// Token: 0x04003741 RID: 14145
		private LuaFunction m_IsTeamRoomAuthorityValidInt32_hotfix;

		// Token: 0x04003742 RID: 14146
		private LuaFunction m_CanAttackTeamGameFunctionGameFunctionTypeInt32_hotfix;

		// Token: 0x04003743 RID: 14147
		private LuaFunction m_CanViewTeamRoomGameFunctionTypeInt32Int32_hotfix;

		// Token: 0x04003744 RID: 14148
		private LuaFunction m_CanAutoMatchTeamRoomGameFunctionTypeInt32_hotfix;

		// Token: 0x04003745 RID: 14149
		private LuaFunction m_AutoMatchTeamRoomInt32GameFunctionTypeInt32_hotfix;

		// Token: 0x04003746 RID: 14150
		private LuaFunction m_JoinTeamRoomInt32GameFunctionTypeInt32_hotfix;

		// Token: 0x04003747 RID: 14151
		private LuaFunction m_GetTeamRoomInfoGameFunctionType_Int32__hotfix;

		// Token: 0x04003748 RID: 14152
		private LuaFunction m_QuitTeamRoom_hotfix;

		// Token: 0x04003749 RID: 14153
		private LuaFunction m_CanCancelAutoMatchTeamRoom_hotfix;

		// Token: 0x0400374A RID: 14154
		private LuaFunction m_CanChangeTeamRoomAuthorityInt32_hotfix;

		// Token: 0x0400374B RID: 14155
		private LuaFunction m_IsInTeam_hotfix;

		// Token: 0x0400374C RID: 14156
		private LuaFunction m_IsInRoom_hotfix;

		// Token: 0x0400374D RID: 14157
		private LuaFunction m_IsInWaitingList_hotfix;

		// Token: 0x0400374E RID: 14158
		private LuaFunction m_CancelAutoMatchTeamRoom_hotfix;

		// Token: 0x0400374F RID: 14159
		private LuaFunction m_CanJoinTeamRoomGameFunctionTypeInt32_hotfix;

		// Token: 0x04003750 RID: 14160
		private LuaFunction m_CanQuitTeamRoom_hotfix;

		// Token: 0x04003751 RID: 14161
		private LuaFunction m_CanGetTeamRoom_hotfix;

		// Token: 0x04003752 RID: 14162
		private LuaFunction m_CanChangeTeamRoomPlayerPosition_hotfix;

		// Token: 0x04003753 RID: 14163
		private LuaFunction m_CanInviteTeamRoom_hotfix;

		// Token: 0x04003754 RID: 14164
		private LuaFunction m_InviteTeamRoom_hotfix;

		// Token: 0x04003755 RID: 14165
		private LuaFunction m_SetTeamRoomInviteInfoTeamRoomInviteInfo_hotfix;

		// Token: 0x04003756 RID: 14166
		private LuaFunction m_IsInvitedUInt64Int32_hotfix;

		// Token: 0x04003757 RID: 14167
		private LuaFunction m_ClearAInviteInfoUInt64Int32_hotfix;

		// Token: 0x04003758 RID: 14168
		private LuaFunction m_ClearTeamRoom_hotfix;

		// Token: 0x04003759 RID: 14169
		private LuaFunction m_CanRefuseInvitationUInt64Int32_hotfix;

		// Token: 0x0400375A RID: 14170
		private LuaFunction m_GetInviteInfos_hotfix;

		// Token: 0x0400375B RID: 14171
		private LuaFunction m_DeductTeamPveBattleEnergyGameFunctionTypeInt32_hotfix;

		// Token: 0x0400375C RID: 14172
		private LuaFunction m_CanGetInviteeInfoList;

		// Token: 0x0400375D RID: 14173
		private LuaFunction m_get_WaitingFunctionTypeId_hotfix;

		// Token: 0x0400375E RID: 14174
		private LuaFunction m_get_WaitingLocationId_hotfix;

		// Token: 0x0400375F RID: 14175
		private LuaFunction m_get_RoomId_hotfix;

		// Token: 0x04003760 RID: 14176
		private LuaFunction m_get_GameFunctionTypeId_hotfix;

		// Token: 0x04003761 RID: 14177
		private LuaFunction m_get_LocationId_hotfix;

		// Token: 0x020004AD RID: 1197
		public class LuaExportHelper
		{
			// Token: 0x06004917 RID: 18711 RVA: 0x0016C470 File Offset: 0x0016A670
			public LuaExportHelper(TeamComponentCommon owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x1700122C RID: 4652
			// (get) Token: 0x06004918 RID: 18712 RVA: 0x0016C480 File Offset: 0x0016A680
			// (set) Token: 0x06004919 RID: 18713 RVA: 0x0016C490 File Offset: 0x0016A690
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

			// Token: 0x1700122D RID: 4653
			// (get) Token: 0x0600491A RID: 18714 RVA: 0x0016C4A0 File Offset: 0x0016A6A0
			// (set) Token: 0x0600491B RID: 18715 RVA: 0x0016C4B0 File Offset: 0x0016A6B0
			public DataSectionTeam m_teamDS
			{
				get
				{
					return this.m_owner.m_teamDS;
				}
				set
				{
					this.m_owner.m_teamDS = value;
				}
			}

			// Token: 0x1700122E RID: 4654
			// (get) Token: 0x0600491C RID: 18716 RVA: 0x0016C4C0 File Offset: 0x0016A6C0
			// (set) Token: 0x0600491D RID: 18717 RVA: 0x0016C4D0 File Offset: 0x0016A6D0
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

			// Token: 0x1700122F RID: 4655
			// (get) Token: 0x0600491E RID: 18718 RVA: 0x0016C4E0 File Offset: 0x0016A6E0
			// (set) Token: 0x0600491F RID: 18719 RVA: 0x0016C4F0 File Offset: 0x0016A6F0
			public AnikiGymComponentCommon m_anikiGym
			{
				get
				{
					return this.m_owner.m_anikiGym;
				}
				set
				{
					this.m_owner.m_anikiGym = value;
				}
			}

			// Token: 0x17001230 RID: 4656
			// (get) Token: 0x06004920 RID: 18720 RVA: 0x0016C500 File Offset: 0x0016A700
			// (set) Token: 0x06004921 RID: 18721 RVA: 0x0016C510 File Offset: 0x0016A710
			public MemoryCorridorCompomentCommon m_memoryCorridor
			{
				get
				{
					return this.m_owner.m_memoryCorridor;
				}
				set
				{
					this.m_owner.m_memoryCorridor = value;
				}
			}

			// Token: 0x17001231 RID: 4657
			// (get) Token: 0x06004922 RID: 18722 RVA: 0x0016C520 File Offset: 0x0016A720
			// (set) Token: 0x06004923 RID: 18723 RVA: 0x0016C530 File Offset: 0x0016A730
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

			// Token: 0x17001232 RID: 4658
			// (get) Token: 0x06004924 RID: 18724 RVA: 0x0016C540 File Offset: 0x0016A740
			// (set) Token: 0x06004925 RID: 18725 RVA: 0x0016C550 File Offset: 0x0016A750
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

			// Token: 0x17001233 RID: 4659
			// (get) Token: 0x06004926 RID: 18726 RVA: 0x0016C560 File Offset: 0x0016A760
			// (set) Token: 0x06004927 RID: 18727 RVA: 0x0016C570 File Offset: 0x0016A770
			public HeroTrainningComponentCommon m_heroTrainning
			{
				get
				{
					return this.m_owner.m_heroTrainning;
				}
				set
				{
					this.m_owner.m_heroTrainning = value;
				}
			}

			// Token: 0x17001234 RID: 4660
			// (get) Token: 0x06004928 RID: 18728 RVA: 0x0016C580 File Offset: 0x0016A780
			// (set) Token: 0x06004929 RID: 18729 RVA: 0x0016C590 File Offset: 0x0016A790
			public CooperateBattleCompomentCommon m_cooperateBattle
			{
				get
				{
					return this.m_owner.m_cooperateBattle;
				}
				set
				{
					this.m_owner.m_cooperateBattle = value;
				}
			}

			// Token: 0x17001235 RID: 4661
			// (get) Token: 0x0600492A RID: 18730 RVA: 0x0016C5A0 File Offset: 0x0016A7A0
			// (set) Token: 0x0600492B RID: 18731 RVA: 0x0016C5B0 File Offset: 0x0016A7B0
			public UnchartedScoreComponentCommon m_unchartedScore
			{
				get
				{
					return this.m_owner.m_unchartedScore;
				}
				set
				{
					this.m_owner.m_unchartedScore = value;
				}
			}

			// Token: 0x17001236 RID: 4662
			// (get) Token: 0x0600492C RID: 18732 RVA: 0x0016C5C0 File Offset: 0x0016A7C0
			// (set) Token: 0x0600492D RID: 18733 RVA: 0x0016C5D0 File Offset: 0x0016A7D0
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

			// Token: 0x0600492E RID: 18734 RVA: 0x0016C5E0 File Offset: 0x0016A7E0
			public bool IsTeamRoomAuthorityValid(int authority)
			{
				return this.m_owner.IsTeamRoomAuthorityValid(authority);
			}

			// Token: 0x04003762 RID: 14178
			private TeamComponentCommon m_owner;
		}
	}
}
