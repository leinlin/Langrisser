using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016BF RID: 5823
[Preserve]
public class Lua_UnityEngine_EventSystems_PointerEventData_InputButton : LuaObject
{
	// Token: 0x060231D0 RID: 143824 RVA: 0x00C29BC0 File Offset: 0x00C27DC0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EventSystems.PointerEventData.InputButton");
		LuaObject.addMember(l, 0, "Left");
		LuaObject.addMember(l, 1, "Right");
		LuaObject.addMember(l, 2, "Middle");
		LuaDLL.lua_pop(l, 1);
	}
}
