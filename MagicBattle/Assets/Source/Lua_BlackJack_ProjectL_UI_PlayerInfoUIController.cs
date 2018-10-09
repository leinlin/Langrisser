using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.PlayerContext;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200152B RID: 5419
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerInfoUIController : LuaObject
{
	// Token: 0x060202F2 RID: 131826 RVA: 0x00AAE240 File Offset: 0x00AAC440
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateViewInPlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.UpdateViewInPlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F3 RID: 131827 RVA: 0x00AAE28C File Offset: 0x00AAC48C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetPlayerNameLimit(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			int playerNameLimit;
			LuaObject.checkType(l, 2, out playerNameLimit);
			playerInfoUIController.SetPlayerNameLimit(playerNameLimit);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F4 RID: 131828 RVA: 0x00AAE2E4 File Offset: 0x00AAC4E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int PlayerInfoOpenTween(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.PlayerInfoOpenTween();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F5 RID: 131829 RVA: 0x00AAE330 File Offset: 0x00AAC530
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeNamePanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.OnChangeNamePanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F6 RID: 131830 RVA: 0x00AAE37C File Offset: 0x00AAC57C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChangeHeadIconPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.ShowChangeHeadIconPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F7 RID: 131831 RVA: 0x00AAE3C8 File Offset: 0x00AAC5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeIconPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.OnChangeIconPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F8 RID: 131832 RVA: 0x00AAE414 File Offset: 0x00AAC614
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202F9 RID: 131833 RVA: 0x00AAE468 File Offset: 0x00AAC668
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetChangeNamePanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.SetChangeNamePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202FA RID: 131834 RVA: 0x00AAE4BC File Offset: 0x00AAC6BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202FB RID: 131835 RVA: 0x00AAE510 File Offset: 0x00AAC710
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRECToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerInfoUIController.m_luaExportHelper.OnRECToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202FC RID: 131836 RVA: 0x00AAE56C File Offset: 0x00AAC76C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnUserCenterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnUserCenterButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202FD RID: 131837 RVA: 0x00AAE5C0 File Offset: 0x00AAC7C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnPlayerCenterButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnPlayerCenterButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202FE RID: 131838 RVA: 0x00AAE614 File Offset: 0x00AAC814
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSignButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnSignButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202FF RID: 131839 RVA: 0x00AAE668 File Offset: 0x00AAC868
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSettingButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnSettingButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020300 RID: 131840 RVA: 0x00AAE6BC File Offset: 0x00AAC8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeNameButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnChangeNameButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020301 RID: 131841 RVA: 0x00AAE710 File Offset: 0x00AAC910
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ChangeNameInputField_OnEndEdit(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string str;
			LuaObject.checkType(l, 2, out str);
			playerInfoUIController.m_luaExportHelper.ChangeNameInputField_OnEndEdit(str);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020302 RID: 131842 RVA: 0x00AAE76C File Offset: 0x00AAC96C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnWatchMyBusinessCardButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnWatchMyBusinessCardButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020303 RID: 131843 RVA: 0x00AAE7C0 File Offset: 0x00AAC9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnConfirmChangeNameButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnConfirmChangeNameButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020304 RID: 131844 RVA: 0x00AAE814 File Offset: 0x00AACA14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnCopyButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnCopyButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020305 RID: 131845 RVA: 0x00AAE868 File Offset: 0x00AACA68
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnVoicePackageButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnVoicePackageButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020306 RID: 131846 RVA: 0x00AAE8BC File Offset: 0x00AACABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnChangeIconButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020307 RID: 131847 RVA: 0x00AAE910 File Offset: 0x00AACB10
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRedeemCodeButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnRedeemCodeButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020308 RID: 131848 RVA: 0x00AAE964 File Offset: 0x00AACB64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRedemptionCodeConfirmButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnRedemptionCodeConfirmButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020309 RID: 131849 RVA: 0x00AAE9B8 File Offset: 0x00AACBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnRedemptionCodeCancelButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnRedemptionCodeCancelButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602030A RID: 131850 RVA: 0x00AAEA0C File Offset: 0x00AACC0C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnForumButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnForumButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602030B RID: 131851 RVA: 0x00AAEA60 File Offset: 0x00AACC60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeAccountButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.OnChangeAccountButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602030C RID: 131852 RVA: 0x00AAEAB4 File Offset: 0x00AACCB4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerInfoUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602030D RID: 131853 RVA: 0x00AAEB20 File Offset: 0x00AACD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602030E RID: 131854 RVA: 0x00AAEB74 File Offset: 0x00AACD74
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602030F RID: 131855 RVA: 0x00AAEBC8 File Offset: 0x00AACDC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerInfoUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020310 RID: 131856 RVA: 0x00AAEC70 File Offset: 0x00AACE70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020311 RID: 131857 RVA: 0x00AAECC4 File Offset: 0x00AACEC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerInfoUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020312 RID: 131858 RVA: 0x00AAED30 File Offset: 0x00AACF30
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
				PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerInfoUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerInfoUIController playerInfoUIController2 = (PlayerInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerInfoUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06020313 RID: 131859 RVA: 0x00AAEE40 File Offset: 0x00AAD040
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020314 RID: 131860 RVA: 0x00AAEEAC File Offset: 0x00AAD0AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020315 RID: 131861 RVA: 0x00AAEF18 File Offset: 0x00AAD118
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020316 RID: 131862 RVA: 0x00AAEF84 File Offset: 0x00AAD184
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020317 RID: 131863 RVA: 0x00AAEFF0 File Offset: 0x00AAD1F0
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
				PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerInfoUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerInfoUIController playerInfoUIController2 = (PlayerInfoUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerInfoUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06020318 RID: 131864 RVA: 0x00AAF100 File Offset: 0x00AAD300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string s = playerInfoUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020319 RID: 131865 RVA: 0x00AAF15C File Offset: 0x00AAD35C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowChangeIconPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnShowChangeIconPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602031A RID: 131866 RVA: 0x00AAF1B0 File Offset: 0x00AAD3B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowChangeIconPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnShowChangeIconPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602031B RID: 131867 RVA: 0x00AAF204 File Offset: 0x00AAD404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnChangeHeadPortraitAndHeadFrame(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602031C RID: 131868 RVA: 0x00AAF270 File Offset: 0x00AAD470
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnChangeHeadPortraitAndHeadFrame(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602031D RID: 131869 RVA: 0x00AAF2DC File Offset: 0x00AAD4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeName(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnChangeName(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602031E RID: 131870 RVA: 0x00AAF338 File Offset: 0x00AAD538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeName(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string obj;
			LuaObject.checkType(l, 2, out obj);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnChangeName(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602031F RID: 131871 RVA: 0x00AAF394 File Offset: 0x00AAD594
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowSign(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnShowSign();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020320 RID: 131872 RVA: 0x00AAF3E8 File Offset: 0x00AAD5E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowSign(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnShowSign();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020321 RID: 131873 RVA: 0x00AAF43C File Offset: 0x00AAD63C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020322 RID: 131874 RVA: 0x00AAF490 File Offset: 0x00AAD690
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020323 RID: 131875 RVA: 0x00AAF4E4 File Offset: 0x00AAD6E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnShowPlayerSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020324 RID: 131876 RVA: 0x00AAF538 File Offset: 0x00AAD738
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnShowPlayerSetting();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020325 RID: 131877 RVA: 0x00AAF58C File Offset: 0x00AAD78C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnShowMyBusinessCard(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnShowMyBusinessCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020326 RID: 131878 RVA: 0x00AAF5E0 File Offset: 0x00AAD7E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnShowMyBusinessCard(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnShowMyBusinessCard();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020327 RID: 131879 RVA: 0x00AAF634 File Offset: 0x00AAD834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeRECState(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnChangeRECState(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020328 RID: 131880 RVA: 0x00AAF690 File Offset: 0x00AAD890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeRECState(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			bool obj;
			LuaObject.checkType(l, 2, out obj);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnChangeRECState(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020329 RID: 131881 RVA: 0x00AAF6EC File Offset: 0x00AAD8EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnRedemptionCodeUse(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action<int> arg2;
			LuaObject.checkDelegate<Action<int>>(l, 3, out arg2);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnRedemptionCodeUse(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602032A RID: 131882 RVA: 0x00AAF758 File Offset: 0x00AAD958
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnRedemptionCodeUse(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			string arg;
			LuaObject.checkType(l, 2, out arg);
			Action<int> arg2;
			LuaObject.checkDelegate<Action<int>>(l, 3, out arg2);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnRedemptionCodeUse(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602032B RID: 131883 RVA: 0x00AAF7C4 File Offset: 0x00AAD9C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__callDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602032C RID: 131884 RVA: 0x00AAF818 File Offset: 0x00AADA18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			playerInfoUIController.m_luaExportHelper.__clearDele_EventOnCrystalNotEnough();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602032D RID: 131885 RVA: 0x00AAF86C File Offset: 0x00AADA6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowChangeIconPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnShowChangeIconPanel += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnShowChangeIconPanel -= value;
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

	// Token: 0x0602032E RID: 131886 RVA: 0x00AAF8EC File Offset: 0x00AADAEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnChangeHeadPortraitAndHeadFrame += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnChangeHeadPortraitAndHeadFrame -= value;
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

	// Token: 0x0602032F RID: 131887 RVA: 0x00AAF96C File Offset: 0x00AADB6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeName(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action<string> value;
			int num = LuaObject.checkDelegate<Action<string>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnChangeName += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnChangeName -= value;
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

	// Token: 0x06020330 RID: 131888 RVA: 0x00AAF9EC File Offset: 0x00AADBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowSign(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnShowSign += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnShowSign -= value;
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

	// Token: 0x06020331 RID: 131889 RVA: 0x00AAFA6C File Offset: 0x00AADC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnClose -= value;
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

	// Token: 0x06020332 RID: 131890 RVA: 0x00AAFAEC File Offset: 0x00AADCEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowPlayerSetting(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnShowPlayerSetting += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnShowPlayerSetting -= value;
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

	// Token: 0x06020333 RID: 131891 RVA: 0x00AAFB6C File Offset: 0x00AADD6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnShowMyBusinessCard(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnShowMyBusinessCard += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnShowMyBusinessCard -= value;
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

	// Token: 0x06020334 RID: 131892 RVA: 0x00AAFBEC File Offset: 0x00AADDEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeRECState(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action<bool> value;
			int num = LuaObject.checkDelegate<Action<bool>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnChangeRECState += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnChangeRECState -= value;
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

	// Token: 0x06020335 RID: 131893 RVA: 0x00AAFC6C File Offset: 0x00AADE6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnRedemptionCodeUse(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action<string, Action<int>> value;
			int num = LuaObject.checkDelegate<Action<string, Action<int>>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnRedemptionCodeUse += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnRedemptionCodeUse -= value;
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

	// Token: 0x06020336 RID: 131894 RVA: 0x00AAFCEC File Offset: 0x00AADEEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnCrystalNotEnough(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoUIController.EventOnCrystalNotEnough += value;
				}
				else if (num == 2)
				{
					playerInfoUIController.EventOnCrystalNotEnough -= value;
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

	// Token: 0x06020337 RID: 131895 RVA: 0x00AAFD6C File Offset: 0x00AADF6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerInfoContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerInfoContentStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020338 RID: 131896 RVA: 0x00AAFDC4 File Offset: 0x00AADFC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerInfoContentStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController playerInfoContentStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out playerInfoContentStateCtrl);
			playerInfoUIController.m_luaExportHelper.m_playerInfoContentStateCtrl = playerInfoContentStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020339 RID: 131897 RVA: 0x00AAFE20 File Offset: 0x00AAE020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_closeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602033A RID: 131898 RVA: 0x00AAFE78 File Offset: 0x00AAE078
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_closeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button closeButton;
			LuaObject.checkType<Button>(l, 2, out closeButton);
			playerInfoUIController.m_luaExportHelper.m_closeButton = closeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602033B RID: 131899 RVA: 0x00AAFED4 File Offset: 0x00AAE0D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_bgButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602033C RID: 131900 RVA: 0x00AAFF2C File Offset: 0x00AAE12C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_bgButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button bgButton;
			LuaObject.checkType<Button>(l, 2, out bgButton);
			playerInfoUIController.m_luaExportHelper.m_bgButton = bgButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602033D RID: 131901 RVA: 0x00AAFF88 File Offset: 0x00AAE188
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeIconButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeIconButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602033E RID: 131902 RVA: 0x00AAFFE0 File Offset: 0x00AAE1E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeIconButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button changeIconButton;
			LuaObject.checkType<Button>(l, 2, out changeIconButton);
			playerInfoUIController.m_luaExportHelper.m_changeIconButton = changeIconButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602033F RID: 131903 RVA: 0x00AB003C File Offset: 0x00AAE23C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNameButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeNameButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020340 RID: 131904 RVA: 0x00AB0094 File Offset: 0x00AAE294
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNameButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button changeNameButton;
			LuaObject.checkType<Button>(l, 2, out changeNameButton);
			playerInfoUIController.m_luaExportHelper.m_changeNameButton = changeNameButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020341 RID: 131905 RVA: 0x00AB00F0 File Offset: 0x00AAE2F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_watchMyBusinessCardButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_watchMyBusinessCardButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020342 RID: 131906 RVA: 0x00AB0148 File Offset: 0x00AAE348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_watchMyBusinessCardButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button watchMyBusinessCardButton;
			LuaObject.checkType<Button>(l, 2, out watchMyBusinessCardButton);
			playerInfoUIController.m_luaExportHelper.m_watchMyBusinessCardButton = watchMyBusinessCardButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020343 RID: 131907 RVA: 0x00AB01A4 File Offset: 0x00AAE3A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_copyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_copyButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020344 RID: 131908 RVA: 0x00AB01FC File Offset: 0x00AAE3FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_copyButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button copyButton;
			LuaObject.checkType<Button>(l, 2, out copyButton);
			playerInfoUIController.m_luaExportHelper.m_copyButton = copyButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020345 RID: 131909 RVA: 0x00AB0258 File Offset: 0x00AAE458
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_signButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_signButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020346 RID: 131910 RVA: 0x00AB02B0 File Offset: 0x00AAE4B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_signButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button signButton;
			LuaObject.checkType<Button>(l, 2, out signButton);
			playerInfoUIController.m_luaExportHelper.m_signButton = signButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020347 RID: 131911 RVA: 0x00AB030C File Offset: 0x00AAE50C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_settingButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_settingButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020348 RID: 131912 RVA: 0x00AB0364 File Offset: 0x00AAE564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_settingButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button settingButton;
			LuaObject.checkType<Button>(l, 2, out settingButton);
			playerInfoUIController.m_luaExportHelper.m_settingButton = settingButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020349 RID: 131913 RVA: 0x00AB03C0 File Offset: 0x00AAE5C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_recToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_recToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602034A RID: 131914 RVA: 0x00AB0418 File Offset: 0x00AAE618
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_recToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Toggle recToggle;
			LuaObject.checkType<Toggle>(l, 2, out recToggle);
			playerInfoUIController.m_luaExportHelper.m_recToggle = recToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602034B RID: 131915 RVA: 0x00AB0474 File Offset: 0x00AAE674
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerIconImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602034C RID: 131916 RVA: 0x00AB04CC File Offset: 0x00AAE6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerIconImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Image playerIconImage;
			LuaObject.checkType<Image>(l, 2, out playerIconImage);
			playerInfoUIController.m_luaExportHelper.m_playerIconImage = playerIconImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602034D RID: 131917 RVA: 0x00AB0528 File Offset: 0x00AAE728
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_headFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602034E RID: 131918 RVA: 0x00AB0580 File Offset: 0x00AAE780
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Transform headFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out headFrameTransform);
			playerInfoUIController.m_luaExportHelper.m_headFrameTransform = headFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602034F RID: 131919 RVA: 0x00AB05DC File Offset: 0x00AAE7DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020350 RID: 131920 RVA: 0x00AB0634 File Offset: 0x00AAE834
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			playerInfoUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020351 RID: 131921 RVA: 0x00AB0690 File Offset: 0x00AAE890
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020352 RID: 131922 RVA: 0x00AB06E8 File Offset: 0x00AAE8E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Text playerLevelText;
			LuaObject.checkType<Text>(l, 2, out playerLevelText);
			playerInfoUIController.m_luaExportHelper.m_playerLevelText = playerLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020353 RID: 131923 RVA: 0x00AB0744 File Offset: 0x00AAE944
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpProgressText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerExpProgressText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020354 RID: 131924 RVA: 0x00AB079C File Offset: 0x00AAE99C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpProgressText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Text playerExpProgressText;
			LuaObject.checkType<Text>(l, 2, out playerExpProgressText);
			playerInfoUIController.m_luaExportHelper.m_playerExpProgressText = playerExpProgressText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020355 RID: 131925 RVA: 0x00AB07F8 File Offset: 0x00AAE9F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerExpProgressImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerExpProgressImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020356 RID: 131926 RVA: 0x00AB0850 File Offset: 0x00AAEA50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerExpProgressImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Image playerExpProgressImage;
			LuaObject.checkType<Image>(l, 2, out playerExpProgressImage);
			playerInfoUIController.m_luaExportHelper.m_playerExpProgressImage = playerExpProgressImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020357 RID: 131927 RVA: 0x00AB08AC File Offset: 0x00AAEAAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userIDText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_userIDText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020358 RID: 131928 RVA: 0x00AB0904 File Offset: 0x00AAEB04
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userIDText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Text userIDText;
			LuaObject.checkType<Text>(l, 2, out userIDText);
			playerInfoUIController.m_luaExportHelper.m_userIDText = userIDText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020359 RID: 131929 RVA: 0x00AB0960 File Offset: 0x00AAEB60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_versionText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_versionText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602035A RID: 131930 RVA: 0x00AB09B8 File Offset: 0x00AAEBB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_versionText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Text versionText;
			LuaObject.checkType<Text>(l, 2, out versionText);
			playerInfoUIController.m_luaExportHelper.m_versionText = versionText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602035B RID: 131931 RVA: 0x00AB0A14 File Offset: 0x00AAEC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNameStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeNameStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602035C RID: 131932 RVA: 0x00AB0A6C File Offset: 0x00AAEC6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNameStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController changeNameStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out changeNameStateCtrl);
			playerInfoUIController.m_luaExportHelper.m_changeNameStateCtrl = changeNameStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602035D RID: 131933 RVA: 0x00AB0AC8 File Offset: 0x00AAECC8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNameInputField(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeNameInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602035E RID: 131934 RVA: 0x00AB0B20 File Offset: 0x00AAED20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNameInputField(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			InputField changeNameInputField;
			LuaObject.checkType<InputField>(l, 2, out changeNameInputField);
			playerInfoUIController.m_luaExportHelper.m_changeNameInputField = changeNameInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602035F RID: 131935 RVA: 0x00AB0B7C File Offset: 0x00AAED7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNamePriceImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeNamePriceImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020360 RID: 131936 RVA: 0x00AB0BD4 File Offset: 0x00AAEDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNamePriceImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Image changeNamePriceImage;
			LuaObject.checkType<Image>(l, 2, out changeNamePriceImage);
			playerInfoUIController.m_luaExportHelper.m_changeNamePriceImage = changeNamePriceImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020361 RID: 131937 RVA: 0x00AB0C30 File Offset: 0x00AAEE30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNamePriceText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeNamePriceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020362 RID: 131938 RVA: 0x00AB0C88 File Offset: 0x00AAEE88
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNamePriceText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Text changeNamePriceText;
			LuaObject.checkType<Text>(l, 2, out changeNamePriceText);
			playerInfoUIController.m_luaExportHelper.m_changeNamePriceText = changeNamePriceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020363 RID: 131939 RVA: 0x00AB0CE4 File Offset: 0x00AAEEE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeNamePanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeNamePanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020364 RID: 131940 RVA: 0x00AB0D3C File Offset: 0x00AAEF3C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeNamePanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button changeNamePanelBGButton;
			LuaObject.checkType<Button>(l, 2, out changeNamePanelBGButton);
			playerInfoUIController.m_luaExportHelper.m_changeNamePanelBGButton = changeNamePanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020365 RID: 131941 RVA: 0x00AB0D98 File Offset: 0x00AAEF98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmChangeNameButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_confirmChangeNameButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020366 RID: 131942 RVA: 0x00AB0DF0 File Offset: 0x00AAEFF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmChangeNameButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button confirmChangeNameButton;
			LuaObject.checkType<Button>(l, 2, out confirmChangeNameButton);
			playerInfoUIController.m_luaExportHelper.m_confirmChangeNameButton = confirmChangeNameButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020367 RID: 131943 RVA: 0x00AB0E4C File Offset: 0x00AAF04C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_voicePackageButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_voicePackageButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020368 RID: 131944 RVA: 0x00AB0EA4 File Offset: 0x00AAF0A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_voicePackageButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button voicePackageButton;
			LuaObject.checkType<Button>(l, 2, out voicePackageButton);
			playerInfoUIController.m_luaExportHelper.m_voicePackageButton = voicePackageButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020369 RID: 131945 RVA: 0x00AB0F00 File Offset: 0x00AAF100
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redeemCodeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_redeemCodeButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602036A RID: 131946 RVA: 0x00AB0F58 File Offset: 0x00AAF158
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redeemCodeButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button redeemCodeButton;
			LuaObject.checkType<Button>(l, 2, out redeemCodeButton);
			playerInfoUIController.m_luaExportHelper.m_redeemCodeButton = redeemCodeButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602036B RID: 131947 RVA: 0x00AB0FB4 File Offset: 0x00AAF1B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_forumButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_forumButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602036C RID: 131948 RVA: 0x00AB100C File Offset: 0x00AAF20C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_forumButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button forumButton;
			LuaObject.checkType<Button>(l, 2, out forumButton);
			playerInfoUIController.m_luaExportHelper.m_forumButton = forumButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602036D RID: 131949 RVA: 0x00AB1068 File Offset: 0x00AAF268
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeAccountButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeAccountButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602036E RID: 131950 RVA: 0x00AB10C0 File Offset: 0x00AAF2C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeAccountButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button changeAccountButton;
			LuaObject.checkType<Button>(l, 2, out changeAccountButton);
			playerInfoUIController.m_luaExportHelper.m_changeAccountButton = changeAccountButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602036F RID: 131951 RVA: 0x00AB111C File Offset: 0x00AAF31C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_userCenterButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_userCenterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020370 RID: 131952 RVA: 0x00AB1174 File Offset: 0x00AAF374
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_userCenterButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button userCenterButton;
			LuaObject.checkType<Button>(l, 2, out userCenterButton);
			playerInfoUIController.m_luaExportHelper.m_userCenterButton = userCenterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020371 RID: 131953 RVA: 0x00AB11D0 File Offset: 0x00AAF3D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerCenterButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerCenterButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020372 RID: 131954 RVA: 0x00AB1228 File Offset: 0x00AAF428
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerCenterButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button playerCenterButton;
			LuaObject.checkType<Button>(l, 2, out playerCenterButton);
			playerInfoUIController.m_luaExportHelper.m_playerCenterButton = playerCenterButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020373 RID: 131955 RVA: 0x00AB1284 File Offset: 0x00AAF484
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redemptionCodePanelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_redemptionCodePanelUIStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020374 RID: 131956 RVA: 0x00AB12DC File Offset: 0x00AAF4DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redemptionCodePanelUIStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			CommonUIStateController redemptionCodePanelUIStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out redemptionCodePanelUIStateCtrl);
			playerInfoUIController.m_luaExportHelper.m_redemptionCodePanelUIStateCtrl = redemptionCodePanelUIStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020375 RID: 131957 RVA: 0x00AB1338 File Offset: 0x00AAF538
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redemptionCodeReturnButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_redemptionCodeReturnButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020376 RID: 131958 RVA: 0x00AB1390 File Offset: 0x00AAF590
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redemptionCodeReturnButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button redemptionCodeReturnButton;
			LuaObject.checkType<Button>(l, 2, out redemptionCodeReturnButton);
			playerInfoUIController.m_luaExportHelper.m_redemptionCodeReturnButton = redemptionCodeReturnButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020377 RID: 131959 RVA: 0x00AB13EC File Offset: 0x00AAF5EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redemptionCodeInputField(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_redemptionCodeInputField);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020378 RID: 131960 RVA: 0x00AB1444 File Offset: 0x00AAF644
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redemptionCodeInputField(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			InputField redemptionCodeInputField;
			LuaObject.checkType<InputField>(l, 2, out redemptionCodeInputField);
			playerInfoUIController.m_luaExportHelper.m_redemptionCodeInputField = redemptionCodeInputField;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020379 RID: 131961 RVA: 0x00AB14A0 File Offset: 0x00AAF6A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redemptionCodeCancelButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_redemptionCodeCancelButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602037A RID: 131962 RVA: 0x00AB14F8 File Offset: 0x00AAF6F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redemptionCodeCancelButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button redemptionCodeCancelButton;
			LuaObject.checkType<Button>(l, 2, out redemptionCodeCancelButton);
			playerInfoUIController.m_luaExportHelper.m_redemptionCodeCancelButton = redemptionCodeCancelButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602037B RID: 131963 RVA: 0x00AB1554 File Offset: 0x00AAF754
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_redemptionCodeConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_redemptionCodeConfirmButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602037C RID: 131964 RVA: 0x00AB15AC File Offset: 0x00AAF7AC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_redemptionCodeConfirmButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			Button redemptionCodeConfirmButton;
			LuaObject.checkType<Button>(l, 2, out redemptionCodeConfirmButton);
			playerInfoUIController.m_luaExportHelper.m_redemptionCodeConfirmButton = redemptionCodeConfirmButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602037D RID: 131965 RVA: 0x00AB1608 File Offset: 0x00AAF808
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeHeadIconPanelGameObj(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_changeHeadIconPanelGameObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602037E RID: 131966 RVA: 0x00AB1660 File Offset: 0x00AAF860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeHeadIconPanelGameObj(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			GameObject changeHeadIconPanelGameObj;
			LuaObject.checkType<GameObject>(l, 2, out changeHeadIconPanelGameObj);
			playerInfoUIController.m_luaExportHelper.m_changeHeadIconPanelGameObj = changeHeadIconPanelGameObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602037F RID: 131967 RVA: 0x00AB16BC File Offset: 0x00AAF8BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeadPortraitPrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerHeadPortraitPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020380 RID: 131968 RVA: 0x00AB1714 File Offset: 0x00AAF914
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeadPortraitPrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			GameObject playerHeadPortraitPrefab;
			LuaObject.checkType<GameObject>(l, 2, out playerHeadPortraitPrefab);
			playerInfoUIController.m_luaExportHelper.m_playerHeadPortraitPrefab = playerHeadPortraitPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020381 RID: 131969 RVA: 0x00AB1770 File Offset: 0x00AAF970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerHeadFramePrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerHeadFramePrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020382 RID: 131970 RVA: 0x00AB17C8 File Offset: 0x00AAF9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerHeadFramePrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			GameObject playerHeadFramePrefab;
			LuaObject.checkType<GameObject>(l, 2, out playerHeadFramePrefab);
			playerInfoUIController.m_luaExportHelper.m_playerHeadFramePrefab = playerHeadFramePrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020383 RID: 131971 RVA: 0x00AB1824 File Offset: 0x00AAFA24
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headIconUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_headIconUIController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020384 RID: 131972 RVA: 0x00AB187C File Offset: 0x00AAFA7C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headIconUIController(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			PlayerInfoHeadIconUIController headIconUIController;
			LuaObject.checkType<PlayerInfoHeadIconUIController>(l, 2, out headIconUIController);
			playerInfoUIController.m_luaExportHelper.m_headIconUIController = headIconUIController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020385 RID: 131973 RVA: 0x00AB18D8 File Offset: 0x00AAFAD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020386 RID: 131974 RVA: 0x00AB1930 File Offset: 0x00AAFB30
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			ClientConfigDataLoader configDataLoader;
			LuaObject.checkType<ClientConfigDataLoader>(l, 2, out configDataLoader);
			playerInfoUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020387 RID: 131975 RVA: 0x00AB198C File Offset: 0x00AAFB8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020388 RID: 131976 RVA: 0x00AB19E4 File Offset: 0x00AAFBE4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerInfoUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020389 RID: 131977 RVA: 0x00AB1A40 File Offset: 0x00AAFC40
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameLimit(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoUIController.m_luaExportHelper.m_playerNameLimit);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602038A RID: 131978 RVA: 0x00AB1A98 File Offset: 0x00AAFC98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameLimit(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoUIController playerInfoUIController = (PlayerInfoUIController)LuaObject.checkSelf(l);
			int playerNameLimit;
			LuaObject.checkType(l, 2, out playerNameLimit);
			playerInfoUIController.m_luaExportHelper.m_playerNameLimit = playerNameLimit;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602038B RID: 131979 RVA: 0x00AB1AF4 File Offset: 0x00AAFCF4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerInfoUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.UpdateViewInPlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.SetPlayerNameLimit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.PlayerInfoOpenTween);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnChangeNamePanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.ShowChangeHeadIconPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnChangeIconPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.SetChangeNamePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnRECToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnUserCenterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnPlayerCenterButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnSignButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnSettingButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnChangeNameButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.ChangeNameInputField_OnEndEdit);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnWatchMyBusinessCardButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnConfirmChangeNameButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnCopyButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnVoicePackageButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnChangeIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnRedeemCodeButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnRedemptionCodeConfirmButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnRedemptionCodeCancelButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnForumButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.OnChangeAccountButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1A);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1B);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1C);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1D);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1E);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache1F);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache20);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache21);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache22);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache23);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache24);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache25);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache26);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnShowChangeIconPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache27);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnShowChangeIconPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache28);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache29);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2A);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnChangeName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2B);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnChangeName);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2C);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnShowSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2D);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnShowSign);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2E);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache2F);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache30);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnShowPlayerSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache31);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnShowPlayerSetting);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache32);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnShowMyBusinessCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache33);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnShowMyBusinessCard);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache34);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnChangeRECState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache35);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnChangeRECState);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache36);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnRedemptionCodeUse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache37);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnRedemptionCodeUse);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache38);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__callDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache39);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.__clearDele_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3A);
		string name = "EventOnShowChangeIconPanel";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnShowChangeIconPanel);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3B, true);
		string name2 = "EventOnChangeHeadPortraitAndHeadFrame";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3C, true);
		string name3 = "EventOnChangeName";
		LuaCSFunction get3 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnChangeName);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3D, true);
		string name4 = "EventOnShowSign";
		LuaCSFunction get4 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnShowSign);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3E, true);
		string name5 = "EventOnClose";
		LuaCSFunction get5 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache3F, true);
		string name6 = "EventOnShowPlayerSetting";
		LuaCSFunction get6 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnShowPlayerSetting);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache40, true);
		string name7 = "EventOnShowMyBusinessCard";
		LuaCSFunction get7 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnShowMyBusinessCard);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache41, true);
		string name8 = "EventOnChangeRECState";
		LuaCSFunction get8 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnChangeRECState);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache42, true);
		string name9 = "EventOnRedemptionCodeUse";
		LuaCSFunction get9 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnRedemptionCodeUse);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache43, true);
		string name10 = "EventOnCrystalNotEnough";
		LuaCSFunction get10 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache44 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache44 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_EventOnCrystalNotEnough);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache44, true);
		string name11 = "m_playerInfoContentStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache45 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache45 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerInfoContentStateCtrl);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache45;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache46 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache46 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerInfoContentStateCtrl);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache46, true);
		string name12 = "m_closeButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache47 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache47 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_closeButton);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache47;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache48 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache48 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_closeButton);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache48, true);
		string name13 = "m_bgButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache49 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache49 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_bgButton);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache49;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_bgButton);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4A, true);
		string name14 = "m_changeIconButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeIconButton);
		}
		LuaCSFunction get14 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeIconButton);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4C, true);
		string name15 = "m_changeNameButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeNameButton);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeNameButton);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4E, true);
		string name16 = "m_watchMyBusinessCardButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_watchMyBusinessCardButton);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache4F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache50 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache50 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_watchMyBusinessCardButton);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache50, true);
		string name17 = "m_copyButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache51 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache51 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_copyButton);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache51;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache52 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache52 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_copyButton);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache52, true);
		string name18 = "m_signButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache53 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache53 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_signButton);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache53;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache54 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache54 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_signButton);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache54, true);
		string name19 = "m_settingButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache55 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache55 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_settingButton);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache55;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache56 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache56 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_settingButton);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache56, true);
		string name20 = "m_recToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache57 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache57 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_recToggle);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache57;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache58 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache58 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_recToggle);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache58, true);
		string name21 = "m_playerIconImage";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache59 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache59 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerIconImage);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache59;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerIconImage);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5A, true);
		string name22 = "m_headFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_headFrameTransform);
		}
		LuaCSFunction get22 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_headFrameTransform);
		}
		LuaObject.addMember(l, name22, get22, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5C, true);
		string name23 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerNameText);
		}
		LuaCSFunction get23 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name23, get23, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5E, true);
		string name24 = "m_playerLevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerLevelText);
		}
		LuaCSFunction get24 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache5F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache60 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache60 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerLevelText);
		}
		LuaObject.addMember(l, name24, get24, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache60, true);
		string name25 = "m_playerExpProgressText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache61 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache61 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerExpProgressText);
		}
		LuaCSFunction get25 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache61;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache62 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache62 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerExpProgressText);
		}
		LuaObject.addMember(l, name25, get25, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache62, true);
		string name26 = "m_playerExpProgressImage";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache63 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache63 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerExpProgressImage);
		}
		LuaCSFunction get26 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache63;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache64 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache64 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerExpProgressImage);
		}
		LuaObject.addMember(l, name26, get26, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache64, true);
		string name27 = "m_userIDText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache65 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache65 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_userIDText);
		}
		LuaCSFunction get27 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache65;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache66 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache66 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_userIDText);
		}
		LuaObject.addMember(l, name27, get27, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache66, true);
		string name28 = "m_versionText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache67 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache67 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_versionText);
		}
		LuaCSFunction get28 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache67;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache68 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache68 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_versionText);
		}
		LuaObject.addMember(l, name28, get28, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache68, true);
		string name29 = "m_changeNameStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache69 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache69 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeNameStateCtrl);
		}
		LuaCSFunction get29 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache69;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeNameStateCtrl);
		}
		LuaObject.addMember(l, name29, get29, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6A, true);
		string name30 = "m_changeNameInputField";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeNameInputField);
		}
		LuaCSFunction get30 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeNameInputField);
		}
		LuaObject.addMember(l, name30, get30, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6C, true);
		string name31 = "m_changeNamePriceImage";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeNamePriceImage);
		}
		LuaCSFunction get31 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeNamePriceImage);
		}
		LuaObject.addMember(l, name31, get31, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6E, true);
		string name32 = "m_changeNamePriceText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeNamePriceText);
		}
		LuaCSFunction get32 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache6F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache70 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache70 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeNamePriceText);
		}
		LuaObject.addMember(l, name32, get32, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache70, true);
		string name33 = "m_changeNamePanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache71 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache71 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeNamePanelBGButton);
		}
		LuaCSFunction get33 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache71;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache72 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache72 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeNamePanelBGButton);
		}
		LuaObject.addMember(l, name33, get33, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache72, true);
		string name34 = "m_confirmChangeNameButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache73 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache73 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_confirmChangeNameButton);
		}
		LuaCSFunction get34 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache73;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache74 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache74 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_confirmChangeNameButton);
		}
		LuaObject.addMember(l, name34, get34, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache74, true);
		string name35 = "m_voicePackageButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache75 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache75 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_voicePackageButton);
		}
		LuaCSFunction get35 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache75;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache76 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache76 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_voicePackageButton);
		}
		LuaObject.addMember(l, name35, get35, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache76, true);
		string name36 = "m_redeemCodeButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache77 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache77 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_redeemCodeButton);
		}
		LuaCSFunction get36 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache77;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache78 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache78 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_redeemCodeButton);
		}
		LuaObject.addMember(l, name36, get36, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache78, true);
		string name37 = "m_forumButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache79 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache79 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_forumButton);
		}
		LuaCSFunction get37 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache79;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_forumButton);
		}
		LuaObject.addMember(l, name37, get37, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7A, true);
		string name38 = "m_changeAccountButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeAccountButton);
		}
		LuaCSFunction get38 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeAccountButton);
		}
		LuaObject.addMember(l, name38, get38, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7C, true);
		string name39 = "m_userCenterButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_userCenterButton);
		}
		LuaCSFunction get39 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_userCenterButton);
		}
		LuaObject.addMember(l, name39, get39, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7E, true);
		string name40 = "m_playerCenterButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerCenterButton);
		}
		LuaCSFunction get40 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache7F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache80 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache80 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerCenterButton);
		}
		LuaObject.addMember(l, name40, get40, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache80, true);
		string name41 = "m_redemptionCodePanelUIStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache81 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache81 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_redemptionCodePanelUIStateCtrl);
		}
		LuaCSFunction get41 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache81;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache82 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache82 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_redemptionCodePanelUIStateCtrl);
		}
		LuaObject.addMember(l, name41, get41, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache82, true);
		string name42 = "m_redemptionCodeReturnButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache83 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache83 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_redemptionCodeReturnButton);
		}
		LuaCSFunction get42 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache83;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache84 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache84 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_redemptionCodeReturnButton);
		}
		LuaObject.addMember(l, name42, get42, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache84, true);
		string name43 = "m_redemptionCodeInputField";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache85 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache85 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_redemptionCodeInputField);
		}
		LuaCSFunction get43 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache85;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache86 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache86 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_redemptionCodeInputField);
		}
		LuaObject.addMember(l, name43, get43, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache86, true);
		string name44 = "m_redemptionCodeCancelButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache87 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache87 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_redemptionCodeCancelButton);
		}
		LuaCSFunction get44 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache87;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache88 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache88 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_redemptionCodeCancelButton);
		}
		LuaObject.addMember(l, name44, get44, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache88, true);
		string name45 = "m_redemptionCodeConfirmButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache89 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache89 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_redemptionCodeConfirmButton);
		}
		LuaCSFunction get45 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache89;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_redemptionCodeConfirmButton);
		}
		LuaObject.addMember(l, name45, get45, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8A, true);
		string name46 = "m_changeHeadIconPanelGameObj";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_changeHeadIconPanelGameObj);
		}
		LuaCSFunction get46 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_changeHeadIconPanelGameObj);
		}
		LuaObject.addMember(l, name46, get46, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8C, true);
		string name47 = "m_playerHeadPortraitPrefab";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerHeadPortraitPrefab);
		}
		LuaCSFunction get47 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerHeadPortraitPrefab);
		}
		LuaObject.addMember(l, name47, get47, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8E, true);
		string name48 = "m_playerHeadFramePrefab";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerHeadFramePrefab);
		}
		LuaCSFunction get48 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache8F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache90 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache90 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerHeadFramePrefab);
		}
		LuaObject.addMember(l, name48, get48, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache90, true);
		string name49 = "m_headIconUIController";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache91 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache91 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_headIconUIController);
		}
		LuaCSFunction get49 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache91;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache92 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache92 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_headIconUIController);
		}
		LuaObject.addMember(l, name49, get49, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache92, true);
		string name50 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache93 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache93 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_configDataLoader);
		}
		LuaCSFunction get50 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache93;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache94 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache94 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name50, get50, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache94, true);
		string name51 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache95 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache95 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerContext);
		}
		LuaCSFunction get51 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache95;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache96 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache96 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name51, get51, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache96, true);
		string name52 = "m_playerNameLimit";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache97 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache97 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.get_m_playerNameLimit);
		}
		LuaCSFunction get52 = Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache97;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache98 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache98 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.set_m_playerNameLimit);
		}
		LuaObject.addMember(l, name52, get52, Lua_BlackJack_ProjectL_UI_PlayerInfoUIController.<>f__mg$cache98, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerInfoUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401627E RID: 90750
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401627F RID: 90751
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016280 RID: 90752
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016281 RID: 90753
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016282 RID: 90754
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016283 RID: 90755
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016284 RID: 90756
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016285 RID: 90757
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016286 RID: 90758
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016287 RID: 90759
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016288 RID: 90760
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016289 RID: 90761
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401628A RID: 90762
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401628B RID: 90763
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401628C RID: 90764
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401628D RID: 90765
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401628E RID: 90766
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401628F RID: 90767
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016290 RID: 90768
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016291 RID: 90769
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016292 RID: 90770
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016293 RID: 90771
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016294 RID: 90772
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016295 RID: 90773
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016296 RID: 90774
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016297 RID: 90775
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016298 RID: 90776
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016299 RID: 90777
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x0401629A RID: 90778
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401629B RID: 90779
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401629C RID: 90780
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401629D RID: 90781
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401629E RID: 90782
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401629F RID: 90783
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x040162A0 RID: 90784
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x040162A1 RID: 90785
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x040162A2 RID: 90786
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x040162A3 RID: 90787
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x040162A4 RID: 90788
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x040162A5 RID: 90789
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x040162A6 RID: 90790
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x040162A7 RID: 90791
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x040162A8 RID: 90792
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x040162A9 RID: 90793
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x040162AA RID: 90794
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x040162AB RID: 90795
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x040162AC RID: 90796
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x040162AD RID: 90797
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x040162AE RID: 90798
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x040162AF RID: 90799
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x040162B0 RID: 90800
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x040162B1 RID: 90801
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x040162B2 RID: 90802
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x040162B3 RID: 90803
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x040162B4 RID: 90804
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x040162B5 RID: 90805
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x040162B6 RID: 90806
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x040162B7 RID: 90807
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x040162B8 RID: 90808
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x040162B9 RID: 90809
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x040162BA RID: 90810
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x040162BB RID: 90811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x040162BC RID: 90812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x040162BD RID: 90813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x040162BE RID: 90814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x040162BF RID: 90815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x040162C0 RID: 90816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x040162C1 RID: 90817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;

	// Token: 0x040162C2 RID: 90818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache44;

	// Token: 0x040162C3 RID: 90819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache45;

	// Token: 0x040162C4 RID: 90820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache46;

	// Token: 0x040162C5 RID: 90821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache47;

	// Token: 0x040162C6 RID: 90822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache48;

	// Token: 0x040162C7 RID: 90823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache49;

	// Token: 0x040162C8 RID: 90824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4A;

	// Token: 0x040162C9 RID: 90825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4B;

	// Token: 0x040162CA RID: 90826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4C;

	// Token: 0x040162CB RID: 90827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4D;

	// Token: 0x040162CC RID: 90828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4E;

	// Token: 0x040162CD RID: 90829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4F;

	// Token: 0x040162CE RID: 90830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache50;

	// Token: 0x040162CF RID: 90831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache51;

	// Token: 0x040162D0 RID: 90832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache52;

	// Token: 0x040162D1 RID: 90833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache53;

	// Token: 0x040162D2 RID: 90834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache54;

	// Token: 0x040162D3 RID: 90835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache55;

	// Token: 0x040162D4 RID: 90836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache56;

	// Token: 0x040162D5 RID: 90837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache57;

	// Token: 0x040162D6 RID: 90838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache58;

	// Token: 0x040162D7 RID: 90839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache59;

	// Token: 0x040162D8 RID: 90840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5A;

	// Token: 0x040162D9 RID: 90841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5B;

	// Token: 0x040162DA RID: 90842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5C;

	// Token: 0x040162DB RID: 90843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5D;

	// Token: 0x040162DC RID: 90844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5E;

	// Token: 0x040162DD RID: 90845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5F;

	// Token: 0x040162DE RID: 90846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache60;

	// Token: 0x040162DF RID: 90847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache61;

	// Token: 0x040162E0 RID: 90848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache62;

	// Token: 0x040162E1 RID: 90849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache63;

	// Token: 0x040162E2 RID: 90850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache64;

	// Token: 0x040162E3 RID: 90851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache65;

	// Token: 0x040162E4 RID: 90852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache66;

	// Token: 0x040162E5 RID: 90853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache67;

	// Token: 0x040162E6 RID: 90854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache68;

	// Token: 0x040162E7 RID: 90855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache69;

	// Token: 0x040162E8 RID: 90856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6A;

	// Token: 0x040162E9 RID: 90857
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6B;

	// Token: 0x040162EA RID: 90858
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6C;

	// Token: 0x040162EB RID: 90859
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6D;

	// Token: 0x040162EC RID: 90860
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6E;

	// Token: 0x040162ED RID: 90861
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6F;

	// Token: 0x040162EE RID: 90862
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache70;

	// Token: 0x040162EF RID: 90863
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache71;

	// Token: 0x040162F0 RID: 90864
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache72;

	// Token: 0x040162F1 RID: 90865
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache73;

	// Token: 0x040162F2 RID: 90866
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache74;

	// Token: 0x040162F3 RID: 90867
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache75;

	// Token: 0x040162F4 RID: 90868
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache76;

	// Token: 0x040162F5 RID: 90869
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache77;

	// Token: 0x040162F6 RID: 90870
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache78;

	// Token: 0x040162F7 RID: 90871
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache79;

	// Token: 0x040162F8 RID: 90872
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7A;

	// Token: 0x040162F9 RID: 90873
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7B;

	// Token: 0x040162FA RID: 90874
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7C;

	// Token: 0x040162FB RID: 90875
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7D;

	// Token: 0x040162FC RID: 90876
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7E;

	// Token: 0x040162FD RID: 90877
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7F;

	// Token: 0x040162FE RID: 90878
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache80;

	// Token: 0x040162FF RID: 90879
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache81;

	// Token: 0x04016300 RID: 90880
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache82;

	// Token: 0x04016301 RID: 90881
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache83;

	// Token: 0x04016302 RID: 90882
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache84;

	// Token: 0x04016303 RID: 90883
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache85;

	// Token: 0x04016304 RID: 90884
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache86;

	// Token: 0x04016305 RID: 90885
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache87;

	// Token: 0x04016306 RID: 90886
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache88;

	// Token: 0x04016307 RID: 90887
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache89;

	// Token: 0x04016308 RID: 90888
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8A;

	// Token: 0x04016309 RID: 90889
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8B;

	// Token: 0x0401630A RID: 90890
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8C;

	// Token: 0x0401630B RID: 90891
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8D;

	// Token: 0x0401630C RID: 90892
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8E;

	// Token: 0x0401630D RID: 90893
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8F;

	// Token: 0x0401630E RID: 90894
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache90;

	// Token: 0x0401630F RID: 90895
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache91;

	// Token: 0x04016310 RID: 90896
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache92;

	// Token: 0x04016311 RID: 90897
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache93;

	// Token: 0x04016312 RID: 90898
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache94;

	// Token: 0x04016313 RID: 90899
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache95;

	// Token: 0x04016314 RID: 90900
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache96;

	// Token: 0x04016315 RID: 90901
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache97;

	// Token: 0x04016316 RID: 90902
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache98;
}
