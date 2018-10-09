using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001153 RID: 4435
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo : LuaObject
{
	// Token: 0x06016899 RID: 92313 RVA: 0x005F9598 File Offset: 0x005F7798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo o = new ConfigDataHeroAssistantTaskInfo();
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

	// Token: 0x0601689A RID: 92314 RVA: 0x005F95E0 File Offset: 0x005F77E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_schedule(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.m_schedule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601689B RID: 92315 RVA: 0x005F9634 File Offset: 0x005F7834
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_schedule(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			ConfigDataHeroAssistantTaskScheduleInfo schedule;
			LuaObject.checkType<ConfigDataHeroAssistantTaskScheduleInfo>(l, 2, out schedule);
			configDataHeroAssistantTaskInfo.m_schedule = schedule;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601689C RID: 92316 RVA: 0x005F968C File Offset: 0x005F788C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_general(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.m_general);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601689D RID: 92317 RVA: 0x005F96E0 File Offset: 0x005F78E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_general(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			ConfigDataHeroAssistantTaskGeneralInfo general;
			LuaObject.checkType<ConfigDataHeroAssistantTaskGeneralInfo>(l, 2, out general);
			configDataHeroAssistantTaskInfo.m_general = general;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601689E RID: 92318 RVA: 0x005F9738 File Offset: 0x005F7938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardCompleteRate(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.m_rewardCompleteRate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601689F RID: 92319 RVA: 0x005F978C File Offset: 0x005F798C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardCompleteRate(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			List<int> rewardCompleteRate;
			LuaObject.checkType<List<int>>(l, 2, out rewardCompleteRate);
			configDataHeroAssistantTaskInfo.m_rewardCompleteRate = rewardCompleteRate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A0 RID: 92320 RVA: 0x005F97E4 File Offset: 0x005F79E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardDropId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.m_rewardDropId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A1 RID: 92321 RVA: 0x005F9838 File Offset: 0x005F7A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardDropId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			List<int> rewardDropId;
			LuaObject.checkType<List<int>>(l, 2, out rewardDropId);
			configDataHeroAssistantTaskInfo.m_rewardDropId = rewardDropId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A2 RID: 92322 RVA: 0x005F9890 File Offset: 0x005F7A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.m_rewardWorkSeconds);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A3 RID: 92323 RVA: 0x005F98E4 File Offset: 0x005F7AE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewardWorkSeconds(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			List<int> rewardWorkSeconds;
			LuaObject.checkType<List<int>>(l, 2, out rewardWorkSeconds);
			configDataHeroAssistantTaskInfo.m_rewardWorkSeconds = rewardWorkSeconds;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A4 RID: 92324 RVA: 0x005F993C File Offset: 0x005F7B3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardDropCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.m_rewardDropCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A5 RID: 92325 RVA: 0x005F9990 File Offset: 0x005F7B90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rewardDropCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			List<int> rewardDropCount;
			LuaObject.checkType<List<int>>(l, 2, out rewardDropCount);
			configDataHeroAssistantTaskInfo.m_rewardDropCount = rewardDropCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A6 RID: 92326 RVA: 0x005F99E8 File Offset: 0x005F7BE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A7 RID: 92327 RVA: 0x005F9A3C File Offset: 0x005F7C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroAssistantTaskInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A8 RID: 92328 RVA: 0x005F9A94 File Offset: 0x005F7C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168A9 RID: 92329 RVA: 0x005F9AE8 File Offset: 0x005F7CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroAssistantTaskInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168AA RID: 92330 RVA: 0x005F9B40 File Offset: 0x005F7D40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Resource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.Resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168AB RID: 92331 RVA: 0x005F9B94 File Offset: 0x005F7D94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RequiredUserLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.RequiredUserLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168AC RID: 92332 RVA: 0x005F9BE8 File Offset: 0x005F7DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RequiredUserLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			int requiredUserLevel;
			LuaObject.checkType(l, 2, out requiredUserLevel);
			configDataHeroAssistantTaskInfo.RequiredUserLevel = requiredUserLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168AD RID: 92333 RVA: 0x005F9C40 File Offset: 0x005F7E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CompletePoints(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.CompletePoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168AE RID: 92334 RVA: 0x005F9C94 File Offset: 0x005F7E94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CompletePoints(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			int completePoints;
			LuaObject.checkType(l, 2, out completePoints);
			configDataHeroAssistantTaskInfo.CompletePoints = completePoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168AF RID: 92335 RVA: 0x005F9CEC File Offset: 0x005F7EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Rewards(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroAssistantTaskInfo configDataHeroAssistantTaskInfo = (ConfigDataHeroAssistantTaskInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroAssistantTaskInfo.Rewards);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060168B0 RID: 92336 RVA: 0x005F9D40 File Offset: 0x005F7F40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroAssistantTaskInfo");
		string name = "m_schedule";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_m_schedule);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_m_schedule);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache1, true);
		string name2 = "m_general";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_m_general);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_m_general);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache3, true);
		string name3 = "m_rewardCompleteRate";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_m_rewardCompleteRate);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_m_rewardCompleteRate);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache5, true);
		string name4 = "m_rewardDropId";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_m_rewardDropId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_m_rewardDropId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache7, true);
		string name5 = "m_rewardWorkSeconds";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_m_rewardWorkSeconds);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_m_rewardWorkSeconds);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache9, true);
		string name6 = "m_rewardDropCount";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_m_rewardDropCount);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_m_rewardDropCount);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheB, true);
		string name7 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_ID);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_ID);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheD, true);
		string name8 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_Name);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_Name);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cacheF, true);
		string name9 = "Resource";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_Resource);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache10, null, true);
		string name10 = "RequiredUserLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_RequiredUserLevel);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache11;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_RequiredUserLevel);
		}
		LuaObject.addMember(l, name10, get9, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache12, true);
		string name11 = "CompletePoints";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_CompletePoints);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.set_CompletePoints);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache14, true);
		string name12 = "Rewards";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.get_Rewards);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache15, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroAssistantTaskInfo.<>f__mg$cache16, typeof(ConfigDataHeroAssistantTaskInfo));
	}

	// Token: 0x0400CFD5 RID: 53205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CFD6 RID: 53206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CFD7 RID: 53207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CFD8 RID: 53208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CFD9 RID: 53209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CFDA RID: 53210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CFDB RID: 53211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CFDC RID: 53212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CFDD RID: 53213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CFDE RID: 53214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CFDF RID: 53215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CFE0 RID: 53216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CFE1 RID: 53217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CFE2 RID: 53218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CFE3 RID: 53219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CFE4 RID: 53220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CFE5 RID: 53221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CFE6 RID: 53222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CFE7 RID: 53223
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CFE8 RID: 53224
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CFE9 RID: 53225
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CFEA RID: 53226
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CFEB RID: 53227
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;
}
