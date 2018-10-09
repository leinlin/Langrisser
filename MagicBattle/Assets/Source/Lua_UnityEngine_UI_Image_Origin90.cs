using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001838 RID: 6200
[Preserve]
public class Lua_UnityEngine_UI_Image_Origin90 : LuaObject
{
	// Token: 0x06024104 RID: 147716 RVA: 0x00CA939C File Offset: 0x00CA759C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.Origin90");
		LuaObject.addMember(l, 0, "BottomLeft");
		LuaObject.addMember(l, 1, "TopLeft");
		LuaObject.addMember(l, 2, "TopRight");
		LuaObject.addMember(l, 3, "BottomRight");
		LuaDLL.lua_pop(l, 1);
	}
}
