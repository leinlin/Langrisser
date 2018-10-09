using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B4 RID: 5812
[Preserve]
public class Lua_UnityEngine_EventSystems_IPointerExitHandler : LuaObject
{
	// Token: 0x06023181 RID: 143745 RVA: 0x00C27DF4 File Offset: 0x00C25FF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPointerExit(IntPtr l)
	{
		int result;
		try
		{
			IPointerExitHandler pointerExitHandler = (IPointerExitHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			pointerExitHandler.OnPointerExit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023182 RID: 143746 RVA: 0x00C27E4C File Offset: 0x00C2604C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IPointerExitHandler");
		if (Lua_UnityEngine_EventSystems_IPointerExitHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IPointerExitHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IPointerExitHandler.OnPointerExit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IPointerExitHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPointerExitHandler));
	}

	// Token: 0x04019077 RID: 102519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
