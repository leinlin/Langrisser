using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200174D RID: 5965
[Preserve]
public class Lua_UnityEngine_Playables_PlayableGraph : LuaObject
{
	// Token: 0x0602380F RID: 145423 RVA: 0x00C6568C File Offset: 0x00C6388C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph = default(PlayableGraph);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableGraph);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023810 RID: 145424 RVA: 0x00C656DC File Offset: 0x00C638DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRootPlayable(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			int index;
			LuaObject.checkType(l, 2, out index);
			Playable rootPlayable = playableGraph.GetRootPlayable(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rootPlayable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023811 RID: 145425 RVA: 0x00C65744 File Offset: 0x00C63944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOutput(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			int index;
			LuaObject.checkType(l, 2, out index);
			PlayableOutput output = playableGraph.GetOutput(index);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, output);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023812 RID: 145426 RVA: 0x00C657AC File Offset: 0x00C639AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Evaluate(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				PlayableGraph playableGraph;
				LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
				playableGraph.Evaluate();
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, playableGraph);
				result = 1;
			}
			else if (num == 2)
			{
				PlayableGraph playableGraph2;
				LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph2);
				float deltaTime;
				LuaObject.checkType(l, 2, out deltaTime);
				playableGraph2.Evaluate(deltaTime);
				LuaObject.pushValue(l, true);
				LuaObject.setBack(l, playableGraph2);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Evaluate to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023813 RID: 145427 RVA: 0x00C6586C File Offset: 0x00C63A6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Destroy(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			playableGraph.Destroy();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, playableGraph);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023814 RID: 145428 RVA: 0x00C658C4 File Offset: 0x00C63AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsValid(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			bool b = playableGraph.IsValid();
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

	// Token: 0x06023815 RID: 145429 RVA: 0x00C65918 File Offset: 0x00C63B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsPlaying(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			bool b = playableGraph.IsPlaying();
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

	// Token: 0x06023816 RID: 145430 RVA: 0x00C6596C File Offset: 0x00C63B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsDone(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			bool b = playableGraph.IsDone();
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

	// Token: 0x06023817 RID: 145431 RVA: 0x00C659C0 File Offset: 0x00C63BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Play(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			playableGraph.Play();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, playableGraph);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023818 RID: 145432 RVA: 0x00C65A18 File Offset: 0x00C63C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Stop(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			playableGraph.Stop();
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, playableGraph);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023819 RID: 145433 RVA: 0x00C65A70 File Offset: 0x00C63C70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTimeUpdateMode(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			DirectorUpdateMode timeUpdateMode = playableGraph.GetTimeUpdateMode();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)timeUpdateMode);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602381A RID: 145434 RVA: 0x00C65AC4 File Offset: 0x00C63CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTimeUpdateMode(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			DirectorUpdateMode timeUpdateMode;
			LuaObject.checkEnum<DirectorUpdateMode>(l, 2, out timeUpdateMode);
			playableGraph.SetTimeUpdateMode(timeUpdateMode);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, playableGraph);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602381B RID: 145435 RVA: 0x00C65B28 File Offset: 0x00C63D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetResolver(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			IExposedPropertyTable resolver = playableGraph.GetResolver();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, resolver);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602381C RID: 145436 RVA: 0x00C65B7C File Offset: 0x00C63D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetResolver(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			IExposedPropertyTable resolver;
			LuaObject.checkType<IExposedPropertyTable>(l, 2, out resolver);
			playableGraph.SetResolver(resolver);
			LuaObject.pushValue(l, true);
			LuaObject.setBack(l, playableGraph);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602381D RID: 145437 RVA: 0x00C65BE0 File Offset: 0x00C63DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetPlayableCount(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			int playableCount = playableGraph.GetPlayableCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602381E RID: 145438 RVA: 0x00C65C34 File Offset: 0x00C63E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRootPlayableCount(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			int rootPlayableCount = playableGraph.GetRootPlayableCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rootPlayableCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602381F RID: 145439 RVA: 0x00C65C88 File Offset: 0x00C63E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetOutputCount(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph;
			LuaObject.checkValueType<PlayableGraph>(l, 1, out playableGraph);
			int outputCount = playableGraph.GetOutputCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, outputCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023820 RID: 145440 RVA: 0x00C65CDC File Offset: 0x00C63EDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Create_s(IntPtr l)
	{
		int result;
		try
		{
			PlayableGraph playableGraph = PlayableGraph.Create();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableGraph);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023821 RID: 145441 RVA: 0x00C65D28 File Offset: 0x00C63F28
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableGraph");
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetRootPlayable);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetOutput);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache1);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.Evaluate);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache2);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.Destroy);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache3);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.IsValid);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache4);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.IsPlaying);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache5);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.IsDone);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache6);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.Play);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache7);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.Stop);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache8);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetTimeUpdateMode);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache9);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.SetTimeUpdateMode);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheA);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheB == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheB = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetResolver);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheB);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheC == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheC = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.SetResolver);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheC);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheD == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheD = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetPlayableCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheD);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheE == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheE = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetRootPlayableCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheE);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheF == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheF = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.GetOutputCount);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cacheF);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache10 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache10 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.Create_s);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache10);
		if (Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache11 == null)
		{
			Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache11 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableGraph.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_PlayableGraph.<>f__mg$cache11, typeof(PlayableGraph), typeof(ValueType));
	}

	// Token: 0x040195D3 RID: 103891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195D4 RID: 103892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195D5 RID: 103893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195D6 RID: 103894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195D7 RID: 103895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040195D8 RID: 103896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040195D9 RID: 103897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040195DA RID: 103898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040195DB RID: 103899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040195DC RID: 103900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040195DD RID: 103901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040195DE RID: 103902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040195DF RID: 103903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040195E0 RID: 103904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040195E1 RID: 103905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040195E2 RID: 103906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040195E3 RID: 103907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040195E4 RID: 103908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
