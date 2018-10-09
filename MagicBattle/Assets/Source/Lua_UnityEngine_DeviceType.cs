using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200168A RID: 5770
[Preserve]
public class Lua_UnityEngine_DeviceType : LuaObject
{
	// Token: 0x06023067 RID: 143463 RVA: 0x00C212A4 File Offset: 0x00C1F4A4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.DeviceType");
		LuaObject.addMember(l, 0, "Unknown");
		LuaObject.addMember(l, 1, "Handheld");
		LuaObject.addMember(l, 2, "Console");
		LuaObject.addMember(l, 3, "Desktop");
		LuaDLL.lua_pop(l, 1);
	}
}
