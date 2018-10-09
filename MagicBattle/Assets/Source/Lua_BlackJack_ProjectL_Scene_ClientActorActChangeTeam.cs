using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F9 RID: 4857
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam : LuaObject
{
	// Token: 0x0601A1E5 RID: 106981 RVA: 0x007ADD38 File Offset: 0x007ABF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeTeam o = new ClientActorActChangeTeam();
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

	// Token: 0x0601A1E6 RID: 106982 RVA: 0x007ADD80 File Offset: 0x007ABF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeTeam clientActorActChangeTeam = (ClientActorActChangeTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActChangeTeam.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1E7 RID: 106983 RVA: 0x007ADDD4 File Offset: 0x007ABFD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeTeam clientActorActChangeTeam = (ClientActorActChangeTeam)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			clientActorActChangeTeam.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1E8 RID: 106984 RVA: 0x007ADE2C File Offset: 0x007AC02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAINpc(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeTeam clientActorActChangeTeam = (ClientActorActChangeTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActChangeTeam.m_isAINpc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1E9 RID: 106985 RVA: 0x007ADE80 File Offset: 0x007AC080
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAINpc(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeTeam clientActorActChangeTeam = (ClientActorActChangeTeam)LuaObject.checkSelf(l);
			bool isAINpc;
			LuaObject.checkType(l, 2, out isAINpc);
			clientActorActChangeTeam.m_isAINpc = isAINpc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1EA RID: 106986 RVA: 0x007ADED8 File Offset: 0x007AC0D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActChangeTeam");
		string name = "m_team";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.get_m_team);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.set_m_team);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache1, true);
		string name2 = "m_isAINpc";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.get_m_isAINpc);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.set_m_isAINpc);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeTeam.<>f__mg$cache4, typeof(ClientActorActChangeTeam), typeof(ClientActorAct));
	}

	// Token: 0x040105D5 RID: 67029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105D6 RID: 67030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105D7 RID: 67031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040105D8 RID: 67032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040105D9 RID: 67033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
