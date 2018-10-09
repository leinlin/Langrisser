using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200164D RID: 5709
[Preserve]
public class Lua_UnityEngine_Camera_MonoOrStereoscopicEye : LuaObject
{
	// Token: 0x06022D87 RID: 142727 RVA: 0x00C0A9B0 File Offset: 0x00C08BB0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Camera.MonoOrStereoscopicEye");
		LuaObject.addMember(l, 0, "Left");
		LuaObject.addMember(l, 1, "Right");
		LuaObject.addMember(l, 2, "Mono");
		LuaDLL.lua_pop(l, 1);
	}
}
