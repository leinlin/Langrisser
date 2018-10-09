using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200113A RID: 4410
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo : LuaObject
{
	// Token: 0x060164F8 RID: 91384 RVA: 0x005DF048 File Offset: 0x005DD248
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo o = new ConfigDataBattleEventActionInfo();
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

	// Token: 0x060164F9 RID: 91385 RVA: 0x005DF090 File Offset: 0x005DD290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Initialize(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			bool b = configDataBattleEventActionInfo.Initialize();
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

	// Token: 0x060164FA RID: 91386 RVA: 0x005DF0E4 File Offset: 0x005DD2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Param1FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			int i = configDataBattleEventActionInfo.Param1FirstValue();
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

	// Token: 0x060164FB RID: 91387 RVA: 0x005DF138 File Offset: 0x005DD338
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Param2FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			int i = configDataBattleEventActionInfo.Param2FirstValue();
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

	// Token: 0x060164FC RID: 91388 RVA: 0x005DF18C File Offset: 0x005DD38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ComputeGroupBehaviorDict_s(IntPtr l)
	{
		int result;
		try
		{
			List<int> groups;
			LuaObject.checkType<List<int>>(l, 1, out groups);
			List<int> behaviors;
			LuaObject.checkType<List<int>>(l, 2, out behaviors);
			Dictionary<int, int> o = ConfigDataBattleEventActionInfo.ComputeGroupBehaviorDict(groups, behaviors);
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

	// Token: 0x060164FD RID: 91389 RVA: 0x005DF1EC File Offset: 0x005DD3EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_reliefGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.m_reliefGroupBehaviors);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164FE RID: 91390 RVA: 0x005DF240 File Offset: 0x005DD440
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_reliefGroupBehaviors(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			Dictionary<int, int> reliefGroupBehaviors;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out reliefGroupBehaviors);
			configDataBattleEventActionInfo.m_reliefGroupBehaviors = reliefGroupBehaviors;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060164FF RID: 91391 RVA: 0x005DF298 File Offset: 0x005DD498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016500 RID: 91392 RVA: 0x005DF2EC File Offset: 0x005DD4EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleEventActionInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016501 RID: 91393 RVA: 0x005DF344 File Offset: 0x005DD544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016502 RID: 91394 RVA: 0x005DF398 File Offset: 0x005DD598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataBattleEventActionInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016503 RID: 91395 RVA: 0x005DF3F0 File Offset: 0x005DD5F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016504 RID: 91396 RVA: 0x005DF444 File Offset: 0x005DD644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataBattleEventActionInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016505 RID: 91397 RVA: 0x005DF49C File Offset: 0x005DD69C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ActionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBattleEventActionInfo.ActionType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016506 RID: 91398 RVA: 0x005DF4F0 File Offset: 0x005DD6F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ActionType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			BattleEventActionType actionType;
			LuaObject.checkEnum<BattleEventActionType>(l, 2, out actionType);
			configDataBattleEventActionInfo.ActionType = actionType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016507 RID: 91399 RVA: 0x005DF548 File Offset: 0x005DD748
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Param1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016508 RID: 91400 RVA: 0x005DF59C File Offset: 0x005DD79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Param2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016509 RID: 91401 RVA: 0x005DF5F0 File Offset: 0x005DD7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Param3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601650A RID: 91402 RVA: 0x005DF644 File Offset: 0x005DD844
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param4(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Param4);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601650B RID: 91403 RVA: 0x005DF698 File Offset: 0x005DD898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Param5);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601650C RID: 91404 RVA: 0x005DF6EC File Offset: 0x005DD8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Param5(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			string param;
			LuaObject.checkType(l, 2, out param);
			configDataBattleEventActionInfo.Param5 = param;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601650D RID: 91405 RVA: 0x005DF744 File Offset: 0x005DD944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param6(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.Param6);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601650E RID: 91406 RVA: 0x005DF798 File Offset: 0x005DD998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReliefActorsBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.ReliefActorsBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601650F RID: 91407 RVA: 0x005DF7EC File Offset: 0x005DD9EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ReliefGroups(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.ReliefGroups);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016510 RID: 91408 RVA: 0x005DF840 File Offset: 0x005DDA40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ReliefGroupBehavior(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.ReliefGroupBehavior);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016511 RID: 91409 RVA: 0x005DF894 File Offset: 0x005DDA94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ReliefRandomArmies_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventActionInfo configDataBattleEventActionInfo = (ConfigDataBattleEventActionInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventActionInfo.ReliefRandomArmies_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016512 RID: 91410 RVA: 0x005DF8E8 File Offset: 0x005DDAE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleEventActionInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.Initialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.Param1FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache1);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.Param2FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache2);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.ComputeGroupBehaviorDict_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache3);
		string name = "m_reliefGroupBehaviors";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_m_reliefGroupBehaviors);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.set_m_reliefGroupBehaviors);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache5, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache7, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache9, true);
		string name4 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_NameStrKey);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheB, true);
		string name5 = "ActionType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_ActionType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.set_ActionType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheD, true);
		string name6 = "Param1";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Param1);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheE, null, true);
		string name7 = "Param2";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Param2);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cacheF, null, true);
		string name8 = "Param3";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Param3);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache10, null, true);
		string name9 = "Param4";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Param4);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache11, null, true);
		string name10 = "Param5";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Param5);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.set_Param5);
		}
		LuaObject.addMember(l, name10, get6, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache13, true);
		string name11 = "Param6";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_Param6);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache14, null, true);
		string name12 = "ReliefActorsBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_ReliefActorsBehavior);
		}
		LuaObject.addMember(l, name12, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache15, null, true);
		string name13 = "ReliefGroups";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_ReliefGroups);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache16, null, true);
		string name14 = "ReliefGroupBehavior";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_ReliefGroupBehavior);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache17, null, true);
		string name15 = "ReliefRandomArmies_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.get_ReliefRandomArmies_ID);
		}
		LuaObject.addMember(l, name15, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache18, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventActionInfo.<>f__mg$cache19, typeof(ConfigDataBattleEventActionInfo));
	}

	// Token: 0x0400CC66 RID: 52326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CC67 RID: 52327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CC68 RID: 52328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CC69 RID: 52329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CC6A RID: 52330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CC6B RID: 52331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CC6C RID: 52332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CC6D RID: 52333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CC6E RID: 52334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CC6F RID: 52335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CC70 RID: 52336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CC71 RID: 52337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CC72 RID: 52338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CC73 RID: 52339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CC74 RID: 52340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CC75 RID: 52341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CC76 RID: 52342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CC77 RID: 52343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CC78 RID: 52344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400CC79 RID: 52345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400CC7A RID: 52346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400CC7B RID: 52347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400CC7C RID: 52348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400CC7D RID: 52349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400CC7E RID: 52350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400CC7F RID: 52351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
