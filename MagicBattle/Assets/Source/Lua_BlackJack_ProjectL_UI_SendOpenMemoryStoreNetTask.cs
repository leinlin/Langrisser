using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001573 RID: 5491
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SendOpenMemoryStoreNetTask : LuaObject
{
	// Token: 0x06021005 RID: 135173 RVA: 0x00B16690 File Offset: 0x00B14890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SendOpenMemoryStoreNetTask o = new SendOpenMemoryStoreNetTask();
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

	// Token: 0x06021006 RID: 135174 RVA: 0x00B166D8 File Offset: 0x00B148D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SendOpenMemoryStoreNetTask");
		if (Lua_BlackJack_ProjectL_UI_SendOpenMemoryStoreNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SendOpenMemoryStoreNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SendOpenMemoryStoreNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_SendOpenMemoryStoreNetTask.<>f__mg$cache0, typeof(SendOpenMemoryStoreNetTask), typeof(UINetTask));
	}

	// Token: 0x04016F01 RID: 93953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
