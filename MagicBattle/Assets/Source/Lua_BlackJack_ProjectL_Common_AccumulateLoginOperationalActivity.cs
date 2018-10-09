using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B2 RID: 4530
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity : LuaObject
{
	// Token: 0x0601777E RID: 96126 RVA: 0x00668D5C File Offset: 0x00666F5C
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
				AccumulateLoginOperationalActivity o = new AccumulateLoginOperationalActivity();
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
				AccumulateLoginOperationalActivity o = new AccumulateLoginOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x0601777F RID: 96127 RVA: 0x00668E0C File Offset: 0x0066700C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			ProAccumulateLoginOperationalActivity pbOperationalActivity;
			LuaObject.checkType<ProAccumulateLoginOperationalActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			accumulateLoginOperationalActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017780 RID: 96128 RVA: 0x00668E70 File Offset: 0x00667070
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			accumulateLoginOperationalActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017781 RID: 96129 RVA: 0x00668EC8 File Offset: 0x006670C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			ProAccumulateLoginOperationalActivity o = accumulateLoginOperationalActivity.SerializeToPB();
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

	// Token: 0x06017782 RID: 96130 RVA: 0x00668F1C File Offset: 0x0066711C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGainRewardByIndex(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			int i = accumulateLoginOperationalActivity.CanGainRewardByIndex(rewardIndex, currentTime);
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

	// Token: 0x06017783 RID: 96131 RVA: 0x00668F8C File Offset: 0x0066718C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddLoginTime(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			DateTime time;
			LuaObject.checkValueType<DateTime>(l, 2, out time);
			bool b = accumulateLoginOperationalActivity.AddLoginTime(time);
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

	// Token: 0x06017784 RID: 96132 RVA: 0x00668FF0 File Offset: 0x006671F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SpecificLoginTimes(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accumulateLoginOperationalActivity.SpecificLoginTimes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017785 RID: 96133 RVA: 0x00669044 File Offset: 0x00667244
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SpecificLoginTimes(IntPtr l)
	{
		int result;
		try
		{
			AccumulateLoginOperationalActivity accumulateLoginOperationalActivity = (AccumulateLoginOperationalActivity)LuaObject.checkSelf(l);
			List<long> specificLoginTimes;
			LuaObject.checkType<List<long>>(l, 2, out specificLoginTimes);
			accumulateLoginOperationalActivity.SpecificLoginTimes = specificLoginTimes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017786 RID: 96134 RVA: 0x0066909C File Offset: 0x0066729C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AccumulateLoginOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.CanGainRewardByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.AddLoginTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache4);
		string name = "SpecificLoginTimes";
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.get_SpecificLoginTimes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.set_SpecificLoginTimes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AccumulateLoginOperationalActivity.<>f__mg$cache7, typeof(AccumulateLoginOperationalActivity), typeof(AwardOperationalActivityBase));
	}

	// Token: 0x0400DDFC RID: 56828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DDFD RID: 56829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DDFE RID: 56830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DDFF RID: 56831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DE00 RID: 56832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DE01 RID: 56833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DE02 RID: 56834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DE03 RID: 56835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
