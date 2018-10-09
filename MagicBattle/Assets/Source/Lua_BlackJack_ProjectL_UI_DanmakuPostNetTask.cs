using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001412 RID: 5138
[Preserve]
public class Lua_BlackJack_ProjectL_UI_DanmakuPostNetTask : LuaObject
{
	// Token: 0x0601D0C8 RID: 118984 RVA: 0x0091F538 File Offset: 0x0091D738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int gameFunctionTypeId;
			LuaObject.checkType(l, 2, out gameFunctionTypeId);
			int locationId;
			LuaObject.checkType(l, 3, out locationId);
			List<PostDanmakuEntry> entries;
			LuaObject.checkType<List<PostDanmakuEntry>>(l, 4, out entries);
			DanmakuPostNetTask o = new DanmakuPostNetTask(gameFunctionTypeId, locationId, entries);
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

	// Token: 0x0601D0C9 RID: 118985 RVA: 0x0091F5A8 File Offset: 0x0091D7A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.DanmakuPostNetTask");
		if (Lua_BlackJack_ProjectL_UI_DanmakuPostNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_DanmakuPostNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_DanmakuPostNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_DanmakuPostNetTask.<>f__mg$cache0, typeof(DanmakuPostNetTask), typeof(UINetTask));
	}

	// Token: 0x04013286 RID: 78470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
