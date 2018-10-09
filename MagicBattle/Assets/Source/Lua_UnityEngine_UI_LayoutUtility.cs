using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001849 RID: 6217
[Preserve]
public class Lua_UnityEngine_UI_LayoutUtility : LuaObject
{
	// Token: 0x0602419F RID: 147871 RVA: 0x00CAD168 File Offset: 0x00CAB368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMinSize_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			int axis;
			LuaObject.checkType(l, 2, out axis);
			float minSize = LayoutUtility.GetMinSize(rect, axis);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, minSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A0 RID: 147872 RVA: 0x00CAD1C8 File Offset: 0x00CAB3C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPreferredSize_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			int axis;
			LuaObject.checkType(l, 2, out axis);
			float preferredSize = LayoutUtility.GetPreferredSize(rect, axis);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preferredSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A1 RID: 147873 RVA: 0x00CAD228 File Offset: 0x00CAB428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFlexibleSize_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			int axis;
			LuaObject.checkType(l, 2, out axis);
			float flexibleSize = LayoutUtility.GetFlexibleSize(rect, axis);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, flexibleSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A2 RID: 147874 RVA: 0x00CAD288 File Offset: 0x00CAB488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMinWidth_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			float minWidth = LayoutUtility.GetMinWidth(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A3 RID: 147875 RVA: 0x00CAD2DC File Offset: 0x00CAB4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPreferredWidth_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			float preferredWidth = LayoutUtility.GetPreferredWidth(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A4 RID: 147876 RVA: 0x00CAD330 File Offset: 0x00CAB530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFlexibleWidth_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			float flexibleWidth = LayoutUtility.GetFlexibleWidth(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A5 RID: 147877 RVA: 0x00CAD384 File Offset: 0x00CAB584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMinHeight_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			float minHeight = LayoutUtility.GetMinHeight(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A6 RID: 147878 RVA: 0x00CAD3D8 File Offset: 0x00CAB5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPreferredHeight_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			float preferredHeight = LayoutUtility.GetPreferredHeight(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A7 RID: 147879 RVA: 0x00CAD42C File Offset: 0x00CAB62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetFlexibleHeight_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			float flexibleHeight = LayoutUtility.GetFlexibleHeight(rect);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A8 RID: 147880 RVA: 0x00CAD480 File Offset: 0x00CAB680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLayoutProperty_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				RectTransform rect;
				LuaObject.checkType<RectTransform>(l, 1, out rect);
				Func<ILayoutElement, float> property;
				LuaObject.checkDelegate<Func<ILayoutElement, float>>(l, 2, out property);
				float defaultValue;
				LuaObject.checkType(l, 3, out defaultValue);
				float layoutProperty = LayoutUtility.GetLayoutProperty(rect, property, defaultValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, layoutProperty);
				result = 2;
			}
			else if (num == 4)
			{
				RectTransform rect2;
				LuaObject.checkType<RectTransform>(l, 1, out rect2);
				Func<ILayoutElement, float> property2;
				LuaObject.checkDelegate<Func<ILayoutElement, float>>(l, 2, out property2);
				float defaultValue2;
				LuaObject.checkType(l, 3, out defaultValue2);
				ILayoutElement o;
				float layoutProperty2 = LayoutUtility.GetLayoutProperty(rect2, property2, defaultValue2, out o);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, layoutProperty2);
				LuaObject.pushValue(l, o);
				result = 3;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function GetLayoutProperty to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241A9 RID: 147881 RVA: 0x00CAD56C File Offset: 0x00CAB76C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.LayoutUtility");
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetMinSize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetPreferredSize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetFlexibleSize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetMinWidth_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetPreferredWidth_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetFlexibleWidth_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetMinHeight_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetPreferredHeight_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetFlexibleHeight_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutUtility.GetLayoutProperty_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutUtility.<>f__mg$cache9);
		LuaObject.createTypeMetatable(l, null, typeof(LayoutUtility));
	}

	// Token: 0x04019D6B RID: 105835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D6C RID: 105836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D6D RID: 105837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D6E RID: 105838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D6F RID: 105839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D70 RID: 105840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D71 RID: 105841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D72 RID: 105842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019D73 RID: 105843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019D74 RID: 105844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
