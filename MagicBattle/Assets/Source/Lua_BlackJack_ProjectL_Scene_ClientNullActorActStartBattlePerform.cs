using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001336 RID: 4918
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform : LuaObject
{
	// Token: 0x0601A5E5 RID: 108005 RVA: 0x007CB56C File Offset: 0x007C976C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActStartBattlePerform o = new ClientNullActorActStartBattlePerform();
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

	// Token: 0x0601A5E6 RID: 108006 RVA: 0x007CB5B4 File Offset: 0x007C97B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battlePerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActStartBattlePerform clientNullActorActStartBattlePerform = (ClientNullActorActStartBattlePerform)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clientNullActorActStartBattlePerform.m_battlePerformInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5E7 RID: 108007 RVA: 0x007CB608 File Offset: 0x007C9808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battlePerformInfo(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActStartBattlePerform clientNullActorActStartBattlePerform = (ClientNullActorActStartBattlePerform)LuaObject.checkSelf(l);
			ConfigDataBattlePerformInfo battlePerformInfo;
			LuaObject.checkType<ConfigDataBattlePerformInfo>(l, 2, out battlePerformInfo);
			clientNullActorActStartBattlePerform.m_battlePerformInfo = battlePerformInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A5E8 RID: 108008 RVA: 0x007CB660 File Offset: 0x007C9860
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActStartBattlePerform");
		string name = "m_battlePerformInfo";
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.get_m_battlePerformInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.set_m_battlePerformInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache1, true);
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattlePerform.<>f__mg$cache2, typeof(ClientNullActorActStartBattlePerform), typeof(ClientActorAct));
	}

	// Token: 0x0401095B RID: 67931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401095C RID: 67932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401095D RID: 67933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
