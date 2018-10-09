using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200182B RID: 6187
[Preserve]
public class Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup : LuaObject
{
	// Token: 0x060240A2 RID: 147618 RVA: 0x00CA6E70 File Offset: 0x00CA5070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_spacing(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, horizontalOrVerticalLayoutGroup.spacing);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A3 RID: 147619 RVA: 0x00CA6EC4 File Offset: 0x00CA50C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_spacing(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			float spacing;
			LuaObject.checkType(l, 2, out spacing);
			horizontalOrVerticalLayoutGroup.spacing = spacing;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A4 RID: 147620 RVA: 0x00CA6F1C File Offset: 0x00CA511C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childForceExpandWidth(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, horizontalOrVerticalLayoutGroup.childForceExpandWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A5 RID: 147621 RVA: 0x00CA6F70 File Offset: 0x00CA5170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childForceExpandWidth(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			bool childForceExpandWidth;
			LuaObject.checkType(l, 2, out childForceExpandWidth);
			horizontalOrVerticalLayoutGroup.childForceExpandWidth = childForceExpandWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A6 RID: 147622 RVA: 0x00CA6FC8 File Offset: 0x00CA51C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childForceExpandHeight(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, horizontalOrVerticalLayoutGroup.childForceExpandHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A7 RID: 147623 RVA: 0x00CA701C File Offset: 0x00CA521C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childForceExpandHeight(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			bool childForceExpandHeight;
			LuaObject.checkType(l, 2, out childForceExpandHeight);
			horizontalOrVerticalLayoutGroup.childForceExpandHeight = childForceExpandHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A8 RID: 147624 RVA: 0x00CA7074 File Offset: 0x00CA5274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childControlWidth(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, horizontalOrVerticalLayoutGroup.childControlWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A9 RID: 147625 RVA: 0x00CA70C8 File Offset: 0x00CA52C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childControlWidth(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			bool childControlWidth;
			LuaObject.checkType(l, 2, out childControlWidth);
			horizontalOrVerticalLayoutGroup.childControlWidth = childControlWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240AA RID: 147626 RVA: 0x00CA7120 File Offset: 0x00CA5320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childControlHeight(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, horizontalOrVerticalLayoutGroup.childControlHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240AB RID: 147627 RVA: 0x00CA7174 File Offset: 0x00CA5374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childControlHeight(IntPtr l)
	{
		int result;
		try
		{
			HorizontalOrVerticalLayoutGroup horizontalOrVerticalLayoutGroup = (HorizontalOrVerticalLayoutGroup)LuaObject.checkSelf(l);
			bool childControlHeight;
			LuaObject.checkType(l, 2, out childControlHeight);
			horizontalOrVerticalLayoutGroup.childControlHeight = childControlHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240AC RID: 147628 RVA: 0x00CA71CC File Offset: 0x00CA53CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.HorizontalOrVerticalLayoutGroup");
		string name = "spacing";
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.get_spacing);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.set_spacing);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache1, true);
		string name2 = "childForceExpandWidth";
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.get_childForceExpandWidth);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.set_childForceExpandWidth);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache3, true);
		string name3 = "childForceExpandHeight";
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.get_childForceExpandHeight);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.set_childForceExpandHeight);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache5, true);
		string name4 = "childControlWidth";
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.get_childControlWidth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.set_childControlWidth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache7, true);
		string name5 = "childControlHeight";
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.get_childControlHeight);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.set_childControlHeight);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_HorizontalOrVerticalLayoutGroup.<>f__mg$cache9, true);
		LuaObject.createTypeMetatable(l, null, typeof(HorizontalOrVerticalLayoutGroup), typeof(LayoutGroup));
	}

	// Token: 0x04019CAA RID: 105642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CAB RID: 105643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CAC RID: 105644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CAD RID: 105645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019CAE RID: 105646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019CAF RID: 105647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019CB0 RID: 105648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019CB1 RID: 105649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019CB2 RID: 105650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019CB3 RID: 105651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
