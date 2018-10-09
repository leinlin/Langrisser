using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001855 RID: 6229
[Preserve]
public class Lua_UnityEngine_UI_Scrollbar_Direction : LuaObject
{
	// Token: 0x0602420E RID: 147982 RVA: 0x00CAFE8C File Offset: 0x00CAE08C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Scrollbar.Direction");
		LuaObject.addMember(l, 0, "LeftToRight");
		LuaObject.addMember(l, 1, "RightToLeft");
		LuaObject.addMember(l, 2, "BottomToTop");
		LuaObject.addMember(l, 3, "TopToBottom");
		LuaDLL.lua_pop(l, 1);
	}
}
