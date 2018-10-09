using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017B1 RID: 6065
[Preserve]
public class Lua_UnityEngine_RenderTextureMemoryless : LuaObject
{
	// Token: 0x06023BDC RID: 146396 RVA: 0x00C834F8 File Offset: 0x00C816F8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RenderTextureMemoryless");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Color");
		LuaObject.addMember(l, 2, "Depth");
		LuaObject.addMember(l, 4, "MSAA");
		LuaDLL.lua_pop(l, 1);
	}
}
