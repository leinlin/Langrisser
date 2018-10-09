using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D3 RID: 4563
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup : LuaObject
{
	// Token: 0x06017ACE RID: 96974 RVA: 0x006816D4 File Offset: 0x0067F8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup o = new BattleRoomPlayerHeroSetup();
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

	// Token: 0x06017ACF RID: 96975 RVA: 0x0068171C File Offset: 0x0067F91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitTeamBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerCount;
			LuaObject.checkType(l, 2, out playerCount);
			int heroPosCount;
			LuaObject.checkType(l, 3, out heroPosCount);
			bool b = battleRoomPlayerHeroSetup.InitTeamBattle(playerCount, heroPosCount);
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

	// Token: 0x06017AD0 RID: 96976 RVA: 0x0068178C File Offset: 0x0067F98C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitPVPBattle(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int heroPosCount;
			LuaObject.checkType(l, 2, out heroPosCount);
			int heroPosCount2;
			LuaObject.checkType(l, 3, out heroPosCount2);
			bool b = battleRoomPlayerHeroSetup.InitPVPBattle(heroPosCount, heroPosCount2);
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

	// Token: 0x06017AD1 RID: 96977 RVA: 0x006817FC File Offset: 0x0067F9FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			battleRoomPlayerHeroSetup.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AD2 RID: 96978 RVA: 0x00681848 File Offset: 0x0067FA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCount(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int count = battleRoomPlayerHeroSetup.GetCount();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, count);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AD3 RID: 96979 RVA: 0x0068189C File Offset: 0x0067FA9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHero(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			int heroPos;
			LuaObject.checkType(l, 3, out heroPos);
			BattleHero hero;
			LuaObject.checkType<BattleHero>(l, 4, out hero);
			bool checkHeroDup;
			LuaObject.checkType(l, 5, out checkHeroDup);
			bool b = battleRoomPlayerHeroSetup.SetHero(playerIdx, heroPos, hero, checkHeroDup);
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

	// Token: 0x06017AD4 RID: 96980 RVA: 0x00681924 File Offset: 0x0067FB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SwapHeros(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			int heroPos;
			LuaObject.checkType(l, 3, out heroPos);
			int heroPos2;
			LuaObject.checkType(l, 4, out heroPos2);
			bool checkPos2HeroExist;
			LuaObject.checkType(l, 5, out checkPos2HeroExist);
			bool b = battleRoomPlayerHeroSetup.SwapHeros(playerIdx, heroPos, heroPos2, checkPos2HeroExist);
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

	// Token: 0x06017AD5 RID: 96981 RVA: 0x006819AC File Offset: 0x0067FBAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int MarkSetupHeroFlag(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			int heroPos;
			LuaObject.checkType(l, 3, out heroPos);
			SetupBattleHeroFlag flag;
			LuaObject.checkEnum<SetupBattleHeroFlag>(l, 4, out flag);
			bool b = battleRoomPlayerHeroSetup.MarkSetupHeroFlag(playerIdx, heroPos, flag);
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

	// Token: 0x06017AD6 RID: 96982 RVA: 0x00681A28 File Offset: 0x0067FC28
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetBattleHeroSetupInfo(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int heroPos;
			LuaObject.checkType(l, 2, out heroPos);
			BattleHeroSetupInfo battleHeroSetupInfo = battleRoomPlayerHeroSetup.GetBattleHeroSetupInfo(heroPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroSetupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AD7 RID: 96983 RVA: 0x00681A8C File Offset: 0x0067FC8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindHeroPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			int heroId;
			LuaObject.checkType(l, 3, out heroId);
			int i = battleRoomPlayerHeroSetup.FindHeroPosition(playerIdx, heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AD8 RID: 96984 RVA: 0x00681AFC File Offset: 0x0067FCFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroCountByPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			int heroCountByPlayerIndex = battleRoomPlayerHeroSetup.GetHeroCountByPlayerIndex(playerIdx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCountByPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AD9 RID: 96985 RVA: 0x00681B60 File Offset: 0x0067FD60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroIdsByPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			List<int> heroIdsByPlayerIndex = battleRoomPlayerHeroSetup.GetHeroIdsByPlayerIndex(playerIdx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroIdsByPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ADA RID: 96986 RVA: 0x00681BC4 File Offset: 0x0067FDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPositionCountByPlayerIndex(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIdx;
			LuaObject.checkType(l, 2, out playerIdx);
			int heroPositionCountByPlayerIndex = battleRoomPlayerHeroSetup.GetHeroPositionCountByPlayerIndex(playerIdx);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPositionCountByPlayerIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ADB RID: 96987 RVA: 0x00681C28 File Offset: 0x0067FE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetBattleHeroSetupInfos(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			List<BattleHeroSetupInfo> battleHeroSetupInfos = battleRoomPlayerHeroSetup.GetBattleHeroSetupInfos();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleHeroSetupInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ADC RID: 96988 RVA: 0x00681C7C File Offset: 0x0067FE7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PVPRoomPositionToTeamPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int heroPos;
			LuaObject.checkType(l, 3, out heroPos);
			int i = battleRoomPlayerHeroSetup.PVPRoomPositionToTeamPosition(playerIndex, heroPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ADD RID: 96989 RVA: 0x00681CEC File Offset: 0x0067FEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PVPTeamPositionToRoomPosition(IntPtr l)
	{
		int result;
		try
		{
			BattleRoomPlayerHeroSetup battleRoomPlayerHeroSetup = (BattleRoomPlayerHeroSetup)LuaObject.checkSelf(l);
			int playerIndex;
			LuaObject.checkType(l, 2, out playerIndex);
			int heroPos;
			LuaObject.checkType(l, 3, out heroPos);
			int i = battleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition(playerIndex, heroPos);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017ADE RID: 96990 RVA: 0x00681D5C File Offset: 0x0067FF5C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BattleRoomPlayerHeroSetup");
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.InitTeamBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.InitPVPBattle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.GetCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.SetHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.SwapHeros);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.MarkSetupHeroFlag);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.FindHeroPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.GetHeroCountByPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.GetHeroIdsByPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.GetHeroPositionCountByPlayerIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.GetBattleHeroSetupInfos);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.PVPRoomPositionToTeamPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.PVPTeamPositionToRoomPosition);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BattleRoomPlayerHeroSetup.<>f__mg$cacheF, typeof(BattleRoomPlayerHeroSetup));
	}

	// Token: 0x0400E10A RID: 57610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E10B RID: 57611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E10C RID: 57612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E10D RID: 57613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E10E RID: 57614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E10F RID: 57615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E110 RID: 57616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E111 RID: 57617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E112 RID: 57618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E113 RID: 57619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E114 RID: 57620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E115 RID: 57621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E116 RID: 57622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E117 RID: 57623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E118 RID: 57624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E119 RID: 57625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;
}
