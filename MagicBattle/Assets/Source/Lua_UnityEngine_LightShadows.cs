using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001714 RID: 5908
[Preserve]
public class Lua_UnityEngine_LightShadows : LuaObject
{
	// Token: 0x060234F0 RID: 144624 RVA: 0x00C433DC File Offset: 0x00C415DC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightShadows");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Hard");
		LuaObject.addMember(l, 2, "Soft");
		LuaDLL.lua_pop(l, 1);
	}
}
