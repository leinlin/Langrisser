using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001393 RID: 5011
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagItemSellNetTask : LuaObject
{
	// Token: 0x0601B525 RID: 111909 RVA: 0x008435A8 File Offset: 0x008417A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			int count;
			LuaObject.checkType(l, 3, out count);
			BagItemSellNetTask o = new BagItemSellNetTask(instanceId, count);
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

	// Token: 0x0601B526 RID: 111910 RVA: 0x00843608 File Offset: 0x00841808
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagItemSellNetTask");
		if (Lua_BlackJack_ProjectL_UI_BagItemSellNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemSellNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemSellNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BagItemSellNetTask.<>f__mg$cache0, typeof(BagItemSellNetTask), typeof(UINetTask));
	}

	// Token: 0x040117E1 RID: 71649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
