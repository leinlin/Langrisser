using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200183B RID: 6203
[Preserve]
public class Lua_UnityEngine_UI_Image_Type : LuaObject
{
	// Token: 0x0602410A RID: 147722 RVA: 0x00CA945C File Offset: 0x00CA765C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.Type");
		LuaObject.addMember(l, 0, "Simple");
		LuaObject.addMember(l, 1, "Sliced");
		LuaObject.addMember(l, 2, "Tiled");
		LuaObject.addMember(l, 3, "Filled");
		LuaDLL.lua_pop(l, 1);
	}
}
