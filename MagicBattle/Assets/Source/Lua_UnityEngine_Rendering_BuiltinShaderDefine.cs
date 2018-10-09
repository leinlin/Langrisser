using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200177D RID: 6013
[Preserve]
public class Lua_UnityEngine_Rendering_BuiltinShaderDefine : LuaObject
{
	// Token: 0x06023A75 RID: 146037 RVA: 0x00C769B0 File Offset: 0x00C74BB0
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.BuiltinShaderDefine");
		LuaObject.addMember(l, 0, "UNITY_NO_DXT5nm");
		LuaObject.addMember(l, 1, "UNITY_NO_RGBM");
		LuaObject.addMember(l, 2, "UNITY_USE_NATIVE_HDR");
		LuaObject.addMember(l, 3, "UNITY_ENABLE_REFLECTION_BUFFERS");
		LuaObject.addMember(l, 4, "UNITY_FRAMEBUFFER_FETCH_AVAILABLE");
		LuaObject.addMember(l, 5, "UNITY_ENABLE_NATIVE_SHADOW_LOOKUPS");
		LuaObject.addMember(l, 6, "UNITY_METAL_SHADOWS_USE_POINT_FILTERING");
		LuaObject.addMember(l, 7, "UNITY_NO_CUBEMAP_ARRAY");
		LuaObject.addMember(l, 8, "UNITY_NO_SCREENSPACE_SHADOWS");
		LuaObject.addMember(l, 9, "UNITY_USE_DITHER_MASK_FOR_ALPHABLENDED_SHADOWS");
		LuaObject.addMember(l, 10, "UNITY_PBS_USE_BRDF1");
		LuaObject.addMember(l, 11, "UNITY_PBS_USE_BRDF2");
		LuaObject.addMember(l, 12, "UNITY_PBS_USE_BRDF3");
		LuaObject.addMember(l, 13, "UNITY_NO_FULL_STANDARD_SHADER");
		LuaObject.addMember(l, 14, "UNITY_SPECCUBE_BOX_PROJECTION");
		LuaObject.addMember(l, 15, "UNITY_SPECCUBE_BLENDING");
		LuaObject.addMember(l, 16, "UNITY_ENABLE_DETAIL_NORMALMAP");
		LuaObject.addMember(l, 17, "SHADER_API_MOBILE");
		LuaObject.addMember(l, 18, "SHADER_API_DESKTOP");
		LuaObject.addMember(l, 19, "UNITY_HARDWARE_TIER1");
		LuaObject.addMember(l, 20, "UNITY_HARDWARE_TIER2");
		LuaObject.addMember(l, 21, "UNITY_HARDWARE_TIER3");
		LuaObject.addMember(l, 22, "UNITY_COLORSPACE_GAMMA");
		LuaObject.addMember(l, 23, "UNITY_LIGHT_PROBE_PROXY_VOLUME");
		LuaObject.addMember(l, 24, "UNITY_LIGHTMAP_DLDR_ENCODING");
		LuaObject.addMember(l, 25, "UNITY_LIGHTMAP_RGBM_ENCODING");
		LuaObject.addMember(l, 26, "UNITY_LIGHTMAP_FULL_HDR");
		LuaDLL.lua_pop(l, 1);
	}
}
