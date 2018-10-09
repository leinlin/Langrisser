using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200177E RID: 6014
[Preserve]
public class Lua_UnityEngine_Rendering_BuiltinShaderMode : LuaObject
{
	// Token: 0x06023A77 RID: 146039 RVA: 0x00C76B30 File Offset: 0x00C74D30
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.BuiltinShaderMode");
		LuaObject.addMember(l, 0, "Disabled");
		LuaObject.addMember(l, 1, "UseBuiltin");
		LuaObject.addMember(l, 2, "UseCustom");
		LuaDLL.lua_pop(l, 1);
	}
}
