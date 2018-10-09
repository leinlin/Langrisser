using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001155 RID: 4437
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroInfo : LuaObject
{
	// Token: 0x060168FB RID: 92411 RVA: 0x005FC26C File Offset: 0x005FA46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo o = new ConfigDataHeroInfo();
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

	// Token: 0x060168FC RID: 92412 RVA: 0x005FC2B4 File Offset: 0x005FA4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int heroStar;
			LuaObject.checkType(l, 2, out heroStar);
			int rank = configDataHeroInfo.GetRank(heroStar);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168FD RID: 92413 RVA: 0x005FC318 File Offset: 0x005FA518
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetCharImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int heroStar;
			LuaObject.checkType(l, 2, out heroStar);
			ConfigDataCharImageInfo charImageInfo = configDataHeroInfo.GetCharImageInfo(heroStar);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168FE RID: 92414 RVA: 0x005FC37C File Offset: 0x005FA57C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_soldierInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168FF RID: 92415 RVA: 0x005FC3D0 File Offset: 0x005FA5D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_soldierInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataSoldierInfo soldierInfo;
			LuaObject.checkType<ConfigDataSoldierInfo>(l, 2, out soldierInfo);
			configDataHeroInfo.m_soldierInfo = soldierInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016900 RID: 92416 RVA: 0x005FC428 File Offset: 0x005FA628
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_skillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016901 RID: 92417 RVA: 0x005FC47C File Offset: 0x005FA67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] skillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out skillInfos);
			configDataHeroInfo.m_skillInfos = skillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016902 RID: 92418 RVA: 0x005FC4D4 File Offset: 0x005FA6D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hiddenSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_hiddenSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016903 RID: 92419 RVA: 0x005FC528 File Offset: 0x005FA728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hiddenSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataSkillInfo[] hiddenSkillInfos;
			LuaObject.checkArray<ConfigDataSkillInfo>(l, 2, out hiddenSkillInfos);
			configDataHeroInfo.m_hiddenSkillInfos = hiddenSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016904 RID: 92420 RVA: 0x005FC580 File Offset: 0x005FA780
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_jobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_jobConnectionInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016905 RID: 92421 RVA: 0x005FC5D4 File Offset: 0x005FA7D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobConnectionInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo jobConnectionInfo;
			LuaObject.checkType<ConfigDataJobConnectionInfo>(l, 2, out jobConnectionInfo);
			configDataHeroInfo.m_jobConnectionInfo = jobConnectionInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016906 RID: 92422 RVA: 0x005FC62C File Offset: 0x005FA82C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_useableJobConnectionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_useableJobConnectionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016907 RID: 92423 RVA: 0x005FC680 File Offset: 0x005FA880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_useableJobConnectionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataJobConnectionInfo[] useableJobConnectionInfos;
			LuaObject.checkArray<ConfigDataJobConnectionInfo>(l, 2, out useableJobConnectionInfos);
			configDataHeroInfo.m_useableJobConnectionInfos = useableJobConnectionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016908 RID: 92424 RVA: 0x005FC6D8 File Offset: 0x005FA8D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fragmentItemInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_fragmentItemInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016909 RID: 92425 RVA: 0x005FC72C File Offset: 0x005FA92C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_fragmentItemInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataItemInfo fragmentItemInfo;
			LuaObject.checkType<ConfigDataItemInfo>(l, 2, out fragmentItemInfo);
			configDataHeroInfo.m_fragmentItemInfo = fragmentItemInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601690A RID: 92426 RVA: 0x005FC784 File Offset: 0x005FA984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_charImageInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601690B RID: 92427 RVA: 0x005FC7D8 File Offset: 0x005FA9D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_charImageInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo charImageInfo;
			LuaObject.checkType<ConfigDataCharImageInfo>(l, 2, out charImageInfo);
			configDataHeroInfo.m_charImageInfo = charImageInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601690C RID: 92428 RVA: 0x005FC830 File Offset: 0x005FAA30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_starToCharImageInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_starToCharImageInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601690D RID: 92429 RVA: 0x005FC884 File Offset: 0x005FAA84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_starToCharImageInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataCharImageInfo[] starToCharImageInfos;
			LuaObject.checkArray<ConfigDataCharImageInfo>(l, 2, out starToCharImageInfos);
			configDataHeroInfo.m_starToCharImageInfos = starToCharImageInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601690E RID: 92430 RVA: 0x005FC8DC File Offset: 0x005FAADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_informationInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_informationInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601690F RID: 92431 RVA: 0x005FC930 File Offset: 0x005FAB30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_informationInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			ConfigDataHeroInformationInfo informationInfo;
			LuaObject.checkType<ConfigDataHeroInformationInfo>(l, 2, out informationInfo);
			configDataHeroInfo.m_informationInfo = informationInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016910 RID: 92432 RVA: 0x005FC988 File Offset: 0x005FAB88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTagIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.m_heroTagIds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016911 RID: 92433 RVA: 0x005FC9DC File Offset: 0x005FABDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTagIds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			List<int> heroTagIds;
			LuaObject.checkType<List<int>>(l, 2, out heroTagIds);
			configDataHeroInfo.m_heroTagIds = heroTagIds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016912 RID: 92434 RVA: 0x005FCA34 File Offset: 0x005FAC34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016913 RID: 92435 RVA: 0x005FCA88 File Offset: 0x005FAC88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016914 RID: 92436 RVA: 0x005FCAE0 File Offset: 0x005FACE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016915 RID: 92437 RVA: 0x005FCB34 File Offset: 0x005FAD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016916 RID: 92438 RVA: 0x005FCB8C File Offset: 0x005FAD8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016917 RID: 92439 RVA: 0x005FCBE0 File Offset: 0x005FADE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataHeroInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016918 RID: 92440 RVA: 0x005FCC38 File Offset: 0x005FAE38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016919 RID: 92441 RVA: 0x005FCC8C File Offset: 0x005FAE8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataHeroInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601691A RID: 92442 RVA: 0x005FCCE4 File Offset: 0x005FAEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601691B RID: 92443 RVA: 0x005FCD38 File Offset: 0x005FAF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataHeroInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601691C RID: 92444 RVA: 0x005FCD90 File Offset: 0x005FAF90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name_Eng(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Name_Eng);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601691D RID: 92445 RVA: 0x005FCDE4 File Offset: 0x005FAFE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name_Eng(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string name_Eng;
			LuaObject.checkType(l, 2, out name_Eng);
			configDataHeroInfo.Name_Eng = name_Eng;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601691E RID: 92446 RVA: 0x005FCE3C File Offset: 0x005FB03C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobWord(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.JobWord);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601691F RID: 92447 RVA: 0x005FCE90 File Offset: 0x005FB090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobWord(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string jobWord;
			LuaObject.checkType(l, 2, out jobWord);
			configDataHeroInfo.JobWord = jobWord;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016920 RID: 92448 RVA: 0x005FCEE8 File Offset: 0x005FB0E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_JobWordKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.JobWordKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016921 RID: 92449 RVA: 0x005FCF3C File Offset: 0x005FB13C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_JobWordKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string jobWordKey;
			LuaObject.checkType(l, 2, out jobWordKey);
			configDataHeroInfo.JobWordKey = jobWordKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016922 RID: 92450 RVA: 0x005FCF94 File Offset: 0x005FB194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Useable(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Useable);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016923 RID: 92451 RVA: 0x005FCFE8 File Offset: 0x005FB1E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Useable(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			bool useable;
			LuaObject.checkType(l, 2, out useable);
			configDataHeroInfo.Useable = useable;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016924 RID: 92452 RVA: 0x005FD040 File Offset: 0x005FB240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Sex(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Sex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016925 RID: 92453 RVA: 0x005FD094 File Offset: 0x005FB294
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Sex(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int sex;
			LuaObject.checkType(l, 2, out sex);
			configDataHeroInfo.Sex = sex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016926 RID: 92454 RVA: 0x005FD0EC File Offset: 0x005FB2EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Star);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016927 RID: 92455 RVA: 0x005FD140 File Offset: 0x005FB340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Star(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int star;
			LuaObject.checkType(l, 2, out star);
			configDataHeroInfo.Star = star;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016928 RID: 92456 RVA: 0x005FD198 File Offset: 0x005FB398
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Rank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016929 RID: 92457 RVA: 0x005FD1EC File Offset: 0x005FB3EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Rank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int rank;
			LuaObject.checkType(l, 2, out rank);
			configDataHeroInfo.Rank = rank;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601692A RID: 92458 RVA: 0x005FD244 File Offset: 0x005FB444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StarToRank(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.StarToRank);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601692B RID: 92459 RVA: 0x005FD298 File Offset: 0x005FB498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FragmentItem_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.FragmentItem_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601692C RID: 92460 RVA: 0x005FD2EC File Offset: 0x005FB4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FragmentItem_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int fragmentItem_ID;
			LuaObject.checkType(l, 2, out fragmentItem_ID);
			configDataHeroInfo.FragmentItem_ID = fragmentItem_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601692D RID: 92461 RVA: 0x005FD344 File Offset: 0x005FB544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExchangedFragmentCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.ExchangedFragmentCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601692E RID: 92462 RVA: 0x005FD398 File Offset: 0x005FB598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExchangedFragmentCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int exchangedFragmentCount;
			LuaObject.checkType(l, 2, out exchangedFragmentCount);
			configDataHeroInfo.ExchangedFragmentCount = exchangedFragmentCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601692F RID: 92463 RVA: 0x005FD3F0 File Offset: 0x005FB5F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Soldier_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Soldier_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016930 RID: 92464 RVA: 0x005FD444 File Offset: 0x005FB644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Soldier_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int soldier_ID;
			LuaObject.checkType(l, 2, out soldier_ID);
			configDataHeroInfo.Soldier_ID = soldier_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016931 RID: 92465 RVA: 0x005FD49C File Offset: 0x005FB69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SelectableSoldier_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.SelectableSoldier_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016932 RID: 92466 RVA: 0x005FD4F0 File Offset: 0x005FB6F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Skills_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Skills_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016933 RID: 92467 RVA: 0x005FD544 File Offset: 0x005FB744
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HiddenSkills_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.HiddenSkills_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016934 RID: 92468 RVA: 0x005FD598 File Offset: 0x005FB798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HPCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.HPCmd_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016935 RID: 92469 RVA: 0x005FD5EC File Offset: 0x005FB7EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HPCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int hpcmd_INI;
			LuaObject.checkType(l, 2, out hpcmd_INI);
			configDataHeroInfo.HPCmd_INI = hpcmd_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016936 RID: 92470 RVA: 0x005FD644 File Offset: 0x005FB844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DFCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.DFCmd_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016937 RID: 92471 RVA: 0x005FD698 File Offset: 0x005FB898
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DFCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int dfcmd_INI;
			LuaObject.checkType(l, 2, out dfcmd_INI);
			configDataHeroInfo.DFCmd_INI = dfcmd_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016938 RID: 92472 RVA: 0x005FD6F0 File Offset: 0x005FB8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ATCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.ATCmd_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016939 RID: 92473 RVA: 0x005FD744 File Offset: 0x005FB944
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ATCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int atcmd_INI;
			LuaObject.checkType(l, 2, out atcmd_INI);
			configDataHeroInfo.ATCmd_INI = atcmd_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601693A RID: 92474 RVA: 0x005FD79C File Offset: 0x005FB99C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MagicDFCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.MagicDFCmd_INI);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601693B RID: 92475 RVA: 0x005FD7F0 File Offset: 0x005FB9F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MagicDFCmd_INI(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int magicDFCmd_INI;
			LuaObject.checkType(l, 2, out magicDFCmd_INI);
			configDataHeroInfo.MagicDFCmd_INI = magicDFCmd_INI;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601693C RID: 92476 RVA: 0x005FD848 File Offset: 0x005FBA48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CmdRating(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.CmdRating);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601693D RID: 92477 RVA: 0x005FD89C File Offset: 0x005FBA9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CmdRating(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			string cmdRating;
			LuaObject.checkType(l, 2, out cmdRating);
			configDataHeroInfo.CmdRating = cmdRating;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601693E RID: 92478 RVA: 0x005FD8F4 File Offset: 0x005FBAF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HPStar(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.HPStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601693F RID: 92479 RVA: 0x005FD948 File Offset: 0x005FBB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ATStar(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.ATStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016940 RID: 92480 RVA: 0x005FD99C File Offset: 0x005FBB9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MagicStar(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.MagicStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016941 RID: 92481 RVA: 0x005FD9F0 File Offset: 0x005FBBF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DFStar(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.DFStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016942 RID: 92482 RVA: 0x005FDA44 File Offset: 0x005FBC44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MagicDFStar(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.MagicDFStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016943 RID: 92483 RVA: 0x005FDA98 File Offset: 0x005FBC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DEXStar(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.DEXStar);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016944 RID: 92484 RVA: 0x005FDAEC File Offset: 0x005FBCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobConnection_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.JobConnection_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016945 RID: 92485 RVA: 0x005FDB40 File Offset: 0x005FBD40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_JobConnection_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int jobConnection_ID;
			LuaObject.checkType(l, 2, out jobConnection_ID);
			configDataHeroInfo.JobConnection_ID = jobConnection_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016946 RID: 92486 RVA: 0x005FDB98 File Offset: 0x005FBD98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UseableJobConnections_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.UseableJobConnections_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016947 RID: 92487 RVA: 0x005FDBEC File Offset: 0x005FBDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.CharImage_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016948 RID: 92488 RVA: 0x005FDC40 File Offset: 0x005FBE40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CharImage_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int charImage_ID;
			LuaObject.checkType(l, 2, out charImage_ID);
			configDataHeroInfo.CharImage_ID = charImage_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016949 RID: 92489 RVA: 0x005FDC98 File Offset: 0x005FBE98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroInformation_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.HeroInformation_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601694A RID: 92490 RVA: 0x005FDCEC File Offset: 0x005FBEEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroInformation_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			int heroInformation_ID;
			LuaObject.checkType(l, 2, out heroInformation_ID);
			configDataHeroInfo.HeroInformation_ID = heroInformation_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601694B RID: 92491 RVA: 0x005FDD44 File Offset: 0x005FBF44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TechCanLearnSoldiers_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.TechCanLearnSoldiers_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601694C RID: 92492 RVA: 0x005FDD98 File Offset: 0x005FBF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Skins_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroInfo configDataHeroInfo = (ConfigDataHeroInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroInfo.Skins_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601694D RID: 92493 RVA: 0x005FDDEC File Offset: 0x005FBFEC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.GetRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.GetCharImageInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1);
		string name = "m_soldierInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_soldierInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_soldierInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3, true);
		string name2 = "m_skillInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_skillInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_skillInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache5, true);
		string name3 = "m_hiddenSkillInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_hiddenSkillInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_hiddenSkillInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache7, true);
		string name4 = "m_jobConnectionInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_jobConnectionInfo);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_jobConnectionInfo);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache9, true);
		string name5 = "m_useableJobConnectionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_useableJobConnectionInfos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_useableJobConnectionInfos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheB, true);
		string name6 = "m_fragmentItemInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_fragmentItemInfo);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_fragmentItemInfo);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheD, true);
		string name7 = "m_charImageInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_charImageInfo);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_charImageInfo);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cacheF, true);
		string name8 = "m_starToCharImageInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_starToCharImageInfos);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_starToCharImageInfos);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache11, true);
		string name9 = "m_informationInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_informationInfo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_informationInfo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache13, true);
		string name10 = "m_heroTagIds";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_m_heroTagIds);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_m_heroTagIds);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache15, true);
		string name11 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_ID);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_ID);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache17, true);
		string name12 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Name);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Name);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache19, true);
		string name13 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_NameStrKey);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1B, true);
		string name14 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Desc);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Desc);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1D, true);
		string name15 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_DescStrKey);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache1F, true);
		string name16 = "Name_Eng";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Name_Eng);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Name_Eng);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache21, true);
		string name17 = "JobWord";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_JobWord);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_JobWord);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache23, true);
		string name18 = "JobWordKey";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_JobWordKey);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_JobWordKey);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache25, true);
		string name19 = "Useable";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Useable);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Useable);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache27, true);
		string name20 = "Sex";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Sex);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Sex);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache29, true);
		string name21 = "Star";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Star);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Star);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2B, true);
		string name22 = "Rank";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Rank);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Rank);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2D, true);
		string name23 = "StarToRank";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_StarToRank);
		}
		LuaObject.addMember(l, name23, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2E, null, true);
		string name24 = "FragmentItem_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_FragmentItem_ID);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_FragmentItem_ID);
		}
		LuaObject.addMember(l, name24, get23, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache30, true);
		string name25 = "ExchangedFragmentCount";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_ExchangedFragmentCount);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_ExchangedFragmentCount);
		}
		LuaObject.addMember(l, name25, get24, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache32, true);
		string name26 = "Soldier_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Soldier_ID);
		}
		LuaCSFunction get25 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_Soldier_ID);
		}
		LuaObject.addMember(l, name26, get25, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache34, true);
		string name27 = "SelectableSoldier_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_SelectableSoldier_ID);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache35, null, true);
		string name28 = "Skills_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Skills_ID);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache36, null, true);
		string name29 = "HiddenSkills_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_HiddenSkills_ID);
		}
		LuaObject.addMember(l, name29, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache37, null, true);
		string name30 = "HPCmd_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_HPCmd_INI);
		}
		LuaCSFunction get26 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache38;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_HPCmd_INI);
		}
		LuaObject.addMember(l, name30, get26, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache39, true);
		string name31 = "DFCmd_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_DFCmd_INI);
		}
		LuaCSFunction get27 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3A;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_DFCmd_INI);
		}
		LuaObject.addMember(l, name31, get27, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3B, true);
		string name32 = "ATCmd_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_ATCmd_INI);
		}
		LuaCSFunction get28 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3C;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_ATCmd_INI);
		}
		LuaObject.addMember(l, name32, get28, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3D, true);
		string name33 = "MagicDFCmd_INI";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_MagicDFCmd_INI);
		}
		LuaCSFunction get29 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3E;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_MagicDFCmd_INI);
		}
		LuaObject.addMember(l, name33, get29, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache3F, true);
		string name34 = "CmdRating";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_CmdRating);
		}
		LuaCSFunction get30 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache40;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_CmdRating);
		}
		LuaObject.addMember(l, name34, get30, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache41, true);
		string name35 = "HPStar";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_HPStar);
		}
		LuaObject.addMember(l, name35, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache42, null, true);
		string name36 = "ATStar";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_ATStar);
		}
		LuaObject.addMember(l, name36, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache43, null, true);
		string name37 = "MagicStar";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_MagicStar);
		}
		LuaObject.addMember(l, name37, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache44, null, true);
		string name38 = "DFStar";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_DFStar);
		}
		LuaObject.addMember(l, name38, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache45, null, true);
		string name39 = "MagicDFStar";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_MagicDFStar);
		}
		LuaObject.addMember(l, name39, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache46, null, true);
		string name40 = "DEXStar";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_DEXStar);
		}
		LuaObject.addMember(l, name40, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache47, null, true);
		string name41 = "JobConnection_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_JobConnection_ID);
		}
		LuaCSFunction get31 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache48;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_JobConnection_ID);
		}
		LuaObject.addMember(l, name41, get31, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache49, true);
		string name42 = "UseableJobConnections_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_UseableJobConnections_ID);
		}
		LuaObject.addMember(l, name42, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4A, null, true);
		string name43 = "CharImage_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_CharImage_ID);
		}
		LuaCSFunction get32 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4B;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_CharImage_ID);
		}
		LuaObject.addMember(l, name43, get32, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4C, true);
		string name44 = "HeroInformation_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_HeroInformation_ID);
		}
		LuaCSFunction get33 = Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4D;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.set_HeroInformation_ID);
		}
		LuaObject.addMember(l, name44, get33, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4E, true);
		string name45 = "TechCanLearnSoldiers_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_TechCanLearnSoldiers_ID);
		}
		LuaObject.addMember(l, name45, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache4F, null, true);
		string name46 = "Skins_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.get_Skins_ID);
		}
		LuaObject.addMember(l, name46, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache50, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroInfo.<>f__mg$cache51, typeof(ConfigDataHeroInfo));
	}

	// Token: 0x0400D033 RID: 53299
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D034 RID: 53300
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D035 RID: 53301
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D036 RID: 53302
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D037 RID: 53303
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D038 RID: 53304
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D039 RID: 53305
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D03A RID: 53306
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D03B RID: 53307
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D03C RID: 53308
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D03D RID: 53309
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D03E RID: 53310
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D03F RID: 53311
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D040 RID: 53312
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D041 RID: 53313
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D042 RID: 53314
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D043 RID: 53315
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D044 RID: 53316
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D045 RID: 53317
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D046 RID: 53318
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D047 RID: 53319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D048 RID: 53320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D049 RID: 53321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D04A RID: 53322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D04B RID: 53323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D04C RID: 53324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D04D RID: 53325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D04E RID: 53326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D04F RID: 53327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D050 RID: 53328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D051 RID: 53329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D052 RID: 53330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D053 RID: 53331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D054 RID: 53332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D055 RID: 53333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D056 RID: 53334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D057 RID: 53335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D058 RID: 53336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D059 RID: 53337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D05A RID: 53338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D05B RID: 53339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D05C RID: 53340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D05D RID: 53341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D05E RID: 53342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D05F RID: 53343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D060 RID: 53344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D061 RID: 53345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D062 RID: 53346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D063 RID: 53347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D064 RID: 53348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D065 RID: 53349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D066 RID: 53350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D067 RID: 53351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D068 RID: 53352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D069 RID: 53353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D06A RID: 53354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D06B RID: 53355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400D06C RID: 53356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400D06D RID: 53357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400D06E RID: 53358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400D06F RID: 53359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400D070 RID: 53360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400D071 RID: 53361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400D072 RID: 53362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400D073 RID: 53363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400D074 RID: 53364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400D075 RID: 53365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400D076 RID: 53366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400D077 RID: 53367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400D078 RID: 53368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400D079 RID: 53369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400D07A RID: 53370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400D07B RID: 53371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400D07C RID: 53372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400D07D RID: 53373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400D07E RID: 53374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400D07F RID: 53375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400D080 RID: 53376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400D081 RID: 53377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400D082 RID: 53378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400D083 RID: 53379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400D084 RID: 53380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;
}
