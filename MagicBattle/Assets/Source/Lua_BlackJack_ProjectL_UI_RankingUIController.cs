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

// Token: 0x0200154D RID: 5453
[Preserve]
public class Lua_BlackJack_ProjectL_UI_RankingUIController : LuaObject
{
	// Token: 0x060209BF RID: 133567 RVA: 0x00AE4998 File Offset: 0x00AE2B98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateRankingUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType rankingType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingType);
			rankingUIController.UpdateRankingUICtrl(rankingType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C0 RID: 133568 RVA: 0x00AE49F0 File Offset: 0x00AE2BF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C1 RID: 133569 RVA: 0x00AE4A44 File Offset: 0x00AE2C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetMainMenuSelectStateFromRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType rankingType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankingType);
			RankingUIController.MainMenuSelectState mainMenuSelectStateFromRankingType = rankingUIController.m_luaExportHelper.GetMainMenuSelectStateFromRankingType(rankingType);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)mainMenuSelectStateFromRankingType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C2 RID: 133570 RVA: 0x00AE4AAC File Offset: 0x00AE2CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMainMenuSelectState(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingUIController.MainMenuSelectState mainMenuSelectState;
			LuaObject.checkEnum<RankingUIController.MainMenuSelectState>(l, 2, out mainMenuSelectState);
			rankingUIController.m_luaExportHelper.SetMainMenuSelectState(mainMenuSelectState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C3 RID: 133571 RVA: 0x00AE4B08 File Offset: 0x00AE2D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAllMainMenuUnselect(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.SetAllMainMenuUnselect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C4 RID: 133572 RVA: 0x00AE4B5C File Offset: 0x00AE2D5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetSubMenuSelectState(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType subMenuSelectState;
			LuaObject.checkEnum<RankingListType>(l, 2, out subMenuSelectState);
			rankingUIController.m_luaExportHelper.SetSubMenuSelectState(subMenuSelectState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C5 RID: 133573 RVA: 0x00AE4BB8 File Offset: 0x00AE2DB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetAllSubMenuToggleUnselect(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.SetAllSubMenuToggleUnselect();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C6 RID: 133574 RVA: 0x00AE4C0C File Offset: 0x00AE2E0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPowerSubMenuPanel(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			bool isshow;
			LuaObject.checkType(l, 2, out isshow);
			rankingUIController.m_luaExportHelper.ShowPowerSubMenuPanel(isshow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C7 RID: 133575 RVA: 0x00AE4C68 File Offset: 0x00AE2E68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowRiftSubMenuPanel(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			bool isshow;
			LuaObject.checkType(l, 2, out isshow);
			rankingUIController.m_luaExportHelper.ShowRiftSubMenuPanel(isshow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C8 RID: 133576 RVA: 0x00AE4CC4 File Offset: 0x00AE2EC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HideAllSubMenuPanel(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.HideAllSubMenuPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209C9 RID: 133577 RVA: 0x00AE4D18 File Offset: 0x00AE2F18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209CA RID: 133578 RVA: 0x00AE4D6C File Offset: 0x00AE2F6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnNoneSubMenuAreaClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnNoneSubMenuAreaClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209CB RID: 133579 RVA: 0x00AE4DC0 File Offset: 0x00AE2FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMainMenuPowerClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnMainMenuPowerClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209CC RID: 133580 RVA: 0x00AE4E14 File Offset: 0x00AE3014
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMainMenuRiftClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnMainMenuRiftClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209CD RID: 133581 RVA: 0x00AE4E68 File Offset: 0x00AE3068
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMainMenuStageClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnMainMenuStageClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209CE RID: 133582 RVA: 0x00AE4EBC File Offset: 0x00AE30BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRankingTypeMenuClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType rankListType;
			LuaObject.checkEnum<RankingListType>(l, 2, out rankListType);
			rankingUIController.m_luaExportHelper.OnRankingTypeMenuClick(rankListType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209CF RID: 133583 RVA: 0x00AE4F18 File Offset: 0x00AE3118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubMenuTopHeroClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnSubMenuTopHeroClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D0 RID: 133584 RVA: 0x00AE4F6C File Offset: 0x00AE316C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubMenuAllHeroClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnSubMenuAllHeroClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D1 RID: 133585 RVA: 0x00AE4FC0 File Offset: 0x00AE31C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubMenuChampionHeroClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnSubMenuChampionHeroClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D2 RID: 133586 RVA: 0x00AE5014 File Offset: 0x00AE3214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubMenuRiftChapterStarClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnSubMenuRiftChapterStarClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D3 RID: 133587 RVA: 0x00AE5068 File Offset: 0x00AE3268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSubMenuRiftAchievementClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.OnSubMenuRiftAchievementClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D4 RID: 133588 RVA: 0x00AE50BC File Offset: 0x00AE32BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			rankingUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D5 RID: 133589 RVA: 0x00AE5128 File Offset: 0x00AE3328
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D6 RID: 133590 RVA: 0x00AE517C File Offset: 0x00AE337C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D7 RID: 133591 RVA: 0x00AE51D0 File Offset: 0x00AE33D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = rankingUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060209D8 RID: 133592 RVA: 0x00AE5278 File Offset: 0x00AE3478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209D9 RID: 133593 RVA: 0x00AE52CC File Offset: 0x00AE34CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			rankingUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209DA RID: 133594 RVA: 0x00AE5338 File Offset: 0x00AE3538
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
				RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				rankingUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				RankingUIController rankingUIController2 = (RankingUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				rankingUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060209DB RID: 133595 RVA: 0x00AE5448 File Offset: 0x00AE3648
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209DC RID: 133596 RVA: 0x00AE54B4 File Offset: 0x00AE36B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209DD RID: 133597 RVA: 0x00AE5520 File Offset: 0x00AE3720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209DE RID: 133598 RVA: 0x00AE558C File Offset: 0x00AE378C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			rankingUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209DF RID: 133599 RVA: 0x00AE55F8 File Offset: 0x00AE37F8
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
				RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				rankingUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				RankingUIController rankingUIController2 = (RankingUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				rankingUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060209E0 RID: 133600 RVA: 0x00AE5708 File Offset: 0x00AE3908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			string s = rankingUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060209E1 RID: 133601 RVA: 0x00AE5764 File Offset: 0x00AE3964
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRankingTypeMenuClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType obj;
			LuaObject.checkEnum<RankingListType>(l, 2, out obj);
			rankingUIController.m_luaExportHelper.__callDele_EventOnRankingTypeMenuClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E2 RID: 133602 RVA: 0x00AE57C0 File Offset: 0x00AE39C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRankingTypeMenuClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType obj;
			LuaObject.checkEnum<RankingListType>(l, 2, out obj);
			rankingUIController.m_luaExportHelper.__clearDele_EventOnRankingTypeMenuClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E3 RID: 133603 RVA: 0x00AE581C File Offset: 0x00AE3A1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnResetRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__callDele_EventOnResetRankingType();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E4 RID: 133604 RVA: 0x00AE5870 File Offset: 0x00AE3A70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnResetRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__clearDele_EventOnResetRankingType();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E5 RID: 133605 RVA: 0x00AE58C4 File Offset: 0x00AE3AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRetunButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__callDele_EventOnRetunButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E6 RID: 133606 RVA: 0x00AE5918 File Offset: 0x00AE3B18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRetunButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			rankingUIController.m_luaExportHelper.__clearDele_EventOnRetunButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E7 RID: 133607 RVA: 0x00AE596C File Offset: 0x00AE3B6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isDuringUpdate(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.m_luaExportHelper.m_isDuringUpdate);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E8 RID: 133608 RVA: 0x00AE59C4 File Offset: 0x00AE3BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isDuringUpdate(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			bool isDuringUpdate;
			LuaObject.checkType(l, 2, out isDuringUpdate);
			rankingUIController.m_luaExportHelper.m_isDuringUpdate = isDuringUpdate;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209E9 RID: 133609 RVA: 0x00AE5A20 File Offset: 0x00AE3C20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSubMenuPanelPowerShow(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.m_luaExportHelper.m_isSubMenuPanelPowerShow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209EA RID: 133610 RVA: 0x00AE5A78 File Offset: 0x00AE3C78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSubMenuPanelPowerShow(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			bool isSubMenuPanelPowerShow;
			LuaObject.checkType(l, 2, out isSubMenuPanelPowerShow);
			rankingUIController.m_luaExportHelper.m_isSubMenuPanelPowerShow = isSubMenuPanelPowerShow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209EB RID: 133611 RVA: 0x00AE5AD4 File Offset: 0x00AE3CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isSubMenuPanelRiftShow(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.m_luaExportHelper.m_isSubMenuPanelRiftShow);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209EC RID: 133612 RVA: 0x00AE5B2C File Offset: 0x00AE3D2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isSubMenuPanelRiftShow(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			bool isSubMenuPanelRiftShow;
			LuaObject.checkType(l, 2, out isSubMenuPanelRiftShow);
			rankingUIController.m_luaExportHelper.m_isSubMenuPanelRiftShow = isSubMenuPanelRiftShow;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209ED RID: 133613 RVA: 0x00AE5B88 File Offset: 0x00AE3D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mainMenuSelectState(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rankingUIController.m_luaExportHelper.m_mainMenuSelectState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209EE RID: 133614 RVA: 0x00AE5BE0 File Offset: 0x00AE3DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mainMenuSelectState(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingUIController.MainMenuSelectState mainMenuSelectState;
			LuaObject.checkEnum<RankingUIController.MainMenuSelectState>(l, 2, out mainMenuSelectState);
			rankingUIController.m_luaExportHelper.m_mainMenuSelectState = mainMenuSelectState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209EF RID: 133615 RVA: 0x00AE5C3C File Offset: 0x00AE3E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_currRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)rankingUIController.m_luaExportHelper.m_currRankingType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F0 RID: 133616 RVA: 0x00AE5C94 File Offset: 0x00AE3E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_currRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingListType currRankingType;
			LuaObject.checkEnum<RankingListType>(l, 2, out currRankingType);
			rankingUIController.m_luaExportHelper.m_currRankingType = currRankingType;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F1 RID: 133617 RVA: 0x00AE5CF0 File Offset: 0x00AE3EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRankingTypeMenuClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			Action<RankingListType> value;
			int num = LuaObject.checkDelegate<Action<RankingListType>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rankingUIController.EventOnRankingTypeMenuClick += value;
				}
				else if (num == 2)
				{
					rankingUIController.EventOnRankingTypeMenuClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F2 RID: 133618 RVA: 0x00AE5D70 File Offset: 0x00AE3F70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnResetRankingType(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rankingUIController.EventOnResetRankingType += value;
				}
				else if (num == 2)
				{
					rankingUIController.EventOnResetRankingType -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F3 RID: 133619 RVA: 0x00AE5DF0 File Offset: 0x00AE3FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRetunButtonClick(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					rankingUIController.EventOnRetunButtonClick += value;
				}
				else if (num == 2)
				{
					rankingUIController.EventOnRetunButtonClick -= value;
				}
			}
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F4 RID: 133620 RVA: 0x00AE5E70 File Offset: 0x00AE4070
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_ReturnButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.ReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F5 RID: 133621 RVA: 0x00AE5EC4 File Offset: 0x00AE40C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_ReturnButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			rankingUIController.ReturnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F6 RID: 133622 RVA: 0x00AE5F1C File Offset: 0x00AE411C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuUICtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F7 RID: 133623 RVA: 0x00AE5F70 File Offset: 0x00AE4170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuUICtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			RankingSubMenuUIController subMenuUICtrl;
			LuaObject.checkType<RankingSubMenuUIController>(l, 2, out subMenuUICtrl);
			rankingUIController.SubMenuUICtrl = subMenuUICtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F8 RID: 133624 RVA: 0x00AE5FC8 File Offset: 0x00AE41C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainMenuPowerButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.MainMenuPowerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209F9 RID: 133625 RVA: 0x00AE601C File Offset: 0x00AE421C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MainMenuPowerButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx mainMenuPowerButton;
			LuaObject.checkType<ButtonEx>(l, 2, out mainMenuPowerButton);
			rankingUIController.MainMenuPowerButton = mainMenuPowerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209FA RID: 133626 RVA: 0x00AE6074 File Offset: 0x00AE4274
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainMenuPowerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.MainMenuPowerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209FB RID: 133627 RVA: 0x00AE60C8 File Offset: 0x00AE42C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MainMenuPowerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController mainMenuPowerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out mainMenuPowerStateCtrl);
			rankingUIController.MainMenuPowerStateCtrl = mainMenuPowerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209FC RID: 133628 RVA: 0x00AE6120 File Offset: 0x00AE4320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuTopHeroButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuTopHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209FD RID: 133629 RVA: 0x00AE6174 File Offset: 0x00AE4374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuTopHeroButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx subMenuTopHeroButton;
			LuaObject.checkType<ButtonEx>(l, 2, out subMenuTopHeroButton);
			rankingUIController.SubMenuTopHeroButton = subMenuTopHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209FE RID: 133630 RVA: 0x00AE61CC File Offset: 0x00AE43CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuTopHeroStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuTopHeroStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060209FF RID: 133631 RVA: 0x00AE6220 File Offset: 0x00AE4420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuTopHeroStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuTopHeroStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuTopHeroStateCtrl);
			rankingUIController.SubMenuTopHeroStateCtrl = subMenuTopHeroStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A00 RID: 133632 RVA: 0x00AE6278 File Offset: 0x00AE4478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuAllHeroButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuAllHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A01 RID: 133633 RVA: 0x00AE62CC File Offset: 0x00AE44CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuAllHeroButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx subMenuAllHeroButton;
			LuaObject.checkType<ButtonEx>(l, 2, out subMenuAllHeroButton);
			rankingUIController.SubMenuAllHeroButton = subMenuAllHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A02 RID: 133634 RVA: 0x00AE6324 File Offset: 0x00AE4524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuAllHeroStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuAllHeroStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A03 RID: 133635 RVA: 0x00AE6378 File Offset: 0x00AE4578
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuAllHeroStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuAllHeroStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuAllHeroStateCtrl);
			rankingUIController.SubMenuAllHeroStateCtrl = subMenuAllHeroStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A04 RID: 133636 RVA: 0x00AE63D0 File Offset: 0x00AE45D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuChampionHeroButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuChampionHeroButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A05 RID: 133637 RVA: 0x00AE6424 File Offset: 0x00AE4624
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuChampionHeroButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx subMenuChampionHeroButton;
			LuaObject.checkType<ButtonEx>(l, 2, out subMenuChampionHeroButton);
			rankingUIController.SubMenuChampionHeroButton = subMenuChampionHeroButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A06 RID: 133638 RVA: 0x00AE647C File Offset: 0x00AE467C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuChampionHeroStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuChampionHeroStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A07 RID: 133639 RVA: 0x00AE64D0 File Offset: 0x00AE46D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuChampionHeroStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuChampionHeroStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuChampionHeroStateCtrl);
			rankingUIController.SubMenuChampionHeroStateCtrl = subMenuChampionHeroStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A08 RID: 133640 RVA: 0x00AE6528 File Offset: 0x00AE4728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainMenuRiftButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.MainMenuRiftButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A09 RID: 133641 RVA: 0x00AE657C File Offset: 0x00AE477C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MainMenuRiftButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx mainMenuRiftButton;
			LuaObject.checkType<ButtonEx>(l, 2, out mainMenuRiftButton);
			rankingUIController.MainMenuRiftButton = mainMenuRiftButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A0A RID: 133642 RVA: 0x00AE65D4 File Offset: 0x00AE47D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainMenuRiftStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.MainMenuRiftStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A0B RID: 133643 RVA: 0x00AE6628 File Offset: 0x00AE4828
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MainMenuRiftStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController mainMenuRiftStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out mainMenuRiftStateCtrl);
			rankingUIController.MainMenuRiftStateCtrl = mainMenuRiftStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A0C RID: 133644 RVA: 0x00AE6680 File Offset: 0x00AE4880
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuRiftChapterStarButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuRiftChapterStarButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A0D RID: 133645 RVA: 0x00AE66D4 File Offset: 0x00AE48D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuRiftChapterStarButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx subMenuRiftChapterStarButton;
			LuaObject.checkType<ButtonEx>(l, 2, out subMenuRiftChapterStarButton);
			rankingUIController.SubMenuRiftChapterStarButton = subMenuRiftChapterStarButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A0E RID: 133646 RVA: 0x00AE672C File Offset: 0x00AE492C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuRiftChapterStarStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuRiftChapterStarStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A0F RID: 133647 RVA: 0x00AE6780 File Offset: 0x00AE4980
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuRiftChapterStarStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuRiftChapterStarStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuRiftChapterStarStateCtrl);
			rankingUIController.SubMenuRiftChapterStarStateCtrl = subMenuRiftChapterStarStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A10 RID: 133648 RVA: 0x00AE67D8 File Offset: 0x00AE49D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuRiftAchievementButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuRiftAchievementButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A11 RID: 133649 RVA: 0x00AE682C File Offset: 0x00AE4A2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuRiftAchievementButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx subMenuRiftAchievementButton;
			LuaObject.checkType<ButtonEx>(l, 2, out subMenuRiftAchievementButton);
			rankingUIController.SubMenuRiftAchievementButton = subMenuRiftAchievementButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A12 RID: 133650 RVA: 0x00AE6884 File Offset: 0x00AE4A84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuRiftAchievementStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuRiftAchievementStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A13 RID: 133651 RVA: 0x00AE68D8 File Offset: 0x00AE4AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuRiftAchievementStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuRiftAchievementStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuRiftAchievementStateCtrl);
			rankingUIController.SubMenuRiftAchievementStateCtrl = subMenuRiftAchievementStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A14 RID: 133652 RVA: 0x00AE6930 File Offset: 0x00AE4B30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainMenuStageButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.MainMenuStageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A15 RID: 133653 RVA: 0x00AE6984 File Offset: 0x00AE4B84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MainMenuStageButton(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			ButtonEx mainMenuStageButton;
			LuaObject.checkType<ButtonEx>(l, 2, out mainMenuStageButton);
			rankingUIController.MainMenuStageButton = mainMenuStageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A16 RID: 133654 RVA: 0x00AE69DC File Offset: 0x00AE4BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_MainMenuStageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.MainMenuStageStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A17 RID: 133655 RVA: 0x00AE6A30 File Offset: 0x00AE4C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_MainMenuStageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController mainMenuStageStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out mainMenuStageStateCtrl);
			rankingUIController.MainMenuStageStateCtrl = mainMenuStageStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A18 RID: 133656 RVA: 0x00AE6A88 File Offset: 0x00AE4C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuPanelPowerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuPanelPowerStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A19 RID: 133657 RVA: 0x00AE6ADC File Offset: 0x00AE4CDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuPanelPowerStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuPanelPowerStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuPanelPowerStateCtrl);
			rankingUIController.SubMenuPanelPowerStateCtrl = subMenuPanelPowerStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A1A RID: 133658 RVA: 0x00AE6B34 File Offset: 0x00AE4D34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuPanelRiftStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuPanelRiftStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A1B RID: 133659 RVA: 0x00AE6B88 File Offset: 0x00AE4D88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuPanelRiftStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuPanelRiftStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuPanelRiftStateCtrl);
			rankingUIController.SubMenuPanelRiftStateCtrl = subMenuPanelRiftStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A1C RID: 133660 RVA: 0x00AE6BE0 File Offset: 0x00AE4DE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SubMenuPanelStageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, rankingUIController.SubMenuPanelStageStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A1D RID: 133661 RVA: 0x00AE6C34 File Offset: 0x00AE4E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SubMenuPanelStageStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			RankingUIController rankingUIController = (RankingUIController)LuaObject.checkSelf(l);
			CommonUIStateController subMenuPanelStageStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out subMenuPanelStageStateCtrl);
			rankingUIController.SubMenuPanelStageStateCtrl = subMenuPanelStageStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020A1E RID: 133662 RVA: 0x00AE6C8C File Offset: 0x00AE4E8C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.RankingUIController");
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.UpdateRankingUICtrl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.GetMainMenuSelectStateFromRankingType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.SetMainMenuSelectState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.SetAllMainMenuUnselect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.SetSubMenuSelectState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.SetAllSubMenuToggleUnselect);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.ShowPowerSubMenuPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.ShowRiftSubMenuPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.HideAllSubMenuPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnNoneSubMenuAreaClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnMainMenuPowerClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnMainMenuRiftClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnMainMenuStageClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnRankingTypeMenuClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnSubMenuTopHeroClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnSubMenuAllHeroClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnSubMenuChampionHeroClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnSubMenuRiftChapterStarClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.OnSubMenuRiftAchievementClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callDele_EventOnRankingTypeMenuClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__clearDele_EventOnRankingTypeMenuClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callDele_EventOnResetRankingType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__clearDele_EventOnResetRankingType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__callDele_EventOnRetunButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.__clearDele_EventOnRetunButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache27);
		string name = "m_isDuringUpdate";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_m_isDuringUpdate);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_m_isDuringUpdate);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache29, true);
		string name2 = "m_isSubMenuPanelPowerShow";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_m_isSubMenuPanelPowerShow);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_m_isSubMenuPanelPowerShow);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2B, true);
		string name3 = "m_isSubMenuPanelRiftShow";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_m_isSubMenuPanelRiftShow);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_m_isSubMenuPanelRiftShow);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2D, true);
		string name4 = "m_mainMenuSelectState";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_m_mainMenuSelectState);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_m_mainMenuSelectState);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache2F, true);
		string name5 = "m_currRankingType";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_m_currRankingType);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_m_currRankingType);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache31, true);
		string name6 = "EventOnRankingTypeMenuClick";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_EventOnRankingTypeMenuClick);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache32, true);
		string name7 = "EventOnResetRankingType";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_EventOnResetRankingType);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache33, true);
		string name8 = "EventOnRetunButtonClick";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_EventOnRetunButtonClick);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache34, true);
		string name9 = "ReturnButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_ReturnButton);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_ReturnButton);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache36, true);
		string name10 = "SubMenuUICtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuUICtrl);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuUICtrl);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache38, true);
		string name11 = "MainMenuPowerButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_MainMenuPowerButton);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_MainMenuPowerButton);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3A, true);
		string name12 = "MainMenuPowerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_MainMenuPowerStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_MainMenuPowerStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3C, true);
		string name13 = "SubMenuTopHeroButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuTopHeroButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuTopHeroButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3E, true);
		string name14 = "SubMenuTopHeroStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuTopHeroStateCtrl);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuTopHeroStateCtrl);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache40, true);
		string name15 = "SubMenuAllHeroButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuAllHeroButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuAllHeroButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache42, true);
		string name16 = "SubMenuAllHeroStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuAllHeroStateCtrl);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuAllHeroStateCtrl);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache44, true);
		string name17 = "SubMenuChampionHeroButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuChampionHeroButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuChampionHeroButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache46, true);
		string name18 = "SubMenuChampionHeroStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuChampionHeroStateCtrl);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuChampionHeroStateCtrl);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache48, true);
		string name19 = "MainMenuRiftButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_MainMenuRiftButton);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_MainMenuRiftButton);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4A, true);
		string name20 = "MainMenuRiftStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_MainMenuRiftStateCtrl);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_MainMenuRiftStateCtrl);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4C, true);
		string name21 = "SubMenuRiftChapterStarButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuRiftChapterStarButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuRiftChapterStarButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4E, true);
		string name22 = "SubMenuRiftChapterStarStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuRiftChapterStarStateCtrl);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuRiftChapterStarStateCtrl);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache50, true);
		string name23 = "SubMenuRiftAchievementButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuRiftAchievementButton);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuRiftAchievementButton);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache52, true);
		string name24 = "SubMenuRiftAchievementStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuRiftAchievementStateCtrl);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuRiftAchievementStateCtrl);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache54, true);
		string name25 = "MainMenuStageButton";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_MainMenuStageButton);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_MainMenuStageButton);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache56, true);
		string name26 = "MainMenuStageStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_MainMenuStageStateCtrl);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_MainMenuStageStateCtrl);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache58, true);
		string name27 = "SubMenuPanelPowerStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuPanelPowerStateCtrl);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuPanelPowerStateCtrl);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5A, true);
		string name28 = "SubMenuPanelRiftStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuPanelRiftStateCtrl);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuPanelRiftStateCtrl);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5C, true);
		string name29 = "SubMenuPanelStageStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.get_SubMenuPanelStageStateCtrl);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_RankingUIController.set_SubMenuPanelStageStateCtrl);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_RankingUIController.<>f__mg$cache5E, true);
		LuaObject.createTypeMetatable(l, null, typeof(RankingUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016907 RID: 92423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016908 RID: 92424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016909 RID: 92425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401690A RID: 92426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401690B RID: 92427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401690C RID: 92428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401690D RID: 92429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401690E RID: 92430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401690F RID: 92431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016910 RID: 92432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016911 RID: 92433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016912 RID: 92434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016913 RID: 92435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016914 RID: 92436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016915 RID: 92437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016916 RID: 92438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016917 RID: 92439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016918 RID: 92440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016919 RID: 92441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x0401691A RID: 92442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x0401691B RID: 92443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x0401691C RID: 92444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401691D RID: 92445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401691E RID: 92446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401691F RID: 92447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016920 RID: 92448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016921 RID: 92449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016922 RID: 92450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016923 RID: 92451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016924 RID: 92452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016925 RID: 92453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04016926 RID: 92454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04016927 RID: 92455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04016928 RID: 92456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04016929 RID: 92457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x0401692A RID: 92458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x0401692B RID: 92459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x0401692C RID: 92460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x0401692D RID: 92461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x0401692E RID: 92462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x0401692F RID: 92463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016930 RID: 92464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016931 RID: 92465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016932 RID: 92466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016933 RID: 92467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016934 RID: 92468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016935 RID: 92469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016936 RID: 92470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016937 RID: 92471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016938 RID: 92472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016939 RID: 92473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x0401693A RID: 92474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x0401693B RID: 92475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x0401693C RID: 92476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x0401693D RID: 92477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401693E RID: 92478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401693F RID: 92479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016940 RID: 92480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016941 RID: 92481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016942 RID: 92482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016943 RID: 92483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016944 RID: 92484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016945 RID: 92485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016946 RID: 92486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016947 RID: 92487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016948 RID: 92488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016949 RID: 92489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x0401694A RID: 92490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x0401694B RID: 92491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x0401694C RID: 92492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x0401694D RID: 92493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401694E RID: 92494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401694F RID: 92495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04016950 RID: 92496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04016951 RID: 92497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04016952 RID: 92498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04016953 RID: 92499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016954 RID: 92500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016955 RID: 92501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016956 RID: 92502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016957 RID: 92503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016958 RID: 92504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016959 RID: 92505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x0401695A RID: 92506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x0401695B RID: 92507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x0401695C RID: 92508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x0401695D RID: 92509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401695E RID: 92510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401695F RID: 92511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04016960 RID: 92512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04016961 RID: 92513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04016962 RID: 92514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04016963 RID: 92515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04016964 RID: 92516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04016965 RID: 92517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;
}
