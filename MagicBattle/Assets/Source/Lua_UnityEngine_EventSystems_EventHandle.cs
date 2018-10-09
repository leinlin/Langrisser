using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016A1 RID: 5793
[Preserve]
public class Lua_UnityEngine_EventSystems_EventHandle : LuaObject
{
	// Token: 0x06023123 RID: 143651 RVA: 0x00C25DD4 File Offset: 0x00C23FD4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EventSystems.EventHandle");
		LuaObject.addMember(l, 0, "Unused");
		LuaObject.addMember(l, 1, "Used");
		LuaDLL.lua_pop(l, 1);
	}
}
