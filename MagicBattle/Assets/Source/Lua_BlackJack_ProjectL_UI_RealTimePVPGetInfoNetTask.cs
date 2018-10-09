using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001551 RID: 5457
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RealTimePVPGetInfoNetTask : LuaObject
{
	// Token: 0x06020A61 RID: 133729 RVA: 0x00AE9760 File Offset: 0x00AE7960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPGetInfoNetTask o = new RealTimePVPGetInfoNetTask();
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

	// Token: 0x06020A62 RID: 133730 RVA: 0x00AE97A8 File Offset: 0x00AE79A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RealTimePVPGetInfoNetTask");
		if (Lua_BlackJack_ProjectL_UI_RealTimePVPGetInfoNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RealTimePVPGetInfoNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RealTimePVPGetInfoNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RealTimePVPGetInfoNetTask.<>f__mg$cache0, typeof(RealTimePVPGetInfoNetTask), typeof(UINetTask));
	}

	// Token: 0x040169A1 RID: 92577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
