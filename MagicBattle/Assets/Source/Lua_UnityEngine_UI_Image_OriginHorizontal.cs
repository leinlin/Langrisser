using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001839 RID: 6201
[Preserve]
public class Lua_UnityEngine_UI_Image_OriginHorizontal : LuaObject
{
	// Token: 0x06024106 RID: 147718 RVA: 0x00CA93F4 File Offset: 0x00CA75F4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.OriginHorizontal");
		LuaObject.addMember(l, 0, "Left");
		LuaObject.addMember(l, 1, "Right");
		LuaDLL.lua_pop(l, 1);
	}
}
