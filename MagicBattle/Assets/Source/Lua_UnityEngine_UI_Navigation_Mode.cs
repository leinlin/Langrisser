using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200184F RID: 6223
[Preserve]
public class Lua_UnityEngine_UI_Navigation_Mode : LuaObject
{
	// Token: 0x060241DA RID: 147930 RVA: 0x00CAE9EC File Offset: 0x00CACBEC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Navigation.Mode");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Horizontal");
		LuaObject.addMember(l, 2, "Vertical");
		LuaObject.addMember(l, 3, "Automatic");
		LuaObject.addMember(l, 4, "Explicit");
		LuaDLL.lua_pop(l, 1);
	}
}
