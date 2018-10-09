using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200182A RID: 6186
[Preserve]
public class Lua_UnityEngine_UI_HorizontalLayoutGroup : LuaObject
{
	// Token: 0x0602409C RID: 147612 RVA: 0x00CA6C78 File Offset: 0x00CA4E78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			HorizontalLayoutGroup horizontalLayoutGroup = (HorizontalLayoutGroup)LuaObject.checkSelf(l);
			horizontalLayoutGroup.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602409D RID: 147613 RVA: 0x00CA6CC4 File Offset: 0x00CA4EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			HorizontalLayoutGroup horizontalLayoutGroup = (HorizontalLayoutGroup)LuaObject.checkSelf(l);
			horizontalLayoutGroup.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602409E RID: 147614 RVA: 0x00CA6D10 File Offset: 0x00CA4F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			HorizontalLayoutGroup horizontalLayoutGroup = (HorizontalLayoutGroup)LuaObject.checkSelf(l);
			horizontalLayoutGroup.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602409F RID: 147615 RVA: 0x00CA6D5C File Offset: 0x00CA4F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			HorizontalLayoutGroup horizontalLayoutGroup = (HorizontalLayoutGroup)LuaObject.checkSelf(l);
			horizontalLayoutGroup.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240A0 RID: 147616 RVA: 0x00CA6DA8 File Offset: 0x00CA4FA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.HorizontalLayoutGroup");
		if (Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalLayoutGroup.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalLayoutGroup.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalLayoutGroup.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_HorizontalLayoutGroup.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_HorizontalLayoutGroup.<>f__mg$cache3);
		LuaObject.createTypeMetatable(l, null, typeof(HorizontalLayoutGroup), typeof(HorizontalOrVerticalLayoutGroup));
	}

	// Token: 0x04019CA6 RID: 105638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CA7 RID: 105639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CA8 RID: 105640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CA9 RID: 105641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
