using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001864 RID: 6244
[Preserve]
public class Lua_UnityEngine_UI_Toggle : LuaObject
{
	// Token: 0x060242E5 RID: 148197 RVA: 0x00CB5A9C File Offset: 0x00CB3C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			CanvasUpdate executing;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out executing);
			toggle.Rebuild(executing);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E6 RID: 148198 RVA: 0x00CB5AF4 File Offset: 0x00CB3CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			toggle.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E7 RID: 148199 RVA: 0x00CB5B40 File Offset: 0x00CB3D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			toggle.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E8 RID: 148200 RVA: 0x00CB5B8C File Offset: 0x00CB3D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerClick(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			toggle.OnPointerClick(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242E9 RID: 148201 RVA: 0x00CB5BE4 File Offset: 0x00CB3DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubmit(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			toggle.OnSubmit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242EA RID: 148202 RVA: 0x00CB5C3C File Offset: 0x00CB3E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_toggleTransition(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)toggle.toggleTransition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242EB RID: 148203 RVA: 0x00CB5C90 File Offset: 0x00CB3E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_toggleTransition(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			Toggle.ToggleTransition toggleTransition;
			LuaObject.checkEnum<Toggle.ToggleTransition>(l, 2, out toggleTransition);
			toggle.toggleTransition = toggleTransition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242EC RID: 148204 RVA: 0x00CB5CE8 File Offset: 0x00CB3EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphic(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, toggle.graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242ED RID: 148205 RVA: 0x00CB5D3C File Offset: 0x00CB3F3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_graphic(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			Graphic graphic;
			LuaObject.checkType<Graphic>(l, 2, out graphic);
			toggle.graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242EE RID: 148206 RVA: 0x00CB5D94 File Offset: 0x00CB3F94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, toggle.onValueChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242EF RID: 148207 RVA: 0x00CB5DE8 File Offset: 0x00CB3FE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onValueChanged(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			Toggle.ToggleEvent onValueChanged;
			LuaObject.checkType<Toggle.ToggleEvent>(l, 2, out onValueChanged);
			toggle.onValueChanged = onValueChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242F0 RID: 148208 RVA: 0x00CB5E40 File Offset: 0x00CB4040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_group(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, toggle.group);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242F1 RID: 148209 RVA: 0x00CB5E94 File Offset: 0x00CB4094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_group(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			ToggleGroup group;
			LuaObject.checkType<ToggleGroup>(l, 2, out group);
			toggle.group = group;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242F2 RID: 148210 RVA: 0x00CB5EEC File Offset: 0x00CB40EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isOn(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, toggle.isOn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242F3 RID: 148211 RVA: 0x00CB5F40 File Offset: 0x00CB4140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isOn(IntPtr l)
	{
		int result;
		try
		{
			Toggle toggle = (Toggle)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			toggle.isOn = isOn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060242F4 RID: 148212 RVA: 0x00CB5F98 File Offset: 0x00CB4198
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Toggle");
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Toggle.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Toggle.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Toggle.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.OnPointerClick);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Toggle.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.OnSubmit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Toggle.<>f__mg$cache4);
		string name = "toggleTransition";
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.get_toggleTransition);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Toggle.<>f__mg$cache5;
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.set_toggleTransition);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Toggle.<>f__mg$cache6, true);
		string name2 = "graphic";
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.get_graphic);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Toggle.<>f__mg$cache7;
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.set_graphic);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Toggle.<>f__mg$cache8, true);
		string name3 = "onValueChanged";
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.get_onValueChanged);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Toggle.<>f__mg$cache9;
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.set_onValueChanged);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Toggle.<>f__mg$cacheA, true);
		string name4 = "group";
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.get_group);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Toggle.<>f__mg$cacheB;
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.set_group);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_Toggle.<>f__mg$cacheC, true);
		string name5 = "isOn";
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.get_isOn);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Toggle.<>f__mg$cacheD;
		if (Lua_UnityEngine_UI_Toggle.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_Toggle.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_Toggle.set_isOn);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_Toggle.<>f__mg$cacheE, true);
		LuaObject.createTypeMetatable(l, null, typeof(Toggle), typeof(Selectable));
	}

	// Token: 0x04019E7B RID: 106107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019E7C RID: 106108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019E7D RID: 106109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019E7E RID: 106110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019E7F RID: 106111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019E80 RID: 106112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019E81 RID: 106113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019E82 RID: 106114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019E83 RID: 106115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019E84 RID: 106116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019E85 RID: 106117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019E86 RID: 106118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019E87 RID: 106119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019E88 RID: 106120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019E89 RID: 106121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
