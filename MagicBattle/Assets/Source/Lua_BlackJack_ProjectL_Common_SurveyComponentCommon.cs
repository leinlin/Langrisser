using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001282 RID: 4738
[Preserve]
public class Lua_BlackJack_ProjectL_Common_SurveyComponentCommon : LuaObject
{
	// Token: 0x06018ACD RID: 101069 RVA: 0x006F74DC File Offset: 0x006F56DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon o = new SurveyComponentCommon();
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

	// Token: 0x06018ACE RID: 101070 RVA: 0x006F7524 File Offset: 0x006F5724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			string name = surveyComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ACF RID: 101071 RVA: 0x006F7578 File Offset: 0x006F5778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			surveyComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD0 RID: 101072 RVA: 0x006F75C4 File Offset: 0x006F57C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			surveyComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD1 RID: 101073 RVA: 0x006F7610 File Offset: 0x006F5810
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			surveyComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD2 RID: 101074 RVA: 0x006F765C File Offset: 0x006F585C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			surveyComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD3 RID: 101075 RVA: 0x006F76B4 File Offset: 0x006F58B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			surveyComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD4 RID: 101076 RVA: 0x006F7700 File Offset: 0x006F5900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			SurveyStatus surveyStatus;
			LuaObject.checkEnum<SurveyStatus>(l, 2, out surveyStatus);
			surveyComponentCommon.SetSurveyStatus(surveyStatus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD5 RID: 101077 RVA: 0x006F7758 File Offset: 0x006F5958
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCurrentSurvey(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			Survey currentSurvey;
			LuaObject.checkType<Survey>(l, 2, out currentSurvey);
			surveyComponentCommon.SetCurrentSurvey(currentSurvey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD6 RID: 101078 RVA: 0x006F77B0 File Offset: 0x006F59B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			SurveyStatus currentSurveyStatus = surveyComponentCommon.GetCurrentSurveyStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)currentSurveyStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD7 RID: 101079 RVA: 0x006F7804 File Offset: 0x006F5A04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainSurveyReward(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			int i = surveyComponentCommon.CanGainSurveyReward();
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

	// Token: 0x06018AD8 RID: 101080 RVA: 0x006F7858 File Offset: 0x006F5A58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FlushSurvey(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			surveyComponentCommon.m_luaExportHelper.FlushSurvey();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AD9 RID: 101081 RVA: 0x006F78AC File Offset: 0x006F5AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			Survey survey;
			LuaObject.checkType<Survey>(l, 2, out survey);
			SurveyStatus surveyStatus = surveyComponentCommon.m_luaExportHelper.GetSurveyStatus(survey);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)surveyStatus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ADA RID: 101082 RVA: 0x006F7914 File Offset: 0x006F5B14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surveyComponentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ADB RID: 101083 RVA: 0x006F796C File Offset: 0x006F5B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			surveyComponentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ADC RID: 101084 RVA: 0x006F79C8 File Offset: 0x006F5BC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surveyComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ADD RID: 101085 RVA: 0x006F7A20 File Offset: 0x006F5C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			surveyComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ADE RID: 101086 RVA: 0x006F7A7C File Offset: 0x006F5C7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_survey(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surveyComponentCommon.m_luaExportHelper.m_survey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ADF RID: 101087 RVA: 0x006F7AD4 File Offset: 0x006F5CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_survey(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			DataSectionSurvey survey;
			LuaObject.checkType<DataSectionSurvey>(l, 2, out survey);
			surveyComponentCommon.m_luaExportHelper.m_survey = survey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE0 RID: 101088 RVA: 0x006F7B30 File Offset: 0x006F5D30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surveyComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE1 RID: 101089 RVA: 0x006F7B88 File Offset: 0x006F5D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			surveyComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE2 RID: 101090 RVA: 0x006F7BE4 File Offset: 0x006F5DE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, surveyComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE3 RID: 101091 RVA: 0x006F7C38 File Offset: 0x006F5E38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponentCommon surveyComponentCommon = (SurveyComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			surveyComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AE4 RID: 101092 RVA: 0x006F7C90 File Offset: 0x006F5E90
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.SurveyComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.SetSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.SetCurrentSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.GetCurrentSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.CanGainSurveyReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.FlushSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.GetSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheB);
		string name = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.get_m_bag);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheD, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cacheF, true);
		string name3 = "m_survey";
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.get_m_survey);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.set_m_survey);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache11, true);
		string name4 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache13, true);
		string name5 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.get_Owner);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache15, true);
		if (Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_SurveyComponentCommon.<>f__mg$cache16, typeof(SurveyComponentCommon));
	}

	// Token: 0x0400EFAB RID: 61355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EFAC RID: 61356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EFAD RID: 61357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EFAE RID: 61358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EFAF RID: 61359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EFB0 RID: 61360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EFB1 RID: 61361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EFB2 RID: 61362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EFB3 RID: 61363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EFB4 RID: 61364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EFB5 RID: 61365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EFB6 RID: 61366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EFB7 RID: 61367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EFB8 RID: 61368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EFB9 RID: 61369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EFBA RID: 61370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EFBB RID: 61371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EFBC RID: 61372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EFBD RID: 61373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EFBE RID: 61374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EFBF RID: 61375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EFC0 RID: 61376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EFC1 RID: 61377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
