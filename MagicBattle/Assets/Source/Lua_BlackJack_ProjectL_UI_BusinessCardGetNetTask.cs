using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013D5 RID: 5077
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardGetNetTask : LuaObject
{
	// Token: 0x0601C654 RID: 116308 RVA: 0x008CC5F4 File Offset: 0x008CA7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string userID;
			LuaObject.checkType(l, 2, out userID);
			BusinessCardGetNetTask o = new BusinessCardGetNetTask(userID);
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

	// Token: 0x0601C655 RID: 116309 RVA: 0x008CC648 File Offset: 0x008CA848
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BusinessCardGetNetTask.<>f__mg$cache0, typeof(BusinessCardGetNetTask), typeof(UINetTask));
	}

	// Token: 0x0401288C RID: 75916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
