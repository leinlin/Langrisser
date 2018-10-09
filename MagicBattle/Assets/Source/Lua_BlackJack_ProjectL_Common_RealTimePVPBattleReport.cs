using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200126D RID: 4717
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport : LuaObject
{
	// Token: 0x0601893C RID: 100668 RVA: 0x006EBE60 File Offset: 0x006EA060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				RealTimePVPBattleReport o = new RealTimePVPBattleReport();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				BattleReport battleReport;
				LuaObject.checkType<BattleReport>(l, 2, out battleReport);
				RealTimePVPBattleReport o = new RealTimePVPBattleReport(battleReport);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601893D RID: 100669 RVA: 0x006EBEF8 File Offset: 0x006EA0F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeepCopy(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			RealTimePVPBattleReport o = realTimePVPBattleReport.DeepCopy();
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

	// Token: 0x0601893E RID: 100670 RVA: 0x006EBF4C File Offset: 0x006EA14C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPro(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport report = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			ProRealTimePVPBattleReport o = report.ToPro();
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

	// Token: 0x0601893F RID: 100671 RVA: 0x006EBFA0 File Offset: 0x006EA1A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerDatas(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReport.PlayerDatas);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018940 RID: 100672 RVA: 0x006EBFF4 File Offset: 0x006EA1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerDatas(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			RealTimePVPBattleReportPlayerData[] playerDatas;
			LuaObject.checkArray<RealTimePVPBattleReportPlayerData>(l, 2, out playerDatas);
			realTimePVPBattleReport.PlayerDatas = playerDatas;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018941 RID: 100673 RVA: 0x006EC04C File Offset: 0x006EA24C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Win(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReport.Win);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018942 RID: 100674 RVA: 0x006EC0A0 File Offset: 0x006EA2A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Win(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			bool win;
			LuaObject.checkType(l, 2, out win);
			realTimePVPBattleReport.Win = win;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018943 RID: 100675 RVA: 0x006EC0F8 File Offset: 0x006EA2F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsCancel(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReport.IsCancel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018944 RID: 100676 RVA: 0x006EC14C File Offset: 0x006EA34C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsCancel(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			bool isCancel;
			LuaObject.checkType(l, 2, out isCancel);
			realTimePVPBattleReport.IsCancel = isCancel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018945 RID: 100677 RVA: 0x006EC1A4 File Offset: 0x006EA3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReportType(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)realTimePVPBattleReport.ReportType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018946 RID: 100678 RVA: 0x006EC1F8 File Offset: 0x006EA3F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ReportType(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			RealTimePVPBattleReportType reportType;
			LuaObject.checkEnum<RealTimePVPBattleReportType>(l, 2, out reportType);
			realTimePVPBattleReport.ReportType = reportType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018947 RID: 100679 RVA: 0x006EC250 File Offset: 0x006EA450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BPRule(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)realTimePVPBattleReport.BPRule);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018948 RID: 100680 RVA: 0x006EC2A4 File Offset: 0x006EA4A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BPRule(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			BattleRoomBPRule bprule;
			LuaObject.checkEnum<BattleRoomBPRule>(l, 2, out bprule);
			realTimePVPBattleReport.BPRule = bprule;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018949 RID: 100681 RVA: 0x006EC2FC File Offset: 0x006EA4FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, realTimePVPBattleReport.CreateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601894A RID: 100682 RVA: 0x006EC354 File Offset: 0x006EA554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			RealTimePVPBattleReport realTimePVPBattleReport = (RealTimePVPBattleReport)LuaObject.checkSelf(l);
			DateTime createTime;
			LuaObject.checkValueType<DateTime>(l, 2, out createTime);
			realTimePVPBattleReport.CreateTime = createTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601894B RID: 100683 RVA: 0x006EC3AC File Offset: 0x006EA5AC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RealTimePVPBattleReport");
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.DeepCopy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.ToPro);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache1);
		string name = "PlayerDatas";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.get_PlayerDatas);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.set_PlayerDatas);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache3, true);
		string name2 = "Win";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.get_Win);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.set_Win);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache5, true);
		string name3 = "IsCancel";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.get_IsCancel);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.set_IsCancel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache7, true);
		string name4 = "ReportType";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.get_ReportType);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.set_ReportType);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cache9, true);
		string name5 = "BPRule";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.get_BPRule);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.set_BPRule);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheB, true);
		string name6 = "CreateTime";
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.get_CreateTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.set_CreateTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheD, true);
		if (Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RealTimePVPBattleReport.<>f__mg$cacheE, typeof(RealTimePVPBattleReport), typeof(BattleReport));
	}

	// Token: 0x0400EE44 RID: 60996
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EE45 RID: 60997
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EE46 RID: 60998
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EE47 RID: 60999
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EE48 RID: 61000
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EE49 RID: 61001
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EE4A RID: 61002
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EE4B RID: 61003
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EE4C RID: 61004
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EE4D RID: 61005
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EE4E RID: 61006
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EE4F RID: 61007
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EE50 RID: 61008
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EE51 RID: 61009
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EE52 RID: 61010
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
