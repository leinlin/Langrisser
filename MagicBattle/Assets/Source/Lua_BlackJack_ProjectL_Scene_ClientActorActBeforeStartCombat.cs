using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F4 RID: 4852
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat : LuaObject
{
	// Token: 0x0601A1C4 RID: 106948 RVA: 0x007AD190 File Offset: 0x007AB390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBeforeStartCombat o = new ClientActorActBeforeStartCombat();
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

	// Token: 0x0601A1C5 RID: 106949 RVA: 0x007AD1D8 File Offset: 0x007AB3D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBeforeStartCombat clientActorActBeforeStartCombat = (ClientActorActBeforeStartCombat)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActBeforeStartCombat.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1C6 RID: 106950 RVA: 0x007AD22C File Offset: 0x007AB42C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActBeforeStartCombat clientActorActBeforeStartCombat = (ClientActorActBeforeStartCombat)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActBeforeStartCombat.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A1C7 RID: 106951 RVA: 0x007AD284 File Offset: 0x007AB484
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActBeforeStartCombat");
		string name = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.get_m_direction);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.set_m_direction);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActBeforeStartCombat.<>f__mg$cache2, typeof(ClientActorActBeforeStartCombat), typeof(ClientActorAct));
	}

	// Token: 0x040105BE RID: 67006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040105BF RID: 67007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040105C0 RID: 67008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
