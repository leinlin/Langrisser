using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001554 RID: 5460
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RechargeStoreBuyStoreItemNetTask : LuaObject
{
	// Token: 0x06020A6B RID: 133739 RVA: 0x00AE99E4 File Offset: 0x00AE7BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int storeItemGoodsID;
			LuaObject.checkType(l, 2, out storeItemGoodsID);
			RechargeStoreBuyStoreItemNetTask o = new RechargeStoreBuyStoreItemNetTask(storeItemGoodsID);
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

	// Token: 0x06020A6C RID: 133740 RVA: 0x00AE9A38 File Offset: 0x00AE7C38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RechargeStoreBuyStoreItemNetTask");
		if (Lua_BlackJack_ProjectL_UI_RechargeStoreBuyStoreItemNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RechargeStoreBuyStoreItemNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RechargeStoreBuyStoreItemNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RechargeStoreBuyStoreItemNetTask.<>f__mg$cache0, typeof(RechargeStoreBuyStoreItemNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A5 RID: 92581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
