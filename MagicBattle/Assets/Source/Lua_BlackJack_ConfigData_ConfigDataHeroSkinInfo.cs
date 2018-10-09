using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001159 RID: 4441
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo : LuaObject
{
	// Token: 0x060169C3 RID: 92611 RVA: 0x00601E44 File Offset: 0x00600044
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo o = new ConfigDataHeroSkinInfo();
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

	// Token: 0x060169C4 RID: 92612 RVA: 0x00601E8C File Offset: 0x0060008C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FixedStoreItemId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.FixedStoreItemId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C5 RID: 92613 RVA: 0x00601EE0 File Offset: 0x006000E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_FixedStoreItemId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			int fixedStoreItemId;
			LuaObject.checkType(l, 2, out fixedStoreItemId);
			configDataHeroSkinInfo.FixedStoreItemId = fixedStoreItemId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C6 RID: 92614 RVA: 0x00601F38 File Offset: 0x00600138
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C7 RID: 92615 RVA: 0x00601F8C File Offset: 0x0060018C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataHeroSkinInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C8 RID: 92616 RVA: 0x00601FE4 File Offset: 0x006001E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169C9 RID: 92617 RVA: 0x00602038 File Offset: 0x00600238
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataHeroSkinInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169CA RID: 92618 RVA: 0x00602090 File Offset: 0x00600290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SpecifiedHero(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.SpecifiedHero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169CB RID: 92619 RVA: 0x006020E4 File Offset: 0x006002E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SpecifiedHero(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			int specifiedHero;
			LuaObject.checkType(l, 2, out specifiedHero);
			configDataHeroSkinInfo.SpecifiedHero = specifiedHero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169CC RID: 92620 RVA: 0x0060213C File Offset: 0x0060033C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CharImageSkinResource_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.CharImageSkinResource_ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169CD RID: 92621 RVA: 0x00602190 File Offset: 0x00600390
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CharImageSkinResource_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			int charImageSkinResource_ID;
			LuaObject.checkType(l, 2, out charImageSkinResource_ID);
			configDataHeroSkinInfo.CharImageSkinResource_ID = charImageSkinResource_ID;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169CE RID: 92622 RVA: 0x006021E8 File Offset: 0x006003E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_SpecifiedModelSkinResource(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.SpecifiedModelSkinResource);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169CF RID: 92623 RVA: 0x0060223C File Offset: 0x0060043C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.Desc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D0 RID: 92624 RVA: 0x00602290 File Offset: 0x00600490
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Desc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			string desc;
			LuaObject.checkType(l, 2, out desc);
			configDataHeroSkinInfo.Desc = desc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D1 RID: 92625 RVA: 0x006022E8 File Offset: 0x006004E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.Icon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D2 RID: 92626 RVA: 0x0060233C File Offset: 0x0060053C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Icon(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			string icon;
			LuaObject.checkType(l, 2, out icon);
			configDataHeroSkinInfo.Icon = icon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D3 RID: 92627 RVA: 0x00602394 File Offset: 0x00600594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_GetPathList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.GetPathList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D4 RID: 92628 RVA: 0x006023E8 File Offset: 0x006005E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_GetPathDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataHeroSkinInfo.GetPathDesc);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D5 RID: 92629 RVA: 0x0060243C File Offset: 0x0060063C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_GetPathDesc(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataHeroSkinInfo configDataHeroSkinInfo = (ConfigDataHeroSkinInfo)LuaObject.checkSelf(l);
			string getPathDesc;
			LuaObject.checkType(l, 2, out getPathDesc);
			configDataHeroSkinInfo.GetPathDesc = getPathDesc;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060169D6 RID: 92630 RVA: 0x00602494 File Offset: 0x00600694
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataHeroSkinInfo");
		string name = "FixedStoreItemId";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_FixedStoreItemId);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_FixedStoreItemId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache1, true);
		string name2 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache3, true);
		string name3 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_Name);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_Name);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache5, true);
		string name4 = "SpecifiedHero";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_SpecifiedHero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_SpecifiedHero);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache7, true);
		string name5 = "CharImageSkinResource_ID";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_CharImageSkinResource_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_CharImageSkinResource_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache9, true);
		string name6 = "SpecifiedModelSkinResource";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_SpecifiedModelSkinResource);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheA, null, true);
		string name7 = "Desc";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_Desc);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheB;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_Desc);
		}
		LuaObject.addMember(l, name7, get6, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheC, true);
		string name8 = "Icon";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_Icon);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheD;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_Icon);
		}
		LuaObject.addMember(l, name8, get7, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheE, true);
		string name9 = "GetPathList";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_GetPathList);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cacheF, null, true);
		string name10 = "GetPathDesc";
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.get_GetPathDesc);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.set_GetPathDesc);
		}
		LuaObject.addMember(l, name10, get8, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache11, true);
		if (Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataHeroSkinInfo.<>f__mg$cache12, typeof(ConfigDataHeroSkinInfo));
	}

	// Token: 0x0400D0F3 RID: 53491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D0F4 RID: 53492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D0F5 RID: 53493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D0F6 RID: 53494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D0F7 RID: 53495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D0F8 RID: 53496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D0F9 RID: 53497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D0FA RID: 53498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D0FB RID: 53499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D0FC RID: 53500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D0FD RID: 53501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D0FE RID: 53502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D0FF RID: 53503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D100 RID: 53504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D101 RID: 53505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D102 RID: 53506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D103 RID: 53507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D104 RID: 53508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D105 RID: 53509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;
}
