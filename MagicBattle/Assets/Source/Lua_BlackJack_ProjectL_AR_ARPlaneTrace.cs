using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.AR;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x0200118C RID: 4492
[Preserve]
public class Lua_BlackJack_ProjectL_AR_ARPlaneTrace : LuaObject
{
	// Token: 0x06016FF6 RID: 94198 RVA: 0x0062E408 File Offset: 0x0062C608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace o = new ARPlaneTrace();
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

	// Token: 0x06016FF7 RID: 94199 RVA: 0x0062E450 File Offset: 0x0062C650
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			arplaneTrace.Init(camera);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF8 RID: 94200 RVA: 0x0062E4A8 File Offset: 0x0062C6A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Update(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			arplaneTrace.Update();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FF9 RID: 94201 RVA: 0x0062E4F4 File Offset: 0x0062C6F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CalculateLookVector(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			Vector3 srcPos;
			LuaObject.checkType(l, 2, out srcPos);
			Vector3 destPos;
			LuaObject.checkType(l, 3, out destPos);
			Quaternion o = arplaneTrace.m_luaExportHelper.CalculateLookVector(srcPos, destPos);
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

	// Token: 0x06016FFA RID: 94202 RVA: 0x0062E568 File Offset: 0x0062C768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_centerPos(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.centerPos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FFB RID: 94203 RVA: 0x0062E5BC File Offset: 0x0062C7BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_centerPos(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			Vector3 centerPos;
			LuaObject.checkType(l, 2, out centerPos);
			arplaneTrace.centerPos = centerPos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FFC RID: 94204 RVA: 0x0062E614 File Offset: 0x0062C814
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_centerRotation(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.centerRotation);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FFD RID: 94205 RVA: 0x0062E668 File Offset: 0x0062C868
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_centerRotation(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			Quaternion centerRotation;
			LuaObject.checkType(l, 2, out centerRotation);
			arplaneTrace.centerRotation = centerRotation;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FFE RID: 94206 RVA: 0x0062E6C0 File Offset: 0x0062C8C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_camera(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.camera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016FFF RID: 94207 RVA: 0x0062E714 File Offset: 0x0062C914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_camera(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			Camera camera;
			LuaObject.checkType<Camera>(l, 2, out camera);
			arplaneTrace.camera = camera;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017000 RID: 94208 RVA: 0x0062E76C File Offset: 0x0062C96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxRayDistance(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.m_luaExportHelper.maxRayDistance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017001 RID: 94209 RVA: 0x0062E7C4 File Offset: 0x0062C9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxRayDistance(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			float maxRayDistance;
			LuaObject.checkType(l, 2, out maxRayDistance);
			arplaneTrace.m_luaExportHelper.maxRayDistance = maxRayDistance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017002 RID: 94210 RVA: 0x0062E820 File Offset: 0x0062CA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_collisionLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.m_luaExportHelper.collisionLayerMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017003 RID: 94211 RVA: 0x0062E87C File Offset: 0x0062CA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_collisionLayerMask(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LayerMask collisionLayerMask;
			LuaObject.checkValueType<LayerMask>(l, 2, out collisionLayerMask);
			arplaneTrace.m_luaExportHelper.collisionLayerMask = collisionLayerMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017004 RID: 94212 RVA: 0x0062E8D8 File Offset: 0x0062CAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_findingSquareDist(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.m_luaExportHelper.findingSquareDist);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017005 RID: 94213 RVA: 0x0062E930 File Offset: 0x0062CB30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_findingSquareDist(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			float findingSquareDist;
			LuaObject.checkType(l, 2, out findingSquareDist);
			arplaneTrace.m_luaExportHelper.findingSquareDist = findingSquareDist;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017006 RID: 94214 RVA: 0x0062E98C File Offset: 0x0062CB8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_squareState(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arplaneTrace.m_luaExportHelper.squareState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017007 RID: 94215 RVA: 0x0062E9E4 File Offset: 0x0062CBE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_squareState(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			ARPlaneTrace.FocusState squareState;
			LuaObject.checkEnum<ARPlaneTrace.FocusState>(l, 2, out squareState);
			arplaneTrace.m_luaExportHelper.squareState = squareState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017008 RID: 94216 RVA: 0x0062EA40 File Offset: 0x0062CC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_trackingInitialized(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arplaneTrace.m_luaExportHelper.trackingInitialized);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017009 RID: 94217 RVA: 0x0062EA98 File Offset: 0x0062CC98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_trackingInitialized(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			bool trackingInitialized;
			LuaObject.checkType(l, 2, out trackingInitialized);
			arplaneTrace.m_luaExportHelper.trackingInitialized = trackingInitialized;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601700A RID: 94218 RVA: 0x0062EAF4 File Offset: 0x0062CCF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SquareState(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)arplaneTrace.SquareState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601700B RID: 94219 RVA: 0x0062EB48 File Offset: 0x0062CD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SquareState(IntPtr l)
	{
		int result;
		try
		{
			ARPlaneTrace arplaneTrace = (ARPlaneTrace)LuaObject.checkSelf(l);
			ARPlaneTrace.FocusState squareState;
			LuaObject.checkEnum<ARPlaneTrace.FocusState>(l, 2, out squareState);
			arplaneTrace.SquareState = squareState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601700C RID: 94220 RVA: 0x0062EBA0 File Offset: 0x0062CDA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.AR.ARPlaneTrace");
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.Update);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.CalculateLookVector);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache2);
		string name = "centerPos";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_centerPos);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_centerPos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache4, true);
		string name2 = "centerRotation";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_centerRotation);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_centerRotation);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache6, true);
		string name3 = "camera";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_camera);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_camera);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache8, true);
		string name4 = "maxRayDistance";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_maxRayDistance);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_maxRayDistance);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheA, true);
		string name5 = "collisionLayerMask";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_collisionLayerMask);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_collisionLayerMask);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheC, true);
		string name6 = "findingSquareDist";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_findingSquareDist);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_findingSquareDist);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheE, true);
		string name7 = "squareState";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_squareState);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_squareState);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache10, true);
		string name8 = "trackingInitialized";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_trackingInitialized);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_trackingInitialized);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache12, true);
		string name9 = "SquareState";
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.get_SquareState);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.set_SquareState);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache14, true);
		if (Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_AR_ARPlaneTrace.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_AR_ARPlaneTrace.<>f__mg$cache15, typeof(ARPlaneTrace));
	}

	// Token: 0x0400D6C0 RID: 54976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D6C1 RID: 54977
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D6C2 RID: 54978
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D6C3 RID: 54979
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D6C4 RID: 54980
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D6C5 RID: 54981
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D6C6 RID: 54982
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D6C7 RID: 54983
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D6C8 RID: 54984
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D6C9 RID: 54985
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D6CA RID: 54986
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D6CB RID: 54987
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D6CC RID: 54988
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D6CD RID: 54989
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D6CE RID: 54990
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D6CF RID: 54991
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D6D0 RID: 54992
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D6D1 RID: 54993
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D6D2 RID: 54994
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D6D3 RID: 54995
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D6D4 RID: 54996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D6D5 RID: 54997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;
}
