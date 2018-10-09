using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001740 RID: 5952
[Preserve]
public class Lua_UnityEngine_Playables_DataStreamType : LuaObject
{
	// Token: 0x060237BF RID: 145343 RVA: 0x00C638B8 File Offset: 0x00C61AB8
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.Playables.DataStreamType");
		LuaObject.addMember(l, 0, "Animation");
		LuaObject.addMember(l, 1, "Audio");
		LuaObject.addMember(l, 2, "Texture");
		LuaObject.addMember(l, 3, "None");
		LuaDLL.lua_pop(l, 1);
	}
}
