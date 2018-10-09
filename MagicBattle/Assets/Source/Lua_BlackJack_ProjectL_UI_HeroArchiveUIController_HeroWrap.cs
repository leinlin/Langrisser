using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200149F RID: 5279
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap : LuaObject
{
	// Token: 0x0601E91D RID: 125213 RVA: 0x009E0370 File Offset: 0x009DE570
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap o = new HeroArchiveUIController.HeroWrap();
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

	// Token: 0x0601E91E RID: 125214 RVA: 0x009E03B8 File Offset: 0x009DE5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap heroWrap = (HeroArchiveUIController.HeroWrap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroWrap.hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E91F RID: 125215 RVA: 0x009E040C File Offset: 0x009DE60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap heroWrap = (HeroArchiveUIController.HeroWrap)LuaObject.checkSelf(l);
			ConfigDataHeroInfo hero;
			LuaObject.checkType<ConfigDataHeroInfo>(l, 2, out hero);
			heroWrap.hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E920 RID: 125216 RVA: 0x009E0464 File Offset: 0x009DE664
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_isUnlocked(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap heroWrap = (HeroArchiveUIController.HeroWrap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroWrap.isUnlocked);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E921 RID: 125217 RVA: 0x009E04B8 File Offset: 0x009DE6B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_isUnlocked(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap heroWrap = (HeroArchiveUIController.HeroWrap)LuaObject.checkSelf(l);
			bool isUnlocked;
			LuaObject.checkType(l, 2, out isUnlocked);
			heroWrap.isUnlocked = isUnlocked;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E922 RID: 125218 RVA: 0x009E0510 File Offset: 0x009DE710
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_isSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap heroWrap = (HeroArchiveUIController.HeroWrap)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroWrap.isSelect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E923 RID: 125219 RVA: 0x009E0564 File Offset: 0x009DE764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_isSelect(IntPtr l)
	{
		int result;
		try
		{
			HeroArchiveUIController.HeroWrap heroWrap = (HeroArchiveUIController.HeroWrap)LuaObject.checkSelf(l);
			bool isSelect;
			LuaObject.checkType(l, 2, out isSelect);
			heroWrap.isSelect = isSelect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601E924 RID: 125220 RVA: 0x009E05BC File Offset: 0x009DE7BC
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroArchiveUIController.HeroWrap");
		string name = "hero";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.get_hero);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache0;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.set_hero);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache1, true);
		string name2 = "isUnlocked";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.get_isUnlocked);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.set_isUnlocked);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache3, true);
		string name3 = "isSelect";
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.get_isSelect);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.set_isSelect);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache5, true);
		if (Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_UI_HeroArchiveUIController_HeroWrap.<>f__mg$cache6, typeof(HeroArchiveUIController.HeroWrap));
	}

	// Token: 0x040149C1 RID: 84417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040149C2 RID: 84418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040149C3 RID: 84419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040149C4 RID: 84420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040149C5 RID: 84421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040149C6 RID: 84422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040149C7 RID: 84423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;
}
