using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F0 RID: 4848
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActActionEnd : LuaObject
{
	// Token: 0x0601A1AA RID: 106922 RVA: 0x007AC870 File Offset: 0x007AAA70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActActionEnd o = new ClientActorActActionEnd();
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

	// Token: 0x0601A1AB RID: 106923 RVA: 0x007AC8B8 File Offset: 0x007AAAB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActActionEnd");
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActActionEnd.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActActionEnd.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActActionEnd.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActActionEnd.<>f__mg$cache0, typeof(ClientActorActActionEnd), typeof(ClientActorAct));
	}

	// Token: 0x040105AC RID: 66988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
