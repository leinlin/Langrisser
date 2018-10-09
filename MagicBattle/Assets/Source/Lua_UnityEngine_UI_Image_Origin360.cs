using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001837 RID: 6199
[Preserve]
public class Lua_UnityEngine_UI_Image_Origin360 : LuaObject
{
	// Token: 0x06024102 RID: 147714 RVA: 0x00CA9344 File Offset: 0x00CA7544
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.Origin360");
		LuaObject.addMember(l, 0, "Bottom");
		LuaObject.addMember(l, 1, "Right");
		LuaObject.addMember(l, 2, "Top");
		LuaObject.addMember(l, 3, "Left");
		LuaDLL.lua_pop(l, 1);
	}
}
