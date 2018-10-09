using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001847 RID: 6215
[Preserve]
public class Lua_UnityEngine_UI_LayoutGroup : LuaObject
{
	// Token: 0x06024184 RID: 147844 RVA: 0x00CAC654 File Offset: 0x00CAA854
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			layoutGroup.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024185 RID: 147845 RVA: 0x00CAC6A0 File Offset: 0x00CAA8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			layoutGroup.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024186 RID: 147846 RVA: 0x00CAC6EC File Offset: 0x00CAA8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			layoutGroup.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024187 RID: 147847 RVA: 0x00CAC738 File Offset: 0x00CAA938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			layoutGroup.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024188 RID: 147848 RVA: 0x00CAC784 File Offset: 0x00CAA984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_padding(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.padding);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024189 RID: 147849 RVA: 0x00CAC7D8 File Offset: 0x00CAA9D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_padding(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			RectOffset padding;
			LuaObject.checkType<RectOffset>(l, 2, out padding);
			layoutGroup.padding = padding;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602418A RID: 147850 RVA: 0x00CAC830 File Offset: 0x00CAAA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_childAlignment(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)layoutGroup.childAlignment);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602418B RID: 147851 RVA: 0x00CAC884 File Offset: 0x00CAAA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_childAlignment(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			TextAnchor childAlignment;
			LuaObject.checkEnum<TextAnchor>(l, 2, out childAlignment);
			layoutGroup.childAlignment = childAlignment;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602418C RID: 147852 RVA: 0x00CAC8DC File Offset: 0x00CAAADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.minWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602418D RID: 147853 RVA: 0x00CAC930 File Offset: 0x00CAAB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.preferredWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602418E RID: 147854 RVA: 0x00CAC984 File Offset: 0x00CAAB84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.flexibleWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602418F RID: 147855 RVA: 0x00CAC9D8 File Offset: 0x00CAABD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.minHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024190 RID: 147856 RVA: 0x00CACA2C File Offset: 0x00CAAC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.preferredHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024191 RID: 147857 RVA: 0x00CACA80 File Offset: 0x00CAAC80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.flexibleHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024192 RID: 147858 RVA: 0x00CACAD4 File Offset: 0x00CAACD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			LayoutGroup layoutGroup = (LayoutGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutGroup.layoutPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024193 RID: 147859 RVA: 0x00CACB28 File Offset: 0x00CAAD28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.LayoutGroup");
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache3);
		string name = "padding";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_padding);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.set_padding);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache5, true);
		string name2 = "childAlignment";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_childAlignment);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.set_childAlignment);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache7, true);
		string name3 = "minWidth";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_minWidth);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache8, null, true);
		string name4 = "preferredWidth";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_preferredWidth);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cache9, null, true);
		string name5 = "flexibleWidth";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_flexibleWidth);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheA, null, true);
		string name6 = "minHeight";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_minHeight);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheB, null, true);
		string name7 = "preferredHeight";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_preferredHeight);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheC, null, true);
		string name8 = "flexibleHeight";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_flexibleHeight);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheD, null, true);
		string name9 = "layoutPriority";
		if (Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_LayoutGroup.get_layoutPriority);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_UI_LayoutGroup.<>f__mg$cacheE, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(LayoutGroup), typeof(UIBehaviour));
	}

	// Token: 0x04019D54 RID: 105812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D55 RID: 105813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D56 RID: 105814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D57 RID: 105815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D58 RID: 105816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D59 RID: 105817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D5A RID: 105818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D5B RID: 105819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019D5C RID: 105820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019D5D RID: 105821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019D5E RID: 105822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019D5F RID: 105823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019D60 RID: 105824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019D61 RID: 105825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019D62 RID: 105826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
