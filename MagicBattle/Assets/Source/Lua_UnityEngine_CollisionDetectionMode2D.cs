using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001663 RID: 5731
[Preserve]
public class Lua_UnityEngine_CollisionDetectionMode2D : LuaObject
{
	// Token: 0x06022E9C RID: 143004 RVA: 0x00C12CA8 File Offset: 0x00C10EA8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CollisionDetectionMode2D");
		LuaObject.addMember(l, 0, "Discrete");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Continuous");
		LuaDLL.lua_pop(l, 1);
	}
}
