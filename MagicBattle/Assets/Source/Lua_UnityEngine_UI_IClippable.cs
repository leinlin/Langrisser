using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200182D RID: 6189
[Preserve]
public class Lua_UnityEngine_UI_IClippable : LuaObject
{
	// Token: 0x060240B5 RID: 147637 RVA: 0x00CA75E8 File Offset: 0x00CA57E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RecalculateClipping(IntPtr l)
	{
		int result;
		try
		{
			IClippable clippable = (IClippable)LuaObject.checkSelf(l);
			clippable.RecalculateClipping();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B6 RID: 147638 RVA: 0x00CA7634 File Offset: 0x00CA5834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Cull(IntPtr l)
	{
		int result;
		try
		{
			IClippable clippable = (IClippable)LuaObject.checkSelf(l);
			Rect clipRect;
			LuaObject.checkValueType<Rect>(l, 2, out clipRect);
			bool validRect;
			LuaObject.checkType(l, 3, out validRect);
			clippable.Cull(clipRect, validRect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B7 RID: 147639 RVA: 0x00CA7698 File Offset: 0x00CA5898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetClipRect(IntPtr l)
	{
		int result;
		try
		{
			IClippable clippable = (IClippable)LuaObject.checkSelf(l);
			Rect value;
			LuaObject.checkValueType<Rect>(l, 2, out value);
			bool validRect;
			LuaObject.checkType(l, 3, out validRect);
			clippable.SetClipRect(value, validRect);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B8 RID: 147640 RVA: 0x00CA76FC File Offset: 0x00CA58FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			IClippable clippable = (IClippable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clippable.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240B9 RID: 147641 RVA: 0x00CA7750 File Offset: 0x00CA5950
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rectTransform(IntPtr l)
	{
		int result;
		try
		{
			IClippable clippable = (IClippable)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, clippable.rectTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060240BA RID: 147642 RVA: 0x00CA77A4 File Offset: 0x00CA59A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.IClippable");
		if (Lua_UnityEngine_UI_IClippable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_IClippable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_IClippable.RecalculateClipping);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IClippable.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_IClippable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_IClippable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_IClippable.Cull);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IClippable.<>f__mg$cache1);
		if (Lua_UnityEngine_UI_IClippable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_IClippable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_IClippable.SetClipRect);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_IClippable.<>f__mg$cache2);
		string name = "gameObject";
		if (Lua_UnityEngine_UI_IClippable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_IClippable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_IClippable.get_gameObject);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_UI_IClippable.<>f__mg$cache3, null, true);
		string name2 = "rectTransform";
		if (Lua_UnityEngine_UI_IClippable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_IClippable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_IClippable.get_rectTransform);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_UI_IClippable.<>f__mg$cache4, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(IClippable));
	}

	// Token: 0x04019CB9 RID: 105657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019CBA RID: 105658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019CBB RID: 105659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019CBC RID: 105660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019CBD RID: 105661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
