using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B6 RID: 5814
[Preserve]
public class Lua_UnityEngine_EventSystems_IScrollHandler : LuaObject
{
	// Token: 0x06023187 RID: 143751 RVA: 0x00C27F4C File Offset: 0x00C2614C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnScroll(IntPtr l)
	{
		int result;
		try
		{
			IScrollHandler scrollHandler = (IScrollHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			scrollHandler.OnScroll(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023188 RID: 143752 RVA: 0x00C27FA4 File Offset: 0x00C261A4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IScrollHandler");
		if (Lua_UnityEngine_EventSystems_IScrollHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IScrollHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IScrollHandler.OnScroll);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IScrollHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IScrollHandler));
	}

	// Token: 0x04019079 RID: 102521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
