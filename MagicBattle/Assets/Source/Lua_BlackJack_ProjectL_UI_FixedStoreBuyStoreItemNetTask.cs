using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001443 RID: 5187
[Preserve]
public class Lua_BlackJack_ProjectL_UI_FixedStoreBuyStoreItemNetTask : LuaObject
{
	// Token: 0x0601DE6D RID: 122477 RVA: 0x0098C88C File Offset: 0x0098AA8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int fixedStoreID;
			LuaObject.checkType(l, 2, out fixedStoreID);
			int fixedStoreItemGoodsID;
			LuaObject.checkType(l, 3, out fixedStoreItemGoodsID);
			int selfChoooseItemIndex;
			LuaObject.checkType(l, 4, out selfChoooseItemIndex);
			FixedStoreBuyStoreItemNetTask o = new FixedStoreBuyStoreItemNetTask(fixedStoreID, fixedStoreItemGoodsID, selfChoooseItemIndex);
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

	// Token: 0x0601DE6E RID: 122478 RVA: 0x0098C8FC File Offset: 0x0098AAFC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.FixedStoreBuyStoreItemNetTask");
		if (Lua_BlackJack_ProjectL_UI_FixedStoreBuyStoreItemNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_FixedStoreBuyStoreItemNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_FixedStoreBuyStoreItemNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_FixedStoreBuyStoreItemNetTask.<>f__mg$cache0, typeof(FixedStoreBuyStoreItemNetTask), typeof(UINetTask));
	}

	// Token: 0x04013FC9 RID: 81865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
