using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017DB RID: 6107
[Preserve]
public class Lua_UnityEngine_Space : LuaObject
{
	// Token: 0x06023D67 RID: 146791 RVA: 0x00C8F6BC File Offset: 0x00C8D8BC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Space");
		LuaObject.addMember(l, 0, "World");
		LuaObject.addMember(l, 1, "Self");
		LuaDLL.lua_pop(l, 1);
	}
}
