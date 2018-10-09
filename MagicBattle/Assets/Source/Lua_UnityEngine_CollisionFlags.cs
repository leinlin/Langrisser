using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001664 RID: 5732
[Preserve]
public class Lua_UnityEngine_CollisionFlags : LuaObject
{
	// Token: 0x06022E9E RID: 143006 RVA: 0x00C12CE8 File Offset: 0x00C10EE8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CollisionFlags");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "CollidedSides");
		LuaObject.addMember(l, 1, "Sides");
		LuaObject.addMember(l, 2, "CollidedAbove");
		LuaObject.addMember(l, 2, "Above");
		LuaObject.addMember(l, 4, "CollidedBelow");
		LuaObject.addMember(l, 4, "Below");
		LuaDLL.lua_pop(l, 1);
	}
}
