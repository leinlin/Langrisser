using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013EA RID: 5098
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ChatGetPlayrInfoListNetTask : LuaObject
{
	// Token: 0x0601C937 RID: 117047 RVA: 0x008E2F5C File Offset: 0x008E115C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<string> playerIdList;
			LuaObject.checkType<List<string>>(l, 2, out playerIdList);
			ChatGetPlayrInfoListNetTask o = new ChatGetPlayrInfoListNetTask(playerIdList);
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

	// Token: 0x0601C938 RID: 117048 RVA: 0x008E2FB0 File Offset: 0x008E11B0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ChatGetPlayrInfoListNetTask");
		if (Lua_BlackJack_ProjectL_UI_ChatGetPlayrInfoListNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ChatGetPlayrInfoListNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ChatGetPlayrInfoListNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ChatGetPlayrInfoListNetTask.<>f__mg$cache0, typeof(ChatGetPlayrInfoListNetTask), typeof(UINetTask));
	}

	// Token: 0x04012B45 RID: 76613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
