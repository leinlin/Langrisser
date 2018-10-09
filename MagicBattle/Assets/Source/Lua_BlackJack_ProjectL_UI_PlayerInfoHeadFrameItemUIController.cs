using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001527 RID: 5415
[Preserve]
public class Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController : LuaObject
{
	// Token: 0x06020270 RID: 131696 RVA: 0x00AA9E7C File Offset: 0x00AA807C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateItemInfo(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			bool isLock;
			LuaObject.checkType(l, 3, out isLock);
			bool isSelected;
			LuaObject.checkType(l, 4, out isSelected);
			playerInfoHeadFrameItemUIController.UpdateItemInfo(headFrameId, isLock, isSelected);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020271 RID: 131697 RVA: 0x00AA9EF0 File Offset: 0x00AA80F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020272 RID: 131698 RVA: 0x00AA9F44 File Offset: 0x00AA8144
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			bool isOn;
			LuaObject.checkType(l, 2, out isOn);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.OnSelectToggleValueChanged(isOn);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020273 RID: 131699 RVA: 0x00AA9FA0 File Offset: 0x00AA81A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020274 RID: 131700 RVA: 0x00AAA00C File Offset: 0x00AA820C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020275 RID: 131701 RVA: 0x00AAA060 File Offset: 0x00AA8260
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020276 RID: 131702 RVA: 0x00AAA0B4 File Offset: 0x00AA82B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06020277 RID: 131703 RVA: 0x00AAA15C File Offset: 0x00AA835C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020278 RID: 131704 RVA: 0x00AAA1B0 File Offset: 0x00AA83B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020279 RID: 131705 RVA: 0x00AAA21C File Offset: 0x00AA841C
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
				PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController2 = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				playerInfoHeadFrameItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602027A RID: 131706 RVA: 0x00AAA32C File Offset: 0x00AA852C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602027B RID: 131707 RVA: 0x00AAA398 File Offset: 0x00AA8598
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602027C RID: 131708 RVA: 0x00AAA404 File Offset: 0x00AA8604
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602027D RID: 131709 RVA: 0x00AAA470 File Offset: 0x00AA8670
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602027E RID: 131710 RVA: 0x00AAA4DC File Offset: 0x00AA86DC
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
				PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController2 = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				playerInfoHeadFrameItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0602027F RID: 131711 RVA: 0x00AAA5EC File Offset: 0x00AA87EC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			string s = playerInfoHeadFrameItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06020280 RID: 131712 RVA: 0x00AAA648 File Offset: 0x00AA8848
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			PlayerInfoHeadFrameItemUIController arg2;
			LuaObject.checkType<PlayerInfoHeadFrameItemUIController>(l, 3, out arg2);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__callDele_EventOnSelectToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020281 RID: 131713 RVA: 0x00AAA6B4 File Offset: 0x00AA88B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			bool arg;
			LuaObject.checkType(l, 2, out arg);
			PlayerInfoHeadFrameItemUIController arg2;
			LuaObject.checkType<PlayerInfoHeadFrameItemUIController>(l, 3, out arg2);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.__clearDele_EventOnSelectToggleValueChanged(arg, arg2);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020282 RID: 131714 RVA: 0x00AAA720 File Offset: 0x00AA8920
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int set_EventOnSelectToggleValueChanged(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			Action<bool, PlayerInfoHeadFrameItemUIController> value;
			int num = LuaObject.checkDelegate<Action<bool, PlayerInfoHeadFrameItemUIController>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					playerInfoHeadFrameItemUIController.EventOnSelectToggleValueChanged += value;
				}
				else if (num == 2)
				{
					playerInfoHeadFrameItemUIController.EventOnSelectToggleValueChanged -= value;
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

	// Token: 0x06020283 RID: 131715 RVA: 0x00AAA7A0 File Offset: 0x00AA89A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadFrameItemUIController.m_luaExportHelper.m_toggle);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020284 RID: 131716 RVA: 0x00AAA7F8 File Offset: 0x00AA89F8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_toggle(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			Toggle toggle;
			LuaObject.checkType<Toggle>(l, 2, out toggle);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.m_toggle = toggle;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020285 RID: 131717 RVA: 0x00AAA854 File Offset: 0x00AA8A54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadFrameItemUIController.m_luaExportHelper.m_headFrameTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020286 RID: 131718 RVA: 0x00AAA8AC File Offset: 0x00AA8AAC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_headFrameTransform(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			Transform headFrameTransform;
			LuaObject.checkType<Transform>(l, 2, out headFrameTransform);
			playerInfoHeadFrameItemUIController.m_luaExportHelper.m_headFrameTransform = headFrameTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020287 RID: 131719 RVA: 0x00AAA908 File Offset: 0x00AA8B08
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_HeadFrameId(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, playerInfoHeadFrameItemUIController.HeadFrameId);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020288 RID: 131720 RVA: 0x00AAA95C File Offset: 0x00AA8B5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_HeadFrameId(IntPtr l)
	{
		int result;
		try
		{
			PlayerInfoHeadFrameItemUIController playerInfoHeadFrameItemUIController = (PlayerInfoHeadFrameItemUIController)LuaObject.checkSelf(l);
			int headFrameId;
			LuaObject.checkType(l, 2, out headFrameId);
			playerInfoHeadFrameItemUIController.HeadFrameId = headFrameId;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06020289 RID: 131721 RVA: 0x00AAA9B4 File Offset: 0x00AA8BB4
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.PlayerInfoHeadFrameItemUIController");
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.UpdateItemInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.OnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__callDele_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.__clearDele_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache11);
		string name = "EventOnSelectToggleValueChanged";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.set_EventOnSelectToggleValueChanged);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache12, true);
		string name2 = "m_toggle";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.get_m_toggle);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.set_m_toggle);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache14, true);
		string name3 = "m_headFrameTransform";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.get_m_headFrameTransform);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.set_m_headFrameTransform);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache16, true);
		string name4 = "HeadFrameId";
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.get_HeadFrameId);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.set_HeadFrameId);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_PlayerInfoHeadFrameItemUIController.<>f__mg$cache18, true);
		LuaObject.createTypeMetatable(l, null, typeof(PlayerInfoHeadFrameItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016204 RID: 90628
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016205 RID: 90629
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016206 RID: 90630
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016207 RID: 90631
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016208 RID: 90632
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016209 RID: 90633
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x0401620A RID: 90634
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x0401620B RID: 90635
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x0401620C RID: 90636
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x0401620D RID: 90637
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x0401620E RID: 90638
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x0401620F RID: 90639
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016210 RID: 90640
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016211 RID: 90641
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016212 RID: 90642
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016213 RID: 90643
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016214 RID: 90644
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016215 RID: 90645
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016216 RID: 90646
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016217 RID: 90647
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016218 RID: 90648
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016219 RID: 90649
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x0401621A RID: 90650
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x0401621B RID: 90651
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x0401621C RID: 90652
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;
}
