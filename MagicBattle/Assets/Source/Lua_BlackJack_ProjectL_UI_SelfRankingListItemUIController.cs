using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001572 RID: 5490
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController : LuaObject
{
	// Token: 0x06020FF5 RID: 135157 RVA: 0x00B15F14 File Offset: 0x00B14114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateCompareInfo(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			int lastRankLevel;
			LuaObject.checkType(l, 2, out lastRankLevel);
			int curRankLevel;
			LuaObject.checkType(l, 3, out curRankLevel);
			selfRankingListItemUIController.UpdateCompareInfo(lastRankLevel, curRankLevel);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF6 RID: 135158 RVA: 0x00B15F78 File Offset: 0x00B14178
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			selfRankingListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF7 RID: 135159 RVA: 0x00B15FCC File Offset: 0x00B141CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			selfRankingListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF8 RID: 135160 RVA: 0x00B16020 File Offset: 0x00B14220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Init(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			selfRankingListItemUIController.m_luaExportHelper.__callBase_Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FF9 RID: 135161 RVA: 0x00B16074 File Offset: 0x00B14274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			selfRankingListItemUIController.m_luaExportHelper.__callBase_RegisterItemClickEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FFA RID: 135162 RVA: 0x00B160D0 File Offset: 0x00B142D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_RegisterItemNeedFillEvent(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			selfRankingListItemUIController.m_luaExportHelper.__callBase_RegisterItemNeedFillEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FFB RID: 135163 RVA: 0x00B1612C File Offset: 0x00B1432C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetItemIndex(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			int i = selfRankingListItemUIController.m_luaExportHelper.__callBase_GetItemIndex();
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

	// Token: 0x06020FFC RID: 135164 RVA: 0x00B16188 File Offset: 0x00B14388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			RankingListType rankType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankType);
			int headIconId;
			LuaObject.checkType(l, 3, out headIconId);
			int rankLevel;
			LuaObject.checkType(l, 4, out rankLevel);
			int lv;
			LuaObject.checkType(l, 5, out lv);
			string playerName;
			LuaObject.checkType(l, 6, out playerName);
			int score;
			LuaObject.checkType(l, 7, out score);
			string heroName;
			LuaObject.checkType(l, 8, out heroName);
			selfRankingListItemUIController.m_luaExportHelper.__callBase_UpdateItemInfo(rankType, headIconId, rankLevel, lv, playerName, score, heroName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FFD RID: 135165 RVA: 0x00B16230 File Offset: 0x00B14430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_GetRankLevelSprite(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			int rankLevel;
			LuaObject.checkType(l, 2, out rankLevel);
			Sprite o = selfRankingListItemUIController.m_luaExportHelper.__callBase_GetRankLevelSprite(rankLevel);
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

	// Token: 0x06020FFE RID: 135166 RVA: 0x00B16298 File Offset: 0x00B14498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_UpdateDetailInfo(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			RankingListType rankType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankType);
			string heroName;
			LuaObject.checkType(l, 3, out heroName);
			int score;
			LuaObject.checkType(l, 4, out score);
			selfRankingListItemUIController.m_luaExportHelper.__callBase_UpdateDetailInfo(rankType, heroName, score);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020FFF RID: 135167 RVA: 0x00B16310 File Offset: 0x00B14510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ComparePanelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selfRankingListItemUIController.ComparePanelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021000 RID: 135168 RVA: 0x00B16364 File Offset: 0x00B14564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ComparePanelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController comparePanelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out comparePanelUIStateCtrl);
			selfRankingListItemUIController.ComparePanelUIStateCtrl = comparePanelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021001 RID: 135169 RVA: 0x00B163BC File Offset: 0x00B145BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_LastRankLevelText(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, selfRankingListItemUIController.LastRankLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021002 RID: 135170 RVA: 0x00B16410 File Offset: 0x00B14610
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_LastRankLevelText(IntPtr l)
	{
		int result;
		try
		{
			SelfRankingListItemUIController selfRankingListItemUIController = (SelfRankingListItemUIController)LuaObject.checkSelf(l);
			Text lastRankLevelText;
			LuaObject.checkType<Text>(l, 2, out lastRankLevelText);
			selfRankingListItemUIController.LastRankLevelText = lastRankLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021003 RID: 135171 RVA: 0x00B16468 File Offset: 0x00B14668
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SelfRankingListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.UpdateCompareInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_RegisterItemClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_RegisterItemNeedFillEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_GetItemIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_GetRankLevelSprite);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.__callBase_UpdateDetailInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cache9);
		string name = "ComparePanelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.get_ComparePanelUIStateCtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheA;
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.set_ComparePanelUIStateCtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheB, true);
		string name2 = "LastRankLevelText";
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.get_LastRankLevelText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheC;
		if (Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.set_LastRankLevelText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SelfRankingListItemUIController.<>f__mg$cacheD, true);
		LuaObject.createTypeMetatable(l, null, typeof(SelfRankingListItemUIController), typeof(RankingListItemUIController));
	}

	// Token: 0x04016EF3 RID: 93939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016EF4 RID: 93940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016EF5 RID: 93941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016EF6 RID: 93942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016EF7 RID: 93943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016EF8 RID: 93944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016EF9 RID: 93945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016EFA RID: 93946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016EFB RID: 93947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016EFC RID: 93948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016EFD RID: 93949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016EFE RID: 93950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016EFF RID: 93951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016F00 RID: 93952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;
}
