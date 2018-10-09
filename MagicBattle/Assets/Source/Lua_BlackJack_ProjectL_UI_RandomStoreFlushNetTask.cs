using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001548 RID: 5448
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RandomStoreFlushNetTask : LuaObject
{
	// Token: 0x0602094C RID: 133452 RVA: 0x00AE0F24 File Offset: 0x00ADF124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int randomStoreID;
			LuaObject.checkType(l, 2, out randomStoreID);
			RandomStoreFlushNetTask o = new RandomStoreFlushNetTask(randomStoreID);
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

	// Token: 0x0602094D RID: 133453 RVA: 0x00AE0F78 File Offset: 0x00ADF178
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RandomStoreFlushNetTask");
		if (Lua_BlackJack_ProjectL_UI_RandomStoreFlushNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RandomStoreFlushNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RandomStoreFlushNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_RandomStoreFlushNetTask.<>f__mg$cache0, typeof(RandomStoreFlushNetTask), typeof(UINetTask));
	}

	// Token: 0x0401689E RID: 92318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
