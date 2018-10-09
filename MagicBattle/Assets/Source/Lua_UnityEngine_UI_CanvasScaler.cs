using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200180F RID: 6159
[Preserve]
public class Lua_UnityEngine_UI_CanvasScaler : LuaObject
{
	// Token: 0x06023F9A RID: 147354 RVA: 0x00CA0380 File Offset: 0x00C9E580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_uiScaleMode(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)canvasScaler.uiScaleMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F9B RID: 147355 RVA: 0x00CA03D4 File Offset: 0x00C9E5D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_uiScaleMode(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			CanvasScaler.ScaleMode uiScaleMode;
			LuaObject.checkEnum<CanvasScaler.ScaleMode>(l, 2, out uiScaleMode);
			canvasScaler.uiScaleMode = uiScaleMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F9C RID: 147356 RVA: 0x00CA042C File Offset: 0x00C9E62C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_referencePixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.referencePixelsPerUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F9D RID: 147357 RVA: 0x00CA0480 File Offset: 0x00C9E680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_referencePixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			float referencePixelsPerUnit;
			LuaObject.checkType(l, 2, out referencePixelsPerUnit);
			canvasScaler.referencePixelsPerUnit = referencePixelsPerUnit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F9E RID: 147358 RVA: 0x00CA04D8 File Offset: 0x00C9E6D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_scaleFactor(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.scaleFactor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F9F RID: 147359 RVA: 0x00CA052C File Offset: 0x00C9E72C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_scaleFactor(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			float scaleFactor;
			LuaObject.checkType(l, 2, out scaleFactor);
			canvasScaler.scaleFactor = scaleFactor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA0 RID: 147360 RVA: 0x00CA0584 File Offset: 0x00C9E784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_referenceResolution(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.referenceResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA1 RID: 147361 RVA: 0x00CA05D8 File Offset: 0x00C9E7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_referenceResolution(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			Vector2 referenceResolution;
			LuaObject.checkType(l, 2, out referenceResolution);
			canvasScaler.referenceResolution = referenceResolution;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA2 RID: 147362 RVA: 0x00CA0630 File Offset: 0x00C9E830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_screenMatchMode(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)canvasScaler.screenMatchMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA3 RID: 147363 RVA: 0x00CA0684 File Offset: 0x00C9E884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_screenMatchMode(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			CanvasScaler.ScreenMatchMode screenMatchMode;
			LuaObject.checkEnum<CanvasScaler.ScreenMatchMode>(l, 2, out screenMatchMode);
			canvasScaler.screenMatchMode = screenMatchMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA4 RID: 147364 RVA: 0x00CA06DC File Offset: 0x00C9E8DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_matchWidthOrHeight(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.matchWidthOrHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA5 RID: 147365 RVA: 0x00CA0730 File Offset: 0x00C9E930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_matchWidthOrHeight(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			float matchWidthOrHeight;
			LuaObject.checkType(l, 2, out matchWidthOrHeight);
			canvasScaler.matchWidthOrHeight = matchWidthOrHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA6 RID: 147366 RVA: 0x00CA0788 File Offset: 0x00C9E988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_physicalUnit(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)canvasScaler.physicalUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA7 RID: 147367 RVA: 0x00CA07DC File Offset: 0x00C9E9DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_physicalUnit(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			CanvasScaler.Unit physicalUnit;
			LuaObject.checkEnum<CanvasScaler.Unit>(l, 2, out physicalUnit);
			canvasScaler.physicalUnit = physicalUnit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA8 RID: 147368 RVA: 0x00CA0834 File Offset: 0x00C9EA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fallbackScreenDPI(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.fallbackScreenDPI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FA9 RID: 147369 RVA: 0x00CA0888 File Offset: 0x00C9EA88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fallbackScreenDPI(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			float fallbackScreenDPI;
			LuaObject.checkType(l, 2, out fallbackScreenDPI);
			canvasScaler.fallbackScreenDPI = fallbackScreenDPI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FAA RID: 147370 RVA: 0x00CA08E0 File Offset: 0x00C9EAE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_defaultSpriteDPI(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.defaultSpriteDPI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FAB RID: 147371 RVA: 0x00CA0934 File Offset: 0x00C9EB34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_defaultSpriteDPI(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			float defaultSpriteDPI;
			LuaObject.checkType(l, 2, out defaultSpriteDPI);
			canvasScaler.defaultSpriteDPI = defaultSpriteDPI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FAC RID: 147372 RVA: 0x00CA098C File Offset: 0x00C9EB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dynamicPixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, canvasScaler.dynamicPixelsPerUnit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FAD RID: 147373 RVA: 0x00CA09E0 File Offset: 0x00C9EBE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_dynamicPixelsPerUnit(IntPtr l)
	{
		int result;
		try
		{
			CanvasScaler canvasScaler = (CanvasScaler)LuaObject.checkSelf(l);
			float dynamicPixelsPerUnit;
			LuaObject.checkType(l, 2, out dynamicPixelsPerUnit);
			canvasScaler.dynamicPixelsPerUnit = dynamicPixelsPerUnit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023FAE RID: 147374 RVA: 0x00CA0A38 File Offset: 0x00C9EC38
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.CanvasScaler");
		string name = "uiScaleMode";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_uiScaleMode);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache0;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_uiScaleMode);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache1, true);
		string name2 = "referencePixelsPerUnit";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_referencePixelsPerUnit);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_referencePixelsPerUnit);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache3, true);
		string name3 = "scaleFactor";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_scaleFactor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_scaleFactor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache5, true);
		string name4 = "referenceResolution";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_referenceResolution);
		}
		LuaCSFunction get4 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache6;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_referenceResolution);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache7, true);
		string name5 = "screenMatchMode";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_screenMatchMode);
		}
		LuaCSFunction get5 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache8;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_screenMatchMode);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache9, true);
		string name6 = "matchWidthOrHeight";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_matchWidthOrHeight);
		}
		LuaCSFunction get6 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheA;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_matchWidthOrHeight);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheB, true);
		string name7 = "physicalUnit";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_physicalUnit);
		}
		LuaCSFunction get7 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheC;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_physicalUnit);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheD, true);
		string name8 = "fallbackScreenDPI";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_fallbackScreenDPI);
		}
		LuaCSFunction get8 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheE;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_fallbackScreenDPI);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cacheF, true);
		string name9 = "defaultSpriteDPI";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_defaultSpriteDPI);
		}
		LuaCSFunction get9 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache10;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_defaultSpriteDPI);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache11, true);
		string name10 = "dynamicPixelsPerUnit";
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.get_dynamicPixelsPerUnit);
		}
		LuaCSFunction get10 = Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache12;
		if (Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_UI_CanvasScaler.set_dynamicPixelsPerUnit);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_UI_CanvasScaler.<>f__mg$cache13, true);
		LuaObject.createTypeMetatable(l, null, typeof(CanvasScaler), typeof(UIBehaviour));
	}

	// Token: 0x04019BDA RID: 105434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BDB RID: 105435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BDC RID: 105436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BDD RID: 105437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019BDE RID: 105438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019BDF RID: 105439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019BE0 RID: 105440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019BE1 RID: 105441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019BE2 RID: 105442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019BE3 RID: 105443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019BE4 RID: 105444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019BE5 RID: 105445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019BE6 RID: 105446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019BE7 RID: 105447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019BE8 RID: 105448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019BE9 RID: 105449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019BEA RID: 105450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019BEB RID: 105451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019BEC RID: 105452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019BED RID: 105453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
