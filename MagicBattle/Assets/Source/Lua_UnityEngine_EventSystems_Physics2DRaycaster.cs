using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016BB RID: 5819
[Preserve]
public class Lua_UnityEngine_EventSystems_Physics2DRaycaster : LuaObject
{
	// Token: 0x06023195 RID: 143765 RVA: 0x00C28260 File Offset: 0x00C26460
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Raycast(IntPtr l)
	{
		int result;
		try
		{
			Physics2DRaycaster physics2DRaycaster = (Physics2DRaycaster)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			List<RaycastResult> resultAppendList;
			LuaObject.checkType<List<RaycastResult>>(l, 3, out resultAppendList);
			physics2DRaycaster.Raycast(eventData, resultAppendList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023196 RID: 143766 RVA: 0x00C282C4 File Offset: 0x00C264C4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.Physics2DRaycaster");
		if (Lua_UnityEngine_EventSystems_Physics2DRaycaster.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_Physics2DRaycaster.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_Physics2DRaycaster.Raycast);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_Physics2DRaycaster.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(Physics2DRaycaster), typeof(PhysicsRaycaster));
	}

	// Token: 0x0401907D RID: 102525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
