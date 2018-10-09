using System;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001750 RID: 5968
[Preserve]
public class Lua_UnityEngine_Playables_PlayableOutputExtensions : LuaObject
{
	// Token: 0x0602382F RID: 145455 RVA: 0x00C66408 File Offset: 0x00C64608
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableOutputExtensions");
		LuaObject.createTypeMetatable(l, null, typeof(PlayableOutputExtensions));
	}
}
