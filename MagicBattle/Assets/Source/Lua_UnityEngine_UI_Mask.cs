using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200184A RID: 6218
[Preserve]
public class Lua_UnityEngine_UI_Mask : LuaObject
{
	// Token: 0x060241AB RID: 147883 RVA: 0x00CAD6FC File Offset: 0x00CAB8FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MaskEnabled(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			bool b = mask.MaskEnabled();
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

	// Token: 0x060241AC RID: 147884 RVA: 0x00CAD750 File Offset: 0x00CAB950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsRaycastLocationValid(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			Vector2 sp;
			LuaObject.checkType(l, 2, out sp);
			Camera eventCamera;
			LuaObject.checkType<Camera>(l, 3, out eventCamera);
			bool b = mask.IsRaycastLocationValid(sp, eventCamera);
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

	// Token: 0x060241AD RID: 147885 RVA: 0x00CAD7C0 File Offset: 0x00CAB9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetModifiedMaterial(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			Material baseMaterial;
			LuaObject.checkType<Material>(l, 2, out baseMaterial);
			Material modifiedMaterial = mask.GetModifiedMaterial(baseMaterial);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, modifiedMaterial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241AE RID: 147886 RVA: 0x00CAD824 File Offset: 0x00CABA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rectTransform(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mask.rectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241AF RID: 147887 RVA: 0x00CAD878 File Offset: 0x00CABA78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_showMaskGraphic(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mask.showMaskGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B0 RID: 147888 RVA: 0x00CAD8CC File Offset: 0x00CABACC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_showMaskGraphic(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			bool showMaskGraphic;
			LuaObject.checkType(l, 2, out showMaskGraphic);
			mask.showMaskGraphic = showMaskGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B1 RID: 147889 RVA: 0x00CAD924 File Offset: 0x00CABB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_graphic(IntPtr l)
	{
		int result;
		try
		{
			Mask mask = (Mask)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, mask.graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B2 RID: 147890 RVA: 0x00CAD978 File Offset: 0x00CABB78
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.Mask");
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.MaskEnabled);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Mask.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.IsRaycastLocationValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Mask.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.GetModifiedMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_Mask.<>f__mg$cache2);
		string name = "rectTransform";
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.get_rectTransform);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_Mask.<>f__mg$cache3, null, true);
		string name2 = "showMaskGraphic";
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.get_showMaskGraphic);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_Mask.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.set_showMaskGraphic);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_UI_Mask.<>f__mg$cache5, true);
		string name3 = "graphic";
		if (Lua_UnityEngine_UI_Mask.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_Mask.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_Mask.get_graphic);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_UI_Mask.<>f__mg$cache6, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Mask), typeof(UIBehaviour));
	}

	// Token: 0x04019D75 RID: 105845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D76 RID: 105846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D77 RID: 105847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D78 RID: 105848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D79 RID: 105849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D7A RID: 105850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D7B RID: 105851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
