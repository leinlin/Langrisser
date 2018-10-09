using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001765 RID: 5989
[Preserve]
public class Lua_UnityEngine_QueueMode : LuaObject
{
	// Token: 0x06023928 RID: 145704 RVA: 0x00C6CF34 File Offset: 0x00C6B134
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.QueueMode");
		LuaObject.addMember(l, 0, "CompleteOthers");
		LuaObject.addMember(l, 2, "PlayNow");
		LuaDLL.lua_pop(l, 1);
	}
}
