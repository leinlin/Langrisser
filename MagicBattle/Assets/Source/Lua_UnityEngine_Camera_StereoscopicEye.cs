using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200164E RID: 5710
[Preserve]
public class Lua_UnityEngine_Camera_StereoscopicEye : LuaObject
{
	// Token: 0x06022D89 RID: 142729 RVA: 0x00C0A9F0 File Offset: 0x00C08BF0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Camera.StereoscopicEye");
		LuaObject.addMember(l, 0, "Left");
		LuaObject.addMember(l, 1, "Right");
		LuaDLL.lua_pop(l, 1);
	}
}
