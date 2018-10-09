using System;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200174C RID: 5964
[Preserve]
public class Lua_UnityEngine_Playables_PlayableExtensions : LuaObject
{
	// Token: 0x0602380D RID: 145421 RVA: 0x00C65664 File Offset: 0x00C63864
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableExtensions");
		LuaObject.createTypeMetatable(l, null, typeof(PlayableExtensions));
	}
}
