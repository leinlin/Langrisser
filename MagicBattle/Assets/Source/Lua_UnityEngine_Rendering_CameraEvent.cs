using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001780 RID: 6016
[Preserve]
public class Lua_UnityEngine_Rendering_CameraEvent : LuaObject
{
	// Token: 0x06023A7B RID: 146043 RVA: 0x00C76BF8 File Offset: 0x00C74DF8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.CameraEvent");
		LuaObject.addMember(l, 0, "BeforeDepthTexture");
		LuaObject.addMember(l, 1, "AfterDepthTexture");
		LuaObject.addMember(l, 2, "BeforeDepthNormalsTexture");
		LuaObject.addMember(l, 3, "AfterDepthNormalsTexture");
		LuaObject.addMember(l, 4, "BeforeGBuffer");
		LuaObject.addMember(l, 5, "AfterGBuffer");
		LuaObject.addMember(l, 6, "BeforeLighting");
		LuaObject.addMember(l, 7, "AfterLighting");
		LuaObject.addMember(l, 8, "BeforeFinalPass");
		LuaObject.addMember(l, 9, "AfterFinalPass");
		LuaObject.addMember(l, 10, "BeforeForwardOpaque");
		LuaObject.addMember(l, 11, "AfterForwardOpaque");
		LuaObject.addMember(l, 12, "BeforeImageEffectsOpaque");
		LuaObject.addMember(l, 13, "AfterImageEffectsOpaque");
		LuaObject.addMember(l, 14, "BeforeSkybox");
		LuaObject.addMember(l, 15, "AfterSkybox");
		LuaObject.addMember(l, 16, "BeforeForwardAlpha");
		LuaObject.addMember(l, 17, "AfterForwardAlpha");
		LuaObject.addMember(l, 18, "BeforeImageEffects");
		LuaObject.addMember(l, 19, "AfterImageEffects");
		LuaObject.addMember(l, 20, "AfterEverything");
		LuaObject.addMember(l, 21, "BeforeReflections");
		LuaObject.addMember(l, 22, "AfterReflections");
		LuaObject.addMember(l, 23, "BeforeHaloAndLensFlares");
		LuaObject.addMember(l, 24, "AfterHaloAndLensFlares");
		LuaDLL.lua_pop(l, 1);
	}
}
