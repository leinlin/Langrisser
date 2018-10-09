using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200132B RID: 4907
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientNullActorActCancelCombat : LuaObject
{
	// Token: 0x0601A5A6 RID: 107942 RVA: 0x007CA04C File Offset: 0x007C824C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientNullActorActCancelCombat o = new ClientNullActorActCancelCombat();
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

	// Token: 0x0601A5A7 RID: 107943 RVA: 0x007CA094 File Offset: 0x007C8294
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientNullActorActCancelCombat");
		if (Lua_BlackJack_ProjectL_Scene_ClientNullActorActCancelCombat.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientNullActorActCancelCombat.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientNullActorActCancelCombat.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientNullActorActCancelCombat.<>f__mg$cache0, typeof(ClientNullActorActCancelCombat), typeof(ClientActorAct));
	}

	// Token: 0x04010932 RID: 67890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
