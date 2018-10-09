using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200145F RID: 5215
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetRandomStoreItemListNetTask : LuaObject
{
	// Token: 0x0601E1FB RID: 123387 RVA: 0x009A87F8 File Offset: 0x009A69F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int randomStoreID;
			LuaObject.checkType(l, 2, out randomStoreID);
			GetRandomStoreItemListNetTask o = new GetRandomStoreItemListNetTask(randomStoreID);
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

	// Token: 0x0601E1FC RID: 123388 RVA: 0x009A884C File Offset: 0x009A6A4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetRandomStoreItemListNetTask");
		if (Lua_BlackJack_ProjectL_UI_GetRandomStoreItemListNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetRandomStoreItemListNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetRandomStoreItemListNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GetRandomStoreItemListNetTask.<>f__mg$cache0, typeof(GetRandomStoreItemListNetTask), typeof(UINetTask));
	}

	// Token: 0x0401431F RID: 82719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
