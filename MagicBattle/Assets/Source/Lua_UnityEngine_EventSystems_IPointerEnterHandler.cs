using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B3 RID: 5811
[Preserve]
public class Lua_UnityEngine_EventSystems_IPointerEnterHandler : LuaObject
{
	// Token: 0x0602317E RID: 143742 RVA: 0x00C27D48 File Offset: 0x00C25F48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerEnter(IntPtr l)
	{
		int result;
		try
		{
			IPointerEnterHandler pointerEnterHandler = (IPointerEnterHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerEnterHandler.OnPointerEnter(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602317F RID: 143743 RVA: 0x00C27DA0 File Offset: 0x00C25FA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IPointerEnterHandler");
		if (Lua_UnityEngine_EventSystems_IPointerEnterHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IPointerEnterHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IPointerEnterHandler.OnPointerEnter);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IPointerEnterHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPointerEnterHandler));
	}

	// Token: 0x04019076 RID: 102518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
