using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200174A RID: 5962
[Preserve]
public class Lua_UnityEngine_Playables_PlayableBehaviour : LuaObject
{
	// Token: 0x060237F4 RID: 145396 RVA: 0x00C64B88 File Offset: 0x00C62D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGraphStart(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			playableBehaviour.OnGraphStart(playable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237F5 RID: 145397 RVA: 0x00C64BE0 File Offset: 0x00C62DE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnGraphStop(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			playableBehaviour.OnGraphStop(playable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237F6 RID: 145398 RVA: 0x00C64C38 File Offset: 0x00C62E38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayableCreate(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			playableBehaviour.OnPlayableCreate(playable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237F7 RID: 145399 RVA: 0x00C64C90 File Offset: 0x00C62E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayableDestroy(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			playableBehaviour.OnPlayableDestroy(playable);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237F8 RID: 145400 RVA: 0x00C64CE8 File Offset: 0x00C62EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBehaviourDelay(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			FrameData info;
			LuaObject.checkValueType<FrameData>(l, 3, out info);
			playableBehaviour.OnBehaviourDelay(playable, info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237F9 RID: 145401 RVA: 0x00C64D4C File Offset: 0x00C62F4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBehaviourPlay(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			FrameData info;
			LuaObject.checkValueType<FrameData>(l, 3, out info);
			playableBehaviour.OnBehaviourPlay(playable, info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237FA RID: 145402 RVA: 0x00C64DB0 File Offset: 0x00C62FB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBehaviourPause(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			FrameData info;
			LuaObject.checkValueType<FrameData>(l, 3, out info);
			playableBehaviour.OnBehaviourPause(playable, info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237FB RID: 145403 RVA: 0x00C64E14 File Offset: 0x00C63014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareData(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			FrameData info;
			LuaObject.checkValueType<FrameData>(l, 3, out info);
			playableBehaviour.PrepareData(playable, info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237FC RID: 145404 RVA: 0x00C64E78 File Offset: 0x00C63078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			FrameData info;
			LuaObject.checkValueType<FrameData>(l, 3, out info);
			playableBehaviour.PrepareFrame(playable, info);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237FD RID: 145405 RVA: 0x00C64EDC File Offset: 0x00C630DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ProcessFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayableBehaviour playableBehaviour = (PlayableBehaviour)LuaObject.checkSelf(l);
			Playable playable;
			LuaObject.checkValueType<Playable>(l, 2, out playable);
			FrameData info;
			LuaObject.checkValueType<FrameData>(l, 3, out info);
			object playerData;
			LuaObject.checkType<object>(l, 4, out playerData);
			playableBehaviour.ProcessFrame(playable, info, playerData);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060237FE RID: 145406 RVA: 0x00C64F50 File Offset: 0x00C63150
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableBehaviour");
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnGraphStart);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnGraphStop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache1);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnPlayableCreate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache2);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnPlayableDestroy);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache3);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnBehaviourDelay);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache4);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnBehaviourPlay);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache5);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.OnBehaviourPause);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache6);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.PrepareData);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache7);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.PrepareFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache8);
		if (Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBehaviour.ProcessFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableBehaviour.<>f__mg$cache9);
		LuaObject.createTypeMetatable(l, null, typeof(PlayableBehaviour));
	}

	// Token: 0x040195BE RID: 103870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195BF RID: 103871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195C0 RID: 103872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195C1 RID: 103873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195C2 RID: 103874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040195C3 RID: 103875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040195C4 RID: 103876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040195C5 RID: 103877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040195C6 RID: 103878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040195C7 RID: 103879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
