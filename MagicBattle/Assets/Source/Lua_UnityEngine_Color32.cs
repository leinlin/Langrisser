using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001666 RID: 5734
[Preserve]
public class Lua_UnityEngine_Color32 : LuaObject
{
	// Token: 0x06022EC6 RID: 143046 RVA: 0x00C14170 File Offset: 0x00C12370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			byte r;
			LuaObject.checkType(l, 2, out r);
			byte g;
			LuaObject.checkType(l, 3, out g);
			byte b;
			LuaObject.checkType(l, 4, out b);
			byte a;
			LuaObject.checkType(l, 5, out a);
			Color32 c = new Color32(r, g, b, a);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, c);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC7 RID: 143047 RVA: 0x00C141EC File Offset: 0x00C123EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Lerp_s(IntPtr l)
	{
		int result;
		try
		{
			Color32 a;
			LuaObject.checkValueType<Color32>(l, 1, out a);
			Color32 b;
			LuaObject.checkValueType<Color32>(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Color32 c = Color32.Lerp(a, b, t);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, c);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC8 RID: 143048 RVA: 0x00C1425C File Offset: 0x00C1245C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int LerpUnclamped_s(IntPtr l)
	{
		int result;
		try
		{
			Color32 a;
			LuaObject.checkValueType<Color32>(l, 1, out a);
			Color32 b;
			LuaObject.checkValueType<Color32>(l, 2, out b);
			float t;
			LuaObject.checkType(l, 3, out t);
			Color32 c = Color32.LerpUnclamped(a, b, t);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, c);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022EC9 RID: 143049 RVA: 0x00C142CC File Offset: 0x00C124CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_r(IntPtr l)
	{
		int result;
		try
		{
			Color32 color;
			LuaObject.checkValueType<Color32>(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.r);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ECA RID: 143050 RVA: 0x00C14320 File Offset: 0x00C12520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_r(IntPtr l)
	{
		int result;
		try
		{
			Color32 c;
			LuaObject.checkValueType<Color32>(l, 1, out c);
			byte r;
			LuaObject.checkType(l, 2, out r);
			c.r = r;
			LuaObject.setBack(l, c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ECB RID: 143051 RVA: 0x00C14384 File Offset: 0x00C12584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_g(IntPtr l)
	{
		int result;
		try
		{
			Color32 color;
			LuaObject.checkValueType<Color32>(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.g);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ECC RID: 143052 RVA: 0x00C143D8 File Offset: 0x00C125D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_g(IntPtr l)
	{
		int result;
		try
		{
			Color32 c;
			LuaObject.checkValueType<Color32>(l, 1, out c);
			byte g;
			LuaObject.checkType(l, 2, out g);
			c.g = g;
			LuaObject.setBack(l, c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ECD RID: 143053 RVA: 0x00C1443C File Offset: 0x00C1263C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_b(IntPtr l)
	{
		int result;
		try
		{
			Color32 color;
			LuaObject.checkValueType<Color32>(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ECE RID: 143054 RVA: 0x00C14490 File Offset: 0x00C12690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_b(IntPtr l)
	{
		int result;
		try
		{
			Color32 c;
			LuaObject.checkValueType<Color32>(l, 1, out c);
			byte b;
			LuaObject.checkType(l, 2, out b);
			c.b = b;
			LuaObject.setBack(l, c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ECF RID: 143055 RVA: 0x00C144F4 File Offset: 0x00C126F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_a(IntPtr l)
	{
		int result;
		try
		{
			Color32 color;
			LuaObject.checkValueType<Color32>(l, 1, out color);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, color.a);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ED0 RID: 143056 RVA: 0x00C14548 File Offset: 0x00C12748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_a(IntPtr l)
	{
		int result;
		try
		{
			Color32 c;
			LuaObject.checkValueType<Color32>(l, 1, out c);
			byte a;
			LuaObject.checkType(l, 2, out a);
			c.a = a;
			LuaObject.setBack(l, c);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022ED1 RID: 143057 RVA: 0x00C145AC File Offset: 0x00C127AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Color32");
		if (Lua_UnityEngine_Color32.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Color32.Lerp_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color32.<>f__mg$cache0);
		if (Lua_UnityEngine_Color32.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Color32.LerpUnclamped_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Color32.<>f__mg$cache1);
		string name = "r";
		if (Lua_UnityEngine_Color32.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Color32.get_r);
		}
		LuaCSFunction get = Lua_UnityEngine_Color32.<>f__mg$cache2;
		if (Lua_UnityEngine_Color32.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Color32.set_r);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_Color32.<>f__mg$cache3, true);
		string name2 = "g";
		if (Lua_UnityEngine_Color32.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Color32.get_g);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Color32.<>f__mg$cache4;
		if (Lua_UnityEngine_Color32.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Color32.set_g);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_Color32.<>f__mg$cache5, true);
		string name3 = "b";
		if (Lua_UnityEngine_Color32.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Color32.get_b);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Color32.<>f__mg$cache6;
		if (Lua_UnityEngine_Color32.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Color32.set_b);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_Color32.<>f__mg$cache7, true);
		string name4 = "a";
		if (Lua_UnityEngine_Color32.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Color32.get_a);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Color32.<>f__mg$cache8;
		if (Lua_UnityEngine_Color32.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Color32.set_a);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_Color32.<>f__mg$cache9, true);
		if (Lua_UnityEngine_Color32.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Color32.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Color32.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Color32.<>f__mg$cacheA, typeof(Color32), typeof(ValueType));
	}

	// Token: 0x04018E58 RID: 101976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018E59 RID: 101977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018E5A RID: 101978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018E5B RID: 101979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018E5C RID: 101980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018E5D RID: 101981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018E5E RID: 101982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018E5F RID: 101983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018E60 RID: 101984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018E61 RID: 101985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018E62 RID: 101986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
