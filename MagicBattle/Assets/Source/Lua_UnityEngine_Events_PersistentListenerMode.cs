using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001697 RID: 5783
[Preserve]
public class Lua_UnityEngine_Events_PersistentListenerMode : LuaObject
{
	// Token: 0x060230DD RID: 143581 RVA: 0x00C2432C File Offset: 0x00C2252C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Events.PersistentListenerMode");
		LuaObject.addMember(l, 0, "EventDefined");
		LuaObject.addMember(l, 1, "Void");
		LuaObject.addMember(l, 2, "Object");
		LuaObject.addMember(l, 3, "Int");
		LuaObject.addMember(l, 4, "Float");
		LuaObject.addMember(l, 5, "String");
		LuaObject.addMember(l, 6, "Bool");
		LuaDLL.lua_pop(l, 1);
	}
}
