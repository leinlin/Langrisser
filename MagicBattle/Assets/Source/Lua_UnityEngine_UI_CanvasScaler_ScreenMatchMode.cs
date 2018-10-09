using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001811 RID: 6161
[Preserve]
public class Lua_UnityEngine_UI_CanvasScaler_ScreenMatchMode : LuaObject
{
	// Token: 0x06023FB2 RID: 147378 RVA: 0x00CA0D70 File Offset: 0x00C9EF70
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.CanvasScaler.ScreenMatchMode");
		LuaObject.addMember(l, 0, "MatchWidthOrHeight");
		LuaObject.addMember(l, 1, "Expand");
		LuaObject.addMember(l, 2, "Shrink");
		LuaDLL.lua_pop(l, 1);
	}
}
