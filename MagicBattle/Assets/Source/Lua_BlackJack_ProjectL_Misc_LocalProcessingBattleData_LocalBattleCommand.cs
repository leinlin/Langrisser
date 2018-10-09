using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012AC RID: 4780
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand : LuaObject
{
	// Token: 0x06019120 RID: 102688 RVA: 0x00725534 File Offset: 0x00723734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand o = new LocalProcessingBattleData.LocalBattleCommand();
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

	// Token: 0x06019121 RID: 102689 RVA: 0x0072557C File Offset: 0x0072377C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			BattleCommand o = localBattleCommand.ToBattleCommand();
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

	// Token: 0x06019122 RID: 102690 RVA: 0x007255D0 File Offset: 0x007237D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromBattleCommand(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			BattleCommand cmd;
			LuaObject.checkType<BattleCommand>(l, 2, out cmd);
			localBattleCommand.FromBattleCommand(cmd);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019123 RID: 102691 RVA: 0x00725628 File Offset: 0x00723828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019124 RID: 102692 RVA: 0x0072567C File Offset: 0x0072387C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int type;
			LuaObject.checkType(l, 2, out type);
			localBattleCommand.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019125 RID: 102693 RVA: 0x007256D4 File Offset: 0x007238D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Step(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.Step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019126 RID: 102694 RVA: 0x00725728 File Offset: 0x00723928
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Step(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			localBattleCommand.Step = step;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019127 RID: 102695 RVA: 0x00725780 File Offset: 0x00723980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Actor(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.Actor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019128 RID: 102696 RVA: 0x007257D4 File Offset: 0x007239D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Actor(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int actor;
			LuaObject.checkType(l, 2, out actor);
			localBattleCommand.Actor = actor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019129 RID: 102697 RVA: 0x0072582C File Offset: 0x00723A2C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Skill(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.Skill);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601912A RID: 102698 RVA: 0x00725880 File Offset: 0x00723A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Skill(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int skill;
			LuaObject.checkType(l, 2, out skill);
			localBattleCommand.Skill = skill;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601912B RID: 102699 RVA: 0x007258D8 File Offset: 0x00723AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PX(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.PX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601912C RID: 102700 RVA: 0x0072592C File Offset: 0x00723B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PX(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int px;
			LuaObject.checkType(l, 2, out px);
			localBattleCommand.PX = px;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601912D RID: 102701 RVA: 0x00725984 File Offset: 0x00723B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PY(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.PY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601912E RID: 102702 RVA: 0x007259D8 File Offset: 0x00723BD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PY(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int py;
			LuaObject.checkType(l, 2, out py);
			localBattleCommand.PY = py;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601912F RID: 102703 RVA: 0x00725A30 File Offset: 0x00723C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_P2X(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.P2X);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019130 RID: 102704 RVA: 0x00725A84 File Offset: 0x00723C84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_P2X(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int p2X;
			LuaObject.checkType(l, 2, out p2X);
			localBattleCommand.P2X = p2X;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019131 RID: 102705 RVA: 0x00725ADC File Offset: 0x00723CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_P2Y(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localBattleCommand.P2Y);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019132 RID: 102706 RVA: 0x00725B30 File Offset: 0x00723D30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_P2Y(IntPtr l)
	{
		int result;
		try
		{
			LocalProcessingBattleData.LocalBattleCommand localBattleCommand = (LocalProcessingBattleData.LocalBattleCommand)LuaObject.checkSelf(l);
			int p2Y;
			LuaObject.checkType(l, 2, out p2Y);
			localBattleCommand.P2Y = p2Y;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019133 RID: 102707 RVA: 0x00725B88 File Offset: 0x00723D88
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalProcessingBattleData.LocalBattleCommand");
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.ToBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.FromBattleCommand);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache1);
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache3, true);
		string name2 = "Step";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_Step);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_Step);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache5, true);
		string name3 = "Actor";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_Actor);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_Actor);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache7, true);
		string name4 = "Skill";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_Skill);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_Skill);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache9, true);
		string name5 = "PX";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_PX);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_PX);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheB, true);
		string name6 = "PY";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_PY);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_PY);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheD, true);
		string name7 = "P2X";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_P2X);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_P2X);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cacheF, true);
		string name8 = "P2Y";
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.get_P2Y);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.set_P2Y);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache11, true);
		if (Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalProcessingBattleData_LocalBattleCommand.<>f__mg$cache12, typeof(LocalProcessingBattleData.LocalBattleCommand));
	}

	// Token: 0x0400F5AA RID: 62890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F5AB RID: 62891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F5AC RID: 62892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F5AD RID: 62893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F5AE RID: 62894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F5AF RID: 62895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F5B0 RID: 62896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F5B1 RID: 62897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F5B2 RID: 62898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F5B3 RID: 62899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F5B4 RID: 62900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F5B5 RID: 62901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F5B6 RID: 62902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F5B7 RID: 62903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F5B8 RID: 62904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F5B9 RID: 62905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F5BA RID: 62906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F5BB RID: 62907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F5BC RID: 62908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
