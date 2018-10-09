using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001467 RID: 5223
[Preserve]
public class Lua_BlackJack_ProjectL_UI_GmCommandNetTask : LuaObject
{
	// Token: 0x0601E274 RID: 123508 RVA: 0x009ABF54 File Offset: 0x009AA154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string cmd;
			LuaObject.checkType(l, 2, out cmd);
			GmCommandNetTask o = new GmCommandNetTask(cmd);
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

	// Token: 0x0601E275 RID: 123509 RVA: 0x009ABFA8 File Offset: 0x009AA1A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.GmCommandNetTask");
		if (Lua_BlackJack_ProjectL_UI_GmCommandNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_GmCommandNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_GmCommandNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_GmCommandNetTask.<>f__mg$cache0, typeof(GmCommandNetTask), typeof(UINetTask));
	}

	// Token: 0x04014388 RID: 82824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
