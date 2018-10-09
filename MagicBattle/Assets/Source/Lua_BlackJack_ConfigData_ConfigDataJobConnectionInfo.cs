using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200115C RID: 4444
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo : LuaObject
{
	// Token: 0x06016A24 RID: 92708 RVA: 0x006049B8 File Offset: 0x00602BB8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo o = new ConfigDataJobConnectionInfo();
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

	// Token: 0x06016A25 RID: 92709 RVA: 0x00604A00 File Offset: 0x00602C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetTalentSkillInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int heroStar;
			LuaObject.checkType(l, 2, out heroStar);
			ConfigDataSkillInfo talentSkillInfo = configDataJobConnectionInfo.GetTalentSkillInfo(heroStar);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, talentSkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A26 RID: 92710 RVA: 0x00604A64 File Offset: 0x00602C64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsJobLevelMax(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int jobLevel;
			LuaObject.checkType(l, 2, out jobLevel);
			bool b = configDataJobConnectionInfo.IsJobLevelMax(jobLevel);
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

	// Token: 0x06016A27 RID: 92711 RVA: 0x00604AC8 File Offset: 0x00602CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.m_jobInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A28 RID: 92712 RVA: 0x00604B1C File Offset: 0x00602D1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			ConfigDataJobInfo jobInfo;
			LuaObject.checkType<ConfigDataJobInfo>(l, 2, out jobInfo);
			configDataJobConnectionInfo.m_jobInfo = jobInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A29 RID: 92713 RVA: 0x00604B74 File Offset: 0x00602D74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_jobLevelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.m_jobLevelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A2A RID: 92714 RVA: 0x00604BC8 File Offset: 0x00602DC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_jobLevelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			ConfigDataJobLevelInfo[] jobLevelInfos;
			LuaObject.checkArray<ConfigDataJobLevelInfo>(l, 2, out jobLevelInfos);
			configDataJobConnectionInfo.m_jobLevelInfos = jobLevelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A2B RID: 92715 RVA: 0x00604C20 File Offset: 0x00602E20
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_unlockConditions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.m_unlockConditions);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A2C RID: 92716 RVA: 0x00604C74 File Offset: 0x00602E74
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_unlockConditions(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			List<ConfigDataJobUnlockConditionInfo> unlockConditions;
			LuaObject.checkType<List<ConfigDataJobUnlockConditionInfo>>(l, 2, out unlockConditions);
			configDataJobConnectionInfo.m_unlockConditions = unlockConditions;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A2D RID: 92717 RVA: 0x00604CCC File Offset: 0x00602ECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_preJobConnectionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.m_preJobConnectionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A2E RID: 92718 RVA: 0x00604D20 File Offset: 0x00602F20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_preJobConnectionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			List<ConfigDataJobConnectionInfo> preJobConnectionInfos;
			LuaObject.checkType<List<ConfigDataJobConnectionInfo>>(l, 2, out preJobConnectionInfos);
			configDataJobConnectionInfo.m_preJobConnectionInfos = preJobConnectionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A2F RID: 92719 RVA: 0x00604D78 File Offset: 0x00602F78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_talentSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.m_talentSkillInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A30 RID: 92720 RVA: 0x00604DCC File Offset: 0x00602FCC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_talentSkillInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			List<ConfigDataSkillInfo> talentSkillInfos;
			LuaObject.checkType<List<ConfigDataSkillInfo>>(l, 2, out talentSkillInfos);
			configDataJobConnectionInfo.m_talentSkillInfos = talentSkillInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A31 RID: 92721 RVA: 0x00604E24 File Offset: 0x00603024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A32 RID: 92722 RVA: 0x00604E78 File Offset: 0x00603078
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataJobConnectionInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A33 RID: 92723 RVA: 0x00604ED0 File Offset: 0x006030D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A34 RID: 92724 RVA: 0x00604F24 File Offset: 0x00603124
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataJobConnectionInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A35 RID: 92725 RVA: 0x00604F7C File Offset: 0x0060317C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.DescStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A36 RID: 92726 RVA: 0x00604FD0 File Offset: 0x006031D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DescStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			string descStrKey;
			LuaObject.checkType(l, 2, out descStrKey);
			configDataJobConnectionInfo.DescStrKey = descStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A37 RID: 92727 RVA: 0x00605028 File Offset: 0x00603228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name_Eng(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Name_Eng);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A38 RID: 92728 RVA: 0x0060507C File Offset: 0x0060327C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name_Eng(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			string name_Eng;
			LuaObject.checkType(l, 2, out name_Eng);
			configDataJobConnectionInfo.Name_Eng = name_Eng;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A39 RID: 92729 RVA: 0x006050D4 File Offset: 0x006032D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Job_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Job_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A3A RID: 92730 RVA: 0x00605128 File Offset: 0x00603328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Job_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int job_ID;
			LuaObject.checkType(l, 2, out job_ID);
			configDataJobConnectionInfo.Job_ID = job_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A3B RID: 92731 RVA: 0x00605180 File Offset: 0x00603380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobLevels_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.JobLevels_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A3C RID: 92732 RVA: 0x006051D4 File Offset: 0x006033D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TalentSkill_IDs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.TalentSkill_IDs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A3D RID: 92733 RVA: 0x00605228 File Offset: 0x00603428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UISort(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.UISort);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A3E RID: 92734 RVA: 0x0060527C File Offset: 0x0060347C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UISort(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int uisort;
			LuaObject.checkType(l, 2, out uisort);
			configDataJobConnectionInfo.UISort = uisort;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A3F RID: 92735 RVA: 0x006052D4 File Offset: 0x006034D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PropertyRating(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.PropertyRating);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A40 RID: 92736 RVA: 0x00605328 File Offset: 0x00603528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PropertyRating(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			string propertyRating;
			LuaObject.checkType(l, 2, out propertyRating);
			configDataJobConnectionInfo.PropertyRating = propertyRating;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A41 RID: 92737 RVA: 0x00605380 File Offset: 0x00603580
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsRecommend(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.IsRecommend);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A42 RID: 92738 RVA: 0x006053D4 File Offset: 0x006035D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsRecommend(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			bool isRecommend;
			LuaObject.checkType(l, 2, out isRecommend);
			configDataJobConnectionInfo.IsRecommend = isRecommend;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A43 RID: 92739 RVA: 0x0060542C File Offset: 0x0060362C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Model);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A44 RID: 92740 RVA: 0x00605480 File Offset: 0x00603680
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Model(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			string model;
			LuaObject.checkType(l, 2, out model);
			configDataJobConnectionInfo.Model = model;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A45 RID: 92741 RVA: 0x006054D8 File Offset: 0x006036D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CombatModel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.CombatModel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A46 RID: 92742 RVA: 0x0060552C File Offset: 0x0060372C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CombatModel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			string combatModel;
			LuaObject.checkType(l, 2, out combatModel);
			configDataJobConnectionInfo.CombatModel = combatModel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A47 RID: 92743 RVA: 0x00605584 File Offset: 0x00603784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReplaceAnims(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.ReplaceAnims);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A48 RID: 92744 RVA: 0x006055D8 File Offset: 0x006037D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A49 RID: 92745 RVA: 0x0060562C File Offset: 0x0060382C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int modelScale;
			LuaObject.checkType(l, 2, out modelScale);
			configDataJobConnectionInfo.ModelScale = modelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A4A RID: 92746 RVA: 0x00605684 File Offset: 0x00603884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BF_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.BF_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A4B RID: 92747 RVA: 0x006056D8 File Offset: 0x006038D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BF_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int bf_ModelScale;
			LuaObject.checkType(l, 2, out bf_ModelScale);
			configDataJobConnectionInfo.BF_ModelScale = bf_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A4C RID: 92748 RVA: 0x00605730 File Offset: 0x00603930
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.UI_ModelScale);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A4D RID: 92749 RVA: 0x00605784 File Offset: 0x00603984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UI_ModelScale(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int ui_ModelScale;
			LuaObject.checkType(l, 2, out ui_ModelScale);
			configDataJobConnectionInfo.UI_ModelScale = ui_ModelScale;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A4E RID: 92750 RVA: 0x006057DC File Offset: 0x006039DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.UI_ModelOffsetX);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A4F RID: 92751 RVA: 0x00605830 File Offset: 0x00603A30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelOffsetX(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetX;
			LuaObject.checkType(l, 2, out ui_ModelOffsetX);
			configDataJobConnectionInfo.UI_ModelOffsetX = ui_ModelOffsetX;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A50 RID: 92752 RVA: 0x00605888 File Offset: 0x00603A88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.UI_ModelOffsetY);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A51 RID: 92753 RVA: 0x006058DC File Offset: 0x00603ADC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UI_ModelOffsetY(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int ui_ModelOffsetY;
			LuaObject.checkType(l, 2, out ui_ModelOffsetY);
			configDataJobConnectionInfo.UI_ModelOffsetY = ui_ModelOffsetY;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A52 RID: 92754 RVA: 0x00605934 File Offset: 0x00603B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Radius(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Radius);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A53 RID: 92755 RVA: 0x00605988 File Offset: 0x00603B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Radius(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int radius;
			LuaObject.checkType(l, 2, out radius);
			configDataJobConnectionInfo.Radius = radius;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A54 RID: 92756 RVA: 0x006059E0 File Offset: 0x00603BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Height(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Height);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A55 RID: 92757 RVA: 0x00605A34 File Offset: 0x00603C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Height(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int height;
			LuaObject.checkType(l, 2, out height);
			configDataJobConnectionInfo.Height = height;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A56 RID: 92758 RVA: 0x00605A8C File Offset: 0x00603C8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FootHeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.FootHeight);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A57 RID: 92759 RVA: 0x00605AE0 File Offset: 0x00603CE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FootHeight(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			int footHeight;
			LuaObject.checkType(l, 2, out footHeight);
			configDataJobConnectionInfo.FootHeight = footHeight;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A58 RID: 92760 RVA: 0x00605B38 File Offset: 0x00603D38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreJobConnectionList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.PreJobConnectionList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A59 RID: 92761 RVA: 0x00605B8C File Offset: 0x00603D8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_JobUnlockConditioList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.JobUnlockConditioList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A5A RID: 92762 RVA: 0x00605BE0 File Offset: 0x00603DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsJobOpen(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.IsJobOpen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A5B RID: 92763 RVA: 0x00605C34 File Offset: 0x00603E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsJobOpen(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			bool isJobOpen;
			LuaObject.checkType(l, 2, out isJobOpen);
			configDataJobConnectionInfo.IsJobOpen = isJobOpen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A5C RID: 92764 RVA: 0x00605C8C File Offset: 0x00603E8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Skins_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataJobConnectionInfo configDataJobConnectionInfo = (ConfigDataJobConnectionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataJobConnectionInfo.Skins_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016A5D RID: 92765 RVA: 0x00605CE0 File Offset: 0x00603EE0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataJobConnectionInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.GetTalentSkillInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.IsJobLevelMax);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1);
		string name = "m_jobInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_m_jobInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_m_jobInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache3, true);
		string name2 = "m_jobLevelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_m_jobLevelInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_m_jobLevelInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache5, true);
		string name3 = "m_unlockConditions";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_m_unlockConditions);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_m_unlockConditions);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache7, true);
		string name4 = "m_preJobConnectionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_m_preJobConnectionInfos);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_m_preJobConnectionInfos);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache9, true);
		string name5 = "m_talentSkillInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_m_talentSkillInfos);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_m_talentSkillInfos);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheB, true);
		string name6 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_ID);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_ID);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheD, true);
		string name7 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Desc);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_Desc);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cacheF, true);
		string name8 = "DescStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_DescStrKey);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_DescStrKey);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache11, true);
		string name9 = "Name_Eng";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Name_Eng);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_Name_Eng);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache13, true);
		string name10 = "Job_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Job_ID);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_Job_ID);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache15, true);
		string name11 = "JobLevels_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_JobLevels_ID);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache16, null, true);
		string name12 = "TalentSkill_IDs";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_TalentSkill_IDs);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache17, null, true);
		string name13 = "UISort";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_UISort);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_UISort);
		}
		LuaObject.addMember(l, name13, get11, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache19, true);
		string name14 = "PropertyRating";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_PropertyRating);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_PropertyRating);
		}
		LuaObject.addMember(l, name14, get12, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1B, true);
		string name15 = "IsRecommend";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_IsRecommend);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_IsRecommend);
		}
		LuaObject.addMember(l, name15, get13, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1D, true);
		string name16 = "Model";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Model);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_Model);
		}
		LuaObject.addMember(l, name16, get14, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache1F, true);
		string name17 = "CombatModel";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_CombatModel);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_CombatModel);
		}
		LuaObject.addMember(l, name17, get15, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache21, true);
		string name18 = "ReplaceAnims";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_ReplaceAnims);
		}
		LuaObject.addMember(l, name18, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache22, null, true);
		string name19 = "ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_ModelScale);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache23;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_ModelScale);
		}
		LuaObject.addMember(l, name19, get16, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache24, true);
		string name20 = "BF_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_BF_ModelScale);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_BF_ModelScale);
		}
		LuaObject.addMember(l, name20, get17, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache26, true);
		string name21 = "UI_ModelScale";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_UI_ModelScale);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_UI_ModelScale);
		}
		LuaObject.addMember(l, name21, get18, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache28, true);
		string name22 = "UI_ModelOffsetX";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_UI_ModelOffsetX);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_UI_ModelOffsetX);
		}
		LuaObject.addMember(l, name22, get19, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2A, true);
		string name23 = "UI_ModelOffsetY";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_UI_ModelOffsetY);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_UI_ModelOffsetY);
		}
		LuaObject.addMember(l, name23, get20, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2C, true);
		string name24 = "Radius";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Radius);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_Radius);
		}
		LuaObject.addMember(l, name24, get21, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2E, true);
		string name25 = "Height";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Height);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_Height);
		}
		LuaObject.addMember(l, name25, get22, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache30, true);
		string name26 = "FootHeight";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_FootHeight);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_FootHeight);
		}
		LuaObject.addMember(l, name26, get23, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache32, true);
		string name27 = "PreJobConnectionList";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_PreJobConnectionList);
		}
		LuaObject.addMember(l, name27, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache33, null, true);
		string name28 = "JobUnlockConditioList";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_JobUnlockConditioList);
		}
		LuaObject.addMember(l, name28, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache34, null, true);
		string name29 = "IsJobOpen";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_IsJobOpen);
		}
		LuaCSFunction get24 = Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache35;
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.set_IsJobOpen);
		}
		LuaObject.addMember(l, name29, get24, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache36, true);
		string name30 = "Skins_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.get_Skins_ID);
		}
		LuaObject.addMember(l, name30, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache37, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataJobConnectionInfo.<>f__mg$cache38, typeof(ConfigDataJobConnectionInfo));
	}

	// Token: 0x0400D14E RID: 53582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D14F RID: 53583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D150 RID: 53584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D151 RID: 53585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D152 RID: 53586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D153 RID: 53587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D154 RID: 53588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D155 RID: 53589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D156 RID: 53590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D157 RID: 53591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D158 RID: 53592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D159 RID: 53593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D15A RID: 53594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D15B RID: 53595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D15C RID: 53596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D15D RID: 53597
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D15E RID: 53598
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D15F RID: 53599
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D160 RID: 53600
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D161 RID: 53601
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D162 RID: 53602
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D163 RID: 53603
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D164 RID: 53604
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D165 RID: 53605
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D166 RID: 53606
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D167 RID: 53607
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D168 RID: 53608
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D169 RID: 53609
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D16A RID: 53610
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D16B RID: 53611
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D16C RID: 53612
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400D16D RID: 53613
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400D16E RID: 53614
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400D16F RID: 53615
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400D170 RID: 53616
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400D171 RID: 53617
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400D172 RID: 53618
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400D173 RID: 53619
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400D174 RID: 53620
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400D175 RID: 53621
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400D176 RID: 53622
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400D177 RID: 53623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400D178 RID: 53624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400D179 RID: 53625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400D17A RID: 53626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400D17B RID: 53627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400D17C RID: 53628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400D17D RID: 53629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400D17E RID: 53630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400D17F RID: 53631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400D180 RID: 53632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400D181 RID: 53633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400D182 RID: 53634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400D183 RID: 53635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400D184 RID: 53636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400D185 RID: 53637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400D186 RID: 53638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;
}
