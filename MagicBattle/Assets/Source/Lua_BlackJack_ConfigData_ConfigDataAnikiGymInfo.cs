using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001134 RID: 4404
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo : LuaObject
{
	// Token: 0x0601642D RID: 91181 RVA: 0x005D9524 File Offset: 0x005D7724
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo o = new ConfigDataAnikiGymInfo();
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

	// Token: 0x0601642E RID: 91182 RVA: 0x005D956C File Offset: 0x005D776C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.m_levelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601642F RID: 91183 RVA: 0x005D95C0 File Offset: 0x005D77C0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_levelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			List<ConfigDataAnikiLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataAnikiLevelInfo>>(l, 2, out levelInfos);
			configDataAnikiGymInfo.m_levelInfos = levelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016430 RID: 91184 RVA: 0x005D9618 File Offset: 0x005D7818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016431 RID: 91185 RVA: 0x005D966C File Offset: 0x005D786C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataAnikiGymInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016432 RID: 91186 RVA: 0x005D96C4 File Offset: 0x005D78C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016433 RID: 91187 RVA: 0x005D9718 File Offset: 0x005D7918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataAnikiGymInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016434 RID: 91188 RVA: 0x005D9770 File Offset: 0x005D7970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016435 RID: 91189 RVA: 0x005D97C4 File Offset: 0x005D79C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataAnikiGymInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016436 RID: 91190 RVA: 0x005D981C File Offset: 0x005D7A1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.TeamName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016437 RID: 91191 RVA: 0x005D9870 File Offset: 0x005D7A70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			string teamName;
			LuaObject.checkType(l, 2, out teamName);
			configDataAnikiGymInfo.TeamName = teamName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016438 RID: 91192 RVA: 0x005D98C8 File Offset: 0x005D7AC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LevelList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.LevelList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016439 RID: 91193 RVA: 0x005D991C File Offset: 0x005D7B1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StartTimeList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.StartTimeList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601643A RID: 91194 RVA: 0x005D9970 File Offset: 0x005D7B70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_OpenDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.OpenDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601643B RID: 91195 RVA: 0x005D99C4 File Offset: 0x005D7BC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_OpenDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			string openDesc;
			LuaObject.checkType(l, 2, out openDesc);
			configDataAnikiGymInfo.OpenDesc = openDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601643C RID: 91196 RVA: 0x005D9A1C File Offset: 0x005D7C1C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataAnikiGymInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601643D RID: 91197 RVA: 0x005D9A70 File Offset: 0x005D7C70
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataAnikiGymInfo configDataAnikiGymInfo = (ConfigDataAnikiGymInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataAnikiGymInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601643E RID: 91198 RVA: 0x005D9AC8 File Offset: 0x005D7CC8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataAnikiGymInfo");
		string name = "m_levelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_m_levelInfos);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_m_levelInfos);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache5, true);
		string name4 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_Desc);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_Desc);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache7, true);
		string name5 = "TeamName";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_TeamName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_TeamName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache9, true);
		string name6 = "LevelList";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_LevelList);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheA, null, true);
		string name7 = "StartTimeList";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_StartTimeList);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheB, null, true);
		string name8 = "OpenDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_OpenDesc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_OpenDesc);
		}
		LuaObject.addMember(l, name8, get6, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheD, true);
		string name9 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.get_Icon);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.set_Icon);
		}
		LuaObject.addMember(l, name9, get7, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataAnikiGymInfo.<>f__mg$cache10, typeof(ConfigDataAnikiGymInfo));
	}

	// Token: 0x0400CBA7 RID: 52135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400CBA8 RID: 52136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400CBA9 RID: 52137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400CBAA RID: 52138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400CBAB RID: 52139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400CBAC RID: 52140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400CBAD RID: 52141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400CBAE RID: 52142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400CBAF RID: 52143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400CBB0 RID: 52144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400CBB1 RID: 52145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400CBB2 RID: 52146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400CBB3 RID: 52147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400CBB4 RID: 52148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400CBB5 RID: 52149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400CBB6 RID: 52150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400CBB7 RID: 52151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
