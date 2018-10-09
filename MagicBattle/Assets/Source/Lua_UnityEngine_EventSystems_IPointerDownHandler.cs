using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B2 RID: 5810
[Preserve]
public class Lua_UnityEngine_EventSystems_IPointerDownHandler : LuaObject
{
	// Token: 0x0602317B RID: 143739 RVA: 0x00C27C9C File Offset: 0x00C25E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerDown(IntPtr l)
	{
		int result;
		try
		{
			IPointerDownHandler pointerDownHandler = (IPointerDownHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerDownHandler.OnPointerDown(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602317C RID: 143740 RVA: 0x00C27CF4 File Offset: 0x00C25EF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IPointerDownHandler");
		if (Lua_UnityEngine_EventSystems_IPointerDownHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IPointerDownHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IPointerDownHandler.OnPointerDown);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IPointerDownHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPointerDownHandler));
	}

	// Token: 0x04019075 RID: 102517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
