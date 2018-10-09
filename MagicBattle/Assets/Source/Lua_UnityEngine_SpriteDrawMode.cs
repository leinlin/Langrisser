using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E2 RID: 6114
[Preserve]
public class Lua_UnityEngine_SpriteDrawMode : LuaObject
{
	// Token: 0x06023DA8 RID: 146856 RVA: 0x00C914E0 File Offset: 0x00C8F6E0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpriteDrawMode");
		LuaObject.addMember(l, 0, "Simple");
		LuaObject.addMember(l, 1, "Sliced");
		LuaObject.addMember(l, 2, "Tiled");
		LuaDLL.lua_pop(l, 1);
	}
}
