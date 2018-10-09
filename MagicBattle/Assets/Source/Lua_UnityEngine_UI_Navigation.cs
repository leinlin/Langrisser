using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200184E RID: 6222
[Preserve]
public class Lua_UnityEngine_UI_Navigation : LuaObject
{
	// Token: 0x060241CC RID: 147916 RVA: 0x00CAE3D8 File Offset: 0x00CAC5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation = default(Navigation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, navigation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241CD RID: 147917 RVA: 0x00CAE428 File Offset: 0x00CAC628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_mode(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)navigation.mode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241CE RID: 147918 RVA: 0x00CAE47C File Offset: 0x00CAC67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mode(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			Navigation.Mode mode;
			LuaObject.checkEnum<Navigation.Mode>(l, 2, out mode);
			navigation.mode = mode;
			LuaObject.setBack(l, navigation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241CF RID: 147919 RVA: 0x00CAE4E0 File Offset: 0x00CAC6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectOnUp(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, navigation.selectOnUp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D0 RID: 147920 RVA: 0x00CAE534 File Offset: 0x00CAC734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectOnUp(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			Selectable selectOnUp;
			LuaObject.checkType<Selectable>(l, 2, out selectOnUp);
			navigation.selectOnUp = selectOnUp;
			LuaObject.setBack(l, navigation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D1 RID: 147921 RVA: 0x00CAE598 File Offset: 0x00CAC798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectOnDown(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, navigation.selectOnDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D2 RID: 147922 RVA: 0x00CAE5EC File Offset: 0x00CAC7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectOnDown(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			Selectable selectOnDown;
			LuaObject.checkType<Selectable>(l, 2, out selectOnDown);
			navigation.selectOnDown = selectOnDown;
			LuaObject.setBack(l, navigation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D3 RID: 147923 RVA: 0x00CAE650 File Offset: 0x00CAC850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectOnLeft(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, navigation.selectOnLeft);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D4 RID: 147924 RVA: 0x00CAE6A4 File Offset: 0x00CAC8A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_selectOnLeft(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			Selectable selectOnLeft;
			LuaObject.checkType<Selectable>(l, 2, out selectOnLeft);
			navigation.selectOnLeft = selectOnLeft;
			LuaObject.setBack(l, navigation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D5 RID: 147925 RVA: 0x00CAE708 File Offset: 0x00CAC908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_selectOnRight(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, navigation.selectOnRight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D6 RID: 147926 RVA: 0x00CAE75C File Offset: 0x00CAC95C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_selectOnRight(IntPtr l)
	{
		int result;
		try
		{
			Navigation navigation;
			LuaObject.checkValueType<Navigation>(l, 1, out navigation);
			Selectable selectOnRight;
			LuaObject.checkType<Selectable>(l, 2, out selectOnRight);
			navigation.selectOnRight = selectOnRight;
			LuaObject.setBack(l, navigation);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D7 RID: 147927 RVA: 0x00CAE7C0 File Offset: 0x00CAC9C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_defaultNavigation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Navigation.defaultNavigation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241D8 RID: 147928 RVA: 0x00CAE80C File Offset: 0x00CACA0C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Navigation");
		string name = "mode";
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.get_mode);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Navigation.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.set_mode);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_Navigation.<>f__mg$cache1, true);
		string name2 = "selectOnUp";
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.get_selectOnUp);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_Navigation.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.set_selectOnUp);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_Navigation.<>f__mg$cache3, true);
		string name3 = "selectOnDown";
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.get_selectOnDown);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_Navigation.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.set_selectOnDown);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_Navigation.<>f__mg$cache5, true);
		string name4 = "selectOnLeft";
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.get_selectOnLeft);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_Navigation.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.set_selectOnLeft);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_Navigation.<>f__mg$cache7, true);
		string name5 = "selectOnRight";
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.get_selectOnRight);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_Navigation.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.set_selectOnRight);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_Navigation.<>f__mg$cache9, true);
		string name6 = "defaultNavigation";
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.get_defaultNavigation);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_UI_Navigation.<>f__mg$cacheA, null, false);
		if (Lua_UnityEngine_UI_Navigation.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_Navigation.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_Navigation.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_Navigation.<>f__mg$cacheB, typeof(Navigation), typeof(ValueType));
	}

	// Token: 0x04019D8E RID: 105870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D8F RID: 105871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D90 RID: 105872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D91 RID: 105873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D92 RID: 105874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D93 RID: 105875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D94 RID: 105876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D95 RID: 105877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019D96 RID: 105878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019D97 RID: 105879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019D98 RID: 105880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019D99 RID: 105881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
