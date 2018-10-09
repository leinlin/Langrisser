using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E1 RID: 6113
[Preserve]
public class Lua_UnityEngine_SpriteAlignment : LuaObject
{
	// Token: 0x06023DA6 RID: 146854 RVA: 0x00C91440 File Offset: 0x00C8F640
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpriteAlignment");
		LuaObject.addMember(l, 0, "Center");
		LuaObject.addMember(l, 1, "TopLeft");
		LuaObject.addMember(l, 2, "TopCenter");
		LuaObject.addMember(l, 3, "TopRight");
		LuaObject.addMember(l, 4, "LeftCenter");
		LuaObject.addMember(l, 5, "RightCenter");
		LuaObject.addMember(l, 6, "BottomLeft");
		LuaObject.addMember(l, 7, "BottomCenter");
		LuaObject.addMember(l, 8, "BottomRight");
		LuaObject.addMember(l, 9, "Custom");
		LuaDLL.lua_pop(l, 1);
	}
}
