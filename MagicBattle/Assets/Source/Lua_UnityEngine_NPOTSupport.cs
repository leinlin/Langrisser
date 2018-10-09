using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001732 RID: 5938
[Preserve]
public class Lua_UnityEngine_NPOTSupport : LuaObject
{
	// Token: 0x060236B3 RID: 145075 RVA: 0x00C53DB8 File Offset: 0x00C51FB8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.NPOTSupport");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Restricted");
		LuaObject.addMember(l, 2, "Full");
		LuaDLL.lua_pop(l, 1);
	}
}
