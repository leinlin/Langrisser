using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016AC RID: 5804
[Preserve]
public class Lua_UnityEngine_EventSystems_IDropHandler : LuaObject
{
	// Token: 0x0602316A RID: 143722 RVA: 0x00C27918 File Offset: 0x00C25B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDrop(IntPtr l)
	{
		int result;
		try
		{
			IDropHandler dropHandler = (IDropHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			dropHandler.OnDrop(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602316B RID: 143723 RVA: 0x00C27970 File Offset: 0x00C25B70
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IDropHandler");
		if (Lua_UnityEngine_EventSystems_IDropHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IDropHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IDropHandler.OnDrop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IDropHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IDropHandler));
	}

	// Token: 0x04019070 RID: 102512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
