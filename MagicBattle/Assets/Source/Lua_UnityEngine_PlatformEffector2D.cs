using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200173E RID: 5950
[Preserve]
public class Lua_UnityEngine_PlatformEffector2D : LuaObject
{
	// Token: 0x060237A8 RID: 145320 RVA: 0x00C62EB8 File Offset: 0x00C610B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useOneWay(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.useOneWay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237A9 RID: 145321 RVA: 0x00C62F0C File Offset: 0x00C6110C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useOneWay(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			bool useOneWay;
			LuaObject.checkType(l, 2, out useOneWay);
			platformEffector2D.useOneWay = useOneWay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237AA RID: 145322 RVA: 0x00C62F64 File Offset: 0x00C61164
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_useOneWayGrouping(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.useOneWayGrouping);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237AB RID: 145323 RVA: 0x00C62FB8 File Offset: 0x00C611B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useOneWayGrouping(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			bool useOneWayGrouping;
			LuaObject.checkType(l, 2, out useOneWayGrouping);
			platformEffector2D.useOneWayGrouping = useOneWayGrouping;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237AC RID: 145324 RVA: 0x00C63010 File Offset: 0x00C61210
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useSideFriction(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.useSideFriction);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237AD RID: 145325 RVA: 0x00C63064 File Offset: 0x00C61264
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_useSideFriction(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			bool useSideFriction;
			LuaObject.checkType(l, 2, out useSideFriction);
			platformEffector2D.useSideFriction = useSideFriction;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237AE RID: 145326 RVA: 0x00C630BC File Offset: 0x00C612BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useSideBounce(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.useSideBounce);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237AF RID: 145327 RVA: 0x00C63110 File Offset: 0x00C61310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useSideBounce(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			bool useSideBounce;
			LuaObject.checkType(l, 2, out useSideBounce);
			platformEffector2D.useSideBounce = useSideBounce;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B0 RID: 145328 RVA: 0x00C63168 File Offset: 0x00C61368
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_surfaceArc(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.surfaceArc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B1 RID: 145329 RVA: 0x00C631BC File Offset: 0x00C613BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_surfaceArc(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			float surfaceArc;
			LuaObject.checkType(l, 2, out surfaceArc);
			platformEffector2D.surfaceArc = surfaceArc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B2 RID: 145330 RVA: 0x00C63214 File Offset: 0x00C61414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sideArc(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.sideArc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B3 RID: 145331 RVA: 0x00C63268 File Offset: 0x00C61468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sideArc(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			float sideArc;
			LuaObject.checkType(l, 2, out sideArc);
			platformEffector2D.sideArc = sideArc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B4 RID: 145332 RVA: 0x00C632C0 File Offset: 0x00C614C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_rotationalOffset(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, platformEffector2D.rotationalOffset);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B5 RID: 145333 RVA: 0x00C63314 File Offset: 0x00C61514
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_rotationalOffset(IntPtr l)
	{
		int result;
		try
		{
			PlatformEffector2D platformEffector2D = (PlatformEffector2D)LuaObject.checkSelf(l);
			float rotationalOffset;
			LuaObject.checkType(l, 2, out rotationalOffset);
			platformEffector2D.rotationalOffset = rotationalOffset;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B6 RID: 145334 RVA: 0x00C6336C File Offset: 0x00C6156C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PlatformEffector2D");
		string name = "useOneWay";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_useOneWay);
		}
		LuaCSFunction get = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache0;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_useOneWay);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache1, true);
		string name2 = "useOneWayGrouping";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_useOneWayGrouping);
		}
		LuaCSFunction get2 = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache2;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_useOneWayGrouping);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache3, true);
		string name3 = "useSideFriction";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_useSideFriction);
		}
		LuaCSFunction get3 = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache4;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_useSideFriction);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache5, true);
		string name4 = "useSideBounce";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_useSideBounce);
		}
		LuaCSFunction get4 = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache6;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_useSideBounce);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache7, true);
		string name5 = "surfaceArc";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_surfaceArc);
		}
		LuaCSFunction get5 = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache8;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_surfaceArc);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cache9, true);
		string name6 = "sideArc";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_sideArc);
		}
		LuaCSFunction get6 = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_sideArc);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheB, true);
		string name7 = "rotationalOffset";
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.get_rotationalOffset);
		}
		LuaCSFunction get7 = Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheC;
		if (Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_PlatformEffector2D.set_rotationalOffset);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_PlatformEffector2D.<>f__mg$cacheD, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlatformEffector2D), typeof(Effector2D));
	}

	// Token: 0x0401958A RID: 103818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401958B RID: 103819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401958C RID: 103820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401958D RID: 103821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401958E RID: 103822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401958F RID: 103823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019590 RID: 103824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019591 RID: 103825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019592 RID: 103826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04019593 RID: 103827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04019594 RID: 103828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04019595 RID: 103829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04019596 RID: 103830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04019597 RID: 103831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
