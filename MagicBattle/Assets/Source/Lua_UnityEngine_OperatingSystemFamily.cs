using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001736 RID: 5942
[Preserve]
public class Lua_UnityEngine_OperatingSystemFamily : LuaObject
{
	// Token: 0x060236D0 RID: 145104 RVA: 0x00C54DF0 File Offset: 0x00C52FF0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.OperatingSystemFamily");
		LuaObject.addMember(l, 0, "Other");
		LuaObject.addMember(l, 1, "MacOSX");
		LuaObject.addMember(l, 2, "Windows");
		LuaObject.addMember(l, 3, "Linux");
		LuaDLL.lua_pop(l, 1);
	}
}
