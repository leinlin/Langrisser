using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001256 RID: 4694
[Preserve]
public class Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon : LuaObject
{
	// Token: 0x06018734 RID: 100148 RVA: 0x006DCED0 File Offset: 0x006DB0D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon o = new OperationalActivityCompomentCommon();
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

	// Token: 0x06018735 RID: 100149 RVA: 0x006DCF18 File Offset: 0x006DB118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			string name = operationalActivityCompomentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018736 RID: 100150 RVA: 0x006DCF6C File Offset: 0x006DB16C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			operationalActivityCompomentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018737 RID: 100151 RVA: 0x006DCFB8 File Offset: 0x006DB1B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			operationalActivityCompomentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018738 RID: 100152 RVA: 0x006DD004 File Offset: 0x006DB204
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			operationalActivityCompomentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018739 RID: 100153 RVA: 0x006DD050 File Offset: 0x006DB250
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			operationalActivityCompomentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601873A RID: 100154 RVA: 0x006DD0A8 File Offset: 0x006DB2A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			operationalActivityCompomentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601873B RID: 100155 RVA: 0x006DD0F4 File Offset: 0x006DB2F4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnFlushLoginDaysEvent(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			operationalActivityCompomentCommon.OnFlushLoginDaysEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601873C RID: 100156 RVA: 0x006DD140 File Offset: 0x006DB340
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnPlayerLevelUpEvent(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int palyerLevel;
			LuaObject.checkType(l, 2, out palyerLevel);
			operationalActivityCompomentCommon.OnPlayerLevelUpEvent(palyerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601873D RID: 100157 RVA: 0x006DD198 File Offset: 0x006DB398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllExpiredOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			operationalActivityCompomentCommon.RemoveAllExpiredOperationalActivities();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601873E RID: 100158 RVA: 0x006DD1E4 File Offset: 0x006DB3E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationalActivity;
			LuaObject.checkType<LimitedTimeExchangeOperationActivity>(l, 2, out limitedTimeExchangeOperationalActivity);
			int itemGroupIndex;
			LuaObject.checkType(l, 3, out itemGroupIndex);
			int i = operationalActivityCompomentCommon.CanExchangeItemGroup(limitedTimeExchangeOperationalActivity, itemGroupIndex);
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

	// Token: 0x0601873F RID: 100159 RVA: 0x006DD254 File Offset: 0x006DB454
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainOperactionalActivityReward(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivityBase;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivityBase);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			int i = operationalActivityCompomentCommon.CanGainOperactionalActivityReward(operationalActivityBase, rewardIndex);
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

	// Token: 0x06018740 RID: 100160 RVA: 0x006DD2C4 File Offset: 0x006DB4C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			List<OperationalActivityBase> allOperationalActivities = operationalActivityCompomentCommon.GetAllOperationalActivities();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allOperationalActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018741 RID: 100161 RVA: 0x006DD318 File Offset: 0x006DB518
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAllValidOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			List<OperationalActivityBase> allValidOperationalActivities = operationalActivityCompomentCommon.GetAllValidOperationalActivities();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, allValidOperationalActivities);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018742 RID: 100162 RVA: 0x006DD36C File Offset: 0x006DB56C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOperationalActivityById(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			ulong operationalActivityInstanceId;
			LuaObject.checkType(l, 2, out operationalActivityInstanceId);
			OperationalActivityBase o = operationalActivityCompomentCommon.FindOperationalActivityById(operationalActivityInstanceId);
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

	// Token: 0x06018743 RID: 100163 RVA: 0x006DD3D0 File Offset: 0x006DB5D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindOperationalActivitiesByType(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityType activityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 2, out activityType);
			List<OperationalActivityBase> o = operationalActivityCompomentCommon.FindOperationalActivitiesByType(activityType);
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

	// Token: 0x06018744 RID: 100164 RVA: 0x006DD434 File Offset: 0x006DB634
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOperationalActivityByActivityCardPoolId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			OperationalActivityBase o = operationalActivityCompomentCommon.FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
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

	// Token: 0x06018745 RID: 100165 RVA: 0x006DD498 File Offset: 0x006DB698
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int FindOperationalActivityByRafflePoolId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int rafflePoolId;
			LuaObject.checkType(l, 2, out rafflePoolId);
			OperationalActivityBase o = operationalActivityCompomentCommon.FindOperationalActivityByRafflePoolId(rafflePoolId);
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

	// Token: 0x06018746 RID: 100166 RVA: 0x006DD4FC File Offset: 0x006DB6FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindOperationalActivityByUnchartedScoreId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			OperationalActivityBase o = operationalActivityCompomentCommon.FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
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

	// Token: 0x06018747 RID: 100167 RVA: 0x006DD560 File Offset: 0x006DB760
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindShowActivityByUnchartedScoreId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			OperationalActivityBase o = operationalActivityCompomentCommon.FindShowActivityByUnchartedScoreId(unchartedScoreId);
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

	// Token: 0x06018748 RID: 100168 RVA: 0x006DD5C4 File Offset: 0x006DB7C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GetAllAdvertisementFlowLayouts(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			List<AdvertisementFlowLayout> allAdvertisementFlowLayouts = operationalActivityCompomentCommon.GetAllAdvertisementFlowLayouts();
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

	// Token: 0x06018749 RID: 100169 RVA: 0x006DD618 File Offset: 0x006DB818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBuyStoreItemCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			operationalActivityCompomentCommon.OnBuyStoreItemCallBack(storeId, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601874A RID: 100170 RVA: 0x006DD67C File Offset: 0x006DB87C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsEffectOperationalActivity_s(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityType operationalActivityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 1, out operationalActivityType);
			bool b = OperationalActivityCompomentCommon.IsEffectOperationalActivity(operationalActivityType);
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

	// Token: 0x0601874B RID: 100171 RVA: 0x006DD6D0 File Offset: 0x006DB8D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsAwardOperationActivity_s(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityType operationalActivityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 1, out operationalActivityType);
			bool b = OperationalActivityCompomentCommon.IsAwardOperationActivity(operationalActivityType);
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

	// Token: 0x0601874C RID: 100172 RVA: 0x006DD724 File Offset: 0x006DB924
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnFlushSuccessCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			operationalActivityCompomentCommon.m_luaExportHelper.OnFlushSuccessCallBack(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601874D RID: 100173 RVA: 0x006DD780 File Offset: 0x006DB980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddNewOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			operationalActivityCompomentCommon.m_luaExportHelper.AddNewOperationalActivity(operationalActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601874E RID: 100174 RVA: 0x006DD7DC File Offset: 0x006DB9DC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitNewNewOperationalActivityInfo(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivityInfo;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivityInfo);
			operationalActivityCompomentCommon.m_luaExportHelper.InitNewNewOperationalActivityInfo(operationalActivityInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601874F RID: 100175 RVA: 0x006DD838 File Offset: 0x006DBA38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddNewActivityCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			operationalActivityCompomentCommon.m_luaExportHelper.OnAddNewActivityCallBack(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018750 RID: 100176 RVA: 0x006DD894 File Offset: 0x006DBA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnActivityInitCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			operationalActivityCompomentCommon.m_luaExportHelper.OnActivityInitCallBack(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018751 RID: 100177 RVA: 0x006DD8F0 File Offset: 0x006DBAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAwardOperationActivityRewardItemGroupIdByIndex(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			int awardOperationActivityRewardItemGroupIdByIndex = operationalActivityCompomentCommon.m_luaExportHelper.GetAwardOperationActivityRewardItemGroupIdByIndex(operationalActivity, rewardIndex);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, awardOperationActivityRewardItemGroupIdByIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018752 RID: 100178 RVA: 0x006DD964 File Offset: 0x006DBB64
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int EffectOperationActivityGenerateEffect(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			bool isPositive;
			LuaObject.checkType(l, 3, out isPositive);
			operationalActivityCompomentCommon.m_luaExportHelper.EffectOperationActivityGenerateEffect(operationalActivity, isPositive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018753 RID: 100179 RVA: 0x006DD9D0 File Offset: 0x006DBBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddRechargeRMBEvent(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			DateTime rechargeTime;
			LuaObject.checkValueType<DateTime>(l, 3, out rechargeTime);
			operationalActivityCompomentCommon.m_luaExportHelper.OnAddRechargeRMBEvent(nums, rechargeTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018754 RID: 100180 RVA: 0x006DDA3C File Offset: 0x006DBC3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConsumeCrystalEvent(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			int nums;
			LuaObject.checkType(l, 2, out nums);
			operationalActivityCompomentCommon.m_luaExportHelper.OnConsumeCrystalEvent(nums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018755 RID: 100181 RVA: 0x006DDA98 File Offset: 0x006DBC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018756 RID: 100182 RVA: 0x006DDAF0 File Offset: 0x006DBCF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			operationalActivityCompomentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018757 RID: 100183 RVA: 0x006DDB4C File Offset: 0x006DBD4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018758 RID: 100184 RVA: 0x006DDBA4 File Offset: 0x006DBDA4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			operationalActivityCompomentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018759 RID: 100185 RVA: 0x006DDC00 File Offset: 0x006DBE00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bag(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_bag);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601875A RID: 100186 RVA: 0x006DDC58 File Offset: 0x006DBE58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_bag(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			BagComponentCommon bag;
			LuaObject.checkType<BagComponentCommon>(l, 2, out bag);
			operationalActivityCompomentCommon.m_luaExportHelper.m_bag = bag;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601875B RID: 100187 RVA: 0x006DDCB4 File Offset: 0x006DBEB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_anikiGym);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601875C RID: 100188 RVA: 0x006DDD0C File Offset: 0x006DBF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_anikiGym(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			AnikiGymComponentCommon anikiGym;
			LuaObject.checkType<AnikiGymComponentCommon>(l, 2, out anikiGym);
			operationalActivityCompomentCommon.m_luaExportHelper.m_anikiGym = anikiGym;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601875D RID: 100189 RVA: 0x006DDD68 File Offset: 0x006DBF68
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_thearchyTrial);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601875E RID: 100190 RVA: 0x006DDDC0 File Offset: 0x006DBFC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyTrial(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			ThearchyTrialCompomentCommon thearchyTrial;
			LuaObject.checkType<ThearchyTrialCompomentCommon>(l, 2, out thearchyTrial);
			operationalActivityCompomentCommon.m_luaExportHelper.m_thearchyTrial = thearchyTrial;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601875F RID: 100191 RVA: 0x006DDE1C File Offset: 0x006DC01C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rift(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_rift);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018760 RID: 100192 RVA: 0x006DDE74 File Offset: 0x006DC074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_rift(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			RiftComponentCommon rift;
			LuaObject.checkType<RiftComponentCommon>(l, 2, out rift);
			operationalActivityCompomentCommon.m_luaExportHelper.m_rift = rift;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018761 RID: 100193 RVA: 0x006DDED0 File Offset: 0x006DC0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_selectCard(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_selectCard);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018762 RID: 100194 RVA: 0x006DDF28 File Offset: 0x006DC128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_selectCard(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			SelectCardComponentCommon selectCard;
			LuaObject.checkType<SelectCardComponentCommon>(l, 2, out selectCard);
			operationalActivityCompomentCommon.m_luaExportHelper.m_selectCard = selectCard;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018763 RID: 100195 RVA: 0x006DDF84 File Offset: 0x006DC184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDungeon(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_heroDungeon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018764 RID: 100196 RVA: 0x006DDFDC File Offset: 0x006DC1DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDungeon(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			HeroDungeonComponentCommon heroDungeon;
			LuaObject.checkType<HeroDungeonComponentCommon>(l, 2, out heroDungeon);
			operationalActivityCompomentCommon.m_luaExportHelper.m_heroDungeon = heroDungeon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018765 RID: 100197 RVA: 0x006DE038 File Offset: 0x006DC238
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_raffle(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_raffle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018766 RID: 100198 RVA: 0x006DE090 File Offset: 0x006DC290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_raffle(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			RaffleComponentCommon raffle;
			LuaObject.checkType<RaffleComponentCommon>(l, 2, out raffle);
			operationalActivityCompomentCommon.m_luaExportHelper.m_raffle = raffle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018767 RID: 100199 RVA: 0x006DE0EC File Offset: 0x006DC2EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_unchartedScore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_unchartedScore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018768 RID: 100200 RVA: 0x006DE144 File Offset: 0x006DC344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			UnchartedScoreComponentCommon unchartedScore;
			LuaObject.checkType<UnchartedScoreComponentCommon>(l, 2, out unchartedScore);
			operationalActivityCompomentCommon.m_luaExportHelper.m_unchartedScore = unchartedScore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018769 RID: 100201 RVA: 0x006DE1A0 File Offset: 0x006DC3A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_fixedStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_fixedStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601876A RID: 100202 RVA: 0x006DE1F8 File Offset: 0x006DC3F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_fixedStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			FixedStoreComponentCommon fixedStore;
			LuaObject.checkType<FixedStoreComponentCommon>(l, 2, out fixedStore);
			operationalActivityCompomentCommon.m_luaExportHelper.m_fixedStore = fixedStore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601876B RID: 100203 RVA: 0x006DE254 File Offset: 0x006DC454
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_randomStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_randomStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601876C RID: 100204 RVA: 0x006DE2AC File Offset: 0x006DC4AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_randomStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			RandomStoreComponentCommon randomStore;
			LuaObject.checkType<RandomStoreComponentCommon>(l, 2, out randomStore);
			operationalActivityCompomentCommon.m_luaExportHelper.m_randomStore = randomStore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601876D RID: 100205 RVA: 0x006DE308 File Offset: 0x006DC508
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_giftStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_giftStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601876E RID: 100206 RVA: 0x006DE360 File Offset: 0x006DC560
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_giftStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			GiftStoreComponentCommon giftStore;
			LuaObject.checkType<GiftStoreComponentCommon>(l, 2, out giftStore);
			operationalActivityCompomentCommon.m_luaExportHelper.m_giftStore = giftStore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601876F RID: 100207 RVA: 0x006DE3BC File Offset: 0x006DC5BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rechargeStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_rechargeStore);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018770 RID: 100208 RVA: 0x006DE414 File Offset: 0x006DC614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rechargeStore(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			RechargeStoreComponentCommon rechargeStore;
			LuaObject.checkType<RechargeStoreComponentCommon>(l, 2, out rechargeStore);
			operationalActivityCompomentCommon.m_luaExportHelper.m_rechargeStore = rechargeStore;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018771 RID: 100209 RVA: 0x006DE470 File Offset: 0x006DC670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_operationalActivityDS(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_operationalActivityDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018772 RID: 100210 RVA: 0x006DE4C8 File Offset: 0x006DC6C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_operationalActivityDS(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			DataSectionOperationalActivity operationalActivityDS;
			LuaObject.checkType<DataSectionOperationalActivity>(l, 2, out operationalActivityDS);
			operationalActivityCompomentCommon.m_luaExportHelper.m_operationalActivityDS = operationalActivityDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018773 RID: 100211 RVA: 0x006DE524 File Offset: 0x006DC724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_announcementDS(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.m_luaExportHelper.m_announcementDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018774 RID: 100212 RVA: 0x006DE57C File Offset: 0x006DC77C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_announcementDS(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			DataSectionAnnouncement announcementDS;
			LuaObject.checkType<DataSectionAnnouncement>(l, 2, out announcementDS);
			operationalActivityCompomentCommon.m_luaExportHelper.m_announcementDS = announcementDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018775 RID: 100213 RVA: 0x006DE5D8 File Offset: 0x006DC7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityCompomentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018776 RID: 100214 RVA: 0x006DE62C File Offset: 0x006DC82C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompomentCommon operationalActivityCompomentCommon = (OperationalActivityCompomentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			operationalActivityCompomentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018777 RID: 100215 RVA: 0x006DE684 File Offset: 0x006DC884
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.OperationalActivityCompomentCommon");
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnFlushLoginDaysEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnPlayerLevelUpEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.RemoveAllExpiredOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.CanExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.CanGainOperactionalActivityReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.GetAllOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.GetAllValidOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.FindOperationalActivityById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.FindOperationalActivitiesByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.FindOperationalActivityByActivityCardPoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.FindOperationalActivityByRafflePoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.FindOperationalActivityByUnchartedScoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.FindShowActivityByUnchartedScoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.GetAllAdvertisementFlowLayouts);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnBuyStoreItemCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.IsEffectOperationalActivity_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.IsAwardOperationActivity_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnFlushSuccessCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.AddNewOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.InitNewNewOperationalActivityInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnAddNewActivityCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnActivityInitCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.GetAwardOperationActivityRewardItemGroupIdByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.EffectOperationActivityGenerateEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnAddRechargeRMBEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.OnConsumeCrystalEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache1F);
		string name = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache21, true);
		string name2 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_basicInfo);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache23, true);
		string name3 = "m_bag";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_bag);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_bag);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache25, true);
		string name4 = "m_anikiGym";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_anikiGym);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_anikiGym);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache27, true);
		string name5 = "m_thearchyTrial";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_thearchyTrial);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_thearchyTrial);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache29, true);
		string name6 = "m_rift";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_rift);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_rift);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2B, true);
		string name7 = "m_selectCard";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_selectCard);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_selectCard);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2D, true);
		string name8 = "m_heroDungeon";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_heroDungeon);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_heroDungeon);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache2F, true);
		string name9 = "m_raffle";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_raffle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_raffle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache31, true);
		string name10 = "m_unchartedScore";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_unchartedScore);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_unchartedScore);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache33, true);
		string name11 = "m_fixedStore";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_fixedStore);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_fixedStore);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache35, true);
		string name12 = "m_randomStore";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_randomStore);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_randomStore);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache37, true);
		string name13 = "m_giftStore";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_giftStore);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_giftStore);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache39, true);
		string name14 = "m_rechargeStore";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_rechargeStore);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_rechargeStore);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3B, true);
		string name15 = "m_operationalActivityDS";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_operationalActivityDS);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_operationalActivityDS);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3D, true);
		string name16 = "m_announcementDS";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_m_announcementDS);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_m_announcementDS);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache3F, true);
		string name17 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.get_Owner);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.set_Owner);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache41, true);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_OperationalActivityCompomentCommon.<>f__mg$cache42, typeof(OperationalActivityCompomentCommon));
	}

	// Token: 0x0400EC6A RID: 60522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EC6B RID: 60523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EC6C RID: 60524
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EC6D RID: 60525
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EC6E RID: 60526
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EC6F RID: 60527
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EC70 RID: 60528
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EC71 RID: 60529
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EC72 RID: 60530
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EC73 RID: 60531
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EC74 RID: 60532
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EC75 RID: 60533
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EC76 RID: 60534
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EC77 RID: 60535
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EC78 RID: 60536
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EC79 RID: 60537
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EC7A RID: 60538
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EC7B RID: 60539
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EC7C RID: 60540
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EC7D RID: 60541
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EC7E RID: 60542
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EC7F RID: 60543
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EC80 RID: 60544
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EC81 RID: 60545
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EC82 RID: 60546
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EC83 RID: 60547
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EC84 RID: 60548
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EC85 RID: 60549
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EC86 RID: 60550
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400EC87 RID: 60551
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400EC88 RID: 60552
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400EC89 RID: 60553
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400EC8A RID: 60554
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400EC8B RID: 60555
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400EC8C RID: 60556
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400EC8D RID: 60557
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400EC8E RID: 60558
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400EC8F RID: 60559
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400EC90 RID: 60560
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400EC91 RID: 60561
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400EC92 RID: 60562
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400EC93 RID: 60563
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400EC94 RID: 60564
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400EC95 RID: 60565
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400EC96 RID: 60566
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0400EC97 RID: 60567
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0400EC98 RID: 60568
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0400EC99 RID: 60569
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0400EC9A RID: 60570
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0400EC9B RID: 60571
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0400EC9C RID: 60572
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0400EC9D RID: 60573
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0400EC9E RID: 60574
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0400EC9F RID: 60575
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0400ECA0 RID: 60576
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0400ECA1 RID: 60577
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0400ECA2 RID: 60578
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0400ECA3 RID: 60579
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0400ECA4 RID: 60580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0400ECA5 RID: 60581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0400ECA6 RID: 60582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0400ECA7 RID: 60583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0400ECA8 RID: 60584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0400ECA9 RID: 60585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0400ECAA RID: 60586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0400ECAB RID: 60587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0400ECAC RID: 60588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
