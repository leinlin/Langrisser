using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017A1 RID: 6049
[Preserve]
public class Lua_UnityEngine_Rendering_ShadowMapPass : LuaObject
{
	// Token: 0x06023B13 RID: 146195 RVA: 0x00C7D474 File Offset: 0x00C7B674
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.ShadowMapPass");
		LuaObject.addMember(l, 1, "PointlightPositiveX");
		LuaObject.addMember(l, 2, "PointlightNegativeX");
		LuaObject.addMember(l, 4, "PointlightPositiveY");
		LuaObject.addMember(l, 8, "PointlightNegativeY");
		LuaObject.addMember(l, 16, "PointlightPositiveZ");
		LuaObject.addMember(l, 32, "PointlightNegativeZ");
		LuaObject.addMember(l, 63, "Pointlight");
		LuaObject.addMember(l, 64, "DirectionalCascade0");
		LuaObject.addMember(l, 128, "DirectionalCascade1");
		LuaObject.addMember(l, 256, "DirectionalCascade2");
		LuaObject.addMember(l, 512, "DirectionalCascade3");
		LuaObject.addMember(l, 960, "Directional");
		LuaObject.addMember(l, 1024, "Spotlight");
		LuaObject.addMember(l, 2047, "All");
		LuaDLL.lua_pop(l, 1);
	}
}
