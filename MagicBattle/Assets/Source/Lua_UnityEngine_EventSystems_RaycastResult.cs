using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016C2 RID: 5826
[Preserve]
public class Lua_UnityEngine_EventSystems_RaycastResult : LuaObject
{
	// Token: 0x060231E2 RID: 143842 RVA: 0x00C2A1E4 File Offset: 0x00C283E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult = default(RaycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E3 RID: 143843 RVA: 0x00C2A234 File Offset: 0x00C28434
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			raycastResult.Clear();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, raycastResult);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E4 RID: 143844 RVA: 0x00C2A28C File Offset: 0x00C2848C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_module(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.module);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E5 RID: 143845 RVA: 0x00C2A2E0 File Offset: 0x00C284E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_module(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			BaseRaycaster module;
			LuaObject.checkType<BaseRaycaster>(l, 2, out module);
			raycastResult.module = module;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E6 RID: 143846 RVA: 0x00C2A344 File Offset: 0x00C28544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_distance(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.distance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E7 RID: 143847 RVA: 0x00C2A398 File Offset: 0x00C28598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_distance(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			float distance;
			LuaObject.checkType(l, 2, out distance);
			raycastResult.distance = distance;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E8 RID: 143848 RVA: 0x00C2A3FC File Offset: 0x00C285FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_index(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231E9 RID: 143849 RVA: 0x00C2A450 File Offset: 0x00C28650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_index(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			float index;
			LuaObject.checkType(l, 2, out index);
			raycastResult.index = index;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231EA RID: 143850 RVA: 0x00C2A4B4 File Offset: 0x00C286B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231EB RID: 143851 RVA: 0x00C2A508 File Offset: 0x00C28708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_depth(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			int depth;
			LuaObject.checkType(l, 2, out depth);
			raycastResult.depth = depth;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231EC RID: 143852 RVA: 0x00C2A56C File Offset: 0x00C2876C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingLayer(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.sortingLayer);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231ED RID: 143853 RVA: 0x00C2A5C0 File Offset: 0x00C287C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingLayer(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			int sortingLayer;
			LuaObject.checkType(l, 2, out sortingLayer);
			raycastResult.sortingLayer = sortingLayer;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231EE RID: 143854 RVA: 0x00C2A624 File Offset: 0x00C28824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.sortingOrder);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231EF RID: 143855 RVA: 0x00C2A678 File Offset: 0x00C28878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_sortingOrder(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			int sortingOrder;
			LuaObject.checkType(l, 2, out sortingOrder);
			raycastResult.sortingOrder = sortingOrder;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F0 RID: 143856 RVA: 0x00C2A6DC File Offset: 0x00C288DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldPosition(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.worldPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F1 RID: 143857 RVA: 0x00C2A730 File Offset: 0x00C28930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_worldPosition(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			Vector3 worldPosition;
			LuaObject.checkType(l, 2, out worldPosition);
			raycastResult.worldPosition = worldPosition;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F2 RID: 143858 RVA: 0x00C2A794 File Offset: 0x00C28994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_worldNormal(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.worldNormal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F3 RID: 143859 RVA: 0x00C2A7E8 File Offset: 0x00C289E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_worldNormal(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			Vector3 worldNormal;
			LuaObject.checkType(l, 2, out worldNormal);
			raycastResult.worldNormal = worldNormal;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F4 RID: 143860 RVA: 0x00C2A84C File Offset: 0x00C28A4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_screenPosition(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.screenPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F5 RID: 143861 RVA: 0x00C2A8A0 File Offset: 0x00C28AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_screenPosition(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			Vector2 screenPosition;
			LuaObject.checkType(l, 2, out screenPosition);
			raycastResult.screenPosition = screenPosition;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F6 RID: 143862 RVA: 0x00C2A904 File Offset: 0x00C28B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_gameObject(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.gameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F7 RID: 143863 RVA: 0x00C2A958 File Offset: 0x00C28B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_gameObject(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			GameObject gameObject;
			LuaObject.checkType<GameObject>(l, 2, out gameObject);
			raycastResult.gameObject = gameObject;
			LuaObject.setBack(l, raycastResult);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F8 RID: 143864 RVA: 0x00C2A9BC File Offset: 0x00C28BBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isValid(IntPtr l)
	{
		int result;
		try
		{
			RaycastResult raycastResult;
			LuaObject.checkValueType<RaycastResult>(l, 1, out raycastResult);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, raycastResult.isValid);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231F9 RID: 143865 RVA: 0x00C2AA10 File Offset: 0x00C28C10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.RaycastResult");
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.Clear);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache0);
		string name = "module";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_module);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache1;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_module);
		}
		LuaObject.addMember(l, name, get, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache2, true);
		string name2 = "distance";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_distance);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache3;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_distance);
		}
		LuaObject.addMember(l, name2, get2, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache4, true);
		string name3 = "index";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_index);
		}
		LuaCSFunction get3 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache5;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_index);
		}
		LuaObject.addMember(l, name3, get3, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache6, true);
		string name4 = "depth";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_depth);
		}
		LuaCSFunction get4 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache7;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_depth);
		}
		LuaObject.addMember(l, name4, get4, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache8, true);
		string name5 = "sortingLayer";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_sortingLayer);
		}
		LuaCSFunction get5 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache9;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_sortingLayer);
		}
		LuaObject.addMember(l, name5, get5, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheA, true);
		string name6 = "sortingOrder";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_sortingOrder);
		}
		LuaCSFunction get6 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheB;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_sortingOrder);
		}
		LuaObject.addMember(l, name6, get6, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheC, true);
		string name7 = "worldPosition";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_worldPosition);
		}
		LuaCSFunction get7 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheD;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_worldPosition);
		}
		LuaObject.addMember(l, name7, get7, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheE, true);
		string name8 = "worldNormal";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_worldNormal);
		}
		LuaCSFunction get8 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cacheF;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_worldNormal);
		}
		LuaObject.addMember(l, name8, get8, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache10, true);
		string name9 = "screenPosition";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_screenPosition);
		}
		LuaCSFunction get9 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache11;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache12 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache12 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_screenPosition);
		}
		LuaObject.addMember(l, name9, get9, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache12, true);
		string name10 = "gameObject";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache13 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache13 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_gameObject);
		}
		LuaCSFunction get10 = Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache13;
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache14 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache14 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.set_gameObject);
		}
		LuaObject.addMember(l, name10, get10, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache14, true);
		string name11 = "isValid";
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache15 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache15 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.get_isValid);
		}
		LuaObject.addMember(l, name11, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache15, null, true);
		if (Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache16 == null)
		{
			Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache16 = new LuaCSFunction(Lua_UnityEngine_EventSystems_RaycastResult.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_EventSystems_RaycastResult.<>f__mg$cache16, typeof(RaycastResult), typeof(ValueType));
	}

	// Token: 0x040190BC RID: 102588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040190BD RID: 102589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040190BE RID: 102590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040190BF RID: 102591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040190C0 RID: 102592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040190C1 RID: 102593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040190C2 RID: 102594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040190C3 RID: 102595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040190C4 RID: 102596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040190C5 RID: 102597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040190C6 RID: 102598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040190C7 RID: 102599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040190C8 RID: 102600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040190C9 RID: 102601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040190CA RID: 102602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040190CB RID: 102603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040190CC RID: 102604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040190CD RID: 102605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040190CE RID: 102606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040190CF RID: 102607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040190D0 RID: 102608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040190D1 RID: 102609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040190D2 RID: 102610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
