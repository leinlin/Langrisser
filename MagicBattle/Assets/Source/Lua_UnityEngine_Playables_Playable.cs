using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001748 RID: 5960
[Preserve]
public class Lua_UnityEngine_Playables_Playable : LuaObject
{
	// Token: 0x060237E8 RID: 145384 RVA: 0x00C64720 File Offset: 0x00C62920
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Playable playable = default(Playable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237E9 RID: 145385 RVA: 0x00C64770 File Offset: 0x00C62970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 1, out playable);
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

	// Token: 0x060237EA RID: 145386 RVA: 0x00C647C8 File Offset: 0x00C629C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayableType(IntPtr l)
	{
		int result;
		try
		{
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 1, out playable);
			Type playableType = playable.GetPlayableType();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237EB RID: 145387 RVA: 0x00C6481C File Offset: 0x00C62A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out graph);
			int inputCount;
			LuaObject.checkType(l, 2, out inputCount);
			Playable playable = Playable.Create(graph, inputCount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237EC RID: 145388 RVA: 0x00C64880 File Offset: 0x00C62A80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, Playable.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237ED RID: 145389 RVA: 0x00C648CC File Offset: 0x00C62ACC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.Playable");
		if (Lua_UnityEngine_Playables_Playable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_Playable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_Playable.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_Playable.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_Playable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_Playable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_Playable.GetPlayableType);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_Playable.<>f__mg$cache1);
		if (Lua_UnityEngine_Playables_Playable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_Playable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_Playable.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_Playable.<>f__mg$cache2);
		string name = "Null";
		if (Lua_UnityEngine_Playables_Playable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_Playable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_Playable.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_Playable.<>f__mg$cache3, null, false);
		if (Lua_UnityEngine_Playables_Playable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_Playable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_Playable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_Playable.<>f__mg$cache4, typeof(Playable), typeof(ValueType));
	}

	// Token: 0x040195B6 RID: 103862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195B7 RID: 103863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195B8 RID: 103864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195B9 RID: 103865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195BA RID: 103866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
