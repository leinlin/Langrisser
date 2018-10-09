using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001410 RID: 5136
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DanmakuGetNetTask : LuaObject
{
	// Token: 0x0601D0AB RID: 118955 RVA: 0x0091E680 File Offset: 0x0091C880
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			DanmakuGetNetTask o = new DanmakuGetNetTask(gameFunctionTypeId, locationId);
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

	// Token: 0x0601D0AC RID: 118956 RVA: 0x0091E6E0 File Offset: 0x0091C8E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DanmakuGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_DanmakuGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_DanmakuGetNetTask.<>f__mg$cache0, typeof(DanmakuGetNetTask), typeof(UINetTask));
	}

	// Token: 0x0401326D RID: 78445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
