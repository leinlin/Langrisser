using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016AF RID: 5807
[Preserve]
public class Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler : LuaObject
{
	// Token: 0x06023172 RID: 143730 RVA: 0x00C27A98 File Offset: 0x00C25C98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnInitializePotentialDrag(IntPtr l)
	{
		int result;
		try
		{
			IInitializePotentialDragHandler initializePotentialDragHandler = (IInitializePotentialDragHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			initializePotentialDragHandler.OnInitializePotentialDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023173 RID: 143731 RVA: 0x00C27AF0 File Offset: 0x00C25CF0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IInitializePotentialDragHandler");
		if (Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler.OnInitializePotentialDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IInitializePotentialDragHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IInitializePotentialDragHandler));
	}

	// Token: 0x04019072 RID: 102514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
