using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.UtilityTools;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200120A RID: 4618
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo : LuaObject
{
	// Token: 0x06017F46 RID: 98118 RVA: 0x006A16D4 File Offset: 0x0069F8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo o = new DataSectionPlayerBasicInfo();
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

	// Token: 0x06017F47 RID: 98119 RVA: 0x006A171C File Offset: 0x0069F91C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			object o = dataSectionPlayerBasicInfo.SerializeToClient();
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

	// Token: 0x06017F48 RID: 98120 RVA: 0x006A1770 File Offset: 0x0069F970
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F49 RID: 98121 RVA: 0x006A17BC File Offset: 0x0069F9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerExp(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			dataSectionPlayerBasicInfo.SetPlayerExp(playerExp);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F4A RID: 98122 RVA: 0x006A1814 File Offset: 0x0069FA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangePlayerName(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			string newName;
			LuaObject.checkType(l, 2, out newName);
			dataSectionPlayerBasicInfo.ChangePlayerName(newName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F4B RID: 98123 RVA: 0x006A186C File Offset: 0x0069FA6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PlayerLevelUp(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.PlayerLevelUp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F4C RID: 98124 RVA: 0x006A18B8 File Offset: 0x0069FAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRechargedCrystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddRechargedCrystal(nums);
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

	// Token: 0x06017F4D RID: 98125 RVA: 0x006A191C File Offset: 0x0069FB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			long i = dataSectionPlayerBasicInfo.AddRechargeRMB(nums);
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

	// Token: 0x06017F4E RID: 98126 RVA: 0x006A1980 File Offset: 0x0069FB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGold(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddGold(nums);
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

	// Token: 0x06017F4F RID: 98127 RVA: 0x006A19E4 File Offset: 0x0069FBE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddCrystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddCrystal(nums);
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

	// Token: 0x06017F50 RID: 98128 RVA: 0x006A1A48 File Offset: 0x0069FC48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUserGuide(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			List<int> userGuide;
			LuaObject.checkType<List<int>>(l, 2, out userGuide);
			dataSectionPlayerBasicInfo.SetUserGuide(userGuide);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F51 RID: 98129 RVA: 0x006A1AA0 File Offset: 0x0069FCA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CleanUserGuide(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			List<int> completeStepIds;
			LuaObject.checkType<List<int>>(l, 2, out completeStepIds);
			dataSectionPlayerBasicInfo.CleanUserGuide(completeStepIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F52 RID: 98130 RVA: 0x006A1AF8 File Offset: 0x0069FCF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsUserGuideCompleted(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int stepId;
			LuaObject.checkType(l, 2, out stepId);
			bool b = dataSectionPlayerBasicInfo.IsUserGuideCompleted(stepId);
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

	// Token: 0x06017F53 RID: 98131 RVA: 0x006A1B5C File Offset: 0x0069FD5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEnergy(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int energy;
			LuaObject.checkType(l, 2, out energy);
			dataSectionPlayerBasicInfo.SetEnergy(energy);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F54 RID: 98132 RVA: 0x006A1BB4 File Offset: 0x0069FDB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitSignDays(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int signDays;
			LuaObject.checkType(l, 2, out signDays);
			dataSectionPlayerBasicInfo.InitSignDays(signDays);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F55 RID: 98133 RVA: 0x006A1C0C File Offset: 0x0069FE0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetSignDays(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.ResetSignDays();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F56 RID: 98134 RVA: 0x006A1C58 File Offset: 0x0069FE58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSignDays(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int signDays;
			LuaObject.checkType(l, 2, out signDays);
			dataSectionPlayerBasicInfo.SetSignDays(signDays);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F57 RID: 98135 RVA: 0x006A1CB0 File Offset: 0x0069FEB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSignDays(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.AddSignDays();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F58 RID: 98136 RVA: 0x006A1CFC File Offset: 0x0069FEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetLastSignTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime lastSignTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastSignTime);
			dataSectionPlayerBasicInfo.SetLastSignTime(lastSignTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F59 RID: 98137 RVA: 0x006A1D54 File Offset: 0x0069FF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetBuyEngryNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.ResetBuyEngryNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F5A RID: 98138 RVA: 0x006A1DA0 File Offset: 0x0069FFA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BuyEngry(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.BuyEngry();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F5B RID: 98139 RVA: 0x006A1DEC File Offset: 0x0069FFEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int BuyArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.BuyArenaTickets();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F5C RID: 98140 RVA: 0x006A1E38 File Offset: 0x006A0038
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetBuyArenaTicketsNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			dataSectionPlayerBasicInfo.ResetBuyArenaTicketsNums();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F5D RID: 98141 RVA: 0x006A1E84 File Offset: 0x006A0084
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetNextPlayerActionFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime nextPlayerActionFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextPlayerActionFlushTime);
			dataSectionPlayerBasicInfo.SetNextPlayerActionFlushTime(nextPlayerActionFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F5E RID: 98142 RVA: 0x006A1EDC File Offset: 0x006A00DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int arenaTickets;
			LuaObject.checkType(l, 2, out arenaTickets);
			dataSectionPlayerBasicInfo.SetArenaTickets(arenaTickets);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F5F RID: 98143 RVA: 0x006A1F34 File Offset: 0x006A0134
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			dataSectionPlayerBasicInfo.AddArenaTickets(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F60 RID: 98144 RVA: 0x006A1F8C File Offset: 0x006A018C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddMemoryEssence(nums);
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

	// Token: 0x06017F61 RID: 98145 RVA: 0x006A1FF0 File Offset: 0x006A01F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int memoryEssence;
			LuaObject.checkType(l, 2, out memoryEssence);
			dataSectionPlayerBasicInfo.SetMemoryEssence(memoryEssence);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F62 RID: 98146 RVA: 0x006A2048 File Offset: 0x006A0248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddBrillianceMithralStone(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddBrillianceMithralStone(nums);
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

	// Token: 0x06017F63 RID: 98147 RVA: 0x006A20AC File Offset: 0x006A02AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddMithralStone(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddMithralStone(nums);
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

	// Token: 0x06017F64 RID: 98148 RVA: 0x006A2110 File Offset: 0x006A0310
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddGuildMedal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddGuildMedal(nums);
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

	// Token: 0x06017F65 RID: 98149 RVA: 0x006A2174 File Offset: 0x006A0374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddArenaHonour(nums);
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

	// Token: 0x06017F66 RID: 98150 RVA: 0x006A21D8 File Offset: 0x006A03D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddRealTimePVPHonor(nums);
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

	// Token: 0x06017F67 RID: 98151 RVA: 0x006A223C File Offset: 0x006A043C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddFriendshipPoints(nums);
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

	// Token: 0x06017F68 RID: 98152 RVA: 0x006A22A0 File Offset: 0x006A04A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetEnergyFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime energyFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out energyFlushTime);
			dataSectionPlayerBasicInfo.SetEnergyFlushTime(energyFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F69 RID: 98153 RVA: 0x006A22F8 File Offset: 0x006A04F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHeadIcon(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			dataSectionPlayerBasicInfo.SetHeadIcon(headIcon);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F6A RID: 98154 RVA: 0x006A2350 File Offset: 0x006A0550
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddSkinTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			int i = dataSectionPlayerBasicInfo.AddSkinTickets(nums);
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

	// Token: 0x06017F6B RID: 98155 RVA: 0x006A23B4 File Offset: 0x006A05B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetMemoryStoreOpenStatus(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			bool memoryStoreOpenStatus;
			LuaObject.checkType(l, 2, out memoryStoreOpenStatus);
			dataSectionPlayerBasicInfo.SetMemoryStoreOpenStatus(memoryStoreOpenStatus);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F6C RID: 98156 RVA: 0x006A240C File Offset: 0x006A060C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.PlayerLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F6D RID: 98157 RVA: 0x006A2460 File Offset: 0x006A0660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int playerLevel;
			LuaObject.checkType(l, 2, out playerLevel);
			dataSectionPlayerBasicInfo.PlayerLevel = playerLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F6E RID: 98158 RVA: 0x006A24B8 File Offset: 0x006A06B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RechargeCrystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.RechargeCrystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F6F RID: 98159 RVA: 0x006A250C File Offset: 0x006A070C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RechargeCrystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int rechargeCrystal;
			LuaObject.checkType(l, 2, out rechargeCrystal);
			dataSectionPlayerBasicInfo.RechargeCrystal = rechargeCrystal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F70 RID: 98160 RVA: 0x006A2564 File Offset: 0x006A0764
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F71 RID: 98161 RVA: 0x006A25B8 File Offset: 0x006A07B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			dataSectionPlayerBasicInfo.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F72 RID: 98162 RVA: 0x006A2610 File Offset: 0x006A0810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Crystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.Crystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F73 RID: 98163 RVA: 0x006A2664 File Offset: 0x006A0864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Crystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int crystal;
			LuaObject.checkType(l, 2, out crystal);
			dataSectionPlayerBasicInfo.Crystal = crystal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F74 RID: 98164 RVA: 0x006A26BC File Offset: 0x006A08BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuideCompleteFlags(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.GuideCompleteFlags);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F75 RID: 98165 RVA: 0x006A2710 File Offset: 0x006A0910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuideCompleteFlags(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			BitArray guideCompleteFlags;
			LuaObject.checkType<BitArray>(l, 2, out guideCompleteFlags);
			dataSectionPlayerBasicInfo.GuideCompleteFlags = guideCompleteFlags;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F76 RID: 98166 RVA: 0x006A2768 File Offset: 0x006A0968
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_EnergyFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.EnergyFlushTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F77 RID: 98167 RVA: 0x006A27C0 File Offset: 0x006A09C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EnergyFlushTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime energyFlushTime;
			LuaObject.checkValueType<DateTime>(l, 2, out energyFlushTime);
			dataSectionPlayerBasicInfo.EnergyFlushTime = energyFlushTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F78 RID: 98168 RVA: 0x006A2818 File Offset: 0x006A0A18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.CreateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F79 RID: 98169 RVA: 0x006A2870 File Offset: 0x006A0A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CreateTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime createTime;
			LuaObject.checkValueType<DateTime>(l, 2, out createTime);
			dataSectionPlayerBasicInfo.CreateTime = createTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F7A RID: 98170 RVA: 0x006A28C8 File Offset: 0x006A0AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CreateTimeUtc(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.CreateTimeUtc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F7B RID: 98171 RVA: 0x006A2920 File Offset: 0x006A0B20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CreateTimeUtc(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime createTimeUtc;
			LuaObject.checkValueType<DateTime>(l, 2, out createTimeUtc);
			dataSectionPlayerBasicInfo.CreateTimeUtc = createTimeUtc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F7C RID: 98172 RVA: 0x006A2978 File Offset: 0x006A0B78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LogoutTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.LogoutTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F7D RID: 98173 RVA: 0x006A29D0 File Offset: 0x006A0BD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LogoutTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime logoutTime;
			LuaObject.checkValueType<DateTime>(l, 2, out logoutTime);
			dataSectionPlayerBasicInfo.LogoutTime = logoutTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F7E RID: 98174 RVA: 0x006A2A28 File Offset: 0x006A0C28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LoginTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.LoginTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F7F RID: 98175 RVA: 0x006A2A80 File Offset: 0x006A0C80
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_LoginTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime loginTime;
			LuaObject.checkValueType<DateTime>(l, 2, out loginTime);
			dataSectionPlayerBasicInfo.LoginTime = loginTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F80 RID: 98176 RVA: 0x006A2AD8 File Offset: 0x006A0CD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastSignTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.LastSignTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F81 RID: 98177 RVA: 0x006A2B30 File Offset: 0x006A0D30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastSignTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime lastSignTime;
			LuaObject.checkValueType<DateTime>(l, 2, out lastSignTime);
			dataSectionPlayerBasicInfo.LastSignTime = lastSignTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F82 RID: 98178 RVA: 0x006A2B88 File Offset: 0x006A0D88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuyEngryNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.BuyEngryNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F83 RID: 98179 RVA: 0x006A2BDC File Offset: 0x006A0DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BuyEngryNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int buyEngryNums;
			LuaObject.checkType(l, 2, out buyEngryNums);
			dataSectionPlayerBasicInfo.BuyEngryNums = buyEngryNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F84 RID: 98180 RVA: 0x006A2C34 File Offset: 0x006A0E34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BuyArenaTicketsNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.BuyArenaTicketsNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F85 RID: 98181 RVA: 0x006A2C88 File Offset: 0x006A0E88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_BuyArenaTicketsNums(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int buyArenaTicketsNums;
			LuaObject.checkType(l, 2, out buyArenaTicketsNums);
			dataSectionPlayerBasicInfo.BuyArenaTicketsNums = buyArenaTicketsNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F86 RID: 98182 RVA: 0x006A2CE0 File Offset: 0x006A0EE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_NextFlushPlayerActionTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.NextFlushPlayerActionTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F87 RID: 98183 RVA: 0x006A2D38 File Offset: 0x006A0F38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_NextFlushPlayerActionTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			DateTime nextFlushPlayerActionTime;
			LuaObject.checkValueType<DateTime>(l, 2, out nextFlushPlayerActionTime);
			dataSectionPlayerBasicInfo.NextFlushPlayerActionTime = nextFlushPlayerActionTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F88 RID: 98184 RVA: 0x006A2D90 File Offset: 0x006A0F90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.ArenaTickets);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F89 RID: 98185 RVA: 0x006A2DE4 File Offset: 0x006A0FE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ArenaTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int arenaTickets;
			LuaObject.checkType(l, 2, out arenaTickets);
			dataSectionPlayerBasicInfo.ArenaTickets = arenaTickets;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F8A RID: 98186 RVA: 0x006A2E3C File Offset: 0x006A103C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.ArenaHonour);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F8B RID: 98187 RVA: 0x006A2E90 File Offset: 0x006A1090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaHonour(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int arenaHonour;
			LuaObject.checkType(l, 2, out arenaHonour);
			dataSectionPlayerBasicInfo.ArenaHonour = arenaHonour;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F8C RID: 98188 RVA: 0x006A2EE8 File Offset: 0x006A10E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_RealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.RealTimePVPHonor);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F8D RID: 98189 RVA: 0x006A2F3C File Offset: 0x006A113C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RealTimePVPHonor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int realTimePVPHonor;
			LuaObject.checkType(l, 2, out realTimePVPHonor);
			dataSectionPlayerBasicInfo.RealTimePVPHonor = realTimePVPHonor;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F8E RID: 98190 RVA: 0x006A2F94 File Offset: 0x006A1194
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.FriendshipPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F8F RID: 98191 RVA: 0x006A2FE8 File Offset: 0x006A11E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int friendshipPoints;
			LuaObject.checkType(l, 2, out friendshipPoints);
			dataSectionPlayerBasicInfo.FriendshipPoints = friendshipPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F90 RID: 98192 RVA: 0x006A3040 File Offset: 0x006A1240
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpenGameRating(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.OpenGameRating);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F91 RID: 98193 RVA: 0x006A3094 File Offset: 0x006A1294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OpenGameRating(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			bool openGameRating;
			LuaObject.checkType(l, 2, out openGameRating);
			dataSectionPlayerBasicInfo.OpenGameRating = openGameRating;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F92 RID: 98194 RVA: 0x006A30EC File Offset: 0x006A12EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkinTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.SkinTickets);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F93 RID: 98195 RVA: 0x006A3140 File Offset: 0x006A1340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkinTickets(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int skinTickets;
			LuaObject.checkType(l, 2, out skinTickets);
			dataSectionPlayerBasicInfo.SkinTickets = skinTickets;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F94 RID: 98196 RVA: 0x006A3198 File Offset: 0x006A1398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.MemoryEssence);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F95 RID: 98197 RVA: 0x006A31EC File Offset: 0x006A13EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MemoryEssence(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int memoryEssence;
			LuaObject.checkType(l, 2, out memoryEssence);
			dataSectionPlayerBasicInfo.MemoryEssence = memoryEssence;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F96 RID: 98198 RVA: 0x006A3244 File Offset: 0x006A1444
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MithralStone(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.MithralStone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F97 RID: 98199 RVA: 0x006A3298 File Offset: 0x006A1498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MithralStone(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int mithralStone;
			LuaObject.checkType(l, 2, out mithralStone);
			dataSectionPlayerBasicInfo.MithralStone = mithralStone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F98 RID: 98200 RVA: 0x006A32F0 File Offset: 0x006A14F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_BrillianceMithralStone(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.BrillianceMithralStone);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F99 RID: 98201 RVA: 0x006A3344 File Offset: 0x006A1544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_BrillianceMithralStone(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int brillianceMithralStone;
			LuaObject.checkType(l, 2, out brillianceMithralStone);
			dataSectionPlayerBasicInfo.BrillianceMithralStone = brillianceMithralStone;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F9A RID: 98202 RVA: 0x006A339C File Offset: 0x006A159C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GuildMedal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.GuildMedal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F9B RID: 98203 RVA: 0x006A33F0 File Offset: 0x006A15F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuildMedal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int guildMedal;
			LuaObject.checkType(l, 2, out guildMedal);
			dataSectionPlayerBasicInfo.GuildMedal = guildMedal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F9C RID: 98204 RVA: 0x006A3448 File Offset: 0x006A1648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MemoryStoreOpen(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.MemoryStoreOpen);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F9D RID: 98205 RVA: 0x006A349C File Offset: 0x006A169C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MemoryStoreOpen(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			bool memoryStoreOpen;
			LuaObject.checkType(l, 2, out memoryStoreOpen);
			dataSectionPlayerBasicInfo.MemoryStoreOpen = memoryStoreOpen;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F9E RID: 98206 RVA: 0x006A34F4 File Offset: 0x006A16F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F9F RID: 98207 RVA: 0x006A3548 File Offset: 0x006A1748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			dataSectionPlayerBasicInfo.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA0 RID: 98208 RVA: 0x006A35A0 File Offset: 0x006A17A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerName(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.PlayerName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA1 RID: 98209 RVA: 0x006A35F4 File Offset: 0x006A17F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerName(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			string playerName;
			LuaObject.checkType(l, 2, out playerName);
			dataSectionPlayerBasicInfo.PlayerName = playerName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA2 RID: 98210 RVA: 0x006A364C File Offset: 0x006A184C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.RechargeRMB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA3 RID: 98211 RVA: 0x006A36A0 File Offset: 0x006A18A0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_RechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			long rechargeRMB;
			LuaObject.checkType(l, 2, out rechargeRMB);
			dataSectionPlayerBasicInfo.RechargeRMB = rechargeRMB;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA4 RID: 98212 RVA: 0x006A36F8 File Offset: 0x006A18F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Energy(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.Energy);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA5 RID: 98213 RVA: 0x006A374C File Offset: 0x006A194C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Energy(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int energy;
			LuaObject.checkType(l, 2, out energy);
			dataSectionPlayerBasicInfo.Energy = energy;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA6 RID: 98214 RVA: 0x006A37A4 File Offset: 0x006A19A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Exp(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.Exp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA7 RID: 98215 RVA: 0x006A37F8 File Offset: 0x006A19F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Exp(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int exp;
			LuaObject.checkType(l, 2, out exp);
			dataSectionPlayerBasicInfo.Exp = exp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA8 RID: 98216 RVA: 0x006A3850 File Offset: 0x006A1A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SignDays(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.SignDays);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FA9 RID: 98217 RVA: 0x006A38A4 File Offset: 0x006A1AA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SignDays(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int signDays;
			LuaObject.checkType(l, 2, out signDays);
			dataSectionPlayerBasicInfo.SignDays = signDays;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FAA RID: 98218 RVA: 0x006A38FC File Offset: 0x006A1AFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionPlayerBasicInfo.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FAB RID: 98219 RVA: 0x006A3950 File Offset: 0x006A1B50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			DataSectionPlayerBasicInfo dataSectionPlayerBasicInfo = (DataSectionPlayerBasicInfo)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			dataSectionPlayerBasicInfo.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017FAC RID: 98220 RVA: 0x006A39A8 File Offset: 0x006A1BA8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionPlayerBasicInfo");
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetPlayerExp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.ChangePlayerName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.PlayerLevelUp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddRechargedCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddGold);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.CleanUserGuide);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.IsUserGuideCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetEnergy);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.InitSignDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.ResetSignDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetSignDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddSignDays);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetLastSignTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.ResetBuyEngryNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.BuyEngry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.BuyArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.ResetBuyArenaTicketsNums);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetNextPlayerActionFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddArenaTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddMemoryEssence);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetMemoryEssence);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddBrillianceMithralStone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddMithralStone);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddGuildMedal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddArenaHonour);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddRealTimePVPHonor);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddFriendshipPoints);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetEnergyFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetHeadIcon);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.AddSkinTickets);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.SetMemoryStoreOpenStatus);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache24);
		string name = "PlayerLevel";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_PlayerLevel);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_PlayerLevel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache26, true);
		string name2 = "RechargeCrystal";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_RechargeCrystal);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_RechargeCrystal);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache28, true);
		string name3 = "Gold";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_Gold);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_Gold);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2A, true);
		string name4 = "Crystal";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_Crystal);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_Crystal);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2C, true);
		string name5 = "GuideCompleteFlags";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_GuideCompleteFlags);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_GuideCompleteFlags);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2E, true);
		string name6 = "EnergyFlushTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_EnergyFlushTime);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_EnergyFlushTime);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache30, true);
		string name7 = "CreateTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_CreateTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_CreateTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache32, true);
		string name8 = "CreateTimeUtc";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_CreateTimeUtc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_CreateTimeUtc);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache34, true);
		string name9 = "LogoutTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_LogoutTime);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_LogoutTime);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache36, true);
		string name10 = "LoginTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_LoginTime);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_LoginTime);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache38, true);
		string name11 = "LastSignTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_LastSignTime);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_LastSignTime);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3A, true);
		string name12 = "BuyEngryNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_BuyEngryNums);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_BuyEngryNums);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3C, true);
		string name13 = "BuyArenaTicketsNums";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_BuyArenaTicketsNums);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_BuyArenaTicketsNums);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3E, true);
		string name14 = "NextFlushPlayerActionTime";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_NextFlushPlayerActionTime);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_NextFlushPlayerActionTime);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache40, true);
		string name15 = "ArenaTickets";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_ArenaTickets);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_ArenaTickets);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache42, true);
		string name16 = "ArenaHonour";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_ArenaHonour);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_ArenaHonour);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache44, true);
		string name17 = "RealTimePVPHonor";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_RealTimePVPHonor);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_RealTimePVPHonor);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache46, true);
		string name18 = "FriendshipPoints";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_FriendshipPoints);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_FriendshipPoints);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache48, true);
		string name19 = "OpenGameRating";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_OpenGameRating);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_OpenGameRating);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4A, true);
		string name20 = "SkinTickets";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_SkinTickets);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_SkinTickets);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4C, true);
		string name21 = "MemoryEssence";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_MemoryEssence);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_MemoryEssence);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4E, true);
		string name22 = "MithralStone";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_MithralStone);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_MithralStone);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache50, true);
		string name23 = "BrillianceMithralStone";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_BrillianceMithralStone);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_BrillianceMithralStone);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache52, true);
		string name24 = "GuildMedal";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_GuildMedal);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_GuildMedal);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache54, true);
		string name25 = "MemoryStoreOpen";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_MemoryStoreOpen);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_MemoryStoreOpen);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache56, true);
		string name26 = "UserId";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_UserId);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_UserId);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache58, true);
		string name27 = "PlayerName";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_PlayerName);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_PlayerName);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5A, true);
		string name28 = "RechargeRMB";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_RechargeRMB);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_RechargeRMB);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5C, true);
		string name29 = "Energy";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_Energy);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_Energy);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5E, true);
		string name30 = "Exp";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_Exp);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_Exp);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache60, true);
		string name31 = "SignDays";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_SignDays);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_SignDays);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache62, true);
		string name32 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.get_HeadIcon);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.set_HeadIcon);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache64, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionPlayerBasicInfo.<>f__mg$cache65, typeof(DataSectionPlayerBasicInfo), typeof(DataSection));
	}

	// Token: 0x0400E514 RID: 58644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E515 RID: 58645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E516 RID: 58646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E517 RID: 58647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E518 RID: 58648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E519 RID: 58649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E51A RID: 58650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E51B RID: 58651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E51C RID: 58652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E51D RID: 58653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E51E RID: 58654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E51F RID: 58655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E520 RID: 58656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E521 RID: 58657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E522 RID: 58658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E523 RID: 58659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E524 RID: 58660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E525 RID: 58661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E526 RID: 58662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E527 RID: 58663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E528 RID: 58664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E529 RID: 58665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E52A RID: 58666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E52B RID: 58667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E52C RID: 58668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E52D RID: 58669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E52E RID: 58670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400E52F RID: 58671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400E530 RID: 58672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400E531 RID: 58673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400E532 RID: 58674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400E533 RID: 58675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400E534 RID: 58676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400E535 RID: 58677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400E536 RID: 58678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400E537 RID: 58679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400E538 RID: 58680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400E539 RID: 58681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400E53A RID: 58682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400E53B RID: 58683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400E53C RID: 58684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400E53D RID: 58685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400E53E RID: 58686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400E53F RID: 58687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400E540 RID: 58688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400E541 RID: 58689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400E542 RID: 58690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400E543 RID: 58691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400E544 RID: 58692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400E545 RID: 58693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400E546 RID: 58694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400E547 RID: 58695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400E548 RID: 58696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400E549 RID: 58697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400E54A RID: 58698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400E54B RID: 58699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400E54C RID: 58700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400E54D RID: 58701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400E54E RID: 58702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400E54F RID: 58703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400E550 RID: 58704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400E551 RID: 58705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400E552 RID: 58706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400E553 RID: 58707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400E554 RID: 58708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400E555 RID: 58709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400E556 RID: 58710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0400E557 RID: 58711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0400E558 RID: 58712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0400E559 RID: 58713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0400E55A RID: 58714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0400E55B RID: 58715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0400E55C RID: 58716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0400E55D RID: 58717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0400E55E RID: 58718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0400E55F RID: 58719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0400E560 RID: 58720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x0400E561 RID: 58721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x0400E562 RID: 58722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x0400E563 RID: 58723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x0400E564 RID: 58724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x0400E565 RID: 58725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x0400E566 RID: 58726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0400E567 RID: 58727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0400E568 RID: 58728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0400E569 RID: 58729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0400E56A RID: 58730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0400E56B RID: 58731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0400E56C RID: 58732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0400E56D RID: 58733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0400E56E RID: 58734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0400E56F RID: 58735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0400E570 RID: 58736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x0400E571 RID: 58737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x0400E572 RID: 58738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x0400E573 RID: 58739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x0400E574 RID: 58740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x0400E575 RID: 58741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x0400E576 RID: 58742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x0400E577 RID: 58743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x0400E578 RID: 58744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x0400E579 RID: 58745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;
}
