using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200136B RID: 4971
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaBattleReportBasicDataGetNetTask : LuaObject
{
	// Token: 0x0601AD43 RID: 109891 RVA: 0x008049B8 File Offset: 0x00802BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReportBasicDataGetNetTask o = new ArenaBattleReportBasicDataGetNetTask();
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

	// Token: 0x0601AD44 RID: 109892 RVA: 0x00804A00 File Offset: 0x00802C00
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaBattleReportBasicDataGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaBattleReportBasicDataGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaBattleReportBasicDataGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaBattleReportBasicDataGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaBattleReportBasicDataGetNetTask.<>f__mg$cache0, typeof(ArenaBattleReportBasicDataGetNetTask), typeof(UINetTask));
	}

	// Token: 0x0401104F RID: 69711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
