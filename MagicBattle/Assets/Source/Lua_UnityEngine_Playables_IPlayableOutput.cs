using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001747 RID: 5959
[Preserve]
public class Lua_UnityEngine_Playables_IPlayableOutput : LuaObject
{
	// Token: 0x060237E5 RID: 145381 RVA: 0x00C64670 File Offset: 0x00C62870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			IPlayableOutput playableOutput = (IPlayableOutput)LuaObject.checkSelf(l);
			PlayableOutputHandle handle = playableOutput.GetHandle();
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

	// Token: 0x060237E6 RID: 145382 RVA: 0x00C646CC File Offset: 0x00C628CC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.IPlayableOutput");
		if (Lua_UnityEngine_Playables_IPlayableOutput.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_IPlayableOutput.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableOutput.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableOutput.<>f__mg$cache0);
		LuaObject.createTypeMetatable(l, null, typeof(IPlayableOutput));
	}

	// Token: 0x040195B5 RID: 103861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;
}
