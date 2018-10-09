using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001156 RID: 4438
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo : LuaObject
{
	// Token: 0x0601694F RID: 92495 RVA: 0x005FE9A8 File Offset: 0x005FCBA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo o = new ConfigDataHeroInformationInfo();
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

	// Token: 0x06016950 RID: 92496 RVA: 0x005FE9F0 File Offset: 0x005FCBF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fetterInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.m_fetterInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016951 RID: 92497 RVA: 0x005FEA44 File Offset: 0x005FCC44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fetterInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			List<ConfigDataHeroFetterInfo> fetterInfos;
			LuaObject.checkType<List<ConfigDataHeroFetterInfo>>(l, 2, out fetterInfos);
			configDataHeroInformationInfo.m_fetterInfos = fetterInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016952 RID: 92498 RVA: 0x005FEA9C File Offset: 0x005FCC9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confessionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.m_confessionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016953 RID: 92499 RVA: 0x005FEAF0 File Offset: 0x005FCCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confessionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			ConfigDataHeroConfessionInfo confessionInfo;
			LuaObject.checkType<ConfigDataHeroConfessionInfo>(l, 2, out confessionInfo);
			configDataHeroInformationInfo.m_confessionInfo = confessionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016954 RID: 92500 RVA: 0x005FEB48 File Offset: 0x005FCD48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.m_heroInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016955 RID: 92501 RVA: 0x005FEB9C File Offset: 0x005FCD9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			ConfigDataHeroInfo heroInfo;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out heroInfo);
			configDataHeroInformationInfo.m_heroInfo = heroInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016956 RID: 92502 RVA: 0x005FEBF4 File Offset: 0x005FCDF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016957 RID: 92503 RVA: 0x005FEC48 File Offset: 0x005FCE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroInformationInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016958 RID: 92504 RVA: 0x005FECA0 File Offset: 0x005FCEA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016959 RID: 92505 RVA: 0x005FECF4 File Offset: 0x005FCEF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroInformationInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601695A RID: 92506 RVA: 0x005FED4C File Offset: 0x005FCF4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroBiographies_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.HeroBiographies_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601695B RID: 92507 RVA: 0x005FEDA0 File Offset: 0x005FCFA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroFetters_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.HeroFetters_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601695C RID: 92508 RVA: 0x005FEDF4 File Offset: 0x005FCFF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroConfession(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.HeroConfession);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601695D RID: 92509 RVA: 0x005FEE48 File Offset: 0x005FD048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroConfession(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int heroConfession;
			LuaObject.checkType(l, 2, out heroConfession);
			configDataHeroInformationInfo.HeroConfession = heroConfession;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601695E RID: 92510 RVA: 0x005FEEA0 File Offset: 0x005FD0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroPerformance_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.HeroPerformance_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601695F RID: 92511 RVA: 0x005FEEF4 File Offset: 0x005FD0F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroPerformance_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int heroPerformance_ID;
			LuaObject.checkType(l, 2, out heroPerformance_ID);
			configDataHeroInformationInfo.HeroPerformance_ID = heroPerformance_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016960 RID: 92512 RVA: 0x005FEF4C File Offset: 0x005FD14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsDungeonLevelsUnLock(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.IsDungeonLevelsUnLock);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016961 RID: 92513 RVA: 0x005FEFA0 File Offset: 0x005FD1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsDungeonLevelsUnLock(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			bool isDungeonLevelsUnLock;
			LuaObject.checkType(l, 2, out isDungeonLevelsUnLock);
			configDataHeroInformationInfo.IsDungeonLevelsUnLock = isDungeonLevelsUnLock;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016962 RID: 92514 RVA: 0x005FEFF8 File Offset: 0x005FD1F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DungeonLevels_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.DungeonLevels_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016963 RID: 92515 RVA: 0x005FF04C File Offset: 0x005FD24C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward1Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Reward1Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016964 RID: 92516 RVA: 0x005FF0A0 File Offset: 0x005FD2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Reward1Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int reward1Star;
			LuaObject.checkType(l, 2, out reward1Star);
			configDataHeroInformationInfo.Reward1Star = reward1Star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016965 RID: 92517 RVA: 0x005FF0F8 File Offset: 0x005FD2F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Reward1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016966 RID: 92518 RVA: 0x005FF14C File Offset: 0x005FD34C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward2Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Reward2Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016967 RID: 92519 RVA: 0x005FF1A0 File Offset: 0x005FD3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Reward2Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int reward2Star;
			LuaObject.checkType(l, 2, out reward2Star);
			configDataHeroInformationInfo.Reward2Star = reward2Star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016968 RID: 92520 RVA: 0x005FF1F8 File Offset: 0x005FD3F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Reward2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016969 RID: 92521 RVA: 0x005FF24C File Offset: 0x005FD44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reward3Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Reward3Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601696A RID: 92522 RVA: 0x005FF2A0 File Offset: 0x005FD4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Reward3Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int reward3Star;
			LuaObject.checkType(l, 2, out reward3Star);
			configDataHeroInformationInfo.Reward3Star = reward3Star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601696B RID: 92523 RVA: 0x005FF2F8 File Offset: 0x005FD4F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Reward3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.Reward3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601696C RID: 92524 RVA: 0x005FF34C File Offset: 0x005FD54C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FavorabilityMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.FavorabilityMaxLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601696D RID: 92525 RVA: 0x005FF3A0 File Offset: 0x005FD5A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FavorabilityMaxLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int favorabilityMaxLevel;
			LuaObject.checkType(l, 2, out favorabilityMaxLevel);
			configDataHeroInformationInfo.FavorabilityMaxLevel = favorabilityMaxLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601696E RID: 92526 RVA: 0x005FF3F8 File Offset: 0x005FD5F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FavourabilityLevelUpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.FavourabilityLevelUpReward);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601696F RID: 92527 RVA: 0x005FF44C File Offset: 0x005FD64C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FavourabilityLevelUpReward(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int favourabilityLevelUpReward;
			LuaObject.checkType(l, 2, out favourabilityLevelUpReward);
			configDataHeroInformationInfo.FavourabilityLevelUpReward = favourabilityLevelUpReward;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016970 RID: 92528 RVA: 0x005FF4A4 File Offset: 0x005FD6A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroTouch(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.HeroTouch);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016971 RID: 92529 RVA: 0x005FF4F8 File Offset: 0x005FD6F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SendRewardsPerformance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.SendRewardsPerformance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016972 RID: 92530 RVA: 0x005FF54C File Offset: 0x005FD74C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SendRewardsPerformance(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			int sendRewardsPerformance;
			LuaObject.checkType(l, 2, out sendRewardsPerformance);
			configDataHeroInformationInfo.SendRewardsPerformance = sendRewardsPerformance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016973 RID: 92531 RVA: 0x005FF5A4 File Offset: 0x005FD7A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InteractHeroPerformances_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInformationInfo configDataHeroInformationInfo = (ConfigDataHeroInformationInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInformationInfo.InteractHeroPerformances_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016974 RID: 92532 RVA: 0x005FF5F8 File Offset: 0x005FD7F8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroInformationInfo");
		string name = "m_fetterInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_m_fetterInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_m_fetterInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1, true);
		string name2 = "m_confessionInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_m_confessionInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_m_confessionInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache3, true);
		string name3 = "m_heroInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_m_heroInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_m_heroInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache9, true);
		string name6 = "HeroBiographies_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_HeroBiographies_ID);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheA, null, true);
		string name7 = "HeroFetters_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_HeroFetters_ID);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheB, null, true);
		string name8 = "HeroConfession";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_HeroConfession);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_HeroConfession);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheD, true);
		string name9 = "HeroPerformance_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_HeroPerformance_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_HeroPerformance_ID);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cacheF, true);
		string name10 = "IsDungeonLevelsUnLock";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_IsDungeonLevelsUnLock);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_IsDungeonLevelsUnLock);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache11, true);
		string name11 = "DungeonLevels_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_DungeonLevels_ID);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache12, null, true);
		string name12 = "Reward1Star";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Reward1Star);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_Reward1Star);
		}
		LuaObject.addMember(l, name12, get9, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache14, true);
		string name13 = "Reward1";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Reward1);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache15, null, true);
		string name14 = "Reward2Star";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Reward2Star);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_Reward2Star);
		}
		LuaObject.addMember(l, name14, get10, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache17, true);
		string name15 = "Reward2";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Reward2);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache18, null, true);
		string name16 = "Reward3Star";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Reward3Star);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_Reward3Star);
		}
		LuaObject.addMember(l, name16, get11, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1A, true);
		string name17 = "Reward3";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_Reward3);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1B, null, true);
		string name18 = "FavorabilityMaxLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_FavorabilityMaxLevel);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_FavorabilityMaxLevel);
		}
		LuaObject.addMember(l, name18, get12, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1D, true);
		string name19 = "FavourabilityLevelUpReward";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_FavourabilityLevelUpReward);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_FavourabilityLevelUpReward);
		}
		LuaObject.addMember(l, name19, get13, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache1F, true);
		string name20 = "HeroTouch";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_HeroTouch);
		}
		LuaObject.addMember(l, name20, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache20, null, true);
		string name21 = "SendRewardsPerformance";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_SendRewardsPerformance);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache21;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.set_SendRewardsPerformance);
		}
		LuaObject.addMember(l, name21, get14, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache22, true);
		string name22 = "InteractHeroPerformances_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.get_InteractHeroPerformances_ID);
		}
		LuaObject.addMember(l, name22, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache23, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroInformationInfo.<>f__mg$cache24, typeof(ConfigDataHeroInformationInfo));
	}

	// Token: 0x0400D085 RID: 53381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D086 RID: 53382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D087 RID: 53383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D088 RID: 53384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D089 RID: 53385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D08A RID: 53386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D08B RID: 53387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D08C RID: 53388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D08D RID: 53389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D08E RID: 53390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D08F RID: 53391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D090 RID: 53392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D091 RID: 53393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D092 RID: 53394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D093 RID: 53395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D094 RID: 53396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D095 RID: 53397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D096 RID: 53398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D097 RID: 53399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D098 RID: 53400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D099 RID: 53401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D09A RID: 53402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D09B RID: 53403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D09C RID: 53404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D09D RID: 53405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D09E RID: 53406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D09F RID: 53407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D0A0 RID: 53408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D0A1 RID: 53409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D0A2 RID: 53410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D0A3 RID: 53411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D0A4 RID: 53412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D0A5 RID: 53413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D0A6 RID: 53414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D0A7 RID: 53415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D0A8 RID: 53416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D0A9 RID: 53417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;
}
