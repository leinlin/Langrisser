using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017D0 RID: 6096
[Preserve]
public class Lua_UnityEngine_ShadowQuality : LuaObject
{
	// Token: 0x06023D0B RID: 146699 RVA: 0x00C8D280 File Offset: 0x00C8B480
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ShadowQuality");
		LuaObject.addMember(l, 0, "Disable");
		LuaObject.addMember(l, 1, "HardOnly");
		LuaObject.addMember(l, 2, "All");
		LuaDLL.lua_pop(l, 1);
	}
}
