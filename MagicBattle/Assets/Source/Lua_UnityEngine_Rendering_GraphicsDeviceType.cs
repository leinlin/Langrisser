using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200178A RID: 6026
[Preserve]
public class Lua_UnityEngine_Rendering_GraphicsDeviceType : LuaObject
{
	// Token: 0x06023ACD RID: 146125 RVA: 0x00C7BDFC File Offset: 0x00C79FFC
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Rendering.GraphicsDeviceType");
		LuaObject.addMember(l, 0, "OpenGL2");
		LuaObject.addMember(l, 1, "Direct3D9");
		LuaObject.addMember(l, 2, "Direct3D11");
		LuaObject.addMember(l, 3, "PlayStation3");
		LuaObject.addMember(l, 4, "Null");
		LuaObject.addMember(l, 6, "Xbox360");
		LuaObject.addMember(l, 8, "OpenGLES2");
		LuaObject.addMember(l, 11, "OpenGLES3");
		LuaObject.addMember(l, 12, "PlayStationVita");
		LuaObject.addMember(l, 13, "PlayStation4");
		LuaObject.addMember(l, 14, "XboxOne");
		LuaObject.addMember(l, 15, "PlayStationMobile");
		LuaObject.addMember(l, 16, "Metal");
		LuaObject.addMember(l, 17, "OpenGLCore");
		LuaObject.addMember(l, 18, "Direct3D12");
		LuaObject.addMember(l, 19, "N3DS");
		LuaObject.addMember(l, 21, "Vulkan");
		LuaObject.addMember(l, 22, "Switch");
		LuaObject.addMember(l, 23, "XboxOneD3D12");
		LuaDLL.lua_pop(l, 1);
	}
}
