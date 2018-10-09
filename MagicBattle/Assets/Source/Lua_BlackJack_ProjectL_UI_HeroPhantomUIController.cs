using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014DA RID: 5338
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroPhantomUIController : LuaObject
{
	// Token: 0x0601F669 RID: 128617 RVA: 0x00A4A98C File Offset: 0x00A48B8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F66A RID: 128618 RVA: 0x00A4A9D8 File Offset: 0x00A48BD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroPhantom(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantom;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantom);
			heroPhantomUIController.SetHeroPhantom(heroPhantom);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F66B RID: 128619 RVA: 0x00A4AA30 File Offset: 0x00A48C30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAllHeroPhantomLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			List<ConfigDataHeroPhantomLevelInfo> levelInfos;
			LuaObject.checkType<List<ConfigDataHeroPhantomLevelInfo>>(l, 2, out levelInfos);
			heroPhantomUIController.AddAllHeroPhantomLevelListItems(levelInfos);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F66C RID: 128620 RVA: 0x00A4AA88 File Offset: 0x00A48C88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearHeroPhantomLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.ClearHeroPhantomLevelListItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F66D RID: 128621 RVA: 0x00A4AAD4 File Offset: 0x00A48CD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F66E RID: 128622 RVA: 0x00A4AB28 File Offset: 0x00A48D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ResetScrollViewToTop(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.ResetScrollViewToTop();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F66F RID: 128623 RVA: 0x00A4AB7C File Offset: 0x00A48D7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddHeroPhantomLevelListItem(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo levelnfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out levelnfo);
			bool opened;
			LuaObject.checkType(l, 3, out opened);
			heroPhantomUIController.m_luaExportHelper.AddHeroPhantomLevelListItem(levelnfo, opened);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F670 RID: 128624 RVA: 0x00A4ABE8 File Offset: 0x00A48DE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CreateSpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomInfo heroPhantomInfo;
			LuaObject.checkType<ConfigDataHeroPhantomInfo>(l, 2, out heroPhantomInfo);
			heroPhantomUIController.m_luaExportHelper.CreateSpineGraphic(heroPhantomInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F671 RID: 128625 RVA: 0x00A4AC44 File Offset: 0x00A48E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int DestroySpineGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.DestroySpineGraphic();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F672 RID: 128626 RVA: 0x00A4AC98 File Offset: 0x00A48E98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F673 RID: 128627 RVA: 0x00A4ACEC File Offset: 0x00A48EEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHelpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.OnHelpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F674 RID: 128628 RVA: 0x00A4AD40 File Offset: 0x00A48F40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroPhantomLevelListItem_OnStartButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			HeroPhantomLevelListItemUIController ctrl;
			LuaObject.checkType<HeroPhantomLevelListItemUIController>(l, 2, out ctrl);
			heroPhantomUIController.m_luaExportHelper.HeroPhantomLevelListItem_OnStartButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F675 RID: 128629 RVA: 0x00A4AD9C File Offset: 0x00A48F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAchievementBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.OnAchievementBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F676 RID: 128630 RVA: 0x00A4ADF0 File Offset: 0x00A48FF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int HeroPhantomLevelListItem_OnAchievementButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			HeroPhantomLevelListItemUIController ctrl;
			LuaObject.checkType<HeroPhantomLevelListItemUIController>(l, 2, out ctrl);
			heroPhantomUIController.m_luaExportHelper.HeroPhantomLevelListItem_OnAchievementButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F677 RID: 128631 RVA: 0x00A4AE4C File Offset: 0x00A4904C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowAchievement(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			BattleLevelAchievement[] achievements;
			LuaObject.checkArray<BattleLevelAchievement>(l, 2, out achievements);
			ConfigDataHeroPhantomLevelInfo heroPhantomLevelInfo;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 3, out heroPhantomLevelInfo);
			heroPhantomUIController.m_luaExportHelper.ShowAchievement(achievements, heroPhantomLevelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F678 RID: 128632 RVA: 0x00A4AEB8 File Offset: 0x00A490B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int AddAchievementItem(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ConfigDataBattleAchievementInfo achievementInfo;
			LuaObject.checkType<ConfigDataBattleAchievementInfo>(l, 2, out achievementInfo);
			List<Goods> rewards;
			LuaObject.checkType<List<Goods>>(l, 3, out rewards);
			GameObject prefab;
			LuaObject.checkType<GameObject>(l, 4, out prefab);
			bool complete;
			LuaObject.checkType(l, 5, out complete);
			heroPhantomUIController.m_luaExportHelper.AddAchievementItem(achievementInfo, rewards, prefab, complete);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F679 RID: 128633 RVA: 0x00A4AF3C File Offset: 0x00A4913C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClearAchievementItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.ClearAchievementItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F67A RID: 128634 RVA: 0x00A4AF90 File Offset: 0x00A49190
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroPhantomUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F67B RID: 128635 RVA: 0x00A4AFFC File Offset: 0x00A491FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F67C RID: 128636 RVA: 0x00A4B050 File Offset: 0x00A49250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F67D RID: 128637 RVA: 0x00A4B0A4 File Offset: 0x00A492A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroPhantomUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601F67E RID: 128638 RVA: 0x00A4B14C File Offset: 0x00A4934C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F67F RID: 128639 RVA: 0x00A4B1A0 File Offset: 0x00A493A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroPhantomUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F680 RID: 128640 RVA: 0x00A4B20C File Offset: 0x00A4940C
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
				HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroPhantomUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroPhantomUIController heroPhantomUIController2 = (HeroPhantomUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroPhantomUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601F681 RID: 128641 RVA: 0x00A4B31C File Offset: 0x00A4951C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F682 RID: 128642 RVA: 0x00A4B388 File Offset: 0x00A49588
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F683 RID: 128643 RVA: 0x00A4B3F4 File Offset: 0x00A495F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F684 RID: 128644 RVA: 0x00A4B460 File Offset: 0x00A49660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroPhantomUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F685 RID: 128645 RVA: 0x00A4B4CC File Offset: 0x00A496CC
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
				HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroPhantomUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroPhantomUIController heroPhantomUIController2 = (HeroPhantomUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroPhantomUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601F686 RID: 128646 RVA: 0x00A4B5DC File Offset: 0x00A497DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			string s = heroPhantomUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601F687 RID: 128647 RVA: 0x00A4B638 File Offset: 0x00A49838
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F688 RID: 128648 RVA: 0x00A4B68C File Offset: 0x00A4988C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F689 RID: 128649 RVA: 0x00A4B6E0 File Offset: 0x00A498E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__callDele_EventOnHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F68A RID: 128650 RVA: 0x00A4B734 File Offset: 0x00A49934
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			heroPhantomUIController.m_luaExportHelper.__clearDele_EventOnHelp();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F68B RID: 128651 RVA: 0x00A4B788 File Offset: 0x00A49988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnStartHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo obj;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out obj);
			heroPhantomUIController.m_luaExportHelper.__callDele_EventOnStartHeroPhantomLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F68C RID: 128652 RVA: 0x00A4B7E4 File Offset: 0x00A499E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnStartHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ConfigDataHeroPhantomLevelInfo obj;
			LuaObject.checkType<ConfigDataHeroPhantomLevelInfo>(l, 2, out obj);
			heroPhantomUIController.m_luaExportHelper.__clearDele_EventOnStartHeroPhantomLevel(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F68D RID: 128653 RVA: 0x00A4B840 File Offset: 0x00A49A40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					heroPhantomUIController.EventOnReturn -= value;
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

	// Token: 0x0601F68E RID: 128654 RVA: 0x00A4B8C0 File Offset: 0x00A49AC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnHelp(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomUIController.EventOnHelp += value;
				}
				else if (num == 2)
				{
					heroPhantomUIController.EventOnHelp -= value;
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

	// Token: 0x0601F68F RID: 128655 RVA: 0x00A4B940 File Offset: 0x00A49B40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnStartHeroPhantomLevel(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Action<ConfigDataHeroPhantomLevelInfo> value;
			int num = LuaObject.checkDelegate<Action<ConfigDataHeroPhantomLevelInfo>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroPhantomUIController.EventOnStartHeroPhantomLevel += value;
				}
				else if (num == 2)
				{
					heroPhantomUIController.EventOnStartHeroPhantomLevel -= value;
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

	// Token: 0x0601F690 RID: 128656 RVA: 0x00A4B9C0 File Offset: 0x00A49BC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F691 RID: 128657 RVA: 0x00A4BA18 File Offset: 0x00A49C18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroPhantomUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F692 RID: 128658 RVA: 0x00A4BA74 File Offset: 0x00A49C74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F693 RID: 128659 RVA: 0x00A4BACC File Offset: 0x00A49CCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			heroPhantomUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F694 RID: 128660 RVA: 0x00A4BB28 File Offset: 0x00A49D28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F695 RID: 128661 RVA: 0x00A4BB80 File Offset: 0x00A49D80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			heroPhantomUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F696 RID: 128662 RVA: 0x00A4BBDC File Offset: 0x00A49DDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_helpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F697 RID: 128663 RVA: 0x00A4BC34 File Offset: 0x00A49E34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_helpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Button helpButton;
			LuaObject.checkType<Button>(l, 2, out helpButton);
			heroPhantomUIController.m_luaExportHelper.m_helpButton = helpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F698 RID: 128664 RVA: 0x00A4BC90 File Offset: 0x00A49E90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_levelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F699 RID: 128665 RVA: 0x00A4BCE8 File Offset: 0x00A49EE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_levelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ScrollRect levelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out levelListScrollRect);
			heroPhantomUIController.m_luaExportHelper.m_levelListScrollRect = levelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F69A RID: 128666 RVA: 0x00A4BD44 File Offset: 0x00A49F44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_charGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F69B RID: 128667 RVA: 0x00A4BD9C File Offset: 0x00A49F9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_charGo(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			GameObject charGo;
			LuaObject.checkType<GameObject>(l, 2, out charGo);
			heroPhantomUIController.m_luaExportHelper.m_charGo = charGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F69C RID: 128668 RVA: 0x00A4BDF8 File Offset: 0x00A49FF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementUIStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_achievementUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F69D RID: 128669 RVA: 0x00A4BE50 File Offset: 0x00A4A050
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementUIStateController(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			CommonUIStateController achievementUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out achievementUIStateController);
			heroPhantomUIController.m_luaExportHelper.m_achievementUIStateController = achievementUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F69E RID: 128670 RVA: 0x00A4BEAC File Offset: 0x00A4A0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_achievementScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F69F RID: 128671 RVA: 0x00A4BF04 File Offset: 0x00A4A104
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			ScrollRect achievementScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out achievementScrollRect);
			heroPhantomUIController.m_luaExportHelper.m_achievementScrollRect = achievementScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A0 RID: 128672 RVA: 0x00A4BF60 File Offset: 0x00A4A160
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_achievementBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A1 RID: 128673 RVA: 0x00A4BFB8 File Offset: 0x00A4A1B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			Button achievementBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out achievementBackgroundButton);
			heroPhantomUIController.m_luaExportHelper.m_achievementBackgroundButton = achievementBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A2 RID: 128674 RVA: 0x00A4C014 File Offset: 0x00A4A214
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_prefabsGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A3 RID: 128675 RVA: 0x00A4C06C File Offset: 0x00A4A26C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_prefabsGameObject(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			GameObject prefabsGameObject;
			LuaObject.checkType<GameObject>(l, 2, out prefabsGameObject);
			heroPhantomUIController.m_luaExportHelper.m_prefabsGameObject = prefabsGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A4 RID: 128676 RVA: 0x00A4C0C8 File Offset: 0x00A4A2C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantomLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_heroPhantomLevelListItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A5 RID: 128677 RVA: 0x00A4C120 File Offset: 0x00A4A320
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomLevelListItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			GameObject heroPhantomLevelListItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroPhantomLevelListItemPrefab);
			heroPhantomUIController.m_luaExportHelper.m_heroPhantomLevelListItemPrefab = heroPhantomLevelListItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A6 RID: 128678 RVA: 0x00A4C17C File Offset: 0x00A4A37C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroPhantomLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_heroPhantomLevelListItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A7 RID: 128679 RVA: 0x00A4C1D4 File Offset: 0x00A4A3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomLevelListItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			List<HeroPhantomLevelListItemUIController> heroPhantomLevelListItems;
			LuaObject.checkType<List<HeroPhantomLevelListItemUIController>>(l, 2, out heroPhantomLevelListItems);
			heroPhantomUIController.m_luaExportHelper.m_heroPhantomLevelListItems = heroPhantomLevelListItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A8 RID: 128680 RVA: 0x00A4C230 File Offset: 0x00A4A430
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_achievementItems);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6A9 RID: 128681 RVA: 0x00A4C288 File Offset: 0x00A4A488
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementItems(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			List<BattleAchievementItemUIController> achievementItems;
			LuaObject.checkType<List<BattleAchievementItemUIController>>(l, 2, out achievementItems);
			heroPhantomUIController.m_luaExportHelper.m_achievementItems = achievementItems;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6AA RID: 128682 RVA: 0x00A4C2E4 File Offset: 0x00A4A4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroPhantomUIController.m_luaExportHelper.m_graphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6AB RID: 128683 RVA: 0x00A4C33C File Offset: 0x00A4A53C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_graphic(IntPtr l)
	{
		int result;
		try
		{
			HeroPhantomUIController heroPhantomUIController = (HeroPhantomUIController)LuaObject.checkSelf(l);
			UISpineGraphic graphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out graphic);
			heroPhantomUIController.m_luaExportHelper.m_graphic = graphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601F6AC RID: 128684 RVA: 0x00A4C398 File Offset: 0x00A4A598
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroPhantomUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.SetHeroPhantom);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.AddAllHeroPhantomLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.ClearHeroPhantomLevelListItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.ResetScrollViewToTop);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.AddHeroPhantomLevelListItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.CreateSpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.DestroySpineGraphic);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.OnHelpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.HeroPhantomLevelListItem_OnStartButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.OnAchievementBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.HeroPhantomLevelListItem_OnAchievementButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.ShowAchievement);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.AddAchievementItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.ClearAchievementItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callDele_EventOnHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__clearDele_EventOnHelp);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__callDele_EventOnStartHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.__clearDele_EventOnStartHeroPhantomLevel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache23);
		string name = "EventOnReturn";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache24, true);
		string name2 = "EventOnHelp";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_EventOnHelp);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache25, true);
		string name3 = "EventOnStartHeroPhantomLevel";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_EventOnStartHeroPhantomLevel);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache26, true);
		string name4 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_marginTransform);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache28, true);
		string name5 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_uiStateController);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2A, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2C, true);
		string name7 = "m_helpButton";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_helpButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_helpButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2E, true);
		string name8 = "m_levelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_levelListScrollRect);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_levelListScrollRect);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache30, true);
		string name9 = "m_charGo";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_charGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_charGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache32, true);
		string name10 = "m_achievementUIStateController";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_achievementUIStateController);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_achievementUIStateController);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache34, true);
		string name11 = "m_achievementScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_achievementScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_achievementScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache36, true);
		string name12 = "m_achievementBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_achievementBackgroundButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_achievementBackgroundButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache38, true);
		string name13 = "m_prefabsGameObject";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_prefabsGameObject);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_prefabsGameObject);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3A, true);
		string name14 = "m_heroPhantomLevelListItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_heroPhantomLevelListItemPrefab);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_heroPhantomLevelListItemPrefab);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3C, true);
		string name15 = "m_heroPhantomLevelListItems";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_heroPhantomLevelListItems);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_heroPhantomLevelListItems);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3E, true);
		string name16 = "m_achievementItems";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_achievementItems);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_achievementItems);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache40, true);
		string name17 = "m_graphic";
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.get_m_graphic);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.set_m_graphic);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroPhantomUIController.<>f__mg$cache42, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroPhantomUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015697 RID: 87703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015698 RID: 87704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015699 RID: 87705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x0401569A RID: 87706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x0401569B RID: 87707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x0401569C RID: 87708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401569D RID: 87709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401569E RID: 87710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401569F RID: 87711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040156A0 RID: 87712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040156A1 RID: 87713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040156A2 RID: 87714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040156A3 RID: 87715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040156A4 RID: 87716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040156A5 RID: 87717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040156A6 RID: 87718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040156A7 RID: 87719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040156A8 RID: 87720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040156A9 RID: 87721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040156AA RID: 87722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040156AB RID: 87723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040156AC RID: 87724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040156AD RID: 87725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040156AE RID: 87726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040156AF RID: 87727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040156B0 RID: 87728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040156B1 RID: 87729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040156B2 RID: 87730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040156B3 RID: 87731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040156B4 RID: 87732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040156B5 RID: 87733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040156B6 RID: 87734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040156B7 RID: 87735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040156B8 RID: 87736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040156B9 RID: 87737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040156BA RID: 87738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040156BB RID: 87739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040156BC RID: 87740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040156BD RID: 87741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040156BE RID: 87742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040156BF RID: 87743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040156C0 RID: 87744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040156C1 RID: 87745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040156C2 RID: 87746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040156C3 RID: 87747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040156C4 RID: 87748
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040156C5 RID: 87749
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040156C6 RID: 87750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040156C7 RID: 87751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040156C8 RID: 87752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040156C9 RID: 87753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040156CA RID: 87754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040156CB RID: 87755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040156CC RID: 87756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040156CD RID: 87757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040156CE RID: 87758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040156CF RID: 87759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040156D0 RID: 87760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040156D1 RID: 87761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040156D2 RID: 87762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040156D3 RID: 87763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040156D4 RID: 87764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040156D5 RID: 87765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040156D6 RID: 87766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040156D7 RID: 87767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040156D8 RID: 87768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040156D9 RID: 87769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;
}
