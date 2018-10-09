using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001145 RID: 4421
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo : LuaObject
{
	// Token: 0x0601665E RID: 91742 RVA: 0x005E9248 File Offset: 0x005E7448
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo o = new ConfigDataCardPoolInfo();
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

	// Token: 0x0601665F RID: 91743 RVA: 0x005E9290 File Offset: 0x005E7490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Groups(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.Groups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016660 RID: 91744 RVA: 0x005E92E4 File Offset: 0x005E74E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Groups(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			Dictionary<int, ConfigDataCardPoolGroupInfo> groups;
			LuaObject.checkType<Dictionary<int, ConfigDataCardPoolGroupInfo>>(l, 2, out groups);
			configDataCardPoolInfo.Groups = groups;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016661 RID: 91745 RVA: 0x005E933C File Offset: 0x005E753C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_replaceHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.m_replaceHeroGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016662 RID: 91746 RVA: 0x005E9390 File Offset: 0x005E7590
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_replaceHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			ConfigDataCardPoolGroupInfo replaceHeroGroup;
			LuaObject.checkType<ConfigDataCardPoolGroupInfo>(l, 2, out replaceHeroGroup);
			configDataCardPoolInfo.m_replaceHeroGroup = replaceHeroGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016663 RID: 91747 RVA: 0x005E93E8 File Offset: 0x005E75E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016664 RID: 91748 RVA: 0x005E943C File Offset: 0x005E763C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataCardPoolInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016665 RID: 91749 RVA: 0x005E9494 File Offset: 0x005E7694
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016666 RID: 91750 RVA: 0x005E94E8 File Offset: 0x005E76E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataCardPoolInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016667 RID: 91751 RVA: 0x005E9540 File Offset: 0x005E7740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PoolType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataCardPoolInfo.PoolType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016668 RID: 91752 RVA: 0x005E9594 File Offset: 0x005E7794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PoolType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			CardPoolType poolType;
			LuaObject.checkEnum<CardPoolType>(l, 2, out poolType);
			configDataCardPoolInfo.PoolType = poolType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016669 RID: 91753 RVA: 0x005E95EC File Offset: 0x005E77EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataCardPoolInfo.SelectType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601666A RID: 91754 RVA: 0x005E9640 File Offset: 0x005E7840
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SelectType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			CardSelectType selectType;
			LuaObject.checkEnum<CardSelectType>(l, 2, out selectType);
			configDataCardPoolInfo.SelectType = selectType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601666B RID: 91755 RVA: 0x005E9698 File Offset: 0x005E7898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CrystalCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.CrystalCost);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601666C RID: 91756 RVA: 0x005E96EC File Offset: 0x005E78EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CrystalCost(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int crystalCost;
			LuaObject.checkType(l, 2, out crystalCost);
			configDataCardPoolInfo.CrystalCost = crystalCost;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601666D RID: 91757 RVA: 0x005E9744 File Offset: 0x005E7944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TenSelectDiscount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.TenSelectDiscount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601666E RID: 91758 RVA: 0x005E9798 File Offset: 0x005E7998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TenSelectDiscount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int tenSelectDiscount;
			LuaObject.checkType(l, 2, out tenSelectDiscount);
			configDataCardPoolInfo.TenSelectDiscount = tenSelectDiscount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601666F RID: 91759 RVA: 0x005E97F0 File Offset: 0x005E79F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TenSelectCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.TenSelectCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016670 RID: 91760 RVA: 0x005E9844 File Offset: 0x005E7A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TenSelectCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int tenSelectCount;
			LuaObject.checkType(l, 2, out tenSelectCount);
			configDataCardPoolInfo.TenSelectCount = tenSelectCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016671 RID: 91761 RVA: 0x005E989C File Offset: 0x005E7A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TicketId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.TicketId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016672 RID: 91762 RVA: 0x005E98F0 File Offset: 0x005E7AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TicketId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int ticketId;
			LuaObject.checkType(l, 2, out ticketId);
			configDataCardPoolInfo.TicketId = ticketId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016673 RID: 91763 RVA: 0x005E9948 File Offset: 0x005E7B48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CardPoolSelectMaxCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.CardPoolSelectMaxCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016674 RID: 91764 RVA: 0x005E999C File Offset: 0x005E7B9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CardPoolSelectMaxCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int cardPoolSelectMaxCount;
			LuaObject.checkType(l, 2, out cardPoolSelectMaxCount);
			configDataCardPoolInfo.CardPoolSelectMaxCount = cardPoolSelectMaxCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016675 RID: 91765 RVA: 0x005E99F4 File Offset: 0x005E7BF4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SortID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.SortID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016676 RID: 91766 RVA: 0x005E9A48 File Offset: 0x005E7C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SortID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int sortID;
			LuaObject.checkType(l, 2, out sortID);
			configDataCardPoolInfo.SortID = sortID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016677 RID: 91767 RVA: 0x005E9AA0 File Offset: 0x005E7CA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GuaranteedGroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.GuaranteedGroupID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016678 RID: 91768 RVA: 0x005E9AF4 File Offset: 0x005E7CF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GuaranteedGroupID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int guaranteedGroupID;
			LuaObject.checkType(l, 2, out guaranteedGroupID);
			configDataCardPoolInfo.GuaranteedGroupID = guaranteedGroupID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016679 RID: 91769 RVA: 0x005E9B4C File Offset: 0x005E7D4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601667A RID: 91770 RVA: 0x005E9BA0 File Offset: 0x005E7DA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataCardPoolInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601667B RID: 91771 RVA: 0x005E9BF8 File Offset: 0x005E7DF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AdsImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.AdsImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601667C RID: 91772 RVA: 0x005E9C4C File Offset: 0x005E7E4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AdsImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			string adsImage;
			LuaObject.checkType(l, 2, out adsImage);
			configDataCardPoolInfo.AdsImage = adsImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601667D RID: 91773 RVA: 0x005E9CA4 File Offset: 0x005E7EA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectProbabilityInfoID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.SelectProbabilityInfoID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601667E RID: 91774 RVA: 0x005E9CF8 File Offset: 0x005E7EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectProbabilityInfoID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int selectProbabilityInfoID;
			LuaObject.checkType(l, 2, out selectProbabilityInfoID);
			configDataCardPoolInfo.SelectProbabilityInfoID = selectProbabilityInfoID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601667F RID: 91775 RVA: 0x005E9D50 File Offset: 0x005E7F50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SelectContentInfoID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.SelectContentInfoID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016680 RID: 91776 RVA: 0x005E9DA4 File Offset: 0x005E7FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SelectContentInfoID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int selectContentInfoID;
			LuaObject.checkType(l, 2, out selectContentInfoID);
			configDataCardPoolInfo.SelectContentInfoID = selectContentInfoID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016681 RID: 91777 RVA: 0x005E9DFC File Offset: 0x005E7FFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ToggleClickImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.ToggleClickImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016682 RID: 91778 RVA: 0x005E9E50 File Offset: 0x005E8050
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ToggleClickImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			string toggleClickImage;
			LuaObject.checkType(l, 2, out toggleClickImage);
			configDataCardPoolInfo.ToggleClickImage = toggleClickImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016683 RID: 91779 RVA: 0x005E9EA8 File Offset: 0x005E80A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ToggleUnClickImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.ToggleUnClickImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016684 RID: 91780 RVA: 0x005E9EFC File Offset: 0x005E80FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ToggleUnClickImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			string toggleUnClickImage;
			LuaObject.checkType(l, 2, out toggleUnClickImage);
			configDataCardPoolInfo.ToggleUnClickImage = toggleUnClickImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016685 RID: 91781 RVA: 0x005E9F54 File Offset: 0x005E8154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MissionCardPoolType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataCardPoolInfo.MissionCardPoolType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016686 RID: 91782 RVA: 0x005E9FA8 File Offset: 0x005E81A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MissionCardPoolType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			MissionCardPoolType missionCardPoolType;
			LuaObject.checkEnum<MissionCardPoolType>(l, 2, out missionCardPoolType);
			configDataCardPoolInfo.MissionCardPoolType = missionCardPoolType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016687 RID: 91783 RVA: 0x005EA000 File Offset: 0x005E8200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TenSelectGuaranteedMinCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.TenSelectGuaranteedMinCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016688 RID: 91784 RVA: 0x005EA054 File Offset: 0x005E8254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TenSelectGuaranteedMinCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int tenSelectGuaranteedMinCount;
			LuaObject.checkType(l, 2, out tenSelectGuaranteedMinCount);
			configDataCardPoolInfo.TenSelectGuaranteedMinCount = tenSelectGuaranteedMinCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016689 RID: 91785 RVA: 0x005EA0AC File Offset: 0x005E82AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReplaceHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.ReplaceHeroGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601668A RID: 91786 RVA: 0x005EA100 File Offset: 0x005E8300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ReplaceHeroGroup(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			int replaceHeroGroup;
			LuaObject.checkType(l, 2, out replaceHeroGroup);
			configDataCardPoolInfo.ReplaceHeroGroup = replaceHeroGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601668B RID: 91787 RVA: 0x005EA158 File Offset: 0x005E8358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CardPoolDetailDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataCardPoolInfo.CardPoolDetailDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601668C RID: 91788 RVA: 0x005EA1AC File Offset: 0x005E83AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CardPoolDetailDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataCardPoolInfo configDataCardPoolInfo = (ConfigDataCardPoolInfo)LuaObject.checkSelf(l);
			string cardPoolDetailDesc;
			LuaObject.checkType(l, 2, out cardPoolDetailDesc);
			configDataCardPoolInfo.CardPoolDetailDesc = cardPoolDetailDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601668D RID: 91789 RVA: 0x005EA204 File Offset: 0x005E8404
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataCardPoolInfo");
		string name = "Groups";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_Groups);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_Groups);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1, true);
		string name2 = "m_replaceHeroGroup";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_m_replaceHeroGroup);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_m_replaceHeroGroup);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache3, true);
		string name3 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_ID);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_ID);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache5, true);
		string name4 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_Name);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_Name);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache7, true);
		string name5 = "PoolType";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_PoolType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_PoolType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache9, true);
		string name6 = "SelectType";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_SelectType);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_SelectType);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheB, true);
		string name7 = "CrystalCost";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_CrystalCost);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_CrystalCost);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheD, true);
		string name8 = "TenSelectDiscount";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_TenSelectDiscount);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_TenSelectDiscount);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cacheF, true);
		string name9 = "TenSelectCount";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_TenSelectCount);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_TenSelectCount);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache11, true);
		string name10 = "TicketId";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_TicketId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_TicketId);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache13, true);
		string name11 = "CardPoolSelectMaxCount";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_CardPoolSelectMaxCount);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_CardPoolSelectMaxCount);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache15, true);
		string name12 = "SortID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_SortID);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache16;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_SortID);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache17, true);
		string name13 = "GuaranteedGroupID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_GuaranteedGroupID);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache18;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_GuaranteedGroupID);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache19, true);
		string name14 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_Icon);
		}
		LuaCSFunction get14 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1A;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_Icon);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1B, true);
		string name15 = "AdsImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_AdsImage);
		}
		LuaCSFunction get15 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1C;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_AdsImage);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1D, true);
		string name16 = "SelectProbabilityInfoID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_SelectProbabilityInfoID);
		}
		LuaCSFunction get16 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1E;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_SelectProbabilityInfoID);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache1F, true);
		string name17 = "SelectContentInfoID";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_SelectContentInfoID);
		}
		LuaCSFunction get17 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache20;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_SelectContentInfoID);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache21, true);
		string name18 = "ToggleClickImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_ToggleClickImage);
		}
		LuaCSFunction get18 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache22;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_ToggleClickImage);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache23, true);
		string name19 = "ToggleUnClickImage";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_ToggleUnClickImage);
		}
		LuaCSFunction get19 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache24;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_ToggleUnClickImage);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache25, true);
		string name20 = "MissionCardPoolType";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_MissionCardPoolType);
		}
		LuaCSFunction get20 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache26;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_MissionCardPoolType);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache27, true);
		string name21 = "TenSelectGuaranteedMinCount";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_TenSelectGuaranteedMinCount);
		}
		LuaCSFunction get21 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache28;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_TenSelectGuaranteedMinCount);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache29, true);
		string name22 = "ReplaceHeroGroup";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_ReplaceHeroGroup);
		}
		LuaCSFunction get22 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2A;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_ReplaceHeroGroup);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2B, true);
		string name23 = "CardPoolDetailDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.get_CardPoolDetailDesc);
		}
		LuaCSFunction get23 = Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2C;
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.set_CardPoolDetailDesc);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2D, true);
		if (Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataCardPoolInfo.<>f__mg$cache2E, typeof(ConfigDataCardPoolInfo));
	}

	// Token: 0x0400CDB6 RID: 52662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CDB7 RID: 52663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CDB8 RID: 52664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CDB9 RID: 52665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CDBA RID: 52666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CDBB RID: 52667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CDBC RID: 52668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CDBD RID: 52669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CDBE RID: 52670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CDBF RID: 52671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CDC0 RID: 52672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CDC1 RID: 52673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CDC2 RID: 52674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CDC3 RID: 52675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CDC4 RID: 52676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CDC5 RID: 52677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CDC6 RID: 52678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CDC7 RID: 52679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CDC8 RID: 52680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CDC9 RID: 52681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CDCA RID: 52682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CDCB RID: 52683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CDCC RID: 52684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CDCD RID: 52685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CDCE RID: 52686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CDCF RID: 52687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400CDD0 RID: 52688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400CDD1 RID: 52689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400CDD2 RID: 52690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400CDD3 RID: 52691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400CDD4 RID: 52692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400CDD5 RID: 52693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400CDD6 RID: 52694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400CDD7 RID: 52695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400CDD8 RID: 52696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400CDD9 RID: 52697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400CDDA RID: 52698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400CDDB RID: 52699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400CDDC RID: 52700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400CDDD RID: 52701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400CDDE RID: 52702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400CDDF RID: 52703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400CDE0 RID: 52704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400CDE1 RID: 52705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400CDE2 RID: 52706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400CDE3 RID: 52707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400CDE4 RID: 52708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
