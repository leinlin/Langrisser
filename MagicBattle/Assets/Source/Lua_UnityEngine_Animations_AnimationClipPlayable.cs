using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001615 RID: 5653
[Preserve]
public class Lua_UnityEngine_Animations_AnimationClipPlayable : LuaObject
{
	// Token: 0x06022A53 RID: 141907 RVA: 0x00BEFABC File Offset: 0x00BEDCBC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationClipPlayable animationClipPlayable = default(AnimationClipPlayable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClipPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A54 RID: 141908 RVA: 0x00BEFB0C File Offset: 0x00BEDD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			AnimationClipPlayable animationClipPlayable;
			LuaObject.checkValueType<AnimationClipPlayable>(l, 1, out animationClipPlayable);
			PlayableHandle handle = animationClipPlayable.GetHandle();
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

	// Token: 0x06022A55 RID: 141909 RVA: 0x00BEFB64 File Offset: 0x00BEDD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnimationClip(IntPtr l)
	{
		int result;
		try
		{
			AnimationClipPlayable animationClipPlayable;
			LuaObject.checkValueType<AnimationClipPlayable>(l, 1, out animationClipPlayable);
			AnimationClip animationClip = animationClipPlayable.GetAnimationClip();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClip);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A56 RID: 141910 RVA: 0x00BEFBB8 File Offset: 0x00BEDDB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetApplyFootIK(IntPtr l)
	{
		int result;
		try
		{
			AnimationClipPlayable animationClipPlayable;
			LuaObject.checkValueType<AnimationClipPlayable>(l, 1, out animationClipPlayable);
			bool applyFootIK = animationClipPlayable.GetApplyFootIK();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, applyFootIK);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A57 RID: 141911 RVA: 0x00BEFC0C File Offset: 0x00BEDE0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetApplyFootIK(IntPtr l)
	{
		int result;
		try
		{
			AnimationClipPlayable animationClipPlayable;
			LuaObject.checkValueType<AnimationClipPlayable>(l, 1, out animationClipPlayable);
			bool applyFootIK;
			LuaObject.checkType(l, 2, out applyFootIK);
			animationClipPlayable.SetApplyFootIK(applyFootIK);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, animationClipPlayable);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A58 RID: 141912 RVA: 0x00BEFC70 File Offset: 0x00BEDE70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out graph);
			AnimationClip clip;
			LuaObject.checkType<AnimationClip>(l, 2, out clip);
			AnimationClipPlayable animationClipPlayable = AnimationClipPlayable.Create(graph, clip);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationClipPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A59 RID: 141913 RVA: 0x00BEFCD4 File Offset: 0x00BEDED4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.AnimationClipPlayable");
		if (Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationClipPlayable.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache0);
		if (Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationClipPlayable.GetAnimationClip);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache1);
		if (Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationClipPlayable.GetApplyFootIK);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache2);
		if (Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationClipPlayable.SetApplyFootIK);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache3);
		if (Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationClipPlayable.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache4);
		if (Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationClipPlayable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Animations_AnimationClipPlayable.<>f__mg$cache5, typeof(AnimationClipPlayable), typeof(ValueType));
	}

	// Token: 0x04018A87 RID: 100999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A88 RID: 101000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A89 RID: 101001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A8A RID: 101002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A8B RID: 101003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A8C RID: 101004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
