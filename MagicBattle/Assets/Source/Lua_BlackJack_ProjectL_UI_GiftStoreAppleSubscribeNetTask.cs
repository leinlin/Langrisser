using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001464 RID: 5220
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask : LuaObject
{
	// Token: 0x0601E269 RID: 123497 RVA: 0x009ABC50 File Offset: 0x009A9E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int giftStoreItemGoodsID;
			LuaObject.checkType(l, 2, out giftStoreItemGoodsID);
			GiftStoreAppleSubscribeNetTask o = new GiftStoreAppleSubscribeNetTask(giftStoreItemGoodsID);
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

	// Token: 0x0601E26A RID: 123498 RVA: 0x009ABCA4 File Offset: 0x009A9EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreAppleSubscribeNetTask giftStoreAppleSubscribeNetTask = (GiftStoreAppleSubscribeNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreAppleSubscribeNetTask.GoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E26B RID: 123499 RVA: 0x009ABCF8 File Offset: 0x009A9EF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GiftStoreAppleSubscribeNetTask");
		string name = "GoodsId";
		if (Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.get_GoodsId);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GiftStoreAppleSubscribeNetTask.<>f__mg$cache1, typeof(GiftStoreAppleSubscribeNetTask), typeof(UINetTask));
	}

	// Token: 0x04014383 RID: 82819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014384 RID: 82820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
