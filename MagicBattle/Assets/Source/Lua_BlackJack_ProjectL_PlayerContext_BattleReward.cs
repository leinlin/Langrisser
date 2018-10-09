using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020012B4 RID: 4788
[Preserve]
public class Lua_BlackJack_ProjectL_PlayerContext_BattleReward : LuaObject
{
	// Token: 0x06019256 RID: 102998 RVA: 0x0072F0AC File Offset: 0x0072D2AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BattleReward o = new BattleReward();
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

	// Token: 0x06019257 RID: 102999 RVA: 0x0072F0F4 File Offset: 0x0072D2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Clear(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			battleReward.Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019258 RID: 103000 RVA: 0x0072F140 File Offset: 0x0072D340
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsEmpty(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			bool b = battleReward.IsEmpty();
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

	// Token: 0x06019259 RID: 103001 RVA: 0x0072F194 File Offset: 0x0072D394
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsChestGoodsEmpty(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			bool b = battleReward.IsChestGoodsEmpty();
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

	// Token: 0x0601925A RID: 103002 RVA: 0x0072F1E8 File Offset: 0x0072D3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.PlayerExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601925B RID: 103003 RVA: 0x0072F23C File Offset: 0x0072D43C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerExp(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int playerExp;
			LuaObject.checkType(l, 2, out playerExp);
			battleReward.PlayerExp = playerExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601925C RID: 103004 RVA: 0x0072F294 File Offset: 0x0072D494
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.HeroExp);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601925D RID: 103005 RVA: 0x0072F2E8 File Offset: 0x0072D4E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeroExp(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int heroExp;
			LuaObject.checkType(l, 2, out heroExp);
			battleReward.HeroExp = heroExp;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601925E RID: 103006 RVA: 0x0072F340 File Offset: 0x0072D540
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Gold(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.Gold);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601925F RID: 103007 RVA: 0x0072F394 File Offset: 0x0072D594
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Gold(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int gold;
			LuaObject.checkType(l, 2, out gold);
			battleReward.Gold = gold;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019260 RID: 103008 RVA: 0x0072F3EC File Offset: 0x0072D5EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_FriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.FriendshipPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019261 RID: 103009 RVA: 0x0072F440 File Offset: 0x0072D640
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FriendshipPoints(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int friendshipPoints;
			LuaObject.checkType(l, 2, out friendshipPoints);
			battleReward.FriendshipPoints = friendshipPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019262 RID: 103010 RVA: 0x0072F498 File Offset: 0x0072D698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Goods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.Goods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019263 RID: 103011 RVA: 0x0072F4EC File Offset: 0x0072D6EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Goods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			List<Goods> goods;
			LuaObject.checkType<List<Goods>>(l, 2, out goods);
			battleReward.Goods = goods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019264 RID: 103012 RVA: 0x0072F544 File Offset: 0x0072D744
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamGoods1(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.TeamGoods1);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019265 RID: 103013 RVA: 0x0072F598 File Offset: 0x0072D798
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_TeamGoods1(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			List<Goods> teamGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out teamGoods);
			battleReward.TeamGoods1 = teamGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019266 RID: 103014 RVA: 0x0072F5F0 File Offset: 0x0072D7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TeamGoods2(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.TeamGoods2);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019267 RID: 103015 RVA: 0x0072F644 File Offset: 0x0072D844
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TeamGoods2(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			List<Goods> teamGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out teamGoods);
			battleReward.TeamGoods2 = teamGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019268 RID: 103016 RVA: 0x0072F69C File Offset: 0x0072D89C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_FriendGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.FriendGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019269 RID: 103017 RVA: 0x0072F6F0 File Offset: 0x0072D8F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_FriendGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			List<Goods> friendGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out friendGoods);
			battleReward.FriendGoods = friendGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601926A RID: 103018 RVA: 0x0072F748 File Offset: 0x0072D948
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DailyGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.DailyGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601926B RID: 103019 RVA: 0x0072F79C File Offset: 0x0072D99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DailyGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			List<Goods> dailyGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out dailyGoods);
			battleReward.DailyGoods = dailyGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601926C RID: 103020 RVA: 0x0072F7F4 File Offset: 0x0072D9F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScoreGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.ScoreGoods);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601926D RID: 103021 RVA: 0x0072F848 File Offset: 0x0072DA48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScoreGoods(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			List<Goods> scoreGoods;
			LuaObject.checkType<List<Goods>>(l, 2, out scoreGoods);
			battleReward.ScoreGoods = scoreGoods;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601926E RID: 103022 RVA: 0x0072F8A0 File Offset: 0x0072DAA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Score(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.Score);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601926F RID: 103023 RVA: 0x0072F8F4 File Offset: 0x0072DAF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Score(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int score;
			LuaObject.checkType(l, 2, out score);
			battleReward.Score = score;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019270 RID: 103024 RVA: 0x0072F94C File Offset: 0x0072DB4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_DailyScoreBonus(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.DailyScoreBonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019271 RID: 103025 RVA: 0x0072F9A0 File Offset: 0x0072DBA0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_DailyScoreBonus(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int dailyScoreBonus;
			LuaObject.checkType(l, 2, out dailyScoreBonus);
			battleReward.DailyScoreBonus = dailyScoreBonus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019272 RID: 103026 RVA: 0x0072F9F8 File Offset: 0x0072DBF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroScoreBonus(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, battleReward.HeroScoreBonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019273 RID: 103027 RVA: 0x0072FA4C File Offset: 0x0072DC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroScoreBonus(IntPtr l)
	{
		int result;
		try
		{
			BattleReward battleReward = (BattleReward)LuaObject.checkSelf(l);
			int heroScoreBonus;
			LuaObject.checkType(l, 2, out heroScoreBonus);
			battleReward.HeroScoreBonus = heroScoreBonus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06019274 RID: 103028 RVA: 0x0072FAA4 File Offset: 0x0072DCA4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.PlayerContext.BattleReward");
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.IsEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.IsChestGoodsEmpty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache2);
		string name = "PlayerExp";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_PlayerExp);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache3;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_PlayerExp);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache4, true);
		string name2 = "HeroExp";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_HeroExp);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache5;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_HeroExp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache6, true);
		string name3 = "Gold";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_Gold);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache7;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_Gold);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache8, true);
		string name4 = "FriendshipPoints";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_FriendshipPoints);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache9;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_FriendshipPoints);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheA, true);
		string name5 = "Goods";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_Goods);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheB;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_Goods);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheC, true);
		string name6 = "TeamGoods1";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_TeamGoods1);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheD;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_TeamGoods1);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheE, true);
		string name7 = "TeamGoods2";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_TeamGoods2);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cacheF;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_TeamGoods2);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache10, true);
		string name8 = "FriendGoods";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_FriendGoods);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_FriendGoods);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache12, true);
		string name9 = "DailyGoods";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_DailyGoods);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_DailyGoods);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache14, true);
		string name10 = "ScoreGoods";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_ScoreGoods);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_ScoreGoods);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache16, true);
		string name11 = "Score";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_Score);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_Score);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache18, true);
		string name12 = "DailyScoreBonus";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_DailyScoreBonus);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_DailyScoreBonus);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1A, true);
		string name13 = "HeroScoreBonus";
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.get_HeroScoreBonus);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.set_HeroScoreBonus);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1C, true);
		if (Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_PlayerContext_BattleReward.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_PlayerContext_BattleReward.<>f__mg$cache1D, typeof(BattleReward));
	}

	// Token: 0x0400F6D0 RID: 63184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400F6D1 RID: 63185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400F6D2 RID: 63186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400F6D3 RID: 63187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400F6D4 RID: 63188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400F6D5 RID: 63189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400F6D6 RID: 63190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400F6D7 RID: 63191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400F6D8 RID: 63192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400F6D9 RID: 63193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400F6DA RID: 63194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400F6DB RID: 63195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400F6DC RID: 63196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400F6DD RID: 63197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400F6DE RID: 63198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400F6DF RID: 63199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400F6E0 RID: 63200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400F6E1 RID: 63201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400F6E2 RID: 63202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400F6E3 RID: 63203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400F6E4 RID: 63204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400F6E5 RID: 63205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400F6E6 RID: 63206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400F6E7 RID: 63207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400F6E8 RID: 63208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400F6E9 RID: 63209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400F6EA RID: 63210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400F6EB RID: 63211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400F6EC RID: 63212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400F6ED RID: 63213
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;
}
