using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016BC RID: 5820
[Preserve]
public class Lua_UnityEngine_EventSystems_PhysicsRaycaster : LuaObject
{
	// Token: 0x06023198 RID: 143768 RVA: 0x00C28324 File Offset: 0x00C26524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			List<RaycastResult> resultAppendList;
			LuaObject.checkType<List<RaycastResult>>(l, 3, out resultAppendList);
			physicsRaycaster.Raycast(eventData, resultAppendList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023199 RID: 143769 RVA: 0x00C28388 File Offset: 0x00C26588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eventCamera(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsRaycaster.eventCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602319A RID: 143770 RVA: 0x00C283DC File Offset: 0x00C265DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_depth(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsRaycaster.depth);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602319B RID: 143771 RVA: 0x00C28430 File Offset: 0x00C26630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_finalEventMask(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsRaycaster.finalEventMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602319C RID: 143772 RVA: 0x00C28484 File Offset: 0x00C26684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eventMask(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsRaycaster.eventMask);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602319D RID: 143773 RVA: 0x00C284DC File Offset: 0x00C266DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_eventMask(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			LayerMask eventMask;
			LuaObject.checkValueType<LayerMask>(l, 2, out eventMask);
			physicsRaycaster.eventMask = eventMask;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602319E RID: 143774 RVA: 0x00C28534 File Offset: 0x00C26734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_maxRayIntersections(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, physicsRaycaster.maxRayIntersections);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602319F RID: 143775 RVA: 0x00C28588 File Offset: 0x00C26788
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_maxRayIntersections(IntPtr l)
	{
		int result;
		try
		{
			PhysicsRaycaster physicsRaycaster = (PhysicsRaycaster)LuaObject.checkSelf(l);
			int maxRayIntersections;
			LuaObject.checkType(l, 2, out maxRayIntersections);
			physicsRaycaster.maxRayIntersections = maxRayIntersections;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060231A0 RID: 143776 RVA: 0x00C285E0 File Offset: 0x00C267E0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.PhysicsRaycaster");
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache0);
		string name = "eventCamera";
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.get_eventCamera);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache1, null, true);
		string name2 = "depth";
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.get_depth);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache2, null, true);
		string name3 = "finalEventMask";
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.get_finalEventMask);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache3, null, true);
		string name4 = "eventMask";
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.get_eventMask);
		}
		LuaCSFunction get = Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache4;
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.set_eventMask);
		}
		LuaObject.addMember(l, name4, get, Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache5, true);
		string name5 = "maxRayIntersections";
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.get_maxRayIntersections);
		}
		LuaCSFunction get2 = Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache6;
		if (Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_EventSystems_PhysicsRaycaster.set_maxRayIntersections);
		}
		LuaObject.addMember(l, name5, get2, Lua_UnityEngine_EventSystems_PhysicsRaycaster.<>f__mg$cache7, true);
		LuaObject.createTypeMetatable(l, null, typeof(PhysicsRaycaster), typeof(BaseRaycaster));
	}

	// Token: 0x0401907E RID: 102526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401907F RID: 102527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04019080 RID: 102528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04019081 RID: 102529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04019082 RID: 102530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04019083 RID: 102531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04019084 RID: 102532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04019085 RID: 102533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
