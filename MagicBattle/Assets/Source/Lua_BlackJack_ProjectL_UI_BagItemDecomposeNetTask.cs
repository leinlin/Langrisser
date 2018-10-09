using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Protocol;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001392 RID: 5010
[Preserve]
public class Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask : LuaObject
{
	// Token: 0x0601B521 RID: 111905 RVA: 0x0084347C File Offset: 0x0084167C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			List<ProGoods> goods;
			LuaObject.checkType<List<ProGoods>>(l, 2, out goods);
			BagItemDecomposeNetTask o = new BagItemDecomposeNetTask(goods);
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

	// Token: 0x0601B522 RID: 111906 RVA: 0x008434D0 File Offset: 0x008416D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			BagItemDecomposeNetTask bagItemDecomposeNetTask = (BagItemDecomposeNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, bagItemDecomposeNetTask.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601B523 RID: 111907 RVA: 0x00843524 File Offset: 0x00841724
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.BagItemDecomposeNetTask");
		string name = "Reward";
		if (Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.get_Reward);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_BagItemDecomposeNetTask.<>f__mg$cache1, typeof(BagItemDecomposeNetTask), typeof(UINetTask));
	}

	// Token: 0x040117DF RID: 71647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040117E0 RID: 71648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
