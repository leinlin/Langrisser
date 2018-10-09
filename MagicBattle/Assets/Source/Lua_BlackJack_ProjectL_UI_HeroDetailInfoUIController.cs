using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020014B3 RID: 5299
[Preserve]
public class Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController : LuaObject
{
	// Token: 0x0601ED04 RID: 126212 RVA: 0x009FF390 File Offset: 0x009FD590
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int UpdateViewInInfoState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailInfoUIController.UpdateViewInInfoState(hero);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED05 RID: 126213 RVA: 0x009FF3E8 File Offset: 0x009FD5E8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetCommonUIState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string commonUIState;
			LuaObject.checkType(l, 2, out commonUIState);
			heroDetailInfoUIController.SetCommonUIState(commonUIState);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED06 RID: 126214 RVA: 0x009FF440 File Offset: 0x009FD640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int IsShowHeroLittleSpine(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			bool isShow;
			LuaObject.checkType(l, 2, out isShow);
			heroDetailInfoUIController.IsShowHeroLittleSpine(isShow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED07 RID: 126215 RVA: 0x009FF498 File Offset: 0x009FD698
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED08 RID: 126216 RVA: 0x009FF4EC File Offset: 0x009FD6EC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ShowHeroInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.ShowHeroInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED09 RID: 126217 RVA: 0x009FF540 File Offset: 0x009FD740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroTagInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.SetHeroTagInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED0A RID: 126218 RVA: 0x009FF594 File Offset: 0x009FD794
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OpenTagPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTagInfo tagInfo;
			LuaObject.checkType<ConfigDataHeroTagInfo>(l, 2, out tagInfo);
			heroDetailInfoUIController.m_luaExportHelper.OpenTagPanel(tagInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED0B RID: 126219 RVA: 0x009FF5F0 File Offset: 0x009FD7F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetTagPanelInfo(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			ConfigDataHeroTagInfo tagPanelInfo;
			LuaObject.checkType<ConfigDataHeroTagInfo>(l, 2, out tagPanelInfo);
			heroDetailInfoUIController.m_luaExportHelper.SetTagPanelInfo(tagPanelInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED0C RID: 126220 RVA: 0x009FF64C File Offset: 0x009FD84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SortRelatedHeroIdByRank(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			int heroId;
			LuaObject.checkType(l, 2, out heroId);
			int heroId2;
			LuaObject.checkType(l, 3, out heroId2);
			int i = heroDetailInfoUIController.m_luaExportHelper.SortRelatedHeroIdByRank(heroId, heroId2);
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

	// Token: 0x0601ED0D RID: 126221 RVA: 0x009FF6C0 File Offset: 0x009FD8C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CloseTagPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.CloseTagPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED0E RID: 126222 RVA: 0x009FF714 File Offset: 0x009FD914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroProperty(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Hero heroProperty;
			LuaObject.checkType<Hero>(l, 2, out heroProperty);
			heroDetailInfoUIController.m_luaExportHelper.SetHeroProperty(heroProperty);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED0F RID: 126223 RVA: 0x009FF770 File Offset: 0x009FD970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetHeroTalent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Hero heroTalent;
			LuaObject.checkType<Hero>(l, 2, out heroTalent);
			heroDetailInfoUIController.m_luaExportHelper.SetHeroTalent(heroTalent);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED10 RID: 126224 RVA: 0x009FF7CC File Offset: 0x009FD9CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetCurSelectSkills(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.SetCurSelectSkills();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED11 RID: 126225 RVA: 0x009FF820 File Offset: 0x009FDA20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkillItemClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			HeroSkillItemUIController skillCtrl;
			LuaObject.checkType<HeroSkillItemUIController>(l, 2, out skillCtrl);
			heroDetailInfoUIController.m_luaExportHelper.OnSkillItemClick(skillCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED12 RID: 126226 RVA: 0x009FF87C File Offset: 0x009FDA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnAddExpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnAddExpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED13 RID: 126227 RVA: 0x009FF8D0 File Offset: 0x009FDAD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSkinInfoButtonClcik(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnSkinInfoButtonClcik();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED14 RID: 126228 RVA: 0x009FF924 File Offset: 0x009FDB24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnJobUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnJobUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED15 RID: 126229 RVA: 0x009FF978 File Offset: 0x009FDB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeSkillButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnChangeSkillButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED16 RID: 126230 RVA: 0x009FF9CC File Offset: 0x009FDBCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPropertyMsgButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnPropertyMsgButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED17 RID: 126231 RVA: 0x009FFA20 File Offset: 0x009FDC20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnExplanationBackgroundButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.OnExplanationBackgroundButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED18 RID: 126232 RVA: 0x009FFA74 File Offset: 0x009FDC74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED19 RID: 126233 RVA: 0x009FFAE0 File Offset: 0x009FDCE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED1A RID: 126234 RVA: 0x009FFB34 File Offset: 0x009FDD34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED1B RID: 126235 RVA: 0x009FFB88 File Offset: 0x009FDD88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = heroDetailInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601ED1C RID: 126236 RVA: 0x009FFC30 File Offset: 0x009FDE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED1D RID: 126237 RVA: 0x009FFC84 File Offset: 0x009FDE84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED1E RID: 126238 RVA: 0x009FFCF0 File Offset: 0x009FDEF0
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
				HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				heroDetailInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				HeroDetailInfoUIController heroDetailInfoUIController2 = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				heroDetailInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601ED1F RID: 126239 RVA: 0x009FFE00 File Offset: 0x009FE000
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED20 RID: 126240 RVA: 0x009FFE6C File Offset: 0x009FE06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED21 RID: 126241 RVA: 0x009FFED8 File Offset: 0x009FE0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED22 RID: 126242 RVA: 0x009FFF44 File Offset: 0x009FE144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			heroDetailInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED23 RID: 126243 RVA: 0x009FFFB0 File Offset: 0x009FE1B0
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
				HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				heroDetailInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				HeroDetailInfoUIController heroDetailInfoUIController2 = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				heroDetailInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601ED24 RID: 126244 RVA: 0x00A000C0 File Offset: 0x009FE2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string s = heroDetailInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601ED25 RID: 126245 RVA: 0x00A0011C File Offset: 0x009FE31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailInfoUIController.m_luaExportHelper.__callDele_EventOnSetDetailState(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED26 RID: 126246 RVA: 0x00A00178 File Offset: 0x009FE378
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			heroDetailInfoUIController.m_luaExportHelper.__clearDele_EventOnSetDetailState(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED27 RID: 126247 RVA: 0x00A001D4 File Offset: 0x009FE3D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__callDele_EventOnSkinInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED28 RID: 126248 RVA: 0x00A00228 File Offset: 0x009FE428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__clearDele_EventOnSkinInfoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED29 RID: 126249 RVA: 0x00A0027C File Offset: 0x009FE47C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnJobUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__callDele_EventOnJobUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED2A RID: 126250 RVA: 0x00A002D0 File Offset: 0x009FE4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnJobUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			heroDetailInfoUIController.m_luaExportHelper.__clearDele_EventOnJobUpButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED2B RID: 126251 RVA: 0x00A00324 File Offset: 0x009FE524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED2C RID: 126252 RVA: 0x00A0037C File Offset: 0x009FE57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			heroDetailInfoUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED2D RID: 126253 RVA: 0x00A003D8 File Offset: 0x009FE5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroArmyImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroArmyImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED2E RID: 126254 RVA: 0x00A00430 File Offset: 0x009FE630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroArmyImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroArmyImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroArmyImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroArmyImg = infoHeroArmyImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED2F RID: 126255 RVA: 0x00A0048C File Offset: 0x009FE68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED30 RID: 126256 RVA: 0x00A004E4 File Offset: 0x009FE6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroLvText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroLvText;
			LuaObject.checkType<Text>(l, 2, out infoHeroLvText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroLvText = infoHeroLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED31 RID: 126257 RVA: 0x00A00540 File Offset: 0x009FE740
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_infoHeroLvMaxText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroLvMaxText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED32 RID: 126258 RVA: 0x00A00598 File Offset: 0x009FE798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroLvMaxText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroLvMaxText;
			LuaObject.checkType<Text>(l, 2, out infoHeroLvMaxText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroLvMaxText = infoHeroLvMaxText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED33 RID: 126259 RVA: 0x00A005F4 File Offset: 0x009FE7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroExpText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroExpText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED34 RID: 126260 RVA: 0x00A0064C File Offset: 0x009FE84C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroExpText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroExpText;
			LuaObject.checkType<Text>(l, 2, out infoHeroExpText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroExpText = infoHeroExpText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED35 RID: 126261 RVA: 0x00A006A8 File Offset: 0x009FE8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroExpImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroExpImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED36 RID: 126262 RVA: 0x00A00700 File Offset: 0x009FE900
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroExpImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroExpImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroExpImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroExpImg = infoHeroExpImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED37 RID: 126263 RVA: 0x00A0075C File Offset: 0x009FE95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED38 RID: 126264 RVA: 0x00A007B4 File Offset: 0x009FE9B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject infoHeroGraphic;
			LuaObject.checkType<GameObject>(l, 2, out infoHeroGraphic);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroGraphic = infoHeroGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED39 RID: 126265 RVA: 0x00A00810 File Offset: 0x009FEA10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_propertyMsgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_propertyMsgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED3A RID: 126266 RVA: 0x00A00868 File Offset: 0x009FEA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_propertyMsgButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button propertyMsgButton;
			LuaObject.checkType<Button>(l, 2, out propertyMsgButton);
			heroDetailInfoUIController.m_luaExportHelper.m_propertyMsgButton = propertyMsgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED3B RID: 126267 RVA: 0x00A008C4 File Offset: 0x009FEAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_explanationStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_explanationStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED3C RID: 126268 RVA: 0x00A0091C File Offset: 0x009FEB1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_explanationStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController explanationStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out explanationStateCtrl);
			heroDetailInfoUIController.m_luaExportHelper.m_explanationStateCtrl = explanationStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED3D RID: 126269 RVA: 0x00A00978 File Offset: 0x009FEB78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_explanationBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_explanationBackgroundButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED3E RID: 126270 RVA: 0x00A009D0 File Offset: 0x009FEBD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_explanationBackgroundButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button explanationBackgroundButton;
			LuaObject.checkType<Button>(l, 2, out explanationBackgroundButton);
			heroDetailInfoUIController.m_luaExportHelper.m_explanationBackgroundButton = explanationBackgroundButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED3F RID: 126271 RVA: 0x00A00A2C File Offset: 0x009FEC2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_explanationText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_explanationText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED40 RID: 126272 RVA: 0x00A00A84 File Offset: 0x009FEC84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_explanationText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text explanationText;
			LuaObject.checkType<Text>(l, 2, out explanationText);
			heroDetailInfoUIController.m_luaExportHelper.m_explanationText = explanationText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED41 RID: 126273 RVA: 0x00A00AE0 File Offset: 0x009FECE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagButtonsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagButtonsContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED42 RID: 126274 RVA: 0x00A00B38 File Offset: 0x009FED38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagButtonsContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject tagButtonsContent;
			LuaObject.checkType<GameObject>(l, 2, out tagButtonsContent);
			heroDetailInfoUIController.m_luaExportHelper.m_tagButtonsContent = tagButtonsContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED43 RID: 126275 RVA: 0x00A00B94 File Offset: 0x009FED94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED44 RID: 126276 RVA: 0x00A00BEC File Offset: 0x009FEDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController tagPanelStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out tagPanelStateCtrl);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelStateCtrl = tagPanelStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED45 RID: 126277 RVA: 0x00A00C48 File Offset: 0x009FEE48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED46 RID: 126278 RVA: 0x00A00CA0 File Offset: 0x009FEEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button tagPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out tagPanelBGButton);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelBGButton = tagPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED47 RID: 126279 RVA: 0x00A00CFC File Offset: 0x009FEEFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tagPanelTitleText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelTitleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED48 RID: 126280 RVA: 0x00A00D54 File Offset: 0x009FEF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelTitleText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text tagPanelTitleText;
			LuaObject.checkType<Text>(l, 2, out tagPanelTitleText);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelTitleText = tagPanelTitleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED49 RID: 126281 RVA: 0x00A00DB0 File Offset: 0x009FEFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED4A RID: 126282 RVA: 0x00A00E08 File Offset: 0x009FF008
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tagPanelDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text tagPanelDescText;
			LuaObject.checkType<Text>(l, 2, out tagPanelDescText);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelDescText = tagPanelDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED4B RID: 126283 RVA: 0x00A00E64 File Offset: 0x009FF064
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED4C RID: 126284 RVA: 0x00A00EBC File Offset: 0x009FF0BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelIconImage(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image tagPanelIconImage;
			LuaObject.checkType<Image>(l, 2, out tagPanelIconImage);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelIconImage = tagPanelIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED4D RID: 126285 RVA: 0x00A00F18 File Offset: 0x009FF118
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_tagPanelListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelListScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED4E RID: 126286 RVA: 0x00A00F70 File Offset: 0x009FF170
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelListScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject tagPanelListScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out tagPanelListScrollViewContent);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelListScrollViewContent = tagPanelListScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED4F RID: 126287 RVA: 0x00A00FCC File Offset: 0x009FF1CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelListScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED50 RID: 126288 RVA: 0x00A01024 File Offset: 0x009FF224
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_tagPanelListScrollRect(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			ScrollRect tagPanelListScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out tagPanelListScrollRect);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelListScrollRect = tagPanelListScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED51 RID: 126289 RVA: 0x00A01080 File Offset: 0x009FF280
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelHeroIconImagePrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelHeroIconImagePrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED52 RID: 126290 RVA: 0x00A010D8 File Offset: 0x009FF2D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelHeroIconImagePrefab(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject tagPanelHeroIconImagePrefab;
			LuaObject.checkType<GameObject>(l, 2, out tagPanelHeroIconImagePrefab);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelHeroIconImagePrefab = tagPanelHeroIconImagePrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED53 RID: 126291 RVA: 0x00A01134 File Offset: 0x009FF334
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_tagPanelCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_tagPanelCloseBtn);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED54 RID: 126292 RVA: 0x00A0118C File Offset: 0x009FF38C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_tagPanelCloseBtn(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button tagPanelCloseBtn;
			LuaObject.checkType<Button>(l, 2, out tagPanelCloseBtn);
			heroDetailInfoUIController.m_luaExportHelper.m_tagPanelCloseBtn = tagPanelCloseBtn;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED55 RID: 126293 RVA: 0x00A011E8 File Offset: 0x009FF3E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropHPImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropHPImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED56 RID: 126294 RVA: 0x00A01240 File Offset: 0x009FF440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropHPImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroPropHPImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroPropHPImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropHPImg = infoHeroPropHPImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED57 RID: 126295 RVA: 0x00A0129C File Offset: 0x009FF49C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDFImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED58 RID: 126296 RVA: 0x00A012F4 File Offset: 0x009FF4F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroPropDFImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroPropDFImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDFImg = infoHeroPropDFImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED59 RID: 126297 RVA: 0x00A01350 File Offset: 0x009FF550
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropATImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropATImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED5A RID: 126298 RVA: 0x00A013A8 File Offset: 0x009FF5A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropATImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroPropATImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroPropATImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropATImg = infoHeroPropATImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED5B RID: 126299 RVA: 0x00A01404 File Offset: 0x009FF604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropMagicDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicDFImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED5C RID: 126300 RVA: 0x00A0145C File Offset: 0x009FF65C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropMagicDFImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroPropMagicDFImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroPropMagicDFImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicDFImg = infoHeroPropMagicDFImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED5D RID: 126301 RVA: 0x00A014B8 File Offset: 0x009FF6B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropMagicImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED5E RID: 126302 RVA: 0x00A01510 File Offset: 0x009FF710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropMagicImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroPropMagicImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroPropMagicImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicImg = infoHeroPropMagicImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED5F RID: 126303 RVA: 0x00A0156C File Offset: 0x009FF76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropDEXImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDEXImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED60 RID: 126304 RVA: 0x00A015C4 File Offset: 0x009FF7C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropDEXImg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroPropDEXImg;
			LuaObject.checkType<Image>(l, 2, out infoHeroPropDEXImg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDEXImg = infoHeroPropDEXImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED61 RID: 126305 RVA: 0x00A01620 File Offset: 0x009FF820
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropHPValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED62 RID: 126306 RVA: 0x00A01678 File Offset: 0x009FF878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropHPValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropHPValueText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropHPValueText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropHPValueText = infoHeroPropHPValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED63 RID: 126307 RVA: 0x00A016D4 File Offset: 0x009FF8D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED64 RID: 126308 RVA: 0x00A0172C File Offset: 0x009FF92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropDFValueText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropDFValueText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDFValueText = infoHeroPropDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED65 RID: 126309 RVA: 0x00A01788 File Offset: 0x009FF988
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropATValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED66 RID: 126310 RVA: 0x00A017E0 File Offset: 0x009FF9E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropATValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropATValueText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropATValueText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropATValueText = infoHeroPropATValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED67 RID: 126311 RVA: 0x00A0183C File Offset: 0x009FFA3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicDFValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED68 RID: 126312 RVA: 0x00A01894 File Offset: 0x009FFA94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropMagicDFValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropMagicDFValueText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropMagicDFValueText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicDFValueText = infoHeroPropMagicDFValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED69 RID: 126313 RVA: 0x00A018F0 File Offset: 0x009FFAF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED6A RID: 126314 RVA: 0x00A01948 File Offset: 0x009FFB48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropMagicValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropMagicValueText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropMagicValueText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicValueText = infoHeroPropMagicValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED6B RID: 126315 RVA: 0x00A019A4 File Offset: 0x009FFBA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDEXValueText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED6C RID: 126316 RVA: 0x00A019FC File Offset: 0x009FFBFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropDEXValueText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropDEXValueText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropDEXValueText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDEXValueText = infoHeroPropDEXValueText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED6D RID: 126317 RVA: 0x00A01A58 File Offset: 0x009FFC58
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_infoHeroPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropHPAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED6E RID: 126318 RVA: 0x00A01AB0 File Offset: 0x009FFCB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropHPAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropHPAddText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropHPAddText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropHPAddText = infoHeroPropHPAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED6F RID: 126319 RVA: 0x00A01B0C File Offset: 0x009FFD0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED70 RID: 126320 RVA: 0x00A01B64 File Offset: 0x009FFD64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropDFAddText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropDFAddText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDFAddText = infoHeroPropDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED71 RID: 126321 RVA: 0x00A01BC0 File Offset: 0x009FFDC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropATAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED72 RID: 126322 RVA: 0x00A01C18 File Offset: 0x009FFE18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropATAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropATAddText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropATAddText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropATAddText = infoHeroPropATAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED73 RID: 126323 RVA: 0x00A01C74 File Offset: 0x009FFE74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicDFAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED74 RID: 126324 RVA: 0x00A01CCC File Offset: 0x009FFECC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropMagicDFAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropMagicDFAddText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropMagicDFAddText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicDFAddText = infoHeroPropMagicDFAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED75 RID: 126325 RVA: 0x00A01D28 File Offset: 0x009FFF28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED76 RID: 126326 RVA: 0x00A01D80 File Offset: 0x009FFF80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropMagicAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropMagicAddText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropMagicAddText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropMagicAddText = infoHeroPropMagicAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED77 RID: 126327 RVA: 0x00A01DDC File Offset: 0x009FFFDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroPropDEXAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDEXAddText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED78 RID: 126328 RVA: 0x00A01E34 File Offset: 0x00A00034
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroPropDEXAddText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroPropDEXAddText;
			LuaObject.checkType<Text>(l, 2, out infoHeroPropDEXAddText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroPropDEXAddText = infoHeroPropDEXAddText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED79 RID: 126329 RVA: 0x00A01E90 File Offset: 0x00A00090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroTalentIcon);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED7A RID: 126330 RVA: 0x00A01EE8 File Offset: 0x00A000E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroTalentIcon(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Image infoHeroTalentIcon;
			LuaObject.checkType<Image>(l, 2, out infoHeroTalentIcon);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroTalentIcon = infoHeroTalentIcon;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED7B RID: 126331 RVA: 0x00A01F44 File Offset: 0x00A00144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroTalentNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroTalentNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED7C RID: 126332 RVA: 0x00A01F9C File Offset: 0x00A0019C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroTalentNameText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroTalentNameText;
			LuaObject.checkType<Text>(l, 2, out infoHeroTalentNameText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroTalentNameText = infoHeroTalentNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED7D RID: 126333 RVA: 0x00A01FF8 File Offset: 0x00A001F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroTalentDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroTalentDescText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED7E RID: 126334 RVA: 0x00A02050 File Offset: 0x00A00250
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroTalentDescText(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Text infoHeroTalentDescText;
			LuaObject.checkType<Text>(l, 2, out infoHeroTalentDescText);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroTalentDescText = infoHeroTalentDescText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED7F RID: 126335 RVA: 0x00A020AC File Offset: 0x00A002AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroCurSkillCostsObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillCostsObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED80 RID: 126336 RVA: 0x00A02104 File Offset: 0x00A00304
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroCurSkillCostsObj(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject infoHeroCurSkillCostsObj;
			LuaObject.checkType<GameObject>(l, 2, out infoHeroCurSkillCostsObj);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillCostsObj = infoHeroCurSkillCostsObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED81 RID: 126337 RVA: 0x00A02160 File Offset: 0x00A00360
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroCurSkillContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED82 RID: 126338 RVA: 0x00A021B8 File Offset: 0x00A003B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroCurSkillContent(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject infoHeroCurSkillContent;
			LuaObject.checkType<GameObject>(l, 2, out infoHeroCurSkillContent);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillContent = infoHeroCurSkillContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED83 RID: 126339 RVA: 0x00A02214 File Offset: 0x00A00414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroCurSkillContentBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillContentBg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED84 RID: 126340 RVA: 0x00A0226C File Offset: 0x00A0046C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroCurSkillContentBg(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject infoHeroCurSkillContentBg;
			LuaObject.checkType<GameObject>(l, 2, out infoHeroCurSkillContentBg);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillContentBg = infoHeroCurSkillContentBg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED85 RID: 126341 RVA: 0x00A022C8 File Offset: 0x00A004C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoHeroCurSkillChangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillChangeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED86 RID: 126342 RVA: 0x00A02320 File Offset: 0x00A00520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoHeroCurSkillChangeButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button infoHeroCurSkillChangeButton;
			LuaObject.checkType<Button>(l, 2, out infoHeroCurSkillChangeButton);
			heroDetailInfoUIController.m_luaExportHelper.m_infoHeroCurSkillChangeButton = infoHeroCurSkillChangeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED87 RID: 126343 RVA: 0x00A0237C File Offset: 0x00A0057C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoCurSkillDescPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoCurSkillDescPanel);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED88 RID: 126344 RVA: 0x00A023D4 File Offset: 0x00A005D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoCurSkillDescPanel(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			GameObject infoCurSkillDescPanel;
			LuaObject.checkType<GameObject>(l, 2, out infoCurSkillDescPanel);
			heroDetailInfoUIController.m_luaExportHelper.m_infoCurSkillDescPanel = infoCurSkillDescPanel;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED89 RID: 126345 RVA: 0x00A02430 File Offset: 0x00A00630
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_infoAddExpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_infoAddExpButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED8A RID: 126346 RVA: 0x00A02488 File Offset: 0x00A00688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_infoAddExpButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button infoAddExpButton;
			LuaObject.checkType<Button>(l, 2, out infoAddExpButton);
			heroDetailInfoUIController.m_luaExportHelper.m_infoAddExpButton = infoAddExpButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED8B RID: 126347 RVA: 0x00A024E4 File Offset: 0x00A006E4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_skinInfoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_skinInfoButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED8C RID: 126348 RVA: 0x00A0253C File Offset: 0x00A0073C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_skinInfoButton(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Button skinInfoButton;
			LuaObject.checkType<Button>(l, 2, out skinInfoButton);
			heroDetailInfoUIController.m_luaExportHelper.m_skinInfoButton = skinInfoButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED8D RID: 126349 RVA: 0x00A02598 File Offset: 0x00A00798
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSetDetailState(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailInfoUIController.EventOnSetDetailState += value;
				}
				else if (num == 2)
				{
					heroDetailInfoUIController.EventOnSetDetailState -= value;
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

	// Token: 0x0601ED8E RID: 126350 RVA: 0x00A02618 File Offset: 0x00A00818
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSkinInfoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailInfoUIController.EventOnSkinInfoButtonClick += value;
				}
				else if (num == 2)
				{
					heroDetailInfoUIController.EventOnSkinInfoButtonClick -= value;
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

	// Token: 0x0601ED8F RID: 126351 RVA: 0x00A02698 File Offset: 0x00A00898
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnJobUpButtonClick(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					heroDetailInfoUIController.EventOnJobUpButtonClick += value;
				}
				else if (num == 2)
				{
					heroDetailInfoUIController.EventOnJobUpButtonClick -= value;
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

	// Token: 0x0601ED90 RID: 126352 RVA: 0x00A02718 File Offset: 0x00A00918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_hero);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED91 RID: 126353 RVA: 0x00A02770 File Offset: 0x00A00970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_hero(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			Hero hero;
			LuaObject.checkType<Hero>(l, 2, out hero);
			heroDetailInfoUIController.m_luaExportHelper.m_hero = hero;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED92 RID: 126354 RVA: 0x00A027CC File Offset: 0x00A009CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_playerHeroGraphic);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED93 RID: 126355 RVA: 0x00A02824 File Offset: 0x00A00A24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeroGraphic(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			UISpineGraphic playerHeroGraphic;
			LuaObject.checkType<UISpineGraphic>(l, 2, out playerHeroGraphic);
			heroDetailInfoUIController.m_luaExportHelper.m_playerHeroGraphic = playerHeroGraphic;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED94 RID: 126356 RVA: 0x00A02880 File Offset: 0x00A00A80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED95 RID: 126357 RVA: 0x00A028D8 File Offset: 0x00A00AD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			heroDetailInfoUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED96 RID: 126358 RVA: 0x00A02934 File Offset: 0x00A00B34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, heroDetailInfoUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED97 RID: 126359 RVA: 0x00A0298C File Offset: 0x00A00B8C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			HeroDetailInfoUIController heroDetailInfoUIController = (HeroDetailInfoUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			heroDetailInfoUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601ED98 RID: 126360 RVA: 0x00A029E8 File Offset: 0x00A00BE8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.HeroDetailInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.UpdateViewInInfoState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SetCommonUIState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.IsShowHeroLittleSpine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.ShowHeroInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SetHeroTagInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OpenTagPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SetTagPanelInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SortRelatedHeroIdByRank);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.CloseTagPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SetHeroProperty);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SetHeroTalent);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.SetCurSelectSkills);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnSkillItemClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnAddExpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnSkinInfoButtonClcik);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnJobUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnChangeSkillButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnPropertyMsgButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.OnExplanationBackgroundButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callDele_EventOnSetDetailState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__clearDele_EventOnSetDetailState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callDele_EventOnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__clearDele_EventOnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__callDele_EventOnJobUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.__clearDele_EventOnJobUpButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache26);
		string name = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_marginTransform);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache28, true);
		string name2 = "m_infoHeroArmyImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroArmyImg);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroArmyImg);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2A, true);
		string name3 = "m_infoHeroLvText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroLvText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroLvText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2C, true);
		string name4 = "m_infoHeroLvMaxText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroLvMaxText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroLvMaxText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2E, true);
		string name5 = "m_infoHeroExpText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroExpText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroExpText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache30, true);
		string name6 = "m_infoHeroExpImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroExpImg);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroExpImg);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache32, true);
		string name7 = "m_infoHeroGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroGraphic);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroGraphic);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache34, true);
		string name8 = "m_propertyMsgButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_propertyMsgButton);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache35;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_propertyMsgButton);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache36, true);
		string name9 = "m_explanationStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_explanationStateCtrl);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache37;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_explanationStateCtrl);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache38, true);
		string name10 = "m_explanationBackgroundButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_explanationBackgroundButton);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache39;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_explanationBackgroundButton);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3A, true);
		string name11 = "m_explanationText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_explanationText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_explanationText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3C, true);
		string name12 = "m_tagButtonsContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagButtonsContent);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagButtonsContent);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3E, true);
		string name13 = "m_tagPanelStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelStateCtrl);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache3F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelStateCtrl);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache40, true);
		string name14 = "m_tagPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelBGButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache41;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelBGButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache42, true);
		string name15 = "m_tagPanelTitleText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelTitleText);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache43;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelTitleText);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache44, true);
		string name16 = "m_tagPanelDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelDescText);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelDescText);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache46, true);
		string name17 = "m_tagPanelIconImage";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelIconImage);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelIconImage);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache48, true);
		string name18 = "m_tagPanelListScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelListScrollViewContent);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelListScrollViewContent);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4A, true);
		string name19 = "m_tagPanelListScrollRect";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelListScrollRect);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelListScrollRect);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4C, true);
		string name20 = "m_tagPanelHeroIconImagePrefab";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelHeroIconImagePrefab);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelHeroIconImagePrefab);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4E, true);
		string name21 = "m_tagPanelCloseBtn";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_tagPanelCloseBtn);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_tagPanelCloseBtn);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache50, true);
		string name22 = "m_infoHeroPropHPImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropHPImg);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropHPImg);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache52, true);
		string name23 = "m_infoHeroPropDFImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropDFImg);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropDFImg);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache54, true);
		string name24 = "m_infoHeroPropATImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropATImg);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropATImg);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache56, true);
		string name25 = "m_infoHeroPropMagicDFImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropMagicDFImg);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropMagicDFImg);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache58, true);
		string name26 = "m_infoHeroPropMagicImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropMagicImg);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropMagicImg);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5A, true);
		string name27 = "m_infoHeroPropDEXImg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropDEXImg);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropDEXImg);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5C, true);
		string name28 = "m_infoHeroPropHPValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropHPValueText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropHPValueText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5E, true);
		string name29 = "m_infoHeroPropDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropDFValueText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropDFValueText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache60, true);
		string name30 = "m_infoHeroPropATValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropATValueText);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropATValueText);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache62, true);
		string name31 = "m_infoHeroPropMagicDFValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropMagicDFValueText);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropMagicDFValueText);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache64, true);
		string name32 = "m_infoHeroPropMagicValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropMagicValueText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropMagicValueText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache66, true);
		string name33 = "m_infoHeroPropDEXValueText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropDEXValueText);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropDEXValueText);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache68, true);
		string name34 = "m_infoHeroPropHPAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropHPAddText);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropHPAddText);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6A, true);
		string name35 = "m_infoHeroPropDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropDFAddText);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropDFAddText);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6C, true);
		string name36 = "m_infoHeroPropATAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropATAddText);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropATAddText);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6E, true);
		string name37 = "m_infoHeroPropMagicDFAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropMagicDFAddText);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropMagicDFAddText);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache70, true);
		string name38 = "m_infoHeroPropMagicAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropMagicAddText);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropMagicAddText);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache72, true);
		string name39 = "m_infoHeroPropDEXAddText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroPropDEXAddText);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroPropDEXAddText);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache74, true);
		string name40 = "m_infoHeroTalentIcon";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroTalentIcon);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroTalentIcon);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache76, true);
		string name41 = "m_infoHeroTalentNameText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroTalentNameText);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroTalentNameText);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache78, true);
		string name42 = "m_infoHeroTalentDescText";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroTalentDescText);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroTalentDescText);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7A, true);
		string name43 = "m_infoHeroCurSkillCostsObj";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroCurSkillCostsObj);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroCurSkillCostsObj);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7C, true);
		string name44 = "m_infoHeroCurSkillContent";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroCurSkillContent);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroCurSkillContent);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7E, true);
		string name45 = "m_infoHeroCurSkillContentBg";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroCurSkillContentBg);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroCurSkillContentBg);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache80, true);
		string name46 = "m_infoHeroCurSkillChangeButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoHeroCurSkillChangeButton);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoHeroCurSkillChangeButton);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache82, true);
		string name47 = "m_infoCurSkillDescPanel";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoCurSkillDescPanel);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoCurSkillDescPanel);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache84, true);
		string name48 = "m_infoAddExpButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_infoAddExpButton);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_infoAddExpButton);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache86, true);
		string name49 = "m_skinInfoButton";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_skinInfoButton);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_skinInfoButton);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache88, true);
		string name50 = "EventOnSetDetailState";
		LuaCSFunction get50 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_EventOnSetDetailState);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache89, true);
		string name51 = "EventOnSkinInfoButtonClick";
		LuaCSFunction get51 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_EventOnSkinInfoButtonClick);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8A, true);
		string name52 = "EventOnJobUpButtonClick";
		LuaCSFunction get52 = null;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_EventOnJobUpButtonClick);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8B, true);
		string name53 = "m_hero";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_hero);
		}
		LuaCSFunction get53 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8C;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_hero);
		}
		LuaObject.addMember(l, name53, get53, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8D, true);
		string name54 = "m_playerHeroGraphic";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_playerHeroGraphic);
		}
		LuaCSFunction get54 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8E;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_playerHeroGraphic);
		}
		LuaObject.addMember(l, name54, get54, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache8F, true);
		string name55 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_playerContext);
		}
		LuaCSFunction get55 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache90;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name55, get55, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache91, true);
		string name56 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.get_m_configDataLoader);
		}
		LuaCSFunction get56 = Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache92;
		if (Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name56, get56, Lua_BlackJack_ProjectL_UI_HeroDetailInfoUIController.<>f__mg$cache93, true);
		LuaObject.createTypeMetatable(l, null, typeof(HeroDetailInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x04014D80 RID: 85376
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04014D81 RID: 85377
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04014D82 RID: 85378
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04014D83 RID: 85379
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04014D84 RID: 85380
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04014D85 RID: 85381
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04014D86 RID: 85382
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04014D87 RID: 85383
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04014D88 RID: 85384
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04014D89 RID: 85385
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04014D8A RID: 85386
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04014D8B RID: 85387
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04014D8C RID: 85388
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04014D8D RID: 85389
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04014D8E RID: 85390
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04014D8F RID: 85391
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04014D90 RID: 85392
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04014D91 RID: 85393
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04014D92 RID: 85394
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04014D93 RID: 85395
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04014D94 RID: 85396
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04014D95 RID: 85397
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04014D96 RID: 85398
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04014D97 RID: 85399
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04014D98 RID: 85400
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04014D99 RID: 85401
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04014D9A RID: 85402
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04014D9B RID: 85403
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04014D9C RID: 85404
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04014D9D RID: 85405
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04014D9E RID: 85406
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04014D9F RID: 85407
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04014DA0 RID: 85408
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04014DA1 RID: 85409
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04014DA2 RID: 85410
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04014DA3 RID: 85411
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04014DA4 RID: 85412
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04014DA5 RID: 85413
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04014DA6 RID: 85414
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04014DA7 RID: 85415
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04014DA8 RID: 85416
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04014DA9 RID: 85417
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04014DAA RID: 85418
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04014DAB RID: 85419
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04014DAC RID: 85420
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04014DAD RID: 85421
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04014DAE RID: 85422
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04014DAF RID: 85423
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04014DB0 RID: 85424
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04014DB1 RID: 85425
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04014DB2 RID: 85426
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04014DB3 RID: 85427
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04014DB4 RID: 85428
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04014DB5 RID: 85429
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04014DB6 RID: 85430
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04014DB7 RID: 85431
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04014DB8 RID: 85432
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04014DB9 RID: 85433
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04014DBA RID: 85434
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04014DBB RID: 85435
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04014DBC RID: 85436
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04014DBD RID: 85437
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04014DBE RID: 85438
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04014DBF RID: 85439
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04014DC0 RID: 85440
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04014DC1 RID: 85441
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04014DC2 RID: 85442
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04014DC3 RID: 85443
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04014DC4 RID: 85444
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04014DC5 RID: 85445
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04014DC6 RID: 85446
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04014DC7 RID: 85447
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04014DC8 RID: 85448
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04014DC9 RID: 85449
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04014DCA RID: 85450
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04014DCB RID: 85451
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04014DCC RID: 85452
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04014DCD RID: 85453
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04014DCE RID: 85454
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04014DCF RID: 85455
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04014DD0 RID: 85456
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04014DD1 RID: 85457
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04014DD2 RID: 85458
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04014DD3 RID: 85459
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04014DD4 RID: 85460
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04014DD5 RID: 85461
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04014DD6 RID: 85462
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04014DD7 RID: 85463
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04014DD8 RID: 85464
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04014DD9 RID: 85465
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04014DDA RID: 85466
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04014DDB RID: 85467
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04014DDC RID: 85468
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04014DDD RID: 85469
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04014DDE RID: 85470
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04014DDF RID: 85471
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04014DE0 RID: 85472
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04014DE1 RID: 85473
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04014DE2 RID: 85474
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04014DE3 RID: 85475
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04014DE4 RID: 85476
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04014DE5 RID: 85477
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04014DE6 RID: 85478
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04014DE7 RID: 85479
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04014DE8 RID: 85480
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04014DE9 RID: 85481
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x04014DEA RID: 85482
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x04014DEB RID: 85483
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x04014DEC RID: 85484
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04014DED RID: 85485
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04014DEE RID: 85486
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04014DEF RID: 85487
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04014DF0 RID: 85488
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04014DF1 RID: 85489
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04014DF2 RID: 85490
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04014DF3 RID: 85491
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04014DF4 RID: 85492
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04014DF5 RID: 85493
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04014DF6 RID: 85494
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x04014DF7 RID: 85495
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x04014DF8 RID: 85496
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x04014DF9 RID: 85497
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x04014DFA RID: 85498
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x04014DFB RID: 85499
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x04014DFC RID: 85500
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x04014DFD RID: 85501
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x04014DFE RID: 85502
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x04014DFF RID: 85503
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x04014E00 RID: 85504
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x04014E01 RID: 85505
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04014E02 RID: 85506
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04014E03 RID: 85507
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04014E04 RID: 85508
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04014E05 RID: 85509
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04014E06 RID: 85510
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04014E07 RID: 85511
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04014E08 RID: 85512
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04014E09 RID: 85513
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04014E0A RID: 85514
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04014E0B RID: 85515
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x04014E0C RID: 85516
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x04014E0D RID: 85517
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x04014E0E RID: 85518
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x04014E0F RID: 85519
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x04014E10 RID: 85520
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x04014E11 RID: 85521
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04014E12 RID: 85522
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04014E13 RID: 85523
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;
}
