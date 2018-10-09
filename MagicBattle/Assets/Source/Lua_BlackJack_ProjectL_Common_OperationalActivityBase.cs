using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001255 RID: 4693
[Preserve]
public class Lua_BlackJack_ProjectL_Common_OperationalActivityBase : LuaObject
{
	// Token: 0x06018715 RID: 100117 RVA: 0x006DC00C File Offset: 0x006DA20C
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
				OperationalActivityBase o = new OperationalActivityBase();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 4)
			{
				ulong instanceId;
				LuaObject.checkType(l, 2, out instanceId);
				int operationalActivityId;
				LuaObject.checkType(l, 3, out operationalActivityId);
				OperationalActivityType operationalActivityType;
				LuaObject.checkEnum<OperationalActivityType>(l, 4, out operationalActivityType);
				OperationalActivityBase o = new OperationalActivityBase(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x06018716 RID: 100118 RVA: 0x006DC0BC File Offset: 0x006DA2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToInfoString(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			string s = operationalActivityBase.ToInfoString();
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

	// Token: 0x06018717 RID: 100119 RVA: 0x006DC110 File Offset: 0x006DA310
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			operationalActivityBase.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018718 RID: 100120 RVA: 0x006DC168 File Offset: 0x006DA368
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBOperationalActivityBasicData(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			ProOperationalActivityBasicInfo o = operationalActivityBase.ToPBOperationalActivityBasicData();
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

	// Token: 0x06018719 RID: 100121 RVA: 0x006DC1BC File Offset: 0x006DA3BC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int InitOperationalActivityTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime operationStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out operationStartTime);
			DateTime operationEndTime;
			LuaObject.checkValueType<DateTime>(l, 3, out operationEndTime);
			DateTime gainRewardEndTime;
			LuaObject.checkValueType<DateTime>(l, 4, out gainRewardEndTime);
			DateTime operationShowTime;
			LuaObject.checkValueType<DateTime>(l, 5, out operationShowTime);
			operationalActivityBase.InitOperationalActivityTime(operationStartTime, operationEndTime, gainRewardEndTime, operationShowTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601871A RID: 100122 RVA: 0x006DC23C File Offset: 0x006DA43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInOperationPeriod(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			bool b = operationalActivityBase.IsInOperationPeriod(time);
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

	// Token: 0x0601871B RID: 100123 RVA: 0x006DC2A0 File Offset: 0x006DA4A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInOperationShowPeriod(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			bool b = operationalActivityBase.IsInOperationShowPeriod(time);
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

	// Token: 0x0601871C RID: 100124 RVA: 0x006DC304 File Offset: 0x006DA504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsInGainRewardPeriod(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			bool b = operationalActivityBase.IsInGainRewardPeriod(time);
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

	// Token: 0x0601871D RID: 100125 RVA: 0x006DC368 File Offset: 0x006DA568
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsExpiredOperationalActivity(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 2, out currentTime);
			bool b = operationalActivityBase.IsExpiredOperationalActivity(currentTime);
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

	// Token: 0x0601871E RID: 100126 RVA: 0x006DC3CC File Offset: 0x006DA5CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetExpiredTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime expiredTime = operationalActivityBase.GetExpiredTime();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, expiredTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601871F RID: 100127 RVA: 0x006DC428 File Offset: 0x006DA628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetInitialTimeInOneDay(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			DateTime initialTimeInOneDay = operationalActivityBase.GetInitialTimeInOneDay(time);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, initialTimeInOneDay);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018720 RID: 100128 RVA: 0x006DC490 File Offset: 0x006DA690
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OperationShowTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.OperationShowTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018721 RID: 100129 RVA: 0x006DC4E8 File Offset: 0x006DA6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationShowTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime operationShowTime;
			LuaObject.checkValueType<DateTime>(l, 2, out operationShowTime);
			operationalActivityBase.OperationShowTime = operationShowTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018722 RID: 100130 RVA: 0x006DC540 File Offset: 0x006DA740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OperationStartTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.OperationStartTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018723 RID: 100131 RVA: 0x006DC598 File Offset: 0x006DA798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationStartTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime operationStartTime;
			LuaObject.checkValueType<DateTime>(l, 2, out operationStartTime);
			operationalActivityBase.OperationStartTime = operationStartTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018724 RID: 100132 RVA: 0x006DC5F0 File Offset: 0x006DA7F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OperationEndTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.OperationEndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018725 RID: 100133 RVA: 0x006DC648 File Offset: 0x006DA848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_OperationEndTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime operationEndTime;
			LuaObject.checkValueType<DateTime>(l, 2, out operationEndTime);
			operationalActivityBase.OperationEndTime = operationEndTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018726 RID: 100134 RVA: 0x006DC6A0 File Offset: 0x006DA8A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GainRewardEndTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.GainRewardEndTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018727 RID: 100135 RVA: 0x006DC6F8 File Offset: 0x006DA8F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GainRewardEndTime(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			DateTime gainRewardEndTime;
			LuaObject.checkValueType<DateTime>(l, 2, out gainRewardEndTime);
			operationalActivityBase.GainRewardEndTime = gainRewardEndTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018728 RID: 100136 RVA: 0x006DC750 File Offset: 0x006DA950
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DaysAfterPlayerCreated(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.DaysAfterPlayerCreated);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018729 RID: 100137 RVA: 0x006DC7A4 File Offset: 0x006DA9A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DaysAfterPlayerCreated(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			int daysAfterPlayerCreated;
			LuaObject.checkType(l, 2, out daysAfterPlayerCreated);
			operationalActivityBase.DaysAfterPlayerCreated = daysAfterPlayerCreated;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601872A RID: 100138 RVA: 0x006DC7FC File Offset: 0x006DA9FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601872B RID: 100139 RVA: 0x006DC850 File Offset: 0x006DAA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			operationalActivityBase.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601872C RID: 100140 RVA: 0x006DC8A8 File Offset: 0x006DAAA8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.ActivityId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601872D RID: 100141 RVA: 0x006DC8FC File Offset: 0x006DAAFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityId(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			int activityId;
			LuaObject.checkType(l, 2, out activityId);
			operationalActivityBase.ActivityId = activityId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601872E RID: 100142 RVA: 0x006DC954 File Offset: 0x006DAB54
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ActivityType(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)operationalActivityBase.ActivityType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601872F RID: 100143 RVA: 0x006DC9A8 File Offset: 0x006DABA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ActivityType(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			OperationalActivityType activityType;
			LuaObject.checkEnum<OperationalActivityType>(l, 2, out activityType);
			operationalActivityBase.ActivityType = activityType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018730 RID: 100144 RVA: 0x006DCA00 File Offset: 0x006DAC00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, operationalActivityBase.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018731 RID: 100145 RVA: 0x006DCA54 File Offset: 0x006DAC54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Config(IntPtr l)
	{
		int result;
		try
		{
			OperationalActivityBase operationalActivityBase = (OperationalActivityBase)LuaObject.checkSelf(l);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 2, out config);
			operationalActivityBase.Config = config;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018732 RID: 100146 RVA: 0x006DCAAC File Offset: 0x006DACAC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.OperationalActivityBase");
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.ToInfoString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.ToPBOperationalActivityBasicData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.InitOperationalActivityTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.IsInOperationPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.IsInOperationShowPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.IsInGainRewardPeriod);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.IsExpiredOperationalActivity);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.GetExpiredTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.GetInitialTimeInOneDay);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache9);
		string name = "OperationShowTime";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_OperationShowTime);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_OperationShowTime);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheB, true);
		string name2 = "OperationStartTime";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_OperationStartTime);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_OperationStartTime);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheD, true);
		string name3 = "OperationEndTime";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_OperationEndTime);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_OperationEndTime);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cacheF, true);
		string name4 = "GainRewardEndTime";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_GainRewardEndTime);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_GainRewardEndTime);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache11, true);
		string name5 = "DaysAfterPlayerCreated";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_DaysAfterPlayerCreated);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_DaysAfterPlayerCreated);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache13, true);
		string name6 = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_InstanceId);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_InstanceId);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache15, true);
		string name7 = "ActivityId";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_ActivityId);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_ActivityId);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache17, true);
		string name8 = "ActivityType";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_ActivityType);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_ActivityType);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache19, true);
		string name9 = "Config";
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.get_Config);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.set_Config);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1B, true);
		if (Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_OperationalActivityBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_OperationalActivityBase.<>f__mg$cache1C, typeof(OperationalActivityBase));
	}

	// Token: 0x0400EC4D RID: 60493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EC4E RID: 60494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EC4F RID: 60495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EC50 RID: 60496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EC51 RID: 60497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EC52 RID: 60498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EC53 RID: 60499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EC54 RID: 60500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EC55 RID: 60501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EC56 RID: 60502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EC57 RID: 60503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EC58 RID: 60504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EC59 RID: 60505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EC5A RID: 60506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EC5B RID: 60507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EC5C RID: 60508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EC5D RID: 60509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EC5E RID: 60510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EC5F RID: 60511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EC60 RID: 60512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400EC61 RID: 60513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400EC62 RID: 60514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400EC63 RID: 60515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400EC64 RID: 60516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400EC65 RID: 60517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400EC66 RID: 60518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400EC67 RID: 60519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400EC68 RID: 60520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400EC69 RID: 60521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;
}
