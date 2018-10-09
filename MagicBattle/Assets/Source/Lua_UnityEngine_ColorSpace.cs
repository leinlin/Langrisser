using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001668 RID: 5736
[Preserve]
public class Lua_UnityEngine_ColorSpace : LuaObject
{
	// Token: 0x06022ED5 RID: 143061 RVA: 0x00C147D4 File Offset: 0x00C129D4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ColorSpace");
		LuaObject.addMember(l, 0, "Gamma");
		LuaObject.addMember(l, 1, "Linear");
		LuaObject.addMember(l, -1, "Uninitialized");
		LuaDLL.lua_pop(l, 1);
	}
}
