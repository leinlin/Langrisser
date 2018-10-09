using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001128 RID: 4392
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UIIntent : LuaObject
{
	// Token: 0x06015DDF RID: 89567 RVA: 0x005A8A2C File Offset: 0x005A6C2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			string targetTaskName;
			LuaObject.checkType(l, 2, out targetTaskName);
			string targetMode;
			LuaObject.checkType(l, 3, out targetMode);
			UIIntent o = new UIIntent(targetTaskName, targetMode);
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

	// Token: 0x06015DE0 RID: 89568 RVA: 0x005A8A8C File Offset: 0x005A6C8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TargetTaskName(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiintent = (UIIntent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uiintent.TargetTaskName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DE1 RID: 89569 RVA: 0x005A8AE0 File Offset: 0x005A6CE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetTaskName(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiintent = (UIIntent)LuaObject.checkSelf(l);
			string targetTaskName;
			LuaObject.checkType(l, 2, out targetTaskName);
			uiintent.m_luaExportHelper.TargetTaskName = targetTaskName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DE2 RID: 89570 RVA: 0x005A8B3C File Offset: 0x005A6D3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TargetMode(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiintent = (UIIntent)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uiintent.TargetMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DE3 RID: 89571 RVA: 0x005A8B90 File Offset: 0x005A6D90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetMode(IntPtr l)
	{
		int result;
		try
		{
			UIIntent uiintent = (UIIntent)LuaObject.checkSelf(l);
			string targetMode;
			LuaObject.checkType(l, 2, out targetMode);
			uiintent.TargetMode = targetMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DE4 RID: 89572 RVA: 0x005A8BE8 File Offset: 0x005A6DE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UIIntent");
		string name = "TargetTaskName";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.get_TargetTaskName);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache0;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.set_TargetTaskName);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache1, true);
		string name2 = "TargetMode";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.get_TargetMode);
		}
		LuaCSFunction get2 = Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.set_TargetMode);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache3, true);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntent.<>f__mg$cache4, typeof(UIIntent));
	}

	// Token: 0x0400C571 RID: 50545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C572 RID: 50546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C573 RID: 50547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C574 RID: 50548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C575 RID: 50549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
