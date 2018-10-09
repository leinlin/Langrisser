using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017B0 RID: 6064
[Preserve]
public class Lua_UnityEngine_RenderTextureFormat : LuaObject
{
	// Token: 0x06023BDA RID: 146394 RVA: 0x00C83378 File Offset: 0x00C81578
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RenderTextureFormat");
		LuaObject.addMember(l, 0, "ARGB32");
		LuaObject.addMember(l, 1, "Depth");
		LuaObject.addMember(l, 2, "ARGBHalf");
		LuaObject.addMember(l, 3, "Shadowmap");
		LuaObject.addMember(l, 4, "RGB565");
		LuaObject.addMember(l, 5, "ARGB4444");
		LuaObject.addMember(l, 6, "ARGB1555");
		LuaObject.addMember(l, 7, "Default");
		LuaObject.addMember(l, 8, "ARGB2101010");
		LuaObject.addMember(l, 9, "DefaultHDR");
		LuaObject.addMember(l, 10, "ARGB64");
		LuaObject.addMember(l, 11, "ARGBFloat");
		LuaObject.addMember(l, 12, "RGFloat");
		LuaObject.addMember(l, 13, "RGHalf");
		LuaObject.addMember(l, 14, "RFloat");
		LuaObject.addMember(l, 15, "RHalf");
		LuaObject.addMember(l, 16, "R8");
		LuaObject.addMember(l, 17, "ARGBInt");
		LuaObject.addMember(l, 18, "RGInt");
		LuaObject.addMember(l, 19, "RInt");
		LuaObject.addMember(l, 20, "BGRA32");
		LuaObject.addMember(l, 22, "RGB111110Float");
		LuaObject.addMember(l, 23, "RG32");
		LuaObject.addMember(l, 24, "RGBAUShort");
		LuaObject.addMember(l, 25, "RG16");
		LuaObject.addMember(l, 26, "BGRA10101010_XR");
		LuaObject.addMember(l, 27, "BGR101010_XR");
		LuaDLL.lua_pop(l, 1);
	}
}
