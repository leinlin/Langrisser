using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001552 RID: 5458
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RealTimePVPGetTopPlayersNetTask : LuaObject
{
	// Token: 0x06020A64 RID: 133732 RVA: 0x00AE9800 File Offset: 0x00AE7A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int topN;
			LuaObject.checkType(l, 2, out topN);
			bool isGlobal;
			LuaObject.checkType(l, 3, out isGlobal);
			RealTimePVPGetTopPlayersNetTask o = new RealTimePVPGetTopPlayersNetTask(topN, isGlobal);
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

	// Token: 0x06020A65 RID: 133733 RVA: 0x00AE9860 File Offset: 0x00AE7A60
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RealTimePVPGetTopPlayersNetTask");
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPGetTopPlayersNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPGetTopPlayersNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPGetTopPlayersNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RealTimePVPGetTopPlayersNetTask.<>f__mg$cache0, typeof(RealTimePVPGetTopPlayersNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A2 RID: 92578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
