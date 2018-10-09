using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001308 RID: 4872
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir : LuaObject
{
	// Token: 0x0601A256 RID: 107094 RVA: 0x007B06D4 File Offset: 0x007AE8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSetDir o = new ClientActorActSetDir();
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

	// Token: 0x0601A257 RID: 107095 RVA: 0x007B071C File Offset: 0x007AE91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSetDir clientActorActSetDir = (ClientActorActSetDir)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientActorActSetDir.m_direction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A258 RID: 107096 RVA: 0x007B0770 File Offset: 0x007AE970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_direction(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActSetDir clientActorActSetDir = (ClientActorActSetDir)LuaObject.checkSelf(l);
			int direction;
			LuaObject.checkType(l, 2, out direction);
			clientActorActSetDir.m_direction = direction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A259 RID: 107097 RVA: 0x007B07C8 File Offset: 0x007AE9C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActSetDir");
		string name = "m_direction";
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.get_m_direction);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.set_m_direction);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActSetDir.<>f__mg$cache2, typeof(ClientActorActSetDir), typeof(ClientActorAct));
	}

	// Token: 0x04010628 RID: 67112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010629 RID: 67113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401062A RID: 67114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
