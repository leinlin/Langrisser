using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001858 RID: 6232
[Preserve]
public class Lua_UnityEngine_UI_ScrollRect_MovementType : LuaObject
{
	// Token: 0x06024252 RID: 148050 RVA: 0x00CB1C84 File Offset: 0x00CAFE84
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.ScrollRect.MovementType");
		LuaObject.addMember(l, 0, "Unrestricted");
		LuaObject.addMember(l, 1, "Elastic");
		LuaObject.addMember(l, 2, "Clamped");
		LuaDLL.lua_pop(l, 1);
	}
}
