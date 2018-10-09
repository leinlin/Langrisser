using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001294 RID: 4756
[Preserve]
public class Lua_BlackJack_ProjectL_Common_UnusableBagItem : LuaObject
{
	// Token: 0x06018C95 RID: 101525 RVA: 0x007048D0 File Offset: 0x00702AD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GoodsType goodsTypeId;
			LuaObject.checkEnum<GoodsType>(l, 2, out goodsTypeId);
			int contentId;
			LuaObject.checkType(l, 3, out contentId);
			int nums;
			LuaObject.checkType(l, 4, out nums);
			ulong instanceId;
			LuaObject.checkType(l, 5, out instanceId);
			UnusableBagItem o = new UnusableBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x06018C96 RID: 101526 RVA: 0x0070494C File Offset: 0x00702B4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.UnusableBagItem");
		if (Lua_BlackJack_ProjectL_Common_UnusableBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_UnusableBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_UnusableBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_UnusableBagItem.<>f__mg$cache0, typeof(UnusableBagItem), typeof(BagItemBase));
	}

	// Token: 0x0400F14F RID: 61775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
