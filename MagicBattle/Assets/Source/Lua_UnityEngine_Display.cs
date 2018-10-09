using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200168C RID: 5772
[Preserve]
public class Lua_UnityEngine_Display : LuaObject
{
	// Token: 0x0602306B RID: 143467 RVA: 0x00C21324 File Offset: 0x00C1F524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Activate(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Display display = (Display)LuaObject.checkSelf(l);
				display.Activate();
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 4)
			{
				Display display2 = (Display)LuaObject.checkSelf(l);
				int width;
				LuaObject.checkType(l, 2, out width);
				int height;
				LuaObject.checkType(l, 3, out height);
				int refreshRate;
				LuaObject.checkType(l, 4, out refreshRate);
				display2.Activate(width, height, refreshRate);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Activate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602306C RID: 143468 RVA: 0x00C213E4 File Offset: 0x00C1F5E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetParams(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			int width;
			LuaObject.checkType(l, 2, out width);
			int height;
			LuaObject.checkType(l, 3, out height);
			int x;
			LuaObject.checkType(l, 4, out x);
			int y;
			LuaObject.checkType(l, 5, out y);
			display.SetParams(width, height, x, y);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602306D RID: 143469 RVA: 0x00C21464 File Offset: 0x00C1F664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetRenderingResolution(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			int w;
			LuaObject.checkType(l, 2, out w);
			int h;
			LuaObject.checkType(l, 3, out h);
			display.SetRenderingResolution(w, h);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602306E RID: 143470 RVA: 0x00C214C8 File Offset: 0x00C1F6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RelativeMouseAt_s(IntPtr l)
	{
		int result;
		try
		{
			Vector3 inputMouseCoordinates;
			LuaObject.checkType(l, 1, out inputMouseCoordinates);
			Vector3 o = Display.RelativeMouseAt(inputMouseCoordinates);
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

	// Token: 0x0602306F RID: 143471 RVA: 0x00C2151C File Offset: 0x00C1F71C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_displays(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Display.displays);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023070 RID: 143472 RVA: 0x00C21564 File Offset: 0x00C1F764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_displays(IntPtr l)
	{
		int result;
		try
		{
			Display[] displays;
			LuaObject.checkArray<Display>(l, 2, out displays);
			Display.displays = displays;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023071 RID: 143473 RVA: 0x00C215B0 File Offset: 0x00C1F7B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderingWidth(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.renderingWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023072 RID: 143474 RVA: 0x00C21604 File Offset: 0x00C1F804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderingHeight(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.renderingHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023073 RID: 143475 RVA: 0x00C21658 File Offset: 0x00C1F858
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_systemWidth(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.systemWidth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023074 RID: 143476 RVA: 0x00C216AC File Offset: 0x00C1F8AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_systemHeight(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.systemHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023075 RID: 143477 RVA: 0x00C21700 File Offset: 0x00C1F900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorBuffer(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.colorBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023076 RID: 143478 RVA: 0x00C21758 File Offset: 0x00C1F958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depthBuffer(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.depthBuffer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023077 RID: 143479 RVA: 0x00C217B0 File Offset: 0x00C1F9B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_active(IntPtr l)
	{
		int result;
		try
		{
			Display display = (Display)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, display.active);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023078 RID: 143480 RVA: 0x00C21804 File Offset: 0x00C1FA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_main(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Display.main);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023079 RID: 143481 RVA: 0x00C2184C File Offset: 0x00C1FA4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Display");
		if (Lua_UnityEngine_Display.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Display.Activate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Display.<>f__mg$cache0);
		if (Lua_UnityEngine_Display.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Display.SetParams);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Display.<>f__mg$cache1);
		if (Lua_UnityEngine_Display.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Display.SetRenderingResolution);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Display.<>f__mg$cache2);
		if (Lua_UnityEngine_Display.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Display.RelativeMouseAt_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Display.<>f__mg$cache3);
		string name = "displays";
		if (Lua_UnityEngine_Display.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Display.get_displays);
		}
		LuaCSFunction get = Lua_UnityEngine_Display.<>f__mg$cache4;
		if (Lua_UnityEngine_Display.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Display.set_displays);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Display.<>f__mg$cache5, false);
		string name2 = "renderingWidth";
		if (Lua_UnityEngine_Display.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Display.get_renderingWidth);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Display.<>f__mg$cache6, null, true);
		string name3 = "renderingHeight";
		if (Lua_UnityEngine_Display.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Display.get_renderingHeight);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Display.<>f__mg$cache7, null, true);
		string name4 = "systemWidth";
		if (Lua_UnityEngine_Display.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Display.get_systemWidth);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Display.<>f__mg$cache8, null, true);
		string name5 = "systemHeight";
		if (Lua_UnityEngine_Display.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Display.get_systemHeight);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Display.<>f__mg$cache9, null, true);
		string name6 = "colorBuffer";
		if (Lua_UnityEngine_Display.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Display.get_colorBuffer);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Display.<>f__mg$cacheA, null, true);
		string name7 = "depthBuffer";
		if (Lua_UnityEngine_Display.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Display.get_depthBuffer);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Display.<>f__mg$cacheB, null, true);
		string name8 = "active";
		if (Lua_UnityEngine_Display.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Display.get_active);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Display.<>f__mg$cacheC, null, true);
		string name9 = "main";
		if (Lua_UnityEngine_Display.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Display.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Display.get_main);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Display.<>f__mg$cacheD, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(Display));
	}

	// Token: 0x04018FB1 RID: 102321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018FB2 RID: 102322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018FB3 RID: 102323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018FB4 RID: 102324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018FB5 RID: 102325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018FB6 RID: 102326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018FB7 RID: 102327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018FB8 RID: 102328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018FB9 RID: 102329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018FBA RID: 102330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018FBB RID: 102331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018FBC RID: 102332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018FBD RID: 102333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018FBE RID: 102334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
