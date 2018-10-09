using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001690 RID: 5776
[Preserve]
public class Lua_UnityEngine_DurationUnit : LuaObject
{
	// Token: 0x0602308A RID: 143498 RVA: 0x00C22110 File Offset: 0x00C20310
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.DurationUnit");
		LuaObject.addMember(l, 0, "Fixed");
		LuaObject.addMember(l, 1, "Normalized");
		LuaDLL.lua_pop(l, 1);
	}
}
