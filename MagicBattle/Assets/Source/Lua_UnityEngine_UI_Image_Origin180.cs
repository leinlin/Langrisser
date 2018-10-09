using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001836 RID: 6198
[Preserve]
public class Lua_UnityEngine_UI_Image_Origin180 : LuaObject
{
	// Token: 0x06024100 RID: 147712 RVA: 0x00CA92EC File Offset: 0x00CA74EC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.Origin180");
		LuaObject.addMember(l, 0, "Bottom");
		LuaObject.addMember(l, 1, "Left");
		LuaObject.addMember(l, 2, "Top");
		LuaObject.addMember(l, 3, "Right");
		LuaDLL.lua_pop(l, 1);
	}
}
