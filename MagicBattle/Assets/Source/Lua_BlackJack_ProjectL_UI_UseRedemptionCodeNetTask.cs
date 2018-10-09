using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015D1 RID: 5585
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask : LuaObject
{
	// Token: 0x060220AE RID: 139438 RVA: 0x00B9B120 File Offset: 0x00B99320
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string key;
			LuaObject.checkType(l, 2, out key);
			UseRedemptionCodeNetTask o = new UseRedemptionCodeNetTask(key);
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

	// Token: 0x060220AF RID: 139439 RVA: 0x00B9B174 File Offset: 0x00B99374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ResultDetail(IntPtr l)
	{
		int result;
		try
		{
			UseRedemptionCodeNetTask useRedemptionCodeNetTask = (UseRedemptionCodeNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, useRedemptionCodeNetTask.ResultDetail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060220B0 RID: 139440 RVA: 0x00B9B1C8 File Offset: 0x00B993C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UseRedemptionCodeNetTask");
		string name = "ResultDetail";
		if (Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.get_ResultDetail);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_UseRedemptionCodeNetTask.<>f__mg$cache1, typeof(UseRedemptionCodeNetTask), typeof(UINetTask));
	}

	// Token: 0x04017EEE RID: 98030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017EEF RID: 98031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
