using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E4 RID: 6116
[Preserve]
public class Lua_UnityEngine_SpriteMeshType : LuaObject
{
	// Token: 0x06023DAC RID: 146860 RVA: 0x00C91560 File Offset: 0x00C8F760
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpriteMeshType");
		LuaObject.addMember(l, 0, "FullRect");
		LuaObject.addMember(l, 1, "Tight");
		LuaDLL.lua_pop(l, 1);
	}
}
