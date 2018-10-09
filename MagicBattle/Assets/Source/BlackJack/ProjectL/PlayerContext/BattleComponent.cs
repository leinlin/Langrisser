using System;
using System.Collections.Generic;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x0200088C RID: 2188
	[HotFix]
	public class BattleComponent : BattleComponentCommon
	{
		// Token: 0x06006D24 RID: 27940 RVA: 0x001E7538 File Offset: 0x001E5738
		public BattleComponent()
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

		// Token: 0x06006D25 RID: 27941 RVA: 0x001E75B4 File Offset: 0x001E57B4
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

		// Token: 0x06006D26 RID: 27942 RVA: 0x001E7630 File Offset: 0x001E5830
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

		// Token: 0x06006D27 RID: 27943 RVA: 0x001E7698 File Offset: 0x001E5898
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

		// Token: 0x06006D28 RID: 27944 RVA: 0x001E7700 File Offset: 0x001E5900
		public void DeSerialize(DSBattleNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSBattleNtf_hotfix != null)
			{
				this.m_DeSerializeDSBattleNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.ClearInitedData();
			foreach (ProTeam proTeam in msg.Teams)
			{
				this.m_battleDS.SetTeam(proTeam.BattleType, proTeam.Heroes);
			}
			this.m_battleDS.InitProcessingBattle(ProcessingBattle.PbBattleProcessingToBattleProcessing(msg.ProcessingBattleInfo));
			this.m_battleDS.InitVersion((ushort)msg.Version, (ushort)msg.Version);
			this.m_battleDS.GotBattleTreasureIds.AddRange(msg.GotBattleTreasureIds);
			this.m_battleDS.ArenaBattleStatus = (ArenaBattleStatus)msg.ArenaBattleStatus;
			this.m_battleDS.ArenaBattleId = msg.ArenaBattleId;
			this.m_battleDS.ArenaBattleRandomSeed = msg.ArenaBattleRandomSeed;
			this.m_battleDS.BattleRoomId = msg.BattleRoomId;
		}

		// Token: 0x06006D29 RID: 27945 RVA: 0x001E7864 File Offset: 0x001E5A64
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
			return this.m_battleDS.ClientVersion;
		}

		// Token: 0x06006D2A RID: 27946 RVA: 0x001E78DC File Offset: 0x001E5ADC
		public void SetBattleBase(BattleBase battleBase)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleBaseBattleBase_hotfix != null)
			{
				this.m_SetBattleBaseBattleBase_hotfix.call(new object[]
				{
					this,
					battleBase
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battle = battleBase;
		}

		// Token: 0x06006D2B RID: 27947 RVA: 0x001E7954 File Offset: 0x001E5B54
		public BattleBase GetBattleBase()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleBase_hotfix != null)
			{
				return (BattleBase)this.m_GetBattleBase_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battle;
		}

		// Token: 0x06006D2C RID: 27948 RVA: 0x001E79C8 File Offset: 0x001E5BC8
		public bool IsRiftBattling()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRiftBattling_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRiftBattling_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProcessingBattle processingBattleInfo = this.m_battleDS.ProcessingBattleInfo;
			return processingBattleInfo.Type == BattleType.Rift && processingBattleInfo.TypeId != 0;
		}

		// Token: 0x06006D2D RID: 27949 RVA: 0x001E7A5C File Offset: 0x001E5C5C
		public bool IsTreasureMapBattling()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTreasureMapBattling_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTreasureMapBattling_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ProcessingBattle processingBattleInfo = this.m_battleDS.ProcessingBattleInfo;
			return processingBattleInfo.Type == BattleType.TreasureMap && processingBattleInfo.TypeId != 0;
		}

		// Token: 0x06006D2E RID: 27950 RVA: 0x001E7AF0 File Offset: 0x001E5CF0
		public List<int> GetBattleTeam(int teamType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleTeamInt32_hotfix != null)
			{
				return (List<int>)this.m_GetBattleTeamInt32_hotfix.call(new object[]
				{
					this,
					teamType
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.GetTeam(teamType);
		}

		// Token: 0x06006D2F RID: 27951 RVA: 0x001E7B78 File Offset: 0x001E5D78
		public void ClearFighting()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ClearFighting_hotfix != null)
			{
				this.m_ClearFighting_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.SetRandomSeed(0);
			this.m_battleDS.SetProcessingBattleInfo(BattleType.None, 0);
			this.m_battleDS.ArenaBattleStatus = ArenaBattleStatus.None;
			this.m_battleDS.ArenaBattleId = int.MinValue;
			this.m_battleDS.ArenaBattleRandomSeed = int.MinValue;
		}

		// Token: 0x06006D30 RID: 27952 RVA: 0x001E7C20 File Offset: 0x001E5E20
		public void SetBattleRandomSeed(int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleRandomSeedInt32_hotfix != null)
			{
				this.m_SetBattleRandomSeedInt32_hotfix.call(new object[]
				{
					this,
					randomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.SetRandomSeed(randomSeed);
		}

		// Token: 0x06006D31 RID: 27953 RVA: 0x001E7C9C File Offset: 0x001E5E9C
		public void SetArenaBattleRandomSeed(int randomSeed)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetArenaBattleRandomSeedInt32_hotfix != null)
			{
				this.m_SetArenaBattleRandomSeedInt32_hotfix.call(new object[]
				{
					this,
					randomSeed
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleDS.ArenaBattleRandomSeed = randomSeed;
		}

		// Token: 0x06006D32 RID: 27954 RVA: 0x001E7D18 File Offset: 0x001E5F18
		public ArenaBattleStatus GetArenaBattleStatus()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaBattleStatus_hotfix != null)
			{
				return (ArenaBattleStatus)this.m_GetArenaBattleStatus_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ArenaBattleStatus;
		}

		// Token: 0x06006D33 RID: 27955 RVA: 0x001E7D90 File Offset: 0x001E5F90
		public int GetArenaBattleId()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetArenaBattleId_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetArenaBattleId_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.ArenaBattleId;
		}

		// Token: 0x06006D34 RID: 27956 RVA: 0x001E7E08 File Offset: 0x001E6008
		public List<int> GetGotBattleTreasureIds()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetGotBattleTreasureIds_hotfix != null)
			{
				return (List<int>)this.m_GetGotBattleTreasureIds_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleDS.GotBattleTreasureIds;
		}

		// Token: 0x06006D35 RID: 27957 RVA: 0x001E7E80 File Offset: 0x001E6080
		public int JoinTeamBattleRoom(ulong roomId, int battleId, GameFunctionType gameFunctionType, int locationId, List<ProBattleRoomPlayer> players, DateTime readyTimeOut)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JoinTeamBattleRoomUInt64Int32GameFunctionTypeInt32List`1DateTime_hotfix != null)
			{
				return Convert.ToInt32(this.m_JoinTeamBattleRoomUInt64Int32GameFunctionTypeInt32List`1DateTime_hotfix.call(new object[]
				{
					this,
					roomId,
					battleId,
					gameFunctionType,
					locationId,
					players,
					readyTimeOut
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBattleInfo configDataBattleInfo = this.m_configDataLoader.GetConfigDataBattleInfo(battleId);
			if (configDataBattleInfo == null)
			{
				return -905;
			}
			base.BattleRoomId = roomId;
			this.m_battleRoom.Clear();
			this.m_battleRoom.RoomId = roomId;
			this.m_battleRoom.BattleRoomType = BattleRoomType.Team;
			this.m_battleRoom.BattleId = battleId;
			this.m_battleRoom.GameFunctionType = gameFunctionType;
			this.m_battleRoom.LocationId = locationId;
			this.m_battleRoom.BattleRoomStatus = BattleRoomStatus.Ready;
			this.m_battleRoom.ReadyTimeout = readyTimeOut;
			this.m_battleRoom.InitPlayers(players);
			this.m_battleRoom.BattleRoomPlayerHeroSetup.InitTeamBattle(players.Count, configDataBattleInfo.AllyPositions.Count);
			return 0;
		}

		// Token: 0x06006D36 RID: 27958 RVA: 0x001E8000 File Offset: 0x001E6200
		public int JoinPVPBattleRoom(ulong roomId, int battleId, List<ProBattleRoomPlayer> players, DateTime readyTimeOut)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JoinPVPBattleRoomUInt64Int32List`1DateTime_hotfix != null)
			{
				return Convert.ToInt32(this.m_JoinPVPBattleRoomUInt64Int32List`1DateTime_hotfix.call(new object[]
				{
					this,
					roomId,
					battleId,
					players,
					readyTimeOut
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataPVPBattleInfo configDataPVPBattleInfo = this.m_configDataLoader.GetConfigDataPVPBattleInfo(battleId);
			if (configDataPVPBattleInfo == null)
			{
				return -934;
			}
			base.BattleRoomId = roomId;
			this.m_battleRoom.Clear();
			this.m_battleRoom.RoomId = roomId;
			this.m_battleRoom.BattleRoomType = BattleRoomType.PVP;
			this.m_battleRoom.BattleId = battleId;
			this.m_battleRoom.GameFunctionType = GameFunctionType.GameFunctionType_None;
			this.m_battleRoom.LocationId = 0;
			this.m_battleRoom.BattleRoomStatus = BattleRoomStatus.Ready;
			this.m_battleRoom.ReadyTimeout = readyTimeOut;
			this.m_battleRoom.InitPlayers(players);
			this.m_battleRoom.BattleRoomPlayerHeroSetup.InitPVPBattle(configDataPVPBattleInfo.AttackPositions.Count, configDataPVPBattleInfo.DefendPositions.Count);
			return 0;
		}

		// Token: 0x06006D37 RID: 27959 RVA: 0x001E8160 File Offset: 0x001E6360
		public int JoinRealtimePVPBattleRoom(ulong roomId, int battleId, List<ProBattleRoomPlayer> players, DateTime readyTimeOut, BattleRoomType roomType)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JoinRealtimePVPBattleRoomUInt64Int32List`1DateTimeBattleRoomType_hotfix != null)
			{
				return Convert.ToInt32(this.m_JoinRealtimePVPBattleRoomUInt64Int32List`1DateTimeBattleRoomType_hotfix.call(new object[]
				{
					this,
					roomId,
					battleId,
					players,
					readyTimeOut,
					roomType
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataRealTimePVPBattleInfo configDataRealTimePVPBattleInfo = this.m_configDataLoader.GetConfigDataRealTimePVPBattleInfo(battleId);
			if (configDataRealTimePVPBattleInfo == null)
			{
				return -935;
			}
			base.BattleRoomId = roomId;
			this.m_battleRoom.Clear();
			this.m_battleRoom.RoomId = roomId;
			this.m_battleRoom.BattleRoomType = roomType;
			this.m_battleRoom.BattleId = battleId;
			this.m_battleRoom.GameFunctionType = GameFunctionType.GameFunctionType_None;
			this.m_battleRoom.LocationId = 0;
			this.m_battleRoom.BattleRoomStatus = BattleRoomStatus.Ready;
			this.m_battleRoom.ReadyTimeout = readyTimeOut;
			this.m_battleRoom.InitPlayers(players);
			this.m_battleRoom.BattleRoomPlayerHeroSetup.InitPVPBattle(configDataRealTimePVPBattleInfo.AttackPositions.Count, configDataRealTimePVPBattleInfo.DefendPositions.Count);
			return 0;
		}

		// Token: 0x06006D38 RID: 27960 RVA: 0x001E82D4 File Offset: 0x001E64D4
		public int JoinGuildMassiveCombatBattleRoom(ulong roomId, int battleId, int locationId, List<ProBattleRoomPlayer> players, DateTime readyTimeOut, List<int> preferredHeroTagIds)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JoinGuildMassiveCombatBattleRoomUInt64Int32Int32List`1DateTimeList`1_hotfix != null)
			{
				return Convert.ToInt32(this.m_JoinGuildMassiveCombatBattleRoomUInt64Int32Int32List`1DateTimeList`1_hotfix.call(new object[]
				{
					this,
					roomId,
					battleId,
					locationId,
					players,
					readyTimeOut,
					preferredHeroTagIds
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ConfigDataBattleInfo configDataBattleInfo = this.m_configDataLoader.GetConfigDataBattleInfo(battleId);
			if (configDataBattleInfo == null)
			{
				return -905;
			}
			base.BattleRoomId = roomId;
			this.m_battleRoom.Clear();
			this.m_battleRoom.RoomId = roomId;
			this.m_battleRoom.BattleRoomType = BattleRoomType.GuildMassiveCombat;
			this.m_battleRoom.BattleId = battleId;
			this.m_battleRoom.GameFunctionType = GameFunctionType.GameFunctionType_GuildMassiveCombat;
			this.m_battleRoom.LocationId = locationId;
			this.m_battleRoom.BattleRoomStatus = BattleRoomStatus.Ready;
			this.m_battleRoom.ReadyTimeout = readyTimeOut;
			this.m_battleRoom.PreferredHeroTagIds.Clear();
			this.m_battleRoom.PreferredHeroTagIds.AddRange(preferredHeroTagIds);
			this.m_battleRoom.InitPlayers(players);
			this.m_battleRoom.BattleRoomPlayerHeroSetup.InitTeamBattle(players.Count, configDataBattleInfo.AllyPositions.Count);
			return 0;
		}

		// Token: 0x06006D39 RID: 27961 RVA: 0x001E8474 File Offset: 0x001E6674
		public int QuitBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_QuitBattleRoom_hotfix != null)
			{
				return Convert.ToInt32(this.m_QuitBattleRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.FinishBattleInBattleServer();
			return 0;
		}

		// Token: 0x06006D3A RID: 27962 RVA: 0x001E84E8 File Offset: 0x001E66E8
		public void SetRealtimePVPBattleRoomData(BattleRoomDataChangeNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetRealtimePVPBattleRoomDataBattleRoomDataChangeNtf_hotfix != null)
			{
				this.m_SetRealtimePVPBattleRoomDataBattleRoomDataChangeNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_battleRoom.BattleMode = (BattleMode)msg.Mode;
			this.m_battleRoom.BPTurn = msg.BPTurn;
			this.m_battleRoom.BPStatus = (BattleRoomBPStatus)msg.BPStatus;
			this.m_battleRoom.BPRule = (BattleRoomBPRule)msg.BPRule;
			this.m_battleRoom.LatestTurnChangeDateTime = new DateTime(msg.LastestTurnChangeTime);
			this.m_battleRoom.RealtimePVPBattleInstanceId = msg.RealtimePVPBattleInstanceId;
		}

		// Token: 0x06006D3B RID: 27963 RVA: 0x001E85C4 File Offset: 0x001E67C4
		public void SetBattleRoomPlayerStatus(ulong sessionId, PlayerBattleStatus status, bool isOffLine)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetBattleRoomPlayerStatusUInt64PlayerBattleStatusBoolean_hotfix != null)
			{
				this.m_SetBattleRoomPlayerStatusUInt64PlayerBattleStatusBoolean_hotfix.call(new object[]
				{
					this,
					sessionId,
					status,
					isOffLine
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomPlayer battleRoomPlayer = this.m_battleRoom.FindPlayerBySessionId(sessionId);
			if (battleRoomPlayer != null)
			{
				battleRoomPlayer.PlayerBattleStatus = status;
				battleRoomPlayer.IsOffline = isOffLine;
			}
		}

		// Token: 0x06006D3C RID: 27964 RVA: 0x001E8678 File Offset: 0x001E6878
		public void InitBattleRoomPlayer(ulong sessionId, List<ProTrainingTech> techs)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitBattleRoomPlayerUInt64List`1_hotfix != null)
			{
				this.m_InitBattleRoomPlayerUInt64List`1_hotfix.call(new object[]
				{
					this,
					sessionId,
					techs
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleRoomPlayer battleRoomPlayer = this.m_battleRoom.FindPlayerBySessionId(sessionId);
			if (battleRoomPlayer != null)
			{
				battleRoomPlayer.Techs.Clear();
				foreach (ProTrainingTech tech in techs)
				{
					TrainingTech trainingTech = TrainingTech.FromDataSection(tech);
					trainingTech.ConfigDataLoader = this.m_configDataLoader;
					battleRoomPlayer.Techs.Add(trainingTech);
				}
			}
		}

		// Token: 0x06006D3D RID: 27965 RVA: 0x001E8778 File Offset: 0x001E6978
		public void BattleRoomHeroSetup(ProBattleHeroSetupInfo heroSetup)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleRoomHeroSetupProBattleHeroSetupInfo_hotfix != null)
			{
				this.m_BattleRoomHeroSetupProBattleHeroSetupInfo_hotfix.call(new object[]
				{
					this,
					heroSetup
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			BattleHero hero = (heroSetup.Hero == null) ? null : BattleHero.PBBattleHeroToBattleHero(heroSetup.Hero);
			this.m_battleRoom.BattleRoomPlayerHeroSetup.SetHero(heroSetup.PlayerIndex, heroSetup.Position, hero, false);
			this.m_battleRoom.BattleRoomPlayerHeroSetup.MarkSetupHeroFlag(heroSetup.PlayerIndex, heroSetup.Position, (SetupBattleHeroFlag)heroSetup.Flag);
		}

		// Token: 0x06006D3E RID: 27966 RVA: 0x001E8848 File Offset: 0x001E6A48
		public void BattleRoomBattleStart()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_BattleRoomBattleStart_hotfix != null)
			{
				this.m_BattleRoomBattleStart_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (BattleRoomPlayer battleRoomPlayer in this.m_battleRoom.Players)
			{
				battleRoomPlayer.PlayerBattleStatus = PlayerBattleStatus.Normal;
			}
			this.m_battleRoom.BattleRoomStatus = BattleRoomStatus.Fighting;
		}

		// Token: 0x06006D3F RID: 27967 RVA: 0x001E8908 File Offset: 0x001E6B08
		public void AppendBattleRoomCommands(List<ProBattleCommand> commands)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AppendBattleRoomCommandsList`1_hotfix != null)
			{
				this.m_AppendBattleRoomCommandsList`1_hotfix.call(new object[]
				{
					this,
					commands
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			foreach (ProBattleCommand pbBattleCommand in commands)
			{
				this.m_battleRoom.BattleCommands.Add(BattleCommand.PBBattleCommandToBattleCommand(pbBattleCommand));
			}
		}

		// Token: 0x06006D40 RID: 27968 RVA: 0x001E89D4 File Offset: 0x001E6BD4
		public bool IsInBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsInBattleRoom_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsInBattleRoom_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return base.IsAttackingInBattleServer();
		}

		// Token: 0x06006D41 RID: 27969 RVA: 0x001E8A48 File Offset: 0x001E6C48
		public BattleRoom GetBattleRoom()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleRoom_hotfix != null)
			{
				return (BattleRoom)this.m_GetBattleRoom_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleRoom;
		}

		// Token: 0x06006D42 RID: 27970 RVA: 0x001E8ABC File Offset: 0x001E6CBC
		public BattleReward GetBattleReward()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetBattleReward_hotfix != null)
			{
				return (BattleReward)this.m_GetBattleReward_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.m_battleReward;
		}

		// Token: 0x17001B9A RID: 7066
		// (get) Token: 0x06006D43 RID: 27971 RVA: 0x001E8B30 File Offset: 0x001E6D30
		// (set) Token: 0x06006D44 RID: 27972 RVA: 0x001E8B50 File Offset: 0x001E6D50
		[DoNotToLua]
		public new BattleComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006D45 RID: 27973 RVA: 0x001E8B5C File Offset: 0x001E6D5C
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06006D46 RID: 27974 RVA: 0x001E8B64 File Offset: 0x001E6D64
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06006D47 RID: 27975 RVA: 0x001E8B6C File Offset: 0x001E6D6C
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06006D48 RID: 27976 RVA: 0x001E8B74 File Offset: 0x001E6D74
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06006D49 RID: 27977 RVA: 0x001E8B7C File Offset: 0x001E6D7C
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06006D4A RID: 27978 RVA: 0x001E8B88 File Offset: 0x001E6D88
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06006D4B RID: 27979 RVA: 0x001E8B90 File Offset: 0x001E6D90
		private bool __callBase_IsGameFunctionOpenByMonthCard(GameFunctionType gameFuncTypeId)
		{
			return base.IsGameFunctionOpenByMonthCard(gameFuncTypeId);
		}

		// Token: 0x06006D4C RID: 27980 RVA: 0x001E8B9C File Offset: 0x001E6D9C
		private int __callBase_GetDailyBonusMaxNums(GameFunctionType gameFuncTypeId)
		{
			return base.GetDailyBonusMaxNums(gameFuncTypeId);
		}

		// Token: 0x06006D4D RID: 27981 RVA: 0x001E8BA8 File Offset: 0x001E6DA8
		private int __callBase_GetSinglePveBattleFailEnergyCostByMonthCard()
		{
			return base.GetSinglePveBattleFailEnergyCostByMonthCard();
		}

		// Token: 0x06006D4E RID: 27982 RVA: 0x001E8BB0 File Offset: 0x001E6DB0
		private int __callBase_GetTeamPveBattleFailEnergyCost(GameFunctionType typeId, int locationId)
		{
			return base.GetTeamPveBattleFailEnergyCost(typeId, locationId);
		}

		// Token: 0x06006D4F RID: 27983 RVA: 0x001E8BBC File Offset: 0x001E6DBC
		private int __callBase_GetTeamPveBattleFailEnergyCostByMonthCard(GameFunctionType typeId, int locationId)
		{
			return base.GetTeamPveBattleFailEnergyCostByMonthCard(typeId, locationId);
		}

		// Token: 0x06006D50 RID: 27984 RVA: 0x001E8BC8 File Offset: 0x001E6DC8
		private void __callBase_AddTeamPveFightFailCompensationEnergyByMonthCard(GameFunctionType typeId, int locationId)
		{
			base.AddTeamPveFightFailCompensationEnergyByMonthCard(typeId, locationId);
		}

		// Token: 0x06006D51 RID: 27985 RVA: 0x001E8BD4 File Offset: 0x001E6DD4
		private bool __callBase_IsWaypointBattling()
		{
			return base.IsWaypointBattling();
		}

		// Token: 0x06006D52 RID: 27986 RVA: 0x001E8BDC File Offset: 0x001E6DDC
		private bool __callBase_IsBattleWin()
		{
			return base.IsBattleWin();
		}

		// Token: 0x06006D53 RID: 27987 RVA: 0x001E8BE4 File Offset: 0x001E6DE4
		private int __callBase_CancelBattle()
		{
			return base.CancelBattle();
		}

		// Token: 0x06006D54 RID: 27988 RVA: 0x001E8BEC File Offset: 0x001E6DEC
		private bool __callBase_IsFighting()
		{
			return base.IsFighting();
		}

		// Token: 0x06006D55 RID: 27989 RVA: 0x001E8BF4 File Offset: 0x001E6DF4
		private bool __callBase_CanSetupMineTeam()
		{
			return base.CanSetupMineTeam();
		}

		// Token: 0x06006D56 RID: 27990 RVA: 0x001E8BFC File Offset: 0x001E6DFC
		private void __callBase_FightFinished(GameFunctionStatus status, bool win, bool needBatlleLog)
		{
			base.FightFinished(status, win, needBatlleLog);
		}

		// Token: 0x06006D57 RID: 27991 RVA: 0x001E8C08 File Offset: 0x001E6E08
		private bool __callBase_IsWayPointFightExist(int wayPointId)
		{
			return base.IsWayPointFightExist(wayPointId);
		}

		// Token: 0x06006D58 RID: 27992 RVA: 0x001E8C14 File Offset: 0x001E6E14
		private void __callBase_WinPveBattle(int battleId)
		{
			base.WinPveBattle(battleId);
		}

		// Token: 0x06006D59 RID: 27993 RVA: 0x001E8C20 File Offset: 0x001E6E20
		private void __callBase_FinishedArenaFight()
		{
			base.FinishedArenaFight();
		}

		// Token: 0x06006D5A RID: 27994 RVA: 0x001E8C28 File Offset: 0x001E6E28
		private ProcessingBattle __callBase_GetProcessingBattle()
		{
			return base.GetProcessingBattle();
		}

		// Token: 0x06006D5B RID: 27995 RVA: 0x001E8C30 File Offset: 0x001E6E30
		private void __callBase_SetProcessingBattleInfo(BattleType type, int typeId)
		{
			base.SetProcessingBattleInfo(type, typeId);
		}

		// Token: 0x06006D5C RID: 27996 RVA: 0x001E8C3C File Offset: 0x001E6E3C
		private void __callBase_SetBattleArmyRandomSeed(int armyRandomSeed)
		{
			base.SetBattleArmyRandomSeed(armyRandomSeed);
		}

		// Token: 0x06006D5D RID: 27997 RVA: 0x001E8C48 File Offset: 0x001E6E48
		private int __callBase_GetBattleArmyRandomSeed()
		{
			return base.GetBattleArmyRandomSeed();
		}

		// Token: 0x06006D5E RID: 27998 RVA: 0x001E8C50 File Offset: 0x001E6E50
		private void __callBase_SetArenaBattleInfo(int arenaBattleId)
		{
			base.SetArenaBattleInfo(arenaBattleId);
		}

		// Token: 0x06006D5F RID: 27999 RVA: 0x001E8C5C File Offset: 0x001E6E5C
		private bool __callBase_IsAttackingPveLevel(BattleType battleType, int levelId)
		{
			return base.IsAttackingPveLevel(battleType, levelId);
		}

		// Token: 0x06006D60 RID: 28000 RVA: 0x001E8C68 File Offset: 0x001E6E68
		private bool __callBase_IsAttackingArenaOpponent()
		{
			return base.IsAttackingArenaOpponent();
		}

		// Token: 0x06006D61 RID: 28001 RVA: 0x001E8C70 File Offset: 0x001E6E70
		private bool __callBase_IsArenaBattleInReady()
		{
			return base.IsArenaBattleInReady();
		}

		// Token: 0x06006D62 RID: 28002 RVA: 0x001E8C78 File Offset: 0x001E6E78
		private bool __callBase_IsAttackingInBattleServer()
		{
			return base.IsAttackingInBattleServer();
		}

		// Token: 0x06006D63 RID: 28003 RVA: 0x001E8C80 File Offset: 0x001E6E80
		private void __callBase_FinishBattleInBattleServer()
		{
			base.FinishBattleInBattleServer();
		}

		// Token: 0x06006D64 RID: 28004 RVA: 0x001E8C88 File Offset: 0x001E6E88
		private int __callBase_CanCreateBattleRoom(BattleRoomType battleRoomType)
		{
			return base.CanCreateBattleRoom(battleRoomType);
		}

		// Token: 0x06006D65 RID: 28005 RVA: 0x001E8C94 File Offset: 0x001E6E94
		private int __callBase_CanCreateTeamBattleRoom()
		{
			return base.CanCreateTeamBattleRoom();
		}

		// Token: 0x06006D66 RID: 28006 RVA: 0x001E8C9C File Offset: 0x001E6E9C
		private int __callBase_CanChangePlayerBattleStatus(PlayerBattleStatus status)
		{
			return base.CanChangePlayerBattleStatus(status);
		}

		// Token: 0x06006D67 RID: 28007 RVA: 0x001E8CA8 File Offset: 0x001E6EA8
		private void __callBase_SetArenaBattleFighting()
		{
			base.SetArenaBattleFighting();
		}

		// Token: 0x06006D68 RID: 28008 RVA: 0x001E8CB0 File Offset: 0x001E6EB0
		private int __callBase_GetBattleId()
		{
			return base.GetBattleId();
		}

		// Token: 0x06006D69 RID: 28009 RVA: 0x001E8CB8 File Offset: 0x001E6EB8
		private int __callBase_GetBattleId(GameFunctionType typeId, int loctionId)
		{
			return base.GetBattleId(typeId, loctionId);
		}

		// Token: 0x06006D6A RID: 28010 RVA: 0x001E8CC4 File Offset: 0x001E6EC4
		private int __callBase_GetMonsterLevel()
		{
			return base.GetMonsterLevel();
		}

		// Token: 0x06006D6B RID: 28011 RVA: 0x001E8CCC File Offset: 0x001E6ECC
		private void __callBase_AddFightHeroFightNumsAndExp(List<int> heroes, int exp)
		{
			base.AddFightHeroFightNumsAndExp(heroes, exp);
		}

		// Token: 0x06006D6C RID: 28012 RVA: 0x001E8CD8 File Offset: 0x001E6ED8
		private List<int> __callBase_GetPveTeam()
		{
			return base.GetPveTeam();
		}

		// Token: 0x06006D6D RID: 28013 RVA: 0x001E8CE0 File Offset: 0x001E6EE0
		private int __callBase_IsMineTeamSetValid(int battleId, int battleType, List<int> fightHeroes)
		{
			return base.IsMineTeamSetValid(battleId, battleType, fightHeroes);
		}

		// Token: 0x06006D6E RID: 28014 RVA: 0x001E8CEC File Offset: 0x001E6EEC
		private int __callBase_IsArenaDefensiveTeamSetValid(int battleId, int teamCount)
		{
			return base.IsArenaDefensiveTeamSetValid(battleId, teamCount);
		}

		// Token: 0x06006D6F RID: 28015 RVA: 0x001E8CF8 File Offset: 0x001E6EF8
		private bool __callBase_IsActionPositionIndexValid(ConfigDataArenaBattleInfo battleInfo, int actionPositionIndex)
		{
			return base.IsActionPositionIndexValid(battleInfo, actionPositionIndex);
		}

		// Token: 0x06006D70 RID: 28016 RVA: 0x001E8D04 File Offset: 0x001E6F04
		private bool __callBase_IsActionValueValid(ConfigDataArenaBattleInfo battleInfo, int actionValue)
		{
			return base.IsActionValueValid(battleInfo, actionValue);
		}

		// Token: 0x06006D71 RID: 28017 RVA: 0x001E8D10 File Offset: 0x001E6F10
		private int __callBase_SetMineTeam(int battleId, int battleType, List<int> team)
		{
			return base.SetMineTeam(battleId, battleType, team);
		}

		// Token: 0x06006D72 RID: 28018 RVA: 0x001E8D1C File Offset: 0x001E6F1C
		private void __callBase_SetTeam(BattleType battleType, List<int> team)
		{
			base.SetTeam(battleType, team);
		}

		// Token: 0x06006D73 RID: 28019 RVA: 0x001E8D28 File Offset: 0x001E6F28
		private List<int> __callBase_GetTeam(BattleType battleType)
		{
			return base.GetTeam(battleType);
		}

		// Token: 0x06006D74 RID: 28020 RVA: 0x001E8D34 File Offset: 0x001E6F34
		private List<BattleHeroEquipment> __callBase_CreateMineBattleHeroEquipments(ulong[] equipmentIds)
		{
			return base.CreateMineBattleHeroEquipments(equipmentIds);
		}

		// Token: 0x06006D75 RID: 28021 RVA: 0x001E8D40 File Offset: 0x001E6F40
		private int __callBase_ComputeBattlePowerFromBattleHeroes(List<BattleHero> heroes, List<TrainingTech> techs)
		{
			return base.ComputeBattlePowerFromBattleHeroes(heroes, techs);
		}

		// Token: 0x06006D76 RID: 28022 RVA: 0x001E8D4C File Offset: 0x001E6F4C
		private int __callBase_ComputeBattlePower(Hero hero)
		{
			return base.ComputeBattlePower(hero);
		}

		// Token: 0x06006D77 RID: 28023 RVA: 0x001E8D58 File Offset: 0x001E6F58
		private int __callBase_ComputeBattlePower(BattleHero hero, List<TrainingTech> techs)
		{
			return base.ComputeBattlePower(hero, techs);
		}

		// Token: 0x06006D78 RID: 28024 RVA: 0x001E8D64 File Offset: 0x001E6F64
		private void __callBase_InitGainBattleTreasures()
		{
			base.InitGainBattleTreasures();
		}

		// Token: 0x06006D79 RID: 28025 RVA: 0x001E8D6C File Offset: 0x001E6F6C
		private void __callBase_AddGotBattleTreasuresInThisBattle()
		{
			base.AddGotBattleTreasuresInThisBattle();
		}

		// Token: 0x06006D7A RID: 28026 RVA: 0x001E8D74 File Offset: 0x001E6F74
		private void __callBase_AddBattleTreasures(List<int> battleTreasures)
		{
			base.AddBattleTreasures(battleTreasures);
		}

		// Token: 0x06006D7B RID: 28027 RVA: 0x001E8D80 File Offset: 0x001E6F80
		private List<int> __callBase_GetGainBattleTreasuresInThisBattle()
		{
			return base.GetGainBattleTreasuresInThisBattle();
		}

		// Token: 0x06006D7C RID: 28028 RVA: 0x001E8D88 File Offset: 0x001E6F88
		private List<Goods> __callBase_GetAllBattleBoxTreasuresInBattle(ConfigDataBattleInfo battleInfo)
		{
			return base.GetAllBattleBoxTreasuresInBattle(battleInfo);
		}

		// Token: 0x06006D7D RID: 28029 RVA: 0x001E8D94 File Offset: 0x001E6F94
		private void __callBase_OnBattlePracticeMissionEvent()
		{
			base.OnBattlePracticeMissionEvent();
		}

		// Token: 0x06006D7E RID: 28030 RVA: 0x001E8D9C File Offset: 0x001E6F9C
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
					this.m_DeSerializeDSBattleNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_GetDSVersion_hotfix = (luaObj.RawGet("GetDSVersion") as LuaFunction);
					this.m_SetBattleBaseBattleBase_hotfix = (luaObj.RawGet("SetBattleBase") as LuaFunction);
					this.m_GetBattleBase_hotfix = (luaObj.RawGet("GetBattleBase") as LuaFunction);
					this.m_IsRiftBattling_hotfix = (luaObj.RawGet("IsRiftBattling") as LuaFunction);
					this.m_IsTreasureMapBattling_hotfix = (luaObj.RawGet("IsTreasureMapBattling") as LuaFunction);
					this.m_GetBattleTeamInt32_hotfix = (luaObj.RawGet("GetBattleTeam") as LuaFunction);
					this.m_ClearFighting_hotfix = (luaObj.RawGet("ClearFighting") as LuaFunction);
					this.m_SetBattleRandomSeedInt32_hotfix = (luaObj.RawGet("SetBattleRandomSeed") as LuaFunction);
					this.m_SetArenaBattleRandomSeedInt32_hotfix = (luaObj.RawGet("SetArenaBattleRandomSeed") as LuaFunction);
					this.m_GetArenaBattleStatus_hotfix = (luaObj.RawGet("GetArenaBattleStatus") as LuaFunction);
					this.m_GetArenaBattleId_hotfix = (luaObj.RawGet("GetArenaBattleId") as LuaFunction);
					this.m_GetGotBattleTreasureIds_hotfix = (luaObj.RawGet("GetGotBattleTreasureIds") as LuaFunction);
					this.m_JoinTeamBattleRoomUInt64Int32GameFunctionTypeInt32List`1DateTime_hotfix = (luaObj.RawGet("JoinTeamBattleRoom") as LuaFunction);
					this.m_JoinPVPBattleRoomUInt64Int32List`1DateTime_hotfix = (luaObj.RawGet("JoinPVPBattleRoom") as LuaFunction);
					this.m_JoinRealtimePVPBattleRoomUInt64Int32List`1DateTimeBattleRoomType_hotfix = (luaObj.RawGet("JoinRealtimePVPBattleRoom") as LuaFunction);
					this.m_JoinGuildMassiveCombatBattleRoomUInt64Int32Int32List`1DateTimeList`1_hotfix = (luaObj.RawGet("JoinGuildMassiveCombatBattleRoom") as LuaFunction);
					this.m_QuitBattleRoom_hotfix = (luaObj.RawGet("QuitBattleRoom") as LuaFunction);
					this.m_SetRealtimePVPBattleRoomDataBattleRoomDataChangeNtf_hotfix = (luaObj.RawGet("SetRealtimePVPBattleRoomData") as LuaFunction);
					this.m_SetBattleRoomPlayerStatusUInt64PlayerBattleStatusBoolean_hotfix = (luaObj.RawGet("SetBattleRoomPlayerStatus") as LuaFunction);
					this.m_InitBattleRoomPlayerUInt64List`1_hotfix = (luaObj.RawGet("InitBattleRoomPlayer") as LuaFunction);
					this.m_BattleRoomHeroSetupProBattleHeroSetupInfo_hotfix = (luaObj.RawGet("BattleRoomHeroSetup") as LuaFunction);
					this.m_BattleRoomBattleStart_hotfix = (luaObj.RawGet("BattleRoomBattleStart") as LuaFunction);
					this.m_AppendBattleRoomCommandsList`1_hotfix = (luaObj.RawGet("AppendBattleRoomCommands") as LuaFunction);
					this.m_IsInBattleRoom_hotfix = (luaObj.RawGet("IsInBattleRoom") as LuaFunction);
					this.m_GetBattleRoom_hotfix = (luaObj.RawGet("GetBattleRoom") as LuaFunction);
					this.m_GetBattleReward_hotfix = (luaObj.RawGet("GetBattleReward") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006D7F RID: 28031 RVA: 0x001E9158 File Offset: 0x001E7358
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005344 RID: 21316
		private BattleRoom m_battleRoom = new BattleRoom();

		// Token: 0x04005345 RID: 21317
		private BattleReward m_battleReward = new BattleReward();

		// Token: 0x04005346 RID: 21318
		[DoNotToLua]
		private BattleComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005347 RID: 21319
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005348 RID: 21320
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005349 RID: 21321
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400534A RID: 21322
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400534B RID: 21323
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400534C RID: 21324
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400534D RID: 21325
		private LuaFunction m_DeSerializeDSBattleNtf_hotfix;

		// Token: 0x0400534E RID: 21326
		private LuaFunction m_GetDSVersion_hotfix;

		// Token: 0x0400534F RID: 21327
		private LuaFunction m_SetBattleBaseBattleBase_hotfix;

		// Token: 0x04005350 RID: 21328
		private LuaFunction m_GetBattleBase_hotfix;

		// Token: 0x04005351 RID: 21329
		private LuaFunction m_IsRiftBattling_hotfix;

		// Token: 0x04005352 RID: 21330
		private LuaFunction m_IsTreasureMapBattling_hotfix;

		// Token: 0x04005353 RID: 21331
		private LuaFunction m_GetBattleTeamInt32_hotfix;

		// Token: 0x04005354 RID: 21332
		private LuaFunction m_ClearFighting_hotfix;

		// Token: 0x04005355 RID: 21333
		private LuaFunction m_SetBattleRandomSeedInt32_hotfix;

		// Token: 0x04005356 RID: 21334
		private LuaFunction m_SetArenaBattleRandomSeedInt32_hotfix;

		// Token: 0x04005357 RID: 21335
		private LuaFunction m_GetArenaBattleStatus_hotfix;

		// Token: 0x04005358 RID: 21336
		private LuaFunction m_GetArenaBattleId_hotfix;

		// Token: 0x04005359 RID: 21337
		private LuaFunction m_GetGotBattleTreasureIds_hotfix;

		// Token: 0x0400535A RID: 21338
		private LuaFunction m_JoinTeamBattleRoomUInt64Int32GameFunctionTypeInt32List;

		// Token: 0x0400535B RID: 21339
		private LuaFunction m_JoinPVPBattleRoomUInt64Int32List;

		// Token: 0x0400535C RID: 21340
		private LuaFunction m_JoinRealtimePVPBattleRoomUInt64Int32List;

		// Token: 0x0400535D RID: 21341
		private LuaFunction m_JoinGuildMassiveCombatBattleRoomUInt64Int32Int32List`1DateTimeList;

		// Token: 0x0400535E RID: 21342
		private LuaFunction m_QuitBattleRoom_hotfix;

		// Token: 0x0400535F RID: 21343
		private LuaFunction m_SetRealtimePVPBattleRoomDataBattleRoomDataChangeNtf_hotfix;

		// Token: 0x04005360 RID: 21344
		private LuaFunction m_SetBattleRoomPlayerStatusUInt64PlayerBattleStatusBoolean_hotfix;

		// Token: 0x04005361 RID: 21345
		private LuaFunction m_InitBattleRoomPlayerUInt64List;

		// Token: 0x04005362 RID: 21346
		private LuaFunction m_BattleRoomHeroSetupProBattleHeroSetupInfo_hotfix;

		// Token: 0x04005363 RID: 21347
		private LuaFunction m_BattleRoomBattleStart_hotfix;

		// Token: 0x04005364 RID: 21348
		private LuaFunction m_AppendBattleRoomCommandsList;

		// Token: 0x04005365 RID: 21349
		private LuaFunction m_IsInBattleRoom_hotfix;

		// Token: 0x04005366 RID: 21350
		private LuaFunction m_GetBattleRoom_hotfix;

		// Token: 0x04005367 RID: 21351
		private LuaFunction m_GetBattleReward_hotfix;

		// Token: 0x0200088D RID: 2189
		public new class LuaExportHelper
		{
			// Token: 0x06006D80 RID: 28032 RVA: 0x001E91C0 File Offset: 0x001E73C0
			public LuaExportHelper(BattleComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06006D81 RID: 28033 RVA: 0x001E91D0 File Offset: 0x001E73D0
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x06006D82 RID: 28034 RVA: 0x001E91E0 File Offset: 0x001E73E0
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x06006D83 RID: 28035 RVA: 0x001E91F0 File Offset: 0x001E73F0
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x06006D84 RID: 28036 RVA: 0x001E9200 File Offset: 0x001E7400
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x06006D85 RID: 28037 RVA: 0x001E9210 File Offset: 0x001E7410
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x06006D86 RID: 28038 RVA: 0x001E9220 File Offset: 0x001E7420
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x06006D87 RID: 28039 RVA: 0x001E9230 File Offset: 0x001E7430
			public bool __callBase_IsGameFunctionOpenByMonthCard(GameFunctionType gameFuncTypeId)
			{
				return this.m_owner.__callBase_IsGameFunctionOpenByMonthCard(gameFuncTypeId);
			}

			// Token: 0x06006D88 RID: 28040 RVA: 0x001E9240 File Offset: 0x001E7440
			public int __callBase_GetDailyBonusMaxNums(GameFunctionType gameFuncTypeId)
			{
				return this.m_owner.__callBase_GetDailyBonusMaxNums(gameFuncTypeId);
			}

			// Token: 0x06006D89 RID: 28041 RVA: 0x001E9250 File Offset: 0x001E7450
			public int __callBase_GetSinglePveBattleFailEnergyCostByMonthCard()
			{
				return this.m_owner.__callBase_GetSinglePveBattleFailEnergyCostByMonthCard();
			}

			// Token: 0x06006D8A RID: 28042 RVA: 0x001E9260 File Offset: 0x001E7460
			public int __callBase_GetTeamPveBattleFailEnergyCost(GameFunctionType typeId, int locationId)
			{
				return this.m_owner.__callBase_GetTeamPveBattleFailEnergyCost(typeId, locationId);
			}

			// Token: 0x06006D8B RID: 28043 RVA: 0x001E9270 File Offset: 0x001E7470
			public int __callBase_GetTeamPveBattleFailEnergyCostByMonthCard(GameFunctionType typeId, int locationId)
			{
				return this.m_owner.__callBase_GetTeamPveBattleFailEnergyCostByMonthCard(typeId, locationId);
			}

			// Token: 0x06006D8C RID: 28044 RVA: 0x001E9280 File Offset: 0x001E7480
			public void __callBase_AddTeamPveFightFailCompensationEnergyByMonthCard(GameFunctionType typeId, int locationId)
			{
				this.m_owner.__callBase_AddTeamPveFightFailCompensationEnergyByMonthCard(typeId, locationId);
			}

			// Token: 0x06006D8D RID: 28045 RVA: 0x001E9290 File Offset: 0x001E7490
			public bool __callBase_IsWaypointBattling()
			{
				return this.m_owner.__callBase_IsWaypointBattling();
			}

			// Token: 0x06006D8E RID: 28046 RVA: 0x001E92A0 File Offset: 0x001E74A0
			public bool __callBase_IsBattleWin()
			{
				return this.m_owner.__callBase_IsBattleWin();
			}

			// Token: 0x06006D8F RID: 28047 RVA: 0x001E92B0 File Offset: 0x001E74B0
			public int __callBase_CancelBattle()
			{
				return this.m_owner.__callBase_CancelBattle();
			}

			// Token: 0x06006D90 RID: 28048 RVA: 0x001E92C0 File Offset: 0x001E74C0
			public bool __callBase_IsFighting()
			{
				return this.m_owner.__callBase_IsFighting();
			}

			// Token: 0x06006D91 RID: 28049 RVA: 0x001E92D0 File Offset: 0x001E74D0
			public bool __callBase_CanSetupMineTeam()
			{
				return this.m_owner.__callBase_CanSetupMineTeam();
			}

			// Token: 0x06006D92 RID: 28050 RVA: 0x001E92E0 File Offset: 0x001E74E0
			public void __callBase_FightFinished(GameFunctionStatus status, bool win, bool needBatlleLog)
			{
				this.m_owner.__callBase_FightFinished(status, win, needBatlleLog);
			}

			// Token: 0x06006D93 RID: 28051 RVA: 0x001E92F0 File Offset: 0x001E74F0
			public bool __callBase_IsWayPointFightExist(int wayPointId)
			{
				return this.m_owner.__callBase_IsWayPointFightExist(wayPointId);
			}

			// Token: 0x06006D94 RID: 28052 RVA: 0x001E9300 File Offset: 0x001E7500
			public void __callBase_WinPveBattle(int battleId)
			{
				this.m_owner.__callBase_WinPveBattle(battleId);
			}

			// Token: 0x06006D95 RID: 28053 RVA: 0x001E9310 File Offset: 0x001E7510
			public void __callBase_FinishedArenaFight()
			{
				this.m_owner.__callBase_FinishedArenaFight();
			}

			// Token: 0x06006D96 RID: 28054 RVA: 0x001E9320 File Offset: 0x001E7520
			public ProcessingBattle __callBase_GetProcessingBattle()
			{
				return this.m_owner.__callBase_GetProcessingBattle();
			}

			// Token: 0x06006D97 RID: 28055 RVA: 0x001E9330 File Offset: 0x001E7530
			public void __callBase_SetProcessingBattleInfo(BattleType type, int typeId)
			{
				this.m_owner.__callBase_SetProcessingBattleInfo(type, typeId);
			}

			// Token: 0x06006D98 RID: 28056 RVA: 0x001E9340 File Offset: 0x001E7540
			public void __callBase_SetBattleArmyRandomSeed(int armyRandomSeed)
			{
				this.m_owner.__callBase_SetBattleArmyRandomSeed(armyRandomSeed);
			}

			// Token: 0x06006D99 RID: 28057 RVA: 0x001E9350 File Offset: 0x001E7550
			public int __callBase_GetBattleArmyRandomSeed()
			{
				return this.m_owner.__callBase_GetBattleArmyRandomSeed();
			}

			// Token: 0x06006D9A RID: 28058 RVA: 0x001E9360 File Offset: 0x001E7560
			public void __callBase_SetArenaBattleInfo(int arenaBattleId)
			{
				this.m_owner.__callBase_SetArenaBattleInfo(arenaBattleId);
			}

			// Token: 0x06006D9B RID: 28059 RVA: 0x001E9370 File Offset: 0x001E7570
			public bool __callBase_IsAttackingPveLevel(BattleType battleType, int levelId)
			{
				return this.m_owner.__callBase_IsAttackingPveLevel(battleType, levelId);
			}

			// Token: 0x06006D9C RID: 28060 RVA: 0x001E9380 File Offset: 0x001E7580
			public bool __callBase_IsAttackingArenaOpponent()
			{
				return this.m_owner.__callBase_IsAttackingArenaOpponent();
			}

			// Token: 0x06006D9D RID: 28061 RVA: 0x001E9390 File Offset: 0x001E7590
			public bool __callBase_IsArenaBattleInReady()
			{
				return this.m_owner.__callBase_IsArenaBattleInReady();
			}

			// Token: 0x06006D9E RID: 28062 RVA: 0x001E93A0 File Offset: 0x001E75A0
			public bool __callBase_IsAttackingInBattleServer()
			{
				return this.m_owner.__callBase_IsAttackingInBattleServer();
			}

			// Token: 0x06006D9F RID: 28063 RVA: 0x001E93B0 File Offset: 0x001E75B0
			public void __callBase_FinishBattleInBattleServer()
			{
				this.m_owner.__callBase_FinishBattleInBattleServer();
			}

			// Token: 0x06006DA0 RID: 28064 RVA: 0x001E93C0 File Offset: 0x001E75C0
			public int __callBase_CanCreateBattleRoom(BattleRoomType battleRoomType)
			{
				return this.m_owner.__callBase_CanCreateBattleRoom(battleRoomType);
			}

			// Token: 0x06006DA1 RID: 28065 RVA: 0x001E93D0 File Offset: 0x001E75D0
			public int __callBase_CanCreateTeamBattleRoom()
			{
				return this.m_owner.__callBase_CanCreateTeamBattleRoom();
			}

			// Token: 0x06006DA2 RID: 28066 RVA: 0x001E93E0 File Offset: 0x001E75E0
			public int __callBase_CanChangePlayerBattleStatus(PlayerBattleStatus status)
			{
				return this.m_owner.__callBase_CanChangePlayerBattleStatus(status);
			}

			// Token: 0x06006DA3 RID: 28067 RVA: 0x001E93F0 File Offset: 0x001E75F0
			public void __callBase_SetArenaBattleFighting()
			{
				this.m_owner.__callBase_SetArenaBattleFighting();
			}

			// Token: 0x06006DA4 RID: 28068 RVA: 0x001E9400 File Offset: 0x001E7600
			public int __callBase_GetBattleId()
			{
				return this.m_owner.__callBase_GetBattleId();
			}

			// Token: 0x06006DA5 RID: 28069 RVA: 0x001E9410 File Offset: 0x001E7610
			public int __callBase_GetBattleId(GameFunctionType typeId, int loctionId)
			{
				return this.m_owner.__callBase_GetBattleId(typeId, loctionId);
			}

			// Token: 0x06006DA6 RID: 28070 RVA: 0x001E9420 File Offset: 0x001E7620
			public int __callBase_GetMonsterLevel()
			{
				return this.m_owner.__callBase_GetMonsterLevel();
			}

			// Token: 0x06006DA7 RID: 28071 RVA: 0x001E9430 File Offset: 0x001E7630
			public void __callBase_AddFightHeroFightNumsAndExp(List<int> heroes, int exp)
			{
				this.m_owner.__callBase_AddFightHeroFightNumsAndExp(heroes, exp);
			}

			// Token: 0x06006DA8 RID: 28072 RVA: 0x001E9440 File Offset: 0x001E7640
			public List<int> __callBase_GetPveTeam()
			{
				return this.m_owner.__callBase_GetPveTeam();
			}

			// Token: 0x06006DA9 RID: 28073 RVA: 0x001E9450 File Offset: 0x001E7650
			public int __callBase_IsMineTeamSetValid(int battleId, int battleType, List<int> fightHeroes)
			{
				return this.m_owner.__callBase_IsMineTeamSetValid(battleId, battleType, fightHeroes);
			}

			// Token: 0x06006DAA RID: 28074 RVA: 0x001E9460 File Offset: 0x001E7660
			public int __callBase_IsArenaDefensiveTeamSetValid(int battleId, int teamCount)
			{
				return this.m_owner.__callBase_IsArenaDefensiveTeamSetValid(battleId, teamCount);
			}

			// Token: 0x06006DAB RID: 28075 RVA: 0x001E9470 File Offset: 0x001E7670
			public bool __callBase_IsActionPositionIndexValid(ConfigDataArenaBattleInfo battleInfo, int actionPositionIndex)
			{
				return this.m_owner.__callBase_IsActionPositionIndexValid(battleInfo, actionPositionIndex);
			}

			// Token: 0x06006DAC RID: 28076 RVA: 0x001E9480 File Offset: 0x001E7680
			public bool __callBase_IsActionValueValid(ConfigDataArenaBattleInfo battleInfo, int actionValue)
			{
				return this.m_owner.__callBase_IsActionValueValid(battleInfo, actionValue);
			}

			// Token: 0x06006DAD RID: 28077 RVA: 0x001E9490 File Offset: 0x001E7690
			public int __callBase_SetMineTeam(int battleId, int battleType, List<int> team)
			{
				return this.m_owner.__callBase_SetMineTeam(battleId, battleType, team);
			}

			// Token: 0x06006DAE RID: 28078 RVA: 0x001E94A0 File Offset: 0x001E76A0
			public void __callBase_SetTeam(BattleType battleType, List<int> team)
			{
				this.m_owner.__callBase_SetTeam(battleType, team);
			}

			// Token: 0x06006DAF RID: 28079 RVA: 0x001E94B0 File Offset: 0x001E76B0
			public List<int> __callBase_GetTeam(BattleType battleType)
			{
				return this.m_owner.__callBase_GetTeam(battleType);
			}

			// Token: 0x06006DB0 RID: 28080 RVA: 0x001E94C0 File Offset: 0x001E76C0
			public List<BattleHeroEquipment> __callBase_CreateMineBattleHeroEquipments(ulong[] equipmentIds)
			{
				return this.m_owner.__callBase_CreateMineBattleHeroEquipments(equipmentIds);
			}

			// Token: 0x06006DB1 RID: 28081 RVA: 0x001E94D0 File Offset: 0x001E76D0
			public int __callBase_ComputeBattlePowerFromBattleHeroes(List<BattleHero> heroes, List<TrainingTech> techs)
			{
				return this.m_owner.__callBase_ComputeBattlePowerFromBattleHeroes(heroes, techs);
			}

			// Token: 0x06006DB2 RID: 28082 RVA: 0x001E94E0 File Offset: 0x001E76E0
			public int __callBase_ComputeBattlePower(Hero hero)
			{
				return this.m_owner.__callBase_ComputeBattlePower(hero);
			}

			// Token: 0x06006DB3 RID: 28083 RVA: 0x001E94F0 File Offset: 0x001E76F0
			public int __callBase_ComputeBattlePower(BattleHero hero, List<TrainingTech> techs)
			{
				return this.m_owner.__callBase_ComputeBattlePower(hero, techs);
			}

			// Token: 0x06006DB4 RID: 28084 RVA: 0x001E9500 File Offset: 0x001E7700
			public void __callBase_InitGainBattleTreasures()
			{
				this.m_owner.__callBase_InitGainBattleTreasures();
			}

			// Token: 0x06006DB5 RID: 28085 RVA: 0x001E9510 File Offset: 0x001E7710
			public void __callBase_AddGotBattleTreasuresInThisBattle()
			{
				this.m_owner.__callBase_AddGotBattleTreasuresInThisBattle();
			}

			// Token: 0x06006DB6 RID: 28086 RVA: 0x001E9520 File Offset: 0x001E7720
			public void __callBase_AddBattleTreasures(List<int> battleTreasures)
			{
				this.m_owner.__callBase_AddBattleTreasures(battleTreasures);
			}

			// Token: 0x06006DB7 RID: 28087 RVA: 0x001E9530 File Offset: 0x001E7730
			public List<int> __callBase_GetGainBattleTreasuresInThisBattle()
			{
				return this.m_owner.__callBase_GetGainBattleTreasuresInThisBattle();
			}

			// Token: 0x06006DB8 RID: 28088 RVA: 0x001E9540 File Offset: 0x001E7740
			public List<Goods> __callBase_GetAllBattleBoxTreasuresInBattle(ConfigDataBattleInfo battleInfo)
			{
				return this.m_owner.__callBase_GetAllBattleBoxTreasuresInBattle(battleInfo);
			}

			// Token: 0x06006DB9 RID: 28089 RVA: 0x001E9550 File Offset: 0x001E7750
			public void __callBase_OnBattlePracticeMissionEvent()
			{
				this.m_owner.__callBase_OnBattlePracticeMissionEvent();
			}

			// Token: 0x17001B9B RID: 7067
			// (get) Token: 0x06006DBA RID: 28090 RVA: 0x001E9560 File Offset: 0x001E7760
			// (set) Token: 0x06006DBB RID: 28091 RVA: 0x001E9570 File Offset: 0x001E7770
			public BattleRoom m_battleRoom
			{
				get
				{
					return this.m_owner.m_battleRoom;
				}
				set
				{
					this.m_owner.m_battleRoom = value;
				}
			}

			// Token: 0x17001B9C RID: 7068
			// (get) Token: 0x06006DBC RID: 28092 RVA: 0x001E9580 File Offset: 0x001E7780
			// (set) Token: 0x06006DBD RID: 28093 RVA: 0x001E9590 File Offset: 0x001E7790
			public BattleReward m_battleReward
			{
				get
				{
					return this.m_owner.m_battleReward;
				}
				set
				{
					this.m_owner.m_battleReward = value;
				}
			}

			// Token: 0x04005368 RID: 21352
			private BattleComponent m_owner;
		}
	}
}
