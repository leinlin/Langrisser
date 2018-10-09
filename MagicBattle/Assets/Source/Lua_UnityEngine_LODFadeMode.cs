using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200171E RID: 5918
[Preserve]
public class Lua_UnityEngine_LODFadeMode : LuaObject
{
	// Token: 0x0602353D RID: 144701 RVA: 0x00C453D8 File Offset: 0x00C435D8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LODFadeMode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "CrossFade");
		LuaObject.addMember(l, 2, "SpeedTree");
		LuaDLL.lua_pop(l, 1);
	}
}
