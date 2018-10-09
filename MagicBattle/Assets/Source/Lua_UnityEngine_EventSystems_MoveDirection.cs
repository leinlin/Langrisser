using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016BA RID: 5818
[Preserve]
public class Lua_UnityEngine_EventSystems_MoveDirection : LuaObject
{
	// Token: 0x06023193 RID: 143763 RVA: 0x00C281FC File Offset: 0x00C263FC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.EventSystems.MoveDirection");
		LuaObject.addMember(l, 0, "Left");
		LuaObject.addMember(l, 1, "Up");
		LuaObject.addMember(l, 2, "Right");
		LuaObject.addMember(l, 3, "Down");
		LuaObject.addMember(l, 4, "None");
		LuaDLL.lua_pop(l, 1);
	}
}
