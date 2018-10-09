using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016A8 RID: 5800
[Preserve]
public class Lua_UnityEngine_EventSystems_IBeginDragHandler : LuaObject
{
	// Token: 0x0602315E RID: 143710 RVA: 0x00C27668 File Offset: 0x00C25868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBeginDrag(IntPtr l)
	{
		int result;
		try
		{
			IBeginDragHandler beginDragHandler = (IBeginDragHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			beginDragHandler.OnBeginDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602315F RID: 143711 RVA: 0x00C276C0 File Offset: 0x00C258C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IBeginDragHandler");
		if (Lua_UnityEngine_EventSystems_IBeginDragHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IBeginDragHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IBeginDragHandler.OnBeginDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IBeginDragHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IBeginDragHandler));
	}

	// Token: 0x0401906C RID: 102508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
