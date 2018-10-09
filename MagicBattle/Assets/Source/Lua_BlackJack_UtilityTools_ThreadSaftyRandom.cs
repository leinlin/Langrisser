using System;
using System.Runtime.CompilerServices;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020015FA RID: 5626
[Preserve]
public class Lua_BlackJack_UtilityTools_ThreadSaftyRandom : LuaObject
{
	// Token: 0x060227FD RID: 141309 RVA: 0x00BD4668 File Offset: 0x00BD2868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				ThreadSaftyRandom o = new ThreadSaftyRandom();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				int seed;
				LuaObject.checkType(l, 2, out seed);
				ThreadSaftyRandom o = new ThreadSaftyRandom(seed);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227FE RID: 141310 RVA: 0x00BD4700 File Offset: 0x00BD2900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Next(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				ThreadSaftyRandom threadSaftyRandom = (ThreadSaftyRandom)LuaObject.checkSelf(l);
				int i = threadSaftyRandom.Next();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 2)
			{
				ThreadSaftyRandom threadSaftyRandom2 = (ThreadSaftyRandom)LuaObject.checkSelf(l);
				int maxValue;
				LuaObject.checkType(l, 2, out maxValue);
				int i2 = threadSaftyRandom2.Next(maxValue);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
				result = 2;
			}
			else if (num == 3)
			{
				ThreadSaftyRandom threadSaftyRandom3 = (ThreadSaftyRandom)LuaObject.checkSelf(l);
				int minValue;
				LuaObject.checkType(l, 2, out minValue);
				int maxValue2;
				LuaObject.checkType(l, 3, out maxValue2);
				int i3 = threadSaftyRandom3.Next(minValue, maxValue2);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i3);
				result = 2;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Next to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060227FF RID: 141311 RVA: 0x00BD4808 File Offset: 0x00BD2A08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int NextDouble(IntPtr l)
	{
		int result;
		try
		{
			ThreadSaftyRandom threadSaftyRandom = (ThreadSaftyRandom)LuaObject.checkSelf(l);
			double d = threadSaftyRandom.NextDouble();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, d);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022800 RID: 141312 RVA: 0x00BD485C File Offset: 0x00BD2A5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.UtilityTools.ThreadSaftyRandom");
		if (Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_UtilityTools_ThreadSaftyRandom.Next);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache0);
		if (Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_UtilityTools_ThreadSaftyRandom.NextDouble);
		}
		LuaObject.addMember(l, Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache1);
		if (Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_UtilityTools_ThreadSaftyRandom.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_UtilityTools_ThreadSaftyRandom.<>f__mg$cache2, typeof(ThreadSaftyRandom), typeof(Random));
	}

	// Token: 0x040185EB RID: 99819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040185EC RID: 99820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040185ED RID: 99821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;
}
