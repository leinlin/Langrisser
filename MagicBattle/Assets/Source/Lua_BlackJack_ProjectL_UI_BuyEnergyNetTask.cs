using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020013DF RID: 5087
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BuyEnergyNetTask : LuaObject
{
	// Token: 0x0601C86A RID: 116842 RVA: 0x008DCF6C File Offset: 0x008DB16C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BuyEnergyNetTask o = new BuyEnergyNetTask();
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

	// Token: 0x0601C86B RID: 116843 RVA: 0x008DCFB4 File Offset: 0x008DB1B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BuyEnergyNetTask");
		if (Lua_BlackJack_ProjectL_UI_BuyEnergyNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BuyEnergyNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BuyEnergyNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BuyEnergyNetTask.<>f__mg$cache0, typeof(BuyEnergyNetTask), typeof(UINetTask));
	}

	// Token: 0x04012A8E RID: 76430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
