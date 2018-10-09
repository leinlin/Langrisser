using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001667 RID: 5735
[Preserve]
public class Lua_UnityEngine_ColorGamut : LuaObject
{
	// Token: 0x06022ED3 RID: 143059 RVA: 0x00C14764 File Offset: 0x00C12964
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.ColorGamut");
		LuaObject.addMember(l, 0, "sRGB");
		LuaObject.addMember(l, 1, "Rec709");
		LuaObject.addMember(l, 2, "Rec2020");
		LuaObject.addMember(l, 3, "DisplayP3");
		LuaObject.addMember(l, 4, "HDR10");
		LuaObject.addMember(l, 5, "DolbyHDR");
		LuaDLL.lua_pop(l, 1);
	}
}
