using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200162B RID: 5675
[Preserve]
public class Lua_UnityEngine_ApplicationSandboxType : LuaObject
{
	// Token: 0x06022BBF RID: 142271 RVA: 0x00BFCF2C File Offset: 0x00BFB12C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ApplicationSandboxType");
		LuaObject.addMember(l, 0, "Unknown");
		LuaObject.addMember(l, 1, "NotSandboxed");
		LuaObject.addMember(l, 2, "Sandboxed");
		LuaObject.addMember(l, 3, "SandboxBroken");
		LuaDLL.lua_pop(l, 1);
	}
}
