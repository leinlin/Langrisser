using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001149 RID: 4425
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo : LuaObject
{
	// Token: 0x06016715 RID: 91925 RVA: 0x005EE5B8 File Offset: 0x005EC7B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo o = new ConfigDataCooperateBattleLevelInfo();
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

	// Token: 0x06016716 RID: 91926 RVA: 0x005EE600 File Offset: 0x005EC800
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.m_battleInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016717 RID: 91927 RVA: 0x005EE654 File Offset: 0x005EC854
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			ConfigDataBattleInfo battleInfo;
			LuaObject.checkType<ConfigDataBattleInfo>(l, 2, out battleInfo);
			configDataCooperateBattleLevelInfo.m_battleInfo = battleInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016718 RID: 91928 RVA: 0x005EE6AC File Offset: 0x005EC8AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.m_groupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016719 RID: 91929 RVA: 0x005EE700 File Offset: 0x005EC900
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_groupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			ConfigDataCooperateBattleInfo groupInfo;
			LuaObject.checkType<ConfigDataCooperateBattleInfo>(l, 2, out groupInfo);
			configDataCooperateBattleLevelInfo.m_groupInfo = groupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601671A RID: 91930 RVA: 0x005EE758 File Offset: 0x005EC958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.m_randomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601671B RID: 91931 RVA: 0x005EE7AC File Offset: 0x005EC9AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_randomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo randomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out randomDropInfo);
			configDataCooperateBattleLevelInfo.m_randomDropInfo = randomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601671C RID: 91932 RVA: 0x005EE804 File Offset: 0x005ECA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_teamRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.m_teamRandomDropInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601671D RID: 91933 RVA: 0x005EE858 File Offset: 0x005ECA58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamRandomDropInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			ConfigDataRandomDropRewardInfo teamRandomDropInfo;
			LuaObject.checkType<ConfigDataRandomDropRewardInfo>(l, 2, out teamRandomDropInfo);
			configDataCooperateBattleLevelInfo.m_teamRandomDropInfo = teamRandomDropInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601671E RID: 91934 RVA: 0x005EE8B0 File Offset: 0x005ECAB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601671F RID: 91935 RVA: 0x005EE904 File Offset: 0x005ECB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataCooperateBattleLevelInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016720 RID: 91936 RVA: 0x005EE95C File Offset: 0x005ECB5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016721 RID: 91937 RVA: 0x005EE9B0 File Offset: 0x005ECBB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataCooperateBattleLevelInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016722 RID: 91938 RVA: 0x005EEA08 File Offset: 0x005ECC08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016723 RID: 91939 RVA: 0x005EEA5C File Offset: 0x005ECC5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataCooperateBattleLevelInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016724 RID: 91940 RVA: 0x005EEAB4 File Offset: 0x005ECCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevelRequired(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.PlayerLevelRequired);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016725 RID: 91941 RVA: 0x005EEB08 File Offset: 0x005ECD08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerLevelRequired(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int playerLevelRequired;
			LuaObject.checkType(l, 2, out playerLevelRequired);
			configDataCooperateBattleLevelInfo.PlayerLevelRequired = playerLevelRequired;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016726 RID: 91942 RVA: 0x005EEB60 File Offset: 0x005ECD60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.EnergySuccess);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016727 RID: 91943 RVA: 0x005EEBB4 File Offset: 0x005ECDB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergySuccess(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int energySuccess;
			LuaObject.checkType(l, 2, out energySuccess);
			configDataCooperateBattleLevelInfo.EnergySuccess = energySuccess;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016728 RID: 91944 RVA: 0x005EEC0C File Offset: 0x005ECE0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.EnergyFail);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016729 RID: 91945 RVA: 0x005EEC60 File Offset: 0x005ECE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EnergyFail(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int energyFail;
			LuaObject.checkType(l, 2, out energyFail);
			configDataCooperateBattleLevelInfo.EnergyFail = energyFail;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601672A RID: 91946 RVA: 0x005EECB8 File Offset: 0x005ECEB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.MonsterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601672B RID: 91947 RVA: 0x005EED0C File Offset: 0x005ECF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MonsterLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int monsterLevel;
			LuaObject.checkType(l, 2, out monsterLevel);
			configDataCooperateBattleLevelInfo.MonsterLevel = monsterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601672C RID: 91948 RVA: 0x005EED64 File Offset: 0x005ECF64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.Battle_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601672D RID: 91949 RVA: 0x005EEDB8 File Offset: 0x005ECFB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Battle_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int battle_ID;
			LuaObject.checkType(l, 2, out battle_ID);
			configDataCooperateBattleLevelInfo.Battle_ID = battle_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601672E RID: 91950 RVA: 0x005EEE10 File Offset: 0x005ED010
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601672F RID: 91951 RVA: 0x005EEE64 File Offset: 0x005ED064
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			configDataCooperateBattleLevelInfo.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016730 RID: 91952 RVA: 0x005EEEBC File Offset: 0x005ED0BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016731 RID: 91953 RVA: 0x005EEF10 File Offset: 0x005ED110
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			configDataCooperateBattleLevelInfo.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016732 RID: 91954 RVA: 0x005EEF68 File Offset: 0x005ED168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016733 RID: 91955 RVA: 0x005EEFBC File Offset: 0x005ED1BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			configDataCooperateBattleLevelInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016734 RID: 91956 RVA: 0x005EF014 File Offset: 0x005ED214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DropID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.DropID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016735 RID: 91957 RVA: 0x005EF068 File Offset: 0x005ED268
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DropID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int dropID;
			LuaObject.checkType(l, 2, out dropID);
			configDataCooperateBattleLevelInfo.DropID = dropID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016736 RID: 91958 RVA: 0x005EF0C0 File Offset: 0x005ED2C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.ItemDropCountDisplay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016737 RID: 91959 RVA: 0x005EF114 File Offset: 0x005ED314
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ItemDropCountDisplay(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int itemDropCountDisplay;
			LuaObject.checkType(l, 2, out itemDropCountDisplay);
			configDataCooperateBattleLevelInfo.ItemDropCountDisplay = itemDropCountDisplay;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016738 RID: 91960 RVA: 0x005EF16C File Offset: 0x005ED36C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016739 RID: 91961 RVA: 0x005EF1C0 File Offset: 0x005ED3C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataCooperateBattleLevelInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601673A RID: 91962 RVA: 0x005EF218 File Offset: 0x005ED418
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.DayBonusDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601673B RID: 91963 RVA: 0x005EF26C File Offset: 0x005ED46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DayBonusDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int dayBonusDrop_ID;
			LuaObject.checkType(l, 2, out dayBonusDrop_ID);
			configDataCooperateBattleLevelInfo.DayBonusDrop_ID = dayBonusDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601673C RID: 91964 RVA: 0x005EF2C4 File Offset: 0x005ED4C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCooperateBattleLevelInfo.TeamDrop_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601673D RID: 91965 RVA: 0x005EF318 File Offset: 0x005ED518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamDrop_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCooperateBattleLevelInfo configDataCooperateBattleLevelInfo = (ConfigDataCooperateBattleLevelInfo)LuaObject.checkSelf(l);
			int teamDrop_ID;
			LuaObject.checkType(l, 2, out teamDrop_ID);
			configDataCooperateBattleLevelInfo.TeamDrop_ID = teamDrop_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601673E RID: 91966 RVA: 0x005EF370 File Offset: 0x005ED570
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataCooperateBattleLevelInfo");
		string name = "m_battleInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_m_battleInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_m_battleInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1, true);
		string name2 = "m_groupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_m_groupInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_m_groupInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache3, true);
		string name3 = "m_randomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_m_randomDropInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_m_randomDropInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache5, true);
		string name4 = "m_teamRandomDropInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_m_teamRandomDropInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_m_teamRandomDropInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheB, true);
		string name7 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_TeamName);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_TeamName);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheD, true);
		string name8 = "PlayerLevelRequired";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_PlayerLevelRequired);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_PlayerLevelRequired);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cacheF, true);
		string name9 = "EnergySuccess";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_EnergySuccess);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_EnergySuccess);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache11, true);
		string name10 = "EnergyFail";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_EnergyFail);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_EnergyFail);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache13, true);
		string name11 = "MonsterLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_MonsterLevel);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_MonsterLevel);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache15, true);
		string name12 = "Battle_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_Battle_ID);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_Battle_ID);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache17, true);
		string name13 = "PlayerExp";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_PlayerExp);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_PlayerExp);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache19, true);
		string name14 = "HeroExp";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_HeroExp);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_HeroExp);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1B, true);
		string name15 = "Gold";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_Gold);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_Gold);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1D, true);
		string name16 = "DropID";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_DropID);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_DropID);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache1F, true);
		string name17 = "ItemDropCountDisplay";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_ItemDropCountDisplay);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_ItemDropCountDisplay);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache21, true);
		string name18 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_Icon);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_Icon);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache23, true);
		string name19 = "DayBonusDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_DayBonusDrop_ID);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_DayBonusDrop_ID);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache25, true);
		string name20 = "TeamDrop_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.get_TeamDrop_ID);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.set_TeamDrop_ID);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache27, true);
		if (Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataCooperateBattleLevelInfo.<>f__mg$cache28, typeof(ConfigDataCooperateBattleLevelInfo));
	}

	// Token: 0x0400CE65 RID: 52837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CE66 RID: 52838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CE67 RID: 52839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CE68 RID: 52840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CE69 RID: 52841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CE6A RID: 52842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CE6B RID: 52843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CE6C RID: 52844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CE6D RID: 52845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CE6E RID: 52846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CE6F RID: 52847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CE70 RID: 52848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CE71 RID: 52849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CE72 RID: 52850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CE73 RID: 52851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CE74 RID: 52852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CE75 RID: 52853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CE76 RID: 52854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CE77 RID: 52855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CE78 RID: 52856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CE79 RID: 52857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CE7A RID: 52858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CE7B RID: 52859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CE7C RID: 52860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CE7D RID: 52861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CE7E RID: 52862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CE7F RID: 52863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CE80 RID: 52864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CE81 RID: 52865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CE82 RID: 52866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CE83 RID: 52867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CE84 RID: 52868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CE85 RID: 52869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CE86 RID: 52870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CE87 RID: 52871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CE88 RID: 52872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CE89 RID: 52873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CE8A RID: 52874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CE8B RID: 52875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CE8C RID: 52876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CE8D RID: 52877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;
}
