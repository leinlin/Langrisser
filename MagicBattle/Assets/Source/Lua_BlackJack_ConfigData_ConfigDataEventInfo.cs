using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200114D RID: 4429
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataEventInfo : LuaObject
{
	// Token: 0x060167D6 RID: 92118 RVA: 0x005F3E28 File Offset: 0x005F2028
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo o = new ConfigDataEventInfo();
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

	// Token: 0x060167D7 RID: 92119 RVA: 0x005F3E70 File Offset: 0x005F2070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D8 RID: 92120 RVA: 0x005F3EC4 File Offset: 0x005F20C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataEventInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167D9 RID: 92121 RVA: 0x005F3F1C File Offset: 0x005F211C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.m_dialogInfoBefore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167DA RID: 92122 RVA: 0x005F3F70 File Offset: 0x005F2170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfoBefore(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoBefore;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoBefore);
			configDataEventInfo.m_dialogInfoBefore = dialogInfoBefore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167DB RID: 92123 RVA: 0x005F3FC8 File Offset: 0x005F21C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.m_dialogInfoAfter);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167DC RID: 92124 RVA: 0x005F401C File Offset: 0x005F221C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dialogInfoAfter(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			ConfigDataDialogInfo dialogInfoAfter;
			LuaObject.checkType<ConfigDataDialogInfo>(l, 2, out dialogInfoAfter);
			configDataEventInfo.m_dialogInfoAfter = dialogInfoAfter;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167DD RID: 92125 RVA: 0x005F4074 File Offset: 0x005F2274
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167DE RID: 92126 RVA: 0x005F40C8 File Offset: 0x005F22C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataEventInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167DF RID: 92127 RVA: 0x005F4120 File Offset: 0x005F2320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E0 RID: 92128 RVA: 0x005F4174 File Offset: 0x005F2374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataEventInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E1 RID: 92129 RVA: 0x005F41CC File Offset: 0x005F23CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E2 RID: 92130 RVA: 0x005F4220 File Offset: 0x005F2420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataEventInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E3 RID: 92131 RVA: 0x005F4278 File Offset: 0x005F2478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E4 RID: 92132 RVA: 0x005F42CC File Offset: 0x005F24CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataEventInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E5 RID: 92133 RVA: 0x005F4324 File Offset: 0x005F2524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E6 RID: 92134 RVA: 0x005F4378 File Offset: 0x005F2578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataEventInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E7 RID: 92135 RVA: 0x005F43D0 File Offset: 0x005F25D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FuncType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataEventInfo.FuncType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E8 RID: 92136 RVA: 0x005F4424 File Offset: 0x005F2624
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FuncType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			EventFuncType funcType;
			LuaObject.checkEnum<EventFuncType>(l, 2, out funcType);
			configDataEventInfo.FuncType = funcType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167E9 RID: 92137 RVA: 0x005F447C File Offset: 0x005F267C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167EA RID: 92138 RVA: 0x005F44D0 File Offset: 0x005F26D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataEventInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167EB RID: 92139 RVA: 0x005F4528 File Offset: 0x005F2728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167EC RID: 92140 RVA: 0x005F457C File Offset: 0x005F277C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataEventInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167ED RID: 92141 RVA: 0x005F45D4 File Offset: 0x005F27D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DisappearCondition(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.DisappearCondition);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167EE RID: 92142 RVA: 0x005F4628 File Offset: 0x005F2828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167EF RID: 92143 RVA: 0x005F467C File Offset: 0x005F287C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataEventInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F0 RID: 92144 RVA: 0x005F46D4 File Offset: 0x005F28D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F1 RID: 92145 RVA: 0x005F4728 File Offset: 0x005F2928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataEventInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F2 RID: 92146 RVA: 0x005F4780 File Offset: 0x005F2980
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.DialogBefore_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F3 RID: 92147 RVA: 0x005F47D4 File Offset: 0x005F29D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogBefore_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int dialogBefore_ID;
			LuaObject.checkType(l, 2, out dialogBefore_ID);
			configDataEventInfo.DialogBefore_ID = dialogBefore_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F4 RID: 92148 RVA: 0x005F482C File Offset: 0x005F2A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.DialogAfter_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F5 RID: 92149 RVA: 0x005F4880 File Offset: 0x005F2A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DialogAfter_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int dialogAfter_ID;
			LuaObject.checkType(l, 2, out dialogAfter_ID);
			configDataEventInfo.DialogAfter_ID = dialogAfter_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F6 RID: 92150 RVA: 0x005F48D8 File Offset: 0x005F2AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.PlayerExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F7 RID: 92151 RVA: 0x005F492C File Offset: 0x005F2B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int playerExpReward;
			LuaObject.checkType(l, 2, out playerExpReward);
			configDataEventInfo.PlayerExpReward = playerExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F8 RID: 92152 RVA: 0x005F4984 File Offset: 0x005F2B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.HeroExpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167F9 RID: 92153 RVA: 0x005F49D8 File Offset: 0x005F2BD8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int heroExpReward;
			LuaObject.checkType(l, 2, out heroExpReward);
			configDataEventInfo.HeroExpReward = heroExpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167FA RID: 92154 RVA: 0x005F4A30 File Offset: 0x005F2C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.GoldReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167FB RID: 92155 RVA: 0x005F4A84 File Offset: 0x005F2C84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int goldReward;
			LuaObject.checkType(l, 2, out goldReward);
			configDataEventInfo.GoldReward = goldReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167FC RID: 92156 RVA: 0x005F4ADC File Offset: 0x005F2CDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Reward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167FD RID: 92157 RVA: 0x005F4B30 File Offset: 0x005F2D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Drop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167FE RID: 92158 RVA: 0x005F4B84 File Offset: 0x005F2D84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Drop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int drop_ID;
			LuaObject.checkType(l, 2, out drop_ID);
			configDataEventInfo.Drop_ID = drop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060167FF RID: 92159 RVA: 0x005F4BDC File Offset: 0x005F2DDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StyleType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataEventInfo.StyleType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016800 RID: 92160 RVA: 0x005F4C30 File Offset: 0x005F2E30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StyleType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			WaypointStyleType styleType;
			LuaObject.checkEnum<WaypointStyleType>(l, 2, out styleType);
			configDataEventInfo.StyleType = styleType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016801 RID: 92161 RVA: 0x005F4C88 File Offset: 0x005F2E88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016802 RID: 92162 RVA: 0x005F4CDC File Offset: 0x005F2EDC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataEventInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016803 RID: 92163 RVA: 0x005F4D34 File Offset: 0x005F2F34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016804 RID: 92164 RVA: 0x005F4D88 File Offset: 0x005F2F88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int modelScale;
			LuaObject.checkType(l, 2, out modelScale);
			configDataEventInfo.ModelScale = modelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016805 RID: 92165 RVA: 0x005F4DE0 File Offset: 0x005F2FE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MapIcon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.MapIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016806 RID: 92166 RVA: 0x005F4E34 File Offset: 0x005F3034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MapIcon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string mapIcon;
			LuaObject.checkType(l, 2, out mapIcon);
			configDataEventInfo.MapIcon = mapIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016807 RID: 92167 RVA: 0x005F4E8C File Offset: 0x005F308C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MapIconY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.MapIconY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016808 RID: 92168 RVA: 0x005F4EE0 File Offset: 0x005F30E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MapIconY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int mapIconY;
			LuaObject.checkType(l, 2, out mapIconY);
			configDataEventInfo.MapIconY = mapIconY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016809 RID: 92169 RVA: 0x005F4F38 File Offset: 0x005F3138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601680A RID: 92170 RVA: 0x005F4F8C File Offset: 0x005F318C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataEventInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601680B RID: 92171 RVA: 0x005F4FE4 File Offset: 0x005F31E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsDanger(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.IsDanger);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601680C RID: 92172 RVA: 0x005F5038 File Offset: 0x005F3238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsDanger(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			bool isDanger;
			LuaObject.checkType(l, 2, out isDanger);
			configDataEventInfo.IsDanger = isDanger;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601680D RID: 92173 RVA: 0x005F5090 File Offset: 0x005F3290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.CharImage_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601680E RID: 92174 RVA: 0x005F50E4 File Offset: 0x005F32E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			int charImage_ID;
			LuaObject.checkType(l, 2, out charImage_ID);
			configDataEventInfo.CharImage_ID = charImage_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601680F RID: 92175 RVA: 0x005F513C File Offset: 0x005F333C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataEventInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016810 RID: 92176 RVA: 0x005F5190 File Offset: 0x005F3390
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataEventInfo configDataEventInfo = (ConfigDataEventInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataEventInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016811 RID: 92177 RVA: 0x005F51E8 File Offset: 0x005F33E8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataEventInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1, true);
		string name2 = "m_dialogInfoBefore";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_m_dialogInfoBefore);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_m_dialogInfoBefore);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache3, true);
		string name3 = "m_dialogInfoAfter";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_m_dialogInfoAfter);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_m_dialogInfoAfter);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache9, true);
		string name6 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_NameStrKey);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheB, true);
		string name7 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Desc);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Desc);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheD, true);
		string name8 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_DescStrKey);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cacheF, true);
		string name9 = "FuncType";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_FuncType);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_FuncType);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache11, true);
		string name10 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_EnergySuccess);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache13, true);
		string name11 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_EnergyFail);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache15, true);
		string name12 = "DisappearCondition";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_DisappearCondition);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache16, null, true);
		string name13 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_MonsterLevel);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache18, true);
		string name14 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Battle_ID);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1A, true);
		string name15 = "DialogBefore_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_DialogBefore_ID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_DialogBefore_ID);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1C, true);
		string name16 = "DialogAfter_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_DialogAfter_ID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_DialogAfter_ID);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1E, true);
		string name17 = "PlayerExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_PlayerExpReward);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_PlayerExpReward);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache20, true);
		string name18 = "HeroExpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_HeroExpReward);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_HeroExpReward);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache22, true);
		string name19 = "GoldReward";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_GoldReward);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_GoldReward);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache24, true);
		string name20 = "Reward";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Reward);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache25, null, true);
		string name21 = "Drop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Drop_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Drop_ID);
		}
		LuaObject.addMember(l, name21, get19, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache27, true);
		string name22 = "StyleType";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_StyleType);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_StyleType);
		}
		LuaObject.addMember(l, name22, get20, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache29, true);
		string name23 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Model);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Model);
		}
		LuaObject.addMember(l, name23, get21, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2B, true);
		string name24 = "ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_ModelScale);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_ModelScale);
		}
		LuaObject.addMember(l, name24, get22, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2D, true);
		string name25 = "MapIcon";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_MapIcon);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2E;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_MapIcon);
		}
		LuaObject.addMember(l, name25, get23, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache2F, true);
		string name26 = "MapIconY";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_MapIconY);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache30;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_MapIconY);
		}
		LuaObject.addMember(l, name26, get24, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache31, true);
		string name27 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Icon);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache32;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Icon);
		}
		LuaObject.addMember(l, name27, get25, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache33, true);
		string name28 = "IsDanger";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_IsDanger);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache34;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_IsDanger);
		}
		LuaObject.addMember(l, name28, get26, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache35, true);
		string name29 = "CharImage_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_CharImage_ID);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache36;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_CharImage_ID);
		}
		LuaObject.addMember(l, name29, get27, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache37, true);
		string name30 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.get_Strategy);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.set_Strategy);
		}
		LuaObject.addMember(l, name30, get28, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache39, true);
		if (Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataEventInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataEventInfo.<>f__mg$cache3A, typeof(ConfigDataEventInfo));
	}

	// Token: 0x0400CF1E RID: 53022
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CF1F RID: 53023
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CF20 RID: 53024
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CF21 RID: 53025
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CF22 RID: 53026
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CF23 RID: 53027
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CF24 RID: 53028
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CF25 RID: 53029
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CF26 RID: 53030
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CF27 RID: 53031
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CF28 RID: 53032
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CF29 RID: 53033
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CF2A RID: 53034
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CF2B RID: 53035
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CF2C RID: 53036
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CF2D RID: 53037
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CF2E RID: 53038
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CF2F RID: 53039
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CF30 RID: 53040
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CF31 RID: 53041
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CF32 RID: 53042
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CF33 RID: 53043
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CF34 RID: 53044
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CF35 RID: 53045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CF36 RID: 53046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CF37 RID: 53047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CF38 RID: 53048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CF39 RID: 53049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CF3A RID: 53050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CF3B RID: 53051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CF3C RID: 53052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CF3D RID: 53053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CF3E RID: 53054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CF3F RID: 53055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CF40 RID: 53056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CF41 RID: 53057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CF42 RID: 53058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CF43 RID: 53059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CF44 RID: 53060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CF45 RID: 53061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CF46 RID: 53062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CF47 RID: 53063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CF48 RID: 53064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CF49 RID: 53065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CF4A RID: 53066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CF4B RID: 53067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CF4C RID: 53068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400CF4D RID: 53069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400CF4E RID: 53070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400CF4F RID: 53071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400CF50 RID: 53072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400CF51 RID: 53073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400CF52 RID: 53074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400CF53 RID: 53075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400CF54 RID: 53076
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400CF55 RID: 53077
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400CF56 RID: 53078
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400CF57 RID: 53079
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400CF58 RID: 53080
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;
}
