using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200120D RID: 4621
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP : LuaObject
{
	// Token: 0x06017FCD RID: 98253 RVA: 0x006A5564 File Offset: 0x006A3764
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP o = new DataSectionRealTimePVP();
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

	// Token: 0x06017FCE RID: 98254 RVA: 0x006A55AC File Offset: 0x006A37AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			dataSectionRealTimePVP.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FCF RID: 98255 RVA: 0x006A55F8 File Offset: 0x006A37F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			object o = dataSectionRealTimePVP.SerializeToClient();
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

	// Token: 0x06017FD0 RID: 98256 RVA: 0x006A564C File Offset: 0x006A384C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int StartPromotion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			dataSectionRealTimePVP.StartPromotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD1 RID: 98257 RVA: 0x006A5698 File Offset: 0x006A3898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int EndPromotion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			dataSectionRealTimePVP.EndPromotion();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD2 RID: 98258 RVA: 0x006A56E4 File Offset: 0x006A38E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SavePromotionReport(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			RealTimePVPBattleReport report;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out report);
			dataSectionRealTimePVP.SavePromotionReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD3 RID: 98259 RVA: 0x006A573C File Offset: 0x006A393C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SaveReport(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			RealTimePVPBattleReport report;
			LuaObject.checkType<RealTimePVPBattleReport>(l, 2, out report);
			dataSectionRealTimePVP.SaveReport(report);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD4 RID: 98260 RVA: 0x006A5794 File Offset: 0x006A3994
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int StartNewSeason(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			dataSectionRealTimePVP.StartNewSeason();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD5 RID: 98261 RVA: 0x006A57E0 File Offset: 0x006A39E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AcquireWinsBonus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			int bonusId;
			LuaObject.checkType(l, 2, out bonusId);
			dataSectionRealTimePVP.AcquireWinsBonus(bonusId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD6 RID: 98262 RVA: 0x006A5838 File Offset: 0x006A3A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PromotionReports(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.PromotionReports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD7 RID: 98263 RVA: 0x006A588C File Offset: 0x006A3A8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PromotionReports(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LinkedList<RealTimePVPBattleReport> promotionReports;
			LuaObject.checkType<LinkedList<RealTimePVPBattleReport>>(l, 2, out promotionReports);
			dataSectionRealTimePVP.PromotionReports = promotionReports;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD8 RID: 98264 RVA: 0x006A58E4 File Offset: 0x006A3AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Reports(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.Reports);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FD9 RID: 98265 RVA: 0x006A5938 File Offset: 0x006A3B38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Reports(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LinkedList<RealTimePVPBattleReport> reports;
			LuaObject.checkType<LinkedList<RealTimePVPBattleReport>>(l, 2, out reports);
			dataSectionRealTimePVP.Reports = reports;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FDA RID: 98266 RVA: 0x006A5990 File Offset: 0x006A3B90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendlyMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.FriendlyMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FDB RID: 98267 RVA: 0x006A59E4 File Offset: 0x006A3BE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FriendlyMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			RealTimePVPMatchStats friendlyMatchStats;
			LuaObject.checkType<RealTimePVPMatchStats>(l, 2, out friendlyMatchStats);
			dataSectionRealTimePVP.FriendlyMatchStats = friendlyMatchStats;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FDC RID: 98268 RVA: 0x006A5A3C File Offset: 0x006A3C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LadderMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.LadderMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FDD RID: 98269 RVA: 0x006A5A90 File Offset: 0x006A3C90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LadderMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			RealTimePVPMatchStats ladderMatchStats;
			LuaObject.checkType<RealTimePVPMatchStats>(l, 2, out ladderMatchStats);
			dataSectionRealTimePVP.LadderMatchStats = ladderMatchStats;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FDE RID: 98270 RVA: 0x006A5AE8 File Offset: 0x006A3CE8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FriendlyCareerMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.FriendlyCareerMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FDF RID: 98271 RVA: 0x006A5B3C File Offset: 0x006A3D3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FriendlyCareerMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			RealTimePVPMatchStats friendlyCareerMatchStats;
			LuaObject.checkType<RealTimePVPMatchStats>(l, 2, out friendlyCareerMatchStats);
			dataSectionRealTimePVP.FriendlyCareerMatchStats = friendlyCareerMatchStats;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE0 RID: 98272 RVA: 0x006A5B94 File Offset: 0x006A3D94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LadderCareerMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.LadderCareerMatchStats);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE1 RID: 98273 RVA: 0x006A5BE8 File Offset: 0x006A3DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LadderCareerMatchStats(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			RealTimePVPMatchStats ladderCareerMatchStats;
			LuaObject.checkType<RealTimePVPMatchStats>(l, 2, out ladderCareerMatchStats);
			dataSectionRealTimePVP.LadderCareerMatchStats = ladderCareerMatchStats;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE2 RID: 98274 RVA: 0x006A5C40 File Offset: 0x006A3E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WinsBonusIdAcquired(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.WinsBonusIdAcquired);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE3 RID: 98275 RVA: 0x006A5C94 File Offset: 0x006A3E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_WinsBonusIdAcquired(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			List<int> winsBonusIdAcquired;
			LuaObject.checkType<List<int>>(l, 2, out winsBonusIdAcquired);
			dataSectionRealTimePVP.WinsBonusIdAcquired = winsBonusIdAcquired;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE4 RID: 98276 RVA: 0x006A5CEC File Offset: 0x006A3EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_IsPromotion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionRealTimePVP.IsPromotion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE5 RID: 98277 RVA: 0x006A5D40 File Offset: 0x006A3F40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsPromotion(IntPtr l)
	{
		int result;
		try
		{
			DataSectionRealTimePVP dataSectionRealTimePVP = (DataSectionRealTimePVP)LuaObject.checkSelf(l);
			bool isPromotion;
			LuaObject.checkType(l, 2, out isPromotion);
			dataSectionRealTimePVP.IsPromotion = isPromotion;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FE6 RID: 98278 RVA: 0x006A5D98 File Offset: 0x006A3F98
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionRealTimePVP");
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.StartPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.EndPromotion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.SavePromotionReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.SaveReport);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.StartNewSeason);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.AcquireWinsBonus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache7);
		string name = "PromotionReports";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_PromotionReports);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_PromotionReports);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache9, true);
		string name2 = "Reports";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_Reports);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_Reports);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheB, true);
		string name3 = "FriendlyMatchStats";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_FriendlyMatchStats);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_FriendlyMatchStats);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheD, true);
		string name4 = "LadderMatchStats";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_LadderMatchStats);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_LadderMatchStats);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cacheF, true);
		string name5 = "FriendlyCareerMatchStats";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_FriendlyCareerMatchStats);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_FriendlyCareerMatchStats);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache11, true);
		string name6 = "LadderCareerMatchStats";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_LadderCareerMatchStats);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_LadderCareerMatchStats);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache13, true);
		string name7 = "WinsBonusIdAcquired";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_WinsBonusIdAcquired);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_WinsBonusIdAcquired);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache15, true);
		string name8 = "IsPromotion";
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.get_IsPromotion);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.set_IsPromotion);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache17, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionRealTimePVP.<>f__mg$cache18, typeof(DataSectionRealTimePVP), typeof(DataSection));
	}

	// Token: 0x0400E595 RID: 58773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E596 RID: 58774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E597 RID: 58775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E598 RID: 58776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E599 RID: 58777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E59A RID: 58778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E59B RID: 58779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E59C RID: 58780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E59D RID: 58781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E59E RID: 58782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E59F RID: 58783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E5A0 RID: 58784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E5A1 RID: 58785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E5A2 RID: 58786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E5A3 RID: 58787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E5A4 RID: 58788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E5A5 RID: 58789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E5A6 RID: 58790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E5A7 RID: 58791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E5A8 RID: 58792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E5A9 RID: 58793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E5AA RID: 58794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E5AB RID: 58795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E5AC RID: 58796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E5AD RID: 58797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
