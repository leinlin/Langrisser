using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200162A RID: 5674
[Preserve]
public class Lua_UnityEngine_ApplicationInstallMode : LuaObject
{
	// Token: 0x06022BBD RID: 142269 RVA: 0x00BFCEBC File Offset: 0x00BFB0BC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ApplicationInstallMode");
		LuaObject.addMember(l, 0, "Unknown");
		LuaObject.addMember(l, 1, "Store");
		LuaObject.addMember(l, 2, "DeveloperBuild");
		LuaObject.addMember(l, 3, "Adhoc");
		LuaObject.addMember(l, 4, "Enterprise");
		LuaObject.addMember(l, 5, "Editor");
		LuaDLL.lua_pop(l, 1);
	}
}
