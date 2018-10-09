using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E4 RID: 4836
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_TeamComponent : LuaObject
{
	// Token: 0x0601A076 RID: 106614 RVA: 0x007A3230 File Offset: 0x007A1430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent o = new TeamComponent();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A077 RID: 106615 RVA: 0x007A3278 File Offset: 0x007A1478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A078 RID: 106616 RVA: 0x007A32C4 File Offset: 0x007A14C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A079 RID: 106617 RVA: 0x007A3310 File Offset: 0x007A1510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A07A RID: 106618 RVA: 0x007A335C File Offset: 0x007A155C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			DSTeamNtf msg;
			LuaObject.checkType<DSTeamNtf>(l, 2, out msg);
			teamComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A07B RID: 106619 RVA: 0x007A33B4 File Offset: 0x007A15B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoom room;
			LuaObject.checkType<TeamRoom>(l, 2, out room);
			teamComponent.CreateTeam(room);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A07C RID: 106620 RVA: 0x007A340C File Offset: 0x007A160C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			TeamRoom room;
			LuaObject.checkType<TeamRoom>(l, 4, out room);
			teamComponent.AutoMatchTeamRoom(gameFunctionTypeId, locationId, room);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A07D RID: 106621 RVA: 0x007A3480 File Offset: 0x007A1680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeTeamRoomAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoomAuthority authority;
			LuaObject.checkEnum<TeamRoomAuthority>(l, 2, out authority);
			teamComponent.ChangeTeamRoomAuthority(authority);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A07E RID: 106622 RVA: 0x007A34D8 File Offset: 0x007A16D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int JoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoom room;
			LuaObject.checkType<TeamRoom>(l, 2, out room);
			teamComponent.JoinTeamRoom(room);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A07F RID: 106623 RVA: 0x007A3530 File Offset: 0x007A1730
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int QuitTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.QuitTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A080 RID: 106624 RVA: 0x007A357C File Offset: 0x007A177C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoomPlayer player;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out player);
			teamComponent.PlayerJoinTeamRoom(player);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A081 RID: 106625 RVA: 0x007A35D4 File Offset: 0x007A17D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerQuitTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoomPlayer quitPlayer;
			LuaObject.checkType<TeamRoomPlayer>(l, 2, out quitPlayer);
			ulong leaderSessionId;
			LuaObject.checkType(l, 3, out leaderSessionId);
			long leaderKickOutTime;
			LuaObject.checkType(l, 4, out leaderKickOutTime);
			teamComponent.PlayerQuitTeamRoom(quitPlayer, leaderSessionId, leaderKickOutTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A082 RID: 106626 RVA: 0x007A3648 File Offset: 0x007A1848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LeaveWaitingListAndJoinRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoom room;
			LuaObject.checkType<TeamRoom>(l, 2, out room);
			teamComponent.LeaveWaitingListAndJoinRoom(room);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A083 RID: 106627 RVA: 0x007A36A0 File Offset: 0x007A18A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeductTeamPveBattleEnergyByClient(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.DeductTeamPveBattleEnergyByClient();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A084 RID: 106628 RVA: 0x007A36EC File Offset: 0x007A18EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			string s = teamComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A085 RID: 106629 RVA: 0x007A3748 File Offset: 0x007A1948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A086 RID: 106630 RVA: 0x007A379C File Offset: 0x007A199C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A087 RID: 106631 RVA: 0x007A37F0 File Offset: 0x007A19F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A088 RID: 106632 RVA: 0x007A3844 File Offset: 0x007A1A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			teamComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A089 RID: 106633 RVA: 0x007A38A0 File Offset: 0x007A1AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A08A RID: 106634 RVA: 0x007A38F4 File Offset: 0x007A1AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponent.m_luaExportHelper.__callBase_IsLevelUnlocked(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A08B RID: 106635 RVA: 0x007A3968 File Offset: 0x007A1B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanCreateTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			ProTeamRoomSetting setting;
			LuaObject.checkType<ProTeamRoomSetting>(l, 2, out setting);
			int i = teamComponent.m_luaExportHelper.__callBase_CanCreateTeam(setting);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A08C RID: 106636 RVA: 0x007A39D0 File Offset: 0x007A1BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CreateTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamComponent.m_luaExportHelper.__callBase_CreateTeam(roomId, gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A08D RID: 106637 RVA: 0x007A3A48 File Offset: 0x007A1C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAttackTeamGameFunction(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponent.m_luaExportHelper.__callBase_CanAttackTeamGameFunction(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A08E RID: 106638 RVA: 0x007A3ABC File Offset: 0x007A1CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanViewTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			int i = teamComponent.m_luaExportHelper.__callBase_CanViewTeamRoom(gameFunctionTypeId, chapterId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A08F RID: 106639 RVA: 0x007A3B40 File Offset: 0x007A1D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanAutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponent.m_luaExportHelper.__callBase_CanAutoMatchTeamRoom(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A090 RID: 106640 RVA: 0x007A3BB4 File Offset: 0x007A1DB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamComponent.m_luaExportHelper.__callBase_AutoMatchTeamRoom(roomId, gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A091 RID: 106641 RVA: 0x007A3C2C File Offset: 0x007A1E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_JoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamComponent.m_luaExportHelper.__callBase_JoinTeamRoom(roomId, gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A092 RID: 106642 RVA: 0x007A3CA4 File Offset: 0x007A1EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetTeamRoomInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			int i;
			teamComponent.m_luaExportHelper.__callBase_GetTeamRoomInfo(out gameFunctionType, out i);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gameFunctionType);
			LuaObject.pushValue(l, i);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A093 RID: 106643 RVA: 0x007A3D10 File Offset: 0x007A1F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_QuitTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_QuitTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A094 RID: 106644 RVA: 0x007A3D64 File Offset: 0x007A1F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanCancelAutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int i = teamComponent.m_luaExportHelper.__callBase_CanCancelAutoMatchTeamRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A095 RID: 106645 RVA: 0x007A3DC0 File Offset: 0x007A1FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanChangeTeamRoomAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int authority;
			LuaObject.checkType(l, 2, out authority);
			int i = teamComponent.m_luaExportHelper.__callBase_CanChangeTeamRoomAuthority(authority);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A096 RID: 106646 RVA: 0x007A3E28 File Offset: 0x007A2028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			bool b = teamComponent.m_luaExportHelper.__callBase_IsInTeam();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A097 RID: 106647 RVA: 0x007A3E84 File Offset: 0x007A2084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			bool b = teamComponent.m_luaExportHelper.__callBase_IsInRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A098 RID: 106648 RVA: 0x007A3EE0 File Offset: 0x007A20E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInWaitingList(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			bool b = teamComponent.m_luaExportHelper.__callBase_IsInWaitingList();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A099 RID: 106649 RVA: 0x007A3F3C File Offset: 0x007A213C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CancelAutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_CancelAutoMatchTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A09A RID: 106650 RVA: 0x007A3F90 File Offset: 0x007A2190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponent.m_luaExportHelper.__callBase_CanJoinTeamRoom(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A09B RID: 106651 RVA: 0x007A4004 File Offset: 0x007A2204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanQuitTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int i = teamComponent.m_luaExportHelper.__callBase_CanQuitTeamRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A09C RID: 106652 RVA: 0x007A4060 File Offset: 0x007A2260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int i = teamComponent.m_luaExportHelper.__callBase_CanGetTeamRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A09D RID: 106653 RVA: 0x007A40BC File Offset: 0x007A22BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanChangeTeamRoomPlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int i = teamComponent.m_luaExportHelper.__callBase_CanChangeTeamRoomPlayerPosition();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A09E RID: 106654 RVA: 0x007A4118 File Offset: 0x007A2318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanInviteTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			int i = teamComponent.m_luaExportHelper.__callBase_CanInviteTeamRoom();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A09F RID: 106655 RVA: 0x007A4174 File Offset: 0x007A2374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_InviteTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_InviteTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A0 RID: 106656 RVA: 0x007A41C8 File Offset: 0x007A23C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetTeamRoomInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoomInviteInfo info;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out info);
			bool b = teamComponent.m_luaExportHelper.__callBase_SetTeamRoomInviteInfo(info);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A1 RID: 106657 RVA: 0x007A4230 File Offset: 0x007A2430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_IsInvited(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			bool b = teamComponent.m_luaExportHelper.__callBase_IsInvited(sessionId, roomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A2 RID: 106658 RVA: 0x007A42A4 File Offset: 0x007A24A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearAInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			teamComponent.m_luaExportHelper.__callBase_ClearAInviteInfo(sessionId, roomId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A3 RID: 106659 RVA: 0x007A4310 File Offset: 0x007A2510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ClearTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			teamComponent.m_luaExportHelper.__callBase_ClearTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A4 RID: 106660 RVA: 0x007A4364 File Offset: 0x007A2564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanRefuseInvitation(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			int i = teamComponent.m_luaExportHelper.__callBase_CanRefuseInvitation(sessionId, roomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A5 RID: 106661 RVA: 0x007A43D8 File Offset: 0x007A25D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetInviteInfos(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			List<TeamRoomInviteInfo> o = teamComponent.m_luaExportHelper.__callBase_GetInviteInfos();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A6 RID: 106662 RVA: 0x007A4434 File Offset: 0x007A2634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeductTeamPveBattleEnergy(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			teamComponent.m_luaExportHelper.__callBase_DeductTeamPveBattleEnergy(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A7 RID: 106663 RVA: 0x007A44A0 File Offset: 0x007A26A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGetInviteeInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			List<string> userIds;
			LuaObject.checkType<List<string>>(l, 2, out userIds);
			int i = teamComponent.m_luaExportHelper.__callBase_CanGetInviteeInfo(userIds);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A8 RID: 106664 RVA: 0x007A4508 File Offset: 0x007A2708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Room(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponent.Room);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0A9 RID: 106665 RVA: 0x007A455C File Offset: 0x007A275C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Room(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			TeamRoom room;
			LuaObject.checkType<TeamRoom>(l, 2, out room);
			teamComponent.Room = room;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0AA RID: 106666 RVA: 0x007A45B4 File Offset: 0x007A27B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsTeamRoomInviteAgain(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponent.IsTeamRoomInviteAgain);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0AB RID: 106667 RVA: 0x007A4608 File Offset: 0x007A2808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsTeamRoomInviteAgain(IntPtr l)
	{
		int result;
		try
		{
			TeamComponent teamComponent = (TeamComponent)LuaObject.checkSelf(l);
			bool isTeamRoomInviteAgain;
			LuaObject.checkType(l, 2, out isTeamRoomInviteAgain);
			teamComponent.IsTeamRoomInviteAgain = isTeamRoomInviteAgain;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A0AC RID: 106668 RVA: 0x007A4660 File Offset: 0x007A2860
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.TeamComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.CreateTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.AutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.ChangeTeamRoomAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.JoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.QuitTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.PlayerJoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.PlayerQuitTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.LeaveWaitingListAndJoinRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.DeductTeamPveBattleEnergyByClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanCreateTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CreateTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanAttackTeamGameFunction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanViewTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanAutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_AutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_JoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_GetTeamRoomInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_QuitTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanCancelAutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanChangeTeamRoomAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_IsInTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_IsInRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_IsInWaitingList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CancelAutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanJoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanQuitTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanGetTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanChangeTeamRoomPlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanInviteTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_InviteTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_SetTeamRoomInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_IsInvited);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_ClearAInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_ClearTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanRefuseInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_GetInviteInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_DeductTeamPveBattleEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.__callBase_CanGetInviteeInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache30);
		string name = "Room";
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.get_Room);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.set_Room);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache32, true);
		string name2 = "IsTeamRoomInviteAgain";
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.get_IsTeamRoomInviteAgain);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.set_IsTeamRoomInviteAgain);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache34, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_TeamComponent.<>f__mg$cache35, typeof(TeamComponent), typeof(TeamComponentCommon));
	}

	// Token: 0x04010490 RID: 66704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010491 RID: 66705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010492 RID: 66706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010493 RID: 66707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010494 RID: 66708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010495 RID: 66709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010496 RID: 66710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010497 RID: 66711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010498 RID: 66712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010499 RID: 66713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401049A RID: 66714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401049B RID: 66715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401049C RID: 66716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401049D RID: 66717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401049E RID: 66718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401049F RID: 66719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040104A0 RID: 66720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040104A1 RID: 66721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040104A2 RID: 66722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040104A3 RID: 66723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040104A4 RID: 66724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040104A5 RID: 66725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040104A6 RID: 66726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040104A7 RID: 66727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040104A8 RID: 66728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040104A9 RID: 66729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040104AA RID: 66730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040104AB RID: 66731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040104AC RID: 66732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040104AD RID: 66733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040104AE RID: 66734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040104AF RID: 66735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040104B0 RID: 66736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040104B1 RID: 66737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040104B2 RID: 66738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040104B3 RID: 66739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040104B4 RID: 66740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040104B5 RID: 66741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040104B6 RID: 66742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040104B7 RID: 66743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040104B8 RID: 66744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040104B9 RID: 66745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040104BA RID: 66746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040104BB RID: 66747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040104BC RID: 66748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040104BD RID: 66749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040104BE RID: 66750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040104BF RID: 66751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040104C0 RID: 66752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040104C1 RID: 66753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040104C2 RID: 66754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040104C3 RID: 66755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040104C4 RID: 66756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040104C5 RID: 66757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;
}
