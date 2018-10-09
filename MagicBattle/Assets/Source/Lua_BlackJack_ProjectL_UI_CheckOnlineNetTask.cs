using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013F0 RID: 5104
[Preserve]
public class Lua_BlackJack_ProjectL_UI_CheckOnlineNetTask : LuaObject
{
	// Token: 0x0601CAAE RID: 117422 RVA: 0x008EE744 File Offset: 0x008EC944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CheckOnlineNetTask o = new CheckOnlineNetTask();
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

	// Token: 0x0601CAAF RID: 117423 RVA: 0x008EE78C File Offset: 0x008EC98C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.CheckOnlineNetTask");
		if (Lua_BlackJack_ProjectL_UI_CheckOnlineNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_CheckOnlineNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_CheckOnlineNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_CheckOnlineNetTask.<>f__mg$cache0, typeof(CheckOnlineNetTask), typeof(UINetTask));
	}

	// Token: 0x04012CB0 RID: 76976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
