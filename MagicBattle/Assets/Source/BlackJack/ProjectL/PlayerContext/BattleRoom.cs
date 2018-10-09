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
	// Token: 0x0200088E RID: 2190
	[HotFix]
	public class BattleRoom
	{
		// Token: 0x06006DBE RID: 28094 RVA: 0x001E95A0 File Offset: 0x001E77A0
		public BattleRoom()
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

		// Token: 0x06006DBF RID: 28095 RVA: 0x001E964C File Offset: 0x001E784C
		public void Clear()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_Clear_hotfix != null)
			{
				this.m_Clear_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.BattleRoomType = (BattleRoomType)0;
			this.BattleId = 0;
			this.GameFunctionType = GameFunctionType.GameFunctionType_None;
			this.LocationId = 0;
			this.BattleRoomStatus = BattleRoomStatus.Ready;
			this.ReadyTimeout = DateTime.MinValue;
			this.LastPlayerBeginActionTime = DateTime.MinValue;
			this.Players.Clear();
			this.BattleRoomPlayerHeroSetup.Clear();
			this.MyPlayerIndex = -1;
			this.LeaderPlayerIndex = -1;
			this.BattleCommands.Clear();
			this.BattleStars = 0;
			this.BattleReward = null;
			this.PVPWinSessionId = 0UL;
			this.BPRule = BattleRoomBPRule.Default;
			this.BPTurn = 0;
			this.BPStatus = BattleRoomBPStatus.Pick;
			this.LatestTurnChangeDateTime = DateTime.MaxValue;
			this.RealtimePVPBattleInstanceId = 0UL;
		}

		// Token: 0x06006DC0 RID: 28096 RVA: 0x001E9754 File Offset: 0x001E7954
		public void InitPlayers(List<ProBattleRoomPlayer> players)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_InitPlayersList`1_hotfix != null)
			{
				this.m_InitPlayersList`1_hotfix.call(new object[]
				{
					this,
					players
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Players.Clear();
			foreach (ProBattleRoomPlayer pbPlayer in players)
			{
				BattleRoomPlayer battleRoomPlayer = BattleRoomPlayer.PbBattleRoomPlayerToBattleRoomPlayer(pbPlayer);
				foreach (TrainingTech trainingTech in battleRoomPlayer.Techs)
				{
					trainingTech.ConfigDataLoader = (GameManager.Instance.ConfigDataLoader as IConfigDataLoader);
				}
				this.Players.Add(battleRoomPlayer);
			}
		}

		// Token: 0x06006DC1 RID: 28097 RVA: 0x001E9880 File Offset: 0x001E7A80
		public BattleRoomPlayer FindPlayerBySessionId(ulong sessionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPlayerBySessionIdUInt64_hotfix != null)
			{
				return (BattleRoomPlayer)this.m_FindPlayerBySessionIdUInt64_hotfix.call(new object[]
				{
					this,
					sessionId2
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ulong sessionId = sessionId2;
			return this.Players.Find((BattleRoomPlayer m) => m.SessionId == sessionId);
		}

		// Token: 0x06006DC2 RID: 28098 RVA: 0x001E9920 File Offset: 0x001E7B20
		public BattleRoomPlayer FindPlayerByUserId(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPlayerByUserIdString_hotfix != null)
			{
				return (BattleRoomPlayer)this.m_FindPlayerByUserIdString_hotfix.call(new object[]
				{
					this,
					userId
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = this.FindPlayerIndex(userId);
			if (num >= 0)
			{
				return this.Players[num];
			}
			return null;
		}

		// Token: 0x06006DC3 RID: 28099 RVA: 0x001E99BC File Offset: 0x001E7BBC
		public void SetMyPlayer(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetMyPlayerString_hotfix != null)
			{
				this.m_SetMyPlayerString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.MyPlayerIndex = this.FindPlayerIndex(userId);
		}

		// Token: 0x06006DC4 RID: 28100 RVA: 0x001E9A3C File Offset: 0x001E7C3C
		public void SetLeaderPlayer(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_SetLeaderPlayerString_hotfix != null)
			{
				this.m_SetLeaderPlayerString_hotfix.call(new object[]
				{
					this,
					userId
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.LeaderPlayerIndex = this.FindPlayerIndex(userId);
		}

		// Token: 0x06006DC5 RID: 28101 RVA: 0x001E9ABC File Offset: 0x001E7CBC
		public int FindPlayerIndex(string userId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPlayerIndexString_hotfix != null)
			{
				return Convert.ToInt32(this.m_FindPlayerIndexString_hotfix.call(new object[]
				{
					this,
					userId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			string userId = userId2;
			return this.Players.FindIndex((BattleRoomPlayer x) => x.UserId == userId && x.SessionId != 0UL);
		}

		// Token: 0x06006DC6 RID: 28102 RVA: 0x001E9B5C File Offset: 0x001E7D5C
		public int FindPlayerIndexBySessiongId(ulong sessionId)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_FindPlayerIndexBySessiongIdUInt64_hotfix != null)
			{
				return Convert.ToInt32(this.m_FindPlayerIndexBySessiongIdUInt64_hotfix.call(new object[]
				{
					this,
					sessionId2
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			ulong sessionId = sessionId2;
			return this.Players.FindIndex((BattleRoomPlayer x) => x.SessionId == sessionId);
		}

		// Token: 0x06006DC7 RID: 28103 RVA: 0x001E9BFC File Offset: 0x001E7DFC
		public BattleRoomPlayer GetMyPlayer()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetMyPlayer_hotfix != null)
			{
				return (BattleRoomPlayer)this.m_GetMyPlayer_hotfix.call(new object[]
				{
					this
				});
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.MyPlayerIndex >= 0)
			{
				return this.Players[this.MyPlayerIndex];
			}
			return null;
		}

		// Token: 0x06006DC8 RID: 28104 RVA: 0x001E9C88 File Offset: 0x001E7E88
		public bool IsTeamOrGuildMassiveCombatRoomType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsTeamOrGuildMassiveCombatRoomType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsTeamOrGuildMassiveCombatRoomType_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.BattleRoomType == BattleRoomType.Team || this.BattleRoomType == BattleRoomType.GuildMassiveCombat;
		}

		// Token: 0x06006DC9 RID: 28105 RVA: 0x001E9D0C File Offset: 0x001E7F0C
		public bool IsAnyPVPBattleRoomType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsAnyPVPBattleRoomType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsAnyPVPBattleRoomType_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.BattleRoomType == BattleRoomType.PVP || this.BattleRoomType == BattleRoomType.RealTimePVPBPMode || this.BattleRoomType == BattleRoomType.RealTimePVPDefaultMode;
		}

		// Token: 0x06006DCA RID: 28106 RVA: 0x001E9D9C File Offset: 0x001E7F9C
		public bool IsRealTimePVPBattleRoomType()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsRealTimePVPBattleRoomType_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsRealTimePVPBattleRoomType_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.BattleRoomType == BattleRoomType.RealTimePVPBPMode || this.BattleRoomType == BattleRoomType.RealTimePVPDefaultMode;
		}

		// Token: 0x06006DCB RID: 28107 RVA: 0x001E9E20 File Offset: 0x001E8020
		public int GetPlayerIndexInCurrentPickTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetPlayerIndexInCurrentPickTurn_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetPlayerIndexInCurrentPickTurn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			return this.BPTurn % 2;
		}

		// Token: 0x06006DCC RID: 28108 RVA: 0x001E9E94 File Offset: 0x001E8094
		public int GetHeroSetupCountMaxInPickTurn(int turn)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroSetupCountMaxInPickTurnInt32_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroSetupCountMaxInPickTurnInt32_hotfix.call(new object[]
				{
					this,
					turn
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			IConfigDataLoader configDataLoader = GameManager.Instance.ConfigDataLoader as IConfigDataLoader;
			switch (turn)
			{
			case 0:
				return (this.BPRule != BattleRoomBPRule.PickOnly) ? configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn1) : configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPSilverHeroCount_Turn1);
			case 1:
				return (this.BPRule != BattleRoomBPRule.PickOnly) ? configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn2) : configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPSilverHeroCount_Turn2);
			case 2:
				return (this.BPRule != BattleRoomBPRule.PickOnly) ? configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn3) : configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPSilverHeroCount_Turn3);
			case 3:
				return (this.BPRule != BattleRoomBPRule.PickOnly) ? configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn4) : configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPSilverHeroCount_Turn4);
			case 4:
				return (this.BPRule != BattleRoomBPRule.PickOnly) ? configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn5) : configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPSilverHeroCount_Turn5);
			case 5:
				return (this.BPRule != BattleRoomBPRule.PickOnly) ? configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn6) : configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPSilverHeroCount_Turn6);
			case 6:
				if (this.BPRule == BattleRoomBPRule.PickOnly)
				{
					throw new ArgumentException(string.Format("RealTimePVPRoom with rule {0} should not have BPTurn = {1}", this.BPRule, this.BPTurn));
				}
				return configDataLoader.UtilityGetConfigableConst(ConfigableConstId.ConfigableConstId_RealTimePVPGoldHeroCount_Turn7);
			default:
				throw new ArgumentException(string.Format("RealTimePVPRoom should not have BPTurn = {0}", this.BPTurn));
			}
		}

		// Token: 0x06006DCD RID: 28109 RVA: 0x001EA094 File Offset: 0x001E8294
		public int GetHeroSetupCountInCurrentPickTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroSetupCountInCurrentPickTurn_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroSetupCountInCurrentPickTurn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.BPTurn >= 2)
			{
				return this.GetHeroSetupCountMaxInPickTurn(this.BPTurn) - this.GetHeroSetupCountMaxInPickTurn(this.BPTurn - 2);
			}
			return this.GetHeroSetupCountMaxInPickTurn(this.BPTurn);
		}

		// Token: 0x06006DCE RID: 28110 RVA: 0x001EA134 File Offset: 0x001E8334
		public int GetRemainHeroSetupCountInCurrentPickTurn()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetRemainHeroSetupCountInCurrentPickTurn_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetRemainHeroSetupCountInCurrentPickTurn_hotfix.call(new object[]
				{
					this
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int playerIndexInCurrentPickTurn = this.GetPlayerIndexInCurrentPickTurn();
			int heroSetupCountMaxInPickTurn = this.GetHeroSetupCountMaxInPickTurn(this.BPTurn);
			int heroCountByPlayerIndex = this.BattleRoomPlayerHeroSetup.GetHeroCountByPlayerIndex(playerIndexInCurrentPickTurn);
			return heroSetupCountMaxInPickTurn - heroCountByPlayerIndex;
		}

		// Token: 0x06006DCF RID: 28111 RVA: 0x001EA1C4 File Offset: 0x001E83C4
		public int GetHeroSetupFlagCount(int playerIndex, SetupBattleHeroFlag flag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_GetHeroSetupFlagCountInt32SetupBattleHeroFlag_hotfix != null)
			{
				return Convert.ToInt32(this.m_GetHeroSetupFlagCountInt32SetupBattleHeroFlag_hotfix.call(new object[]
				{
					this,
					playerIndex,
					flag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int num = 0;
			foreach (BattleHeroSetupInfo battleHeroSetupInfo in this.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfos())
			{
				if (battleHeroSetupInfo.HasFlag(flag))
				{
					num++;
				}
			}
			return num;
		}

		// Token: 0x06006DD0 RID: 28112 RVA: 0x001EA2B0 File Offset: 0x001E84B0
		public bool IsHeroSetupHasFlag(int playerIndex, int heroId, SetupBattleHeroFlag flag)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_IsHeroSetupHasFlagInt32Int32SetupBattleHeroFlag_hotfix != null)
			{
				return Convert.ToBoolean(this.m_IsHeroSetupHasFlagInt32Int32SetupBattleHeroFlag_hotfix.call(new object[]
				{
					this,
					playerIndex,
					heroId,
					flag
				}));
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int heroPos = this.BattleRoomPlayerHeroSetup.FindHeroPosition(playerIndex, heroId);
			BattleHeroSetupInfo battleHeroSetupInfo = this.BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(heroPos);
			return battleHeroSetupInfo != null && battleHeroSetupInfo.HasFlag(flag);
		}

		// Token: 0x17001B9D RID: 7069
		// (get) Token: 0x06006DD1 RID: 28113 RVA: 0x001EA378 File Offset: 0x001E8578
		// (set) Token: 0x06006DD2 RID: 28114 RVA: 0x001EA398 File Offset: 0x001E8598
		[DoNotToLua]
		public BattleRoom.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new BattleRoom.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06006DD3 RID: 28115 RVA: 0x001EA3A4 File Offset: 0x001E85A4
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
					this.m_Clear_hotfix = (luaObj.RawGet("Clear") as LuaFunction);
					this.m_InitPlayersList`1_hotfix = (luaObj.RawGet("InitPlayers") as LuaFunction);
					this.m_FindPlayerBySessionIdUInt64_hotfix = (luaObj.RawGet("FindPlayerBySessionId") as LuaFunction);
					this.m_FindPlayerByUserIdString_hotfix = (luaObj.RawGet("FindPlayerByUserId") as LuaFunction);
					this.m_SetMyPlayerString_hotfix = (luaObj.RawGet("SetMyPlayer") as LuaFunction);
					this.m_SetLeaderPlayerString_hotfix = (luaObj.RawGet("SetLeaderPlayer") as LuaFunction);
					this.m_FindPlayerIndexString_hotfix = (luaObj.RawGet("FindPlayerIndex") as LuaFunction);
					this.m_FindPlayerIndexBySessiongIdUInt64_hotfix = (luaObj.RawGet("FindPlayerIndexBySessiongId") as LuaFunction);
					this.m_GetMyPlayer_hotfix = (luaObj.RawGet("GetMyPlayer") as LuaFunction);
					this.m_IsTeamOrGuildMassiveCombatRoomType_hotfix = (luaObj.RawGet("IsTeamOrGuildMassiveCombatRoomType") as LuaFunction);
					this.m_IsAnyPVPBattleRoomType_hotfix = (luaObj.RawGet("IsAnyPVPBattleRoomType") as LuaFunction);
					this.m_IsRealTimePVPBattleRoomType_hotfix = (luaObj.RawGet("IsRealTimePVPBattleRoomType") as LuaFunction);
					this.m_GetPlayerIndexInCurrentPickTurn_hotfix = (luaObj.RawGet("GetPlayerIndexInCurrentPickTurn") as LuaFunction);
					this.m_GetHeroSetupCountMaxInPickTurnInt32_hotfix = (luaObj.RawGet("GetHeroSetupCountMaxInPickTurn") as LuaFunction);
					this.m_GetHeroSetupCountInCurrentPickTurn_hotfix = (luaObj.RawGet("GetHeroSetupCountInCurrentPickTurn") as LuaFunction);
					this.m_GetRemainHeroSetupCountInCurrentPickTurn_hotfix = (luaObj.RawGet("GetRemainHeroSetupCountInCurrentPickTurn") as LuaFunction);
					this.m_GetHeroSetupFlagCountInt32SetupBattleHeroFlag_hotfix = (luaObj.RawGet("GetHeroSetupFlagCount") as LuaFunction);
					this.m_IsHeroSetupHasFlagInt32Int32SetupBattleHeroFlag_hotfix = (luaObj.RawGet("IsHeroSetupHasFlag") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06006DD4 RID: 28116 RVA: 0x001EA634 File Offset: 0x001E8834
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(BattleRoom));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005369 RID: 21353
		public ulong RoomId;

		// Token: 0x0400536A RID: 21354
		public BattleRoomType BattleRoomType;

		// Token: 0x0400536B RID: 21355
		public int BattleId;

		// Token: 0x0400536C RID: 21356
		public GameFunctionType GameFunctionType;

		// Token: 0x0400536D RID: 21357
		public int LocationId;

		// Token: 0x0400536E RID: 21358
		public BattleRoomStatus BattleRoomStatus;

		// Token: 0x0400536F RID: 21359
		public DateTime ReadyTimeout;

		// Token: 0x04005370 RID: 21360
		public DateTime LastPlayerBeginActionTime;

		// Token: 0x04005371 RID: 21361
		public List<BattleRoomPlayer> Players = new List<BattleRoomPlayer>();

		// Token: 0x04005372 RID: 21362
		public BattleRoomPlayerHeroSetup BattleRoomPlayerHeroSetup = new BattleRoomPlayerHeroSetup();

		// Token: 0x04005373 RID: 21363
		public int MyPlayerIndex = -1;

		// Token: 0x04005374 RID: 21364
		public int LeaderPlayerIndex = -1;

		// Token: 0x04005375 RID: 21365
		public List<BattleCommand> BattleCommands = new List<BattleCommand>();

		// Token: 0x04005376 RID: 21366
		public int BattleStars;

		// Token: 0x04005377 RID: 21367
		public BattleReward BattleReward;

		// Token: 0x04005378 RID: 21368
		public ulong PVPWinSessionId;

		// Token: 0x04005379 RID: 21369
		public BattleMode BattleMode;

		// Token: 0x0400537A RID: 21370
		public BattleRoomBPRule BPRule;

		// Token: 0x0400537B RID: 21371
		public int BPTurn;

		// Token: 0x0400537C RID: 21372
		public BattleRoomBPStatus BPStatus;

		// Token: 0x0400537D RID: 21373
		public DateTime LatestTurnChangeDateTime = DateTime.MaxValue;

		// Token: 0x0400537E RID: 21374
		public ulong RealtimePVPBattleInstanceId;

		// Token: 0x0400537F RID: 21375
		public List<int> PreferredHeroTagIds = new List<int>();

		// Token: 0x04005380 RID: 21376
		[DoNotToLua]
		private BattleRoom.LuaExportHelper luaExportHelper;

		// Token: 0x04005381 RID: 21377
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x04005382 RID: 21378
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x04005383 RID: 21379
		private LuaFunction m_ctor_hotfix;

		// Token: 0x04005384 RID: 21380
		private LuaFunction m_Clear_hotfix;

		// Token: 0x04005385 RID: 21381
		private LuaFunction m_InitPlayersList;

		// Token: 0x04005386 RID: 21382
		private LuaFunction m_FindPlayerBySessionIdUInt64_hotfix;

		// Token: 0x04005387 RID: 21383
		private LuaFunction m_FindPlayerByUserIdString_hotfix;

		// Token: 0x04005388 RID: 21384
		private LuaFunction m_SetMyPlayerString_hotfix;

		// Token: 0x04005389 RID: 21385
		private LuaFunction m_SetLeaderPlayerString_hotfix;

		// Token: 0x0400538A RID: 21386
		private LuaFunction m_FindPlayerIndexString_hotfix;

		// Token: 0x0400538B RID: 21387
		private LuaFunction m_FindPlayerIndexBySessiongIdUInt64_hotfix;

		// Token: 0x0400538C RID: 21388
		private LuaFunction m_GetMyPlayer_hotfix;

		// Token: 0x0400538D RID: 21389
		private LuaFunction m_IsTeamOrGuildMassiveCombatRoomType_hotfix;

		// Token: 0x0400538E RID: 21390
		private LuaFunction m_IsAnyPVPBattleRoomType_hotfix;

		// Token: 0x0400538F RID: 21391
		private LuaFunction m_IsRealTimePVPBattleRoomType_hotfix;

		// Token: 0x04005390 RID: 21392
		private LuaFunction m_GetPlayerIndexInCurrentPickTurn_hotfix;

		// Token: 0x04005391 RID: 21393
		private LuaFunction m_GetHeroSetupCountMaxInPickTurnInt32_hotfix;

		// Token: 0x04005392 RID: 21394
		private LuaFunction m_GetHeroSetupCountInCurrentPickTurn_hotfix;

		// Token: 0x04005393 RID: 21395
		private LuaFunction m_GetRemainHeroSetupCountInCurrentPickTurn_hotfix;

		// Token: 0x04005394 RID: 21396
		private LuaFunction m_GetHeroSetupFlagCountInt32SetupBattleHeroFlag_hotfix;

		// Token: 0x04005395 RID: 21397
		private LuaFunction m_IsHeroSetupHasFlagInt32Int32SetupBattleHeroFlag_hotfix;

		// Token: 0x0200088F RID: 2191
		public class LuaExportHelper
		{
			// Token: 0x06006DD5 RID: 28117 RVA: 0x001EA69C File Offset: 0x001E889C
			public LuaExportHelper(BattleRoom owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x04005396 RID: 21398
			private BattleRoom m_owner;
		}
	}
}
