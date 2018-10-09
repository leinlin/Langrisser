using System;
using SLua;
using UnityEngine.Animations;
using UnityEngine.Scripting;

// Token: 0x02001618 RID: 5656
[Preserve]
public class Lua_UnityEngine_Animations_AnimationPlayableExtensions : LuaObject
{
	// Token: 0x06022A69 RID: 141929 RVA: 0x00BF0360 File Offset: 0x00BEE560
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.AnimationPlayableExtensions");
		LuaObject.createTypeMetatable(l, null, typeof(AnimationPlayableExtensions));
	}
}
