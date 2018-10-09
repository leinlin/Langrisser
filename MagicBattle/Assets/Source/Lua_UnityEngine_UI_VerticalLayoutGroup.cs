using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001869 RID: 6249
[Preserve]
public class Lua_UnityEngine_UI_VerticalLayoutGroup : LuaObject
{
	// Token: 0x06024315 RID: 148245 RVA: 0x00CB6F10 File Offset: 0x00CB5110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputHorizontal(IntPtr l)
	{
		int result;
		try
		{
			VerticalLayoutGroup verticalLayoutGroup = (VerticalLayoutGroup)LuaObject.checkSelf(l);
			verticalLayoutGroup.CalculateLayoutInputHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024316 RID: 148246 RVA: 0x00CB6F5C File Offset: 0x00CB515C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLayoutInputVertical(IntPtr l)
	{
		int result;
		try
		{
			VerticalLayoutGroup verticalLayoutGroup = (VerticalLayoutGroup)LuaObject.checkSelf(l);
			verticalLayoutGroup.CalculateLayoutInputVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024317 RID: 148247 RVA: 0x00CB6FA8 File Offset: 0x00CB51A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			VerticalLayoutGroup verticalLayoutGroup = (VerticalLayoutGroup)LuaObject.checkSelf(l);
			verticalLayoutGroup.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024318 RID: 148248 RVA: 0x00CB6FF4 File Offset: 0x00CB51F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			VerticalLayoutGroup verticalLayoutGroup = (VerticalLayoutGroup)LuaObject.checkSelf(l);
			verticalLayoutGroup.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024319 RID: 148249 RVA: 0x00CB7040 File Offset: 0x00CB5240
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.VerticalLayoutGroup");
		if (Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_VerticalLayoutGroup.CalculateLayoutInputHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_VerticalLayoutGroup.CalculateLayoutInputVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_VerticalLayoutGroup.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_VerticalLayoutGroup.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_VerticalLayoutGroup.<>f__mg$cache3);
		LuaObject.createTypeMetatable(l, null, typeof(VerticalLayoutGroup), typeof(HorizontalOrVerticalLayoutGroup));
	}

	// Token: 0x04019EA1 RID: 106145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019EA2 RID: 106146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019EA3 RID: 106147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019EA4 RID: 106148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
