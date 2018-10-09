using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020014A1 RID: 5281
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroAssistantCancelTaskNetTask : LuaObject
{
	// Token: 0x0601E929 RID: 125225 RVA: 0x009E07B0 File Offset: 0x009DE9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int taskIndex;
			LuaObject.checkType(l, 2, out taskIndex);
			int slot;
			LuaObject.checkType(l, 3, out slot);
			HeroAssistantCancelTaskNetTask o = new HeroAssistantCancelTaskNetTask(taskIndex, slot);
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

	// Token: 0x0601E92A RID: 125226 RVA: 0x009E0810 File Offset: 0x009DEA10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroAssistantCancelTaskNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroAssistantCancelTaskNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroAssistantCancelTaskNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroAssistantCancelTaskNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroAssistantCancelTaskNetTask.<>f__mg$cache0, typeof(HeroAssistantCancelTaskNetTask), typeof(UINetTask));
	}

	// Token: 0x040149C9 RID: 84425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
