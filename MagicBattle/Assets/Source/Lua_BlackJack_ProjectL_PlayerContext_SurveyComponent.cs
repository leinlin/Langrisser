using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012E3 RID: 4835
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent : LuaObject
{
	// Token: 0x0601A062 RID: 106594 RVA: 0x007A2978 File Offset: 0x007A0B78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent o = new SurveyComponent();
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

	// Token: 0x0601A063 RID: 106595 RVA: 0x007A29C0 File Offset: 0x007A0BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A064 RID: 106596 RVA: 0x007A2A0C File Offset: 0x007A0C0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A065 RID: 106597 RVA: 0x007A2A58 File Offset: 0x007A0C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A066 RID: 106598 RVA: 0x007A2AA4 File Offset: 0x007A0CA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeSerialize(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			DSSurveyNtf msg;
			LuaObject.checkType<DSSurveyNtf>(l, 2, out msg);
			surveyComponent.DeSerialize(msg);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A067 RID: 106599 RVA: 0x007A2AFC File Offset: 0x007A0CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			ushort dsversion = surveyComponent.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A068 RID: 106600 RVA: 0x007A2B50 File Offset: 0x007A0D50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			string s = surveyComponent.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A069 RID: 106601 RVA: 0x007A2BAC File Offset: 0x007A0DAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A06A RID: 106602 RVA: 0x007A2C00 File Offset: 0x007A0E00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A06B RID: 106603 RVA: 0x007A2C54 File Offset: 0x007A0E54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A06C RID: 106604 RVA: 0x007A2CA8 File Offset: 0x007A0EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			surveyComponent.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A06D RID: 106605 RVA: 0x007A2D04 File Offset: 0x007A0F04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A06E RID: 106606 RVA: 0x007A2D58 File Offset: 0x007A0F58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FlushSurvey(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			surveyComponent.m_luaExportHelper.__callBase_FlushSurvey();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A06F RID: 106607 RVA: 0x007A2DAC File Offset: 0x007A0FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			Survey survey;
			LuaObject.checkType<Survey>(l, 2, out survey);
			SurveyStatus e = surveyComponent.m_luaExportHelper.__callBase_GetSurveyStatus(survey);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A070 RID: 106608 RVA: 0x007A2E14 File Offset: 0x007A1014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			SurveyStatus status;
			LuaObject.checkEnum<SurveyStatus>(l, 2, out status);
			surveyComponent.m_luaExportHelper.__callBase_SetSurveyStatus(status);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A071 RID: 106609 RVA: 0x007A2E70 File Offset: 0x007A1070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetCurrentSurvey(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			Survey survey;
			LuaObject.checkType<Survey>(l, 2, out survey);
			surveyComponent.m_luaExportHelper.__callBase_SetCurrentSurvey(survey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601A072 RID: 106610 RVA: 0x007A2ECC File Offset: 0x007A10CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetCurrentSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			SurveyStatus e = surveyComponent.m_luaExportHelper.__callBase_GetCurrentSurveyStatus();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)e);
			result = 2;
		}
		catch (Exception e2)
		{
			result = LuaObject.error(l, e2);
		}
		return result;
	}

	// Token: 0x0601A073 RID: 106611 RVA: 0x007A2F28 File Offset: 0x007A1128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGainSurveyReward(IntPtr l)
	{
		int result;
		try
		{
			SurveyComponent surveyComponent = (SurveyComponent)LuaObject.checkSelf(l);
			int i = surveyComponent.m_luaExportHelper.__callBase_CanGainSurveyReward();
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

	// Token: 0x0601A074 RID: 106612 RVA: 0x007A2F84 File Offset: 0x007A1184
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.SurveyComponent");
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.DeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_FlushSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_GetSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_SetSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_SetCurrentSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_GetCurrentSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.__callBase_CanGainSurveyReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_SurveyComponent.<>f__mg$cache11, typeof(SurveyComponent), typeof(SurveyComponentCommon));
	}

	// Token: 0x0401047E RID: 66686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401047F RID: 66687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04010480 RID: 66688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04010481 RID: 66689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04010482 RID: 66690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04010483 RID: 66691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04010484 RID: 66692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04010485 RID: 66693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04010486 RID: 66694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04010487 RID: 66695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04010488 RID: 66696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04010489 RID: 66697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401048A RID: 66698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401048B RID: 66699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401048C RID: 66700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401048D RID: 66701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401048E RID: 66702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401048F RID: 66703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;
}
