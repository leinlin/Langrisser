using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001715 RID: 5909
[Preserve]
public class Lua_UnityEngine_LightType : LuaObject
{
	// Token: 0x060234F2 RID: 144626 RVA: 0x00C4341C File Offset: 0x00C4161C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.LightType");
		LuaObject.addMember(l, 0, "Spot");
		LuaObject.addMember(l, 1, "Directional");
		LuaObject.addMember(l, 2, "Point");
		LuaObject.addMember(l, 3, "Area");
		LuaDLL.lua_pop(l, 1);
	}
}
