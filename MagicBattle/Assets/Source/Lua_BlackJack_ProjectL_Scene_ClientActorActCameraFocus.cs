using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Scene;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012F6 RID: 4854
[Preserve]
public class Lua_BlackJack_ProjectL_Scene_ClientActorActCameraFocus : LuaObject
{
	// Token: 0x0601A1D8 RID: 106968 RVA: 0x007AD970 File Offset: 0x007ABB70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ClientActorActCameraFocus o = new ClientActorActCameraFocus();
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

	// Token: 0x0601A1D9 RID: 106969 RVA: 0x007AD9B8 File Offset: 0x007ABBB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Scene.ClientActorActCameraFocus");
		if (Lua_BlackJack_ProjectL_Scene_ClientActorActCameraFocus.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Scene_ClientActorActCameraFocus.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Scene_ClientActorActCameraFocus.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Scene_ClientActorActCameraFocus.<>f__mg$cache0, typeof(ClientActorActCameraFocus), typeof(ClientActorAct));
	}

	// Token: 0x040105CE RID: 67022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
