using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D1 RID: 5841
[Preserve]
public class Lua_UnityEngine_FrameTimingManager : LuaObject
{
	// Token: 0x06023254 RID: 143956 RVA: 0x00C2D058 File Offset: 0x00C2B258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CaptureFrameTimings_s(IntPtr l)
	{
		int result;
		try
		{
			FrameTimingManager.CaptureFrameTimings();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023255 RID: 143957 RVA: 0x00C2D098 File Offset: 0x00C2B298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLatestTimings_s(IntPtr l)
	{
		int result;
		try
		{
			uint numFrames;
			LuaObject.checkType(l, 1, out numFrames);
			FrameTiming[] timings;
			LuaObject.checkArray<FrameTiming>(l, 2, out timings);
			uint latestTimings = FrameTimingManager.GetLatestTimings(numFrames, timings);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, latestTimings);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023256 RID: 143958 RVA: 0x00C2D0F8 File Offset: 0x00C2B2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetVSyncsPerSecond_s(IntPtr l)
	{
		int result;
		try
		{
			float vsyncsPerSecond = FrameTimingManager.GetVSyncsPerSecond();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, vsyncsPerSecond);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023257 RID: 143959 RVA: 0x00C2D140 File Offset: 0x00C2B340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetGpuTimerFrequency_s(IntPtr l)
	{
		int result;
		try
		{
			ulong gpuTimerFrequency = FrameTimingManager.GetGpuTimerFrequency();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gpuTimerFrequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023258 RID: 143960 RVA: 0x00C2D188 File Offset: 0x00C2B388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCpuTimerFrequency_s(IntPtr l)
	{
		int result;
		try
		{
			ulong cpuTimerFrequency = FrameTimingManager.GetCpuTimerFrequency();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, cpuTimerFrequency);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023259 RID: 143961 RVA: 0x00C2D1D0 File Offset: 0x00C2B3D0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FrameTimingManager");
		if (Lua_UnityEngine_FrameTimingManager.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_FrameTimingManager.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_FrameTimingManager.CaptureFrameTimings_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_FrameTimingManager.<>f__mg$cache0);
		if (Lua_UnityEngine_FrameTimingManager.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_FrameTimingManager.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_FrameTimingManager.GetLatestTimings_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_FrameTimingManager.<>f__mg$cache1);
		if (Lua_UnityEngine_FrameTimingManager.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_FrameTimingManager.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_FrameTimingManager.GetVSyncsPerSecond_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_FrameTimingManager.<>f__mg$cache2);
		if (Lua_UnityEngine_FrameTimingManager.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_FrameTimingManager.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_FrameTimingManager.GetGpuTimerFrequency_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_FrameTimingManager.<>f__mg$cache3);
		if (Lua_UnityEngine_FrameTimingManager.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_FrameTimingManager.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_FrameTimingManager.GetCpuTimerFrequency_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_FrameTimingManager.<>f__mg$cache4);
		LuaObject.createTypeMetatable(l, null, typeof(FrameTimingManager));
	}

	// Token: 0x04019110 RID: 102672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019111 RID: 102673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019112 RID: 102674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019113 RID: 102675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019114 RID: 102676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
