using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001243 RID: 4675
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroPhantom : LuaObject
{
	// Token: 0x060184A5 RID: 99493 RVA: 0x006C968C File Offset: 0x006C788C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom o = new HeroPhantom();
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

	// Token: 0x060184A6 RID: 99494 RVA: 0x006C96D4 File Offset: 0x006C78D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			HeroPhantomLevel level = heroPhantom.GetLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A7 RID: 99495 RVA: 0x006C9738 File Offset: 0x006C7938
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Levels(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.Levels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A8 RID: 99496 RVA: 0x006C978C File Offset: 0x006C798C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Levels(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			List<HeroPhantomLevel> levels;
			LuaObject.checkType<List<HeroPhantomLevel>>(l, 2, out levels);
			heroPhantom.Levels = levels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184A9 RID: 99497 RVA: 0x006C97E4 File Offset: 0x006C79E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184AA RID: 99498 RVA: 0x006C9838 File Offset: 0x006C7A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			heroPhantom.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184AB RID: 99499 RVA: 0x006C9890 File Offset: 0x006C7A90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184AC RID: 99500 RVA: 0x006C98E4 File Offset: 0x006C7AE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Description(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.Description);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184AD RID: 99501 RVA: 0x006C9938 File Offset: 0x006C7B38
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelConfigs(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.LevelConfigs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184AE RID: 99502 RVA: 0x006C998C File Offset: 0x006C7B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_OpenDateTime(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.OpenDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184AF RID: 99503 RVA: 0x006C99E4 File Offset: 0x006C7BE4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CloseDateTime(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.CloseDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B0 RID: 99504 RVA: 0x006C9A3C File Offset: 0x006C7C3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ShowDateTime(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.ShowDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B1 RID: 99505 RVA: 0x006C9A94 File Offset: 0x006C7C94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HideDateTime(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.HideDateTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B2 RID: 99506 RVA: 0x006C9AEC File Offset: 0x006C7CEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_WhichCollection(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.WhichCollection);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B3 RID: 99507 RVA: 0x006C9B40 File Offset: 0x006C7D40
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_WhichCollection(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			HeroPhantomCollections whichCollection;
			LuaObject.checkType<HeroPhantomCollections>(l, 2, out whichCollection);
			heroPhantom.WhichCollection = whichCollection;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B4 RID: 99508 RVA: 0x006C9B98 File Offset: 0x006C7D98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Config(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.Config);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B5 RID: 99509 RVA: 0x006C9BEC File Offset: 0x006C7DEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B6 RID: 99510 RVA: 0x006C9C40 File Offset: 0x006C7E40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPhantom.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B7 RID: 99511 RVA: 0x006C9C98 File Offset: 0x006C7E98
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsAvailableForShow(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.IsAvailableForShow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B8 RID: 99512 RVA: 0x006C9CEC File Offset: 0x006C7EEC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsAvailableForChallenge(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantom heroPhantom = (HeroPhantom)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom.IsAvailableForChallenge);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184B9 RID: 99513 RVA: 0x006C9D40 File Offset: 0x006C7F40
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroPhantom");
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.GetLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache0);
		string name = "Levels";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_Levels);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.set_Levels);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache2, true);
		string name2 = "ID";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_ID);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.set_ID);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache4, true);
		string name3 = "Name";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_Name);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache5, null, true);
		string name4 = "Description";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_Description);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache6, null, true);
		string name5 = "LevelConfigs";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_LevelConfigs);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache7, null, true);
		string name6 = "OpenDateTime";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_OpenDateTime);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache8, null, true);
		string name7 = "CloseDateTime";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_CloseDateTime);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache9, null, true);
		string name8 = "ShowDateTime";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_ShowDateTime);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheA, null, true);
		string name9 = "HideDateTime";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_HideDateTime);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheB, null, true);
		string name10 = "WhichCollection";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_WhichCollection);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.set_WhichCollection);
		}
		LuaObject.addMember(l, name10, get3, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheD, true);
		string name11 = "Config";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_Config);
		}
		LuaObject.addMember(l, name11, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheE, null, true);
		string name12 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_ConfigDataLoader);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name12, get4, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache10, true);
		string name13 = "IsAvailableForShow";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_IsAvailableForShow);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache11, null, true);
		string name14 = "IsAvailableForChallenge";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.get_IsAvailableForChallenge);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache12, null, true);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantom.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroPhantom.<>f__mg$cache13, typeof(HeroPhantom));
	}

	// Token: 0x0400EA01 RID: 59905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EA02 RID: 59906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EA03 RID: 59907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EA04 RID: 59908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EA05 RID: 59909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EA06 RID: 59910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EA07 RID: 59911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EA08 RID: 59912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EA09 RID: 59913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400EA0A RID: 59914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400EA0B RID: 59915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400EA0C RID: 59916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400EA0D RID: 59917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400EA0E RID: 59918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400EA0F RID: 59919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400EA10 RID: 59920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400EA11 RID: 59921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400EA12 RID: 59922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400EA13 RID: 59923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400EA14 RID: 59924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;
}
