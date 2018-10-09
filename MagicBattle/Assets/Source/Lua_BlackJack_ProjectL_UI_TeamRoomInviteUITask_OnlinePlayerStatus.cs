using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015A1 RID: 5537
[Preserve]
public class Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus : LuaObject
{
	// Token: 0x06021863 RID: 137315 RVA: 0x00B59884 File Offset: 0x00B57A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus o = new TeamRoomInviteUITask.OnlinePlayerStatus();
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

	// Token: 0x06021864 RID: 137316 RVA: 0x00B598CC File Offset: 0x00B57ACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UpdateTime(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = (TeamRoomInviteUITask.OnlinePlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlinePlayerStatus.UpdateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021865 RID: 137317 RVA: 0x00B59924 File Offset: 0x00B57B24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UpdateTime(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = (TeamRoomInviteUITask.OnlinePlayerStatus)LuaObject.checkSelf(l);
			DateTime updateTime;
			LuaObject.checkValueType<DateTime>(l, 2, out updateTime);
			onlinePlayerStatus.UpdateTime = updateTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021866 RID: 137318 RVA: 0x00B5997C File Offset: 0x00B57B7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = (TeamRoomInviteUITask.OnlinePlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, onlinePlayerStatus.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021867 RID: 137319 RVA: 0x00B599D0 File Offset: 0x00B57BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = (TeamRoomInviteUITask.OnlinePlayerStatus)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			onlinePlayerStatus.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021868 RID: 137320 RVA: 0x00B59A28 File Offset: 0x00B57C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InviteState(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = (TeamRoomInviteUITask.OnlinePlayerStatus)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)onlinePlayerStatus.InviteState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021869 RID: 137321 RVA: 0x00B59A7C File Offset: 0x00B57C7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_InviteState(IntPtr l)
	{
		int result;
		try
		{
			TeamRoomInviteUITask.OnlinePlayerStatus onlinePlayerStatus = (TeamRoomInviteUITask.OnlinePlayerStatus)LuaObject.checkSelf(l);
			TeamRoomPlayerInviteState inviteState;
			LuaObject.checkEnum<TeamRoomPlayerInviteState>(l, 2, out inviteState);
			onlinePlayerStatus.InviteState = inviteState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602186A RID: 137322 RVA: 0x00B59AD4 File Offset: 0x00B57CD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.TeamRoomInviteUITask.OnlinePlayerStatus");
		string name = "UpdateTime";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.get_UpdateTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.set_UpdateTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache1, true);
		string name2 = "UserId";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.get_UserId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.set_UserId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache3, true);
		string name3 = "InviteState";
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.get_InviteState);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.set_InviteState);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_TeamRoomInviteUITask_OnlinePlayerStatus.<>f__mg$cache6, typeof(TeamRoomInviteUITask.OnlinePlayerStatus));
	}

	// Token: 0x04017703 RID: 96003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017704 RID: 96004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017705 RID: 96005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017706 RID: 96006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017707 RID: 96007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017708 RID: 96008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017709 RID: 96009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
