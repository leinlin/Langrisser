using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001753 RID: 5971
[Preserve]
public class Lua_UnityEngine_Playables_ScriptPlayableOutput : LuaObject
{
	// Token: 0x06023839 RID: 145465 RVA: 0x00C66694 File Offset: 0x00C64894
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ScriptPlayableOutput scriptPlayableOutput = default(ScriptPlayableOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scriptPlayableOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602383A RID: 145466 RVA: 0x00C666E4 File Offset: 0x00C648E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			ScriptPlayableOutput scriptPlayableOutput;
			LuaObject.checkValueType<ScriptPlayableOutput>(l, 1, out scriptPlayableOutput);
			PlayableOutputHandle handle = scriptPlayableOutput.GetHandle();
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

	// Token: 0x0602383B RID: 145467 RVA: 0x00C6673C File Offset: 0x00C6493C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out graph);
			string name;
			LuaObject.checkType(l, 2, out name);
			ScriptPlayableOutput scriptPlayableOutput = ScriptPlayableOutput.Create(graph, name);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, scriptPlayableOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602383C RID: 145468 RVA: 0x00C667A0 File Offset: 0x00C649A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, ScriptPlayableOutput.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602383D RID: 145469 RVA: 0x00C667EC File Offset: 0x00C649EC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.ScriptPlayableOutput");
		if (Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_ScriptPlayableOutput.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_ScriptPlayableOutput.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache1);
		string name = "Null";
		if (Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_ScriptPlayableOutput.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache2, null, false);
		if (Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_ScriptPlayableOutput.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_ScriptPlayableOutput.<>f__mg$cache3, typeof(ScriptPlayableOutput), typeof(ValueType));
	}

	// Token: 0x040195F1 RID: 103921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195F2 RID: 103922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195F3 RID: 103923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195F4 RID: 103924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
