using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001169 RID: 4457
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo : LuaObject
{
	// Token: 0x06016CAD RID: 93357 RVA: 0x006172A4 File Offset: 0x006154A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo o = new ConfigDataScoreLevelInfo();
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

	// Token: 0x06016CAE RID: 93358 RVA: 0x006172EC File Offset: 0x006154EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockDaysDelayGroupSet(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.UnlockDaysDelayGroupSet);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CAF RID: 93359 RVA: 0x00617340 File Offset: 0x00615540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnlockDaysDelayGroupSet(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			HashSet<int> unlockDaysDelayGroupSet;
			LuaObject.checkType<HashSet<int>>(l, 2, out unlockDaysDelayGroupSet);
			configDataScoreLevelInfo.UnlockDaysDelayGroupSet = unlockDaysDelayGroupSet;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB0 RID: 93360 RVA: 0x00617398 File Offset: 0x00615598
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB1 RID: 93361 RVA: 0x006173EC File Offset: 0x006155EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataScoreLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB2 RID: 93362 RVA: 0x00617444 File Offset: 0x00615644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB3 RID: 93363 RVA: 0x00617498 File Offset: 0x00615698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataScoreLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB4 RID: 93364 RVA: 0x006174F0 File Offset: 0x006156F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB5 RID: 93365 RVA: 0x00617544 File Offset: 0x00615744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataScoreLevelInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB6 RID: 93366 RVA: 0x0061759C File Offset: 0x0061579C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevelMin(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.PlayerLevelMin);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB7 RID: 93367 RVA: 0x006175F0 File Offset: 0x006157F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerLevelMin(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int playerLevelMin;
			LuaObject.checkType(l, 2, out playerLevelMin);
			configDataScoreLevelInfo.PlayerLevelMin = playerLevelMin;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB8 RID: 93368 RVA: 0x00617648 File Offset: 0x00615848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnlockDaysDelayGroup(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.UnlockDaysDelayGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CB9 RID: 93369 RVA: 0x0061769C File Offset: 0x0061589C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CBA RID: 93370 RVA: 0x006176F0 File Offset: 0x006158F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataScoreLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CBB RID: 93371 RVA: 0x00617748 File Offset: 0x00615948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CBC RID: 93372 RVA: 0x0061779C File Offset: 0x0061599C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataScoreLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CBD RID: 93373 RVA: 0x006177F4 File Offset: 0x006159F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyTeam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.EnergyTeam);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CBE RID: 93374 RVA: 0x00617848 File Offset: 0x00615A48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyTeam(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int energyTeam;
			LuaObject.checkType(l, 2, out energyTeam);
			configDataScoreLevelInfo.EnergyTeam = energyTeam;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CBF RID: 93375 RVA: 0x006178A0 File Offset: 0x00615AA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC0 RID: 93376 RVA: 0x006178F4 File Offset: 0x00615AF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataScoreLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC1 RID: 93377 RVA: 0x0061794C File Offset: 0x00615B4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC2 RID: 93378 RVA: 0x006179A0 File Offset: 0x00615BA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataScoreLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC3 RID: 93379 RVA: 0x006179F8 File Offset: 0x00615BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC4 RID: 93380 RVA: 0x00617A4C File Offset: 0x00615C4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataScoreLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC5 RID: 93381 RVA: 0x00617AA4 File Offset: 0x00615CA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC6 RID: 93382 RVA: 0x00617AF8 File Offset: 0x00615CF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataScoreLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC7 RID: 93383 RVA: 0x00617B50 File Offset: 0x00615D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.GoldReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC8 RID: 93384 RVA: 0x00617BA4 File Offset: 0x00615DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GoldReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int goldReward;
			LuaObject.checkType(l, 2, out goldReward);
			configDataScoreLevelInfo.GoldReward = goldReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CC9 RID: 93385 RVA: 0x00617BFC File Offset: 0x00615DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScoreBase(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.ScoreBase);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CCA RID: 93386 RVA: 0x00617C50 File Offset: 0x00615E50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScoreBase(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int scoreBase;
			LuaObject.checkType(l, 2, out scoreBase);
			configDataScoreLevelInfo.ScoreBase = scoreBase;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CCB RID: 93387 RVA: 0x00617CA8 File Offset: 0x00615EA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DropID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.DropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CCC RID: 93388 RVA: 0x00617CFC File Offset: 0x00615EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DropID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int dropID;
			LuaObject.checkType(l, 2, out dropID);
			configDataScoreLevelInfo.DropID = dropID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CCD RID: 93389 RVA: 0x00617D54 File Offset: 0x00615F54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.ItemDropCountDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CCE RID: 93390 RVA: 0x00617DA8 File Offset: 0x00615FA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int itemDropCountDisplay;
			LuaObject.checkType(l, 2, out itemDropCountDisplay);
			configDataScoreLevelInfo.ItemDropCountDisplay = itemDropCountDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CCF RID: 93391 RVA: 0x00617E00 File Offset: 0x00616000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.TeamDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD0 RID: 93392 RVA: 0x00617E54 File Offset: 0x00616054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int teamDrop_ID;
			LuaObject.checkType(l, 2, out teamDrop_ID);
			configDataScoreLevelInfo.TeamDrop_ID = teamDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD1 RID: 93393 RVA: 0x00617EAC File Offset: 0x006160AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.DayBonusDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD2 RID: 93394 RVA: 0x00617F00 File Offset: 0x00616100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			int dayBonusDrop_ID;
			LuaObject.checkType(l, 2, out dayBonusDrop_ID);
			configDataScoreLevelInfo.DayBonusDrop_ID = dayBonusDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD3 RID: 93395 RVA: 0x00617F58 File Offset: 0x00616158
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.BattleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD4 RID: 93396 RVA: 0x00617FAC File Offset: 0x006161AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BattleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataScoreLevelInfo.BattleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD5 RID: 93397 RVA: 0x00618004 File Offset: 0x00616204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.RandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD6 RID: 93398 RVA: 0x00618058 File Offset: 0x00616258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo randomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out randomDropInfo);
			configDataScoreLevelInfo.RandomDropInfo = randomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD7 RID: 93399 RVA: 0x006180B0 File Offset: 0x006162B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.TeamRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD8 RID: 93400 RVA: 0x00618104 File Offset: 0x00616304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo teamRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out teamRandomDropInfo);
			configDataScoreLevelInfo.TeamRandomDropInfo = teamRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CD9 RID: 93401 RVA: 0x0061815C File Offset: 0x0061635C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DailyRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.DailyRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CDA RID: 93402 RVA: 0x006181B0 File Offset: 0x006163B0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DailyRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo dailyRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out dailyRandomDropInfo);
			configDataScoreLevelInfo.DailyRandomDropInfo = dailyRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CDB RID: 93403 RVA: 0x00618208 File Offset: 0x00616408
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataScoreLevelInfo.UnchartedScoreInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CDC RID: 93404 RVA: 0x0061825C File Offset: 0x0061645C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnchartedScoreInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataScoreLevelInfo configDataScoreLevelInfo = (ConfigDataScoreLevelInfo)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreInfo unchartedScoreInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreInfo>(l, 2, out unchartedScoreInfo);
			configDataScoreLevelInfo.UnchartedScoreInfo = unchartedScoreInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016CDD RID: 93405 RVA: 0x006182B4 File Offset: 0x006164B4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataScoreLevelInfo");
		string name = "UnlockDaysDelayGroupSet";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_UnlockDaysDelayGroupSet);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_UnlockDaysDelayGroupSet);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache5, true);
		string name4 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_TeamName);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_TeamName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache7, true);
		string name5 = "PlayerLevelMin";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_PlayerLevelMin);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_PlayerLevelMin);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache9, true);
		string name6 = "UnlockDaysDelayGroup";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_UnlockDaysDelayGroup);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheA, null, true);
		string name7 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheC, true);
		string name8 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheE, true);
		string name9 = "EnergyTeam";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_EnergyTeam);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cacheF;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_EnergyTeam);
		}
		LuaObject.addMember(l, name9, get8, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache10, true);
		string name10 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache12, true);
		string name11 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache14, true);
		string name12 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache16, true);
		string name13 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_HeroExp);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache17;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name13, get12, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache18, true);
		string name14 = "GoldReward";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_GoldReward);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_GoldReward);
		}
		LuaObject.addMember(l, name14, get13, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1A, true);
		string name15 = "ScoreBase";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_ScoreBase);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_ScoreBase);
		}
		LuaObject.addMember(l, name15, get14, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1C, true);
		string name16 = "DropID";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_DropID);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1D;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_DropID);
		}
		LuaObject.addMember(l, name16, get15, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1E, true);
		string name17 = "ItemDropCountDisplay";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_ItemDropCountDisplay);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache1F;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_ItemDropCountDisplay);
		}
		LuaObject.addMember(l, name17, get16, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache20, true);
		string name18 = "TeamDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_TeamDrop_ID);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_TeamDrop_ID);
		}
		LuaObject.addMember(l, name18, get17, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache22, true);
		string name19 = "DayBonusDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_DayBonusDrop_ID);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_DayBonusDrop_ID);
		}
		LuaObject.addMember(l, name19, get18, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache24, true);
		string name20 = "BattleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_BattleInfo);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_BattleInfo);
		}
		LuaObject.addMember(l, name20, get19, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache26, true);
		string name21 = "RandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_RandomDropInfo);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_RandomDropInfo);
		}
		LuaObject.addMember(l, name21, get20, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache28, true);
		string name22 = "TeamRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_TeamRandomDropInfo);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_TeamRandomDropInfo);
		}
		LuaObject.addMember(l, name22, get21, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2A, true);
		string name23 = "DailyRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_DailyRandomDropInfo);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_DailyRandomDropInfo);
		}
		LuaObject.addMember(l, name23, get22, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2C, true);
		string name24 = "UnchartedScoreInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.get_UnchartedScoreInfo);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.set_UnchartedScoreInfo);
		}
		LuaObject.addMember(l, name24, get23, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2E, true);
		if (Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataScoreLevelInfo.<>f__mg$cache2F, typeof(ConfigDataScoreLevelInfo));
	}

	// Token: 0x0400D3BD RID: 54205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D3BE RID: 54206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D3BF RID: 54207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D3C0 RID: 54208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D3C1 RID: 54209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D3C2 RID: 54210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D3C3 RID: 54211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D3C4 RID: 54212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D3C5 RID: 54213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D3C6 RID: 54214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D3C7 RID: 54215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D3C8 RID: 54216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D3C9 RID: 54217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D3CA RID: 54218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D3CB RID: 54219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D3CC RID: 54220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D3CD RID: 54221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D3CE RID: 54222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D3CF RID: 54223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D3D0 RID: 54224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D3D1 RID: 54225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D3D2 RID: 54226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D3D3 RID: 54227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D3D4 RID: 54228
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D3D5 RID: 54229
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D3D6 RID: 54230
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D3D7 RID: 54231
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D3D8 RID: 54232
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D3D9 RID: 54233
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D3DA RID: 54234
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D3DB RID: 54235
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D3DC RID: 54236
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D3DD RID: 54237
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D3DE RID: 54238
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D3DF RID: 54239
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D3E0 RID: 54240
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D3E1 RID: 54241
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D3E2 RID: 54242
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D3E3 RID: 54243
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D3E4 RID: 54244
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D3E5 RID: 54245
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D3E6 RID: 54246
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D3E7 RID: 54247
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D3E8 RID: 54248
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D3E9 RID: 54249
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D3EA RID: 54250
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D3EB RID: 54251
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D3EC RID: 54252
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;
}
