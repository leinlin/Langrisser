using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001275 RID: 4725
[Preserve]
public class Lua_BlackJack_ProjectL_Common_RiftChapter : LuaObject
{
	// Token: 0x060189FB RID: 100859 RVA: 0x006F15C4 File Offset: 0x006EF7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter o = new RiftChapter();
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

	// Token: 0x060189FC RID: 100860 RVA: 0x006F160C File Offset: 0x006EF80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PBRiftChapterToRiftCHapter_s(IntPtr l)
	{
		int result;
		try
		{
			ProRiftChapter pbRiftChapter;
			LuaObject.checkType<ProRiftChapter>(l, 1, out pbRiftChapter);
			RiftChapter o = RiftChapter.PBRiftChapterToRiftCHapter(pbRiftChapter);
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

	// Token: 0x060189FD RID: 100861 RVA: 0x006F1660 File Offset: 0x006EF860
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int RiftChapterToPBRiftChapter_s(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter;
			LuaObject.checkType<RiftChapter>(l, 1, out riftChapter);
			ProRiftChapter o = RiftChapter.RiftChapterToPBRiftChapter(riftChapter);
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

	// Token: 0x060189FE RID: 100862 RVA: 0x006F16B4 File Offset: 0x006EF8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChapterLevels(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter = (RiftChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapter.ChapterLevels);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060189FF RID: 100863 RVA: 0x006F1708 File Offset: 0x006EF908
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ChapterLevels(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter = (RiftChapter)LuaObject.checkSelf(l);
			List<RiftLevel> chapterLevels;
			LuaObject.checkType<List<RiftLevel>>(l, 2, out chapterLevels);
			riftChapter.ChapterLevels = chapterLevels;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A00 RID: 100864 RVA: 0x006F1760 File Offset: 0x006EF960
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StarRewardIndexes(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter = (RiftChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapter.StarRewardIndexes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A01 RID: 100865 RVA: 0x006F17B4 File Offset: 0x006EF9B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StarRewardIndexes(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter = (RiftChapter)LuaObject.checkSelf(l);
			List<int> starRewardIndexes;
			LuaObject.checkType<List<int>>(l, 2, out starRewardIndexes);
			riftChapter.StarRewardIndexes = starRewardIndexes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A02 RID: 100866 RVA: 0x006F180C File Offset: 0x006EFA0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TotalStars(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter = (RiftChapter)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, riftChapter.TotalStars);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A03 RID: 100867 RVA: 0x006F1860 File Offset: 0x006EFA60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TotalStars(IntPtr l)
	{
		int result;
		try
		{
			RiftChapter riftChapter = (RiftChapter)LuaObject.checkSelf(l);
			int totalStars;
			LuaObject.checkType(l, 2, out totalStars);
			riftChapter.TotalStars = totalStars;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018A04 RID: 100868 RVA: 0x006F18B8 File Offset: 0x006EFAB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.RiftChapter");
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.PBRiftChapterToRiftCHapter_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.RiftChapterToPBRiftChapter_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache1);
		string name = "ChapterLevels";
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.get_ChapterLevels);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.set_ChapterLevels);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache3, true);
		string name2 = "StarRewardIndexes";
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.get_StarRewardIndexes);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.set_StarRewardIndexes);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache5, true);
		string name3 = "TotalStars";
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.get_TotalStars);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.set_TotalStars);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache7, true);
		if (Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_RiftChapter.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_RiftChapter.<>f__mg$cache8, typeof(RiftChapter));
	}

	// Token: 0x0400EEF3 RID: 61171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400EEF4 RID: 61172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400EEF5 RID: 61173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400EEF6 RID: 61174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400EEF7 RID: 61175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400EEF8 RID: 61176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400EEF9 RID: 61177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400EEFA RID: 61178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400EEFB RID: 61179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;
}
