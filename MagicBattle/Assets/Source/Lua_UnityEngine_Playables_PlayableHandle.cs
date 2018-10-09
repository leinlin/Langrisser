using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x0200174E RID: 5966
[Preserve]
public class Lua_UnityEngine_Playables_PlayableHandle : LuaObject
{
	// Token: 0x06023823 RID: 145443 RVA: 0x00C65FD4 File Offset: 0x00C641D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayableHandle playableHandle = default(PlayableHandle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableHandle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023824 RID: 145444 RVA: 0x00C66024 File Offset: 0x00C64224
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			PlayableHandle x;
			LuaObject.checkValueType<PlayableHandle>(l, 1, out x);
			PlayableHandle y;
			LuaObject.checkValueType<PlayableHandle>(l, 2, out y);
			bool b = x == y;
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

	// Token: 0x06023825 RID: 145445 RVA: 0x00C66084 File Offset: 0x00C64284
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			PlayableHandle x;
			LuaObject.checkValueType<PlayableHandle>(l, 1, out x);
			PlayableHandle y;
			LuaObject.checkValueType<PlayableHandle>(l, 2, out y);
			bool b = x != y;
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

	// Token: 0x06023826 RID: 145446 RVA: 0x00C660E4 File Offset: 0x00C642E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayableHandle.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023827 RID: 145447 RVA: 0x00C66130 File Offset: 0x00C64330
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableHandle");
		if (Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableHandle.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableHandle.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache1);
		string name = "Null";
		if (Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableHandle.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache2, null, false);
		if (Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableHandle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_PlayableHandle.<>f__mg$cache3, typeof(PlayableHandle), typeof(ValueType));
	}

	// Token: 0x040195E5 RID: 103909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195E6 RID: 103910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195E7 RID: 103911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195E8 RID: 103912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
