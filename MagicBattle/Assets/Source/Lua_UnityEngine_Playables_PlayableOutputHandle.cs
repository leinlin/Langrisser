using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine.Playables;
using UnityEngine.Scripting;

// Token: 0x02001751 RID: 5969
[Preserve]
public class Lua_UnityEngine_Playables_PlayableOutputHandle : LuaObject
{
	// Token: 0x06023831 RID: 145457 RVA: 0x00C66430 File Offset: 0x00C64630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			PlayableOutputHandle playableOutputHandle = default(PlayableOutputHandle);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playableOutputHandle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023832 RID: 145458 RVA: 0x00C66480 File Offset: 0x00C64680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Equality(IntPtr l)
	{
		int result;
		try
		{
			PlayableOutputHandle lhs;
			LuaObject.checkValueType<PlayableOutputHandle>(l, 1, out lhs);
			PlayableOutputHandle rhs;
			LuaObject.checkValueType<PlayableOutputHandle>(l, 2, out rhs);
			bool b = lhs == rhs;
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

	// Token: 0x06023833 RID: 145459 RVA: 0x00C664E0 File Offset: 0x00C646E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int op_Inequality(IntPtr l)
	{
		int result;
		try
		{
			PlayableOutputHandle lhs;
			LuaObject.checkValueType<PlayableOutputHandle>(l, 1, out lhs);
			PlayableOutputHandle rhs;
			LuaObject.checkValueType<PlayableOutputHandle>(l, 2, out rhs);
			bool b = lhs != rhs;
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

	// Token: 0x06023834 RID: 145460 RVA: 0x00C66540 File Offset: 0x00C64740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Null(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, PlayableOutputHandle.Null);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023835 RID: 145461 RVA: 0x00C6658C File Offset: 0x00C6478C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.Playables.PlayableOutputHandle");
		if (Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutputHandle.op_Equality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache0);
		if (Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutputHandle.op_Inequality);
		}
		LuaObject.addMember(l, Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache1);
		string name = "Null";
		if (Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutputHandle.get_Null);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache2, null, false);
		if (Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_Playables_PlayableOutputHandle.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_UnityEngine_Playables_PlayableOutputHandle.<>f__mg$cache3, typeof(PlayableOutputHandle), typeof(ValueType));
	}

	// Token: 0x040195ED RID: 103917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040195EE RID: 103918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040195EF RID: 103919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040195F0 RID: 103920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
