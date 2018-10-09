using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017FF RID: 6143
[Preserve]
public class Lua_UnityEngine_ThreadPriority : LuaObject
{
	// Token: 0x06023ED4 RID: 147156 RVA: 0x00C9A66C File Offset: 0x00C9886C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ThreadPriority");
		LuaObject.addMember(l, 0, "Low");
		LuaObject.addMember(l, 1, "BelowNormal");
		LuaObject.addMember(l, 2, "Normal");
		LuaObject.addMember(l, 4, "High");
		LuaDLL.lua_pop(l, 1);
	}
}
