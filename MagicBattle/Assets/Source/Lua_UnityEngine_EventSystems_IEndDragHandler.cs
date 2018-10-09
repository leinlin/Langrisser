using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016AD RID: 5805
[Preserve]
public class Lua_UnityEngine_EventSystems_IEndDragHandler : LuaObject
{
	// Token: 0x0602316D RID: 143725 RVA: 0x00C279C4 File Offset: 0x00C25BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndDrag(IntPtr l)
	{
		int result;
		try
		{
			IEndDragHandler endDragHandler = (IEndDragHandler)LuaObject.checkSelf(l);
			PointerEventData eventData;
			LuaObject.checkType<PointerEventData>(l, 2, out eventData);
			endDragHandler.OnEndDrag(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602316E RID: 143726 RVA: 0x00C27A1C File Offset: 0x00C25C1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IEndDragHandler");
		if (Lua_UnityEngine_EventSystems_IEndDragHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IEndDragHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IEndDragHandler.OnEndDrag);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IEndDragHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IEndDragHandler));
	}

	// Token: 0x04019071 RID: 102513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
