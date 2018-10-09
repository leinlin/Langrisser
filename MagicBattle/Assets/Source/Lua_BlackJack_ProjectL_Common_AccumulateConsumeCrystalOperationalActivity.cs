using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011B1 RID: 4529
[Preserve]
public class Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity : LuaObject
{
	// Token: 0x06017774 RID: 96116 RVA: 0x006688DC File Offset: 0x00666ADC
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
				AccumulateConsumeCrystalOperationalActivity o = new AccumulateConsumeCrystalOperationalActivity();
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
				AccumulateConsumeCrystalOperationalActivity o = new AccumulateConsumeCrystalOperationalActivity(instanceId, operationalActivityId, operationalActivityType);
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

	// Token: 0x06017775 RID: 96117 RVA: 0x0066898C File Offset: 0x00666B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int DeserializeFromPB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			ProAccumulateConsumeCrystalOperationalActivity pbOperationalActivity;
			LuaObject.checkType<ProAccumulateConsumeCrystalOperationalActivity>(l, 2, out pbOperationalActivity);
			ConfigDataOperationalActivityInfo config;
			LuaObject.checkType<ConfigDataOperationalActivityInfo>(l, 3, out config);
			accumulateConsumeCrystalOperationalActivity.DeserializeFromPB(pbOperationalActivity, config);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017776 RID: 96118 RVA: 0x006689F0 File Offset: 0x00666BF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBNtf(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			DSOperationalActivityNtf ntf;
			LuaObject.checkType<DSOperationalActivityNtf>(l, 2, out ntf);
			accumulateConsumeCrystalOperationalActivity.ToPBNtf(ntf);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017777 RID: 96119 RVA: 0x00668A48 File Offset: 0x00666C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SerializeToPB(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			ProAccumulateConsumeCrystalOperationalActivity o = accumulateConsumeCrystalOperationalActivity.SerializeToPB();
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

	// Token: 0x06017778 RID: 96120 RVA: 0x00668A9C File Offset: 0x00666C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGainRewardByIndex(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			int rewardIndex;
			LuaObject.checkType(l, 2, out rewardIndex);
			DateTime currentTime;
			LuaObject.checkValueType<DateTime>(l, 3, out currentTime);
			int i = accumulateConsumeCrystalOperationalActivity.CanGainRewardByIndex(rewardIndex, currentTime);
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

	// Token: 0x06017779 RID: 96121 RVA: 0x00668B0C File Offset: 0x00666D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddConsumeCrystal(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			int addNums;
			LuaObject.checkType(l, 2, out addNums);
			accumulateConsumeCrystalOperationalActivity.AddConsumeCrystal(addNums);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601777A RID: 96122 RVA: 0x00668B64 File Offset: 0x00666D64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AccumulateConsumeCrystal(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, accumulateConsumeCrystalOperationalActivity.AccumulateConsumeCrystal);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601777B RID: 96123 RVA: 0x00668BB8 File Offset: 0x00666DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AccumulateConsumeCrystal(IntPtr l)
	{
		int result;
		try
		{
			AccumulateConsumeCrystalOperationalActivity accumulateConsumeCrystalOperationalActivity = (AccumulateConsumeCrystalOperationalActivity)LuaObject.checkSelf(l);
			int accumulateConsumeCrystal;
			LuaObject.checkType(l, 2, out accumulateConsumeCrystal);
			accumulateConsumeCrystalOperationalActivity.AccumulateConsumeCrystal = accumulateConsumeCrystal;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601777C RID: 96124 RVA: 0x00668C10 File Offset: 0x00666E10
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.AccumulateConsumeCrystalOperationalActivity");
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.DeserializeFromPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.ToPBNtf);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.SerializeToPB);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.CanGainRewardByIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.AddConsumeCrystal);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache4);
		string name = "AccumulateConsumeCrystal";
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.get_AccumulateConsumeCrystal);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.set_AccumulateConsumeCrystal);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache6, true);
		if (Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_AccumulateConsumeCrystalOperationalActivity.<>f__mg$cache7, typeof(AccumulateConsumeCrystalOperationalActivity), typeof(AwardOperationalActivityBase));
	}

	// Token: 0x0400DDF4 RID: 56820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400DDF5 RID: 56821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400DDF6 RID: 56822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400DDF7 RID: 56823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400DDF8 RID: 56824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400DDF9 RID: 56825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400DDFA RID: 56826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400DDFB RID: 56827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;
}
