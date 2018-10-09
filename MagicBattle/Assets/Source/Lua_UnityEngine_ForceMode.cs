using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016CE RID: 5838
[Preserve]
public class Lua_UnityEngine_ForceMode : LuaObject
{
	// Token: 0x0602323F RID: 143935 RVA: 0x00C2C830 File Offset: 0x00C2AA30
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ForceMode");
		LuaObject.addMember(l, 0, "Force");
		LuaObject.addMember(l, 1, "Impulse");
		LuaObject.addMember(l, 2, "VelocityChange");
		LuaObject.addMember(l, 5, "Acceleration");
		LuaDLL.lua_pop(l, 1);
	}
}
