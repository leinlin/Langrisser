using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001744 RID: 5956
[Preserve]
public class Lua_UnityEngine_Playables_IPlayable : LuaObject
{
	// Token: 0x060237D3 RID: 145363 RVA: 0x00C63FB0 File Offset: 0x00C621B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			IPlayable playable = (IPlayable)LuaObject.checkSelf(l);
			PlayableHandle handle = playable.GetHandle();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, handle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237D4 RID: 145364 RVA: 0x00C6400C File Offset: 0x00C6220C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.IPlayable");
		if (Lua_UnityEngine_Playables_IPlayable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_IPlayable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayable.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayable.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPlayable));
	}

	// Token: 0x040195A9 RID: 103849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
