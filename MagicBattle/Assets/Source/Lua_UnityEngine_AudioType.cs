using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001635 RID: 5685
[Preserve]
public class Lua_UnityEngine_AudioType : LuaObject
{
	// Token: 0x06022C19 RID: 142361 RVA: 0x00BFFD80 File Offset: 0x00BFDF80
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.AudioType");
		LuaObject.addMember(l, 0, "UNKNOWN");
		LuaObject.addMember(l, 1, "ACC");
		LuaObject.addMember(l, 2, "AIFF");
		LuaObject.addMember(l, 10, "IT");
		LuaObject.addMember(l, 12, "MOD");
		LuaObject.addMember(l, 13, "MPEG");
		LuaObject.addMember(l, 14, "OGGVORBIS");
		LuaObject.addMember(l, 17, "S3M");
		LuaObject.addMember(l, 20, "WAV");
		LuaObject.addMember(l, 21, "XM");
		LuaObject.addMember(l, 22, "XMA");
		LuaObject.addMember(l, 23, "VAG");
		LuaObject.addMember(l, 24, "AUDIOQUEUE");
		LuaDLL.lua_pop(l, 1);
	}
}
