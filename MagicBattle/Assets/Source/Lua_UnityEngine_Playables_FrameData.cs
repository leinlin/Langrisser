using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001742 RID: 5954
[Preserve]
public class Lua_UnityEngine_Playables_FrameData : LuaObject
{
	// Token: 0x060237C3 RID: 145347 RVA: 0x00C63968 File Offset: 0x00C61B68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData = default(FrameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237C4 RID: 145348 RVA: 0x00C639B8 File Offset: 0x00C61BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_frameId(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.frameId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237C5 RID: 145349 RVA: 0x00C63A0C File Offset: 0x00C61C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_deltaTime(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.deltaTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237C6 RID: 145350 RVA: 0x00C63A60 File Offset: 0x00C61C60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_weight(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.weight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237C7 RID: 145351 RVA: 0x00C63AB4 File Offset: 0x00C61CB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_effectiveWeight(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.effectiveWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237C8 RID: 145352 RVA: 0x00C63B08 File Offset: 0x00C61D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_effectiveParentDelay(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.effectiveParentDelay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237C9 RID: 145353 RVA: 0x00C63B5C File Offset: 0x00C61D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_effectiveParentSpeed(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.effectiveParentSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237CA RID: 145354 RVA: 0x00C63BB0 File Offset: 0x00C61DB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_effectiveSpeed(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.effectiveSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237CB RID: 145355 RVA: 0x00C63C04 File Offset: 0x00C61E04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_evaluationType(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)frameData.evaluationType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237CC RID: 145356 RVA: 0x00C63C58 File Offset: 0x00C61E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_seekOccurred(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.seekOccurred);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237CD RID: 145357 RVA: 0x00C63CAC File Offset: 0x00C61EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timeLooped(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.timeLooped);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237CE RID: 145358 RVA: 0x00C63D00 File Offset: 0x00C61F00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_timeHeld(IntPtr l)
	{
		int result;
		try
		{
			FrameData frameData;
			LuaObject.checkValueType<FrameData>(l, 1, out frameData);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, frameData.timeHeld);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237CF RID: 145359 RVA: 0x00C63D54 File Offset: 0x00C61F54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.FrameData");
		string name = "frameId";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_frameId);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache0, null, true);
		string name2 = "deltaTime";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_deltaTime);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache1, null, true);
		string name3 = "weight";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_weight);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache2, null, true);
		string name4 = "effectiveWeight";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_effectiveWeight);
		}
		LuaObject.addMember(l, name4, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache3, null, true);
		string name5 = "effectiveParentDelay";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_effectiveParentDelay);
		}
		LuaObject.addMember(l, name5, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache4, null, true);
		string name6 = "effectiveParentSpeed";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_effectiveParentSpeed);
		}
		LuaObject.addMember(l, name6, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache5, null, true);
		string name7 = "effectiveSpeed";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_effectiveSpeed);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache6, null, true);
		string name8 = "evaluationType";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_evaluationType);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache7, null, true);
		string name9 = "seekOccurred";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_seekOccurred);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache8, null, true);
		string name10 = "timeLooped";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_timeLooped);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_Playables_FrameData.<>f__mg$cache9, null, true);
		string name11 = "timeHeld";
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.get_timeHeld);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_Playables_FrameData.<>f__mg$cacheA, null, true);
		if (Lua_UnityEngine_Playables_FrameData.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Playables_FrameData.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Playables_FrameData.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_FrameData.<>f__mg$cacheB, typeof(FrameData), typeof(ValueType));
	}

	// Token: 0x0401959D RID: 103837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401959E RID: 103838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401959F RID: 103839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195A0 RID: 103840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195A1 RID: 103841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040195A2 RID: 103842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040195A3 RID: 103843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040195A4 RID: 103844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040195A5 RID: 103845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040195A6 RID: 103846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040195A7 RID: 103847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040195A8 RID: 103848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;
}
