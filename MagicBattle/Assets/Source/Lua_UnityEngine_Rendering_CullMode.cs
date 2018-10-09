using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001787 RID: 6023
[Preserve]
public class Lua_UnityEngine_Rendering_CullMode : LuaObject
{
	// Token: 0x06023AC5 RID: 146117 RVA: 0x00C7BC60 File Offset: 0x00C79E60
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.CullMode");
		LuaObject.addMember(l, 0, "Off");
		LuaObject.addMember(l, 1, "Front");
		LuaObject.addMember(l, 2, "Back");
		LuaDLL.lua_pop(l, 1);
	}
}
