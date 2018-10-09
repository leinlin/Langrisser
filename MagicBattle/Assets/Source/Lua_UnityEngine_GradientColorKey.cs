using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D9 RID: 5849
[Preserve]
public class Lua_UnityEngine_GradientColorKey : LuaObject
{
	// Token: 0x060232D2 RID: 144082 RVA: 0x00C30E58 File Offset: 0x00C2F058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Color col;
			LuaObject.checkType(l, 2, out col);
			float time;
			LuaObject.checkType(l, 3, out time);
			GradientColorKey gradientColorKey = new GradientColorKey(col, time);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradientColorKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232D3 RID: 144083 RVA: 0x00C30EC0 File Offset: 0x00C2F0C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_color(IntPtr l)
	{
		int result;
		try
		{
			GradientColorKey gradientColorKey;
			LuaObject.checkValueType<GradientColorKey>(l, 1, out gradientColorKey);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradientColorKey.color);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232D4 RID: 144084 RVA: 0x00C30F14 File Offset: 0x00C2F114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_color(IntPtr l)
	{
		int result;
		try
		{
			GradientColorKey gradientColorKey;
			LuaObject.checkValueType<GradientColorKey>(l, 1, out gradientColorKey);
			Color color;
			LuaObject.checkType(l, 2, out color);
			gradientColorKey.color = color;
			LuaObject.setBack(l, gradientColorKey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232D5 RID: 144085 RVA: 0x00C30F78 File Offset: 0x00C2F178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			GradientColorKey gradientColorKey;
			LuaObject.checkValueType<GradientColorKey>(l, 1, out gradientColorKey);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradientColorKey.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232D6 RID: 144086 RVA: 0x00C30FCC File Offset: 0x00C2F1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_time(IntPtr l)
	{
		int result;
		try
		{
			GradientColorKey gradientColorKey;
			LuaObject.checkValueType<GradientColorKey>(l, 1, out gradientColorKey);
			float time;
			LuaObject.checkType(l, 2, out time);
			gradientColorKey.time = time;
			LuaObject.setBack(l, gradientColorKey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232D7 RID: 144087 RVA: 0x00C31030 File Offset: 0x00C2F230
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.GradientColorKey");
		string name = "color";
		if (Lua_UnityEngine_GradientColorKey.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_GradientColorKey.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_GradientColorKey.get_color);
		}
		LuaCSFunction get = Lua_UnityEngine_GradientColorKey.<>f__mg$cache0;
		if (Lua_UnityEngine_GradientColorKey.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_GradientColorKey.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_GradientColorKey.set_color);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_GradientColorKey.<>f__mg$cache1, true);
		string name2 = "time";
		if (Lua_UnityEngine_GradientColorKey.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_GradientColorKey.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_GradientColorKey.get_time);
		}
		LuaCSFunction get2 = Lua_UnityEngine_GradientColorKey.<>f__mg$cache2;
		if (Lua_UnityEngine_GradientColorKey.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_GradientColorKey.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_GradientColorKey.set_time);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_GradientColorKey.<>f__mg$cache3, true);
		if (Lua_UnityEngine_GradientColorKey.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_GradientColorKey.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_GradientColorKey.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_GradientColorKey.<>f__mg$cache4, typeof(GradientColorKey), typeof(ValueType));
	}

	// Token: 0x0401917E RID: 102782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401917F RID: 102783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019180 RID: 102784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019181 RID: 102785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019182 RID: 102786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
