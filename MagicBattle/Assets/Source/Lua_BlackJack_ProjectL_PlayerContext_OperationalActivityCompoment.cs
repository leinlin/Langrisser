using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012D5 RID: 4821
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment : LuaObject
{
	// Token: 0x0601971F RID: 104223 RVA: 0x007545DC File Offset: 0x007527DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment o = new OperationalActivityCompoment();
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

	// Token: 0x06019720 RID: 104224 RVA: 0x00754624 File Offset: 0x00752824
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019721 RID: 104225 RVA: 0x00754670 File Offset: 0x00752870
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019722 RID: 104226 RVA: 0x007546BC File Offset: 0x007528BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019723 RID: 104227 RVA: 0x00754708 File Offset: 0x00752908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ulong operationalActivityInstanceId;
			LuaObject.checkType(l, 2, out operationalActivityInstanceId);
			int itemGroupIndex;
			LuaObject.checkType(l, 3, out itemGroupIndex);
			int i = operationalActivityCompoment.ExchangeItemGroup(operationalActivityInstanceId, itemGroupIndex);
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

	// Token: 0x06019724 RID: 104228 RVA: 0x00754778 File Offset: 0x00752978
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GainReward(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ulong operationalActivityInstanceId;
			LuaObject.checkType(l, 2, out operationalActivityInstanceId);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			int i = operationalActivityCompoment.GainReward(operationalActivityInstanceId, rewardIndex);
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

	// Token: 0x06019725 RID: 104229 RVA: 0x007547E8 File Offset: 0x007529E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Deserialize(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(DSOperationalActivityNtf)))
			{
				OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
				DSOperationalActivityNtf ntf;
				LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
				operationalActivityCompoment.Deserialize(ntf);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(DSAnnouncementNtf)))
			{
				OperationalActivityCompoment operationalActivityCompoment2 = (OperationalActivityCompoment)LuaObject.checkSelf(l);
				DSAnnouncementNtf ntf2;
				LuaObject.checkType<DSAnnouncementNtf>(l, 2, out ntf2);
				operationalActivityCompoment2.Deserialize(ntf2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(AdvertisementFlowLayoutUpdateNtf)))
			{
				OperationalActivityCompoment operationalActivityCompoment3 = (OperationalActivityCompoment)LuaObject.checkSelf(l);
				AdvertisementFlowLayoutUpdateNtf ntf3;
				LuaObject.checkType<AdvertisementFlowLayoutUpdateNtf>(l, 2, out ntf3);
				operationalActivityCompoment3.Deserialize(ntf3);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function Deserialize to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019726 RID: 104230 RVA: 0x00754904 File Offset: 0x00752B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetDSVersion(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ushort dsversion = operationalActivityCompoment.GetDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, dsversion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019727 RID: 104231 RVA: 0x00754958 File Offset: 0x00752B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetAnnouncementDSVersion(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ushort announcementDSVersion = operationalActivityCompoment.GetAnnouncementDSVersion();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, announcementDSVersion);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019728 RID: 104232 RVA: 0x007549AC File Offset: 0x00752BAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddNewOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ProOperationalActivityBasicInfo operationalActivityBasicInfo;
			LuaObject.checkType<ProOperationalActivityBasicInfo>(l, 2, out operationalActivityBasicInfo);
			bool b = operationalActivityCompoment.AddNewOperationalActivity(operationalActivityBasicInfo);
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

	// Token: 0x06019729 RID: 104233 RVA: 0x00754A10 File Offset: 0x00752C10
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddRedeemActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			RedeemInfoAck info;
			LuaObject.checkType<RedeemInfoAck>(l, 3, out info);
			bool b = operationalActivityCompoment.AddRedeemActivity(activityId, info);
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

	// Token: 0x0601972A RID: 104234 RVA: 0x00754A80 File Offset: 0x00752C80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddFansRewardFromPBTCBTActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int activityID;
			LuaObject.checkType(l, 2, out activityID);
			long startDate;
			LuaObject.checkType(l, 3, out startDate);
			long endDate;
			LuaObject.checkType(l, 4, out endDate);
			bool isClaimed;
			LuaObject.checkType(l, 5, out isClaimed);
			bool b = operationalActivityCompoment.AddFansRewardFromPBTCBTActivity(activityID, startDate, endDate, isClaimed);
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

	// Token: 0x0601972B RID: 104235 RVA: 0x00754B08 File Offset: 0x00752D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ProAnnouncement pbAnnouncement;
			LuaObject.checkType<ProAnnouncement>(l, 2, out pbAnnouncement);
			operationalActivityCompoment.AddAnnouncement(pbAnnouncement);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601972C RID: 104236 RVA: 0x00754B60 File Offset: 0x00752D60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ProOperationalActivityBasicInfo opertioanlActivityInfo;
			LuaObject.checkType<ProOperationalActivityBasicInfo>(l, 2, out opertioanlActivityInfo);
			operationalActivityCompoment.UpdateOperationalActivity(opertioanlActivityInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601972D RID: 104237 RVA: 0x00754BB8 File Offset: 0x00752DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetValidAnnouncements(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			List<Announcement> validAnnouncements = operationalActivityCompoment.GetValidAnnouncements();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, validAnnouncements);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601972E RID: 104238 RVA: 0x00754C0C File Offset: 0x00752E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveGlobalAnnouncement(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			operationalActivityCompoment.RemoveGlobalAnnouncement(instanceId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601972F RID: 104239 RVA: 0x00754C64 File Offset: 0x00752E64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RemoveAllExpiredAnnouncements(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.RemoveAllExpiredAnnouncements();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019730 RID: 104240 RVA: 0x00754CB0 File Offset: 0x00752EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetName(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			string s = operationalActivityCompoment.m_luaExportHelper.__callBase_GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019731 RID: 104241 RVA: 0x00754D0C File Offset: 0x00752F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019732 RID: 104242 RVA: 0x00754D60 File Offset: 0x00752F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostInit(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.m_luaExportHelper.__callBase_PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019733 RID: 104243 RVA: 0x00754DB4 File Offset: 0x00752FB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_DeInit(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.m_luaExportHelper.__callBase_DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019734 RID: 104244 RVA: 0x00754E08 File Offset: 0x00753008
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Tick(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			operationalActivityCompoment.m_luaExportHelper.__callBase_Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019735 RID: 104245 RVA: 0x00754E64 File Offset: 0x00753064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.m_luaExportHelper.__callBase_PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019736 RID: 104246 RVA: 0x00754EB8 File Offset: 0x007530B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnFlushLoginDaysEvent(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.m_luaExportHelper.__callBase_OnFlushLoginDaysEvent();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019737 RID: 104247 RVA: 0x00754F0C File Offset: 0x0075310C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnFlushSuccessCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			operationalActivityCompoment.m_luaExportHelper.__callBase_OnFlushSuccessCallBack(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019738 RID: 104248 RVA: 0x00754F68 File Offset: 0x00753168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnPlayerLevelUpEvent(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int palyerLevel;
			LuaObject.checkType(l, 2, out palyerLevel);
			operationalActivityCompoment.m_luaExportHelper.__callBase_OnPlayerLevelUpEvent(palyerLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019739 RID: 104249 RVA: 0x00754FC4 File Offset: 0x007531C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_AddNewOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			operationalActivityCompoment.m_luaExportHelper.__callBase_AddNewOperationalActivity(operationalActivity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601973A RID: 104250 RVA: 0x00755020 File Offset: 0x00753220
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_InitNewNewOperationalActivityInfo(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivityInfo;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivityInfo);
			operationalActivityCompoment.m_luaExportHelper.__callBase_InitNewNewOperationalActivityInfo(operationalActivityInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601973B RID: 104251 RVA: 0x0075507C File Offset: 0x0075327C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnAddNewActivityCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			operationalActivityCompoment.m_luaExportHelper.__callBase_OnAddNewActivityCallBack(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601973C RID: 104252 RVA: 0x007550D8 File Offset: 0x007532D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnActivityInitCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase activity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out activity);
			operationalActivityCompoment.m_luaExportHelper.__callBase_OnActivityInitCallBack(activity);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601973D RID: 104253 RVA: 0x00755134 File Offset: 0x00753334
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_RemoveAllExpiredOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			operationalActivityCompoment.m_luaExportHelper.__callBase_RemoveAllExpiredOperationalActivities();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601973E RID: 104254 RVA: 0x00755188 File Offset: 0x00753388
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_CanExchangeItemGroup(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationalActivity;
			LuaObject.checkType<LimitedTimeExchangeOperationActivity>(l, 2, out limitedTimeExchangeOperationalActivity);
			int itemGroupIndex;
			LuaObject.checkType(l, 3, out itemGroupIndex);
			int i = operationalActivityCompoment.m_luaExportHelper.__callBase_CanExchangeItemGroup(limitedTimeExchangeOperationalActivity, itemGroupIndex);
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

	// Token: 0x0601973F RID: 104255 RVA: 0x007551FC File Offset: 0x007533FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_CanGainOperactionalActivityReward(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivityBase;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivityBase);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			int i = operationalActivityCompoment.m_luaExportHelper.__callBase_CanGainOperactionalActivityReward(operationalActivityBase, rewardIndex);
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

	// Token: 0x06019740 RID: 104256 RVA: 0x00755270 File Offset: 0x00753470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			List<OperationalActivityBase> o = operationalActivityCompoment.m_luaExportHelper.__callBase_GetAllOperationalActivities();
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

	// Token: 0x06019741 RID: 104257 RVA: 0x007552CC File Offset: 0x007534CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAllValidOperationalActivities(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			List<OperationalActivityBase> o = operationalActivityCompoment.m_luaExportHelper.__callBase_GetAllValidOperationalActivities();
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

	// Token: 0x06019742 RID: 104258 RVA: 0x00755328 File Offset: 0x00753528
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetAwardOperationActivityRewardItemGroupIdByIndex(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			int rewardIndex;
			LuaObject.checkType(l, 3, out rewardIndex);
			int i = operationalActivityCompoment.m_luaExportHelper.__callBase_GetAwardOperationActivityRewardItemGroupIdByIndex(operationalActivity, rewardIndex);
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

	// Token: 0x06019743 RID: 104259 RVA: 0x0075539C File Offset: 0x0075359C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_EffectOperationActivityGenerateEffect(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityBase operationalActivity;
			LuaObject.checkType<OperationalActivityBase>(l, 2, out operationalActivity);
			bool isPositive;
			LuaObject.checkType(l, 3, out isPositive);
			operationalActivityCompoment.m_luaExportHelper.__callBase_EffectOperationActivityGenerateEffect(operationalActivity, isPositive);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019744 RID: 104260 RVA: 0x00755408 File Offset: 0x00753608
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindOperationalActivityById(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			ulong operationalActivityInstanceId;
			LuaObject.checkType(l, 2, out operationalActivityInstanceId);
			OperationalActivityBase o = operationalActivityCompoment.m_luaExportHelper.__callBase_FindOperationalActivityById(operationalActivityInstanceId);
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

	// Token: 0x06019745 RID: 104261 RVA: 0x00755470 File Offset: 0x00753670
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindOperationalActivitiesByType(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			OperationalActivityType activityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 2, out activityType);
			List<OperationalActivityBase> o = operationalActivityCompoment.m_luaExportHelper.__callBase_FindOperationalActivitiesByType(activityType);
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

	// Token: 0x06019746 RID: 104262 RVA: 0x007554D8 File Offset: 0x007536D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindOperationalActivityByActivityCardPoolId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int activityCardPoolId;
			LuaObject.checkType(l, 2, out activityCardPoolId);
			OperationalActivityBase o = operationalActivityCompoment.m_luaExportHelper.__callBase_FindOperationalActivityByActivityCardPoolId(activityCardPoolId);
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

	// Token: 0x06019747 RID: 104263 RVA: 0x00755540 File Offset: 0x00753740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_FindOperationalActivityByRafflePoolId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int rafflePoolId;
			LuaObject.checkType(l, 2, out rafflePoolId);
			OperationalActivityBase o = operationalActivityCompoment.m_luaExportHelper.__callBase_FindOperationalActivityByRafflePoolId(rafflePoolId);
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

	// Token: 0x06019748 RID: 104264 RVA: 0x007555A8 File Offset: 0x007537A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindOperationalActivityByUnchartedScoreId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			OperationalActivityBase o = operationalActivityCompoment.m_luaExportHelper.__callBase_FindOperationalActivityByUnchartedScoreId(unchartedScoreId);
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

	// Token: 0x06019749 RID: 104265 RVA: 0x00755610 File Offset: 0x00753810
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_FindShowActivityByUnchartedScoreId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int unchartedScoreId;
			LuaObject.checkType(l, 2, out unchartedScoreId);
			OperationalActivityBase o = operationalActivityCompoment.m_luaExportHelper.__callBase_FindShowActivityByUnchartedScoreId(unchartedScoreId);
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

	// Token: 0x0601974A RID: 104266 RVA: 0x00755678 File Offset: 0x00753878
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_GetAllAdvertisementFlowLayouts(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			List<AdvertisementFlowLayout> o = operationalActivityCompoment.m_luaExportHelper.__callBase_GetAllAdvertisementFlowLayouts();
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

	// Token: 0x0601974B RID: 104267 RVA: 0x007556D4 File Offset: 0x007538D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBuyStoreItemCallBack(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityCompoment operationalActivityCompoment = (OperationalActivityCompoment)LuaObject.checkSelf(l);
			int storeId;
			LuaObject.checkType(l, 2, out storeId);
			int goodsId;
			LuaObject.checkType(l, 3, out goodsId);
			operationalActivityCompoment.m_luaExportHelper.__callBase_OnBuyStoreItemCallBack(storeId, goodsId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601974C RID: 104268 RVA: 0x00755740 File Offset: 0x00753940
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.OperationalActivityCompoment");
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.ExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.GainReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.Deserialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.GetDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.GetAnnouncementDSVersion);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.AddNewOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.AddRedeemActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.AddFansRewardFromPBTCBTActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.AddAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.UpdateOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.GetValidAnnouncements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.RemoveGlobalAnnouncement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.RemoveAllExpiredAnnouncements);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_OnFlushLoginDaysEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_OnFlushSuccessCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_OnPlayerLevelUpEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_AddNewOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_InitNewNewOperationalActivityInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_OnAddNewActivityCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_OnActivityInitCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_RemoveAllExpiredOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_CanExchangeItemGroup);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_CanGainOperactionalActivityReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_GetAllOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_GetAllValidOperationalActivities);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_GetAwardOperationActivityRewardItemGroupIdByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_EffectOperationActivityGenerateEffect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_FindOperationalActivityById);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_FindOperationalActivitiesByType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_FindOperationalActivityByActivityCardPoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_FindOperationalActivityByRafflePoolId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_FindOperationalActivityByUnchartedScoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_FindShowActivityByUnchartedScoreId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_GetAllAdvertisementFlowLayouts);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.__callBase_OnBuyStoreItemCallBack);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_OperationalActivityCompoment.<>f__mg$cache2C, typeof(OperationalActivityCompoment), typeof(OperationalActivityCompomentCommon));
	}

	// Token: 0x0400FB57 RID: 64343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400FB58 RID: 64344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400FB59 RID: 64345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400FB5A RID: 64346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400FB5B RID: 64347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400FB5C RID: 64348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400FB5D RID: 64349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400FB5E RID: 64350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400FB5F RID: 64351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400FB60 RID: 64352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400FB61 RID: 64353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400FB62 RID: 64354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400FB63 RID: 64355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400FB64 RID: 64356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400FB65 RID: 64357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400FB66 RID: 64358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400FB67 RID: 64359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400FB68 RID: 64360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400FB69 RID: 64361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400FB6A RID: 64362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400FB6B RID: 64363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400FB6C RID: 64364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400FB6D RID: 64365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400FB6E RID: 64366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400FB6F RID: 64367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400FB70 RID: 64368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400FB71 RID: 64369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400FB72 RID: 64370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400FB73 RID: 64371
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400FB74 RID: 64372
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400FB75 RID: 64373
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0400FB76 RID: 64374
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0400FB77 RID: 64375
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0400FB78 RID: 64376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0400FB79 RID: 64377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0400FB7A RID: 64378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0400FB7B RID: 64379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0400FB7C RID: 64380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0400FB7D RID: 64381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0400FB7E RID: 64382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0400FB7F RID: 64383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x0400FB80 RID: 64384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x0400FB81 RID: 64385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x0400FB82 RID: 64386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x0400FB83 RID: 64387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;
}
