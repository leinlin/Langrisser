using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200181F RID: 6175
[Preserve]
public class Lua_UnityEngine_UI_Dropdown_OptionDataList : LuaObject
{
	// Token: 0x06024029 RID: 147497 RVA: 0x00CA3D58 File Offset: 0x00CA1F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionDataList o = new Dropdown.OptionDataList();
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

	// Token: 0x0602402A RID: 147498 RVA: 0x00CA3DA0 File Offset: 0x00CA1FA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_options(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionDataList optionDataList = (Dropdown.OptionDataList)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, optionDataList.options);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602402B RID: 147499 RVA: 0x00CA3DF4 File Offset: 0x00CA1FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_options(IntPtr l)
	{
		int result;
		try
		{
			Dropdown.OptionDataList optionDataList = (Dropdown.OptionDataList)LuaObject.checkSelf(l);
			List<Dropdown.OptionData> options;
			LuaObject.checkType<List<Dropdown.OptionData>>(l, 2, out options);
			optionDataList.options = options;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602402C RID: 147500 RVA: 0x00CA3E4C File Offset: 0x00CA204C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Dropdown.OptionDataList");
		string name = "options";
		if (Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionDataList.get_options);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionDataList.set_options);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache1, true);
		if (Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Dropdown_OptionDataList.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Dropdown_OptionDataList.<>f__mg$cache2, typeof(Dropdown.OptionDataList));
	}

	// Token: 0x04019C49 RID: 105545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C4A RID: 105546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C4B RID: 105547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
