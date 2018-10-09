using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001350 RID: 4944
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ActivityExchangeItemGroupNetTask : LuaObject
{
	// Token: 0x0601A916 RID: 108822 RVA: 0x007E3724 File Offset: 0x007E1924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong activityInatanceID;
			LuaObject.checkType(l, 2, out activityInatanceID);
			int itemGroupIndex;
			LuaObject.checkType(l, 3, out itemGroupIndex);
			ActivityExchangeItemGroupNetTask o = new ActivityExchangeItemGroupNetTask(activityInatanceID, itemGroupIndex);
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

	// Token: 0x0601A917 RID: 108823 RVA: 0x007E3784 File Offset: 0x007E1984
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ActivityExchangeItemGroupNetTask");
		if (Lua_BlackJack_ProjectL_UI_ActivityExchangeItemGroupNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ActivityExchangeItemGroupNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ActivityExchangeItemGroupNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ActivityExchangeItemGroupNetTask.<>f__mg$cache0, typeof(ActivityExchangeItemGroupNetTask), typeof(UINetTask));
	}

	// Token: 0x04010C58 RID: 68696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
