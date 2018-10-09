using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011BB RID: 4539
[Preserve]
public class Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo : LuaObject
{
	// Token: 0x06017856 RID: 96342 RVA: 0x0066F184 File Offset: 0x0066D384
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefenseInfo o = new ArenaDefenseInfo();
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

	// Token: 0x06017857 RID: 96343 RVA: 0x0066F1CC File Offset: 0x0066D3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddDefenseNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefenseInfo arenaDefenseInfo = (ArenaDefenseInfo)LuaObject.checkSelf(l);
			bool successfulDefense;
			LuaObject.checkType(l, 2, out successfulDefense);
			arenaDefenseInfo.AddDefenseNums(successfulDefense);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017858 RID: 96344 RVA: 0x0066F224 File Offset: 0x0066D424
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SuccessfulDefenseNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefenseInfo arenaDefenseInfo = (ArenaDefenseInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefenseInfo.SuccessfulDefenseNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017859 RID: 96345 RVA: 0x0066F278 File Offset: 0x0066D478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SuccessfulDefenseNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefenseInfo arenaDefenseInfo = (ArenaDefenseInfo)LuaObject.checkSelf(l);
			int successfulDefenseNums;
			LuaObject.checkType(l, 2, out successfulDefenseNums);
			arenaDefenseInfo.SuccessfulDefenseNums = successfulDefenseNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601785A RID: 96346 RVA: 0x0066F2D0 File Offset: 0x0066D4D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TotalDefenseNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefenseInfo arenaDefenseInfo = (ArenaDefenseInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, arenaDefenseInfo.TotalDefenseNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601785B RID: 96347 RVA: 0x0066F324 File Offset: 0x0066D524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TotalDefenseNums(IntPtr l)
	{
		int result;
		try
		{
			ArenaDefenseInfo arenaDefenseInfo = (ArenaDefenseInfo)LuaObject.checkSelf(l);
			int totalDefenseNums;
			LuaObject.checkType(l, 2, out totalDefenseNums);
			arenaDefenseInfo.TotalDefenseNums = totalDefenseNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601785C RID: 96348 RVA: 0x0066F37C File Offset: 0x0066D57C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.ArenaDefenseInfo");
		if (Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.AddDefenseNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache0);
		string name = "SuccessfulDefenseNums";
		if (Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.get_SuccessfulDefenseNums);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.set_SuccessfulDefenseNums);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache2, true);
		string name2 = "TotalDefenseNums";
		if (Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.get_TotalDefenseNums);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.set_TotalDefenseNums);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache4, true);
		if (Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_ArenaDefenseInfo.<>f__mg$cache5, typeof(ArenaDefenseInfo));
	}

	// Token: 0x0400DEC2 RID: 57026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DEC3 RID: 57027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DEC4 RID: 57028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DEC5 RID: 57029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DEC6 RID: 57030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DEC7 RID: 57031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;
}
