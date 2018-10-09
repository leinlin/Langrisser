using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017C3 RID: 6083
[Preserve]
public class Lua_UnityEngine_ScaleMode : LuaObject
{
	// Token: 0x06023C9A RID: 146586 RVA: 0x00C895D4 File Offset: 0x00C877D4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ScaleMode");
		LuaObject.addMember(l, 0, "StretchToFill");
		LuaObject.addMember(l, 1, "ScaleAndCrop");
		LuaObject.addMember(l, 2, "ScaleToFit");
		LuaDLL.lua_pop(l, 1);
	}
}
