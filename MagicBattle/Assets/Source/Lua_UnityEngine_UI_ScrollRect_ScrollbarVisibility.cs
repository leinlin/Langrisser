using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001859 RID: 6233
[Preserve]
public class Lua_UnityEngine_UI_ScrollRect_ScrollbarVisibility : LuaObject
{
	// Token: 0x06024254 RID: 148052 RVA: 0x00CB1CC4 File Offset: 0x00CAFEC4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.ScrollRect.ScrollbarVisibility");
		LuaObject.addMember(l, 0, "Permanent");
		LuaObject.addMember(l, 1, "AutoHide");
		LuaObject.addMember(l, 2, "AutoHideAndExpandViewport");
		LuaDLL.lua_pop(l, 1);
	}
}
