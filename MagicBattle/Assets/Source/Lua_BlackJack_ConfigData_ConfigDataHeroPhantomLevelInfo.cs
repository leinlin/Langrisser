using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001158 RID: 4440
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo : LuaObject
{
	// Token: 0x06016994 RID: 92564 RVA: 0x006008CC File Offset: 0x005FEACC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo o = new ConfigDataHeroPhantomLevelInfo();
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

	// Token: 0x06016995 RID: 92565 RVA: 0x00600914 File Offset: 0x005FEB14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.m_achievements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016996 RID: 92566 RVA: 0x00600968 File Offset: 0x005FEB68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_achievements(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			configDataHeroPhantomLevelInfo.m_achievements = achievements;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016997 RID: 92567 RVA: 0x006009C0 File Offset: 0x005FEBC0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016998 RID: 92568 RVA: 0x00600A14 File Offset: 0x005FEC14
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataHeroPhantomLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016999 RID: 92569 RVA: 0x00600A6C File Offset: 0x005FEC6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601699A RID: 92570 RVA: 0x00600AC0 File Offset: 0x005FECC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo groupInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out groupInfo);
			configDataHeroPhantomLevelInfo.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601699B RID: 92571 RVA: 0x00600B18 File Offset: 0x005FED18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601699C RID: 92572 RVA: 0x00600B6C File Offset: 0x005FED6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroPhantomLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601699D RID: 92573 RVA: 0x00600BC4 File Offset: 0x005FEDC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601699E RID: 92574 RVA: 0x00600C18 File Offset: 0x005FEE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroPhantomLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601699F RID: 92575 RVA: 0x00600C70 File Offset: 0x005FEE70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.PreLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A0 RID: 92576 RVA: 0x00600CC4 File Offset: 0x005FEEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PreLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int preLevel;
			LuaObject.checkType(l, 2, out preLevel);
			configDataHeroPhantomLevelInfo.PreLevel = preLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A1 RID: 92577 RVA: 0x00600D1C File Offset: 0x005FEF1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A2 RID: 92578 RVA: 0x00600D70 File Offset: 0x005FEF70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataHeroPhantomLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A3 RID: 92579 RVA: 0x00600DC8 File Offset: 0x005FEFC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A4 RID: 92580 RVA: 0x00600E1C File Offset: 0x005FF01C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataHeroPhantomLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A5 RID: 92581 RVA: 0x00600E74 File Offset: 0x005FF074
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A6 RID: 92582 RVA: 0x00600EC8 File Offset: 0x005FF0C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataHeroPhantomLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A7 RID: 92583 RVA: 0x00600F20 File Offset: 0x005FF120
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A8 RID: 92584 RVA: 0x00600F74 File Offset: 0x005FF174
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataHeroPhantomLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169A9 RID: 92585 RVA: 0x00600FCC File Offset: 0x005FF1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169AA RID: 92586 RVA: 0x00601020 File Offset: 0x005FF220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataHeroPhantomLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169AB RID: 92587 RVA: 0x00601078 File Offset: 0x005FF278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169AC RID: 92588 RVA: 0x006010CC File Offset: 0x005FF2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataHeroPhantomLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169AD RID: 92589 RVA: 0x00601124 File Offset: 0x005FF324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169AE RID: 92590 RVA: 0x00601178 File Offset: 0x005FF378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataHeroPhantomLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169AF RID: 92591 RVA: 0x006011D0 File Offset: 0x005FF3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DropID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.DropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B0 RID: 92592 RVA: 0x00601224 File Offset: 0x005FF424
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DropID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int dropID;
			LuaObject.checkType(l, 2, out dropID);
			configDataHeroPhantomLevelInfo.DropID = dropID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B1 RID: 92593 RVA: 0x0060127C File Offset: 0x005FF47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FirstClearDropItems(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.FirstClearDropItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B2 RID: 92594 RVA: 0x006012D0 File Offset: 0x005FF4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.DisplayRewardCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B3 RID: 92595 RVA: 0x00601324 File Offset: 0x005FF524
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DisplayRewardCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int displayRewardCount;
			LuaObject.checkType(l, 2, out displayRewardCount);
			configDataHeroPhantomLevelInfo.DisplayRewardCount = displayRewardCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B4 RID: 92596 RVA: 0x0060137C File Offset: 0x005FF57C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement1ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Achievement1ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B5 RID: 92597 RVA: 0x006013D0 File Offset: 0x005FF5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievement1ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int achievement1ID;
			LuaObject.checkType(l, 2, out achievement1ID);
			configDataHeroPhantomLevelInfo.Achievement1ID = achievement1ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B6 RID: 92598 RVA: 0x00601428 File Offset: 0x005FF628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Achievement1BonusItem(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Achievement1BonusItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B7 RID: 92599 RVA: 0x0060147C File Offset: 0x005FF67C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement2ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Achievement2ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B8 RID: 92600 RVA: 0x006014D0 File Offset: 0x005FF6D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Achievement2ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int achievement2ID;
			LuaObject.checkType(l, 2, out achievement2ID);
			configDataHeroPhantomLevelInfo.Achievement2ID = achievement2ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169B9 RID: 92601 RVA: 0x00601528 File Offset: 0x005FF728
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement2BonusItem(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Achievement2BonusItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169BA RID: 92602 RVA: 0x0060157C File Offset: 0x005FF77C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement3ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Achievement3ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169BB RID: 92603 RVA: 0x006015D0 File Offset: 0x005FF7D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Achievement3ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			int achievement3ID;
			LuaObject.checkType(l, 2, out achievement3ID);
			configDataHeroPhantomLevelInfo.Achievement3ID = achievement3ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169BC RID: 92604 RVA: 0x00601628 File Offset: 0x005FF828
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Achievement3BonusItem(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Achievement3BonusItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169BD RID: 92605 RVA: 0x0060167C File Offset: 0x005FF87C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169BE RID: 92606 RVA: 0x006016D0 File Offset: 0x005FF8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataHeroPhantomLevelInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169BF RID: 92607 RVA: 0x00601728 File Offset: 0x005FF928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroPhantomLevelInfo.Strategy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C0 RID: 92608 RVA: 0x0060177C File Offset: 0x005FF97C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Strategy(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroPhantomLevelInfo configDataHeroPhantomLevelInfo = (ConfigDataHeroPhantomLevelInfo)LuaObject.checkSelf(l);
			string strategy;
			LuaObject.checkType(l, 2, out strategy);
			configDataHeroPhantomLevelInfo.Strategy = strategy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C1 RID: 92609 RVA: 0x006017D4 File Offset: 0x005FF9D4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroPhantomLevelInfo");
		string name = "m_achievements";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_m_achievements);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_m_achievements);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_groupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_m_groupInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_m_groupInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache9, true);
		string name6 = "PreLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_PreLevel);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_PreLevel);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheB, true);
		string name7 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheD, true);
		string name8 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cacheF, true);
		string name9 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache11, true);
		string name10 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache13, true);
		string name11 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache15, true);
		string name12 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_HeroExp);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache17, true);
		string name13 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Gold);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache19, true);
		string name14 = "DropID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_DropID);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_DropID);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1B, true);
		string name15 = "FirstClearDropItems";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_FirstClearDropItems);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1C, null, true);
		string name16 = "DisplayRewardCount";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_DisplayRewardCount);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_DisplayRewardCount);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1E, true);
		string name17 = "Achievement1ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Achievement1ID);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Achievement1ID);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache20, true);
		string name18 = "Achievement1BonusItem";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Achievement1BonusItem);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache21, null, true);
		string name19 = "Achievement2ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Achievement2ID);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Achievement2ID);
		}
		LuaObject.addMember(l, name19, get17, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache23, true);
		string name20 = "Achievement2BonusItem";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Achievement2BonusItem);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache24, null, true);
		string name21 = "Achievement3ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Achievement3ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Achievement3ID);
		}
		LuaObject.addMember(l, name21, get18, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache26, true);
		string name22 = "Achievement3BonusItem";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Achievement3BonusItem);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache27, null, true);
		string name23 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Icon);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Icon);
		}
		LuaObject.addMember(l, name23, get19, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache29, true);
		string name24 = "Strategy";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.get_Strategy);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.set_Strategy);
		}
		LuaObject.addMember(l, name24, get20, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2B, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroPhantomLevelInfo.<>f__mg$cache2C, typeof(ConfigDataHeroPhantomLevelInfo));
	}

	// Token: 0x0400D0C6 RID: 53446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D0C7 RID: 53447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D0C8 RID: 53448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D0C9 RID: 53449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D0CA RID: 53450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D0CB RID: 53451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D0CC RID: 53452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D0CD RID: 53453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D0CE RID: 53454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D0CF RID: 53455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D0D0 RID: 53456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D0D1 RID: 53457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D0D2 RID: 53458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D0D3 RID: 53459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D0D4 RID: 53460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D0D5 RID: 53461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D0D6 RID: 53462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D0D7 RID: 53463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D0D8 RID: 53464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D0D9 RID: 53465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D0DA RID: 53466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D0DB RID: 53467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D0DC RID: 53468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D0DD RID: 53469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D0DE RID: 53470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D0DF RID: 53471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D0E0 RID: 53472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D0E1 RID: 53473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D0E2 RID: 53474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D0E3 RID: 53475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D0E4 RID: 53476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D0E5 RID: 53477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D0E6 RID: 53478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D0E7 RID: 53479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D0E8 RID: 53480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D0E9 RID: 53481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D0EA RID: 53482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D0EB RID: 53483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D0EC RID: 53484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D0ED RID: 53485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D0EE RID: 53486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D0EF RID: 53487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D0F0 RID: 53488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D0F1 RID: 53489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D0F2 RID: 53490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
