using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001788 RID: 6024
[Preserve]
public class Lua_UnityEngine_Rendering_DefaultReflectionMode : LuaObject
{
	// Token: 0x06023AC7 RID: 146119 RVA: 0x00C7BCA0 File Offset: 0x00C79EA0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.DefaultReflectionMode");
		LuaObject.addMember(l, 0, "Skybox");
		LuaObject.addMember(l, 1, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
