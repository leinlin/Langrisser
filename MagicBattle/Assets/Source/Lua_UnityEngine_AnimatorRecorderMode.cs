using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001623 RID: 5667
[Preserve]
public class Lua_UnityEngine_AnimatorRecorderMode : LuaObject
{
	// Token: 0x06022B68 RID: 142184 RVA: 0x00BFABF0 File Offset: 0x00BF8DF0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimatorRecorderMode");
		LuaObject.addMember(l, 0, "Offline");
		LuaObject.addMember(l, 1, "Playback");
		LuaObject.addMember(l, 2, "Record");
		LuaDLL.lua_pop(l, 1);
	}
}
