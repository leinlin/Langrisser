using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200180D RID: 6157
[Preserve]
public class Lua_UnityEngine_UI_Button : LuaObject
{
	// Token: 0x06023F91 RID: 147345 RVA: 0x00CA00BC File Offset: 0x00C9E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			Button button = (Button)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			button.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F92 RID: 147346 RVA: 0x00CA0114 File Offset: 0x00C9E314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubmit(IntPtr l)
	{
		int result;
		try
		{
			Button button = (Button)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			button.OnSubmit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F93 RID: 147347 RVA: 0x00CA016C File Offset: 0x00C9E36C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onClick(IntPtr l)
	{
		int result;
		try
		{
			Button button = (Button)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, button.onClick);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F94 RID: 147348 RVA: 0x00CA01C0 File Offset: 0x00C9E3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onClick(IntPtr l)
	{
		int result;
		try
		{
			Button button = (Button)LuaObject.checkSelf(l);
			Button.ButtonClickedEvent onClick;
			LuaObject.checkType<Button.ButtonClickedEvent>(l, 2, out onClick);
			button.onClick = onClick;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F95 RID: 147349 RVA: 0x00CA0218 File Offset: 0x00C9E418
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Button");
		if (Lua_UnityEngine_UI_Button.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Button.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Button.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Button.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Button.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Button.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Button.OnSubmit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Button.<>f__mg$cache1);
		string name = "onClick";
		if (Lua_UnityEngine_UI_Button.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Button.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Button.get_onClick);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Button.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_Button.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Button.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Button.set_onClick);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Button.<>f__mg$cache3, true);
		LuaObject.createTypeMetatable(l, null, typeof(Button), typeof(Selectable));
	}

	// Token: 0x04019BD5 RID: 105429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BD6 RID: 105430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BD7 RID: 105431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BD8 RID: 105432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
