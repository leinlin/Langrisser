using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001813 RID: 6163
[Preserve]
public class Lua_UnityEngine_UI_CanvasUpdate : LuaObject
{
	// Token: 0x06023FB6 RID: 147382 RVA: 0x00CA0E14 File Offset: 0x00C9F014
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.CanvasUpdate");
		LuaObject.addMember(l, 0, "Prelayout");
		LuaObject.addMember(l, 1, "Layout");
		LuaObject.addMember(l, 2, "PostLayout");
		LuaObject.addMember(l, 3, "PreRender");
		LuaObject.addMember(l, 4, "LatePreRender");
		LuaObject.addMember(l, 5, "MaxUpdateValue");
		LuaDLL.lua_pop(l, 1);
	}
}
