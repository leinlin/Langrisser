using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200178D RID: 6029
[Preserve]
public class Lua_UnityEngine_Rendering_IndexFormat : LuaObject
{
	// Token: 0x06023AE3 RID: 146147 RVA: 0x00C7C6F4 File Offset: 0x00C7A8F4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.IndexFormat");
		LuaObject.addMember(l, 0, "UInt16");
		LuaObject.addMember(l, 1, "UInt32");
		LuaDLL.lua_pop(l, 1);
	}
}
