using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017EA RID: 6122
[Preserve]
public class Lua_UnityEngine_StackTraceLogType : LuaObject
{
	// Token: 0x06023DCF RID: 146895 RVA: 0x00C92168 File Offset: 0x00C90368
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.StackTraceLogType");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "ScriptOnly");
		LuaObject.addMember(l, 2, "Full");
		LuaDLL.lua_pop(l, 1);
	}
}
