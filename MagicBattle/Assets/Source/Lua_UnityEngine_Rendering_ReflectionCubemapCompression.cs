using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001794 RID: 6036
[Preserve]
public class Lua_UnityEngine_Rendering_ReflectionCubemapCompression : LuaObject
{
	// Token: 0x06023AF1 RID: 146161 RVA: 0x00C7C994 File Offset: 0x00C7AB94
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ReflectionCubemapCompression");
		LuaObject.addMember(l, 0, "Uncompressed");
		LuaObject.addMember(l, 1, "Compressed");
		LuaObject.addMember(l, 2, "Auto");
		LuaDLL.lua_pop(l, 1);
	}
}
