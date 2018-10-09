using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001611 RID: 5649
[Preserve]
public class Lua_UnityEngine_AnimationCullingType : LuaObject
{
	// Token: 0x06022A26 RID: 141862 RVA: 0x00BEE6C4 File Offset: 0x00BEC8C4
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AnimationCullingType");
		LuaObject.addMember(l, 0, "AlwaysAnimate");
		LuaObject.addMember(l, 1, "BasedOnRenderers");
		LuaObject.addMember(l, 2, "BasedOnClipBounds");
		LuaObject.addMember(l, 3, "BasedOnUserBounds");
		LuaDLL.lua_pop(l, 1);
	}
}
