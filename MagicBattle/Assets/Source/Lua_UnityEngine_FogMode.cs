using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016CC RID: 5836
[Preserve]
public class Lua_UnityEngine_FogMode : LuaObject
{
	// Token: 0x0602322A RID: 143914 RVA: 0x00C2BCE8 File Offset: 0x00C29EE8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.FogMode");
		LuaObject.addMember(l, 1, "Linear");
		LuaObject.addMember(l, 2, "Exponential");
		LuaObject.addMember(l, 3, "ExponentialSquared");
		LuaDLL.lua_pop(l, 1);
	}
}
