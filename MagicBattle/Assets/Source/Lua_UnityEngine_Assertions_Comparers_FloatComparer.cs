using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Assertions.Comparers;
using UnityEngine.Scripting;

// Token: 0x0200162F RID: 5679
[Preserve]
public class Lua_UnityEngine_Assertions_Comparers_FloatComparer : LuaObject
{
	// Token: 0x06022BE1 RID: 142305 RVA: 0x00BFDF24 File Offset: 0x00BFC124
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				FloatComparer o = new FloatComparer();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(bool)))
			{
				bool relative;
				LuaObject.checkType(l, 2, out relative);
				FloatComparer o = new FloatComparer(relative);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (LuaObject.matchType(l, num, 2, typeof(float)))
			{
				float error;
				LuaObject.checkType(l, 2, out error);
				FloatComparer o = new FloatComparer(error);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 3)
			{
				float error2;
				LuaObject.checkType(l, 2, out error2);
				bool relative2;
				LuaObject.checkType(l, 3, out relative2);
				FloatComparer o = new FloatComparer(error2, relative2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BE2 RID: 142306 RVA: 0x00BFE044 File Offset: 0x00BFC244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AreEqual_s(IntPtr l)
	{
		int result;
		try
		{
			float expected;
			LuaObject.checkType(l, 1, out expected);
			float actual;
			LuaObject.checkType(l, 2, out actual);
			float error;
			LuaObject.checkType(l, 3, out error);
			bool b = FloatComparer.AreEqual(expected, actual, error);
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

	// Token: 0x06022BE3 RID: 142307 RVA: 0x00BFE0B4 File Offset: 0x00BFC2B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AreEqualRelative_s(IntPtr l)
	{
		int result;
		try
		{
			float expected;
			LuaObject.checkType(l, 1, out expected);
			float actual;
			LuaObject.checkType(l, 2, out actual);
			float error;
			LuaObject.checkType(l, 3, out error);
			bool b = FloatComparer.AreEqualRelative(expected, actual, error);
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

	// Token: 0x06022BE4 RID: 142308 RVA: 0x00BFE124 File Offset: 0x00BFC324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_s_ComparerWithDefaultTolerance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, FloatComparer.s_ComparerWithDefaultTolerance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BE5 RID: 142309 RVA: 0x00BFE16C File Offset: 0x00BFC36C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_kEpsilon(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, 1E-05f);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BE6 RID: 142310 RVA: 0x00BFE1B4 File Offset: 0x00BFC3B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Assertions.Comparers.FloatComparer");
		if (Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Assertions_Comparers_FloatComparer.AreEqual_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache0);
		if (Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Assertions_Comparers_FloatComparer.AreEqualRelative_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache1);
		string name = "s_ComparerWithDefaultTolerance";
		if (Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Assertions_Comparers_FloatComparer.get_s_ComparerWithDefaultTolerance);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache2, null, false);
		string name2 = "kEpsilon";
		if (Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Assertions_Comparers_FloatComparer.get_kEpsilon);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache3, null, false);
		if (Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Assertions_Comparers_FloatComparer.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Assertions_Comparers_FloatComparer.<>f__mg$cache4, typeof(FloatComparer));
	}

	// Token: 0x04018BE1 RID: 101345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BE2 RID: 101346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018BE3 RID: 101347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018BE4 RID: 101348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018BE5 RID: 101349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
