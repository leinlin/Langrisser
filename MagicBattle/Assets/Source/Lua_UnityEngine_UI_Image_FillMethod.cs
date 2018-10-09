using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001835 RID: 6197
[Preserve]
public class Lua_UnityEngine_UI_Image_FillMethod : LuaObject
{
	// Token: 0x060240FE RID: 147710 RVA: 0x00CA9288 File Offset: 0x00CA7488
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.FillMethod");
		LuaObject.addMember(l, 0, "Horizontal");
		LuaObject.addMember(l, 1, "Vertical");
		LuaObject.addMember(l, 2, "Radial90");
		LuaObject.addMember(l, 3, "Radial180");
		LuaObject.addMember(l, 4, "Radial360");
		LuaDLL.lua_pop(l, 1);
	}
}
