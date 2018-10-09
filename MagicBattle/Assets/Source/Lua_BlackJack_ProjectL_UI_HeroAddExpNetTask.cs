using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200149D RID: 5277
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroAddExpNetTask : LuaObject
{
	// Token: 0x0601E8B2 RID: 125106 RVA: 0x009DCE64 File Offset: 0x009DB064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			GoodsType goodsType;
			LuaObject.checkEnum<GoodsType>(l, 3, out goodsType);
			int itemId;
			LuaObject.checkType(l, 4, out itemId);
			int count;
			LuaObject.checkType(l, 5, out count);
			HeroAddExpNetTask o = new HeroAddExpNetTask(heroId, goodsType, itemId, count);
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

	// Token: 0x0601E8B3 RID: 125107 RVA: 0x009DCEE0 File Offset: 0x009DB0E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroAddExpNetTask");
		if (Lua_BlackJack_ProjectL_UI_HeroAddExpNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroAddExpNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroAddExpNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroAddExpNetTask.<>f__mg$cache0, typeof(HeroAddExpNetTask), typeof(UINetTask));
	}

	// Token: 0x0401495A RID: 84314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
