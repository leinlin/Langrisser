using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020016D0 RID: 5840
[Preserve]
public class Lua_UnityEngine_FrameTiming : LuaObject
{
	// Token: 0x06023243 RID: 143939 RVA: 0x00C2C8BC File Offset: 0x00C2AABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming = default(FrameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023244 RID: 143940 RVA: 0x00C2C90C File Offset: 0x00C2AB0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cpuTimePresentCalled(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.cpuTimePresentCalled);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023245 RID: 143941 RVA: 0x00C2C960 File Offset: 0x00C2AB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cpuTimePresentCalled(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			ulong cpuTimePresentCalled;
			LuaObject.checkType(l, 2, out cpuTimePresentCalled);
			frameTiming.cpuTimePresentCalled = cpuTimePresentCalled;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023246 RID: 143942 RVA: 0x00C2C9C4 File Offset: 0x00C2ABC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cpuFrameTime(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.cpuFrameTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023247 RID: 143943 RVA: 0x00C2CA18 File Offset: 0x00C2AC18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cpuFrameTime(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			double cpuFrameTime;
			LuaObject.checkType(l, 2, out cpuFrameTime);
			frameTiming.cpuFrameTime = cpuFrameTime;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023248 RID: 143944 RVA: 0x00C2CA7C File Offset: 0x00C2AC7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_cpuTimeFrameComplete(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.cpuTimeFrameComplete);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023249 RID: 143945 RVA: 0x00C2CAD0 File Offset: 0x00C2ACD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_cpuTimeFrameComplete(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			ulong cpuTimeFrameComplete;
			LuaObject.checkType(l, 2, out cpuTimeFrameComplete);
			frameTiming.cpuTimeFrameComplete = cpuTimeFrameComplete;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602324A RID: 143946 RVA: 0x00C2CB34 File Offset: 0x00C2AD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gpuFrameTime(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.gpuFrameTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602324B RID: 143947 RVA: 0x00C2CB88 File Offset: 0x00C2AD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gpuFrameTime(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			double gpuFrameTime;
			LuaObject.checkType(l, 2, out gpuFrameTime);
			frameTiming.gpuFrameTime = gpuFrameTime;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602324C RID: 143948 RVA: 0x00C2CBEC File Offset: 0x00C2ADEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_heightScale(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.heightScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602324D RID: 143949 RVA: 0x00C2CC40 File Offset: 0x00C2AE40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_heightScale(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			float heightScale;
			LuaObject.checkType(l, 2, out heightScale);
			frameTiming.heightScale = heightScale;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602324E RID: 143950 RVA: 0x00C2CCA4 File Offset: 0x00C2AEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_widthScale(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.widthScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602324F RID: 143951 RVA: 0x00C2CCF8 File Offset: 0x00C2AEF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_widthScale(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			float widthScale;
			LuaObject.checkType(l, 2, out widthScale);
			frameTiming.widthScale = widthScale;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023250 RID: 143952 RVA: 0x00C2CD5C File Offset: 0x00C2AF5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_syncInterval(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameTiming.syncInterval);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023251 RID: 143953 RVA: 0x00C2CDB0 File Offset: 0x00C2AFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_syncInterval(IntPtr l)
	{
		int result;
		try
		{
			FrameTiming frameTiming;
			LuaObject.checkValueType<FrameTiming>(l, 1, out frameTiming);
			uint syncInterval;
			LuaObject.checkType(l, 2, out syncInterval);
			frameTiming.syncInterval = syncInterval;
			LuaObject.setBack(l, frameTiming);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023252 RID: 143954 RVA: 0x00C2CE14 File Offset: 0x00C2B014
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.FrameTiming");
		string name = "cpuTimePresentCalled";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_cpuTimePresentCalled);
		}
		LuaCSFunction get = Lua_UnityEngine_FrameTiming.<>f__mg$cache0;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_cpuTimePresentCalled);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_FrameTiming.<>f__mg$cache1, true);
		string name2 = "cpuFrameTime";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_cpuFrameTime);
		}
		LuaCSFunction get2 = Lua_UnityEngine_FrameTiming.<>f__mg$cache2;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_cpuFrameTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_FrameTiming.<>f__mg$cache3, true);
		string name3 = "cpuTimeFrameComplete";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_cpuTimeFrameComplete);
		}
		LuaCSFunction get3 = Lua_UnityEngine_FrameTiming.<>f__mg$cache4;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_cpuTimeFrameComplete);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_FrameTiming.<>f__mg$cache5, true);
		string name4 = "gpuFrameTime";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_gpuFrameTime);
		}
		LuaCSFunction get4 = Lua_UnityEngine_FrameTiming.<>f__mg$cache6;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_gpuFrameTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_FrameTiming.<>f__mg$cache7, true);
		string name5 = "heightScale";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_heightScale);
		}
		LuaCSFunction get5 = Lua_UnityEngine_FrameTiming.<>f__mg$cache8;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_heightScale);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_FrameTiming.<>f__mg$cache9, true);
		string name6 = "widthScale";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_widthScale);
		}
		LuaCSFunction get6 = Lua_UnityEngine_FrameTiming.<>f__mg$cacheA;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_widthScale);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_FrameTiming.<>f__mg$cacheB, true);
		string name7 = "syncInterval";
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_FrameTiming.get_syncInterval);
		}
		LuaCSFunction get7 = Lua_UnityEngine_FrameTiming.<>f__mg$cacheC;
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_FrameTiming.set_syncInterval);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_FrameTiming.<>f__mg$cacheD, true);
		if (Lua_UnityEngine_FrameTiming.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_FrameTiming.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_FrameTiming.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_FrameTiming.<>f__mg$cacheE, typeof(FrameTiming), typeof(ValueType));
	}

	// Token: 0x04019101 RID: 102657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019102 RID: 102658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019103 RID: 102659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019104 RID: 102660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019105 RID: 102661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019106 RID: 102662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019107 RID: 102663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019108 RID: 102664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019109 RID: 102665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401910A RID: 102666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401910B RID: 102667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401910C RID: 102668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401910D RID: 102669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401910E RID: 102670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401910F RID: 102671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
