using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001172 RID: 4466
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo : LuaObject
{
	// Token: 0x06016E72 RID: 93810 RVA: 0x006241A4 File Offset: 0x006223A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo o = new ConfigDataTrainingTechInfo();
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

	// Token: 0x06016E73 RID: 93811 RVA: 0x006241EC File Offset: 0x006223EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_techLevelupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.m_techLevelupInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E74 RID: 93812 RVA: 0x00624240 File Offset: 0x00622440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_techLevelupInfo(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			List<ConfigDataTrainingTechLevelInfo> techLevelupInfo;
			LuaObject.checkType<List<ConfigDataTrainingTechLevelInfo>>(l, 2, out techLevelupInfo);
			configDataTrainingTechInfo.m_techLevelupInfo = techLevelupInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E75 RID: 93813 RVA: 0x00624298 File Offset: 0x00622498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_Infos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.m_Infos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E76 RID: 93814 RVA: 0x006242EC File Offset: 0x006224EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_Infos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			List<TrainingTechInfo> infos;
			LuaObject.checkType<List<TrainingTechInfo>>(l, 2, out infos);
			configDataTrainingTechInfo.m_Infos = infos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E77 RID: 93815 RVA: 0x00624344 File Offset: 0x00622544
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_courseId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.m_courseId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E78 RID: 93816 RVA: 0x00624398 File Offset: 0x00622598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_courseId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			int courseId;
			LuaObject.checkType(l, 2, out courseId);
			configDataTrainingTechInfo.m_courseId = courseId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E79 RID: 93817 RVA: 0x006243F0 File Offset: 0x006225F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E7A RID: 93818 RVA: 0x00624444 File Offset: 0x00622644
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataTrainingTechInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E7B RID: 93819 RVA: 0x0062449C File Offset: 0x0062269C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E7C RID: 93820 RVA: 0x006244F0 File Offset: 0x006226F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataTrainingTechInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E7D RID: 93821 RVA: 0x00624548 File Offset: 0x00622748
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Resource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.Resource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E7E RID: 93822 RVA: 0x0062459C File Offset: 0x0062279C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Resource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			string resource;
			LuaObject.checkType(l, 2, out resource);
			configDataTrainingTechInfo.Resource = resource;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E7F RID: 93823 RVA: 0x006245F4 File Offset: 0x006227F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreTechIDs(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.PreTechIDs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E80 RID: 93824 RVA: 0x00624648 File Offset: 0x00622848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PreTechLevel(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.PreTechLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E81 RID: 93825 RVA: 0x0062469C File Offset: 0x0062289C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RoomLevelRequired(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.RoomLevelRequired);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E82 RID: 93826 RVA: 0x006246F0 File Offset: 0x006228F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RoomLevelRequired(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			int roomLevelRequired;
			LuaObject.checkType(l, 2, out roomLevelRequired);
			configDataTrainingTechInfo.RoomLevelRequired = roomLevelRequired;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E83 RID: 93827 RVA: 0x00624748 File Offset: 0x00622948
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SoldierIDRelated(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.SoldierIDRelated);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E84 RID: 93828 RVA: 0x0062479C File Offset: 0x0062299C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArmyIDRelated(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.ArmyIDRelated);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E85 RID: 93829 RVA: 0x006247F0 File Offset: 0x006229F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsSummon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.IsSummon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E86 RID: 93830 RVA: 0x00624844 File Offset: 0x00622A44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_IsSummon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			bool isSummon;
			LuaObject.checkType(l, 2, out isSummon);
			configDataTrainingTechInfo.IsSummon = isSummon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E87 RID: 93831 RVA: 0x0062489C File Offset: 0x00622A9C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TechType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)configDataTrainingTechInfo.TechType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E88 RID: 93832 RVA: 0x006248F0 File Offset: 0x00622AF0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TechType(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			TechDisplayType techType;
			LuaObject.checkEnum<TechDisplayType>(l, 2, out techType);
			configDataTrainingTechInfo.TechType = techType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E89 RID: 93833 RVA: 0x00624948 File Offset: 0x00622B48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TechLevelupInfoList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataTrainingTechInfo configDataTrainingTechInfo = (ConfigDataTrainingTechInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataTrainingTechInfo.TechLevelupInfoList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016E8A RID: 93834 RVA: 0x0062499C File Offset: 0x00622B9C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataTrainingTechInfo");
		string name = "m_techLevelupInfo";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_m_techLevelupInfo);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_m_techLevelupInfo);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache1, true);
		string name2 = "m_Infos";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_m_Infos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_m_Infos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache3, true);
		string name3 = "m_courseId";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_m_courseId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_m_courseId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache5, true);
		string name4 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_ID);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_ID);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache7, true);
		string name5 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache9, true);
		string name6 = "Resource";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_Resource);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_Resource);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheB, true);
		string name7 = "PreTechIDs";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_PreTechIDs);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheC, null, true);
		string name8 = "PreTechLevel";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_PreTechLevel);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheD, null, true);
		string name9 = "RoomLevelRequired";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_RoomLevelRequired);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_RoomLevelRequired);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cacheF, true);
		string name10 = "SoldierIDRelated";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_SoldierIDRelated);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache10, null, true);
		string name11 = "ArmyIDRelated";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_ArmyIDRelated);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache11, null, true);
		string name12 = "IsSummon";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_IsSummon);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache12;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_IsSummon);
		}
		LuaObject.addMember(l, name12, get8, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache13, true);
		string name13 = "TechType";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_TechType);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache14;
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.set_TechType);
		}
		LuaObject.addMember(l, name13, get9, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache15, true);
		string name14 = "TechLevelupInfoList";
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.get_TechLevelupInfoList);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache16, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataTrainingTechInfo.<>f__mg$cache17, typeof(ConfigDataTrainingTechInfo));
	}

	// Token: 0x0400D570 RID: 54640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D571 RID: 54641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D572 RID: 54642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D573 RID: 54643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D574 RID: 54644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D575 RID: 54645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D576 RID: 54646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D577 RID: 54647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D578 RID: 54648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D579 RID: 54649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D57A RID: 54650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D57B RID: 54651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D57C RID: 54652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D57D RID: 54653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D57E RID: 54654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D57F RID: 54655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D580 RID: 54656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D581 RID: 54657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D582 RID: 54658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D583 RID: 54659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D584 RID: 54660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D585 RID: 54661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D586 RID: 54662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D587 RID: 54663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
