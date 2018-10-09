using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014A0 RID: 5280
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroAssistantAssignToTaskNetTask : LuaObject
{
	// Token: 0x0601E926 RID: 125222 RVA: 0x009E06DC File Offset: 0x009DE8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int taskIndex;
			LuaObject.checkType(l, 2, out taskIndex);
			List<int> heroIds;
			LuaObject.checkType<List<int>>(l, 3, out heroIds);
			int workSeconds;
			LuaObject.checkType(l, 4, out workSeconds);
			int slot;
			LuaObject.checkType(l, 5, out slot);
			HeroAssistantAssignToTaskNetTask o = new HeroAssistantAssignToTaskNetTask(taskIndex, heroIds, workSeconds, slot);
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

	// Token: 0x0601E927 RID: 125223 RVA: 0x009E0758 File Offset: 0x009DE958
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroAssistantAssignToTaskNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroAssistantAssignToTaskNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroAssistantAssignToTaskNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroAssistantAssignToTaskNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroAssistantAssignToTaskNetTask.<>f__mg$cache0, typeof(HeroAssistantAssignToTaskNetTask), typeof(UINetTask));
	}

	// Token: 0x040149C8 RID: 84424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
