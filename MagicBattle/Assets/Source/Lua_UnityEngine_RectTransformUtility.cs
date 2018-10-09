using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001773 RID: 6003
[Preserve]
public class Lua_UnityEngine_RectTransformUtility : LuaObject
{
	// Token: 0x060239E7 RID: 145895 RVA: 0x00C72830 File Offset: 0x00C70A30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RectangleContainsScreenPoint_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 2)
			{
				RectTransform rect;
				LuaObject.checkType<RectTransform>(l, 1, out rect);
				Vector2 screenPoint;
				LuaObject.checkType(l, 2, out screenPoint);
				bool b = RectTransformUtility.RectangleContainsScreenPoint(rect, screenPoint);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b);
				result = 2;
			}
			else if (num == 3)
			{
				RectTransform rect2;
				LuaObject.checkType<RectTransform>(l, 1, out rect2);
				Vector2 screenPoint2;
				LuaObject.checkType(l, 2, out screenPoint2);
				Camera cam;
				LuaObject.checkType<Camera>(l, 3, out cam);
				bool b2 = RectTransformUtility.RectangleContainsScreenPoint(rect2, screenPoint2, cam);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, b2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function RectangleContainsScreenPoint to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239E8 RID: 145896 RVA: 0x00C72904 File Offset: 0x00C70B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PixelAdjustPoint_s(IntPtr l)
	{
		int result;
		try
		{
			Vector2 point;
			LuaObject.checkType(l, 1, out point);
			Transform elementTransform;
			LuaObject.checkType<Transform>(l, 2, out elementTransform);
			Canvas canvas;
			LuaObject.checkType<Canvas>(l, 3, out canvas);
			Vector2 o = RectTransformUtility.PixelAdjustPoint(point, elementTransform, canvas);
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

	// Token: 0x060239E9 RID: 145897 RVA: 0x00C72974 File Offset: 0x00C70B74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PixelAdjustRect_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rectTransform;
			LuaObject.checkType<RectTransform>(l, 1, out rectTransform);
			Canvas canvas;
			LuaObject.checkType<Canvas>(l, 2, out canvas);
			Rect rect = RectTransformUtility.PixelAdjustRect(rectTransform, canvas);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239EA RID: 145898 RVA: 0x00C729D8 File Offset: 0x00C70BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPointToWorldPointInRectangle_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			Vector2 screenPoint;
			LuaObject.checkType(l, 2, out screenPoint);
			Camera cam;
			LuaObject.checkType<Camera>(l, 3, out cam);
			Vector3 o;
			bool b = RectTransformUtility.ScreenPointToWorldPointInRectangle(rect, screenPoint, cam, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239EB RID: 145899 RVA: 0x00C72A50 File Offset: 0x00C70C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ScreenPointToLocalPointInRectangle_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			Vector2 screenPoint;
			LuaObject.checkType(l, 2, out screenPoint);
			Camera cam;
			LuaObject.checkType<Camera>(l, 3, out cam);
			Vector2 o;
			bool b = RectTransformUtility.ScreenPointToLocalPointInRectangle(rect, screenPoint, cam, out o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			LuaObject.pushValue(l, o);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239EC RID: 145900 RVA: 0x00C72AC8 File Offset: 0x00C70CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ScreenPointToRay_s(IntPtr l)
	{
		int result;
		try
		{
			Camera cam;
			LuaObject.checkType<Camera>(l, 1, out cam);
			Vector2 screenPos;
			LuaObject.checkType(l, 2, out screenPos);
			Ray ray = RectTransformUtility.ScreenPointToRay(cam, screenPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ray);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239ED RID: 145901 RVA: 0x00C72B2C File Offset: 0x00C70D2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int WorldToScreenPoint_s(IntPtr l)
	{
		int result;
		try
		{
			Camera cam;
			LuaObject.checkType<Camera>(l, 1, out cam);
			Vector3 worldPoint;
			LuaObject.checkType(l, 2, out worldPoint);
			Vector2 o = RectTransformUtility.WorldToScreenPoint(cam, worldPoint);
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

	// Token: 0x060239EE RID: 145902 RVA: 0x00C72B8C File Offset: 0x00C70D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateRelativeRectTransformBounds_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				Transform trans;
				LuaObject.checkType<Transform>(l, 1, out trans);
				Bounds bounds = RectTransformUtility.CalculateRelativeRectTransformBounds(trans);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, bounds);
				result = 2;
			}
			else if (num == 2)
			{
				Transform root;
				LuaObject.checkType<Transform>(l, 1, out root);
				Transform child;
				LuaObject.checkType<Transform>(l, 2, out child);
				Bounds bounds2 = RectTransformUtility.CalculateRelativeRectTransformBounds(root, child);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, bounds2);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function CalculateRelativeRectTransformBounds to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239EF RID: 145903 RVA: 0x00C72C50 File Offset: 0x00C70E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FlipLayoutOnAxis_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			int axis;
			LuaObject.checkType(l, 2, out axis);
			bool keepPositioning;
			LuaObject.checkType(l, 3, out keepPositioning);
			bool recursive;
			LuaObject.checkType(l, 4, out recursive);
			RectTransformUtility.FlipLayoutOnAxis(rect, axis, keepPositioning, recursive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F0 RID: 145904 RVA: 0x00C72CC0 File Offset: 0x00C70EC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FlipLayoutAxes_s(IntPtr l)
	{
		int result;
		try
		{
			RectTransform rect;
			LuaObject.checkType<RectTransform>(l, 1, out rect);
			bool keepPositioning;
			LuaObject.checkType(l, 2, out keepPositioning);
			bool recursive;
			LuaObject.checkType(l, 3, out recursive);
			RectTransformUtility.FlipLayoutAxes(rect, keepPositioning, recursive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060239F1 RID: 145905 RVA: 0x00C72D24 File Offset: 0x00C70F24
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.RectTransformUtility");
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.RectangleContainsScreenPoint_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache0);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.PixelAdjustPoint_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache1);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.PixelAdjustRect_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache2);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.ScreenPointToWorldPointInRectangle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache3);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.ScreenPointToLocalPointInRectangle_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache4);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.ScreenPointToRay_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache5);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.WorldToScreenPoint_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache6);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.CalculateRelativeRectTransformBounds_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache7);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.FlipLayoutOnAxis_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache8);
		if (Lua_UnityEngine_RectTransformUtility.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_RectTransformUtility.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_RectTransformUtility.FlipLayoutAxes_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_RectTransformUtility.<>f__mg$cache9);
		LuaObject.createTypeMetatable(l, null, typeof(RectTransformUtility));
	}

	// Token: 0x0401975F RID: 104287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019760 RID: 104288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019761 RID: 104289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019762 RID: 104290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019763 RID: 104291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019764 RID: 104292
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019765 RID: 104293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019766 RID: 104294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019767 RID: 104295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019768 RID: 104296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
