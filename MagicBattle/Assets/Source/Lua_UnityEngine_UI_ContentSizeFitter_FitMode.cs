using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001819 RID: 6169
[Preserve]
public class Lua_UnityEngine_UI_ContentSizeFitter_FitMode : LuaObject
{
	// Token: 0x06023FE5 RID: 147429 RVA: 0x00CA1FF8 File Offset: 0x00CA01F8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UI.ContentSizeFitter.FitMode");
		LuaObject.addMember(l, 0, "Unconstrained");
		LuaObject.addMember(l, 1, "MinSize");
		LuaObject.addMember(l, 2, "PreferredSize");
		LuaDLL.lua_pop(l, 1);
	}
}
