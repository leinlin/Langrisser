using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001322 RID: 4898
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart : LuaObject
{
	// Token: 0x0601A4B7 RID: 107703 RVA: 0x007C2150 File Offset: 0x007C0350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataRealTimePVPBattleStart o = new ClientBattle.LogDataRealTimePVPBattleStart();
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

	// Token: 0x0601A4B8 RID: 107704 RVA: 0x007C2198 File Offset: 0x007C0398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataRealTimePVPBattleStart logDataRealTimePVPBattleStart = (ClientBattle.LogDataRealTimePVPBattleStart)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataRealTimePVPBattleStart.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4B9 RID: 107705 RVA: 0x007C21EC File Offset: 0x007C03EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataRealTimePVPBattleStart logDataRealTimePVPBattleStart = (ClientBattle.LogDataRealTimePVPBattleStart)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataRealTimePVPBattleStart.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4BA RID: 107706 RVA: 0x007C2244 File Offset: 0x007C0444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RealTimePVPBattleId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataRealTimePVPBattleStart logDataRealTimePVPBattleStart = (ClientBattle.LogDataRealTimePVPBattleStart)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataRealTimePVPBattleStart.RealTimePVPBattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4BB RID: 107707 RVA: 0x007C2298 File Offset: 0x007C0498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealTimePVPBattleId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataRealTimePVPBattleStart logDataRealTimePVPBattleStart = (ClientBattle.LogDataRealTimePVPBattleStart)LuaObject.checkSelf(l);
			int realTimePVPBattleId;
			LuaObject.checkType(l, 2, out realTimePVPBattleId);
			logDataRealTimePVPBattleStart.RealTimePVPBattleId = realTimePVPBattleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4BC RID: 107708 RVA: 0x007C22F0 File Offset: 0x007C04F0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataRealTimePVPBattleStart");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache1, true);
		string name2 = "RealTimePVPBattleId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.get_RealTimePVPBattleId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.set_RealTimePVPBattleId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataRealTimePVPBattleStart.<>f__mg$cache4, typeof(ClientBattle.LogDataRealTimePVPBattleStart));
	}

	// Token: 0x04010855 RID: 67669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010856 RID: 67670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010857 RID: 67671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010858 RID: 67672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010859 RID: 67673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
