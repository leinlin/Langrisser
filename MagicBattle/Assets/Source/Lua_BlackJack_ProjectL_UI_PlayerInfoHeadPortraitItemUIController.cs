using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001529 RID: 5417
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController : LuaObject
{
	// Token: 0x060202D1 RID: 131793 RVA: 0x00AAD148 File Offset: 0x00AAB348
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			string headPortraitName;
			LuaObject.checkType(l, 3, out headPortraitName);
			bool isSelected;
			LuaObject.checkType(l, 4, out isSelected);
			playerInfoHeadPortraitItemUIController.UpdateItemInfo(headPortraitId, headPortraitName, isSelected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D2 RID: 131794 RVA: 0x00AAD1BC File Offset: 0x00AAB3BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D3 RID: 131795 RVA: 0x00AAD210 File Offset: 0x00AAB410
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.OnSelectToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D4 RID: 131796 RVA: 0x00AAD26C File Offset: 0x00AAB46C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D5 RID: 131797 RVA: 0x00AAD2D8 File Offset: 0x00AAB4D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D6 RID: 131798 RVA: 0x00AAD32C File Offset: 0x00AAB52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D7 RID: 131799 RVA: 0x00AAD380 File Offset: 0x00AAB580
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x060202D8 RID: 131800 RVA: 0x00AAD428 File Offset: 0x00AAB628
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202D9 RID: 131801 RVA: 0x00AAD47C File Offset: 0x00AAB67C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202DA RID: 131802 RVA: 0x00AAD4E8 File Offset: 0x00AAB6E8
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
				PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController2 = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerInfoHeadPortraitItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x060202DB RID: 131803 RVA: 0x00AAD5F8 File Offset: 0x00AAB7F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202DC RID: 131804 RVA: 0x00AAD664 File Offset: 0x00AAB864
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202DD RID: 131805 RVA: 0x00AAD6D0 File Offset: 0x00AAB8D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202DE RID: 131806 RVA: 0x00AAD73C File Offset: 0x00AAB93C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202DF RID: 131807 RVA: 0x00AAD7A8 File Offset: 0x00AAB9A8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetToggleValueChangedListener(IntPtr l)
	{
		int result;
		try
		{
			int total = LuaDLL.lua_gettop(l);
			if (LuaObject.matchType(l, total, 2, typeof(string[]), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController2 = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerInfoHeadPortraitItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x060202E0 RID: 131808 RVA: 0x00AAD8B8 File Offset: 0x00AABAB8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string s = playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x060202E1 RID: 131809 RVA: 0x00AAD914 File Offset: 0x00AABB14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			PlayerInfoHeadPortraitItemUIController arg2;
			LuaObject.checkType<PlayerInfoHeadPortraitItemUIController>(l, 3, out arg2);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__callDele_EventOnSelectToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E2 RID: 131810 RVA: 0x00AAD980 File Offset: 0x00AABB80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			PlayerInfoHeadPortraitItemUIController arg2;
			LuaObject.checkType<PlayerInfoHeadPortraitItemUIController>(l, 3, out arg2);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.__clearDele_EventOnSelectToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E3 RID: 131811 RVA: 0x00AAD9EC File Offset: 0x00AABBEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			Action<bool, PlayerInfoHeadPortraitItemUIController> value;
			int num = LuaObject.checkDelegate<Action<bool, PlayerInfoHeadPortraitItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoHeadPortraitItemUIController.EventOnSelectToggleValueChanged += value;
				}
				else if (num == 2)
				{
					playerInfoHeadPortraitItemUIController.EventOnSelectToggleValueChanged -= value;
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

	// Token: 0x060202E4 RID: 131812 RVA: 0x00AADA6C File Offset: 0x00AABC6C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadPortraitItemUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E5 RID: 131813 RVA: 0x00AADAC4 File Offset: 0x00AABCC4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E6 RID: 131814 RVA: 0x00AADB20 File Offset: 0x00AABD20
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headPortraitImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadPortraitItemUIController.m_luaExportHelper.m_headPortraitImage);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E7 RID: 131815 RVA: 0x00AADB78 File Offset: 0x00AABD78
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headPortraitImage(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			Image headPortraitImage;
			LuaObject.checkType<Image>(l, 2, out headPortraitImage);
			playerInfoHeadPortraitItemUIController.m_luaExportHelper.m_headPortraitImage = headPortraitImage;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E8 RID: 131816 RVA: 0x00AADBD4 File Offset: 0x00AABDD4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadPortraitId(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadPortraitItemUIController.HeadPortraitId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202E9 RID: 131817 RVA: 0x00AADC28 File Offset: 0x00AABE28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadPortraitId(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			int headPortraitId;
			LuaObject.checkType(l, 2, out headPortraitId);
			playerInfoHeadPortraitItemUIController.HeadPortraitId = headPortraitId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202EA RID: 131818 RVA: 0x00AADC80 File Offset: 0x00AABE80
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_HeadPortraitName(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadPortraitItemUIController.HeadPortraitName);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202EB RID: 131819 RVA: 0x00AADCD4 File Offset: 0x00AABED4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadPortraitName(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadPortraitItemUIController playerInfoHeadPortraitItemUIController = (PlayerInfoHeadPortraitItemUIController)LuaObject.checkSelf(l);
			string headPortraitName;
			LuaObject.checkType(l, 2, out headPortraitName);
			playerInfoHeadPortraitItemUIController.HeadPortraitName = headPortraitName;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x060202EC RID: 131820 RVA: 0x00AADD2C File Offset: 0x00AABF2C
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerInfoHeadPortraitItemUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.OnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__callDele_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.__clearDele_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache11);
		string name = "EventOnSelectToggleValueChanged";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.set_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache12, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache14, true);
		string name3 = "m_headPortraitImage";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.get_m_headPortraitImage);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.set_m_headPortraitImage);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache16, true);
		string name4 = "HeadPortraitId";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.get_HeadPortraitId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.set_HeadPortraitId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache18, true);
		string name5 = "HeadPortraitName";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.get_HeadPortraitName);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.set_HeadPortraitName);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadPortraitItemUIController.<>f__mg$cache1A, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerInfoHeadPortraitItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016261 RID: 90721
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016262 RID: 90722
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016263 RID: 90723
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016264 RID: 90724
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016265 RID: 90725
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016266 RID: 90726
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016267 RID: 90727
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016268 RID: 90728
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016269 RID: 90729
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401626A RID: 90730
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401626B RID: 90731
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401626C RID: 90732
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x0401626D RID: 90733
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401626E RID: 90734
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401626F RID: 90735
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016270 RID: 90736
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016271 RID: 90737
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016272 RID: 90738
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016273 RID: 90739
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016274 RID: 90740
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016275 RID: 90741
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016276 RID: 90742
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016277 RID: 90743
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016278 RID: 90744
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016279 RID: 90745
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x0401627A RID: 90746
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x0401627B RID: 90747
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;
}
