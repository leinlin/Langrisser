using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x020017D7 RID: 6103
[Preserve]
public class Lua_UnityEngine_SliderJoint2D : LuaObject
{
	// Token: 0x06023D38 RID: 146744 RVA: 0x00C8E31C File Offset: 0x00C8C51C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMotorForce(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			float timeStep;
			LuaObject.checkType(l, 2, out timeStep);
			float motorForce = sliderJoint2D.GetMotorForce(timeStep);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, motorForce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D39 RID: 146745 RVA: 0x00C8E380 File Offset: 0x00C8C580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_autoConfigureAngle(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.autoConfigureAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D3A RID: 146746 RVA: 0x00C8E3D4 File Offset: 0x00C8C5D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_autoConfigureAngle(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			bool autoConfigureAngle;
			LuaObject.checkType(l, 2, out autoConfigureAngle);
			sliderJoint2D.autoConfigureAngle = autoConfigureAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D3B RID: 146747 RVA: 0x00C8E42C File Offset: 0x00C8C62C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_angle(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.angle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D3C RID: 146748 RVA: 0x00C8E480 File Offset: 0x00C8C680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angle(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			float angle;
			LuaObject.checkType(l, 2, out angle);
			sliderJoint2D.angle = angle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D3D RID: 146749 RVA: 0x00C8E4D8 File Offset: 0x00C8C6D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_useMotor(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.useMotor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D3E RID: 146750 RVA: 0x00C8E52C File Offset: 0x00C8C72C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_useMotor(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			bool useMotor;
			LuaObject.checkType(l, 2, out useMotor);
			sliderJoint2D.useMotor = useMotor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D3F RID: 146751 RVA: 0x00C8E584 File Offset: 0x00C8C784
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_useLimits(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.useLimits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D40 RID: 146752 RVA: 0x00C8E5D8 File Offset: 0x00C8C7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useLimits(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			bool useLimits;
			LuaObject.checkType(l, 2, out useLimits);
			sliderJoint2D.useLimits = useLimits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D41 RID: 146753 RVA: 0x00C8E630 File Offset: 0x00C8C830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_motor(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.motor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D42 RID: 146754 RVA: 0x00C8E688 File Offset: 0x00C8C888
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_motor(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			JointMotor2D motor;
			LuaObject.checkValueType<JointMotor2D>(l, 2, out motor);
			sliderJoint2D.motor = motor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D43 RID: 146755 RVA: 0x00C8E6E0 File Offset: 0x00C8C8E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_limits(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.limits);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D44 RID: 146756 RVA: 0x00C8E738 File Offset: 0x00C8C938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_limits(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			JointTranslationLimits2D limits;
			LuaObject.checkValueType<JointTranslationLimits2D>(l, 2, out limits);
			sliderJoint2D.limits = limits;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D45 RID: 146757 RVA: 0x00C8E790 File Offset: 0x00C8C990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_limitState(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)sliderJoint2D.limitState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D46 RID: 146758 RVA: 0x00C8E7E4 File Offset: 0x00C8C9E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_referenceAngle(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.referenceAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D47 RID: 146759 RVA: 0x00C8E838 File Offset: 0x00C8CA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_jointTranslation(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.jointTranslation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D48 RID: 146760 RVA: 0x00C8E88C File Offset: 0x00C8CA8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_jointSpeed(IntPtr l)
	{
		int result;
		try
		{
			SliderJoint2D sliderJoint2D = (SliderJoint2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, sliderJoint2D.jointSpeed);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023D49 RID: 146761 RVA: 0x00C8E8E0 File Offset: 0x00C8CAE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.SliderJoint2D");
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.GetMotorForce);
		}
		LuaObject.addMember(l, Lua_UnityEngine_SliderJoint2D.<>f__mg$cache0);
		string name = "autoConfigureAngle";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_autoConfigureAngle);
		}
		LuaCSFunction get = Lua_UnityEngine_SliderJoint2D.<>f__mg$cache1;
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.set_autoConfigureAngle);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_SliderJoint2D.<>f__mg$cache2, true);
		string name2 = "angle";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_angle);
		}
		LuaCSFunction get2 = Lua_UnityEngine_SliderJoint2D.<>f__mg$cache3;
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.set_angle);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_SliderJoint2D.<>f__mg$cache4, true);
		string name3 = "useMotor";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_useMotor);
		}
		LuaCSFunction get3 = Lua_UnityEngine_SliderJoint2D.<>f__mg$cache5;
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.set_useMotor);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_SliderJoint2D.<>f__mg$cache6, true);
		string name4 = "useLimits";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_useLimits);
		}
		LuaCSFunction get4 = Lua_UnityEngine_SliderJoint2D.<>f__mg$cache7;
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.set_useLimits);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_SliderJoint2D.<>f__mg$cache8, true);
		string name5 = "motor";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_motor);
		}
		LuaCSFunction get5 = Lua_UnityEngine_SliderJoint2D.<>f__mg$cache9;
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.set_motor);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheA, true);
		string name6 = "limits";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_limits);
		}
		LuaCSFunction get6 = Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheB;
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.set_limits);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheC, true);
		string name7 = "limitState";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_limitState);
		}
		LuaObject.addMember(l, name7, Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheD, null, true);
		string name8 = "referenceAngle";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_referenceAngle);
		}
		LuaObject.addMember(l, name8, Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheE, null, true);
		string name9 = "jointTranslation";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_jointTranslation);
		}
		LuaObject.addMember(l, name9, Lua_UnityEngine_SliderJoint2D.<>f__mg$cacheF, null, true);
		string name10 = "jointSpeed";
		if (Lua_UnityEngine_SliderJoint2D.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_SliderJoint2D.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_SliderJoint2D.get_jointSpeed);
		}
		LuaObject.addMember(l, name10, Lua_UnityEngine_SliderJoint2D.<>f__mg$cache10, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(SliderJoint2D), typeof(AnchoredJoint2D));
	}

	// Token: 0x040199E8 RID: 104936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040199E9 RID: 104937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040199EA RID: 104938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040199EB RID: 104939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040199EC RID: 104940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040199ED RID: 104941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040199EE RID: 104942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040199EF RID: 104943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040199F0 RID: 104944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040199F1 RID: 104945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040199F2 RID: 104946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040199F3 RID: 104947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040199F4 RID: 104948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040199F5 RID: 104949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040199F6 RID: 104950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040199F7 RID: 104951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040199F8 RID: 104952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
