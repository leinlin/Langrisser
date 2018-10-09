using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012EF RID: 4847
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActActionBegin : LuaObject
{
	// Token: 0x0601A1A7 RID: 106919 RVA: 0x007AC7D0 File Offset: 0x007AA9D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActActionBegin o = new ClientActorActActionBegin();
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

	// Token: 0x0601A1A8 RID: 106920 RVA: 0x007AC818 File Offset: 0x007AAA18
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActActionBegin");
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActActionBegin.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActActionBegin.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActActionBegin.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActActionBegin.<>f__mg$cache0, typeof(ClientActorActActionBegin), typeof(ClientActorAct));
	}

	// Token: 0x040105AB RID: 66987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
