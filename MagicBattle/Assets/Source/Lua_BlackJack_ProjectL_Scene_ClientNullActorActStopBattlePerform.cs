using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001337 RID: 4919
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActStopBattlePerform : LuaObject
{
	// Token: 0x0601A5EA RID: 108010 RVA: 0x007CB700 File Offset: 0x007C9900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActStopBattlePerform o = new ClientNullActorActStopBattlePerform();
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

	// Token: 0x0601A5EB RID: 108011 RVA: 0x007CB748 File Offset: 0x007C9948
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActStopBattlePerform");
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActStopBattlePerform.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActStopBattlePerform.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStopBattlePerform.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActStopBattlePerform.<>f__mg$cache0, typeof(ClientNullActorActStopBattlePerform), typeof(ClientActorAct));
	}

	// Token: 0x0401095E RID: 67934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
