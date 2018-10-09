using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015C0 RID: 5568
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UIGroup : LuaObject
{
	// Token: 0x06021DD7 RID: 138711 RVA: 0x00B84B64 File Offset: 0x00B82D64
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "BlackJack.ProjectL.UI.UIGroup");
		LuaObject.addMember(l, 0, "Entry");
		LuaObject.addMember(l, 1, "Login");
		LuaObject.addMember(l, 2, "ReLogin");
		LuaObject.addMember(l, 3, "Preload");
		LuaObject.addMember(l, 4, "Common");
		LuaObject.addMember(l, 5, "World");
		LuaObject.addMember(l, 6, "Battle");
		LuaDLL.lua_pop(l, 1);
	}
}
