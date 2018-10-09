using System;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x0200123B RID: 4667
[Preserve]
public class Lua_BlackJack_ProjectL_Common_HeroCommentEntry : LuaObject
{
	// Token: 0x06018350 RID: 99152 RVA: 0x006BE818 File Offset: 0x006BCA18
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			int num = LuaDLL.lua_gettop(l);
			if (num == 1)
			{
				HeroCommentEntry o = new HeroCommentEntry();
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else if (num == 2)
			{
				HeroCommentEntry other;
				LuaObject.checkType<HeroCommentEntry>(l, 2, out other);
				HeroCommentEntry o = new HeroCommentEntry(other);
				LuaObject.pushValue(l, true);
				LuaObject.pushValue(l, o);
				result = 2;
			}
			else
			{
				result = LuaObject.error(l, "New object failed.");
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018351 RID: 99153 RVA: 0x006BE8B0 File Offset: 0x006BCAB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int HeroCommentEntryToPBHeroCommentEntry_s(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry entry;
			LuaObject.checkType<HeroCommentEntry>(l, 1, out entry);
			ProHeroCommentEntry o = HeroCommentEntry.HeroCommentEntryToPBHeroCommentEntry(entry);
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

	// Token: 0x06018352 RID: 99154 RVA: 0x006BE904 File Offset: 0x006BCB04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PBHeroCommentEntryToHeroCommentEntry_s(IntPtr l)
	{
		int result;
		try
		{
			ProHeroCommentEntry pbEntry;
			LuaObject.checkType<ProHeroCommentEntry>(l, 1, out pbEntry);
			HeroCommentEntry o = HeroCommentEntry.PBHeroCommentEntryToHeroCommentEntry(pbEntry);
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

	// Token: 0x06018353 RID: 99155 RVA: 0x006BE958 File Offset: 0x006BCB58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.InstanceId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018354 RID: 99156 RVA: 0x006BE9AC File Offset: 0x006BCBAC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_InstanceId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			ulong instanceId;
			LuaObject.checkType(l, 2, out instanceId);
			heroCommentEntry.InstanceId = instanceId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018355 RID: 99157 RVA: 0x006BEA04 File Offset: 0x006BCC04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Content(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.Content);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018356 RID: 99158 RVA: 0x006BEA58 File Offset: 0x006BCC58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Content(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			heroCommentEntry.Content = content;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018357 RID: 99159 RVA: 0x006BEAB0 File Offset: 0x006BCCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommenterUserId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.CommenterUserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018358 RID: 99160 RVA: 0x006BEB04 File Offset: 0x006BCD04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CommenterUserId(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			string commenterUserId;
			LuaObject.checkType(l, 2, out commenterUserId);
			heroCommentEntry.CommenterUserId = commenterUserId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018359 RID: 99161 RVA: 0x006BEB5C File Offset: 0x006BCD5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommenterName(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.CommenterName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601835A RID: 99162 RVA: 0x006BEBB0 File Offset: 0x006BCDB0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommenterName(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			string commenterName;
			LuaObject.checkType(l, 2, out commenterName);
			heroCommentEntry.CommenterName = commenterName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601835B RID: 99163 RVA: 0x006BEC08 File Offset: 0x006BCE08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_CommenterLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.CommenterLevel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601835C RID: 99164 RVA: 0x006BEC5C File Offset: 0x006BCE5C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_CommenterLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			int commenterLevel;
			LuaObject.checkType(l, 2, out commenterLevel);
			heroCommentEntry.CommenterLevel = commenterLevel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601835D RID: 99165 RVA: 0x006BECB4 File Offset: 0x006BCEB4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_PraiseNums(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.PraiseNums);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601835E RID: 99166 RVA: 0x006BED08 File Offset: 0x006BCF08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PraiseNums(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			int praiseNums;
			LuaObject.checkType(l, 2, out praiseNums);
			heroCommentEntry.PraiseNums = praiseNums;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601835F RID: 99167 RVA: 0x006BED60 File Offset: 0x006BCF60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_CommentTime(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroCommentEntry.CommentTime);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018360 RID: 99168 RVA: 0x006BEDB4 File Offset: 0x006BCFB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_CommentTime(IntPtr l)
	{
		int result;
		try
		{
			HeroCommentEntry heroCommentEntry = (HeroCommentEntry)LuaObject.checkSelf(l);
			long commentTime;
			LuaObject.checkType(l, 2, out commentTime);
			heroCommentEntry.CommentTime = commentTime;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06018361 RID: 99169 RVA: 0x006BEE0C File Offset: 0x006BD00C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.HeroCommentEntry");
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.HeroCommentEntryToPBHeroCommentEntry_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.PBHeroCommentEntryToHeroCommentEntry_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache1);
		string name = "InstanceId";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_InstanceId);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_InstanceId);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache3, true);
		string name2 = "Content";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_Content);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_Content);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache5, true);
		string name3 = "CommenterUserId";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_CommenterUserId);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_CommenterUserId);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache7, true);
		string name4 = "CommenterName";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_CommenterName);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_CommenterName);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache9, true);
		string name5 = "CommenterLevel";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_CommenterLevel);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_CommenterLevel);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheB, true);
		string name6 = "PraiseNums";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_PraiseNums);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_PraiseNums);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheD, true);
		string name7 = "CommentTime";
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.get_CommentTime);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.set_CommentTime);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cacheF, true);
		if (Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_HeroCommentEntry.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_HeroCommentEntry.<>f__mg$cache10, typeof(HeroCommentEntry));
	}

	// Token: 0x0400E8BC RID: 59580
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E8BD RID: 59581
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E8BE RID: 59582
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E8BF RID: 59583
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E8C0 RID: 59584
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E8C1 RID: 59585
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E8C2 RID: 59586
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E8C3 RID: 59587
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E8C4 RID: 59588
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E8C5 RID: 59589
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E8C6 RID: 59590
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E8C7 RID: 59591
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E8C8 RID: 59592
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E8C9 RID: 59593
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E8CA RID: 59594
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E8CB RID: 59595
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E8CC RID: 59596
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;
}
