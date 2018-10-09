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

// Token: 0x020015C9 RID: 5577
[Preserve]
public class Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController : LuaObject
{
	// Token: 0x06021F34 RID: 139060 RVA: 0x00B8F72C File Offset: 0x00B8D92C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetUnchartedScoreRewardGroupInfo(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			ConfigDataUnchartedScoreRewardGroupInfo rewardInfo;
			LuaObject.checkType<ConfigDataUnchartedScoreRewardGroupInfo>(l, 2, out rewardInfo);
			string scoreName;
			LuaObject.checkType(l, 3, out scoreName);
			unchartedScoreRewardListItemUIController.SetUnchartedScoreRewardGroupInfo(rewardInfo, scoreName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F35 RID: 139061 RVA: 0x00B8F790 File Offset: 0x00B8D990
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetGot(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			bool got;
			LuaObject.checkType(l, 2, out got);
			unchartedScoreRewardListItemUIController.SetGot(got);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F36 RID: 139062 RVA: 0x00B8F7E8 File Offset: 0x00B8D9E8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F37 RID: 139063 RVA: 0x00B8F83C File Offset: 0x00B8DA3C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F38 RID: 139064 RVA: 0x00B8F8A8 File Offset: 0x00B8DAA8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F39 RID: 139065 RVA: 0x00B8F8FC File Offset: 0x00B8DAFC
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F3A RID: 139066 RVA: 0x00B8F950 File Offset: 0x00B8DB50
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x06021F3B RID: 139067 RVA: 0x00B8F9F8 File Offset: 0x00B8DBF8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F3C RID: 139068 RVA: 0x00B8FA4C File Offset: 0x00B8DC4C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F3D RID: 139069 RVA: 0x00B8FAB8 File Offset: 0x00B8DCB8
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
				UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController2 = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				unchartedScoreRewardListItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x06021F3E RID: 139070 RVA: 0x00B8FBC8 File Offset: 0x00B8DDC8
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F3F RID: 139071 RVA: 0x00B8FC34 File Offset: 0x00B8DE34
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F40 RID: 139072 RVA: 0x00B8FCA0 File Offset: 0x00B8DEA0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F41 RID: 139073 RVA: 0x00B8FD0C File Offset: 0x00B8DF0C
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F42 RID: 139074 RVA: 0x00B8FD78 File Offset: 0x00B8DF78
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
				UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController2 = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				unchartedScoreRewardListItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x06021F43 RID: 139075 RVA: 0x00B8FE88 File Offset: 0x00B8E088
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			string s = unchartedScoreRewardListItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x06021F44 RID: 139076 RVA: 0x00B8FEE4 File Offset: 0x00B8E0E4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRewardListItemUIController.m_luaExportHelper.m_uiStateController);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F45 RID: 139077 RVA: 0x00B8FF3C File Offset: 0x00B8E13C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_uiStateController(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			CommonUIStateController uiStateController;
			LuaObject.checkType<CommonUIStateController>(l, 2, out uiStateController);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.m_uiStateController = uiStateController;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F46 RID: 139078 RVA: 0x00B8FF98 File Offset: 0x00B8E198
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRewardListItemUIController.m_luaExportHelper.m_nameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F47 RID: 139079 RVA: 0x00B8FFF0 File Offset: 0x00B8E1F0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_nameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			Text nameText;
			LuaObject.checkType<Text>(l, 2, out nameText);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.m_nameText = nameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F48 RID: 139080 RVA: 0x00B9004C File Offset: 0x00B8E24C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRewardListItemUIController.m_luaExportHelper.m_scoreNameText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F49 RID: 139081 RVA: 0x00B900A4 File Offset: 0x00B8E2A4
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreNameText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			Text scoreNameText;
			LuaObject.checkType<Text>(l, 2, out scoreNameText);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.m_scoreNameText = scoreNameText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F4A RID: 139082 RVA: 0x00B90100 File Offset: 0x00B8E300
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_scoreText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRewardListItemUIController.m_luaExportHelper.m_scoreText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F4B RID: 139083 RVA: 0x00B90158 File Offset: 0x00B8E358
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_scoreText(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			Text scoreText;
			LuaObject.checkType<Text>(l, 2, out scoreText);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.m_scoreText = scoreText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F4C RID: 139084 RVA: 0x00B901B4 File Offset: 0x00B8E3B4
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	[Preserve]
	public static int get_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, unchartedScoreRewardListItemUIController.m_luaExportHelper.m_rewardGroupTransform);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F4D RID: 139085 RVA: 0x00B9020C File Offset: 0x00B8E40C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardGroupTransform(IntPtr l)
	{
		int result;
		try
		{
			UnchartedScoreRewardListItemUIController unchartedScoreRewardListItemUIController = (UnchartedScoreRewardListItemUIController)LuaObject.checkSelf(l);
			Transform rewardGroupTransform;
			LuaObject.checkType<Transform>(l, 2, out rewardGroupTransform);
			unchartedScoreRewardListItemUIController.m_luaExportHelper.m_rewardGroupTransform = rewardGroupTransform;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x06021F4E RID: 139086 RVA: 0x00B90268 File Offset: 0x00B8E468
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.UnchartedScoreRewardListItemUIController");
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.SetUnchartedScoreRewardGroupInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.SetGot);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cacheF);
		string name = "m_uiStateController";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.get_m_uiStateController);
		}
		LuaCSFunction get = Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache10;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.set_m_uiStateController);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache11, true);
		string name2 = "m_nameText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.get_m_nameText);
		}
		LuaCSFunction get2 = Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache12;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.set_m_nameText);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache13, true);
		string name3 = "m_scoreNameText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.get_m_scoreNameText);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache14;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.set_m_scoreNameText);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache15, true);
		string name4 = "m_scoreText";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.get_m_scoreText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache16;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.set_m_scoreText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache17, true);
		string name5 = "m_rewardGroupTransform";
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.get_m_rewardGroupTransform);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.set_m_rewardGroupTransform);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_UnchartedScoreRewardListItemUIController.<>f__mg$cache19, true);
		LuaObject.createTypeMetatable(l, null, typeof(UnchartedScoreRewardListItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04017D84 RID: 97668
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04017D85 RID: 97669
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04017D86 RID: 97670
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04017D87 RID: 97671
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04017D88 RID: 97672
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04017D89 RID: 97673
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04017D8A RID: 97674
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04017D8B RID: 97675
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04017D8C RID: 97676
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04017D8D RID: 97677
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04017D8E RID: 97678
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04017D8F RID: 97679
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04017D90 RID: 97680
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04017D91 RID: 97681
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04017D92 RID: 97682
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04017D93 RID: 97683
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04017D94 RID: 97684
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04017D95 RID: 97685
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04017D96 RID: 97686
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04017D97 RID: 97687
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04017D98 RID: 97688
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04017D99 RID: 97689
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04017D9A RID: 97690
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04017D9B RID: 97691
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04017D9C RID: 97692
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04017D9D RID: 97693
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;
}
