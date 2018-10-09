using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012C7 RID: 4807
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_GmCommand : LuaObject
{
	// Token: 0x060194AB RID: 103595 RVA: 0x007407BC File Offset: 0x0073E9BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			GmCommand o = new GmCommand();
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

	// Token: 0x060194AC RID: 103596 RVA: 0x00740804 File Offset: 0x0073EA04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AddItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ADD_ITEM");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194AD RID: 103597 RVA: 0x0074084C File Offset: 0x0073EA4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RemoveItem(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "REMOVE_ITEM");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194AE RID: 103598 RVA: 0x00740894 File Offset: 0x0073EA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ClearBag(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "CLEAR_BAG");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194AF RID: 103599 RVA: 0x007408DC File Offset: 0x0073EADC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AddHero(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "ADD_HERO");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B0 RID: 103600 RVA: 0x00740924 File Offset: 0x0073EB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SendTemplateMail(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "POST_TEMPLATEMAIL");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B1 RID: 103601 RVA: 0x0074096C File Offset: 0x0073EB6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CleanUserGuide(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "CLEAN_USER_GUIDE");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B2 RID: 103602 RVA: 0x007409B4 File Offset: 0x0073EBB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_AddActivity(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "POST_GLOBALOPERATIONALACTIVITY");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B3 RID: 103603 RVA: 0x007409FC File Offset: 0x0073EBFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BattleCheat(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "BATTLE_CHEAT");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B4 RID: 103604 RVA: 0x00740A44 File Offset: 0x0073EC44
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_MaxTrainingTechs(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "SET_MAXTRAININGTECHS");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B5 RID: 103605 RVA: 0x00740A8C File Offset: 0x0073EC8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_LevelUpHeroFetter(IntPtr l)
	{
		int result;
		try
		{
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, "LevelUpHeroFetter");
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060194B6 RID: 103606 RVA: 0x00740AD4 File Offset: 0x0073ECD4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.GmCommand");
		string name = "AddItem";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_AddItem);
		}
		LuaObject.addMember(l, name, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache0, null, false);
		string name2 = "RemoveItem";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_RemoveItem);
		}
		LuaObject.addMember(l, name2, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache1, null, false);
		string name3 = "ClearBag";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_ClearBag);
		}
		LuaObject.addMember(l, name3, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache2, null, false);
		string name4 = "AddHero";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_AddHero);
		}
		LuaObject.addMember(l, name4, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache3, null, false);
		string name5 = "SendTemplateMail";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_SendTemplateMail);
		}
		LuaObject.addMember(l, name5, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache4, null, false);
		string name6 = "CleanUserGuide";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_CleanUserGuide);
		}
		LuaObject.addMember(l, name6, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache5, null, false);
		string name7 = "AddActivity";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_AddActivity);
		}
		LuaObject.addMember(l, name7, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache6, null, false);
		string name8 = "BattleCheat";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_BattleCheat);
		}
		LuaObject.addMember(l, name8, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache7, null, false);
		string name9 = "MaxTrainingTechs";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_MaxTrainingTechs);
		}
		LuaObject.addMember(l, name9, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache8, null, false);
		string name10 = "LevelUpHeroFetter";
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.get_LevelUpHeroFetter);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cache9, null, false);
		if (Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_GmCommand.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_GmCommand.<>f__mg$cacheA, typeof(GmCommand));
	}

	// Token: 0x0400F8FF RID: 63743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F900 RID: 63744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F901 RID: 63745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F902 RID: 63746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F903 RID: 63747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F904 RID: 63748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F905 RID: 63749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F906 RID: 63750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F907 RID: 63751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F908 RID: 63752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F909 RID: 63753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;
}
