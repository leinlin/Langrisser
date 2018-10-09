using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.Scene;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001530 RID: 5424
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerSettingUIController : LuaObject
{
	// Token: 0x06020451 RID: 132177 RVA: 0x00AB920C File Offset: 0x00AB740C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SettingPanelShow(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.SettingPanelShow();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020452 RID: 132178 RVA: 0x00AB9258 File Offset: 0x00AB7458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSettingPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.UpdateSettingPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020453 RID: 132179 RVA: 0x00AB92A4 File Offset: 0x00AB74A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020454 RID: 132180 RVA: 0x00AB92F8 File Offset: 0x00AB74F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSettingPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.OnSettingPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020455 RID: 132181 RVA: 0x00AB934C File Offset: 0x00AB754C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnMusicVolumeValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float volumn;
			LuaObject.checkType(l, 2, out volumn);
			playerSettingUIController.m_luaExportHelper.OnMusicVolumeValueChanged(volumn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020456 RID: 132182 RVA: 0x00AB93A8 File Offset: 0x00AB75A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSoundVolumeValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float volumn;
			LuaObject.checkType(l, 2, out volumn);
			playerSettingUIController.m_luaExportHelper.OnSoundVolumeValueChanged(volumn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020457 RID: 132183 RVA: 0x00AB9404 File Offset: 0x00AB7604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoiceVolumeValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float volumn;
			LuaObject.checkType(l, 2, out volumn);
			playerSettingUIController.m_luaExportHelper.OnVoiceVolumeValueChanged(volumn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020458 RID: 132184 RVA: 0x00AB9460 File Offset: 0x00AB7660
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPowerSaveModeToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUIController.m_luaExportHelper.OnPowerSaveModeToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020459 RID: 132185 RVA: 0x00AB94BC File Offset: 0x00AB76BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnEndActionToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUIController.m_luaExportHelper.OnEndActionToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602045A RID: 132186 RVA: 0x00AB9518 File Offset: 0x00AB7718
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRecoveryEnergyToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUIController.m_luaExportHelper.OnRecoveryEnergyToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602045B RID: 132187 RVA: 0x00AB9574 File Offset: 0x00AB7774
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRandomEventToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUIController.m_luaExportHelper.OnRandomEventToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602045C RID: 132188 RVA: 0x00AB95D0 File Offset: 0x00AB77D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnArenaTicketToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUIController.m_luaExportHelper.OnArenaTicketToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602045D RID: 132189 RVA: 0x00AB962C File Offset: 0x00AB782C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnStoreRefreshToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerSettingUIController.m_luaExportHelper.OnStoreRefreshToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602045E RID: 132190 RVA: 0x00AB9688 File Offset: 0x00AB7888
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleAnimationOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool battleAnimationOn;
			LuaObject.checkType(l, 2, out battleAnimationOn);
			playerSettingUIController.m_luaExportHelper.SetBattleAnimationOn(battleAnimationOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602045F RID: 132191 RVA: 0x00AB96E4 File Offset: 0x00AB78E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleAnimationOff(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool battleAnimationOff;
			LuaObject.checkType(l, 2, out battleAnimationOff);
			playerSettingUIController.m_luaExportHelper.SetBattleAnimationOff(battleAnimationOff);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020460 RID: 132192 RVA: 0x00AB9740 File Offset: 0x00AB7940
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetBattleAnimationOnlyMine(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool battleAnimationOnlyMine;
			LuaObject.checkType(l, 2, out battleAnimationOnlyMine);
			playerSettingUIController.m_luaExportHelper.SetBattleAnimationOnlyMine(battleAnimationOnlyMine);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020461 RID: 132193 RVA: 0x00AB979C File Offset: 0x00AB799C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleAnimationOffButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.OnBattleAnimationOffButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020462 RID: 132194 RVA: 0x00AB97F0 File Offset: 0x00AB79F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBattleAnimationOnlyMineButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.OnBattleAnimationOnlyMineButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020463 RID: 132195 RVA: 0x00AB9844 File Offset: 0x00AB7A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerSettingUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020464 RID: 132196 RVA: 0x00AB98B0 File Offset: 0x00AB7AB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020465 RID: 132197 RVA: 0x00AB9904 File Offset: 0x00AB7B04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020466 RID: 132198 RVA: 0x00AB9958 File Offset: 0x00AB7B58
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerSettingUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020467 RID: 132199 RVA: 0x00AB9A00 File Offset: 0x00AB7C00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020468 RID: 132200 RVA: 0x00AB9A54 File Offset: 0x00AB7C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerSettingUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020469 RID: 132201 RVA: 0x00AB9AC0 File Offset: 0x00AB7CC0
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
				PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerSettingUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerSettingUIController playerSettingUIController2 = (PlayerSettingUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerSettingUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602046A RID: 132202 RVA: 0x00AB9BD0 File Offset: 0x00AB7DD0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSettingUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602046B RID: 132203 RVA: 0x00AB9C3C File Offset: 0x00AB7E3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSettingUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602046C RID: 132204 RVA: 0x00AB9CA8 File Offset: 0x00AB7EA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSettingUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602046D RID: 132205 RVA: 0x00AB9D14 File Offset: 0x00AB7F14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerSettingUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602046E RID: 132206 RVA: 0x00AB9D80 File Offset: 0x00AB7F80
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
				PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerSettingUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerSettingUIController playerSettingUIController2 = (PlayerSettingUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerSettingUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602046F RID: 132207 RVA: 0x00AB9E90 File Offset: 0x00AB8090
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			string s = playerSettingUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020470 RID: 132208 RVA: 0x00AB9EEC File Offset: 0x00AB80EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnMusicVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnMusicVolumeChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020471 RID: 132209 RVA: 0x00AB9F48 File Offset: 0x00AB8148
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnMusicVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnMusicVolumeChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020472 RID: 132210 RVA: 0x00AB9FA4 File Offset: 0x00AB81A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSoundVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnSoundVolumeChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020473 RID: 132211 RVA: 0x00ABA000 File Offset: 0x00AB8200
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSoundVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnSoundVolumeChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020474 RID: 132212 RVA: 0x00ABA05C File Offset: 0x00AB825C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnVoiceVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnVoiceVolumeChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020475 RID: 132213 RVA: 0x00ABA0B8 File Offset: 0x00AB82B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnVoiceVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			float obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnVoiceVolumeChanged(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020476 RID: 132214 RVA: 0x00ABA114 File Offset: 0x00AB8314
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnPowerSaveModeIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnPowerSaveModeIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020477 RID: 132215 RVA: 0x00ABA170 File Offset: 0x00AB8370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnPowerSaveModeIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnPowerSaveModeIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020478 RID: 132216 RVA: 0x00ABA1CC File Offset: 0x00AB83CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnEndActionIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnEndActionIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020479 RID: 132217 RVA: 0x00ABA228 File Offset: 0x00AB8428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnEndActionIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnEndActionIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602047A RID: 132218 RVA: 0x00ABA284 File Offset: 0x00AB8484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNotifyRecoveryEnergyIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnNotifyRecoveryEnergyIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602047B RID: 132219 RVA: 0x00ABA2E0 File Offset: 0x00AB84E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNotifyRecoveryEnergyIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnNotifyRecoveryEnergyIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602047C RID: 132220 RVA: 0x00ABA33C File Offset: 0x00AB853C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNotifyRandomEventIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnNotifyRandomEventIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602047D RID: 132221 RVA: 0x00ABA398 File Offset: 0x00AB8598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNotifyRandomEventIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnNotifyRandomEventIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602047E RID: 132222 RVA: 0x00ABA3F4 File Offset: 0x00AB85F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNotifyArenaTicketIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnNotifyArenaTicketIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602047F RID: 132223 RVA: 0x00ABA450 File Offset: 0x00AB8650
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNotifyArenaTicketIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnNotifyArenaTicketIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020480 RID: 132224 RVA: 0x00ABA4AC File Offset: 0x00AB86AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnNotifyStoreRefreshIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnNotifyStoreRefreshIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020481 RID: 132225 RVA: 0x00ABA508 File Offset: 0x00AB8708
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnNotifyStoreRefreshIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnNotifyStoreRefreshIsOn(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020482 RID: 132226 RVA: 0x00ABA564 File Offset: 0x00AB8764
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSetBattleAnimationMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			SkipCombatMode obj;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnSetBattleAnimationMode(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020483 RID: 132227 RVA: 0x00ABA5C0 File Offset: 0x00AB87C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSetBattleAnimationMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			SkipCombatMode obj;
			LuaObject.checkEnum<SkipCombatMode>(l, 2, out obj);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnSetBattleAnimationMode(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020484 RID: 132228 RVA: 0x00ABA61C File Offset: 0x00AB881C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020485 RID: 132229 RVA: 0x00ABA670 File Offset: 0x00AB8870
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			playerSettingUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020486 RID: 132230 RVA: 0x00ABA6C4 File Offset: 0x00AB88C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnMusicVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<float> value;
			int num = LuaObject.checkDelegate<Action<float>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnMusicVolumeChanged += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnMusicVolumeChanged -= value;
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

	// Token: 0x06020487 RID: 132231 RVA: 0x00ABA744 File Offset: 0x00AB8944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSoundVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<float> value;
			int num = LuaObject.checkDelegate<Action<float>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnSoundVolumeChanged += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnSoundVolumeChanged -= value;
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

	// Token: 0x06020488 RID: 132232 RVA: 0x00ABA7C4 File Offset: 0x00AB89C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnVoiceVolumeChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<float> value;
			int num = LuaObject.checkDelegate<Action<float>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnVoiceVolumeChanged += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnVoiceVolumeChanged -= value;
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

	// Token: 0x06020489 RID: 132233 RVA: 0x00ABA844 File Offset: 0x00AB8A44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnPowerSaveModeIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnPowerSaveModeIsOn += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnPowerSaveModeIsOn -= value;
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

	// Token: 0x0602048A RID: 132234 RVA: 0x00ABA8C4 File Offset: 0x00AB8AC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnEndActionIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnEndActionIsOn += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnEndActionIsOn -= value;
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

	// Token: 0x0602048B RID: 132235 RVA: 0x00ABA944 File Offset: 0x00AB8B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNotifyRecoveryEnergyIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnNotifyRecoveryEnergyIsOn += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnNotifyRecoveryEnergyIsOn -= value;
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

	// Token: 0x0602048C RID: 132236 RVA: 0x00ABA9C4 File Offset: 0x00AB8BC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNotifyRandomEventIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnNotifyRandomEventIsOn += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnNotifyRandomEventIsOn -= value;
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

	// Token: 0x0602048D RID: 132237 RVA: 0x00ABAA44 File Offset: 0x00AB8C44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNotifyArenaTicketIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnNotifyArenaTicketIsOn += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnNotifyArenaTicketIsOn -= value;
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

	// Token: 0x0602048E RID: 132238 RVA: 0x00ABAAC4 File Offset: 0x00AB8CC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnNotifyStoreRefreshIsOn(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnNotifyStoreRefreshIsOn += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnNotifyStoreRefreshIsOn -= value;
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

	// Token: 0x0602048F RID: 132239 RVA: 0x00ABAB44 File Offset: 0x00AB8D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSetBattleAnimationMode(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action<SkipCombatMode> value;
			int num = LuaObject.checkDelegate<Action<SkipCombatMode>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnSetBattleAnimationMode += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnSetBattleAnimationMode -= value;
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

	// Token: 0x06020490 RID: 132240 RVA: 0x00ABABC4 File Offset: 0x00AB8DC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerSettingUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					playerSettingUIController.EventOnClose -= value;
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

	// Token: 0x06020491 RID: 132241 RVA: 0x00ABAC44 File Offset: 0x00AB8E44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_settingStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_settingStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020492 RID: 132242 RVA: 0x00ABAC9C File Offset: 0x00AB8E9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_settingStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController settingStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out settingStateCtrl);
			playerSettingUIController.m_luaExportHelper.m_settingStateCtrl = settingStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020493 RID: 132243 RVA: 0x00ABACF8 File Offset: 0x00AB8EF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_settingPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_settingPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020494 RID: 132244 RVA: 0x00ABAD50 File Offset: 0x00AB8F50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_settingPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Button settingPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out settingPanelBGButton);
			playerSettingUIController.m_luaExportHelper.m_settingPanelBGButton = settingPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020495 RID: 132245 RVA: 0x00ABADAC File Offset: 0x00AB8FAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_settingPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_settingPanelCloseButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020496 RID: 132246 RVA: 0x00ABAE04 File Offset: 0x00AB9004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_settingPanelCloseButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Button settingPanelCloseButton;
			LuaObject.checkType<Button>(l, 2, out settingPanelCloseButton);
			playerSettingUIController.m_luaExportHelper.m_settingPanelCloseButton = settingPanelCloseButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020497 RID: 132247 RVA: 0x00ABAE60 File Offset: 0x00AB9060
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_musicVolumeSlider(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_musicVolumeSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020498 RID: 132248 RVA: 0x00ABAEB8 File Offset: 0x00AB90B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_musicVolumeSlider(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Slider musicVolumeSlider;
			LuaObject.checkType<Slider>(l, 2, out musicVolumeSlider);
			playerSettingUIController.m_luaExportHelper.m_musicVolumeSlider = musicVolumeSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020499 RID: 132249 RVA: 0x00ABAF14 File Offset: 0x00AB9114
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soundVolumeSlider(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_soundVolumeSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602049A RID: 132250 RVA: 0x00ABAF6C File Offset: 0x00AB916C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soundVolumeSlider(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Slider soundVolumeSlider;
			LuaObject.checkType<Slider>(l, 2, out soundVolumeSlider);
			playerSettingUIController.m_luaExportHelper.m_soundVolumeSlider = soundVolumeSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602049B RID: 132251 RVA: 0x00ABAFC8 File Offset: 0x00AB91C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceVolumeSlider(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_voiceVolumeSlider);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602049C RID: 132252 RVA: 0x00ABB020 File Offset: 0x00AB9220
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceVolumeSlider(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Slider voiceVolumeSlider;
			LuaObject.checkType<Slider>(l, 2, out voiceVolumeSlider);
			playerSettingUIController.m_luaExportHelper.m_voiceVolumeSlider = voiceVolumeSlider;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602049D RID: 132253 RVA: 0x00ABB07C File Offset: 0x00AB927C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_musicSoundOnState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_musicSoundOnState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602049E RID: 132254 RVA: 0x00ABB0D4 File Offset: 0x00AB92D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_musicSoundOnState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController musicSoundOnState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out musicSoundOnState);
			playerSettingUIController.m_luaExportHelper.m_musicSoundOnState = musicSoundOnState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602049F RID: 132255 RVA: 0x00ABB130 File Offset: 0x00AB9330
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_musicSoundOffState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_musicSoundOffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A0 RID: 132256 RVA: 0x00ABB188 File Offset: 0x00AB9388
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_musicSoundOffState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController musicSoundOffState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out musicSoundOffState);
			playerSettingUIController.m_luaExportHelper.m_musicSoundOffState = musicSoundOffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A1 RID: 132257 RVA: 0x00ABB1E4 File Offset: 0x00AB93E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soundSoundOnState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_soundSoundOnState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A2 RID: 132258 RVA: 0x00ABB23C File Offset: 0x00AB943C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soundSoundOnState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soundSoundOnState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soundSoundOnState);
			playerSettingUIController.m_luaExportHelper.m_soundSoundOnState = soundSoundOnState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A3 RID: 132259 RVA: 0x00ABB298 File Offset: 0x00AB9498
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_soundSoundOffState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_soundSoundOffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A4 RID: 132260 RVA: 0x00ABB2F0 File Offset: 0x00AB94F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_soundSoundOffState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController soundSoundOffState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out soundSoundOffState);
			playerSettingUIController.m_luaExportHelper.m_soundSoundOffState = soundSoundOffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A5 RID: 132261 RVA: 0x00ABB34C File Offset: 0x00AB954C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceSoundOnState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_voiceSoundOnState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A6 RID: 132262 RVA: 0x00ABB3A4 File Offset: 0x00AB95A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceSoundOnState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController voiceSoundOnState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out voiceSoundOnState);
			playerSettingUIController.m_luaExportHelper.m_voiceSoundOnState = voiceSoundOnState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A7 RID: 132263 RVA: 0x00ABB400 File Offset: 0x00AB9600
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voiceSoundOffState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_voiceSoundOffState);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A8 RID: 132264 RVA: 0x00ABB458 File Offset: 0x00AB9658
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voiceSoundOffState(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			CommonUIStateController voiceSoundOffState;
			LuaObject.checkType<CommonUIStateController>(l, 2, out voiceSoundOffState);
			playerSettingUIController.m_luaExportHelper.m_voiceSoundOffState = voiceSoundOffState;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204A9 RID: 132265 RVA: 0x00ABB4B4 File Offset: 0x00AB96B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerSaveModeOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_powerSaveModeOnToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204AA RID: 132266 RVA: 0x00ABB50C File Offset: 0x00AB970C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerSaveModeOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle powerSaveModeOnToggle;
			LuaObject.checkType<Toggle>(l, 2, out powerSaveModeOnToggle);
			playerSettingUIController.m_luaExportHelper.m_powerSaveModeOnToggle = powerSaveModeOnToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204AB RID: 132267 RVA: 0x00ABB568 File Offset: 0x00AB9768
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_powerSaveModeOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_powerSaveModeOffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204AC RID: 132268 RVA: 0x00ABB5C0 File Offset: 0x00AB97C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_powerSaveModeOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle powerSaveModeOffToggle;
			LuaObject.checkType<Toggle>(l, 2, out powerSaveModeOffToggle);
			playerSettingUIController.m_luaExportHelper.m_powerSaveModeOffToggle = powerSaveModeOffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204AD RID: 132269 RVA: 0x00ABB61C File Offset: 0x00AB981C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endActionOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_endActionOnToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204AE RID: 132270 RVA: 0x00ABB674 File Offset: 0x00AB9874
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endActionOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle endActionOnToggle;
			LuaObject.checkType<Toggle>(l, 2, out endActionOnToggle);
			playerSettingUIController.m_luaExportHelper.m_endActionOnToggle = endActionOnToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204AF RID: 132271 RVA: 0x00ABB6D0 File Offset: 0x00AB98D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_endActionOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_endActionOffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B0 RID: 132272 RVA: 0x00ABB728 File Offset: 0x00AB9928
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_endActionOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle endActionOffToggle;
			LuaObject.checkType<Toggle>(l, 2, out endActionOffToggle);
			playerSettingUIController.m_luaExportHelper.m_endActionOffToggle = endActionOffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B1 RID: 132273 RVA: 0x00ABB784 File Offset: 0x00AB9984
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recoveryEnergyOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_recoveryEnergyOnToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B2 RID: 132274 RVA: 0x00ABB7DC File Offset: 0x00AB99DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recoveryEnergyOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle recoveryEnergyOnToggle;
			LuaObject.checkType<Toggle>(l, 2, out recoveryEnergyOnToggle);
			playerSettingUIController.m_luaExportHelper.m_recoveryEnergyOnToggle = recoveryEnergyOnToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B3 RID: 132275 RVA: 0x00ABB838 File Offset: 0x00AB9A38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recoveryEnergyOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_recoveryEnergyOffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B4 RID: 132276 RVA: 0x00ABB890 File Offset: 0x00AB9A90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recoveryEnergyOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle recoveryEnergyOffToggle;
			LuaObject.checkType<Toggle>(l, 2, out recoveryEnergyOffToggle);
			playerSettingUIController.m_luaExportHelper.m_recoveryEnergyOffToggle = recoveryEnergyOffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B5 RID: 132277 RVA: 0x00ABB8EC File Offset: 0x00AB9AEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_arenaTicketOnToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B6 RID: 132278 RVA: 0x00ABB944 File Offset: 0x00AB9B44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle arenaTicketOnToggle;
			LuaObject.checkType<Toggle>(l, 2, out arenaTicketOnToggle);
			playerSettingUIController.m_luaExportHelper.m_arenaTicketOnToggle = arenaTicketOnToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B7 RID: 132279 RVA: 0x00ABB9A0 File Offset: 0x00AB9BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_arenaTicketOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_arenaTicketOffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B8 RID: 132280 RVA: 0x00ABB9F8 File Offset: 0x00AB9BF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_arenaTicketOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle arenaTicketOffToggle;
			LuaObject.checkType<Toggle>(l, 2, out arenaTicketOffToggle);
			playerSettingUIController.m_luaExportHelper.m_arenaTicketOffToggle = arenaTicketOffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204B9 RID: 132281 RVA: 0x00ABBA54 File Offset: 0x00AB9C54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeRefreshOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_storeRefreshOnToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204BA RID: 132282 RVA: 0x00ABBAAC File Offset: 0x00AB9CAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeRefreshOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle storeRefreshOnToggle;
			LuaObject.checkType<Toggle>(l, 2, out storeRefreshOnToggle);
			playerSettingUIController.m_luaExportHelper.m_storeRefreshOnToggle = storeRefreshOnToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204BB RID: 132283 RVA: 0x00ABBB08 File Offset: 0x00AB9D08
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_storeRefreshOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_storeRefreshOffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204BC RID: 132284 RVA: 0x00ABBB60 File Offset: 0x00AB9D60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_storeRefreshOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle storeRefreshOffToggle;
			LuaObject.checkType<Toggle>(l, 2, out storeRefreshOffToggle);
			playerSettingUIController.m_luaExportHelper.m_storeRefreshOffToggle = storeRefreshOffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204BD RID: 132285 RVA: 0x00ABBBBC File Offset: 0x00AB9DBC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleAnimationOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_battleAnimationOnToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204BE RID: 132286 RVA: 0x00ABBC14 File Offset: 0x00AB9E14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleAnimationOnToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle battleAnimationOnToggle;
			LuaObject.checkType<Toggle>(l, 2, out battleAnimationOnToggle);
			playerSettingUIController.m_luaExportHelper.m_battleAnimationOnToggle = battleAnimationOnToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204BF RID: 132287 RVA: 0x00ABBC70 File Offset: 0x00AB9E70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleAnimationOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_battleAnimationOffToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C0 RID: 132288 RVA: 0x00ABBCC8 File Offset: 0x00AB9EC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleAnimationOffToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle battleAnimationOffToggle;
			LuaObject.checkType<Toggle>(l, 2, out battleAnimationOffToggle);
			playerSettingUIController.m_luaExportHelper.m_battleAnimationOffToggle = battleAnimationOffToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C1 RID: 132289 RVA: 0x00ABBD24 File Offset: 0x00AB9F24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleAnimationOffButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_battleAnimationOffButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C2 RID: 132290 RVA: 0x00ABBD7C File Offset: 0x00AB9F7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleAnimationOffButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Button battleAnimationOffButton;
			LuaObject.checkType<Button>(l, 2, out battleAnimationOffButton);
			playerSettingUIController.m_luaExportHelper.m_battleAnimationOffButton = battleAnimationOffButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C3 RID: 132291 RVA: 0x00ABBDD8 File Offset: 0x00AB9FD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleAnimationOnlyMineToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_battleAnimationOnlyMineToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C4 RID: 132292 RVA: 0x00ABBE30 File Offset: 0x00ABA030
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleAnimationOnlyMineToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Toggle battleAnimationOnlyMineToggle;
			LuaObject.checkType<Toggle>(l, 2, out battleAnimationOnlyMineToggle);
			playerSettingUIController.m_luaExportHelper.m_battleAnimationOnlyMineToggle = battleAnimationOnlyMineToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C5 RID: 132293 RVA: 0x00ABBE8C File Offset: 0x00ABA08C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_battleAnimationOnlyMineButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_battleAnimationOnlyMineButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C6 RID: 132294 RVA: 0x00ABBEE4 File Offset: 0x00ABA0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_battleAnimationOnlyMineButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			Button battleAnimationOnlyMineButton;
			LuaObject.checkType<Button>(l, 2, out battleAnimationOnlyMineButton);
			playerSettingUIController.m_luaExportHelper.m_battleAnimationOnlyMineButton = battleAnimationOnlyMineButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C7 RID: 132295 RVA: 0x00ABBF40 File Offset: 0x00ABA140
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C8 RID: 132296 RVA: 0x00ABBF98 File Offset: 0x00ABA198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerSettingUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204C9 RID: 132297 RVA: 0x00ABBFF4 File Offset: 0x00ABA1F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerSettingUIController.m_luaExportHelper.m_isIgnoreToggleEvent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204CA RID: 132298 RVA: 0x00ABC04C File Offset: 0x00ABA24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isIgnoreToggleEvent(IntPtr l)
	{
		int result;
		try
		{
			PlayerSettingUIController playerSettingUIController = (PlayerSettingUIController)LuaObject.checkSelf(l);
			bool isIgnoreToggleEvent;
			LuaObject.checkType(l, 2, out isIgnoreToggleEvent);
			playerSettingUIController.m_luaExportHelper.m_isIgnoreToggleEvent = isIgnoreToggleEvent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060204CB RID: 132299 RVA: 0x00ABC0A8 File Offset: 0x00ABA2A8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerSettingUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.SettingPanelShow);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.UpdateSettingPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnSettingPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnMusicVolumeValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnSoundVolumeValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnVoiceVolumeValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnPowerSaveModeToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnEndActionToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnRecoveryEnergyToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnRandomEventToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnArenaTicketToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnStoreRefreshToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.SetBattleAnimationOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.SetBattleAnimationOff);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.SetBattleAnimationOnlyMine);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnBattleAnimationOffButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.OnBattleAnimationOnlyMineButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnMusicVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnMusicVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnSoundVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnSoundVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnVoiceVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnVoiceVolumeChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnPowerSaveModeIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnPowerSaveModeIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnEndActionIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnEndActionIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnNotifyRecoveryEnergyIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnNotifyRecoveryEnergyIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnNotifyRandomEventIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnNotifyRandomEventIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnNotifyArenaTicketIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnNotifyArenaTicketIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnNotifyStoreRefreshIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnNotifyStoreRefreshIsOn);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnSetBattleAnimationMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnSetBattleAnimationMode);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache34);
		string name = "EventOnMusicVolumeChanged";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnMusicVolumeChanged);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache35, true);
		string name2 = "EventOnSoundVolumeChanged";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnSoundVolumeChanged);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache36, true);
		string name3 = "EventOnVoiceVolumeChanged";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnVoiceVolumeChanged);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache37, true);
		string name4 = "EventOnPowerSaveModeIsOn";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnPowerSaveModeIsOn);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache38, true);
		string name5 = "EventOnEndActionIsOn";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnEndActionIsOn);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache39, true);
		string name6 = "EventOnNotifyRecoveryEnergyIsOn";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnNotifyRecoveryEnergyIsOn);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3A, true);
		string name7 = "EventOnNotifyRandomEventIsOn";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnNotifyRandomEventIsOn);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3B, true);
		string name8 = "EventOnNotifyArenaTicketIsOn";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnNotifyArenaTicketIsOn);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3C, true);
		string name9 = "EventOnNotifyStoreRefreshIsOn";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnNotifyStoreRefreshIsOn);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3D, true);
		string name10 = "EventOnSetBattleAnimationMode";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnSetBattleAnimationMode);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3E, true);
		string name11 = "EventOnClose";
		LuaCSFunction get11 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache3F, true);
		string name12 = "m_settingStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_settingStateCtrl);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_settingStateCtrl);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache41, true);
		string name13 = "m_settingPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_settingPanelBGButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_settingPanelBGButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache43, true);
		string name14 = "m_settingPanelCloseButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_settingPanelCloseButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache44;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_settingPanelCloseButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache45, true);
		string name15 = "m_musicVolumeSlider";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_musicVolumeSlider);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache46;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_musicVolumeSlider);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache47, true);
		string name16 = "m_soundVolumeSlider";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_soundVolumeSlider);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache48;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_soundVolumeSlider);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache49, true);
		string name17 = "m_voiceVolumeSlider";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_voiceVolumeSlider);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4A;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_voiceVolumeSlider);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4B, true);
		string name18 = "m_musicSoundOnState";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_musicSoundOnState);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4C;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_musicSoundOnState);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4D, true);
		string name19 = "m_musicSoundOffState";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_musicSoundOffState);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4E;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_musicSoundOffState);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache4F, true);
		string name20 = "m_soundSoundOnState";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_soundSoundOnState);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache50;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_soundSoundOnState);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache51, true);
		string name21 = "m_soundSoundOffState";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_soundSoundOffState);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache52;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_soundSoundOffState);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache53, true);
		string name22 = "m_voiceSoundOnState";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_voiceSoundOnState);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache54;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_voiceSoundOnState);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache55, true);
		string name23 = "m_voiceSoundOffState";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_voiceSoundOffState);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache56;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_voiceSoundOffState);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache57, true);
		string name24 = "m_powerSaveModeOnToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_powerSaveModeOnToggle);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache58;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_powerSaveModeOnToggle);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache59, true);
		string name25 = "m_powerSaveModeOffToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_powerSaveModeOffToggle);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5A;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_powerSaveModeOffToggle);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5B, true);
		string name26 = "m_endActionOnToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_endActionOnToggle);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5C;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_endActionOnToggle);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5D, true);
		string name27 = "m_endActionOffToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_endActionOffToggle);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5E;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_endActionOffToggle);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache5F, true);
		string name28 = "m_recoveryEnergyOnToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_recoveryEnergyOnToggle);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache60;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_recoveryEnergyOnToggle);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache61, true);
		string name29 = "m_recoveryEnergyOffToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_recoveryEnergyOffToggle);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache62;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_recoveryEnergyOffToggle);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache63, true);
		string name30 = "m_arenaTicketOnToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_arenaTicketOnToggle);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache64;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_arenaTicketOnToggle);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache65, true);
		string name31 = "m_arenaTicketOffToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_arenaTicketOffToggle);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache66;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_arenaTicketOffToggle);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache67, true);
		string name32 = "m_storeRefreshOnToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_storeRefreshOnToggle);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache68;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_storeRefreshOnToggle);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache69, true);
		string name33 = "m_storeRefreshOffToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_storeRefreshOffToggle);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6A;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_storeRefreshOffToggle);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6B, true);
		string name34 = "m_battleAnimationOnToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_battleAnimationOnToggle);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6C;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_battleAnimationOnToggle);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6D, true);
		string name35 = "m_battleAnimationOffToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_battleAnimationOffToggle);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6E;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_battleAnimationOffToggle);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache6F, true);
		string name36 = "m_battleAnimationOffButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_battleAnimationOffButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache70;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_battleAnimationOffButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache71, true);
		string name37 = "m_battleAnimationOnlyMineToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_battleAnimationOnlyMineToggle);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache72;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_battleAnimationOnlyMineToggle);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache73, true);
		string name38 = "m_battleAnimationOnlyMineButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_battleAnimationOnlyMineButton);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache74;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_battleAnimationOnlyMineButton);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache75, true);
		string name39 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_playerContext);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache76;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache77, true);
		string name40 = "m_isIgnoreToggleEvent";
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.get_m_isIgnoreToggleEvent);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache78;
		if (Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.set_m_isIgnoreToggleEvent);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_PlayerSettingUIController.<>f__mg$cache79, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerSettingUIController), typeof(UIControllerBase));
	}

	// Token: 0x040163D3 RID: 91091
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x040163D4 RID: 91092
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x040163D5 RID: 91093
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x040163D6 RID: 91094
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x040163D7 RID: 91095
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x040163D8 RID: 91096
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x040163D9 RID: 91097
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x040163DA RID: 91098
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x040163DB RID: 91099
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x040163DC RID: 91100
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x040163DD RID: 91101
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x040163DE RID: 91102
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x040163DF RID: 91103
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x040163E0 RID: 91104
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x040163E1 RID: 91105
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x040163E2 RID: 91106
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x040163E3 RID: 91107
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x040163E4 RID: 91108
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x040163E5 RID: 91109
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x040163E6 RID: 91110
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x040163E7 RID: 91111
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x040163E8 RID: 91112
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x040163E9 RID: 91113
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x040163EA RID: 91114
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x040163EB RID: 91115
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x040163EC RID: 91116
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x040163ED RID: 91117
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x040163EE RID: 91118
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x040163EF RID: 91119
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x040163F0 RID: 91120
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x040163F1 RID: 91121
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x040163F2 RID: 91122
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x040163F3 RID: 91123
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x040163F4 RID: 91124
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040163F5 RID: 91125
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040163F6 RID: 91126
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040163F7 RID: 91127
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040163F8 RID: 91128
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040163F9 RID: 91129
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040163FA RID: 91130
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040163FB RID: 91131
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040163FC RID: 91132
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040163FD RID: 91133
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040163FE RID: 91134
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040163FF RID: 91135
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04016400 RID: 91136
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x04016401 RID: 91137
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x04016402 RID: 91138
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x04016403 RID: 91139
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x04016404 RID: 91140
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x04016405 RID: 91141
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016406 RID: 91142
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016407 RID: 91143
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016408 RID: 91144
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016409 RID: 91145
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x0401640A RID: 91146
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x0401640B RID: 91147
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x0401640C RID: 91148
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x0401640D RID: 91149
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x0401640E RID: 91150
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x0401640F RID: 91151
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x04016410 RID: 91152
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x04016411 RID: 91153
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x04016412 RID: 91154
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x04016413 RID: 91155
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x04016414 RID: 91156
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x04016415 RID: 91157
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016416 RID: 91158
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x04016417 RID: 91159
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x04016418 RID: 91160
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x04016419 RID: 91161
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x0401641A RID: 91162
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x0401641B RID: 91163
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x0401641C RID: 91164
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x0401641D RID: 91165
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x0401641E RID: 91166
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x0401641F RID: 91167
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x04016420 RID: 91168
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x04016421 RID: 91169
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x04016422 RID: 91170
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x04016423 RID: 91171
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x04016424 RID: 91172
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x04016425 RID: 91173
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x04016426 RID: 91174
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x04016427 RID: 91175
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x04016428 RID: 91176
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x04016429 RID: 91177
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x0401642A RID: 91178
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x0401642B RID: 91179
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x0401642C RID: 91180
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x0401642D RID: 91181
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x0401642E RID: 91182
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x0401642F RID: 91183
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x04016430 RID: 91184
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x04016431 RID: 91185
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x04016432 RID: 91186
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x04016433 RID: 91187
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x04016434 RID: 91188
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x04016435 RID: 91189
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x04016436 RID: 91190
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x04016437 RID: 91191
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x04016438 RID: 91192
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x04016439 RID: 91193
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x0401643A RID: 91194
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x0401643B RID: 91195
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x0401643C RID: 91196
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x0401643D RID: 91197
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x0401643E RID: 91198
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x0401643F RID: 91199
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x04016440 RID: 91200
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x04016441 RID: 91201
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x04016442 RID: 91202
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x04016443 RID: 91203
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x04016444 RID: 91204
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x04016445 RID: 91205
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x04016446 RID: 91206
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x04016447 RID: 91207
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x04016448 RID: 91208
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x04016449 RID: 91209
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x0401644A RID: 91210
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x0401644B RID: 91211
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x0401644C RID: 91212
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;
}
