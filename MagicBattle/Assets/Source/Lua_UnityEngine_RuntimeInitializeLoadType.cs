using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017C0 RID: 6080
[Preserve]
public class Lua_UnityEngine_RuntimeInitializeLoadType : LuaObject
{
	// Token: 0x06023C91 RID: 146577 RVA: 0x00C89234 File Offset: 0x00C87434
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RuntimeInitializeLoadType");
		LuaObject.addMember(l, 0, "AfterSceneLoad");
		LuaObject.addMember(l, 1, "BeforeSceneLoad");
		LuaDLL.lua_pop(l, 1);
	}
}
