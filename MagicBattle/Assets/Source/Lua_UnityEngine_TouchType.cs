using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001803 RID: 6147
[Preserve]
public class Lua_UnityEngine_TouchType : LuaObject
{
	// Token: 0x06023F11 RID: 147217 RVA: 0x00C9C058 File Offset: 0x00C9A258
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TouchType");
		LuaObject.addMember(l, 0, "Direct");
		LuaObject.addMember(l, 1, "Indirect");
		LuaObject.addMember(l, 2, "Stylus");
		LuaDLL.lua_pop(l, 1);
	}
}
