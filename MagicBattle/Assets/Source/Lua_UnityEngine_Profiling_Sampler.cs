using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Profiling;
using UnityEngine.Scripting;

// Token: 0x0200175F RID: 5983
[Preserve]
public class Lua_UnityEngine_Profiling_Sampler : LuaObject
{
	// Token: 0x060238A4 RID: 145572 RVA: 0x00C6929C File Offset: 0x00C6749C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRecorder(IntPtr l)
	{
		int result;
		try
		{
			Sampler sampler = (Sampler)LuaObject.checkSelf(l);
			Recorder recorder = sampler.GetRecorder();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recorder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A5 RID: 145573 RVA: 0x00C692F0 File Offset: 0x00C674F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Get_s(IntPtr l)
	{
		int result;
		try
		{
			string name;
			LuaObject.checkType(l, 1, out name);
			Sampler o = Sampler.Get(name);
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

	// Token: 0x060238A6 RID: 145574 RVA: 0x00C69344 File Offset: 0x00C67544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetNames_s(IntPtr l)
	{
		int result;
		try
		{
			List<string> names;
			LuaObject.checkType<List<string>>(l, 1, out names);
			int names2 = Sampler.GetNames(names);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, names2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A7 RID: 145575 RVA: 0x00C69398 File Offset: 0x00C67598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isValid(IntPtr l)
	{
		int result;
		try
		{
			Sampler sampler = (Sampler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sampler.isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A8 RID: 145576 RVA: 0x00C693EC File Offset: 0x00C675EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_name(IntPtr l)
	{
		int result;
		try
		{
			Sampler sampler = (Sampler)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sampler.name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A9 RID: 145577 RVA: 0x00C69440 File Offset: 0x00C67640
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Profiling.Sampler");
		if (Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Profiling_Sampler.GetRecorder);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache0);
		if (Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Profiling_Sampler.Get_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache1);
		if (Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Profiling_Sampler.GetNames_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache2);
		string name = "isValid";
		if (Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Profiling_Sampler.get_isValid);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache3, null, true);
		string name2 = "name";
		if (Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Profiling_Sampler.get_name);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Profiling_Sampler.<>f__mg$cache4, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Sampler));
	}

	// Token: 0x04019644 RID: 104004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019645 RID: 104005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019646 RID: 104006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019647 RID: 104007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019648 RID: 104008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
