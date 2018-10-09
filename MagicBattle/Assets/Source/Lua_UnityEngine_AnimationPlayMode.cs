using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001614 RID: 5652
[Preserve]
public class Lua_UnityEngine_AnimationPlayMode : LuaObject
{
	// Token: 0x06022A51 RID: 141905 RVA: 0x00BEFA7C File Offset: 0x00BEDC7C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimationPlayMode");
		LuaObject.addMember(l, 0, "Stop");
		LuaObject.addMember(l, 1, "Queue");
		LuaObject.addMember(l, 2, "Mix");
		LuaDLL.lua_pop(l, 1);
	}
}
