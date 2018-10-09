using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200181B RID: 6171
[Preserve]
public class Lua_UnityEngine_UI_DefaultControls_Resources : LuaObject
{
	// Token: 0x06023FF4 RID: 147444 RVA: 0x00CA2588 File Offset: 0x00CA0788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources = default(DefaultControls.Resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FF5 RID: 147445 RVA: 0x00CA25D8 File Offset: 0x00CA07D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_standard(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.standard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FF6 RID: 147446 RVA: 0x00CA262C File Offset: 0x00CA082C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_standard(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite standard;
			LuaObject.checkType<Sprite>(l, 2, out standard);
			resources.standard = standard;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FF7 RID: 147447 RVA: 0x00CA2690 File Offset: 0x00CA0890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_background(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.background);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FF8 RID: 147448 RVA: 0x00CA26E4 File Offset: 0x00CA08E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_background(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite background;
			LuaObject.checkType<Sprite>(l, 2, out background);
			resources.background = background;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FF9 RID: 147449 RVA: 0x00CA2748 File Offset: 0x00CA0948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inputField(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.inputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FFA RID: 147450 RVA: 0x00CA279C File Offset: 0x00CA099C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_inputField(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite inputField;
			LuaObject.checkType<Sprite>(l, 2, out inputField);
			resources.inputField = inputField;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FFB RID: 147451 RVA: 0x00CA2800 File Offset: 0x00CA0A00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_knob(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.knob);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FFC RID: 147452 RVA: 0x00CA2854 File Offset: 0x00CA0A54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_knob(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite knob;
			LuaObject.checkType<Sprite>(l, 2, out knob);
			resources.knob = knob;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FFD RID: 147453 RVA: 0x00CA28B8 File Offset: 0x00CA0AB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_checkmark(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.checkmark);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FFE RID: 147454 RVA: 0x00CA290C File Offset: 0x00CA0B0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_checkmark(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite checkmark;
			LuaObject.checkType<Sprite>(l, 2, out checkmark);
			resources.checkmark = checkmark;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FFF RID: 147455 RVA: 0x00CA2970 File Offset: 0x00CA0B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_dropdown(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.dropdown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024000 RID: 147456 RVA: 0x00CA29C4 File Offset: 0x00CA0BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_dropdown(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite dropdown;
			LuaObject.checkType<Sprite>(l, 2, out dropdown);
			resources.dropdown = dropdown;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024001 RID: 147457 RVA: 0x00CA2A28 File Offset: 0x00CA0C28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_mask(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resources.mask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024002 RID: 147458 RVA: 0x00CA2A7C File Offset: 0x00CA0C7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_mask(IntPtr l)
	{
		int result;
		try
		{
			DefaultControls.Resources resources;
			LuaObject.checkValueType<DefaultControls.Resources>(l, 1, out resources);
			Sprite mask;
			LuaObject.checkType<Sprite>(l, 2, out mask);
			resources.mask = mask;
			LuaObject.setBack(l, resources);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024003 RID: 147459 RVA: 0x00CA2AE0 File Offset: 0x00CA0CE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.DefaultControls.Resources");
		string name = "standard";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_standard);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_standard);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache1, true);
		string name2 = "background";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_background);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_background);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache3, true);
		string name3 = "inputField";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_inputField);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_inputField);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache5, true);
		string name4 = "knob";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_knob);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_knob);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache7, true);
		string name5 = "checkmark";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_checkmark);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_checkmark);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cache9, true);
		string name6 = "dropdown";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_dropdown);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_dropdown);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheB, true);
		string name7 = "mask";
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.get_mask);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.set_mask);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheD, true);
		if (Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_DefaultControls_Resources.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_DefaultControls_Resources.<>f__mg$cacheE, typeof(DefaultControls.Resources), typeof(ValueType));
	}

	// Token: 0x04019C1C RID: 105500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019C1D RID: 105501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019C1E RID: 105502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019C1F RID: 105503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019C20 RID: 105504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019C21 RID: 105505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019C22 RID: 105506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019C23 RID: 105507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019C24 RID: 105508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019C25 RID: 105509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019C26 RID: 105510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019C27 RID: 105511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019C28 RID: 105512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019C29 RID: 105513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019C2A RID: 105514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
