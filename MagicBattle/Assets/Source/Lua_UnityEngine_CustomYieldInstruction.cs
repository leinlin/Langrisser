using System;
using System.Runtime.CompilerServices;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;

// Token: 0x02001685 RID: 5765
[Preserve]
public class Lua_UnityEngine_CustomYieldInstruction : LuaObject
{
	// Token: 0x06023042 RID: 143426 RVA: 0x00C1FDC0 File Offset: 0x00C1DFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int MoveNext(IntPtr l)
	{
		int result;
		try
		{
			CustomYieldInstruction customYieldInstruction = (CustomYieldInstruction)LuaObject.checkSelf(l);
			bool b = customYieldInstruction.MoveNext();
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

	// Token: 0x06023043 RID: 143427 RVA: 0x00C1FE14 File Offset: 0x00C1E014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Reset(IntPtr l)
	{
		int result;
		try
		{
			CustomYieldInstruction customYieldInstruction = (CustomYieldInstruction)LuaObject.checkSelf(l);
			customYieldInstruction.Reset();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023044 RID: 143428 RVA: 0x00C1FE60 File Offset: 0x00C1E060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_keepWaiting(IntPtr l)
	{
		int result;
		try
		{
			CustomYieldInstruction customYieldInstruction = (CustomYieldInstruction)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customYieldInstruction.keepWaiting);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023045 RID: 143429 RVA: 0x00C1FEB4 File Offset: 0x00C1E0B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Current(IntPtr l)
	{
		int result;
		try
		{
			CustomYieldInstruction customYieldInstruction = (CustomYieldInstruction)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, customYieldInstruction.Current);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06023046 RID: 143430 RVA: 0x00C1FF08 File Offset: 0x00C1E108
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "UnityEngine.CustomYieldInstruction");
		if (Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache0 == null)
		{
			Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache0 = new LuaCSFunction(Lua_UnityEngine_CustomYieldInstruction.MoveNext);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache0);
		if (Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache1 == null)
		{
			Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache1 = new LuaCSFunction(Lua_UnityEngine_CustomYieldInstruction.Reset);
		}
		LuaObject.addMember(l, Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache1);
		string name = "keepWaiting";
		if (Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache2 == null)
		{
			Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache2 = new LuaCSFunction(Lua_UnityEngine_CustomYieldInstruction.get_keepWaiting);
		}
		LuaObject.addMember(l, name, Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache2, null, true);
		string name2 = "Current";
		if (Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache3 == null)
		{
			Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache3 = new LuaCSFunction(Lua_UnityEngine_CustomYieldInstruction.get_Current);
		}
		LuaObject.addMember(l, name2, Lua_UnityEngine_CustomYieldInstruction.<>f__mg$cache3, null, true);
		LuaObject.createTypeMetatable(l, null, typeof(CustomYieldInstruction));
	}

	// Token: 0x04018F96 RID: 102294
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04018F97 RID: 102295
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04018F98 RID: 102296
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04018F99 RID: 102297
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;
}
