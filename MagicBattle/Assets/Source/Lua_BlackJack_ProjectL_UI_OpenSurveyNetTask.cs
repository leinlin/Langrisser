using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001521 RID: 5409
[Preserve]
public class Lua_BlackJack_ProjectL_UI_OpenSurveyNetTask : LuaObject
{
	// Token: 0x060201F0 RID: 131568 RVA: 0x00AA6044 File Offset: 0x00AA4244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			OpenSurveyNetTask o = new OpenSurveyNetTask();
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

	// Token: 0x060201F1 RID: 131569 RVA: 0x00AA608C File Offset: 0x00AA428C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.OpenSurveyNetTask");
		if (Lua_BlackJack_ProjectL_UI_OpenSurveyNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_OpenSurveyNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_OpenSurveyNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_OpenSurveyNetTask.<>f__mg$cache0, typeof(OpenSurveyNetTask), typeof(UINetTask));
	}

	// Token: 0x04016190 RID: 90512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
