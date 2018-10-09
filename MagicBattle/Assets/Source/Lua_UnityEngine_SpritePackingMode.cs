using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E5 RID: 6117
[Preserve]
public class Lua_UnityEngine_SpritePackingMode : LuaObject
{
	// Token: 0x06023DAE RID: 146862 RVA: 0x00C91594 File Offset: 0x00C8F794
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpritePackingMode");
		LuaObject.addMember(l, 0, "Tight");
		LuaObject.addMember(l, 1, "Rectangle");
		LuaDLL.lua_pop(l, 1);
	}
}
