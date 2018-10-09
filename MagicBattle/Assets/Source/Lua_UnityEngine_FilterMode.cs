using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016C6 RID: 5830
[Preserve]
public class Lua_UnityEngine_FilterMode : LuaObject
{
	// Token: 0x06023218 RID: 143896 RVA: 0x00C2B8C8 File Offset: 0x00C29AC8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.FilterMode");
		LuaObject.addMember(l, 0, "Point");
		LuaObject.addMember(l, 1, "Bilinear");
		LuaObject.addMember(l, 2, "Trilinear");
		LuaDLL.lua_pop(l, 1);
	}
}
