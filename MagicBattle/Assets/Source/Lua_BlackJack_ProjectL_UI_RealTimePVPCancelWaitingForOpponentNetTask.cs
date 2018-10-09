using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001550 RID: 5456
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RealTimePVPCancelWaitingForOpponentNetTask : LuaObject
{
	// Token: 0x06020A5E RID: 133726 RVA: 0x00AE96C0 File Offset: 0x00AE78C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPCancelWaitingForOpponentNetTask o = new RealTimePVPCancelWaitingForOpponentNetTask();
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

	// Token: 0x06020A5F RID: 133727 RVA: 0x00AE9708 File Offset: 0x00AE7908
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RealTimePVPCancelWaitingForOpponentNetTask");
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPCancelWaitingForOpponentNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPCancelWaitingForOpponentNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPCancelWaitingForOpponentNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RealTimePVPCancelWaitingForOpponentNetTask.<>f__mg$cache0, typeof(RealTimePVPCancelWaitingForOpponentNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A0 RID: 92576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
