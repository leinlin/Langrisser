using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017FD RID: 6141
[Preserve]
public class Lua_UnityEngine_TextureFormat : LuaObject
{
	// Token: 0x06023ED0 RID: 147152 RVA: 0x00C9A2D8 File Offset: 0x00C984D8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.TextureFormat");
		LuaObject.addMember(l, 1, "Alpha8");
		LuaObject.addMember(l, 2, "ARGB4444");
		LuaObject.addMember(l, 3, "RGB24");
		LuaObject.addMember(l, 4, "RGBA32");
		LuaObject.addMember(l, 5, "ARGB32");
		LuaObject.addMember(l, 7, "RGB565");
		LuaObject.addMember(l, 9, "R16");
		LuaObject.addMember(l, 10, "DXT1");
		LuaObject.addMember(l, 12, "DXT5");
		LuaObject.addMember(l, 13, "RGBA4444");
		LuaObject.addMember(l, 14, "BGRA32");
		LuaObject.addMember(l, 15, "RHalf");
		LuaObject.addMember(l, 16, "RGHalf");
		LuaObject.addMember(l, 17, "RGBAHalf");
		LuaObject.addMember(l, 18, "RFloat");
		LuaObject.addMember(l, 19, "RGFloat");
		LuaObject.addMember(l, 20, "RGBAFloat");
		LuaObject.addMember(l, 21, "YUY2");
		LuaObject.addMember(l, 22, "RGB9e5Float");
		LuaObject.addMember(l, 24, "BC6H");
		LuaObject.addMember(l, 25, "BC7");
		LuaObject.addMember(l, 26, "BC4");
		LuaObject.addMember(l, 27, "BC5");
		LuaObject.addMember(l, 28, "DXT1Crunched");
		LuaObject.addMember(l, 29, "DXT5Crunched");
		LuaObject.addMember(l, 30, "PVRTC_RGB2");
		LuaObject.addMember(l, 31, "PVRTC_RGBA2");
		LuaObject.addMember(l, 32, "PVRTC_RGB4");
		LuaObject.addMember(l, 33, "PVRTC_RGBA4");
		LuaObject.addMember(l, 34, "ETC_RGB4");
		LuaObject.addMember(l, 35, "ATC_RGB4");
		LuaObject.addMember(l, 36, "ATC_RGBA8");
		LuaObject.addMember(l, 41, "EAC_R");
		LuaObject.addMember(l, 42, "EAC_R_SIGNED");
		LuaObject.addMember(l, 43, "EAC_RG");
		LuaObject.addMember(l, 44, "EAC_RG_SIGNED");
		LuaObject.addMember(l, 45, "ETC2_RGB");
		LuaObject.addMember(l, 46, "ETC2_RGBA1");
		LuaObject.addMember(l, 47, "ETC2_RGBA8");
		LuaObject.addMember(l, 48, "ASTC_RGB_4x4");
		LuaObject.addMember(l, 49, "ASTC_RGB_5x5");
		LuaObject.addMember(l, 50, "ASTC_RGB_6x6");
		LuaObject.addMember(l, 51, "ASTC_RGB_8x8");
		LuaObject.addMember(l, 52, "ASTC_RGB_10x10");
		LuaObject.addMember(l, 53, "ASTC_RGB_12x12");
		LuaObject.addMember(l, 54, "ASTC_RGBA_4x4");
		LuaObject.addMember(l, 55, "ASTC_RGBA_5x5");
		LuaObject.addMember(l, 56, "ASTC_RGBA_6x6");
		LuaObject.addMember(l, 57, "ASTC_RGBA_8x8");
		LuaObject.addMember(l, 58, "ASTC_RGBA_10x10");
		LuaObject.addMember(l, 59, "ASTC_RGBA_12x12");
		LuaObject.addMember(l, 60, "ETC_RGB4_3DS");
		LuaObject.addMember(l, 61, "ETC_RGBA8_3DS");
		LuaObject.addMember(l, 62, "RG16");
		LuaObject.addMember(l, 63, "R8");
		LuaObject.addMember(l, 64, "ETC_RGB4Crunched");
		LuaObject.addMember(l, 65, "ETC2_RGBA8Crunched");
		LuaObject.addMember(l, -127, "PVRTC_4BPP_RGB");
		LuaObject.addMember(l, -127, "PVRTC_4BPP_RGBA");
		LuaObject.addMember(l, -127, "PVRTC_2BPP_RGB");
		LuaObject.addMember(l, -127, "PVRTC_2BPP_RGBA");
		LuaDLL.lua_pop(l, 1);
	}
}
