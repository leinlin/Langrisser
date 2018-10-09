using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D8 RID: 5848
[Preserve]
public class Lua_UnityEngine_GradientAlphaKey : LuaObject
{
	// Token: 0x060232CB RID: 144075 RVA: 0x00C30B9C File Offset: 0x00C2ED9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			float alpha;
			LuaObject.checkType(l, 2, out alpha);
			float time;
			LuaObject.checkType(l, 3, out time);
			GradientAlphaKey gradientAlphaKey = new GradientAlphaKey(alpha, time);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradientAlphaKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232CC RID: 144076 RVA: 0x00C30C04 File Offset: 0x00C2EE04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_alpha(IntPtr l)
	{
		int result;
		try
		{
			GradientAlphaKey gradientAlphaKey;
			LuaObject.checkValueType<GradientAlphaKey>(l, 1, out gradientAlphaKey);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradientAlphaKey.alpha);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232CD RID: 144077 RVA: 0x00C30C58 File Offset: 0x00C2EE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_alpha(IntPtr l)
	{
		int result;
		try
		{
			GradientAlphaKey gradientAlphaKey;
			LuaObject.checkValueType<GradientAlphaKey>(l, 1, out gradientAlphaKey);
			float alpha;
			LuaObject.checkType(l, 2, out alpha);
			gradientAlphaKey.alpha = alpha;
			LuaObject.setBack(l, gradientAlphaKey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232CE RID: 144078 RVA: 0x00C30CBC File Offset: 0x00C2EEBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			GradientAlphaKey gradientAlphaKey;
			LuaObject.checkValueType<GradientAlphaKey>(l, 1, out gradientAlphaKey);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gradientAlphaKey.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232CF RID: 144079 RVA: 0x00C30D10 File Offset: 0x00C2EF10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_time(IntPtr l)
	{
		int result;
		try
		{
			GradientAlphaKey gradientAlphaKey;
			LuaObject.checkValueType<GradientAlphaKey>(l, 1, out gradientAlphaKey);
			float time;
			LuaObject.checkType(l, 2, out time);
			gradientAlphaKey.time = time;
			LuaObject.setBack(l, gradientAlphaKey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060232D0 RID: 144080 RVA: 0x00C30D74 File Offset: 0x00C2EF74
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.GradientAlphaKey");
		string name = "alpha";
		if (Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_GradientAlphaKey.get_alpha);
		}
		LuaCSFunction get = Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache0;
		if (Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_GradientAlphaKey.set_alpha);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache1, true);
		string name2 = "time";
		if (Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_GradientAlphaKey.get_time);
		}
		LuaCSFunction get2 = Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache2;
		if (Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_GradientAlphaKey.set_time);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache3, true);
		if (Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_GradientAlphaKey.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_GradientAlphaKey.<>f__mg$cache4, typeof(GradientAlphaKey), typeof(ValueType));
	}

	// Token: 0x04019179 RID: 102777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401917A RID: 102778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401917B RID: 102779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401917C RID: 102780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401917D RID: 102781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
