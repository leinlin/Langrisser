using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.Protocol;
using SLua;
using UnityEngine.Scripting;

// Token: 0x020011D5 RID: 4565
[Preserve]
public class Lua_BlackJack_ProjectL_Common_BusinessCard : LuaObject
{
	// Token: 0x06017AF7 RID: 97015 RVA: 0x00682C60 File Offset: 0x00680E60
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard o = new BusinessCard();
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

	// Token: 0x06017AF8 RID: 97016 RVA: 0x00682CA8 File Offset: 0x00680EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ToProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard;
			LuaObject.checkType<BusinessCard>(l, 1, out businessCard);
			ProBusinessCard o = BusinessCard.ToProtocol(businessCard);
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

	// Token: 0x06017AF9 RID: 97017 RVA: 0x00682CFC File Offset: 0x00680EFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FromProtocol_s(IntPtr l)
	{
		int result;
		try
		{
			ProBusinessCard pbBusinessCard;
			LuaObject.checkType<ProBusinessCard>(l, 1, out pbBusinessCard);
			BusinessCard o = BusinessCard.FromProtocol(pbBusinessCard);
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

	// Token: 0x06017AFA RID: 97018 RVA: 0x00682D50 File Offset: 0x00680F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Heroes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.Heroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AFB RID: 97019 RVA: 0x00682DA4 File Offset: 0x00680FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Heroes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			List<BattleHero> heroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out heroes);
			businessCard.Heroes = heroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AFC RID: 97020 RVA: 0x00682DFC File Offset: 0x00680FFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Techs(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.Techs);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AFD RID: 97021 RVA: 0x00682E50 File Offset: 0x00681050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Techs(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			List<TrainingTech> techs;
			LuaObject.checkType<List<TrainingTech>>(l, 2, out techs);
			businessCard.Techs = techs;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AFE RID: 97022 RVA: 0x00682EA8 File Offset: 0x006810A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MostSkilledHeroes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.MostSkilledHeroes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017AFF RID: 97023 RVA: 0x00682EFC File Offset: 0x006810FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_MostSkilledHeroes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			List<BattleHero> mostSkilledHeroes;
			LuaObject.checkType<List<BattleHero>>(l, 2, out mostSkilledHeroes);
			businessCard.MostSkilledHeroes = mostSkilledHeroes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B00 RID: 97024 RVA: 0x00682F54 File Offset: 0x00681154
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UserId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.UserId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B01 RID: 97025 RVA: 0x00682FA8 File Offset: 0x006811A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UserId(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			string userId;
			LuaObject.checkType(l, 2, out userId);
			businessCard.UserId = userId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B02 RID: 97026 RVA: 0x00683000 File Offset: 0x00681200
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B03 RID: 97027 RVA: 0x00683054 File Offset: 0x00681254
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			businessCard.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B04 RID: 97028 RVA: 0x006830AC File Offset: 0x006812AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_Level(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.Level);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B05 RID: 97029 RVA: 0x00683100 File Offset: 0x00681300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Level(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			int level;
			LuaObject.checkType(l, 2, out level);
			businessCard.Level = level;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B06 RID: 97030 RVA: 0x00683158 File Offset: 0x00681358
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.HeadIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B07 RID: 97031 RVA: 0x006831AC File Offset: 0x006813AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_HeadIcon(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			int headIcon;
			LuaObject.checkType(l, 2, out headIcon);
			businessCard.HeadIcon = headIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B08 RID: 97032 RVA: 0x00683204 File Offset: 0x00681404
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.ArenaPoints);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B09 RID: 97033 RVA: 0x00683258 File Offset: 0x00681458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ArenaPoints(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			int arenaPoints;
			LuaObject.checkType(l, 2, out arenaPoints);
			businessCard.ArenaPoints = arenaPoints;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B0A RID: 97034 RVA: 0x006832B0 File Offset: 0x006814B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Likes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.Likes);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B0B RID: 97035 RVA: 0x00683304 File Offset: 0x00681504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Likes(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			int likes;
			LuaObject.checkType(l, 2, out likes);
			businessCard.Likes = likes;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B0C RID: 97036 RVA: 0x0068335C File Offset: 0x0068155C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_IsOnLine(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.IsOnLine);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B0D RID: 97037 RVA: 0x006833B0 File Offset: 0x006815B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_IsOnLine(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			bool isOnLine;
			LuaObject.checkType(l, 2, out isOnLine);
			businessCard.IsOnLine = isOnLine;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B0E RID: 97038 RVA: 0x00683408 File Offset: 0x00681608
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SetInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.SetInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B0F RID: 97039 RVA: 0x0068345C File Offset: 0x0068165C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SetInfo(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			BusinessCardInfoSet setInfo;
			LuaObject.checkType<BusinessCardInfoSet>(l, 2, out setInfo);
			businessCard.SetInfo = setInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B10 RID: 97040 RVA: 0x006834B4 File Offset: 0x006816B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_StatisticalData(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, businessCard.StatisticalData);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B11 RID: 97041 RVA: 0x00683508 File Offset: 0x00681708
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_StatisticalData(IntPtr l)
	{
		int result;
		try
		{
			BusinessCard businessCard = (BusinessCard)LuaObject.checkSelf(l);
			BusinessCardStatisticalData statisticalData;
			LuaObject.checkType<BusinessCardStatisticalData>(l, 2, out statisticalData);
			businessCard.StatisticalData = statisticalData;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06017B12 RID: 97042 RVA: 0x00683560 File Offset: 0x00681760
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.Common.BusinessCard");
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.ToProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.FromProtocol_s);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache1);
		string name = "Heroes";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_Heroes);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache2;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_Heroes);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache3, true);
		string name2 = "Techs";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_Techs);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache4;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_Techs);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache5, true);
		string name3 = "MostSkilledHeroes";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_MostSkilledHeroes);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache6;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_MostSkilledHeroes);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache7, true);
		string name4 = "UserId";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_UserId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache8;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_UserId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache9, true);
		string name5 = "Name";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_Name);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_Name);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheB, true);
		string name6 = "Level";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_Level);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_Level);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheD, true);
		string name7 = "HeadIcon";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_HeadIcon);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheE;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_HeadIcon);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cacheF, true);
		string name8 = "ArenaPoints";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_ArenaPoints);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_ArenaPoints);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache11, true);
		string name9 = "Likes";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_Likes);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_Likes);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache13, true);
		string name10 = "IsOnLine";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_IsOnLine);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_IsOnLine);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache15, true);
		string name11 = "SetInfo";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_SetInfo);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_SetInfo);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache17, true);
		string name12 = "StatisticalData";
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.get_StatisticalData);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.set_StatisticalData);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache19, true);
		if (Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_Common_BusinessCard.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ProjectL_Common_BusinessCard.<>f__mg$cache1A, typeof(BusinessCard));
	}

	// Token: 0x0400E12F RID: 57647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400E130 RID: 57648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400E131 RID: 57649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400E132 RID: 57650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400E133 RID: 57651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400E134 RID: 57652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400E135 RID: 57653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400E136 RID: 57654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400E137 RID: 57655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400E138 RID: 57656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400E139 RID: 57657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400E13A RID: 57658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400E13B RID: 57659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400E13C RID: 57660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400E13D RID: 57661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400E13E RID: 57662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400E13F RID: 57663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400E140 RID: 57664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400E141 RID: 57665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400E142 RID: 57666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400E143 RID: 57667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400E144 RID: 57668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400E145 RID: 57669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400E146 RID: 57670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400E147 RID: 57671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400E148 RID: 57672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400E149 RID: 57673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
