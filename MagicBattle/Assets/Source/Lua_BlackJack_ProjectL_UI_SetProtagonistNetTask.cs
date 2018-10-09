using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001575 RID: 5493
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SetProtagonistNetTask : LuaObject
{
	// Token: 0x06021057 RID: 135255 RVA: 0x00B18FFC File Offset: 0x00B171FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int protagonistId;
			LuaObject.checkType(l, 2, out protagonistId);
			SetProtagonistNetTask o = new SetProtagonistNetTask(protagonistId);
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

	// Token: 0x06021058 RID: 135256 RVA: 0x00B19050 File Offset: 0x00B17250
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SetProtagonistNetTask");
		if (Lua_BlackJack_ProjectL_UI_SetProtagonistNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SetProtagonistNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SetProtagonistNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SetProtagonistNetTask.<>f__mg$cache0, typeof(SetProtagonistNetTask), typeof(UINetTask));
	}

	// Token: 0x04016F4F RID: 94031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
