using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200184B RID: 6219
[Preserve]
public class Lua_UnityEngine_UI_MaskableGraphic : LuaObject
{
	// Token: 0x060241B4 RID: 147892 RVA: 0x00CADAB8 File Offset: 0x00CABCB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetModifiedMaterial(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			Material baseMaterial;
			LuaObject.checkType<Material>(l, 2, out baseMaterial);
			Material modifiedMaterial = maskableGraphic.GetModifiedMaterial(baseMaterial);
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

	// Token: 0x060241B5 RID: 147893 RVA: 0x00CADB1C File Offset: 0x00CABD1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cull(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			Rect clipRect;
			LuaObject.checkValueType<Rect>(l, 2, out clipRect);
			bool validRect;
			LuaObject.checkType(l, 3, out validRect);
			maskableGraphic.Cull(clipRect, validRect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B6 RID: 147894 RVA: 0x00CADB80 File Offset: 0x00CABD80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClipRect(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			Rect clipRect;
			LuaObject.checkValueType<Rect>(l, 2, out clipRect);
			bool validRect;
			LuaObject.checkType(l, 3, out validRect);
			maskableGraphic.SetClipRect(clipRect, validRect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B7 RID: 147895 RVA: 0x00CADBE4 File Offset: 0x00CABDE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RecalculateClipping(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			maskableGraphic.RecalculateClipping();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B8 RID: 147896 RVA: 0x00CADC30 File Offset: 0x00CABE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RecalculateMasking(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			maskableGraphic.RecalculateMasking();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241B9 RID: 147897 RVA: 0x00CADC7C File Offset: 0x00CABE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_onCullStateChanged(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, maskableGraphic.onCullStateChanged);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241BA RID: 147898 RVA: 0x00CADCD0 File Offset: 0x00CABED0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_onCullStateChanged(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			MaskableGraphic.CullStateChangedEvent onCullStateChanged;
			LuaObject.checkType<MaskableGraphic.CullStateChangedEvent>(l, 2, out onCullStateChanged);
			maskableGraphic.onCullStateChanged = onCullStateChanged;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241BB RID: 147899 RVA: 0x00CADD28 File Offset: 0x00CABF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maskable(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, maskableGraphic.maskable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241BC RID: 147900 RVA: 0x00CADD7C File Offset: 0x00CABF7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maskable(IntPtr l)
	{
		int result;
		try
		{
			MaskableGraphic maskableGraphic = (MaskableGraphic)LuaObject.checkSelf(l);
			bool maskable;
			LuaObject.checkType(l, 2, out maskable);
			maskableGraphic.maskable = maskable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060241BD RID: 147901 RVA: 0x00CADDD4 File Offset: 0x00CABFD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.MaskableGraphic");
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.GetModifiedMaterial);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.Cull);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.SetClipRect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache2);
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.RecalculateClipping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache3);
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.RecalculateMasking);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache4);
		string name = "onCullStateChanged";
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.get_onCullStateChanged);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache5;
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.set_onCullStateChanged);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache6, true);
		string name2 = "maskable";
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.get_maskable);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache7;
		if (Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_UI_MaskableGraphic.set_maskable);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_MaskableGraphic.<>f__mg$cache8, true);
		LuaObject.createTypeMetatable(l, null, typeof(MaskableGraphic), typeof(Graphic));
	}

	// Token: 0x04019D7C RID: 105852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019D7D RID: 105853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019D7E RID: 105854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019D7F RID: 105855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019D80 RID: 105856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019D81 RID: 105857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019D82 RID: 105858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019D83 RID: 105859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019D84 RID: 105860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
