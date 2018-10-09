using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001628 RID: 5672
[Preserve]
public class Lua_UnityEngine_AnisotropicFiltering : LuaObject
{
	// Token: 0x06022B8A RID: 142218 RVA: 0x00BFB8B0 File Offset: 0x00BF9AB0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnisotropicFiltering");
		LuaObject.addMember(l, 0, "Disable");
		LuaObject.addMember(l, 1, "Enable");
		LuaObject.addMember(l, 2, "ForceEnable");
		LuaDLL.lua_pop(l, 1);
	}
}
