using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200177C RID: 6012
[Preserve]
public class Lua_UnityEngine_Rendering_BuiltinRenderTextureType : LuaObject
{
	// Token: 0x06023A73 RID: 146035 RVA: 0x00C76874 File Offset: 0x00C74A74
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.BuiltinRenderTextureType");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "CurrentActive");
		LuaObject.addMember(l, 2, "CameraTarget");
		LuaObject.addMember(l, 3, "Depth");
		LuaObject.addMember(l, 4, "DepthNormals");
		LuaObject.addMember(l, 5, "ResolvedDepth");
		LuaObject.addMember(l, 7, "PrepassNormalsSpec");
		LuaObject.addMember(l, 8, "PrepassLight");
		LuaObject.addMember(l, 9, "PrepassLightSpec");
		LuaObject.addMember(l, 10, "GBuffer0");
		LuaObject.addMember(l, 11, "GBuffer1");
		LuaObject.addMember(l, 12, "GBuffer2");
		LuaObject.addMember(l, 13, "GBuffer3");
		LuaObject.addMember(l, 14, "Reflections");
		LuaObject.addMember(l, 15, "MotionVectors");
		LuaObject.addMember(l, 16, "GBuffer4");
		LuaObject.addMember(l, 17, "GBuffer5");
		LuaObject.addMember(l, 18, "GBuffer6");
		LuaObject.addMember(l, 19, "GBuffer7");
		LuaObject.addMember(l, -3, "PropertyName");
		LuaObject.addMember(l, -2, "BufferPtr");
		LuaObject.addMember(l, -1, "BindableTexture");
		LuaDLL.lua_pop(l, 1);
	}
}
