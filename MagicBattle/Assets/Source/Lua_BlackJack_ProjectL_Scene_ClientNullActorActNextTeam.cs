using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001330 RID: 4912
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam : LuaObject
{
	// Token: 0x0601A5C5 RID: 107973 RVA: 0x007CAB04 File Offset: 0x007C8D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTeam o = new ClientNullActorActNextTeam();
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

	// Token: 0x0601A5C6 RID: 107974 RVA: 0x007CAB4C File Offset: 0x007C8D4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_team(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTeam clientNullActorActNextTeam = (ClientNullActorActNextTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActNextTeam.m_team);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C7 RID: 107975 RVA: 0x007CABA0 File Offset: 0x007C8DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_team(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTeam clientNullActorActNextTeam = (ClientNullActorActNextTeam)LuaObject.checkSelf(l);
			int team;
			LuaObject.checkType(l, 2, out team);
			clientNullActorActNextTeam.m_team = team;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C8 RID: 107976 RVA: 0x007CABF8 File Offset: 0x007C8DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_focusActor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTeam clientNullActorActNextTeam = (ClientNullActorActNextTeam)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActNextTeam.m_focusActor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5C9 RID: 107977 RVA: 0x007CAC4C File Offset: 0x007C8E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_focusActor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActNextTeam clientNullActorActNextTeam = (ClientNullActorActNextTeam)LuaObject.checkSelf(l);
			ClientBattleActor focusActor;
			LuaObject.checkType<ClientBattleActor>(l, 2, out focusActor);
			clientNullActorActNextTeam.m_focusActor = focusActor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5CA RID: 107978 RVA: 0x007CACA4 File Offset: 0x007C8EA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActNextTeam");
		string name = "m_team";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.get_m_team);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.set_m_team);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache1, true);
		string name2 = "m_focusActor";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.get_m_focusActor);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.set_m_focusActor);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActNextTeam.<>f__mg$cache4, typeof(ClientNullActorActNextTeam), typeof(ClientActorAct));
	}

	// Token: 0x04010947 RID: 67911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04010948 RID: 67912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010949 RID: 67913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401094A RID: 67914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401094B RID: 67915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
