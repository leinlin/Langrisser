using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200123D RID: 4669
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroDungeonChapter : LuaObject
{
	// Token: 0x0601843B RID: 99387 RVA: 0x006C659C File Offset: 0x006C479C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter o = new HeroDungeonChapter();
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

	// Token: 0x0601843C RID: 99388 RVA: 0x006C65E4 File Offset: 0x006C47E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ToPBChapter_s(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter chapter;
			LuaObject.checkType<HeroDungeonChapter>(l, 1, out chapter);
			ProHeroDungeonChapter o = HeroDungeonChapter.ToPBChapter(chapter);
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

	// Token: 0x0601843D RID: 99389 RVA: 0x006C6638 File Offset: 0x006C4838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChapterLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonChapter.ChapterLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601843E RID: 99390 RVA: 0x006C668C File Offset: 0x006C488C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChapterLevels(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			List<HeroDungeonLevel> chapterLevels;
			LuaObject.checkType<List<HeroDungeonLevel>>(l, 2, out chapterLevels);
			heroDungeonChapter.ChapterLevels = chapterLevels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601843F RID: 99391 RVA: 0x006C66E4 File Offset: 0x006C48E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_StarRewardIndexes(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonChapter.StarRewardIndexes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018440 RID: 99392 RVA: 0x006C6738 File Offset: 0x006C4938
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StarRewardIndexes(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			List<int> starRewardIndexes;
			LuaObject.checkType<List<int>>(l, 2, out starRewardIndexes);
			heroDungeonChapter.StarRewardIndexes = starRewardIndexes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018441 RID: 99393 RVA: 0x006C6790 File Offset: 0x006C4990
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ChapterId(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonChapter.ChapterId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018442 RID: 99394 RVA: 0x006C67E4 File Offset: 0x006C49E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChapterId(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			int chapterId;
			LuaObject.checkType(l, 2, out chapterId);
			heroDungeonChapter.ChapterId = chapterId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018443 RID: 99395 RVA: 0x006C683C File Offset: 0x006C4A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalStars(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDungeonChapter.TotalStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018444 RID: 99396 RVA: 0x006C6890 File Offset: 0x006C4A90
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TotalStars(IntPtr l)
	{
		int result;
		try
		{
			HeroDungeonChapter heroDungeonChapter = (HeroDungeonChapter)LuaObject.checkSelf(l);
			int totalStars;
			LuaObject.checkType(l, 2, out totalStars);
			heroDungeonChapter.TotalStars = totalStars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018445 RID: 99397 RVA: 0x006C68E8 File Offset: 0x006C4AE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroDungeonChapter");
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.ToPBChapter_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache0);
		string name = "ChapterLevels";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.get_ChapterLevels);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache1;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.set_ChapterLevels);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache2, true);
		string name2 = "StarRewardIndexes";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.get_StarRewardIndexes);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.set_StarRewardIndexes);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache4, true);
		string name3 = "ChapterId";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.get_ChapterId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.set_ChapterId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache6, true);
		string name4 = "TotalStars";
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.get_TotalStars);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.set_TotalStars);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache8, true);
		if (Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroDungeonChapter.<>f__mg$cache9, typeof(HeroDungeonChapter));
	}

	// Token: 0x0400E9A3 RID: 59811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E9A4 RID: 59812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E9A5 RID: 59813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E9A6 RID: 59814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E9A7 RID: 59815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E9A8 RID: 59816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E9A9 RID: 59817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E9AA RID: 59818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E9AB RID: 59819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E9AC RID: 59820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;
}
