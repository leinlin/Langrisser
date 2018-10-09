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

// Token: 0x0200150F RID: 5391
[Preserve]
public class Lua_BlackJack_ProjectL_UI_MissionItemUIController : LuaObject
{
	// Token: 0x0601FF0F RID: 130831 RVA: 0x00A8F204 File Offset: 0x00A8D404
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int InitMissionItem(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			bool isMissionFinished;
			LuaObject.checkType(l, 3, out isMissionFinished);
			bool isMissionCompleted;
			LuaObject.checkType(l, 4, out isMissionCompleted);
			missionItemUIController.InitMissionItem(mission, isMissionFinished, isMissionCompleted);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF10 RID: 130832 RVA: 0x00A8F278 File Offset: 0x00A8D478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF11 RID: 130833 RVA: 0x00A8F2CC File Offset: 0x00A8D4CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int SetMissionInfo(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.SetMissionInfo();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF12 RID: 130834 RVA: 0x00A8F320 File Offset: 0x00A8D520
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.OnGetButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF13 RID: 130835 RVA: 0x00A8F374 File Offset: 0x00A8D574
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int OnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.OnGotoButtonClick();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF14 RID: 130836 RVA: 0x00A8F3C8 File Offset: 0x00A8D5C8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Initlize(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			string ctrlName;
			LuaObject.checkType(l, 2, out ctrlName);
			bool bindNow;
			LuaObject.checkType(l, 3, out bindNow);
			missionItemUIController.m_luaExportHelper.__callBase_Initlize(ctrlName, bindNow);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF15 RID: 130837 RVA: 0x00A8F434 File Offset: 0x00A8D634
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFields(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.__callBase_BindFields();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF16 RID: 130838 RVA: 0x00A8F488 File Offset: 0x00A8D688
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnBindFiledsCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.__callBase_OnBindFiledsCompleted();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF17 RID: 130839 RVA: 0x00A8F4DC File Offset: 0x00A8D6DC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_BindFieldImpl(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
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
			UnityEngine.Object o = missionItemUIController.m_luaExportHelper.__callBase_BindFieldImpl(fieldType, path, initState, fieldName, ctrlName, optional);
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

	// Token: 0x0601FF18 RID: 130840 RVA: 0x00A8F584 File Offset: 0x00A8D784
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_Clear(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			missionItemUIController.m_luaExportHelper.__callBase_Clear();
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF19 RID: 130841 RVA: 0x00A8F5D8 File Offset: 0x00A8D7D8
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_OnButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Button button;
			LuaObject.checkType<Button>(l, 2, out button);
			string fieldName;
			LuaObject.checkType(l, 3, out fieldName);
			missionItemUIController.m_luaExportHelper.__callBase_OnButtonClick(button, fieldName);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF1A RID: 130842 RVA: 0x00A8F644 File Offset: 0x00A8D844
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
				MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase> action;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
				missionItemUIController.m_luaExportHelper.__callBase_SetButtonClickListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase>)))
			{
				MissionItemUIController missionItemUIController2 = (MissionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase> action2;
				LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action2);
				missionItemUIController2.m_luaExportHelper.__callBase_SetButtonClickListener(fieldName, action2);
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

	// Token: 0x0601FF1B RID: 130843 RVA: 0x00A8F754 File Offset: 0x00A8D954
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonDoubleClickListener(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionItemUIController.m_luaExportHelper.__callBase_SetButtonDoubleClickListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF1C RID: 130844 RVA: 0x00A8F7C0 File Offset: 0x00A8D9C0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressStartListener(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressStartListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF1D RID: 130845 RVA: 0x00A8F82C File Offset: 0x00A8DA2C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressingListener(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressingListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF1E RID: 130846 RVA: 0x00A8F898 File Offset: 0x00A8DA98
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_SetButtonLongPressEndListener(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			string fieldName;
			LuaObject.checkType(l, 2, out fieldName);
			Action<UIControllerBase> action;
			LuaObject.checkDelegate<Action<UIControllerBase>>(l, 3, out action);
			missionItemUIController.m_luaExportHelper.__callBase_SetButtonLongPressEndListener(fieldName, action);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF1F RID: 130847 RVA: 0x00A8F904 File Offset: 0x00A8DB04
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
				MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
				string[] fieldNames;
				LuaObject.checkArray<string>(l, 2, out fieldNames);
				Action<UIControllerBase, bool> action;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action);
				missionItemUIController.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldNames, action);
				LuaObject.pushValue(l, true);
				result = 1;
			}
			else if (LuaObject.matchType(l, total, 2, typeof(string), typeof(Action<UIControllerBase, bool>)))
			{
				MissionItemUIController missionItemUIController2 = (MissionItemUIController)LuaObject.checkSelf(l);
				string fieldName;
				LuaObject.checkType(l, 2, out fieldName);
				Action<UIControllerBase, bool> action2;
				LuaObject.checkDelegate<Action<UIControllerBase, bool>>(l, 3, out action2);
				missionItemUIController2.m_luaExportHelper.__callBase_SetToggleValueChangedListener(fieldName, action2);
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

	// Token: 0x0601FF20 RID: 130848 RVA: 0x00A8FA14 File Offset: 0x00A8DC14
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callBase_ToString(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			string s = missionItemUIController.m_luaExportHelper.__callBase_ToString();
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

	// Token: 0x0601FF21 RID: 130849 RVA: 0x00A8FA70 File Offset: 0x00A8DC70
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			missionItemUIController.m_luaExportHelper.__callDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF22 RID: 130850 RVA: 0x00A8FACC File Offset: 0x00A8DCCC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			GetPathData obj;
			LuaObject.checkType<GetPathData>(l, 2, out obj);
			missionItemUIController.m_luaExportHelper.__clearDele_EventOnGotoButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF23 RID: 130851 RVA: 0x00A8FB28 File Offset: 0x00A8DD28
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __callDele_EventOnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			missionItemUIController.m_luaExportHelper.__callDele_EventOnGetButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF24 RID: 130852 RVA: 0x00A8FB84 File Offset: 0x00A8DD84
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int __clearDele_EventOnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			int obj;
			LuaObject.checkType(l, 2, out obj);
			missionItemUIController.m_luaExportHelper.__clearDele_EventOnGetButtonClick(obj);
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF25 RID: 130853 RVA: 0x00A8FBE0 File Offset: 0x00A8DDE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGotoButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Action<GetPathData> value;
			int num = LuaObject.checkDelegate<Action<GetPathData>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					missionItemUIController.EventOnGotoButtonClick += value;
				}
				else if (num == 2)
				{
					missionItemUIController.EventOnGotoButtonClick -= value;
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

	// Token: 0x0601FF26 RID: 130854 RVA: 0x00A8FC60 File Offset: 0x00A8DE60
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_EventOnGetButtonClick(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Action<int> value;
			int num = LuaObject.checkDelegate<Action<int>>(l, 2, out value);
			if (num != 0)
			{
				if (num == 1)
				{
					missionItemUIController.EventOnGetButtonClick += value;
				}
				else if (num == 2)
				{
					missionItemUIController.EventOnGetButtonClick -= value;
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

	// Token: 0x0601FF27 RID: 130855 RVA: 0x00A8FCE0 File Offset: 0x00A8DEE0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_achievementIconGo(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_achievementIconGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF28 RID: 130856 RVA: 0x00A8FD38 File Offset: 0x00A8DF38
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_achievementIconGo(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			GameObject achievementIconGo;
			LuaObject.checkType<GameObject>(l, 2, out achievementIconGo);
			missionItemUIController.m_luaExportHelper.m_achievementIconGo = achievementIconGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF29 RID: 130857 RVA: 0x00A8FD94 File Offset: 0x00A8DF94
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_titleText(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_titleText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF2A RID: 130858 RVA: 0x00A8FDEC File Offset: 0x00A8DFEC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_titleText(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Text titleText;
			LuaObject.checkType<Text>(l, 2, out titleText);
			missionItemUIController.m_luaExportHelper.m_titleText = titleText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF2B RID: 130859 RVA: 0x00A8FE48 File Offset: 0x00A8E048
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_descText(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_descText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF2C RID: 130860 RVA: 0x00A8FEA0 File Offset: 0x00A8E0A0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_descText(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Text descText;
			LuaObject.checkType<Text>(l, 2, out descText);
			missionItemUIController.m_luaExportHelper.m_descText = descText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF2D RID: 130861 RVA: 0x00A8FEFC File Offset: 0x00A8E0FC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_countText(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_countText);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF2E RID: 130862 RVA: 0x00A8FF54 File Offset: 0x00A8E154
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_countText(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Text countText;
			LuaObject.checkType<Text>(l, 2, out countText);
			missionItemUIController.m_luaExportHelper.m_countText = countText;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF2F RID: 130863 RVA: 0x00A8FFB0 File Offset: 0x00A8E1B0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_getButton);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF30 RID: 130864 RVA: 0x00A90008 File Offset: 0x00A8E208
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_getButton(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Button getButton;
			LuaObject.checkType<Button>(l, 2, out getButton);
			missionItemUIController.m_luaExportHelper.m_getButton = getButton;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF31 RID: 130865 RVA: 0x00A90064 File Offset: 0x00A8E264
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_progressImg(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_progressImg);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF32 RID: 130866 RVA: 0x00A900BC File Offset: 0x00A8E2BC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_progressImg(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Image progressImg;
			LuaObject.checkType<Image>(l, 2, out progressImg);
			missionItemUIController.m_luaExportHelper.m_progressImg = progressImg;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF33 RID: 130867 RVA: 0x00A90118 File Offset: 0x00A8E318
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_rewardListGo(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_rewardListGo);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF34 RID: 130868 RVA: 0x00A90170 File Offset: 0x00A8E370
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_rewardListGo(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			GameObject rewardListGo;
			LuaObject.checkType<GameObject>(l, 2, out rewardListGo);
			missionItemUIController.m_luaExportHelper.m_rewardListGo = rewardListGo;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF35 RID: 130869 RVA: 0x00A901CC File Offset: 0x00A8E3CC
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_mission(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_mission);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF36 RID: 130870 RVA: 0x00A90220 File Offset: 0x00A8E420
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_mission(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			Mission mission;
			LuaObject.checkType<Mission>(l, 2, out mission);
			missionItemUIController.m_mission = mission;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF37 RID: 130871 RVA: 0x00A90278 File Offset: 0x00A8E478
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMissionFinished(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_isMissionFinished);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF38 RID: 130872 RVA: 0x00A902D0 File Offset: 0x00A8E4D0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMissionFinished(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			bool isMissionFinished;
			LuaObject.checkType(l, 2, out isMissionFinished);
			missionItemUIController.m_luaExportHelper.m_isMissionFinished = isMissionFinished;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF39 RID: 130873 RVA: 0x00A9032C File Offset: 0x00A8E52C
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_m_isMissionCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.m_isMissionCompleted);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF3A RID: 130874 RVA: 0x00A90384 File Offset: 0x00A8E584
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_m_isMissionCompleted(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			bool isMissionCompleted;
			LuaObject.checkType(l, 2, out isMissionCompleted);
			missionItemUIController.m_luaExportHelper.m_isMissionCompleted = isMissionCompleted;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF3B RID: 130875 RVA: 0x00A903E0 File Offset: 0x00A8E5E0
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int get_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			LuaObject.pushValue(l, true);
			LuaObject.pushValue(l, missionItemUIController.m_luaExportHelper.playerCtx);
			result = 2;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF3C RID: 130876 RVA: 0x00A90438 File Offset: 0x00A8E638
	[Preserve]
	[MonoPInvokeCallback(typeof(LuaCSFunction))]
	public static int set_playerCtx(IntPtr l)
	{
		int result;
		try
		{
			MissionItemUIController missionItemUIController = (MissionItemUIController)LuaObject.checkSelf(l);
			ProjectLPlayerContext playerCtx;
			LuaObject.checkType<ProjectLPlayerContext>(l, 2, out playerCtx);
			missionItemUIController.m_luaExportHelper.playerCtx = playerCtx;
			LuaObject.pushValue(l, true);
			result = 1;
		}
		catch (Exception e)
		{
			result = LuaObject.error(l, e);
		}
		return result;
	}

	// Token: 0x0601FF3D RID: 130877 RVA: 0x00A90494 File Offset: 0x00A8E694
	[Preserve]
	public static void reg(IntPtr l)
	{
		LuaObject.getTypeTable(l, "BlackJack.ProjectL.UI.MissionItemUIController");
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache0 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache0 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.InitMissionItem);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache0);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.SetMissionInfo);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache3 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache3 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.OnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache3);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache4 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache4 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.OnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache4);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache5 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache5 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_Initlize);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache5);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache6 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache6 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_BindFields);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache6);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache7 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache7 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_OnBindFiledsCompleted);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache7);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache8 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache8 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_BindFieldImpl);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache8);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache9 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache9 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_Clear);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache9);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheA == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheA = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_OnButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheA);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheB == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheB = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_SetButtonClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheB);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheC == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheC = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_SetButtonDoubleClickListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheC);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheD == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheD = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_SetButtonLongPressStartListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheD);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheE == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheE = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_SetButtonLongPressingListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheE);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheF == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheF = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_SetButtonLongPressEndListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cacheF);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache10 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache10 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_SetToggleValueChangedListener);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache10);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache11 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache11 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callBase_ToString);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache11);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache12 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache12 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache12);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache13 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache13 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__clearDele_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache13);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache14 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache14 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__callDele_EventOnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache14);
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache15 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache15 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.__clearDele_EventOnGetButtonClick);
		}
		LuaObject.addMember(l, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache15);
		string name = "EventOnGotoButtonClick";
		LuaCSFunction get = null;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache16 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache16 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_EventOnGotoButtonClick);
		}
		LuaObject.addMember(l, name, get, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache16, true);
		string name2 = "EventOnGetButtonClick";
		LuaCSFunction get2 = null;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache17 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache17 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_EventOnGetButtonClick);
		}
		LuaObject.addMember(l, name2, get2, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache17, true);
		string name3 = "m_achievementIconGo";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache18 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache18 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_achievementIconGo);
		}
		LuaCSFunction get3 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache18;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache19 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache19 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_achievementIconGo);
		}
		LuaObject.addMember(l, name3, get3, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache19, true);
		string name4 = "m_titleText";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_titleText);
		}
		LuaCSFunction get4 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1A;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_titleText);
		}
		LuaObject.addMember(l, name4, get4, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1B, true);
		string name5 = "m_descText";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_descText);
		}
		LuaCSFunction get5 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1C;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_descText);
		}
		LuaObject.addMember(l, name5, get5, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1D, true);
		string name6 = "m_countText";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1E == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1E = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_countText);
		}
		LuaCSFunction get6 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1E;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1F == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1F = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_countText);
		}
		LuaObject.addMember(l, name6, get6, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache1F, true);
		string name7 = "m_getButton";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache20 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache20 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_getButton);
		}
		LuaCSFunction get7 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache20;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache21 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache21 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_getButton);
		}
		LuaObject.addMember(l, name7, get7, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache21, true);
		string name8 = "m_progressImg";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache22 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache22 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_progressImg);
		}
		LuaCSFunction get8 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache22;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache23 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache23 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_progressImg);
		}
		LuaObject.addMember(l, name8, get8, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache23, true);
		string name9 = "m_rewardListGo";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache24 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache24 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_rewardListGo);
		}
		LuaCSFunction get9 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache24;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache25 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache25 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_rewardListGo);
		}
		LuaObject.addMember(l, name9, get9, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache25, true);
		string name10 = "m_mission";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache26 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache26 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_mission);
		}
		LuaCSFunction get10 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache26;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache27 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache27 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_mission);
		}
		LuaObject.addMember(l, name10, get10, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache27, true);
		string name11 = "m_isMissionFinished";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache28 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache28 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_isMissionFinished);
		}
		LuaCSFunction get11 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache28;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache29 == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache29 = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_isMissionFinished);
		}
		LuaObject.addMember(l, name11, get11, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache29, true);
		string name12 = "m_isMissionCompleted";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2A == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2A = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_m_isMissionCompleted);
		}
		LuaCSFunction get12 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2A;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2B == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2B = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_m_isMissionCompleted);
		}
		LuaObject.addMember(l, name12, get12, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2B, true);
		string name13 = "playerCtx";
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2C == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2C = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.get_playerCtx);
		}
		LuaCSFunction get13 = Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2C;
		if (Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2D == null)
		{
			Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2D = new LuaCSFunction(Lua_BlackJack_ProjectL_UI_MissionItemUIController.set_playerCtx);
		}
		LuaObject.addMember(l, name13, get13, Lua_BlackJack_ProjectL_UI_MissionItemUIController.<>f__mg$cache2D, true);
		LuaObject.createTypeMetatable(l, null, typeof(MissionItemUIController), typeof(UIControllerBase));
	}

	// Token: 0x04015ED3 RID: 89811
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache0;

	// Token: 0x04015ED4 RID: 89812
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1;

	// Token: 0x04015ED5 RID: 89813
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2;

	// Token: 0x04015ED6 RID: 89814
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache3;

	// Token: 0x04015ED7 RID: 89815
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache4;

	// Token: 0x04015ED8 RID: 89816
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache5;

	// Token: 0x04015ED9 RID: 89817
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache6;

	// Token: 0x04015EDA RID: 89818
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache7;

	// Token: 0x04015EDB RID: 89819
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache8;

	// Token: 0x04015EDC RID: 89820
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache9;

	// Token: 0x04015EDD RID: 89821
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheA;

	// Token: 0x04015EDE RID: 89822
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheB;

	// Token: 0x04015EDF RID: 89823
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheC;

	// Token: 0x04015EE0 RID: 89824
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheD;

	// Token: 0x04015EE1 RID: 89825
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheE;

	// Token: 0x04015EE2 RID: 89826
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cacheF;

	// Token: 0x04015EE3 RID: 89827
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache10;

	// Token: 0x04015EE4 RID: 89828
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache11;

	// Token: 0x04015EE5 RID: 89829
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache12;

	// Token: 0x04015EE6 RID: 89830
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache13;

	// Token: 0x04015EE7 RID: 89831
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache14;

	// Token: 0x04015EE8 RID: 89832
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache15;

	// Token: 0x04015EE9 RID: 89833
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache16;

	// Token: 0x04015EEA RID: 89834
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache17;

	// Token: 0x04015EEB RID: 89835
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache18;

	// Token: 0x04015EEC RID: 89836
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache19;

	// Token: 0x04015EED RID: 89837
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1A;

	// Token: 0x04015EEE RID: 89838
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1B;

	// Token: 0x04015EEF RID: 89839
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1C;

	// Token: 0x04015EF0 RID: 89840
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1D;

	// Token: 0x04015EF1 RID: 89841
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1E;

	// Token: 0x04015EF2 RID: 89842
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache1F;

	// Token: 0x04015EF3 RID: 89843
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache20;

	// Token: 0x04015EF4 RID: 89844
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache21;

	// Token: 0x04015EF5 RID: 89845
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache22;

	// Token: 0x04015EF6 RID: 89846
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache23;

	// Token: 0x04015EF7 RID: 89847
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache24;

	// Token: 0x04015EF8 RID: 89848
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache25;

	// Token: 0x04015EF9 RID: 89849
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache26;

	// Token: 0x04015EFA RID: 89850
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache27;

	// Token: 0x04015EFB RID: 89851
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache28;

	// Token: 0x04015EFC RID: 89852
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache29;

	// Token: 0x04015EFD RID: 89853
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2A;

	// Token: 0x04015EFE RID: 89854
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2B;

	// Token: 0x04015EFF RID: 89855
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2C;

	// Token: 0x04015F00 RID: 89856
	[CompilerGenerated]
	private static LuaCSFunction <>f__mg$cache2D;
}
