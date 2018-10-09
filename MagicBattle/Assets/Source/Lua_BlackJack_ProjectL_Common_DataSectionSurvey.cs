using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001213 RID: 4627
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionSurvey : LuaObject
{
	// Token: 0x0601805E RID: 98398 RVA: 0x006A98D0 File Offset: 0x006A7AD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey o = new DataSectionSurvey();
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

	// Token: 0x0601805F RID: 98399 RVA: 0x006A9918 File Offset: 0x006A7B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey dataSectionSurvey = (DataSectionSurvey)LuaObject.checkSelf(l);
			SurveyStatus currentSurveyStatus = dataSectionSurvey.GetCurrentSurveyStatus();
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

	// Token: 0x06018060 RID: 98400 RVA: 0x006A996C File Offset: 0x006A7B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSurveyStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey dataSectionSurvey = (DataSectionSurvey)LuaObject.checkSelf(l);
			SurveyStatus surveyStatus;
			LuaObject.checkEnum<SurveyStatus>(l, 2, out surveyStatus);
			dataSectionSurvey.SetSurveyStatus(surveyStatus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018061 RID: 98401 RVA: 0x006A99C4 File Offset: 0x006A7BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurrentSurvey(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey dataSectionSurvey = (DataSectionSurvey)LuaObject.checkSelf(l);
			Survey currentSurvey;
			LuaObject.checkType<Survey>(l, 2, out currentSurvey);
			dataSectionSurvey.SetCurrentSurvey(currentSurvey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018062 RID: 98402 RVA: 0x006A9A1C File Offset: 0x006A7C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitCurrentSurvey(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey dataSectionSurvey = (DataSectionSurvey)LuaObject.checkSelf(l);
			Survey survey;
			LuaObject.checkType<Survey>(l, 2, out survey);
			dataSectionSurvey.InitCurrentSurvey(survey);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018063 RID: 98403 RVA: 0x006A9A74 File Offset: 0x006A7C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey dataSectionSurvey = (DataSectionSurvey)LuaObject.checkSelf(l);
			object o = dataSectionSurvey.SerializeToClient();
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

	// Token: 0x06018064 RID: 98404 RVA: 0x006A9AC8 File Offset: 0x006A7CC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurrentSurvey(IntPtr l)
	{
		int result;
		try
		{
			DataSectionSurvey dataSectionSurvey = (DataSectionSurvey)LuaObject.checkSelf(l);
			Survey currentSurvey = dataSectionSurvey.GetCurrentSurvey();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, currentSurvey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018065 RID: 98405 RVA: 0x006A9B1C File Offset: 0x006A7D1C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionSurvey");
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.GetCurrentSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.SetSurveyStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.SetCurrentSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.InitCurrentSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.GetCurrentSurvey);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionSurvey.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionSurvey.<>f__mg$cache6, typeof(DataSectionSurvey), typeof(DataSection));
	}

	// Token: 0x0400E61A RID: 58906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E61B RID: 58907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E61C RID: 58908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E61D RID: 58909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E61E RID: 58910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E61F RID: 58911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E620 RID: 58912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
