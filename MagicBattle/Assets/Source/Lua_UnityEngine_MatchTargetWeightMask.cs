using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001722 RID: 5922
[Preserve]
public class Lua_UnityEngine_MatchTargetWeightMask : LuaObject
{
	// Token: 0x06023563 RID: 144739 RVA: 0x00C467C4 File Offset: 0x00C449C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Vector3 positionXYZWeight;
			LuaObject.checkType(l, 2, out positionXYZWeight);
			float rotationWeight;
			LuaObject.checkType(l, 3, out rotationWeight);
			MatchTargetWeightMask matchTargetWeightMask = new MatchTargetWeightMask(positionXYZWeight, rotationWeight);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matchTargetWeightMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023564 RID: 144740 RVA: 0x00C4682C File Offset: 0x00C44A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_positionXYZWeight(IntPtr l)
	{
		int result;
		try
		{
			MatchTargetWeightMask matchTargetWeightMask;
			LuaObject.checkValueType<MatchTargetWeightMask>(l, 1, out matchTargetWeightMask);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matchTargetWeightMask.positionXYZWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023565 RID: 144741 RVA: 0x00C46880 File Offset: 0x00C44A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_positionXYZWeight(IntPtr l)
	{
		int result;
		try
		{
			MatchTargetWeightMask matchTargetWeightMask;
			LuaObject.checkValueType<MatchTargetWeightMask>(l, 1, out matchTargetWeightMask);
			Vector3 positionXYZWeight;
			LuaObject.checkType(l, 2, out positionXYZWeight);
			matchTargetWeightMask.positionXYZWeight = positionXYZWeight;
			LuaObject.setBack(l, matchTargetWeightMask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023566 RID: 144742 RVA: 0x00C468E4 File Offset: 0x00C44AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_rotationWeight(IntPtr l)
	{
		int result;
		try
		{
			MatchTargetWeightMask matchTargetWeightMask;
			LuaObject.checkValueType<MatchTargetWeightMask>(l, 1, out matchTargetWeightMask);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, matchTargetWeightMask.rotationWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023567 RID: 144743 RVA: 0x00C46938 File Offset: 0x00C44B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotationWeight(IntPtr l)
	{
		int result;
		try
		{
			MatchTargetWeightMask matchTargetWeightMask;
			LuaObject.checkValueType<MatchTargetWeightMask>(l, 1, out matchTargetWeightMask);
			float rotationWeight;
			LuaObject.checkType(l, 2, out rotationWeight);
			matchTargetWeightMask.rotationWeight = rotationWeight;
			LuaObject.setBack(l, matchTargetWeightMask);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023568 RID: 144744 RVA: 0x00C4699C File Offset: 0x00C44B9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.MatchTargetWeightMask");
		string name = "positionXYZWeight";
		if (Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_MatchTargetWeightMask.get_positionXYZWeight);
		}
		LuaCSFunction get = Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache0;
		if (Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_MatchTargetWeightMask.set_positionXYZWeight);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache1, true);
		string name2 = "rotationWeight";
		if (Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_MatchTargetWeightMask.get_rotationWeight);
		}
		LuaCSFunction get2 = Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache2;
		if (Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_MatchTargetWeightMask.set_rotationWeight);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache3, true);
		if (Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_MatchTargetWeightMask.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_MatchTargetWeightMask.<>f__mg$cache4, typeof(MatchTargetWeightMask), typeof(ValueType));
	}

	// Token: 0x0401937D RID: 103293
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401937E RID: 103294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401937F RID: 103295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019380 RID: 103296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019381 RID: 103297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
