using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001244 RID: 4676
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroPhantomCollections : LuaObject
{
	// Token: 0x060184BB RID: 99515 RVA: 0x006CA06C File Offset: 0x006C826C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections o = new HeroPhantomCollections();
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

	// Token: 0x060184BC RID: 99516 RVA: 0x006CA0B4 File Offset: 0x006C82B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			int heroPhantomId;
			LuaObject.checkType(l, 2, out heroPhantomId);
			HeroPhantom heroPhantom = heroPhantomCollections.GetHeroPhantom(heroPhantomId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantom);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184BD RID: 99517 RVA: 0x006CA118 File Offset: 0x006C8318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			int levelId;
			LuaObject.checkType(l, 2, out levelId);
			HeroPhantomLevel heroPhantomLevel = heroPhantomCollections.GetHeroPhantomLevel(levelId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184BE RID: 99518 RVA: 0x006CA17C File Offset: 0x006C837C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ReloadConfigData(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			heroPhantomCollections.ReloadConfigData();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184BF RID: 99519 RVA: 0x006CA1C8 File Offset: 0x006C83C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Now(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			CurrentTime currentTime;
			int num = LuaObject.checkDelegate<CurrentTime>(l, 2, out currentTime);
			if (num == 0)
			{
				heroPhantomCollections.Now = currentTime;
			}
			else if (num == 1)
			{
				HeroPhantomCollections heroPhantomCollections2 = heroPhantomCollections;
				heroPhantomCollections2.Now = (CurrentTime)Delegate.Combine(heroPhantomCollections2.Now, currentTime);
			}
			else if (num == 2)
			{
				HeroPhantomCollections heroPhantomCollections3 = heroPhantomCollections;
				heroPhantomCollections3.Now = (CurrentTime)Delegate.Remove(heroPhantomCollections3.Now, currentTime);
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184C0 RID: 99520 RVA: 0x006CA270 File Offset: 0x006C8470
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeroPhantoms(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCollections.HeroPhantoms);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184C1 RID: 99521 RVA: 0x006CA2C4 File Offset: 0x006C84C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroPhantoms(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			List<HeroPhantom> heroPhantoms;
			LuaObject.checkType<List<HeroPhantom>>(l, 2, out heroPhantoms);
			heroPhantomCollections.HeroPhantoms = heroPhantoms;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184C2 RID: 99522 RVA: 0x006CA31C File Offset: 0x006C851C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomCollections.ConfigDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184C3 RID: 99523 RVA: 0x006CA370 File Offset: 0x006C8570
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ConfigDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomCollections heroPhantomCollections = (HeroPhantomCollections)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroPhantomCollections.ConfigDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060184C4 RID: 99524 RVA: 0x006CA3C8 File Offset: 0x006C85C8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroPhantomCollections");
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.GetHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.GetHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.ReloadConfigData);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache2);
		string name = "Now";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.set_Now);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache3, true);
		string name2 = "HeroPhantoms";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.get_HeroPhantoms);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.set_HeroPhantoms);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache5, true);
		string name3 = "ConfigDataLoader";
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.get_ConfigDataLoader);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.set_ConfigDataLoader);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroPhantomCollections.<>f__mg$cache8, typeof(HeroPhantomCollections));
	}

	// Token: 0x0400EA15 RID: 59925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EA16 RID: 59926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EA17 RID: 59927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EA18 RID: 59928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EA19 RID: 59929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EA1A RID: 59930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EA1B RID: 59931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EA1C RID: 59932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EA1D RID: 59933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
