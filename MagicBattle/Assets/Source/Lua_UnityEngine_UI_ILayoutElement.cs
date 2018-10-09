using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001830 RID: 6192
[Preserve]
public class Lua_UnityEngine_UI_ILayoutElement : LuaObject
{
	// Token: 0x060240C3 RID: 147651 RVA: 0x00CA7A44 File Offset: 0x00CA5C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240C4 RID: 147652 RVA: 0x00CA7A90 File Offset: 0x00CA5C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240C5 RID: 147653 RVA: 0x00CA7ADC File Offset: 0x00CA5CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_minWidth(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240C6 RID: 147654 RVA: 0x00CA7B30 File Offset: 0x00CA5D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_preferredWidth(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240C7 RID: 147655 RVA: 0x00CA7B84 File Offset: 0x00CA5D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleWidth(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240C8 RID: 147656 RVA: 0x00CA7BD8 File Offset: 0x00CA5DD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_minHeight(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240C9 RID: 147657 RVA: 0x00CA7C2C File Offset: 0x00CA5E2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_preferredHeight(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240CA RID: 147658 RVA: 0x00CA7C80 File Offset: 0x00CA5E80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flexibleHeight(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240CB RID: 147659 RVA: 0x00CA7CD4 File Offset: 0x00CA5ED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_layoutPriority(IntPtr l)
	{
		int result;
		try
		{
			ILayoutElement layoutElement = (ILayoutElement)LuaObject.checkSelf(l);
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

	// Token: 0x060240CC RID: 147660 RVA: 0x00CA7D28 File Offset: 0x00CA5F28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.ILayoutElement");
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache1);
		string name = "minWidth";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_minWidth);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache2, null, true);
		string name2 = "preferredWidth";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_preferredWidth);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache3, null, true);
		string name3 = "flexibleWidth";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_flexibleWidth);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache4, null, true);
		string name4 = "minHeight";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_minHeight);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache5, null, true);
		string name5 = "preferredHeight";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_preferredHeight);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache6, null, true);
		string name6 = "flexibleHeight";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_flexibleHeight);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache7, null, true);
		string name7 = "layoutPriority";
		if (Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_ILayoutElement.get_layoutPriority);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_UI_ILayoutElement.<>f__mg$cache8, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(ILayoutElement));
	}

	// Token: 0x04019CC1 RID: 105665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CC2 RID: 105666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CC3 RID: 105667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CC4 RID: 105668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019CC5 RID: 105669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019CC6 RID: 105670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019CC7 RID: 105671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019CC8 RID: 105672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019CC9 RID: 105673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
