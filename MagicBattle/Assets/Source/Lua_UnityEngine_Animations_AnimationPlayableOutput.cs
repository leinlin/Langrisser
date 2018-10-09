using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Animations;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001619 RID: 5657
[Preserve]
public class Lua_UnityEngine_Animations_AnimationPlayableOutput : LuaObject
{
	// Token: 0x06022A6B RID: 141931 RVA: 0x00BF0388 File Offset: 0x00BEE588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			AnimationPlayableOutput animationPlayableOutput = default(AnimationPlayableOutput);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationPlayableOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A6C RID: 141932 RVA: 0x00BF03D8 File Offset: 0x00BEE5D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetHandle(IntPtr l)
	{
		int result;
		try
		{
			AnimationPlayableOutput animationPlayableOutput;
			LuaObject.checkValueType<AnimationPlayableOutput>(l, 1, out animationPlayableOutput);
			PlayableOutputHandle handle = animationPlayableOutput.GetHandle();
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

	// Token: 0x06022A6D RID: 141933 RVA: 0x00BF0430 File Offset: 0x00BEE630
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetTarget(IntPtr l)
	{
		int result;
		try
		{
			AnimationPlayableOutput animationPlayableOutput;
			LuaObject.checkValueType<AnimationPlayableOutput>(l, 1, out animationPlayableOutput);
			Animator target = animationPlayableOutput.GetTarget();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, target);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A6E RID: 141934 RVA: 0x00BF0484 File Offset: 0x00BEE684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTarget(IntPtr l)
	{
		int result;
		try
		{
			AnimationPlayableOutput animationPlayableOutput;
			LuaObject.checkValueType<AnimationPlayableOutput>(l, 1, out animationPlayableOutput);
			Animator target;
			LuaObject.checkType<Animator>(l, 2, out target);
			animationPlayableOutput.SetTarget(target);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, animationPlayableOutput);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A6F RID: 141935 RVA: 0x00BF04E8 File Offset: 0x00BEE6E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph graph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out graph);
			string name;
			LuaObject.checkType(l, 2, out name);
			Animator target;
			LuaObject.checkType<Animator>(l, 3, out target);
			AnimationPlayableOutput animationPlayableOutput = AnimationPlayableOutput.Create(graph, name, target);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, animationPlayableOutput);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A70 RID: 141936 RVA: 0x00BF055C File Offset: 0x00BEE75C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, AnimationPlayableOutput.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022A71 RID: 141937 RVA: 0x00BF05A8 File Offset: 0x00BEE7A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Animations.AnimationPlayableOutput");
		if (Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationPlayableOutput.GetHandle);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache0);
		if (Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationPlayableOutput.GetTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache1);
		if (Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationPlayableOutput.SetTarget);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache2);
		if (Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationPlayableOutput.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache3);
		string name = "Null";
		if (Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationPlayableOutput.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache4, null, false);
		if (Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Animations_AnimationPlayableOutput.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Animations_AnimationPlayableOutput.<>f__mg$cache5, typeof(AnimationPlayableOutput), typeof(ValueType));
	}

	// Token: 0x04018A97 RID: 101015
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018A98 RID: 101016
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018A99 RID: 101017
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018A9A RID: 101018
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04018A9B RID: 101019
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04018A9C RID: 101020
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
