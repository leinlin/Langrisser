using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001749 RID: 5961
[Preserve]
public class Lua_UnityEngine_Playables_PlayableAsset : LuaObject
{
	// Token: 0x060237EF RID: 145391 RVA: 0x00C649B8 File Offset: 0x00C62BB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreatePlayable(IntPtr l)
	{
		int result;
		try
		{
			PlayableAsset playableAsset = (PlayableAsset)LuaObject.checkSelf(l);
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

	// Token: 0x060237F0 RID: 145392 RVA: 0x00C64A2C File Offset: 0x00C62C2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_duration(IntPtr l)
	{
		int result;
		try
		{
			PlayableAsset playableAsset = (PlayableAsset)LuaObject.checkSelf(l);
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

	// Token: 0x060237F1 RID: 145393 RVA: 0x00C64A80 File Offset: 0x00C62C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_outputs(IntPtr l)
	{
		int result;
		try
		{
			PlayableAsset playableAsset = (PlayableAsset)LuaObject.checkSelf(l);
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

	// Token: 0x060237F2 RID: 145394 RVA: 0x00C64AD4 File Offset: 0x00C62CD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableAsset");
		if (Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableAsset.CreatePlayable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache0);
		string name = "duration";
		if (Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableAsset.get_duration);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache1, null, true);
		string name2 = "outputs";
		if (Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableAsset.get_outputs);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Playables_PlayableAsset.<>f__mg$cache2, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayableAsset), typeof(ScriptableObject));
	}

	// Token: 0x040195BB RID: 103867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195BC RID: 103868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195BD RID: 103869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
