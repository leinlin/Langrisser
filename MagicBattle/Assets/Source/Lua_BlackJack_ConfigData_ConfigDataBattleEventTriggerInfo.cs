using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200113B RID: 4411
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo : LuaObject
{
	// Token: 0x06016514 RID: 91412 RVA: 0x005DFCE0 File Offset: 0x005DDEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo o = new ConfigDataBattleEventTriggerInfo();
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

	// Token: 0x06016515 RID: 91413 RVA: 0x005DFD28 File Offset: 0x005DDF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Param1FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			int i = configDataBattleEventTriggerInfo.Param1FirstValue();
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

	// Token: 0x06016516 RID: 91414 RVA: 0x005DFD7C File Offset: 0x005DDF7C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Param2FirstValue(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			int i = configDataBattleEventTriggerInfo.Param2FirstValue();
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

	// Token: 0x06016517 RID: 91415 RVA: 0x005DFDD0 File Offset: 0x005DDFD0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_battleEventActionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.m_battleEventActionInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016518 RID: 91416 RVA: 0x005DFE24 File Offset: 0x005DE024
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_battleEventActionInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			ConfigDataBattleEventActionInfo[] battleEventActionInfos;
			LuaObject.checkArray<ConfigDataBattleEventActionInfo>(l, 2, out battleEventActionInfos);
			configDataBattleEventTriggerInfo.m_battleEventActionInfos = battleEventActionInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016519 RID: 91417 RVA: 0x005DFE7C File Offset: 0x005DE07C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601651A RID: 91418 RVA: 0x005DFED0 File Offset: 0x005DE0D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataBattleEventTriggerInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601651B RID: 91419 RVA: 0x005DFF28 File Offset: 0x005DE128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601651C RID: 91420 RVA: 0x005DFF7C File Offset: 0x005DE17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataBattleEventTriggerInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601651D RID: 91421 RVA: 0x005DFFD4 File Offset: 0x005DE1D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.NameStrKey);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601651E RID: 91422 RVA: 0x005E0028 File Offset: 0x005DE228
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_NameStrKey(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			string nameStrKey;
			LuaObject.checkType(l, 2, out nameStrKey);
			configDataBattleEventTriggerInfo.NameStrKey = nameStrKey;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601651F RID: 91423 RVA: 0x005E0080 File Offset: 0x005DE280
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TriggerType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataBattleEventTriggerInfo.TriggerType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016520 RID: 91424 RVA: 0x005E00D4 File Offset: 0x005DE2D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TriggerType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			BattleEventTriggerType triggerType;
			LuaObject.checkEnum<BattleEventTriggerType>(l, 2, out triggerType);
			configDataBattleEventTriggerInfo.TriggerType = triggerType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016521 RID: 91425 RVA: 0x005E012C File Offset: 0x005DE32C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Param1(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.Param1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016522 RID: 91426 RVA: 0x005E0180 File Offset: 0x005DE380
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param2(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.Param2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016523 RID: 91427 RVA: 0x005E01D4 File Offset: 0x005DE3D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Param3(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.Param3);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016524 RID: 91428 RVA: 0x005E0228 File Offset: 0x005DE428
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Actions_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.Actions_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016525 RID: 91429 RVA: 0x005E027C File Offset: 0x005DE47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CanRepeat(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataBattleEventTriggerInfo.CanRepeat);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016526 RID: 91430 RVA: 0x005E02D0 File Offset: 0x005DE4D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CanRepeat(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataBattleEventTriggerInfo configDataBattleEventTriggerInfo = (ConfigDataBattleEventTriggerInfo)LuaObject.checkSelf(l);
			bool canRepeat;
			LuaObject.checkType(l, 2, out canRepeat);
			configDataBattleEventTriggerInfo.CanRepeat = canRepeat;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016527 RID: 91431 RVA: 0x005E0328 File Offset: 0x005DE528
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataBattleEventTriggerInfo");
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.Param1FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache0);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.Param2FirstValue);
		}
		LuaObject.addMember(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache1);
		string name = "m_battleEventActionInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_m_battleEventActionInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.set_m_battleEventActionInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache3, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache5, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache7, true);
		string name4 = "NameStrKey";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_NameStrKey);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.set_NameStrKey);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache9, true);
		string name5 = "TriggerType";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_TriggerType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.set_TriggerType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheB, true);
		string name6 = "Param1";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_Param1);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheC, null, true);
		string name7 = "Param2";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_Param2);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheD, null, true);
		string name8 = "Param3";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_Param3);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheE, null, true);
		string name9 = "Actions_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_Actions_ID);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cacheF, null, true);
		string name10 = "CanRepeat";
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.get_CanRepeat);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.set_CanRepeat);
		}
		LuaObject.addMember(l, name10, get6, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache11, true);
		if (Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataBattleEventTriggerInfo.<>f__mg$cache12, typeof(ConfigDataBattleEventTriggerInfo));
	}

	// Token: 0x0400CC80 RID: 52352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CC81 RID: 52353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CC82 RID: 52354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CC83 RID: 52355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CC84 RID: 52356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CC85 RID: 52357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CC86 RID: 52358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CC87 RID: 52359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CC88 RID: 52360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CC89 RID: 52361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CC8A RID: 52362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CC8B RID: 52363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CC8C RID: 52364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CC8D RID: 52365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CC8E RID: 52366
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CC8F RID: 52367
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CC90 RID: 52368
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400CC91 RID: 52369
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400CC92 RID: 52370
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
