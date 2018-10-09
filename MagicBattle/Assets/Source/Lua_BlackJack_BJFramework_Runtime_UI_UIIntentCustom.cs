using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001129 RID: 4393
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom : LuaObject
{
	// Token: 0x06015DE6 RID: 89574 RVA: 0x005A8CC4 File Offset: 0x005A6EC4
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
			UIIntentCustom o = new UIIntentCustom(targetTaskName, targetMode);
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

	// Token: 0x06015DE7 RID: 89575 RVA: 0x005A8D24 File Offset: 0x005A6F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetParam(IntPtr l)
	{
		int result;
		try
		{
			UIIntentCustom uiintentCustom = (UIIntentCustom)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			object value;
			LuaObject.checkType<object>(l, 3, out value);
			uiintentCustom.SetParam(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DE8 RID: 89576 RVA: 0x005A8D88 File Offset: 0x005A6F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TryGetParam(IntPtr l)
	{
		int result;
		try
		{
			UIIntentCustom uiintentCustom = (UIIntentCustom)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			object o;
			bool b = uiintentCustom.TryGetParam(key, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DE9 RID: 89577 RVA: 0x005A8DF8 File Offset: 0x005A6FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_params(IntPtr l)
	{
		int result;
		try
		{
			UIIntentCustom uiintentCustom = (UIIntentCustom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uiintentCustom.m_luaExportHelper.m_params);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DEA RID: 89578 RVA: 0x005A8E50 File Offset: 0x005A7050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_params(IntPtr l)
	{
		int result;
		try
		{
			UIIntentCustom uiintentCustom = (UIIntentCustom)LuaObject.checkSelf(l);
			Dictionary<string, object> @params;
			LuaObject.checkType<Dictionary<string, object>>(l, 2, out @params);
			uiintentCustom.m_luaExportHelper.m_params = @params;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DEB RID: 89579 RVA: 0x005A8EAC File Offset: 0x005A70AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UIIntentCustom");
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.SetParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.TryGetParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache1);
		string name = "m_params";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.get_m_params);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.set_m_params);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache3, true);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentCustom.<>f__mg$cache4, typeof(UIIntentCustom), typeof(UIIntent));
	}

	// Token: 0x0400C576 RID: 50550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C577 RID: 50551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C578 RID: 50552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C579 RID: 50553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C57A RID: 50554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
