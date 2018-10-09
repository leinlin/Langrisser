using System;
using SLua;
using UnityEngine.Collections;
using UnityEngine.Scripting;

// Token: 0x0200165C RID: 5724
[Preserve]
public class Lua_UnityEngine_Collections_NativeSliceExtensions : LuaObject
{
	// Token: 0x06022E47 RID: 142919 RVA: 0x00C0FF90 File Offset: 0x00C0E190
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Collections.NativeSliceExtensions");
		LuaObject.createTypeMetatable(l, null, typeof(NativeSliceExtensions));
	}
}
