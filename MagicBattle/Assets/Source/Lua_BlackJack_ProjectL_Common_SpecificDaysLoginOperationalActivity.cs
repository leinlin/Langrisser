using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200127E RID: 4734
[Preserve]
public class Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity : LuaObject
{
	// Token: 0x06018AAC RID: 101036 RVA: 0x006F67C4 File Offset: 0x006F49C4
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
				SpecificDaysLoginOperationalActivity o = new SpecificDaysLoginOperationalActivity();
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
				SpecificDaysLoginOperationalActivity o = new SpecificDaysLoginOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x06018AAD RID: 101037 RVA: 0x006F6874 File Offset: 0x006F4A74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = (SpecificDaysLoginOperationalActivity)LuaObject.checkSelf(l);
			ProSpecificDaysLoginOperationalActivity pbOperationalActivity;
			LuaObject.checkType<ProSpecificDaysLoginOperationalActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			specificDaysLoginOperationalActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AAE RID: 101038 RVA: 0x006F68D8 File Offset: 0x006F4AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = (SpecificDaysLoginOperationalActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			specificDaysLoginOperationalActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AAF RID: 101039 RVA: 0x006F6930 File Offset: 0x006F4B30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = (SpecificDaysLoginOperationalActivity)LuaObject.checkSelf(l);
			ProSpecificDaysLoginOperationalActivity o = specificDaysLoginOperationalActivity.SerializeToPB();
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

	// Token: 0x06018AB0 RID: 101040 RVA: 0x006F6984 File Offset: 0x006F4B84
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int CanGainRewardByIndex(IntPtr l)
	{
		int result;
		try
		{
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = (SpecificDaysLoginOperationalActivity)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			int i = specificDaysLoginOperationalActivity.CanGainRewardByIndex(rewardIndex, currentTime);
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

	// Token: 0x06018AB1 RID: 101041 RVA: 0x006F69F4 File Offset: 0x006F4BF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SpecificLoginTimes(IntPtr l)
	{
		int result;
		try
		{
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = (SpecificDaysLoginOperationalActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, specificDaysLoginOperationalActivity.SpecificLoginTimes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AB2 RID: 101042 RVA: 0x006F6A48 File Offset: 0x006F4C48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_SpecificLoginTimes(IntPtr l)
	{
		int result;
		try
		{
			SpecificDaysLoginOperationalActivity specificDaysLoginOperationalActivity = (SpecificDaysLoginOperationalActivity)LuaObject.checkSelf(l);
			List<long> specificLoginTimes;
			LuaObject.checkType<List<long>>(l, 2, out specificLoginTimes);
			specificDaysLoginOperationalActivity.SpecificLoginTimes = specificLoginTimes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018AB3 RID: 101043 RVA: 0x006F6AA0 File Offset: 0x006F4CA0
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.SpecificDaysLoginOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.CanGainRewardByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache3);
		string name = "SpecificLoginTimes";
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.get_SpecificLoginTimes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.set_SpecificLoginTimes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_SpecificDaysLoginOperationalActivity.<>f__mg$cache6, typeof(SpecificDaysLoginOperationalActivity), typeof(AwardOperationalActivityBase));
	}

	// Token: 0x0400EF92 RID: 61330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EF93 RID: 61331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EF94 RID: 61332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EF95 RID: 61333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EF96 RID: 61334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EF97 RID: 61335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EF98 RID: 61336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
