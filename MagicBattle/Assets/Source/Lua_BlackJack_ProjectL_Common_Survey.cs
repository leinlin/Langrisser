using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001281 RID: 4737
[Preserve]
public class Lua_BlackJack_ProjectL_Common_Survey : LuaObject
{
	// Token: 0x06018AC0 RID: 101056 RVA: 0x006F6F88 File Offset: 0x006F5188
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			Survey o = new Survey();
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

	// Token: 0x06018AC1 RID: 101057 RVA: 0x006F6FD0 File Offset: 0x006F51D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBSurvey_s(IntPtr l)
	{
		int result;
		try
		{
			Survey survey;
			LuaObject.checkType<Survey>(l, 1, out survey);
			ProSurvey o = Survey.ToPBSurvey(survey);
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

	// Token: 0x06018AC2 RID: 101058 RVA: 0x006F7024 File Offset: 0x006F5224
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToSurvey_s(IntPtr l)
	{
		int result;
		try
		{
			ProSurvey pbSurvey;
			LuaObject.checkType<ProSurvey>(l, 1, out pbSurvey);
			Survey o = Survey.ToSurvey(pbSurvey);
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

	// Token: 0x06018AC3 RID: 101059 RVA: 0x006F7078 File Offset: 0x006F5278
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, survey.Id);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AC4 RID: 101060 RVA: 0x006F70CC File Offset: 0x006F52CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Id(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			survey.Id = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AC5 RID: 101061 RVA: 0x006F7124 File Offset: 0x006F5324
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Status(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)survey.Status);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AC6 RID: 101062 RVA: 0x006F7178 File Offset: 0x006F5378
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Status(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			SurveyStatus status;
			LuaObject.checkEnum<SurveyStatus>(l, 2, out status);
			survey.Status = status;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AC7 RID: 101063 RVA: 0x006F71D0 File Offset: 0x006F53D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StartTime(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, survey.StartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AC8 RID: 101064 RVA: 0x006F7228 File Offset: 0x006F5428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_StartTime(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			DateTime startTime;
			LuaObject.checkValueType<DateTime>(l, 2, out startTime);
			survey.StartTime = startTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AC9 RID: 101065 RVA: 0x006F7280 File Offset: 0x006F5480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_EndTime(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, survey.EndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ACA RID: 101066 RVA: 0x006F72D8 File Offset: 0x006F54D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EndTime(IntPtr l)
	{
		int result;
		try
		{
			Survey survey = (Survey)LuaObject.checkSelf(l);
			DateTime endTime;
			LuaObject.checkValueType<DateTime>(l, 2, out endTime);
			survey.EndTime = endTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018ACB RID: 101067 RVA: 0x006F7330 File Offset: 0x006F5530
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.Survey");
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.ToPBSurvey_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.ToSurvey_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache1);
		string name = "Id";
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.get_Id);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.set_Id);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache3, true);
		string name2 = "Status";
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.get_Status);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.set_Status);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache5, true);
		string name3 = "StartTime";
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.get_StartTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.set_StartTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache7, true);
		string name4 = "EndTime";
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.get_EndTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.set_EndTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cache9, true);
		if (Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_Survey.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_Survey.<>f__mg$cacheA, typeof(Survey));
	}

	// Token: 0x0400EFA0 RID: 61344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EFA1 RID: 61345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EFA2 RID: 61346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EFA3 RID: 61347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EFA4 RID: 61348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EFA5 RID: 61349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EFA6 RID: 61350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EFA7 RID: 61351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EFA8 RID: 61352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EFA9 RID: 61353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EFAA RID: 61354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
