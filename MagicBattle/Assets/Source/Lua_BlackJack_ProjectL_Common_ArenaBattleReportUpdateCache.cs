using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B9 RID: 4537
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaBattleReportUpdateCache : LuaObject
{
	// Token: 0x06017809 RID: 96265 RVA: 0x0066CCD4 File Offset: 0x0066AED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaBattleReportUpdateCache o = new ArenaBattleReportUpdateCache();
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

	// Token: 0x0601780A RID: 96266 RVA: 0x0066CD1C File Offset: 0x0066AF1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaBattleReportUpdateCache");
		if (Lua_BlackJack_ProjectL_Common_ArenaBattleReportUpdateCache.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaBattleReportUpdateCache.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaBattleReportUpdateCache.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaBattleReportUpdateCache.<>f__mg$cache0, typeof(ArenaBattleReportUpdateCache), typeof(UpdateCacheList<ArenaBattleReport>));
	}

	// Token: 0x0400DE79 RID: 56953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
