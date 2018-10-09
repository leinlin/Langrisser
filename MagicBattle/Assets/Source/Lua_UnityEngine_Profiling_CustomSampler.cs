using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Scripting;

// Token: 0x0200175C RID: 5980
[Preserve]
public class Lua_UnityEngine_Profiling_CustomSampler : LuaObject
{
	// Token: 0x06023880 RID: 145536 RVA: 0x00C68444 File Offset: 0x00C66644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Begin(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				CustomSampler customSampler = (CustomSampler)LuaObject.checkSelf(l);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				CustomSampler customSampler2 = (CustomSampler)LuaObject.checkSelf(l);
				UnityEngine.Object @object;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out @object);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Begin to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023881 RID: 145537 RVA: 0x00C684E0 File Offset: 0x00C666E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int End(IntPtr l)
	{
		int result;
		try
		{
			CustomSampler customSampler = (CustomSampler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023882 RID: 145538 RVA: 0x00C68528 File Offset: 0x00C66728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			CustomSampler o = CustomSampler.Create(name);
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

	// Token: 0x06023883 RID: 145539 RVA: 0x00C6857C File Offset: 0x00C6677C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Profiling.CustomSampler");
		if (Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Profiling_CustomSampler.Begin);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache0);
		if (Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Profiling_CustomSampler.End);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache1);
		if (Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Profiling_CustomSampler.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_CustomSampler.<>f__mg$cache2);
		LuaObject.createTypeMetatable(l, null, typeof(CustomSampler), typeof(Sampler));
	}

	// Token: 0x04019626 RID: 103974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019627 RID: 103975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019628 RID: 103976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
