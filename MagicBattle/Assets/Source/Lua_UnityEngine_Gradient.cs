using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D7 RID: 5847
[Preserve]
public class Lua_UnityEngine_Gradient : LuaObject
{
	// Token: 0x060232C0 RID: 144064 RVA: 0x00C30720 File Offset: 0x00C2E920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Gradient o = new Gradient();
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

	// Token: 0x060232C1 RID: 144065 RVA: 0x00C30768 File Offset: 0x00C2E968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Evaluate(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			float time;
			LuaObject.checkType(l, 2, out time);
			Color o = gradient.Evaluate(time);
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

	// Token: 0x060232C2 RID: 144066 RVA: 0x00C307CC File Offset: 0x00C2E9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetKeys(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			GradientColorKey[] colorKeys;
			LuaObject.checkArray<GradientColorKey>(l, 2, out colorKeys);
			GradientAlphaKey[] alphaKeys;
			LuaObject.checkArray<GradientAlphaKey>(l, 3, out alphaKeys);
			gradient.SetKeys(colorKeys, alphaKeys);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C3 RID: 144067 RVA: 0x00C30830 File Offset: 0x00C2EA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_colorKeys(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradient.colorKeys);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C4 RID: 144068 RVA: 0x00C30884 File Offset: 0x00C2EA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_colorKeys(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			GradientColorKey[] colorKeys;
			LuaObject.checkArray<GradientColorKey>(l, 2, out colorKeys);
			gradient.colorKeys = colorKeys;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C5 RID: 144069 RVA: 0x00C308DC File Offset: 0x00C2EADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alphaKeys(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradient.alphaKeys);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C6 RID: 144070 RVA: 0x00C30930 File Offset: 0x00C2EB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alphaKeys(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			GradientAlphaKey[] alphaKeys;
			LuaObject.checkArray<GradientAlphaKey>(l, 2, out alphaKeys);
			gradient.alphaKeys = alphaKeys;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C7 RID: 144071 RVA: 0x00C30988 File Offset: 0x00C2EB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_mode(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)gradient.mode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C8 RID: 144072 RVA: 0x00C309DC File Offset: 0x00C2EBDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_mode(IntPtr l)
	{
		int result;
		try
		{
			Gradient gradient = (Gradient)LuaObject.checkSelf(l);
			GradientMode mode;
			LuaObject.checkEnum<GradientMode>(l, 2, out mode);
			gradient.mode = mode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232C9 RID: 144073 RVA: 0x00C30A34 File Offset: 0x00C2EC34
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Gradient");
		if (Lua_UnityEngine_Gradient.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Gradient.Evaluate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Gradient.<>f__mg$cache0);
		if (Lua_UnityEngine_Gradient.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Gradient.SetKeys);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Gradient.<>f__mg$cache1);
		string name = "colorKeys";
		if (Lua_UnityEngine_Gradient.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Gradient.get_colorKeys);
		}
		LuaCSFunction get = Lua_UnityEngine_Gradient.<>f__mg$cache2;
		if (Lua_UnityEngine_Gradient.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Gradient.set_colorKeys);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Gradient.<>f__mg$cache3, true);
		string name2 = "alphaKeys";
		if (Lua_UnityEngine_Gradient.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Gradient.get_alphaKeys);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Gradient.<>f__mg$cache4;
		if (Lua_UnityEngine_Gradient.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Gradient.set_alphaKeys);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Gradient.<>f__mg$cache5, true);
		string name3 = "mode";
		if (Lua_UnityEngine_Gradient.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Gradient.get_mode);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Gradient.<>f__mg$cache6;
		if (Lua_UnityEngine_Gradient.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Gradient.set_mode);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Gradient.<>f__mg$cache7, true);
		if (Lua_UnityEngine_Gradient.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Gradient.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Gradient.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Gradient.<>f__mg$cache8, typeof(Gradient));
	}

	// Token: 0x04019170 RID: 102768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019171 RID: 102769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019172 RID: 102770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019173 RID: 102771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019174 RID: 102772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019175 RID: 102773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019176 RID: 102774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019177 RID: 102775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019178 RID: 102776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
