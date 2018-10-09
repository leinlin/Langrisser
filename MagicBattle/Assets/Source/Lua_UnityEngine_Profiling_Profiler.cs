using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Profiling;
using UnityEngine.Scripting;

// Token: 0x0200175D RID: 5981
[Preserve]
public class Lua_UnityEngine_Profiling_Profiler : LuaObject
{
	// Token: 0x06023885 RID: 145541 RVA: 0x00C68620 File Offset: 0x00C66820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFramesFromFile_s(IntPtr l)
	{
		int result;
		try
		{
			string text;
			LuaObject.checkType(l, 1, out text);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023886 RID: 145542 RVA: 0x00C68664 File Offset: 0x00C66864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BeginThreadProfiling_s(IntPtr l)
	{
		int result;
		try
		{
			string text;
			LuaObject.checkType(l, 1, out text);
			string text2;
			LuaObject.checkType(l, 2, out text2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023887 RID: 145543 RVA: 0x00C686B4 File Offset: 0x00C668B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndThreadProfiling_s(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023888 RID: 145544 RVA: 0x00C686F0 File Offset: 0x00C668F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BeginSample_s(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				string text;
				LuaObject.checkType(l, 1, out text);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (num == 2)
			{
				string text2;
				LuaObject.checkType(l, 1, out text2);
				UnityEngine.Object @object;
				LuaObject.checkType<UnityEngine.Object>(l, 2, out @object);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function BeginSample to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023889 RID: 145545 RVA: 0x00C68788 File Offset: 0x00C66988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndSample_s(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602388A RID: 145546 RVA: 0x00C687C4 File Offset: 0x00C669C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRuntimeMemorySizeLong_s(IntPtr l)
	{
		int result;
		try
		{
			UnityEngine.Object o;
			LuaObject.checkType<UnityEngine.Object>(l, 1, out o);
			long runtimeMemorySizeLong = Profiler.GetRuntimeMemorySizeLong(o);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, runtimeMemorySizeLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602388B RID: 145547 RVA: 0x00C68818 File Offset: 0x00C66A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMonoHeapSizeLong_s(IntPtr l)
	{
		int result;
		try
		{
			long monoHeapSizeLong = Profiler.GetMonoHeapSizeLong();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monoHeapSizeLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602388C RID: 145548 RVA: 0x00C68860 File Offset: 0x00C66A60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMonoUsedSizeLong_s(IntPtr l)
	{
		int result;
		try
		{
			long monoUsedSizeLong = Profiler.GetMonoUsedSizeLong();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, monoUsedSizeLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602388D RID: 145549 RVA: 0x00C688A8 File Offset: 0x00C66AA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTempAllocatorRequestedSize_s(IntPtr l)
	{
		int result;
		try
		{
			uint tempAllocatorRequestedSize;
			LuaObject.checkType(l, 1, out tempAllocatorRequestedSize);
			bool b = Profiler.SetTempAllocatorRequestedSize(tempAllocatorRequestedSize);
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

	// Token: 0x0602388E RID: 145550 RVA: 0x00C688FC File Offset: 0x00C66AFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTempAllocatorSize_s(IntPtr l)
	{
		int result;
		try
		{
			uint tempAllocatorSize = Profiler.GetTempAllocatorSize();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, tempAllocatorSize);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602388F RID: 145551 RVA: 0x00C68944 File Offset: 0x00C66B44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTotalAllocatedMemoryLong_s(IntPtr l)
	{
		int result;
		try
		{
			long totalAllocatedMemoryLong = Profiler.GetTotalAllocatedMemoryLong();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalAllocatedMemoryLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023890 RID: 145552 RVA: 0x00C6898C File Offset: 0x00C66B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalUnusedReservedMemoryLong_s(IntPtr l)
	{
		int result;
		try
		{
			long totalUnusedReservedMemoryLong = Profiler.GetTotalUnusedReservedMemoryLong();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalUnusedReservedMemoryLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023891 RID: 145553 RVA: 0x00C689D4 File Offset: 0x00C66BD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTotalReservedMemoryLong_s(IntPtr l)
	{
		int result;
		try
		{
			long totalReservedMemoryLong = Profiler.GetTotalReservedMemoryLong();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, totalReservedMemoryLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023892 RID: 145554 RVA: 0x00C68A1C File Offset: 0x00C66C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_supported(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Profiler.supported);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023893 RID: 145555 RVA: 0x00C68A64 File Offset: 0x00C66C64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_logFile(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Profiler.logFile);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023894 RID: 145556 RVA: 0x00C68AAC File Offset: 0x00C66CAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_logFile(IntPtr l)
	{
		int result;
		try
		{
			string logFile;
			LuaObject.checkType(l, 2, out logFile);
			Profiler.logFile = logFile;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023895 RID: 145557 RVA: 0x00C68AF8 File Offset: 0x00C66CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableBinaryLog(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Profiler.enableBinaryLog);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023896 RID: 145558 RVA: 0x00C68B40 File Offset: 0x00C66D40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_enableBinaryLog(IntPtr l)
	{
		int result;
		try
		{
			bool enableBinaryLog;
			LuaObject.checkType(l, 2, out enableBinaryLog);
			Profiler.enableBinaryLog = enableBinaryLog;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023897 RID: 145559 RVA: 0x00C68B8C File Offset: 0x00C66D8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_enabled(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Profiler.enabled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023898 RID: 145560 RVA: 0x00C68BD4 File Offset: 0x00C66DD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enabled(IntPtr l)
	{
		int result;
		try
		{
			bool enabled;
			LuaObject.checkType(l, 2, out enabled);
			Profiler.enabled = enabled;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023899 RID: 145561 RVA: 0x00C68C20 File Offset: 0x00C66E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_usedHeapSizeLong(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Profiler.usedHeapSizeLong);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602389A RID: 145562 RVA: 0x00C68C68 File Offset: 0x00C66E68
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Profiling.Profiler");
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.AddFramesFromFile_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache0);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.BeginThreadProfiling_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache1);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.EndThreadProfiling_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache2);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.BeginSample_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache3);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.EndSample_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache4);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetRuntimeMemorySizeLong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache5);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetMonoHeapSizeLong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache6);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetMonoUsedSizeLong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache7);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.SetTempAllocatorRequestedSize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache8);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetTempAllocatorSize_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache9);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetTotalAllocatedMemoryLong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheA);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetTotalUnusedReservedMemoryLong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheB);
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.GetTotalReservedMemoryLong_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheC);
		string name = "supported";
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.get_supported);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheD, null, false);
		string name2 = "logFile";
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.get_logFile);
		}
		LuaCSFunction get = Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheE;
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.set_logFile);
		}
		LuaObject.addMember(l, name2, get, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cacheF, false);
		string name3 = "enableBinaryLog";
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.get_enableBinaryLog);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache10;
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.set_enableBinaryLog);
		}
		LuaObject.addMember(l, name3, get2, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache11, false);
		string name4 = "enabled";
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.get_enabled);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache12;
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.set_enabled);
		}
		LuaObject.addMember(l, name4, get3, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache13, false);
		string name5 = "usedHeapSizeLong";
		if (Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Profiling_Profiler.get_usedHeapSizeLong);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Profiling_Profiler.<>f__mg$cache14, null, false);
		LuaObject.createTypeMetatable(l, null, typeof(Profiler));
	}

	// Token: 0x04019629 RID: 103977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401962A RID: 103978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401962B RID: 103979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401962C RID: 103980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401962D RID: 103981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401962E RID: 103982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401962F RID: 103983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019630 RID: 103984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019631 RID: 103985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019632 RID: 103986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019633 RID: 103987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019634 RID: 103988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019635 RID: 103989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019636 RID: 103990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019637 RID: 103991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019638 RID: 103992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019639 RID: 103993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401963A RID: 103994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401963B RID: 103995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401963C RID: 103996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401963D RID: 103997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
