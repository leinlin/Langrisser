using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200112A RID: 4394
[Preserve]
public class Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable : LuaObject
{
	// Token: 0x06015DED RID: 89581 RVA: 0x005A8F90 File Offset: 0x005A7190
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			UIIntent prevTaskIntent;
			LuaObject.checkType<UIIntent>(l, 2, out prevTaskIntent);
			string targetTaskName;
			LuaObject.checkType(l, 3, out targetTaskName);
			string targetMode;
			LuaObject.checkType(l, 4, out targetMode);
			UIIntentReturnable o = new UIIntentReturnable(prevTaskIntent, targetTaskName, targetMode);
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

	// Token: 0x06015DEE RID: 89582 RVA: 0x005A9000 File Offset: 0x005A7200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetParam(IntPtr l)
	{
		int result;
		try
		{
			UIIntentReturnable uiintentReturnable = (UIIntentReturnable)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			object value;
			LuaObject.checkType<object>(l, 3, out value);
			uiintentReturnable.m_luaExportHelper.__callBase_SetParam(key, value);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DEF RID: 89583 RVA: 0x005A906C File Offset: 0x005A726C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_TryGetParam(IntPtr l)
	{
		int result;
		try
		{
			UIIntentReturnable uiintentReturnable = (UIIntentReturnable)LuaObject.checkSelf(l);
			string key;
			LuaObject.checkType(l, 2, out key);
			object o;
			bool b = uiintentReturnable.m_luaExportHelper.__callBase_TryGetParam(key, out o);
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

	// Token: 0x06015DF0 RID: 89584 RVA: 0x005A90E0 File Offset: 0x005A72E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PrevTaskIntent(IntPtr l)
	{
		int result;
		try
		{
			UIIntentReturnable uiintentReturnable = (UIIntentReturnable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, uiintentReturnable.PrevTaskIntent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DF1 RID: 89585 RVA: 0x005A9134 File Offset: 0x005A7334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PrevTaskIntent(IntPtr l)
	{
		int result;
		try
		{
			UIIntentReturnable uiintentReturnable = (UIIntentReturnable)LuaObject.checkSelf(l);
			UIIntent prevTaskIntent;
			LuaObject.checkType<UIIntent>(l, 2, out prevTaskIntent);
			uiintentReturnable.PrevTaskIntent = prevTaskIntent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06015DF2 RID: 89586 RVA: 0x005A918C File Offset: 0x005A738C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.BJFramework.Runtime.UI.UIIntentReturnable");
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.__callBase_SetParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache0);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.__callBase_TryGetParam);
		}
		LuaObject.addMember(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache1);
		string name = "PrevTaskIntent";
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.get_PrevTaskIntent);
		}
		LuaCSFunction get = Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache2;
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.set_PrevTaskIntent);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache3, true);
		if (Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_BJFramework_Runtime_UI_UIIntentReturnable.<>f__mg$cache4, typeof(UIIntentReturnable), typeof(UIIntentCustom));
	}

	// Token: 0x0400C57B RID: 50555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400C57C RID: 50556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400C57D RID: 50557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400C57E RID: 50558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400C57F RID: 50559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
