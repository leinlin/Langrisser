using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200136A RID: 4970
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaBattleReconnectNetTask : LuaObject
{
	// Token: 0x0601AD40 RID: 109888 RVA: 0x00804918 File Offset: 0x00802B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReconnectNetTask o = new ArenaBattleReconnectNetTask();
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

	// Token: 0x0601AD41 RID: 109889 RVA: 0x00804960 File Offset: 0x00802B60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaBattleReconnectNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaBattleReconnectNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaBattleReconnectNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaBattleReconnectNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaBattleReconnectNetTask.<>f__mg$cache0, typeof(ArenaBattleReconnectNetTask), typeof(UINetTask));
	}

	// Token: 0x0401104E RID: 69710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
