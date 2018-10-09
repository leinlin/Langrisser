using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Battle;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200132E RID: 4910
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor : LuaObject
{
	// Token: 0x0601A5B9 RID: 107961 RVA: 0x007CA6EC File Offset: 0x007C88EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextActor o = new ClientNullActorActNextActor();
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

	// Token: 0x0601A5BA RID: 107962 RVA: 0x007CA734 File Offset: 0x007C8934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nextActor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextActor clientNullActorActNextActor = (ClientNullActorActNextActor)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActNextActor.m_nextActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5BB RID: 107963 RVA: 0x007CA788 File Offset: 0x007C8988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nextActor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextActor clientNullActorActNextActor = (ClientNullActorActNextActor)LuaObject.checkSelf(l);
			BattleActor nextActor;
			LuaObject.checkType<BattleActor>(l, 2, out nextActor);
			clientNullActorActNextActor.m_nextActor = nextActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5BC RID: 107964 RVA: 0x007CA7E0 File Offset: 0x007C89E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActNextActor");
		string name = "m_nextActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.get_m_nextActor);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.set_m_nextActor);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextActor.<>f__mg$cache2, typeof(ClientNullActorActNextActor), typeof(ClientActorAct));
	}

	// Token: 0x0401093F RID: 67903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010940 RID: 67904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010941 RID: 67905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
