using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001662 RID: 5730
[Preserve]
public class Lua_UnityEngine_CollisionDetectionMode : LuaObject
{
	// Token: 0x06022E9A RID: 143002 RVA: 0x00C12C68 File Offset: 0x00C10E68
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CollisionDetectionMode");
		LuaObject.addMember(l, 0, "Discrete");
		LuaObject.addMember(l, 1, "Continuous");
		LuaObject.addMember(l, 2, "ContinuousDynamic");
		LuaDLL.lua_pop(l, 1);
	}
}
