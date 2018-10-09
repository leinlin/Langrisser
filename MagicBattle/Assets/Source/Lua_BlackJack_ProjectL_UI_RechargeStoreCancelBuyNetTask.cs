using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001555 RID: 5461
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RechargeStoreCancelBuyNetTask : LuaObject
{
	// Token: 0x06020A6E RID: 133742 RVA: 0x00AE9A90 File Offset: 0x00AE7C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int storeItemGoodsID;
			LuaObject.checkType(l, 2, out storeItemGoodsID);
			RechargeStoreCancelBuyNetTask o = new RechargeStoreCancelBuyNetTask(storeItemGoodsID);
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

	// Token: 0x06020A6F RID: 133743 RVA: 0x00AE9AE4 File Offset: 0x00AE7CE4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RechargeStoreCancelBuyNetTask");
		if (Lua_BlackJack_ProjectL_UI_RechargeStoreCancelBuyNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RechargeStoreCancelBuyNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RechargeStoreCancelBuyNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RechargeStoreCancelBuyNetTask.<>f__mg$cache0, typeof(RechargeStoreCancelBuyNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A6 RID: 92582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
