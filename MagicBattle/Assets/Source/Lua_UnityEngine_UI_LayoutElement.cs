using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001846 RID: 6214
[Preserve]
public class Lua_UnityEngine_UI_LayoutElement : LuaObject
{
	// Token: 0x06024170 RID: 147824 RVA: 0x00CABDA8 File Offset: 0x00CA9FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			layoutElement.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024171 RID: 147825 RVA: 0x00CABDF4 File Offset: 0x00CA9FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			layoutElement.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024172 RID: 147826 RVA: 0x00CABE40 File Offset: 0x00CAA040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ignoreLayout(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.ignoreLayout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024173 RID: 147827 RVA: 0x00CABE94 File Offset: 0x00CAA094
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ignoreLayout(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			bool ignoreLayout;
			LuaObject.checkType(l, 2, out ignoreLayout);
			layoutElement.ignoreLayout = ignoreLayout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024174 RID: 147828 RVA: 0x00CABEEC File Offset: 0x00CAA0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024175 RID: 147829 RVA: 0x00CABF40 File Offset: 0x00CAA140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			float minWidth;
			LuaObject.checkType(l, 2, out minWidth);
			layoutElement.minWidth = minWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024176 RID: 147830 RVA: 0x00CABF98 File Offset: 0x00CAA198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024177 RID: 147831 RVA: 0x00CABFEC File Offset: 0x00CAA1EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_minHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			float minHeight;
			LuaObject.checkType(l, 2, out minHeight);
			layoutElement.minHeight = minHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024178 RID: 147832 RVA: 0x00CAC044 File Offset: 0x00CAA244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024179 RID: 147833 RVA: 0x00CAC098 File Offset: 0x00CAA298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			float preferredWidth;
			LuaObject.checkType(l, 2, out preferredWidth);
			layoutElement.preferredWidth = preferredWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602417A RID: 147834 RVA: 0x00CAC0F0 File Offset: 0x00CAA2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602417B RID: 147835 RVA: 0x00CAC144 File Offset: 0x00CAA344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			float preferredHeight;
			LuaObject.checkType(l, 2, out preferredHeight);
			layoutElement.preferredHeight = preferredHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602417C RID: 147836 RVA: 0x00CAC19C File Offset: 0x00CAA39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602417D RID: 147837 RVA: 0x00CAC1F0 File Offset: 0x00CAA3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			float flexibleWidth;
			LuaObject.checkType(l, 2, out flexibleWidth);
			layoutElement.flexibleWidth = flexibleWidth;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602417E RID: 147838 RVA: 0x00CAC248 File Offset: 0x00CAA448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602417F RID: 147839 RVA: 0x00CAC29C File Offset: 0x00CAA49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			float flexibleHeight;
			LuaObject.checkType(l, 2, out flexibleHeight);
			layoutElement.flexibleHeight = flexibleHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024180 RID: 147840 RVA: 0x00CAC2F4 File Offset: 0x00CAA4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutElement.layoutPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024181 RID: 147841 RVA: 0x00CAC348 File Offset: 0x00CAA548
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			LayoutElement layoutElement = (LayoutElement)LuaObject.checkSelf(l);
			int layoutPriority;
			LuaObject.checkType(l, 2, out layoutPriority);
			layoutElement.layoutPriority = layoutPriority;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024182 RID: 147842 RVA: 0x00CAC3A0 File Offset: 0x00CAA5A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.LayoutElement");
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache1);
		string name = "ignoreLayout";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_ignoreLayout);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_ignoreLayout);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache3, true);
		string name2 = "minWidth";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_minWidth);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_minWidth);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache5, true);
		string name3 = "minHeight";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_minHeight);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_minHeight);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache7, true);
		string name4 = "preferredWidth";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_preferredWidth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_preferredWidth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache9, true);
		string name5 = "preferredHeight";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_preferredHeight);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_preferredHeight);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheB, true);
		string name6 = "flexibleWidth";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_flexibleWidth);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_flexibleWidth);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheD, true);
		string name7 = "flexibleHeight";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_flexibleHeight);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_flexibleHeight);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cacheF, true);
		string name8 = "layoutPriority";
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.get_layoutPriority);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutElement.set_layoutPriority);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UI_LayoutElement.<>f__mg$cache11, true);
		LuaObject.createTypeMetatable(l, null, typeof(LayoutElement), typeof(UIBehaviour));
	}

	// Token: 0x04019D42 RID: 105794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D43 RID: 105795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D44 RID: 105796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D45 RID: 105797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D46 RID: 105798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D47 RID: 105799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D48 RID: 105800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D49 RID: 105801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019D4A RID: 105802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019D4B RID: 105803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019D4C RID: 105804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019D4D RID: 105805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019D4E RID: 105806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019D4F RID: 105807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019D50 RID: 105808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019D51 RID: 105809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019D52 RID: 105810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019D53 RID: 105811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
