using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B0 RID: 5808
[Preserve]
public class Lua_UnityEngine_EventSystems_IMoveHandler : LuaObject
{
	// Token: 0x06023175 RID: 143733 RVA: 0x00C27B44 File Offset: 0x00C25D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMove(IntPtr l)
	{
		int result;
		try
		{
			IMoveHandler moveHandler = (IMoveHandler)LuaObject.checkSelf(l);
			AxisEventData eventData;
			LuaObject.checkType<AxisEventData>(l, 2, out eventData);
			moveHandler.OnMove(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023176 RID: 143734 RVA: 0x00C27B9C File Offset: 0x00C25D9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.IMoveHandler");
		if (Lua_UnityEngine_EventSystems_IMoveHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_IMoveHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_IMoveHandler.OnMove);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_IMoveHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IMoveHandler));
	}

	// Token: 0x04019073 RID: 102515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
