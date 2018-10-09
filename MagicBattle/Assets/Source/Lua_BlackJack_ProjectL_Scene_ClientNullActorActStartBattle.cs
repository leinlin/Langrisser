using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001335 RID: 4917
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattle : LuaObject
{
	// Token: 0x0601A5E2 RID: 108002 RVA: 0x007CB4CC File Offset: 0x007C96CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActStartBattle o = new ClientNullActorActStartBattle();
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

	// Token: 0x0601A5E3 RID: 108003 RVA: 0x007CB514 File Offset: 0x007C9714
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActStartBattle");
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattle.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattle.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActStartBattle.<>f__mg$cache0, typeof(ClientNullActorActStartBattle), typeof(ClientActorAct));
	}

	// Token: 0x0401095A RID: 67930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
