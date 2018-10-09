using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011C3 RID: 4547
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase : LuaObject
{
	// Token: 0x060178DA RID: 96474 RVA: 0x00672930 File Offset: 0x00670B30
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
				AwardOperationalActivityBase o = new AwardOperationalActivityBase();
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
				AwardOperationalActivityBase o = new AwardOperationalActivityBase(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x060178DB RID: 96475 RVA: 0x006729E0 File Offset: 0x00670BE0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGainRewardByIndex(IntPtr l)
	{
		int result;
		try
		{
			AwardOperationalActivityBase awardOperationalActivityBase = (AwardOperationalActivityBase)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			int i = awardOperationalActivityBase.CanGainRewardByIndex(rewardIndex, currentTime);
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

	// Token: 0x060178DC RID: 96476 RVA: 0x00672A50 File Offset: 0x00670C50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int GainReward(IntPtr l)
	{
		int result;
		try
		{
			AwardOperationalActivityBase awardOperationalActivityBase = (AwardOperationalActivityBase)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			awardOperationalActivityBase.GainReward(rewardIndex);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178DD RID: 96477 RVA: 0x00672AA8 File Offset: 0x00670CA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GainedRewardIndexs(IntPtr l)
	{
		int result;
		try
		{
			AwardOperationalActivityBase awardOperationalActivityBase = (AwardOperationalActivityBase)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, awardOperationalActivityBase.GainedRewardIndexs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178DE RID: 96478 RVA: 0x00672AFC File Offset: 0x00670CFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_GainedRewardIndexs(IntPtr l)
	{
		int result;
		try
		{
			AwardOperationalActivityBase awardOperationalActivityBase = (AwardOperationalActivityBase)LuaObject.checkSelf(l);
			List<int> gainedRewardIndexs;
			LuaObject.checkType<List<int>>(l, 2, out gainedRewardIndexs);
			awardOperationalActivityBase.GainedRewardIndexs = gainedRewardIndexs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060178DF RID: 96479 RVA: 0x00672B54 File Offset: 0x00670D54
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AwardOperationalActivityBase");
		if (Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.CanGainRewardByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.GainReward);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache1);
		string name = "GainedRewardIndexs";
		if (Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.get_GainedRewardIndexs);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.set_GainedRewardIndexs);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache3, true);
		if (Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AwardOperationalActivityBase.<>f__mg$cache4, typeof(AwardOperationalActivityBase), typeof(OperationalActivityBase));
	}

	// Token: 0x0400DF36 RID: 57142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DF37 RID: 57143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DF38 RID: 57144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DF39 RID: 57145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DF3A RID: 57146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;
}
