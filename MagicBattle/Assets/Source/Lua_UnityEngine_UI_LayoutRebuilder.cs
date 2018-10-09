using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001848 RID: 6216
[Preserve]
public class Lua_UnityEngine_UI_LayoutRebuilder : LuaObject
{
	// Token: 0x06024195 RID: 147861 RVA: 0x00CACDA4 File Offset: 0x00CAAFA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LayoutRebuilder o = new LayoutRebuilder();
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

	// Token: 0x06024196 RID: 147862 RVA: 0x00CACDEC File Offset: 0x00CAAFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDestroyed(IntPtr l)
	{
		int result;
		try
		{
			LayoutRebuilder layoutRebuilder = (LayoutRebuilder)LuaObject.checkSelf(l);
			bool b = layoutRebuilder.IsDestroyed();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024197 RID: 147863 RVA: 0x00CACE40 File Offset: 0x00CAB040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Rebuild(IntPtr l)
	{
		int result;
		try
		{
			LayoutRebuilder layoutRebuilder = (LayoutRebuilder)LuaObject.checkSelf(l);
			CanvasUpdate executing;
			LuaObject.checkEnum<CanvasUpdate>(l, 2, out executing);
			layoutRebuilder.Rebuild(executing);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024198 RID: 147864 RVA: 0x00CACE98 File Offset: 0x00CAB098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LayoutComplete(IntPtr l)
	{
		int result;
		try
		{
			LayoutRebuilder layoutRebuilder = (LayoutRebuilder)LuaObject.checkSelf(l);
			layoutRebuilder.LayoutComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06024199 RID: 147865 RVA: 0x00CACEE4 File Offset: 0x00CAB0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GraphicUpdateComplete(IntPtr l)
	{
		int result;
		try
		{
			LayoutRebuilder layoutRebuilder = (LayoutRebuilder)LuaObject.checkSelf(l);
			layoutRebuilder.GraphicUpdateComplete();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602419A RID: 147866 RVA: 0x00CACF30 File Offset: 0x00CAB130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ForceRebuildLayoutImmediate_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform layoutRoot;
			LuaObject.checkType<RectTransform>(l, 1, out layoutRoot);
			LayoutRebuilder.ForceRebuildLayoutImmediate(layoutRoot);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602419B RID: 147867 RVA: 0x00CACF7C File Offset: 0x00CAB17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MarkLayoutForRebuild_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			LayoutRebuilder.MarkLayoutForRebuild(rect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602419C RID: 147868 RVA: 0x00CACFC8 File Offset: 0x00CAB1C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_transform(IntPtr l)
	{
		int result;
		try
		{
			LayoutRebuilder layoutRebuilder = (LayoutRebuilder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, layoutRebuilder.transform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602419D RID: 147869 RVA: 0x00CAD01C File Offset: 0x00CAB21C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.LayoutRebuilder");
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.IsDestroyed);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.Rebuild);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.LayoutComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.GraphicUpdateComplete);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.ForceRebuildLayoutImmediate_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.MarkLayoutForRebuild_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache5);
		string name = "transform";
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.get_transform);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache6, null, true);
		if (Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_LayoutRebuilder.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_LayoutRebuilder.<>f__mg$cache7, typeof(LayoutRebuilder));
	}

	// Token: 0x04019D63 RID: 105827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D64 RID: 105828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D65 RID: 105829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D66 RID: 105830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D67 RID: 105831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D68 RID: 105832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D69 RID: 105833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D6A RID: 105834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
