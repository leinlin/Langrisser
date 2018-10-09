using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001209 RID: 4617
[Preserve]
public class Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity : LuaObject
{
	// Token: 0x06017F2F RID: 98095 RVA: 0x006A0C48 File Offset: 0x0069EE48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity o = new DataSectionOperationalActivity();
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

	// Token: 0x06017F30 RID: 98096 RVA: 0x006A0C90 File Offset: 0x0069EE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearInitedData(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			dataSectionOperationalActivity.ClearInitedData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F31 RID: 98097 RVA: 0x006A0CDC File Offset: 0x0069EEDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToClient(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			object o = dataSectionOperationalActivity.SerializeToClient();
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

	// Token: 0x06017F32 RID: 98098 RVA: 0x006A0D30 File Offset: 0x0069EF30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindOperationalActivityById(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			ulong operationalActivityInstanceId;
			LuaObject.checkType(l, 2, out operationalActivityInstanceId);
			OperationalActivityBase o = dataSectionOperationalActivity.FindOperationalActivityById(operationalActivityInstanceId);
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

	// Token: 0x06017F33 RID: 98099 RVA: 0x006A0D94 File Offset: 0x0069EF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindOperationalActivitiesByType(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			OperationalActivityType activityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 2, out activityType);
			List<OperationalActivityBase> o = dataSectionOperationalActivity.FindOperationalActivitiesByType(activityType);
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

	// Token: 0x06017F34 RID: 98100 RVA: 0x006A0DF8 File Offset: 0x0069EFF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			List<OperationalActivityBase> operationalActivities;
			LuaObject.checkType<List<OperationalActivityBase>>(l, 2, out operationalActivities);
			dataSectionOperationalActivity.InitOperationalActivities(operationalActivities);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F35 RID: 98101 RVA: 0x006A0E50 File Offset: 0x0069F050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			List<OperationalActivityBase> operationalActivities;
			LuaObject.checkType<List<OperationalActivityBase>>(l, 2, out operationalActivities);
			dataSectionOperationalActivity.SetOperationalActivities(operationalActivities);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F36 RID: 98102 RVA: 0x006A0EA8 File Offset: 0x0069F0A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAccumulateLoginTime(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity;
			LuaObject.checkType<AccumulateLoginOperationalActivity>(l, 2, out accumulateLoginOperationalActivity);
			DateTime loginTime;
			LuaObject.checkValueType<DateTime>(l, 3, out loginTime);
			bool b = dataSectionOperationalActivity.AddAccumulateLoginTime(accumulateLoginOperationalActivity, loginTime);
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

	// Token: 0x06017F37 RID: 98103 RVA: 0x006A0F18 File Offset: 0x0069F118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			AccumulateRechargeOperationalActivity activity;
			LuaObject.checkType<AccumulateRechargeOperationalActivity>(l, 2, out activity);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionOperationalActivity.AddRechargeRMB(activity, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F38 RID: 98104 RVA: 0x006A0F7C File Offset: 0x0069F17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddConsumeCrystal(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			AccumulateConsumeCrystalOperationalActivity activity;
			LuaObject.checkType<AccumulateConsumeCrystalOperationalActivity>(l, 2, out activity);
			int nums;
			LuaObject.checkType(l, 3, out nums);
			dataSectionOperationalActivity.AddConsumeCrystal(activity, nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F39 RID: 98105 RVA: 0x006A0FE0 File Offset: 0x0069F1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerLevel(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			PlayerLevelUpOperationalActivity playerLevelUpOperationalActivity;
			LuaObject.checkType<PlayerLevelUpOperationalActivity>(l, 2, out playerLevelUpOperationalActivity);
			int playerLevel;
			LuaObject.checkType(l, 3, out playerLevel);
			dataSectionOperationalActivity.SetPlayerLevel(playerLevelUpOperationalActivity, playerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F3A RID: 98106 RVA: 0x006A1044 File Offset: 0x0069F244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddSpecificLoginTimes(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity;
			LuaObject.checkType<SpecificDaysLoginOperationalActivity>(l, 2, out specificDaysLoginOperationalActivity);
			long time;
			LuaObject.checkType(l, 3, out time);
			dataSectionOperationalActivity.AddSpecificLoginTimes(specificDaysLoginOperationalActivity, time);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F3B RID: 98107 RVA: 0x006A10A8 File Offset: 0x0069F2A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity;
			LuaObject.checkType<LimitedTimeExchangeOperationActivity>(l, 2, out limitedTimeExchangeOperationActivity);
			int itemGroupId;
			LuaObject.checkType(l, 3, out itemGroupId);
			dataSectionOperationalActivity.ExchangeItemGroup(limitedTimeExchangeOperationActivity, itemGroupId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F3C RID: 98108 RVA: 0x006A110C File Offset: 0x0069F30C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GainReward(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			AwardOperationalActivityBase operationalActivity;
			LuaObject.checkType<AwardOperationalActivityBase>(l, 2, out operationalActivity);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			dataSectionOperationalActivity.GainReward(operationalActivity, rewardIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F3D RID: 98109 RVA: 0x006A1170 File Offset: 0x0069F370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			dataSectionOperationalActivity.ClearOperationalActivities();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F3E RID: 98110 RVA: 0x006A11BC File Offset: 0x0069F3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddNewOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			dataSectionOperationalActivity.AddNewOperationalActivity(operationalActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F3F RID: 98111 RVA: 0x006A1214 File Offset: 0x0069F414
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RemoveExpiredOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			OperationalActivityBase operatinoalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operatinoalActivity);
			dataSectionOperationalActivity.RemoveExpiredOperationalActivity(operatinoalActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F40 RID: 98112 RVA: 0x006A126C File Offset: 0x0069F46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAdvertisementLayout(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			dataSectionOperationalActivity.ClearAdvertisementLayout();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F41 RID: 98113 RVA: 0x006A12B8 File Offset: 0x0069F4B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitAdvertisementLayout(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			AdvertisementFlowLayout layout;
			LuaObject.checkType<AdvertisementFlowLayout>(l, 2, out layout);
			dataSectionOperationalActivity.InitAdvertisementLayout(layout);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F42 RID: 98114 RVA: 0x006A1310 File Offset: 0x0069F510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllAdvertisementFlowLayouts(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			List<AdvertisementFlowLayout> allAdvertisementFlowLayouts = dataSectionOperationalActivity.GetAllAdvertisementFlowLayouts();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allAdvertisementFlowLayouts);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F43 RID: 98115 RVA: 0x006A1364 File Offset: 0x0069F564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			DataSectionOperationalActivity dataSectionOperationalActivity = (DataSectionOperationalActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dataSectionOperationalActivity.AllOperationalActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017F44 RID: 98116 RVA: 0x006A13B8 File Offset: 0x0069F5B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.DataSectionOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.ClearInitedData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.SerializeToClient);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.FindOperationalActivityById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.FindOperationalActivitiesByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.InitOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.SetOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.AddAccumulateLoginTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.AddRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.AddConsumeCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.SetPlayerLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.AddSpecificLoginTimes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.ExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.GainReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.ClearOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.AddNewOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.RemoveExpiredOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.ClearAdvertisementLayout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.InitAdvertisementLayout);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.GetAllAdvertisementFlowLayouts);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache12);
		string name = "AllOperationalActivities";
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.get_AllOperationalActivities);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache13, null, true);
		if (Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_DataSectionOperationalActivity.<>f__mg$cache14, typeof(DataSectionOperationalActivity), typeof(DataSection));
	}

	// Token: 0x0400E4FF RID: 58623
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E500 RID: 58624
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E501 RID: 58625
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E502 RID: 58626
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E503 RID: 58627
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E504 RID: 58628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E505 RID: 58629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E506 RID: 58630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E507 RID: 58631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E508 RID: 58632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E509 RID: 58633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E50A RID: 58634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E50B RID: 58635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E50C RID: 58636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E50D RID: 58637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E50E RID: 58638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E50F RID: 58639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E510 RID: 58640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E511 RID: 58641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E512 RID: 58642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E513 RID: 58643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;
}
