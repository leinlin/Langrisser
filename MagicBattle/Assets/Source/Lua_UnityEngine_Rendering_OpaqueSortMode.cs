using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001791 RID: 6033
[Preserve]
public class Lua_UnityEngine_Rendering_OpaqueSortMode : LuaObject
{
	// Token: 0x06023AEB RID: 146155 RVA: 0x00C7C83C File Offset: 0x00C7AA3C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.OpaqueSortMode");
		LuaObject.addMember(l, 0, "Default");
		LuaObject.addMember(l, 1, "FrontToBack");
		LuaObject.addMember(l, 2, "NoDistanceSort");
		LuaDLL.lua_pop(l, 1);
	}
}
