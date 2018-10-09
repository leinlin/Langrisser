using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F7 RID: 4855
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy : LuaObject
{
	// Token: 0x0601A1DB RID: 106971 RVA: 0x007ADA10 File Offset: 0x007ABC10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeArmy o = new ClientActorActChangeArmy();
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

	// Token: 0x0601A1DC RID: 106972 RVA: 0x007ADA58 File Offset: 0x007ABC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeArmy clientActorActChangeArmy = (ClientActorActChangeArmy)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActChangeArmy.m_heroArmyInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1DD RID: 106973 RVA: 0x007ADAAC File Offset: 0x007ABCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroArmyInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActChangeArmy clientActorActChangeArmy = (ClientActorActChangeArmy)LuaObject.checkSelf(l);
			ConfigDataArmyInfo heroArmyInfo;
			LuaObject.checkType<ConfigDataArmyInfo>(l, 2, out heroArmyInfo);
			clientActorActChangeArmy.m_heroArmyInfo = heroArmyInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1DE RID: 106974 RVA: 0x007ADB04 File Offset: 0x007ABD04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActChangeArmy");
		string name = "m_heroArmyInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.get_m_heroArmyInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.set_m_heroArmyInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActChangeArmy.<>f__mg$cache2, typeof(ClientActorActChangeArmy), typeof(ClientActorAct));
	}

	// Token: 0x040105CF RID: 67023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105D0 RID: 67024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105D1 RID: 67025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
