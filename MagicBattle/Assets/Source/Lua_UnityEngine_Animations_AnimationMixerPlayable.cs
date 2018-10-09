using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001617 RID: 5655
[Preserve]
public class Lua_UnityEngine_Animations_AnimationMixerPlayable : LuaObject
{
	// Token: 0x06022A64 RID: 141924 RVA: 0x00BF01A4 File Offset: 0x00BEE3A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationMixerPlayable animationMixerPlayable = default(AnimationMixerPlayable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationMixerPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A65 RID: 141925 RVA: 0x00BF01F4 File Offset: 0x00BEE3F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			AnimationMixerPlayable animationMixerPlayable;
			LuaObject.checkValueType<AnimationMixerPlayable>(l, 1, out animationMixerPlayable);
			PlayableHandle handle = animationMixerPlayable.GetHandle();
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

	// Token: 0x06022A66 RID: 141926 RVA: 0x00BF024C File Offset: 0x00BEE44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out graph);
			int inputCount;
			LuaObject.checkType(l, 2, out inputCount);
			bool normalizeWeights;
			LuaObject.checkType(l, 3, out normalizeWeights);
			AnimationMixerPlayable animationMixerPlayable = AnimationMixerPlayable.Create(graph, inputCount, normalizeWeights);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationMixerPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A67 RID: 141927 RVA: 0x00BF02C0 File Offset: 0x00BEE4C0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.AnimationMixerPlayable");
		if (Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationMixerPlayable.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache0);
		if (Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationMixerPlayable.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache1);
		if (Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationMixerPlayable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Animations_AnimationMixerPlayable.<>f__mg$cache2, typeof(AnimationMixerPlayable), typeof(ValueType));
	}

	// Token: 0x04018A94 RID: 101012
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A95 RID: 101013
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A96 RID: 101014
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
