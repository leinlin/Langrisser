using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017C4 RID: 6084
[Preserve]
public class Lua_UnityEngine_SceneManagement_LoadSceneMode : LuaObject
{
	// Token: 0x06023C9C RID: 146588 RVA: 0x00C89614 File Offset: 0x00C87814
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.SceneManagement.LoadSceneMode");
		LuaObject.addMember(l, 0, "Single");
		LuaObject.addMember(l, 1, "Additive");
		LuaDLL.lua_pop(l, 1);
	}
}
