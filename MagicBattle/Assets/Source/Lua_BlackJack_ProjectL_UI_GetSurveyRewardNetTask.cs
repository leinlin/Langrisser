using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001462 RID: 5218
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GetSurveyRewardNetTask : LuaObject
{
	// Token: 0x0601E254 RID: 123476 RVA: 0x009AB3B0 File Offset: 0x009A95B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GetSurveyRewardNetTask o = new GetSurveyRewardNetTask();
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

	// Token: 0x0601E255 RID: 123477 RVA: 0x009AB3F8 File Offset: 0x009A95F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GetSurveyRewardNetTask");
		if (Lua_BlackJack_ProjectL_UI_GetSurveyRewardNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GetSurveyRewardNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GetSurveyRewardNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GetSurveyRewardNetTask.<>f__mg$cache0, typeof(GetSurveyRewardNetTask), typeof(UINetTask));
	}

	// Token: 0x04014372 RID: 82802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
