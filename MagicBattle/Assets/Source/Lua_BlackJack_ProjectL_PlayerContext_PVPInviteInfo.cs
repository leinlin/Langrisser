using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D9 RID: 4825
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo : LuaObject
{
	// Token: 0x06019F46 RID: 106310 RVA: 0x0079A240 File Offset: 0x00798440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PVPInviteInfo o = new PVPInviteInfo();
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

	// Token: 0x06019F47 RID: 106311 RVA: 0x0079A288 File Offset: 0x00798488
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Inviter(IntPtr l)
	{
		int result;
		try
		{
			PVPInviteInfo pvpinviteInfo = (PVPInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpinviteInfo.Inviter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F48 RID: 106312 RVA: 0x0079A2DC File Offset: 0x007984DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Inviter(IntPtr l)
	{
		int result;
		try
		{
			PVPInviteInfo pvpinviteInfo = (PVPInviteInfo)LuaObject.checkSelf(l);
			UserSummary inviter;
			LuaObject.checkType<UserSummary>(l, 2, out inviter);
			pvpinviteInfo.Inviter = inviter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F49 RID: 106313 RVA: 0x0079A334 File Offset: 0x00798534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Timeout(IntPtr l)
	{
		int result;
		try
		{
			PVPInviteInfo pvpinviteInfo = (PVPInviteInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pvpinviteInfo.Timeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F4A RID: 106314 RVA: 0x0079A38C File Offset: 0x0079858C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Timeout(IntPtr l)
	{
		int result;
		try
		{
			PVPInviteInfo pvpinviteInfo = (PVPInviteInfo)LuaObject.checkSelf(l);
			DateTime timeout;
			LuaObject.checkValueType<DateTime>(l, 2, out timeout);
			pvpinviteInfo.Timeout = timeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019F4B RID: 106315 RVA: 0x0079A3E4 File Offset: 0x007985E4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.PVPInviteInfo");
		string name = "Inviter";
		if (Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.get_Inviter);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.set_Inviter);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache1, true);
		string name2 = "Timeout";
		if (Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.get_Timeout);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.set_Timeout);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_PVPInviteInfo.<>f__mg$cache4, typeof(PVPInviteInfo));
	}

	// Token: 0x04010376 RID: 66422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010377 RID: 66423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010378 RID: 66424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010379 RID: 66425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401037A RID: 66426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
