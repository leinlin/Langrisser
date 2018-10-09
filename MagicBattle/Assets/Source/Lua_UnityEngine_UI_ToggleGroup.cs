using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001867 RID: 6247
[Preserve]
public class Lua_UnityEngine_UI_ToggleGroup : LuaObject
{
	// Token: 0x060242FB RID: 148219 RVA: 0x00CB62BC File Offset: 0x00CB44BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NotifyToggleOn(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			toggleGroup.NotifyToggleOn(toggle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242FC RID: 148220 RVA: 0x00CB6314 File Offset: 0x00CB4514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UnregisterToggle(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			toggleGroup.UnregisterToggle(toggle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242FD RID: 148221 RVA: 0x00CB636C File Offset: 0x00CB456C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterToggle(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			toggleGroup.RegisterToggle(toggle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242FE RID: 148222 RVA: 0x00CB63C4 File Offset: 0x00CB45C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AnyTogglesOn(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			bool b = toggleGroup.AnyTogglesOn();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242FF RID: 148223 RVA: 0x00CB6418 File Offset: 0x00CB4618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ActiveToggles(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			IEnumerable<Toggle> o = toggleGroup.ActiveToggles();
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

	// Token: 0x06024300 RID: 148224 RVA: 0x00CB646C File Offset: 0x00CB466C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAllTogglesOff(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			toggleGroup.SetAllTogglesOff();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024301 RID: 148225 RVA: 0x00CB64B8 File Offset: 0x00CB46B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_allowSwitchOff(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, toggleGroup.allowSwitchOff);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024302 RID: 148226 RVA: 0x00CB650C File Offset: 0x00CB470C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_allowSwitchOff(IntPtr l)
	{
		int result;
		try
		{
			ToggleGroup toggleGroup = (ToggleGroup)LuaObject.checkSelf(l);
			bool allowSwitchOff;
			LuaObject.checkType(l, 2, out allowSwitchOff);
			toggleGroup.allowSwitchOff = allowSwitchOff;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024303 RID: 148227 RVA: 0x00CB6564 File Offset: 0x00CB4764
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ToggleGroup");
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.NotifyToggleOn);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.UnregisterToggle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.RegisterToggle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.AnyTogglesOn);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.ActiveToggles);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.SetAllTogglesOff);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache5);
		string name = "allowSwitchOff";
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.get_allowSwitchOff);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_ToggleGroup.set_allowSwitchOff);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_ToggleGroup.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(ToggleGroup), typeof(UIBehaviour));
	}

	// Token: 0x04019E8B RID: 106123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E8C RID: 106124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E8D RID: 106125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E8E RID: 106126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E8F RID: 106127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E90 RID: 106128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E91 RID: 106129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019E92 RID: 106130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
