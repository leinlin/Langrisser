using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001745 RID: 5957
[Preserve]
public class Lua_UnityEngine_Playables_IPlayableAsset : LuaObject
{
	// Token: 0x060237D6 RID: 145366 RVA: 0x00C64060 File Offset: 0x00C62260
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CreatePlayable(IntPtr l)
	{
		int result;
		try
		{
			IPlayableAsset playableAsset = (IPlayableAsset)LuaObject.checkSelf(l);
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 2, out graph);
			GameObject owner;
			LuaObject.checkType<GameObject>(l, 3, out owner);
			Playable playable = playableAsset.CreatePlayable(graph, owner);
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

	// Token: 0x060237D7 RID: 145367 RVA: 0x00C640D4 File Offset: 0x00C622D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_duration(IntPtr l)
	{
		int result;
		try
		{
			IPlayableAsset playableAsset = (IPlayableAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableAsset.duration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237D8 RID: 145368 RVA: 0x00C64128 File Offset: 0x00C62328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_outputs(IntPtr l)
	{
		int result;
		try
		{
			IPlayableAsset playableAsset = (IPlayableAsset)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableAsset.outputs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237D9 RID: 145369 RVA: 0x00C6417C File Offset: 0x00C6237C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.IPlayableAsset");
		if (Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableAsset.CreatePlayable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache0);
		string name = "duration";
		if (Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableAsset.get_duration);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache1, null, true);
		string name2 = "outputs";
		if (Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableAsset.get_outputs);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Playables_IPlayableAsset.<>f__mg$cache2, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(IPlayableAsset));
	}

	// Token: 0x040195AA RID: 103850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195AB RID: 103851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195AC RID: 103852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
