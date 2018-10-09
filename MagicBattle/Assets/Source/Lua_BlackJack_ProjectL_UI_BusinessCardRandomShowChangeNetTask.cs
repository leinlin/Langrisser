using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013DB RID: 5083
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardRandomShowChangeNetTask : LuaObject
{
	// Token: 0x0601C6EA RID: 116458 RVA: 0x008D1378 File Offset: 0x008CF578
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			bool isRandomShow;
			LuaObject.checkType(l, 2, out isRandomShow);
			BusinessCardRandomShowChangeNetTask o = new BusinessCardRandomShowChangeNetTask(isRandomShow);
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

	// Token: 0x0601C6EB RID: 116459 RVA: 0x008D13CC File Offset: 0x008CF5CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardRandomShowChangeNetTask");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardRandomShowChangeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardRandomShowChangeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardRandomShowChangeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BusinessCardRandomShowChangeNetTask.<>f__mg$cache0, typeof(BusinessCardRandomShowChangeNetTask), typeof(UINetTask));
	}

	// Token: 0x04012916 RID: 76054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
