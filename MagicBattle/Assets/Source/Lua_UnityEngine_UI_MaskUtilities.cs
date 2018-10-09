using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200184D RID: 6221
[Preserve]
public class Lua_UnityEngine_UI_MaskUtilities : LuaObject
{
	// Token: 0x060241C2 RID: 147906 RVA: 0x00CADFF4 File Offset: 0x00CAC1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			MaskUtilities o = new MaskUtilities();
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

	// Token: 0x060241C3 RID: 147907 RVA: 0x00CAE03C File Offset: 0x00CAC23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Notify2DMaskStateChanged_s(IntPtr l)
	{
		int result;
		try
		{
			Component mask;
			LuaObject.checkType<Component>(l, 1, out mask);
			MaskUtilities.Notify2DMaskStateChanged(mask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241C4 RID: 147908 RVA: 0x00CAE088 File Offset: 0x00CAC288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int NotifyStencilStateChanged_s(IntPtr l)
	{
		int result;
		try
		{
			Component mask;
			LuaObject.checkType<Component>(l, 1, out mask);
			MaskUtilities.NotifyStencilStateChanged(mask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241C5 RID: 147909 RVA: 0x00CAE0D4 File Offset: 0x00CAC2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindRootSortOverrideCanvas_s(IntPtr l)
	{
		int result;
		try
		{
			Transform start;
			LuaObject.checkType<Transform>(l, 1, out start);
			Transform o = MaskUtilities.FindRootSortOverrideCanvas(start);
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

	// Token: 0x060241C6 RID: 147910 RVA: 0x00CAE128 File Offset: 0x00CAC328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetStencilDepth_s(IntPtr l)
	{
		int result;
		try
		{
			Transform transform;
			LuaObject.checkType<Transform>(l, 1, out transform);
			Transform stopAfter;
			LuaObject.checkType<Transform>(l, 2, out stopAfter);
			int stencilDepth = MaskUtilities.GetStencilDepth(transform, stopAfter);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, stencilDepth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241C7 RID: 147911 RVA: 0x00CAE188 File Offset: 0x00CAC388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDescendantOrSelf_s(IntPtr l)
	{
		int result;
		try
		{
			Transform father;
			LuaObject.checkType<Transform>(l, 1, out father);
			Transform child;
			LuaObject.checkType<Transform>(l, 2, out child);
			bool b = MaskUtilities.IsDescendantOrSelf(father, child);
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

	// Token: 0x060241C8 RID: 147912 RVA: 0x00CAE1E8 File Offset: 0x00CAC3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRectMaskForClippable_s(IntPtr l)
	{
		int result;
		try
		{
			IClippable clippable;
			LuaObject.checkType<IClippable>(l, 1, out clippable);
			RectMask2D rectMaskForClippable = MaskUtilities.GetRectMaskForClippable(clippable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectMaskForClippable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241C9 RID: 147913 RVA: 0x00CAE23C File Offset: 0x00CAC43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRectMasksForClip_s(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D clipper;
			LuaObject.checkType<RectMask2D>(l, 1, out clipper);
			List<RectMask2D> masks;
			LuaObject.checkType<List<RectMask2D>>(l, 2, out masks);
			MaskUtilities.GetRectMasksForClip(clipper, masks);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241CA RID: 147914 RVA: 0x00CAE294 File Offset: 0x00CAC494
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.MaskUtilities");
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.Notify2DMaskStateChanged_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.NotifyStencilStateChanged_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.FindRootSortOverrideCanvas_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.GetStencilDepth_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.IsDescendantOrSelf_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache4);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.GetRectMaskForClippable_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache5);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.GetRectMasksForClip_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache6);
		if (Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_MaskUtilities.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_UI_MaskUtilities.<>f__mg$cache7, typeof(MaskUtilities));
	}

	// Token: 0x04019D86 RID: 105862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D87 RID: 105863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D88 RID: 105864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D89 RID: 105865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D8A RID: 105866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D8B RID: 105867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D8C RID: 105868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D8D RID: 105869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
