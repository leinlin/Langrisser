using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001338 RID: 4920
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime : LuaObject
{
	// Token: 0x0601A5ED RID: 108013 RVA: 0x007CB7A0 File Offset: 0x007C99A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActWaitTime o = new ClientNullActorActWaitTime();
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

	// Token: 0x0601A5EE RID: 108014 RVA: 0x007CB7E8 File Offset: 0x007C99E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_time(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActWaitTime clientNullActorActWaitTime = (ClientNullActorActWaitTime)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActWaitTime.m_time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5EF RID: 108015 RVA: 0x007CB83C File Offset: 0x007C9A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_time(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActWaitTime clientNullActorActWaitTime = (ClientNullActorActWaitTime)LuaObject.checkSelf(l);
			int time;
			LuaObject.checkType(l, 2, out time);
			clientNullActorActWaitTime.m_time = time;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5F0 RID: 108016 RVA: 0x007CB894 File Offset: 0x007C9A94
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActWaitTime");
		string name = "m_time";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.get_m_time);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.set_m_time);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActWaitTime.<>f__mg$cache2, typeof(ClientNullActorActWaitTime), typeof(ClientActorAct));
	}

	// Token: 0x0401095F RID: 67935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010960 RID: 67936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010961 RID: 67937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
