using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016DA RID: 5850
[Preserve]
public class Lua_UnityEngine_GradientMode : LuaObject
{
	// Token: 0x060232D9 RID: 144089 RVA: 0x00C31114 File Offset: 0x00C2F314
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.GradientMode");
		LuaObject.addMember(l, 0, "Blend");
		LuaObject.addMember(l, 1, "Fixed");
		LuaDLL.lua_pop(l, 1);
	}
}
