using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200183A RID: 6202
[Preserve]
public class Lua_UnityEngine_UI_Image_OriginVertical : LuaObject
{
	// Token: 0x06024108 RID: 147720 RVA: 0x00CA9428 File Offset: 0x00CA7628
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Image.OriginVertical");
		LuaObject.addMember(l, 0, "Bottom");
		LuaObject.addMember(l, 1, "Top");
		LuaDLL.lua_pop(l, 1);
	}
}
