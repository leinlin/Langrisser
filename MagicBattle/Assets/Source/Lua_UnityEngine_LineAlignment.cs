using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001716 RID: 5910
[Preserve]
public class Lua_UnityEngine_LineAlignment : LuaObject
{
	// Token: 0x060234F4 RID: 144628 RVA: 0x00C43474 File Offset: 0x00C41674
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LineAlignment");
		LuaObject.addMember(l, 0, "View");
		LuaObject.addMember(l, 1, "Local");
		LuaDLL.lua_pop(l, 1);
	}
}
