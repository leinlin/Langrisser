using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001266 RID: 4710
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomNumber : LuaObject
{
	// Token: 0x060188D7 RID: 100567 RVA: 0x006E9328 File Offset: 0x006E7528
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomNumber o = new RandomNumber();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, o);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188D8 RID: 100568 RVA: 0x006E9370 File Offset: 0x006E7570
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetSeed(IntPtr l)
	{
		int result;
		try
		{
			RandomNumber randomNumber = (RandomNumber)LuaObject.checkSelf(l);
			int seed;
			LuaObject.checkType(l, 2, out seed);
			randomNumber.SetSeed(seed);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188D9 RID: 100569 RVA: 0x006E93C8 File Offset: 0x006E75C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetState(IntPtr l)
	{
		int result;
		try
		{
			RandomNumber randomNumber = (RandomNumber)LuaObject.checkSelf(l);
			RandomNumberState state;
			LuaObject.checkValueType<RandomNumberState>(l, 2, out state);
			randomNumber.SetState(state);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188DA RID: 100570 RVA: 0x006E9420 File Offset: 0x006E7620
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetState(IntPtr l)
	{
		int result;
		try
		{
			RandomNumber randomNumber = (RandomNumber)LuaObject.checkSelf(l);
			RandomNumberState state = randomNumber.GetState();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, state);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188DB RID: 100571 RVA: 0x006E947C File Offset: 0x006E767C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Next(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				RandomNumber randomNumber = (RandomNumber)LuaObject.checkSelf(l);
				int i = randomNumber.Next();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i);
				result = 2;
			}
			else if (num == 3)
			{
				RandomNumber randomNumber2 = (RandomNumber)LuaObject.checkSelf(l);
				int min;
				LuaObject.checkType(l, 2, out min);
				int max;
				LuaObject.checkType(l, 3, out max);
				int i2 = randomNumber2.Next(min, max);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, i2);
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

	// Token: 0x060188DC RID: 100572 RVA: 0x006E9544 File Offset: 0x006E7744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRandomNumberByAccumulateWeight(IntPtr l)
	{
		int result;
		try
		{
			RandomNumber randomNumber = (RandomNumber)LuaObject.checkSelf(l);
			Dictionary<int, int> weights;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out weights);
			int randomNumberByAccumulateWeight = randomNumber.GetRandomNumberByAccumulateWeight(weights);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomNumberByAccumulateWeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188DD RID: 100573 RVA: 0x006E95A8 File Offset: 0x006E77A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomNumber");
		if (Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomNumber.SetSeed);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomNumber.SetState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomNumber.GetState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomNumber.Next);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomNumber.GetRandomNumberByAccumulateWeight);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomNumber.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomNumber.<>f__mg$cache5, typeof(RandomNumber));
	}

	// Token: 0x0400EDED RID: 60909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDEE RID: 60910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EDEF RID: 60911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EDF0 RID: 60912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EDF1 RID: 60913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EDF2 RID: 60914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
