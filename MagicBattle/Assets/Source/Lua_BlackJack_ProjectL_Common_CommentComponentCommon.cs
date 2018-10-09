using System;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011E4 RID: 4580
[Preserve]
public class Lua_BlackJack_ProjectL_Common_CommentComponentCommon : LuaObject
{
	// Token: 0x06017BE9 RID: 97257 RVA: 0x00689350 File Offset: 0x00687550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon o = new CommentComponentCommon();
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

	// Token: 0x06017BEA RID: 97258 RVA: 0x00689398 File Offset: 0x00687598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetName(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			string name = commentComponentCommon.GetName();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BEB RID: 97259 RVA: 0x006893EC File Offset: 0x006875EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			commentComponentCommon.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BEC RID: 97260 RVA: 0x00689438 File Offset: 0x00687638
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int PostInit(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			commentComponentCommon.PostInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BED RID: 97261 RVA: 0x00689484 File Offset: 0x00687684
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DeInit(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			commentComponentCommon.DeInit();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BEE RID: 97262 RVA: 0x006894D0 File Offset: 0x006876D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Tick(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			uint deltaMillisecond;
			LuaObject.checkType(l, 2, out deltaMillisecond);
			commentComponentCommon.Tick(deltaMillisecond);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BEF RID: 97263 RVA: 0x00689528 File Offset: 0x00687728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PostDeSerialize(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			commentComponentCommon.PostDeSerialize();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF0 RID: 97264 RVA: 0x00689574 File Offset: 0x00687774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanCommentHero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = commentComponentCommon.CanCommentHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF1 RID: 97265 RVA: 0x006895D8 File Offset: 0x006877D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanPraiseHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			ulong entryInstanceId;
			LuaObject.checkType(l, 3, out entryInstanceId);
			int i = commentComponentCommon.CanPraiseHeroCommentEntry(heroId, entryInstanceId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF2 RID: 97266 RVA: 0x00689648 File Offset: 0x00687848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanGetHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = commentComponentCommon.CanGetHeroComment(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF3 RID: 97267 RVA: 0x006896AC File Offset: 0x006878AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CanViewPlayerHero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int i = commentComponentCommon.CanViewPlayerHero(heroId);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, i);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF4 RID: 97268 RVA: 0x00689710 File Offset: 0x00687910
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int IsNeedTruncateHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			bool b = commentComponentCommon.IsNeedTruncateHeroComment(content);
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

	// Token: 0x06017BF5 RID: 97269 RVA: 0x00689774 File Offset: 0x00687974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int TruncateHeroComment(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			string content;
			LuaObject.checkType(l, 2, out content);
			string s = commentComponentCommon.TruncateHeroComment(content);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, s);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF6 RID: 97270 RVA: 0x006897D8 File Offset: 0x006879D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FindPlayerHeroCommentEntry(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			PlayerHeroCommentEntry o = commentComponentCommon.FindPlayerHeroCommentEntry(heroId);
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

	// Token: 0x06017BF7 RID: 97271 RVA: 0x0068983C File Offset: 0x00687A3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_commentDS(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentComponentCommon.m_luaExportHelper.m_commentDS);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF8 RID: 97272 RVA: 0x00689894 File Offset: 0x00687A94
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_commentDS(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			DataSectionComment commentDS;
			LuaObject.checkType<DataSectionComment>(l, 2, out commentDS);
			commentComponentCommon.m_luaExportHelper.m_commentDS = commentDS;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BF9 RID: 97273 RVA: 0x006898F0 File Offset: 0x00687AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentComponentCommon.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BFA RID: 97274 RVA: 0x00689948 File Offset: 0x00687B48
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			commentComponentCommon.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BFB RID: 97275 RVA: 0x006899A4 File Offset: 0x00687BA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentComponentCommon.m_luaExportHelper.m_basicInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BFC RID: 97276 RVA: 0x006899FC File Offset: 0x00687BFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_basicInfo(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			PlayerBasicInfoComponentCommon basicInfo;
			LuaObject.checkType<PlayerBasicInfoComponentCommon>(l, 2, out basicInfo);
			commentComponentCommon.m_luaExportHelper.m_basicInfo = basicInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BFD RID: 97277 RVA: 0x00689A58 File Offset: 0x00687C58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentComponentCommon.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BFE RID: 97278 RVA: 0x00689AB0 File Offset: 0x00687CB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			HeroComponentCommon hero;
			LuaObject.checkType<HeroComponentCommon>(l, 2, out hero);
			commentComponentCommon.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017BFF RID: 97279 RVA: 0x00689B0C File Offset: 0x00687D0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Owner(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, commentComponentCommon.Owner);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C00 RID: 97280 RVA: 0x00689B60 File Offset: 0x00687D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Owner(IntPtr l)
	{
		int result;
		try
		{
			CommentComponentCommon commentComponentCommon = (CommentComponentCommon)LuaObject.checkSelf(l);
			IComponentOwner owner;
			LuaObject.checkType<IComponentOwner>(l, 2, out owner);
			commentComponentCommon.Owner = owner;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017C01 RID: 97281 RVA: 0x00689BB8 File Offset: 0x00687DB8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.CommentComponentCommon");
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.GetName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.PostInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.DeInit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.Tick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.PostDeSerialize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.CanCommentHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.CanPraiseHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.CanGetHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.CanViewPlayerHero);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.IsNeedTruncateHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.TruncateHeroComment);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.FindPlayerHeroCommentEntry);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheC);
		string name = "m_commentDS";
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.get_m_commentDS);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.set_m_commentDS);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheE, true);
		string name2 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.get_m_configDataLoader);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache10, true);
		string name3 = "m_basicInfo";
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.get_m_basicInfo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.set_m_basicInfo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache12, true);
		string name4 = "m_hero";
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.get_m_hero);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.set_m_hero);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache14, true);
		string name5 = "Owner";
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.get_Owner);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.set_Owner);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache16, true);
		if (Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_CommentComponentCommon.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_CommentComponentCommon.<>f__mg$cache17, typeof(CommentComponentCommon));
	}

	// Token: 0x0400E203 RID: 57859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E204 RID: 57860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E205 RID: 57861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E206 RID: 57862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E207 RID: 57863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E208 RID: 57864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E209 RID: 57865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E20A RID: 57866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E20B RID: 57867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E20C RID: 57868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E20D RID: 57869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E20E RID: 57870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E20F RID: 57871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E210 RID: 57872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E211 RID: 57873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E212 RID: 57874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E213 RID: 57875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E214 RID: 57876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E215 RID: 57877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E216 RID: 57878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E217 RID: 57879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E218 RID: 57880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E219 RID: 57881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E21A RID: 57882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;
}
