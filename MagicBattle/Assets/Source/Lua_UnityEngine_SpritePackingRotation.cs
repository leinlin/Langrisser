using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017E6 RID: 6118
[Preserve]
public class Lua_UnityEngine_SpritePackingRotation : LuaObject
{
	// Token: 0x06023DB0 RID: 146864 RVA: 0x00C915C8 File Offset: 0x00C8F7C8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SpritePackingRotation");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 15, "Any");
		LuaDLL.lua_pop(l, 1);
	}
}
