using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A0 RID: 5792
[Preserve]
public class Lua_UnityEngine_EventSystems_BaseRaycaster : LuaObject
{
	// Token: 0x0602311D RID: 143645 RVA: 0x00C25B98 File Offset: 0x00C23D98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			BaseRaycaster baseRaycaster = (BaseRaycaster)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			List<RaycastResult> resultAppendList;
			LuaObject.checkType<List<RaycastResult>>(l, 3, out resultAppendList);
			baseRaycaster.Raycast(eventData, resultAppendList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602311E RID: 143646 RVA: 0x00C25BFC File Offset: 0x00C23DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_eventCamera(IntPtr l)
	{
		int result;
		try
		{
			BaseRaycaster baseRaycaster = (BaseRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseRaycaster.eventCamera);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602311F RID: 143647 RVA: 0x00C25C50 File Offset: 0x00C23E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sortOrderPriority(IntPtr l)
	{
		int result;
		try
		{
			BaseRaycaster baseRaycaster = (BaseRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseRaycaster.sortOrderPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023120 RID: 143648 RVA: 0x00C25CA4 File Offset: 0x00C23EA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_renderOrderPriority(IntPtr l)
	{
		int result;
		try
		{
			BaseRaycaster baseRaycaster = (BaseRaycaster)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, baseRaycaster.renderOrderPriority);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023121 RID: 143649 RVA: 0x00C25CF8 File Offset: 0x00C23EF8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.BaseRaycaster");
		if (Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseRaycaster.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache0);
		string name = "eventCamera";
		if (Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseRaycaster.get_eventCamera);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache1, null, true);
		string name2 = "sortOrderPriority";
		if (Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseRaycaster.get_sortOrderPriority);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache2, null, true);
		string name3 = "renderOrderPriority";
		if (Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_EventSystems_BaseRaycaster.get_renderOrderPriority);
		}
		LuaObject.addMember(l, name3, Lua_UnityEngine_EventSystems_BaseRaycaster.<>f__mg$cache3, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(BaseRaycaster), typeof(UIBehaviour));
	}

	// Token: 0x0401903B RID: 102459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401903C RID: 102460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401903D RID: 102461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401903E RID: 102462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
