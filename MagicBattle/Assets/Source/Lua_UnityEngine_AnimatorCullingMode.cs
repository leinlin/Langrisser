using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001621 RID: 5665
[Preserve]
public class Lua_UnityEngine_AnimatorCullingMode : LuaObject
{
	// Token: 0x06022B5C RID: 142172 RVA: 0x00BFA638 File Offset: 0x00BF8838
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimatorCullingMode");
		LuaObject.addMember(l, 0, "AlwaysAnimate");
		LuaObject.addMember(l, 1, "BasedOnRenderers");
		LuaObject.addMember(l, 1, "CullUpdateTransforms");
		LuaObject.addMember(l, 2, "CullCompletely");
		LuaDLL.lua_pop(l, 1);
	}
}
