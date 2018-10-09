using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200160F RID: 5647
[Preserve]
public class Lua_UnityEngine_AnimationBlendMode : LuaObject
{
	// Token: 0x06022A0F RID: 141839 RVA: 0x00BEDD34 File Offset: 0x00BEBF34
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimationBlendMode");
		LuaObject.addMember(l, 0, "Blend");
		LuaObject.addMember(l, 1, "Additive");
		LuaDLL.lua_pop(l, 1);
	}
}
