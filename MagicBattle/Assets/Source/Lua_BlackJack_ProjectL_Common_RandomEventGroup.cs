using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001264 RID: 4708
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RandomEventGroup : LuaObject
{
	// Token: 0x060188C6 RID: 100550 RVA: 0x006E8CC8 File Offset: 0x006E6EC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup o = new RandomEventGroup();
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

	// Token: 0x060188C7 RID: 100551 RVA: 0x006E8D10 File Offset: 0x006E6F10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGenerateRandomEvent(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			bool b = randomEventGroup.CanGenerateRandomEvent();
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

	// Token: 0x060188C8 RID: 100552 RVA: 0x006E8D64 File Offset: 0x006E6F64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Index(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEventGroup.Index);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188C9 RID: 100553 RVA: 0x006E8DB8 File Offset: 0x006E6FB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Index(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			randomEventGroup.Index = index;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188CA RID: 100554 RVA: 0x006E8E10 File Offset: 0x006E7010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Nums(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEventGroup.Nums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188CB RID: 100555 RVA: 0x006E8E64 File Offset: 0x006E7064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Nums(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			randomEventGroup.Nums = nums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188CC RID: 100556 RVA: 0x006E8EBC File Offset: 0x006E70BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MaxNums(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, randomEventGroup.MaxNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188CD RID: 100557 RVA: 0x006E8F10 File Offset: 0x006E7110
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MaxNums(IntPtr l)
	{
		int result;
		try
		{
			RandomEventGroup randomEventGroup = (RandomEventGroup)LuaObject.checkSelf(l);
			int maxNums;
			LuaObject.checkType(l, 2, out maxNums);
			randomEventGroup.MaxNums = maxNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060188CE RID: 100558 RVA: 0x006E8F68 File Offset: 0x006E7168
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RandomEventGroup");
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.CanGenerateRandomEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache0);
		string name = "Index";
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.get_Index);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.set_Index);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache2, true);
		string name2 = "Nums";
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.get_Nums);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.set_Nums);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache4, true);
		string name3 = "MaxNums";
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.get_MaxNums);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.set_MaxNums);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RandomEventGroup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RandomEventGroup.<>f__mg$cache7, typeof(RandomEventGroup));
	}

	// Token: 0x0400EDE0 RID: 60896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EDE1 RID: 60897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EDE2 RID: 60898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EDE3 RID: 60899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EDE4 RID: 60900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EDE5 RID: 60901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EDE6 RID: 60902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EDE7 RID: 60903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
