using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001800 RID: 6144
[Preserve]
public class Lua_UnityEngine_Time : LuaObject
{
	// Token: 0x06023ED6 RID: 147158 RVA: 0x00C9A6C4 File Offset: 0x00C988C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Time o = new Time();
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

	// Token: 0x06023ED7 RID: 147159 RVA: 0x00C9A70C File Offset: 0x00C9890C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_time(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.time);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ED8 RID: 147160 RVA: 0x00C9A754 File Offset: 0x00C98954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timeSinceLevelLoad(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.timeSinceLevelLoad);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023ED9 RID: 147161 RVA: 0x00C9A79C File Offset: 0x00C9899C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.deltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EDA RID: 147162 RVA: 0x00C9A7E4 File Offset: 0x00C989E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fixedTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.fixedTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EDB RID: 147163 RVA: 0x00C9A82C File Offset: 0x00C98A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_unscaledTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.unscaledTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EDC RID: 147164 RVA: 0x00C9A874 File Offset: 0x00C98A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fixedUnscaledTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.fixedUnscaledTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EDD RID: 147165 RVA: 0x00C9A8BC File Offset: 0x00C98ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_unscaledDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.unscaledDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EDE RID: 147166 RVA: 0x00C9A904 File Offset: 0x00C98B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fixedUnscaledDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.fixedUnscaledDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EDF RID: 147167 RVA: 0x00C9A94C File Offset: 0x00C98B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_fixedDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.fixedDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE0 RID: 147168 RVA: 0x00C9A994 File Offset: 0x00C98B94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_fixedDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			float fixedDeltaTime;
			LuaObject.checkType(l, 2, out fixedDeltaTime);
			Time.fixedDeltaTime = fixedDeltaTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE1 RID: 147169 RVA: 0x00C9A9E0 File Offset: 0x00C98BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maximumDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.maximumDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE2 RID: 147170 RVA: 0x00C9AA28 File Offset: 0x00C98C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			float maximumDeltaTime;
			LuaObject.checkType(l, 2, out maximumDeltaTime);
			Time.maximumDeltaTime = maximumDeltaTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE3 RID: 147171 RVA: 0x00C9AA74 File Offset: 0x00C98C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_smoothDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.smoothDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE4 RID: 147172 RVA: 0x00C9AABC File Offset: 0x00C98CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maximumParticleDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.maximumParticleDeltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE5 RID: 147173 RVA: 0x00C9AB04 File Offset: 0x00C98D04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maximumParticleDeltaTime(IntPtr l)
	{
		int result;
		try
		{
			float maximumParticleDeltaTime;
			LuaObject.checkType(l, 2, out maximumParticleDeltaTime);
			Time.maximumParticleDeltaTime = maximumParticleDeltaTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE6 RID: 147174 RVA: 0x00C9AB50 File Offset: 0x00C98D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timeScale(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.timeScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE7 RID: 147175 RVA: 0x00C9AB98 File Offset: 0x00C98D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_timeScale(IntPtr l)
	{
		int result;
		try
		{
			float timeScale;
			LuaObject.checkType(l, 2, out timeScale);
			Time.timeScale = timeScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE8 RID: 147176 RVA: 0x00C9ABE4 File Offset: 0x00C98DE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frameCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.frameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EE9 RID: 147177 RVA: 0x00C9AC2C File Offset: 0x00C98E2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderedFrameCount(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.renderedFrameCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EEA RID: 147178 RVA: 0x00C9AC74 File Offset: 0x00C98E74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_realtimeSinceStartup(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.realtimeSinceStartup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EEB RID: 147179 RVA: 0x00C9ACBC File Offset: 0x00C98EBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_captureFramerate(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.captureFramerate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EEC RID: 147180 RVA: 0x00C9AD04 File Offset: 0x00C98F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_captureFramerate(IntPtr l)
	{
		int result;
		try
		{
			int captureFramerate;
			LuaObject.checkType(l, 2, out captureFramerate);
			Time.captureFramerate = captureFramerate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EED RID: 147181 RVA: 0x00C9AD50 File Offset: 0x00C98F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_inFixedTimeStep(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Time.inFixedTimeStep);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023EEE RID: 147182 RVA: 0x00C9AD98 File Offset: 0x00C98F98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Time");
		string name = "time";
		if (Lua_UnityEngine_Time.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Time.get_time);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Time.<>f__mg$cache0, null, false);
		string name2 = "timeSinceLevelLoad";
		if (Lua_UnityEngine_Time.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Time.get_timeSinceLevelLoad);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Time.<>f__mg$cache1, null, false);
		string name3 = "deltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Time.get_deltaTime);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Time.<>f__mg$cache2, null, false);
		string name4 = "fixedTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Time.get_fixedTime);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Time.<>f__mg$cache3, null, false);
		string name5 = "unscaledTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Time.get_unscaledTime);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Time.<>f__mg$cache4, null, false);
		string name6 = "fixedUnscaledTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Time.get_fixedUnscaledTime);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Time.<>f__mg$cache5, null, false);
		string name7 = "unscaledDeltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Time.get_unscaledDeltaTime);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Time.<>f__mg$cache6, null, false);
		string name8 = "fixedUnscaledDeltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Time.get_fixedUnscaledDeltaTime);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Time.<>f__mg$cache7, null, false);
		string name9 = "fixedDeltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Time.get_fixedDeltaTime);
		}
		LuaCSFunction get = Lua_UnityEngine_Time.<>f__mg$cache8;
		if (Lua_UnityEngine_Time.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Time.set_fixedDeltaTime);
		}
		LuaObject.addMember(l, name9, get, Lua_UnityEngine_Time.<>f__mg$cache9, false);
		string name10 = "maximumDeltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Time.get_maximumDeltaTime);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Time.<>f__mg$cacheA;
		if (Lua_UnityEngine_Time.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Time.set_maximumDeltaTime);
		}
		LuaObject.addMember(l, name10, get2, Lua_UnityEngine_Time.<>f__mg$cacheB, false);
		string name11 = "smoothDeltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Time.get_smoothDeltaTime);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Time.<>f__mg$cacheC, null, false);
		string name12 = "maximumParticleDeltaTime";
		if (Lua_UnityEngine_Time.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Time.get_maximumParticleDeltaTime);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Time.<>f__mg$cacheD;
		if (Lua_UnityEngine_Time.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Time.set_maximumParticleDeltaTime);
		}
		LuaObject.addMember(l, name12, get3, Lua_UnityEngine_Time.<>f__mg$cacheE, false);
		string name13 = "timeScale";
		if (Lua_UnityEngine_Time.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Time.get_timeScale);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Time.<>f__mg$cacheF;
		if (Lua_UnityEngine_Time.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Time.set_timeScale);
		}
		LuaObject.addMember(l, name13, get4, Lua_UnityEngine_Time.<>f__mg$cache10, false);
		string name14 = "frameCount";
		if (Lua_UnityEngine_Time.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Time.get_frameCount);
		}
		LuaObject.addMember(l, name14, Lua_UnityEngine_Time.<>f__mg$cache11, null, false);
		string name15 = "renderedFrameCount";
		if (Lua_UnityEngine_Time.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_Time.get_renderedFrameCount);
		}
		LuaObject.addMember(l, name15, Lua_UnityEngine_Time.<>f__mg$cache12, null, false);
		string name16 = "realtimeSinceStartup";
		if (Lua_UnityEngine_Time.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_Time.get_realtimeSinceStartup);
		}
		LuaObject.addMember(l, name16, Lua_UnityEngine_Time.<>f__mg$cache13, null, false);
		string name17 = "captureFramerate";
		if (Lua_UnityEngine_Time.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_Time.get_captureFramerate);
		}
		LuaCSFunction get5 = Lua_UnityEngine_Time.<>f__mg$cache14;
		if (Lua_UnityEngine_Time.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_Time.set_captureFramerate);
		}
		LuaObject.addMember(l, name17, get5, Lua_UnityEngine_Time.<>f__mg$cache15, false);
		string name18 = "inFixedTimeStep";
		if (Lua_UnityEngine_Time.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_Time.get_inFixedTimeStep);
		}
		LuaObject.addMember(l, name18, Lua_UnityEngine_Time.<>f__mg$cache16, null, false);
		if (Lua_UnityEngine_Time.<>f__mg$cache17 == null)
		{
			Lua_UnityEngine_Time.<>f__mg$cache17 = new LuaCSFunction(Lua_UnityEngine_Time.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Time.<>f__mg$cache17, typeof(Time));
	}

	// Token: 0x04019B34 RID: 105268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019B35 RID: 105269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019B36 RID: 105270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019B37 RID: 105271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019B38 RID: 105272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019B39 RID: 105273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019B3A RID: 105274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019B3B RID: 105275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019B3C RID: 105276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019B3D RID: 105277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019B3E RID: 105278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019B3F RID: 105279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019B40 RID: 105280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019B41 RID: 105281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04019B42 RID: 105282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019B43 RID: 105283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04019B44 RID: 105284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04019B45 RID: 105285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04019B46 RID: 105286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04019B47 RID: 105287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04019B48 RID: 105288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04019B49 RID: 105289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04019B4A RID: 105290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04019B4B RID: 105291
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
