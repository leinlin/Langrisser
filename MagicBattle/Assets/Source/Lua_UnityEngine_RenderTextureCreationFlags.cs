using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017AE RID: 6062
[Preserve]
public class Lua_UnityEngine_RenderTextureCreationFlags : LuaObject
{
	// Token: 0x06023BB6 RID: 146358 RVA: 0x00C821B8 File Offset: 0x00C803B8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RenderTextureCreationFlags");
		LuaObject.addMember(l, 1, "MipMap");
		LuaObject.addMember(l, 2, "AutoGenerateMips");
		LuaObject.addMember(l, 4, "SRGB");
		LuaObject.addMember(l, 8, "EyeTexture");
		LuaObject.addMember(l, 16, "EnableRandomWrite");
		LuaObject.addMember(l, 32, "CreatedFromScript");
		LuaObject.addMember(l, 128, "AllowVerticalFlip");
		LuaObject.addMember(l, 256, "NoResolvedColorSurface");
		LuaObject.addMember(l, 1024, "DynamicallyScalable");
		LuaDLL.lua_pop(l, 1);
	}
}
