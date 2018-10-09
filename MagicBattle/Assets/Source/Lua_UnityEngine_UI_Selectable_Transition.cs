using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200185C RID: 6236
[Preserve]
public class Lua_UnityEngine_UI_Selectable_Transition : LuaObject
{
	// Token: 0x0602427B RID: 148091 RVA: 0x00CB2D1C File Offset: 0x00CB0F1C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Selectable.Transition");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "ColorTint");
		LuaObject.addMember(l, 2, "SpriteSwap");
		LuaObject.addMember(l, 3, "Animation");
		LuaDLL.lua_pop(l, 1);
	}
}
