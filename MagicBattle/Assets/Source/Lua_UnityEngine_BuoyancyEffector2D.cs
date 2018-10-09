using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001648 RID: 5704
[Preserve]
public class Lua_UnityEngine_BuoyancyEffector2D : LuaObject
{
	// Token: 0x06022CBF RID: 142527 RVA: 0x00C04910 File Offset: 0x00C02B10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_surfaceLevel(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.surfaceLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC0 RID: 142528 RVA: 0x00C04964 File Offset: 0x00C02B64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_surfaceLevel(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float surfaceLevel;
			LuaObject.checkType(l, 2, out surfaceLevel);
			buoyancyEffector2D.surfaceLevel = surfaceLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC1 RID: 142529 RVA: 0x00C049BC File Offset: 0x00C02BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_density(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.density);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC2 RID: 142530 RVA: 0x00C04A10 File Offset: 0x00C02C10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_density(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float density;
			LuaObject.checkType(l, 2, out density);
			buoyancyEffector2D.density = density;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC3 RID: 142531 RVA: 0x00C04A68 File Offset: 0x00C02C68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_linearDrag(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.linearDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC4 RID: 142532 RVA: 0x00C04ABC File Offset: 0x00C02CBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_linearDrag(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float linearDrag;
			LuaObject.checkType(l, 2, out linearDrag);
			buoyancyEffector2D.linearDrag = linearDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC5 RID: 142533 RVA: 0x00C04B14 File Offset: 0x00C02D14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.angularDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC6 RID: 142534 RVA: 0x00C04B68 File Offset: 0x00C02D68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float angularDrag;
			LuaObject.checkType(l, 2, out angularDrag);
			buoyancyEffector2D.angularDrag = angularDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC7 RID: 142535 RVA: 0x00C04BC0 File Offset: 0x00C02DC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flowAngle(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.flowAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC8 RID: 142536 RVA: 0x00C04C14 File Offset: 0x00C02E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flowAngle(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float flowAngle;
			LuaObject.checkType(l, 2, out flowAngle);
			buoyancyEffector2D.flowAngle = flowAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CC9 RID: 142537 RVA: 0x00C04C6C File Offset: 0x00C02E6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flowMagnitude(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.flowMagnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CCA RID: 142538 RVA: 0x00C04CC0 File Offset: 0x00C02EC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flowMagnitude(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float flowMagnitude;
			LuaObject.checkType(l, 2, out flowMagnitude);
			buoyancyEffector2D.flowMagnitude = flowMagnitude;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CCB RID: 142539 RVA: 0x00C04D18 File Offset: 0x00C02F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_flowVariation(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, buoyancyEffector2D.flowVariation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CCC RID: 142540 RVA: 0x00C04D6C File Offset: 0x00C02F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_flowVariation(IntPtr l)
	{
		int result;
		try
		{
			BuoyancyEffector2D buoyancyEffector2D = (BuoyancyEffector2D)LuaObject.checkSelf(l);
			float flowVariation;
			LuaObject.checkType(l, 2, out flowVariation);
			buoyancyEffector2D.flowVariation = flowVariation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022CCD RID: 142541 RVA: 0x00C04DC4 File Offset: 0x00C02FC4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.BuoyancyEffector2D");
		string name = "surfaceLevel";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_surfaceLevel);
		}
		LuaCSFunction get = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache0;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_surfaceLevel);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache1, true);
		string name2 = "density";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_density);
		}
		LuaCSFunction get2 = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache2;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_density);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache3, true);
		string name3 = "linearDrag";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_linearDrag);
		}
		LuaCSFunction get3 = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache4;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_linearDrag);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache5, true);
		string name4 = "angularDrag";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_angularDrag);
		}
		LuaCSFunction get4 = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache6;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_angularDrag);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache7, true);
		string name5 = "flowAngle";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_flowAngle);
		}
		LuaCSFunction get5 = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache8;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_flowAngle);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cache9, true);
		string name6 = "flowMagnitude";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_flowMagnitude);
		}
		LuaCSFunction get6 = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_flowMagnitude);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheB, true);
		string name7 = "flowVariation";
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.get_flowVariation);
		}
		LuaCSFunction get7 = Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheC;
		if (Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_BuoyancyEffector2D.set_flowVariation);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_BuoyancyEffector2D.<>f__mg$cacheD, true);
		LuaObject.createTypeMetatable(l, null, typeof(BuoyancyEffector2D), typeof(Effector2D));
	}

	// Token: 0x04018C8D RID: 101517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018C8E RID: 101518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018C8F RID: 101519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018C90 RID: 101520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018C91 RID: 101521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018C92 RID: 101522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018C93 RID: 101523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018C94 RID: 101524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018C95 RID: 101525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018C96 RID: 101526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018C97 RID: 101527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018C98 RID: 101528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018C99 RID: 101529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018C9A RID: 101530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
