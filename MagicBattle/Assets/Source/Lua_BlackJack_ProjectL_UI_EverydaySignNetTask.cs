using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001432 RID: 5170
[Preserve]
public class Lua_BlackJack_ProjectL_UI_EverydaySignNetTask : LuaObject
{
	// Token: 0x0601DA7B RID: 121467 RVA: 0x0096CAB4 File Offset: 0x0096ACB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			EverydaySignNetTask o = new EverydaySignNetTask();
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

	// Token: 0x0601DA7C RID: 121468 RVA: 0x0096CAFC File Offset: 0x0096ACFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			EverydaySignNetTask everydaySignNetTask = (EverydaySignNetTask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, everydaySignNetTask.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601DA7D RID: 121469 RVA: 0x0096CB50 File Offset: 0x0096AD50
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.EverydaySignNetTask");
		string name = "Rewards";
		if (Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.get_Rewards);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.<>f__mg$cache0, null, true);
		if (Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_EverydaySignNetTask.<>f__mg$cache1, typeof(EverydaySignNetTask), typeof(UINetTask));
	}

	// Token: 0x04013BF9 RID: 80889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04013BFA RID: 80890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;
}
