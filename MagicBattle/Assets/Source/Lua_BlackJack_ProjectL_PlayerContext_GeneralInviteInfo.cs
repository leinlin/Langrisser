using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C3 RID: 4803
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo : LuaObject
{
	// Token: 0x0601946A RID: 103530 RVA: 0x0073EA30 File Offset: 0x0073CC30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GeneralInviteInfo o = new GeneralInviteInfo();
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

	// Token: 0x0601946B RID: 103531 RVA: 0x0073EA78 File Offset: 0x0073CC78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTimeout(IntPtr l)
	{
		int result;
		try
		{
			GeneralInviteInfo generalInviteInfo = (GeneralInviteInfo)LuaObject.checkSelf(l);
			DateTime timeout = generalInviteInfo.GetTimeout();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, timeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601946C RID: 103532 RVA: 0x0073EAD4 File Offset: 0x0073CCD4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamRoomInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			GeneralInviteInfo generalInviteInfo = (GeneralInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, generalInviteInfo.TeamRoomInviteInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601946D RID: 103533 RVA: 0x0073EB28 File Offset: 0x0073CD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamRoomInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			GeneralInviteInfo generalInviteInfo = (GeneralInviteInfo)LuaObject.checkSelf(l);
			TeamRoomInviteInfo teamRoomInviteInfo;
			LuaObject.checkType<TeamRoomInviteInfo>(l, 2, out teamRoomInviteInfo);
			generalInviteInfo.TeamRoomInviteInfo = teamRoomInviteInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601946E RID: 103534 RVA: 0x0073EB80 File Offset: 0x0073CD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PVPInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			GeneralInviteInfo generalInviteInfo = (GeneralInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, generalInviteInfo.PVPInviteInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601946F RID: 103535 RVA: 0x0073EBD4 File Offset: 0x0073CDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PVPInviteInfo(IntPtr l)
	{
		int result;
		try
		{
			GeneralInviteInfo generalInviteInfo = (GeneralInviteInfo)LuaObject.checkSelf(l);
			PVPInviteInfo pvpinviteInfo;
			LuaObject.checkType<PVPInviteInfo>(l, 2, out pvpinviteInfo);
			generalInviteInfo.PVPInviteInfo = pvpinviteInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019470 RID: 103536 RVA: 0x0073EC2C File Offset: 0x0073CE2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.GeneralInviteInfo");
		if (Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.GetTimeout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache0);
		string name = "TeamRoomInviteInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.get_TeamRoomInviteInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.set_TeamRoomInviteInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache2, true);
		string name2 = "PVPInviteInfo";
		if (Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.get_PVPInviteInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.set_PVPInviteInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache4, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_GeneralInviteInfo.<>f__mg$cache5, typeof(GeneralInviteInfo));
	}

	// Token: 0x0400F8C6 RID: 63686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F8C7 RID: 63687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F8C8 RID: 63688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F8C9 RID: 63689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F8CA RID: 63690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F8CB RID: 63691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
