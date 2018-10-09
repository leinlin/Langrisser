using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200165B RID: 5723
[Preserve]
public class Lua_UnityEngine_Collections_Allocator : LuaObject
{
	// Token: 0x06022E45 RID: 142917 RVA: 0x00C0FF2C File Offset: 0x00C0E12C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Collections.Allocator");
		LuaObject.addMember(l, 0, "Invalid");
		LuaObject.addMember(l, 1, "None");
		LuaObject.addMember(l, 2, "Temp");
		LuaObject.addMember(l, 3, "TempJob");
		LuaObject.addMember(l, 4, "Persistent");
		LuaDLL.lua_pop(l, 1);
	}
}
