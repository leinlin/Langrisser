using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001866 RID: 6246
[Preserve]
public class Lua_UnityEngine_UI_Toggle_ToggleTransition : LuaObject
{
	// Token: 0x060242F9 RID: 148217 RVA: 0x00CB6288 File Offset: 0x00CB4488
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.Toggle.ToggleTransition");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "Fade");
		LuaDLL.lua_pop(l, 1);
	}
}
