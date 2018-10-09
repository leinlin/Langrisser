using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001756 RID: 5974
[Preserve]
public class Lua_UnityEngine_PlayMode : LuaObject
{
	// Token: 0x0602384F RID: 145487 RVA: 0x00C66FA4 File Offset: 0x00C651A4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.PlayMode");
		LuaObject.addMember(l, 0, "StopSameLayer");
		LuaObject.addMember(l, 4, "StopAll");
		LuaDLL.lua_pop(l, 1);
	}
}
