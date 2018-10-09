using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200171C RID: 5916
[Preserve]
public class Lua_UnityEngine_LocationServiceStatus : LuaObject
{
	// Token: 0x06023532 RID: 144690 RVA: 0x00C44FC4 File Offset: 0x00C431C4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LocationServiceStatus");
		LuaObject.addMember(l, 0, "Stopped");
		LuaObject.addMember(l, 1, "Initializing");
		LuaObject.addMember(l, 2, "Running");
		LuaObject.addMember(l, 3, "Failed");
		LuaDLL.lua_pop(l, 1);
	}
}
