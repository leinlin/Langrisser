using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017C8 RID: 6088
[Preserve]
public class Lua_UnityEngine_Screen : LuaObject
{
	// Token: 0x06023CC0 RID: 146624 RVA: 0x00C8A774 File Offset: 0x00C88974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Screen o = new Screen();
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

	// Token: 0x06023CC1 RID: 146625 RVA: 0x00C8A7BC File Offset: 0x00C889BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetResolution_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 3)
			{
				int width;
				LuaObject.checkType(l, 1, out width);
				int height;
				LuaObject.checkType(l, 2, out height);
				bool fullscreen;
				LuaObject.checkType(l, 3, out fullscreen);
				Screen.SetResolution(width, height, fullscreen);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				int width2;
				LuaObject.checkType(l, 1, out width2);
				int height2;
				LuaObject.checkType(l, 2, out height2);
				bool fullscreen2;
				LuaObject.checkType(l, 3, out fullscreen2);
				int preferredRefreshRate;
				LuaObject.checkType(l, 4, out preferredRefreshRate);
				Screen.SetResolution(width2, height2, fullscreen2, preferredRefreshRate);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function SetResolution to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC2 RID: 146626 RVA: 0x00C8A894 File Offset: 0x00C88A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_resolutions(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.resolutions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC3 RID: 146627 RVA: 0x00C8A8DC File Offset: 0x00C88ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_currentResolution(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.currentResolution);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC4 RID: 146628 RVA: 0x00C8A928 File Offset: 0x00C88B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fullScreen(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.fullScreen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC5 RID: 146629 RVA: 0x00C8A970 File Offset: 0x00C88B70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_fullScreen(IntPtr l)
	{
		int result;
		try
		{
			bool fullScreen;
			LuaObject.checkType(l, 2, out fullScreen);
			Screen.fullScreen = fullScreen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC6 RID: 146630 RVA: 0x00C8A9BC File Offset: 0x00C88BBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_width(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.width);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC7 RID: 146631 RVA: 0x00C8AA04 File Offset: 0x00C88C04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_height(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC8 RID: 146632 RVA: 0x00C8AA4C File Offset: 0x00C88C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_dpi(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.dpi);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CC9 RID: 146633 RVA: 0x00C8AA94 File Offset: 0x00C88C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_orientation(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)Screen.orientation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CCA RID: 146634 RVA: 0x00C8AADC File Offset: 0x00C88CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_orientation(IntPtr l)
	{
		int result;
		try
		{
			ScreenOrientation orientation;
			LuaObject.checkEnum<ScreenOrientation>(l, 2, out orientation);
			Screen.orientation = orientation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CCB RID: 146635 RVA: 0x00C8AB28 File Offset: 0x00C88D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sleepTimeout(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.sleepTimeout);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CCC RID: 146636 RVA: 0x00C8AB70 File Offset: 0x00C88D70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sleepTimeout(IntPtr l)
	{
		int result;
		try
		{
			int sleepTimeout;
			LuaObject.checkType(l, 2, out sleepTimeout);
			Screen.sleepTimeout = sleepTimeout;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CCD RID: 146637 RVA: 0x00C8ABBC File Offset: 0x00C88DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autorotateToPortrait(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.autorotateToPortrait);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CCE RID: 146638 RVA: 0x00C8AC04 File Offset: 0x00C88E04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autorotateToPortrait(IntPtr l)
	{
		int result;
		try
		{
			bool autorotateToPortrait;
			LuaObject.checkType(l, 2, out autorotateToPortrait);
			Screen.autorotateToPortrait = autorotateToPortrait;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CCF RID: 146639 RVA: 0x00C8AC50 File Offset: 0x00C88E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autorotateToPortraitUpsideDown(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.autorotateToPortraitUpsideDown);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD0 RID: 146640 RVA: 0x00C8AC98 File Offset: 0x00C88E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autorotateToPortraitUpsideDown(IntPtr l)
	{
		int result;
		try
		{
			bool autorotateToPortraitUpsideDown;
			LuaObject.checkType(l, 2, out autorotateToPortraitUpsideDown);
			Screen.autorotateToPortraitUpsideDown = autorotateToPortraitUpsideDown;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD1 RID: 146641 RVA: 0x00C8ACE4 File Offset: 0x00C88EE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_autorotateToLandscapeLeft(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.autorotateToLandscapeLeft);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD2 RID: 146642 RVA: 0x00C8AD2C File Offset: 0x00C88F2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_autorotateToLandscapeLeft(IntPtr l)
	{
		int result;
		try
		{
			bool autorotateToLandscapeLeft;
			LuaObject.checkType(l, 2, out autorotateToLandscapeLeft);
			Screen.autorotateToLandscapeLeft = autorotateToLandscapeLeft;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD3 RID: 146643 RVA: 0x00C8AD78 File Offset: 0x00C88F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autorotateToLandscapeRight(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.autorotateToLandscapeRight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD4 RID: 146644 RVA: 0x00C8ADC0 File Offset: 0x00C88FC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_autorotateToLandscapeRight(IntPtr l)
	{
		int result;
		try
		{
			bool autorotateToLandscapeRight;
			LuaObject.checkType(l, 2, out autorotateToLandscapeRight);
			Screen.autorotateToLandscapeRight = autorotateToLandscapeRight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD5 RID: 146645 RVA: 0x00C8AE0C File Offset: 0x00C8900C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_safeArea(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Screen.safeArea);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023CD6 RID: 146646 RVA: 0x00C8AE58 File Offset: 0x00C89058
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Screen");
		if (Lua_UnityEngine_Screen.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Screen.SetResolution_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Screen.<>f__mg$cache0);
		string name = "resolutions";
		if (Lua_UnityEngine_Screen.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Screen.get_resolutions);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Screen.<>f__mg$cache1, null, false);
		string name2 = "currentResolution";
		if (Lua_UnityEngine_Screen.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Screen.get_currentResolution);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Screen.<>f__mg$cache2, null, false);
		string name3 = "fullScreen";
		if (Lua_UnityEngine_Screen.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Screen.get_fullScreen);
		}
		LuaCSFunction get = Lua_UnityEngine_Screen.<>f__mg$cache3;
		if (Lua_UnityEngine_Screen.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Screen.set_fullScreen);
		}
		LuaObject.addMember(l, name3, get, Lua_UnityEngine_Screen.<>f__mg$cache4, false);
		string name4 = "width";
		if (Lua_UnityEngine_Screen.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Screen.get_width);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Screen.<>f__mg$cache5, null, false);
		string name5 = "height";
		if (Lua_UnityEngine_Screen.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Screen.get_height);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Screen.<>f__mg$cache6, null, false);
		string name6 = "dpi";
		if (Lua_UnityEngine_Screen.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Screen.get_dpi);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Screen.<>f__mg$cache7, null, false);
		string name7 = "orientation";
		if (Lua_UnityEngine_Screen.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Screen.get_orientation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Screen.<>f__mg$cache8;
		if (Lua_UnityEngine_Screen.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Screen.set_orientation);
		}
		LuaObject.addMember(l, name7, get2, Lua_UnityEngine_Screen.<>f__mg$cache9, false);
		string name8 = "sleepTimeout";
		if (Lua_UnityEngine_Screen.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Screen.get_sleepTimeout);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Screen.<>f__mg$cacheA;
		if (Lua_UnityEngine_Screen.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Screen.set_sleepTimeout);
		}
		LuaObject.addMember(l, name8, get3, Lua_UnityEngine_Screen.<>f__mg$cacheB, false);
		string name9 = "autorotateToPortrait";
		if (Lua_UnityEngine_Screen.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Screen.get_autorotateToPortrait);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Screen.<>f__mg$cacheC;
		if (Lua_UnityEngine_Screen.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Screen.set_autorotateToPortrait);
		}
		LuaObject.addMember(l, name9, get4, Lua_UnityEngine_Screen.<>f__mg$cacheD, false);
		string name10 = "autorotateToPortraitUpsideDown";
		if (Lua_UnityEngine_Screen.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Screen.get_autorotateToPortraitUpsideDown);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Screen.<>f__mg$cacheE;
		if (Lua_UnityEngine_Screen.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Screen.set_autorotateToPortraitUpsideDown);
		}
		LuaObject.addMember(l, name10, get5, Lua_UnityEngine_Screen.<>f__mg$cacheF, false);
		string name11 = "autorotateToLandscapeLeft";
		if (Lua_UnityEngine_Screen.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Screen.get_autorotateToLandscapeLeft);
		}
		LuaCSFunction get6 = Lua_UnityEngine_Screen.<>f__mg$cache10;
		if (Lua_UnityEngine_Screen.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Screen.set_autorotateToLandscapeLeft);
		}
		LuaObject.addMember(l, name11, get6, Lua_UnityEngine_Screen.<>f__mg$cache11, false);
		string name12 = "autorotateToLandscapeRight";
		if (Lua_UnityEngine_Screen.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Screen.get_autorotateToLandscapeRight);
		}
		LuaCSFunction get7 = Lua_UnityEngine_Screen.<>f__mg$cache12;
		if (Lua_UnityEngine_Screen.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Screen.set_autorotateToLandscapeRight);
		}
		LuaObject.addMember(l, name12, get7, Lua_UnityEngine_Screen.<>f__mg$cache13, false);
		string name13 = "safeArea";
		if (Lua_UnityEngine_Screen.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Screen.get_safeArea);
		}
		LuaObject.addMember(l, name13, Lua_UnityEngine_Screen.<>f__mg$cache14, null, false);
		if (Lua_UnityEngine_Screen.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Screen.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Screen.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Screen.<>f__mg$cache15, typeof(Screen));
	}

	// Token: 0x0401998E RID: 104846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401998F RID: 104847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019990 RID: 104848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019991 RID: 104849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019992 RID: 104850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019993 RID: 104851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019994 RID: 104852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019995 RID: 104853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019996 RID: 104854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019997 RID: 104855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019998 RID: 104856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019999 RID: 104857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401999A RID: 104858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401999B RID: 104859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401999C RID: 104860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401999D RID: 104861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401999E RID: 104862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401999F RID: 104863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040199A0 RID: 104864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040199A1 RID: 104865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040199A2 RID: 104866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040199A3 RID: 104867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
