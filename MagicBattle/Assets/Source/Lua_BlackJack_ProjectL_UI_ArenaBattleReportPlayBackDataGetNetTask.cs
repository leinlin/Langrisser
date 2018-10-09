using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200136C RID: 4972
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaBattleReportPlayBackDataGetNetTask : LuaObject
{
	// Token: 0x0601AD46 RID: 109894 RVA: 0x00804A58 File Offset: 0x00802C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ulong arenaBattleReportInstanceId;
			LuaObject.checkType(l, 2, out arenaBattleReportInstanceId);
			ArenaBattleReportPlayBackDataGetNetTask o = new ArenaBattleReportPlayBackDataGetNetTask(arenaBattleReportInstanceId);
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

	// Token: 0x0601AD47 RID: 109895 RVA: 0x00804AAC File Offset: 0x00802CAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaBattleReportPlayBackDataGetNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaBattleReportPlayBackDataGetNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaBattleReportPlayBackDataGetNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaBattleReportPlayBackDataGetNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaBattleReportPlayBackDataGetNetTask.<>f__mg$cache0, typeof(ArenaBattleReportPlayBackDataGetNetTask), typeof(UINetTask));
	}

	// Token: 0x04011050 RID: 69712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
