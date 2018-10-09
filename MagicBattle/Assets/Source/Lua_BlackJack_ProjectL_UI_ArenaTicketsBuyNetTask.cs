using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001383 RID: 4995
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ArenaTicketsBuyNetTask : LuaObject
{
	// Token: 0x0601B0A1 RID: 110753 RVA: 0x0081FA2C File Offset: 0x0081DC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaTicketsBuyNetTask o = new ArenaTicketsBuyNetTask();
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

	// Token: 0x0601B0A2 RID: 110754 RVA: 0x0081FA74 File Offset: 0x0081DC74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ArenaTicketsBuyNetTask");
		if (Lua_BlackJack_ProjectL_UI_ArenaTicketsBuyNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ArenaTicketsBuyNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ArenaTicketsBuyNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_ArenaTicketsBuyNetTask.<>f__mg$cache0, typeof(ArenaTicketsBuyNetTask), typeof(UINetTask));
	}

	// Token: 0x0401137D RID: 70525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
