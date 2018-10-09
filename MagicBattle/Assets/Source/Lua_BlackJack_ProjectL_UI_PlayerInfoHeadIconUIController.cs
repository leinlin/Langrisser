using System;
using System.Collections.Generic;
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

// Token: 0x02001528 RID: 5416
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController : LuaObject
{
	// Token: 0x0602028B RID: 131723 RVA: 0x00AAAD64 File Offset: 0x00AA8F64
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowChangeHeadIconPanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			GameObject headPortraitItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out headPortraitItemPrefab);
			GameObject headFrameItemPrefab;
			LuaObject.checkType<GameObject>(l, 3, out headFrameItemPrefab);
			playerInfoHeadIconUIController.ShowChangeHeadIconPanel(headPortraitItemPrefab, headFrameItemPrefab);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602028C RID: 131724 RVA: 0x00AAADC8 File Offset: 0x00AA8FC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int ChangeHeadIconTogglePanel(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			PlayerInfoHeadIconPanelType panelType;
			LuaObject.checkEnum<PlayerInfoHeadIconPanelType>(l, 2, out panelType);
			playerInfoHeadIconUIController.ChangeHeadIconTogglePanel(panelType);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602028D RID: 131725 RVA: 0x00AAAE20 File Offset: 0x00AA9020
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnChangeIconPanelCloseButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.OnChangeIconPanelCloseButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602028E RID: 131726 RVA: 0x00AAAE6C File Offset: 0x00AA906C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602028F RID: 131727 RVA: 0x00AAAEC0 File Offset: 0x00AA90C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateChangHeadIconPreview(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.UpdateChangHeadIconPreview();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020290 RID: 131728 RVA: 0x00AAAF14 File Offset: 0x00AA9114
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnConfirmChangeIconButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.OnConfirmChangeIconButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020291 RID: 131729 RVA: 0x00AAAF68 File Offset: 0x00AA9168
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int GetCurPanelType(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			PlayerInfoHeadIconPanelType curPanelType = playerInfoHeadIconUIController.m_luaExportHelper.GetCurPanelType();
			LuaObject.pushValue(l, true);
			LuaObject.pushEnum(l, (int)curPanelType);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020292 RID: 131730 RVA: 0x00AAAFC4 File Offset: 0x00AA91C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeadPortraitToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 3, out itemCtrl);
			playerInfoHeadIconUIController.m_luaExportHelper.OnHeadPortraitToggleValueChanged(isOn, itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020293 RID: 131731 RVA: 0x00AAB030 File Offset: 0x00AA9230
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int OnHeadFrameToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			UIControllerBase itemCtrl;
			LuaObject.checkType<UIControllerBase>(l, 3, out itemCtrl);
			playerInfoHeadIconUIController.m_luaExportHelper.OnHeadFrameToggleValueChanged(isOn, itemCtrl);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020294 RID: 131732 RVA: 0x00AAB09C File Offset: 0x00AA929C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeadFrameValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerInfoHeadIconUIController.m_luaExportHelper.OnHeadFrameValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020295 RID: 131733 RVA: 0x00AAB0F8 File Offset: 0x00AA92F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnHeadPortraitValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerInfoHeadIconUIController.m_luaExportHelper.OnHeadPortraitValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020296 RID: 131734 RVA: 0x00AAB154 File Offset: 0x00AA9354
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int CheckHeadFrameValid(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.CheckHeadFrameValid();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020297 RID: 131735 RVA: 0x00AAB1A8 File Offset: 0x00AA93A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020298 RID: 131736 RVA: 0x00AAB214 File Offset: 0x00AA9414
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020299 RID: 131737 RVA: 0x00AAB268 File Offset: 0x00AA9468
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602029A RID: 131738 RVA: 0x00AAB2BC File Offset: 0x00AA94BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerInfoHeadIconUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602029B RID: 131739 RVA: 0x00AAB364 File Offset: 0x00AA9564
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602029C RID: 131740 RVA: 0x00AAB3B8 File Offset: 0x00AA95B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602029D RID: 131741 RVA: 0x00AAB424 File Offset: 0x00AA9624
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonClickListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase>)))
			{
				PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerInfoHeadIconUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerInfoHeadIconUIController playerInfoHeadIconUIController2 = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerInfoHeadIconUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602029E RID: 131742 RVA: 0x00AAB534 File Offset: 0x00AA9734
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602029F RID: 131743 RVA: 0x00AAB5A0 File Offset: 0x00AA97A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A0 RID: 131744 RVA: 0x00AAB60C File Offset: 0x00AA980C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A1 RID: 131745 RVA: 0x00AAB678 File Offset: 0x00AA9878
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadIconUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A2 RID: 131746 RVA: 0x00AAB6E4 File Offset: 0x00AA98E4
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
				PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerInfoHeadIconUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerInfoHeadIconUIController playerInfoHeadIconUIController2 = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerInfoHeadIconUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060202A3 RID: 131747 RVA: 0x00AAB7F4 File Offset: 0x00AA99F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			string s = playerInfoHeadIconUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060202A4 RID: 131748 RVA: 0x00AAB850 File Offset: 0x00AA9A50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			playerInfoHeadIconUIController.m_luaExportHelper.__callDele_EventOnChangeHeadPortraitAndHeadFrame(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A5 RID: 131749 RVA: 0x00AAB8BC File Offset: 0x00AA9ABC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			int arg;
			LuaObject.checkType(l, 2, out arg);
			int arg2;
			LuaObject.checkType(l, 3, out arg2);
			playerInfoHeadIconUIController.m_luaExportHelper.__clearDele_EventOnChangeHeadPortraitAndHeadFrame(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A6 RID: 131750 RVA: 0x00AAB928 File Offset: 0x00AA9B28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_headFrameToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A7 RID: 131751 RVA: 0x00AAB980 File Offset: 0x00AA9B80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Toggle headFrameToggle;
			LuaObject.checkType<Toggle>(l, 2, out headFrameToggle);
			playerInfoHeadIconUIController.m_luaExportHelper.m_headFrameToggle = headFrameToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A8 RID: 131752 RVA: 0x00AAB9DC File Offset: 0x00AA9BDC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headPortraitToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_headPortraitToggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202A9 RID: 131753 RVA: 0x00AABA34 File Offset: 0x00AA9C34
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headPortraitToggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Toggle headPortraitToggle;
			LuaObject.checkType<Toggle>(l, 2, out headPortraitToggle);
			playerInfoHeadIconUIController.m_luaExportHelper.m_headPortraitToggle = headPortraitToggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202AA RID: 131754 RVA: 0x00AABA90 File Offset: 0x00AA9C90
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeHeadPortraitScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_changeHeadPortraitScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202AB RID: 131755 RVA: 0x00AABAE8 File Offset: 0x00AA9CE8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeHeadPortraitScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			GameObject changeHeadPortraitScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out changeHeadPortraitScrollViewContent);
			playerInfoHeadIconUIController.m_luaExportHelper.m_changeHeadPortraitScrollViewContent = changeHeadPortraitScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202AC RID: 131756 RVA: 0x00AABB44 File Offset: 0x00AA9D44
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeHeadFrameScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_changeHeadFrameScrollViewContent);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202AD RID: 131757 RVA: 0x00AABB9C File Offset: 0x00AA9D9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeHeadFrameScrollViewContent(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			GameObject changeHeadFrameScrollViewContent;
			LuaObject.checkType<GameObject>(l, 2, out changeHeadFrameScrollViewContent);
			playerInfoHeadIconUIController.m_luaExportHelper.m_changeHeadFrameScrollViewContent = changeHeadFrameScrollViewContent;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202AE RID: 131758 RVA: 0x00AABBF8 File Offset: 0x00AA9DF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_changeIconStateCtrl);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202AF RID: 131759 RVA: 0x00AABC50 File Offset: 0x00AA9E50
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_changeIconStateCtrl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			CommonUIStateController changeIconStateCtrl;
			LuaObject.checkType<CommonUIStateController>(l, 2, out changeIconStateCtrl);
			playerInfoHeadIconUIController.m_luaExportHelper.m_changeIconStateCtrl = changeIconStateCtrl;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B0 RID: 131760 RVA: 0x00AABCAC File Offset: 0x00AA9EAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_changeIconPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_changeIconPanelBGButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B1 RID: 131761 RVA: 0x00AABD04 File Offset: 0x00AA9F04
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_changeIconPanelBGButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Button changeIconPanelBGButton;
			LuaObject.checkType<Button>(l, 2, out changeIconPanelBGButton);
			playerInfoHeadIconUIController.m_luaExportHelper.m_changeIconPanelBGButton = changeIconPanelBGButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B2 RID: 131762 RVA: 0x00AABD60 File Offset: 0x00AA9F60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_confirmChangeIconButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_confirmChangeIconButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B3 RID: 131763 RVA: 0x00AABDB8 File Offset: 0x00AA9FB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_confirmChangeIconButton(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Button confirmChangeIconButton;
			LuaObject.checkType<Button>(l, 2, out confirmChangeIconButton);
			playerInfoHeadIconUIController.m_luaExportHelper.m_confirmChangeIconButton = confirmChangeIconButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B4 RID: 131764 RVA: 0x00AABE14 File Offset: 0x00AAA014
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_previewHeadPortraitImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_previewHeadPortraitImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B5 RID: 131765 RVA: 0x00AABE6C File Offset: 0x00AAA06C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_previewHeadPortraitImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Image previewHeadPortraitImage;
			LuaObject.checkType<Image>(l, 2, out previewHeadPortraitImage);
			playerInfoHeadIconUIController.m_luaExportHelper.m_previewHeadPortraitImage = previewHeadPortraitImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B6 RID: 131766 RVA: 0x00AABEC8 File Offset: 0x00AAA0C8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_previewHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_previewHeadFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B7 RID: 131767 RVA: 0x00AABF20 File Offset: 0x00AAA120
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_previewHeadFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Transform previewHeadFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out previewHeadFrameTransform);
			playerInfoHeadIconUIController.m_luaExportHelper.m_previewHeadFrameTransform = previewHeadFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B8 RID: 131768 RVA: 0x00AABF7C File Offset: 0x00AAA17C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_previewLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_previewLevelText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202B9 RID: 131769 RVA: 0x00AABFD4 File Offset: 0x00AAA1D4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_previewLevelText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Text previewLevelText;
			LuaObject.checkType<Text>(l, 2, out previewLevelText);
			playerInfoHeadIconUIController.m_luaExportHelper.m_previewLevelText = previewLevelText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202BA RID: 131770 RVA: 0x00AAC030 File Offset: 0x00AAA230
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_previewFrameUnlockText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_previewFrameUnlockText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202BB RID: 131771 RVA: 0x00AAC088 File Offset: 0x00AAA288
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_previewFrameUnlockText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Text previewFrameUnlockText;
			LuaObject.checkType<Text>(l, 2, out previewFrameUnlockText);
			playerInfoHeadIconUIController.m_luaExportHelper.m_previewFrameUnlockText = previewFrameUnlockText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202BC RID: 131772 RVA: 0x00AAC0E4 File Offset: 0x00AAA2E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_previewPortraitNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_previewPortraitNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202BD RID: 131773 RVA: 0x00AAC13C File Offset: 0x00AAA33C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_previewPortraitNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Text previewPortraitNameText;
			LuaObject.checkType<Text>(l, 2, out previewPortraitNameText);
			playerInfoHeadIconUIController.m_luaExportHelper.m_previewPortraitNameText = previewPortraitNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202BE RID: 131774 RVA: 0x00AAC198 File Offset: 0x00AAA398
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_previewFrameNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_previewFrameNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202BF RID: 131775 RVA: 0x00AAC1F0 File Offset: 0x00AAA3F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_previewFrameNameText(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Text previewFrameNameText;
			LuaObject.checkType<Text>(l, 2, out previewFrameNameText);
			playerInfoHeadIconUIController.m_luaExportHelper.m_previewFrameNameText = previewFrameNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C0 RID: 131776 RVA: 0x00AAC24C File Offset: 0x00AAA44C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnChangeHeadPortraitAndHeadFrame(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			Action<int, int> value;
			int num = LuaObject.checkDelegate<Action<int, int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoHeadIconUIController.EventOnChangeHeadPortraitAndHeadFrame += value;
				}
				else if (num == 2)
				{
					playerInfoHeadIconUIController.EventOnChangeHeadPortraitAndHeadFrame -= value;
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

	// Token: 0x060202C1 RID: 131777 RVA: 0x00AAC2CC File Offset: 0x00AAA4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headPortraitItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_headPortraitItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C2 RID: 131778 RVA: 0x00AAC324 File Offset: 0x00AAA524
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headPortraitItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			GameObject headPortraitItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out headPortraitItemPrefab);
			playerInfoHeadIconUIController.m_luaExportHelper.m_headPortraitItemPrefab = headPortraitItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C3 RID: 131779 RVA: 0x00AAC380 File Offset: 0x00AAA580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_headFrameItemPrefab);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C4 RID: 131780 RVA: 0x00AAC3D8 File Offset: 0x00AAA5D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameItemPrefab(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			GameObject headFrameItemPrefab;
			LuaObject.checkType<GameObject>(l, 2, out headFrameItemPrefab);
			playerInfoHeadIconUIController.m_luaExportHelper.m_headFrameItemPrefab = headFrameItemPrefab;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C5 RID: 131781 RVA: 0x00AAC434 File Offset: 0x00AAA634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroList(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_heroList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C6 RID: 131782 RVA: 0x00AAC48C File Offset: 0x00AAA68C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroList(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			List<Hero> heroList;
			LuaObject.checkType<List<Hero>>(l, 2, out heroList);
			playerInfoHeadIconUIController.m_luaExportHelper.m_heroList = heroList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C7 RID: 131783 RVA: 0x00AAC4E8 File Offset: 0x00AAA6E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectedHeadPortraitItem(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_curSelectedHeadPortraitItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C8 RID: 131784 RVA: 0x00AAC540 File Offset: 0x00AAA740
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectedHeadPortraitItem(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			PlayerInfoHeadPortraitItemUIController curSelectedHeadPortraitItem;
			LuaObject.checkType<PlayerInfoHeadPortraitItemUIController>(l, 2, out curSelectedHeadPortraitItem);
			playerInfoHeadIconUIController.m_luaExportHelper.m_curSelectedHeadPortraitItem = curSelectedHeadPortraitItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202C9 RID: 131785 RVA: 0x00AAC59C File Offset: 0x00AAA79C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_curSelectedHeadFrameItem(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_curSelectedHeadFrameItem);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202CA RID: 131786 RVA: 0x00AAC5F4 File Offset: 0x00AAA7F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_curSelectedHeadFrameItem(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			PlayerInfoHeadFrameItemUIController curSelectedHeadFrameItem;
			LuaObject.checkType<PlayerInfoHeadFrameItemUIController>(l, 2, out curSelectedHeadFrameItem);
			playerInfoHeadIconUIController.m_luaExportHelper.m_curSelectedHeadFrameItem = curSelectedHeadFrameItem;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202CB RID: 131787 RVA: 0x00AAC650 File Offset: 0x00AAA850
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202CC RID: 131788 RVA: 0x00AAC6A8 File Offset: 0x00AAA8A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			playerInfoHeadIconUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202CD RID: 131789 RVA: 0x00AAC704 File Offset: 0x00AAA904
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadIconUIController.m_luaExportHelper.m_playerContext);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202CE RID: 131790 RVA: 0x00AAC75C File Offset: 0x00AAA95C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerContext(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadIconUIController playerInfoHeadIconUIController = (PlayerInfoHeadIconUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerContext;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerContext);
			playerInfoHeadIconUIController.m_luaExportHelper.m_playerContext = playerContext;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202CF RID: 131791 RVA: 0x00AAC7B8 File Offset: 0x00AAA9B8
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerInfoHeadIconUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.ShowChangeHeadIconPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.ChangeHeadIconTogglePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnChangeIconPanelCloseButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.UpdateChangHeadIconPreview);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnConfirmChangeIconButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.GetCurPanelType);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnHeadPortraitToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnHeadFrameToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnHeadFrameValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.OnHeadPortraitValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.CheckHeadFrameValid);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache15);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache16);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache17);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache18);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__callDele_EventOnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache19);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.__clearDele_EventOnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1A);
		string name = "m_headFrameToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_headFrameToggle);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_headFrameToggle);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1C, true);
		string name2 = "m_headPortraitToggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_headPortraitToggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_headPortraitToggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1E, true);
		string name3 = "m_changeHeadPortraitScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_changeHeadPortraitScrollViewContent);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache1F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_changeHeadPortraitScrollViewContent);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache20, true);
		string name4 = "m_changeHeadFrameScrollViewContent";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_changeHeadFrameScrollViewContent);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache21;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_changeHeadFrameScrollViewContent);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache22, true);
		string name5 = "m_changeIconStateCtrl";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_changeIconStateCtrl);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache23;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_changeIconStateCtrl);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache24, true);
		string name6 = "m_changeIconPanelBGButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_changeIconPanelBGButton);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache25;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_changeIconPanelBGButton);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache26, true);
		string name7 = "m_confirmChangeIconButton";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_confirmChangeIconButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache27;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_confirmChangeIconButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache28, true);
		string name8 = "m_previewHeadPortraitImage";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_previewHeadPortraitImage);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache29;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_previewHeadPortraitImage);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2A, true);
		string name9 = "m_previewHeadFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_previewHeadFrameTransform);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2B;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_previewHeadFrameTransform);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2C, true);
		string name10 = "m_previewLevelText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_previewLevelText);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2D;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_previewLevelText);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2E, true);
		string name11 = "m_previewFrameUnlockText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_previewFrameUnlockText);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache2F;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache30 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache30 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_previewFrameUnlockText);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache30, true);
		string name12 = "m_previewPortraitNameText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache31 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache31 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_previewPortraitNameText);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache31;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache32 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache32 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_previewPortraitNameText);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache32, true);
		string name13 = "m_previewFrameNameText";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache33 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache33 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_previewFrameNameText);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache33;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache34 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache34 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_previewFrameNameText);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache34, true);
		string name14 = "EventOnChangeHeadPortraitAndHeadFrame";
		LuaCSFunction get14 = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache35 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache35 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_EventOnChangeHeadPortraitAndHeadFrame);
		}
		LuaObject.addMember(l, name14, get14, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache35, true);
		string name15 = "m_headPortraitItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache36 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache36 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_headPortraitItemPrefab);
		}
		LuaCSFunction get15 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache36;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache37 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache37 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_headPortraitItemPrefab);
		}
		LuaObject.addMember(l, name15, get15, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache37, true);
		string name16 = "m_headFrameItemPrefab";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache38 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache38 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_headFrameItemPrefab);
		}
		LuaCSFunction get16 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache38;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache39 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache39 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_headFrameItemPrefab);
		}
		LuaObject.addMember(l, name16, get16, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache39, true);
		string name17 = "m_heroList";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_heroList);
		}
		LuaCSFunction get17 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3A;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3B == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_heroList);
		}
		LuaObject.addMember(l, name17, get17, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3B, true);
		string name18 = "m_curSelectedHeadPortraitItem";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3C == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_curSelectedHeadPortraitItem);
		}
		LuaCSFunction get18 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3C;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3D == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_curSelectedHeadPortraitItem);
		}
		LuaObject.addMember(l, name18, get18, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3D, true);
		string name19 = "m_curSelectedHeadFrameItem";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3E == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_curSelectedHeadFrameItem);
		}
		LuaCSFunction get19 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3E;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3F == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_curSelectedHeadFrameItem);
		}
		LuaObject.addMember(l, name19, get19, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache3F, true);
		string name20 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache40 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache40 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_configDataLoader);
		}
		LuaCSFunction get20 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache40;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache41 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache41 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name20, get20, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache41, true);
		string name21 = "m_playerContext";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache42 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache42 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.get_m_playerContext);
		}
		LuaCSFunction get21 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache42;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache43 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache43 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.set_m_playerContext);
		}
		LuaObject.addMember(l, name21, get21, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadIconUIController.<>f__mg$cache43, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerInfoHeadIconUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401621D RID: 90653
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401621E RID: 90654
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401621F RID: 90655
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016220 RID: 90656
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016221 RID: 90657
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016222 RID: 90658
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016223 RID: 90659
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016224 RID: 90660
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016225 RID: 90661
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016226 RID: 90662
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016227 RID: 90663
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016228 RID: 90664
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016229 RID: 90665
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401622A RID: 90666
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401622B RID: 90667
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401622C RID: 90668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401622D RID: 90669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401622E RID: 90670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401622F RID: 90671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016230 RID: 90672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016231 RID: 90673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016232 RID: 90674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016233 RID: 90675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016234 RID: 90676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016235 RID: 90677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016236 RID: 90678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016237 RID: 90679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016238 RID: 90680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016239 RID: 90681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401623A RID: 90682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401623B RID: 90683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401623C RID: 90684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401623D RID: 90685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401623E RID: 90686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401623F RID: 90687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04016240 RID: 90688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04016241 RID: 90689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04016242 RID: 90690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04016243 RID: 90691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04016244 RID: 90692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04016245 RID: 90693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04016246 RID: 90694
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04016247 RID: 90695
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04016248 RID: 90696
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04016249 RID: 90697
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x0401624A RID: 90698
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;

	// Token: 0x0401624B RID: 90699
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2E;

	// Token: 0x0401624C RID: 90700
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2F;

	// Token: 0x0401624D RID: 90701
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache30;

	// Token: 0x0401624E RID: 90702
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache31;

	// Token: 0x0401624F RID: 90703
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache32;

	// Token: 0x04016250 RID: 90704
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache33;

	// Token: 0x04016251 RID: 90705
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache34;

	// Token: 0x04016252 RID: 90706
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache35;

	// Token: 0x04016253 RID: 90707
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache36;

	// Token: 0x04016254 RID: 90708
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache37;

	// Token: 0x04016255 RID: 90709
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache38;

	// Token: 0x04016256 RID: 90710
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache39;

	// Token: 0x04016257 RID: 90711
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3A;

	// Token: 0x04016258 RID: 90712
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3B;

	// Token: 0x04016259 RID: 90713
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3C;

	// Token: 0x0401625A RID: 90714
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3D;

	// Token: 0x0401625B RID: 90715
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3E;

	// Token: 0x0401625C RID: 90716
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3F;

	// Token: 0x0401625D RID: 90717
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache40;

	// Token: 0x0401625E RID: 90718
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache41;

	// Token: 0x0401625F RID: 90719
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache42;

	// Token: 0x04016260 RID: 90720
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache43;
}
