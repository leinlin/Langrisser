using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using BlackJack.BJFramework.Runtime.Prefab;
using BlackJack.BJFramework.Runtime.UI;
using BlackJack.ConfigData;
using BlackJack.ProjectL.UI;
using SLua;
using UnityEngine;
using UnityEngine.Scripting;
using UnityEngine.UI;

// Token: 0x02001577 RID: 5495
[Preserve]
public class Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController : LuaObject
{
	// Token: 0x06021069 RID: 135273 RVA: 0x00B19718 File Offset: 0x00B17918
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Refresh(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			List<int> heroIDList;
			LuaObject.checkType<List<int>>(l, 2, out heroIDList);
			shareTenSelectCardUIController.Refresh(heroIDList);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602106A RID: 135274 RVA: 0x00B19770 File Offset: 0x00B17970
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			shareTenSelectCardUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602106B RID: 135275 RVA: 0x00B197C4 File Offset: 0x00B179C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int UpdateSharePlayerInfo(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			shareTenSelectCardUIController.m_luaExportHelper.UpdateSharePlayerInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602106C RID: 135276 RVA: 0x00B19818 File Offset: 0x00B17A18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int Compare(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			int leftHeroID;
			LuaObject.checkType(l, 2, out leftHeroID);
			int rightHeroID;
			LuaObject.checkType(l, 3, out rightHeroID);
			int i = shareTenSelectCardUIController.m_luaExportHelper.Compare(leftHeroID, rightHeroID);
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

	// Token: 0x0602106D RID: 135277 RVA: 0x00B1988C File Offset: 0x00B17A8C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602106E RID: 135278 RVA: 0x00B198F8 File Offset: 0x00B17AF8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602106F RID: 135279 RVA: 0x00B1994C File Offset: 0x00B17B4C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021070 RID: 135280 RVA: 0x00B199A0 File Offset: 0x00B17BA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = shareTenSelectCardUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021071 RID: 135281 RVA: 0x00B19A48 File Offset: 0x00B17C48
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021072 RID: 135282 RVA: 0x00B19A9C File Offset: 0x00B17C9C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021073 RID: 135283 RVA: 0x00B19B08 File Offset: 0x00B17D08
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
				ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				shareTenSelectCardUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				ShareTenSelectCardUIController shareTenSelectCardUIController2 = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				shareTenSelectCardUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021074 RID: 135284 RVA: 0x00B19C18 File Offset: 0x00B17E18
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021075 RID: 135285 RVA: 0x00B19C84 File Offset: 0x00B17E84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021076 RID: 135286 RVA: 0x00B19CF0 File Offset: 0x00B17EF0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021077 RID: 135287 RVA: 0x00B19D5C File Offset: 0x00B17F5C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			shareTenSelectCardUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021078 RID: 135288 RVA: 0x00B19DC8 File Offset: 0x00B17FC8
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
				ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				shareTenSelectCardUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				ShareTenSelectCardUIController shareTenSelectCardUIController2 = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				shareTenSelectCardUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021079 RID: 135289 RVA: 0x00B19ED8 File Offset: 0x00B180D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			string s = shareTenSelectCardUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0602107A RID: 135290 RVA: 0x00B19F34 File Offset: 0x00B18134
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGroup(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_heroGroup);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602107B RID: 135291 RVA: 0x00B19F8C File Offset: 0x00B1818C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGroup(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			GameObject heroGroup;
			LuaObject.checkType<GameObject>(l, 2, out heroGroup);
			shareTenSelectCardUIController.m_luaExportHelper.m_heroGroup = heroGroup;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602107C RID: 135292 RVA: 0x00B19FE8 File Offset: 0x00B181E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_playerNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602107D RID: 135293 RVA: 0x00B1A040 File Offset: 0x00B18240
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerNameText(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			Text playerNameText;
			LuaObject.checkType<Text>(l, 2, out playerNameText);
			shareTenSelectCardUIController.m_luaExportHelper.m_playerNameText = playerNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602107E RID: 135294 RVA: 0x00B1A09C File Offset: 0x00B1829C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_playerLvText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0602107F RID: 135295 RVA: 0x00B1A0F4 File Offset: 0x00B182F4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_playerLvText(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			Text playerLvText;
			LuaObject.checkType<Text>(l, 2, out playerLvText);
			shareTenSelectCardUIController.m_luaExportHelper.m_playerLvText = playerLvText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021080 RID: 135296 RVA: 0x00B1A150 File Offset: 0x00B18350
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_serverNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021081 RID: 135297 RVA: 0x00B1A1A8 File Offset: 0x00B183A8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_serverNameText(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			Text serverNameText;
			LuaObject.checkType<Text>(l, 2, out serverNameText);
			shareTenSelectCardUIController.m_luaExportHelper.m_serverNameText = serverNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021082 RID: 135298 RVA: 0x00B1A204 File Offset: 0x00B18404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroDummyParentList(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_heroDummyParentList);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021083 RID: 135299 RVA: 0x00B1A25C File Offset: 0x00B1845C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroDummyParentList(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			List<Transform> heroDummyParentList;
			LuaObject.checkType<List<Transform>>(l, 2, out heroDummyParentList);
			shareTenSelectCardUIController.m_luaExportHelper.m_heroDummyParentList = heroDummyParentList;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021084 RID: 135300 RVA: 0x00B1A2B8 File Offset: 0x00B184B8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_heroGameObject(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_heroGameObject);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021085 RID: 135301 RVA: 0x00B1A310 File Offset: 0x00B18510
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_heroGameObject(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			List<GameObject> heroGameObject;
			LuaObject.checkType<List<GameObject>>(l, 2, out heroGameObject);
			shareTenSelectCardUIController.m_luaExportHelper.m_heroGameObject = heroGameObject;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021086 RID: 135302 RVA: 0x00B1A36C File Offset: 0x00B1856C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, shareTenSelectCardUIController.m_luaExportHelper.m_configDataLoader);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021087 RID: 135303 RVA: 0x00B1A3C4 File Offset: 0x00B185C4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_configDataLoader(IntPtr l)
	{
		int result;
		try
		{
			ShareTenSelectCardUIController shareTenSelectCardUIController = (ShareTenSelectCardUIController)LuaObject.checkSelf(l);
			IConfigDataLoader configDataLoader;
			LuaObject.checkType<IConfigDataLoader>(l, 2, out configDataLoader);
			shareTenSelectCardUIController.m_luaExportHelper.m_configDataLoader = configDataLoader;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021088 RID: 135304 RVA: 0x00B1A420 File Offset: 0x00B18620
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.ShareTenSelectCardUIController");
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.Refresh);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.UpdateSharePlayerInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.Compare);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache10);
		string name = "m_heroGroup";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_heroGroup);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache11;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_heroGroup);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache12, true);
		string name2 = "m_playerNameText";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_playerNameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache13;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_playerNameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache14, true);
		string name3 = "m_playerLvText";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_playerLvText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache15;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_playerLvText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache16, true);
		string name4 = "m_serverNameText";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_serverNameText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache17;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_serverNameText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache18, true);
		string name5 = "m_heroDummyParentList";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_heroDummyParentList);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache19;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_heroDummyParentList);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1A, true);
		string name6 = "m_heroGameObject";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_heroGameObject);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1B;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_heroGameObject);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1C, true);
		string name7 = "m_configDataLoader";
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.get_m_configDataLoader);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1D;
		if (Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.set_m_configDataLoader);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_ShareTenSelectCardUIController.<>f__mg$cache1E, true);
		LuaObject.createTypeMetatable(l, null, typeof(ShareTenSelectCardUIController), typeof(UIControllerBase));
	}

	// Token: 0x04016F5D RID: 94045
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04016F5E RID: 94046
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04016F5F RID: 94047
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04016F60 RID: 94048
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04016F61 RID: 94049
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04016F62 RID: 94050
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04016F63 RID: 94051
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04016F64 RID: 94052
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04016F65 RID: 94053
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04016F66 RID: 94054
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04016F67 RID: 94055
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04016F68 RID: 94056
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04016F69 RID: 94057
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04016F6A RID: 94058
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04016F6B RID: 94059
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04016F6C RID: 94060
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04016F6D RID: 94061
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04016F6E RID: 94062
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04016F6F RID: 94063
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04016F70 RID: 94064
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04016F71 RID: 94065
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04016F72 RID: 94066
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04016F73 RID: 94067
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04016F74 RID: 94068
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04016F75 RID: 94069
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04016F76 RID: 94070
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04016F77 RID: 94071
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04016F78 RID: 94072
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04016F79 RID: 94073
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04016F7A RID: 94074
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04016F7B RID: 94075
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;
}
