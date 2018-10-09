using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013D9 RID: 5081
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BusinessCardHeroSetUpdateNetTask : LuaObject
{
	// Token: 0x0601C6CC RID: 116428 RVA: 0x008D041C File Offset: 0x008CE61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<BusinessCardHeroSet> heroSetList;
			LuaObject.checkType<List<BusinessCardHeroSet>>(l, 2, out heroSetList);
			BusinessCardHeroSetUpdateNetTask o = new BusinessCardHeroSetUpdateNetTask(heroSetList);
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

	// Token: 0x0601C6CD RID: 116429 RVA: 0x008D0470 File Offset: 0x008CE670
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BusinessCardHeroSetUpdateNetTask");
		if (Lua_BlackJack_ProjectL_UI_BusinessCardHeroSetUpdateNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BusinessCardHeroSetUpdateNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BusinessCardHeroSetUpdateNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BusinessCardHeroSetUpdateNetTask.<>f__mg$cache0, typeof(BusinessCardHeroSetUpdateNetTask), typeof(UINetTask));
	}

	// Token: 0x040128FC RID: 76028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
