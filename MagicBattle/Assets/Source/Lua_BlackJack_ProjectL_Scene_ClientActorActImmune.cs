using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012FF RID: 4863
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActImmune : LuaObject
{
	// Token: 0x0601A213 RID: 107027 RVA: 0x007AEE3C File Offset: 0x007AD03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActImmune o = new ClientActorActImmune();
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

	// Token: 0x0601A214 RID: 107028 RVA: 0x007AEE84 File Offset: 0x007AD084
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActImmune");
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActImmune.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActImmune.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActImmune.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActImmune.<>f__mg$cache0, typeof(ClientActorActImmune), typeof(ClientActorAct));
	}

	// Token: 0x040105F7 RID: 67063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
