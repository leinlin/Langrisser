using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200185F RID: 6239
[Preserve]
public class Lua_UnityEngine_UI_Slider_Direction : LuaObject
{
	// Token: 0x060242A6 RID: 148134 RVA: 0x00CB3F68 File Offset: 0x00CB2168
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Slider.Direction");
		LuaObject.addMember(l, 0, "LeftToRight");
		LuaObject.addMember(l, 1, "RightToLeft");
		LuaObject.addMember(l, 2, "BottomToTop");
		LuaObject.addMember(l, 3, "TopToBottom");
		LuaDLL.lua_pop(l, 1);
	}
}
