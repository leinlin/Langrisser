using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012FB RID: 4859
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActDie : LuaObject
{
	// Token: 0x0601A1F7 RID: 106999 RVA: 0x007AE424 File Offset: 0x007AC624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDie o = new ClientActorActDie();
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

	// Token: 0x0601A1F8 RID: 107000 RVA: 0x007AE46C File Offset: 0x007AC66C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isAfterCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDie clientActorActDie = (ClientActorActDie)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActDie.m_isAfterCombat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1F9 RID: 107001 RVA: 0x007AE4C0 File Offset: 0x007AC6C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isAfterCombat(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActDie clientActorActDie = (ClientActorActDie)LuaObject.checkSelf(l);
			bool isAfterCombat;
			LuaObject.checkType(l, 2, out isAfterCombat);
			clientActorActDie.m_isAfterCombat = isAfterCombat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1FA RID: 107002 RVA: 0x007AE518 File Offset: 0x007AC718
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActDie");
		string name = "m_isAfterCombat";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDie.get_m_isAfterCombat);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDie.set_m_isAfterCombat);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActDie.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActDie.<>f__mg$cache2, typeof(ClientActorActDie), typeof(ClientActorAct));
	}

	// Token: 0x040105E3 RID: 67043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105E4 RID: 67044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105E5 RID: 67045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
