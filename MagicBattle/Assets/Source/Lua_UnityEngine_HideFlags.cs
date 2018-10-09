using System;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020016DE RID: 5854
[Preserve]
public class Lua_UnityEngine_HideFlags : LuaObject
{
	// Token: 0x06023307 RID: 144135 RVA: 0x00C35598 File Offset: 0x00C33798
	public static void reg(IntPtr l)
	{
		LuaObject.getEnumTable(l, "UnityEngine.HideFlags");
		LuaObject.addMember(l, 0, "None");
		LuaObject.addMember(l, 1, "HideInHierarchy");
		LuaObject.addMember(l, 2, "HideInInspector");
		LuaObject.addMember(l, 4, "DontSaveInEditor");
		LuaObject.addMember(l, 8, "NotEditable");
		LuaObject.addMember(l, 16, "DontSaveInBuild");
		LuaObject.addMember(l, 32, "DontUnloadUnusedAsset");
		LuaObject.addMember(l, 52, "DontSave");
		LuaObject.addMember(l, 61, "HideAndDontSave");
		LuaDLL.lua_pop(l, 1);
	}
}
