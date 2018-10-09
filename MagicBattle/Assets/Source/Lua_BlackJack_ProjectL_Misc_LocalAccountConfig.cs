using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Misc;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012A6 RID: 4774
[Preserve]
public class Lua_BlackJack_ProjectL_Misc_LocalAccountConfig : LuaObject
{
	// Token: 0x06019079 RID: 102521 RVA: 0x00720B48 File Offset: 0x0071ED48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig o = new LocalAccountConfig();
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

	// Token: 0x0601907A RID: 102522 RVA: 0x00720B90 File Offset: 0x0071ED90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetFileName(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			string fileName;
			LuaObject.checkType(l, 2, out fileName);
			localAccountConfig.SetFileName(fileName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601907B RID: 102523 RVA: 0x00720BE8 File Offset: 0x0071EDE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Save(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			bool b = localAccountConfig.Save();
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

	// Token: 0x0601907C RID: 102524 RVA: 0x00720C3C File Offset: 0x0071EE3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Load(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			bool b = localAccountConfig.Load();
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

	// Token: 0x0601907D RID: 102525 RVA: 0x00720C90 File Offset: 0x0071EE90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHaveReadHeroBiography(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localAccountConfig.AddHaveReadHeroBiography(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601907E RID: 102526 RVA: 0x00720CE8 File Offset: 0x0071EEE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHaveReadHeroPerformance(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localAccountConfig.AddHaveReadHeroPerformance(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601907F RID: 102527 RVA: 0x00720D40 File Offset: 0x0071EF40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddUnlockHeroBiography(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localAccountConfig.AddUnlockHeroBiography(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019080 RID: 102528 RVA: 0x00720D98 File Offset: 0x0071EF98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddUnlockHeroPerformance(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localAccountConfig.AddUnlockHeroPerformance(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019081 RID: 102529 RVA: 0x00720DF0 File Offset: 0x0071EFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddUnlockHeroDungeonLevelId(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localAccountConfig.AddUnlockHeroDungeonLevelId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019082 RID: 102530 RVA: 0x00720E48 File Offset: 0x0071F048
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int AddUnlockHeroFetterId(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			localAccountConfig.AddUnlockHeroFetterId(id);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019083 RID: 102531 RVA: 0x00720EA0 File Offset: 0x0071F0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetArenaAttackerHeroIds(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			List<int> arenaAttackerHeroIds;
			LuaObject.checkType<List<int>>(l, 2, out arenaAttackerHeroIds);
			localAccountConfig.SetArenaAttackerHeroIds(arenaAttackerHeroIds);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019084 RID: 102532 RVA: 0x00720EF8 File Offset: 0x0071F0F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetHaveDoneMemoryExtraction(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			bool haveDoneMemoryExtraction;
			LuaObject.checkType(l, 2, out haveDoneMemoryExtraction);
			localAccountConfig.SetHaveDoneMemoryExtraction(haveDoneMemoryExtraction);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019085 RID: 102533 RVA: 0x00720F50 File Offset: 0x0071F150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Data(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig localAccountConfig = (LocalAccountConfig)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, localAccountConfig.Data);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019086 RID: 102534 RVA: 0x00720FA4 File Offset: 0x0071F1A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Instance(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, LocalAccountConfig.Instance);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019087 RID: 102535 RVA: 0x00720FEC File Offset: 0x0071F1EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Instance(IntPtr l)
	{
		int result;
		try
		{
			LocalAccountConfig instance;
			LuaObject.checkType<LocalAccountConfig>(l, 2, out instance);
			LocalAccountConfig.Instance = instance;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019088 RID: 102536 RVA: 0x00721038 File Offset: 0x0071F238
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Misc.LocalAccountConfig");
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.SetFileName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.Save);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.Load);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.AddHaveReadHeroBiography);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.AddHaveReadHeroPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.AddUnlockHeroBiography);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.AddUnlockHeroPerformance);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.AddUnlockHeroDungeonLevelId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.AddUnlockHeroFetterId);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.SetArenaAttackerHeroIds);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.SetHaveDoneMemoryExtraction);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheA);
		string name = "Data";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.get_Data);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheB, null, true);
		string name2 = "Instance";
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.get_Instance);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.set_Instance);
		}
		LuaObject.addMember(l, name2, get, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheD, false);
		if (Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Misc_LocalAccountConfig.<>f__mg$cacheE, typeof(LocalAccountConfig));
	}

	// Token: 0x0400F50F RID: 62735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F510 RID: 62736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F511 RID: 62737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F512 RID: 62738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F513 RID: 62739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F514 RID: 62740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F515 RID: 62741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F516 RID: 62742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F517 RID: 62743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F518 RID: 62744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F519 RID: 62745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F51A RID: 62746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F51B RID: 62747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F51C RID: 62748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F51D RID: 62749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;
}
