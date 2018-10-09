using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001802 RID: 6146
[Preserve]
public class Lua_UnityEngine_TouchPhase : LuaObject
{
	// Token: 0x06023F0F RID: 147215 RVA: 0x00C9BFF4 File Offset: 0x00C9A1F4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TouchPhase");
		LuaObject.addMember(l, 0, "Began");
		LuaObject.addMember(l, 1, "Moved");
		LuaObject.addMember(l, 2, "Stationary");
		LuaObject.addMember(l, 3, "Ended");
		LuaObject.addMember(l, 4, "Canceled");
		LuaDLL.lua_pop(l, 1);
	}
}
