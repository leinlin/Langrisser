using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200180A RID: 6154
[Preserve]
public class Lua_UnityEngine_UI_AspectRatioFitter : LuaObject
{
	// Token: 0x06023F84 RID: 147332 RVA: 0x00C9FC20 File Offset: 0x00C9DE20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLayoutHorizontal(IntPtr l)
	{
		int result;
		try
		{
			AspectRatioFitter aspectRatioFitter = (AspectRatioFitter)LuaObject.checkSelf(l);
			aspectRatioFitter.SetLayoutHorizontal();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F85 RID: 147333 RVA: 0x00C9FC6C File Offset: 0x00C9DE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayoutVertical(IntPtr l)
	{
		int result;
		try
		{
			AspectRatioFitter aspectRatioFitter = (AspectRatioFitter)LuaObject.checkSelf(l);
			aspectRatioFitter.SetLayoutVertical();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F86 RID: 147334 RVA: 0x00C9FCB8 File Offset: 0x00C9DEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_aspectMode(IntPtr l)
	{
		int result;
		try
		{
			AspectRatioFitter aspectRatioFitter = (AspectRatioFitter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)aspectRatioFitter.aspectMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F87 RID: 147335 RVA: 0x00C9FD0C File Offset: 0x00C9DF0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_aspectMode(IntPtr l)
	{
		int result;
		try
		{
			AspectRatioFitter aspectRatioFitter = (AspectRatioFitter)LuaObject.checkSelf(l);
			AspectRatioFitter.AspectMode aspectMode;
			LuaObject.checkEnum<AspectRatioFitter.AspectMode>(l, 2, out aspectMode);
			aspectRatioFitter.aspectMode = aspectMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F88 RID: 147336 RVA: 0x00C9FD64 File Offset: 0x00C9DF64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_aspectRatio(IntPtr l)
	{
		int result;
		try
		{
			AspectRatioFitter aspectRatioFitter = (AspectRatioFitter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, aspectRatioFitter.aspectRatio);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F89 RID: 147337 RVA: 0x00C9FDB8 File Offset: 0x00C9DFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_aspectRatio(IntPtr l)
	{
		int result;
		try
		{
			AspectRatioFitter aspectRatioFitter = (AspectRatioFitter)LuaObject.checkSelf(l);
			float aspectRatio;
			LuaObject.checkType(l, 2, out aspectRatio);
			aspectRatioFitter.aspectRatio = aspectRatio;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023F8A RID: 147338 RVA: 0x00C9FE10 File Offset: 0x00C9E010
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.UI.AspectRatioFitter");
		if (Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_UI_AspectRatioFitter.SetLayoutHorizontal);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache0);
		if (Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_UI_AspectRatioFitter.SetLayoutVertical);
		}
		LuaObject.addMember(l, Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache1);
		string name = "aspectMode";
		if (Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_UI_AspectRatioFitter.get_aspectMode);
		}
		LuaCSFunction get = Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache2;
		if (Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_UI_AspectRatioFitter.set_aspectMode);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache3, true);
		string name2 = "aspectRatio";
		if (Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_UI_AspectRatioFitter.get_aspectRatio);
		}
		LuaCSFunction get2 = Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache4;
		if (Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_UI_AspectRatioFitter.set_aspectRatio);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_UI_AspectRatioFitter.<>f__mg$cache5, true);
		LuaObject.createTypeMetatable(l, null, typeof(AspectRatioFitter), typeof(UIBehaviour));
	}

	// Token: 0x04019BCE RID: 105422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019BCF RID: 105423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019BD0 RID: 105424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019BD1 RID: 105425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019BD2 RID: 105426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019BD3 RID: 105427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
