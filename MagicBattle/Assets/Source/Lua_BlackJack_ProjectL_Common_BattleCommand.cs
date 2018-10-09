using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C9 RID: 4553
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleCommand : LuaObject
{
	// Token: 0x06017986 RID: 96646 RVA: 0x00677FA0 File Offset: 0x006761A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand o = new BattleCommand();
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

	// Token: 0x06017987 RID: 96647 RVA: 0x00677FE8 File Offset: 0x006761E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBBattleCommandToBattleCommand_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattleCommand pbBattleCommand;
			LuaObject.checkType<ProBattleCommand>(l, 1, out pbBattleCommand);
			BattleCommand o = BattleCommand.PBBattleCommandToBattleCommand(pbBattleCommand);
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

	// Token: 0x06017988 RID: 96648 RVA: 0x0067803C File Offset: 0x0067623C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int BattleCommandToPBBattleCommand_s(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand;
			LuaObject.checkType<BattleCommand>(l, 1, out battleCommand);
			ProBattleCommand o = BattleCommand.BattleCommandToPBBattleCommand(battleCommand);
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

	// Token: 0x06017989 RID: 96649 RVA: 0x00678090 File Offset: 0x00676290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GridPositionToPBBattlePosition_s(IntPtr l)
	{
		int result;
		try
		{
			GridPosition gridPosition;
			LuaObject.checkValueType<GridPosition>(l, 1, out gridPosition);
			ProBattlePosition o = BattleCommand.GridPositionToPBBattlePosition(gridPosition);
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

	// Token: 0x0601798A RID: 96650 RVA: 0x006780E4 File Offset: 0x006762E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBBattlePositionToGridPosition_s(IntPtr l)
	{
		int result;
		try
		{
			ProBattlePosition pbBattlePosition;
			LuaObject.checkType<ProBattlePosition>(l, 1, out pbBattlePosition);
			GridPosition gridPosition = BattleCommand.PBBattlePositionToGridPosition(pbBattlePosition);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, gridPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601798B RID: 96651 RVA: 0x0067813C File Offset: 0x0067633C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Type(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)battleCommand.Type);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601798C RID: 96652 RVA: 0x00678190 File Offset: 0x00676390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Type(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			BattleCommandType type;
			LuaObject.checkEnum<BattleCommandType>(l, 2, out type);
			battleCommand.Type = type;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601798D RID: 96653 RVA: 0x006781E8 File Offset: 0x006763E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Step(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCommand.Step);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601798E RID: 96654 RVA: 0x0067823C File Offset: 0x0067643C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Step(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			int step;
			LuaObject.checkType(l, 2, out step);
			battleCommand.Step = step;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601798F RID: 96655 RVA: 0x00678294 File Offset: 0x00676494
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActorId(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCommand.ActorId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017990 RID: 96656 RVA: 0x006782E8 File Offset: 0x006764E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActorId(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			int actorId;
			LuaObject.checkType(l, 2, out actorId);
			battleCommand.ActorId = actorId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017991 RID: 96657 RVA: 0x00678340 File Offset: 0x00676540
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SkillIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCommand.SkillIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017992 RID: 96658 RVA: 0x00678394 File Offset: 0x00676594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SkillIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			int skillIndex;
			LuaObject.checkType(l, 2, out skillIndex);
			battleCommand.SkillIndex = skillIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017993 RID: 96659 RVA: 0x006783EC File Offset: 0x006765EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCommand.TargetPosition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017994 RID: 96660 RVA: 0x00678444 File Offset: 0x00676644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TargetPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			GridPosition targetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPosition);
			battleCommand.TargetPosition = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017995 RID: 96661 RVA: 0x0067849C File Offset: 0x0067669C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TargetPosition2(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleCommand.TargetPosition2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017996 RID: 96662 RVA: 0x006784F4 File Offset: 0x006766F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TargetPosition2(IntPtr l)
	{
		int result;
		try
		{
			BattleCommand battleCommand = (BattleCommand)LuaObject.checkSelf(l);
			GridPosition targetPosition;
			LuaObject.checkValueType<GridPosition>(l, 2, out targetPosition);
			battleCommand.TargetPosition2 = targetPosition;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017997 RID: 96663 RVA: 0x0067854C File Offset: 0x0067674C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleCommand");
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.PBBattleCommandToBattleCommand_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.BattleCommandToPBBattleCommand_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.GridPositionToPBBattlePosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.PBBattlePositionToGridPosition_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache3);
		string name = "Type";
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.get_Type);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.set_Type);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache5, true);
		string name2 = "Step";
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.get_Step);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.set_Step);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache7, true);
		string name3 = "ActorId";
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.get_ActorId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.set_ActorId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache9, true);
		string name4 = "SkillIndex";
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.get_SkillIndex);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.set_SkillIndex);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheB, true);
		string name5 = "TargetPosition";
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.get_TargetPosition);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.set_TargetPosition);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheD, true);
		string name6 = "TargetPosition2";
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.get_TargetPosition2);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.set_TargetPosition2);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleCommand.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleCommand.<>f__mg$cache10, typeof(BattleCommand));
	}

	// Token: 0x0400DFD6 RID: 57302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DFD7 RID: 57303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DFD8 RID: 57304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DFD9 RID: 57305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DFDA RID: 57306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DFDB RID: 57307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DFDC RID: 57308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DFDD RID: 57309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400DFDE RID: 57310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400DFDF RID: 57311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400DFE0 RID: 57312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400DFE1 RID: 57313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400DFE2 RID: 57314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400DFE3 RID: 57315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400DFE4 RID: 57316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400DFE5 RID: 57317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400DFE6 RID: 57318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
