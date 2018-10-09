using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001616 RID: 5654
[Preserve]
public class Lua_UnityEngine_Animations_AnimationLayerMixerPlayable : LuaObject
{
	// Token: 0x06022A5B RID: 141915 RVA: 0x00BEFDDC File Offset: 0x00BEDFDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationLayerMixerPlayable animationLayerMixerPlayable = default(AnimationLayerMixerPlayable);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationLayerMixerPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A5C RID: 141916 RVA: 0x00BEFE2C File Offset: 0x00BEE02C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			AnimationLayerMixerPlayable animationLayerMixerPlayable;
			LuaObject.checkValueType<AnimationLayerMixerPlayable>(l, 1, out animationLayerMixerPlayable);
			PlayableHandle handle = animationLayerMixerPlayable.GetHandle();
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

	// Token: 0x06022A5D RID: 141917 RVA: 0x00BEFE84 File Offset: 0x00BEE084
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsLayerAdditive(IntPtr l)
	{
		int result;
		try
		{
			AnimationLayerMixerPlayable animationLayerMixerPlayable;
			LuaObject.checkValueType<AnimationLayerMixerPlayable>(l, 1, out animationLayerMixerPlayable);
			uint layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			bool b = animationLayerMixerPlayable.IsLayerAdditive(layerIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, b);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A5E RID: 141918 RVA: 0x00BEFEE4 File Offset: 0x00BEE0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerAdditive(IntPtr l)
	{
		int result;
		try
		{
			AnimationLayerMixerPlayable animationLayerMixerPlayable;
			LuaObject.checkValueType<AnimationLayerMixerPlayable>(l, 1, out animationLayerMixerPlayable);
			uint layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			bool value;
			LuaObject.checkType(l, 3, out value);
			animationLayerMixerPlayable.SetLayerAdditive(layerIndex, value);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, animationLayerMixerPlayable);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A5F RID: 141919 RVA: 0x00BEFF54 File Offset: 0x00BEE154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLayerMaskFromAvatarMask(IntPtr l)
	{
		int result;
		try
		{
			AnimationLayerMixerPlayable animationLayerMixerPlayable;
			LuaObject.checkValueType<AnimationLayerMixerPlayable>(l, 1, out animationLayerMixerPlayable);
			uint layerIndex;
			LuaObject.checkType(l, 2, out layerIndex);
			AvatarMask mask;
			LuaObject.checkType<AvatarMask>(l, 3, out mask);
			animationLayerMixerPlayable.SetLayerMaskFromAvatarMask(layerIndex, mask);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, animationLayerMixerPlayable);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A60 RID: 141920 RVA: 0x00BEFFC4 File Offset: 0x00BEE1C4
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
			AnimationLayerMixerPlayable animationLayerMixerPlayable = AnimationLayerMixerPlayable.Create(graph, inputCount);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationLayerMixerPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A61 RID: 141921 RVA: 0x00BF0028 File Offset: 0x00BEE228
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AnimationLayerMixerPlayable.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A62 RID: 141922 RVA: 0x00BF0074 File Offset: 0x00BEE274
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.AnimationLayerMixerPlayable");
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache0);
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.IsLayerAdditive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache1);
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.SetLayerAdditive);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache2);
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.SetLayerMaskFromAvatarMask);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache3);
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache4);
		string name = "Null";
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache5, null, false);
		if (Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Animations_AnimationLayerMixerPlayable.<>f__mg$cache6, typeof(AnimationLayerMixerPlayable), typeof(ValueType));
	}

	// Token: 0x04018A8D RID: 101005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A8E RID: 101006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A8F RID: 101007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A90 RID: 101008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A91 RID: 101009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A92 RID: 101010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04018A93 RID: 101011
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
