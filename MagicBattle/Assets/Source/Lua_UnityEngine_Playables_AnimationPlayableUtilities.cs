using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200173F RID: 5951
[Preserve]
public class Lua_UnityEngine_Playables_AnimationPlayableUtilities : LuaObject
{
	// Token: 0x060237B8 RID: 145336 RVA: 0x00C63594 File Offset: 0x00C61794
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Play_s(IntPtr l)
	{
		int result;
		try
		{
			Animator animator;
			LuaObject.checkType<Animator>(l, 1, out animator);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 3, out graph);
			AnimationPlayableUtilities.Play(animator, playable, graph);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237B9 RID: 145337 RVA: 0x00C635F8 File Offset: 0x00C617F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayClip_s(IntPtr l)
	{
		int result;
		try
		{
			Animator animator;
			LuaObject.checkType<Animator>(l, 1, out animator);
			AnimationClip clip;
			LuaObject.checkType<AnimationClip>(l, 2, out clip);
			PlayableGraph playableGraph;
			AnimationClipPlayable animationClipPlayable = AnimationPlayableUtilities.PlayClip(animator, clip, out playableGraph);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClipPlayable);
			LuaObject.pushValue(l, playableGraph);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237BA RID: 145338 RVA: 0x00C63670 File Offset: 0x00C61870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayMixer_s(IntPtr l)
	{
		int result;
		try
		{
			Animator animator;
			LuaObject.checkType<Animator>(l, 1, out animator);
			int inputCount;
			LuaObject.checkType(l, 2, out inputCount);
			PlayableGraph playableGraph;
			AnimationMixerPlayable animationMixerPlayable = AnimationPlayableUtilities.PlayMixer(animator, inputCount, out playableGraph);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationMixerPlayable);
			LuaObject.pushValue(l, playableGraph);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237BB RID: 145339 RVA: 0x00C636E8 File Offset: 0x00C618E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayLayerMixer_s(IntPtr l)
	{
		int result;
		try
		{
			Animator animator;
			LuaObject.checkType<Animator>(l, 1, out animator);
			int inputCount;
			LuaObject.checkType(l, 2, out inputCount);
			PlayableGraph playableGraph;
			AnimationLayerMixerPlayable animationLayerMixerPlayable = AnimationPlayableUtilities.PlayLayerMixer(animator, inputCount, out playableGraph);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationLayerMixerPlayable);
			LuaObject.pushValue(l, playableGraph);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237BC RID: 145340 RVA: 0x00C63760 File Offset: 0x00C61960
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayAnimatorController_s(IntPtr l)
	{
		int result;
		try
		{
			Animator animator;
			LuaObject.checkType<Animator>(l, 1, out animator);
			RuntimeAnimatorController controller;
			LuaObject.checkType<RuntimeAnimatorController>(l, 2, out controller);
			PlayableGraph playableGraph;
			AnimatorControllerPlayable animatorControllerPlayable = AnimationPlayableUtilities.PlayAnimatorController(animator, controller, out playableGraph);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animatorControllerPlayable);
			LuaObject.pushValue(l, playableGraph);
			result = 3;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237BD RID: 145341 RVA: 0x00C637D8 File Offset: 0x00C619D8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.AnimationPlayableUtilities");
		if (Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_AnimationPlayableUtilities.Play_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_AnimationPlayableUtilities.PlayClip_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache1);
		if (Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_AnimationPlayableUtilities.PlayMixer_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache2);
		if (Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_AnimationPlayableUtilities.PlayLayerMixer_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache3);
		if (Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_AnimationPlayableUtilities.PlayAnimatorController_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_AnimationPlayableUtilities.<>f__mg$cache4);
		LuaObject.createTypeMetatable(l, null, typeof(AnimationPlayableUtilities));
	}

	// Token: 0x04019598 RID: 103832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04019599 RID: 103833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401959A RID: 103834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401959B RID: 103835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401959C RID: 103836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
