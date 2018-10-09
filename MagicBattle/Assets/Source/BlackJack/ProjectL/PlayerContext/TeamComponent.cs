using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime;
using BlackJack.BJFramework.Runtime.Lua;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;

namespace BlackJack.ProjectL.PlayerContext
{
	// Token: 0x020008E7 RID: 2279
	[HotFix]
	public class TeamComponent : TeamComponentCommon
	{
		// Token: 0x0600772E RID: 30510 RVA: 0x00208D04 File Offset: 0x00206F04
		public TeamComponent()
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

		// Token: 0x0600772F RID: 30511 RVA: 0x00208D6C File Offset: 0x00206F6C
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

		// Token: 0x06007730 RID: 30512 RVA: 0x00208DE8 File Offset: 0x00206FE8
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

		// Token: 0x06007731 RID: 30513 RVA: 0x00208E50 File Offset: 0x00207050
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

		// Token: 0x06007732 RID: 30514 RVA: 0x00208EB8 File Offset: 0x002070B8
		public void DeSerialize(DSTeamNtf msg)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeSerializeDSTeamNtf_hotfix != null)
			{
				this.m_DeSerializeDSTeamNtf_hotfix.call(new object[]
				{
					this,
					msg
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.ClearInitedData();
			this.m_teamDS.RoomId = msg.RoomId;
			this.m_teamDS.GameFunctionTypeId = (GameFunctionType)msg.GameFunctionTypeId;
			this.m_teamDS.LocationId = msg.LocationId;
			this.m_teamDS.WaitingFunctionTypeId = (GameFunctionType)msg.WaitingFunctionTypeId;
			this.m_teamDS.WaitingLocationId = msg.WaitingLocationId;
			if (msg.LastInviteSendTime != 0L)
			{
				this.m_teamDS.LastInviteSendTime = new DateTime(msg.LastInviteSendTime);
			}
			foreach (ProTeamRoomInviteInfo pbInfo in msg.InviteInfos)
			{
				this.m_teamDS.SetTeamRoomInviteInfo(TeamRoomInviteInfo.PbTeamRoomInviteInfoToTeamRoomInviteInfo(pbInfo));
			}
		}

		// Token: 0x06007733 RID: 30515 RVA: 0x00209008 File Offset: 0x00207208
		public void CreateTeam(TeamRoom room)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_CreateTeamTeamRoom_hotfix != null)
			{
				this.m_CreateTeamTeamRoom_hotfix.call(new object[]
				{
					this,
					room
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Room = room;
			TeamRoomSetting setting = room.Setting;
			base.CreateTeam(room.RoomId, setting.GameFunctionTypeId, setting.LocationId);
		}

		// Token: 0x06007734 RID: 30516 RVA: 0x002090A0 File Offset: 0x002072A0
		public void AutoMatchTeamRoom(GameFunctionType gameFunctionTypeId, int locationId, TeamRoom room)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_AutoMatchTeamRoomGameFunctionTypeInt32TeamRoom_hotfix != null)
			{
				this.m_AutoMatchTeamRoomGameFunctionTypeInt32TeamRoom_hotfix.call(new object[]
				{
					this,
					gameFunctionTypeId,
					locationId,
					room
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			int roomId = 0;
			if (room != null)
			{
				this.Room = room;
				roomId = room.RoomId;
			}
			base.AutoMatchTeamRoom(roomId, gameFunctionTypeId, locationId);
		}

		// Token: 0x06007735 RID: 30517 RVA: 0x00209150 File Offset: 0x00207350
		public void ChangeTeamRoomAuthority(TeamRoomAuthority authority)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_ChangeTeamRoomAuthorityTeamRoomAuthority_hotfix != null)
			{
				this.m_ChangeTeamRoomAuthorityTeamRoomAuthority_hotfix.call(new object[]
				{
					this,
					authority
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Room != null)
			{
				this.Room.Setting.Authority = authority;
			}
		}

		// Token: 0x06007736 RID: 30518 RVA: 0x002091DC File Offset: 0x002073DC
		public void JoinTeamRoom(TeamRoom room)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_JoinTeamRoomTeamRoom_hotfix != null)
			{
				this.m_JoinTeamRoomTeamRoom_hotfix.call(new object[]
				{
					this,
					room
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.Room = room;
			TeamRoomSetting setting = room.Setting;
			base.JoinTeamRoom(room.RoomId, setting.GameFunctionTypeId, setting.LocationId);
		}

		// Token: 0x06007737 RID: 30519 RVA: 0x00209274 File Offset: 0x00207474
		public override void QuitTeamRoom()
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
			this.Room = null;
			base.QuitTeamRoom();
		}

		// Token: 0x06007738 RID: 30520 RVA: 0x002092E4 File Offset: 0x002074E4
		public void PlayerJoinTeamRoom(TeamRoomPlayer player)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerJoinTeamRoomTeamRoomPlayer_hotfix != null)
			{
				this.m_PlayerJoinTeamRoomTeamRoomPlayer_hotfix.call(new object[]
				{
					this,
					player
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Room != null)
			{
				this.Room.JoinTeamRoom(player);
			}
		}

		// Token: 0x06007739 RID: 30521 RVA: 0x0020936C File Offset: 0x0020756C
		public void PlayerQuitTeamRoom(TeamRoomPlayer quitPlayer, ulong leaderSessionId, long leaderKickOutTime)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_PlayerQuitTeamRoomTeamRoomPlayerUInt64Int64_hotfix != null)
			{
				this.m_PlayerQuitTeamRoomTeamRoomPlayerUInt64Int64_hotfix.call(new object[]
				{
					this,
					quitPlayer,
					leaderSessionId,
					leaderKickOutTime
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			if (this.Room != null)
			{
				if (this.Room.IsLeader(quitPlayer))
				{
					this.Room.LeaderKickOutTime = new DateTime(leaderKickOutTime);
					TeamRoomPlayer leader = this.Room.FindTeamRoomPlayer(leaderSessionId);
					this.Room.Leader = leader;
				}
				this.Room.QuitTeamRoom(quitPlayer);
			}
		}

		// Token: 0x0600773A RID: 30522 RVA: 0x00209450 File Offset: 0x00207650
		public void LeaveWaitingListAndJoinRoom(TeamRoom room)
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_LeaveWaitingListAndJoinRoomTeamRoom_hotfix != null)
			{
				this.m_LeaveWaitingListAndJoinRoomTeamRoom_hotfix.call(new object[]
				{
					this,
					room
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			this.m_teamDS.WaitingFunctionTypeId = GameFunctionType.GameFunctionType_None;
			this.m_teamDS.WaitingLocationId = 0;
			this.JoinTeamRoom(room);
		}

		// Token: 0x0600773B RID: 30523 RVA: 0x002094E0 File Offset: 0x002076E0
		public void DeductTeamPveBattleEnergyByClient()
		{
			if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_DeductTeamPveBattleEnergyByClient_hotfix != null)
			{
				this.m_DeductTeamPveBattleEnergyByClient_hotfix.call(new object[]
				{
					this
				});
				return;
			}
			BJLuaObjHelper.IsSkipLuaHotfix = false;
			base.DeductTeamPveBattleEnergy(this.Room.Setting.GameFunctionTypeId, this.Room.Setting.LocationId);
		}

		// Token: 0x17001BE5 RID: 7141
		// (get) Token: 0x0600773C RID: 30524 RVA: 0x00209568 File Offset: 0x00207768
		// (set) Token: 0x0600773D RID: 30525 RVA: 0x002095DC File Offset: 0x002077DC
		public TeamRoom Room
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_Room_hotfix != null)
				{
					return (TeamRoom)this.m_get_Room_hotfix.call(new object[]
					{
						this
					});
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<Room>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_RoomTeamRoom_hotfix != null)
				{
					this.m_set_RoomTeamRoom_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<Room>k__BackingField = value;
			}
		}

		// Token: 0x17001BE6 RID: 7142
		// (get) Token: 0x0600773E RID: 30526 RVA: 0x00209654 File Offset: 0x00207854
		// (set) Token: 0x0600773F RID: 30527 RVA: 0x002096C8 File Offset: 0x002078C8
		public bool IsTeamRoomInviteAgain
		{
			[CompilerGenerated]
			get
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_get_IsTeamRoomInviteAgain_hotfix != null)
				{
					return Convert.ToBoolean(this.m_get_IsTeamRoomInviteAgain_hotfix.call(new object[]
					{
						this
					}));
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				return this.<IsTeamRoomInviteAgain>k__BackingField;
			}
			[CompilerGenerated]
			set
			{
				if (!BJLuaObjHelper.IsSkipLuaHotfix && this.TryInitHotFix("") && this.m_set_IsTeamRoomInviteAgainBoolean_hotfix != null)
				{
					this.m_set_IsTeamRoomInviteAgainBoolean_hotfix.call(new object[]
					{
						this,
						value
					});
					return;
				}
				BJLuaObjHelper.IsSkipLuaHotfix = false;
				this.<IsTeamRoomInviteAgain>k__BackingField = value;
			}
		}

		// Token: 0x17001BE7 RID: 7143
		// (get) Token: 0x06007740 RID: 30528 RVA: 0x00209740 File Offset: 0x00207940
		// (set) Token: 0x06007741 RID: 30529 RVA: 0x00209760 File Offset: 0x00207960
		[DoNotToLua]
		public new TeamComponent.LuaExportHelper m_luaExportHelper
		{
			get
			{
				if (this.luaExportHelper == null)
				{
					this.luaExportHelper = new TeamComponent.LuaExportHelper(this);
				}
				return this.luaExportHelper;
			}
			set
			{
				this.luaExportHelper = value;
			}
		}

		// Token: 0x06007742 RID: 30530 RVA: 0x0020976C File Offset: 0x0020796C
		private string __callBase_GetName()
		{
			return base.GetName();
		}

		// Token: 0x06007743 RID: 30531 RVA: 0x00209774 File Offset: 0x00207974
		private void __callBase_Init()
		{
			base.Init();
		}

		// Token: 0x06007744 RID: 30532 RVA: 0x0020977C File Offset: 0x0020797C
		private void __callBase_PostInit()
		{
			base.PostInit();
		}

		// Token: 0x06007745 RID: 30533 RVA: 0x00209784 File Offset: 0x00207984
		private void __callBase_DeInit()
		{
			base.DeInit();
		}

		// Token: 0x06007746 RID: 30534 RVA: 0x0020978C File Offset: 0x0020798C
		private void __callBase_Tick(uint deltaMillisecond)
		{
			base.Tick(deltaMillisecond);
		}

		// Token: 0x06007747 RID: 30535 RVA: 0x00209798 File Offset: 0x00207998
		private void __callBase_PostDeSerialize()
		{
			base.PostDeSerialize();
		}

		// Token: 0x06007748 RID: 30536 RVA: 0x002097A0 File Offset: 0x002079A0
		private int __callBase_IsLevelUnlocked(GameFunctionType gameFunctionTypeId, int locationId)
		{
			return base.IsLevelUnlocked(gameFunctionTypeId, locationId);
		}

		// Token: 0x06007749 RID: 30537 RVA: 0x002097AC File Offset: 0x002079AC
		private int __callBase_CanCreateTeam(ProTeamRoomSetting setting)
		{
			return base.CanCreateTeam(setting);
		}

		// Token: 0x0600774A RID: 30538 RVA: 0x002097B8 File Offset: 0x002079B8
		private void __callBase_CreateTeam(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
		{
			base.CreateTeam(roomId, gameFunctionTypeId, locationId);
		}

		// Token: 0x0600774B RID: 30539 RVA: 0x002097C4 File Offset: 0x002079C4
		private int __callBase_CanAttackTeamGameFunction(GameFunctionType gameFunctionTypeId, int locationId)
		{
			return base.CanAttackTeamGameFunction(gameFunctionTypeId, locationId);
		}

		// Token: 0x0600774C RID: 30540 RVA: 0x002097D0 File Offset: 0x002079D0
		private int __callBase_CanViewTeamRoom(GameFunctionType gameFunctionTypeId, int chapterId, int locationId)
		{
			return base.CanViewTeamRoom(gameFunctionTypeId, chapterId, locationId);
		}

		// Token: 0x0600774D RID: 30541 RVA: 0x002097DC File Offset: 0x002079DC
		private int __callBase_CanAutoMatchTeamRoom(GameFunctionType gameFunctionTypeId, int locationId)
		{
			return base.CanAutoMatchTeamRoom(gameFunctionTypeId, locationId);
		}

		// Token: 0x0600774E RID: 30542 RVA: 0x002097E8 File Offset: 0x002079E8
		private void __callBase_AutoMatchTeamRoom(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
		{
			base.AutoMatchTeamRoom(roomId, gameFunctionTypeId, locationId);
		}

		// Token: 0x0600774F RID: 30543 RVA: 0x002097F4 File Offset: 0x002079F4
		private void __callBase_JoinTeamRoom(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
		{
			base.JoinTeamRoom(roomId, gameFunctionTypeId, locationId);
		}

		// Token: 0x06007750 RID: 30544 RVA: 0x00209800 File Offset: 0x00207A00
		private void __callBase_GetTeamRoomInfo(out GameFunctionType typeId, out int locationId)
		{
			base.GetTeamRoomInfo(out typeId, out locationId);
		}

		// Token: 0x06007751 RID: 30545 RVA: 0x0020980C File Offset: 0x00207A0C
		private void __callBase_QuitTeamRoom()
		{
			base.QuitTeamRoom();
		}

		// Token: 0x06007752 RID: 30546 RVA: 0x00209814 File Offset: 0x00207A14
		private int __callBase_CanCancelAutoMatchTeamRoom()
		{
			return base.CanCancelAutoMatchTeamRoom();
		}

		// Token: 0x06007753 RID: 30547 RVA: 0x0020981C File Offset: 0x00207A1C
		private int __callBase_CanChangeTeamRoomAuthority(int authority)
		{
			return base.CanChangeTeamRoomAuthority(authority);
		}

		// Token: 0x06007754 RID: 30548 RVA: 0x00209828 File Offset: 0x00207A28
		private bool __callBase_IsInTeam()
		{
			return base.IsInTeam();
		}

		// Token: 0x06007755 RID: 30549 RVA: 0x00209830 File Offset: 0x00207A30
		private bool __callBase_IsInRoom()
		{
			return base.IsInRoom();
		}

		// Token: 0x06007756 RID: 30550 RVA: 0x00209838 File Offset: 0x00207A38
		private bool __callBase_IsInWaitingList()
		{
			return base.IsInWaitingList();
		}

		// Token: 0x06007757 RID: 30551 RVA: 0x00209840 File Offset: 0x00207A40
		private void __callBase_CancelAutoMatchTeamRoom()
		{
			base.CancelAutoMatchTeamRoom();
		}

		// Token: 0x06007758 RID: 30552 RVA: 0x00209848 File Offset: 0x00207A48
		private int __callBase_CanJoinTeamRoom(GameFunctionType gameFunctionTypeId, int locationId)
		{
			return base.CanJoinTeamRoom(gameFunctionTypeId, locationId);
		}

		// Token: 0x06007759 RID: 30553 RVA: 0x00209854 File Offset: 0x00207A54
		private int __callBase_CanQuitTeamRoom()
		{
			return base.CanQuitTeamRoom();
		}

		// Token: 0x0600775A RID: 30554 RVA: 0x0020985C File Offset: 0x00207A5C
		private int __callBase_CanGetTeamRoom()
		{
			return base.CanGetTeamRoom();
		}

		// Token: 0x0600775B RID: 30555 RVA: 0x00209864 File Offset: 0x00207A64
		private int __callBase_CanChangeTeamRoomPlayerPosition()
		{
			return base.CanChangeTeamRoomPlayerPosition();
		}

		// Token: 0x0600775C RID: 30556 RVA: 0x0020986C File Offset: 0x00207A6C
		private int __callBase_CanInviteTeamRoom()
		{
			return base.CanInviteTeamRoom();
		}

		// Token: 0x0600775D RID: 30557 RVA: 0x00209874 File Offset: 0x00207A74
		private void __callBase_InviteTeamRoom()
		{
			base.InviteTeamRoom();
		}

		// Token: 0x0600775E RID: 30558 RVA: 0x0020987C File Offset: 0x00207A7C
		private bool __callBase_SetTeamRoomInviteInfo(TeamRoomInviteInfo info)
		{
			return base.SetTeamRoomInviteInfo(info);
		}

		// Token: 0x0600775F RID: 30559 RVA: 0x00209888 File Offset: 0x00207A88
		private bool __callBase_IsInvited(ulong sessionId, int roomId)
		{
			return base.IsInvited(sessionId, roomId);
		}

		// Token: 0x06007760 RID: 30560 RVA: 0x00209894 File Offset: 0x00207A94
		private void __callBase_ClearAInviteInfo(ulong sessionId, int roomId)
		{
			base.ClearAInviteInfo(sessionId, roomId);
		}

		// Token: 0x06007761 RID: 30561 RVA: 0x002098A0 File Offset: 0x00207AA0
		private void __callBase_ClearTeamRoom()
		{
			base.ClearTeamRoom();
		}

		// Token: 0x06007762 RID: 30562 RVA: 0x002098A8 File Offset: 0x00207AA8
		private int __callBase_CanRefuseInvitation(ulong sessionId, int roomId)
		{
			return base.CanRefuseInvitation(sessionId, roomId);
		}

		// Token: 0x06007763 RID: 30563 RVA: 0x002098B4 File Offset: 0x00207AB4
		private List<TeamRoomInviteInfo> __callBase_GetInviteInfos()
		{
			return base.GetInviteInfos();
		}

		// Token: 0x06007764 RID: 30564 RVA: 0x002098BC File Offset: 0x00207ABC
		private void __callBase_DeductTeamPveBattleEnergy(GameFunctionType gameFunctionTypeId, int locationId)
		{
			base.DeductTeamPveBattleEnergy(gameFunctionTypeId, locationId);
		}

		// Token: 0x06007765 RID: 30565 RVA: 0x002098C8 File Offset: 0x00207AC8
		private int __callBase_CanGetInviteeInfo(List<string> userIds)
		{
			return base.CanGetInviteeInfo(userIds);
		}

		// Token: 0x06007766 RID: 30566 RVA: 0x002098D4 File Offset: 0x00207AD4
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
					this.m_DeSerializeDSTeamNtf_hotfix = (luaObj.RawGet("DeSerialize") as LuaFunction);
					this.m_CreateTeamTeamRoom_hotfix = (luaObj.RawGet("CreateTeam") as LuaFunction);
					this.m_AutoMatchTeamRoomGameFunctionTypeInt32TeamRoom_hotfix = (luaObj.RawGet("AutoMatchTeamRoom") as LuaFunction);
					this.m_ChangeTeamRoomAuthorityTeamRoomAuthority_hotfix = (luaObj.RawGet("ChangeTeamRoomAuthority") as LuaFunction);
					this.m_JoinTeamRoomTeamRoom_hotfix = (luaObj.RawGet("JoinTeamRoom") as LuaFunction);
					this.m_QuitTeamRoom_hotfix = (luaObj.RawGet("QuitTeamRoom") as LuaFunction);
					this.m_PlayerJoinTeamRoomTeamRoomPlayer_hotfix = (luaObj.RawGet("PlayerJoinTeamRoom") as LuaFunction);
					this.m_PlayerQuitTeamRoomTeamRoomPlayerUInt64Int64_hotfix = (luaObj.RawGet("PlayerQuitTeamRoom") as LuaFunction);
					this.m_LeaveWaitingListAndJoinRoomTeamRoom_hotfix = (luaObj.RawGet("LeaveWaitingListAndJoinRoom") as LuaFunction);
					this.m_DeductTeamPveBattleEnergyByClient_hotfix = (luaObj.RawGet("DeductTeamPveBattleEnergyByClient") as LuaFunction);
					this.m_get_Room_hotfix = (luaObj.RawGet("get_Room") as LuaFunction);
					this.m_set_RoomTeamRoom_hotfix = (luaObj.RawGet("set_Room") as LuaFunction);
					this.m_get_IsTeamRoomInviteAgain_hotfix = (luaObj.RawGet("get_IsTeamRoomInviteAgain") as LuaFunction);
					this.m_set_IsTeamRoomInviteAgainBoolean_hotfix = (luaObj.RawGet("set_IsTeamRoomInviteAgain") as LuaFunction);
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06007767 RID: 30567 RVA: 0x00209B48 File Offset: 0x00207D48
		private bool TryInitHotFix(string luaModuleName)
		{
			bool result;
			if (this.m_hotfixState != ObjectLuaHotFixState.Uninit)
			{
				result = (this.m_hotfixState == ObjectLuaHotFixState.InitAvialable);
			}
			else
			{
				bool flag = LuaManager.TryInitHotfixForObj(this, luaModuleName, typeof(TeamComponent));
				this.m_hotfixState = ((!flag) ? ObjectLuaHotFixState.InitUnavialable : ObjectLuaHotFixState.InitAvialable);
				result = flag;
			}
			return result;
		}

		// Token: 0x04005648 RID: 22088
		[DoNotToLua]
		private TeamComponent.LuaExportHelper luaExportHelper;

		// Token: 0x04005649 RID: 22089
		private BJLuaObjHelper m_luaObjHelper;

		// Token: 0x0400564A RID: 22090
		private ObjectLuaHotFixState m_hotfixState;

		// Token: 0x0400564B RID: 22091
		private LuaFunction m_ctor_hotfix;

		// Token: 0x0400564C RID: 22092
		private LuaFunction m_Init_hotfix;

		// Token: 0x0400564D RID: 22093
		private LuaFunction m_PostInit_hotfix;

		// Token: 0x0400564E RID: 22094
		private LuaFunction m_DeInit_hotfix;

		// Token: 0x0400564F RID: 22095
		private LuaFunction m_DeSerializeDSTeamNtf_hotfix;

		// Token: 0x04005650 RID: 22096
		private LuaFunction m_CreateTeamTeamRoom_hotfix;

		// Token: 0x04005651 RID: 22097
		private LuaFunction m_AutoMatchTeamRoomGameFunctionTypeInt32TeamRoom_hotfix;

		// Token: 0x04005652 RID: 22098
		private LuaFunction m_ChangeTeamRoomAuthorityTeamRoomAuthority_hotfix;

		// Token: 0x04005653 RID: 22099
		private LuaFunction m_JoinTeamRoomTeamRoom_hotfix;

		// Token: 0x04005654 RID: 22100
		private LuaFunction m_QuitTeamRoom_hotfix;

		// Token: 0x04005655 RID: 22101
		private LuaFunction m_PlayerJoinTeamRoomTeamRoomPlayer_hotfix;

		// Token: 0x04005656 RID: 22102
		private LuaFunction m_PlayerQuitTeamRoomTeamRoomPlayerUInt64Int64_hotfix;

		// Token: 0x04005657 RID: 22103
		private LuaFunction m_LeaveWaitingListAndJoinRoomTeamRoom_hotfix;

		// Token: 0x04005658 RID: 22104
		private LuaFunction m_DeductTeamPveBattleEnergyByClient_hotfix;

		// Token: 0x04005659 RID: 22105
		private LuaFunction m_get_Room_hotfix;

		// Token: 0x0400565A RID: 22106
		private LuaFunction m_set_RoomTeamRoom_hotfix;

		// Token: 0x0400565B RID: 22107
		private LuaFunction m_get_IsTeamRoomInviteAgain_hotfix;

		// Token: 0x0400565C RID: 22108
		private LuaFunction m_set_IsTeamRoomInviteAgainBoolean_hotfix;

		// Token: 0x020008E8 RID: 2280
		public new class LuaExportHelper
		{
			// Token: 0x06007768 RID: 30568 RVA: 0x00209BB0 File Offset: 0x00207DB0
			public LuaExportHelper(TeamComponent owner)
			{
				this.m_owner = owner;
			}

			// Token: 0x06007769 RID: 30569 RVA: 0x00209BC0 File Offset: 0x00207DC0
			public string __callBase_GetName()
			{
				return this.m_owner.__callBase_GetName();
			}

			// Token: 0x0600776A RID: 30570 RVA: 0x00209BD0 File Offset: 0x00207DD0
			public void __callBase_Init()
			{
				this.m_owner.__callBase_Init();
			}

			// Token: 0x0600776B RID: 30571 RVA: 0x00209BE0 File Offset: 0x00207DE0
			public void __callBase_PostInit()
			{
				this.m_owner.__callBase_PostInit();
			}

			// Token: 0x0600776C RID: 30572 RVA: 0x00209BF0 File Offset: 0x00207DF0
			public void __callBase_DeInit()
			{
				this.m_owner.__callBase_DeInit();
			}

			// Token: 0x0600776D RID: 30573 RVA: 0x00209C00 File Offset: 0x00207E00
			public void __callBase_Tick(uint deltaMillisecond)
			{
				this.m_owner.__callBase_Tick(deltaMillisecond);
			}

			// Token: 0x0600776E RID: 30574 RVA: 0x00209C10 File Offset: 0x00207E10
			public void __callBase_PostDeSerialize()
			{
				this.m_owner.__callBase_PostDeSerialize();
			}

			// Token: 0x0600776F RID: 30575 RVA: 0x00209C20 File Offset: 0x00207E20
			public int __callBase_IsLevelUnlocked(GameFunctionType gameFunctionTypeId, int locationId)
			{
				return this.m_owner.__callBase_IsLevelUnlocked(gameFunctionTypeId, locationId);
			}

			// Token: 0x06007770 RID: 30576 RVA: 0x00209C30 File Offset: 0x00207E30
			public int __callBase_CanCreateTeam(ProTeamRoomSetting setting)
			{
				return this.m_owner.__callBase_CanCreateTeam(setting);
			}

			// Token: 0x06007771 RID: 30577 RVA: 0x00209C40 File Offset: 0x00207E40
			public void __callBase_CreateTeam(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
			{
				this.m_owner.__callBase_CreateTeam(roomId, gameFunctionTypeId, locationId);
			}

			// Token: 0x06007772 RID: 30578 RVA: 0x00209C50 File Offset: 0x00207E50
			public int __callBase_CanAttackTeamGameFunction(GameFunctionType gameFunctionTypeId, int locationId)
			{
				return this.m_owner.__callBase_CanAttackTeamGameFunction(gameFunctionTypeId, locationId);
			}

			// Token: 0x06007773 RID: 30579 RVA: 0x00209C60 File Offset: 0x00207E60
			public int __callBase_CanViewTeamRoom(GameFunctionType gameFunctionTypeId, int chapterId, int locationId)
			{
				return this.m_owner.__callBase_CanViewTeamRoom(gameFunctionTypeId, chapterId, locationId);
			}

			// Token: 0x06007774 RID: 30580 RVA: 0x00209C70 File Offset: 0x00207E70
			public int __callBase_CanAutoMatchTeamRoom(GameFunctionType gameFunctionTypeId, int locationId)
			{
				return this.m_owner.__callBase_CanAutoMatchTeamRoom(gameFunctionTypeId, locationId);
			}

			// Token: 0x06007775 RID: 30581 RVA: 0x00209C80 File Offset: 0x00207E80
			public void __callBase_AutoMatchTeamRoom(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
			{
				this.m_owner.__callBase_AutoMatchTeamRoom(roomId, gameFunctionTypeId, locationId);
			}

			// Token: 0x06007776 RID: 30582 RVA: 0x00209C90 File Offset: 0x00207E90
			public void __callBase_JoinTeamRoom(int roomId, GameFunctionType gameFunctionTypeId, int locationId)
			{
				this.m_owner.__callBase_JoinTeamRoom(roomId, gameFunctionTypeId, locationId);
			}

			// Token: 0x06007777 RID: 30583 RVA: 0x00209CA0 File Offset: 0x00207EA0
			public void __callBase_GetTeamRoomInfo(out GameFunctionType typeId, out int locationId)
			{
				this.m_owner.__callBase_GetTeamRoomInfo(out typeId, out locationId);
			}

			// Token: 0x06007778 RID: 30584 RVA: 0x00209CB0 File Offset: 0x00207EB0
			public void __callBase_QuitTeamRoom()
			{
				this.m_owner.__callBase_QuitTeamRoom();
			}

			// Token: 0x06007779 RID: 30585 RVA: 0x00209CC0 File Offset: 0x00207EC0
			public int __callBase_CanCancelAutoMatchTeamRoom()
			{
				return this.m_owner.__callBase_CanCancelAutoMatchTeamRoom();
			}

			// Token: 0x0600777A RID: 30586 RVA: 0x00209CD0 File Offset: 0x00207ED0
			public int __callBase_CanChangeTeamRoomAuthority(int authority)
			{
				return this.m_owner.__callBase_CanChangeTeamRoomAuthority(authority);
			}

			// Token: 0x0600777B RID: 30587 RVA: 0x00209CE0 File Offset: 0x00207EE0
			public bool __callBase_IsInTeam()
			{
				return this.m_owner.__callBase_IsInTeam();
			}

			// Token: 0x0600777C RID: 30588 RVA: 0x00209CF0 File Offset: 0x00207EF0
			public bool __callBase_IsInRoom()
			{
				return this.m_owner.__callBase_IsInRoom();
			}

			// Token: 0x0600777D RID: 30589 RVA: 0x00209D00 File Offset: 0x00207F00
			public bool __callBase_IsInWaitingList()
			{
				return this.m_owner.__callBase_IsInWaitingList();
			}

			// Token: 0x0600777E RID: 30590 RVA: 0x00209D10 File Offset: 0x00207F10
			public void __callBase_CancelAutoMatchTeamRoom()
			{
				this.m_owner.__callBase_CancelAutoMatchTeamRoom();
			}

			// Token: 0x0600777F RID: 30591 RVA: 0x00209D20 File Offset: 0x00207F20
			public int __callBase_CanJoinTeamRoom(GameFunctionType gameFunctionTypeId, int locationId)
			{
				return this.m_owner.__callBase_CanJoinTeamRoom(gameFunctionTypeId, locationId);
			}

			// Token: 0x06007780 RID: 30592 RVA: 0x00209D30 File Offset: 0x00207F30
			public int __callBase_CanQuitTeamRoom()
			{
				return this.m_owner.__callBase_CanQuitTeamRoom();
			}

			// Token: 0x06007781 RID: 30593 RVA: 0x00209D40 File Offset: 0x00207F40
			public int __callBase_CanGetTeamRoom()
			{
				return this.m_owner.__callBase_CanGetTeamRoom();
			}

			// Token: 0x06007782 RID: 30594 RVA: 0x00209D50 File Offset: 0x00207F50
			public int __callBase_CanChangeTeamRoomPlayerPosition()
			{
				return this.m_owner.__callBase_CanChangeTeamRoomPlayerPosition();
			}

			// Token: 0x06007783 RID: 30595 RVA: 0x00209D60 File Offset: 0x00207F60
			public int __callBase_CanInviteTeamRoom()
			{
				return this.m_owner.__callBase_CanInviteTeamRoom();
			}

			// Token: 0x06007784 RID: 30596 RVA: 0x00209D70 File Offset: 0x00207F70
			public void __callBase_InviteTeamRoom()
			{
				this.m_owner.__callBase_InviteTeamRoom();
			}

			// Token: 0x06007785 RID: 30597 RVA: 0x00209D80 File Offset: 0x00207F80
			public bool __callBase_SetTeamRoomInviteInfo(TeamRoomInviteInfo info)
			{
				return this.m_owner.__callBase_SetTeamRoomInviteInfo(info);
			}

			// Token: 0x06007786 RID: 30598 RVA: 0x00209D90 File Offset: 0x00207F90
			public bool __callBase_IsInvited(ulong sessionId, int roomId)
			{
				return this.m_owner.__callBase_IsInvited(sessionId, roomId);
			}

			// Token: 0x06007787 RID: 30599 RVA: 0x00209DA0 File Offset: 0x00207FA0
			public void __callBase_ClearAInviteInfo(ulong sessionId, int roomId)
			{
				this.m_owner.__callBase_ClearAInviteInfo(sessionId, roomId);
			}

			// Token: 0x06007788 RID: 30600 RVA: 0x00209DB0 File Offset: 0x00207FB0
			public void __callBase_ClearTeamRoom()
			{
				this.m_owner.__callBase_ClearTeamRoom();
			}

			// Token: 0x06007789 RID: 30601 RVA: 0x00209DC0 File Offset: 0x00207FC0
			public int __callBase_CanRefuseInvitation(ulong sessionId, int roomId)
			{
				return this.m_owner.__callBase_CanRefuseInvitation(sessionId, roomId);
			}

			// Token: 0x0600778A RID: 30602 RVA: 0x00209DD0 File Offset: 0x00207FD0
			public List<TeamRoomInviteInfo> __callBase_GetInviteInfos()
			{
				return this.m_owner.__callBase_GetInviteInfos();
			}

			// Token: 0x0600778B RID: 30603 RVA: 0x00209DE0 File Offset: 0x00207FE0
			public void __callBase_DeductTeamPveBattleEnergy(GameFunctionType gameFunctionTypeId, int locationId)
			{
				this.m_owner.__callBase_DeductTeamPveBattleEnergy(gameFunctionTypeId, locationId);
			}

			// Token: 0x0600778C RID: 30604 RVA: 0x00209DF0 File Offset: 0x00207FF0
			public int __callBase_CanGetInviteeInfo(List<string> userIds)
			{
				return this.m_owner.__callBase_CanGetInviteeInfo(userIds);
			}

			// Token: 0x0400565D RID: 22109
			private TeamComponent m_owner;
		}
	}
}
