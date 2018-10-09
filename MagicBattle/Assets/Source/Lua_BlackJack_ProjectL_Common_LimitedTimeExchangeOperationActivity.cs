using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200124C RID: 4684
[Preserve]
public class Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity : LuaObject
{
	// Token: 0x0601859A RID: 99738 RVA: 0x006D0B48 File Offset: 0x006CED48
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
				LimitedTimeExchangeOperationActivity o = new LimitedTimeExchangeOperationActivity();
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
				LimitedTimeExchangeOperationActivity o = new LimitedTimeExchangeOperationActivity(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x0601859B RID: 99739 RVA: 0x006D0BF8 File Offset: 0x006CEDF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			ProLimitedTimeExchangeOperationActivity pbOperationalActivity;
			LuaObject.checkType<ProLimitedTimeExchangeOperationActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			limitedTimeExchangeOperationActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601859C RID: 99740 RVA: 0x006D0C5C File Offset: 0x006CEE5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			limitedTimeExchangeOperationActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601859D RID: 99741 RVA: 0x006D0CB4 File Offset: 0x006CEEB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			ProLimitedTimeExchangeOperationActivity o = limitedTimeExchangeOperationActivity.SerializeToPB();
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

	// Token: 0x0601859E RID: 99742 RVA: 0x006D0D08 File Offset: 0x006CEF08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanExchangeOperationalActivityItem(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			int itemGroupIndex;
			LuaObject.checkType(l, 2, out itemGroupIndex);
			int exchangeTimes;
			LuaObject.checkType(l, 3, out exchangeTimes);
			int i = limitedTimeExchangeOperationActivity.CanExchangeOperationalActivityItem(itemGroupIndex, exchangeTimes);
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

	// Token: 0x0601859F RID: 99743 RVA: 0x006D0D78 File Offset: 0x006CEF78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddOperationalActivityItemExchangeTimes(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			int itemGroupIndex;
			LuaObject.checkType(l, 2, out itemGroupIndex);
			int exchangeTimes;
			LuaObject.checkType(l, 3, out exchangeTimes);
			int i = limitedTimeExchangeOperationActivity.AddOperationalActivityItemExchangeTimes(itemGroupIndex, exchangeTimes);
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

	// Token: 0x060185A0 RID: 99744 RVA: 0x006D0DE8 File Offset: 0x006CEFE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ExchangedItemGroups(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, limitedTimeExchangeOperationActivity.ExchangedItemGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185A1 RID: 99745 RVA: 0x006D0E3C File Offset: 0x006CF03C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ExchangedItemGroups(IntPtr l)
	{
		int result;
		try
		{
			LimitedTimeExchangeOperationActivity limitedTimeExchangeOperationActivity = (LimitedTimeExchangeOperationActivity)LuaObject.checkSelf(l);
			Dictionary<int, int> exchangedItemGroups;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out exchangedItemGroups);
			limitedTimeExchangeOperationActivity.ExchangedItemGroups = exchangedItemGroups;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060185A2 RID: 99746 RVA: 0x006D0E94 File Offset: 0x006CF094
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.LimitedTimeExchangeOperationActivity");
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.CanExchangeOperationalActivityItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.AddOperationalActivityItemExchangeTimes);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache4);
		string name = "ExchangedItemGroups";
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.get_ExchangedItemGroups);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.set_ExchangedItemGroups);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_LimitedTimeExchangeOperationActivity.<>f__mg$cache7, typeof(LimitedTimeExchangeOperationActivity), typeof(OperationalActivityBase));
	}

	// Token: 0x0400EAE4 RID: 60132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EAE5 RID: 60133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EAE6 RID: 60134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EAE7 RID: 60135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EAE8 RID: 60136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EAE9 RID: 60137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EAEA RID: 60138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EAEB RID: 60139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
