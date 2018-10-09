using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001721 RID: 5921
[Preserve]
public class Lua_UnityEngine_LogType : LuaObject
{
	// Token: 0x06023561 RID: 144737 RVA: 0x00C46760 File Offset: 0x00C44960
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LogType");
		LuaObject.addMember(l, 0, "Error");
		LuaObject.addMember(l, 1, "Assert");
		LuaObject.addMember(l, 2, "Warning");
		LuaObject.addMember(l, 3, "Log");
		LuaObject.addMember(l, 4, "Exception");
		LuaDLL.lua_pop(l, 1);
	}
}
