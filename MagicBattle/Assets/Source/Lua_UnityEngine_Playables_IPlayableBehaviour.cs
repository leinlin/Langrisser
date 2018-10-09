using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001746 RID: 5958
[Preserve]
public class Lua_UnityEngine_Playables_IPlayableBehaviour : LuaObject
{
	// Token: 0x060237DB RID: 145371 RVA: 0x00C64224 File Offset: 0x00C62424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGraphStart(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237DC RID: 145372 RVA: 0x00C6427C File Offset: 0x00C6247C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGraphStop(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237DD RID: 145373 RVA: 0x00C642D4 File Offset: 0x00C624D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlayableCreate(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237DE RID: 145374 RVA: 0x00C6432C File Offset: 0x00C6252C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayableDestroy(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237DF RID: 145375 RVA: 0x00C64384 File Offset: 0x00C62584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBehaviourPlay(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237E0 RID: 145376 RVA: 0x00C643E8 File Offset: 0x00C625E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBehaviourPause(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237E1 RID: 145377 RVA: 0x00C6444C File Offset: 0x00C6264C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PrepareFrame(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237E2 RID: 145378 RVA: 0x00C644B0 File Offset: 0x00C626B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ProcessFrame(IntPtr l)
	{
		int result;
		try
		{
			IPlayableBehaviour playableBehaviour = (IPlayableBehaviour)LuaObject.checkSelf(l);
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

	// Token: 0x060237E3 RID: 145379 RVA: 0x00C64524 File Offset: 0x00C62724
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.IPlayableBehaviour");
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.OnGraphStart);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.OnGraphStop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache1);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.OnPlayableCreate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache2);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.OnPlayableDestroy);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache3);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.OnBehaviourPlay);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache4);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.OnBehaviourPause);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache5);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.PrepareFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache6);
		if (Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Playables_IPlayableBehaviour.ProcessFrame);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_IPlayableBehaviour.<>f__mg$cache7);
		LuaObject.createTypeMetatable(l, null, typeof(IPlayableBehaviour));
	}

	// Token: 0x040195AD RID: 103853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195AE RID: 103854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195AF RID: 103855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195B0 RID: 103856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195B1 RID: 103857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040195B2 RID: 103858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040195B3 RID: 103859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040195B4 RID: 103860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
