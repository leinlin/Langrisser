using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B3 RID: 4531
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity : LuaObject
{
	// Token: 0x06017788 RID: 96136 RVA: 0x006691E8 File Offset: 0x006673E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				AccumulateRechargeOperationalActivity o = new AccumulateRechargeOperationalActivity();
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
				AccumulateRechargeOperationalActivity o = new AccumulateRechargeOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x06017789 RID: 96137 RVA: 0x00669298 File Offset: 0x00667498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			ProAccumulateRechargeOperationalActivity pbOperationalActivity;
			LuaObject.checkType<ProAccumulateRechargeOperationalActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			accumulateRechargeOperationalActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601778A RID: 96138 RVA: 0x006692FC File Offset: 0x006674FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			accumulateRechargeOperationalActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601778B RID: 96139 RVA: 0x00669354 File Offset: 0x00667554
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			ProAccumulateRechargeOperationalActivity o = accumulateRechargeOperationalActivity.SerializeToPB();
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

	// Token: 0x0601778C RID: 96140 RVA: 0x006693A8 File Offset: 0x006675A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainRewardByIndex(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			int i = accumulateRechargeOperationalActivity.CanGainRewardByIndex(rewardIndex, currentTime);
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

	// Token: 0x0601778D RID: 96141 RVA: 0x00669418 File Offset: 0x00667618
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			int addNums;
			LuaObject.checkType(l, 2, out addNums);
			accumulateRechargeOperationalActivity.AddRechargeRMB(addNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601778E RID: 96142 RVA: 0x00669470 File Offset: 0x00667670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AccumulateRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accumulateRechargeOperationalActivity.AccumulateRechargeRMB);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601778F RID: 96143 RVA: 0x006694C4 File Offset: 0x006676C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_AccumulateRechargeRMB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateRechargeOperationalActivity accumulateRechargeOperationalActivity = (AccumulateRechargeOperationalActivity)LuaObject.checkSelf(l);
			int accumulateRechargeRMB;
			LuaObject.checkType(l, 2, out accumulateRechargeRMB);
			accumulateRechargeOperationalActivity.AccumulateRechargeRMB = accumulateRechargeRMB;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017790 RID: 96144 RVA: 0x0066951C File Offset: 0x0066771C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AccumulateRechargeOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.CanGainRewardByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.AddRechargeRMB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache4);
		string name = "AccumulateRechargeRMB";
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.get_AccumulateRechargeRMB);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.set_AccumulateRechargeRMB);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AccumulateRechargeOperationalActivity.<>f__mg$cache7, typeof(AccumulateRechargeOperationalActivity), typeof(AwardOperationalActivityBase));
	}

	// Token: 0x0400DE04 RID: 56836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DE05 RID: 56837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DE06 RID: 56838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DE07 RID: 56839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE08 RID: 56840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE09 RID: 56841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE0A RID: 56842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE0B RID: 56843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
