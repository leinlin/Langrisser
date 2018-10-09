using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200131D RID: 4893
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart : LuaObject
{
	// Token: 0x0601A492 RID: 107666 RVA: 0x007C13F4 File Offset: 0x007BF5F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataArenaBattleStart o = new ClientBattle.LogDataArenaBattleStart();
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

	// Token: 0x0601A493 RID: 107667 RVA: 0x007C143C File Offset: 0x007BF63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataArenaBattleStart logDataArenaBattleStart = (ClientBattle.LogDataArenaBattleStart)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataArenaBattleStart.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A494 RID: 107668 RVA: 0x007C1490 File Offset: 0x007BF690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataArenaBattleStart logDataArenaBattleStart = (ClientBattle.LogDataArenaBattleStart)LuaObject.checkSelf(l);
			string type;
			LuaObject.checkType(l, 2, out type);
			logDataArenaBattleStart.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A495 RID: 107669 RVA: 0x007C14E8 File Offset: 0x007BF6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaBattleId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataArenaBattleStart logDataArenaBattleStart = (ClientBattle.LogDataArenaBattleStart)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, logDataArenaBattleStart.ArenaBattleId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A496 RID: 107670 RVA: 0x007C153C File Offset: 0x007BF73C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaBattleId(IntPtr l)
	{
		int result;
		try
		{
			ClientBattle.LogDataArenaBattleStart logDataArenaBattleStart = (ClientBattle.LogDataArenaBattleStart)LuaObject.checkSelf(l);
			int arenaBattleId;
			LuaObject.checkType(l, 2, out arenaBattleId);
			logDataArenaBattleStart.ArenaBattleId = arenaBattleId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A497 RID: 107671 RVA: 0x007C1594 File Offset: 0x007BF794
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientBattle.LogDataArenaBattleStart");
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache1, true);
		string name2 = "ArenaBattleId";
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.get_ArenaBattleId);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.set_ArenaBattleId);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientBattle_LogDataArenaBattleStart.<>f__mg$cache4, typeof(ClientBattle.LogDataArenaBattleStart));
	}

	// Token: 0x0401083A RID: 67642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401083B RID: 67643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401083C RID: 67644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401083D RID: 67645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401083E RID: 67646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
