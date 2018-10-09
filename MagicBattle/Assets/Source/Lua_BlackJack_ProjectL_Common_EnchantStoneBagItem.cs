using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200121A RID: 4634
[Preserve]
public class Lua_BlackJack_ProjectL_Common_EnchantStoneBagItem : LuaObject
{
	// Token: 0x060180AB RID: 98475 RVA: 0x006AB844 File Offset: 0x006A9A44
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
			EnchantStoneBagItem o = new EnchantStoneBagItem(goodsTypeId, contentId, nums, instanceId);
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

	// Token: 0x060180AC RID: 98476 RVA: 0x006AB8C0 File Offset: 0x006A9AC0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.EnchantStoneBagItem");
		if (Lua_BlackJack_ProjectL_Common_EnchantStoneBagItem.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_EnchantStoneBagItem.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_EnchantStoneBagItem.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_EnchantStoneBagItem.<>f__mg$cache0, typeof(EnchantStoneBagItem), typeof(BagItemBase));
	}

	// Token: 0x0400E659 RID: 58969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
