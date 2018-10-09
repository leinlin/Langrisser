using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017D1 RID: 6097
[Preserve]
public class Lua_UnityEngine_ShadowResolution : LuaObject
{
	// Token: 0x06023D0D RID: 146701 RVA: 0x00C8D2C0 File Offset: 0x00C8B4C0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ShadowResolution");
		LuaObject.addMember(l, 0, "Low");
		LuaObject.addMember(l, 1, "Medium");
		LuaObject.addMember(l, 2, "High");
		LuaObject.addMember(l, 3, "VeryHigh");
		LuaDLL.lua_pop(l, 1);
	}
}
