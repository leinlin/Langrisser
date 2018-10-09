using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001707 RID: 5895
[Preserve]
public class Lua_UnityEngine_LightmapBakeType : LuaObject
{
	// Token: 0x060234A8 RID: 144552 RVA: 0x00C41B4C File Offset: 0x00C3FD4C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightmapBakeType");
		LuaObject.addMember(l, 1, "Mixed");
		LuaObject.addMember(l, 2, "Baked");
		LuaObject.addMember(l, 4, "Realtime");
		LuaDLL.lua_pop(l, 1);
	}
}
