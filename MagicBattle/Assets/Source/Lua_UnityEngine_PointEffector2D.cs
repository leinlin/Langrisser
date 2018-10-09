using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001757 RID: 5975
[Preserve]
public class Lua_UnityEngine_PointEffector2D : LuaObject
{
	// Token: 0x06023851 RID: 145489 RVA: 0x00C66FD8 File Offset: 0x00C651D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceMagnitude(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointEffector2D.forceMagnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023852 RID: 145490 RVA: 0x00C6702C File Offset: 0x00C6522C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceMagnitude(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			float forceMagnitude;
			LuaObject.checkType(l, 2, out forceMagnitude);
			pointEffector2D.forceMagnitude = forceMagnitude;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023853 RID: 145491 RVA: 0x00C67084 File Offset: 0x00C65284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceVariation(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointEffector2D.forceVariation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023854 RID: 145492 RVA: 0x00C670D8 File Offset: 0x00C652D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceVariation(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			float forceVariation;
			LuaObject.checkType(l, 2, out forceVariation);
			pointEffector2D.forceVariation = forceVariation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023855 RID: 145493 RVA: 0x00C67130 File Offset: 0x00C65330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distanceScale(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointEffector2D.distanceScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023856 RID: 145494 RVA: 0x00C67184 File Offset: 0x00C65384
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_distanceScale(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			float distanceScale;
			LuaObject.checkType(l, 2, out distanceScale);
			pointEffector2D.distanceScale = distanceScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023857 RID: 145495 RVA: 0x00C671DC File Offset: 0x00C653DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_drag(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointEffector2D.drag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023858 RID: 145496 RVA: 0x00C67230 File Offset: 0x00C65430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_drag(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			float drag;
			LuaObject.checkType(l, 2, out drag);
			pointEffector2D.drag = drag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023859 RID: 145497 RVA: 0x00C67288 File Offset: 0x00C65488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, pointEffector2D.angularDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602385A RID: 145498 RVA: 0x00C672DC File Offset: 0x00C654DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			float angularDrag;
			LuaObject.checkType(l, 2, out angularDrag);
			pointEffector2D.angularDrag = angularDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602385B RID: 145499 RVA: 0x00C67334 File Offset: 0x00C65534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceSource(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pointEffector2D.forceSource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602385C RID: 145500 RVA: 0x00C67388 File Offset: 0x00C65588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceSource(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			EffectorSelection2D forceSource;
			LuaObject.checkEnum<EffectorSelection2D>(l, 2, out forceSource);
			pointEffector2D.forceSource = forceSource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602385D RID: 145501 RVA: 0x00C673E0 File Offset: 0x00C655E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceTarget(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pointEffector2D.forceTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602385E RID: 145502 RVA: 0x00C67434 File Offset: 0x00C65634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceTarget(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			EffectorSelection2D forceTarget;
			LuaObject.checkEnum<EffectorSelection2D>(l, 2, out forceTarget);
			pointEffector2D.forceTarget = forceTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602385F RID: 145503 RVA: 0x00C6748C File Offset: 0x00C6568C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceMode(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)pointEffector2D.forceMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023860 RID: 145504 RVA: 0x00C674E0 File Offset: 0x00C656E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceMode(IntPtr l)
	{
		int result;
		try
		{
			PointEffector2D pointEffector2D = (PointEffector2D)LuaObject.checkSelf(l);
			EffectorForceMode2D forceMode;
			LuaObject.checkEnum<EffectorForceMode2D>(l, 2, out forceMode);
			pointEffector2D.forceMode = forceMode;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023861 RID: 145505 RVA: 0x00C67538 File Offset: 0x00C65738
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.PointEffector2D");
		string name = "forceMagnitude";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_forceMagnitude);
		}
		LuaCSFunction get = Lua_UnityEngine_PointEffector2D.<>f__mg$cache0;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_forceMagnitude);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_PointEffector2D.<>f__mg$cache1, true);
		string name2 = "forceVariation";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_forceVariation);
		}
		LuaCSFunction get2 = Lua_UnityEngine_PointEffector2D.<>f__mg$cache2;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_forceVariation);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_PointEffector2D.<>f__mg$cache3, true);
		string name3 = "distanceScale";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_distanceScale);
		}
		LuaCSFunction get3 = Lua_UnityEngine_PointEffector2D.<>f__mg$cache4;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_distanceScale);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_PointEffector2D.<>f__mg$cache5, true);
		string name4 = "drag";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_drag);
		}
		LuaCSFunction get4 = Lua_UnityEngine_PointEffector2D.<>f__mg$cache6;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_drag);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_PointEffector2D.<>f__mg$cache7, true);
		string name5 = "angularDrag";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_angularDrag);
		}
		LuaCSFunction get5 = Lua_UnityEngine_PointEffector2D.<>f__mg$cache8;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_angularDrag);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_PointEffector2D.<>f__mg$cache9, true);
		string name6 = "forceSource";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_forceSource);
		}
		LuaCSFunction get6 = Lua_UnityEngine_PointEffector2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_forceSource);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_PointEffector2D.<>f__mg$cacheB, true);
		string name7 = "forceTarget";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_forceTarget);
		}
		LuaCSFunction get7 = Lua_UnityEngine_PointEffector2D.<>f__mg$cacheC;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_forceTarget);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_PointEffector2D.<>f__mg$cacheD, true);
		string name8 = "forceMode";
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.get_forceMode);
		}
		LuaCSFunction get8 = Lua_UnityEngine_PointEffector2D.<>f__mg$cacheE;
		if (Lua_UnityEngine_PointEffector2D.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_PointEffector2D.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_PointEffector2D.set_forceMode);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_PointEffector2D.<>f__mg$cacheF, true);
		LuaObject.createTypeMetatable(l, null, typeof(PointEffector2D), typeof(Effector2D));
	}

	// Token: 0x04019601 RID: 103937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019602 RID: 103938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019603 RID: 103939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019604 RID: 103940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019605 RID: 103941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019606 RID: 103942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019607 RID: 103943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019608 RID: 103944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04019609 RID: 103945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401960A RID: 103946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401960B RID: 103947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401960C RID: 103948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401960D RID: 103949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401960E RID: 103950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401960F RID: 103951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04019610 RID: 103952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
