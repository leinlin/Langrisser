using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001792 RID: 6034
[Preserve]
public class Lua_UnityEngine_Rendering_PassType : LuaObject
{
	// Token: 0x06023AED RID: 146157 RVA: 0x00C7C87C File Offset: 0x00C7AA7C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.PassType");
		LuaObject.addMember(l, 0, "Normal");
		LuaObject.addMember(l, 1, "Vertex");
		LuaObject.addMember(l, 2, "VertexLM");
		LuaObject.addMember(l, 3, "VertexLMRGBM");
		LuaObject.addMember(l, 4, "ForwardBase");
		LuaObject.addMember(l, 5, "ForwardAdd");
		LuaObject.addMember(l, 6, "LightPrePassBase");
		LuaObject.addMember(l, 7, "LightPrePassFinal");
		LuaObject.addMember(l, 8, "ShadowCaster");
		LuaObject.addMember(l, 10, "Deferred");
		LuaObject.addMember(l, 11, "Meta");
		LuaObject.addMember(l, 12, "MotionVectors");
		LuaDLL.lua_pop(l, 1);
	}
}
