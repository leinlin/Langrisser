using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200178E RID: 6030
[Preserve]
public class Lua_UnityEngine_Rendering_LightEvent : LuaObject
{
	// Token: 0x06023AE5 RID: 146149 RVA: 0x00C7C728 File Offset: 0x00C7A928
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.LightEvent");
		LuaObject.addMember(l, 0, "BeforeShadowMap");
		LuaObject.addMember(l, 1, "AfterShadowMap");
		LuaObject.addMember(l, 2, "BeforeScreenspaceMask");
		LuaObject.addMember(l, 3, "AfterScreenspaceMask");
		LuaObject.addMember(l, 4, "BeforeShadowMapPass");
		LuaObject.addMember(l, 5, "AfterShadowMapPass");
		LuaDLL.lua_pop(l, 1);
	}
}
