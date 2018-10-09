using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020017C1 RID: 6081
[Preserve]
public class Lua_UnityEngine_RuntimePlatform : LuaObject
{
	// Token: 0x06023C93 RID: 146579 RVA: 0x00C89268 File Offset: 0x00C87468
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.RuntimePlatform");
		LuaObject.addMember(l, 0, "OSXEditor");
		LuaObject.addMember(l, 1, "OSXPlayer");
		LuaObject.addMember(l, 2, "WindowsPlayer");
		LuaObject.addMember(l, 3, "OSXWebPlayer");
		LuaObject.addMember(l, 4, "OSXDashboardPlayer");
		LuaObject.addMember(l, 5, "WindowsWebPlayer");
		LuaObject.addMember(l, 7, "WindowsEditor");
		LuaObject.addMember(l, 8, "IPhonePlayer");
		LuaObject.addMember(l, 9, "PS3");
		LuaObject.addMember(l, 10, "XBOX360");
		LuaObject.addMember(l, 11, "Android");
		LuaObject.addMember(l, 12, "NaCl");
		LuaObject.addMember(l, 13, "LinuxPlayer");
		LuaObject.addMember(l, 15, "FlashPlayer");
		LuaObject.addMember(l, 16, "LinuxEditor");
		LuaObject.addMember(l, 17, "WebGLPlayer");
		LuaObject.addMember(l, 18, "WSAPlayerX86");
		LuaObject.addMember(l, 18, "MetroPlayerX86");
		LuaObject.addMember(l, 19, "WSAPlayerX64");
		LuaObject.addMember(l, 19, "MetroPlayerX64");
		LuaObject.addMember(l, 20, "WSAPlayerARM");
		LuaObject.addMember(l, 20, "MetroPlayerARM");
		LuaObject.addMember(l, 21, "WP8Player");
		LuaObject.addMember(l, 22, "BlackBerryPlayer");
		LuaObject.addMember(l, 22, "BB10Player");
		LuaObject.addMember(l, 23, "TizenPlayer");
		LuaObject.addMember(l, 24, "PSP2");
		LuaObject.addMember(l, 25, "PS4");
		LuaObject.addMember(l, 26, "PSM");
		LuaObject.addMember(l, 27, "XboxOne");
		LuaObject.addMember(l, 28, "SamsungTVPlayer");
		LuaObject.addMember(l, 30, "WiiU");
		LuaObject.addMember(l, 31, "tvOS");
		LuaObject.addMember(l, 32, "Switch");
		LuaDLL.lua_pop(l, 1);
	}
}
