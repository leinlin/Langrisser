using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.EventSystems;
using UnityEngine.Scripting;

// Token: 0x020016B8 RID: 5816
[Preserve]
public class Lua_UnityEngine_EventSystems_ISubmitHandler : LuaObject
{
	// Token: 0x0602318D RID: 143757 RVA: 0x00C280A4 File Offset: 0x00C262A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubmit(IntPtr l)
	{
		int result;
		try
		{
			ISubmitHandler submitHandler = (ISubmitHandler)LuaObject.checkSelf(l);
			BaseEventData eventData;
			LuaObject.checkType<BaseEventData>(l, 2, out eventData);
			submitHandler.OnSubmit(eventData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602318E RID: 143758 RVA: 0x00C280FC File Offset: 0x00C262FC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.EventSystems.ISubmitHandler");
		if (Lua_UnityEngine_EventSystems_ISubmitHandler.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_EventSystems_ISubmitHandler.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_EventSystems_ISubmitHandler.OnSubmit);
		}
		LuaObject.addMember(l, Lua_UnityEngine_EventSystems_ISubmitHandler.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(ISubmitHandler));
	}

	// Token: 0x0401907B RID: 102523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
