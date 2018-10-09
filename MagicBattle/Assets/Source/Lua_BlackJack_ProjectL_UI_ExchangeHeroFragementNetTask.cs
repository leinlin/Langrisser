using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001433 RID: 5171
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask : LuaObject
{
	// Token: 0x0601DA7F RID: 121471 RVA: 0x0096CBD4 File Offset: 0x0096ADD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ExchangeHeroFragementNetTask o = new ExchangeHeroFragementNetTask();
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

	// Token: 0x0601DA80 RID: 121472 RVA: 0x0096CC1C File Offset: 0x0096AE1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			ExchangeHeroFragementNetTask exchangeHeroFragementNetTask = (ExchangeHeroFragementNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, exchangeHeroFragementNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA81 RID: 121473 RVA: 0x0096CC70 File Offset: 0x0096AE70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ExchangeHeroFragementNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ExchangeHeroFragementNetTask.<>f__mg$cache1, typeof(ExchangeHeroFragementNetTask), typeof(UINetTask));
	}

	// Token: 0x04013BFB RID: 80891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013BFC RID: 80892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
