using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001547 RID: 5447
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RandomStoreBuyStoreItemNetTask : LuaObject
{
	// Token: 0x06020949 RID: 133449 RVA: 0x00AE0E6C File Offset: 0x00ADF06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int randomStoreID;
			LuaObject.checkType(l, 2, out randomStoreID);
			int randomStoreItemIndex;
			LuaObject.checkType(l, 3, out randomStoreItemIndex);
			RandomStoreBuyStoreItemNetTask o = new RandomStoreBuyStoreItemNetTask(randomStoreID, randomStoreItemIndex);
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

	// Token: 0x0602094A RID: 133450 RVA: 0x00AE0ECC File Offset: 0x00ADF0CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RandomStoreBuyStoreItemNetTask");
		if (Lua_BlackJack_ProjectL_UI_RandomStoreBuyStoreItemNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RandomStoreBuyStoreItemNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RandomStoreBuyStoreItemNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RandomStoreBuyStoreItemNetTask.<>f__mg$cache0, typeof(RandomStoreBuyStoreItemNetTask), typeof(UINetTask));
	}

	// Token: 0x0401689D RID: 92317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
