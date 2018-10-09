using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200169A RID: 5786
[Preserve]
public class Lua_UnityEngine_Events_UnityEventCallState : LuaObject
{
	// Token: 0x060230ED RID: 143597 RVA: 0x00C248EC File Offset: 0x00C22AEC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Events.UnityEventCallState");
		LuaObject.addMember(l, 0, "Off");
		LuaObject.addMember(l, 1, "EditorAndRuntime");
		LuaObject.addMember(l, 2, "RuntimeOnly");
		LuaDLL.lua_pop(l, 1);
	}
}
