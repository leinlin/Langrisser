using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001853 RID: 6227
[Preserve]
public class Lua_UnityEngine_UI_RectMask2D : LuaObject
{
	// Token: 0x060241EA RID: 147946 RVA: 0x00CAEED0 File Offset: 0x00CAD0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaycastLocationValid(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D rectMask2D = (RectMask2D)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			Camera eventCamera;
			LuaObject.checkType<Camera>(l, 3, out eventCamera);
			bool b = rectMask2D.IsRaycastLocationValid(sp, eventCamera);
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

	// Token: 0x060241EB RID: 147947 RVA: 0x00CAEF40 File Offset: 0x00CAD140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PerformClipping(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D rectMask2D = (RectMask2D)LuaObject.checkSelf(l);
			rectMask2D.PerformClipping();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241EC RID: 147948 RVA: 0x00CAEF8C File Offset: 0x00CAD18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddClippable(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D rectMask2D = (RectMask2D)LuaObject.checkSelf(l);
			IClippable clippable;
			LuaObject.checkType<IClippable>(l, 2, out clippable);
			rectMask2D.AddClippable(clippable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241ED RID: 147949 RVA: 0x00CAEFE4 File Offset: 0x00CAD1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveClippable(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D rectMask2D = (RectMask2D)LuaObject.checkSelf(l);
			IClippable clippable;
			LuaObject.checkType<IClippable>(l, 2, out clippable);
			rectMask2D.RemoveClippable(clippable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241EE RID: 147950 RVA: 0x00CAF03C File Offset: 0x00CAD23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_canvasRect(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D rectMask2D = (RectMask2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectMask2D.canvasRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241EF RID: 147951 RVA: 0x00CAF094 File Offset: 0x00CAD294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_rectTransform(IntPtr l)
	{
		int result;
		try
		{
			RectMask2D rectMask2D = (RectMask2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rectMask2D.rectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241F0 RID: 147952 RVA: 0x00CAF0E8 File Offset: 0x00CAD2E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.RectMask2D");
		if (Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_RectMask2D.IsRaycastLocationValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_RectMask2D.PerformClipping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_RectMask2D.AddClippable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_RectMask2D.RemoveClippable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache3);
		string name = "canvasRect";
		if (Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_RectMask2D.get_canvasRect);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache4, null, true);
		string name2 = "rectTransform";
		if (Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_RectMask2D.get_rectTransform);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_UI_RectMask2D.<>f__mg$cache5, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(RectMask2D), typeof(UIBehaviour));
	}

	// Token: 0x04019DA2 RID: 105890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019DA3 RID: 105891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019DA4 RID: 105892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019DA5 RID: 105893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019DA6 RID: 105894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019DA7 RID: 105895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
