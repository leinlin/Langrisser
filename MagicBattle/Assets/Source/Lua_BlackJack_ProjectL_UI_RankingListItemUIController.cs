using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001549 RID: 5449
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RankingListItemUIController : LuaObject
{
	// Token: 0x0602094F RID: 133455 RVA: 0x00AE0FD0 File Offset: 0x00ADF1D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Init(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			rankingListItemUIController.Init();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020950 RID: 133456 RVA: 0x00AE101C File Offset: 0x00ADF21C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItemClickEvent(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			rankingListItemUIController.RegisterItemClickEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020951 RID: 133457 RVA: 0x00AE1074 File Offset: 0x00ADF274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int RegisterItemNeedFillEvent(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 2, out action);
			rankingListItemUIController.RegisterItemNeedFillEvent(action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020952 RID: 133458 RVA: 0x00AE10CC File Offset: 0x00ADF2CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetItemIndex(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			int itemIndex = rankingListItemUIController.GetItemIndex();
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, itemIndex);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020953 RID: 133459 RVA: 0x00AE1120 File Offset: 0x00ADF320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
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
			rankingListItemUIController.UpdateItemInfo(rankType, headIconId, rankLevel, lv, playerName, score, heroName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020954 RID: 133460 RVA: 0x00AE11C4 File Offset: 0x00ADF3C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			rankingListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020955 RID: 133461 RVA: 0x00AE1218 File Offset: 0x00ADF418
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetRankLevelSprite(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			int rankLevel;
			LuaObject.checkType(l, 2, out rankLevel);
			Sprite rankLevelSprite = rankingListItemUIController.m_luaExportHelper.GetRankLevelSprite(rankLevel);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankLevelSprite);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020956 RID: 133462 RVA: 0x00AE1280 File Offset: 0x00ADF480
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateDetailInfo(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			RankingListType rankType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankType);
			string heroName;
			LuaObject.checkType(l, 3, out heroName);
			int score;
			LuaObject.checkType(l, 4, out score);
			rankingListItemUIController.m_luaExportHelper.UpdateDetailInfo(rankType, heroName, score);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020957 RID: 133463 RVA: 0x00AE12F8 File Offset: 0x00ADF4F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rankingListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020958 RID: 133464 RVA: 0x00AE1364 File Offset: 0x00ADF564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			rankingListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020959 RID: 133465 RVA: 0x00AE13B8 File Offset: 0x00ADF5B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			rankingListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602095A RID: 133466 RVA: 0x00AE140C File Offset: 0x00ADF60C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Type fieldType;
			LuaObject.checkType(l, 2, out fieldType);
			string path;
			LuaObject.checkType(l, 3, out path);
			AutoBindAttribute.InitState initState;
			LuaObject.checkEnum<AutoBindAttribute.InitState>(l, 4, out initState);
			string fieldName;
			LuaObject.checkType(l, 5, out fieldName);
			string ctrlName;
			LuaObject.checkType(l, 6, out ctrlName);
			bool optional;
			LuaObject.checkType(l, 7, out optional);
			UnityEngine.Object o = rankingListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602095B RID: 133467 RVA: 0x00AE14B4 File Offset: 0x00ADF6B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			rankingListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602095C RID: 133468 RVA: 0x00AE1508 File Offset: 0x00ADF708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rankingListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602095D RID: 133469 RVA: 0x00AE1574 File Offset: 0x00ADF774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rankingListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RankingListItemUIController rankingListItemUIController2 = (RankingListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rankingListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetButtonClickListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602095E RID: 133470 RVA: 0x00AE1684 File Offset: 0x00ADF884
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602095F RID: 133471 RVA: 0x00AE16F0 File Offset: 0x00ADF8F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020960 RID: 133472 RVA: 0x00AE175C File Offset: 0x00ADF95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020961 RID: 133473 RVA: 0x00AE17C8 File Offset: 0x00ADF9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020962 RID: 133474 RVA: 0x00AE1834 File Offset: 0x00ADFA34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rankingListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RankingListItemUIController rankingListItemUIController2 = (RankingListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rankingListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else
			{
				LuaObject.pushValue(l, false);
				LuaDLL.lua_pushstring(l, "No matched override function __callBase_SetToggleValueChangedListener to call");
				result = 2;
			}
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020963 RID: 133475 RVA: 0x00AE1944 File Offset: 0x00ADFB44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			string s = rankingListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020964 RID: 133476 RVA: 0x00AE19A0 File Offset: 0x00ADFBA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.ScrollItemBaseUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020965 RID: 133477 RVA: 0x00AE19F4 File Offset: 0x00ADFBF4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ScrollItemBaseUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			ScrollItemBaseUIController scrollItemBaseUICtrl;
			LuaObject.checkType<ScrollItemBaseUIController>(l, 2, out scrollItemBaseUICtrl);
			rankingListItemUIController.ScrollItemBaseUICtrl = scrollItemBaseUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020966 RID: 133478 RVA: 0x00AE1A4C File Offset: 0x00ADFC4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.RankValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020967 RID: 133479 RVA: 0x00AE1AA0 File Offset: 0x00ADFCA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RankValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text rankValueText;
			LuaObject.checkType<Text>(l, 2, out rankValueText);
			rankingListItemUIController.RankValueText = rankValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020968 RID: 133480 RVA: 0x00AE1AF8 File Offset: 0x00ADFCF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RankValueImage(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.RankValueImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020969 RID: 133481 RVA: 0x00AE1B4C File Offset: 0x00ADFD4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RankValueImage(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Image rankValueImage;
			LuaObject.checkType<Image>(l, 2, out rankValueImage);
			rankingListItemUIController.RankValueImage = rankValueImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602096A RID: 133482 RVA: 0x00AE1BA4 File Offset: 0x00ADFDA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadIconImage(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.HeadIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602096B RID: 133483 RVA: 0x00AE1BF8 File Offset: 0x00ADFDF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadIconImage(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Image headIconImage;
			LuaObject.checkType<Image>(l, 2, out headIconImage);
			rankingListItemUIController.HeadIconImage = headIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602096C RID: 133484 RVA: 0x00AE1C50 File Offset: 0x00ADFE50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.PlayerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602096D RID: 133485 RVA: 0x00AE1CA4 File Offset: 0x00ADFEA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerLevelText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			rankingListItemUIController.PlayerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602096E RID: 133486 RVA: 0x00AE1CFC File Offset: 0x00ADFEFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_PlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.PlayerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602096F RID: 133487 RVA: 0x00AE1D50 File Offset: 0x00ADFF50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_PlayerNameText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			rankingListItemUIController.PlayerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020970 RID: 133488 RVA: 0x00AE1DA8 File Offset: 0x00ADFFA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_DetailGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.DetailGroupStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020971 RID: 133489 RVA: 0x00AE1DFC File Offset: 0x00ADFFFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_DetailGroupStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController detailGroupStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out detailGroupStateCtrl);
			rankingListItemUIController.DetailGroupStateCtrl = detailGroupStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020972 RID: 133490 RVA: 0x00AE1E54 File Offset: 0x00AE0054
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_TopHeroScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.TopHeroScoreValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020973 RID: 133491 RVA: 0x00AE1EA8 File Offset: 0x00AE00A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_TopHeroScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text topHeroScoreValueText;
			LuaObject.checkType<Text>(l, 2, out topHeroScoreValueText);
			rankingListItemUIController.TopHeroScoreValueText = topHeroScoreValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020974 RID: 133492 RVA: 0x00AE1F00 File Offset: 0x00AE0100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_AllHeroScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.AllHeroScoreValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020975 RID: 133493 RVA: 0x00AE1F54 File Offset: 0x00AE0154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_AllHeroScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text allHeroScoreValueText;
			LuaObject.checkType<Text>(l, 2, out allHeroScoreValueText);
			rankingListItemUIController.AllHeroScoreValueText = allHeroScoreValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020976 RID: 133494 RVA: 0x00AE1FAC File Offset: 0x00AE01AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChampionHeroScoreTitleText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.ChampionHeroScoreTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020977 RID: 133495 RVA: 0x00AE2000 File Offset: 0x00AE0200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChampionHeroScoreTitleText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text championHeroScoreTitleText;
			LuaObject.checkType<Text>(l, 2, out championHeroScoreTitleText);
			rankingListItemUIController.ChampionHeroScoreTitleText = championHeroScoreTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020978 RID: 133496 RVA: 0x00AE2058 File Offset: 0x00AE0258
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ChampionHeroScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.ChampionHeroScoreValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020979 RID: 133497 RVA: 0x00AE20AC File Offset: 0x00AE02AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ChampionHeroScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text championHeroScoreValueText;
			LuaObject.checkType<Text>(l, 2, out championHeroScoreValueText);
			rankingListItemUIController.ChampionHeroScoreValueText = championHeroScoreValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602097A RID: 133498 RVA: 0x00AE2104 File Offset: 0x00AE0304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftChapterStarScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.RiftChapterStarScoreValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602097B RID: 133499 RVA: 0x00AE2158 File Offset: 0x00AE0358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RiftChapterStarScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text riftChapterStarScoreValueText;
			LuaObject.checkType<Text>(l, 2, out riftChapterStarScoreValueText);
			rankingListItemUIController.RiftChapterStarScoreValueText = riftChapterStarScoreValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602097C RID: 133500 RVA: 0x00AE21B0 File Offset: 0x00AE03B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_RiftAchievementScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingListItemUIController.RiftAchievementScoreValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602097D RID: 133501 RVA: 0x00AE2204 File Offset: 0x00AE0404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_RiftAchievementScoreValueText(IntPtr l)
	{
		int result;
		try
		{
			RankingListItemUIController rankingListItemUIController = (RankingListItemUIController)LuaObject.checkSelf(l);
			Text riftAchievementScoreValueText;
			LuaObject.checkType<Text>(l, 2, out riftAchievementScoreValueText);
			rankingListItemUIController.RiftAchievementScoreValueText = riftAchievementScoreValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602097E RID: 133502 RVA: 0x00AE225C File Offset: 0x00AE045C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RankingListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.Init);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.RegisterItemClickEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.RegisterItemNeedFillEvent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.GetItemIndex);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.GetRankLevelSprite);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.UpdateDetailInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache14);
		string name = "ScrollItemBaseUICtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_ScrollItemBaseUICtrl);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_ScrollItemBaseUICtrl);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache16, true);
		string name2 = "RankValueText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_RankValueText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_RankValueText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache18, true);
		string name3 = "RankValueImage";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_RankValueImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_RankValueImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1A, true);
		string name4 = "HeadIconImage";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_HeadIconImage);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_HeadIconImage);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1C, true);
		string name5 = "PlayerLevelText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_PlayerLevelText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_PlayerLevelText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1E, true);
		string name6 = "PlayerNameText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_PlayerNameText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_PlayerNameText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache20, true);
		string name7 = "DetailGroupStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_DetailGroupStateCtrl);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_DetailGroupStateCtrl);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache22, true);
		string name8 = "TopHeroScoreValueText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_TopHeroScoreValueText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_TopHeroScoreValueText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache24, true);
		string name9 = "AllHeroScoreValueText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_AllHeroScoreValueText);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_AllHeroScoreValueText);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache26, true);
		string name10 = "ChampionHeroScoreTitleText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_ChampionHeroScoreTitleText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_ChampionHeroScoreTitleText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache28, true);
		string name11 = "ChampionHeroScoreValueText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_ChampionHeroScoreValueText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_ChampionHeroScoreValueText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2A, true);
		string name12 = "RiftChapterStarScoreValueText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_RiftChapterStarScoreValueText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_RiftChapterStarScoreValueText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2C, true);
		string name13 = "RiftAchievementScoreValueText";
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.get_RiftAchievementScoreValueText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingListItemUIController.set_RiftAchievementScoreValueText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RankingListItemUIController.<>f__mg$cache2E, true);
		LuaObject.createTypeMetatable(l, null, typeof(RankingListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401689F RID: 92319
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040168A0 RID: 92320
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040168A1 RID: 92321
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040168A2 RID: 92322
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040168A3 RID: 92323
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040168A4 RID: 92324
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040168A5 RID: 92325
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040168A6 RID: 92326
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040168A7 RID: 92327
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040168A8 RID: 92328
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040168A9 RID: 92329
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040168AA RID: 92330
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040168AB RID: 92331
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040168AC RID: 92332
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040168AD RID: 92333
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040168AE RID: 92334
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040168AF RID: 92335
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040168B0 RID: 92336
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040168B1 RID: 92337
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040168B2 RID: 92338
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040168B3 RID: 92339
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040168B4 RID: 92340
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040168B5 RID: 92341
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040168B6 RID: 92342
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040168B7 RID: 92343
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040168B8 RID: 92344
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040168B9 RID: 92345
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040168BA RID: 92346
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040168BB RID: 92347
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040168BC RID: 92348
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040168BD RID: 92349
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040168BE RID: 92350
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040168BF RID: 92351
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040168C0 RID: 92352
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040168C1 RID: 92353
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040168C2 RID: 92354
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040168C3 RID: 92355
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040168C4 RID: 92356
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040168C5 RID: 92357
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040168C6 RID: 92358
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040168C7 RID: 92359
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040168C8 RID: 92360
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040168C9 RID: 92361
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040168CA RID: 92362
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040168CB RID: 92363
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040168CC RID: 92364
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040168CD RID: 92365
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;
}
