using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001741 RID: 5953
[Preserve]
public class Lua_UnityEngine_Playables_DirectorUpdateMode : LuaObject
{
	// Token: 0x060237C1 RID: 145345 RVA: 0x00C63910 File Offset: 0x00C61B10
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Playables.DirectorUpdateMode");
		LuaObject.addMember(l, 0, "DSPClock");
		LuaObject.addMember(l, 1, "GameTime");
		LuaObject.addMember(l, 2, "UnscaledGameTime");
		LuaObject.addMember(l, 3, "Manual");
		LuaDLL.lua_pop(l, 1);
	}
}
