using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200174B RID: 5963
[Preserve]
public class Lua_UnityEngine_Playables_PlayableBinding : LuaObject
{
	// Token: 0x06023800 RID: 145408 RVA: 0x00C650E0 File Offset: 0x00C632E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding = default(PlayableBinding);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableBinding);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023801 RID: 145409 RVA: 0x00C65130 File Offset: 0x00C63330
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_None(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayableBinding.None);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023802 RID: 145410 RVA: 0x00C65178 File Offset: 0x00C63378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefaultDuration(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayableBinding.DefaultDuration);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023803 RID: 145411 RVA: 0x00C651C0 File Offset: 0x00C633C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_streamName(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableBinding.streamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023804 RID: 145412 RVA: 0x00C65214 File Offset: 0x00C63414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_streamName(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			string streamName;
			LuaObject.checkType(l, 2, out streamName);
			playableBinding.streamName = streamName;
			LuaObject.setBack(l, playableBinding);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023805 RID: 145413 RVA: 0x00C65278 File Offset: 0x00C63478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_streamType(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)playableBinding.streamType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023806 RID: 145414 RVA: 0x00C652CC File Offset: 0x00C634CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_streamType(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			DataStreamType streamType;
			LuaObject.checkEnum<DataStreamType>(l, 2, out streamType);
			playableBinding.streamType = streamType;
			LuaObject.setBack(l, playableBinding);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023807 RID: 145415 RVA: 0x00C65330 File Offset: 0x00C63530
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_sourceObject(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableBinding.sourceObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023808 RID: 145416 RVA: 0x00C65384 File Offset: 0x00C63584
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_sourceObject(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			UnityEngine.Object sourceObject;
			LuaObject.checkType<UnityEngine.Object>(l, 2, out sourceObject);
			playableBinding.sourceObject = sourceObject;
			LuaObject.setBack(l, playableBinding);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023809 RID: 145417 RVA: 0x00C653E8 File Offset: 0x00C635E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_sourceBindingType(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableBinding.sourceBindingType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602380A RID: 145418 RVA: 0x00C6543C File Offset: 0x00C6363C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_sourceBindingType(IntPtr l)
	{
		int result;
		try
		{
			PlayableBinding playableBinding;
			LuaObject.checkValueType<PlayableBinding>(l, 1, out playableBinding);
			Type sourceBindingType;
			LuaObject.checkType(l, 2, out sourceBindingType);
			playableBinding.sourceBindingType = sourceBindingType;
			LuaObject.setBack(l, playableBinding);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602380B RID: 145419 RVA: 0x00C654A0 File Offset: 0x00C636A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableBinding");
		string name = "None";
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.get_None);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache0, null, false);
		string name2 = "DefaultDuration";
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.get_DefaultDuration);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache1, null, false);
		string name3 = "streamName";
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.get_streamName);
		}
		LuaCSFunction get = Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache2;
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.set_streamName);
		}
		LuaObject.addMember(l, name3, get, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache3, true);
		string name4 = "streamType";
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache4 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache4 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.get_streamType);
		}
		LuaCSFunction get2 = Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache4;
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache5 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache5 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.set_streamType);
		}
		LuaObject.addMember(l, name4, get2, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache5, true);
		string name5 = "sourceObject";
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache6 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache6 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.get_sourceObject);
		}
		LuaCSFunction get3 = Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache6;
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache7 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache7 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.set_sourceObject);
		}
		LuaObject.addMember(l, name5, get3, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache7, true);
		string name6 = "sourceBindingType";
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache8 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache8 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.get_sourceBindingType);
		}
		LuaCSFunction get4 = Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache8;
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache9 == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache9 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.set_sourceBindingType);
		}
		LuaObject.addMember(l, name6, get4, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cache9, true);
		if (Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cacheA == null)
		{
			Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cacheA = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableBinding.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_PlayableBinding.<>f__mg$cacheA, typeof(PlayableBinding), typeof(ValueType));
	}

	// Token: 0x040195C8 RID: 103880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195C9 RID: 103881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195CA RID: 103882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195CB RID: 103883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040195CC RID: 103884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040195CD RID: 103885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040195CE RID: 103886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040195CF RID: 103887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040195D0 RID: 103888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040195D1 RID: 103889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040195D2 RID: 103890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
