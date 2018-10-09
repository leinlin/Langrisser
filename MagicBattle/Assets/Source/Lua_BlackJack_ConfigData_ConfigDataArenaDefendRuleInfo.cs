using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001137 RID: 4407
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo : LuaObject
{
	// Token: 0x060164A1 RID: 91297 RVA: 0x005DC99C File Offset: 0x005DAB9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo o = new ConfigDataArenaDefendRuleInfo();
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

	// Token: 0x060164A2 RID: 91298 RVA: 0x005DC9E4 File Offset: 0x005DABE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.m_battleWinConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A3 RID: 91299 RVA: 0x005DCA38 File Offset: 0x005DAC38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleWinConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleWinConditionInfo[] battleWinConditionInfos;
			LuaObject.checkArray<ConfigDataBattleWinConditionInfo>(l, 2, out battleWinConditionInfos);
			configDataArenaDefendRuleInfo.m_battleWinConditionInfos = battleWinConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A4 RID: 91300 RVA: 0x005DCA90 File Offset: 0x005DAC90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.m_battleLoseConditionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A5 RID: 91301 RVA: 0x005DCAE4 File Offset: 0x005DACE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleLoseConditionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			ConfigDataBattleLoseConditionInfo[] battleLoseConditionInfos;
			LuaObject.checkArray<ConfigDataBattleLoseConditionInfo>(l, 2, out battleLoseConditionInfos);
			configDataArenaDefendRuleInfo.m_battleLoseConditionInfos = battleLoseConditionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A6 RID: 91302 RVA: 0x005DCB3C File Offset: 0x005DAD3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A7 RID: 91303 RVA: 0x005DCB90 File Offset: 0x005DAD90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataArenaDefendRuleInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A8 RID: 91304 RVA: 0x005DCBE8 File Offset: 0x005DADE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164A9 RID: 91305 RVA: 0x005DCC3C File Offset: 0x005DAE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataArenaDefendRuleInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164AA RID: 91306 RVA: 0x005DCC94 File Offset: 0x005DAE94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164AB RID: 91307 RVA: 0x005DCCE8 File Offset: 0x005DAEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataArenaDefendRuleInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164AC RID: 91308 RVA: 0x005DCD40 File Offset: 0x005DAF40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DefendWinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.DefendWinDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164AD RID: 91309 RVA: 0x005DCD94 File Offset: 0x005DAF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendWinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string defendWinDesc;
			LuaObject.checkType(l, 2, out defendWinDesc);
			configDataArenaDefendRuleInfo.DefendWinDesc = defendWinDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164AE RID: 91310 RVA: 0x005DCDEC File Offset: 0x005DAFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendWinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.DefendWinDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164AF RID: 91311 RVA: 0x005DCE40 File Offset: 0x005DB040
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DefendWinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string defendWinDescStrKey;
			LuaObject.checkType(l, 2, out defendWinDescStrKey);
			configDataArenaDefendRuleInfo.DefendWinDescStrKey = defendWinDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B0 RID: 91312 RVA: 0x005DCE98 File Offset: 0x005DB098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendLoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.DefendLoseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B1 RID: 91313 RVA: 0x005DCEEC File Offset: 0x005DB0EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendLoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string defendLoseDesc;
			LuaObject.checkType(l, 2, out defendLoseDesc);
			configDataArenaDefendRuleInfo.DefendLoseDesc = defendLoseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B2 RID: 91314 RVA: 0x005DCF44 File Offset: 0x005DB144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DefendLoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.DefendLoseDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B3 RID: 91315 RVA: 0x005DCF98 File Offset: 0x005DB198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DefendLoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string defendLoseDescStrKey;
			LuaObject.checkType(l, 2, out defendLoseDescStrKey);
			configDataArenaDefendRuleInfo.DefendLoseDescStrKey = defendLoseDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B4 RID: 91316 RVA: 0x005DCFF0 File Offset: 0x005DB1F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.WinDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B5 RID: 91317 RVA: 0x005DD044 File Offset: 0x005DB244
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WinDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string winDesc;
			LuaObject.checkType(l, 2, out winDesc);
			configDataArenaDefendRuleInfo.WinDesc = winDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B6 RID: 91318 RVA: 0x005DD09C File Offset: 0x005DB29C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.WinDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B7 RID: 91319 RVA: 0x005DD0F0 File Offset: 0x005DB2F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WinDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string winDescStrKey;
			LuaObject.checkType(l, 2, out winDescStrKey);
			configDataArenaDefendRuleInfo.WinDescStrKey = winDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B8 RID: 91320 RVA: 0x005DD148 File Offset: 0x005DB348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.LoseDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164B9 RID: 91321 RVA: 0x005DD19C File Offset: 0x005DB39C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LoseDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string loseDesc;
			LuaObject.checkType(l, 2, out loseDesc);
			configDataArenaDefendRuleInfo.LoseDesc = loseDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164BA RID: 91322 RVA: 0x005DD1F4 File Offset: 0x005DB3F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.LoseDescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164BB RID: 91323 RVA: 0x005DD248 File Offset: 0x005DB448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LoseDescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string loseDescStrKey;
			LuaObject.checkType(l, 2, out loseDescStrKey);
			configDataArenaDefendRuleInfo.LoseDescStrKey = loseDescStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164BC RID: 91324 RVA: 0x005DD2A0 File Offset: 0x005DB4A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.TurnMax);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164BD RID: 91325 RVA: 0x005DD2F4 File Offset: 0x005DB4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TurnMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			int turnMax;
			LuaObject.checkType(l, 2, out turnMax);
			configDataArenaDefendRuleInfo.TurnMax = turnMax;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164BE RID: 91326 RVA: 0x005DD34C File Offset: 0x005DB54C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_WinConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.WinConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164BF RID: 91327 RVA: 0x005DD3A0 File Offset: 0x005DB5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoseConditions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.LoseConditions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C0 RID: 91328 RVA: 0x005DD3F4 File Offset: 0x005DB5F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataArenaDefendRuleInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C1 RID: 91329 RVA: 0x005DD448 File Offset: 0x005DB648
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataArenaDefendRuleInfo configDataArenaDefendRuleInfo = (ConfigDataArenaDefendRuleInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataArenaDefendRuleInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164C2 RID: 91330 RVA: 0x005DD4A0 File Offset: 0x005DB6A0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataArenaDefendRuleInfo");
		string name = "m_battleWinConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_m_battleWinConditionInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_m_battleWinConditionInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1, true);
		string name2 = "m_battleLoseConditionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_m_battleLoseConditionInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_m_battleLoseConditionInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache7, true);
		string name5 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_NameStrKey);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache9, true);
		string name6 = "DefendWinDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_DefendWinDesc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_DefendWinDesc);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheB, true);
		string name7 = "DefendWinDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_DefendWinDescStrKey);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_DefendWinDescStrKey);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheD, true);
		string name8 = "DefendLoseDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_DefendLoseDesc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_DefendLoseDesc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cacheF, true);
		string name9 = "DefendLoseDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_DefendLoseDescStrKey);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_DefendLoseDescStrKey);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache11, true);
		string name10 = "WinDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_WinDesc);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_WinDesc);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache13, true);
		string name11 = "WinDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_WinDescStrKey);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_WinDescStrKey);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache15, true);
		string name12 = "LoseDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_LoseDesc);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_LoseDesc);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache17, true);
		string name13 = "LoseDescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_LoseDescStrKey);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_LoseDescStrKey);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache19, true);
		string name14 = "TurnMax";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_TurnMax);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_TurnMax);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1B, true);
		string name15 = "WinConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_WinConditions_ID);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1C, null, true);
		string name16 = "LoseConditions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_LoseConditions_ID);
		}
		LuaObject.addMember(l, name16, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1D, null, true);
		string name17 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.get_Icon);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.set_Icon);
		}
		LuaObject.addMember(l, name17, get15, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache1F, true);
		if (Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataArenaDefendRuleInfo.<>f__mg$cache20, typeof(ConfigDataArenaDefendRuleInfo));
	}

	// Token: 0x0400CC15 RID: 52245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CC16 RID: 52246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CC17 RID: 52247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CC18 RID: 52248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CC19 RID: 52249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CC1A RID: 52250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CC1B RID: 52251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CC1C RID: 52252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CC1D RID: 52253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CC1E RID: 52254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CC1F RID: 52255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CC20 RID: 52256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CC21 RID: 52257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CC22 RID: 52258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CC23 RID: 52259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CC24 RID: 52260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CC25 RID: 52261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CC26 RID: 52262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CC27 RID: 52263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CC28 RID: 52264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CC29 RID: 52265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CC2A RID: 52266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CC2B RID: 52267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CC2C RID: 52268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CC2D RID: 52269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CC2E RID: 52270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CC2F RID: 52271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CC30 RID: 52272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CC31 RID: 52273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CC32 RID: 52274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CC33 RID: 52275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CC34 RID: 52276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CC35 RID: 52277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;
}
