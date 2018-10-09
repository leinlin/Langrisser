using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001321 RID: 4897
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart : LuaObject
{
	// Token: 0x0601A4B0 RID: 107696 RVA: 0x007C1ED4 File Offset: 0x007C00D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataPVPBattleStart o = new ClientBattle.LogDataPVPBattleStart();
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

	// Token: 0x0601A4B1 RID: 107697 RVA: 0x007C1F1C File Offset: 0x007C011C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataPVPBattleStart logDataPVPBattleStart = (ClientBattle.LogDataPVPBattleStart)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataPVPBattleStart.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4B2 RID: 107698 RVA: 0x007C1F70 File Offset: 0x007C0170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataPVPBattleStart logDataPVPBattleStart = (ClientBattle.LogDataPVPBattleStart)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataPVPBattleStart.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4B3 RID: 107699 RVA: 0x007C1FC8 File Offset: 0x007C01C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PVPBattleId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataPVPBattleStart logDataPVPBattleStart = (ClientBattle.LogDataPVPBattleStart)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataPVPBattleStart.PVPBattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4B4 RID: 107700 RVA: 0x007C201C File Offset: 0x007C021C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PVPBattleId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataPVPBattleStart logDataPVPBattleStart = (ClientBattle.LogDataPVPBattleStart)LuaObject.checkSelf(l);
			int pvpbattleId;
			LuaObject.checkType(l, 2, out pvpbattleId);
			logDataPVPBattleStart.PVPBattleId = pvpbattleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A4B5 RID: 107701 RVA: 0x007C2074 File Offset: 0x007C0274
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataPVPBattleStart");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache1, true);
		string name2 = "PVPBattleId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.get_PVPBattleId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.set_PVPBattleId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataPVPBattleStart.<>f__mg$cache4, typeof(ClientBattle.LogDataPVPBattleStart));
	}

	// Token: 0x04010850 RID: 67664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010851 RID: 67665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010852 RID: 67666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010853 RID: 67667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010854 RID: 67668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
