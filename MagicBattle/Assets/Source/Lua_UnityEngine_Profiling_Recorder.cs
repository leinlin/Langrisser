using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Profiling;
using UnityEngine.Scripting;

// Token: 0x0200175E RID: 5982
[Preserve]
public class Lua_UnityEngine_Profiling_Recorder : LuaObject
{
	// Token: 0x0602389C RID: 145564 RVA: 0x00C68F88 File Offset: 0x00C67188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Get_s(IntPtr l)
	{
		int result;
		try
		{
			string samplerName;
			LuaObject.checkType(l, 1, out samplerName);
			Recorder o = Recorder.Get(samplerName);
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

	// Token: 0x0602389D RID: 145565 RVA: 0x00C68FDC File Offset: 0x00C671DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isValid(IntPtr l)
	{
		int result;
		try
		{
			Recorder recorder = (Recorder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recorder.isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602389E RID: 145566 RVA: 0x00C69030 File Offset: 0x00C67230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			Recorder recorder = (Recorder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recorder.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602389F RID: 145567 RVA: 0x00C69084 File Offset: 0x00C67284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			Recorder recorder = (Recorder)LuaObject.checkSelf(l);
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			recorder.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A0 RID: 145568 RVA: 0x00C690DC File Offset: 0x00C672DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_elapsedNanoseconds(IntPtr l)
	{
		int result;
		try
		{
			Recorder recorder = (Recorder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recorder.elapsedNanoseconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A1 RID: 145569 RVA: 0x00C69130 File Offset: 0x00C67330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sampleBlockCount(IntPtr l)
	{
		int result;
		try
		{
			Recorder recorder = (Recorder)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, recorder.sampleBlockCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060238A2 RID: 145570 RVA: 0x00C69184 File Offset: 0x00C67384
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Profiling.Recorder");
		if (Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Profiling_Recorder.Get_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache0);
		string name = "isValid";
		if (Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Profiling_Recorder.get_isValid);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache1, null, true);
		string name2 = "enabled";
		if (Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Profiling_Recorder.get_enabled);
		}
		LuaCSFunction get = Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache2;
		if (Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Profiling_Recorder.set_enabled);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache3, true);
		string name3 = "elapsedNanoseconds";
		if (Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Profiling_Recorder.get_elapsedNanoseconds);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache4, null, true);
		string name4 = "sampleBlockCount";
		if (Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Profiling_Recorder.get_sampleBlockCount);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Profiling_Recorder.<>f__mg$cache5, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(Recorder));
	}

	// Token: 0x0401963E RID: 103998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401963F RID: 103999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019640 RID: 104000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019641 RID: 104001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019642 RID: 104002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019643 RID: 104003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
