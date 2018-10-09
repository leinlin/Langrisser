using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200174F RID: 5967
[Preserve]
public class Lua_UnityEngine_Playables_PlayableOutput : LuaObject
{
	// Token: 0x06023829 RID: 145449 RVA: 0x00C661F8 File Offset: 0x00C643F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayableOutput playableOutput = default(PlayableOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602382A RID: 145450 RVA: 0x00C66248 File Offset: 0x00C64448
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			PlayableOutput playableOutput;
			LuaObject.checkValueType<PlayableOutput>(l, 1, out playableOutput);
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

	// Token: 0x0602382B RID: 145451 RVA: 0x00C662A0 File Offset: 0x00C644A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayableOutputType(IntPtr l)
	{
		int result;
		try
		{
			PlayableOutput playableOutput;
			LuaObject.checkValueType<PlayableOutput>(l, 1, out playableOutput);
			Type playableOutputType = playableOutput.GetPlayableOutputType();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableOutputType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602382C RID: 145452 RVA: 0x00C662F4 File Offset: 0x00C644F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayableOutput.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602382D RID: 145453 RVA: 0x00C66340 File Offset: 0x00C64540
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableOutput");
		if (Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutput.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutput.GetPlayableOutputType);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache1);
		string name = "Null";
		if (Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutput.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache2, null, false);
		if (Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutput.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_PlayableOutput.<>f__mg$cache3, typeof(PlayableOutput), typeof(ValueType));
	}

	// Token: 0x040195E9 RID: 103913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195EA RID: 103914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195EB RID: 103915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195EC RID: 103916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
