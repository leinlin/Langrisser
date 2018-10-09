using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.Common;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x020015CE RID: 5582
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedUIController : LuaObject
{
	// Token: 0x06022009 RID: 139273 RVA: 0x00B96090 File Offset: 0x00B94290
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int Open(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.Open();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602200A RID: 139274 RVA: 0x00B960DC File Offset: 0x00B942DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnchartedInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.SetUnchartedInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602200B RID: 139275 RVA: 0x00B96128 File Offset: 0x00B94328
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetClimbTowerFlushTime(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			TimeSpan climbTowerFlushTime;
			LuaObject.checkValueType<TimeSpan>(l, 2, out climbTowerFlushTime);
			unchartedUIController.SetClimbTowerFlushTime(climbTowerFlushTime);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602200C RID: 139276 RVA: 0x00B96180 File Offset: 0x00B94380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnchartedToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			int unchartedToggle;
			LuaObject.checkType(l, 2, out unchartedToggle);
			unchartedUIController.SetUnchartedToggle(unchartedToggle);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602200D RID: 139277 RVA: 0x00B961D8 File Offset: 0x00B943D8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602200E RID: 139278 RVA: 0x00B9622C File Offset: 0x00B9442C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetButtonOpened(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController ctrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out ctrl);
			GameFunctionType gameFunctionType;
			LuaObject.checkEnum<GameFunctionType>(l, 3, out gameFunctionType);
			unchartedUIController.m_luaExportHelper.SetButtonOpened(ctrl, gameFunctionType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602200F RID: 139279 RVA: 0x00B96298 File Offset: 0x00B94498
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetTreasureMapDailyCount(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			int haveCount;
			LuaObject.checkType(l, 2, out haveCount);
			int allCount;
			LuaObject.checkType(l, 3, out allCount);
			unchartedUIController.m_luaExportHelper.SetTreasureMapDailyCount(haveCount, allCount);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022010 RID: 139280 RVA: 0x00B96304 File Offset: 0x00B94504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int FireEventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			BattleType battleType;
			LuaObject.checkEnum<BattleType>(l, 2, out battleType);
			int chapterId;
			LuaObject.checkType(l, 3, out chapterId);
			unchartedUIController.m_luaExportHelper.FireEventOnShowUncharted(battleType, chapterId);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022011 RID: 139281 RVA: 0x00B96370 File Offset: 0x00B94570
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnReturnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnReturnButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022012 RID: 139282 RVA: 0x00B963C4 File Offset: 0x00B945C4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTeamButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnTeamButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022013 RID: 139283 RVA: 0x00B96418 File Offset: 0x00B94618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnDailyToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			unchartedUIController.m_luaExportHelper.OnDailyToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022014 RID: 139284 RVA: 0x00B96474 File Offset: 0x00B94674
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnLimitTimeToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			unchartedUIController.m_luaExportHelper.OnLimitTimeToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022015 RID: 139285 RVA: 0x00B964D0 File Offset: 0x00B946D0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int SetLimitTimeItems(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.SetLimitTimeItems();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022016 RID: 139286 RVA: 0x00B96524 File Offset: 0x00B94724
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnAnikiButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnAnikiButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022017 RID: 139287 RVA: 0x00B96578 File Offset: 0x00B94778
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnThearchyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnThearchyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022018 RID: 139288 RVA: 0x00B965CC File Offset: 0x00B947CC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnTreasureMapButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnTreasureMapButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022019 RID: 139289 RVA: 0x00B96620 File Offset: 0x00B94820
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnMemoryCorridorButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnMemoryCorridorButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602201A RID: 139290 RVA: 0x00B96674 File Offset: 0x00B94874
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeroTrainingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnHeroTrainingButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602201B RID: 139291 RVA: 0x00B966C8 File Offset: 0x00B948C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnClimbTowerButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.OnClimbTowerButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602201C RID: 139292 RVA: 0x00B9671C File Offset: 0x00B9491C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeroPhantomButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			HeroPhantomButton ctrl;
			LuaObject.checkType<HeroPhantomButton>(l, 2, out ctrl);
			unchartedUIController.m_luaExportHelper.OnHeroPhantomButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602201D RID: 139293 RVA: 0x00B96778 File Offset: 0x00B94978
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCooperateBattleButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CooperateBattleButton ctrl;
			LuaObject.checkType<CooperateBattleButton>(l, 2, out ctrl);
			unchartedUIController.m_luaExportHelper.OnCooperateBattleButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602201E RID: 139294 RVA: 0x00B967D4 File Offset: 0x00B949D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUnchartedScoreButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			UnchartedScoreButton ctrl;
			LuaObject.checkType<UnchartedScoreButton>(l, 2, out ctrl);
			unchartedUIController.m_luaExportHelper.OnUnchartedScoreButtonClick(ctrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602201F RID: 139295 RVA: 0x00B96830 File Offset: 0x00B94A30
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			unchartedUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022020 RID: 139296 RVA: 0x00B9689C File Offset: 0x00B94A9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022021 RID: 139297 RVA: 0x00B968F0 File Offset: 0x00B94AF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022022 RID: 139298 RVA: 0x00B96944 File Offset: 0x00B94B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = unchartedUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06022023 RID: 139299 RVA: 0x00B969EC File Offset: 0x00B94BEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022024 RID: 139300 RVA: 0x00B96A40 File Offset: 0x00B94C40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			unchartedUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022025 RID: 139301 RVA: 0x00B96AAC File Offset: 0x00B94CAC
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
				UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				unchartedUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UnchartedUIController unchartedUIController2 = (UnchartedUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				unchartedUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06022026 RID: 139302 RVA: 0x00B96BBC File Offset: 0x00B94DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022027 RID: 139303 RVA: 0x00B96C28 File Offset: 0x00B94E28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022028 RID: 139304 RVA: 0x00B96C94 File Offset: 0x00B94E94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022029 RID: 139305 RVA: 0x00B96D00 File Offset: 0x00B94F00
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602202A RID: 139306 RVA: 0x00B96D6C File Offset: 0x00B94F6C
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
				UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				unchartedUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UnchartedUIController unchartedUIController2 = (UnchartedUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				unchartedUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602202B RID: 139307 RVA: 0x00B96E7C File Offset: 0x00B9507C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			string s = unchartedUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602202C RID: 139308 RVA: 0x00B96ED8 File Offset: 0x00B950D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			unchartedUIController.m_luaExportHelper.__callDele_EventOnShowUncharted(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602202D RID: 139309 RVA: 0x00B96F44 File Offset: 0x00B95144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			BattleType arg;
			LuaObject.checkEnum<BattleType>(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			unchartedUIController.m_luaExportHelper.__clearDele_EventOnShowUncharted(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602202E RID: 139310 RVA: 0x00B96FB0 File Offset: 0x00B951B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__callDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602202F RID: 139311 RVA: 0x00B97004 File Offset: 0x00B95204
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __clearDele_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__clearDele_EventOnReturn();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022030 RID: 139312 RVA: 0x00B97058 File Offset: 0x00B95258
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__callDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022031 RID: 139313 RVA: 0x00B970AC File Offset: 0x00B952AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			unchartedUIController.m_luaExportHelper.__clearDele_EventOnShowTeam();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022032 RID: 139314 RVA: 0x00B97100 File Offset: 0x00B95300
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnShowUncharted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Action<BattleType, int> value;
			int num = LuaObject.checkDelegate<Action<BattleType, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedUIController.EventOnShowUncharted += value;
				}
				else if (num == 2)
				{
					unchartedUIController.EventOnShowUncharted -= value;
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

	// Token: 0x06022033 RID: 139315 RVA: 0x00B97180 File Offset: 0x00B95380
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnReturn(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedUIController.EventOnReturn += value;
				}
				else if (num == 2)
				{
					unchartedUIController.EventOnReturn -= value;
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

	// Token: 0x06022034 RID: 139316 RVA: 0x00B97200 File Offset: 0x00B95400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowTeam(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					unchartedUIController.EventOnShowTeam += value;
				}
				else if (num == 2)
				{
					unchartedUIController.EventOnShowTeam -= value;
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

	// Token: 0x06022035 RID: 139317 RVA: 0x00B97280 File Offset: 0x00B95480
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022036 RID: 139318 RVA: 0x00B972D8 File Offset: 0x00B954D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			unchartedUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022037 RID: 139319 RVA: 0x00B97334 File Offset: 0x00B95534
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_marginTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022038 RID: 139320 RVA: 0x00B9738C File Offset: 0x00B9558C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_marginTransform(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			RectTransform marginTransform;
			LuaObject.checkType<RectTransform>(l, 2, out marginTransform);
			unchartedUIController.m_luaExportHelper.m_marginTransform = marginTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022039 RID: 139321 RVA: 0x00B973E8 File Offset: 0x00B955E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_returnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602203A RID: 139322 RVA: 0x00B97440 File Offset: 0x00B95640
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_returnButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button returnButton;
			LuaObject.checkType<Button>(l, 2, out returnButton);
			unchartedUIController.m_luaExportHelper.m_returnButton = returnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602203B RID: 139323 RVA: 0x00B9749C File Offset: 0x00B9569C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_teamButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602203C RID: 139324 RVA: 0x00B974F4 File Offset: 0x00B956F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_teamButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button teamButton;
			LuaObject.checkType<Button>(l, 2, out teamButton);
			unchartedUIController.m_luaExportHelper.m_teamButton = teamButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602203D RID: 139325 RVA: 0x00B97550 File Offset: 0x00B95750
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_dailyToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_dailyToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602203E RID: 139326 RVA: 0x00B975A8 File Offset: 0x00B957A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Toggle dailyToggle;
			LuaObject.checkType<Toggle>(l, 2, out dailyToggle);
			unchartedUIController.m_luaExportHelper.m_dailyToggle = dailyToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602203F RID: 139327 RVA: 0x00B97604 File Offset: 0x00B95804
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_limitTimeToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_limitTimeToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022040 RID: 139328 RVA: 0x00B9765C File Offset: 0x00B9585C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_limitTimeToggle(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Toggle limitTimeToggle;
			LuaObject.checkType<Toggle>(l, 2, out limitTimeToggle);
			unchartedUIController.m_luaExportHelper.m_limitTimeToggle = limitTimeToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022041 RID: 139329 RVA: 0x00B976B8 File Offset: 0x00B958B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_dailyScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_dailyScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022042 RID: 139330 RVA: 0x00B97710 File Offset: 0x00B95910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_dailyScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			ScrollRect dailyScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out dailyScrollRect);
			unchartedUIController.m_luaExportHelper.m_dailyScrollRect = dailyScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022043 RID: 139331 RVA: 0x00B9776C File Offset: 0x00B9596C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_limitTimeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_limitTimeScrollRect);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022044 RID: 139332 RVA: 0x00B977C4 File Offset: 0x00B959C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_limitTimeScrollRect(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			ScrollRect limitTimeScrollRect;
			LuaObject.checkType<ScrollRect>(l, 2, out limitTimeScrollRect);
			unchartedUIController.m_luaExportHelper.m_limitTimeScrollRect = limitTimeScrollRect;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022045 RID: 139333 RVA: 0x00B97820 File Offset: 0x00B95A20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_anikiButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022046 RID: 139334 RVA: 0x00B97878 File Offset: 0x00B95A78
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_anikiButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button anikiButton;
			LuaObject.checkType<Button>(l, 2, out anikiButton);
			unchartedUIController.m_luaExportHelper.m_anikiButton = anikiButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022047 RID: 139335 RVA: 0x00B978D4 File Offset: 0x00B95AD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_anikiUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_anikiUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022048 RID: 139336 RVA: 0x00B9792C File Offset: 0x00B95B2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController anikiUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out anikiUIStateController);
			unchartedUIController.m_luaExportHelper.m_anikiUIStateController = anikiUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022049 RID: 139337 RVA: 0x00B97988 File Offset: 0x00B95B88
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_anikiDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_anikiDailyRewardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602204A RID: 139338 RVA: 0x00B979E0 File Offset: 0x00B95BE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_anikiDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Text anikiDailyRewardText;
			LuaObject.checkType<Text>(l, 2, out anikiDailyRewardText);
			unchartedUIController.m_luaExportHelper.m_anikiDailyRewardText = anikiDailyRewardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602204B RID: 139339 RVA: 0x00B97A3C File Offset: 0x00B95C3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_thearchyButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_thearchyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602204C RID: 139340 RVA: 0x00B97A94 File Offset: 0x00B95C94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button thearchyButton;
			LuaObject.checkType<Button>(l, 2, out thearchyButton);
			unchartedUIController.m_luaExportHelper.m_thearchyButton = thearchyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602204D RID: 139341 RVA: 0x00B97AF0 File Offset: 0x00B95CF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_thearchyUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_thearchyUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602204E RID: 139342 RVA: 0x00B97B48 File Offset: 0x00B95D48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController thearchyUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out thearchyUIStateController);
			unchartedUIController.m_luaExportHelper.m_thearchyUIStateController = thearchyUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602204F RID: 139343 RVA: 0x00B97BA4 File Offset: 0x00B95DA4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_thearchyDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_thearchyDailyRewardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022050 RID: 139344 RVA: 0x00B97BFC File Offset: 0x00B95DFC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_thearchyDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Text thearchyDailyRewardText;
			LuaObject.checkType<Text>(l, 2, out thearchyDailyRewardText);
			unchartedUIController.m_luaExportHelper.m_thearchyDailyRewardText = thearchyDailyRewardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022051 RID: 139345 RVA: 0x00B97C58 File Offset: 0x00B95E58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureMapButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_treasureMapButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022052 RID: 139346 RVA: 0x00B97CB0 File Offset: 0x00B95EB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureMapButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button treasureMapButton;
			LuaObject.checkType<Button>(l, 2, out treasureMapButton);
			unchartedUIController.m_luaExportHelper.m_treasureMapButton = treasureMapButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022053 RID: 139347 RVA: 0x00B97D0C File Offset: 0x00B95F0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureMapUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_treasureMapUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022054 RID: 139348 RVA: 0x00B97D64 File Offset: 0x00B95F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureMapUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController treasureMapUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out treasureMapUIStateController);
			unchartedUIController.m_luaExportHelper.m_treasureMapUIStateController = treasureMapUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022055 RID: 139349 RVA: 0x00B97DC0 File Offset: 0x00B95FC0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_treasureMapCountText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_treasureMapCountText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022056 RID: 139350 RVA: 0x00B97E18 File Offset: 0x00B96018
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_treasureMapCountText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Text treasureMapCountText;
			LuaObject.checkType<Text>(l, 2, out treasureMapCountText);
			unchartedUIController.m_luaExportHelper.m_treasureMapCountText = treasureMapCountText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022057 RID: 139351 RVA: 0x00B97E74 File Offset: 0x00B96074
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_memoryCorridorButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_memoryCorridorButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022058 RID: 139352 RVA: 0x00B97ECC File Offset: 0x00B960CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button memoryCorridorButton;
			LuaObject.checkType<Button>(l, 2, out memoryCorridorButton);
			unchartedUIController.m_luaExportHelper.m_memoryCorridorButton = memoryCorridorButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022059 RID: 139353 RVA: 0x00B97F28 File Offset: 0x00B96128
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_memoryCorridorUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602205A RID: 139354 RVA: 0x00B97F80 File Offset: 0x00B96180
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController memoryCorridorUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out memoryCorridorUIStateController);
			unchartedUIController.m_luaExportHelper.m_memoryCorridorUIStateController = memoryCorridorUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602205B RID: 139355 RVA: 0x00B97FDC File Offset: 0x00B961DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_memoryCorridorDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_memoryCorridorDailyRewardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602205C RID: 139356 RVA: 0x00B98034 File Offset: 0x00B96234
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_memoryCorridorDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Text memoryCorridorDailyRewardText;
			LuaObject.checkType<Text>(l, 2, out memoryCorridorDailyRewardText);
			unchartedUIController.m_luaExportHelper.m_memoryCorridorDailyRewardText = memoryCorridorDailyRewardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602205D RID: 139357 RVA: 0x00B98090 File Offset: 0x00B96290
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainingButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_heroTrainingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602205E RID: 139358 RVA: 0x00B980E8 File Offset: 0x00B962E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainingButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button heroTrainingButton;
			LuaObject.checkType<Button>(l, 2, out heroTrainingButton);
			unchartedUIController.m_luaExportHelper.m_heroTrainingButton = heroTrainingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602205F RID: 139359 RVA: 0x00B98144 File Offset: 0x00B96344
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroTrainingUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_heroTrainingUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022060 RID: 139360 RVA: 0x00B9819C File Offset: 0x00B9639C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainingUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController heroTrainingUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out heroTrainingUIStateController);
			unchartedUIController.m_luaExportHelper.m_heroTrainingUIStateController = heroTrainingUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022061 RID: 139361 RVA: 0x00B981F8 File Offset: 0x00B963F8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroTrainingDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_heroTrainingDailyRewardText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022062 RID: 139362 RVA: 0x00B98250 File Offset: 0x00B96450
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroTrainingDailyRewardText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Text heroTrainingDailyRewardText;
			LuaObject.checkType<Text>(l, 2, out heroTrainingDailyRewardText);
			unchartedUIController.m_luaExportHelper.m_heroTrainingDailyRewardText = heroTrainingDailyRewardText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022063 RID: 139363 RVA: 0x00B982AC File Offset: 0x00B964AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_climbTowerButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022064 RID: 139364 RVA: 0x00B98304 File Offset: 0x00B96504
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerButton(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Button climbTowerButton;
			LuaObject.checkType<Button>(l, 2, out climbTowerButton);
			unchartedUIController.m_luaExportHelper.m_climbTowerButton = climbTowerButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022065 RID: 139365 RVA: 0x00B98360 File Offset: 0x00B96560
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_climbTowerUIStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022066 RID: 139366 RVA: 0x00B983B8 File Offset: 0x00B965B8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_climbTowerUIStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			CommonUIStateController climbTowerUIStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out climbTowerUIStateController);
			unchartedUIController.m_luaExportHelper.m_climbTowerUIStateController = climbTowerUIStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022067 RID: 139367 RVA: 0x00B98414 File Offset: 0x00B96614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_climbTowerFlushtText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_climbTowerFlushtText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022068 RID: 139368 RVA: 0x00B9846C File Offset: 0x00B9666C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_climbTowerFlushtText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			Text climbTowerFlushtText;
			LuaObject.checkType<Text>(l, 2, out climbTowerFlushtText);
			unchartedUIController.m_luaExportHelper.m_climbTowerFlushtText = climbTowerFlushtText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022069 RID: 139369 RVA: 0x00B984C8 File Offset: 0x00B966C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_heroPhantomButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_heroPhantomButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602206A RID: 139370 RVA: 0x00B98520 File Offset: 0x00B96720
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroPhantomButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			GameObject heroPhantomButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out heroPhantomButtonPrefab);
			unchartedUIController.m_luaExportHelper.m_heroPhantomButtonPrefab = heroPhantomButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602206B RID: 139371 RVA: 0x00B9857C File Offset: 0x00B9677C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cooperateBattleButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_cooperateBattleButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602206C RID: 139372 RVA: 0x00B985D4 File Offset: 0x00B967D4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_cooperateBattleButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			GameObject cooperateBattleButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out cooperateBattleButtonPrefab);
			unchartedUIController.m_luaExportHelper.m_cooperateBattleButtonPrefab = cooperateBattleButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602206D RID: 139373 RVA: 0x00B98630 File Offset: 0x00B96830
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_unchartedScoreButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_unchartedScoreButtonPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602206E RID: 139374 RVA: 0x00B98688 File Offset: 0x00B96888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_unchartedScoreButtonPrefab(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			GameObject unchartedScoreButtonPrefab;
			LuaObject.checkType<GameObject>(l, 2, out unchartedScoreButtonPrefab);
			unchartedUIController.m_luaExportHelper.m_unchartedScoreButtonPrefab = unchartedScoreButtonPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602206F RID: 139375 RVA: 0x00B986E4 File Offset: 0x00B968E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022070 RID: 139376 RVA: 0x00B9873C File Offset: 0x00B9693C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			unchartedUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022071 RID: 139377 RVA: 0x00B98798 File Offset: 0x00B96998
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022072 RID: 139378 RVA: 0x00B987F0 File Offset: 0x00B969F0
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			UnchartedUIController unchartedUIController = (UnchartedUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			unchartedUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06022073 RID: 139379 RVA: 0x00B9884C File Offset: 0x00B96A4C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedUIController");
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.Open);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.SetUnchartedInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.SetClimbTowerFlushTime);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.SetUnchartedToggle);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.SetButtonOpened);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.SetTreasureMapDailyCount);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.FireEventOnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnReturnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnTeamButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnDailyToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnLimitTimeToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.SetLimitTimeItems);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnAnikiButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnThearchyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnTreasureMapButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnMemoryCorridorButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnHeroTrainingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnClimbTowerButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnHeroPhantomButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnCooperateBattleButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.OnUnchartedScoreButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callDele_EventOnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__clearDele_EventOnShowUncharted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__clearDele_EventOnReturn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__callDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.__clearDele_EventOnShowTeam);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache28);
		string name = "EventOnShowUncharted";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_EventOnShowUncharted);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache29, true);
		string name2 = "EventOnReturn";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_EventOnReturn);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2A, true);
		string name3 = "EventOnShowTeam";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_EventOnShowTeam);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2B, true);
		string name4 = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_uiStateController);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2D, true);
		string name5 = "m_marginTransform";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_marginTransform);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2E;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_marginTransform);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache2F, true);
		string name6 = "m_returnButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_returnButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache30;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_returnButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache31, true);
		string name7 = "m_teamButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_teamButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache32;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_teamButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache33, true);
		string name8 = "m_dailyToggle";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_dailyToggle);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache34;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_dailyToggle);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache35, true);
		string name9 = "m_limitTimeToggle";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_limitTimeToggle);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_limitTimeToggle);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache37, true);
		string name10 = "m_dailyScrollRect";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_dailyScrollRect);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_dailyScrollRect);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache39, true);
		string name11 = "m_limitTimeScrollRect";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_limitTimeScrollRect);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_limitTimeScrollRect);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3B, true);
		string name12 = "m_anikiButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_anikiButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_anikiButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3D, true);
		string name13 = "m_anikiUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_anikiUIStateController);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_anikiUIStateController);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache3F, true);
		string name14 = "m_anikiDailyRewardText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_anikiDailyRewardText);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_anikiDailyRewardText);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache41, true);
		string name15 = "m_thearchyButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_thearchyButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_thearchyButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache43, true);
		string name16 = "m_thearchyUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_thearchyUIStateController);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_thearchyUIStateController);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache45, true);
		string name17 = "m_thearchyDailyRewardText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_thearchyDailyRewardText);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_thearchyDailyRewardText);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache47, true);
		string name18 = "m_treasureMapButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_treasureMapButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_treasureMapButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache49, true);
		string name19 = "m_treasureMapUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_treasureMapUIStateController);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_treasureMapUIStateController);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4B, true);
		string name20 = "m_treasureMapCountText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_treasureMapCountText);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_treasureMapCountText);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4D, true);
		string name21 = "m_memoryCorridorButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_memoryCorridorButton);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_memoryCorridorButton);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache4F, true);
		string name22 = "m_memoryCorridorUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_memoryCorridorUIStateController);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_memoryCorridorUIStateController);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache51, true);
		string name23 = "m_memoryCorridorDailyRewardText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_memoryCorridorDailyRewardText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_memoryCorridorDailyRewardText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache53, true);
		string name24 = "m_heroTrainingButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_heroTrainingButton);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_heroTrainingButton);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache55, true);
		string name25 = "m_heroTrainingUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_heroTrainingUIStateController);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_heroTrainingUIStateController);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache57, true);
		string name26 = "m_heroTrainingDailyRewardText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_heroTrainingDailyRewardText);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_heroTrainingDailyRewardText);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache59, true);
		string name27 = "m_climbTowerButton";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_climbTowerButton);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_climbTowerButton);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5B, true);
		string name28 = "m_climbTowerUIStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_climbTowerUIStateController);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_climbTowerUIStateController);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5D, true);
		string name29 = "m_climbTowerFlushtText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_climbTowerFlushtText);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_climbTowerFlushtText);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache5F, true);
		string name30 = "m_heroPhantomButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_heroPhantomButtonPrefab);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_heroPhantomButtonPrefab);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache61, true);
		string name31 = "m_cooperateBattleButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_cooperateBattleButtonPrefab);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_cooperateBattleButtonPrefab);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache63, true);
		string name32 = "m_unchartedScoreButtonPrefab";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_unchartedScoreButtonPrefab);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_unchartedScoreButtonPrefab);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache65, true);
		string name33 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_configDataLoader);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache67, true);
		string name34 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.get_m_playerContext);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_UnchartedUIController.<>f__mg$cache69, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnchartedUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017E4F RID: 97871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017E50 RID: 97872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017E51 RID: 97873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017E52 RID: 97874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017E53 RID: 97875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017E54 RID: 97876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017E55 RID: 97877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017E56 RID: 97878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017E57 RID: 97879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017E58 RID: 97880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017E59 RID: 97881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017E5A RID: 97882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017E5B RID: 97883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017E5C RID: 97884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017E5D RID: 97885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017E5E RID: 97886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017E5F RID: 97887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017E60 RID: 97888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017E61 RID: 97889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017E62 RID: 97890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017E63 RID: 97891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017E64 RID: 97892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017E65 RID: 97893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017E66 RID: 97894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017E67 RID: 97895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017E68 RID: 97896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017E69 RID: 97897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017E6A RID: 97898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017E6B RID: 97899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04017E6C RID: 97900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04017E6D RID: 97901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04017E6E RID: 97902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04017E6F RID: 97903
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04017E70 RID: 97904
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04017E71 RID: 97905
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017E72 RID: 97906
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017E73 RID: 97907
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017E74 RID: 97908
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04017E75 RID: 97909
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04017E76 RID: 97910
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04017E77 RID: 97911
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04017E78 RID: 97912
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04017E79 RID: 97913
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04017E7A RID: 97914
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04017E7B RID: 97915
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04017E7C RID: 97916
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04017E7D RID: 97917
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04017E7E RID: 97918
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04017E7F RID: 97919
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04017E80 RID: 97920
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04017E81 RID: 97921
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04017E82 RID: 97922
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04017E83 RID: 97923
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04017E84 RID: 97924
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04017E85 RID: 97925
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04017E86 RID: 97926
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04017E87 RID: 97927
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04017E88 RID: 97928
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04017E89 RID: 97929
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04017E8A RID: 97930
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04017E8B RID: 97931
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04017E8C RID: 97932
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04017E8D RID: 97933
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04017E8E RID: 97934
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04017E8F RID: 97935
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04017E90 RID: 97936
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04017E91 RID: 97937
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04017E92 RID: 97938
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04017E93 RID: 97939
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04017E94 RID: 97940
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04017E95 RID: 97941
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x04017E96 RID: 97942
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x04017E97 RID: 97943
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x04017E98 RID: 97944
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x04017E99 RID: 97945
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x04017E9A RID: 97946
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x04017E9B RID: 97947
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04017E9C RID: 97948
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04017E9D RID: 97949
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04017E9E RID: 97950
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04017E9F RID: 97951
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04017EA0 RID: 97952
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04017EA1 RID: 97953
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04017EA2 RID: 97954
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04017EA3 RID: 97955
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04017EA4 RID: 97956
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04017EA5 RID: 97957
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x04017EA6 RID: 97958
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x04017EA7 RID: 97959
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x04017EA8 RID: 97960
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x04017EA9 RID: 97961
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x04017EAA RID: 97962
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x04017EAB RID: 97963
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04017EAC RID: 97964
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04017EAD RID: 97965
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04017EAE RID: 97966
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04017EAF RID: 97967
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04017EB0 RID: 97968
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04017EB1 RID: 97969
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04017EB2 RID: 97970
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04017EB3 RID: 97971
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04017EB4 RID: 97972
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04017EB5 RID: 97973
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x04017EB6 RID: 97974
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x04017EB7 RID: 97975
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x04017EB8 RID: 97976
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;
}
