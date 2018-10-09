using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.ConfigData;
using SLua;
using UnityEngine.Scripting;

// Token: 0x02001174 RID: 4468
[Preserve]
public class Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo : LuaObject
{
	// Token: 0x06016EAD RID: 93869 RVA: 0x00625C04 File Offset: 0x00623E04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int constructor(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo o = new ConfigDataUnchartedScoreInfo();
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

	// Token: 0x06016EAE RID: 93870 RVA: 0x00625C4C File Offset: 0x00623E4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeroId2Bonus(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.HeroId2Bonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EAF RID: 93871 RVA: 0x00625CA0 File Offset: 0x00623EA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeroId2Bonus(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			Dictionary<int, int> heroId2Bonus;
			LuaObject.checkType<Dictionary<int, int>>(l, 2, out heroId2Bonus);
			configDataUnchartedScoreInfo.HeroId2Bonus = heroId2Bonus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB0 RID: 93872 RVA: 0x00625CF8 File Offset: 0x00623EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id2ChallengeLevelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.Id2ChallengeLevelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB1 RID: 93873 RVA: 0x00625D4C File Offset: 0x00623F4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id2ChallengeLevelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			Dictionary<int, ConfigDataChallengeLevelInfo> id2ChallengeLevelInfos;
			LuaObject.checkType<Dictionary<int, ConfigDataChallengeLevelInfo>>(l, 2, out id2ChallengeLevelInfos);
			configDataUnchartedScoreInfo.Id2ChallengeLevelInfos = id2ChallengeLevelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB2 RID: 93874 RVA: 0x00625DA4 File Offset: 0x00623FA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Id2ScoreLevelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.Id2ScoreLevelInfos);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB3 RID: 93875 RVA: 0x00625DF8 File Offset: 0x00623FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_Id2ScoreLevelInfos(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			Dictionary<int, ConfigDataScoreLevelInfo> id2ScoreLevelInfos;
			LuaObject.checkType<Dictionary<int, ConfigDataScoreLevelInfo>>(l, 2, out id2ScoreLevelInfos);
			configDataUnchartedScoreInfo.Id2ScoreLevelInfos = id2ScoreLevelInfos;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB4 RID: 93876 RVA: 0x00625E50 File Offset: 0x00624050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Score2GoodsList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.Score2GoodsList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB5 RID: 93877 RVA: 0x00625EA4 File Offset: 0x006240A4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Score2GoodsList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			Dictionary<int, List<Goods>> score2GoodsList;
			LuaObject.checkType<Dictionary<int, List<Goods>>>(l, 2, out score2GoodsList);
			configDataUnchartedScoreInfo.Score2GoodsList = score2GoodsList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB6 RID: 93878 RVA: 0x00625EFC File Offset: 0x006240FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ID);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB7 RID: 93879 RVA: 0x00625F50 File Offset: 0x00624150
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ID(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			int id;
			LuaObject.checkType(l, 2, out id);
			configDataUnchartedScoreInfo.ID = id;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB8 RID: 93880 RVA: 0x00625FA8 File Offset: 0x006241A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.Name);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EB9 RID: 93881 RVA: 0x00625FFC File Offset: 0x006241FC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_Name(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			string name;
			LuaObject.checkType(l, 2, out name);
			configDataUnchartedScoreInfo.Name = name;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EBA RID: 93882 RVA: 0x00626054 File Offset: 0x00624254
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PageImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.PageImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EBB RID: 93883 RVA: 0x006260A8 File Offset: 0x006242A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_PageImage(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			string pageImage;
			LuaObject.checkType(l, 2, out pageImage);
			configDataUnchartedScoreInfo.PageImage = pageImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EBC RID: 93884 RVA: 0x00626100 File Offset: 0x00624300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_UIState(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.UIState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EBD RID: 93885 RVA: 0x00626154 File Offset: 0x00624354
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_UIState(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			string uistate;
			LuaObject.checkType(l, 2, out uistate);
			configDataUnchartedScoreInfo.UIState = uistate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EBE RID: 93886 RVA: 0x006261AC File Offset: 0x006243AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScoreName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ScoreName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EBF RID: 93887 RVA: 0x00626200 File Offset: 0x00624400
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScoreName(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			string scoreName;
			LuaObject.checkType(l, 2, out scoreName);
			configDataUnchartedScoreInfo.ScoreName = scoreName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC0 RID: 93888 RVA: 0x00626258 File Offset: 0x00624458
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_BonusHeroIdList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.BonusHeroIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC1 RID: 93889 RVA: 0x006262AC File Offset: 0x006244AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_UnchartedScoreRewardGroupId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.UnchartedScoreRewardGroupId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC2 RID: 93890 RVA: 0x00626300 File Offset: 0x00624500
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_UnchartedScoreRewardGroupId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			int unchartedScoreRewardGroupId;
			LuaObject.checkType(l, 2, out unchartedScoreRewardGroupId);
			configDataUnchartedScoreInfo.UnchartedScoreRewardGroupId = unchartedScoreRewardGroupId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC3 RID: 93891 RVA: 0x00626358 File Offset: 0x00624558
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScoreItemId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ScoreItemId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC4 RID: 93892 RVA: 0x006263AC File Offset: 0x006245AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScoreItemId(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			int scoreItemId;
			LuaObject.checkType(l, 2, out scoreItemId);
			configDataUnchartedScoreInfo.ScoreItemId = scoreItemId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC5 RID: 93893 RVA: 0x00626404 File Offset: 0x00624604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChallengeLevelIdList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ChallengeLevelIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC6 RID: 93894 RVA: 0x00626458 File Offset: 0x00624658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScoreLevelIdList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ScoreLevelIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC7 RID: 93895 RVA: 0x006264AC File Offset: 0x006246AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_ScoreLevelBonusCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ScoreLevelBonusCount);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC8 RID: 93896 RVA: 0x00626500 File Offset: 0x00624700
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScoreLevelBonusCount(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			int scoreLevelBonusCount;
			LuaObject.checkType(l, 2, out scoreLevelBonusCount);
			configDataUnchartedScoreInfo.ScoreLevelBonusCount = scoreLevelBonusCount;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016EC9 RID: 93897 RVA: 0x00626558 File Offset: 0x00624758
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScoreLevelBonus(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ScoreLevelBonus);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ECA RID: 93898 RVA: 0x006265AC File Offset: 0x006247AC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_ScoreLevelBonus(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			int scoreLevelBonus;
			LuaObject.checkType(l, 2, out scoreLevelBonus);
			configDataUnchartedScoreInfo.ScoreLevelBonus = scoreLevelBonus;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ECB RID: 93899 RVA: 0x00626604 File Offset: 0x00624804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ModelIdList(IntPtr l)
	{
		int result;
		try
		{
			ConfigDataUnchartedScoreInfo configDataUnchartedScoreInfo = (ConfigDataUnchartedScoreInfo)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, configDataUnchartedScoreInfo.ModelIdList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06016ECC RID: 93900 RVA: 0x00626658 File Offset: 0x00624858
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ConfigData.ConfigDataUnchartedScoreInfo");
		string name = "HeroId2Bonus";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_HeroId2Bonus);
		}
		LuaCSFunction get = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache0;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_HeroId2Bonus);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1, true);
		string name2 = "Id2ChallengeLevelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_Id2ChallengeLevelInfos);
		}
		LuaCSFunction get2 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache2;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_Id2ChallengeLevelInfos);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache3, true);
		string name3 = "Id2ScoreLevelInfos";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_Id2ScoreLevelInfos);
		}
		LuaCSFunction get3 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache4;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_Id2ScoreLevelInfos);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache5, true);
		string name4 = "Score2GoodsList";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_Score2GoodsList);
		}
		LuaCSFunction get4 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache6;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_Score2GoodsList);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache7, true);
		string name5 = "ID";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ID);
		}
		LuaCSFunction get5 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache8;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_ID);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache9, true);
		string name6 = "Name";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_Name);
		}
		LuaCSFunction get6 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheA;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_Name);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheB, true);
		string name7 = "PageImage";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_PageImage);
		}
		LuaCSFunction get7 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheC;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_PageImage);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheD, true);
		string name8 = "UIState";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_UIState);
		}
		LuaCSFunction get8 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheE;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_UIState);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cacheF, true);
		string name9 = "ScoreName";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ScoreName);
		}
		LuaCSFunction get9 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache10;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_ScoreName);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache11, true);
		string name10 = "BonusHeroIdList";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_BonusHeroIdList);
		}
		LuaObject.addMember(l, name10, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache12, null, true);
		string name11 = "UnchartedScoreRewardGroupId";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_UnchartedScoreRewardGroupId);
		}
		LuaCSFunction get10 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache13;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_UnchartedScoreRewardGroupId);
		}
		LuaObject.addMember(l, name11, get10, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache14, true);
		string name12 = "ScoreItemId";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ScoreItemId);
		}
		LuaCSFunction get11 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache15;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_ScoreItemId);
		}
		LuaObject.addMember(l, name12, get11, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache16, true);
		string name13 = "ChallengeLevelIdList";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ChallengeLevelIdList);
		}
		LuaObject.addMember(l, name13, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache17, null, true);
		string name14 = "ScoreLevelIdList";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ScoreLevelIdList);
		}
		LuaObject.addMember(l, name14, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache18, null, true);
		string name15 = "ScoreLevelBonusCount";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ScoreLevelBonusCount);
		}
		LuaCSFunction get12 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache19;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_ScoreLevelBonusCount);
		}
		LuaObject.addMember(l, name15, get12, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1A, true);
		string name16 = "ScoreLevelBonus";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ScoreLevelBonus);
		}
		LuaCSFunction get13 = Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1B;
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.set_ScoreLevelBonus);
		}
		LuaObject.addMember(l, name16, get13, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1C, true);
		string name17 = "ModelIdList";
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.get_ModelIdList);
		}
		LuaObject.addMember(l, name17, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1D, null, true);
		if (Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.constructor);
		}
		LuaObject.createTypeMetatable(l, Lua_BlackJack_ConfigData_ConfigDataUnchartedScoreInfo.<>f__mg$cache1E, typeof(ConfigDataUnchartedScoreInfo));
	}

	// Token: 0x0400D5A7 RID: 54695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0400D5A8 RID: 54696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0400D5A9 RID: 54697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0400D5AA RID: 54698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0400D5AB RID: 54699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0400D5AC RID: 54700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0400D5AD RID: 54701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0400D5AE RID: 54702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0400D5AF RID: 54703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0400D5B0 RID: 54704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0400D5B1 RID: 54705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0400D5B2 RID: 54706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0400D5B3 RID: 54707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0400D5B4 RID: 54708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0400D5B5 RID: 54709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0400D5B6 RID: 54710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0400D5B7 RID: 54711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0400D5B8 RID: 54712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0400D5B9 RID: 54713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0400D5BA RID: 54714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0400D5BB RID: 54715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0400D5BC RID: 54716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0400D5BD RID: 54717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0400D5BE RID: 54718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0400D5BF RID: 54719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0400D5C0 RID: 54720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0400D5C1 RID: 54721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x0400D5C2 RID: 54722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0400D5C3 RID: 54723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0400D5C4 RID: 54724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0400D5C5 RID: 54725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
