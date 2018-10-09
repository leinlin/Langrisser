using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001659 RID: 5721
[Preserve]
public class Lua_UnityEngine_CharacterJoint : LuaObject
{
	// Token: 0x06022E2B RID: 142891 RVA: 0x00C0F434 File Offset: 0x00C0D634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_swingAxis(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.swingAxis);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E2C RID: 142892 RVA: 0x00C0F488 File Offset: 0x00C0D688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_swingAxis(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			Vector3 swingAxis;
			LuaObject.checkType(l, 2, out swingAxis);
			characterJoint.swingAxis = swingAxis;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E2D RID: 142893 RVA: 0x00C0F4E0 File Offset: 0x00C0D6E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_twistLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.twistLimitSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E2E RID: 142894 RVA: 0x00C0F538 File Offset: 0x00C0D738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_twistLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			SoftJointLimitSpring twistLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 2, out twistLimitSpring);
			characterJoint.twistLimitSpring = twistLimitSpring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E2F RID: 142895 RVA: 0x00C0F590 File Offset: 0x00C0D790
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_swingLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.swingLimitSpring);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E30 RID: 142896 RVA: 0x00C0F5E8 File Offset: 0x00C0D7E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_swingLimitSpring(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			SoftJointLimitSpring swingLimitSpring;
			LuaObject.checkValueType<SoftJointLimitSpring>(l, 2, out swingLimitSpring);
			characterJoint.swingLimitSpring = swingLimitSpring;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E31 RID: 142897 RVA: 0x00C0F640 File Offset: 0x00C0D840
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_lowTwistLimit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.lowTwistLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E32 RID: 142898 RVA: 0x00C0F698 File Offset: 0x00C0D898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_lowTwistLimit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			SoftJointLimit lowTwistLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out lowTwistLimit);
			characterJoint.lowTwistLimit = lowTwistLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E33 RID: 142899 RVA: 0x00C0F6F0 File Offset: 0x00C0D8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_highTwistLimit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.highTwistLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E34 RID: 142900 RVA: 0x00C0F748 File Offset: 0x00C0D948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_highTwistLimit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			SoftJointLimit highTwistLimit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out highTwistLimit);
			characterJoint.highTwistLimit = highTwistLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E35 RID: 142901 RVA: 0x00C0F7A0 File Offset: 0x00C0D9A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_swing1Limit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.swing1Limit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E36 RID: 142902 RVA: 0x00C0F7F8 File Offset: 0x00C0D9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_swing1Limit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			SoftJointLimit swing1Limit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out swing1Limit);
			characterJoint.swing1Limit = swing1Limit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E37 RID: 142903 RVA: 0x00C0F850 File Offset: 0x00C0DA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_swing2Limit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.swing2Limit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E38 RID: 142904 RVA: 0x00C0F8A8 File Offset: 0x00C0DAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_swing2Limit(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			SoftJointLimit swing2Limit;
			LuaObject.checkValueType<SoftJointLimit>(l, 2, out swing2Limit);
			characterJoint.swing2Limit = swing2Limit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E39 RID: 142905 RVA: 0x00C0F900 File Offset: 0x00C0DB00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_enableProjection(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.enableProjection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E3A RID: 142906 RVA: 0x00C0F954 File Offset: 0x00C0DB54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_enableProjection(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			bool enableProjection;
			LuaObject.checkType(l, 2, out enableProjection);
			characterJoint.enableProjection = enableProjection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E3B RID: 142907 RVA: 0x00C0F9AC File Offset: 0x00C0DBAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_projectionDistance(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.projectionDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E3C RID: 142908 RVA: 0x00C0FA00 File Offset: 0x00C0DC00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_projectionDistance(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			float projectionDistance;
			LuaObject.checkType(l, 2, out projectionDistance);
			characterJoint.projectionDistance = projectionDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E3D RID: 142909 RVA: 0x00C0FA58 File Offset: 0x00C0DC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_projectionAngle(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, characterJoint.projectionAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E3E RID: 142910 RVA: 0x00C0FAAC File Offset: 0x00C0DCAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_projectionAngle(IntPtr l)
	{
		int result;
		try
		{
			CharacterJoint characterJoint = (CharacterJoint)LuaObject.checkSelf(l);
			float projectionAngle;
			LuaObject.checkType(l, 2, out projectionAngle);
			characterJoint.projectionAngle = projectionAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022E3F RID: 142911 RVA: 0x00C0FB04 File Offset: 0x00C0DD04
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CharacterJoint");
		string name = "swingAxis";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_swingAxis);
		}
		LuaCSFunction get = Lua_UnityEngine_CharacterJoint.<>f__mg$cache0;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_swingAxis);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_CharacterJoint.<>f__mg$cache1, true);
		string name2 = "twistLimitSpring";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_twistLimitSpring);
		}
		LuaCSFunction get2 = Lua_UnityEngine_CharacterJoint.<>f__mg$cache2;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_twistLimitSpring);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_CharacterJoint.<>f__mg$cache3, true);
		string name3 = "swingLimitSpring";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_swingLimitSpring);
		}
		LuaCSFunction get3 = Lua_UnityEngine_CharacterJoint.<>f__mg$cache4;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_swingLimitSpring);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_CharacterJoint.<>f__mg$cache5, true);
		string name4 = "lowTwistLimit";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_lowTwistLimit);
		}
		LuaCSFunction get4 = Lua_UnityEngine_CharacterJoint.<>f__mg$cache6;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_lowTwistLimit);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_CharacterJoint.<>f__mg$cache7, true);
		string name5 = "highTwistLimit";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_highTwistLimit);
		}
		LuaCSFunction get5 = Lua_UnityEngine_CharacterJoint.<>f__mg$cache8;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_highTwistLimit);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_CharacterJoint.<>f__mg$cache9, true);
		string name6 = "swing1Limit";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_swing1Limit);
		}
		LuaCSFunction get6 = Lua_UnityEngine_CharacterJoint.<>f__mg$cacheA;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_swing1Limit);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_CharacterJoint.<>f__mg$cacheB, true);
		string name7 = "swing2Limit";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_swing2Limit);
		}
		LuaCSFunction get7 = Lua_UnityEngine_CharacterJoint.<>f__mg$cacheC;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_swing2Limit);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_CharacterJoint.<>f__mg$cacheD, true);
		string name8 = "enableProjection";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_enableProjection);
		}
		LuaCSFunction get8 = Lua_UnityEngine_CharacterJoint.<>f__mg$cacheE;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_enableProjection);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_CharacterJoint.<>f__mg$cacheF, true);
		string name9 = "projectionDistance";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_projectionDistance);
		}
		LuaCSFunction get9 = Lua_UnityEngine_CharacterJoint.<>f__mg$cache10;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_projectionDistance);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_CharacterJoint.<>f__mg$cache11, true);
		string name10 = "projectionAngle";
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.get_projectionAngle);
		}
		LuaCSFunction get10 = Lua_UnityEngine_CharacterJoint.<>f__mg$cache12;
		if (Lua_UnityEngine_CharacterJoint.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_CharacterJoint.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_CharacterJoint.set_projectionAngle);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_CharacterJoint.<>f__mg$cache13, true);
		LuaObject.createTypeMetatable(l, null, typeof(CharacterJoint), typeof(Joint));
	}

	// Token: 0x04018DD7 RID: 101847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018DD8 RID: 101848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018DD9 RID: 101849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018DDA RID: 101850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018DDB RID: 101851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018DDC RID: 101852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018DDD RID: 101853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018DDE RID: 101854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018DDF RID: 101855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018DE0 RID: 101856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018DE1 RID: 101857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018DE2 RID: 101858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018DE3 RID: 101859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018DE4 RID: 101860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04018DE5 RID: 101861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04018DE6 RID: 101862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04018DE7 RID: 101863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04018DE8 RID: 101864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04018DE9 RID: 101865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04018DEA RID: 101866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
