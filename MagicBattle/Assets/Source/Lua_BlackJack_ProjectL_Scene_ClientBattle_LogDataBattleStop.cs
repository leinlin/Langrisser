using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200131F RID: 4895
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop : LuaObject
{
	// Token: 0x0601A4A0 RID: 107680 RVA: 0x007C18EC File Offset: 0x007BFAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleStop o = new ClientBattle.LogDataBattleStop();
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

	// Token: 0x0601A4A1 RID: 107681 RVA: 0x007C1934 File Offset: 0x007BFB34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleStop logDataBattleStop = (ClientBattle.LogDataBattleStop)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataBattleStop.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4A2 RID: 107682 RVA: 0x007C1988 File Offset: 0x007BFB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleStop logDataBattleStop = (ClientBattle.LogDataBattleStop)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataBattleStop.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4A3 RID: 107683 RVA: 0x007C19E0 File Offset: 0x007BFBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsWin(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleStop logDataBattleStop = (ClientBattle.LogDataBattleStop)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataBattleStop.IsWin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4A4 RID: 107684 RVA: 0x007C1A34 File Offset: 0x007BFC34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsWin(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataBattleStop logDataBattleStop = (ClientBattle.LogDataBattleStop)LuaObject.checkSelf(l);
			bool isWin;
			LuaObject.checkType(l, 2, out isWin);
			logDataBattleStop.IsWin = isWin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4A5 RID: 107685 RVA: 0x007C1A8C File Offset: 0x007BFC8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataBattleStop");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache1, true);
		string name2 = "IsWin";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.get_IsWin);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.set_IsWin);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataBattleStop.<>f__mg$cache4, typeof(ClientBattle.LogDataBattleStop));
	}

	// Token: 0x04010844 RID: 67652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010845 RID: 67653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010846 RID: 67654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010847 RID: 67655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010848 RID: 67656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
