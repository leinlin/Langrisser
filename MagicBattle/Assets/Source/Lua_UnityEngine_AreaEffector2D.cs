using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200162C RID: 5676
[Preserve]
public class Lua_UnityEngine_AreaEffector2D : LuaObject
{
	// Token: 0x06022BC1 RID: 142273 RVA: 0x00BFCF84 File Offset: 0x00BFB184
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_forceAngle(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areaEffector2D.forceAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC2 RID: 142274 RVA: 0x00BFCFD8 File Offset: 0x00BFB1D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceAngle(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			float forceAngle;
			LuaObject.checkType(l, 2, out forceAngle);
			areaEffector2D.forceAngle = forceAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC3 RID: 142275 RVA: 0x00BFD030 File Offset: 0x00BFB230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_useGlobalAngle(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areaEffector2D.useGlobalAngle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC4 RID: 142276 RVA: 0x00BFD084 File Offset: 0x00BFB284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_useGlobalAngle(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			bool useGlobalAngle;
			LuaObject.checkType(l, 2, out useGlobalAngle);
			areaEffector2D.useGlobalAngle = useGlobalAngle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC5 RID: 142277 RVA: 0x00BFD0DC File Offset: 0x00BFB2DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_forceMagnitude(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areaEffector2D.forceMagnitude);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC6 RID: 142278 RVA: 0x00BFD130 File Offset: 0x00BFB330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_forceMagnitude(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			float forceMagnitude;
			LuaObject.checkType(l, 2, out forceMagnitude);
			areaEffector2D.forceMagnitude = forceMagnitude;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC7 RID: 142279 RVA: 0x00BFD188 File Offset: 0x00BFB388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceVariation(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areaEffector2D.forceVariation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC8 RID: 142280 RVA: 0x00BFD1DC File Offset: 0x00BFB3DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_forceVariation(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			float forceVariation;
			LuaObject.checkType(l, 2, out forceVariation);
			areaEffector2D.forceVariation = forceVariation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BC9 RID: 142281 RVA: 0x00BFD234 File Offset: 0x00BFB434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_drag(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areaEffector2D.drag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BCA RID: 142282 RVA: 0x00BFD288 File Offset: 0x00BFB488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_drag(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			float drag;
			LuaObject.checkType(l, 2, out drag);
			areaEffector2D.drag = drag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BCB RID: 142283 RVA: 0x00BFD2E0 File Offset: 0x00BFB4E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, areaEffector2D.angularDrag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BCC RID: 142284 RVA: 0x00BFD334 File Offset: 0x00BFB534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_angularDrag(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			float angularDrag;
			LuaObject.checkType(l, 2, out angularDrag);
			areaEffector2D.angularDrag = angularDrag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BCD RID: 142285 RVA: 0x00BFD38C File Offset: 0x00BFB58C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_forceTarget(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)areaEffector2D.forceTarget);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BCE RID: 142286 RVA: 0x00BFD3E0 File Offset: 0x00BFB5E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_forceTarget(IntPtr l)
	{
		int result;
		try
		{
			AreaEffector2D areaEffector2D = (AreaEffector2D)LuaObject.checkSelf(l);
			EffectorSelection2D forceTarget;
			LuaObject.checkEnum<EffectorSelection2D>(l, 2, out forceTarget);
			areaEffector2D.forceTarget = forceTarget;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022BCF RID: 142287 RVA: 0x00BFD438 File Offset: 0x00BFB638
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.AreaEffector2D");
		string name = "forceAngle";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_forceAngle);
		}
		LuaCSFunction get = Lua_UnityEngine_AreaEffector2D.<>f__mg$cache0;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_forceAngle);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_AreaEffector2D.<>f__mg$cache1, true);
		string name2 = "useGlobalAngle";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_useGlobalAngle);
		}
		LuaCSFunction get2 = Lua_UnityEngine_AreaEffector2D.<>f__mg$cache2;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_useGlobalAngle);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_AreaEffector2D.<>f__mg$cache3, true);
		string name3 = "forceMagnitude";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_forceMagnitude);
		}
		LuaCSFunction get3 = Lua_UnityEngine_AreaEffector2D.<>f__mg$cache4;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_forceMagnitude);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_AreaEffector2D.<>f__mg$cache5, true);
		string name4 = "forceVariation";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_forceVariation);
		}
		LuaCSFunction get4 = Lua_UnityEngine_AreaEffector2D.<>f__mg$cache6;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_forceVariation);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_AreaEffector2D.<>f__mg$cache7, true);
		string name5 = "drag";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_drag);
		}
		LuaCSFunction get5 = Lua_UnityEngine_AreaEffector2D.<>f__mg$cache8;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_drag);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_AreaEffector2D.<>f__mg$cache9, true);
		string name6 = "angularDrag";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_angularDrag);
		}
		LuaCSFunction get6 = Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheA;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_angularDrag);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheB, true);
		string name7 = "forceTarget";
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.get_forceTarget);
		}
		LuaCSFunction get7 = Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheC;
		if (Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_AreaEffector2D.set_forceTarget);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_AreaEffector2D.<>f__mg$cacheD, true);
		LuaObject.createTypeMetatable(l, null, typeof(AreaEffector2D), typeof(Effector2D));
	}

	// Token: 0x04018BC7 RID: 101319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018BC8 RID: 101320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018BC9 RID: 101321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018BCA RID: 101322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018BCB RID: 101323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018BCC RID: 101324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018BCD RID: 101325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04018BCE RID: 101326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04018BCF RID: 101327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04018BD0 RID: 101328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04018BD1 RID: 101329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04018BD2 RID: 101330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04018BD3 RID: 101331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04018BD4 RID: 101332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
