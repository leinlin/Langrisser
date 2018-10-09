using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016F2 RID: 5874
[Preserve]
public class Lua_UnityEngine_IMECompositionMode : LuaObject
{
	// Token: 0x0602339E RID: 144286 RVA: 0x00C396A8 File Offset: 0x00C378A8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.IMECompositionMode");
		LuaObject.addMember(l, 0, "Auto");
		LuaObject.addMember(l, 1, "On");
		LuaObject.addMember(l, 2, "Off");
		LuaDLL.lua_pop(l, 1);
	}
}
