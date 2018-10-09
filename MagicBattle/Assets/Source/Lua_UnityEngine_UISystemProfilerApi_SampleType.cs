using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200186D RID: 6253
[Preserve]
public class Lua_UnityEngine_UISystemProfilerApi_SampleType : LuaObject
{
	// Token: 0x06024333 RID: 148275 RVA: 0x00CB7A3C File Offset: 0x00CB5C3C
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.UISystemProfilerApi.SampleType");
		LuaObject.addMember(l, 0, "Layout");
		LuaObject.addMember(l, 1, "Render");
		LuaDLL.lua_pop(l, 1);
	}
}
