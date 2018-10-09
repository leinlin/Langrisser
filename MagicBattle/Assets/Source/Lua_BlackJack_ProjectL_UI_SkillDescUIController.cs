using System;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x0200157C RID: 5500
[Preserve]
public class Lua_BlackJack_ProjectL_UI_SkillDescUIController : LuaObject
{
	// Token: 0x06021143 RID: 135491 RVA: 0x00B205B4 File Offset: 0x00B1E7B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitSkillDesc(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			skillDescUIController.InitSkillDesc(skillInfo);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021144 RID: 135492 RVA: 0x00B2060C File Offset: 0x00B1E80C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021145 RID: 135493 RVA: 0x00B20660 File Offset: 0x00B1E860
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ShowPanel(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.ShowPanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021146 RID: 135494 RVA: 0x00B206B4 File Offset: 0x00B1E8B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int ClosePanel(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.ClosePanel();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021147 RID: 135495 RVA: 0x00B20708 File Offset: 0x00B1E908
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			skillDescUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021148 RID: 135496 RVA: 0x00B20774 File Offset: 0x00B1E974
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021149 RID: 135497 RVA: 0x00B207C8 File Offset: 0x00B1E9C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602114A RID: 135498 RVA: 0x00B2081C File Offset: 0x00B1EA1C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = skillDescUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0602114B RID: 135499 RVA: 0x00B208C4 File Offset: 0x00B1EAC4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602114C RID: 135500 RVA: 0x00B20918 File Offset: 0x00B1EB18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			skillDescUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602114D RID: 135501 RVA: 0x00B20984 File Offset: 0x00B1EB84
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
				SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				skillDescUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				SkillDescUIController skillDescUIController2 = (SkillDescUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				skillDescUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0602114E RID: 135502 RVA: 0x00B20A94 File Offset: 0x00B1EC94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			skillDescUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602114F RID: 135503 RVA: 0x00B20B00 File Offset: 0x00B1ED00
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			skillDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021150 RID: 135504 RVA: 0x00B20B6C File Offset: 0x00B1ED6C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			skillDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021151 RID: 135505 RVA: 0x00B20BD8 File Offset: 0x00B1EDD8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			skillDescUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021152 RID: 135506 RVA: 0x00B20C44 File Offset: 0x00B1EE44
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
				SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				skillDescUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				SkillDescUIController skillDescUIController2 = (SkillDescUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				skillDescUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021153 RID: 135507 RVA: 0x00B20D54 File Offset: 0x00B1EF54
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			string s = skillDescUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021154 RID: 135508 RVA: 0x00B20DB0 File Offset: 0x00B1EFB0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.__callDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021155 RID: 135509 RVA: 0x00B20E04 File Offset: 0x00B1F004
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			skillDescUIController.m_luaExportHelper.__clearDele_EventOnClose();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021156 RID: 135510 RVA: 0x00B20E58 File Offset: 0x00B1F058
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnClose(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Action value;
			int num = LuaObject.checkDelegate<Action>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					skillDescUIController.EventOnClose += value;
				}
				else if (num == 2)
				{
					skillDescUIController.EventOnClose -= value;
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

	// Token: 0x06021157 RID: 135511 RVA: 0x00B20ED8 File Offset: 0x00B1F0D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021158 RID: 135512 RVA: 0x00B20F30 File Offset: 0x00B1F130
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			skillDescUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021159 RID: 135513 RVA: 0x00B20F8C File Offset: 0x00B1F18C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_costObj(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_costObj);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602115A RID: 135514 RVA: 0x00B20FE4 File Offset: 0x00B1F1E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_costObj(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			GameObject costObj;
			LuaObject.checkType<GameObject>(l, 2, out costObj);
			skillDescUIController.m_luaExportHelper.m_costObj = costObj;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602115B RID: 135515 RVA: 0x00B21040 File Offset: 0x00B1F240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_typeText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_typeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602115C RID: 135516 RVA: 0x00B21098 File Offset: 0x00B1F298
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_typeText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Text typeText;
			LuaObject.checkType<Text>(l, 2, out typeText);
			skillDescUIController.m_luaExportHelper.m_typeText = typeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602115D RID: 135517 RVA: 0x00B210F4 File Offset: 0x00B1F2F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_cdText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_cdText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602115E RID: 135518 RVA: 0x00B2114C File Offset: 0x00B1F34C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_cdText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Text cdText;
			LuaObject.checkType<Text>(l, 2, out cdText);
			skillDescUIController.m_luaExportHelper.m_cdText = cdText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602115F RID: 135519 RVA: 0x00B211A8 File Offset: 0x00B1F3A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_distanceText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_distanceText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021160 RID: 135520 RVA: 0x00B21200 File Offset: 0x00B1F400
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_distanceText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Text distanceText;
			LuaObject.checkType<Text>(l, 2, out distanceText);
			skillDescUIController.m_luaExportHelper.m_distanceText = distanceText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021161 RID: 135521 RVA: 0x00B2125C File Offset: 0x00B1F45C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rangeText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_rangeText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021162 RID: 135522 RVA: 0x00B212B4 File Offset: 0x00B1F4B4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rangeText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Text rangeText;
			LuaObject.checkType<Text>(l, 2, out rangeText);
			skillDescUIController.m_luaExportHelper.m_rangeText = rangeText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021163 RID: 135523 RVA: 0x00B21310 File Offset: 0x00B1F510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021164 RID: 135524 RVA: 0x00B21368 File Offset: 0x00B1F568
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			skillDescUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021165 RID: 135525 RVA: 0x00B213C4 File Offset: 0x00B1F5C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_boundaryGo(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.m_luaExportHelper.m_boundaryGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021166 RID: 135526 RVA: 0x00B2141C File Offset: 0x00B1F61C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_boundaryGo(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			GameObject boundaryGo;
			LuaObject.checkType<GameObject>(l, 2, out boundaryGo);
			skillDescUIController.m_luaExportHelper.m_boundaryGo = boundaryGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021167 RID: 135527 RVA: 0x00B21478 File Offset: 0x00B1F678
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_SkillInfo(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, skillDescUIController.SkillInfo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021168 RID: 135528 RVA: 0x00B214CC File Offset: 0x00B1F6CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_SkillInfo(IntPtr l)
	{
		int result;
		try
		{
			SkillDescUIController skillDescUIController = (SkillDescUIController)LuaObject.checkSelf(l);
			ConfigDataSkillInfo skillInfo;
			LuaObject.checkType<ConfigDataSkillInfo>(l, 2, out skillInfo);
			skillDescUIController.m_luaExportHelper.SkillInfo = skillInfo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021169 RID: 135529 RVA: 0x00B21528 File Offset: 0x00B1F728
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.SkillDescUIController");
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.InitSkillDesc);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.ShowPanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.ClosePanel);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__callDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.__clearDele_EventOnClose);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache12);
		string name = "EventOnClose";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_EventOnClose);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache13, true);
		string name2 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_nameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache15, true);
		string name3 = "m_costObj";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_costObj);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_costObj);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache17, true);
		string name4 = "m_typeText";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_typeText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_typeText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache19, true);
		string name5 = "m_cdText";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_cdText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_cdText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1B, true);
		string name6 = "m_distanceText";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_distanceText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_distanceText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1D, true);
		string name7 = "m_rangeText";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_rangeText);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_rangeText);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache1F, true);
		string name8 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_descText);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_descText);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache21, true);
		string name9 = "m_boundaryGo";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_m_boundaryGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_m_boundaryGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache23, true);
		string name10 = "SkillInfo";
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.get_SkillInfo);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_SkillDescUIController.set_SkillInfo);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_SkillDescUIController.<>f__mg$cache25, true);
		LuaObject.createTypeMetatable(l, null, typeof(SkillDescUIController), typeof(UIControllerBase));
	}

	// Token: 0x0401702D RID: 94253
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x0401702E RID: 94254
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x0401702F RID: 94255
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017030 RID: 94256
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017031 RID: 94257
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017032 RID: 94258
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017033 RID: 94259
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017034 RID: 94260
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017035 RID: 94261
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017036 RID: 94262
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017037 RID: 94263
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017038 RID: 94264
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017039 RID: 94265
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x0401703A RID: 94266
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x0401703B RID: 94267
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x0401703C RID: 94268
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x0401703D RID: 94269
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x0401703E RID: 94270
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x0401703F RID: 94271
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017040 RID: 94272
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017041 RID: 94273
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017042 RID: 94274
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017043 RID: 94275
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017044 RID: 94276
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017045 RID: 94277
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017046 RID: 94278
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04017047 RID: 94279
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04017048 RID: 94280
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04017049 RID: 94281
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x0401704A RID: 94282
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x0401704B RID: 94283
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x0401704C RID: 94284
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x0401704D RID: 94285
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x0401704E RID: 94286
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x0401704F RID: 94287
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04017050 RID: 94288
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04017051 RID: 94289
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04017052 RID: 94290
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;
}
