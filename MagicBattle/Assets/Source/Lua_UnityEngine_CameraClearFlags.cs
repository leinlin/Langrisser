using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200164F RID: 5711
[Preserve]
public class Lua_UnityEngine_CameraClearFlags : LuaObject
{
	// Token: 0x06022D8B RID: 142731 RVA: 0x00C0AA24 File Offset: 0x00C08C24
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.CameraClearFlags");
		LuaObject.addMember(l, 1, "Skybox");
		LuaObject.addMember(l, 2, "SolidColor");
		LuaObject.addMember(l, 2, "Color");
		LuaObject.addMember(l, 3, "Depth");
		LuaObject.addMember(l, 4, "Nothing");
		LuaDLL.lua_pop(l, 1);
	}
}
