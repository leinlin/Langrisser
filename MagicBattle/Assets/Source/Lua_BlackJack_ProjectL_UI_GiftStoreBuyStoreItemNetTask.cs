using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001465 RID: 5221
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask : LuaObject
{
	// Token: 0x0601E26D RID: 123501 RVA: 0x009ABD7C File Offset: 0x009A9F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int giftStoreItemGoodsID;
			LuaObject.checkType(l, 2, out giftStoreItemGoodsID);
			GiftStoreBuyStoreItemNetTask o = new GiftStoreBuyStoreItemNetTask(giftStoreItemGoodsID);
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

	// Token: 0x0601E26E RID: 123502 RVA: 0x009ABDD0 File Offset: 0x009A9FD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoodsId(IntPtr l)
	{
		int result;
		try
		{
			GiftStoreBuyStoreItemNetTask giftStoreBuyStoreItemNetTask = (GiftStoreBuyStoreItemNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, giftStoreBuyStoreItemNetTask.GoodsId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E26F RID: 123503 RVA: 0x009ABE24 File Offset: 0x009AA024
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GiftStoreBuyStoreItemNetTask");
		string name = "GoodsId";
		if (Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.get_GoodsId);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GiftStoreBuyStoreItemNetTask.<>f__mg$cache1, typeof(GiftStoreBuyStoreItemNetTask), typeof(UINetTask));
	}

	// Token: 0x04014385 RID: 82821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014386 RID: 82822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
