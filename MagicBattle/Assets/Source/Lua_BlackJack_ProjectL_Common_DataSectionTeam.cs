using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001214 RID: 4628
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionTeam : LuaObject
{
	// Token: 0x06018067 RID: 98407 RVA: 0x006A9C48 File Offset: 0x006A7E48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam o = new DataSectionTeam();
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

	// Token: 0x06018068 RID: 98408 RVA: 0x006A9C90 File Offset: 0x006A7E90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			dataSectionTeam.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018069 RID: 98409 RVA: 0x006A9CDC File Offset: 0x006A7EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearTeamRoom(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			dataSectionTeam.ClearTeamRoom();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601806A RID: 98410 RVA: 0x006A9D28 File Offset: 0x006A7F28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInviteInfos(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			dataSectionTeam.ClearInviteInfos();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601806B RID: 98411 RVA: 0x006A9D74 File Offset: 0x006A7F74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			dataSectionTeam.ClearAInviteInfo(sessionId, roomId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601806C RID: 98412 RVA: 0x006A9DD8 File Offset: 0x006A7FD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsInvited(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			ulong sessionId;
			LuaObject.checkType(l, 2, out sessionId);
			int roomId;
			LuaObject.checkType(l, 3, out roomId);
			bool b = dataSectionTeam.IsInvited(sessionId, roomId);
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

	// Token: 0x0601806D RID: 98413 RVA: 0x006A9E48 File Offset: 0x006A8048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetInviteInfos(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			List<TeamRoomInviteInfo> inviteInfos = dataSectionTeam.GetInviteInfos();
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

	// Token: 0x0601806E RID: 98414 RVA: 0x006A9E9C File Offset: 0x006A809C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			object o = dataSectionTeam.SerializeToClient();
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

	// Token: 0x0601806F RID: 98415 RVA: 0x006A9EF0 File Offset: 0x006A80F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTeamRoomInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			TeamRoomInviteInfo teamRoomInviteInfo;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out teamRoomInviteInfo);
			bool b = dataSectionTeam.SetTeamRoomInviteInfo(teamRoomInviteInfo);
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

	// Token: 0x06018070 RID: 98416 RVA: 0x006A9F54 File Offset: 0x006A8154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionTeam.RoomId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018071 RID: 98417 RVA: 0x006A9FA8 File Offset: 0x006A81A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			int roomId;
			LuaObject.checkType(l, 2, out roomId);
			dataSectionTeam.RoomId = roomId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018072 RID: 98418 RVA: 0x006AA000 File Offset: 0x006A8200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)dataSectionTeam.GameFunctionTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018073 RID: 98419 RVA: 0x006AA054 File Offset: 0x006A8254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GameFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			GameFunctionType gameFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out gameFunctionTypeId);
			dataSectionTeam.GameFunctionTypeId = gameFunctionTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018074 RID: 98420 RVA: 0x006AA0AC File Offset: 0x006A82AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LocationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionTeam.LocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018075 RID: 98421 RVA: 0x006AA100 File Offset: 0x006A8300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LocationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			int locationId;
			LuaObject.checkType(l, 2, out locationId);
			dataSectionTeam.LocationId = locationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018076 RID: 98422 RVA: 0x006AA158 File Offset: 0x006A8358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WaitingFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)dataSectionTeam.WaitingFunctionTypeId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018077 RID: 98423 RVA: 0x006AA1AC File Offset: 0x006A83AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WaitingFunctionTypeId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			GameFunctionType waitingFunctionTypeId;
			LuaObject.checkEnum<GameFunctionType>(l, 2, out waitingFunctionTypeId);
			dataSectionTeam.WaitingFunctionTypeId = waitingFunctionTypeId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018078 RID: 98424 RVA: 0x006AA204 File Offset: 0x006A8404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WaitingLocationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionTeam.WaitingLocationId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018079 RID: 98425 RVA: 0x006AA258 File Offset: 0x006A8458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WaitingLocationId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			int waitingLocationId;
			LuaObject.checkType(l, 2, out waitingLocationId);
			dataSectionTeam.WaitingLocationId = waitingLocationId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601807A RID: 98426 RVA: 0x006AA2B0 File Offset: 0x006A84B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastInviteSendTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionTeam.LastInviteSendTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601807B RID: 98427 RVA: 0x006AA308 File Offset: 0x006A8508
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastInviteSendTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionTeam dataSectionTeam = (DataSectionTeam)LuaObject.checkSelf(l);
			DateTime lastInviteSendTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastInviteSendTime);
			dataSectionTeam.LastInviteSendTime = lastInviteSendTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601807C RID: 98428 RVA: 0x006AA360 File Offset: 0x006A8560
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionTeam");
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.ClearTeamRoom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.ClearInviteInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.ClearAInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.IsInvited);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.GetInviteInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.SetTeamRoomInviteInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache7);
		string name = "RoomId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.get_RoomId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.set_RoomId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache9, true);
		string name2 = "GameFunctionTypeId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.get_GameFunctionTypeId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.set_GameFunctionTypeId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheB, true);
		string name3 = "LocationId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.get_LocationId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.set_LocationId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheD, true);
		string name4 = "WaitingFunctionTypeId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.get_WaitingFunctionTypeId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.set_WaitingFunctionTypeId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cacheF, true);
		string name5 = "WaitingLocationId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.get_WaitingLocationId);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.set_WaitingLocationId);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache11, true);
		string name6 = "LastInviteSendTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.get_LastInviteSendTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.set_LastInviteSendTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache13, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionTeam.<>f__mg$cache14, typeof(DataSectionTeam), typeof(DataSection));
	}

	// Token: 0x0400E621 RID: 58913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E622 RID: 58914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E623 RID: 58915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E624 RID: 58916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E625 RID: 58917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E626 RID: 58918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E627 RID: 58919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E628 RID: 58920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E629 RID: 58921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E62A RID: 58922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E62B RID: 58923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E62C RID: 58924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E62D RID: 58925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E62E RID: 58926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E62F RID: 58927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E630 RID: 58928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E631 RID: 58929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E632 RID: 58930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E633 RID: 58931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E634 RID: 58932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E635 RID: 58933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
