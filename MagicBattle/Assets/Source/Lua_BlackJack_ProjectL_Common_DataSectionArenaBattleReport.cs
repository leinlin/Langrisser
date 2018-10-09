using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011F5 RID: 4597
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport : LuaObject
{
	// Token: 0x06017D69 RID: 97641 RVA: 0x00693E98 File Offset: 0x00692098
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport o = new DataSectionArenaBattleReport();
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

	// Token: 0x06017D6A RID: 97642 RVA: 0x00693EE0 File Offset: 0x006920E0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			dataSectionArenaBattleReport.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D6B RID: 97643 RVA: 0x00693F2C File Offset: 0x0069212C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			ArenaBattleReport report;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out report);
			dataSectionArenaBattleReport.InitArenaBattleReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D6C RID: 97644 RVA: 0x00693F84 File Offset: 0x00692184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			int index;
			LuaObject.checkType(l, 2, out index);
			ArenaBattleReport report;
			LuaObject.checkType<ArenaBattleReport>(l, 3, out report);
			dataSectionArenaBattleReport.SetArenaBattleReport(index, report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D6D RID: 97645 RVA: 0x00693FE8 File Offset: 0x006921E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			ArenaBattleReport report;
			LuaObject.checkType<ArenaBattleReport>(l, 2, out report);
			dataSectionArenaBattleReport.AddArenaBattleReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D6E RID: 97646 RVA: 0x00694040 File Offset: 0x00692240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DirtyArenaBattleReport(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			ulong battleReportInstanceId;
			LuaObject.checkType(l, 2, out battleReportInstanceId);
			dataSectionArenaBattleReport.DirtyArenaBattleReport(battleReportInstanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D6F RID: 97647 RVA: 0x00694098 File Offset: 0x00692298
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllArenaBattleReports(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			List<ArenaBattleReport> allArenaBattleReports = dataSectionArenaBattleReport.GetAllArenaBattleReports();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allArenaBattleReports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D70 RID: 97648 RVA: 0x006940EC File Offset: 0x006922EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindArenaBattleReportByInstanceId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			ulong battleReportInstanceId;
			LuaObject.checkType(l, 2, out battleReportInstanceId);
			ArenaBattleReport o = dataSectionArenaBattleReport.FindArenaBattleReportByInstanceId(battleReportInstanceId);
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

	// Token: 0x06017D71 RID: 97649 RVA: 0x00694150 File Offset: 0x00692350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetNextBattleReportIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			byte nextBattleReportIndex;
			LuaObject.checkType(l, 2, out nextBattleReportIndex);
			dataSectionArenaBattleReport.SetNextBattleReportIndex(nextBattleReportIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D72 RID: 97650 RVA: 0x006941A8 File Offset: 0x006923A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextBattleReportIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionArenaBattleReport.NextBattleReportIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D73 RID: 97651 RVA: 0x006941FC File Offset: 0x006923FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextBattleReportIndex(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			byte nextBattleReportIndex;
			LuaObject.checkType(l, 2, out nextBattleReportIndex);
			dataSectionArenaBattleReport.NextBattleReportIndex = nextBattleReportIndex;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D74 RID: 97652 RVA: 0x00694254 File Offset: 0x00692454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BattleReportNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionArenaBattleReport.BattleReportNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D75 RID: 97653 RVA: 0x006942A8 File Offset: 0x006924A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ArenaBattleReportInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionArenaBattleReport.ArenaBattleReportInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D76 RID: 97654 RVA: 0x006942FC File Offset: 0x006924FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaBattleReportInfo(IntPtr l)
	{
		int result;
		try
		{
			DataSectionArenaBattleReport dataSectionArenaBattleReport = (DataSectionArenaBattleReport)LuaObject.checkSelf(l);
			ArenaBattleReportUpdateCache arenaBattleReportInfo;
			LuaObject.checkType<ArenaBattleReportUpdateCache>(l, 2, out arenaBattleReportInfo);
			dataSectionArenaBattleReport.ArenaBattleReportInfo = arenaBattleReportInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017D77 RID: 97655 RVA: 0x00694354 File Offset: 0x00692554
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionArenaBattleReport");
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.InitArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.SetArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.AddArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.DirtyArenaBattleReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.GetAllArenaBattleReports);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.FindArenaBattleReportByInstanceId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.SetNextBattleReportIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache7);
		string name = "NextBattleReportIndex";
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.get_NextBattleReportIndex);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.set_NextBattleReportIndex);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cache9, true);
		string name2 = "BattleReportNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.get_BattleReportNums);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheA, null, true);
		string name3 = "ArenaBattleReportInfo";
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.get_ArenaBattleReportInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.set_ArenaBattleReportInfo);
		}
		LuaObject.addMember(l, name3, get2, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheC, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionArenaBattleReport.<>f__mg$cacheD, typeof(DataSectionArenaBattleReport), typeof(DataSection));
	}

	// Token: 0x0400E361 RID: 58209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E362 RID: 58210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E363 RID: 58211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E364 RID: 58212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E365 RID: 58213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E366 RID: 58214
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E367 RID: 58215
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E368 RID: 58216
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E369 RID: 58217
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E36A RID: 58218
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E36B RID: 58219
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E36C RID: 58220
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E36D RID: 58221
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E36E RID: 58222
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
