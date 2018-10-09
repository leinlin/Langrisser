using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200137B RID: 4987
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaPlayerInfoGetNetTask : LuaObject
{
	// Token: 0x0601AFE5 RID: 110565 RVA: 0x00819AF4 File Offset: 0x00817CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaPlayerInfoGetNetTask o = new ArenaPlayerInfoGetNetTask();
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

	// Token: 0x0601AFE6 RID: 110566 RVA: 0x00819B3C File Offset: 0x00817D3C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaPlayerInfoGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaPlayerInfoGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaPlayerInfoGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaPlayerInfoGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaPlayerInfoGetNetTask.<>f__mg$cache0, typeof(ArenaPlayerInfoGetNetTask), typeof(UINetTask));
	}

	// Token: 0x040112D1 RID: 70353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
