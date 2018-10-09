using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200177F RID: 6015
[Preserve]
public class Lua_UnityEngine_Rendering_BuiltinShaderType : LuaObject
{
	// Token: 0x06023A79 RID: 146041 RVA: 0x00C76B70 File Offset: 0x00C74D70
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.BuiltinShaderType");
		LuaObject.addMember(l, 0, "DeferredShading");
		LuaObject.addMember(l, 1, "DeferredReflections");
		LuaObject.addMember(l, 2, "LegacyDeferredLighting");
		LuaObject.addMember(l, 3, "ScreenSpaceShadows");
		LuaObject.addMember(l, 4, "DepthNormals");
		LuaObject.addMember(l, 5, "MotionVectors");
		LuaObject.addMember(l, 6, "LightHalo");
		LuaObject.addMember(l, 7, "LensFlare");
		LuaDLL.lua_pop(l, 1);
	}
}
