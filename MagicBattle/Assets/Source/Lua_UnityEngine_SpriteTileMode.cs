using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E9 RID: 6121
[Preserve]
public class Lua_UnityEngine_SpriteTileMode : LuaObject
{
	// Token: 0x06023DCD RID: 146893 RVA: 0x00C92134 File Offset: 0x00C90334
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpriteTileMode");
		LuaObject.addMember(l, 0, "Continuous");
		LuaObject.addMember(l, 1, "Adaptive");
		LuaDLL.lua_pop(l, 1);
	}
}
