using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001730 RID: 5936
[Preserve]
public class Lua_UnityEngine_MixedLightingMode : LuaObject
{
	// Token: 0x060236A7 RID: 145063 RVA: 0x00C536A8 File Offset: 0x00C518A8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.MixedLightingMode");
		LuaObject.addMember(l, 0, "IndirectOnly");
		LuaObject.addMember(l, 1, "Subtractive");
		LuaObject.addMember(l, 2, "Shadowmask");
		LuaDLL.lua_pop(l, 1);
	}
}
