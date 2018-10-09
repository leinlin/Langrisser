using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001784 RID: 6020
[Preserve]
public class Lua_UnityEngine_Rendering_CompareFunction : LuaObject
{
	// Token: 0x06023ABF RID: 146111 RVA: 0x00C7BB1C File Offset: 0x00C79D1C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.CompareFunction");
		LuaObject.addMember(l, 0, "Disabled");
		LuaObject.addMember(l, 1, "Never");
		LuaObject.addMember(l, 2, "Less");
		LuaObject.addMember(l, 3, "Equal");
		LuaObject.addMember(l, 4, "LessEqual");
		LuaObject.addMember(l, 5, "Greater");
		LuaObject.addMember(l, 6, "NotEqual");
		LuaObject.addMember(l, 7, "GreaterEqual");
		LuaObject.addMember(l, 8, "Always");
		LuaDLL.lua_pop(l, 1);
	}
}
