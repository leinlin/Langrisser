using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016CF RID: 5839
[Preserve]
public class Lua_UnityEngine_ForceMode2D : LuaObject
{
	// Token: 0x06023241 RID: 143937 RVA: 0x00C2C888 File Offset: 0x00C2AA88
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ForceMode2D");
		LuaObject.addMember(l, 0, "Force");
		LuaObject.addMember(l, 1, "Impulse");
		LuaDLL.lua_pop(l, 1);
	}
}
