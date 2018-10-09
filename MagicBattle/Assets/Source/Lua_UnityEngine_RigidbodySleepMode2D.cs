using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017BC RID: 6076
[Preserve]
public class Lua_UnityEngine_RigidbodySleepMode2D : LuaObject
{
	// Token: 0x06023C87 RID: 146567 RVA: 0x00C89060 File Offset: 0x00C87260
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RigidbodySleepMode2D");
		LuaObject.addMember(l, 0, "NeverSleep");
		LuaObject.addMember(l, 1, "StartAwake");
		LuaObject.addMember(l, 2, "StartAsleep");
		LuaDLL.lua_pop(l, 1);
	}
}
