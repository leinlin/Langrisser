using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001283 RID: 4739
[Preserve]
public class Lua_BlackJack_ProjectL_Common_TeamComponentCommon : LuaObject
{
	// Token: 0x06018AE6 RID: 101094 RVA: 0x006F7FE0 File Offset: 0x006F61E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon o = new TeamComponentCommon();
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

	// Token: 0x06018AE7 RID: 101095 RVA: 0x006F8028 File Offset: 0x006F6228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			string name = teamComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE8 RID: 101096 RVA: 0x006F807C File Offset: 0x006F627C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE9 RID: 101097 RVA: 0x006F80C8 File Offset: 0x006F62C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AEA RID: 101098 RVA: 0x006F8114 File Offset: 0x006F6314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AEB RID: 101099 RVA: 0x006F8160 File Offset: 0x006F6360
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			teamComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AEC RID: 101100 RVA: 0x006F81B8 File Offset: 0x006F63B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AED RID: 101101 RVA: 0x006F8204 File Offset: 0x006F6404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsLevelUnlocked(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponentCommon.IsLevelUnlocked(gameFunctionTypeId, locationId);
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

	// Token: 0x06018AEE RID: 101102 RVA: 0x006F8274 File Offset: 0x006F6474
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanCreateTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			ProTeamRoomSetting setting;
			LuaObject.checkType<ProTeamRoomSetting>(l, 2, out setting);
			int i = teamComponentCommon.CanCreateTeam(setting);
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

	// Token: 0x06018AEF RID: 101103 RVA: 0x006F82D8 File Offset: 0x006F64D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamComponentCommon.CreateTeam(roomId, gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AF0 RID: 101104 RVA: 0x006F834C File Offset: 0x006F654C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAttackTeamGameFunction(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponentCommon.CanAttackTeamGameFunction(gameFunctionTypeId, locationId);
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

	// Token: 0x06018AF1 RID: 101105 RVA: 0x006F83BC File Offset: 0x006F65BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanViewTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			int i = teamComponentCommon.CanViewTeamRoom(gameFunctionTypeId, chapterId, locationId);
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

	// Token: 0x06018AF2 RID: 101106 RVA: 0x006F8438 File Offset: 0x006F6638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanAutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponentCommon.CanAutoMatchTeamRoom(gameFunctionTypeId, locationId);
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

	// Token: 0x06018AF3 RID: 101107 RVA: 0x006F84A8 File Offset: 0x006F66A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamComponentCommon.AutoMatchTeamRoom(roomId, gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AF4 RID: 101108 RVA: 0x006F851C File Offset: 0x006F671C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int JoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 4, out locationId);
			teamComponentCommon.JoinTeamRoom(roomId, gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AF5 RID: 101109 RVA: 0x006F8590 File Offset: 0x006F6790
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTeamRoomInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionType;
			int i;
			teamComponentCommon.GetTeamRoomInfo(out gameFunctionType, out i);
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

	// Token: 0x06018AF6 RID: 101110 RVA: 0x006F85F8 File Offset: 0x006F67F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int QuitTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.QuitTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AF7 RID: 101111 RVA: 0x006F8644 File Offset: 0x006F6844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanCancelAutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int i = teamComponentCommon.CanCancelAutoMatchTeamRoom();
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

	// Token: 0x06018AF8 RID: 101112 RVA: 0x006F8698 File Offset: 0x006F6898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanChangeTeamRoomAuthority(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int authority;
			LuaObject.checkType(l, 2, out authority);
			int i = teamComponentCommon.CanChangeTeamRoomAuthority(authority);
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

	// Token: 0x06018AF9 RID: 101113 RVA: 0x006F86FC File Offset: 0x006F68FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInTeam(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			bool b = teamComponentCommon.IsInTeam();
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

	// Token: 0x06018AFA RID: 101114 RVA: 0x006F8750 File Offset: 0x006F6950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			bool b = teamComponentCommon.IsInRoom();
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

	// Token: 0x06018AFB RID: 101115 RVA: 0x006F87A4 File Offset: 0x006F69A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInWaitingList(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			bool b = teamComponentCommon.IsInWaitingList();
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

	// Token: 0x06018AFC RID: 101116 RVA: 0x006F87F8 File Offset: 0x006F69F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CancelAutoMatchTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.CancelAutoMatchTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AFD RID: 101117 RVA: 0x006F8844 File Offset: 0x006F6A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanJoinTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			int i = teamComponentCommon.CanJoinTeamRoom(gameFunctionTypeId, locationId);
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

	// Token: 0x06018AFE RID: 101118 RVA: 0x006F88B4 File Offset: 0x006F6AB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanQuitTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int i = teamComponentCommon.CanQuitTeamRoom();
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

	// Token: 0x06018AFF RID: 101119 RVA: 0x006F8908 File Offset: 0x006F6B08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int i = teamComponentCommon.CanGetTeamRoom();
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

	// Token: 0x06018B00 RID: 101120 RVA: 0x006F895C File Offset: 0x006F6B5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanChangeTeamRoomPlayerPosition(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int i = teamComponentCommon.CanChangeTeamRoomPlayerPosition();
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

	// Token: 0x06018B01 RID: 101121 RVA: 0x006F89B0 File Offset: 0x006F6BB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanInviteTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int i = teamComponentCommon.CanInviteTeamRoom();
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

	// Token: 0x06018B02 RID: 101122 RVA: 0x006F8A04 File Offset: 0x006F6C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InviteTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.InviteTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B03 RID: 101123 RVA: 0x006F8A50 File Offset: 0x006F6C50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamRoomInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			TeamRoomInviteInfo teamRoomInviteInfo;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out teamRoomInviteInfo);
			bool b = teamComponentCommon.SetTeamRoomInviteInfo(teamRoomInviteInfo);
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

	// Token: 0x06018B04 RID: 101124 RVA: 0x006F8AB4 File Offset: 0x006F6CB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInvited(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			bool b = teamComponentCommon.IsInvited(sessionId, roomId);
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

	// Token: 0x06018B05 RID: 101125 RVA: 0x006F8B24 File Offset: 0x006F6D24
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearAInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			teamComponentCommon.ClearAInviteInfo(sessionId, roomId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B06 RID: 101126 RVA: 0x006F8B88 File Offset: 0x006F6D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			teamComponentCommon.ClearTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B07 RID: 101127 RVA: 0x006F8BD4 File Offset: 0x006F6DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanRefuseInvitation(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			int i = teamComponentCommon.CanRefuseInvitation(sessionId, roomId);
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

	// Token: 0x06018B08 RID: 101128 RVA: 0x006F8C44 File Offset: 0x006F6E44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetInviteInfos(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			List<TeamRoomInviteInfo> inviteInfos = teamComponentCommon.GetInviteInfos();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, inviteInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B09 RID: 101129 RVA: 0x006F8C98 File Offset: 0x006F6E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeductTeamPveBattleEnergy(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			teamComponentCommon.DeductTeamPveBattleEnergy(gameFunctionTypeId, locationId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B0A RID: 101130 RVA: 0x006F8CFC File Offset: 0x006F6EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetInviteeInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			List<string> userIds;
			LuaObject.checkType<List<string>>(l, 2, out userIds);
			int i = teamComponentCommon.CanGetInviteeInfo(userIds);
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

	// Token: 0x06018B0B RID: 101131 RVA: 0x006F8D60 File Offset: 0x006F6F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsTeamRoomAuthorityValid(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			int authority;
			LuaObject.checkType(l, 2, out authority);
			bool b = teamComponentCommon.m_luaExportHelper.IsTeamRoomAuthorityValid(authority);
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

	// Token: 0x06018B0C RID: 101132 RVA: 0x006F8DC8 File Offset: 0x006F6FC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B0D RID: 101133 RVA: 0x006F8E20 File Offset: 0x006F7020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			teamComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B0E RID: 101134 RVA: 0x006F8E7C File Offset: 0x006F707C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamDS(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_teamDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B0F RID: 101135 RVA: 0x006F8ED4 File Offset: 0x006F70D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamDS(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			DataSectionTeam teamDS;
			LuaObject.checkType<DataSectionTeam>(l, 2, out teamDS);
			teamComponentCommon.m_luaExportHelper.m_teamDS = teamDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B10 RID: 101136 RVA: 0x006F8F30 File Offset: 0x006F7130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B11 RID: 101137 RVA: 0x006F8F88 File Offset: 0x006F7188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			teamComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B12 RID: 101138 RVA: 0x006F8FE4 File Offset: 0x006F71E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_anikiGym);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B13 RID: 101139 RVA: 0x006F903C File Offset: 0x006F723C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			AnikiGymComponentCommon anikiGym;
			LuaObject.checkType<AnikiGymComponentCommon>(l, 2, out anikiGym);
			teamComponentCommon.m_luaExportHelper.m_anikiGym = anikiGym;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B14 RID: 101140 RVA: 0x006F9098 File Offset: 0x006F7298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridor(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_memoryCorridor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B15 RID: 101141 RVA: 0x006F90F0 File Offset: 0x006F72F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridor(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			MemoryCorridorCompomentCommon memoryCorridor;
			LuaObject.checkType<MemoryCorridorCompomentCommon>(l, 2, out memoryCorridor);
			teamComponentCommon.m_luaExportHelper.m_memoryCorridor = memoryCorridor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B16 RID: 101142 RVA: 0x006F914C File Offset: 0x006F734C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_thearchyTrial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B17 RID: 101143 RVA: 0x006F91A4 File Offset: 0x006F73A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			ThearchyTrialCompomentCommon thearchyTrial;
			LuaObject.checkType<ThearchyTrialCompomentCommon>(l, 2, out thearchyTrial);
			teamComponentCommon.m_luaExportHelper.m_thearchyTrial = thearchyTrial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B18 RID: 101144 RVA: 0x006F9200 File Offset: 0x006F7400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B19 RID: 101145 RVA: 0x006F9258 File Offset: 0x006F7458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			teamComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B1A RID: 101146 RVA: 0x006F92B4 File Offset: 0x006F74B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroTrainning(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_heroTrainning);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B1B RID: 101147 RVA: 0x006F930C File Offset: 0x006F750C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_heroTrainning(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			HeroTrainningComponentCommon heroTrainning;
			LuaObject.checkType<HeroTrainningComponentCommon>(l, 2, out heroTrainning);
			teamComponentCommon.m_luaExportHelper.m_heroTrainning = heroTrainning;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B1C RID: 101148 RVA: 0x006F9368 File Offset: 0x006F7568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_cooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_cooperateBattle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B1D RID: 101149 RVA: 0x006F93C0 File Offset: 0x006F75C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cooperateBattle(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			CooperateBattleCompomentCommon cooperateBattle;
			LuaObject.checkType<CooperateBattleCompomentCommon>(l, 2, out cooperateBattle);
			teamComponentCommon.m_luaExportHelper.m_cooperateBattle = cooperateBattle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B1E RID: 101150 RVA: 0x006F941C File Offset: 0x006F761C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_unchartedScore(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_unchartedScore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B1F RID: 101151 RVA: 0x006F9474 File Offset: 0x006F7674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_unchartedScore(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			UnchartedScoreComponentCommon unchartedScore;
			LuaObject.checkType<UnchartedScoreComponentCommon>(l, 2, out unchartedScore);
			teamComponentCommon.m_luaExportHelper.m_unchartedScore = unchartedScore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B20 RID: 101152 RVA: 0x006F94D0 File Offset: 0x006F76D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battle(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.m_luaExportHelper.m_battle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B21 RID: 101153 RVA: 0x006F9528 File Offset: 0x006F7728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battle(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			BattleComponentCommon battle;
			LuaObject.checkType<BattleComponentCommon>(l, 2, out battle);
			teamComponentCommon.m_luaExportHelper.m_battle = battle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B22 RID: 101154 RVA: 0x006F9584 File Offset: 0x006F7784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FinishTeamBattleMissionEvent(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			Action action;
			int num = LuaObject.checkDelegate<Action>(l, 2, out action);
			if (num == 0)
			{
				teamComponentCommon.FinishTeamBattleMissionEvent = action;
			}
			else if (num == 1)
			{
				TeamComponentCommon teamComponentCommon2 = teamComponentCommon;
				teamComponentCommon2.FinishTeamBattleMissionEvent = (Action)Delegate.Combine(teamComponentCommon2.FinishTeamBattleMissionEvent, action);
			}
			else if (num == 2)
			{
				TeamComponentCommon teamComponentCommon3 = teamComponentCommon;
				teamComponentCommon3.FinishTeamBattleMissionEvent = (Action)Delegate.Remove(teamComponentCommon3.FinishTeamBattleMissionEvent, action);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B23 RID: 101155 RVA: 0x006F962C File Offset: 0x006F782C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B24 RID: 101156 RVA: 0x006F9680 File Offset: 0x006F7880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			teamComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B25 RID: 101157 RVA: 0x006F96D8 File Offset: 0x006F78D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WaitingFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamComponentCommon.WaitingFunctionTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B26 RID: 101158 RVA: 0x006F972C File Offset: 0x006F792C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WaitingLocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.WaitingLocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B27 RID: 101159 RVA: 0x006F9780 File Offset: 0x006F7980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomId(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.RoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B28 RID: 101160 RVA: 0x006F97D4 File Offset: 0x006F79D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)teamComponentCommon.GameFunctionTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B29 RID: 101161 RVA: 0x006F9828 File Offset: 0x006F7A28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LocationId(IntPtr l)
	{
		int result;
		try
		{
			TeamComponentCommon teamComponentCommon = (TeamComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, teamComponentCommon.LocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018B2A RID: 101162 RVA: 0x006F987C File Offset: 0x006F7A7C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.TeamComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.IsLevelUnlocked);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanCreateTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CreateTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanAttackTeamGameFunction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanViewTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanAutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.AutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.JoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.GetTeamRoomInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.QuitTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanCancelAutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanChangeTeamRoomAuthority);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.IsInTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.IsInRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.IsInWaitingList);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CancelAutoMatchTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanJoinTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanQuitTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanGetTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanChangeTeamRoomPlayerPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanInviteTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.InviteTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.SetTeamRoomInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.IsInvited);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.ClearAInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.ClearTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanRefuseInvitation);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.GetInviteInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.DeductTeamPveBattleEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.CanGetInviteeInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.IsTeamRoomAuthorityValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache24);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache26, true);
		string name2 = "m_teamDS";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_teamDS);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_teamDS);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache28, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2A, true);
		string name4 = "m_anikiGym";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_anikiGym);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_anikiGym);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2C, true);
		string name5 = "m_memoryCorridor";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_memoryCorridor);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_memoryCorridor);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2E, true);
		string name6 = "m_thearchyTrial";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_thearchyTrial);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_thearchyTrial);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache30, true);
		string name7 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache32, true);
		string name8 = "m_heroTrainning";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_heroTrainning);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_heroTrainning);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache34, true);
		string name9 = "m_cooperateBattle";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_cooperateBattle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_cooperateBattle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache36, true);
		string name10 = "m_unchartedScore";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_unchartedScore);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_unchartedScore);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache38, true);
		string name11 = "m_battle";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_m_battle);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_m_battle);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3A, true);
		string name12 = "FinishTeamBattleMissionEvent";
		LuaCSFunction get12 = null;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_FinishTeamBattleMissionEvent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3B, true);
		string name13 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_Owner);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3D, true);
		string name14 = "WaitingFunctionTypeId";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_WaitingFunctionTypeId);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3E, null, true);
		string name15 = "WaitingLocationId";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_WaitingLocationId);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache3F, null, true);
		string name16 = "RoomId";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_RoomId);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache40, null, true);
		string name17 = "GameFunctionTypeId";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_GameFunctionTypeId);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache41, null, true);
		string name18 = "LocationId";
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.get_LocationId);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache42, null, true);
		if (Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_TeamComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_TeamComponentCommon.<>f__mg$cache43, typeof(TeamComponentCommon));
	}

	// Token: 0x0400EFC2 RID: 61378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EFC3 RID: 61379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EFC4 RID: 61380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EFC5 RID: 61381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EFC6 RID: 61382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EFC7 RID: 61383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EFC8 RID: 61384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EFC9 RID: 61385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EFCA RID: 61386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EFCB RID: 61387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EFCC RID: 61388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EFCD RID: 61389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EFCE RID: 61390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EFCF RID: 61391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EFD0 RID: 61392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EFD1 RID: 61393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EFD2 RID: 61394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EFD3 RID: 61395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EFD4 RID: 61396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EFD5 RID: 61397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EFD6 RID: 61398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EFD7 RID: 61399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EFD8 RID: 61400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EFD9 RID: 61401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EFDA RID: 61402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EFDB RID: 61403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EFDC RID: 61404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EFDD RID: 61405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EFDE RID: 61406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EFDF RID: 61407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EFE0 RID: 61408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EFE1 RID: 61409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EFE2 RID: 61410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EFE3 RID: 61411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EFE4 RID: 61412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EFE5 RID: 61413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EFE6 RID: 61414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EFE7 RID: 61415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EFE8 RID: 61416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EFE9 RID: 61417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EFEA RID: 61418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EFEB RID: 61419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EFEC RID: 61420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EFED RID: 61421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400EFEE RID: 61422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400EFEF RID: 61423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400EFF0 RID: 61424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400EFF1 RID: 61425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400EFF2 RID: 61426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400EFF3 RID: 61427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400EFF4 RID: 61428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400EFF5 RID: 61429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400EFF6 RID: 61430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400EFF7 RID: 61431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400EFF8 RID: 61432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400EFF9 RID: 61433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400EFFA RID: 61434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400EFFB RID: 61435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400EFFC RID: 61436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400EFFD RID: 61437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400EFFE RID: 61438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400EFFF RID: 61439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400F000 RID: 61440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400F001 RID: 61441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400F002 RID: 61442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400F003 RID: 61443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400F004 RID: 61444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400F005 RID: 61445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;
}
