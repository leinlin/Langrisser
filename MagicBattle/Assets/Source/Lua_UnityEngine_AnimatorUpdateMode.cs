using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001626 RID: 5670
[Preserve]
public class Lua_UnityEngine_AnimatorUpdateMode : LuaObject
{
	// Token: 0x06022B83 RID: 142211 RVA: 0x00BFB6F0 File Offset: 0x00BF98F0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimatorUpdateMode");
		LuaObject.addMember(l, 0, "Normal");
		LuaObject.addMember(l, 1, "AnimatePhysics");
		LuaObject.addMember(l, 2, "UnscaledTime");
		LuaDLL.lua_pop(l, 1);
	}
}
