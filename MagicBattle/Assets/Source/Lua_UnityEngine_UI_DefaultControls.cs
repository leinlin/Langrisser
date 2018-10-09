using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200181A RID: 6170
[Preserve]
public class Lua_UnityEngine_UI_DefaultControls : LuaObject
{
	// Token: 0x06023FE7 RID: 147431 RVA: 0x00CA2038 File Offset: 0x00CA0238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePanel_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreatePanel(resources);
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

	// Token: 0x06023FE8 RID: 147432 RVA: 0x00CA208C File Offset: 0x00CA028C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateButton_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateButton(resources);
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

	// Token: 0x06023FE9 RID: 147433 RVA: 0x00CA20E0 File Offset: 0x00CA02E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateText_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateText(resources);
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

	// Token: 0x06023FEA RID: 147434 RVA: 0x00CA2134 File Offset: 0x00CA0334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateImage_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateImage(resources);
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

	// Token: 0x06023FEB RID: 147435 RVA: 0x00CA2188 File Offset: 0x00CA0388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateRawImage_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateRawImage(resources);
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

	// Token: 0x06023FEC RID: 147436 RVA: 0x00CA21DC File Offset: 0x00CA03DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSlider_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateSlider(resources);
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

	// Token: 0x06023FED RID: 147437 RVA: 0x00CA2230 File Offset: 0x00CA0430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateScrollbar_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateScrollbar(resources);
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

	// Token: 0x06023FEE RID: 147438 RVA: 0x00CA2284 File Offset: 0x00CA0484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateToggle_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateToggle(resources);
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

	// Token: 0x06023FEF RID: 147439 RVA: 0x00CA22D8 File Offset: 0x00CA04D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateInputField_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateInputField(resources);
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

	// Token: 0x06023FF0 RID: 147440 RVA: 0x00CA232C File Offset: 0x00CA052C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreateDropdown_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateDropdown(resources);
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

	// Token: 0x06023FF1 RID: 147441 RVA: 0x00CA2380 File Offset: 0x00CA0580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateScrollView_s(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			GameObject o = DefaultControls.CreateScrollView(resources);
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

	// Token: 0x06023FF2 RID: 147442 RVA: 0x00CA23D4 File Offset: 0x00CA05D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.DefaultControls");
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreatePanel_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateButton_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateText_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateImage_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateRawImage_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateSlider_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateScrollbar_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateToggle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache7);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateInputField_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache8);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateDropdown_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cache9);
		if (Lua_UnityEngine_UI_DefaultControls.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_DefaultControls.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls.CreateScrollView_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_DefaultControls.<>f__mg$cacheA);
		LuaObject.createTypeMetatable(l, null, typeof(DefaultControls));
	}

	// Token: 0x04019C11 RID: 105489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C12 RID: 105490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C13 RID: 105491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C14 RID: 105492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C15 RID: 105493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C16 RID: 105494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C17 RID: 105495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C18 RID: 105496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C19 RID: 105497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C1A RID: 105498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019C1B RID: 105499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
