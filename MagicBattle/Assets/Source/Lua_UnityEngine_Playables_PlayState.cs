using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001752 RID: 5970
[Preserve]
public class Lua_UnityEngine_Playables_PlayState : LuaObject
{
	// Token: 0x06023837 RID: 145463 RVA: 0x00C66654 File Offset: 0x00C64854
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Playables.PlayState");
		LuaObject.addMember(l, 0, "Paused");
		LuaObject.addMember(l, 1, "Playing");
		LuaObject.addMember(l, 2, "Delayed");
		LuaDLL.lua_pop(l, 1);
	}
}
